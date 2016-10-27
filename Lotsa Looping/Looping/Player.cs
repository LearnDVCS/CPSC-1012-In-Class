using System;
using System.Collections.Generic; // for the List<T>

namespace Looping
{
    public class Player
    {
        public string Name { get; set; }
        private DeckOfCards MyStack { get; set; }

        public PlayingCard Draw()
        {
            return MyStack.DrawCard();
        }

        public void AddToStack(params PlayingCard[] cards) // TODO: Google params
        {
            foreach (PlayingCard item in cards)
                MyStack.AddCard(item);
        }
    }
}
