using System;

namespace Garage
{

    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Zero speeds off making a left turn!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero does a nose wheely as it comes to a stop!");
        }

    }
}