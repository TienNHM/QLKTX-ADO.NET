using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKTX;

namespace QLKTX.UI
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYKTXDataSet.PHIEUDK' table. You can move, or remove it, as needed.
            this.pHIEUDKTableAdapter.Fill(this.qUANLYKTXDataSet.PHIEUDK);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYKTXDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qUANLYKTXDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qUANLYKTXDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qUANLYKTXDataSet.SINHVIEN);

            this.rvSinhVien.RefreshReport();
            this.rvNhanVien.RefreshReport();
            this.rvPhong.RefreshReport();
        }
    }
}
