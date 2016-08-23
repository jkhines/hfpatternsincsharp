using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuack CreatMallardDuck();
        public abstract IQuack CreateRedheadDuck();
        public abstract IQuack CreateDuckCall();
        public abstract IQuack CreateRubberDuck();
    }
}
