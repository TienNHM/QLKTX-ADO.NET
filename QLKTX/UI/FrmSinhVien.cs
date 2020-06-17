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
    public partial class FrmSinhVien : Form
    {
        bool isExpended = false;
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        public FrmSinhVien(string maSV)
        {
            InitializeComponent();
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            isExpended = !isExpended;
            if (isExpended)
            {
                pnMoRong.Visible = true;
                this.Width = 1050;
            }
            else
            {
                pnMoRong.Visible = false;
                this.Width = 735;
            }
        }
    }
}
