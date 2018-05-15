using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication3.Model;

namespace WebApplication3.DAL
{
    public class UserInfoDAL
    {
        SQLHelper sqlHelp = new SQLHelper();
        public static int  count;
        public object loadData(UserInfo user)
        {
            SqlParameter[] paraValues = {
                                        new SqlParameter("@strTable",SqlDbType.VarChar),
                                        new SqlParameter("@strColumn",SqlDbType.VarChar),
                                        new SqlParameter("@intColType",SqlDbType.Int),
                                        new SqlParameter("@intOrder",SqlDbType.Int),
                                        new SqlParameter("@strColumnlist",SqlDbType.VarChar),
                                        new SqlParameter("@intPageSize",SqlDbType.Int),
                                        new SqlParameter("@intPageNum",SqlDbType.Int),
                                        new SqlParameter("@strWhere",SqlDbType.VarChar),
                                        new SqlParameter("@intPageCount",SqlDbType.Int)
                                        };

            paraValues[0].Value = user.tableName;
            paraValues[1].Value = user.Column;
            paraValues[2].Value = user.ColType;
            paraValues[3].Value = user.Order;
            paraValues[4].Value =user.Columnlist;
            paraValues[5].Value = user.PageSize;
            paraValues[6].Value = user.PageNum;
            paraValues[7].Value = user.Where;
            paraValues[8].Direction = ParameterDirection.Output;
            object obj = sqlHelp.ExecuteProcTable("sp_page", paraValues);
            count = Convert.ToInt32(paraValues[8].Value);
            return obj;
            
        }
    }
}