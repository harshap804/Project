using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for C4_5
/// </summary>
public class C4_5
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E6EDL0R;Initial Catalog=marks_c45;Integrated Security=True");
    string Label1 = "", h1 = "", h2 = "", h3 = "",h11="";
    /*public C4_5()
    {
        id3algo();
    }*/
    public void add()
    {
        SqlCommand cmd1;
        con.Open();
        string mp = "delete from final";
        cmd1 = new SqlCommand(mp, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string ml = "select sno,ssc,hsc,g1,g2,g3,g4,g5,g6,g7,g8,p1,p2,p3,p4,p5,p6,result from main";
        da = new SqlDataAdapter(ml, con);
        da.Fill(ds);
        double g_avg = 0, pg_avg = 0, g_total = 0, pg_total = 0, graduate = 0, pgraduate = 0;
        double g1 = 0, dg1 = 0, g2 = 0, dg2 = 0, g3 = 0, dg3 = 0, g4 = 0, dg4 = 0, g5 = 0, g6 = 0, g7 = 0, g8 = 0, dg5 = 0, dg6 = 0, dg7 = 0, dg8 = 0, dg_total = 0, dg_avg = 0;
        double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, dp1 = 0, dp2 = 0, dp3 = 0, dp4 = 0, dp5 = 0, dp_total = 0, dp_avg = 0;
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                g1 = Convert.ToDouble(ds.Tables[0].Rows[i][3].ToString());
                g2 = Convert.ToDouble(ds.Tables[0].Rows[i][4].ToString());
                g3 = Convert.ToDouble(ds.Tables[0].Rows[i][5].ToString());
                g4 = Convert.ToDouble(ds.Tables[0].Rows[i][6].ToString());
                g5 = Convert.ToDouble(ds.Tables[0].Rows[i][7].ToString());
                g6 = Convert.ToDouble(ds.Tables[0].Rows[i][8].ToString());
                g7 = Convert.ToDouble(ds.Tables[0].Rows[i][9].ToString());
                g8 = Convert.ToDouble(ds.Tables[0].Rows[i][10].ToString());
                p1 = Convert.ToDouble(ds.Tables[0].Rows[i][11].ToString());
                p2 = Convert.ToDouble(ds.Tables[0].Rows[i][12].ToString());
                p3 = Convert.ToDouble(ds.Tables[0].Rows[i][13].ToString());
                p4 = Convert.ToDouble(ds.Tables[0].Rows[i][14].ToString());
                p5 = Convert.ToDouble(ds.Tables[0].Rows[i][15].ToString());
                p6 = Convert.ToDouble(ds.Tables[0].Rows[i][16].ToString());
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
                g_avg = g_total / 8;
                pg_total = p1 + p2 + p3 + p4 + p5 + p6;
                pg_avg = pg_total / 6;
                graduate = g_avg + dg_avg;
                pgraduate = pg_avg + dp_avg;
                SqlCommand cmd;
                con.Open();
                string m = "insert into final values('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + graduate + "','" + pgraduate + "','" + ds.Tables[0].Rows[i][17].ToString() + "')";
                cmd = new SqlCommand(m, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            id3algo();
        }
    } 
    public void id3algo()
    {
        SqlCommand cmd1;
        con.Open();
        string ml = "delete from main_3";
        cmd1 = new SqlCommand(ml, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        SqlDataAdapter da1;
        DataSet ds1 = new DataSet();
        string lp = "select top 1 ssc from final order by ssc desc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double maxssc = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        ds1 = new DataSet();
        lp = "select top 1 ssc from final order by ssc asc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double minssc = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        double subssc = (maxssc - minssc) / 4;
        ds1 = new DataSet();
        lp = "select top 1 hsc from final order by hsc desc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double maxhsc = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        ds1 = new DataSet();
        lp = "select top 1 hsc from final order by hsc asc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double minhsc = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        double subhsc = (maxhsc - minhsc) / 4;
        ds1 = new DataSet();
        lp = "select top 1 g from final order by g desc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double maxg = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        ds1 = new DataSet();
        lp = "select top 1 g from final order by g asc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double ming = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        double subg = (maxg - ming) / 4;
        ds1 = new DataSet();
        lp = "select top 1 pg from final order by pg desc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double maxpg = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        ds1 = new DataSet();
        lp = "select top 1 pg from final order by pg asc";
        da1 = new SqlDataAdapter(lp, con);
        da1.Fill(ds1);
        double minpg = Convert.ToDouble(ds1.Tables[0].Rows[0][0].ToString());
        double subpg = (maxpg- minpg) / 4;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select sno,ssc,hsc,g,pg,result from final";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count > 0)
        {
            double sscstart1 = 35;
            double sscend1 = sscstart1 + subssc;
            double sscstart2 = sscend1;
            double sscend2 = sscend1 + subssc;
            double sscstart3 = sscend2;
            double sscend3 = sscend2 + subssc;
            double hscstart1 = 35;
            double hscend1 = hscstart1 + subhsc;
            double hscstart2 = hscend1;
            double hscend2 = hscend1 + subhsc;
            double hscstart3 = hscend2;
            double hscend3 = hscend2 + subhsc;
            double gstart1 = 35;
            double gend1 = gstart1 + (subg);
            double gstart2 = gend1;
            double gend2 = gend1 + subg;
            double gstart3 = gend2;
            double gend3 = gend2 + subg;
            double pgstart1 = 35;
            double pgend1 = pgstart1 + (subpg);
            double pgstart2 = pgend1;
            double pgend2 = pgend1 + subpg;
            double pgstart3 = pgend2;
            double pgend3 = pgend2 + subpg;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ssc1 = "",hsc1 = "", g1 = "",pg1="";
                string sno = ds.Tables[0].Rows[i][0].ToString();
                string res = ds.Tables[0].Rows[i][5].ToString();
                double ssc = 0,hsc = 0, g = 0, pg = 0;
                ssc = Convert.ToDouble(ds.Tables[0].Rows[i][1].ToString());
               hsc = Convert.ToDouble(ds.Tables[0].Rows[i][2].ToString());
                g = Convert.ToDouble(ds.Tables[0].Rows[i][3].ToString());
                pg = Convert.ToDouble(ds.Tables[0].Rows[i][4].ToString());

                if (ssc >= sscstart1 && ssc <= sscend1)
                {
                    ssc1= "C";
                }
                else if (ssc > sscstart2 && ssc <= sscend2)
                {
                    ssc1 = "B";
                }
                else
                {
                    ssc1 = "A";
                }
                if (hsc>= hscstart1 && hsc <= hscend1)
                {
                    hsc1 = "F";
                }
                else if (hsc > hscstart2 && hsc <= 20 +hscend2)
                {
                    hsc1 = "E";
                }
                else
                {
                    hsc1 = "D";
                }
                if (g >= gstart1 && g <= gend1)
                {
                    g1 = "R";
                }
                else if (g >= gstart2 &&g <= gend2)
                {
                    g1 = "Q";
                }
                else
                {
                    g1 = "P";
                }
                if (pg >= pgstart1 && pg <= gend1)
                {
                    pg1 = "Z";
                }
                else if (pg >= pgstart2 && pg <= pgend2)
                {
                    pg1 = "Y";
                }
                else
                {
                    pg1 = "X";
                }


                SqlCommand cmd;
                con.Open();
                string me = "insert into main_3 values('" + sno + "','" + ssc1 + "','" + hsc1 + "','" + g1 + "','"+pg1+"','" + res + "')";
                cmd = new SqlCommand(me, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }
        trainingdata();


    }
    public void trainingdata()
    {
        h2= "";
        h1 = "";
        h3= "";
        SqlCommand cmd1;
        con.Open();
        string str1 = "delete from tempssc";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from  temphsc";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from tempg";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from temppg";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from prob_table";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from tree";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from temp1";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        h2 = "";
        h1 = "";
        SqlCommand cmd;
        con.Open();
        string str = "delete from MainFieldCal";
        cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        con.Open();
        str = "delete from FinalBranch";
        cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        con.Open();
        str = "delete from ent_gain";
        cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        string[] arr = new string[4] { "ssc", "hsc", "g", "pg"};
        int flag = 0;

        string yu = "", pp = "";

        for (int i = 0; i < arr.Length; i++)
        {
            // createnewtable(arr[i]);
            insertdata(arr[i]);
            calculateentropy(arr[i]);
            calculateentropyofset(arr[i]);
            calculategain(arr[i], yu, yu);


        }
        Maxvalue();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select Field from FinalBranch";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        string sr = "";
        if (ds.Tables[0].Rows.Count > 0)
        {

            for (int po = 0; po < ds.Tables[0].Rows.Count; po++)
            {
                sr = ds.Tables[0].Rows[po][0].ToString();
                h2 += sr + ",";
                string[] arr1;

                if (sr == "ssc")
                {
                    arr1 = new string[3] { "C", "B", "A" };
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        deletesub();
                        deletenewtable();
                        insertdatasub(sr, arr1[i]);
                        calculateentropyofset(sr);
                        h3 = "";
                        string[] ar = new string[3] { "hsc", "g", "pg" };
                        for (int p = 0; p < ar.Length; p++)
                        {

                            SqlDataAdapter da2;
                            DataSet ds2 = new DataSet();
                            string f = "select field from FinalBranch where field='" + ar[p] + "'";
                            da2 = new SqlDataAdapter(f, con);
                            da2.Fill(ds2);
                            // calculateentropy(ar[p]);

                            //calculategain(ar[p], arr1[i], ar[p]);
                            if (ds2.Tables[0].Rows.Count == 0)
                            {
                                h3 += ar[p] + ",";
                            }
                        }
                        h3 = h3.TrimEnd(',');
                        string[] s = h3.Split(',');
                        foreach (string word in s)
                        {
                            calculateentropy(word);

                            calculategain(word, arr1[i], word);
                        }

                        Maxvalue();
                    }
                    //Maxsub();
                }
                else if (sr == "hsc")
                {
                    arr1 = new string[3] { "F", "E", "D" };
                    for (int i = 0; i < arr1.Length; i++)
                    {


                        deletesub();
                        deletenewtable();
                        insertdatasub(sr, arr1[i]);
                        calculateentropyofset(sr);
                        h3= "";
                        string[] ar = new string[3] { "hsc", "g", "pg" };
                        for (int p = 0; p < ar.Length; p++)
                        {

                            SqlDataAdapter da2;
                            DataSet ds2 = new DataSet();
                            string f = "select field from FinalBranch where field='" + ar[p] + "'";
                            da2 = new SqlDataAdapter(f, con);
                            da2.Fill(ds2);
                            if (ds2.Tables[0].Rows.Count == 0)
                            {
                                h3 += ar[p] + ",";
                            }
                            // calculateentropy(ar[p]);

                            //  calculategain(ar[p], arr1[i], ar[p]);
                        }
                        h3= h3.TrimEnd(',');
                        string[] s = h3.Split(',');
                        foreach (string word in s)
                        {
                            calculateentropy(word);

                            calculategain(word, arr1[i], word);
                        }
                        Maxvalue();
                    }
                    // Maxsub();
                }
                else if (sr == "g")
                {
                    arr1 = new string[3] { "R", "Q", "P" };
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        h3= "";
                        string[] ar = new string[3] { "hsc", "g","pg" };
                        for (int p = 0; p < ar.Length; p++)
                        {

                            SqlDataAdapter da2;
                            DataSet ds2 = new DataSet();
                            string f = "select field from FinalBranch where field='" + ar[p] + "'";
                            da2 = new SqlDataAdapter(f, con);
                            da2.Fill(ds2);
                            if (ds2.Tables[0].Rows.Count == 0)
                            {
                                h3+= ar[p] + ",";
                            }
                            // calculateentropy(ar[p]);

                            //calculategain(ar[p], arr1[i], ar[p]);
                        }
                        h3= h3.TrimEnd(',');
                        string[] s = h3.Split(',');
                        foreach (string word in s)
                        {
                            calculateentropy(word);

                            calculategain(word, arr1[i], word);
                        }
                        Maxvalue();
                    }
                    //  Maxsub();
                }
                else if (sr == "pg")
                {
                    arr1 = new string[3] { "Z", "Y", "X" };
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        h3 = "";
                        string[] ar = new string[3] { "hsc", "g", "pg" };
                        for (int p = 0; p < ar.Length; p++)
                        {

                            SqlDataAdapter da2;
                            DataSet ds2 = new DataSet();
                            string f = "select field from FinalBranch where field='" + ar[p] + "'";
                            da2 = new SqlDataAdapter(f, con);
                            da2.Fill(ds2);
                            if (ds2.Tables[0].Rows.Count == 0)
                            {
                                h3 += ar[p] + ",";
                            }
                            // calculateentropy(ar[p]);

                            //calculategain(ar[p], arr1[i], ar[p]);
                        }
                        h3 = h3.TrimEnd(',');
                        string[] s = h3.Split(',');
                        foreach (string word in s)
                        {
                            calculateentropy(word);

                            calculategain(word, arr1[i], word);
                        }
                        Maxvalue();
                    }
                    //  Maxsub();
                }

                string[] st = h2.Split(',');
                string sm = "";
                for (int l = 0; l < st.Length; l++)
                {
                    sm += " Field<>'" + st[l] + "' and";
                }
                string oldString = sm;
                int lastIndex = sm.LastIndexOf("and");
                string newString = sm;
                if (lastIndex != -1)
                {
                    newString = oldString.Remove(lastIndex).Trim();
                }

                int val = 0;
                ds = new DataSet();
                m = "select  Field from FinalBranch where " + newString + "  and gain>'" + val + "'";
                da = new SqlDataAdapter(m, con);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    po = -1;
                }


            }
        }
        tree();
    }
    void Maxsub()
    {

        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string lp = "select gain,field,subfield from temp1";
        da = new SqlDataAdapter(lp, con);
        da.Fill(ds);
        double gain = 0, max = 0;
        string field = "", subfield = "";
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                gain = Convert.ToDouble(ds.Tables[0].Rows[i][0].ToString());
                if (gain > max)
                {
                    max = gain;
                    field = ds.Tables[0].Rows[i][1].ToString();
                    subfield = ds.Tables[0].Rows[i][2].ToString();
                }

            }
            SqlCommand cmd;
            con.Open();
            string p = "insert into FinalBranch values('" + field + "','" + subfield + "','" + gain + "')";
            cmd = new SqlCommand(p, con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            p = "delete from temp1";
            cmd = new SqlCommand(p, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
    void deletesub()
    {
        SqlCommand cmd;
        con.Open();
        string m = "delete from ent_gain";
        cmd = new SqlCommand(m, con);
        cmd.ExecuteNonQuery();
        con.Close();
        con.Open();
        m = "delete from MainFieldCal";
        cmd = new SqlCommand(m, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    void deletenewtable()
    {
        SqlCommand cmd1;
        con.Open();
        string str1 = "delete from tempssc";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from  temphsc";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from tempg";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        con.Open();
        str1 = "delete from temppg";
        cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();

    }
    void Maxvalue()
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string lp = "select mainfield,gain,sfield from ent_gain";
        da = new SqlDataAdapter(lp, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            double max = 0;
            string field = "";
            string subfield = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                

                double gain = Convert.ToDouble(ds.Tables[0].Rows[i][1].ToString());
                if (gain > max)
                {
                    max = gain;
                    field = ds.Tables[0].Rows[i][0].ToString();
                    subfield = ds.Tables[0].Rows[i][2].ToString();
                }

                if (gain == 0)
                {
                    field = ds.Tables[0].Rows[i][0].ToString();
                    subfield = ds.Tables[0].Rows[i][2].ToString();
                }


            }
            SqlCommand cmd;
            con.Open();
            string ml = "insert into FinalBranch values('" + field + "','" + subfield + "','" + max + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
            /*SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            string op = "select field,subfield,result,prob from prob_table where field='" + field + "' and (prob>'0')";
            da1 = new SqlDataAdapter(op, con);
            da1.Fill(ds1);
            string sr = "";
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    sr = ds1.Tables[0].Rows[i][0].ToString();
                    h11 += sr + ",";
                    con.Open();
                    string tp = "insert into tree values('" + ds1.Tables[0].Rows[i][0].ToString() + "','" + ds1.Tables[0].Rows[i][1].ToString() + "','" + ds1.Tables[0].Rows[i][2].ToString() + "','" + ds1.Tables[0].Rows[i][3].ToString() + "')";
                    cmd = new SqlCommand(tp, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string[] st = h11.Split(',');
                    string sm = "";
                    for (int l = 0; l < st.Length-1; l++)
                    {
                        sm += " field<>'" + st[l] + "' and";
                    }
                    string oldString = sm;
                    int lastIndex = sm.LastIndexOf("and");
                    string newString = sm;
                    if (lastIndex != -1)
                    {
                        newString = oldString.Remove(lastIndex).Trim();
                    }

                    int val = 0;
                    ds1 = new DataSet();
                    op = "select  field,subfield,result,prob from prob_table where " + newString + " and (prob>'0')";
                    da1 = new SqlDataAdapter(op, con);
                    da1.Fill(ds1);
                    if (ds1.Tables[0].Rows.Count == 1)
                    {
                        i = -1;
                    }
                }
            }*/

        }
    }
    void tree()
    {
        string[] f = new string[] { "ssc", "hsc", "g", "pg" };
        string [] arr= new string[3];
        for (int j = 0; j < f.Length; j++)
        {
            if (f[j] == "ssc")
            {
                arr = new string[] { "C", "B", "A" };
            }
            else if (f[j] == "hsc")
            {
                arr = new string[] { "F", "E", "D" };
            }
            else if (f[j] == "g")
            {
                arr = new string[] { "R", "Q", "P" };
            }
            else if (f[j] == "pg")
            {
                arr = new string[] { "Z", "Y", "X" };
            }
            for (int k = 0; k < arr.Length; k++)
            {

                SqlDataAdapter da1;
                DataSet ds1 = new DataSet();
                string op = "select field,subfield,result,prob from prob_table where field='" + f[j] + "' and subfield='"+arr[k]+"' and (prob>'0')";
                da1 = new SqlDataAdapter(op, con);
                da1.Fill(ds1);
                string sr = "";
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    /* for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                     {
                         sr = ds1.Tables[0].Rows[i][0].ToString();
                         h11 += sr + ",";*/
                    SqlCommand cmd;
                    con.Open();
                    string tp = "insert into tree values('" + ds1.Tables[0].Rows[0][0].ToString() + "','" + ds1.Tables[0].Rows[0][1].ToString() + "','" + ds1.Tables[0].Rows[0][2].ToString() + "','" + ds1.Tables[0].Rows[0][3].ToString() + "')";
                    cmd = new SqlCommand(tp, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    /*string[] st = h11.Split(',');
                    string sm = "";
                    for (int l = 0; l < st.Length - 1; l++)
                    {
                        sm += " field<>'" + st[l] + "' and";
                    }
                    string oldString = sm;
                    int lastIndex = sm.LastIndexOf("and");
                    string newString = sm;
                    if (lastIndex != -1)
                    {
                        newString = oldString.Remove(lastIndex).Trim();
                    }

                    int val = 0;
                    ds1 = new DataSet();
                    op = "select  field,subfield,result,prob from prob_table where " + newString + " and (prob>'0')";
                    da1 = new SqlDataAdapter(op, con);
                    da1.Fill(ds1);
                    if (ds1.Tables[0].Rows.Count == 1)
                    {
                        i = -1;
                    }*/
                }
            }
        }
        }
    
    void Maxvalue1()
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string lp = "select mainfield,gain,sfield from ent_gain";
        da = new SqlDataAdapter(lp, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            double max = 0;
            string field = "";
            string subfield = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                double gain = Convert.ToDouble(ds.Tables[0].Rows[i][1].ToString());
                if (gain > max)
                {
                    max = gain;
                    field = ds.Tables[0].Rows[i][0].ToString();
                    subfield = ds.Tables[0].Rows[i][2].ToString();
                }

                if (gain == 0)
                {
                    field = ds.Tables[0].Rows[i][0].ToString();
                    subfield = ds.Tables[0].Rows[i][2].ToString();
                }


            }
            SqlCommand cmd;
            con.Open();
            string ml = "insert into temp1 values('" + field + "','" + subfield + "','" + max + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            string op = "select field,subfield,result,prob from prob_table where field='" + field + "' and prob='1'";
            da1 = new SqlDataAdapter(op, con);
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {

                    con.Open();
                    string tp = "insert into tree values('" + ds1.Tables[0].Rows[i][0].ToString() + "','" + ds1.Tables[0].Rows[i][1].ToString() + "','" + ds1.Tables[0].Rows[i][2].ToString() + "','" + ds1.Tables[0].Rows[i][3].ToString() + "')";
                    cmd = new SqlCommand(tp, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }
    }
    void calculateentropyofset(string field)
    {

        double p = 0;
        double n = 0;
        double n1 = 0;
        if (field == "ssc")
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select ssc from tempssc where result='50'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                p = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select ssc from tempssc where result='60'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select ssc from tempssc where result='80'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n1 = ds.Tables[0].Rows.Count;
            }

            Label1 = Convert.ToString(Entropyofset(p, n,n1));
        }
        else if (field == "hsc")
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select hsc from temphsc where result='50'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                p = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select hsc from temphsc where result='60'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select hsc from temphsc where result='80'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n1 = ds.Tables[0].Rows.Count;
            }

            Label1 = Convert.ToString(Entropyofset(p, n,n1));
        }
        else if (field == "g")
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select g from tempg where result='50'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                p = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select g from tempg where result='60'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select g from tempg where result='80'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n1 = ds.Tables[0].Rows.Count;
            }
            Label1 = Convert.ToString(Entropyofset(p, n,n1));
        }
        else if (field == "pg")
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ml = "select pg from temppg where result='50'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                p = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select pg from temppg where result='60'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n = ds.Tables[0].Rows.Count;
            }
            ds = new DataSet();
            ml = "select pg from temppg where result='80'";
            da = new SqlDataAdapter(ml, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                n1 = ds.Tables[0].Rows.Count;
            }
            Label1 = Convert.ToString(Entropyofset(p, n, n1));
        }
        if (Label1== "NaN")
        {
            Label1 = "0";
        }


    }
    void calculategain(string field, string sub, string sr)
    {
        if (field == "ssc")
        {
            string[] arr = new string[3] { "F", "E", "D" };
            double entropy = 0;
            double gain = 0;
            int m = 0;
            for (m = 0; m < arr.Length; m++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string t = "select pi,ni,I_pini from MainFieldCal where SubField='" + arr[m] + "'";
                da = new SqlDataAdapter(t, con);
                da.Fill(ds);
                double sum = 0;
                double p = 0, n = 0;
                double total = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                    n = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString());
                    sum = (p + n) / Convert.ToDouble(h1);

                    entropy = sum * Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString()) + entropy;
                }
            }
            if (Convert.ToString(entropy) == "NaN")
            {
                entropy = 0;
            }
            gain = Convert.ToDouble(Label1) - entropy;
            if (Convert.ToString(gain) == "NaN")
            {
                gain = 0;
            }
            if (sr != "")
            {
                field = sr;
            }

            SqlCommand cmd;
            con.Open();
            string ml = "insert into ent_gain values('" + field + "','" + sub + "','" + entropy + "','" + gain + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        else if (field == "hsc")
        {
            string[] arr = new string[3] { "F", "E", "D" };
            double entropy = 0;
            double gain = 0;
            int m = 0;
            for (m = 0; m < arr.Length; m++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string t = "select pi,ni,I_pini from MainFieldCal where SubField='" + arr[m] + "'";
                da = new SqlDataAdapter(t, con);
                da.Fill(ds);
                double sum = 0;
                double p = 0, n = 0;
                double total = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                    n = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString());
                    sum = (p + n) / Convert.ToDouble(h1);

                    entropy = sum * Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString()) + entropy;
                }
            }
            if (Convert.ToString(entropy) == "NaN")
            {
                entropy = 0;
            }
            gain = Convert.ToDouble(Label1) - entropy;
            if (Convert.ToString(gain) == "NaN")
            {
                gain = 0;
            }
            if (sr != "")
            {
                field = sr;
            }
            SqlCommand cmd;
            con.Open();
            string ml = "insert into ent_gain values('" + field + "','" + sub + "','" + entropy + "','" + gain + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        else if (field == "g")
        {
            string[] arr = new string[3] { "R", "Q", "P" };
            double entropy = 0;
            double gain = 0;
            int m = 0;
            for (m = 0; m < arr.Length; m++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string t = "select pi,ni,I_pini from MainFieldCal where SubField='" + arr[m] + "'";
                da = new SqlDataAdapter(t, con);
                da.Fill(ds);
                double sum = 0;
                double p = 0, n = 0;
                double total = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                    n = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString());
                    sum = (p + n) / Convert.ToDouble(h1);

                    entropy = sum * Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString()) + entropy;

                }
            }
            if (Convert.ToString(entropy) == "NaN")
            {
                entropy = 0;
            }
            gain = Convert.ToDouble(Label1) - entropy;
            if (Convert.ToString(gain) == "NaN")
            {
                gain = 0;
            }
            if (sr != "")
            {
                field = sr;
            }
            SqlCommand cmd;
            con.Open();
            string ml = "insert into ent_gain values('" + field + "','" + sub + "','" + entropy + "','" + gain + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        else if (field == "pg")
        {
            string[] arr = new string[3] { "Z", "Y", "X" };
            double entropy = 0;
            double gain = 0;
            int m = 0;
            for (m = 0; m < arr.Length; m++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string t = "select pi,ni,I_pini from MainFieldCal where SubField='" + arr[m] + "'";
                da = new SqlDataAdapter(t, con);
                da.Fill(ds);
                double sum = 0;
                double p = 0, n = 0;
                double total = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                    n = Convert.ToDouble(ds.Tables[0].Rows[0][1].ToString());
                    sum = (p + n) / Convert.ToDouble(h1);

                    entropy = sum * Convert.ToDouble(ds.Tables[0].Rows[0][2].ToString()) + entropy;

                }
            }
            if (Convert.ToString(entropy) == "NaN")
            {
                entropy = 0;
            }
            gain = Convert.ToDouble(Label1) - entropy;
            if (Convert.ToString(gain) == "NaN")
            {
                gain = 0;
            }
            if (sr != "")
            {
                field = sr;
            }
            SqlCommand cmd;
            con.Open();
            string ml = "insert into ent_gain values('" + field + "','" + sub + "','" + entropy + "','" + gain + "')";
            cmd = new SqlCommand(ml, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    double Entropyofset(double p, double n,double n1)
    {

        double sum = p + n+n1;
        h1 = Convert.ToString(sum);
        double totalp = p / sum;
        double totaln = n / sum;
        double totaln1 = n1 / sum;
        double entropy = -(totalp) * ((Math.Log(totalp)) / Math.Log(2)) - (totaln) * ((Math.Log(totaln)) / Math.Log(2)) - (totaln1) * ((Math.Log(totaln1)) / Math.Log(2));
        return entropy;
    }
    void insertdata(string field)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string op = "";


        if (field == "ssc")
        {
            op = "select sno,ssc,hsc,g,pg,result from main_3";
            da = new SqlDataAdapter(op, con);
            da.Fill(ds);
            for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
            {
                SqlCommand cmd;
                con.Open();
                string s = "";
                s = "insert into tempssc values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "','" + ds.Tables[0].Rows[l][3].ToString() + "','" + ds.Tables[0].Rows[l][4].ToString() + "','" + ds.Tables[0].Rows[l][5].ToString() + "')";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else if (field == "hsc")
        {
            op = "select sno,hsc,g,pg,result from main_3";
            da = new SqlDataAdapter(op, con);
            da.Fill(ds);
            for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
            {
                SqlCommand cmd;
                con.Open();
                string s = "";
                s = "insert into temphsc values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "','" + ds.Tables[0].Rows[l][3].ToString() + "','" + ds.Tables[0].Rows[l][4].ToString() + "')";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else if (field == "g")
        {
            op = "select sno,g,pg,result from main_3";
            da = new SqlDataAdapter(op, con);
            da.Fill(ds);
            for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
            {
                SqlCommand cmd;
                con.Open();
                string s = "";
                s = "insert into tempg values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "','" + ds.Tables[0].Rows[l][3].ToString() + "')";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else if (field == "pg")
        {
            op = "select sno,pg,result from main_3";
            da = new SqlDataAdapter(op, con);
            da.Fill(ds);
            for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
            {
                SqlCommand cmd;
                con.Open();
                string s = "";
                s = "insert into temppg values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "')";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }

    void insertdatasub(string field, string subfield)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string op = "";



        op = "select sno,ssc,hsc,g,pg,result from main_3 where " + field + "='" + subfield + "'";
        da = new SqlDataAdapter(op, con);
        da.Fill(ds);
        for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
        {
            SqlCommand cmd;
            con.Open();
            string s = "";
            s = "insert into tempssc values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "','" + ds.Tables[0].Rows[l][3].ToString() + "','" + ds.Tables[0].Rows[l][4].ToString() + "','" + ds.Tables[0].Rows[l][5].ToString() + "')";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        ds = new DataSet();
        op = "select sno,hsc,g,pg,result from main_3  where " + field + "='" + subfield + "'";
        da = new SqlDataAdapter(op, con);
        da.Fill(ds);
        for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
        {
            SqlCommand cmd;
            con.Open();
            string s = "";
            s = "insert into temphsc values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "','" + ds.Tables[0].Rows[l][3].ToString() + "','" + ds.Tables[0].Rows[l][4].ToString() + "')";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        ds = new DataSet();
        op = "select sno,g,pg,result from main_3 where " + field + "='" + subfield + "'";
        da = new SqlDataAdapter(op, con);
        da.Fill(ds);
        for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
        {
            SqlCommand cmd;
            con.Open();
            string s = "";
            s = "insert into tempg values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "','" + ds.Tables[0].Rows[l][3].ToString() + "')";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ds = new DataSet();
        op = "select sno,pg,result from main_3 where " + field + "='" + subfield + "'";
        da = new SqlDataAdapter(op, con);
        da.Fill(ds);
        for (int l = 0; l < ds.Tables[0].Rows.Count; l++)
        {
            SqlCommand cmd;
            con.Open();
            string s = "";
            s = "insert into temppg values('" + ds.Tables[0].Rows[l][0].ToString() + "','" + ds.Tables[0].Rows[l][1].ToString() + "','" + ds.Tables[0].Rows[l][2].ToString() + "')";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }

    void calculateentropy(string field)
    {
        if (field == "ssc")
        {
            string[] arr = new string[3] { "C", "B", "A" };
            for (int j = 0; j < arr.Length; j++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string ml = "select sno from tempssc where ssc='" + arr[j] + "' and result='50'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double p = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from tempssc where ssc='" + arr[j] + "' and result='60'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from tempssc where ssc='" + arr[j] + "' and result='80'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q1 = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q1 = ds.Tables[0].Rows.Count;
                }
                string[] val = new string[3] { "50", "60","80" };
                SqlCommand cmd;
                string m = "";
                double sum = p + q+q1;
                for (int i = 0; i < val.Length; i++)
                {
                    if (val[i] == "50")
                    {
                        double prob = probability(p, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "60")
                    {
                        double prob = probability(q, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "80")
                    {
                        double prob = probability(q1, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                double entval = entropy(p, q,q1);

                con.Open();
                m = "insert into MainFieldCal values('" + field + "','" + arr[j] + "','" + p + "','" + q + "','"+q1+"','" + entval + "')";
                cmd = new SqlCommand(m, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else if (field == "hsc")
        {
            string[] arr = new string[3] { "F", "E", "D" };
            for (int j = 0; j < arr.Length; j++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string ml = "select sno from temphsc where hsc='" + arr[j] + "' and result='50'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double p = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from temphsc where hsc='" + arr[j] + "' and result='60'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from temphsc where hsc='" + arr[j] + "' and result='80'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q1 = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q1 = ds.Tables[0].Rows.Count;
                }
                string[] val = new string[3] { "50", "60","80" };
                SqlCommand cmd;
                string m = "";
                double sum = p + q+q1;
                for (int i = 0; i < val.Length; i++)
                {
                    if (val[i] == "50")
                    {
                        double prob = probability(p, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "60")
                    {
                        double prob = probability(q, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "80")
                    {
                        double prob = probability(q1, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                double entval = entropy(p, q,q1);

                con.Open();
                m = "insert into MainFieldCal values('" + field + "','" + arr[j] + "','" + p + "','" + q + "','"+q1+"','" + entval + "')";
                cmd = new SqlCommand(m, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else if (field == "g")
        {
            string[] arr = new string[3] { "R", "Q", "P" };
            for (int j = 0; j < arr.Length; j++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string ml = "select sno from tempg where g='" + arr[j] + "' and result='50'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double p = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from tempg where g='" + arr[j] + "' and result='60'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from tempg where g='" + arr[j] + "' and result='80'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q1 = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q1 = ds.Tables[0].Rows.Count;
                }
                string[] val = new string[3] { "50", "60","80" };
                SqlCommand cmd;
                string m = "";
                double sum = p + q+q1;
                for (int i = 0; i < val.Length; i++)
                {
                    if (val[i] == "50")
                    {
                        double prob = probability(p, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "60")
                    {
                        double prob = probability(q, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "80")
                    {
                        double prob = probability(q1, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                double entval = entropy(p, q,q1);

                con.Open();
                m = "insert into MainFieldCal values('" + field + "','" + arr[j] + "','" + p + "','" + q + "','"+q1+"','" + entval + "')";
                cmd = new SqlCommand(m, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        else if (field == "pg")
        {
            string[] arr = new string[3] { "Z", "Y", "X" };
            for (int j = 0; j < arr.Length; j++)
            {
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string ml = "select sno from temppg where pg='" + arr[j] + "' and result='50'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double p = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    p = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from temppg where pg='" + arr[j] + "' and result='60'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q = ds.Tables[0].Rows.Count;
                }
                ds = new DataSet();
                ml = "select sno from temppg where pg='" + arr[j] + "' and result='80'";
                da = new SqlDataAdapter(ml, con);
                da.Fill(ds);
                double q1 = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    q1 = ds.Tables[0].Rows.Count;
                }
                string[] val = new string[3] { "50", "60", "80" };
                SqlCommand cmd;
                string m = "";
                double sum = p + q+q1;
                for (int i = 0; i < val.Length; i++)
                {
                    if (val[i] == "50")
                    {
                        double prob = probability(p, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "60")
                    {
                        double prob = probability(q, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (val[i] == "80")
                    {
                        double prob = probability(q1, sum);
                        if (Convert.ToString(prob) == "NaN")
                        {
                            prob = 0;
                        }
                        con.Open();
                        m = "insert into prob_table values('" + field + "','" + arr[j] + "','" + val[i] + "','" + prob + "')";
                        cmd = new SqlCommand(m, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                double entval = entropy(p, q,q1);

                con.Open();
                m = "insert into MainFieldCal values('" + field + "','" + arr[j] + "','" + p + "','" + q + "','"+q1+"','" + entval + "')";
                cmd = new SqlCommand(m, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }


    }
    double probability(double p, double sum)
    {

        double totalp = p / sum;

        return totalp;
    }

    double entropy(double p, double n,double nn)
    {
        double sum = p + n+nn;
        double totalp = p / sum;
        double totaln = n / sum;
        double totalnn = nn / sum;
        double entropy = -(totalp) * ((Math.Log(totalp)) / Math.Log(2)) - (totaln) * ((Math.Log(totaln)) / Math.Log(2)) - (totalnn) * ((Math.Log(totalnn)) / Math.Log(2));
        if (Convert.ToString(entropy) == "NaN")
        {
            entropy = 0;
        }
        return entropy;
    }

    
   
   

   
}