using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TRational plus =  new TRational(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox4.Text = plus.Plus_Rational().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TRational minus = new TRational(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox5.Text = minus.Minus_Rational().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TRational multiplication = new TRational(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox6.Text = multiplication.multiplication_Rational().ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TRational division = new TRational(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            textBox7.Text = division.division_Rational().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TRational Conclusion = new TRational(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox2.Text));
            
            listBox1.Items.Add(Conclusion.Conclusion_Rational().ToString());
        }

        
    }
}
