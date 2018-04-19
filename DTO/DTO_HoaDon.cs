using System;
using System.Collections.Generic;
using System.Linq;


namespace DTO
{
    public class DTO_HoaDon
    {
        private bool _TrangThai;
        private double _TongTien;
        private string _GhiChu;
        private DateTime _ThoiGianBatDau;
        private int _ID_Ban;
        private Int64 _ID;

        public Int64 ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int ID_Ban
        {
            get { return _ID_Ban; }
            set { _ID_Ban = value; }
        }
        private string _NguoiTao;

        public string NguoiTao
        {
            get { return _NguoiTao; }
            set { _NguoiTao = value; }
        }

        private DateTime _NgayCapNhat;

        public DateTime NgayCapNhat
        {
            get { return _NgayCapNhat; }
            set { _NgayCapNhat = value; }
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


        public DateTime ThoiGianBatDau
        {
            get { return _ThoiGianBatDau; }
            set { _ThoiGianBatDau = value; }
        }

        private DateTime _ThoiGianKetThuc;

        public DateTime ThoiGianKetThuc
        {
            get { return _ThoiGianKetThuc; }
            set { _ThoiGianKetThuc = value; }
        }


        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }


        public double TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }


        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public DTO_HoaDon()
        {
            _ID = 0;
            _ID_Ban = 0;
            _TongTien = 0.0;
            _GhiChu = "";
            _NguoiTao = "";
            _NguoiCapNhat = "";
            _NgayTao = DateTime.Now;
            _NgayCapNhat = DateTime.Now;
            _ThoiGianBatDau = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss"));
            _ThoiGianKetThuc = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss"));
            _TrangThai = false;
        }

        public DTO_HoaDon(int id, int id_ban, double tongtien, string GhiChu, string NguoiTao, string NguoiCapNhat, DateTime NgayTao, DateTime NgayCapNhat, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc, bool TrangThai)
        {
            _ID = id;
            _ID_Ban = id_ban;
            _TongTien = tongtien;
            _GhiChu = GhiChu;
            _NguoiTao = NguoiTao;
            _NguoiCapNhat = NguoiCapNhat;
            _NgayTao = NgayTao;
            _NgayCapNhat = NgayCapNhat;
            _ThoiGianBatDau = ThoiGianBatDau;
            _ThoiGianKetThuc = ThoiGianKetThuc;
            _TrangThai = TrangThai;

        }
    }
}
