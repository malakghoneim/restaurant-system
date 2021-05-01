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
    public partial class booktable : Form
    {
        public booktable()
        {
            InitializeComponent();
        }

        private void booktable_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void booktable_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked)
            {
                comboBox1.Enabled = true;
               // MessageBox.Show("yes");
               
            }
                
            else
                comboBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;
                int age = Convert.ToInt32(textBox3.Text);
                int id = Convert.ToInt32(textBox4.Text);

                start.allcustomers[start.counter] = new normalcustomer(name, age, id);
            }
            catch(Exception)
            {
                MessageBox.Show("enter all info\n");
            }

            this.Close();
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int addcost;
            if(comboBox1.SelectedIndex==0)
            {
                addcost = 10;
                label9.Text = addcost.ToString();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                addcost = 20;
                label9.Text = addcost.ToString();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                addcost = 15;
                label9.Text = addcost.ToString();
            }
            else
            {
                addcost = 0;
                label9.Text = addcost.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            label9.Text = 0.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox1.Enabled = true;
                
            }

            else
                comboBox1.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
