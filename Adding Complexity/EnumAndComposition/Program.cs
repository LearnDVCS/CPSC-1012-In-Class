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
            Coin gameCoin = new Coin();
            Console.WriteLine("Heads I win, Tails you lose:");
            gameCoin.Toss();
            Console.WriteLine(gameCoin);

            Console.WriteLine("Let's try again... Enter HEADS or TAILS:");
            string userInput = Console.ReadLine().ToUpper();

            // Parse the text into a CoinFace data type.
            Coin.CoinFace userChoice; // Declare a variable
            userChoice = (Coin.CoinFace) // Casting
                         Enum.Parse(typeof (Coin.CoinFace), userInput);
            // Parsing              \   DataType         /  \ string/

            gameCoin.Toss();
            if (gameCoin.FaceShowing == userChoice)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("I Win!!!!!!!!! HA!!");
        }
    }
}
