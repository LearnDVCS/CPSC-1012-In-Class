using System;
using System.Collections.Generic; // for the List<T> class

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

        public static List<int> FibonacciSequence(int length)
        {
            List<int> fib = new List<int>(); // create an empty list
            if(length >= 1)
            {
                for(int index = 0; index < length; index++)
                {
                    int fibNumber = FibonacciNumber(index + 1);
                    fib.Add(fibNumber);
                }
            }
            return fib;
        }

        public static int[] FibonacciArraySequence(int length)
        {
            int[] fib = new int[0]; // an "empty" array
            if(length >= 1)
            {
                fib = new int[length]; // size of array = length
                for (int index = 0; index < fib.Length; index++)
                    fib[index] = FibonacciNumber(index + 1);
            }
            return fib;
        }

        public static bool IsPerfect(int number)
        {
            // Let's start out optomistically.
            bool perfect = true;

            // Perfect numbers are always greater than 1
            if (number <= 1)
                perfect = false;
            else
            {
                // The following logic attempt to prove it is imperfect
                int halfway = number / 2;
                int total = 0;
                int count = 1;

                while(count <= halfway)
                {
                    if (number % count == 0) // then count is a factor of number
                        total += count;
                    count++; // increase count by 1
                }
                // The number is not perfect if its factors don't total the number
                if (total != number)
                    perfect = false;
            }
            return perfect;
        }

        public static int Factorial(int number)
        {
            // TODO: Use a loop to calculate and return the factorial
            //       of the number that is passed in to this method.
            //   - create a variable & give it the value 1 to start
            int fact = 1;
            //   - have loop that repeats as long as the number > 1
            while (number > 1)
            {
                //      -> fact = fact * number
                fact *= number;
                //      -> number = number - 1
                number--; // Decrement operator
            }
            return fact;
        }
    } // end of class
}
