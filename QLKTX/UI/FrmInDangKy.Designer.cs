namespace QLKTX.UI
{
    partial class FrmInDangKy
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.selectParaPDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYKTXDataSet = new QLKTX.QUANLYKTXDataSet();
            this.selectParaChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPhieuDK = new System.Windows.Forms.TabPage();
            this.rvPDK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.rvHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.select_Para_ChiTietHoaDonTableAdapter = new QLKTX.QUANLYKTXDataSetTableAdapters.Select_Para_ChiTietHoaDonTableAdapter();
            this.Select_Para_PDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.select_Para_PDKTableAdapter = new QLKTX.QUANLYKTXDataSetTableAdapters.Select_Para_PDKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.selectParaPDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKTXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParaChiTietHoaDonBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPhieuDK.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Para_PDKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectParaPDKBindingSource
            // 
            this.selectParaPDKBindingSource.DataMember = "Select_Para_PDK";
            this.selectParaPDKBindingSource.DataSource = this.qUANLYKTXDataSet;
            // 
            // qUANLYKTXDataSet
            // 
            this.qUANLYKTXDataSet.DataSetName = "QUANLYKTXDataSet";
            this.qUANLYKTXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectParaChiTietHoaDonBindingSource
            // 
            this.selectParaChiTietHoaDonBindingSource.DataMember = "Select_Para_ChiTietHoaDon";
            this.selectParaChiTietHoaDonBindingSource.DataSource = this.qUANLYKTXDataSet;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Goldenrod;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXuat, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(375, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(313, 36);
            this.txtInput.TabIndex = 1;
            // 
            // btnXuat
            // 
            this.btnXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXuat.Location = new System.Drawing.Point(694, 3);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 37);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "XUẤT";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPhieuDK);
            this.tabControl.Controls.Add(this.tabHoaDon);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1064, 638);
            this.tabControl.TabIndex = 1;
            // 
            // tabPhieuDK
            // 
            this.tabPhieuDK.Controls.Add(this.rvPDK);
            this.tabPhieuDK.Location = new System.Drawing.Point(4, 30);
            this.tabPhieuDK.Name = "tabPhieuDK";
            this.tabPhieuDK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuDK.Size = new System.Drawing.Size(1056, 604);
            this.tabPhieuDK.TabIndex = 0;
            this.tabPhieuDK.Text = "Phiếu đăng ký phòng";
            this.tabPhieuDK.UseVisualStyleBackColor = true;
            // 
            // rvPDK
            // 
            this.rvPDK.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetParaPDK";
            reportDataSource3.Value = this.selectParaPDKBindingSource;
            this.rvPDK.LocalReport.DataSources.Add(reportDataSource3);
            this.rvPDK.LocalReport.ReportEmbeddedResource = "QLKTX.Reports.ReportParaChiTietPhieuDK.rdlc";
            this.rvPDK.Location = new System.Drawing.Point(3, 3);
            this.rvPDK.Name = "rvPDK";
            this.rvPDK.ServerReport.BearerToken = null;
            this.rvPDK.Size = new System.Drawing.Size(1050, 598);
            this.rvPDK.TabIndex = 0;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.rvHoaDon);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 30);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(1056, 604);
            this.tabHoaDon.TabIndex = 1;
            this.tabHoaDon.Text = "Hóa đơn dịch vụ";
            this.tabHoaDon.UseVisualStyleBackColor = true;
            // 
            // rvHoaDon
            // 
            this.rvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSetParaChiTietHoaDon";
            reportDataSource4.Value = this.selectParaChiTietHoaDonBindingSource;
            this.rvHoaDon.LocalReport.DataSources.Add(reportDataSource4);
            this.rvHoaDon.LocalReport.ReportEmbeddedResource = "QLKTX.Reports.ReportParaChiTietHoaDon.rdlc";
            this.rvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.rvHoaDon.Name = "rvHoaDon";
            this.rvHoaDon.ServerReport.BearerToken = null;
            this.rvHoaDon.Size = new System.Drawing.Size(1050, 598);
            this.rvHoaDon.TabIndex = 0;
            // 
            // select_Para_ChiTietHoaDonTableAdapter
            // 
            this.select_Para_ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // Select_Para_PDKBindingSource
            // 
            this.Select_Para_PDKBindingSource.DataMember = "Select_Para_PDK";
            this.Select_Para_PDKBindingSource.DataSource = this.qUANLYKTXDataSet;
            // 
            // select_Para_PDKTableAdapter
            // 
            this.select_Para_PDKTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmInDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In";
            this.Load += new System.EventHandler(this.FrmInDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectParaPDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKTXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectParaChiTietHoaDonBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPhieuDK.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Select_Para_PDKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhieuDK;
        private System.Windows.Forms.TabPage tabHoaDon;
        private Microsoft.Reporting.WinForms.ReportViewer rvHoaDon;
        private System.Windows.Forms.BindingSource selectParaChiTietHoaDonBindingSource;
        private QUANLYKTXDataSet qUANLYKTXDataSet;
        private QUANLYKTXDataSetTableAdapters.Select_Para_ChiTietHoaDonTableAdapter select_Para_ChiTietHoaDonTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvPDK;
        private System.Windows.Forms.BindingSource Select_Para_PDKBindingSource;
        private System.Windows.Forms.BindingSource selectParaPDKBindingSource;
        private QUANLYKTXDataSetTableAdapters.Select_Para_PDKTableAdapter select_Para_PDKTableAdapter;
    }
}