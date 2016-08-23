using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class DuckWatcher : IObserver<IQuack>
    {
        public void OnNext(IQuack value)
        {
            Console.WriteLine("DuckWatcher: {0} just quacked.\r\n", value.GetType());
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
