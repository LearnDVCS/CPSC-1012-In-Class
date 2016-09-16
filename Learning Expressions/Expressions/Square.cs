using System;

namespace Expressions
{
    public class Square
    {
        // Fields
        private double _Side;

        // Properties
        public double Side
        {
            get { return _Side; }
            private set { _Side = value; }
        }

        public double Area
        {
            get { return Side * Side; }
        }

        public double Perimeter
        {
            get { return Side * 4; }
        }

        public Square(double sideLength)
        {
            Side = sideLength; // Store the value via the property
        }
    }
}
