using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Client_Requests
{
   public interface IFacadeMethods
    {
        void CreateMotocicle(int countWheel, string model);
        void CreateCar(int countWheel, string model);

    }
}
