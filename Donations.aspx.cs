using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userKey"]==null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Community_AssistEntities commAssEnt = new Community_AssistEntities();
            int key = (int)Session["userKey"];
            var donations = (from d in commAssEnt.Donations
                            where d.PersonKey == key
                            select d).ToList();
            GridView1.DataSource = donations;
            GridView1.DataBind();
        }
    }
}