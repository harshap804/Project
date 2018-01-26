using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

public partial class ForgotPassword : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["update"] == "update")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Successfully password updated !!!')", true);
            Session["update"] = "";
        }
        if(!IsPostBack)
        {
            Image2.Visible = false;
            Image3.Visible = false;
           

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select sid,name,email,uname,pass from student where email='" + em.Text + "'";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        string uid = "",name="", email = "", uname = "", pass = "";
        if (ds.Tables[0].Rows.Count > 0)
        {
            Image2.Visible = true;
            Image3.Visible = false;
            uid = ds.Tables[0].Rows[0][0].ToString();
            name = ds.Tables[0].Rows[0][1].ToString();
            email = ds.Tables[0].Rows[0][2].ToString();
            uname = ds.Tables[0].Rows[0][3].ToString();
            pass = ds.Tables[0].Rows[0][4].ToString();
            eemail(uid, name, email, uname, pass);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Mail Sent to your Mail ID !!!')", true);

        }
        else
        {
            Image2.Visible = false;
            Image3.Visible = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('E-Mail id not registered') !!!", true);
        }
       
    }
    public void eemail(string uid,string name, string mailid, string uname, string pass)
    {
        MailMessage mail = new MailMessage();

        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("mailtestingw@gmail.com");
        mail.To.Add(mailid);
        mail.Subject = "Mail From Student Marks Prediction System";

        mail.Body = "Dear " + name + ",<br /><br />Mail From Student Marks Prediction System<br><b>To set password </b> <a href=http://localhost:58603/SetPassword.aspx?uid=" + uid+">Click Here</a>" + " <br><br> --<br><b>From:</b><br><b>Student Marks Prediction System</b><br>";
        mail.IsBodyHtml = true;

        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("mailtestingw@gmail.com", "testmail123");
        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}