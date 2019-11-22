using System;
using System.Collections.Generic;

namespace CustomColors
{
    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();
            var mazda = new Mazda();

            zero.MainColor = "White";
            zero.MaximumOccupancy = 2;
            tesla.MainColor = "Blue";
            tesla.MaximumOccupancy = 5;
            mazda.MainColor = "Grey";
            mazda.MaximumOccupancy = 5;
            ram.MainColor = "Orange";
            ram.MaximumOccupancy = 6;
            cessna.MainColor = "Green";
            cessna.MaximumOccupancy = 2;

            zero.TestDrive("right");
            tesla.TestDrive("right");
            ram.TestDrive("right");
            cessna.TestDrive("right");
            mazda.TestDrive("right");
        }
    }
}