using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public abstract class customer:person
    {
        public customer() { }
        public customer(string name, int age, int id):base(name,age,id)
        {

        }
        public virtual double orderfood(menuitems item, int quantity)
        {
            return (item.price) * quantity;
        }
    }
}
