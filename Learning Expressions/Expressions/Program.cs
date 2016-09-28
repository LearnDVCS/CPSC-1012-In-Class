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
            // DemoCircle();
            // DemoDie();
            //DemoFraction();
            //DemoAngle();
            DemoBetterFraction();
        }

        private static void DemoBetterFraction()
        {
            Fraction first = new Fraction(1, 2);
            Fraction second = new Fraction(3, 4);
            first.MultiplyBy(second);
            Console.WriteLine("The answer is: " + first);
        }

        private static void DemoAngle()
        {
            Angle right = new Angle(90);
            Console.WriteLine($"An angle of {right} is the same as {right.Raidans} radians.");
        }

        private static void DemoFraction()
        {
            Fraction data = new Fraction(4,15);
            // If I place an object in my string interpolation,
            // then the .ToString() method will be called on that object.
            Console.WriteLine($"We are {data} of the way through this course");

            Fraction mark = new Fraction(4, 5);
            Console.WriteLine($"I got {mark} which is {mark.ToPercent()}%");
        }

        private static void DemoDie()
        {
            Die first, second, third, fourth, fifth;
            first = new Die();
            second = new Die();
            third = new Die();
            fourth = new Die();
            fifth = new Die();

            Console.WriteLine("The die values are:");
            string message = $"\t{first.FaceValue}\t{second.FaceValue}\t{third.FaceValue}\t{fourth.FaceValue}\t{fifth.FaceValue}";
            Console.WriteLine(message);

            // Reroll the first and second die.
            first.Roll();
            second.Roll();
            Console.WriteLine("\nAfter re-rolling the first two die:");
            message = $"\t{first.FaceValue}\t{second.FaceValue}\t{third.FaceValue}\t{fourth.FaceValue}\t{fifth.FaceValue}";
            Console.WriteLine(message);
        }

        private static void DemoCircle()
        {
            double diameter;
            Console.WriteLine("Enter a diameter for a circle: ");
            diameter = double.Parse(Console.ReadLine());

            Circle ball = new Circle(diameter);

            //double circumference = Circle.PI * ball.Diameter;

            Console.WriteLine($"The circumference is {ball.Circumference}");
            Console.WriteLine($"The radius is {ball.Radius}");
            Console.WriteLine($"The area is {ball.Area}");

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
