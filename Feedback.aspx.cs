using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Feedback : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Feedback Submitted !!!')", true);
            Session["add"] = "";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sid = Session["sid"].ToString();
        string dt = DateTime.Now.ToShortDateString();
        dt = dfun(dt);
        string time = DateTime.Now.ToShortTimeString();
        
        SqlCommand cmd;
        con.Open();
        string ml = "insert into Feedback values('" + sid + "','" + feed.Text + "','" + dt + "','" + time + "')";
        cmd = new SqlCommand(ml, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["add"] = "add";
        Response.Redirect("Feedback.aspx");

    }
    public string dfun(string str)
    {
        DateTime dt = Convert.ToDateTime(str);
        string s = dt.ToString("yyyy/MM/dd");
        return s;
    }

}