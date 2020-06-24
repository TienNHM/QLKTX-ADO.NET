using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using QLKTX.BS;

namespace QLKTX.UI
{
    public partial class FrmTongQuan : Form
    {
        private ItemType type = ItemType.Unknown;
        private Item item = new Item(null);
        private DataTable dt = new DataTable();

        public FrmTongQuan(ItemType type)
        {
            InitializeComponent();
            this.type = type;
            dgv.Dock = DockStyle.Fill;
            dgv.AutoSize = true;
            dt.Clear();
            if (type == ItemType.DichVu)
            {
                this.Text = "THÔNG TIN DỊCH VỤ";
                item.picItem.BackgroundImage = Properties.Resources.water;
                BL_DichVu db = new BL_DichVu();
                dt = db.Select();
                dgv.DataSource = dt;
                dgv.Columns[0].HeaderText = "Mã dịch vụ";
                dgv.Columns[1].HeaderText = "Tên dịch vụ";
                dgv.Columns[2].HeaderText = "Giá dịch vụ";
                dgv.Columns[3].HeaderText = "Đơn vị tính";
            }
            else if (type == ItemType.LoaiPhong)
            {
                this.Text = "THÔNG TIN LOẠI PHÒNG";
                item.picItem.BackgroundImage = Properties.Resources.room;
                BL_LoaiPhong db = new BL_LoaiPhong();
                dt = db.Select();
                dgv.DataSource = dt;
                dgv.Columns[0].HeaderText = "Mã loại phòng";
                dgv.Columns[1].HeaderText = "Số sinh viên tối đa";
                dgv.Columns[2].HeaderText = "Diện tích (met vuông)";
                dgv.Columns[3].HeaderText = "Đơn giá (đồng/tháng)";
            }
            else if (type == ItemType.KhuPhong)
            {
                item.picItem.BackgroundImage = Properties.Resources.students;
                this.Text = "THÔNG TIN KHU PHÒNG";

            }
            else if (type == ItemType.NhanVien)
            {
                this.Text = "THÔNG TIN NHÂN VIÊN";
                item.picItem.BackgroundImage = Properties.Resources.collaboration;
                BL_NhanVien db = new BL_NhanVien();
                dt = db.Select();
                dgv.DataSource = dt;
                dgv.Columns[0].HeaderText = "Mã NV";
                dgv.Columns[1].HeaderText = "CMND";
                dgv.Columns[2].HeaderText = "Họ tên";
                dgv.Columns[3].HeaderText = "SĐT";
                dgv.Columns[4].HeaderText = "Email";
                dgv.Columns[5].HeaderText = "Địa chỉ";
                dgv.Columns[6].HeaderText = "Lương";
                dgv.Columns[7].HeaderText = "Quản lý";
            }
            else
            {
                item.picItem.BackgroundImage = Properties.Resources.info;
            }    

            item.Dock = DockStyle.Right;
            item.btnTitle.Visible = false;
            item.picItem.BackColor = Color.Goldenrod;
            pnTop.Controls.Add(item);
            
        }
    }
}
