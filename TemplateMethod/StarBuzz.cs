using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public interface ICaffeineBeverage
    {
        void PrepareRecipe();
        void Brew();
        void AddCondiments();
        void BoilWater();
        void PourInCup();
    }

    public abstract class CaffeineBeverage : ICaffeineBeverage
    {
        #region ICaffeineBeverage Members

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("Pouring beverage...");
        }

        // C# - There is no 'final' keyword as in Java
        // where subclasses cannot redefine the parent method
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        #endregion
    }

    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping tea...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }
    }

    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }
    }
}
