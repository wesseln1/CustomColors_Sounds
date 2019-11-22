using System;
using System.Collections.Generic;

namespace CustomColors
{
    public class Mazda : Vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Mazda zips by! Zoom Zoom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Whipped the {MainColor} Mazda that thing {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Skrrtted the {MainColor} Mazda to a stop!");
        }

        public override void TestDrive(string direction)
        {
            Drive();
            Turn(direction);
            Stop();
            Console.WriteLine();
        }
    }
}