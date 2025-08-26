using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    class ShoppingCart
    {
        public List<string> Items = new();
        public Dictionary<string, int> Quantities = new();
        public HashSet<string> Discounts = new();
    }

}
