using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class agent : System.Web.UI.Page
    {
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            bindGridView();
        }

        private void bindGridView()
        {
            VodioContainer ve = new VodioContainer();
            List<Agent> ag = ve.Agents.Where(a => a.Name != null).ToList();
            GridView1.DataSource = ag;
            GridView1.DataBind();
        }

        protected void SearchM_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Agent> ag = ve.Agents.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
            GridView1.DataSource = ag;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindGridView();
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (!Page.IsPostBack)
            {
                VodioContainer ve = new VodioContainer();
                int id = int.Parse(e.CommandArgument.ToString());
                List<Agent> ags = ve.Agents.Where(a => a.Name.Contains(SearchBox.Text)).ToList();

                int dt = ags[id].Id;
                //var dt = (int)((GridView)sender).DataKeys[id].Value;

                if (e.CommandName == "Delete")
                {
                    //var ag1 = ve.Agents.Where(c => c.Id == dt).FirstOrDefault();
                    //ve.Agents.Remove(ag1);
                    //ve.SaveChanges();
                    //Page_Load(null, null);
                }
                if (e.CommandName == "Edit")
                {
                    //Response.Redirect("EditPage.aspx?dt=" + dt);

                    Response.Redirect("editAgent.aspx?dt=" + dt);
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("agent.aspx");
        }

        protected void HomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void AddAgent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAgent.aspx");
        }

    }
}
