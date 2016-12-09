using System;
using System.Collections.Generic;

namespace AppStar
{
    public class MarathonRunnerFileIO
        : CSVFileIO<MarathonRunner>  // Inherits from CSVFileIO<T> base class
    {
        #region Constructors
        public MarathonRunnerFileIO(string filePath)
            : base(filePath) // Call the CSVFileIO<T> constructor 
                             //   before running this constructor's body
        {
            // Info about where I am
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--Inside MarathonRunnerFileIO(string) constructor--");
            Console.ResetColor();
        }

        // Here's another constructor - parameterless - that "chains" to the constructor above
        public MarathonRunnerFileIO() : this(@"Data\MarathonRunners.txt")
        {
            // Info about where I am
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--Inside MarathonRunnerFileIO() constructor--");
            Console.ResetColor();
        }
        #endregion

        #region Implementations of the base class abstract methods
        protected override string ToCsvString(MarathonRunner item)
        {
            return $"{item.LastName},{item.FirstName},{item.RunnerNumber},{item.MinutesToComplete}";
        }

        protected override MarathonRunner ParseLine(string line)
        {
            string[] parts = line.Split(','); // break the line into "fields"
            MarathonRunner result = new MarathonRunner()
            {
                FirstName = parts[1],
                LastName = parts[0],
                RunnerNumber = int.Parse(parts[2]),
                MinutesToComplete = double.Parse(parts[3])
            };
            return result;
        }
        #endregion
    }
}
