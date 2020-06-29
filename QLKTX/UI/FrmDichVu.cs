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
    public partial class FrmDichVu : Form
    {
        private string TenDV = "";
        private string error = "";

        public FrmDichVu(string TenDV)
        {
            InitializeComponent();
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.DichVu, EnumConst.DichVu.TenDV, TenDV.Trim());
            if (error == "")
            {
                this.TenDV = TenDV;
                txtMaDV.Text = dt.Rows[0]["MaDV"].ToString();
                txtTenDV.Text = dt.Rows[0]["TenDV"].ToString();
                txtGiaDV.Text = dt.Rows[0]["GiaDV"].ToString();
                txtDonViTinh.Text = dt.Rows[0]["DonViTinh"].ToString();
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
