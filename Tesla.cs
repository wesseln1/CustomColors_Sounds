using System;
using System.Collections.Generic;

namespace CustomColors
{
    public class Tesla : Vehicle
    { // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zips by you! zzzzzzZZZZZZZZzzzz!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Whipped the {MainColor} Telsa that thing {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"Skrrtted the {MainColor} Telsa to a stop!");
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