using System; // so I can use the Random class

namespace Expressions
{
    public class Die
    {
        // Static field
        private static Random _rnd = new Random(); // note the initialization
        // From a design perspective, having a Random
        // number generator that is shared among all
        // Die objects is a good idea, because it will
        // improve the "randomness" of the numbers generated

        // Constructor
        public Die()
        {
            // TODO: set up the side of the die that is the face showing value
            Sides = 6; // a common six-sided die
            Roll();
        }

        // An overloaded constructor
        public Die(int numberOfSides)
        {
            Sides = numberOfSides;
            Roll();
        }

        // Property
        public int FaceValue { get; private set; }
        public int Sides { get; private set; }

        // Method
        public void Roll()
        {
            // Get a random value greater than or equal to 1 & less than Sides + 1
            FaceValue = _rnd.Next(1, Sides + 1);
        }

    }
}
