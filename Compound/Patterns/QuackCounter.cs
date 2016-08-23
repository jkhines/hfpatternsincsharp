using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class QuackCounter : IQuack
    {
        private IQuack duck;
        private static int numberOfQuacks;
        public static int Quacks
        {
            get { return numberOfQuacks;  }
        }

        private Observable observable;

        public QuackCounter(IQuack duck)
        {
            this.duck = duck;
            observable = new Observable(this);
        }

        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
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
