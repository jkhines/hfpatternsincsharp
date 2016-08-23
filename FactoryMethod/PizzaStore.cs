using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }

    public class PortlandPizzaStore : PizzaStore
    {
        // portland-style preparation for all pizzas
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheese")
                pizza = new PortlandStyleCheesePizza();
            else if (type == "Clam")
                pizza = new PortlandStyleClamPizza();
            else if (type == "Suede")
                pizza = new PortlandStyleShoePizza();

            return pizza;
        }
    }

    public class HillsboroPizzaStore : PizzaStore
    {
        // hillsboro-style preparation for all pizzas
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "Cheese")
                pizza = new HillsboroStyleCheesePizza();
            else if (type == "Clam")
                pizza = new HillsboroStyleClamPizza();
            else if (type == "Suede")
                pizza = new HillsboroStyleShoePizza();

            return pizza;
        }
    }
}
