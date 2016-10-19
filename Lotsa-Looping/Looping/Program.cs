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
