using Prototype.implementtios;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.ano = 2010;
            car.marca = "Toyota";

            Car car2 = (Car)car.Clone();
            car.ShowDatails();
            car2.ShowDatails();

        }
    }
}
