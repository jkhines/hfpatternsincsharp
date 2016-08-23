using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class DuckFactory : AbstractDuckFactory
    {
        public override IQuack CreatMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuack CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuack CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuack CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
