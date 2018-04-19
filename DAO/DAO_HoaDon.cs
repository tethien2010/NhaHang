using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO
{
    public class DAO_HoaDon
    {
        public DataSet LuuHoaDon(int ID_Ban, string GhiChu, double TongTien, int TrangThai, string NguoiTao, string NguoiCapNhat)
        {
            KetNoi kn = new KetNoi();
            kn.LayThongTinTruyVan("sp_getBan");
            kn.AddParameter("@ID_Ban", ID_Ban);
            DataSet ds = kn.ExecuteDataSet();

            return ds;
        }
    }
}
