using Telerik.WinControls.UI;

namespace DNC_Student
{
    partial class FromDNC
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromDNC));
            this.txtMSSV_Input = new Telerik.WinControls.UI.RadTextBox();
            this.btnTruyCap = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picSinhVien = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTinChiNo = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTichLuy = new Telerik.WinControls.UI.RadTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new Telerik.WinControls.UI.RadTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLop = new Telerik.WinControls.UI.RadTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNganhHoc = new Telerik.WinControls.UI.RadTextBox();
            this.linkChiTiet = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaLop_Input = new Telerik.WinControls.UI.RadTextBox();
            this.dataGridViewSinhVien = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSinhVien_Input = new Telerik.WinControls.UI.RadTextBox();
            this.cboPages = new Telerik.WinControls.UI.RadDropDownList();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.groupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.linkLichHoc = new System.Windows.Forms.LinkLabel();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTruyCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTinChiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTichLuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganhHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSinhVien_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSSV_Input
            // 
            this.txtMSSV_Input.Location = new System.Drawing.Point(6, 52);
            this.txtMSSV_Input.Name = "txtMSSV_Input";
            this.txtMSSV_Input.Size = new System.Drawing.Size(190, 26);
            this.txtMSSV_Input.TabIndex = 0;
            this.txtMSSV_Input.ThemeName = "Crystal";
            // 
            // btnTruyCap
            // 
            this.btnTruyCap.Location = new System.Drawing.Point(6, 191);
            this.btnTruyCap.Name = "btnTruyCap";
            this.btnTruyCap.Size = new System.Drawing.Size(189, 45);
            this.btnTruyCap.TabIndex = 3;
            this.btnTruyCap.Text = "Tra cứu";
            this.btnTruyCap.ThemeName = "Crystal";
            this.btnTruyCap.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtHoTen.Location = new System.Drawing.Point(162, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(155, 26);
            this.txtHoTen.TabIndex = 14;
            this.txtHoTen.TabStop = false;
            this.txtHoTen.ThemeName = "Crystal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã số sinh viên";
            // 
            // picSinhVien
            // 
            this.picSinhVien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picSinhVien.Location = new System.Drawing.Point(6, 37);
            this.picSinhVien.Name = "picSinhVien";
            this.picSinhVien.Size = new System.Drawing.Size(147, 193);
            this.picSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSinhVien.TabIndex = 8;
            this.picSinhVien.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoTinChi.Location = new System.Drawing.Point(328, 52);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(155, 26);
            this.txtSoTinChi.TabIndex = 10;
            this.txtSoTinChi.TabStop = false;
            this.txtSoTinChi.ThemeName = "Crystal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số tín chỉ nợ";
            // 
            // txtSoTinChiNo
            // 
            this.txtSoTinChiNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoTinChiNo.Location = new System.Drawing.Point(328, 106);
            this.txtSoTinChiNo.Name = "txtSoTinChiNo";
            this.txtSoTinChiNo.ReadOnly = true;
            this.txtSoTinChiNo.Size = new System.Drawing.Size(155, 26);
            this.txtSoTinChiNo.TabIndex = 9;
            this.txtSoTinChiNo.TabStop = false;
            this.txtSoTinChiNo.ThemeName = "Crystal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "TB chung tích lũy";
            // 
            // txtTichLuy
            // 
            this.txtTichLuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTichLuy.Location = new System.Drawing.Point(328, 156);
            this.txtTichLuy.Name = "txtTichLuy";
            this.txtTichLuy.ReadOnly = true;
            this.txtTichLuy.Size = new System.Drawing.Size(155, 26);
            this.txtTichLuy.TabIndex = 8;
            this.txtTichLuy.TabStop = false;
            this.txtTichLuy.ThemeName = "Crystal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTinhTrang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTinhTrang.Location = new System.Drawing.Point(162, 106);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(155, 26);
            this.txtTinhTrang.TabIndex = 13;
            this.txtTinhTrang.TabStop = false;
            this.txtTinhTrang.ThemeName = "Crystal";
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.txtTinhTrang_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Lớp";
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLop.Location = new System.Drawing.Point(162, 156);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(155, 26);
            this.txtLop.TabIndex = 12;
            this.txtLop.TabStop = false;
            this.txtLop.ThemeName = "Crystal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngành học";
            // 
            // txtNganhHoc
            // 
            this.txtNganhHoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNganhHoc.Location = new System.Drawing.Point(162, 204);
            this.txtNganhHoc.Name = "txtNganhHoc";
            this.txtNganhHoc.ReadOnly = true;
            this.txtNganhHoc.Size = new System.Drawing.Size(155, 26);
            this.txtNganhHoc.TabIndex = 11;
            this.txtNganhHoc.TabStop = false;
            this.txtNganhHoc.ThemeName = "Crystal";
            // 
            // linkChiTiet
            // 
            this.linkChiTiet.AutoSize = true;
            this.linkChiTiet.Location = new System.Drawing.Point(330, 207);
            this.linkChiTiet.Name = "linkChiTiet";
            this.linkChiTiet.Size = new System.Drawing.Size(58, 19);
            this.linkChiTiet.TabIndex = 7;
            this.linkChiTiet.TabStop = true;
            this.linkChiTiet.Text = "Chi tiết";
            this.linkChiTiet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChiTiet_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã lớp";
            // 
            // txtMaLop_Input
            // 
            this.txtMaLop_Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaLop_Input.Location = new System.Drawing.Point(5, 104);
            this.txtMaLop_Input.Name = "txtMaLop_Input";
            this.txtMaLop_Input.Size = new System.Drawing.Size(189, 26);
            this.txtMaLop_Input.TabIndex = 1;
            this.txtMaLop_Input.ThemeName = "Crystal";
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSinhVien.AutoSizeRows = true;
            this.dataGridViewSinhVien.HideSelection = true;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(12, 312);
            // 
            // 
            // 
            this.dataGridViewSinhVien.MasterTemplate.AllowAddNewRow = false;
            this.dataGridViewSinhVien.MasterTemplate.AllowColumnChooser = false;
            this.dataGridViewSinhVien.MasterTemplate.AllowDeleteRow = false;
            this.dataGridViewSinhVien.MasterTemplate.AllowDragToGroup = false;
            this.dataGridViewSinhVien.MasterTemplate.AllowEditRow = false;
            this.dataGridViewSinhVien.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "STT";
            gridViewTextBoxColumn1.Name = "STT";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 74;
            gridViewTextBoxColumn2.HeaderText = "MSSV";
            gridViewTextBoxColumn2.Name = "MSSV";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 126;
            gridViewTextBoxColumn3.HeaderText = "Họ Tên";
            gridViewTextBoxColumn3.Name = "HoTen";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 284;
            gridViewTextBoxColumn4.HeaderText = "Key";
            gridViewTextBoxColumn4.Name = "Key";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 210;
            this.dataGridViewSinhVien.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dataGridViewSinhVien.MasterTemplate.EnableGrouping = false;
            this.dataGridViewSinhVien.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dataGridViewSinhVien.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.ReadOnly = true;
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(726, 252);
            this.dataGridViewSinhVien.TabIndex = 25;
            this.dataGridViewSinhVien.ThemeName = "Crystal";
            this.dataGridViewSinhVien.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtTenSinhVien_Input
            // 
            this.txtTenSinhVien_Input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTenSinhVien_Input.Location = new System.Drawing.Point(5, 156);
            this.txtTenSinhVien_Input.Name = "txtTenSinhVien_Input";
            this.txtTenSinhVien_Input.Size = new System.Drawing.Size(190, 26);
            this.txtTenSinhVien_Input.TabIndex = 2;
            this.txtTenSinhVien_Input.ThemeName = "Crystal";
            // 
            // cboTrang
            // 
            this.cboPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPages.Location = new System.Drawing.Point(651, 275);
            this.cboPages.MaxDropDownItems = 6;
            this.cboPages.Name = "cboTrang";
            this.cboPages.Size = new System.Drawing.Size(87, 26);
            this.cboPages.TabIndex = 5;
            this.cboPages.ThemeName = "Crystal";
            this.cboPages.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cboTrang_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Trang hiện tại";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox2.Controls.Add(this.txtMaLop_Input);
            this.groupBox2.Controls.Add(this.txtMSSV_Input);
            this.groupBox2.Controls.Add(this.btnTruyCap);
            this.groupBox2.Controls.Add(this.txtTenSinhVien_Input);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.groupBox2.HeaderText = "Thông tin cần tìm";
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 245);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cần tìm";
            this.groupBox2.ThemeName = "Crystal";
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox3.Controls.Add(this.picSinhVien);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSoTinChi);
            this.groupBox3.Controls.Add(this.linkLichHoc);
            this.groupBox3.Controls.Add(this.linkChiTiet);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNganhHoc);
            this.groupBox3.Controls.Add(this.txtSoTinChiNo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtLop);
            this.groupBox3.Controls.Add(this.txtTichLuy);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTinhTrang);
            this.groupBox3.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.groupBox3.HeaderText = "Thông tin chi tiết";
            this.groupBox3.Location = new System.Drawing.Point(248, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 245);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            this.groupBox3.ThemeName = "Crystal";
            // 
            // linkLichHoc
            // 
            this.linkLichHoc.AutoSize = true;
            this.linkLichHoc.Location = new System.Drawing.Point(405, 207);
            this.linkLichHoc.Name = "linkLichHoc";
            this.linkLichHoc.Size = new System.Drawing.Size(69, 19);
            this.linkLichHoc.TabIndex = 8;
            this.linkLichHoc.TabStop = true;
            this.linkLichHoc.Text = "Lịch học";
            this.linkLichHoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLichHoc_LinkClicked);
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTacGia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTacGia.Location = new System.Drawing.Point(8, 275);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(129, 19);
            this.lblTacGia.TabIndex = 30;
            this.lblTacGia.Text = "Thông tin tác giả";
            this.lblTacGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTacGia_MouseClick);
            // 
            // FromDNC
            // 
            this.AcceptButton = this.btnTruyCap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 576);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboPages);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FromDNC";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Xem điểm sinh viên DNC";
            this.ThemeName = "Crystal";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FromDNC_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTruyCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTinChiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTichLuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNganhHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSinhVien_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadTextBox txtMSSV_Input;
        private RadButton btnTruyCap;
        private System.Windows.Forms.Label label1;
        private RadTextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSinhVien;
        private System.Windows.Forms.Label label4;
        private RadTextBox txtSoTinChi;
        private System.Windows.Forms.Label label5;
        private RadTextBox txtSoTinChiNo;
        private System.Windows.Forms.Label label6;
        private RadTextBox txtTichLuy;
        private System.Windows.Forms.Label label7;
        private RadTextBox txtTinhTrang;
        private System.Windows.Forms.Label label8;
        private RadTextBox txtLop;
        private System.Windows.Forms.Label label9;
        private RadTextBox txtNganhHoc;
        private System.Windows.Forms.LinkLabel linkChiTiet;
        private System.Windows.Forms.Label label10;
        private RadTextBox txtMaLop_Input;
        private RadGridView dataGridViewSinhVien;
        private System.Windows.Forms.Label label2;
        private RadTextBox txtTenSinhVien_Input;
        private RadDropDownList cboPages;
        private System.Windows.Forms.Label label11;
        private RadGroupBox groupBox2;
        private RadGroupBox groupBox3;
        private System.Windows.Forms.Label lblTacGia;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.LinkLabel linkLichHoc;
    }
}

