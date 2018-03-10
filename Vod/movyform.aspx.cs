using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class movyform : System.Web.UI.Page
    {
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bindGridView();
        }

        private void bindGridView()
        {
            VodioContainer ve = new VodioContainer();
            List<Movie> mov = ve.Movies.Where(a => a.Title != null).ToList();
            GridView1.DataSource = mov;
            GridView1.DataBind();
        }

        protected void SearchM_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Movie> mov = ve.Movies.Where(a => a.Title.Contains(SearchBox.Text)).ToList();
            GridView1.DataSource = mov;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindGridView();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Movie> movs = ve.Movies.Where(a => a.Title.Contains(SearchBox.Text)).ToList();

            int id = int.Parse(e.CommandArgument.ToString());
            //var dt = (int)((GridView)sender).DataKeys[id].Value;
            int dt = movs[id].Id ;

            if (e.CommandName == "Delete")
            {
                //var mov1 = ve.Movies.Where(c => c.Id == dt).FirstOrDefault();
                //mov1.
                //var mov1 = ve.Movies.Where(c => c.Id == dt).FirstOrDefault();


                //ve.Movies.Remove(mov1);
                //ve.SaveChanges();
                //Show_Click(null, null);
            }
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditMoviePage.aspx?dt=" + dt);
            }
            if (e.CommandName == "Genres")
            {
                Response.Redirect("MovieGenres.aspx?dt=" + dt);
            }
            if (e.CommandName == "Categories")
            {
                Response.Redirect("MovieCategories.aspx?dt=" + dt);
            }
            if (e.CommandName == "Roles")
            {
                Response.Redirect("MovieRoles.aspx?dt=" + dt);
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void AddMovie_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewMovie.aspx");
        }

    }
}