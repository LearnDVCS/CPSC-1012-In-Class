using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTryAgain
{
    class Program
    {
        public enum DayOfWeek { Invalid, Sun, Mon, Tue, Wed, Thu, Fri, Sat }

        private static bool TryParse(string text, out DayOfWeek value)
        {
            // Because the parameter "value" is declared as a "out" variable,
            // my method MUST assign a value to that variable.
            bool isValid;
            // An example of exception handling
            try
            {
                // Now, let me attempt parsing my text as an enum
                value = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), text); // Might "blow up"
                isValid = true;
            }
            catch // The catch block "handles" the exception
            {
                value = DayOfWeek.Invalid;
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
                    Console.WriteLine("\tInvalid input. Try again.");
            }
            while (! isValidInput);

            Console.WriteLine($"The value I have is {number}");

            DayOfWeek today;
            Console.Write("Enter the day of the week (3 char abbrev.): ");
            if (Program.TryParse(Console.ReadLine(), out today))
                Console.WriteLine($"You said today is {today}");
            else
                Console.WriteLine("I don't know what you mean....");
        }
    }
}
