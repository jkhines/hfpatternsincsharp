using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] adaptee = new int[] { 1, 2, 3 };
            List<int> adapter = new List<int>(adaptee);
            adapter.Add(4);
            int[] restoredAdaptee = adapter.ToArray();
        }
    }
}
