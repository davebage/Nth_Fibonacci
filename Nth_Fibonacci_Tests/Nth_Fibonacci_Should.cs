using System;
using Nth_Fibonacci;
using NUnit.Framework;

namespace Nth_Fibonacci_Tests
{
    public class Nth_Fibonacci_Should
    {
        private Fibonacci _fibonacci;

        [SetUp]
        public void Setup()
        {
            _fibonacci = new Fibonacci();
        }

        [Test]
        public void throw_exception_for_negative_position()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _fibonacci.NthFibonacci(-1));
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(1, 3)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(5, 6)]
        [TestCase(8, 7)]
        [TestCase(13, 8)]
        [TestCase(21, 9)]
        [TestCase(34, 10)]
        public void return_fibonacci_result_for_submitted_position(int expectedResult, int position)
        {

            int result = _fibonacci.NthFibonacci(position);

            Assert.That(result, Is.EqualTo(expectedResult));

        }
    }
}