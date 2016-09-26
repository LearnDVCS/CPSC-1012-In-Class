namespace Expressions
{
    public class Fraction
    {
        // Auto-implemented Properties
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        // Constructor
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Property
        public Fraction Reciprocal
        {
            get { return new Fraction(Denominator, Numerator); }
        }

        // Method - specifically, I will override (change) the behaviour of
        //          the default ToString() method.
        public override string ToString()
        {
            string stringValue = $"{Numerator}/{Denominator}";
            return stringValue;
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
