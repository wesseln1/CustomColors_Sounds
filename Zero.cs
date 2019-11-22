using System;
using System.Collections.Generic;

namespace CustomColors
{
    public class Zero : Vehicle
    { // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by! shhhhhhhummmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Whipped the {MainColor} Zero that thing {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"Skrrtted the {MainColor} Zero to a stop!");
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