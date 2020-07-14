using Factory.Common;
using Factory.Implementations;
using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
   public  class VehicleFactury
    {

        public static IVehicle GetVehicle(string nameClass) 
        {
            IVehicle obj = null;
            switch (nameClass)
            {
                case VehicleName.BMW:
                    obj = new Bmw();
                    break;

                case VehicleName.Mercedes:
                    obj = new Mercedes();
                    break;

                default:
                    obj = new Bmw();
                    break;
            }

            return obj;

        }

      
    }
}
