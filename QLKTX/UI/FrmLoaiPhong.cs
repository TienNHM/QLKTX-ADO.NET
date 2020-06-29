using QLKTX.BS;
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
    public partial class FrmLoaiPhong : Form
    {
        string error = "";
        string MaLoaiPhong = "";

        public FrmLoaiPhong()
        {
            InitializeComponent();
        }

        public FrmLoaiPhong(string key)
        {
            InitializeComponent();
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.LoaiPhong, EnumConst.LoaiPhong.MaLoaiPhong, key);
            if (error == "")
            {
                this.MaLoaiPhong = key;
                txtMaLoaiPhong.Text = dt.Rows[0]["MaLoaiPhong"].ToString();
                txtSoSV.Text = dt.Rows[0]["SoSV"].ToString();
                txtDonGia.Text = dt.Rows[0]["DonGia"].ToString();
                txtDienTich.Text = dt.Rows[0]["DienTich"].ToString();
            }   
            else
                MessageBox.Show("Đã xảy ra lỗi trong quá trình truy xuất dữ liệu. \n" + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
