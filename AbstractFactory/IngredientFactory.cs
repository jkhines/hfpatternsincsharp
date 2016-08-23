using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface IIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
    }

    public class Dough
    {
    }

    public class Sauce
    {
    }

    public class Cheese
    {
    }

    public class PortlandIngredientFactory : IIngredientFactory
    {
        #region IngredientFactory Members

        public Dough CreateDough()
        {
            Console.WriteLine("Portland");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Portland");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Portland");
            return new Cheese();
        }

        #endregion
    }

    public class HillsboroIngredientFactory : IIngredientFactory
    {
        #region IngredientFactory Members

        public Dough CreateDough()
        {
            Console.WriteLine("Hillsboro");
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Hillsboro");
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Hillsboro");
            return new Cheese();
        }

        #endregion
    }

}
