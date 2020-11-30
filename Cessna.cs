using System;


namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past. Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna leaves a trail of smoke as it turns in the sky!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna bounces as its tires screech to a halt.");
        }

    }
}