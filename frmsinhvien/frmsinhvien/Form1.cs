using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmsinhvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            listbandau.Items.Add(txthoten.Text);
            txthoten.Text = "";
            txthoten.Focus();
        }

        private void btnsangphai_Click(object sender, EventArgs e)
        {
            int n = listbandau.SelectedItems.Count; //Tong so muc duoc chon
            for (int i = 0; i <= n - 1; i++)
                listketqua.Items.Add(listbandau.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                listbandau.Items.RemoveAt(j);

        }

        private void btnsangtrai_Click(object sender, EventArgs e)
        {
            int n = listketqua.SelectedItems.Count; //Tong so muc duoc chon
            for (int i = 0; i <= n - 1; i++)
                listbandau.Items.Add(listketqua.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                listketqua.Items.RemoveAt(j);
        }

        private void btnallsangphai_Click(object sender, EventArgs e)
        {

            int n = listbandau.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                listketqua.Items.Add(listbandau.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                listbandau.Items.RemoveAt(j);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int n = listbandau.SelectedItems.Count;
            for (int i = n - 1; i >= 0; i--)
                listbandau.Items.Remove(listbandau.SelectedItems[i].ToString());
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnallsangtrai_Click(object sender, EventArgs e)
        {
            int n = listketqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                listbandau.Items.Add(listketqua.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                listketqua.Items.RemoveAt(j);
        }
    }
}
