using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string connectionString;
            SqlConnection con;
            connectionString = @"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            MessageBox.Show("Connection created");
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.masterDataSet.hotel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.hotelBindingSource.AddNew();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.hotelBindingSource.RemoveCurrent();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.hotelTableAdapter.Update(this.masterDataSet.hotel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hotelTableAdapter.Fill(this.masterDataSet.hotel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Form7 f2 = new Form7();
            f2.Activate();
            f2.Show();
        }
    }
}
