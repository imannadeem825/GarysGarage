using System;
using System.Collections.Generic;

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
                MaximumOccupancy = "2",
                CurrentChargePercentage = 15.0
            };

            Tesla elec = new Tesla()
            {
                BatteryKWh = 5000,
                MainColor = "onyx",
                MaximumOccupancy = "4",
                CurrentChargePercentage = 15.0
            };


            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                elec, moto
            };

            Console.WriteLine("Electric Vehicles");

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }


            /***********************************************/

            Cessna plane = new Cessna()
            {
                FuelCapacity = 5.5,
                MainColor = "gray",
                MaximumOccupancy = "40",
                CurrentTankPercentage = 20.0
            };


            Ram truck = new Ram()
            {
                FuelCapacity = 20.5,
                MainColor = "navy",
                MaximumOccupancy = "3",
                CurrentTankPercentage = 20.0
            };


            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                truck, plane
            };

            Console.WriteLine("Gas Vehicles");

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}


// truck.Drive();
// truck.Turn("right");
// truck.Stop();

// moto.Drive();
// moto.Turn("left");
// moto.Stop();

// elec.Drive();
// elec.Turn("left");
// elec.Stop();

// plane.Drive();
// plane.Turn("right");
// plane.Stop();