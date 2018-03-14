using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Categories_Click(object sender, EventArgs e)
        {
            Response.Redirect("category.aspx");
        }

        protected void Movies_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");

        }

        protected void Genres_Click(object sender, EventArgs e)
        {
            Response.Redirect("genre.aspx");
        }

        protected void Agents_Click(object sender, EventArgs e)
        {
            Response.Redirect("agent.aspx");
        }

        protected void Banners_Click(object sender, EventArgs e)
        {
            Response.Redirect("banner.aspx");

        }

        protected void Bundles_Click(object sender, EventArgs e)
        {
            Response.Redirect("bundle.aspx");
        }
    }
}