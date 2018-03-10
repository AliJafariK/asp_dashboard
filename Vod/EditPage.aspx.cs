using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class EditPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dt.Text = Request.QueryString["dt"];

                int temp = Int32.Parse(dt.Text);

                VodioContainer ve = new VodioContainer();
                var category1 = ve.Categories.Where(c => c.Id == temp).FirstOrDefault();
                textName.Text = category1.Name.ToString();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            dt.Text = Request.QueryString["dt"];
            int temp = Int32.Parse(dt.Text);

            var category1 = ve.Categories.Where(c => c.Id == temp).FirstOrDefault();
            category1.Name = textName.Text;
            ve.Entry(category1).State = System.Data.Entity.EntityState.Modified;
            ve.SaveChanges();

        }
    }
}