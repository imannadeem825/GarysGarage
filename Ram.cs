using System;

namespace GarysGarage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100.0;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. Rrrrruuummmble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} gently rolls to a stop.");
        }
    }

}