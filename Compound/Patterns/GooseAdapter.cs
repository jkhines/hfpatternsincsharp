using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class GooseAdapter : IQuack
    {
        private Observable observable;

        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }

        public void Quack()
        {
            goose.Honk();
            observable.OnNext();
        }

        public IDisposable Subscribe(IObserver<IQuack> observer)
        {
            observable.Subscribe(observer);
            return null; // why a return value here?
        }

        public void OnNext()
        {
            observable.OnNext();
        }
    }
}
