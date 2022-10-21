namespace frmsinhvien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listbandau = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listketqua = new System.Windows.Forms.ListBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnsangphai = new System.Windows.Forms.Button();
            this.btnsangtrai = new System.Windows.Forms.Button();
            this.btnallsangphai = new System.Windows.Forms.Button();
            this.btnallsangtrai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listbandau);
            this.groupBox1.Location = new System.Drawing.Point(57, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // listbandau
            // 
            this.listbandau.FormattingEnabled = true;
            this.listbandau.Location = new System.Drawing.Point(5, 18);
            this.listbandau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listbandau.Name = "listbandau";
            this.listbandau.Size = new System.Drawing.Size(210, 277);
            this.listbandau.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listketqua);
            this.groupBox2.Location = new System.Drawing.Point(416, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(220, 306);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // listketqua
            // 
            this.listketqua.FormattingEnabled = true;
            this.listketqua.Location = new System.Drawing.Point(5, 18);
            this.listketqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listketqua.Name = "listketqua";
            this.listketqua.Size = new System.Drawing.Size(211, 277);
            this.listketqua.TabIndex = 0;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(475, 69);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(68, 19);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnsangphai
            // 
            this.btnsangphai.Location = new System.Drawing.Point(280, 206);
            this.btnsangphai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsangphai.Name = "btnsangphai";
            this.btnsangphai.Size = new System.Drawing.Size(56, 19);
            this.btnsangphai.TabIndex = 3;
            this.btnsangphai.Text = ">";
            this.btnsangphai.UseVisualStyleBackColor = true;
            this.btnsangphai.Click += new System.EventHandler(this.btnsangphai_Click);
            // 
            // btnsangtrai
            // 
            this.btnsangtrai.Location = new System.Drawing.Point(356, 206);
            this.btnsangtrai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsangtrai.Name = "btnsangtrai";
            this.btnsangtrai.Size = new System.Drawing.Size(56, 19);
            this.btnsangtrai.TabIndex = 4;
            this.btnsangtrai.Text = "<";
            this.btnsangtrai.UseVisualStyleBackColor = true;
            this.btnsangtrai.Click += new System.EventHandler(this.btnsangtrai_Click);
            // 
            // btnallsangphai
            // 
            this.btnallsangphai.Location = new System.Drawing.Point(280, 248);
            this.btnallsangphai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnallsangphai.Name = "btnallsangphai";
            this.btnallsangphai.Size = new System.Drawing.Size(56, 19);
            this.btnallsangphai.TabIndex = 5;
            this.btnallsangphai.Text = ">>";
            this.btnallsangphai.UseVisualStyleBackColor = true;
            this.btnallsangphai.Click += new System.EventHandler(this.btnallsangphai_Click);
            // 
            // btnallsangtrai
            // 
            this.btnallsangtrai.Location = new System.Drawing.Point(356, 248);
            this.btnallsangtrai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnallsangtrai.Name = "btnallsangtrai";
            this.btnallsangtrai.Size = new System.Drawing.Size(56, 19);
            this.btnallsangtrai.TabIndex = 6;
            this.btnallsangtrai.Text = "<<";
            this.btnallsangtrai.UseVisualStyleBackColor = true;
            this.btnallsangtrai.Click += new System.EventHandler(this.btnallsangtrai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(133, 440);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(505, 440);
            this.btnketthuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(56, 19);
            this.btnketthuc.TabIndex = 8;
            this.btnketthuc.Text = "Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(237, 70);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(216, 20);
            this.txthoten.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ và Tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnallsangtrai);
            this.Controls.Add(this.btnallsangphai);
            this.Controls.Add(this.btnsangtrai);
            this.Controls.Add(this.btnsangphai);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listbandau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listketqua;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnsangphai;
        private System.Windows.Forms.Button btnsangtrai;
        private System.Windows.Forms.Button btnallsangphai;
        private System.Windows.Forms.Button btnallsangtrai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
    }
}

