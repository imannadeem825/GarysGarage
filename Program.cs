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

            moto.Drive();
            moto.Turn("left");
            moto.Stop();

            Cessna plane = new Cessna()
            {
                FuelCapacity = 5.5,
                MainColor = "gray",
                MaximumOccupancy = "40"
            };

            plane.Drive();
            plane.Turn("right");
            plane.Stop();

            Tesla elec = new Tesla()
            {
                BatteryKWh = 5000,
                MainColor = "onyx",
                MaximumOccupancy = "4"
            };

            elec.Drive();
            elec.Turn("left");
            elec.Stop();

            Ram truck = new Ram()
            {
                FuelCapacity = 20.5,
                MainColor = "navy",
                MaximumOccupancy = "3"
            };

            truck.Drive();
            truck.Turn("right");
            truck.Stop();
        }
    }
}
