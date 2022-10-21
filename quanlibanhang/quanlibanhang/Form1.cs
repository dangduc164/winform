using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanhang
{
    public partial class Form1 : Form
    {
        int nut = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nut = 1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nut = 2;
            if (nut == 1)
            {
                //them moi
                //kiem tra xem cac o co rong hay khong
                if (textBox1.Text == "")
                { MessageBox.Show("truong ma san pham khong duoc de trong !"); }
                QLBHEntities db = new QLBHEntities();
                if (db.tblSanphams.FirstOrDefault(c => c.maSP == textBox1.Text) == null)
                {//cho phep nhap moi
                    // chen du lieu tu form vao database
                    tblSanpham bt = new tblSanpham();
                    bt.maSP = textBox1.Text;
                    bt.tenSP = textBox2.Text;
                    bt.gia = int.Parse(textBox3.Text);
                    bt.soluong = int.Parse(textBox4.Text);
                    //add du lieu tu bang vao database
                    db.tblSanphams.Add(bt);
                    //lu lai database
                    db.SaveChanges();
                    //hien thi du lieu len dataGridView
                    dataGridView1.DataSource = db.tblSanphams.ToList();
                }
                else
                { MessageBox.Show("da ton tai ma sp nay! vui long nhap ma khac"); }
            }
            if (nut == 4)
            {
                //luu sua
                QLBHEntities db = new QLBHEntities();
                tblSanpham bt = new tblSanpham();
                bt = db.tblSanphams.FirstOrDefault(c => c.maSP == textBox1.Text);// select * form ten bang where đk=....?

                //bt.maSP = textBox1.Text;
                bt.tenSP = textBox2.Text;
                bt.gia = int.Parse(textBox3.Text);
                bt.soluong = int.Parse(textBox4.Text);

                db.SaveChanges();
                dataGridView1.DataSource = db.tblSanphams.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //b1 khai bao bien co so du lieu , 
            QLBHEntities db = new QLBHEntities();
            //khai bao bien tao bang tblSanpham
            tblSanpham bt = new tblSanpham();
            dataGridView1.DataSource = db.tblSanphams.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // khai bao 1 bien dong
            DataGridViewRow dong = new DataGridViewRow();
            dong = this.dataGridView1.Rows[e.RowIndex];
            //  gan du lieu cho cac text box
            textBox1.Text = dong.Cells[0].Value.ToString();
            textBox2.Text = dong.Cells[1].Value.ToString();
            textBox3.Text = dong.Cells[2].Value.ToString();
            textBox4.Text = dong.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nut = 3;
            //b1: khai bao bien co so du lieu (db)
            QLBHEntities db = new QLBHEntities();
            // khai bao bang tam co lien ket bang du lieu that
            tblSanpham bt = new tblSanpham();
            //xoa du lieu trong bang tam : dua vao ma san pham vua chon
            bt = db.tblSanphams.FirstOrDefault(c => c.maSP == textBox1.Text);// select * form ten bang where đk=....?
            db.tblSanphams.Remove(bt);
            db.SaveChanges();
            //lam moi lai du lieu tren datagridview
            var lst = db.tblSanphams.ToList();
            dataGridView1.DataSource = lst;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nut = 4;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nut = 5;
            this.Close();
        }
    }
}
