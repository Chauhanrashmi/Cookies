using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//concept of viewstate
public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = (DataSet)(ViewState["aa"]);
        if(ds==null)
        {
            ds = getdata();
            ViewState["aa"] = ds;
            Label1.Text = "Read data from database";
        }
        else
        {
            Label1.Text = "Read data from viewstate";
        }
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    private DataSet getdata()
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from emp",ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default5.aspx");
    }
}