using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementations
{
    public class Mercedes : IVehicle
    {
        public void run()
        {
            Console.WriteLine("Running like Mercedes car.....");
        }

        public void start()
        {
            Console.WriteLine("Starting like Mercedes car.....");
        }

        public void stop()
        {
            Console.WriteLine("Stop like Mercedes car.....");
        }
    }
}
