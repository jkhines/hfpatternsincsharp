using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            Menu dinerMenu = new Menu("DINER MENU", "Lunch");
            Menu cafeMenu = new Menu("CAFE MENU", "Dinner");
            Menu dessertMenu = new Menu("DESSERT MENU", "Dessert of course! ");
            Menu allMenus = new Menu("ALL MENUS", "All menus combined");

            MenuItem item = new MenuItem("Pancake", "Plain", true, 1.99);
            pancakeHouseMenu.Add(item);

            allMenus.Add(pancakeHouseMenu);
            cafeMenu.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            Waitress shirley = new Waitress(allMenus);
            shirley.PrintMenu();
            Console.ReadLine();
        }
    }
}
