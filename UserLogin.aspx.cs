using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UserLogin : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select pass,sid from student where uname='" + uname.Text + "'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string pass = ds.Tables[0].Rows[0][0].ToString();
            if (pass == password.Text)
            {
                Session["type"] = "user";
                Session["sid"] = ds.Tables[0].Rows[0][1].ToString();
                Response.Redirect("Student_Details.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Invalid Password !!!')", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Invalid User ID !!!')", true);
        }

    }
}