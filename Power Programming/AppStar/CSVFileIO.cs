﻿using System.Collections.Generic;
using System.IO;
using System; // for the Console class

namespace AppStar
{
    /// <summary>
    /// The CSVFileStorage class provides simple reading of all the lines of text of a CSV(Comma-Separated-Values) file.
    /// </summary>
    /// <remarks>
    /// An abstract class can NOT be instantiated. Only sub-classes can be instantiated.
    /// </remarks>
    public abstract class CSVFileIO<T>
    {
        #region Properties and Constructors
        public string FilePath { get; private set; }

        /// <summary>
        /// Initializes a new instance of the CSVFileStorage class.
        /// </summary>
        public CSVFileIO(string filePath)
        {
            FilePath = filePath;
            // Info about where I am
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"--Inside CSVFileIO(string) constructor--FilePath={FilePath}");
            Console.ResetColor();
        }
        #endregion

        #region Public Methods
        public List<T> LoadData()
        {
            return ReadAllLines();
        }

        public bool SaveData(List<T> data, bool append = false)
        {
            bool success;
            try
            {
                WriteAllLines(data, append);
                success = true;
            }
            catch(System.ArgumentException)
            {
                success = false; // TODO: Should find a better way to report a write error
            }
            return success;
        }
        #endregion

        #region Abstract, Protected, and Private methods
        // Here is an abstract, protected method. It only defines the signature.
        protected abstract T ParseLine(string line);

        private List<T> ReadAllLines()
        {
            List<T> data = new List<T>();

            // Read the text file, one line at a time
            using (TextReader reader = new StreamReader(FilePath))
            {
                string aSingleLine = reader.ReadLine(); // a priming read
                while (aSingleLine != null)
                {
                    T item = ParseLine(aSingleLine);
                    data.Add(item);
                    aSingleLine = reader.ReadLine(); // get the next
                }
            }
            return data;
        }

        protected abstract string ToCsvString(T item);

        private void WriteAllLines(List<T> data, bool append)
        {
            using (TextWriter writer = new StreamWriter(FilePath, append))
            {
                foreach (T item in data)
                {
                    string line = ToCsvString(item);
                    writer.WriteLine(line);
                }
            }
        }
        #endregion
    }
}
