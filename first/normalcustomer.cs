using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class normalcustomer:customer
    {
       // public static int normalcount = 0;
        public normalcustomer() { }
        public normalcustomer(string name, int age, int id):base(name,age,id)
        {
            //normalcustomer.normalcount++;
        }
        public override double orderfood(menuitems item, int quantity)
        {
            return (item.price) * quantity;
        }

    }
}
