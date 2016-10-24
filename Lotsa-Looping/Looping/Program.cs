using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lotsa-Looping Demos");
            Console.WriteLine("===================");

            string userOption;
            do
            {
                DisplayMenu();
                userOption = Console.ReadLine().ToUpper();
                RunDemo(userOption);
            } while (userOption != "X");
        }

        private static void RunDemo(string option)
        {
            switch(option)
            {
                case "A":
                    int position;
                    Console.Write("Enter a position in the sequence: ");
                    position = int.Parse(Console.ReadLine());
                    int fib = MathFormulas.FibonacciNumber(position);
                    Console.WriteLine($"The fibonacci number at {position} is {fib}.");
                    break;
                case "B":
                    // Demo IsPerfect by finding the first 5 perfect numbers.
                    int perfectCount = 0;
                    int numberToCheck = 1;
                    while (perfectCount < 5)
                    {
                        if(MathFormulas.IsPerfect(numberToCheck))
                        {
                            Console.WriteLine($"{numberToCheck} is perfect.");
                            perfectCount++;
                        }
                        numberToCheck++; // move on to the next number.
                        // TODO: Remove this later...
                        Console.WriteLine($"\tChecking {numberToCheck}");
                    }
                    break;
            }
        }


        private static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("A) MathFormulas.Fibonnacci");
            Console.WriteLine("B) MathFormulas.IsPerfect");
            // Others....
            Console.WriteLine("X) Exit");
            Console.WriteLine("\tSelect an item from the menu: ");
        }
    }
}
