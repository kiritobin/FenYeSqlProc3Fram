using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
    public class UserInfo
    {
        public string tableName { get; set; }
        public string Column { get; set; }
        public int ColType { get; set; }
        public int Order { get; set; }
        public string Columnlist { get; set; }
        public int PageSize { get; set; }
        public int PageNum { get; set; }
        public string Where { get; set; }
        //public string PageCount { get; set; }
    }
}
