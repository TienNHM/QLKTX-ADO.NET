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
        private string MaPDK = "";
        DataTable dataKhuPhong = new DataTable();

        public FrmDangKyPhong(string MaPDK = "")
        {
            InitializeComponent();
            if (MaPDK != "")
            {
                var dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.PhieuDK, EnumConst.PhieuDK.MaPDK, MaPDK.Trim());
                if (dt.Rows.Count > 0)
                {
                    this.MaPDK = MaPDK;
                    txtMSSV.Text = dt.Rows[0]["MSSV"].ToString();
                    txtNamHoc.Text = dt.Rows[0]["NamHoc"].ToString();
                    txtNgayBD.Text = dt.Rows[0]["NgayBD"].ToString();
                    txtThoiHan.Text = dt.Rows[0]["ThoiHan"].ToString();
                    cmbHocKi.Text = dt.Rows[0]["HocKi"].ToString();
                    cmbKhu.Text = dt.Rows[0]["Khu"].ToString();
                    cmbMaPhong.Text = dt.Rows[0]["MaPhong"].ToString();
                    lbMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình truy xuất dữ liệu! \n" + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else
            {
                //Ngày đăng kí
                lbNgayGioDK.Text = DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
                //Thông tin nhân viên
                lbMaNV.Text = FrmMain.MaNV + "";
                //Khu
                InitKhu();
            }    
        }

        private void InitKhu()
        {
            dataKhuPhong = FrmMain.bS_Layer.LayDSPhongTrong(ref error);
            if (error == "")
            {
                string current_Khu = "";
                for (int i = 0; i < dataKhuPhong.Rows.Count; i++)
                {
                    string tmp = dataKhuPhong.Rows[i]["Khu"].ToString();
                    if (tmp.Equals(current_Khu) == false)
                    {
                        cmbKhu.Items.Add(tmp);
                        current_Khu = tmp;
                    }    
                }                    
            }    
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int identity = -1;
            try
            {
                var re = FrmMain.bS_Layer.Insert(
                            MSSV: txtMSSV.Text.Trim(),
                            MaNV: FrmMain.MaNV,
                            Khu: cmbKhu.Text.Trim(),
                            MaPhong: cmbMaPhong.Text.Trim(),
                            HocKi: cmbHocKi.Text.Trim(),
                            NamHoc: txtNamHoc.Text.Trim(),
                            NgayGioDK: DateTime.Now,
                            ThoiHan: Convert.ToInt32(txtThoiHan.Text),
                            NgayBD: txtNgayBD.Text.Trim(),
                            ref identity, ref error);

                if (re == true && identity != -1)
                {
                    btnInPDK.Enabled = true;
                    this.MaPDK = identity.ToString();
                    FrmMain.bS_Layer.Insert(ref error, txtMSSV.Text.Trim(), cmbMaPhong.Text.Trim(), cmbKhu.Text.Trim());
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Enabled = false;
                    btnDangKy.Enabled = false;
                }
                else
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaPhong.Text = "";
            if (cmbKhu.SelectedIndex > 0)
            {
                cmbMaPhong.Enabled = true;
                cmbMaPhong.Items.Clear();

                //Xác định đang chọn phòng cho khu nào
                string khu = cmbKhu.SelectedItem.ToString();

                //Lấy danh sách phòng của khu tương ứng
                var rows = dataKhuPhong.Select($"Khu = '{khu}'");
                //Thêm vào cmb
                foreach (DataRow r in rows)
                {
                    cmbMaPhong.Items.Add(r["MaPhong"].ToString());
                }    
            }   
        }

        private void btnInPDK_Click(object sender, EventArgs e)
        {
            if (MaPDK == "") return;
            this.Hide();
            FrmInDangKy frmIn = new FrmInDangKy(FrmInDangKy.PrintType.PhieuDK, MaPDK);
            frmIn.Show();
            this.Dispose();
        }
    }
}
