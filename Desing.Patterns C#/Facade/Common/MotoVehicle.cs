using Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Common
{
    public  abstract class MotoVehicle : IVehicle
    {
        private string model;

        public MotoVehicle(int countWheel, string model)
        {
            CountWheel = countWheel;
            this.model = model;
        }

        public int CountWheel { get; set; }
        public string Mode { get; set; }
       
        public void Create()
        {
            Console.WriteLine("Creating a {0} with {1} wheels", Mode, CountWheel);
        }
    }
}
