using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class PancakeHouseMenu : IEnumerable<MenuItem>
    {
        ArrayList menuItems;

        public ArrayList MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("Pancake1", "Description1", true, 2.99);
            AddItem("Pancake2", "Description2", false, 2.99);
            AddItem("Pancake3", "Description3", true, 3.49);
            AddItem("Pancake4", "Description4", true, 3.59);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            this.menuItems.Add(menuItem);
        }

        #region IEnumerable<MenuItem> Members

        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Count; i++)
            {
                yield return (MenuItem)this.menuItems[i];
            }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Count; i++)
            {
                yield return this.menuItems[i];
            }
        }

        #endregion
    }
}
