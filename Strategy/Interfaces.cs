using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quack();
    }
}
