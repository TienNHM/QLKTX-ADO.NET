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
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTKPhong_Click(object sender, EventArgs e)
        {
            btnPhong.BackColor = Color.Gold;
            btnSinhVien.BackColor = SystemColors.Control;
            btnNhanVien.BackColor = SystemColors.Control;
        }

        private void btnTKSV_Click(object sender, EventArgs e)
        {
            btnPhong.BackColor = SystemColors.Control;
            btnSinhVien.BackColor = Color.Gold;
            btnNhanVien.BackColor = SystemColors.Control;
        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            btnPhong.BackColor = SystemColors.Control;
            btnSinhVien.BackColor = SystemColors.Control;
            btnNhanVien.BackColor = Color.Gold;
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
            (sender as Button).BackColor = Color.Gold;
        }

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}
