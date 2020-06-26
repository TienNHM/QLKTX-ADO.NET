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
        DataTable dt;
        Dictionary<string, int> DichVuSuDung = new Dictionary<string, int>();

        public FrmHoaDon(string MaNV = "", string MaHD = "")
        {
            InitializeComponent();
            dtNgayHD.Value = DateTime.Now;
            if (MaHD != "" && MaNV == "")
            {
                var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.HoaDon, EnumConst.HoaDon.MaHD, MaHD);
                if (dt.DataSet != null)
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
            dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.DichVu, EnumConst.DichVu.All);
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbTenDV.Items.Add(dt.Rows[i]["TenDV"].ToString());
        }

        private void InitKhu()
        {
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.Phong);
            string[] Khu = { "" };
            if (dt == null) return;
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbKhu.Items.Add(dt.Rows[i]["Khu"].ToString());
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
            lbDonVi.Text = "Đơn vị tính: " + dt.Rows[cmbTenDV.SelectedIndex]["DonViTinh"].ToString();
            numSoLuong.Value = 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbTenDV.Text.Trim() == "" || numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số liệu không hợp lệ", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            string key = dt.Rows[cmbTenDV.SelectedIndex]["MaDV"].ToString();
            string DonVi = dt.Rows[cmbTenDV.SelectedIndex]["DonViTinh"].ToString();
            int value = (int)numSoLuong.Value;

            try 
            {
                //Đã tồn tại, thì tăng giá trị lên
                DichVuSuDung[key] += value;
                for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                    if (dgvHoaDon.Rows[i].Cells[0].Value.ToString() == key) 
                    {
                        int val = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[2].Value.ToString().Trim()) + Convert.ToInt32(numSoLuong.Value);
                        dgvHoaDon.Rows[i].Cells[2].Value = val.ToString();
                        break;
                    }    
            } 
            catch 
            {
                //Ngược lại, thì thêm mới
                DichVuSuDung[key] = value;
                string[] rowValue = new string[] { key, cmbTenDV.Text.Trim(), value.ToString(), DonVi };
                dgvHoaDon.Rows.Add(rowValue);
            }

        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (DichVuSuDung.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }          
            
            int identity = -1;
            bool createHoaDon = FrmMain.bS_Layer.Insert(txtNamHoc.Text.Trim(), txtThang.Text.Trim(), dtNgayHD.Value, 
                                                        MaNV, cmbPhong.Text.Trim(), cmbKhu.Text.Trim(), ref identity, ref error);
            int count = 0, max = 0;
            if (createHoaDon && identity > 0)
            {
                foreach (var maDV in DichVuSuDung.Keys)
                {
                    max++;
                    var re = FrmMain.bS_Layer.Insert(identity.ToString(), maDV, DichVuSuDung[maDV], ref error);
                    if (re == false)
                        MessageBox.Show("Lỗi khi thêm dịch vụ vào hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else count++;
                }    
            }
            else
                MessageBox.Show("Lỗi khi tạo hóa đơn. \n" + error, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (count == max && count > 0)
                MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvHoaDon.CurrentCell.RowIndex;
            var row = dgvHoaDon.Rows[index];
            if (row.IsNewRow == false)
            {
                string maDV = row.Cells[0].Value.ToString().Trim();
                DichVuSuDung.Remove(maDV);
                dgvHoaDon.Rows.Remove(row);
            }    
            dgvHoaDon.Refresh();
            MessageBox.Show("Đã xóa xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
