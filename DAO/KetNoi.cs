using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class KetNoi
    {
        /// <summary>
        /// Cấu hình chuỗi kết nối SQL
        /// </summary>
        public string _Conn = "Data Source=.;Initial Catalog=NhaHang;Integrated Security=True";
        SqlConnection sqlCon;
        SqlDataAdapter da;
        SqlCommand cmd;

        public KetNoi()
        {
            sqlCon = new SqlConnection() { ConnectionString = _Conn };
        }
        
        /// <summary>
        /// Lấy thông tin truy vấn dữ liệu (Stored Proceduced)
        /// </summary>
        /// <param name="Query"></param>
        public void LayThongTinTruyVan(string Query)
        {
            cmd = new SqlCommand(Query, sqlCon) { CommandType = CommandType.StoredProcedure };

        }

        public void AddParameter(SqlParameter para)
        {
            cmd.Parameters.Add(para);
        }

        /// <summary>
        /// Thêm tham số vào câu truy vấn stored (Tham số stored, giá trị stored)
        /// </summary>
        /// <param name="param">Tham số stored</param>
        /// <param name="value">Giá trị tham số</param>
        public void AddParameter(string param, object value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        /// <summary>
        /// Trả về dữ liệu Datatable
        /// </summary>
        /// <param name="sp"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable()
        {
            using (SqlConnection connetion = new SqlConnection(_Conn))
            {
                DataTable dt = new DataTable("DataTable");

                da = new SqlDataAdapter(cmd) { SelectCommand = cmd };
                da.Fill(dt);

                cmd.Dispose();
                da.Dispose();
                return dt;
            }
        }

        /// <summary>
        /// Trả về dữ liệu dạng Dataset
        /// </summary>
        /// <param name="sp"></param>
        /// <returns></returns>
        public DataSet ExecuteDataSet()
        {
            DataSet ds = new DataSet("Dataset");

            da = new SqlDataAdapter(cmd) { SelectCommand = cmd };
            da.Fill(ds);

            cmd.Dispose();
            da.Dispose();
            return ds;
        }

    }
}
