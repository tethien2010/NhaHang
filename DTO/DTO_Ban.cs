using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Ban
    {
        // Fields...
        private DateTime _NgayTao;
        private string _NguoiTao;
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _TenBan;

        public string TenBan
        {
            get { return _TenBan; }
            set { _TenBan = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }


        public string NguoiTao
        {
            get { return _NguoiTao; }
            set { _NguoiTao = value; }
        }

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

        public DTO_Ban()
        {
            _ID = 0;
            _TenBan = "";
            _GhiChu = "";
            _NguoiTao = "";
            _NguoiCapNhat = "";
            _NgayTao = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            _NgayCapNhat = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public DTO_Ban(int id, string tenban, string ghichu, string nguoitao, string nguoicapnhat, DateTime ngaytao, DateTime ngaycapnhat){
            _ID = ID;
            _TenBan = tenban;
            _GhiChu = ghichu;
            _NguoiTao = nguoitao;
            _NguoiCapNhat = nguoicapnhat;
            _NgayTao = ngaytao;
            _NgayCapNhat = ngaycapnhat;
        }
    }
}
