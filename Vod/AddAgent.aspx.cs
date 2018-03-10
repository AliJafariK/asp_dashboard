using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddAgent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddAgent_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            Agent ag = new Agent()
            {
                Name = NameText.Text,
                Bio = BioText.Text
            };
            ve.Agents.Add(ag);
            ve.SaveChanges();
            Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");

        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("agent.aspx");
        }
    }
}