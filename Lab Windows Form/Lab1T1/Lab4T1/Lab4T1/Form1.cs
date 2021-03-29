using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            n = Convert.ToInt32(textBox1.Text);
           

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] matrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
                Console.WriteLine();
            }

            double d = 1;

            for (int i = 0; n > 0; i++)
            {
                n--;
                for (int j = 0; n > 0; j++)
                {
                    n--;
                    if (i % 2 != 0 || j % 2 != 0)
                    {
                        if (matrix[i, j] < 0)
                        {
                            d = matrix[i, j];
                        }
                    }
                }
            }

            textBox3.Text = d.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
