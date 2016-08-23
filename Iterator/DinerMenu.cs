using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class DinerMenu : IEnumerable<MenuItem>
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public MenuItem[] MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Diner1", "Description1", true, 2.99);
            AddItem("Diner2", "Description2", false, 2.99);
            AddItem("Diner3", "Description3", true, 3.29);
            AddItem("Diner4", "Description4", true, 3.05);
            AddItem("Diner5", "Description5", true, 3.11);
            AddItem("Diner6", "Description6", true, 3.12);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, isVegetarian, price);
            if (this.numberOfItems >= MAX_ITEMS)
                throw new ApplicationException(String.Format("Exceeded maximum number of menu items: {0}", MAX_ITEMS));
            else
                this.menuItems[this.numberOfItems++] = menuItem;
        }

        #region IEnumerable<MenuItem> Members

        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                yield return this.menuItems[i];
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.menuItems.Length; i++)
            {
                yield return this.menuItems[i];
            }
        }

        #endregion
    }

}
