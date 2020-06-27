namespace QLKTX.UI
{
    partial class FrmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbTenDV = new System.Windows.Forms.ComboBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTenDV = new System.Windows.Forms.Label();
            this.pnContainerBottom = new System.Windows.Forms.Panel();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.pnContainerTop = new System.Windows.Forms.Panel();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.dtNgayHD = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.cmbKhu = new System.Windows.Forms.ComboBox();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lbKhu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTop.SuspendLayout();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnContainerBottom.SuspendLayout();
            this.pnContainerTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Goldenrod;
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(584, 45);
            this.pnTop.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(584, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "THÔNG TIN HÓA ĐƠN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.dgvHoaDon);
            this.pnContainer.Controls.Add(this.panel1);
            this.pnContainer.Controls.Add(this.pnContainerBottom);
            this.pnContainer.Controls.Add(this.pnContainerTop);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 45);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(584, 516);
            this.pnContainer.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.SoLuong,
            this.DonViTinh});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 212);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(584, 259);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lbDonVi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.cmbTenDV);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.lbTenDV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 94);
            this.panel1.TabIndex = 3;
            // 
            // lbDonVi
            // 
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbDonVi.Location = new System.Drawing.Point(127, 68);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(303, 23);
            this.lbDonVi.TabIndex = 17;
            this.lbDonVi.Text = "Đơn vị tính: ";
            this.lbDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Location = new System.Drawing.Point(460, 44);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 27);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Location = new System.Drawing.Point(460, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 27);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.numSoLuong.Location = new System.Drawing.Point(127, 42);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(303, 23);
            this.numSoLuong.TabIndex = 16;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTenDV
            // 
            this.cmbTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbTenDV.FormattingEnabled = true;
            this.cmbTenDV.Location = new System.Drawing.Point(127, 10);
            this.cmbTenDV.Name = "cmbTenDV";
            this.cmbTenDV.Size = new System.Drawing.Size(303, 24);
            this.cmbTenDV.TabIndex = 15;
            this.cmbTenDV.SelectedIndexChanged += new System.EventHandler(this.cmbTenDV_SelectedIndexChanged);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbSoLuong.Location = new System.Drawing.Point(38, 44);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(72, 17);
            this.lbSoLuong.TabIndex = 14;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbTenDV
            // 
            this.lbTenDV.AutoSize = true;
            this.lbTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbTenDV.Location = new System.Drawing.Point(38, 13);
            this.lbTenDV.Name = "lbTenDV";
            this.lbTenDV.Size = new System.Drawing.Size(62, 17);
            this.lbTenDV.TabIndex = 13;
            this.lbTenDV.Text = "Dịch vụ";
            // 
            // pnContainerBottom
            // 
            this.pnContainerBottom.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnContainerBottom.Controls.Add(this.btnHoanTat);
            this.pnContainerBottom.Controls.Add(this.btnInHoaDon);
            this.pnContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnContainerBottom.Location = new System.Drawing.Point(0, 471);
            this.pnContainerBottom.Name = "pnContainerBottom";
            this.pnContainerBottom.Size = new System.Drawing.Size(584, 45);
            this.pnContainerBottom.TabIndex = 2;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHoanTat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTat.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnHoanTat.Location = new System.Drawing.Point(0, 0);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(146, 45);
            this.btnHoanTat.TabIndex = 0;
            this.btnHoanTat.Text = "HOÀN TẤT";
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Orange;
            this.btnInHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInHoaDon.Enabled = false;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Location = new System.Drawing.Point(438, 0);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(146, 45);
            this.btnInHoaDon.TabIndex = 1;
            this.btnInHoaDon.Text = "IN HOÁ ĐƠN";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // pnContainerTop
            // 
            this.pnContainerTop.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnContainerTop.Controls.Add(this.txtNamHoc);
            this.pnContainerTop.Controls.Add(this.dtNgayHD);
            this.pnContainerTop.Controls.Add(this.txtMaNV);
            this.pnContainerTop.Controls.Add(this.txtThang);
            this.pnContainerTop.Controls.Add(this.lbNhanVien);
            this.pnContainerTop.Controls.Add(this.lbNgay);
            this.pnContainerTop.Controls.Add(this.label2);
            this.pnContainerTop.Controls.Add(this.cmbPhong);
            this.pnContainerTop.Controls.Add(this.cmbKhu);
            this.pnContainerTop.Controls.Add(this.lbPhong);
            this.pnContainerTop.Controls.Add(this.lbKhu);
            this.pnContainerTop.Controls.Add(this.label1);
            this.pnContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainerTop.Location = new System.Drawing.Point(0, 0);
            this.pnContainerTop.Name = "pnContainerTop";
            this.pnContainerTop.Size = new System.Drawing.Size(584, 118);
            this.pnContainerTop.TabIndex = 1;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.Location = new System.Drawing.Point(225, 81);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(145, 25);
            this.txtNamHoc.TabIndex = 17;
            // 
            // dtNgayHD
            // 
            this.dtNgayHD.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtNgayHD.Enabled = false;
            this.dtNgayHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayHD.Location = new System.Drawing.Point(27, 81);
            this.dtNgayHD.Name = "dtNgayHD";
            this.dtNgayHD.Size = new System.Drawing.Size(163, 25);
            this.dtNgayHD.TabIndex = 13;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(27, 28);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(163, 25);
            this.txtMaNV.TabIndex = 11;
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(225, 28);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(145, 25);
            this.txtThang.TabIndex = 16;
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(28, 11);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(71, 17);
            this.lbNhanVien.TabIndex = 10;
            this.lbNhanVien.Text = "Nhân viên";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(28, 61);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(114, 17);
            this.lbNgay.TabIndex = 12;
            this.lbNgay.Text = "Ngày lập hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Năm học";
            // 
            // cmbPhong
            // 
            this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(408, 81);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(145, 25);
            this.cmbPhong.TabIndex = 9;
            // 
            // cmbKhu
            // 
            this.cmbKhu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhu.FormattingEnabled = true;
            this.cmbKhu.Location = new System.Drawing.Point(408, 28);
            this.cmbKhu.Name = "cmbKhu";
            this.cmbKhu.Size = new System.Drawing.Size(145, 25);
            this.cmbKhu.TabIndex = 8;
            this.cmbKhu.SelectedIndexChanged += new System.EventHandler(this.cmbKhu_SelectedIndexChanged);
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(411, 61);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(46, 17);
            this.lbPhong.TabIndex = 1;
            this.lbPhong.Text = "Phòng";
            // 
            // lbKhu
            // 
            this.lbKhu.AutoSize = true;
            this.lbKhu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhu.Location = new System.Drawing.Point(411, 11);
            this.lbKhu.Name = "lbKhu";
            this.lbKhu.Size = new System.Drawing.Size(32, 17);
            this.lbKhu.TabIndex = 0;
            this.lbKhu.Text = "Khu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tháng";
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MaDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaDV.HeaderText = "Mã dịch vụ";
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TenDV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DonViTinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnTop);
            this.DoubleBuffered = true;
            this.Name = "FrmHoaDon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.pnTop.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnContainerBottom.ResumeLayout(false);
            this.pnContainerTop.ResumeLayout(false);
            this.pnContainerTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Panel pnContainerBottom;
        private System.Windows.Forms.Panel pnContainerTop;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.ComboBox cmbKhu;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbKhu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cmbTenDV;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTenDV;
        private System.Windows.Forms.DateTimePicker dtNgayHD;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
    }
}