using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public enum Gender { Unknown = -4, M = 44, F = 32 }
    class Program
    {
        static void Main(string[] args)
        {
            Gender forUser;
            if (TryParseText(Console.ReadLine(), out forUser))
                Console.WriteLine(forUser);
            else
                Console.WriteLine("What's that willis?");
        }
        public static bool TryParseText(string text, out Gender convertedResult)
        {
            try
            { 
                // hehe
                double temp;
                if (double.TryParse(text, out temp))
                    throw new Exception("I don't like numbers as enums....");
                convertedResult = (Gender)Enum.Parse(typeof(Gender), text, true);
                return true;
            }
            catch
            {
                convertedResult = Gender.Unknown;
                return false;
            }
        }
    }
}
