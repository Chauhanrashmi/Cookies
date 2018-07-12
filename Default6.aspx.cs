using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Concept of ViewstateMode
public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            Label1.Text = "Hello";
            Label2.Text = " Welcome";
            Label3.Text = "here";
        }
    }
}