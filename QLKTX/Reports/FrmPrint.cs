using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.Reports
{
    public partial class FrmPrint : Form
    {
        DataTable Data = null;

        public FrmPrint(DataTable data)
        {
            InitializeComponent();
            this.Data = data;
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            if (Data == null) return;
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("HÓA ĐƠN", dataSourceValue: Data);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
