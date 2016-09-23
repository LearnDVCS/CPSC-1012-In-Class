using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // PartACylinder();
            // PartACone();

            PartB();
        }

        private static void PartB()
        {
            // Part B - Using Objects
            // 1) Get user input
            double r = Prompt("Enter a radius: ");
            double h = Prompt("Enter a height: ");
            // 2) Create a Cylinder object
            Cylinder tube = new Cylinder(r, h);// Pass in values to the c'tor
            // 3) Output the Cylinder volume and surface area
            Console.WriteLine($"The volume is {tube.Volume} and the surface area is {tube.SurfaceArea}");

            // 4) Get user input
            // 5) Create a Cone object
            // 6) Output the Cone volume and surface area
        }

        private static double Prompt(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        private static void PartACone()
        {
            // 1) Get user input data
            Console.WriteLine("Cone Calculations (in centimeters)");
            double radius = Prompt("Enter a radius: ");
            double height = Prompt("Enter a height: ");
            // 2) Calculate values
            double volume = 1.0 / 3.0 * Math.PI * radius * radius * height;
            double surfaceArea = (Math.PI * radius * radius)
                               + (Math.PI * radius *
                                  Math.Sqrt(radius * radius + height * height));
            // 3) Display the results to the user
            Console.WriteLine();
            string output = $"The volume is {volume} cubic cm and the surface area is {surfaceArea} square cm.";
            Console.WriteLine(output);
        }

        private static void PartACylinder()
        {
            // Calculate volume and surface area for the Cylinder
            /* Test Data: Cylinder
             * Radius | Height | Volume | Surface Area
             * =======|========|========|=============
             *    1   |    1   | 3.1419 | 12.56636
             *    1   |    2   | 6.28318| 18.84954
            */
            // 1) Declare variables I will need for input data
            double radius, height;
            string userInput;

            // 2) Prompt the user for Radius and Height
            Console.WriteLine("Cylinder Calculations (in centimeters)"); // "title"
            //Console.Write("Enter a radius: "); // Prompt message
            //userInput = Console.ReadLine(); // Get text input
            //radius = double.Parse(userInput); // convert string to double
            radius = Prompt("Enter a radius: ");
            //Console.Write("Enter a height: ");
            //userInput = Console.ReadLine();
            //height = double.Parse(userInput);
            height = Prompt("Enter a height: ");

            // 3) Declare variable for the calculations
            double volume, surfaceArea;

            // 4) Calculate the value from the input
            volume = Math.PI * radius * radius * height;
            surfaceArea = (2 * Math.PI * radius * radius)
                        + (2 * Math.PI * radius * height);

            // 5) Display the results to the user
            Console.WriteLine(); // blank line
            string output = $"The volume is {volume} cubic cm and the surface area is {surfaceArea} square cm.";
            Console.WriteLine(output);
        }
    }
}
