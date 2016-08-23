using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    public interface IQuack : IObservable<IQuack>
    {
        void Quack();
    }
}
