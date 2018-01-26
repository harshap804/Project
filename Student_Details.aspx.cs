using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Student_Details : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        string sid = Session["sid"].ToString();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select name,email,mobile,uname from student where sid='" + sid + "'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label6.Text = ds.Tables[0].Rows[0][0].ToString();
            Label7.Text = ds.Tables[0].Rows[0][1].ToString();
            Label8.Text = ds.Tables[0].Rows[0][2].ToString();
            Label9.Text = ds.Tables[0].Rows[0][3].ToString();
        }
    }
}