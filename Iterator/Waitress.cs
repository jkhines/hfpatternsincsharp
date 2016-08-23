using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Waitress
    {
        IMenu menu;

        public Waitress(IMenu menu)
        {
            this.menu = menu;
        }

        public void PrintMenu()
        {
            menu.Print();
        }
    }
}
