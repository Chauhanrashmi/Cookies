using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie ckk = Request.Cookies["myckk"];
        if(ckk!=null)
        {
            Label1.Text = "Welcome:" + ckk.Values["uname"];
        }
        else
        {
            Response.Write("Sorry! Cookie not created");
        }
    }
}