using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class EditMoviePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                String dt = Request.QueryString["dt"];

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
                //int id = ve.Movies.Max(m => m.Id);
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
                    Thumbnail = new Image() { Height = 0, Width = 0, Url = "Unknown" },
                };

                ve.Movies.Add(mov);
                //ve.Entry(category1).State = System.Data.Entity.EntityState.Modified;
                ve.SaveChanges();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }
    }
}