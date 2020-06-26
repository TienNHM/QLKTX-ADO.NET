using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BS
{
    public static class EnumConst
    {
        #region Enum
        public enum NhanVien
        {
            MaNV = 0,
            CMND,
            HoTen,
            SDT,
            Email,
            All
        }

        public enum SinhVien
        {
            MSSV = 0,
            MaLop,
            HoTen,
            Phai,
            CMND,
            Email,
            SDT,
            QueQuan,
            All
        }

        public enum HoaDon
        {
            MaHD,
            KhuPhong,
            All
        }

        public enum PhieuDK
        {
            MaPDK,
            MSSV,
            MaNV,
            KhuPhong,
            HocKi,
            NamHoc,
            All
        }

        public enum Phong
        {
            Khu,
            LoaiPhong,
            All
        }

        public enum DichVu
        {
            MaDV,
            TenDV,
            All
        }

        public enum LoaiPhong
        {
            MaLoaiPhong,
            SoSV,
            DienTich,
            DonGia,
            All
        }
        #endregion

        #region Mục chọn để tìm kiếm
        public static string[] SearchNhanVien = new string[]
        {
            "Mã nhân viên",
            "Chứng minh nhân dân",
            "Họ tên",
            "Số điện thoại",
            "Email",
            "Tất cả"
        };

        public static string[] SearchSinhVien = new string[]
        {
            "MSSV",
            "Mã lớp",
            "Họ tên",
            "Nữ",
            "Chứng minh nhân dân",
            "Email",
            "Số điện thoại",
            "Quê quán",
            "Tất cả"
        };

        public static string[] SearchPhieuDK = new string[]
        {
            "Mã phiếu đăng kí",
            "MSSV",
            "Mã nhân viên",
            "Khu phòng",
            "Học kì",
            "Năm học",
            "Tất cả"
        };

        public static string[] SearchHoaDon = new string[]
        {
            "Mã hóa đơn",
            "Khu phòng",
            "Tất cả"
        };

        public static string[] SearchPhong = new string[]
        {
            "Khu",
            "Loại phòng",
            "Tất cả"
        };
        #endregion

        #region HeaderText
        public static string[] SinhVienHeaderText = new string[]
        {
            "MSSV",
            "Mã lớp",
            "Diện",
            "Họ tên",
            "Nữ",
            "Ngày sinh",
            "CMND",
            "Email",
            "SĐT",
            "BHYT",
            "Quê",
            "Ảnh"
        };

        public static string[] NhanVienHeaderText = new string[]
        {
            "Mã NV",
            "CMND",
            "Họ tên",
            "SĐT",
            "Email",
            "Địa chỉ",
            "Lương",
            "Mã NQL",
            "Ảnh"
        };

        public static string[] LoaiPhongHeaderText = new string[]
        {
            "Mã loại phòng",
            "Số sinh viên tối đa",
            "Diện tích (met vuông)",
            "Đơn giá (đồng/tháng)"
        };

        public static string[] DichVuHeaderText = new string[]
        {
            "Mã dịch vụ",
            "Tên dịch vụ",
            "Giá dịch vụ",
            "Đơn vị tính"
        };

        public static string[] HoaDonHeaderText = new string[]
        {
            "Mã hóa đơn",
            "Năm",
            "Tháng",
            "Ngày xuất hóa đơn",
            "Mã NV",
            "Mã phòng",
            "Mã khu"
        };

        public static string[] PhieuDKHeaderText = new string[]
        {
            "Mã phiếu",
            "MSSV",
            "Mã nhân viên",
            "Khu",
            "Mã phòng",
            "Học kì",
            "Năm học",
            "Ngày giờ đăng kí",
            "Thời hạn",
            "Ngày bắt đầu ở"
        };

        public static string[] PhongHeaderText = new string[]
        {
            "Mã phòng",
            "Mã khu",
            "Loại phòng"
        };
        #endregion
    }
}
