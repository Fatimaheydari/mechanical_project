using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Digi_VA\\source\\repos\\WindowsFormsApp12\\WindowsFormsApp12\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM customers WHERE name = '"+name+"'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();

            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtb_name_update.Text;
            string phone = txtb_phone_update.Text;
            string repair = txtb_repair_update.Text;
            string price = txtb_price_update.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Digi_VA\\source\\repos\\WindowsFormsApp12\\WindowsFormsApp12\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE customers set phone = '"+phone+"' , type_repair = '"+repair+"' , price = '"+price+"' WHERE name = '"+name+"'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();

            sc.Close();
            MessageBox.Show("changs have been saved");
            txtb_name_update.Text = txtb_phone_update.Text = txtb_repair_update.Text = txtb_price_update.Text = " ";
        }
    }
    }
    

