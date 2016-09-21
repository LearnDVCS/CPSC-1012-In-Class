using System; // for the Console and Math classes

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartACylinder();
            PartACone();
            //PartB();
        }

        private static void PartB()
        {
            throw new NotImplementedException();
        }

        private static void PartACone()
        {
            // Part A - No Objects
            /* Test Data: Cone
             * Radius | Height | Volume | Surface Area
             * =======|========|========|=============
             *    1   |    3   | 3.1419 | 13.07616987...
             *    1   |    30  | 31.419 | 97.441635297...
            */
            // 1) Declare variable I will need for input data
            double radius, height;
            string userInput;

            // 2) Prompt the user for Radius and Height
            Console.WriteLine("Cone Calculations (in centimeters)"); // "title" message
            Console.Write("Enter a radius: "); // Prompt message
            userInput = Console.ReadLine(); // Get text input
            radius = double.Parse(userInput); // convert string to double
            Console.Write("Enter a height: ");
            userInput = Console.ReadLine();
            height = double.Parse(userInput);

            // 3) Declare variables for the calculations
            double volume, surfaceArea;

            // 4) Calculate the values from the input
            volume = (1.0 / 3.0) * 3.14159 * radius * radius * height;

            surfaceArea = (3.14159 * radius * radius)
                        + (3.14159 * radius * Math.Sqrt(radius * radius + height * height));

            // 5) Display the results to the user
            Console.WriteLine();
            string output = $"The volume is {volume} cubic cm and the surface area is {surfaceArea} square cm";
            Console.WriteLine(output);
        }

        private static void PartACylinder()
        {
            // Part A - No Objects
            /* Test Data: Cylinder
             * Radius | Height | Volume | Surface Area
             * =======|========|========|=============
             *    1   |    1   | 3.1419 | 12.56636
             *    1   |    2   | 6.28318| 18.84954
            */
            // 1) Declare variable I will need for input data
            double radius, height;
            string userInput;

            // 2) Prompt the user for Radius and Height
            Console.WriteLine("Cylinder Calculations (in centimeters)"); // "title" message
            Console.Write("Enter a radius: "); // Prompt message
            userInput = Console.ReadLine(); // Get text input
            radius = double.Parse(userInput); // convert string to double
            Console.Write("Enter a height: ");
            userInput = Console.ReadLine();
            height = double.Parse(userInput);

            // 3) Declare variables for the calculations
            double volume, surfaceArea;

            // 4) Calculate the values from the input
            volume = 3.14159 * radius * radius * height;
            surfaceArea = (2 * 3.14159 * radius * radius)
                        + (2 * 3.14159 * radius * height);

            // 5) Display the results to the user
            Console.WriteLine();
            string output = $"The volume is {volume} cubic cm and the surface area is {surfaceArea} square cm";
            Console.WriteLine(output);
        }
    }
}
