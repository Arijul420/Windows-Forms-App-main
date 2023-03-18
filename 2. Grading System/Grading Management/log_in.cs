using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading_Management
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }
		
		private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("nasif", StringComparison.OrdinalIgnoreCase) && textBox2.Text == "1234")
            {
                new Grade(textBox1.Text, textBox2.Text).Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Try again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

              
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
