using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBundle_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            Bundle newbun = new Bundle()
            {
                Title = TitleBundleT.Text,
                //CateroryId = CategoryIdT.Text,
                //GenreId = GenreIdT.Text,
                Type = short.Parse(TypeT.Text)
            };
            ve.Bundles.Add(newbun);
            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("bundle.aspx");
        }
    }
}