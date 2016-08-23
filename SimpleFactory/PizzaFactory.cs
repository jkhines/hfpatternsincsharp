using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheese")
                pizza = new CheesePizza();
            else if (type == "Clam")
                pizza = new ClamPizza();
            else if (type == "Suede")
                pizza = new ShoePizza();

            return pizza;
        }
    }
}
