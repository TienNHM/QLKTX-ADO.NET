namespace QLKTX.UI
{
    partial class FrmBaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYKTXDataSet = new QLKTX.QUANLYKTXDataSet();
            this.pHIEUDKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.sINHVIENTableAdapter = new QLKTX.QUANLYKTXDataSetTableAdapters.SINHVIENTableAdapter();
            this.nHANVIENTableAdapter = new QLKTX.QUANLYKTXDataSetTableAdapters.NHANVIENTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.PHIEUDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDKTableAdapter = new QLKTX.QUANLYKTXDataSetTableAdapters.PHIEUDKTableAdapter();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.rvPhong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.rvNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.rvSinhVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKTXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUDKBindingSource)).BeginInit();
            this.tabPhong.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabSinhVien.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // NHANVIENBindingSource
            // 
            this.NHANVIENBindingSource.DataMember = "NHANVIEN";
            this.NHANVIENBindingSource.DataSource = this.qUANLYKTXDataSet;
            // 
            // qUANLYKTXDataSet
            // 
            this.qUANLYKTXDataSet.DataSetName = "QUANLYKTXDataSet";
            this.qUANLYKTXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUDKBindingSource1
            // 
            this.pHIEUDKBindingSource1.DataMember = "PHIEUDK";
            this.pHIEUDKBindingSource1.DataSource = this.qUANLYKTXDataSet;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qUANLYKTXDataSet;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Goldenrod;
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1064, 45);
            this.pnTop.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1064, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "BÁO CÁO";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 639);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Azure;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Navy;
            this.btnCreate.Location = new System.Drawing.Point(449, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(166, 33);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "TẠO BÁO CÁO";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PHIEUDKBindingSource
            // 
            this.PHIEUDKBindingSource.DataMember = "PHIEUDK";
            this.PHIEUDKBindingSource.DataSource = this.qUANLYKTXDataSet;
            // 
            // pHIEUDKTableAdapter
            // 
            this.pHIEUDKTableAdapter.ClearBeforeFill = true;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.rvPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(1056, 564);
            this.tabPhong.TabIndex = 2;
            this.tabPhong.Text = "Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // rvPhong
            // 
            this.rvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDangKyPhong";
            reportDataSource1.Value = this.pHIEUDKBindingSource1;
            this.rvPhong.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPhong.LocalReport.ReportEmbeddedResource = "QLKTX.Reports.ReportDangKyPhong.rdlc";
            this.rvPhong.Location = new System.Drawing.Point(3, 3);
            this.rvPhong.Name = "rvPhong";
            this.rvPhong.ServerReport.BearerToken = null;
            this.rvPhong.Size = new System.Drawing.Size(1050, 558);
            this.rvPhong.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.rvNhanVien);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 26);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1056, 564);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // rvNhanVien
            // 
            this.rvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetNhanVien";
            reportDataSource2.Value = this.NHANVIENBindingSource;
            this.rvNhanVien.LocalReport.DataSources.Add(reportDataSource2);
            this.rvNhanVien.LocalReport.ReportEmbeddedResource = "QLKTX.Reports.ReportNhanVien.rdlc";
            this.rvNhanVien.Location = new System.Drawing.Point(3, 3);
            this.rvNhanVien.Name = "rvNhanVien";
            this.rvNhanVien.ServerReport.BearerToken = null;
            this.rvNhanVien.Size = new System.Drawing.Size(1050, 558);
            this.rvNhanVien.TabIndex = 0;
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Controls.Add(this.rvSinhVien);
            this.tabSinhVien.Location = new System.Drawing.Point(4, 26);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinhVien.Size = new System.Drawing.Size(1056, 564);
            this.tabSinhVien.TabIndex = 0;
            this.tabSinhVien.Text = "Sinh viên";
            this.tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // rvSinhVien
            // 
            this.rvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetSinhVien";
            reportDataSource3.Value = this.sINHVIENBindingSource;
            this.rvSinhVien.LocalReport.DataSources.Add(reportDataSource3);
            this.rvSinhVien.LocalReport.ReportEmbeddedResource = "QLKTX.Reports.ReportSinhVien.rdlc";
            this.rvSinhVien.Location = new System.Drawing.Point(3, 3);
            this.rvSinhVien.Name = "rvSinhVien";
            this.rvSinhVien.ServerReport.BearerToken = null;
            this.rvSinhVien.Size = new System.Drawing.Size(1050, 558);
            this.rvSinhVien.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSinhVien);
            this.tabControl.Controls.Add(this.tabNhanVien);
            this.tabControl.Controls.Add(this.tabPhong);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1064, 594);
            this.tabControl.TabIndex = 2;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTop);
            this.DoubleBuffered = true;
            this.Name = "FrmBaoCao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKTXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUDKBindingSource)).EndInit();
            this.tabPhong.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.tabSinhVien.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private QUANLYKTXDataSet qUANLYKTXDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QUANLYKTXDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private QUANLYKTXDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource PHIEUDKBindingSource;
        private System.Windows.Forms.BindingSource pHIEUDKBindingSource1;
        private QUANLYKTXDataSetTableAdapters.PHIEUDKTableAdapter pHIEUDKTableAdapter;
        private System.Windows.Forms.TabPage tabPhong;
        private Microsoft.Reporting.WinForms.ReportViewer rvPhong;
        private System.Windows.Forms.TabPage tabNhanVien;
        private Microsoft.Reporting.WinForms.ReportViewer rvNhanVien;
        private System.Windows.Forms.TabPage tabSinhVien;
        private Microsoft.Reporting.WinForms.ReportViewer rvSinhVien;
        private System.Windows.Forms.TabControl tabControl;
    }
}