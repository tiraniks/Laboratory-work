using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_WF
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

            double[] ay = new double[n];

            string[] ar = textBox2.Text.Split(' ');
            double[] z = new double[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = Convert.ToDouble(ar[i]);
            }

            Array.Sort(ar);
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = ar.Length;
            for (int i = 0; i < ar.Length; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = ar[i];
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


            double min = 1000;
            for (int j = 0; j < n; j++)
            {
                ay[j] = Convert.ToDouble(ar[j]);
            }

            for (int i = 0; i < n; i += 1)
            {
                if (min > ay[i])
                {
                    min = ay[i];
                }
            }

            textBox4.Text = min.ToString();


           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);

            double[] ay = new double[n];

            string[] ar = textBox2.Text.Split(' ');
            double[] z = new double[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = Convert.ToDouble(ar[i]);

                if (z[i] % 3 == 0)
                {
                    dataGridView1.Rows[0].Cells[i].Value = z[i];
                }
                else
                {
                    textBox7.Text = $"Чисел кратних 3 нема";
                }
            }

            

        }
    }   
}
    

