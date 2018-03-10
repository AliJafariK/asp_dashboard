using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public partial class AddRol2Mov : System.Web.UI.Page
    {
        private String dt;
        protected static List<Agent> selectedAgents = new List<Agent>();

        protected void Add2Selceted(Agent a)
        {
            selectedAgents.Add(a);
        }

        protected String Return_Dt()
        {
            String dt = Request.QueryString["dt"];
            return dt;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dt = Return_Dt();
            if (!Page.IsPostBack)
            {
                VodioContainer ve = new VodioContainer();
                List<Agent> rol = ve.Agents.Where(a => a.Id != null).ToList();
                AllAgent.DataSource = rol;
                AllAgent.DataBind();
                //Load_MovieRole();
                Load_SelAgent();
            }
        }
        protected void SearchM_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            List<Agent> rol = ve.Agents.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
            AllAgent.DataSource = rol;
            AllAgent.DataBind();
        }

        List<MovieRole> rols = new List<MovieRole>();

        protected void Load_MovieRole()
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);
            List<Role> ag1 = ve.Movies.Where(a => a.Id == temp).FirstOrDefault().Roles.ToList();
            rols.Clear();
            foreach (Role a in ag1)
            {
                MovieRole mr = new MovieRole()
                {
                    Agent = a.Agent.Name,
                    Movie = a.Movie.Title,
                    Name = a.Name,
                    Id = a.Id
                };
                rols.Add(mr);
            }

            //MovRol.DataSource = ag1;
            //MovRol.DataBind();
        }

        protected void AllAgent_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            VodioContainer ve = new VodioContainer();
            //String dt = Return_Dt();
            int temp = Int32.Parse(dt);
            int id = int.Parse(e.CommandArgument.ToString());

            List<Agent> ags = ve.Agents.Where(a => a.Name.Contains(SearchBox.Text)).ToList();
            Agent newag = new Agent();

            if (e.CommandName == "Add")
            {
                newag.Name = ags[id].Name;
                newag.Bio = ags[id].Bio;

                //gglobal.addGG(newag);
                Add2Selceted(newag);
                //selectedagents.Add(newag);
                Load_SelAgent();
            }
        }

        protected void Load_SelAgent()
        {
            SelAgent.DataSource = selectedAgents;
            SelAgent.DataBind();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("MovieRoles.aspx?dt=" + dt);
        }

        protected void AddRole_Click(object sender, EventArgs e)
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            Movie mov1 = ve.Movies.Where(a => a.Id == temp).FirstOrDefault();


            foreach (Agent ag in selectedAgents)
            {
                Role newrl = new Role()
                {
                    Name = RoleNames.SelectedValue,
                    Agent = ag,
                    Movie = ve.Movies.Where(a => a.Id == temp).FirstOrDefault()
                };

                mov1.Roles.Add(newrl);
                ve.SaveChanges();
            }
            selectedAgents.Clear();
            Load_SelAgent();
            Response.Write(@"<script language='javascript'>alert('Add successfully!');</script>");
        }
    }
}