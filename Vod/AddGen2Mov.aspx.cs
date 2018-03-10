using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddGen2Mov : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = Return_Dt();
            if (!Page.IsPostBack)
            {
                VodioContainer ve = new VodioContainer();
                List<Genre> gen = ve.Genres.Where(a => a.Id != null).ToList();
                AllGen.DataSource = gen;
                AllGen.DataBind();
                Load_MovieGenre();
            }
            
        }

        protected void Load_MovieGenre()
        {
            VodioContainer ve = new VodioContainer();
            //String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            List<Genre> gen2 = ve.Genres.Where(a => a.Movies.Any(m => m.Id == temp)).ToList();
            MovGen.DataSource = gen2;
            MovGen.DataBind();
        }

        protected void SearchM_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Genre> gen = ve.Genres.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
            AllGen.DataSource = gen;
            AllGen.DataBind();
        }

        private String dt;
        

        protected String Return_Dt()
        {
            String dt = Request.QueryString["dt"];

            return dt;
        }

        protected void AllGen_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            VodioContainer ve = new VodioContainer();
            //String dt = Return_Dt();
            int temp = Int32.Parse(dt);
            int id = int.Parse(e.CommandArgument.ToString());

            List<Genre> gens = ve.Genres.Where(a => a.Name.Contains(SearchBox.Text)).ToList();


            //string idt = AllGen.Rows[id].Cells[0].Text;
            //int tid = (int)((GridView)sender).DataKeys[].Value;
            //var tt = (int)((GridView)sender).DataKeys[id].Value;


            if (e.CommandName == "Add2Gen")
            {
                //Genre newGen = ve.Genres.Where(g => g.Id == tt).FirstOrDefault();
                Genre newGen = gens[id];
                Movie thisMov = ve.Movies.Where(a => a.Id == temp).FirstOrDefault();
                thisMov.Genres.Add(newGen);
                ve.SaveChanges();
                Load_MovieGenre();

                Check_CategoryGenre_table(newGen.Id, temp);
            }
        }

        protected void Check_CategoryGenre_table_delete(int genId, int movId)
        {
            VodioContainer ve = new VodioContainer();
            Movie mov = ve.Movies.Where(m => m.Id == movId).FirstOrDefault();
            List<Category> cats = ve.Categories.Where(a => a.Movies.Any(m => m.Id == movId)).ToList();

            foreach (Category c in cats)
            {
                if (!Exist_GenreCategory_InOthers(c.Id, genId))
                {
                    List<CategoryGenre> cgs = ve.CategoryGenres.Where(a => a.Genre.Id == genId).ToList();
                    CategoryGenre cgs2 = cgs.Where(a => a.Category.Id == c.Id).FirstOrDefault();
                    ve.CategoryGenres.Remove(cgs2);
                    ve.SaveChanges();
                }
                //if (Is_Exist_InCategoryGenre(c.Id, genId))
                //{
                //    //Add_CategoryGenre(c.Id, genId);
                //}
            }
        }

         protected bool Exist_GenreCategory_InOthers(int catId,int genId)
        {
            VodioContainer ve = new VodioContainer();
            List<Movie> movs = ve.Movies.Where(m => m.Id != null).ToList();
            int temp = Int32.Parse(dt);

            Movie thisMovie = movs[temp];
            movs.Remove(thisMovie);

            foreach (Movie m in movs)
            {
                List<Category> cats = m.Categories.ToList();
                List<Genre> gens = m.Genres.ToList();
                foreach (Category c in cats)
                {
                    foreach (Genre g in gens)
                    {
                        if (c.Id == catId && g.Id == genId)
                            return true;
                    }
                }
            }

            return false;
        }

        protected void Check_CategoryGenre_table(int genId, int movId)
        {
            VodioContainer ve = new VodioContainer();
            Movie mov = ve.Movies.Where(m => m.Id == movId).FirstOrDefault();
            List<Category> cats = ve.Categories.Where(a => a.Movies.Any(m => m.Id == movId)).ToList();
            foreach (Category c in cats)
            {
                if (!Is_Exist_InCategoryGenre(c.Id, genId))
                {
                    Add_CategoryGenre(c.Id, genId);
                }
            }
        }

        protected void Add_CategoryGenre(int catId, int genId)
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

        protected Boolean Is_Exist_InCategoryGenre(int catId, int genId)
        {
            VodioContainer ve = new VodioContainer();
            List<CategoryGenre> cgs = ve.CategoryGenres.Where(a => a.Category.Id == catId).ToList();
            foreach (CategoryGenre temp in cgs)
            {
                if (temp.Genre.Id == genId)
                    return true;
            }
            return false;
        }

        protected void MovGen_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            //String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            int id = int.Parse(e.CommandArgument.ToString());
            var tt = (int)((GridView)sender).DataKeys[id].Value;

            if (e.CommandName == "DeleteGen")
            {
                Movie mov = ve.Movies.Where(m => m.Id == temp).FirstOrDefault();
                Genre gen = ve.Genres.Where(g => g.Id == tt).FirstOrDefault();
                mov.Genres.Remove(gen);
                ve.SaveChanges();

                Check_CategoryGenre_table_delete(tt,temp);

                Load_MovieGenre();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        
    }
}