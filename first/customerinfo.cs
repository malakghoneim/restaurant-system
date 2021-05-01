using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace first
{
    public partial class customerinfo : Form
    {
        public customerinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            int id = Convert.ToInt32(textBox3.Text);
            if(radioButton1.Checked)
                {
                
                start.allcustomers[start.counter ] = new normalcustomer(name, age, id);
                
                start.counter++;
            }
            
            
            else if(radioButton2.Checked)
            {
                string promocode = textBox4.Text;
                start.allcustomers[start.counter] = new vipcustomer(name, age, id,promocode);
                

                start.counter++;
            }
            this.Close();
            
            new orderonline().ShowDialog();
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                label4.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void customerinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dataSet1.customers);

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            //SqlCommand cmd = new SqlCommand("sp_insert", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@age", textBox2.Text);
            //cmd.Parameters.AddWithValue("@id", textBox3.Text);
           // cmd.Parameters.AddWithValue("@address", textBox4.Text);
           // con.Open();
            //int i = cmd.ExecuteNonQuery();

            //con.Close();

            //if (i != 0)
            //{
                //MessageBox.Show(i + "Data Saved");
            //}
        }
    }
}
