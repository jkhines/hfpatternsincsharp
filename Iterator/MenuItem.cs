using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Iterator
{
    public class MenuItem : IMenu
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

        bool isVegetarian;
        public bool IsVegetarian
        {
            get { return isVegetarian; }
            set { isVegetarian = value; }
        }

        double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.IsVegetarian = isVegetarian;
            this.Price = price;
        }

        public void Print()
        {
            System.Console.WriteLine(
                "Menu Item\n-------------\nVegetarian? {0}\n{1}, {2} -- {3}",
                this.IsVegetarian, this.Name, this.Price, this.Description);
        }
    }
}
