using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStar
{
    // An interface defines the method/property signatures for some data type that implements the interface.
    // It effectively describes how something can be used (i.e., what method calls or property get/set can be used) on some object
    // Interfaces as a data type describe a contract specifying what methods/properties will be available.
    // HOW those methods/properties are implemented isn't important to the interface - the job
    // of implementing them is done by the concrete class/object.
    public interface Loader<TObject>
    {
        List<TObject> LoadData();
    }

    class Program : Loader<string> // I promise to implement the Loader<string> method in this class
    {
        static void Main(string[] args)
        {
            Loader<MarathonRunner> reader = new MarathonRunnerFileIO();
            Display<MarathonRunner>(reader);
            //var data = reader.LoadData();
            //foreach (var item in data)
            //    Console.WriteLine(item);
            Display<string>(new Program());
        }

        static void Display<T>(Loader<T> reader)
        {
            foreach (T item in reader.LoadData())
                Console.WriteLine(item);
        }

        public List<string> LoadData()
        {
            string[] data = { "Fred", "Barney", "Wilma", "Betty", "Pebbles", "BamBam" };
            return new List<string>(data);
        }
    }
}
