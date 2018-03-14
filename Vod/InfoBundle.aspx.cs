using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{

    public partial class InfoBundle : System.Web.UI.Page
    {
        public string dt;
        public int selectedTab;
        protected static List<Banner> selectedBanners = new List<Banner>();

        protected void Add2Selceted(Banner a)
        {
            selectedBanners.Add(a);
        }

        protected void Load_SelBanners()
        {
            selcetedBanners.DataSource = selectedBanners;
            selcetedBanners.DataBind();
        }


        protected string dt_load()
        {
            return Request.QueryString["dt"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = dt_load();
            selected_tab.Value = Request.Form[selected_tab.UniqueID];
            if(!Page.IsPostBack)
            {
                selectedTab = 1;
                Fill_GenCat();
                Fill_Banners();
                Show_All_Banners();
                Load_SelBanners();
                Show_All_Movies();
                Load_Selected_Movie();
            }
        }

        protected void Load_Selected_Movie()
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            Bundle thisbun = ve.Bundles.Where(b => b.Id == temp).FirstOrDefault();
            Movie bunMov = thisbun.Movies.FirstOrDefault();
            if(bunMov != null)
                SelectedMovieT.Text = bunMov.Title;
        }
        protected void Show_All_Movies()
        {
            VodioContainer ve = new VodioContainer();
            List<Movie> movs = ve.Movies.ToList();

            AllMovie.DataSource = movs;
            AllMovie.DataBind();
        }

        protected void Show_All_Banners()
        {
            VodioContainer ve = new VodioContainer();
            List<Banner> allbans = ve.Banners.ToList();

            banners.DataSource = allbans;
            banners.DataBind();
        }

        protected void Fill_Banners()
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            Bundle thisbun = ve.Bundles.Where(b => b.Id == temp).FirstOrDefault();
            List<Banner> bans = thisbun.Banners.ToList();

            BundleBanners.DataSource = bans;
            BundleBanners.DataBind();
        }

        protected void Fill_GenCat()
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            Bundle thisbun = ve.Bundles.Where(b => b.Id == temp).FirstOrDefault();

            genIdT.Text = thisbun.GenreId;
            catIdT.Text = thisbun.CateroryId;
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("bundle.aspx");
        }

        protected void addGenCat_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            Bundle thisbun = ve.Bundles.Where(b => b.Id == temp).FirstOrDefault();
            thisbun.GenreId = genIdT.Text;
            thisbun.CateroryId = catIdT.Text;
            ve.SaveChanges();
            selectedTab = 1;
            Response.Write(@"<script language='javascript'>alert('Add Genre and Category Successfully!');</script>");
        }

        protected void banners_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);
            int id = int.Parse(e.CommandArgument.ToString());
            
            List<Banner> bans = ve.Banners.ToList();

            if (e.CommandName == "Add2Ban")
            {
                Banner newban = bans[id];
                Add2Selceted(newban);
                Load_SelBanners();
                Fill_Banners();
            }
            selectedTab = 3;

        }

        protected void addBanner_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            Bundle bun1 = ve.Bundles.Where(a => a.Id == temp).FirstOrDefault();

            for (int i = 0; i < selectedBanners.Count(); i++)
            {
                var newbanId = selectedBanners[i].Id;

                bun1.Banners.Add(ve.Banners.SingleOrDefault(b => b.Id == newbanId));
                ve.SaveChanges();
            }

            selectedBanners.Clear();
            Load_SelBanners();

            Response.Write(@"<script language='javascript'>alert('Add Banners Successfully!');</script>");
        }

        protected void AllMovie_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);
            int id = int.Parse(e.CommandArgument.ToString());
            List<Movie> mov = ve.Movies.Where(a => a.Title.Contains(SearchText.Text)).ToList();
            Bundle bun = ve.Bundles.Where(b => b.Id == temp).FirstOrDefault();

            if (e.CommandName == "Sel4Ban")
            {
                bun.Movies.Add(mov[id]);
                ve.SaveChanges();
                SelectedMovieT.Text = mov[id].Title;
                selectedTab = 2;
                Response.Write(@"<script language='javascript'>alert('Add Movie Successfully!');</script>");

            }
        }

        protected void SearchMov_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Movie> movs = ve.Movies.Where(m => m.Title.Contains(SearchText.Text)).ToList();
            AllMovie.DataSource = movs;
            AllMovie.DataBind();
            selectedTab = 2;
        }

        protected void Back_Click1(object sender, EventArgs e)
        {
            Response.Redirect("bundle.aspx");
        }
    }
}