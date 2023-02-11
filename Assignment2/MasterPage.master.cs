using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGoodWebsites_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/GoodWebsite/GoodWebsite.Aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }

    protected void btnPoorWebsites_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PoorWebsite/PoorWebsite.Aspx");
    }
}
