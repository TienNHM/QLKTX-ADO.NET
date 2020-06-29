using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKTX.UI;

namespace QLKTX
{
    public enum ItemType
    {
        KhuPhong,
        NhanVien,
        DichVu,
        HoaDon,
        LoaiPhong,
        Unknown
    }

    public partial class Item : UserControl
    {
        public ClickEvent ClickEvent = null;

        private ItemType type = ItemType.Unknown;
        private string strKey = "";

        public Item(ClickEvent click)
        {
            InitializeComponent();
            this.ClickEvent = click;
        }

        public Item(ItemType type)
        {
            InitializeComponent();
            this.type = type;
            this.ClickEvent = EventClick;
        }

        public Item(ItemType type, string key)
        {
            InitializeComponent();
            this.type = type;
            this.ClickEvent = ShowInfo;
            strKey = key;
        }

        private void ShowInfo()
        {
            switch (this.type)
            {
                case ItemType.KhuPhong:
                    break;
                case ItemType.LoaiPhong:
                    FrmLoaiPhong loaiPhong = new FrmLoaiPhong(this.strKey);
                    loaiPhong.ShowDialog();
                    break;
                case ItemType.NhanVien:
                    FrmNhanVien nhanVien = new FrmNhanVien(this.strKey);
                    nhanVien.ShowDialog();
                    break;
                case ItemType.DichVu:
                    FrmDichVu dichVu = new FrmDichVu(this.strKey);
                    dichVu.ShowDialog();
                    break;
            }    
        }

        private void EventClick()
        {
            FrmTongQuan tongQuan = new FrmTongQuan(this.type);
            tongQuan.ShowDialog();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (ClickEvent != null)
                this.ClickEvent();
        }

        private void btnTitle_Enter(object sender, EventArgs e)
        {
            btnTitle.BackColor = Color.Coral;
        }

        private void btnTitle_Leave(object sender, EventArgs e)
        {
            btnTitle.BackColor = Color.Transparent;
        }
    }
}
