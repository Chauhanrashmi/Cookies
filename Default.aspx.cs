using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text=="abc" && TextBox2.Text=="xys")
        {
            HttpCookie ck = new HttpCookie("myckk");
            ck.Values.Add("uname",TextBox1.Text);
            ck.Values.Add("upass",TextBox2.Text);
            ck.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(ck);
            Response.Redirect("default2.aspx");
        }
        else
        {
            Response.Write("Wrong Username/Password");
        }
    }
}