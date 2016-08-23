using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public interface ICaffeineBeverageWithHook
    {
        void PrepareRecipe();
        void Brew();
        void AddCondiments();
        void BoilWater();
        void PourInCup();
    }

    public abstract class CaffeineBeverageWithHook : ICaffeineBeverageWithHook
    {
        #region ICaffeineBeverage Members

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        public abstract void Brew();

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

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
            if (CustomerWantsCondiments())
                AddCondiments();
        }
        #endregion
    }

    public class TeaWithHook : CaffeineBeverageWithHook
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

    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.Write("Would you like milk and sugar with your coffee (Y/n)? : ");
            string answer = Console.ReadLine().Trim();
            return (answer.Length == 0 || answer.ToLower().StartsWith("y"));
        }
    }
}
