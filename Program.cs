using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new vehicles
            Zero moto = new Zero()
            {
                BatteryKWh = 2000,
                MainColor = "white",
                MaximumOccupancy = "2"
            };

            Cessna plane = new Cessna()
            {
                FuelCapacity = 5.5,
                MainColor = "gray",
                MaximumOccupancy = "40"
            };

            Tesla elec = new Tesla()
            {
                BatteryKWh = 5000,
                MainColor = "onyx",
                MaximumOccupancy = "4"
            };

            Ram truck = new Ram()
            {
                FuelCapacity = 20.5,
                MainColor = "navy",
                MaximumOccupancy = "3"
            };

            moto.Drive();
            plane.Drive();
            elec.Drive();
            truck.Drive();
            
            moto.Turn("left");
        }
    }
}
