using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Zero fxs = new Zero()
            {
                MainColor = "Black"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Purple"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Blue"
            };
            Ram truck = new Ram()
            {
                MainColor = "Red"
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            truck.Drive();
            truck.Turn();
            truck.Stop();
        }
    }
}
