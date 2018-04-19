using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DTO;
using System.ComponentModel;

namespace DAO
{
    public class DAO_Ban
    {
        public BindingList<DTO_Ban> GetBan(int id)
        {
            try
            {
                KetNoi kn = new KetNoi();
                kn.LayThongTinTruyVan("sp_getBan");
                kn.AddParameter("@ID", id);
                DataSet ds = kn.ExecuteDataSet();
                BindingList<DTO_Ban> _list = new BindingList<DTO_Ban>();
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DTO_Ban dto = new DTO_Ban();
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        dto.ID = Convert.ToInt32(item["ID_Ban"].ToString());
                        dto.TenBan = item["TenBan"].ToString();
                        _list.Add(dto);
                    }
                }
                return _list;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
