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
    public partial class FrmDangKyPhong : Form
    {
        private string error = "";
        private string MaNV = "";

        public FrmDangKyPhong(string StrMaNV)
        {
            InitializeComponent();
            //Ngày đăng kí
            lbNgay.Text = "Ngày đăng ký: " + DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
            //Thông tin nhân viên
            lbNhanVien.Text = "Mã nhân viên: " + StrMaNV;
            MaNV = StrMaNV;
            //Khu
            InitKhu();
        }

        private void InitKhu()
        {
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.Phong);
            string[] Khu = { "" };
            if (dt != null)
            {
                List<string> tmp = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                    tmp.Add(dt.Rows[i]["Khu"].ToString());
                Khu = tmp.ToArray();
            }    
            cmbKhu.Items.AddRange(Khu);
        }

        private void PhieuDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát phải không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No)
                e.Cancel = true;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            var re = FrmMain.bS_Layer.Insert(txtMSSV.Text.Trim(), MaNV, cmbKhu.Text.Trim(), cmbMaPhong.Text.Trim(),
                cmbHocKi.Text.Trim(), txtNamHoc.Text.Trim(), DateTime.Now, Convert.ToInt32(txtThoiHan.Text), txtNgayBD.Text.Trim(), ref error);
            if (re == true)
            {
                btnInPDK.Enabled = true;
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhu.SelectedIndex > 0)
            {
                cmbMaPhong.Enabled = true;
                string[] MaPhong = { "" };
                var dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.Phong, strMaKhu: cmbKhu.Text.Trim());
                if (dt != null)
                {
                    List<string> tmp = new List<string>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                        tmp.Add(dt.Rows[i]["MaPhong"].ToString());
                    MaPhong = tmp.ToArray();
                }
                cmbMaPhong.Items.AddRange(MaPhong);
            }     
        }

        private void btnInPDK_Click(object sender, EventArgs e)
        {

        }
    }
}
