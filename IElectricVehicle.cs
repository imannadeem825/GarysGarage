using System;

namespace GarysGarage
{
    public interface IElectricVehicle
    {

        double BatteryKWh { get; set; }

        double CurrentChargePercentage { get; set; }
        void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100.00;
        }

    }
}

