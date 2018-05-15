using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.DAL;
using WebApplication3.Model;

namespace WebApplication3.BLL
{
   
    public class UserInfoBAL
    {
        UserInfoDAL userDal = new UserInfoDAL();
        public int count = UserInfoDAL.count;

        public object loadData(UserInfo user)
        {
           return userDal.loadData(user);
        }
    }
}