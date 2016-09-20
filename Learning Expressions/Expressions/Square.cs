using System;

namespace Expressions
{
    public class Square
    {
        // Fields
        // the double data type holds a number with a fractional portion
        private double _Side;

        // Properties
        public double Side
        {
            get { return _Side; }
            private set { _Side = value; } // not accessible outside of this class
        }

        public double Area
        {
            get { return Side * Side; }
        }

        public double Perimeter
        {
            get { return Side * 4; }
        }

        // Constructor
        public Square(double sideLength)
        {
            Side = sideLength;
        }
    }
}
