using Facade.Client_Requests;
using Facade.implemantations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
   public class Facade : IFacadeMethods
    {
        private Car car { get; set; }
        private Motocicle motocicle { get; set; }

        public void CreateCar(int countWheel, string model)
        {
            car = new Car(countWheel, model);
            car.Create();

        }

        public void CreateMotocicle(int countWheel, string model)
        {
            motocicle = new Motocicle(countWheel, model);
            motocicle.Create();
        }
    }
}
