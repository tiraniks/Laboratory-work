using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2T4
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            int[] k = new int[n];

            for (int i = 0; i < n; i++)
            {
                k[i] = 1;
            }

            if (n >= 2)
            {
                for (int i = 0; i < n; i++)
                {
                    int x = 2 * k[i - 1] + 3 * k[i - 2];

                    k[i] = x;
                }
            }
            for (int i = 0; i < k.Length; i++)
            {
                textBox2.Text += k[i].ToString() + "\r\n";
            }

            

        }
    }
}
