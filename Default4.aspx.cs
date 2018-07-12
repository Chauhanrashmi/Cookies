using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//concept of multiple QueryString
public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Welcome:" + Request.QueryString["ab"];
        //Label2.Text = "From"+ Response.QueryString["ab1"].ToString();
    }
}