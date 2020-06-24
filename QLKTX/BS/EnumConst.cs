using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.BS
{
    public static class EnumConst
    {

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
            "Mã NQL"
        };

        public static string[] LoaiPhongHeaderText = new string[]
        {
            "Mã loại phòng",
            "Số sinh viên tối đa",
            "Diện tích (met vuông)",
            "Đơn giá (đồng/tháng)"
        };
    }
}
