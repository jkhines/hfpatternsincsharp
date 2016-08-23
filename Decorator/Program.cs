using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Decorator
{
    class UpperCaseTextReader
    {
        TextReader myTextReader;

        UpperCaseTextReader(TextReader newTextReader)
        {
            this.myTextReader = newTextReader;
        }

        public string ReadToEnd()
        {
            return (myTextReader.ReadToEnd().ToUpper());

            // example
            //UpperCaseTextReader reader =
            //    new UpperCaseTextReader(new TextReader(
            //        new FileStream(path)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev = new AfricanBlend();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new HouseBlend();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new Cream(bev);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new Cream(bev);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));
            Console.ReadLine();
        }
    }
}
