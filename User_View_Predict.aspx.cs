using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class User_View_Predict : System.Web.UI.Page
{
    public static string constr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    SqlConnection con = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
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
        Panel17.Visible = false;
        string uid = Session["sid"].ToString();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select sid,name,uname from student where sid='"+uid+"'";
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
        if (e.CommandName == "yes")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select sscp,hscp,g1c,g2c,g3c,g4c,g5c,g6c,g7c,g8c,p1c,p2c,p3c,p4c,p5c,p6c,highest_q,current_sem from student where sid='" + i + "'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            string hq = "", sem = "";
            double ssc = 0, hsc = 0, g_avg = 0, g_total = 0, pg_avg = 0, pg_total = 0, graduate = 0, pgraduate = 0, dp_total = 0, dg_avg = 0, dg_total = 0, dp_avg = 0, dg1 = 0, dg2 = 0, dg3 = 0, dg4 = 0, dg5 = 0, dg6 = 0, dg7 = 0, dg8 = 0, dp1 = 0, dp2 = 0, dp3 = 0, dp4 = 0, dp5 = 0, dp6 = 0;
            double gcount = 0, pgcount = 0, g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0, g6 = 0, g7 = 0, g8 = 0, p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                ssc = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                sscl.Text = Convert.ToString(ssc);
                Panel1.Visible = true;

                hsc = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString());
                hscl.Text = Convert.ToString(hsc);
                Panel2.Visible = true;
                /* hq = ds.Tables[0].Rows[0][16].ToString();
                 sem = ds.Tables[0].Rows[0][17].ToString();
                 string[] s = sem.Split(' ');
                 int val = Convert.ToInt32(s[1]) + 1;*/
                if (ds.Tables[0].Rows[0][2].ToString() == "")
                {
                    g1 = 0;
                }
                else
                {
                    g1 = Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString());
                    g1l.Text = Convert.ToString(g1);
                    Panel3.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][3].ToString() == "")
                {
                    g2 = 0;
                }
                else
                {
                    g2 = Convert.ToDouble(ds.Tables[0].Rows[0][3].ToString());
                    g2l.Text = Convert.ToString(g2);
                    Panel4.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][4].ToString() == "")
                {
                    g3 = 0;
                }
                else
                {
                    g3 = Convert.ToDouble(ds.Tables[0].Rows[0][4].ToString());
                    g3l.Text = Convert.ToString(g3);
                    Panel5.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][5].ToString() == "")
                {
                    g4 = 0;
                }
                else
                {
                    g4 = Convert.ToDouble(ds.Tables[0].Rows[0][5].ToString());
                    g4l.Text = Convert.ToString(g4);
                    Panel6.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][6].ToString() == "")
                {
                    g5 = 0;
                }
                else
                {
                    g5 = Convert.ToDouble(ds.Tables[0].Rows[0][6].ToString());
                    g5l.Text = Convert.ToString(g5);
                    Panel7.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][7].ToString() == "")
                {
                    g6 = 0;
                }
                else
                {
                    g6 = Convert.ToDouble(ds.Tables[0].Rows[0][7].ToString());
                    g6l.Text = Convert.ToString(g6);
                    Panel8.Visible = true;

                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][8].ToString() == "")
                {
                    g7 = 0;
                }
                else
                {
                    g7 = Convert.ToDouble(ds.Tables[0].Rows[0][8].ToString());
                    g7l.Text = Convert.ToString(g7);
                    Panel9.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][9].ToString() == "")
                {
                    g8 = 0;
                }
                else
                {
                    g8 = Convert.ToDouble(ds.Tables[0].Rows[0][9].ToString());
                    g8l.Text = Convert.ToString(g8);
                    Panel10.Visible = true;
                    gcount = gcount + 1;
                }
                if (ds.Tables[0].Rows[0][10].ToString() == "")
                {
                    p1 = 0;
                }
                else
                {
                    p1 = Convert.ToDouble(ds.Tables[0].Rows[0][10].ToString());
                    p1l.Text = Convert.ToString(p1);
                    Panel11.Visible = true;
                    pgcount = pgcount + 1;
                }
                if (ds.Tables[0].Rows[0][11].ToString() == "")
                {
                    p2 = 0;
                }
                else
                {
                    p2 = Convert.ToDouble(ds.Tables[0].Rows[0][11].ToString());
                    p2l.Text = Convert.ToString(p2);
                    Panel12.Visible = true;
                    pgcount = pgcount + 1;
                }
                if (ds.Tables[0].Rows[0][12].ToString() == "")
                {
                    p3 = 0;
                }
                else
                {
                    p3 = Convert.ToDouble(ds.Tables[0].Rows[0][12].ToString());
                    p3l.Text = Convert.ToString(p3);
                    Panel13.Visible = true;
                    pgcount = pgcount + 1;
                }
                if (ds.Tables[0].Rows[0][13].ToString() == "")
                {
                    p4 = 0;
                }
                else
                {
                    p4 = Convert.ToDouble(ds.Tables[0].Rows[0][13].ToString());
                    p4l.Text = Convert.ToString(p4);
                    Panel14.Visible = true;
                    pgcount = pgcount + 1;
                }
                if (ds.Tables[0].Rows[0][14].ToString() == "")
                {
                    p5 = 0;
                }
                else
                {
                    p5 = Convert.ToDouble(ds.Tables[0].Rows[0][14].ToString());
                    p5l.Text = Convert.ToString(p5);
                    Panel15.Visible = true;
                    pgcount = pgcount + 1;
                }
                if (ds.Tables[0].Rows[0][15].ToString() == "")
                {
                    p6 = 0;
                }
                else
                {
                    p6 = Convert.ToDouble(ds.Tables[0].Rows[0][15].ToString());
                    p6l.Text = Convert.ToString(p6);
                    Panel16.Visible = true;
                    pgcount = pgcount + 1;
                }
                dg1 = g2 - g1;
                dg2 = g3 - g2;
                dg3 = g4 - g3;
                dg4 = g5 - g4;
                dg5 = g6 - g5;
                dg6 = g7 - g6;
                dg7 = g8 - g7;
                dp1 = p2 - p1;
                dp2 = p3 - p2;
                dp3 = p4 - p3;
                dp4 = p5 - p4;
                dp5 = p6 - p5;
                dp_total = dp1 + dp2 + dp3 + dp4 + dp5;
                dp_avg = dp_total / 5;
                dg_total = dg1 + dg2 + dg3 + dg4 + dg5 + dg6 + dg7;
                dg_avg = dg_total / 7;
                g_total = g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8;
                g_avg = g_total / gcount;
                pg_total = p1 + p2 + p3 + p4 + p5 + p6;
                pg_avg = pg_total / pgcount;
                graduate = g_avg + dg_avg;
                pgraduate = pg_avg + dp_avg;
                C4_5 obj = new C4_5();
                obj.add();
                /* double total = ssc + hsc + graduate + pgraduate;
                 double sscprob = ssc / total;
                 double hscprob = hsc / total;
                 double graduateprob = graduate / total;
                 double pgraduateprob = pgraduate / total;
               // double sumprob = sscprob + hscprob + graduateprob + pgraduate;
               //  string str = result(sscprob,hscprob,graduateprob,pgraduateprob,hq);*/
                string sscgrade = "", hscgrade = "", ggrade = "", pggrade = "";
                if (ssc >= 80 && ssc <= 100)
                {
                    sscgrade = "A";
                }
                else if (ssc >= 50 && ssc < 80)
                {
                    sscgrade = "B";
                }
                else if (ssc >= 35 && ssc <= 50)
                {
                    sscgrade = "C";
                }
                if (hsc >= 80 && hsc <= 100)
                {
                    hscgrade = "D";
                }
                else if (hsc >= 50 && hsc < 80)
                {
                    hscgrade = "E";
                }
                else if (hsc >= 35 && hsc <= 50)
                {
                    hscgrade = "F";
                }
                if (graduate >= 80 && graduate <= 100)
                {
                    ggrade = "P";
                }
                else if (graduate >= 50 && graduate < 80)
                {
                    ggrade = "Q";
                }
                else if (graduate >= 35 && graduate <= 50)
                {
                    ggrade = "R";
                }
                if (pgraduate >= 80 && pgraduate <= 100)
                {
                    pggrade = "P";
                }
                else if (pgraduate >= 50 && pgraduate < 80)
                {
                    pggrade = "Q";
                }
                else if (pgraduate >= 35 && pgraduate <= 50)
                {
                    pggrade = "R";
                }
                double sscm = 0, hscm = 0, gm = 0, pggm = 0;
                if (sscgrade == "A")
                {
                    sscm = 80;
                }
                else if (sscgrade == "B")
                {
                    sscm = 60;
                }
                else if (sscgrade == "C")
                {
                    sscm = 50;
                }
                if (hscgrade == "D")
                {
                    hscm = 80;
                }
                else if (hscgrade == "E")
                {
                    hscm = 60;
                }
                else if (hscgrade == "F")
                {
                    hscm = 50;
                }
                if (ggrade == "P")
                {
                    gm = 80;
                }
                else if (ggrade == "Q")
                {
                    gm = 60;
                }
                else if (ggrade == "R")
                {
                    gm = 50;
                }
                if (pggrade == "X")
                {
                    pggm = 80;
                }
                else if (pggrade == "Y")
                {
                    pggm = 60;
                }
                else if (pggrade == "Z")
                {
                    pggm = 50;
                }
                double sscp = 0, hscp = 0, gp = 0, pgp = 0;

                SqlDataAdapter da2;
                DataSet ds2 = new DataSet();
                string m = "select prob from tree where node='ssc'and gain='" + sscgrade + "'";
                da2 = new SqlDataAdapter(m, con);
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    sscp = Convert.ToDouble(ds2.Tables[0].Rows[0][0].ToString());
                }
                ds2 = new DataSet();
                m = "select prob from tree where node='hsc'and gain='" + hscgrade + "'";
                da2 = new SqlDataAdapter(m, con);
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    hscp = Convert.ToDouble(ds2.Tables[0].Rows[0][0].ToString());
                }
                ds2 = new DataSet();
                m = "select prob from tree where node='g'and gain='" + ggrade + "'";
                da2 = new SqlDataAdapter(m, con);
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    gp = Convert.ToDouble(ds2.Tables[0].Rows[0][0].ToString());
                }
                ds2 = new DataSet();
                m = "select prob from tree where node='pg'and gain='" + pggrade + "'";
                da2 = new SqlDataAdapter(m, con);
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    pgp = Convert.ToDouble(ds2.Tables[0].Rows[0][0].ToString());
                }
                double avg = 0, probavg = 0;
                avg = sscm + hscm + gm + pggm;
                avg = avg / (2 + gcount + pgcount);
                probavg = sscp + hscp + gp + pgp;
                probavg = probavg / (2 + gcount + pgcount);
                string expectedgrade = "";
                if (avg >= 80 && avg <= 100)
                {
                    expectedgrade = "A";

                }
                else if (avg >= 60 && avg < 80)
                {
                    expectedgrade = "B";
                }
                else if (avg >= 50 && avg < 60)
                {
                    expectedgrade = "C";
                }
                else if (avg >= 35 && avg < 50)
                {
                    expectedgrade = "D";
                }
                SqlDataAdapter da6;
                DataSet ds6 = new DataSet();
                string t = "select prob,gain from tree where node='g' or node='pg'";
                da6 = new SqlDataAdapter(t, con);
                da6.Fill(ds6);
                if (ds6.Tables[0].Rows.Count > 0)
                {
                    double prob = 0;
                    for (int o = 0; o < ds6.Tables[0].Rows.Count; o++)
                    {
                        prob = Convert.ToDouble(ds6.Tables[0].Rows[o][0].ToString());
                        if (probavg < prob)
                        {
                            expectedgrade = ds6.Tables[0].Rows[o][1].ToString();
                            if (expectedgrade == "X")
                            {
                                expectedgrade = "A";
                            }
                            else if (expectedgrade == "Y")
                            {
                                expectedgrade = "B";
                            }
                            else if (expectedgrade == "Z")
                            {
                                expectedgrade = "C";
                            }
                            if (expectedgrade == "P")
                            {
                                expectedgrade = "A";
                            }
                            else if (expectedgrade == "Q")
                            {
                                expectedgrade = "B";
                            }
                            else if (expectedgrade == "R")
                            {
                                expectedgrade = "C";
                            }


                        }
                    }
                }
                expected.Text = "Expected grade=" + expectedgrade;
                Panel17.Visible = true;
            }

        }

    }
}