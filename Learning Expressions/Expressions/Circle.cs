using System; // the Math class can be used to get PI

namespace Expressions
{
    public class Circle
    {
        // Fields
        // The reason that I make PI static, is because the value for 
        // PI should remaing the same, regardless of the size of any circles.
        public static double PI = 3.14159; // declaring & giving a value

        // Properties
        // The next three properties calculate values based off of the Diameter
        public double Radius { get { return Diameter / 2; } }
        //       *                           double   int

        // Notice how an instance member (Circumference) can use
        // both instance (Diameter) and static (PI) members.
        // Instance members can reference both instance and static members.
        // Static members ONLY have access to other static members.
        public double Circumference { get { return Diameter * PI; } }
        //                                         instance   static

        public double Area { get { return Math.PI * Math.Pow(Radius, 2); } }
        
        // The following is an "auto-implemented" property
        public double Diameter { get; set; } // let the compiler put in
                                             // a backing store
        /*
        // Here is a longer way of doing exactly the same thing as the auto-implemented
        private double _Diameter;
        public double Diameter
        {
            get
            {
                return _Diameter;
            }
            set
            {
                _Diameter = value;
            }
        }
        */

        // Constructor
        // Parameterless construtor
        public Circle()
        {
            // nothing to do here, in this example
        }

        public Circle(double diameter)
        {
            Diameter = diameter;
        }
    }
}
