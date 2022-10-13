using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_CS_pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double marime;
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox26.Text);
            double num2 = Convert.ToDouble(textBox27.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);

            textBox28.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            if (radioButton1.Checked = true)
            {
                double marime = 6.3;
            }
            else if (radioButton2.Checked = true)
            {
                double marime = 10.75;
            }
            else if (radioButton3.Checked = true)
            {
                double marime = 13.25;
            }
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8 + marime;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = "0";
            textBox9.Text = "0";
            textBox12.Text = "0";
            textBox11.Text = "0";
            textBox17.Text = "0";
            textBox20.Text = "0";
            textBox23.Text = "0";
            textBox26.Text = "0";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox6.Text);
            double num2 = Convert.ToDouble(textBox7.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox4.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox9.Text);
            double num2 = Convert.ToDouble(textBox8.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox5.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox12.Text);
            double num2 = Convert.ToDouble(textBox14.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox16.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox11.Text);
            double num2 = Convert.ToDouble(textBox13.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox15.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox17.Text);
            double num2 = Convert.ToDouble(textBox18.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox19.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox20.Text);
            double num2 = Convert.ToDouble(textBox21.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox22.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox23.Text);
            double num2 = Convert.ToDouble(textBox24.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);


            textBox25.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox26.Text);
            double num2 = Convert.ToDouble(textBox27.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);

            textBox28.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            if(radioButton1.Checked = true)
            {
                double marime = 6.30;
            } else if(radioButton2.Checked = true)
            {
                double marime = 10.75;
            } else if(radioButton3.Checked = true)
            {
                double marime = 13.25;
            }
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8 + marime;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to close the app?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox26.Text);
            double num2 = Convert.ToDouble(textBox27.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);

            textBox28.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            if (radioButton1.Checked = true)
            {
                double marime = 6.3;
            }
            else if (radioButton2.Checked = true)
            {
                double marime = 10.75;
            }
            else if (radioButton3.Checked = true)
            {
                double marime = 13.25;
            }
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8 + marime;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox26.Text);
            double num2 = Convert.ToDouble(textBox27.Text);
            double nez = num1 * num2;
            string Subtotal1 = String.Format("{0:0.00}", nez);

            textBox28.Text = Subtotal1;
            double numa = Convert.ToDouble(textBox4.Text);
            double numb = Convert.ToDouble(textBox5.Text);
            double num3 = Convert.ToDouble(textBox16.Text);
            double num4 = Convert.ToDouble(textBox15.Text);
            double num5 = Convert.ToDouble(textBox19.Text);
            double num6 = Convert.ToDouble(textBox22.Text);
            double num7 = Convert.ToDouble(textBox25.Text);
            double num8 = Convert.ToDouble(textBox28.Text);
            if (radioButton1.Checked = true)
            {
                double marime = 6.3;
            }
            else if (radioButton2.Checked = true)
            {
                double marime = 10.75;
            }
            else if (radioButton3.Checked = true)
            {
                double marime = 13.25;
            }
            double nep = numa + numb + num3 + num4 + num5 + num6 + num7 + num8 + marime;
            string Subtotal2 = String.Format("{0:0.00}", nep);
            textBox29.Text = Subtotal2;
        }
    }
}
