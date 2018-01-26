using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetPassword : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string uid = Request.QueryString["uid"];
        SqlCommand cmd;
        con.Open();
        string lp = "update student set pass='" + cpass.Text + "' where sid='" + uid + "'";
        cmd = new SqlCommand(lp, con);
        cmd.ExecuteNonQuery();
        con.Close();
      
        Response.Redirect("UserLogin.aspx");
    }
}