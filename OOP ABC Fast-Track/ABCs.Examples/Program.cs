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
            DemoDriver1();
        } // end of Main() method

        /// <summary>
        /// Quick 'n Dirty demo of variables, objects and User Input/Output
        /// </summary>
        private static void DemoDriver1()
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

            long totalDistinctValues = (long)int.MaxValue - int.MinValue;
            Console.WriteLine("There are " + totalDistinctValues + " total distinct values that an integer can hold.");


            // Create two objects based on the Greeter data type (class)
            // Declaring a variable to hold a Greeter object
            Greeter walmartGreeter;
            // Create the Greeter object and assign it to the variable
            walmartGreeter = new Greeter("Welcome to Walmart!", "Thank you for shopping at Walmart! Come again!!");
            UseGreeter(walmartGreeter);

            Greeter klingonCommander;
            klingonCommander = new Greeter("nuqneH!", "Qapla'!");
            UseGreeter(klingonCommander);


            // Get some user input for creating our next Greeter object
            Console.WriteLine(); // put in a blank line on the screen
            string helloMsg, goodbyeMsg;
            // Prompt for and get user input
            Console.Write("Enter a hello message: ");
            helloMsg = Console.ReadLine(); // User must press [Enter] to submit
            Console.Write("Enter a goodbye message: ");
            goodbyeMsg = Console.ReadLine(); // ALL user input is text in the console

            // Make my Greeter object
            Greeter myGreeter = new Greeter(helloMsg, goodbyeMsg);
            UseGreeter(myGreeter);

            // Get a number from the user
            Console.WriteLine("\n\n\n"); // notice the escape characters
            Console.Write("\tEnter a mark between 0 and 100 that you want to get for this course: ");
            int preferredMark;
            preferredMark = int.Parse(Console.ReadLine());
            Console.WriteLine("Great choice! Go for it!!");

        }


        // This is private because I don't want it called from outside my
        // Program class (which is acting as a "driver" for my program).
        // The void return type means that this method will NOT return
        // any information.
        private static void UseGreeter(Greeter someone)
        {
            Console.WriteLine(someone.SayHello());
            Console.WriteLine(someone.SayGoodbye());
            return;
        }
    }
}
