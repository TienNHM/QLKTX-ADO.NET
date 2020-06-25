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
    public partial class FrmPhong : Form
    {
        public FrmPhong()
        {
            InitializeComponent();
        }

        public FrmPhong(string Khu, string MaPhong)
        {
            InitializeComponent();
            cmbKhu.Text = Khu.Trim();
            cmbKhu.Enabled = false;
            cmbPhong.Text = MaPhong.Trim();
            cmbPhong.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmbLoaiPhong.Enabled = true;
            cmbKhu.Enabled = true;
            cmbPhong.Enabled = true;
        }
    }
}
