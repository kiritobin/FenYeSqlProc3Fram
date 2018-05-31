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
        UserInfoBLL userBll = new UserInfoBLL();
        UserInfo user = new UserInfo();
        int count = 1;
        private void loadData()
        {
            count = Convert.ToInt32(ViewState["count"]);
            user.tableName = "stuInfo";
            user.Column = "stuNO";
            user.ColType = 0;
            user.Order = 0;
            user.Columnlist = "*";
            user.PageSize = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            user.PageNum = count;
            user.Where = "";
            GridView1.DataSource = userBll.loadData(user);
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"] = 1;
                loadData();
                Label1.Text = Label1.Text = "当前页：" + count;
                Label2.Text = "总页数：" + userBll.Count();
            }
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            ViewState["count"] = 1;
            loadData();
            Label1.Text = Label1.Text = "当前页：" + count;
            Label2.Text = "总页数：" + userBll.Count();
        }

        protected void btnPre_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ViewState["count"]) > 1)
            {
                ViewState["count"] = Convert.ToInt32(ViewState["count"]) - 1;
                loadData();
                Label1.Text = "当前页：" + count;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ViewState["count"]) < userBll.Count())
            {
                ViewState["count"] = Convert.ToInt32(ViewState["count"]) + 1;
                loadData();
                Label1.Text = "当前页：" + count;
            }
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            ViewState["count"] = userBll.Count();
            loadData();
            Label1.Text = "当前页：" + count;
        }

        protected void btnGO_Click(object sender, EventArgs e)
        {
            try
            {
                ViewState["count"] = Convert.ToInt32(TextBox1.Text);
            }
            catch
            {
                return;
            }
            if (Convert.ToInt32(ViewState["count"]) <= userBll.Count())
            {
                loadData();
                Label1.Text = "当前页：" + count;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('超出范围');", true);
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            ViewState["count"] = 1;
            loadData();
            Label1.Text = "当前页：" + count;
            Label2.Text = "总页数：" + userBll.Count();
        }
    }
}
