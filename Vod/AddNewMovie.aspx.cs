using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddNewMovie : System.Web.UI.Page
    {
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
                    Thumbnail = new Image() { Height = 0, Width = 0, Url="Unknown"},
                };

                ve.Movies.Add(mov);
                //ve.Entry(category1).State = System.Data.Entity.EntityState.Modified;
                ve.SaveChanges();
                Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");
            }
        }
    }
}