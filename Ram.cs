using System;
using System.Collections.Generic;

namespace CustomColors
{
    public class Ram : Vehicle
    { // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram zips by you! Rummmmmmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Whipped the {MainColor} Ram that thing {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"Skrrtted the {MainColor} Ram to a stop!");
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