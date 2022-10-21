using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhakhoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            getpay();
        }
        private void getpay()
        {
            var total = 0;
            if (txtname.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên!");
            }
            else
            {
                if(chkcaovoi.Checked == true)
                {
                    total += 100000;
                }
                if(chktaytrang.Checked == true)
                {
                    total += 1200000;
                }
                if(chkchuprang.Checked == true)
                {
                    total += 200000;
                }
                total += int.Parse(numericUpDown1.Value.ToString()) * 80000;
                txttotal.Text = "$"+total.ToString();
                listBox1.
            }
        }
    }
}
