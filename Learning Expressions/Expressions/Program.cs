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
            //DemoCalculator();
            //DemoSquare();

            // Demo Circle
            double diameter;
            Console.WriteLine("Enter a diameter for a circle: ");
            diameter = double.Parse(Console.ReadLine());

            Circle ball = new Circle(diameter);

            double circumference = Circle.PI * ball.Diameter;

            Console.WriteLine($"The circumference is {circumference}");

            // 1) Add properties called Radius, Circumference and Area
            //    that calculate their values based on the circle's diameter
            // 2) Refactor the Main method to demo the Circle's new
            //    properties, and put all that demo code in a new static
            //    method inside of the Program class.
        }

        private static void DemoSquare()
        {
            double length;
            Console.Write("Enter a real number: ");
            length = double.Parse(Console.ReadLine());
            // Create a square object
            Square box = new Square(length);

            Console.WriteLine("The square has a side of " + box.Side + " and an area of " + box.Area);
            Console.WriteLine();

            string result;
            // We are goind to use "string interpolation" to build our message
            // Remember the $ when using string interpolation
            result = $"Side = {box.Side}, Area = {box.Area}, Outside Perimeter = {box.Perimeter}";
            Console.WriteLine(result);
        }

        private static void DemoCalculator()
        {
            int first, second;
            Console.Write("Enter a number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine(); // blank line
            int result;
            result = Calculator.Add(first, second);
            Console.WriteLine("The sum is " + result);
            result = Calculator.Multiply(first, second);
            Console.WriteLine("The product is " + result);
        }
    }
}
