using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddCat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddCategory_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            Category cat = new Category()
            {
                Name = CatNameText.Text
            };
            ve.Categories.Add(cat);
            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("category");
        }
    }
}