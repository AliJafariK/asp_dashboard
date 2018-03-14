using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class bundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                load_data();
            }
        }

        protected void load_data()
        {
            VodioContainer ve = new VodioContainer();
            List<Bundle> bun = ve.Bundles.ToList();
            bundles1.DataSource = bun;
            bundles1.DataBind();
        }

        protected void bundles_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void bundles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int id = int.Parse(e.CommandArgument.ToString());
            var dt = (int)((GridView)sender).DataKeys[id].Value;

            if (e.CommandName == "Delete")
            {
                var bun = ve.Bundles.Where(a => a.Id == dt).FirstOrDefault();
                ve.Bundles.Remove(bun);
                ve.SaveChanges();
                load_data();
            }

            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditBundle.aspx?dt=" + dt);
            }

            if (e.CommandName == "Info")
            {
                Response.Redirect("InfoBundle.aspx?dt=" + dt);
            }
        }

        protected void AddBundle_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBundle.aspx");
        }
    }
}