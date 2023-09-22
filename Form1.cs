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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int a1 = 1;
            string connectsql = "";
            SqlConnection connection = new SqlConnection(connectsql);
            connection.Open();
            string query = "Select * From list";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int label1location = label1.Bottom;
            while (reader.Read())
            {
                Label l1 = new Label();
                l1.Top = label1location + 30 * a1;
                l1.Left = this.Left + 10;
                l1.Text = reader.GetValue(1).ToString();
                l1.TextAlign = ContentAlignment.MiddleCenter;
                Label l2 = new Label();
                l2.Top = label1location + 30 * a1;
                l2.Left = l1.Right + 10;
                l2.Text = reader.GetValue(2).ToString();
                l2.TextAlign = ContentAlignment.MiddleLeft;
                Label l3 = new Label();
                l3.Top = label1location + 30 * a1;
                l3.Left = l2.Right + 10;
                l3.Text = reader.GetValue(3).ToString();
                l3.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Add(l1);
                this.Controls.Add(l2);
                this.Controls.Add(l3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formtoopen=new Form2();
            formtoopen.ShowDialog();
        }
    }
}
