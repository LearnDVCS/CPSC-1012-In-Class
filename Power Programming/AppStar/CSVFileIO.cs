using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStar
{
    // An abstract class can NOT be instantiated. Only sub-classes can be instantiated.
    public abstract class CSVFileIO<T>
    {
        #region Properties and Constructors
        public string FilePath { get; private set; }

        public CSVFileIO(string filePath)
        {
            FilePath = filePath;
        }
        #endregion

        #region Public Methods
        public List<T> LoadData()
        {
            throw new NotImplementedException();
        }

        public bool SaveData(List<T> data, bool append = false)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Abstract, Protected, and Private Methods
        // Here is an abstract, protected method
        protected abstract T ParseLine(string line);

        private List<T> ReadAllLines()
        {
            List<T> data = new List<T>();

            // Read the text file, one line at a time
            using (TextReader reader = new StreamReader(FilePath))
            {
                string aSingleLine = reader.ReadLine(); // Priming read
                while(aSingleLine != null)
                {
                    T item = ParseLine(aSingleLine);
                    data.Add(item);
                    aSingleLine = reader.ReadLine(); // get the next line of text
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
