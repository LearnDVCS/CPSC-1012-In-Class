using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCs.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable will give me a "place" to hold information
            int myAge = 32; // Variable Initialization statement
            int averageClassAge; // Variable Declaration statement

            // Assignment statement
            averageClassAge = 23;

            // Output what the maximum integer value is that I can store in
            // an int variable
            Console.WriteLine("Max int value is: " + int.MaxValue);
            Console.WriteLine("Min int value is: " + int.MinValue);

            long totalDistinctValues = (long) int.MaxValue - int.MinValue;
            Console.WriteLine("There are " + totalDistinctValues + " total distinct values that an integer can hold.");


            // Create two objects based on the Greeter data type (class)
            // Declaring a variable to hold a Greeter object
            Greeter walmartGreeter;
            // Create the Greeter object and assign it to the variable
            walmartGreeter = new Greeter("Welcome to Walmart!", "Thank you for shopping at Walmart! Come again!!");
            Console.WriteLine(walmartGreeter.SayHello());
            Console.WriteLine(walmartGreeter.SayGoodbye());

            Greeter klingonCommander;
            klingonCommander = new Greeter("nuqneH!", "Qapla'!");
            Console.WriteLine(klingonCommander.SayHello());
            Console.WriteLine(klingonCommander.SayGoodbye());

        }
    }
}
