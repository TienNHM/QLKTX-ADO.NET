using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKTX;

namespace QLKTX.UI
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Sinh vien
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                this.sINHVIENTableAdapter.Fill(this.qUANLYKTXDataSet.SINHVIEN);
                this.rvSinhVien.RefreshReport();
            }
            //Nhan vien
            else if (tabControl.SelectedTab == tabControl.TabPages[1])
            {
                this.nHANVIENTableAdapter.Fill(this.qUANLYKTXDataSet.NHANVIEN);
                this.rvNhanVien.RefreshReport();
            }
            //Dang ky phong
            else if (tabControl.SelectedTab == tabControl.TabPages[2])
            {
                this.pHIEUDKTableAdapter.Fill(this.qUANLYKTXDataSet.PHIEUDK);
                this.rvPhieuDK.RefreshReport();
            }
            //SDDV
            else if (tabControl.SelectedTab == tabControl.TabPages[3])
            {
                //KTX
                if (tabSDDV.SelectedTab == tabSDDV.TabPages[0])
                {
                    if (cmb_DV_KTX.SelectedIndex < 0)
                    {
                        MessageBox.Show("Vui lòng chọn mục báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.select_ThongKeDichVuTableAdapter.Fill(qUANLYKTXDataSet.Select_ThongKeDichVu);
                    this.rvKTX.RefreshReport();
                }
                //Khu
                else if (tabSDDV.SelectedTab == tabSDDV.TabPages[1])
                {
                    if (cmb_DV_Khu.SelectedIndex < 0)
                    {
                        MessageBox.Show("Vui lòng chọn mục báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string dv = cmb_DV_Khu.Text.Trim();
                    this.select_2Para_ThongKeSDDV_KhuTableAdapter.Fill(this.qUANLYKTXDataSet.Select_2Para_ThongKeSDDV_Khu, cmbKhu_Khu.Text, dv);
                    this.rvKhu.RefreshReport();
                }
                //Phong
                else if (tabSDDV.SelectedTab == tabSDDV.TabPages[2])
                {
                    if (cmb_DV_Phong.SelectedIndex < 0)
                    {
                        MessageBox.Show("Vui lòng chọn mục báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string dv = cmb_DV_Phong.Text.Trim();
                    this.select_3Para_SDDV_PhongTableAdapter.Fill(this.qUANLYKTXDataSet.Select_3Para_SDDV_Phong, cmb_Khu_Phong.Text, cmb_Phong_Phong.Text, dv);
                    this.rvPhong.RefreshReport();
                }                    
            }
        }
    }
}
