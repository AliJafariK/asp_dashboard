using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace Vod
{
    public partial class EditBanner : System.Web.UI.Page
    {
        public string dt;

        protected string dt_load()
        {
            return dt = Request.QueryString["dt"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = dt_load();
            if(!Page.IsPostBack)
                load_data();
        }

        protected void load_data()
        {
            int temp = Int32.Parse(dt);

            VodioContainer ve = new VodioContainer();
            Banner ban1 = ve.Banners.Where(c => c.Id == temp).FirstOrDefault();

            UploadState.Text = ban1.Url;
            Session["fileName"] = ban1.Url;
            Url2ClickText.Text = ban1.UrlToClick;
            MovieIdText.Text = ban1.MovieId.ToString();
            CategoryIdText.Text = ban1.CategoryId.ToString();
            GenreIdText.Text = ban1.GenreId.ToString();
            ListNameText.Text = ban1.ListName;


        }

        protected void UploadBan_Click(object sender, EventArgs e)
        {
            if (UploadBanner.HasFile)
            {
                UploadBanner.SaveAs(@Properties.Settings.Default.PosterDir + UploadBanner.FileName);
                UploadState.Text = "File Uploaded: " + UploadBanner.FileName;
                Session["fileName"] = UploadBanner.FileName;
            }
            else
            {
                UploadState.Text = "No File Uploaded.";
            }
        }

        protected void AddBanner_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();

            string fn = (string)Session["fileName"];

            Bitmap Banner = new Bitmap(Path.Combine(Properties.Settings.Default.PosterDir, fn));

            int temp = Int32.Parse(dt);


            var ban = ve.Banners.Where(b => b.Id == temp).FirstOrDefault();


            ban.Url = fn;
            ban.Width = Banner.Width;
            ban.Height = Banner.Height;
            ban.UrlToClick = Url2ClickText.Text;
            ban.MovieId = int.Parse(MovieIdText.Text);
            ban.CategoryId = int.Parse(CategoryIdText.Text);
            ban.GenreId = int.Parse(GenreIdText.Text);
            ban.ListName = ListNameText.Text;

            ve.Entry(ban).State = System.Data.Entity.EntityState.Modified;
            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Update successfully!');</script>");
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("banner.aspx");
        }
    }
}