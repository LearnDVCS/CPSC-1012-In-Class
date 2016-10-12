using System;

namespace AssortedExamples
{
    public class Square
    {
        // Properties
        public int Side { get; private set; }
        public int Area
        {
            get
            {
                return Side * Side;
            }
        }
        public Square(int sideLength)
        {
            Side = sideLength;
        }
    }
}
