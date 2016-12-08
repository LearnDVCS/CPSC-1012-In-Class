using System.Collections.Generic;
using System.IO;

namespace SimpleFileIO
{
    /// <summary>
    /// The CSVFileStorage class provides simple reading of all the lines of text of a CSV(Comma-Separated-Values) file.
    /// </summary>
    public class CSVFileIO
    {
        public string FilePath { get; private set; }

        /// <summary>
        /// Initializes a new instance of the CSVFileStorage class.
        /// </summary>
        public CSVFileIO(string filePath)
        {
            FilePath = filePath;
        }

        public List<string> ReadAllLines()
        {
            List<string> lines = new List<string>();
            // The using keyword ensures that the reader is properly closed when we are done,
            // whether or not an exception has been thrown.
            // The object (ie, our reader) must implement the IDisposable interface
            using (TextReader reader = new StreamReader(FilePath))
            {
                string aSingleLine = reader.ReadLine(); // a priming read
                while (aSingleLine != null)
                {
                    lines.Add(aSingleLine);
                    aSingleLine = reader.ReadLine(); // get the next
                }
            }
            return lines;
        }

        public void WriteAllLines(List<string> lines, bool append)
        {
            using (TextWriter writer = new StreamWriter(FilePath, append))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
