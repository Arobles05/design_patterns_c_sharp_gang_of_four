using System;

namespace Facade
{
   public class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.CreateCar(4, "Toyota");

            facade.CreateMotocicle(3, "GYM");
        }
    }
}
