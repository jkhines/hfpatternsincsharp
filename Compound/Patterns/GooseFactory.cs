using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class GooseFactory : AbstractGooseFactory
    {
        public override IQuack CreateGoose()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
