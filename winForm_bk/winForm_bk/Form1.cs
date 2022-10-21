using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm_bk
{
    public partial class Form1 : Form
    {
        public int choi, thang;
            
        public Form1()
        {
            InitializeComponent();
            choi = thang = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            choi++;
            Random r = new Random();
            label1.Text = r.Next(0, 9).ToString();
            label2.Text = r.Next(0, 9).ToString();
            label3.Text = r.Next(0, 9).ToString();
            //an hien anh
            if((label1.Text=="7") ||(label2.Text=="7") ||(label3.Text=="7"))
            {
                pictureBox1.Visible = true;
                thang++;
            }
            else
            {
                pictureBox1.Visible = false;
            }
            //hien thi cho label 4 va 5
            label4.Text = thang.ToString();
            label5.Text = ((double)thang / choi).ToString("0.00%");
        }
    }
}
