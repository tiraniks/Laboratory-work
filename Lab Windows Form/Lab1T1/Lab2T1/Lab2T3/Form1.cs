using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x, n;

            

            x = Convert.ToDouble(textBox1.Text);

            double radX = x / 180 * Math.PI;

            n = Convert.ToDouble(textBox2.Text);


            double s = 0;

            if (0 < x && x < Math.PI)
            {
                for (int i = 0; i < n + 1; i++)
                {
                    s = Math.Log(Math.Abs(Math.Sin(x)));

                    double k = Math.Log(2) - Math.Cos(2 * x) - Math.Cos(4 * x) / 2 * n * i;

                    s = k - Math.Cos(2 * n * x) * i / n * i;
                }
                textBox3.Text = s.ToString();
            }
            else
            {
                textBox3.Text = ("Рівняння не виконується ");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
