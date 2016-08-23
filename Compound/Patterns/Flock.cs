using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class Flock : IQuack
    {
        List<IQuack> children = new List<IQuack>();

        public void Add(IQuack child)
        {
            children.Add(child);
        }

        public void Quack()
        {
            foreach (IQuack child in children)
                child.Quack();
        }

        public IDisposable Subscribe(IObserver<IQuack> observer)
        {
            foreach (IQuack child in children)
                child.Subscribe(observer);
            
            return null; // why a return value here?
        }

        public void OnNext()
        {
            // not needed for flock - Flock.Quack() will implement this for all of flock's children
        }
    }
}
