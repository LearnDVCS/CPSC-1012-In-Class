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
            FixSign();
        }

        // Property
        public bool IsProper
        {
            get
            {
                bool proper;
                if (Numerator < Denominator)
                    proper = true;
                else
                    proper = false;
                return proper;
            }
        }

        // Private method to fix the sign.
        private void FixSign()
        {
            if(Denominator < 0)
            {
                Numerator *= -1; // same as Numerator = Numerator * -1;
                Denominator *= -1;
            }
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

        public void MultiplyBy(Fraction otherFraction)
        {
            this.Numerator = this.Numerator * otherFraction.Numerator;
            this.Denominator = this.Denominator * otherFraction.Denominator;
        }

        public void DivideBy(Fraction other)
        {
            // The following is how we would mechanically divide two fractions
            Numerator = Numerator * other.Denominator;
            Denominator = Denominator * other.Numerator;

            // That's just the same as multiplying by the reciprocal... hmmm.
        }

        public void Add(Fraction other)
        {
            Numerator = (Numerator * other.Denominator)
                      + (other.Numerator * Denominator);
            Denominator = Denominator * other.Denominator;
        }

        public void Subtract(Fraction other)
        {
            Numerator = (Numerator * other.Denominator)
                      - (other.Numerator * Denominator);
            Denominator = Denominator * other.Denominator;
        }
    }
}
