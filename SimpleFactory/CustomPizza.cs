using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom cheese pizza.");
        }
    }
    class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom sea-creature pizza.");
        }
    }
    class ShoePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom orthopedic pizza.");
        }
    }
}
