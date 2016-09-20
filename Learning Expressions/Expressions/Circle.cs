using System;

namespace Expressions
{
    public class Circle
    {
        // Fields
        public static double PI = 3.14159;
        // Properties
        // The following is an "auto-implemented" property
        public double Diameter { get; set; } // let the compiler put in a backing store

        // Constructor
        public Circle(double diameter)
        {
            Diameter = diameter;
        }
    }
}
