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
        private string error = "";

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
                dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.LoaiPhong, BS_layer.SelectType.All);
                dgv.DataSource = dt;
                for (int i = 0; i < dgv.ColumnCount; i++)
                    dgv.Columns[i].HeaderText = EnumConst.LoaiPhongHeaderText[i];
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
                dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.NhanVien, BS_layer.SelectType.All);
                dgv.DataSource = dt;
                for (int i = 0; i < dgv.ColumnCount; i++)
                    dgv.Columns[i].HeaderText = EnumConst.NhanVienHeaderText[i];
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
