using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Iterator
{

    public class Menu : IMenu
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        ArrayList children = new ArrayList();

        public Menu(String name, String description)
        {
            this.Name = name;
            this.Description = description;
        }

        public void Print()
        {
            Console.WriteLine("Menu\n{0}, {1}\n---------------------",
                this.Name, this.Description);

            foreach (IMenu child in this.children)
                child.Print();
        }

        public void Add(IMenu menu)
        {
            this.children.Add(menu);
        }
    }
}
