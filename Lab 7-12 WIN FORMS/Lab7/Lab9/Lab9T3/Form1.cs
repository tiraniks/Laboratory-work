using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9T3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectangle sqe = new rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            textBox3.Text = sqe.Rectangle_P().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rectangle sqe = new rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            textBox4.Text = sqe.Rectangle_S().ToString();
        }
    }
}
