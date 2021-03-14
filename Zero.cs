using System;

public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero drives past. Whoooosh!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The vehicle turns {direction}");
    }
}