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
    public partial class EditMoviePage : System.Web.UI.Page
    {
        public string dt;

        protected string dt_load()
        {
            return Request.QueryString["dt"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dt = dt_load();
            if (!Page.IsPostBack)
            {
                int temp = Int32.Parse(dt);

                VodioContainer ve = new VodioContainer();
                Movie mov1 = ve.Movies.Where(c => c.Id == temp).FirstOrDefault();

                MovieTitleText.Text = mov1.Title;
                DescriptionText.Text = mov1.Description;
                YearText.Text = mov1.Year.ToString();
                if (mov1.Featured == true)
                    FeaturedCheckBox.Checked = true;
                else
                    FeaturedCheckBox.Checked = false;
                PriceText.Text = mov1.Price.ToString();
                FolderNameText.Text = mov1.FolderName.ToString();
                EditorialRateText.Text = mov1.EditorialRate.ToString();
                if (mov1.Disable == true)
                    DisableCheckbox.Checked = true;
                else
                    DisableCheckbox.Checked = false;

                if (mov1.Downloadables.Contains("320"))
                    Downloadables320.Checked = true;
                else
                    Downloadables320.Checked = false;

                if (mov1.Downloadables.Contains("480"))
                    Downloadables480.Checked = true;
                else
                    Downloadables480.Checked = false;

                if (mov1.Downloadables.Contains("720"))
                    Downloadables720.Checked = true;
                else
                    Downloadables720.Checked = false;

                if (mov1.Downloadables.Contains("1080"))
                    Downloadables1080.Checked = true;
                else
                    Downloadables1080.Checked = false;


                if (mov1.Qualities.Contains("320"))
                    Qualities320.Checked = true;
                else
                    Qualities320.Checked = false;

                if (mov1.Qualities.Contains("480"))
                    Qualities480.Checked = true;
                else
                    Qualities480.Checked = false;

                if (mov1.Qualities.Contains("720"))
                    Qualities720.Checked = true;
                else
                    Qualities720.Checked = false;

                if (mov1.Qualities.Contains("1080"))
                    Qualities1080.Checked = true;
                else
                    Qualities1080.Checked = false;


                UploadState.Text = mov1.Thumbnail.Url;
                Session["fileName"] = mov1.Thumbnail.Url;


            }
        }

        public bool IsNumeric(string input)
        {
            double test;
            return double.TryParse(input, out test);
        }

        protected void Update_Click1(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            bool done = true;
            String.IsNullOrEmpty(MovieTitleText.Text);
            if (String.IsNullOrEmpty(MovieTitleText.Text) || String.IsNullOrEmpty(DescriptionText.Text) ||
                String.IsNullOrEmpty(PriceText.Text) || String.IsNullOrEmpty(YearText.Text) ||
                String.IsNullOrEmpty(FolderNameText.Text))
            {
                Response.Write(@"<script language='javascript'>alert('All * fileds should be filled!');</script>");
                done = false;
            }
            else if (!IsNumeric(PriceText.Text))
            {
                Response.Write(@"<script language='javascript'>alert('Price should be number!');</script>");
                done = false;
            }
            else if (!IsNumeric(EditorialRateText.Text))
            {
                Response.Write(@"<script language='javascript'>alert('EditorialRate should be number!');</script>");
                done = false;
            }
            else if (!IsNumeric(YearText.Text))
            {
                Response.Write(@"<script language='javascript'>alert('Year should be number!');</script>");
                done = false;
            }

            if (done)
            {
                string Qua = "";

                if (Qualities320.Checked)
                    Qua += "320,";
                if (Qualities480.Checked)
                    Qua += "480,";
                if (Qualities720.Checked)
                    Qua += "720,";
                if (Qualities1080.Checked)
                    Qua += "1080,";
                if (Qua.Length >= 1)
                    if (Qua[Qua.Length - 1] == ',')
                        Qua = Qua.Remove(Qua.Length - 1);

                string dl = "";
                if (Downloadables320.Checked)
                    dl += "320,";
                if (Downloadables480.Checked)
                    dl += "480,";
                if (Downloadables720.Checked)
                    dl += "720,";
                if (Downloadables1080.Checked)
                    dl += "1080,";
                if (dl.Length >= 1)
                    if (dl[dl.Length - 1] == ',')
                        dl = dl.Remove(dl.Length - 1);

                string fn = (string)Session["fileName"];
                Bitmap poster = new Bitmap(Path.Combine(Properties.Settings.Default.PosterDir, fn));

                int temp = Int32.Parse(dt);

                var mov1 = ve.Movies.Where(c => c.Id == temp).FirstOrDefault();

                mov1.Title = MovieTitleText.Text;
                mov1.Description = DescriptionText.Text;
                mov1.Year = int.Parse(YearText.Text);
                mov1.Price = int.Parse(PriceText.Text);
                mov1.Featured = FeaturedCheckBox.Checked;
                mov1.FolderName = FolderNameText.Text;
                mov1.Qualities = Qua;
                mov1.Downloadables = dl;
                mov1.Teaser = Qua;
                mov1.Rate = 0;
                mov1.RatedUsers = 0;
                mov1.DateCreated = DateTime.Now;
                mov1.CommentId = 0;
                mov1.Visit = 0;
                mov1.ThumbUps = 0;
                mov1.ThumbDowns = 0;
                mov1.Duration = 0;  /// TODO : should be changes!
                mov1.Disable = DisableCheckbox.Checked;
                mov1.EditorialRate = Convert.ToDouble(EditorialRateText.Text);
                mov1.Thumbnail.Url = fn;
                mov1.Thumbnail.Width = poster.Width;
                mov1.Thumbnail.Height = poster.Height;
                //mov1.Thumbnail = new Image() { Height = poster.Height, Width = poster.Width, Url = fn };

                ve.SaveChanges();

            }


        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }


        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (PosterUpload.HasFile)
            {
                PosterUpload.SaveAs(@Properties.Settings.Default.PosterDir + PosterUpload.FileName);
                UploadState.Text = "File Uploaded: " + PosterUpload.FileName;
                Session["fileName"] = PosterUpload.FileName;
            }
            else
            {
                UploadState.Text = "No File Uploaded.";
            }
        }
    }
}