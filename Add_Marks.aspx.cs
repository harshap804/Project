using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Add_Marks : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["update"] == "update")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Marks Details Updated !!!')", true);
            Session["update"] = "";
            
        }
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel10.Visible = false;
        Panel11.Visible = false;
        Panel12.Visible = false;
        Panel13.Visible = false;
        Panel14.Visible = false;
        Panel15.Visible = false;
        Panel16.Visible = false;
        Button1.Visible = false;
        if (!IsPostBack)
        {
            
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string m = "select uname from student";
            da = new SqlDataAdapter(m, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DropDownList3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Select Username !!!')", true);

        }
        else
        {
            if (DropDownList1.SelectedItem.Text == "Graduation")
            {
                DropDownList2.Items.Add("Sem 1");
                DropDownList2.Items.Add("Sem 2");
                DropDownList2.Items.Add("Sem 3");
                DropDownList2.Items.Add("Sem 4");
                DropDownList2.Items.Add("Sem 5");
                DropDownList2.Items.Add("Sem 6");
                DropDownList2.Items.Add("Sem 7");
                DropDownList2.Items.Add("Sem 8");
            }
            else
            {
                DropDownList2.Items.Add("Sem 1");
                DropDownList2.Items.Add("Sem 2");
                DropDownList2.Items.Add("Sem 3");
                DropDownList2.Items.Add("Sem 4");
                DropDownList2.Items.Add("Sem 5");
                DropDownList2.Items.Add("Sem 6");
            }
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Select Student Username !!!')", true);

        }
       else if (DropDownList1.SelectedItem.Text == "--Select--")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Select Highest Qualification !!!')", true);

        }
        else
        {
            if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 1")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 2")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 3")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 4")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 5")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 6")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 7")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 8")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 1")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Panel11.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 2")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Panel11.Visible = true;
                Panel12.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 3")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Panel11.Visible = true;
                Panel12.Visible = true;
                Panel13.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 4")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Panel11.Visible = true;
                Panel12.Visible = true;
                Panel13.Visible = true;
                Panel14.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 5")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Panel11.Visible = true;
                Panel12.Visible = true;
                Panel13.Visible = true;
                Panel14.Visible = true;
                Panel15.Visible = true;
                Button1.Visible = true;
            }
            else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 6")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
                Panel9.Visible = true;
                Panel10.Visible = true;
                Panel11.Visible = true;
                Panel12.Visible = true;
                Panel13.Visible = true;
                Panel14.Visible = true;
                Panel15.Visible = true;
                Panel16.Visible = true;
                Button1.Visible = true;
            }
        }
    }

  

    protected void Button1_Click1(object sender, EventArgs e)
    {
        int flag = 0;
        if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 1")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 2")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 3")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 4")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 5")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 6")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 7")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Graduation" && DropDownList2.SelectedItem.Text == "Sem 8")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 1")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "" || p1marks.Text == "" || p1cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 2")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "" || p1marks.Text == "" || p1cgpi.Text == "" || p2cgpi.Text == "" || p2marks.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 3")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "" || p1marks.Text == "" || p1cgpi.Text == "" || p2cgpi.Text == "" || p2marks.Text == "" || p3marks.Text == "" || p3cgpi.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 4")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "" || p1marks.Text == "" || p1cgpi.Text == "" || p2cgpi.Text == "" || p2marks.Text == "" || p3marks.Text == "" || p3cgpi.Text == "" || p4cgpi.Text == "" || p4marks.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 5")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "" || p1marks.Text == "" || p1cgpi.Text == "" || p2cgpi.Text == "" || p2marks.Text == "" || p3marks.Text == "" || p3cgpi.Text == "" || p4cgpi.Text == "" || p4marks.Text == "" || p5cgpi.Text == "" || p5marks.Text == "")
            {
                flag = 1;
            }

        }
        else if (DropDownList1.SelectedItem.Text == "Post-Graduation" && DropDownList2.SelectedItem.Text == "Sem 6")
        {
            if (g1marks.Text == "" || g1cgpi.Text == "" || g2marks.Text == "" || g2marks.Text == "" || g3marks.Text == "" || g3cgpi.Text == "" || g4marks.Text == "" || g4cgpi.Text == "" || g5marks.Text == "" || g5cgpi.Text == "" || g6marks.Text == "" || g6cgpi.Text == "" || g7cgpi.Text == "" || g7marks.Text == "" || g8marks.Text == "" || g8cgpi.Text == "" || p1marks.Text == "" || p1cgpi.Text == "" || p2cgpi.Text == "" || p2marks.Text == "" || p3marks.Text == "" || p3cgpi.Text == "" || p4cgpi.Text == "" || p4marks.Text == "" || p5cgpi.Text == "" || p5marks.Text == "" || p6cgpi.Text == "" || p6marks.Text == "")
            {
                flag = 1;
            }

        }
        if (flag == 1)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Enter Marks and CGPI !!!')", true);
        }
        else
        {
            SqlCommand cmd;
            con.Open();
            string ml = "update student set highest_q='"+DropDownList1.SelectedItem.Text+"',current_sem='"+DropDownList2.SelectedItem.Text+"',sscm='" + sscmarks.Text + "',sscp='" + sscpercent.Text + "',hscm='" + hscmarks.Text + "',hscp='" + hscpercent.Text + "',g1m='" + g1marks.Text + "',g1c='" + g1cgpi.Text + "',g2m='" + g2marks.Text + "',g2c='" + g2cgpi.Text + "',g3m='" + g3marks.Text + "',g3c='" + g3cgpi.Text + "',g4m='" + g4marks.Text + "',g4c='" + g4cgpi.Text + "',g5m='" + g5marks.Text + "',g5c='" + g5cgpi.Text + "',g6m='" + g6marks.Text + "',g6c='" + g6cgpi.Text + "',g7m='" + g7marks.Text + "',g7c='" + g7cgpi.Text + "',g8m='" + g8marks.Text + "',g8c='" + g8cgpi.Text + "',p1m='" + p1marks.Text + "',p1c='" + p1cgpi.Text + "',p2m='" + p2marks.Text + "',p2c='" + p2cgpi.Text + "',p3m='" + p3marks.Text + "',p3c='" + p3cgpi.Text + "',p4m='" + p4marks.Text + "',p4c='" + p4cgpi.Text + "',p5m='" + p5marks.Text + "',p5c='" + p5cgpi.Text + "',p6m='" + p6marks.Text + "',p6c='" + p6cgpi.Text + "' where uname='" + DropDownList3.SelectedItem.Text + "'";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Session["update"] = "update";
            Response.Redirect("Add_Marks.aspx");

        }
    }
}