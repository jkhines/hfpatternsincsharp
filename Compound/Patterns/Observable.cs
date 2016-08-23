using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class Observable : IObservable<IQuack>
    {
        private List<IObserver<IQuack>> observers = new List<IObserver<IQuack>>();
        private IQuack duck;

        public Observable(IQuack duck)
        {
            this.duck = duck;
        }

        public IDisposable Subscribe(IObserver<IQuack> observer)
        {
            observers.Add(observer);
            return null; // why a return value here?
        }

        public void OnNext()
        {
            foreach (var observer in observers)
            {
                observer.OnNext(duck);
            }
        }
    }
}
