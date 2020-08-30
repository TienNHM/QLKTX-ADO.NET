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
    public partial class FrmInDangKy : Form
    {
        public enum PrintType
        {
            PhieuDK = 0,
            HoaDon,
        }

        private string ID = "";
        private PrintType printType;

        public FrmInDangKy()
        {
            InitializeComponent();
        }

        public FrmInDangKy(PrintType printType, string ID)
        {
            InitializeComponent();
            this.ID = ID.Trim();
            this.printType = printType;
            txtInput.Text = ID.Trim();

            //Chọn tabPage tương ứng để hiển thị
            TabPage tab1 = tabControl.TabPages[(int)printType];
            tabControl.TabPages.Clear();
            tabControl.TabPages.Add(tab1);
        }
        
        private void ReportViewerLoad()
        {
            if (PrintType.HoaDon == this.printType)
            {
                select_Para_ChiTietHoaDonTableAdapter.Fill(qUANLYKTXDataSet.Select_Para_ChiTietHoaDon, Convert.ToInt32(txtInput.Text.Trim()));
                this.rvHoaDon.RefreshReport();
            }
            else if (PrintType.PhieuDK == this.printType)
            {
                select_Para_PDKTableAdapter.Fill(qUANLYKTXDataSet.Select_Para_PDK, Convert.ToInt32(txtInput.Text.Trim()));
                this.rvPDK.RefreshReport();
            }
        }

        private void FrmInDangKy_Load(object sender, EventArgs e)
        {
            if (txtInput.Text == "") return;
            //ReportViewerLoad();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }
            ReportViewerLoad();
        }
    }
}
