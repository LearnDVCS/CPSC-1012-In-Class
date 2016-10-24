using System;
using System.Collections.Generic;

namespace Looping
{
    public class DeckOfCards
    {
        private List<PlayingCard> Cards { get; set; }

        public int Count
        { get { return Cards.Count; } }

        public bool IsEmpty
        { get { return Count == 0; } }

        public DeckOfCards()
        {
            // Set up a standard deck of 52 cards
            Cards = new List<PlayingCard>();
            // Loop through each suit, and each card value for each suit
            foreach(PlayingCard.CardSuit suit in
                    Enum.GetValues(typeof(PlayingCard.CardSuit)))
            {
                foreach(PlayingCard.CardValue value in
                        Enum.GetValues(typeof(PlayingCard.CardValue)))
                {
                    PlayingCard aCard = new PlayingCard(value, suit);
                    Cards.Add(aCard);
                }
            }
        }

        public PlayingCard DrawCard()
        {
            PlayingCard card = null;
            if(!IsEmpty)
            {
                card = Cards[0]; // from the top of the deck
                Cards.Remove(card);
            }
            return card;
        }
    }
}
