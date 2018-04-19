using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using System.Data;
using System.ComponentModel;

namespace DAO
{
    public class DAO_MonAn
    {
        /// <summary>
        /// Lấy thông tin đầy đủ món ăn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BindingList<DTO_MonAn> LayDanhSachMonAn_Full(int id)
        {
            try
            {
                KetNoi kn = new KetNoi();
                kn.LayThongTinTruyVan("DanhSachMonAn");
                kn.AddParameter("@ID", id);
                DataSet ds = kn.ExecuteDataSet();
                //BindingList<DTO_MonAn> _list = new BindingList<DTO_MonAn>();
                DTO_MonAn dto = new DTO_MonAn();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        dto.ID = Convert.ToInt32(item["ID_MonAn"].ToString());
                        dto.TenMonAn = item["TenMonAn"].ToString();
                        dto.GhiChu = item["GhiChu"].ToString();
                        dto.NguoiTao = item["NguoiTao"].ToString();
                        dto.NguoiCapNhat = item["NguoiCapNhat"].ToString();
                        dto.NgayTao = Convert.ToDateTime(item["NgayTao"].ToString());
                        dto.NgayCapNhat = Convert.ToDateTime(item["NgayCapNhat"].ToString());
                        dto.DonGia = Convert.ToDouble(item["Giaban"].ToString());
                        dto.SoLuong = Convert.ToInt32(item["SoLuong"].ToString());
                        dto.list_monan.Add(dto);
                    }
                }
                return dto.list_monan;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        /// <summary>
        /// Chọn món ăn và số lượng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet ChonMonAn(int id)
        {
            try
            {
                KetNoi kn = new KetNoi();
                kn.LayThongTinTruyVan("DanhSachMonAn");
                kn.AddParameter("@ID", id);
                return kn.ExecuteDataSet();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
