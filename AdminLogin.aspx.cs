using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
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
        string ml = "select pass from Admin where id='"+aid.Text+"'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string pass = ds.Tables[0].Rows[0][0].ToString();
            if (pass == password.Text)
            {
                Session["type"] = "admin";
                Response.Redirect("Add_Students.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Invalid Password !!!')", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Invalid Admin ID !!!')", true);
        }

    }
}