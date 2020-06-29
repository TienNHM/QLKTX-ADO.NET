using QLKTX.BS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLKTX.UI
{
    public partial class FrmHoaDon : Form
    {
        string error = "";
        string MaHD = "";
        DataTable DS_DichVu;
        Dictionary<string, int> DichVuSuDung = new Dictionary<string, int>();

        public FrmHoaDon()
        {
            InitializeComponent();
            InitKhu();
            InitDichVu();
            btnInHoaDon.Enabled = false;
            dtNgayHD.Value = DateTime.Now;
            txtMaNV.Text = FrmMain.MaNV;
        }

        public FrmHoaDon(string MaHD)
        {
            InitializeComponent();
            InitKhu();
            InitDichVu();
            btnInHoaDon.Enabled = true;
            this.MaHD = MaHD;
            dtNgayHD.Value = DateTime.Now;
            var hoaDon = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.HoaDon, EnumConst.HoaDon.MaHD, MaHD);
            if (hoaDon != null)
            {
                txtMaNV.Text = hoaDon.Rows[0]["MaNV"].ToString();
                cmbKhu.Text = hoaDon.Rows[0]["Khu"].ToString();
                cmbPhong.Text = hoaDon.Rows[0]["MaPhong"].ToString();
                txtThang.Text = hoaDon.Rows[0]["Thang"].ToString();
                txtNamHoc.Text = hoaDon.Rows[0]["Nam"].ToString();
                dtNgayHD.Value = (DateTime)hoaDon.Rows[0]["NgayHD"];

                //MaDV, SoLuong
                var sddv = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.SDDV, EnumConst.SDDV.MaHD, MaHD);
                sddv.Columns.RemoveAt(0);

                DichVuSuDung.Clear();
                dgvHoaDon.DataSource = null;
                foreach (DataRow row in sddv.Rows)
                {
                    string key = row["MaDV"].ToString();
                    int value = Convert.ToInt32(row["SoLuong"]);
                    DichVuSuDung[key] = value;
                    var r = DS_DichVu.Rows.Find(key);
                    string[] data = new string[] { key, r["TenDV"].ToString(), value.ToString(), r["DonViTinh"].ToString() };
                    dgvHoaDon.Rows.Add(data);
                }    
            }
        }

        private void InitDichVu()
        {
            //Lấy danh sách tất cả các dịch vụ hiện có
            DS_DichVu = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.DichVu, EnumConst.DichVu.All);

            if (DS_DichVu == null) return;

            //Đặt primary key, để sau này có thể Find()
            DataColumn[] primaryKey = new DataColumn[] { DS_DichVu.Columns["MaDV"] };
            DS_DichVu.PrimaryKey = primaryKey;

            //Cập nhật các dịch vụ hiện có lên giao diện người dùng
            for (int i = 0; i < DS_DichVu.Rows.Count; i++)
                cmbTenDV.Items.Add(DS_DichVu.Rows[i]["TenDV"].ToString());
        }

        private void InitKhu()
        {
            //Lấy danh sách tất cả các khu nhà hiện có
            var dt = FrmMain.bS_Layer.Select(ref error, BS.BS_layer.TableName.Phong);

            if (dt == null) return;

            //Cập nhật danh sách các khu nhà lên giao diện người dùng
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbKhu.Items.Add(dt.Rows[i]["Khu"].ToString());
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhu.SelectedIndex > 0)
            {
                //Cho phép người dùng chọn phòng
                cmbPhong.Enabled = true;

                //Lấy danh sách tất cả các phòng ở hiện có, tương ứng với Khu được chọn
                var dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.Phong, strMaKhu: cmbKhu.Text.Trim());

                if (dt == null) return;

                //Cập nhật danh sách phòng ở lên giao diện người dùng
                for (int i = 0; i < dt.Rows.Count; i++)
                    cmbPhong.Items.Add(dt.Rows[i]["MaPhong"].ToString());
            }
        }

        /// <summary>
        /// Cập nhật đơn vị tính tương ứng cho từng dịch vụ được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDonVi.Text = "Đơn vị tính: " + DS_DichVu.Rows[cmbTenDV.SelectedIndex]["DonViTinh"].ToString();
            numSoLuong.Value = 1;
        }

        /// <summary>
        /// Thêm dịch vụ vào hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Nếu chưa chọn dịch vụ nào, hoặc chọn số lượng không hợp lệ
            if (cmbTenDV.Text.Trim() == "" || numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số liệu không hợp lệ", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            //Lấy MaDV, DonViTinh, SoLuong tương ứng cho từng dịch vụ
            string key = DS_DichVu.Rows[cmbTenDV.SelectedIndex]["MaDV"].ToString();
            string DonVi = DS_DichVu.Rows[cmbTenDV.SelectedIndex]["DonViTinh"].ToString();
            int value = (int)numSoLuong.Value;

            try 
            {
                //Dịch vụ đã tồn tại trong hóa đơn, thì tăng giá trị lên
                DichVuSuDung[key] += value;

                //Cập nhật giá trị trên giao diện
                for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                    if (dgvHoaDon.Rows[i].Cells[0].Value.ToString() == key) 
                    {
                        dgvHoaDon.Rows[i].Cells[2].Value = DichVuSuDung[key].ToString();
                        break;
                    }    
            } 
            catch 
            {
                //Ngược lại, thì thêm mới
                DichVuSuDung[key] = value;

                //Thêm mới một hàng vào dgv
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

            //Sửa thông tin hóa đơn
            if (MaHD != "")
            {
                bool reHoaDon = FrmMain.bS_Layer.Update(MaHD, txtNamHoc.Text.Trim(), txtThang.Text.Trim(), dtNgayHD.Value, 
                                                    txtMaNV.Text.Trim(), cmbPhong.Text.Trim(), cmbKhu.Text.Trim(), ref error);

                //Cập nhật danh sách các dịch vụ
                foreach (string maDV_key in DichVuSuDung.Keys)
                {
                    //Kiểm tra dịch vụ maDV_key đã có trong hóa đơn chưa
                    bool exist = FrmMain.bS_Layer.Select(ref error, MaHD, maDV_key);

                    //Nếu đã có, cập nhật nó
                    if (exist)
                        FrmMain.bS_Layer.Update(ref error, MaHD, maDV_key, SoLuong: DichVuSuDung[maDV_key]);
                    //Ngược lại, thêm mới 1 dịch vụ vào hóa đơn
                    else
                        FrmMain.bS_Layer.Insert(ref error, MaHD, maDV_key, SoLuong: DichVuSuDung[maDV_key]);
                }    

                if (reHoaDon)
                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật hóa đơn! \n" + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            //Thêm mới 1 hóa đơn
            else
            {
                int identity = -1;  //Dùng để xác định mã hóa đơn vừa mới thêm vào

                //Tạo mới 1 hóa đơn
                bool createHoaDon = FrmMain.bS_Layer.Insert(txtNamHoc.Text.Trim(), txtThang.Text.Trim(), dtNgayHD.Value,
                                                            FrmMain.MaNV, cmbPhong.Text.Trim(), cmbKhu.Text.Trim(), ref identity, ref error);
                
                int count = 0, max = 0; //Dùng để xác định có thêm được tất cả các dịch vụ vào hóa đơn hay không

                if (createHoaDon && identity > 0)
                {
                    this.MaHD = identity.ToString();
                    foreach (var maDV in DichVuSuDung.Keys)
                    {
                        max++;
                        var re = FrmMain.bS_Layer.Insert(ref error, this.MaHD, maDV, SoLuong: DichVuSuDung[maDV]);
                        if (re == false)
                            MessageBox.Show("Lỗi khi thêm dịch vụ vào hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else count++;
                    }
                }
                else
                    MessageBox.Show("Lỗi khi tạo hóa đơn. \n" + error, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (count == max && count > 0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnInHoaDon.Enabled = true;
                }    
                else
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thực hiện lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
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
            FrmInDangKy frmIn = new FrmInDangKy(FrmInDangKy.PrintType.HoaDon, MaHD);
            this.Hide();
            frmIn.ShowDialog();
            this.Dispose();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có thật sự muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (MaHD == "")
                    this.Dispose();
                else
                {
                    FrmMain.bS_Layer.Delete(BS_layer.TableName.SDDV, MaHD, ref error);
                    if (error != "")
                    {
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa danh sách dịch vụ của hóa đơn số " + MaHD + ". \n" + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }    
                    FrmMain.bS_Layer.Delete(BS_layer.TableName.HoaDon, MaHD, ref error);
                    if (error != "")
                    {
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa hóa đơn. \n" + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }    
                    else this.Dispose();
                }    
            }    
        }
    }
}
