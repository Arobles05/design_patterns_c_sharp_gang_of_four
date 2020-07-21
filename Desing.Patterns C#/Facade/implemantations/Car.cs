using Facade.Common;
using Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.implemantations
{
    public class Car: MotoVehicle
    {
      

        public Car(int countWheel, string model) : base(countWheel,model)
        {
           
        }

      
    }
}
