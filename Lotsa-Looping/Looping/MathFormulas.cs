using System;

namespace Looping
{
    public class MathFormulas
    {
        /// <summary>
        /// Calculates the number at a certain position in the
        /// Fibonacci Sequence.
        /// </summary>
        /// <param name="i">
        /// The position in the sequence (Must be greater than zero)
        /// </param>
        /// <returns>A value in the  Fibonacci Sequence</returns>
        public static int FibonacciNumber(int i)
        {
            int current = 1, previous = 1, beforePrevious = 0;
            if (i >= 1)
            {
                for (int counter = 3; counter <= i; counter++)
                {
                    beforePrevious = previous;
                    previous = current;
                    current = beforePrevious + previous;
                }
            }
            else
                throw new Exception("Can only create a fibonacci  number based on a positive non-zero position");
            return current;
        }
    }
}
