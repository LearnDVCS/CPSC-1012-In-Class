using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            int boxSize = GetLength("Enter the size of the box: ");
            Console.Write("Enter the fill character: ");
            char fill = Console.ReadLine()[0];
            DisplayBox(boxSize);
            DisplayBox(boxSize, fill);
        }

        private static void DisplayBox(int length, char fillChar)
        {
            for(int row = 1; row <= length; row++)
            {
                for(int col = 1; col <= length; col++)
                {
                    if (row == 1 || row == length)
                        Console.Write('-');
                    else if (col == 1 || col == length)
                        Console.Write('|');
                    else
                        Console.Write(fillChar);
                }
            }
        }

        private static void DisplayBox(int length)
        {
            DisplayBox(length, ' ');
        }

        private static int GetLength(string prompt)
        {
            Console.Write(prompt);
            int size = int.Parse(Console.ReadLine());
            return size;
        }
    }
}
