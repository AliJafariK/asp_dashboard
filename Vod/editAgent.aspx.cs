using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class editAgent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            //dt.Text = Request.QueryString["dt"];

            String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);

            Agent ag1 = ve.Agents.Where(c => c.Id == temp).FirstOrDefault();

            NameText.Text = ag1.Name.ToString();
            BioText.Text = ag1.Bio.ToString();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("agent.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            String dt = Request.QueryString["dt"];
            int temp = Int32.Parse(dt);
            Agent ag1 = ve.Agents.Where(c => c.Id == temp).FirstOrDefault();
            ag1.Name = NameText.Text;
            ag1.Bio = BioText.Text;
            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Update successfully!');</script>");

        }
    }
}