using System; // so I can use the Random class

namespace Expressions
{
    public class Die
    {
        // Static field
        private static Random _rnd = new Random(); // note the initialization

        // Constructor
        public Die()
        {
            // set up the side of the die that is the face showing value
            Roll();
        }

        // Property
        public int FaceValue { get; private set; }

        // Method
        public void Roll()
        {
            // Get a random value greater than or equal to 1 and less than 7
            FaceValue = _rnd.Next(1, 7);
        }
    }
}
