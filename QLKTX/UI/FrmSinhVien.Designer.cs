namespace QLKTX.UI
{
    partial class FrmSinhVien
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMoRong = new System.Windows.Forms.Button();
            this.pnSV = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMoRong = new System.Windows.Forms.Panel();
            this.dgvThanNhan = new System.Windows.Forms.DataGridView();
            this.lbThanNhan = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.ckbNu = new System.Windows.Forms.CheckBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDienSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.txtNgSinh = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbAnhChanDung = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbBHYT = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.pnSV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnMoRong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Location = new System.Drawing.Point(166, 6);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 28);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Crimson;
            this.btnLuu.Location = new System.Drawing.Point(337, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 28);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMoRong
            // 
            this.btnMoRong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoRong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoRong.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMoRong.Location = new System.Drawing.Point(499, 6);
            this.btnMoRong.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMoRong.Size = new System.Drawing.Size(72, 28);
            this.btnMoRong.TabIndex = 28;
            this.btnMoRong.Text = ">>>";
            this.btnMoRong.UseVisualStyleBackColor = true;
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click);
            // 
            // pnSV
            // 
            this.pnSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnSV.Controls.Add(this.pnContainer);
            this.pnSV.Controls.Add(this.panel2);
            this.pnSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSV.Location = new System.Drawing.Point(0, 50);
            this.pnSV.Name = "pnSV";
            this.pnSV.Size = new System.Drawing.Size(724, 328);
            this.pnSV.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnMoRong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 43);
            this.panel2.TabIndex = 29;
            // 
            // pnMoRong
            // 
            this.pnMoRong.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnMoRong.Controls.Add(this.dgvThanNhan);
            this.pnMoRong.Controls.Add(this.lbThanNhan);
            this.pnMoRong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMoRong.Location = new System.Drawing.Point(724, 50);
            this.pnMoRong.Name = "pnMoRong";
            this.pnMoRong.Size = new System.Drawing.Size(0, 328);
            this.pnMoRong.TabIndex = 30;
            this.pnMoRong.Visible = false;
            // 
            // dgvThanNhan
            // 
            this.dgvThanNhan.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvThanNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThanNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanNhan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvThanNhan.Location = new System.Drawing.Point(-310, 40);
            this.dgvThanNhan.Name = "dgvThanNhan";
            this.dgvThanNhan.Size = new System.Drawing.Size(310, 288);
            this.dgvThanNhan.TabIndex = 0;
            // 
            // lbThanNhan
            // 
            this.lbThanNhan.BackColor = System.Drawing.Color.SteelBlue;
            this.lbThanNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbThanNhan.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanNhan.Location = new System.Drawing.Point(0, 0);
            this.lbThanNhan.Name = "lbThanNhan";
            this.lbThanNhan.Size = new System.Drawing.Size(0, 40);
            this.lbThanNhan.TabIndex = 1;
            this.lbThanNhan.Text = "Thân nhân";
            this.lbThanNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.MinimumSize = new System.Drawing.Size(719, 50);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(720, 50);
            this.pnTop.TabIndex = 31;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.MinimumSize = new System.Drawing.Size(724, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(724, 50);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "THÔNG TIN SINH VIÊN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.ckbNu);
            this.pnContainer.Controls.Add(this.btnChoose);
            this.pnContainer.Controls.Add(this.txtQueQuan);
            this.pnContainer.Controls.Add(this.label3);
            this.pnContainer.Controls.Add(this.txtDienSV);
            this.pnContainer.Controls.Add(this.label2);
            this.pnContainer.Controls.Add(this.txtMSSV);
            this.pnContainer.Controls.Add(this.cmbMaLop);
            this.pnContainer.Controls.Add(this.txtCMND);
            this.pnContainer.Controls.Add(this.lbCMND);
            this.pnContainer.Controls.Add(this.txtNgSinh);
            this.pnContainer.Controls.Add(this.lbHoTen);
            this.pnContainer.Controls.Add(this.lbNgaySinh);
            this.pnContainer.Controls.Add(this.lbGioiTinh);
            this.pnContainer.Controls.Add(this.txtHoTen);
            this.pnContainer.Controls.Add(this.picAvt);
            this.pnContainer.Controls.Add(this.txtBHYT);
            this.pnContainer.Controls.Add(this.txtEmail);
            this.pnContainer.Controls.Add(this.txtSDT);
            this.pnContainer.Controls.Add(this.lbAnhChanDung);
            this.pnContainer.Controls.Add(this.lbMaLop);
            this.pnContainer.Controls.Add(this.lbBHYT);
            this.pnContainer.Controls.Add(this.lbEmail);
            this.pnContainer.Controls.Add(this.lbSDT);
            this.pnContainer.Controls.Add(this.lbMSSV);
            this.pnContainer.Location = new System.Drawing.Point(3, 6);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(717, 280);
            this.pnContainer.TabIndex = 30;
            // 
            // ckbNu
            // 
            this.ckbNu.AutoSize = true;
            this.ckbNu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNu.Location = new System.Drawing.Point(102, 155);
            this.ckbNu.Name = "ckbNu";
            this.ckbNu.Size = new System.Drawing.Size(48, 23);
            this.ckbNu.TabIndex = 60;
            this.ckbNu.Text = "Nữ";
            this.ckbNu.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChoose.Location = new System.Drawing.Point(588, 233);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 30);
            this.btnChoose.TabIndex = 59;
            this.btnChoose.Text = "Chọn hình";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.SystemColors.Control;
            this.txtQueQuan.Location = new System.Drawing.Point(102, 240);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(160, 23);
            this.txtQueQuan.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quê quán";
            // 
            // txtDienSV
            // 
            this.txtDienSV.BackColor = System.Drawing.SystemColors.Control;
            this.txtDienSV.Location = new System.Drawing.Point(362, 198);
            this.txtDienSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienSV.Name = "txtDienSV";
            this.txtDienSV.Size = new System.Drawing.Size(160, 23);
            this.txtDienSV.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Diện SV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.BackColor = System.Drawing.SystemColors.Control;
            this.txtMSSV.Location = new System.Drawing.Point(102, 17);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(160, 23);
            this.txtMSSV.TabIndex = 38;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(102, 198);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(160, 23);
            this.cmbMaLop.TabIndex = 46;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.Control;
            this.txtCMND.Location = new System.Drawing.Point(362, 17);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(160, 23);
            this.txtCMND.TabIndex = 44;
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(302, 19);
            this.lbCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(43, 15);
            this.lbCMND.TabIndex = 43;
            this.lbCMND.Text = "CMND";
            // 
            // txtNgSinh
            // 
            this.txtNgSinh.BackColor = System.Drawing.SystemColors.Control;
            this.txtNgSinh.Location = new System.Drawing.Point(102, 110);
            this.txtNgSinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgSinh.Name = "txtNgSinh";
            this.txtNgSinh.Size = new System.Drawing.Size(160, 23);
            this.txtNgSinh.TabIndex = 41;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(32, 66);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(45, 15);
            this.lbHoTen.TabIndex = 37;
            this.lbHoTen.Text = "Họ tên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(32, 113);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(60, 15);
            this.lbNgaySinh.TabIndex = 40;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(32, 158);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(55, 15);
            this.lbGioiTinh.TabIndex = 42;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.txtHoTen.Location = new System.Drawing.Point(102, 63);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 23);
            this.txtHoTen.TabIndex = 39;
            // 
            // picAvt
            // 
            this.picAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvt.Location = new System.Drawing.Point(571, 59);
            this.picAvt.Margin = new System.Windows.Forms.Padding(2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(112, 162);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvt.TabIndex = 52;
            this.picAvt.TabStop = false;
            // 
            // txtBHYT
            // 
            this.txtBHYT.BackColor = System.Drawing.SystemColors.Control;
            this.txtBHYT.Location = new System.Drawing.Point(362, 155);
            this.txtBHYT.Margin = new System.Windows.Forms.Padding(2);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(160, 23);
            this.txtBHYT.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Location = new System.Drawing.Point(362, 110);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 23);
            this.txtEmail.TabIndex = 50;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Control;
            this.txtSDT.Location = new System.Drawing.Point(362, 63);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(160, 23);
            this.txtSDT.TabIndex = 48;
            // 
            // lbAnhChanDung
            // 
            this.lbAnhChanDung.AutoSize = true;
            this.lbAnhChanDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnhChanDung.Location = new System.Drawing.Point(568, 17);
            this.lbAnhChanDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnhChanDung.Name = "lbAnhChanDung";
            this.lbAnhChanDung.Size = new System.Drawing.Size(117, 17);
            this.lbAnhChanDung.TabIndex = 54;
            this.lbAnhChanDung.Text = "Ảnh chân dung";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(32, 201);
            this.lbMaLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(28, 15);
            this.lbMaLop.TabIndex = 45;
            this.lbMaLop.Text = "Lớp";
            // 
            // lbBHYT
            // 
            this.lbBHYT.AutoSize = true;
            this.lbBHYT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBHYT.Location = new System.Drawing.Point(302, 157);
            this.lbBHYT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBHYT.Name = "lbBHYT";
            this.lbBHYT.Size = new System.Drawing.Size(38, 15);
            this.lbBHYT.TabIndex = 51;
            this.lbBHYT.Text = "BHYT";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(302, 112);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 49;
            this.lbEmail.Text = "Email";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(302, 65);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(30, 15);
            this.lbSDT.TabIndex = 47;
            this.lbSDT.Text = "SĐT";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(32, 20);
            this.lbMSSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(40, 15);
            this.lbMSSV.TabIndex = 36;
            this.lbMSSV.Text = "MSSV";
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 378);
            this.Controls.Add(this.pnMoRong);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.pnTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 400);
            this.Name = "FrmSinhVien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh Viên";
            this.pnSV.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnMoRong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMoRong;
        private System.Windows.Forms.Panel pnSV;
        private System.Windows.Forms.Panel pnMoRong;
        private System.Windows.Forms.Label lbThanNhan;
        private System.Windows.Forms.DataGridView dgvThanNhan;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.CheckBox ckbNu;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.TextBox txtNgSinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbAnhChanDung;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbBHYT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbMSSV;
    }
}