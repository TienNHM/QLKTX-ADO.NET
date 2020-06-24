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
    public partial class FrmTimKiem : Form
    {
        public enum SearchType
        {
            NhanVien,
            SinhVien,
            PhieuDK,
            Phong,
            HoaDon
        }


        SearchType searchType;

        private TextBox txtKey = new TextBox()
        {
            Location = new Point(300, 28),
            Size = new Size(630, 25),
            Font = new Font("Segoe UI", 10)
        };

        private string error = "";

        public FrmTimKiem()
        {
            InitializeComponent();
            pnInput.Controls.Add(txtKey);
            txtKey.TextChanged += new EventHandler(txtKey_TextChanged);
            txtKey.Enter += new EventHandler(txtKey_Enter);
        }

        private void txtKey_Enter(object sender, EventArgs e)
        {
            txtKey.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchType == SearchType.SinhVien)
            {
                BL_SinhVien sinhVien = new BL_SinhVien();
                dgv.DataSource = sinhVien.Select(
                    (BL_SinhVien.SelectType)cmbMucTimKiem.SelectedIndex, 
                    txtKey.Text.Trim(),
                    ref error);
                for (int i = 0; i < dgv.Columns.Count; i++)
                    dgv.Columns[i].HeaderText = EnumConst.SinhVienHeaderText[i];
            }                
        }

        private void TimTheoLoai_Click(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = SystemColors.Control;
            btnSinhVien.BackColor = SystemColors.Control;
            btnPhieuDK.BackColor = SystemColors.Control;
            btnPhong.BackColor = SystemColors.Control;
            btnHoaDon.BackColor = SystemColors.Control;
            var btn = sender as Button;
            btn.BackColor = Color.Gold;

            cmbMucTimKiem.Items.Clear();
            cmbMucTimKiem.Text = "";

            txtKey.Visible = true;

            if (btn.Name == "btnNhanVien")
            {
                searchType = SearchType.NhanVien;
                string[] items = new string[]
                {
                    "Mã nhân viên",
                    "Chứng minh nhân dân",
                    "Họ tên",
                    "Số điện thoại",
                    "Email",
                    "Tất cả"
                };
                cmbMucTimKiem.Items.AddRange(items);
            }
            else if (btn.Name == "btnSinhVien")
            {
                searchType = SearchType.SinhVien;
                string[] items = new string[]
                {
                    "Mã số sinh viên",
                    "Mã lớp",
                    "Họ tên",
                    "Phái",
                    "CMND",
                    "Email",
                    "Số điện thoại",
                    "Quê quán",
                    "Tất cả"
                };
                cmbMucTimKiem.Items.AddRange(items);
            }   
            else if (btn.Name == "btnPhieuDK")
            {
                searchType = SearchType.PhieuDK;
                string[] items = new string[]
                {
                    "Mã phiếu",
                    "Khu phòng",
                    "Học kì",
                    "Năm học"
                };
                cmbMucTimKiem.Items.AddRange(items);
            }   
            else if (btn.Name == "btnPhong")
            {
                searchType = SearchType.Phong;
                string[] items = new string[]
                {
                    "Khu phòng",
                    "Loại phòng"
                };
                cmbMucTimKiem.Items.AddRange(items);
            }   
            else if (btn.Name == "btnHoaDon")
            {
                searchType = SearchType.HoaDon;
                string[] items = new string[]
                {
                    "Mã hóa đơn",
                    "Khu phòng",
                };
                cmbMucTimKiem.Items.AddRange(items);
            }    
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text.EndsWith(" ")) 
                btnSearch_Click(sender, e);
        }

        private void cmbMucTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            if (cmbMucTimKiem.Text == "Khu phòng")
            {
                txtKey.Visible = false;
                pnKey.Visible = true;
            } 
            else
            {
                txtKey.Visible = true;
                pnKey.Visible = false;
            }    
        }
    }
}
