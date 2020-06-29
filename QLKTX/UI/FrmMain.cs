using QLKTX.BS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.UI
{
    public delegate void ClickEvent();
    public partial class FrmMain : Form
    {
        private bool isExit = false;
        private BL_DangNhap.AccountType _accountType;
        public static BS_layer bS_Layer = new BS_layer();

        public static string MaNV { get; set; }

        public FrmMain(string strMaNV, BL_DangNhap.AccountType accountType)
        {
            MaNV = strMaNV.Trim();
            this._accountType = accountType;
            InitializeComponent();
            Init();
            lbNgay.Text = "Ngày hiện tại: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");

            if (accountType == BL_DangNhap.AccountType.Employee)
            {
                ctrlDS_NhanVien.Enabled = false;
                ctrlBaoCao.Enabled = false;
            }                
        }

        #region Init
        private Item ctrlDangXuat;
        private Item ctrlThoat;
        private Item ctrlSinhVien;
        private Item ctrlPhong;
        private Item ctrlHoaDon;
        private Item ctrlDS_KhuPhong;
        private Item ctrlDS_NhanVien;
        private Item ctrlLoaiPhong;
        private Item ctrlDS_DichVu;
        private Item ctrlTimKiem;
        private Item ctrlBaoCao;
        private Item ctrlHuongDan;

        private void Init()
        {
            //Đăng nhập
            ctrlDangXuat = new Item(DangXuat);
            ctrlDangXuat.picItem.BackgroundImage = Properties.Resources.logout;
            ctrlDangXuat.btnTitle.Text = "ĐĂNG XUẤT";
            ctrlDangXuat.Dock = DockStyle.Top;
            ctrlDangXuat.btnTitle.ForeColor = Color.DarkRed;
            pnQuanTriLayout.Controls.Add(ctrlDangXuat);
            //Thoát
            ctrlThoat = new Item(Thoat);
            ctrlThoat.picItem.BackgroundImage = Properties.Resources.cancel;
            ctrlThoat.btnTitle.Text = "THOÁT";
            ctrlThoat.Dock = DockStyle.Top;
            ctrlThoat.btnTitle.ForeColor = Color.DarkRed;
            pnQuanTriLayout.Controls.Add(ctrlThoat);
            //Sinh viên
            ctrlSinhVien = new Item(SinhVien);
            ctrlSinhVien.picItem.BackgroundImage = Properties.Resources.student;
            ctrlSinhVien.btnTitle.Text = "SINH VIÊN";
            ctrlSinhVien.Dock = DockStyle.Top;
            pnThemLayout.Controls.Add(ctrlSinhVien);
            //Phòng
            ctrlPhong = new Item(Phong);
            ctrlPhong.picItem.BackgroundImage = Properties.Resources.bunk_bed;
            ctrlPhong.btnTitle.Text = "PHÒNG";
            ctrlPhong.Dock = DockStyle.Top;
            pnThemLayout.Controls.Add(ctrlPhong);
            //Hoá đơn
            ctrlHoaDon = new Item(HoaDon);
            ctrlHoaDon.picItem.BackgroundImage = Properties.Resources.form;
            ctrlHoaDon.btnTitle.Text = "HOÁ ĐƠN";
            ctrlHoaDon.Dock = DockStyle.Top;
            pnThemLayout.Controls.Add(ctrlHoaDon);
            //DS Khu phòng
            ctrlDS_KhuPhong = new Item(ItemType.KhuPhong);
            ctrlDS_KhuPhong.picItem.BackgroundImage = Properties.Resources.room;
            ctrlDS_KhuPhong.btnTitle.Text = "DS Khu phòng";
            ctrlDS_KhuPhong.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlDS_KhuPhong);
            //DS Nhân viên
            ctrlDS_NhanVien = new Item(ItemType.NhanVien);
            ctrlDS_NhanVien.picItem.BackgroundImage = Properties.Resources.collaboration;
            ctrlDS_NhanVien.btnTitle.Text = "DS Nhân viên";
            ctrlDS_NhanVien.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlDS_NhanVien);
            //DS Khu phòng
            ctrlLoaiPhong = new Item(ItemType.LoaiPhong);
            ctrlLoaiPhong.picItem.BackgroundImage = Properties.Resources.bunk_bed;
            ctrlLoaiPhong.btnTitle.Text = "Loại phòng";
            ctrlLoaiPhong.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlLoaiPhong);
            //DS dịch vụ
            ctrlDS_DichVu = new Item(ItemType.DichVu);
            ctrlDS_DichVu.picItem.BackgroundImage = Properties.Resources.water;
            ctrlDS_DichVu.btnTitle.Text = "Dịch vụ";
            ctrlDS_DichVu.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlDS_DichVu);
            //Tìm kiếm
            ctrlTimKiem = new Item(TimKiem);
            ctrlTimKiem.picItem.BackgroundImage = Properties.Resources.search;
            ctrlTimKiem.btnTitle.Text = "Tìm kiếm";
            ctrlTimKiem.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlTimKiem);
            //Báo cáo
            ctrlBaoCao = new Item(BaoCao);
            ctrlBaoCao.picItem.BackgroundImage = Properties.Resources.business_report;
            ctrlBaoCao.btnTitle.Text = "Báo cáo";
            ctrlBaoCao.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlBaoCao);
            //Hướng dẫn
            ctrlHuongDan = new Item(HuongDan);
            ctrlHuongDan.picItem.BackgroundImage = Properties.Resources.info;
            ctrlHuongDan.btnTitle.Text = "Hướng dẫn";
            ctrlHuongDan.Dock = DockStyle.Top;
            pnThongTinLayout.Controls.Add(ctrlHuongDan);
        }
        #endregion

        private void DangXuat()
        {
            DialogResult re = MessageBox.Show("Bạn muốn đăng xuất khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                isExit = false;
                FrmDangNhap.exit = false;
                this.Dispose();
            }
        }

        private void Thoat()
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                isExit = true;
                FrmDangNhap.exit = true;
                Application.Exit();
            }    
        }

        private void Phong()
        {
            FrmDangKyPhong frmDangKyPhong = new FrmDangKyPhong();
            frmDangKyPhong.ShowDialog();
        }

        private void SinhVien()
        {
            FrmSinhVien frmSinhVien = new FrmSinhVien();
            frmSinhVien.ShowDialog();
        }

        private void TimKiem()
        {
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.ShowDialog();
        }

        private void BaoCao()
        {
            FrmBaoCao baoCao = new FrmBaoCao();
            baoCao.ShowDialog();
        }

        private void HuongDan()
        {
            FrmHuongDan huongDan = new FrmHuongDan();
            huongDan.ShowDialog();
        }

        private void HoaDon()
        {
            FrmHoaDon hoaDon = new FrmHoaDon();
            hoaDon.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
            else
                this.Dispose();
        }
    }
}
