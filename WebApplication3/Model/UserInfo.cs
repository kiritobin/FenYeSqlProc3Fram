using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
    public class UserInfo
    {
        public UserInfo() { }
        public string tableName = "stuInfo";
        public string Column = "stuNO";
        public int ColType = 0;
        public int Order { get; set; }
        public string Columnlist = "*";
        public int PageSize { get; set; }
        public int PageNum { get; set; }
        public string Where = "";
        public  string PageCount { get;set; }
    }
}