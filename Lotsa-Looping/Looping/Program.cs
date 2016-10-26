using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lotsa-Looping Demos");
            Console.WriteLine("===================");

            string userOption;
            do
            {
                DisplayMenu();
                userOption = Console.ReadLine().ToUpper();
                RunDemo(userOption);
            } while (userOption != "X");
        }

        private static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("A) MathFormulas.Fibonacci");
            Console.WriteLine("B) MathFormulas.IsPerfect");
            Console.WriteLine("C) MathFormulas.FibonacciSequence");
            Console.WriteLine("D) MathFormulas.Factorial");
            Console.WriteLine("E) Show a Deck of Cards");
            Console.WriteLine("F) Shuffle a Deck of Cards");
            Console.WriteLine("G) Play the game \"War\" with cards");
            // Others....
            Console.WriteLine("X) Exit");
            Console.WriteLine("\tSelect an item from the menu: ");
        }

        private static void RunDemo(string option)
        {
            switch(option)
            {
                case "A":
                    DemoFibonacciNumber();
                    break;
                case "B":
                    DemoIsPerfect();
                    break;
                case "C":
                    DemoFibonacciSequence();
                    break;
                case "D":
                    // TODO: Factorial Demo

                    /* <-- start of multi-line comment
                    // First way - all inside one spot
                    //string userInput;
                    // Ask the user for a number
                    //   - Display a message
                    Console.Write("Enter a number: ");
                    //   - Get the text
                    string userInput = Console.ReadLine();
                    //   - Convert the text to a number
                    int number = int.Parse(userInput);
                    // Calculate the factorial
                    //   - create a variable & give it the value 1 to start
                    int fact = 1;
                    //   - have loop that repeats as long as the number > 1
                    while (number > 1)
                    {
                        //      -> fact = fact * number
                        fact *= number;
                        //      -> number = number - 1
                        number--; // Decrement operator
                    }
                    // Display the factorial value
                    Console.WriteLine("The factorial is " + fact);
                    end my multline comment -> */

                    // Second way - putting the calculation logic inside of the MathFormula class
                    // Interact with user
                    Console.Write("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());
                    // Use my MathFormula class to do the calculations
                    int result = MathFormulas.Factorial(num);
                    Console.WriteLine("The factorial of {0} is {1}",
                                      num,
                                      result);
                    break;
                case "E":
                {
                    DeckOfCards deck = new DeckOfCards();
                    ShowCards(deck);
                    break;
                }
                case "F":
                {
                    DeckOfCards deck = new DeckOfCards();
                    deck.Shuffle();
                    ShowCards(deck);
                    break;
                }
            }
        }

        private static void ShowCards(DeckOfCards theDeck)
        {
            while(!theDeck.IsEmpty)
            {
                PlayingCard card = theDeck.DrawCard();
                Console.WriteLine(card);
            }
        }

        private static void DemoFibonacciSequence()
        {
            // display the first 10 numbers in the fibonacci sequence
            List<int> sequence = MathFormulas.FibonacciSequence(10);
            // Now, we are going to loop through all the items in the list
            foreach (int number in sequence)
                Console.Write($"{number}, ");
        }

        private static void DemoIsPerfect()
        {
            // Demo IsPerfect by finding the first 5 perfect numbers.
            int perfectCount = 0;
            int numberToCheck = 1;
            while (perfectCount < 5)
            {
                if (MathFormulas.IsPerfect(numberToCheck))
                {
                    Console.WriteLine($"{numberToCheck} is perfect.");
                    perfectCount++;
                }
                numberToCheck++; // move on to the next number.
                                 // TODO: Remove this later...
                Console.WriteLine($"\tChecking {numberToCheck}");
            }
        }

        private static void DemoFibonacciNumber()
        {
            int position;
            Console.Write("Enter a position in the sequence: ");
            position = int.Parse(Console.ReadLine());
            int fib = MathFormulas.FibonacciNumber(position);
            Console.WriteLine($"The fibonacci number at {position} is {fib}.");
        }
    }
}
