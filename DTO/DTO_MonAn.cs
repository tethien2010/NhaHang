using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DTO
{
    public class DTO_MonAn
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _TenMonAn;

        public string TenMonAn
        {
            get { return _TenMonAn; }
            set { _TenMonAn = value; }
        }

        private string _NguoiTao;

        public string NguoiTao
        {
            get { return _NguoiTao; }
            set { _NguoiTao = value; }
        }

        private DateTime _NgayTao;
        public DateTime NgayTao
        {
            get { return _NgayTao; }
            set { _NgayTao = value; }
        }

        private string _NguoiCapNhat;

        public string NguoiCapNhat
        {
            get { return _NguoiCapNhat; }
            set { _NguoiCapNhat = value; }
        }
        private DateTime _NgayCapNhat;

        public DateTime NgayCapNhat
        {
            get { return _NgayCapNhat; }
            set { _NgayCapNhat = value; }
        }

        private double _DonGia;

        public double DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private bool _Chon;
        public bool Chon
        {
            get { return _Chon; }
            set { _Chon = value; }
        }

        public DTO_MonAn()
        {
            _ID = 0;
            _TenMonAn = "";
            _GhiChu = "";
            _NguoiTao = "";
            _NguoiCapNhat = "";
            _NgayTao = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            _NgayCapNhat = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            _DonGia = 0.0;
            _SoLuong = 0;
        }
        /// <summary>
        /// Lấy thông tin đầy đủ về món ăn
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenmonan"></param>
        /// <param name="ghichu"></param>
        /// <param name="nguoitao"></param>
        /// <param name="nguoicapnhat"></param>
        /// <param name="ngaytao"></param>
        /// <param name="ngaycapnhat"></param>
        /// <param name="giaban"></param>
        public DTO_MonAn(int id, string tenmonan, string ghichu, string nguoitao, string nguoicapnhat, DateTime ngaytao, DateTime ngaycapnhat, double giaban)
        {
            _ID = id;
            _TenMonAn = tenmonan;
            _GhiChu = ghichu;
            _NguoiTao = nguoitao;
            _NguoiCapNhat = nguoicapnhat;
            _NgayTao = ngaytao;
            _NgayCapNhat = ngaycapnhat;
            _DonGia = giaban;
        }
        /// <summary>
        /// Lấy danh sách để khách hàng chọn món ăn 
        /// Gồm tên món và số lượng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenmonan"></param>
        /// <param name="soluong"></param>
        /// 
        public DTO_MonAn(bool chon,int id, string tenmonan, int soluong,double dongia)
        {
            _Chon = chon;
            _ID = id;
            _TenMonAn = tenmonan;
            _DonGia = dongia;
            _SoLuong = soluong;
        }
        
        public BindingList<DTO_MonAn> list_monan = new BindingList<DTO_MonAn>(); 
    }
}
