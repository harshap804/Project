using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ViewEditDelete : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["update"] == "update")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Successfully Data Updated !!!')", true);
            Session["update"] = "";
        }
        Panel1.Visible = false;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select sid,name,email,mobile from student";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "edit")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            string t = "select mobile,email from student where sid='" + i + "'";
            da = new SqlDataAdapter(t, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                h1.Value = i;
                mobile.Text = ds.Tables[0].Rows[0][0].ToString();
                TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                Panel1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
            }

        }
        else if (e.CommandName == "delete")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            /*if (h1.Value == "1")
            {*/
                SqlCommand cmd;
                con.Open();
                string str = "delete from student where sid='"+i+"'";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
            Response.Redirect("ViewEditDelete.aspx");
          // }
                 
           

        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd;
        con.Open();
        string pl = "update student set mobile='" + mobile.Text + "',email='" +TextBox1.Text + "' where sid='" + h1.Value + "'";
        cmd = new SqlCommand(pl, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["update"] = "update";
        Response.Redirect("ViewEditDelete.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}