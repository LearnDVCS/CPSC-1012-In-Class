using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myApp = new Program(); // Creating an instance of your application
            myApp.Run();
        }

        private List<MultipleChoiceQuestion> Questions { get; set; }

        public Program()
        {
            Questions = new List<MultipleChoiceQuestion>(); // empty list
        }

        private void Run()
        {
            // To have a loop that keeps the program alive until the user quits
            string userInput;
            do
            {
                DisplayMenu();
                Console.Write("Select an item from the menu");
                userInput = Console.ReadLine().ToUpper();
                ProcessUserInput(userInput);
            } while (userInput != "Q");
        }

        private void ProcessUserInput(string userInput)
        {
            switch(userInput)
            {
                case "2":
                    Forms.DisplayForm form2 = new Forms.DisplayForm();
                    form2.ShowForm(Questions);
                    break;
                case "Q":
                    Console.WriteLine("Thanks for marking my application!");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.WriteLine("\nPress [Enter] to continue...");
            Console.ReadLine(); // tossing the user input
        }

        private void DisplayMenu()
        {
            // TODO: Finish this....
            Console.Clear(); // clear the screen
            Console.WriteLine("TBA");
        }
    }
}
