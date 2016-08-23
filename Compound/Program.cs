using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compound
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory, Flock, and Duck Creation
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            AbstractGooseFactory gooseFactory = new GooseFactory();

            IQuack redhead = duckFactory.CreateRedheadDuck();
            IQuack call = duckFactory.CreateDuckCall();
            IQuack rubber = duckFactory.CreateRubberDuck();
            IQuack goose = gooseFactory.CreateGoose();

            Flock duckFlock = new Flock();
            duckFlock.Add(redhead);
            duckFlock.Add(call);
            duckFlock.Add(rubber);
            duckFlock.Add(goose);

            IQuack mallard1 = duckFactory.CreatMallardDuck();
            IQuack mallard2 = duckFactory.CreatMallardDuck();
            IQuack mallard3 = duckFactory.CreatMallardDuck();
            IQuack mallard4 = duckFactory.CreatMallardDuck();

            Flock mallardFlock = new Flock();
            mallardFlock.Add(mallard1);
            mallardFlock.Add(mallard2);
            mallardFlock.Add(mallard3);
            mallardFlock.Add(mallard4);

            duckFlock.Add(mallardFlock);
            #endregion

            DuckWatcher duckWatcher = new DuckWatcher();
            duckFlock.Subscribe(duckWatcher);

            Console.WriteLine("\r\n***DUCK SIMULATOR: WHOLE FLOCK***");
            Simulate(duckFlock);

            Console.WriteLine("The ducks quacked {0} times.  Thank you for playing.",
                QuackCounter.Quacks);

            Console.WriteLine("\r\n***DUCK SIMULATOR: MALLARD FLOCK***");
            Simulate(mallardFlock);

            Console.WriteLine("The ducks quacked {0} times.  Thank you for playing.",
                QuackCounter.Quacks);
            Console.ReadLine();
        }

        // the magic of polymorphism
        static void Simulate(IQuack duck)
        {
            duck.Quack();
        }
    }
}
