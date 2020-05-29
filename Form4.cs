using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.cus' table. You can move, or remove it, as needed.
            this.cusTableAdapter.Fill(this.masterDataSet.cus);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.cusTableAdapter.Fill(this.masterDataSet.cus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cusBindingSource.AddNew();
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
                this.cusBindingSource.RemoveCurrent();
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
                this.cusTableAdapter.Update(this.masterDataSet.cus);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f1 = new Form9();
            f1.Activate();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Activate();
            f3.Show();
        }
    }
}
