using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class CheesePizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public CheesePizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Making custom cheese pizza.");
            this.ingredientFactory.CreateDough();
            this.ingredientFactory.CreateSauce();
            this.ingredientFactory.CreateCheese();
        }
    }

    class ClamPizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public ClamPizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Making custom sea-creature pizza.");
            this.ingredientFactory.CreateDough();
            this.ingredientFactory.CreateSauce();
            this.ingredientFactory.CreateCheese();
        }
    }

    class ShoePizza : Pizza
    {
        IIngredientFactory ingredientFactory;

        public ShoePizza(IIngredientFactory customIngredientFactory)
        {
            this.ingredientFactory = customIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Making custom orthopedic pizza.");
            this.ingredientFactory.CreateDough();
            this.ingredientFactory.CreateSauce();
            this.ingredientFactory.CreateCheese();
        }
    }
}
