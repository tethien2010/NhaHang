using System;
using System.Collections.Generic;
using System.Linq;
using DAO;
using System.Data;


namespace BUS
{
    public class BUS_MonAn
    {
        /// <summary>
        /// Chọn món ăn và số lượng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet ChonMonAn(int id)
        {
            DAO_MonAn dao = new DAO_MonAn();
            return dao.ChonMonAn(id);
        }
        
        
    }
}
