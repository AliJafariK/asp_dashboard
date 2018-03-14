using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class ReorderBanner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                bindData();
            }
        }

        protected void bindData()
        {
            VodioContainer ve = new VodioContainer();
            List<Banner> bans = ve.Banners.ToList();
            bans1.DataSource = bans;
            bans1.DataBind();
        }

        protected void bans1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Banner> bans = ve.Banners.ToList();
            int id = int.Parse(e.CommandArgument.ToString());
            var dt = (int)((GridView)sender).DataKeys[id].Value;

            if (e.CommandName == "MIF")
            {
                //var banFirst = bans[id];
                var banFirst = ve.Banners.Where(b => b.Id == dt).FirstOrDefault();

                ve.Banners.Remove(banFirst);
                ve.SaveChanges();
                bans.Remove(banFirst);

                List<Banner> tempBans = new List<Banner>();
                foreach(Banner b in bans)
                {
                    tempBans.Add(b);
                }

                foreach (Banner b in bans)
                {
                    ve.Banners.Remove(b);
                    ve.SaveChanges();
                }

                List<Banner> just4Count = ve.Banners.ToList();

                bans.Clear();
                
                ve.Banners.Add(banFirst);
                ve.SaveChanges();

                List<Banner> j4c2 = ve.Banners.ToList();

                foreach (Banner b in tempBans)
                {
                    ve.Banners.Add(b);
                    ve.SaveChanges();
                }

                bindData();

            }

        }
    }
}