using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.UI
{
    public partial class FrmInHoaDon : Form
    {
        string MaHD = "";
        public FrmInHoaDon()
        {
            InitializeComponent();
        }

        public FrmInHoaDon(string MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD.Trim();
            txtMaHD.Text = MaHD.Trim();
        }

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            if (MaHD != "")
            {
                select_Para_ChiTietHoaDonTableAdapter.Fill(qUANLYKTXDataSet.Select_Para_ChiTietHoaDon, Convert.ToInt32(txtMaHD.Text.Trim()));
                this.reportViewer1.RefreshReport();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "") 
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
                return;
            }                
            select_Para_ChiTietHoaDonTableAdapter.Fill(qUANLYKTXDataSet.Select_Para_ChiTietHoaDon, Convert.ToInt32(txtMaHD.Text.Trim()));
            this.reportViewer1.RefreshReport();
        }
    }
}
