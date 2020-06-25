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
            dt.Clear();


            if (type == ItemType.DichVu)
            {
                this.Text = "THÔNG TIN DỊCH VỤ";
                lbTitle.Text = "THÔNG TIN DỊCH VỤ";
                item.picItem.BackgroundImage = Properties.Resources.water;

                dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.DichVu, EnumConst.DichVu.All);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string TenDV = dt.Rows[i]["TenDV"].ToString();
                    var item = new Item(ItemType.DichVu, TenDV);
                    if (TenDV == "Điện")
                        item.picItem.BackgroundImage = Properties.Resources.electrical;
                    else if (TenDV == "Nước")
                        item.picItem.BackgroundImage = Properties.Resources.water;
                    else if (TenDV == "Wifi4" || TenDV == "Wifi8")
                        item.picItem.BackgroundImage = Properties.Resources.wifi;
                    else if (TenDV == "Giữ xe")
                        item.picItem.BackgroundImage = Properties.Resources.garage;
                    item.btnTitle.Text = TenDV;
                    pnContainer.Controls.Add(item);
                }                    
            }
            else if (type == ItemType.LoaiPhong)
            {
                this.Text = "THÔNG TIN LOẠI PHÒNG";
                lbTitle.Text = "THÔNG TIN LOẠI PHÒNG";
                item.picItem.BackgroundImage = Properties.Resources.room;
                dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.LoaiPhong, EnumConst.LoaiPhong.All);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string LoaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();
                    var item = new Item(ItemType.LoaiPhong, LoaiPhong);
                    item.picItem.BackgroundImage = Properties.Resources.bunk_bed;
                    item.btnTitle.Text = LoaiPhong;
                    pnContainer.Controls.Add(item);
                }                    
            }
            else if (type == ItemType.KhuPhong)
            {
                item.picItem.BackgroundImage = Properties.Resources.students;
                this.Text = "THÔNG TIN KHU PHÒNG";
                lbTitle.Text = "THÔNG TIN KHU PHÒNG";
                dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.Phong);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string khu = dt.Rows[i]["Khu"].ToString();
                    var item = new Item(ItemType.LoaiPhong, khu);
                    item.picItem.BackgroundImage = Properties.Resources.room;
                    item.btnTitle.Text = khu;
                    pnContainer.Controls.Add(item);
                }                    
            }
            else if (type == ItemType.NhanVien)
            {
                this.Text = "THÔNG TIN NHÂN VIÊN";
                lbTitle.Text = "THÔNG TIN NHÂN VIÊN";
                item.picItem.BackgroundImage = Properties.Resources.collaboration;
                dt = FrmMain.bS_Layer.Select(ref error, BS_layer.TableName.NhanVien, EnumConst.NhanVien.All);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string MaNV = dt.Rows[i]["MaNV"].ToString();
                    var item = new Item(ItemType.NhanVien, MaNV);
                    item.picItem.BackgroundImage = Properties.Resources.collaboration;
                    item.btnTitle.Text = MaNV;
                    pnContainer.Controls.Add(item);
                }                    
            } 

            item.Dock = DockStyle.Right;
            item.btnTitle.Visible = false;
            item.picItem.BackColor = Color.Goldenrod;
            pnTop.Controls.Add(item);
        }
    }
}
