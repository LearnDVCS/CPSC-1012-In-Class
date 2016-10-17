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
            Sides = 6;
            Roll();
        }

        public Die(int sides)
        {
            // TODO: Test this in the Program.cs as well
            // Less than 4 sides and more than 20 sides are not allowed.
            if (sides < 4 || sides > 20)
                throw new Exception("Die can only have 4 to 20 sides");
            Sides = sides;
            Roll();
        }

        // Property
        public int Sides { get; private set; }
        public int FaceValue { get; private set; }

        // Method
        public void Roll()
        {
            // Get a random value greater than or equal to 1 and less than 7
            FaceValue = _rnd.Next(1, Sides + 1);
        }
    }
}
