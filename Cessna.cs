using System;

public class Cessna : Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna drives past. Zooooom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The vehicle makes a wide {direction} turn.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna rolls down the runway and stops.");
    }
}