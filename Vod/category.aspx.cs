using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class category : System.Web.UI.Page
    {


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bindGridView();
        }

        private void bindGridView()
        {
            VodioContainer ve = new VodioContainer();
            List<Category> cat = ve.Categories.Where(a => a.Name != null).ToList();
            GridView1.DataSource = cat;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindGridView();
            }
        }

        protected void SearchM_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Category> cat = ve.Categories.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
            GridView1.DataSource = cat;
            GridView1.DataBind();
        }

        //protected void showFilm_Click(object sender, EventArgs e)
        //{

        //    string htmlTable = "<table border='1' cellpadding='0' cellspacing='0'><tr>";
        //    htmlTable += "</tr>";
        //    foreach (Category dr in cat)
        //    {
        //        string id = dr.Id.ToString();
        //        string name = dr.Name.ToString();
        //        htmlTable += "<tr><td>" + id + "</td><td>" + name + "</td></tr>";
        //    }
        //    htmlTable += "</table>";
        //    catTable.Text = htmlTable;
        //    ve.SaveChanges();

        //    Category category = new Category()
        //    {
        //        Name = "asb"
        //    };

        //    ve.Categories.Add(category);
        //    ve.SaveChanges();

        //    var category1 = ve.Categories.Where(c => c.Name == "asb").FirstOrDefault();
        //    category1.Name = "gav";
        //    ve.Entry(category1).State = System.Data.Entity.EntityState.Modified;
        //    ve.SaveChanges();

        //    ve.Categories.Remove(category1);
        //    ve.SaveChanges();

        //}

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (!Page.IsPostBack)
            {
                VodioContainer ve = new VodioContainer();
                int id = int.Parse(e.CommandArgument.ToString());
                var dt = (int)((GridView)sender).DataKeys[id].Value;

                if (e.CommandName == "Delete")
                {
                    //var category1 = ve.Categories.Where(c => c.Id == dt).FirstOrDefault();
                    //ve.Categories.Remove(category1);
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
            Response.Redirect("category.aspx");
        }

        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void AddCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCat.aspx");
        }

        
    }
}