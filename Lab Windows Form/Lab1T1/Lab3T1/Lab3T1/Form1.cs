using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            string[] ar = textBox2.Text.Split(' ');
            double[] z = new double[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = Convert.ToDouble(ar[i]);
            }

            double a = 0;

            for (int i = 0; i < n; i++)
            {
                if (a < z[i])
                {
                    a = z[i];
                }

            }

            textBox3.Text = a.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
