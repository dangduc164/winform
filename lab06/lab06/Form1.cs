using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String s = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
            label1.Text = s;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file|*.avi|MPEG File | *.mpeg | Wav File |*.Wav | Midi File | *.midi | Mp4 File | *.mp4";
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName;
            axWindowsMediaPlayer1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }
    }
}
