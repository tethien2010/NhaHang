using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_NhanVien
    {
        /// <summary>
        /// Mã Nhân viên
        /// </summary>
        public Int64 MaNV { get; set; }
        /// <summary>
        /// Tên đăng nhập nhân viên
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Mật khẩu nhân viên
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Họ và tên nhân viên
        /// </summary>
        public string TenNV { get; set; }
        /// <summary>
        /// Địa chỉ nhân viên
        /// </summary>
        public string DiaChi { get; set; }
        /// <summary>
        /// Các thông tin cần ghi chú nhân viên
        /// </summary>
        public string GhiChu { get; set; }
        /// <summary>
        /// Email của nhân viên
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Số điện thoại của nhân viên
        /// </summary>
        public string SDT { get; set; }

        public DTO_NhanVien()
        {
            MaNV = 0;
            UserName = "";
            Password = "";
            TenNV = "";
            DiaChi = "";
            GhiChu = "";
            Email = "";
            SDT = "012345678";
        }
        public DTO_NhanVien(Int64 manv, string username, string password, string tennv, string diachi, string ghichu, string email, string sdt)
        {
            MaNV = manv;
            UserName = username;
            Password = password;
            TenNV = tennv;
            DiaChi = diachi;
            GhiChu = ghichu;
            Email = email;
            SDT = sdt;
        }
    }
}
