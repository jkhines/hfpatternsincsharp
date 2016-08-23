using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mallard");
            Mallard mallard = new Mallard();
            Helper(mallard);

            Console.WriteLine("Spaniel");
            Spaniel spaniel = new Spaniel();
            Helper(spaniel);

            Console.WriteLine("Progeny");
            Spaniel progeny = new Spaniel();
            progeny.SetQuack(new QuackLikeMallard());
            Helper(progeny);

            Console.ReadLine();
        }

        static void Helper(Duck myDuck)
        {
            myDuck.Swim();
            myDuck.DoFly();
            myDuck.DoQuack();
        }
    }
}
