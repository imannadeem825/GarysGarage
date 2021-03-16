using System; 

namespace GarysGarage 
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }

        double CurrentTankPercentage { get; set; }

        void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100.0;
        }
    }
}