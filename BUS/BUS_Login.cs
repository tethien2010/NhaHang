using System;
using System.Collections.Generic;
using System.Linq;
using DAO;

namespace BUS
{
    public class BUS_Login
    {
        public bool Login(string user, string pass)
        {
            DAO_Login dao = new DAO_Login();
            return dao.Login(user,pass);
        }
    }
}
