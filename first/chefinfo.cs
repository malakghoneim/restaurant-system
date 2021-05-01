using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first
{
    public partial class chefinfo : Form
    {
        public chefinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                int age = Convert.ToInt32(textBox2.Text);
                int id = Convert.ToInt32(textBox3.Text);
                int salary = Convert.ToInt32(textBox4.Text);
                int extrahrs= Convert.ToInt32(numericUpDown1.Text);

                start.chefs[start.chefcounter] = new chef(name, age, id,salary,extrahrs);
                start.chefcounter++;
                int bonus = start.chefs[start.chefcounter - 1].calculatebonus(start.chefs[start.chefcounter - 1]);
                
                label6.Text = bonus.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("enter all info\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                int age = Convert.ToInt32(textBox2.Text);
                int id = Convert.ToInt32(textBox3.Text);
                int salary = Convert.ToInt32(textBox4.Text);
                int extrahrs = Convert.ToInt32(numericUpDown1.Text);

                start.chefs[start.chefcounter] = new chef(name, age, id, salary, extrahrs);
                start.chefcounter++;
                int total = start.chefs[start.chefcounter - 1].totalsalary(start.chefs[start.chefcounter - 1]);

                label7.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("enter all info\n");
            }
        }

        private void chefinfo_Load(object sender, EventArgs e)
        {

        }
    }
}
