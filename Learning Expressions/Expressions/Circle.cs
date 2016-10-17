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

        public double Radius { get { return Diameter / 2; } }
        //        *                          double   int

        public double Circumference { get { return Diameter * PI; } }
        //                                         instance  static

        public double Area { get { return PI * Radius * Radius; } }

        // Constructor
        public Circle(double diameter)
        {
            // TODO: Test this in the Program.cs (homework)
            if (diameter <= 0)
                throw new Exception("Circles must have a diameter greater than zero.");
            Diameter = diameter;
        }
    }
}
