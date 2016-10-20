﻿using System;

namespace Looping
{
    public class MathFormulas
    {
        /// <summary>
        /// Calculates the number at a certain position in the Fibonacci Sequence.
        /// </summary>
        /// <param name="i">
        /// The position in the sequence (must be greater than zero)
        /// </param>
        /// <returns>
        /// A value in the Fibonacci Sequence
        /// </returns>
        public static int FibonacciNumber(int i)
        {
            int current = 1, previous = 1, beforePrevious = 0;
            if (i >= 1)
            {
                // Do the calculation
                for (int counter = 3; counter <= i; counter++)
                {
                    beforePrevious = previous;
                    previous = current;
                    // Quick check to see if we go over the max value
                    if (beforePrevious > int.MaxValue - previous)
                        throw new Exception("The number is too big to calculate the Fibonacci");
                    current = beforePrevious + previous;
                }
            }
            else
                throw new Exception("Can only create a Fibonacci number based on a positive non-zero position");

            return current;
        }

        public static bool IsPerfect(int number)
        {
            bool perfect = true;
            if (number <= 1)
                perfect = false;
            else
            {
                // The following logic attempts to prove it is imperfect
                int halfWay = number / 2;
                int total = 0;
                int count = 1;
                while (total != number && total <= halfWay && total < number)
                {
                    if (number % count == 0) // Then count is a factor of number
                        total += count;
                    count++;
                }
                if (total != number)
                    perfect = false;
            }
            return perfect;
        }
    }
}
