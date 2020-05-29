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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.masterDataSet.hotel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f1 = new Form9();
            f1.Activate();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            searchbyid(textBox1.Text.Trim());
        }


        protected void searchbyid(string searchText)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No Id to search!");

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-U2LF2JT;Initial Catalog=master;Integrated Security=True"))
                {
                    string sql = "SELECT * FROM hotel WHERE hotel_id = '" + textBox1.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {

                        cmd.Parameters.AddWithValue("id", textBox1.Text);

                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        ad.Fill(dt);

                        if (dt.Rows.Count > 0)
                        { //check if the query returns any data
                            dataGridView1.DataSource = dt;
                            //dg1.DataBind();
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                }
            }
        }
    }
}
       




        