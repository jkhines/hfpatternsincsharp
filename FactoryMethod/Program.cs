using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PortlandPizzaStore();
            store.OrderPizza("Cheese");
            store = new HillsboroPizzaStore();
            store.OrderPizza("Clam");
        }
    }
}
