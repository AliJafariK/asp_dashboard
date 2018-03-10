using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vod
{
    public class MovieRole 
    {
        public string Movie { get; set; }
        public string Agent { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public partial class MovieRoles : System.Web.UI.Page
    {
        private string dt;

        protected string Set_Dt()
        {
            string tes = Request.QueryString["dt"];
            return tes;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dt = Set_Dt();
            if (!Page.IsPostBack)
            {
                bindDate();
            }
        }

        List<MovieRole> rols = new List<MovieRole>();

        protected void bindDate()
        {
            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);
            List<Role> rol = ve.Movies.Where(a => a.Id == temp).FirstOrDefault().Roles.ToList();
            rols.Clear();
            foreach (Role a in rol)
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

            RolesShow.DataSource = rols;
            RolesShow.DataBind();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("movyform.aspx");
        }

        protected void AddRol2Mov_Click(object sender, EventArgs e)
        {
            int temp = Int32.Parse(dt);
            Response.Redirect("AddRol2Mov.aspx?dt=" + dt);
        }

        protected void Roles_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            VodioContainer ve = new VodioContainer();
            int temp = Int32.Parse(dt);

            int id = int.Parse(e.CommandArgument.ToString());
            bindDate();
            int tempId = rols[id].Id;

            if (e.CommandName == "Delete")
            {
                Movie mov = ve.Movies.Where(a => a.Id == temp).FirstOrDefault();
                //List<Role> rols = mov.Roles.Where(a => a.Id != null).ToList();
                Role delrol = mov.Roles.Where(a => a.Id == tempId).FirstOrDefault();

                ve.Movies.Where(a => a.Id == temp).FirstOrDefault().Roles.Remove(delrol);
                //    ve.Entry(category1).State = System.Data.Entity.EntityState.Modified;
                if (delrol != null)
                {
                    ve.Entry(delrol).State = System.Data.Entity.EntityState.Deleted;
                    ve.SaveChanges();
                }
                bindDate();
            }
        }

        protected void Roles_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}