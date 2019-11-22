using System;
using System.Collections.Generic;

namespace CustomColors
{
    public class Cessna : Vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cennsa zips by you! bbbbuurrrrrrggggggggggggggggg");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Whipped the {MainColor} Cennsa that thing {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Skrrtted the {MainColor} Cennsa to a stop!");
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