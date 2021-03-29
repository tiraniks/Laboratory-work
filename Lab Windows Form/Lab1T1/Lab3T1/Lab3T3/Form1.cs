using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3T3
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

            int p = n;

            int[] x = new int[n];

            int[] y = new int[n];

            int s = 0;

            for (int i = 0; n > 0; i++)
            {
                n--;
                
                int a = Convert.ToInt32(textBox2.Text);

                x[i] = a;

                int b = Convert.ToInt32(textBox3.Text);

                y[i] = b;
            }

            for (int j = 0; p > 0; j++)
            {
                p--;
                int k = x[j] * y[j];
                s += k;
            }

            textBox4.Text = s.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
