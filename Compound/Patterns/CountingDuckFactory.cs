using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuack CreatMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuack CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuack CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuack CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
