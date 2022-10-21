namespace WindowsFormsApplication1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkhoaitaychien = new System.Windows.Forms.Button();
            this.btncam = new System.Windows.Forms.Button();
            this.btnlipton = new System.Windows.Forms.Button();
            this.btncoca = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnpepsi = new System.Windows.Forms.Button();
            this.btncomga = new System.Windows.Forms.Button();
            this.btngaran = new System.Windows.Forms.Button();
            this.btngavien = new System.Windows.Forms.Button();
            this.btntomvien = new System.Windows.Forms.Button();
            this.btnburgerca = new System.Windows.Forms.Button();
            this.btnburgertom = new System.Windows.Forms.Button();
            this.btnburgerga = new System.Windows.Forms.Button();
            this.btnburgerbo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBtenban = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(249, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "FastFood Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Screenshot__88_;
            this.pictureBox1.Location = new System.Drawing.Point(47, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkhoaitaychien);
            this.groupBox1.Controls.Add(this.btncam);
            this.groupBox1.Controls.Add(this.btnlipton);
            this.groupBox1.Controls.Add(this.btncoca);
            this.groupBox1.Controls.Add(this.btncafe);
            this.groupBox1.Controls.Add(this.btn7up);
            this.groupBox1.Controls.Add(this.btnpepsi);
            this.groupBox1.Controls.Add(this.btncomga);
            this.groupBox1.Controls.Add(this.btngaran);
            this.groupBox1.Controls.Add(this.btngavien);
            this.groupBox1.Controls.Add(this.btntomvien);
            this.groupBox1.Controls.Add(this.btnburgerca);
            this.groupBox1.Controls.Add(this.btnburgertom);
            this.groupBox1.Controls.Add(this.btnburgerga);
            this.groupBox1.Controls.Add(this.btnburgerbo);
            this.groupBox1.Location = new System.Drawing.Point(47, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnkhoaitaychien
            // 
            this.btnkhoaitaychien.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnkhoaitaychien.Location = new System.Drawing.Point(343, 142);
            this.btnkhoaitaychien.Name = "btnkhoaitaychien";
            this.btnkhoaitaychien.Size = new System.Drawing.Size(161, 34);
            this.btnkhoaitaychien.TabIndex = 14;
            this.btnkhoaitaychien.Text = "Khoai tây chiên";
            this.btnkhoaitaychien.UseVisualStyleBackColor = true;
            this.btnkhoaitaychien.Click += new System.EventHandler(this.btnkhoaitaychien_Click);
            // 
            // btncam
            // 
            this.btncam.ForeColor = System.Drawing.Color.Red;
            this.btncam.Location = new System.Drawing.Point(429, 102);
            this.btncam.Name = "btncam";
            this.btncam.Size = new System.Drawing.Size(75, 34);
            this.btncam.TabIndex = 13;
            this.btncam.Text = "Cam";
            this.btncam.UseVisualStyleBackColor = true;
            this.btncam.Click += new System.EventHandler(this.btncam_Click);
            // 
            // btnlipton
            // 
            this.btnlipton.ForeColor = System.Drawing.Color.Red;
            this.btnlipton.Location = new System.Drawing.Point(429, 63);
            this.btnlipton.Name = "btnlipton";
            this.btnlipton.Size = new System.Drawing.Size(75, 33);
            this.btnlipton.TabIndex = 12;
            this.btnlipton.Text = "Lipton";
            this.btnlipton.UseVisualStyleBackColor = true;
            this.btnlipton.Click += new System.EventHandler(this.btnlipton_Click);
            // 
            // btncoca
            // 
            this.btncoca.ForeColor = System.Drawing.Color.Red;
            this.btncoca.Location = new System.Drawing.Point(429, 21);
            this.btncoca.Name = "btncoca";
            this.btncoca.Size = new System.Drawing.Size(75, 34);
            this.btncoca.TabIndex = 11;
            this.btncoca.Text = "Coca";
            this.btncoca.UseVisualStyleBackColor = true;
            this.btncoca.Click += new System.EventHandler(this.btncoca_Click);
            // 
            // btncafe
            // 
            this.btncafe.ForeColor = System.Drawing.Color.Red;
            this.btncafe.Location = new System.Drawing.Point(343, 102);
            this.btncafe.Name = "btncafe";
            this.btncafe.Size = new System.Drawing.Size(75, 34);
            this.btncafe.TabIndex = 10;
            this.btncafe.Text = "Cafe";
            this.btncafe.UseVisualStyleBackColor = true;
            this.btncafe.Click += new System.EventHandler(this.btncafe_Click);
            // 
            // btn7up
            // 
            this.btn7up.ForeColor = System.Drawing.Color.Red;
            this.btn7up.Location = new System.Drawing.Point(343, 62);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(75, 34);
            this.btn7up.TabIndex = 9;
            this.btn7up.Text = "7 up";
            this.btn7up.UseVisualStyleBackColor = true;
            this.btn7up.Click += new System.EventHandler(this.btn7up_Click);
            // 
            // btnpepsi
            // 
            this.btnpepsi.ForeColor = System.Drawing.Color.Red;
            this.btnpepsi.Location = new System.Drawing.Point(343, 22);
            this.btnpepsi.Name = "btnpepsi";
            this.btnpepsi.Size = new System.Drawing.Size(75, 33);
            this.btnpepsi.TabIndex = 8;
            this.btnpepsi.Text = "Pepsi";
            this.btnpepsi.UseVisualStyleBackColor = true;
            this.btnpepsi.Click += new System.EventHandler(this.btnpepsi_Click);
            // 
            // btncomga
            // 
            this.btncomga.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncomga.Location = new System.Drawing.Point(173, 142);
            this.btncomga.Name = "btncomga";
            this.btncomga.Size = new System.Drawing.Size(160, 34);
            this.btncomga.TabIndex = 7;
            this.btncomga.Text = "Cơm gà Tender";
            this.btncomga.UseVisualStyleBackColor = true;
            this.btncomga.Click += new System.EventHandler(this.btncomga_Click);
            // 
            // btngaran
            // 
            this.btngaran.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btngaran.Location = new System.Drawing.Point(173, 102);
            this.btngaran.Name = "btngaran";
            this.btngaran.Size = new System.Drawing.Size(160, 34);
            this.btngaran.TabIndex = 6;
            this.btngaran.Text = "Gà rán phần";
            this.btngaran.UseVisualStyleBackColor = true;
            this.btngaran.Click += new System.EventHandler(this.btngaran_Click);
            // 
            // btngavien
            // 
            this.btngavien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btngavien.Location = new System.Drawing.Point(173, 62);
            this.btngavien.Name = "btngavien";
            this.btngavien.Size = new System.Drawing.Size(160, 34);
            this.btngavien.TabIndex = 5;
            this.btngavien.Text = "Gà viên Cola";
            this.btngavien.UseVisualStyleBackColor = true;
            this.btngavien.Click += new System.EventHandler(this.btngavien_Click);
            // 
            // btntomvien
            // 
            this.btntomvien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btntomvien.Location = new System.Drawing.Point(173, 22);
            this.btntomvien.Name = "btntomvien";
            this.btntomvien.Size = new System.Drawing.Size(160, 34);
            this.btntomvien.TabIndex = 4;
            this.btntomvien.Text = "Tôm viên Cola";
            this.btntomvien.UseVisualStyleBackColor = true;
            this.btntomvien.Click += new System.EventHandler(this.btntomvien_Click);
            // 
            // btnburgerca
            // 
            this.btnburgerca.ForeColor = System.Drawing.Color.Red;
            this.btnburgerca.Location = new System.Drawing.Point(7, 142);
            this.btnburgerca.Name = "btnburgerca";
            this.btnburgerca.Size = new System.Drawing.Size(160, 34);
            this.btnburgerca.TabIndex = 3;
            this.btnburgerca.Text = "burger phô mai ";
            this.btnburgerca.UseVisualStyleBackColor = true;
            this.btnburgerca.Click += new System.EventHandler(this.btnburgerca_Click);
            // 
            // btnburgertom
            // 
            this.btnburgertom.ForeColor = System.Drawing.Color.Red;
            this.btnburgertom.Location = new System.Drawing.Point(7, 102);
            this.btnburgertom.Name = "btnburgertom";
            this.btnburgertom.Size = new System.Drawing.Size(160, 34);
            this.btnburgertom.TabIndex = 2;
            this.btnburgertom.Text = "burger phô mai tôm";
            this.btnburgertom.UseVisualStyleBackColor = true;
            this.btnburgertom.Click += new System.EventHandler(this.btnburgertom_Click);
            // 
            // btnburgerga
            // 
            this.btnburgerga.ForeColor = System.Drawing.Color.Red;
            this.btnburgerga.Location = new System.Drawing.Point(7, 62);
            this.btnburgerga.Name = "btnburgerga";
            this.btnburgerga.Size = new System.Drawing.Size(160, 34);
            this.btnburgerga.TabIndex = 1;
            this.btnburgerga.Text = "gàburger phô mai ";
            this.btnburgerga.UseVisualStyleBackColor = true;
            this.btnburgerga.Click += new System.EventHandler(this.btnburgerga_Click);
            // 
            // btnburgerbo
            // 
            this.btnburgerbo.ForeColor = System.Drawing.Color.Red;
            this.btnburgerbo.Location = new System.Drawing.Point(7, 22);
            this.btnburgerbo.Name = "btnburgerbo";
            this.btnburgerbo.Size = new System.Drawing.Size(160, 33);
            this.btnburgerbo.TabIndex = 0;
            this.btnburgerbo.Text = "burger phô mai bò";
            this.btnburgerbo.UseVisualStyleBackColor = true;
            this.btnburgerbo.Click += new System.EventHandler(this.btnburgerbo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 212);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(47, 412);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(496, 412);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(75, 23);
            this.btnorder.TabIndex = 5;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên bàn";
            // 
            // CBtenban
            // 
            this.CBtenban.FormattingEnabled = true;
            this.CBtenban.Location = new System.Drawing.Point(220, 409);
            this.CBtenban.Name = "CBtenban";
            this.CBtenban.Size = new System.Drawing.Size(218, 24);
            this.CBtenban.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 714);
            this.Controls.Add(this.CBtenban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkhoaitaychien;
        private System.Windows.Forms.Button btncam;
        private System.Windows.Forms.Button btnlipton;
        private System.Windows.Forms.Button btncoca;
        private System.Windows.Forms.Button btncafe;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnpepsi;
        private System.Windows.Forms.Button btncomga;
        private System.Windows.Forms.Button btngaran;
        private System.Windows.Forms.Button btngavien;
        private System.Windows.Forms.Button btntomvien;
        private System.Windows.Forms.Button btnburgerca;
        private System.Windows.Forms.Button btnburgertom;
        private System.Windows.Forms.Button btnburgerga;
        private System.Windows.Forms.Button btnburgerbo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBtenban;
    }
}

