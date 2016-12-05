using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoFileInput();
            //DemoStringSplitMethod();
            //DemoStringJoinMethod();
            //DemoFileOutput();
            DemoReadAlbums();
        }

        private static void DemoReadAlbums()
        {
            // Whenever reading a CSV file, you need to be mindful of the
            // file structure. In these album text files, the first line
            // contains the album title and the artist.
            // In all subsequent lines, the structure is:
            // SongTitle, Composer, RunningTime (minutes:seconds)
            CSVFileIO reader = new CSVFileIO(@"Data\Album_1.txt");
            List<string> contents = reader.ReadAllLines();
            string[] parts = contents[0].Split(','); // Split the first line
            // The first line has two parts: album title,artist
            Console.WriteLine($"The album '{parts[0]}' by {parts[1]}");

            foreach(string line in contents.Skip(1)) // skip the first line
            {
                parts = line.Split(',');
                string message = $"\t{parts[0]} by {parts[1]} ({parts[2]})";
                //                     song         composer     time
                Console.WriteLine(message);
            }
        }

        private static void DemoFileOutput()
        {
            string filePath = "Tweets.txt";
            List<string> tweets = new List<string>();
            string input;
            do
            {
                Console.Write("Tweet (x to exit): ");
                input = Console.ReadLine();
                if (input.ToUpper() != "X")
                    tweets.Add(DateTime.Now.ToString() + "," + input);
            } while (input.ToUpper() != "X");
            CSVFileIO writer = new CSVFileIO(filePath);
            writer.WriteAllLines(tweets, false); // write to the file
        }

        private static void DemoStringJoinMethod()
        {
            // Declare an array, prepopulated with values
            string[] fibSequence = { "1", "1", "2", "3", "5", "8", "13", "21", "34", "55" };
            // Transform the array into a single string
            string fibExample = string.Join(",", fibSequence);
            Console.WriteLine(fibExample);
            // You can do this with an array of any data type, such as int
            int[] grades = { 80, 75, 42, 54, 67, 91 };
            string gradesText = string.Join(",", grades);
            Console.WriteLine(gradesText);
        }

        private static void DemoStringSplitMethod()
        {
            string text = "Gilleland,Dan,34,15:45"; // CSV line of text
            // Create an array from a CSV line of text
            string[] parts = text.Split(','); // Split the line by the comma
            Console.WriteLine($"{parts[1]} {parts[0]} is in parking spot {parts[2]} and has {parts[3]} minutes left on the meter");
        }

        private static void DemoFileInput()
        {
            // Display the contents of Program.cs
            string path = @"..\..\Program.cs";

            CSVFileIO reader = new CSVFileIO(path);
            List<string> linesOfCode = reader.ReadAllLines();

            foreach (string line in linesOfCode)
                Console.WriteLine(line);
        }
    }
}
