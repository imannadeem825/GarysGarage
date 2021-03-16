using System;

namespace GarysGarage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {

        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100.00;
            Console.WriteLine("Charging");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. Mmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle seems to glide around you, turning {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently rolls to a stop.");
        }
    }

    internal interface IElectric
    {
        void ChargeBattery();
    }

}