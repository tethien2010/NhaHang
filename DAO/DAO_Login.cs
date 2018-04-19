using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DTO;

namespace DAO
{
    public class DAO_Login
    {
        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public bool Login(string UserName, string Password)
        {
            DataTable ds = new DataTable();
            

            KetNoi kn = new KetNoi();
            kn.LayThongTinTruyVan("sp_Login");
            kn.AddParameter("@username",UserName);
            kn.AddParameter("@pass", Password);
            ds = kn.ExecuteDataSet().Tables[0];
            if (ds.Rows[0]["Result"] == "1")
            {
                DTO_Login.Is_login = true;
                DTO_Login.first_login = false;
                DTO_Login.Username = ds.Rows[0]["Username"].ToString();
                DTO_Login.ChucVu = ds.Rows[0]["ChucVu"].ToString();
                return true;
            }
            else
            {
                DTO_Login.Is_login = false;
                DTO_Login.first_login = false;
            }
            return false;
        }
    }
}
