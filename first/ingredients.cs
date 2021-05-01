using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
   public class ingredients
    {
        public string type;
        public int count;
        public bool expiredate;
        public ingredients() { }
        public ingredients(string type, int count, bool expiredate)
        {
            this.type = type;
            this.count = count;
            this.expiredate = expiredate;
        }

    }
}
