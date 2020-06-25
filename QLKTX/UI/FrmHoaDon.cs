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
    public partial class FrmHoaDon : Form
    {
        string error = "";
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        public FrmHoaDon(string MaHD)
        {
            InitializeComponent();
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.HoaDon, MaHD);
            if (dt != null)
            {
                txtNhanVien.Text = dt.Rows[0]["MaNV"].ToString();
                cmbKhu.Text = dt.Rows[0]["khu"].ToString();
                cmbPhong.Text = dt.Rows[0]["Phong"].ToString();
                dtNgayHD.Value = (DateTime)dt.Rows[0]["NgayHD"];
                cmbTenDV.Text = dt.Rows[0]["TenDV"].ToString();
            }    
        }
    }
}
