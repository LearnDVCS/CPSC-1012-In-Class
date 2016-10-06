using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption;

            do
            {
                DisplayMenu();

                // Get user's choice
                userOption = Console.ReadLine().ToUpper();
                //           \      string    /

                ShowDemo(userOption);
            } while (userOption != "X");
        }

        private static void ShowDemo(string userOption)
        {
            // Show the appropriate demo
            switch (userOption)
            {
                case "A":
                    DemoBaseConversion();
                    break;
                case "B":
                    DemoMemoryAddress();
                    break;
                case "C":
                    DemoColor();
                    break;
                case "X":
                    Console.WriteLine("Thanks for trying the demos.");
                    break;
                default:
                    Console.WriteLine("Invalid menu item");
                    break;
            }
        }

        private static void DisplayMenu()
        {
            // Show a menu for which demo to run
            Console.WriteLine("Select a demo from the following:");
            Console.WriteLine("A)  Base 10 to Base 16");
            Console.WriteLine("B)  Memory Address Demo");
            Console.WriteLine("C)  Color Demo");
            Console.WriteLine("X)  Exit");
        }

        private static void DemoColor()
        {
            Console.WriteLine("\nColor Demo\n");
            Color white = new Color(255, 255, 255);
            Console.WriteLine($"White is {white.Hex} where Red = {white.Red}, Blue = {white.Blue} and Green = {white.Green}");
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
