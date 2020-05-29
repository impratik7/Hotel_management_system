using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text.Equals("pratik") && textBox2.Text.Equals("pratik"))
            {
                string connectionString;
                SqlConnection con;
                connectionString = @"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                MessageBox.Show("Connection created");

                this.Hide();

                Form9 f2 = new Form9();
                f2.Activate();
                f2.Show();
            }

        }
    }
}
