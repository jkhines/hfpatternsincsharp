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

            pizza.Prepare(); // abstract factory pattern
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
            IIngredientFactory ingredientFactory =
                new PortlandIngredientFactory();

            if (type == "Cheese")
                pizza = new CheesePizza(ingredientFactory);
            else if (type == "Clam")
                pizza = new ClamPizza(ingredientFactory);
            else if (type == "Suede")
                pizza = new ShoePizza(ingredientFactory);

            return pizza;
        }
    }

    public class HillsboroPizzaStore : PizzaStore
    {
        // hillsboro-style preparation for all pizzas
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory =
                new HillsboroIngredientFactory();

            if (type == "Cheese")
                pizza = new CheesePizza(ingredientFactory);
            else if (type == "Clam")
                pizza = new ClamPizza(ingredientFactory);
            else if (type == "Suede")
                pizza = new ShoePizza(ingredientFactory);

            return pizza;
        }
    }
}
