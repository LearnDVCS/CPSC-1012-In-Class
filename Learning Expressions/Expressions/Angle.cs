﻿using System; // I need Math class

namespace Expressions
{
    public class Angle
    {
        // Property
        public double Degrees { get; private set; }

        // Constructor
        public Angle(double degrees)
        {
            Degrees = degrees;
        }

        // Other properties that are calculations
        public double Raidans
        { get { return Degrees * (Math.PI / 180); } }

        public double Grads
        { get { return Raidans * (200 / Math.PI); } }

        // Method to convert to string
        public override string ToString()
        {
            return Degrees.ToString() + '\u00B0';
            //     \double/             \ char /
            //     \    string      /       |
            //      ________________    \string/
            //            \                /
            //             \       +      /
            //              \   string   /
        }
    }
}