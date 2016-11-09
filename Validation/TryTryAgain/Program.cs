using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTryAgain
{
    class Program
    {
        public enum MonthName { Invalid, Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }

        private static bool TryParse(string text, out MonthName convertedValue)
        {
            // Because the parameter "convertedValue" is declared as an "out"
            // variable, my method MUST assign a value to that variable.
            bool isValid;
            // An example of exception handling
            try
            {
                // Now, let me attempt parsing my text as an enum
                convertedValue = (MonthName)Enum.Parse(typeof(MonthName), text);
                // The above line might "blow up"
                isValid = true;
            }
            catch // The catch block "handles" the exception
            {
                convertedValue = MonthName.Invalid;
                isValid = false;
            }
            return isValid;
        }


        static void Main(string[] args)
        {
            // Testing strings to see if they can be converted to numbers
            // can be done with the .TryParse() method on the numeric types.
            int number;
            bool isValidInput;
            do
            {
                Console.Write("Enter a whole number: ");
                isValidInput = int.TryParse(Console.ReadLine(), out number);
                if (!isValidInput)
                    Console.Write("\tInvalid Input. Try again.");
            } while (!isValidInput);

            Console.WriteLine($"The value I have is {number}");

            double amount;
            Console.Write("Enter a real number: ");
            while(! double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("\tThat's not a real number. Try again.");
            }
            Console.WriteLine($"The real number is {amount}");


            // Give our custom tryparse method a shot
            MonthName endOfTerm;
            Console.Write("Enter the month of the end of the term (3 char abbrev.");
            // out is a keyword that modifies how a parameter operates.
            // (note - put on a test sometime...)
            if (Program.TryParse(Console.ReadLine(), out endOfTerm))
                Console.WriteLine($"You said this term ends in {endOfTerm}");
            else
                Console.WriteLine("I don't know what you mean....");
        }
    }
}
