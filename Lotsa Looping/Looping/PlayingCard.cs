using System;

namespace Looping
{
    public class PlayingCard
    {
        // Enumeration types
        public enum CardSuit { HEARTS, CLUBS, DIAMONDS, SPADES }
        public enum CardValue
        {
            ACE = 1,
            DEUCE,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING
        }

        // Properties
        public CardSuit Suit { get; private set; }
        public CardValue Value { get; private set; }

        // Constructor
        public PlayingCard(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }

        // Methods
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
