using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Billing_System
{
    public partial class Order : Form
    {
        public Order(string strTextBox1, string strTextBox2)
        {
            InitializeComponent();
			textBox7.Text = strTextBox1;
            textBox8.Text = strTextBox2;
        }
		
		string discount(string i)
        {
            string p = "";
            if (i == "DISCOUNT5")
                p = "0.05";
            else if (i == "DISCOUNT10")
                p = "0.1";          
            else if (i == "DISCOUNT15")
                p = "0.15";
            else
                p = "0.00";
            return p;
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("Enter all Price");
                    textBox1.Focus();
                    return;
                }

                else if ( ((float.Parse(textBox1.Text))>200) || ((float.Parse(textBox2.Text)) > 200) || ((float.Parse(textBox3.Text)) > 200) || ((float.Parse(textBox4.Text)) > 200) || ((float.Parse(textBox5.Text)) > 200))
                {
                    MessageBox.Show("Unit Price can be at most 200");
                    textBox1.Focus();
                    textBox6.Clear();
                    if ((float.Parse(textBox1.Text))> 200) textBox1.Clear();
                    else if ((float.Parse(textBox2.Text)) > 200) textBox2.Clear();
                    else if ((float.Parse(textBox3.Text)) > 200) textBox3.Clear();
                    else if ((float.Parse(textBox4.Text)) > 200) textBox4.Clear();
                    else if ((float.Parse(textBox5.Text)) > 200) textBox5.Clear();
                    return;
                }


                else
                {
                    var b = float.Parse(textBox1.Text);
                    var k = float.Parse(textBox2.Text);
                    var f = float.Parse(textBox3.Text);
                    var bu = float.Parse(textBox4.Text);
                    var p = float.Parse(textBox5.Text);

                    var c1 = float.Parse(comboBox1.SelectedItem.ToString());
                    var c2 = float.Parse(comboBox2.SelectedItem.ToString());
                    var c3 = float.Parse(comboBox3.SelectedItem.ToString());
                    var c4 = float.Parse(comboBox4.SelectedItem.ToString());
                    var c5 = float.Parse(comboBox5.SelectedItem.ToString());

                    float total = ((b * c1) + (k * c2) + (f * c3) + (bu * c4) + (p * c5));

                    var dis = float.Parse(discount(textBox9.Text));
                    float distotal = total - total * dis;

                    textBox6.Text = distotal.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter all Unit Price");
                return;
            }

        }
    }
}
