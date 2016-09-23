using System; // for the Math class

namespace Shapes
{
    public class Cylinder
    {
        // Fields
        private double _Radius;
        private double _Height;

        // Properies
        public double Radius
        {
            get { return _Radius; }
            private set { _Radius = value; }
        }

        public double Height
        {
            get { return _Height; }
            private set { _Height = value; }
        }

        public double Volume
        {
            get { return Math.PI * Radius * Radius * Height; }
        }

        public double SurfaceArea
        {
            get
            {
                return (2 * Math.PI * Radius * Radius)
                     + (2 * Math.PI * Radius * Height);
            }
        }

        // Constructor
        public Cylinder(double r, double Height)
        {
            Radius = r;
            this.Height = Height;
        }
    }
}
