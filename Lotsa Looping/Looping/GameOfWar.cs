using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    public class GameOfWar
    {
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public bool GameFinished { get; private set; }

        public void PlayGame(string playerOneName, string playerTwoName)
        {
            Setup(playerOneName, playerTwoName);

            GameFinished = false;

            while(!GameFinished)
            {
                // do a turn
                Battle();
            }
        }

        private void Battle()
        {
            PlayingCard firstCard, secondCard;
            firstCard = FirstPlayer.Draw();
            secondCard = SecondPlayer.Draw();
            if(firstCard.Value > secondCard.Value)
            {
                // first player gets the cards
                FirstPlayer.AddToStack(firstCard, secondCard);
            }
            else if(secondCard.Value > firstCard.Value)
            {
                // second player gets the cards
                SecondPlayer.AddToStack(firstCard, secondCard);
            }
            else
            {
                // It's War!!!
            }
        }

        private void Setup(string first, string second)
        {
            // Get a deck of cards, and deal them out to the two players
            // Here's an example of creating a new object and setting the public
            // property values using an "Initializer List"
            FirstPlayer = new Player()
            {
                Name = first
            };

            // The older way of remembering to set a property after creating
            SecondPlayer = new Player();
            SecondPlayer.Name = second;

            DeckOfCards freshDeck = new DeckOfCards();
            while(!freshDeck.IsEmpty)
            {
                FirstPlayer.AddToStack(freshDeck.DrawCard());
                SecondPlayer.AddToStack(freshDeck.DrawCard());
            }
        }
    }
}
