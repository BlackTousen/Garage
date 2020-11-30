using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. ZZZZZzzzt!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Tesla cuts you off before making a right turn!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla switches lanes four times before coming to a stop at the light...");
        }


    }
}