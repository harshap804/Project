using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Add_Students : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Session["add"] = "";
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Data Added !!!')", true);

        }
      
    }

    protected void DropDownList12_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        SqlDataAdapter da1;
        DataSet ds1 = new DataSet();
        string ml = "select uname from student where uname='" + uname.Text + "'";
        da1 = new SqlDataAdapter(ml, con);
        da1.Fill(ds1);
        if (ds1.Tables[0].Rows.Count > 0)
        {
            Label25.Text = "Username Already Exist !!!";
        }
        else
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string mt = "select top 1 sid from student order by sid desc";
            da = new SqlDataAdapter(mt, con);
            da.Fill(ds);
            int count = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                count = count + 1;
            }
            else
            {
                count = 1001;
            }
            SqlCommand cmd;
            con.Open();
            string mm = "insert into student values('" + count + "','" + Name.Text + "','" + email.Text + "','" + mobile.Text + "','" + uname.Text + "','" + password.Text + "','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')";
            cmd = new SqlCommand(mm, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["add"] = "add";
            Response.Redirect("Add_Students.aspx");
        }

        
    }
}