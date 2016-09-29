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
            FixSign();
        }

        private void FixSign()
        {
            if(Denominator < 0)
            {
                Denominator *= -1; // same as Denominator = Demonator * -1;
                Numerator *= -1;
            }
        }

        // Property that identifies if this fraction is proper or not
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

        public void MultiplyBy(Fraction otherFraction)
        {
            this.Numerator = this.Numerator * otherFraction.Numerator;
            this.Denominator = this.Denominator * otherFraction.Denominator;
        }

        public void DivideBy(Fraction other)
        {
            // Multiply this numerator against the other denominator, and vice-versa
            Numerator = Numerator * other.Denominator;
            Denominator = Denominator * other.Numerator;
        }

        public void Add(Fraction other)
        {
            // Order matters! I have to calculate the new value for the
            // numerator before I do the new value for the denominator.
            // Why? Because if I change the denominator value first,
            // then it will "contaminate" the results of calculating
            // the new numerator.
            Numerator = other.Denominator * Numerator
                      + other.Numerator * Denominator;
            Denominator = Denominator * other.Denominator;
        }

        public void Subtract(Fraction other)
        {
            Numerator = other.Denominator * Numerator
                      - other.Numerator * Denominator;
            Denominator = Denominator * other.Denominator;
        }
    }
}
