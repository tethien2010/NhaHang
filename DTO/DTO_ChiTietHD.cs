using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;


namespace DTO
{
    public class DTO_ChiTietHD
    {
        /// <summary>
        /// ID chi tiết hóa đơn
        /// </summary>
        public Int64 ID_CT { get; set; }
        /// <summary>
        /// ID hóa đơn
        /// </summary>
        public Int64 ID_HD { get; set; }
        /// <summary>
        /// ID món ăn
        /// </summary>
        public Int64 ID_MA { get; set; }
        /// <summary>
        /// Đơn giá của món ăn
        /// </summary>
        public double DonGia { get; set; }
        /// <summary>
        /// ngày tạo hóa đơn
        /// </summary>
        public DateTime NgayTao { get; set; }
        /// <summary>
        /// Thời gian bắt đầu lập hóa đơn
        /// </summary>
        public DateTime ThoiGianBatDau { get; set; }
        /// <summary>
        /// Thời gian khi thanh toán hóa đơn
        /// </summary>
        public DateTime ThoiGianKetThuc { get; set; }
        public string GhiChu { get; set; }
        /// <summary>
        /// Số lượng món ăn
        /// </summary>
        public int SoLuong { get; set; }
        /// <summary>
        /// Thành tiền = đơn giá * số lượng
        /// </summary>
        /// 
        private double? _ThanhTien;
        public double? ThanhTien 
        {
            get { return SoLuong * DonGia; }

            set { _ThanhTien = value; }
        }

        public string TenMonAn { get; set; }

        public DTO_ChiTietHD()
        {
            ID_CT = 0;
            ID_HD = 0;
            ID_MA = 0;
            DonGia = 0.0;
            NgayTao = Convert.ToDateTime(NgayTao.ToString("dd/MM/yyyy"));
            ThoiGianBatDau = Convert.ToDateTime(ThoiGianBatDau.ToString("HH:mm"));
            ThoiGianKetThuc = Convert.ToDateTime(ThoiGianKetThuc.ToString("HH:mm"));
            GhiChu = "";
            SoLuong = 0;
            ThanhTien = 0;
        }
        public double  f_ThanhTien()
        {
            return  DonGia * SoLuong;
        }

        public DTO_ChiTietHD(Int64 id_ct, Int64 id_hd, Int64 id_ma, double dongia, DateTime ngaytao, DateTime thoigianbatdau, DateTime thoigianketthuc, string ghichu, int soluong, double thanhtien)
        {
            ID_CT = id_ct;
            ID_HD = id_hd;
            ID_MA = id_ma;
            DonGia = dongia;
            NgayTao = ngaytao;
            ThoiGianBatDau = thoigianbatdau;
            ThoiGianKetThuc = thoigianketthuc;
            GhiChu = ghichu;
            SoLuong = soluong;
            ThanhTien = thanhtien;
        }
        public BindingList<DTO_ChiTietHD> list_chitiet = new BindingList<DTO_ChiTietHD>();
    }

}
