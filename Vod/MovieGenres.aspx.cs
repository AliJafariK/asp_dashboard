using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class MovieGenres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            VodioContainer ve = new VodioContainer();
            List<Genre> gen = ve.Genres.Where(a => a.Movies.Any(m => m.Id == temp)).ToList();
            GenresShow.DataSource = gen;
            GenresShow.DataBind();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        protected void AddGen2Mov_Click(object sender, EventArgs e)
        {
            String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            Response.Redirect("AddGen2Mov.aspx?dt=" + dt);
        }
    }
}