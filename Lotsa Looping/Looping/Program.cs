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
            Console.WriteLine("C) MathFormulas.Factorial");
            Console.WriteLine("D) MathFormulas.FibonacciSequence");
            Console.WriteLine("E) Brand new deck of cards");
            Console.WriteLine("F) Shuffle a deck of cards");
            // Others...
            Console.WriteLine("X) Exit");
            Console.Write("\tSelect an item from the menu: ");
        }

        private static void RunDemo(string option)
        {
            switch(option)
            {
                case "A":
                    DemoFibonacci();
                    break;
                case "B":
                    DemoIsPerfect();
                    break;
                case "C":
                    DemoFactorial();
                    break;
                case "D":
                    // Your homework;
                    break;
                case "E":
                    DeckOfCards myDeck = new DeckOfCards();
                    ShowDeck(myDeck);
                    break;
                case "F":
                    myDeck = new DeckOfCards();
                    myDeck.Shuffle();
                    ShowDeck(myDeck);
                    break;
                case "G":
                    break;
            }
        }

        private static void ShowDeck(DeckOfCards deck)
        {
            while(!deck.IsEmpty)
            {
                PlayingCard aCard = deck.DrawCard();
                Console.WriteLine(aCard);
            }
        }

        private static void DemoFactorial()
        {
            // Ask for a number
            Console.Write("Enter a number: ");
            // Get the number
            int number = int.Parse(Console.ReadLine()); // convert text to int
            // Calculate Factorial
            //   - factorial = number
            int factorial = number;
            //   - number = number - 1
            number--;
            //   - As long as number is > 1...
            while (number > 1)
            {
                //      - factorial = factorial * number
                factorial *= number;
                //      - number = number - 1
                number--;
            }

            // Display my result
            Console.WriteLine($"The factorial is {factorial}");
        }

        private static void DemoIsPerfect()
        {
            // Show the first five perfect numbers :)
            Console.WriteLine("Here are the first 5 perfect numbers:");
            int perfectCount = 1;
            int numberToCheck = 1;
            while(perfectCount <= 5)
            {
                if (MathFormulas.IsPerfect(numberToCheck))
                {
                    Console.WriteLine($"{numberToCheck} is perfect.");
                    perfectCount++;
                }

                numberToCheck++; // move on to the next number
                // TODO: Remove the next line later....
                Console.WriteLine($"\t... currently checking {numberToCheck}");
            }
        }

        private static void DemoFibonacci()
        {
            int position;
            Console.Write("Enter a position in the sequence: ");
            position = int.Parse(Console.ReadLine());
            int fib = MathFormulas.FibonacciNumber(position);
            Console.WriteLine($"The fibonacci number at {position} is {fib}.");
        }
    }
}
