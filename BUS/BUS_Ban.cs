using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DAO;
using System.ComponentModel;
using DTO;

namespace BUS
{
    public class BUS_Ban
    {
        public BindingList<DTO_Ban> GetBan(int id)
        {
            DAO_Ban dao = new DAO_Ban();
            return dao.GetBan(id);
        }
    }
}
