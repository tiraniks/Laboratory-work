using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TNumber sum = new TNumber(Convert.ToInt32(textBox1.Text));
            textBox3.Text = sum.Random_Sum_Array().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TNumber sumq = new TNumber(Convert.ToInt32(textBox2.Text));
            textBox4.Text = sumq.SumQ().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TNumber FL = new TNumber(Convert.ToInt32(textBox1.Text));
            listBox1.Items.Add(FL.First_last().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TNumber FLQ = new TNumber(Convert.ToInt32(textBox1.Text));
            listBox2.Items.Add(FLQ.First_lastQ().ToString());
        }
    }
}
