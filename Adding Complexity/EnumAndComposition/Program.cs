using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoStudentComposition();
        }

        private static void DemoStudentComposition()
        {
            // Addresses courtesy of http://www.fakeaddressgenerator.com/
            Address myAddress = new Address(null,
                                            "4964 Roger Street",
                                            "Duncan",
                                            "British Columbia",
                                            "V9L 1E5");
            Student me, roomate;
            me = new Student(123456789,
                             "Dan (the man) Gilleland",
                             Gender.Male,
                             myAddress,
                             "DMIT",
                             9.0,
                             false);

            roomate = new Student(987654321,
                                  "Phil Errup",
                                  Gender.Male,
                                  myAddress,
                                  "DMIT",
                                  7.8);

            // Display the information about a student
            Console.WriteLine(me.ToString());
            Console.WriteLine(roomate.ToString());
        }
    }
}
