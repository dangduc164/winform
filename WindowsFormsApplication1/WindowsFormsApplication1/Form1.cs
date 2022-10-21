using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DataTable tbOrder = new DataTable();
        DataRow r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quatity");
        }
        private void chonmon(string tenmon)
        {
            int test = 0;//nghĩa là món này chưa có trong bảng đặt hàng 
            foreach(DataRow row in tbOrder.Rows)
            {
                if(row["FoodName"].ToString()==tenmon)
                {
                    test = 1;
                }
            }
            if (test == 1)
            {
                foreach (DataRow row in tbOrder.Rows)
                {
                    //thêm số lượng +1
                    if (row["FoodName"].ToString() == tenmon)
                    {
                        row["Quatity"] = int.Parse(row["Quatity"].ToString()) + 1; 
                    }
                }
            }
            else
            {
                //thêm mới 1 món và bảng
                r = tbOrder.NewRow();
                r["FoodName"] = tenmon;
                r["Quatity"] = 1;
                tbOrder.Rows.Add(r);
            }

        }

        private void btnburgerbo_Click(object sender, EventArgs e)
        {
            chonmon(btnburgerbo.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btnburgerga_Click(object sender, EventArgs e)
        {
            chonmon(btnburgerga.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btnburgertom_Click(object sender, EventArgs e)
        {
            chonmon(btnburgertom.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btnburgerca_Click(object sender, EventArgs e)
        {
            chonmon(btnburgerca.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btntomvien_Click(object sender, EventArgs e)
        {
            chonmon(btntomvien.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btngavien_Click(object sender, EventArgs e)
        {
            chonmon(btngavien.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btngaran_Click(object sender, EventArgs e)
        {
            chonmon(btngaran.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btncomga_Click(object sender, EventArgs e)
        {
            chonmon(btncomga.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btnpepsi_Click(object sender, EventArgs e)
        {
            chonmon(btnpepsi.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btn7up_Click(object sender, EventArgs e)
        {
            chonmon(btn7up.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btncafe_Click(object sender, EventArgs e)
        {
            chonmon(btncafe.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btncoca_Click(object sender, EventArgs e)
        {
            chonmon(btncoca.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btnlipton_Click(object sender, EventArgs e)
        {
            chonmon(btnlipton.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btncam_Click(object sender, EventArgs e)
        {
            chonmon(btncam.Text);
            dataGridView1.DataSource = tbOrder;
        }

        private void btnkhoaitaychien_Click(object sender, EventArgs e)
        {
            chonmon(btnkhoaitaychien.Text);
            dataGridView1.DataSource = tbOrder;
        }
    }
}
