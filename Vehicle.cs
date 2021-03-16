using System;

namespace GarysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine("turn right");
        }

        public virtual void Stop()
        {
            Console.WriteLine("screech");
        }
    }

}