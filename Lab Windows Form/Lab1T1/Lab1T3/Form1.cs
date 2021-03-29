using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1T3
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, x2, y2, x3, y3;

            x1 = Convert.ToDouble(textBox1.Text);
            y1 = Convert.ToDouble(textBox2.Text);
            x2 = Convert.ToDouble(textBox3.Text);
            y2 = Convert.ToDouble(textBox4.Text);
            x3 = Convert.ToDouble(textBox5.Text);
            y3 = Convert.ToDouble(textBox6.Text);


            double AB, AC, BC;

            AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            if ((Math.Pow(AB, 2) < Math.Pow(AC, 2) + Math.Pow(BC, 2)) || (Math.Pow(AC, 2) < Math.Pow(AB, 2) + Math.Pow(BC, 2)) || (Math.Pow(BC, 2) < Math.Pow(AB, 2) + Math.Pow(AC, 2)))
            {
                textBox7.Text = ("Трикутник буде гострокутнім");
            }
            else
            {
                textBox7.Text = ("Трикутник не буде гострокутнім");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
