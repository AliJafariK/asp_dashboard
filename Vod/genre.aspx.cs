using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{

    public partial class genre : System.Web.UI.Page
    {
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bindGridView();
        }

        private void bindGridView()
        {
            VodioContainer ve = new VodioContainer();
            List<Genre> gen = ve.Genres.Where(a => a.Name != null).ToList();

            GridView1.DataSource = gen;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                VodioContainer ve = new VodioContainer();
                List<Genre> gen = ve.Genres.Where(a => a.Name != null).ToList();
                GridView1.DataSource = gen;
                GridView1.DataBind();
            }
        }
        protected void SearchM_Click(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
                VodioContainer ve = new VodioContainer();
                List<Genre> gen = ve.Genres.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
                GridView1.DataSource = gen;
                GridView1.DataBind();
            //}
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (!Page.IsPostBack)
            {
                VodioContainer ve = new VodioContainer();
                int id = int.Parse(e.CommandArgument.ToString());
                var dt = (int)((GridView)sender).DataKeys[id].Value;

                if (e.CommandName == "Delete")
                {
                    //var gen1 = ve.Genres.Where(c => c.Id == dt).FirstOrDefault();
                    //ve.Genres.Remove(gen1);
                    //ve.SaveChanges();
                    //showFilm_Click(null, null);
                }
                if (e.CommandName == "Edit")
                {
                    //Response.Redirect("EditPage.aspx?dt=" + dt);
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("genre.aspx");
        }

        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void AddGen_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddGen.aspx");
        }

    }
}