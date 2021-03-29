using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4T3
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

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;

            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = n;

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] a = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }

            double[,] b = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = rand.Next(-100, 100);
                }
            }          

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
                
            }          

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = b[i, j];
                }
                
            }

            double[,] c = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = rand.Next(0, 0);
                }
            }            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];

                    dataGridView3.Rows[i].Cells[j].Value = c[i, j];
                }
                
            }

        }
    }
}
