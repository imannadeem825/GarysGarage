using System;


namespace GarysGarage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
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
            Console.WriteLine($"The {MainColor} Zero drives past. Whoooosh!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle squeals around, turning {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero screeches to a halt.");
        }
    }

}