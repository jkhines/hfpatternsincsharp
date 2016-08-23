using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class PortlandStyleCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom Portland style cheese pizza.");
        }
    }

    class PortlandStyleClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom Portland style sea-creature pizza.");
        }
    }

    class PortlandStyleShoePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom Portland style orthopedic pizza.");
        }
    }

    class HillsboroStyleCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom Hillsboro style cheese pizza.");
        }
    }

    class HillsboroStyleClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom Hillsboro style sea-creature pizza.");
        }
    }

    class HillsboroStyleShoePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Making custom Hillsboro style orthopedic pizza.");
        }
    }
}
