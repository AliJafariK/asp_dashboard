using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class InfoBundle : System.Web.UI.Page
    {
        public string dt;

        protected string dt_load()
        {
            return Request.QueryString["dt"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = dt_load();
            selected_tab.Value = Request.Form[selected_tab.UniqueID];

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("bundle.aspx");
        }
    }
}