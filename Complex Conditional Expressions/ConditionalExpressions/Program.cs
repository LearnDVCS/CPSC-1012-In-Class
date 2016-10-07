﻿using System;

namespace ConditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an angle (in degrees): ");
            int angle;
            angle = int.Parse(Console.ReadLine());
            string angleType;
            if (angle > 0 && angle < 90)
                angleType = "Acute";
            else if (angle == 90)
                angleType = "Right";
            else if (angle > 90 && angle < 180)
                angleType = "Obtuse";
            else if (angle == 180)
                angleType = "Straight";
            else if (angle > 180 && angle < 360)
                angleType = "Reflex";
            else if (angle == 360)
                angleType = "Full Rotation";
            else
                angleType = "Undefined";

            Console.WriteLine($"A {angle} degree angle is a {angleType} angle.");

            if (angleType != "Undefined")
            {
                double radians = angle * (Math.PI / 180);
                radians = Math.Round(radians, 3);

                Console.WriteLine($"A {angle} degree angle is {radians} Radians.");
            }
        }
    }
}
