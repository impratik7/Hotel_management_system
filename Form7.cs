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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string s = "insert into hotel values(@p1,@p2,@p3)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted "); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string s = "insert into room values(@p1,@p2,@p3,@p4)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", textBox6.Text);
            cmd.Parameters.AddWithValue("@p2", textBox5.Text);
            cmd.Parameters.AddWithValue("@p3", textBox4.Text);
            cmd.Parameters.AddWithValue("@p4", textBox7.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted "); 
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string s = "insert into emp values(@p1,@p2,@p3,@p4)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", textBox10.Text);
            cmd.Parameters.AddWithValue("@p2", textBox9.Text);
            cmd.Parameters.AddWithValue("@p3", textBox8.Text);
            cmd.Parameters.AddWithValue("@p4", textBox11.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted "); 
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string s = "insert into emp values(@p1,@p2,@p3)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", textBox15.Text);
            cmd.Parameters.AddWithValue("@p2", textBox14.Text);
            cmd.Parameters.AddWithValue("@p3", textBox13.Text);
            
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted "); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f1 = new Form9();
            f1.Activate();
            f1.Show();
        }
    }
}
