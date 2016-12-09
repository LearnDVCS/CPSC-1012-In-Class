using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStar
{
    // An interface defines the method/property signatures for some data type that implements
    // the interface. It effectively describes how something can be used (i.e., what method
    // calls or property get/set can be used) on some object.
    // Interfaces as a data type describe a "contract" specifying what methods/properties will
    // be available.
    // HOW those methods/properties are implemented isn't important to the interface - the job
    // of implementing them is one by the concrete class/object.
    public interface Loader<TObject>
    {
        List<TObject> LoadData(); // Notice how this method matches the signature in CSVFileIO.
    }

    class Program
    {
        static void Main(string[] args)
        {
            var reader = new MarathonRunnerFileIO(); // use the default file path inside
            Display<MarathonRunner>(reader);

            Console.WriteLine("\nPress [Enter] to load phone data...");
            Console.ReadLine(); // tossing the input....
            var phoneReader = new PhoneBookFileIO(@"Data\PhoneList_777475.txt");
            //Display(phoneReader); // notice that I didn't need to specify the <T>...
            List<PhoneNumberEntry> allNumbers = phoneReader.LoadData();

            allNumbers.Sort((x, y) => 
            {
                return x.LastName.CompareTo(y.FirstName);
            });
            for (int index = 1; index < 20; index++)
                Console.WriteLine(allNumbers[index]);
        }

        // Here's a generic method that expects an object that supports an interface
        static void Display<T>(Loader<T> reader)
        {
            foreach (T item in reader.LoadData())
                Console.WriteLine(item);
        }
    }
}
