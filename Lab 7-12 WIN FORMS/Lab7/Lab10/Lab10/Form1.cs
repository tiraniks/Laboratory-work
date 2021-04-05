using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSquare sqe = new TSquare(Convert.ToInt32(textBox1.Text));

            textBox2.Text = sqe.SSquare().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TSquare sqe = new TSquare(Convert.ToInt32(textBox1.Text));

            textBox3.Text = sqe.PerimeterSquare().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TSquare t1 = new TSquare(Convert.ToInt32(textBox1.Text));
            TSquare t2 = new TSquare(Convert.ToInt32(rnd.Next(1, 100)));
            textBox4.Text = t2.RandomSquare(t1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TSquare t1 = new TSquare(Convert.ToInt32(textBox1.Text));
            TSquare t2 = new TSquare(Convert.ToInt32(rnd.Next(1, 100)));
            TSquare s = t1 + t2;
            textBox5.Text = s.Input_Output().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TSquare t1 = new TSquare(Convert.ToInt32(textBox1.Text));
            TSquare t2 = new TSquare(Convert.ToInt32(rnd.Next(1, 100)));
            TSquare s = t1 - t2;
            textBox6.Text = s.Input_Output().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TSquare t1 = new TSquare(Convert.ToInt32(textBox1.Text));
            double t2 = Convert.ToDouble(textBox8.Text);
            TSquare s = t1 * t2;
            textBox7.Text = s.Input_Output().ToString();
        }

     

        private void button7_Click(object sender, EventArgs e)
        {
            TCube sqe = new TCube(Convert.ToInt32(textBox9.Text));

            textBox10.Text = sqe.CubeV().ToString();
        }
    }
}
