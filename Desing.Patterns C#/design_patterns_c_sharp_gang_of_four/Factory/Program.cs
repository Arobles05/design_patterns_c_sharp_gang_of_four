using Factory.Common;
using Factory.Implementations;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory....!");

            Mercedes mercedes = (Mercedes)VehicleFactury.GetVehicle(VehicleName.Mercedes);
            mercedes.run();
            mercedes.start();
            mercedes.stop();

            Bmw bmw = (Bmw)VehicleFactury.GetVehicle(VehicleName.BMW);
            bmw.run();
            bmw.start();
            bmw.stop();
        }
    }
}
