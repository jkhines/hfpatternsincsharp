using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class PizzaStore
    {
        PizzaFactory factory;

        public PizzaStore(PizzaFactory customPizzaFactory)
        {
            this.factory = customPizzaFactory;
        }

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = this.factory.CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
