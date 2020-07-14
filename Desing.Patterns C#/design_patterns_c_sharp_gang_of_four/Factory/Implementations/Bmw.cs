using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementations
{
    public class Bmw : IVehicle
    {
        public void run()
        {
            Console.WriteLine("Running like BMW car.....");
        }

        public void start()
        {
            Console.WriteLine("Starting like BMW car.....");
        }

        public void stop()
        {
            Console.WriteLine("Stop like BMW car.....");
        }
    }
}
