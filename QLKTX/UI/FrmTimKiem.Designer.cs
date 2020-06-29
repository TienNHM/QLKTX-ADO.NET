namespace QLKTX.UI
{
    partial class FrmTimKiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnInput = new System.Windows.Forms.Panel();
            this.pnKey = new System.Windows.Forms.Panel();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMucTimKiem = new System.Windows.Forms.ComboBox();
            this.lbMuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPhanLoai = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnPhieuDK = new System.Windows.Forms.Button();
            this.lbPhanLoai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnTop.SuspendLayout();
            this.pnInput.SuspendLayout();
            this.pnKey.SuspendLayout();
            this.pnPhanLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Location = new System.Drawing.Point(950, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.SystemColors.Control;
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPhong.Location = new System.Drawing.Point(475, 0);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(90, 32);
            this.btnPhong.TabIndex = 2;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.TimTheoLoai_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.SystemColors.Control;
            this.btnSinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSinhVien.Location = new System.Drawing.Point(295, 0);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(90, 32);
            this.btnSinhVien.TabIndex = 3;
            this.btnSinhVien.Text = "Sinh viên";
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.TimTheoLoai_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Indigo;
            this.btnNhanVien.Location = new System.Drawing.Point(385, 0);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(90, 32);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.TimTheoLoai_Click);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.pnInput);
            this.pnTop.Controls.Add(this.pnPhanLoai);
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 50);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1064, 109);
            this.pnTop.TabIndex = 6;
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.pnKey);
            this.pnInput.Controls.Add(this.cmbMucTimKiem);
            this.pnInput.Controls.Add(this.lbMuc);
            this.pnInput.Controls.Add(this.btnSearch);
            this.pnInput.Controls.Add(this.label1);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInput.Location = new System.Drawing.Point(0, 44);
            this.pnInput.Name = "pnInput";
            this.pnInput.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnInput.Size = new System.Drawing.Size(1064, 61);
            this.pnInput.TabIndex = 7;
            // 
            // pnKey
            // 
            this.pnKey.Controls.Add(this.txtPhong);
            this.pnKey.Controls.Add(this.label4);
            this.pnKey.Controls.Add(this.txtKhu);
            this.pnKey.Controls.Add(this.label3);
            this.pnKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnKey.Location = new System.Drawing.Point(300, 27);
            this.pnKey.Name = "pnKey";
            this.pnKey.Size = new System.Drawing.Size(630, 26);
            this.pnKey.TabIndex = 11;
            this.pnKey.Visible = false;
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhong.Location = new System.Drawing.Point(389, 0);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(150, 25);
            this.txtPhong.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.label4.Location = new System.Drawing.Point(296, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã phòng: ";
            // 
            // txtKhu
            // 
            this.txtKhu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKhu.Location = new System.Drawing.Point(91, 0);
            this.txtKhu.Name = "txtKhu";
            this.txtKhu.Size = new System.Drawing.Size(150, 25);
            this.txtKhu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMucTimKiem
            // 
            this.cmbMucTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMucTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMucTimKiem.FormattingEnabled = true;
            this.cmbMucTimKiem.Location = new System.Drawing.Point(24, 28);
            this.cmbMucTimKiem.Name = "cmbMucTimKiem";
            this.cmbMucTimKiem.Size = new System.Drawing.Size(241, 25);
            this.cmbMucTimKiem.TabIndex = 10;
            this.cmbMucTimKiem.SelectedIndexChanged += new System.EventHandler(this.cmbMucTimKiem_SelectedIndexChanged);
            // 
            // lbMuc
            // 
            this.lbMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbMuc.Location = new System.Drawing.Point(24, 4);
            this.lbMuc.Name = "lbMuc";
            this.lbMuc.Size = new System.Drawing.Size(163, 26);
            this.lbMuc.TabIndex = 9;
            this.lbMuc.Text = "Tìm kiếm theo mục:";
            this.lbMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(297, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nội dung tìm kiếm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnPhanLoai
            // 
            this.pnPhanLoai.Controls.Add(this.btnHoaDon);
            this.pnPhanLoai.Controls.Add(this.btnPhieuDK);
            this.pnPhanLoai.Controls.Add(this.btnPhong);
            this.pnPhanLoai.Controls.Add(this.btnNhanVien);
            this.pnPhanLoai.Controls.Add(this.btnSinhVien);
            this.pnPhanLoai.Controls.Add(this.lbPhanLoai);
            this.pnPhanLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPhanLoai.Location = new System.Drawing.Point(0, 12);
            this.pnPhanLoai.Name = "pnPhanLoai";
            this.pnPhanLoai.Size = new System.Drawing.Size(1064, 32);
            this.pnPhanLoai.TabIndex = 6;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.DeepPink;
            this.btnHoaDon.Location = new System.Drawing.Point(655, 0);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(90, 32);
            this.btnHoaDon.TabIndex = 8;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.TimTheoLoai_Click);
            // 
            // btnPhieuDK
            // 
            this.btnPhieuDK.BackColor = System.Drawing.SystemColors.Control;
            this.btnPhieuDK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhieuDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuDK.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnPhieuDK.Location = new System.Drawing.Point(565, 0);
            this.btnPhieuDK.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPhieuDK.Name = "btnPhieuDK";
            this.btnPhieuDK.Size = new System.Drawing.Size(90, 32);
            this.btnPhieuDK.TabIndex = 9;
            this.btnPhieuDK.Text = "Phiếu ĐK";
            this.btnPhieuDK.UseVisualStyleBackColor = false;
            this.btnPhieuDK.Click += new System.EventHandler(this.TimTheoLoai_Click);
            // 
            // lbPhanLoai
            // 
            this.lbPhanLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbPhanLoai.Location = new System.Drawing.Point(0, 0);
            this.lbPhanLoai.Name = "lbPhanLoai";
            this.lbPhanLoai.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lbPhanLoai.Size = new System.Drawing.Size(295, 32);
            this.lbPhanLoai.TabIndex = 7;
            this.lbPhanLoai.Text = "Loại thông tin tìm kiếm:";
            this.lbPhanLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 12);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1064, 50);
            this.label2.TabIndex = 7;
            this.label2.Text = "TÌM THÔNG TIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.Location = new System.Drawing.Point(0, 159);
            this.dgv.Margin = new System.Windows.Forms.Padding(10);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Size = new System.Drawing.Size(1064, 522);
            this.dgv.TabIndex = 10;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FrmTimKiem
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "FrmTimKiem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.pnTop.ResumeLayout(false);
            this.pnInput.ResumeLayout(false);
            this.pnKey.ResumeLayout(false);
            this.pnKey.PerformLayout();
            this.pnPhanLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPhanLoai;
        private System.Windows.Forms.Label lbPhanLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnPhieuDK;
        private System.Windows.Forms.ComboBox cmbMucTimKiem;
        private System.Windows.Forms.Label lbMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnKey;
        private System.Windows.Forms.TextBox txtKhu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DataGridView dgv;
    }
}