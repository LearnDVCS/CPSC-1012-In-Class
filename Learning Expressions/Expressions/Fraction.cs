namespace Expressions
{
    public class Fraction
    {
        // Auto-implemented Properties
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        // Explicitly implemented Property
        public Fraction Reciprocal
        {
            get { return new Fraction(Denominator, Numerator); }
        }

        // Constructor
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Method - specifically, I will override (change) the default
        //          behaviour of the ToString() method
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public double ToDouble()
        {
            double value = (double)Numerator / Denominator;
            return value;
        }

        public double ToPercent()
        {
            return ToDouble() * 100.0;
        }
    }
}
