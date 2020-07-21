using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.implementtios
{
    public class Car : IPrototypeCloneble 
    {
        public string marca { get; set; }
        public int ano { get; set; }

        public IPrototypeCloneble Clone()
        {
            return (IPrototypeCloneble)MemberwiseClone();
          
           // return (IPrototypeCloneble)this.Clone();

        }

        public void ShowDatails()
        {
            Console.WriteLine("Marca {0} => Año del Vehiculo {1}, hashcode {2}  \n' ",marca, ano, this.GetHashCode());
        }

    }
}
