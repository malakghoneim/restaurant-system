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
    public partial class makefood : Form
    {
        public makefood()
        {
            InitializeComponent();
        }

        private void makefood_Load(object sender, EventArgs e)
        {
            start.ingredients[0] = new ingredients("dough", 10, true);
            start.ingredients[1] = new ingredients("salsa", 7, true);
            start.ingredients[2] = new ingredients("olives", 10, true);
            start.ingredients[3] = new ingredients("cheese", 6, true);
            start.ingredients[4] = new ingredients("onions", 4, true);
            start.ingredients[5] = new ingredients("pasta", 10, true);
            start.ingredients[6] = new ingredients("sauce", 10, true);
            start.ingredients[7] = new ingredients("chicken", 10, true);
            start.ingredients[8] = new ingredients("tomato", 10, false);
            start.ingredients[9] = new ingredients("lettuce", 5, true);


            if (start.ingredients[0].count > 0 && start.ingredients[0].expiredate )
                comboBox1.Items.Add("dough");

            if (start.ingredients[1].count > 0 && start.ingredients[1].expiredate)
                comboBox1.Items.Add("salsa");

            if (start.ingredients[2].count > 0 && start.ingredients[2].expiredate)
                comboBox1.Items.Add("olives");

            if (start.ingredients[3].count > 0 && start.ingredients[3].expiredate)
                comboBox1.Items.Add("cheese");

            if (start.ingredients[4].count > 0 && start.ingredients[4].expiredate)
                comboBox1.Items.Add("onions");

            if (start.ingredients[5].count > 0 && start.ingredients[5].expiredate)
                comboBox1.Items.Add("pasta");

            if (start.ingredients[6].count > 0 && start.ingredients[6].expiredate)
                comboBox1.Items.Add("sauce");

            if (start.ingredients[7].count > 0 && start.ingredients[7].expiredate)
                comboBox1.Items.Add("chicken");

            if (start.ingredients[8].count > 0 && start.ingredients[8].expiredate)
                comboBox1.Items.Add("tomato");

            if (start.ingredients[9].count > 0 && start.ingredients[9].expiredate)
                comboBox1.Items.Add("lettuce");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plate = textBox1.Text;
            if(plate=="pizza")
            {
                if (comboBox1.Items.Contains("dough") && comboBox1.Items.Contains("salsa") && comboBox1.Items.Contains("olives") && comboBox1.Items.Contains("cheese") && comboBox1.Items.Contains("onions"))
                {
                    MessageBox.Show("Making pizza...please wait");
                    this.Close();
                }
                else
                    MessageBox.Show("Some of the ingredients not available...choose another plate");
            }
            if(plate=="pasta")
            {
                if (comboBox1.Items.Contains("pasta") && comboBox1.Items.Contains("sauce") && comboBox1.Items.Contains("cheese") && comboBox1.Items.Contains("chicken"))
                {
                    MessageBox.Show("Making pasta...please wait");
                    this.Close();
                }
                else
                    MessageBox.Show("Some of the ingredients not available...choose another plate");
            }
            if(plate=="salad")
            {
                if(comboBox1.Items.Contains("tomato") && comboBox1.Items.Contains("onions") && comboBox1.Items.Contains("lettuce") )
                {
                    MessageBox.Show("Making salad...please wait");
                    this.Close();
                }
                else
                    MessageBox.Show("Some of the ingredients not available...choose another plate");
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
