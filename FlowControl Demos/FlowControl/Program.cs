using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption;

            // Show a menu for which demo to run
            Console.WriteLine("Select a demo from the following:");
            Console.WriteLine("A)  Base 10 to Base 16");
            Console.WriteLine("B)  Memory Address Demo");
            Console.WriteLine("C)  Color Demo");

            // Get user's choice
            userOption = Console.ReadLine().ToUpper();
            //           \      string    /

            // Show the appropriate demo
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
            Console.WriteLine("Enter a number less than 4096");
            int baseTenNumber = int.Parse(Console.ReadLine());

            // Do Calculations
            int wholePortion, remainder;
            string baseSixteenNumber;

            wholePortion = baseTenNumber / 256; // 16^2
            baseSixteenNumber = GetHexDigit(wholePortion);

            remainder = baseTenNumber % 256;
            // get the next digit
            wholePortion = remainder / 16; // 16^1
            baseSixteenNumber += GetHexDigit(wholePortion);
            // get the last value
            remainder = remainder % 16;
            baseSixteenNumber += GetHexDigit(remainder);

            Console.WriteLine("The base 16 value is " + baseSixteenNumber);
        }

        private static string GetHexDigit(int wholePortion)
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
            else
                hex = ""; // TODO: look for better way to handle invalid digit

            return hex;
        }
    }
}
