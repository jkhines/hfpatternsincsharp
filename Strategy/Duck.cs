using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck
{
    public abstract class Duck
    {
        IFlyBehavior flyer;
        IQuackBehavior quacker;

        public virtual void DoFly()
        {
            this.flyer.Fly();
        }

        public virtual void SetFly(IFlyBehavior newFlyer)
        {
            this.flyer = newFlyer;
        }

        public virtual void DoQuack()
        {
            this.quacker.Quack();
        }

        public virtual void SetQuack(IQuackBehavior newQuacker)
        {
            this.quacker = newQuacker;
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swish, swish");
        }
    }

    public class Mallard : Duck
    {
        public Mallard()
        {
            SetFly(new FlyWithWings());
            SetQuack(new QuackLikeMallard());
        }
    }

    public class Spaniel : Duck
    {
        public Spaniel()
        {
            SetFly(new FlyWithJetPropulsion());
            SetQuack(new QuackLikeSpaniel());
        }
    }
}
