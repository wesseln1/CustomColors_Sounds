using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomColors
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} vehcile zipped by! Vroom Vroom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Whipped this thing {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Skrrtted the vehicle to a stop!");
        }

        public virtual void TestDrive(string direction)
        {
            Drive();
            Turn(direction);
            Stop();
            Console.WriteLine();
        }
    }
}