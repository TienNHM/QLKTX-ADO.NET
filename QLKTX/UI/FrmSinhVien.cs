using QLKTX.BS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.UI
{
    public partial class FrmSinhVien : Form
    {
        bool isExpended = false;
        string error = "";

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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.SinhVien, EnumConst.SinhVien.MSSV, txtMSSV.Text.Trim());
            bool bNu = true;
            if (txtGioiTinh.Text.Trim() == "Nam")
                bNu = false;
            bool result = false;
            if (dt != null)
            {
                result = FrmMain.bS_Layer.Update(
                    txtMSSV.Text.Trim(),
                    cmbMaLop.Text.Trim(),
                    txtDienSV.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    Phai: bNu,
                    txtNgSinh.Text,
                    txtCMND.Text,
                    txtEmail.Text,
                    txtSDT.Text,
                    txtBHYT.Text,
                    txtQueQuan.Text,
                    txtAvt.Text.Trim(),
                    ref error);
            }   
            else
            {
                result = FrmMain.bS_Layer.Insert(
                    txtMSSV.Text.Trim(),
                    cmbMaLop.Text.Trim(),
                    txtDienSV.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    Phai: bNu,
                    txtNgSinh.Text,
                    txtCMND.Text,
                    txtEmail.Text,
                    txtSDT.Text,
                    txtBHYT.Text,
                    txtQueQuan.Text,
                    txtAvt.Text.Trim(),
                    ref error);
            }
            if (result)
                MessageBox.Show("Đã lưu xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Image (*.png)|*.png|Image (*.jpg)|*.jpg|All files (*.*)|*.*",
                Title = "Chọn ảnh chân dung"
            };
            var re = fileDialog.ShowDialog();
            if (re == DialogResult.OK)
            {
                txtAvt.Text = fileDialog.FileName;
                picAvt.BackgroundImage = Image.FromStream(fileDialog.OpenFile());
            }    
        }
    }
}
