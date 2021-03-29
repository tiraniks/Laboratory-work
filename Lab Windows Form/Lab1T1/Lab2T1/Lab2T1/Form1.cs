using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);

            double n = Convert.ToDouble(textBox2.Text);

            if (n > 0)
            {
                double k = Math.Pow(a + 1, 2);
                n--;
                while (n > 0)
                {
                    k = Math.Pow(a + 1, 2) * Math.Pow(a + 2, 2) * Math.Pow(a + 1, 2) * Math.Pow(a, 2) * Math.Pow(a, 2);
                    n--;
                }
                k = k * Math.Pow(a, 2);
                textBox3.Text = k.ToString();
            }
            else
            {
                textBox3.Text = ("Рівняння не виконуєтся");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
