using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
   public class menuitems
    {
        public string type;
        public int count;
        public double price;

        public menuitems() { }
        public menuitems(string type, int count, double price)
        {
            this.type = type;
            this.count = count;
            this.price = price;
        }
    }
}
