using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.BLL;
using WebApplication3.DAL;

using WebApplication3.Model;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserInfoBAL userBll = new UserInfoBAL();
        UserInfo user = new UserInfo();
        static int i = 1;
        private void loadData()
        {
            user.tableName = "stuInfo";
            user.Column = "stuNO";
            user.ColType = 0;
            user.Order = 0;
            user.Columnlist = "*";
            user.PageSize = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            user.PageNum = i;
            user.Where = "";
            GridView1.DataSource = userBll.loadData(user);
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                i = 1;
                loadData();
                Label1.Text = "当前页：" + i;
            }
            Label2.Text = "总页数：" + UserInfoDAL.count;
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            i = 1;
            loadData();
            Label1.Text = "当前页：" + 1;
        }
        
        protected void btnPre_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                i--;
                loadData();
                Label1.Text = "当前页：" + i;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (i < userBll.count)
            {
                i++;
                i++;
                loadData();
                Label1.Text = "当前页：" + i;
            }
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            i = userBll.count;
            loadData();
            Label1.Text = "当前页：" + i;
        }

        protected void btnGO_Click(object sender, EventArgs e)
        {
            try
            {
                i = Convert.ToInt32(TextBox1.Text);
            }
            catch
            {
                return;
            }
            if (i <= userBll.count)
            {
                loadData();
                Label1.Text = "当前页：" + i;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('超出范围');", true);
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            i = 1;
            loadData();
            Label1.Text = "当前页：" + i;
            Label2.Text = "总页数：" + UserInfoDAL.count;
        }
    }
}
