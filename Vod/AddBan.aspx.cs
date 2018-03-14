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
    public partial class AddBan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

            Banner ban = new Banner()
            {
                Url = fn,
                Width = Banner.Width,
                Height = Banner.Height,
                UrlToClick = Url2ClickText.Text,
                MovieId = int.Parse(MovieIdText.Text),
                CategoryId = int.Parse(CategoryIdText.Text),
                GenreId = int.Parse(GenreIdText.Text),
                ListName = ListNameText.Text
            };

            ve.Banners.Add(ban);
            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("banner.aspx");
        }
    }
}