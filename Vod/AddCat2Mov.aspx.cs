using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddCat2Mov : System.Web.UI.Page
    {
        protected void MovCat_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //MovCat.PageIndex = e.NewPageIndex;
            //Load_MovieCategory();
        }

        protected void AllCat_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //AllCat.PageIndex = e.NewPageIndex;
            //bindAllCat();
        }

        private void bindAllCat()
        {
            VodioContainer ve = new VodioContainer();
            List<Category> cat = ve.Categories.Where(a => a.Id != null).ToList();
            AllCat.DataSource = cat;
            AllCat.DataBind();
        }

        private String dt;


        protected void Page_Load(object sender, EventArgs e)
        {
            dt = Return_Dt();
            if (!Page.IsPostBack)
            {
                bindAllCat();
                Load_MovieCategory();
            }
        }

        protected void Load_MovieCategory()
        {
            VodioContainer ve = new VodioContainer();
            //String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            List<Category> cat2 = ve.Categories.Where(a => a.Movies.Any(m => m.Id == temp)).ToList();
            MovCat.DataSource = cat2;
            MovCat.DataBind();
        }

        protected void SearchM_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Category> cat = ve.Categories.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
            AllCat.DataSource = cat;
            AllCat.DataBind();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        protected String Return_Dt()
        {
            String dt = Request.QueryString["dt"];
            return dt;
        }

        protected void AllCat_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            VodioContainer ve = new VodioContainer();
            //String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            int id = int.Parse(e.CommandArgument.ToString());
            var tt = (int)((GridView)sender).DataKeys[id].Value;
            List<Category> cats = ve.Categories.Where(a => a.Name.Contains(SearchBox.Text)).ToList();


            if (e.CommandName == "Add2Cat")
                {
                //Category newCat = ve.Categories.Where(c => c.Id == tt).FirstOrDefault();
                    Category newCat = cats[id];
                    Movie thisMov = ve.Movies.Where(a => a.Id == temp).FirstOrDefault();
                    thisMov.Categories.Add(newCat);
                    ve.SaveChanges();
                    Load_MovieCategory();

                    Check_CategoryGenre_table(tt, temp);
                }
            //}
        }

        protected void Check_CategoryGenre_table(int catId,int movId)
        {
            VodioContainer ve = new VodioContainer();
            Movie mov = ve.Movies.Where(m => m.Id == movId).FirstOrDefault();
            List<Genre> gens = ve.Genres.Where(a => a.Movies.Any(m => m.Id == movId)).ToList();
            foreach (Genre g in gens)
            {
                if (!Is_Exist_InCategoryGenre(catId,g.Id))
                {
                    Add_CategoryGenre(catId,g.Id);
                }
            }
        }

        protected void Add_CategoryGenre(int catId,int genId)
        {
            VodioContainer ve = new VodioContainer();
            CategoryGenre cg = new CategoryGenre()
            {
                Genre = ve.Genres.Where(a => a.Id == genId).FirstOrDefault(),
                Category = ve.Categories.Where(a => a.Id == catId).FirstOrDefault()

            };

            ve.CategoryGenres.Add(cg);
            ve.SaveChanges();
        }

        protected Boolean Is_Exist_InCategoryGenre(int catId,int genId)
        {
            VodioContainer ve = new VodioContainer();
            List<CategoryGenre> cgs = ve.CategoryGenres.Where(a => a.Category.Id == catId).ToList();
            foreach(CategoryGenre temp in cgs)
            {
                if (temp.Genre.Id == genId)
                    return true;
            }
            return false;
        }
        protected void MovCat_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
                VodioContainer ve = new VodioContainer();
                //String dt = Request.QueryString["dt"];
                int temp = Int32.Parse(dt);
                int id = int.Parse(e.CommandArgument.ToString());
                var tt = (int)((GridView)sender).DataKeys[id].Value;

                if (e.CommandName == "DeleteGen")
                {
                    Movie mov = ve.Movies.Where(m => m.Id == temp).FirstOrDefault();
                    Category cat = ve.Categories.Where(g => g.Id == tt).FirstOrDefault();
                    mov.Categories.Remove(cat);
                    ve.SaveChanges();
                    Load_MovieCategory();
                }
            //}
        }

    }
}