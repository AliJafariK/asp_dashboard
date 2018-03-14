using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;


namespace Vod
{
    public partial class AddNewMovie : System.Web.UI.Page
    {
        //public string fileName;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        public bool IsNumeric(string input)
        {
            double test;
            return double.TryParse(input, out test);
        }

        protected void AddMovie_Click(object sender, EventArgs e)
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
                //int id = ve.Movies.Max(m => m.Id);

                //System.IO.Stream stream = PosterUpload.PostedFile.InputStream;
                //System.Drawing.Image poster = System.Drawing.Image.FromStream(stream);
                string fn = (string) Session["fileName"];
                Bitmap poster = new Bitmap(Path.Combine(Properties.Settings.Default.PosterDir, fn));

                //var poster = new Image();
                //poster.src = "myFile.png";

                //System.Drawing.Image poster = System.Drawing.Image.FromStream(PosterUpload.PostedFile.InputStream);

                Movie mov = new Movie()
                {
                    //Id = 200,
                    Title = MovieTitleText.Text,
                    Description = DescriptionText.Text,
                    Year = int.Parse(YearText.Text),
                    Price = int.Parse(PriceText.Text),
                    Featured = FeaturedCheckBox.Checked,
                    FolderName = FolderNameText.Text,
                    Qualities = Qua,
                    Downloadables = dl,
                    Teaser = Qua,
                    Rate = 0,
                    RatedUsers = 0,
                    DateCreated = DateTime.Now,
                    CommentId = 0,
                    Visit = 0,
                    ThumbUps = 0,
                    ThumbDowns = 0,
                    Duration = 0,  /// TODO : should be changes!
                    Disable = DisableCheckbox.Checked,
                    EditorialRate = Convert.ToDouble(EditorialRateText.Text),
                    Thumbnail = new Image() { Height = poster.Height, Width = poster.Height, Url= fn },
                };

                ve.Movies.Add(mov);
                //ve.Entry(category1).State = System.Data.Entity.EntityState.Modified;
                ve.SaveChanges();
                Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");
            }
        }

        //protected void set_fileName(string name)
        //{
        //    fileName = name;
        //}

        protected void UploadButton_Click(object sender, EventArgs e)
        {

            if (PosterUpload.HasFile)
            {
                //string value = ConfigurationManager.AppSettings["PosterDirectory"];
                //string t = Properties.Settings.Default.PosterDir;

                PosterUpload.SaveAs(@Properties.Settings.Default.PosterDir + PosterUpload.FileName);
                UploadState.Text = "File Uploaded: " + PosterUpload.FileName;
                //set_fileName(PosterUpload.FileName);
                Session["fileName"] = PosterUpload.FileName;
                //if( PosterUpload.FileName.ToString() != "" )
                //    fileName = PosterUpload.FileName.ToString();
            }
            else
            {
                UploadState.Text = "No File Uploaded.";
            }
        }
    }
}