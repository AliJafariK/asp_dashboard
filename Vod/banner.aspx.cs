using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class banner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                show_gridView();
            }
        }

        protected void show_gridView()
        {
            VodioContainer ve = new VodioContainer();
            List<Banner> bans = ve.Banners.ToList();
            ban1.DataSource = bans;
            ban1.DataBind();
        }

        protected void ban1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int id = int.Parse(e.CommandArgument.ToString());
            var dt = (int)((GridView)sender).DataKeys[id].Value;

            if (e.CommandName == "Delete")
            {
                var ban = ve.Banners.Where(a => a.Id == dt).FirstOrDefault();
                ve.Banners.Remove(ban);
                ve.SaveChanges();
                show_gridView();
            }

            if(e.CommandName == "Edit")
            {
                Response.Redirect("EditBanner.aspx?dt=" + dt);
            }
        }

        protected void ban1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void AddBanner_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBan.aspx");
        }

        protected void ReorderBanner_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReorderBanner.aspx");
        }
    }
}