using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3T4
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
            int b = n;

            double p = n;

            int[,] k = new int[Convert.ToInt32(p), Convert.ToInt32(p)];
            int[,] A = new int[n,n];
            int[,] B = new int[n,n];

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = 1;

            for (int i = 0; n > 0; i++)
            {
                int a = Convert.ToInt32(textBox2.Text);
                n--;
                if (a > 0)
                {
                    A[i,i] = a;
                }
                else
                {
                    B[i,i] = a;
                }
            }

            k = A;

            k = B;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = k[i, j];
                }
            }
        }
    }
}
