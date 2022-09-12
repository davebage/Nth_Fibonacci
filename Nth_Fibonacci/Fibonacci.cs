namespace Nth_Fibonacci
{
    public class Fibonacci
    {
        public int NthFibonacci(int fibonacciPosition)
        {
            // Fibonacci returns the sum of the previous 2 values
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            if (fibonacciPosition < 0) throw new IndexOutOfRangeException();

            int[] fibonacciArray = new int[2] { 0, 1 } ;

            for(var positionCounter = 1; positionCounter < fibonacciPosition; positionCounter++)
            {
                int nextValue = fibonacciArray[0] + fibonacciArray[1];
                fibonacciArray[0] = fibonacciArray[1];
                fibonacciArray[1] = nextValue;
            }

            return fibonacciArray[0];
        }

    }
}