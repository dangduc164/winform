using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danhmucnhanvien
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "")
            {
                MessageBox.Show("Ban chua nhap day du ho ten! Moi ban nhap lai!");
                txthoten.Focus();
            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Ban chua nhap day du so dien thoai! Moi ban nhap lai!");
                txtdienthoai.Focus();
            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Ban chua nhap day du dia chi! Moi ban nhap lai!");
                txtdiachi.Focus();
            }
            else 
            { 
            ListViewItem lvi = lstnhanvien.Items.Add(txthoten.Text);
            lvi.SubItems.Add(dtpngaysinh.Value.ToShortDateString());
            lvi.SubItems.Add(txtdienthoai.Text);
            lvi.SubItems.Add(txtdiachi.Text);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstnhanvien.SelectedItems.Count > 0)
            {
                lstnhanvien.Items.Remove(lstnhanvien.SelectedItems[0]);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstnhanvien.SelectedItems.Count > 0)
            {
                lstnhanvien.SelectedItems[0].SubItems[0].Text = txthoten.Text;
                lstnhanvien.SelectedItems[0].SubItems[1].Text = dtpngaysinh.Value.ToShortDateString();
                lstnhanvien.SelectedItems[0].SubItems[2].Text = txtdienthoai.Text;
                lstnhanvien.SelectedItems[0].SubItems[3].Text = txtdiachi.Text;
            }
        }

        private void lstnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstnhanvien.SelectedItems.Count > 0)
            {
                txthoten.Text = lstnhanvien.SelectedItems[0].SubItems[0].Text;
                dtpngaysinh.Text = lstnhanvien.SelectedItems[0].SubItems[1].Text;
                txtdienthoai.Text = lstnhanvien.SelectedItems[0].SubItems[2].Text;
                txtdiachi.Text = lstnhanvien.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
