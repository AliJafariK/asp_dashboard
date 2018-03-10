using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class MovieCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            VodioContainer ve = new VodioContainer();
            List<Category> cat = ve.Categories.Where(a => a.Movies.Any(m => m.Id == temp)).ToList();
            CategoriesShow.DataSource = cat;
            CategoriesShow.DataBind();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        protected void AddCat_Click(object sender, EventArgs e)
        {
            String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            Response.Redirect("AddCat2Mov.aspx?dt=" + dt);
        }
    }
}