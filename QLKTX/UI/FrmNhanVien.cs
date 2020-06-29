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
    public partial class FrmNhanVien : Form
    {
        string error = "";
        string strAvt = "";

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        public FrmNhanVien(string maNV)
        {
            InitializeComponent();
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.NhanVien, EnumConst.NhanVien.MaNV, maNV);
            if (dt != null)
            {
                txtMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                txtMaNQL.Text = dt.Rows[0]["MaNQL"].ToString();
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtCMND.Text = dt.Rows[0]["CMND"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtLuong.Text = dt.Rows[0]["Luong"].ToString();
                txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                strAvt = dt.Rows[0]["AnhChanDung"].ToString();
                try
                {
                    picAvt.BackgroundImage = Image.FromFile(strAvt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi load ảnh chân dung. \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pnContainer.Enabled = false;
            btnChoose.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnContainer.Enabled = true;
            btnChoose.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = FrmMain.bS_Layer.Update(ref error, txtMaNV.Text.Trim(), txtCMND.Text.Trim(), txtHoTen.Text.Trim(), 
                txtSDT.Text.Trim(), txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), Convert.ToInt32(txtLuong.Text.Trim()), txtMaNQL.Text.Trim(), strAvt.Trim());
            if (dt)
                MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật thông tin. \n" + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image (*.png)|*.png|Image (*.jpeg, *.jpg)|*.jpeg, *.jpg|All files (*.*)|*.*",
                Title = "Chọn ảnh chân dung"
            };
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK) 
            {
                strAvt = openFile.FileName;
                picAvt.BackgroundImage = Image.FromStream(openFile.OpenFile());
            }    
        }
    }
}
