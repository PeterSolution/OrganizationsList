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

namespace ListOfOrganizations
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { 
                string text1 = textBox1.Text;
                string text2 = textBox2.Text;
                string text3=textBox3.Text;

                string connectsql = "";
                SqlConnection connectionn = new SqlConnection(connectsql);
                connectionn.Open();
                string query = "INSERT INTO list (nazwa, osoba, stan) VALUES (@textt1, @textt2, @textt3)";
                SqlCommand commm = new SqlCommand(query, connectionn);
                commm.Parameters.AddWithValue("@textt1", text1);
                commm.Parameters.AddWithValue("@textt2", text2);
                commm.Parameters.AddWithValue("@textt3", text3);
                commm.ExecuteNonQuery();
                connectionn.Close();
            }
            else
            {
                MessageBox.Show("Write what you want to add in first field");
            }

        }
    }
}
