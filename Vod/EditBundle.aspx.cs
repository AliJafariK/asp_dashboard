using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class EditBundle : System.Web.UI.Page
    {
        public string dt;

        protected string dt_load()
        {
            return Request.QueryString["dt"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = dt_load();
            if(!Page.IsPostBack)
            {
                load_data();
            }
        }

        protected void load_data()
        {
            int temp = Int32.Parse(dt);

            VodioContainer ve = new VodioContainer();
            Bundle bun1 = ve.Bundles.Where(c => c.Id == temp).FirstOrDefault();

            TitleBundleT.Text = bun1.Title;
            //CategoryIdT.Text = bun1.CateroryId;
            //GenreIdT.Text = bun1.GenreId;
            TypeT.Text = bun1.Type.ToString();
        }

        protected void AddBundle_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);
            Bundle bun1 = ve.Bundles.Where(b => b.Id == temp).FirstOrDefault();

            bun1.Title = TitleBundleT.Text;
            //bun1.CateroryId = CategoryIdT.Text;
            //bun1.GenreId = GenreIdT.Text;
            bun1.Type = short.Parse(TypeT.Text);

            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Update successfully!');</script>");

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("bundle.aspx");
        }
    }
}