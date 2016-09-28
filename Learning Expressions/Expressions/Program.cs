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
            // DemoSquare();
            // DemoStaticVsNonStatic();
            // DemoCircle();
            // DemoDie();
            // DemoAngle();
            DemoFraction();
        }

        private static void DemoFraction()
        {
            Fraction data = new Fraction(4, 15);
            // If I place an object in my string interpolation,
            // then the .ToString() method will be called on that object.
            Console.WriteLine($"We are {data} of the way through this course.");

            Fraction mark = new Fraction(4, 5);
            Console.WriteLine($"My mark was {mark} which is {mark.ToPercent()} %.");

            data = new Fraction(4, 6);
            Console.WriteLine($"The reciprocal of {data} is {data.Reciprocal}");
        }

        private static void DemoAngle()
        {
            Console.WriteLine(5 + 1);
            Console.WriteLine(5.ToString() + 1.ToString());
            Angle right = new Angle(90);
            //Console.WriteLine(right.ToString());
            Console.WriteLine($"A {right} angle is {right.Radians} Radians and {right.Grads} Grads");
            Console.Write("I just ");
            Console.Write("LOVE"); // TODO: 
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.Write("♥"); // [Alt] + [num-3]
            Console.WriteLine(" Programming");
        }

        private static void DemoDie()
        {
            Die first, second, third, fourth, fifth;
            first = new Die();
            second = new Die();
            third = new Die();
            fourth = new Die();
            fifth = new Die();

            Console.WriteLine("The initial die values are:");
            string message = $"\t{first.FaceValue}\t{second.FaceValue}\t{third.FaceValue}\t{fourth.FaceValue}\t{fifth.FaceValue}";

            Console.WriteLine(message);

            // Reroll the first and second die
            first.Roll();
            second.Roll();
            Console.WriteLine("\nAfter re-rolling the first two die:");
            message = $"\t{first.FaceValue}\t{second.FaceValue}\t{third.FaceValue}\t{fourth.FaceValue}\t{fifth.FaceValue}";

            Console.WriteLine(message);
        }

        private static void DemoCircle()
        {
            /* Test Data
             * Diameter | Area  | Radius | Circumference
             * =========|=======|========|==============
             *     2    |3.14159|    1   | 6.28318
             */
            double diameter;
            Console.Write("Enter a diameter for a circle: ");
            diameter = double.Parse(Console.ReadLine());

            Circle ball = new Circle(diameter);

            Console.WriteLine($"The circumference is {ball.Circumference}");
            Console.WriteLine($"The radius is {ball.Radius}");
            Console.WriteLine($"The area is {ball.Area}");
        }

        private static void DemoStaticVsNonStatic()
        {
            Circle smallBall = new Circle();
            smallBall.Diameter = 1;

            double circumference = Circle.PI * smallBall.Diameter;
            string message;
            message = $"A ball of diameter {smallBall.Diameter} has a circumference of {circumference}";
            Console.WriteLine(message);

            Circle bigBall = new Circle();
            bigBall.Diameter = 100;

            circumference = Circle.PI * bigBall.Diameter;
            message = $"A ball of diameter {bigBall.Diameter} has a circumference of {circumference}";
            Console.WriteLine(message);

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
