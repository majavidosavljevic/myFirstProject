using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c, d, resRE = 0, resIM = 0;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            d = Convert.ToDouble(textBox4.Text);
            if (comboBox1.Text == "Zbrajanje")
            {
                resRE = a + c;
                resIM = b + d;
            }
            else if (comboBox1.Text == "Oduzimanje")
            {
                resRE = a - c;
                resIM = b - d;
            }
            else if (comboBox1.Text == "Množenje")
            {
                resRE = a * c - b * d;
                resIM = b * c - a * d;
            }
            else if (comboBox1.Text == "Dijeljenje")
            {
                resRE = (a * c + b * d) / (c * c + d * d);
                resIM = (b * c - a * d) / (c * c + d * d);
            }

            if (resIM > 0) textBox5.Text = Convert.ToString(resRE + "+" + resIM + "i");
            if (resIM < 0) textBox5.Text = Convert.ToString(resRE + "-" + Math.Abs(resIM) + "i");

            if (checkBox1.Checked)
            {
                double modul1;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                modul1 = Math.Sqrt(a * a + b * b);
                textBox6.Text = Convert.ToString(string.Format("{0:0.00}", modul1));
            }

            if (checkBox2.Checked)
            {
                double modul2;
                c = Convert.ToDouble(textBox3.Text);
                d = Convert.ToDouble(textBox4.Text);
                modul2 = Math.Sqrt(c * c + d * d);
                textBox7.Text = Convert.ToString(string.Format("{0:0.00}", modul2));
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
