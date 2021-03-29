using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4T5
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

            Random rand = new Random(DateTime.Now.Millisecond);

            double[,] a = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-10, 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
                
            }

            int s = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 0)
                    {
                        s++;
                        break;
                    }
                }
            }

            if (s == 0)
            {
                textBox3.Text = "Таких рядків немає";
            }
            else
            {
                textBox3.Text = s.ToString();
            }
        }
    }
}
