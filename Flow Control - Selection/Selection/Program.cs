using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use a menu for which demo to show
            Console.WriteLine("Select a demo from the following:");
            Console.WriteLine("A)\tBase 10 to Base 16");
            Console.WriteLine("B)\tMemory Address Demo");
            Console.WriteLine("C)\tColor Demo");

            string userOption;
            Console.Write("Enter your selection: ");
            userOption = Console.ReadLine().ToUpper();

            if (userOption == "A")
                DemoBaseConversion();
            if (userOption == "B")
                DemoMemoryAddress();
            if (userOption == "C")
                DemoColor();
        }

        private static void DemoColor()
        {
            throw new NotImplementedException();
        }

        private static void DemoMemoryAddress()
        {
            Console.WriteLine("\nMemory Address Demo\n");
            Console.Write("Enter a number less than 65535: ");
            ushort address = ushort.Parse(Console.ReadLine());
            MemoryAddress demo = new MemoryAddress(address);
            Console.WriteLine($"The hex value is {demo.HexValue}");
        }

        private static void DemoBaseConversion()
        {
            Console.WriteLine("\nBase Conversion Demo\n");
            Console.WriteLine("Enter a number less than 4096: ");
            int baseTenNumber = int.Parse(Console.ReadLine());

            // Do Calculations
            int wholePortion, remainder;
            string baseSixteenNumber;
            wholePortion = baseTenNumber / 256; // 16^2

            baseSixteenNumber = GetHexadecimalDigit(wholePortion);
            remainder = baseTenNumber % 256; // 16^2
            // get the next value for the 16^1 position
            wholePortion = remainder / 16; // 16^1
            baseSixteenNumber += GetHexadecimalDigit(wholePortion);
            // get the last value of the conversion
            remainder = remainder % 16;
            baseSixteenNumber += GetHexadecimalDigit(remainder);

            Console.WriteLine("The base 16 value is " + baseSixteenNumber);
        }

        private static string GetHexadecimalDigit(int wholePortion)
        {
            string hex;
            if (wholePortion <= 9)
                hex = wholePortion.ToString();
            else if (wholePortion == 10)
                hex = "A";
            else if (wholePortion == 11)
                hex = "B";
            else if (wholePortion == 12)
                hex = "C";
            else if (wholePortion == 13)
                hex = "D";
            else if (wholePortion == 14)
                hex = "E";
            else if (wholePortion == 15)
                hex = "F";
            else // default value
                hex = ""; // Later, we will learn how to report an error.

            return hex;
        }
    }
}
