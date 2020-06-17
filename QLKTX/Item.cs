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
        SinhVien,
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
