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
    public partial class Grade : Form
    {
        public Grade(string strTextBox1, string strTextBox2)
        {
            InitializeComponent();
			textBox12.Text = strTextBox1;
            textBox13.Text = strTextBox2;
 
            label16.Text = strTextBox1 + "'s CGPA :";
        }
		
		private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox11_TextChanged(object sender, EventArgs e)
        {  

        }


        string gpoint(string i)
        {
            string p = "";
            if (i == "A+"){
                p = "4.00";
            }
            else if(i == "A"){
                p = "3.75";
            }
            else if (i == "A-"){
                p = "3.50";
            }
            else if (i == "B+"){
                p = "3.25";
            }
            else if (i == "B"){
                p = "3.00";
            }
            else if (i == "B-"){
                p = "2.75";
            }
            else if (i=="C+"){
                p = "2.50";
            }
            else if (i == "C"){
                p = "2.25";
            }
            else if (i == "D"){
                p = "2.00";
            }
            else if (i == "F"){
                p = "0.00";
            }

            return p;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Grade_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text) && String.IsNullOrEmpty(textBox6.Text) && String.IsNullOrEmpty(textBox7.Text) && String.IsNullOrEmpty(textBox8.Text) && String.IsNullOrEmpty(textBox9.Text) && String.IsNullOrEmpty(textBox10.Text))
                {
                    MessageBox.Show("Enter all Grade & Credit");
                    textBox1.Focus();
                    return;
                }

                else if (!(((float.Parse(textBox2.Text)) >= 1 && (float.Parse(textBox2.Text)) <= 3) && ((float.Parse(textBox4.Text)) >= 1 && (float.Parse(textBox4.Text)) <= 3) && ((float.Parse(textBox6.Text)) >= 1 && (float.Parse(textBox6.Text)) <= 3) && ((float.Parse(textBox8.Text)) >= 1 && (float.Parse(textBox8.Text)) <= 3) & ((float.Parse(textBox10.Text)) >= 1 && (float.Parse(textBox10.Text)) <= 3)))
                {
                    MessageBox.Show("Credit can be between 1.00 and 3.00", "Error");
                    textBox11.Clear();
                    if (!((float.Parse(textBox2.Text)) >= 1 && (float.Parse(textBox2.Text)) <= 3)) textBox2.Clear();
                    else if (!((float.Parse(textBox4.Text)) >= 1 && (float.Parse(textBox4.Text)) <= 3)) textBox4.Clear();
                    else if (!((float.Parse(textBox6.Text)) >= 1 && (float.Parse(textBox6.Text)) <= 3)) textBox6.Clear();
                    else if (!((float.Parse(textBox8.Text)) >= 1 && (float.Parse(textBox8.Text)) <= 3)) textBox8.Clear();
                    else if (!((float.Parse(textBox10.Text)) >= 1 && (float.Parse(textBox10.Text)) <= 3)) textBox10.Clear();
                    return;
                }


                else
                {
                    var dcgp = float.Parse(gpoint(textBox1.Text));
                    var dcc = float.Parse(textBox2.Text);

                    var sdgp = float.Parse(gpoint(textBox3.Text));
                    var sdc = float.Parse(textBox4.Text);

                    var osgp = float.Parse(gpoint(textBox5.Text));
                    var osc = float.Parse(textBox6.Text);

                    var msdgp = float.Parse(gpoint(textBox7.Text));
                    var msdc = float.Parse(textBox8.Text);

                    var isdgp = float.Parse(gpoint(textBox9.Text));
                    var isdc = float.Parse(textBox10.Text);

                    float cg = ((dcgp * dcc) + (sdgp * sdc) + (osgp * osc) + (msdgp * msdc) + (isdgp * isdc)) / (dcc + sdc + osc + msdc + isdc);
                    textBox11.Text = cg.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Enter all Grade & Credit");
                return;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
