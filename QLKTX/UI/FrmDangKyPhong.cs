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
    public partial class FrmDangKyPhong : Form
    {
        public FrmDangKyPhong(string StrMaNV)
        {
            InitializeComponent();
            //Ngày đăng kí
            lbNgay.Text = "Ngày đăng ký: " + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
            //Thông tin nhân viên
            lbNhanVien.Text = "Mã nhân viên: " + StrMaNV;
            //Khu
            string[] Khu = { "" };
            cmbKhu.Items.AddRange(Khu);
            //MaPhong
            string[] MaPhong = { "" };
            cmbMaPhong.Items.AddRange(MaPhong);
        }

        private void PhieuDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát phải không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No)
                e.Cancel = true;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {


            //if (isFinished)
            btnInPDK.Enabled = true;
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhu.Text != null)
                cmbMaPhong.Enabled = true; 
        }
    }
}
