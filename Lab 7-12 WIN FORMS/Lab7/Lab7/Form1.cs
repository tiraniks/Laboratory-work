using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
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

            Matrix tmx = new Matrix(n);
            int[,] matrix = tmx.InputMatrix();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            Convert.ToString(Matrix.Min());

            Convert.ToString(Matrix.Max());

        }


    }
}
