using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);

            if ((Math.Pow(x, 2)) + (Math.Log(x + 1)) > 0)
            {
                double Y = Math.Cos(Math.Pow(x, 2) + Math.Log(x + 1));
                textBox2.Text = Y.ToString();
            }
            else if ((Math.Pow(x, 2)) + (Math.Log(x + 1)) < 0)
            {
                double Y = 1 / (Math.Pow(x, 2) + Math.Log(x + 1));
                textBox2.Text = Y.ToString();

            }
            else if ((Math.Pow(x, 2)) + (Math.Log(x + 1)) == 0)
            {
                double Y = Math.Cos(x);
                textBox2.Text = Y.ToString();
            }
            else
            {
                textBox2.Text = ("Порожня множина");
            }

        }
    }
}
