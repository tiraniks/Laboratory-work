using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
;       }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            double[] A = new double[n];
            int s = 0;
            int f = 1;

            for (int i = 0; i < n; i++)
            {
                f = i;
                f *= i;
                double a = Math.Pow(-1, i) * i / f;

                A[i] = a;
            }

            for (int j = 0; j == A[0] + 1; j++)
            {
                if (j > 0)
                {
                    s += j;
                }
            }

            textBox2.Text = s.ToString();
        }
    }
}
