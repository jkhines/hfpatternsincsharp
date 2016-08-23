using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        public virtual void Prepare()
        {
            Console.WriteLine("Standard preparation technique.");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Standard baking technique.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Standard cutting technique.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Standard boxing technique.");
        }
    }
}
