using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formatting of currency example
            double tuition = 1940.00;
            Console.WriteLine($"DMIT Tuition: {tuition:C}");
            // Formatting of decimal precision
            Console.WriteLine($"PI with precision: {Math.PI}");
            Console.WriteLine($"PI to 4 decimals:  {Math.PI:##.0000}");
        }
    }
}
