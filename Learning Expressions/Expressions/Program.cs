using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // DemoCalculator();
            DemoSquare();
        }

        private static void DemoSquare()
        {
            double length;
            Console.Write("Enter a real number: ");
            length = double.Parse(Console.ReadLine());
            // Create a square object
            Square box = new Square(length);

            string result;
            // We are going to use "string interpolation" to build our message
            // Remember the $ when using string interpolation
            result = $"Side = {box.Side}, Area = {box.Area}, Outside Perimeter = {box.Perimeter}";
            Console.WriteLine(result);
        }

        private static void DemoCalculator()
        {
            int firstNumber, secondNumber;
            Console.Write("Enter a number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(); // blank line
            int result;
            result = Calculator.Add(firstNumber, secondNumber);
            Console.WriteLine("The sum is " + result);
            result = Calculator.Multiply(firstNumber, secondNumber);
            Console.WriteLine("The product is " + result);
        }
    }
}
