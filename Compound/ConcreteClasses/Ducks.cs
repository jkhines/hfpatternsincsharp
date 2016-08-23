using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class MallardDuck : IQuack
    {
        private Observable observable;

        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
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

    class RedheadDuck : IQuack
    {
        private Observable observable;

        public RedheadDuck()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
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

    class DuckCall : IQuack
    {
         private Observable observable;

        public DuckCall()
        {
            observable = new Observable(this);
        }

       public void Quack()
        {
            Console.WriteLine("Kwak!");
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

    class RubberDuck : IQuack
    {
        private Observable observable;

        public RubberDuck()
        {
            observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeek!");
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
