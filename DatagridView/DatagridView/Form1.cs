using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatagridView
{
    public partial class Form1 : Form
    {
        DataGridViewRow dong;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows[0].Cells[0].Value = '1';
            //dataGridView1.Rows[0].Cells[1].Value = "thong";
            //dataGridView1.Rows[0].Cells[2].Value = "thaibinh";
            //dataGridView1.Rows[0].Cells[3].Value = "12345";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //lệnh lưu
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //thẻ mới
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lênh chọn dòng 
            dong = this.dataGridView1.Rows[e.RowIndex];

            textBox1.Text = dong.Cells[0].Value.ToString();
            textBox2.Text = dong.Cells[1].Value.ToString();
            textBox3.Text = dong.Cells[2].Value.ToString();
            textBox4.Text = dong.Cells[3].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dong);
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            //nut sua(cap nhat)
            dataGridView1.Rows[dong.Index].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[dong.Index].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[dong.Index].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[dong.Index].Cells[3].Value = textBox4.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
