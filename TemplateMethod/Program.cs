using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // test StarBuzz method template pattern
            TestStarBuzz();

            // test StarBuzz method template pattern with hooks
            TestStarBuzzWithHook();

            Console.Read();
        }

        private static void TestStarBuzz()
        {
            Console.WriteLine("\r\nDrink 1...");
            ICaffeineBeverage myDrink = new Tea();
            myDrink.PrepareRecipe();

            Console.WriteLine("\r\nDrink 2...");
            myDrink = new Coffee();
            myDrink.PrepareRecipe();
        }

        private static void TestStarBuzzWithHook()
        {
            Console.WriteLine("\r\nDrink 1 With Hook...");
            ICaffeineBeverageWithHook myDrink = new TeaWithHook();
            myDrink.PrepareRecipe();

            Console.WriteLine("\r\nDrink 2 With Hook...");
            myDrink = new CoffeeWithHook();
            myDrink.PrepareRecipe();
        }
    }
}
