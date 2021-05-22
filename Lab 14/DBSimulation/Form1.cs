using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show(_db.GetAll());
        }

        private PcDatabase _db = new PcDatabase();
        

        private void Show(List<PC> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Введіть дані ");
                return;
            }
            dataGridView1.RowCount = list.Count;
            for (int i=0;i<list.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].passport_data_name;
                dataGridView1.Rows[i].Cells[1].Value = list[i].education;
                dataGridView1.Rows[i].Cells[2].Value = list[i].specialty;
                dataGridView1.Rows[i].Cells[3].Value = list[i].position;
                dataGridView1.Rows[i].Cells[4].Value = list[i].salary;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PC newPc = new PC(
                textBoxName.Text,
                textBoxEducation.Text,
                textBoxSpecialty.Text,
                textBoxPosition.Text,
                double.Parse(textBoxSalary.Text)
                ); ;
            _db.Add(newPc);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;

            StreamWriter sw = new StreamWriter("text.txt", true);
            sw.WriteLine(textBoxName.Text);
            sw.WriteLine(textBoxEducation.Text);
            sw.WriteLine(textBoxSpecialty.Text);
            sw.WriteLine(textBoxPosition.Text);
            sw.WriteLine(textBoxSalary.Text);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            PC PcToDelete = _db.GetByIndex(i);
            _db.Remove(PcToDelete);
            Show(_db.GetAll());
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
