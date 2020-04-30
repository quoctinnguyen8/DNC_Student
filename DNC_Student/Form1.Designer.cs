namespace DNC_Student
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
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnTruyCap = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picSinhVien = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTinChiNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTichLuy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNganhHoc = new System.Windows.Forms.TextBox();
            this.linkChiTiet = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.cboTrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(12, 40);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(180, 22);
            this.txtMSSV.TabIndex = 0;
            // 
            // btnTruyCap
            // 
            this.btnTruyCap.Location = new System.Drawing.Point(12, 195);
            this.btnTruyCap.Name = "btnTruyCap";
            this.btnTruyCap.Size = new System.Drawing.Size(94, 38);
            this.btnTruyCap.TabIndex = 1;
            this.btnTruyCap.Text = "Tra cứu";
            this.btnTruyCap.UseVisualStyleBackColor = true;
            this.btnTruyCap.Click += new System.EventHandler(this.btnTruyCap_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(860, 457);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(196, 122);
            this.txtKetQua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(735, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(155, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã số sinh viên";
            // 
            // picSinhVien
            // 
            this.picSinhVien.Location = new System.Drawing.Point(6, 20);
            this.picSinhVien.Name = "picSinhVien";
            this.picSinhVien.Size = new System.Drawing.Size(134, 168);
            this.picSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSinhVien.TabIndex = 8;
            this.picSinhVien.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(580, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 195);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(898, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(901, 40);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(155, 22);
            this.txtSoTinChi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(898, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số tín chỉ nợ";
            // 
            // txtSoTinChiNo
            // 
            this.txtSoTinChiNo.Location = new System.Drawing.Point(901, 94);
            this.txtSoTinChiNo.Name = "txtSoTinChiNo";
            this.txtSoTinChiNo.ReadOnly = true;
            this.txtSoTinChiNo.Size = new System.Drawing.Size(155, 22);
            this.txtSoTinChiNo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(898, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "TB chung tich lũy";
            // 
            // txtTichLuy
            // 
            this.txtTichLuy.Location = new System.Drawing.Point(901, 144);
            this.txtTichLuy.Name = "txtTichLuy";
            this.txtTichLuy.ReadOnly = true;
            this.txtTichLuy.Size = new System.Drawing.Size(155, 22);
            this.txtTichLuy.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(732, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(735, 94);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(155, 22);
            this.txtTinhTrang.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(735, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lớp";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(735, 144);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(155, 22);
            this.txtLop.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(735, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngành học";
            // 
            // txtNganhHoc
            // 
            this.txtNganhHoc.Location = new System.Drawing.Point(735, 192);
            this.txtNganhHoc.Name = "txtNganhHoc";
            this.txtNganhHoc.ReadOnly = true;
            this.txtNganhHoc.Size = new System.Drawing.Size(155, 22);
            this.txtNganhHoc.TabIndex = 21;
            // 
            // linkChiTiet
            // 
            this.linkChiTiet.AutoSize = true;
            this.linkChiTiet.Location = new System.Drawing.Point(903, 195);
            this.linkChiTiet.Name = "linkChiTiet";
            this.linkChiTiet.Size = new System.Drawing.Size(81, 17);
            this.linkChiTiet.TabIndex = 22;
            this.linkChiTiet.TabStop = true;
            this.linkChiTiet.Text = "Xem chi tiết";
            this.linkChiTiet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChiTiet_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(13, 94);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(179, 22);
            this.txtMaLop.TabIndex = 24;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.AllowUserToAddRows = false;
            this.dataGridViewSinhVien.AllowUserToDeleteRows = false;
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.HoTen,
            this.Key});
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(12, 269);
            this.dataGridViewSinhVien.MultiSelect = false;
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.ReadOnly = true;
            this.dataGridViewSinhVien.RowTemplate.Height = 24;
            this.dataGridViewSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(614, 310);
            this.dataGridViewSinhVien.TabIndex = 25;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);
            this.dataGridViewSinhVien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSinhVien_RowHeaderMouseClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 250;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(12, 144);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(177, 22);
            this.txtTenSinhVien.TabIndex = 27;
            // 
            // cboTrang
            // 
            this.cboTrang.FormattingEnabled = true;
            this.cboTrang.Location = new System.Drawing.Point(539, 239);
            this.cboTrang.Name = "cboTrang";
            this.cboTrang.Size = new System.Drawing.Size(87, 24);
            this.cboTrang.TabIndex = 28;
            this.cboTrang.SelectedIndexChanged += new System.EventHandler(this.cboTrang_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Trang hiện tại";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTruyCap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 591);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboTrang);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linkChiTiet);
            this.Controls.Add(this.txtNganhHoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTichLuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoTinChiNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTruyCap);
            this.Controls.Add(this.txtMSSV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm sinh viên DNC";
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnTruyCap;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTinChiNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTichLuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNganhHoc;
        private System.Windows.Forms.LinkLabel linkChiTiet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.ComboBox cboTrang;
        private System.Windows.Forms.Label label11;
    }
}

