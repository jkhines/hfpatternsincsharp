using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore(new PizzaFactory());
            Pizza myPizza = store.OrderPizza("Clam");
        }
    }
}
