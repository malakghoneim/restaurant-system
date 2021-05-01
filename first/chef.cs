using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class chef :person
    {
        int salary;
        int extrahrs;
        public chef() { }
        public chef(string name, int age, int id, int salary,int extrahrs):base(name,age,id)
        {
            this.salary = salary;
            this.extrahrs = extrahrs;
        }
        public int calculatebonus(chef chef)
        {
            return chef.extrahrs * 50;
        }
        public int totalsalary(chef chef)
        {
            return (chef.salary + chef.extrahrs * 50);
        }
    }
}
