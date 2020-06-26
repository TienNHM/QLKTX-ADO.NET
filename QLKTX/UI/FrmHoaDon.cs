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
    public partial class FrmHoaDon : Form
    {
        string error = "";
        string MaNV = "";
        List<string> DS_DichVu = new List<string>();
        List<string> DS_DonViTinh = new List<string>();

        public FrmHoaDon(string MaNV = "", string MaHD = "")
        {
            InitializeComponent();
            dtNgayHD.Value = DateTime.Now;
            if (MaHD != "" && MaNV == "")
            {
                var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.HoaDon, EnumConst.HoaDon.MaHD, MaHD);
                if (dt != null)
                {
                    txtMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                    cmbKhu.Text = dt.Rows[0]["khu"].ToString();
                    cmbPhong.Text = dt.Rows[0]["Phong"].ToString();
                    dtNgayHD.Value = (DateTime)dt.Rows[0]["NgayHD"];
                    cmbTenDV.Text = dt.Rows[0]["TenDV"].ToString();
                }
            }    
            if (MaNV != "" && MaHD == "")
            {
                this.MaNV = MaNV;
                txtMaNV.Text = MaNV;
                InitKhu();
                InitDichVu();
            }    
        }

        private void InitDichVu()
        {
            var dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.DichVu, EnumConst.DichVu.All);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DS_DichVu.Add(dt.Rows[i]["TenDV"].ToString());
                    DS_DonViTinh.Add(dt.Rows[i]["DonViTinh"].ToString());
                }    
                cmbTenDV.Items.AddRange(DS_DichVu.ToArray());
            }    
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

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhu.SelectedIndex > 0)
            {
                cmbPhong.Enabled = true;
                string[] MaPhong = { "" };
                var dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.Phong, strMaKhu: cmbKhu.Text.Trim());
                if (dt != null)
                {
                    List<string> tmp = new List<string>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                        tmp.Add(dt.Rows[i]["MaPhong"].ToString());
                    MaPhong = tmp.ToArray();
                }
                cmbPhong.Items.AddRange(MaPhong);
            }
        }

        private void cmbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDonVi.Text = "Đơn vị tính: " + DS_DonViTinh[cmbTenDV.SelectedIndex];
        }
    }
}
