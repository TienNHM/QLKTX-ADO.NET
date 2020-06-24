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
    public partial class FrmTimKiem : Form
    {
        public enum SearchType
        {
            NhanVien,
            SinhVien,
            PhieuDK,
            Phong,
            HoaDon
        }

        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void TimTheoLoai_Click(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = SystemColors.Control;
            btnSinhVien.BackColor = SystemColors.Control;
            btnPhieuDK.BackColor = SystemColors.Control;
            btnPhong.BackColor = SystemColors.Control;
            btnHoaDon.BackColor = SystemColors.Control;
            var btn = sender as Button;
            btn.BackColor = Color.Gold;
        }
    }
}
