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

        public DeckOfCards(bool asEmptyDeck = false)
        {
            // Set up a standard deck of 52 cards
            Cards = new List<PlayingCard>(); // start with an empty list

            if (!asEmptyDeck)
            {
                // Loop through each suit, and each card value for each suit
                foreach (PlayingCard.CardSuit suit in
                        Enum.GetValues(typeof(PlayingCard.CardSuit)))
                {
                    foreach (PlayingCard.CardValue value in
                            Enum.GetValues(typeof(PlayingCard.CardValue)))
                    {
                        PlayingCard freshCard = new PlayingCard(value, suit);
                        Cards.Add(freshCard);
                    }
                }
            }
        }

        public PlayingCard DrawCard()
        {
            PlayingCard card = null; // no card, in case the deck is empty
            if(!IsEmpty)
            {
                card = Cards[0]; // from the top of the deck
                Cards.Remove(card); // take it out of the deck
            }
            return card; // give it to whoever calls this method
        }

        private static Random _Rnd = new Random();

        public void Shuffle()
        {
            if(!IsEmpty)
            {
                for (int counter = 0; counter < 500; counter++)
                {
                    // First, pick a spot to re-insert the card
                    int index = _Rnd.Next(Count);
                    // Second, remove a card from the deck
                    PlayingCard card = Cards[0]; // Grab the top card
                    Cards.Remove(card); // or Cards.RemoveAt(0);
                    // Third, re-insert the card
                    Cards.Insert(index, card);
                }
            }
        }

        public void AddCard(PlayingCard cardToAdd)
        {
            Cards.Add(cardToAdd);
        }
    }
}
