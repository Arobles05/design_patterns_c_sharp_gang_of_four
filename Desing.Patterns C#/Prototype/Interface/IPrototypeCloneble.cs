using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Interface
{
   public interface IPrototypeCloneble
    {
        IPrototypeCloneble Clone();
        void ShowDatails();
    }
}
