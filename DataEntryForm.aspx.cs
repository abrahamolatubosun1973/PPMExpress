using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DataEntryForm : System.Web.UI.Page
{
    public string mChoose { get; set; }     // = string.Empty;
    public string mState { get; set; }      // = string.Empty;
    public string mLGA{ get; set; } // = string.Empty;
    public string mFacility{ get; set; }  // = string.Empty;
    public string mMnth{ get; set; } // = string.Empty;
    public string mYr{ get; set; } // = string.Empty;
    public string mFile{ get; set; } // = string.Empty;
    //ch = (string)Session["choose"]; Response.Write("<script language=javascript>alert('"+ex.Message.ToString()+"');</script>");
    #region ======= Some Definations ======
    //protected void Yrs()
    //{
    //    int YrNo = 2020; //Convert.ToInt32(string.Format("{0}",DateTime.Now.AddYears(3)));
    //    drpYrs.ClearSelection();
    //    drpYrs.Items.Clear();
    //    drpYrs.Items.Add("");
    //    for (int i = 2000; i <= YrNo; i++)
    //    {
    //        drpYrs.Items.Add(i.ToString());
    //    }
    //}

    //protected void FillState()
    //{
    //    string SQl = "Select Distinct statename from tbl_States order by statename asc";
    //    SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
    //    cn.Open();
    //    SqlCommand cmd = new SqlCommand(SQl, cn);
    //    SqlDataReader r = cmd.ExecuteReader();
    //    try
    //    {
    //        drpStates.ClearSelection();
    //        drpStates.Items.Clear();
    //        drpStates.Items.Add("");
    //        while (r.Read()) { drpStates.Items.Add(r["statename"].ToString()); }

    //    }
    //    catch (Exception e)
    //    {

    //    }
    //}

    //protected void FillThematic()
    //{
    //    string SQl = "Select * from tbl_grpname order by abrv asc";
    //    SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
    //    cn.Open();
    //    SqlCommand cmd = new SqlCommand(SQl, cn);
    //    SqlDataReader r = cmd.ExecuteReader();
    //    try
    //    {
    //        drpThematic.ClearSelection();
    //        drpThematic.Items.Clear();
    //        drpThematic.Items.Add("");
    //        while (r.Read()) { drpThematic.Items.Add(r["fname"].ToString()); }

    //    }
    //    catch (Exception e)
    //    {

    //    }
    //}
#endregion
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!Page.IsPostBack)
        {
            //Yrs();
            //FillState();
            //FillThematic();

            if (!string.IsNullOrEmpty(Session["mChoose"] as string))
            {
                mChoose = Session["mChoose"].ToString();
                mState = Session["mState"].ToString();
                mLGA = Session["mLGA"].ToString();
                mFacility = Session["mFacility"].ToString();
                mMnth = Session["mMnth"].ToString();
                mYr = Session["mYr"].ToString();
            }
            //===================================================
            //drpStates.Text = mState;
            //drpLGA.Text = mLGA;
            //drpFacility.Text = mFacility;
            //drpMnth.Text = mMnth;
            //drpYrs.Text = mYr;
            //drpThematic.Text = ch;
           // ch = (string)Session["choose"];

            Session["Edit"] = "F";

            lblThematic.Text = " " + mState + "/" + mLGA + "/" + mFacility + "/" + mMnth + "-" + mYr;
           
            switch (mChoose)
            {
                case "OVC":
                    CLS_OVC();
                    EDIT_OVC();
                    MultiView1.SetActiveView(View1);
                    TextBox3.Focus();
                    break;
                case "FN":
                    MultiView1.SetActiveView(View2);
                    break;
                case "PP":
                    MultiView1.SetActiveView(View3);
                    break;
                case "PEP":
                    MultiView1.SetActiveView(View4);
                    break;
               
                default:
                    break;
            }
        }// end if
       
    }// end page_load
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim()) 
                        + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox10.Focus();
    }
    //protected void TextBox15_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox9.Text = Convert.ToString(Convert.ToInt32(TextBox10.Text) + Convert.ToInt32(TextBox11.Text) + Convert.ToInt32(TextBox12.Text) 
    //                  + Convert.ToInt32(TextBox13.Text) + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text));
    //    TextBox1.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text)+Convert.ToInt32(TextBox9.Text));
    //    TextBox18.Focus();
    //}
    protected void TextBox24_TextChanged(object sender, EventArgs e)
    {
        TextBox17.Text = Convert.ToString(Convert.ToInt32(TextBox18.Text.Trim()) + Convert.ToInt32(TextBox19.Text.Trim()) + Convert.ToInt32(TextBox20.Text.Trim())
                  + Convert.ToInt32(TextBox21.Text.Trim()) + Convert.ToInt32(TextBox22.Text.Trim()) + Convert.ToInt32(TextBox23.Text.Trim()) + Convert.ToInt32(TextBox24.Text.Trim()));
        TextBox26.Focus();
    }
    protected void TextBox32_TextChanged(object sender, EventArgs e)
    {
        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + Convert.ToInt32(TextBox27.Text) + Convert.ToInt32(TextBox28.Text)
                     + Convert.ToInt32(TextBox29.Text) + Convert.ToInt32(TextBox30.Text) + Convert.ToInt32(TextBox31.Text) + Convert.ToInt32(TextBox32.Text));
        TextBox16.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox17.Text));
        TextBox34.Focus();
    }
    protected void TextBox40_TextChanged(object sender, EventArgs e)
    {
        TextBox33.Text = Convert.ToString(Convert.ToInt32(TextBox34.Text) + Convert.ToInt32(TextBox35.Text) + Convert.ToInt32(TextBox36.Text) + Convert.ToInt32(TextBox37.Text) 
                        + Convert.ToInt32(TextBox38.Text) + Convert.ToInt32(TextBox39.Text) + Convert.ToInt32(TextBox40.Text));
        TextBox42.Focus();
    }
    protected void TextBox48_TextChanged(object sender, EventArgs e)
    {
        TextBox41.Text = Convert.ToString(Convert.ToInt32(TextBox42.Text) + Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox44.Text)
                    + Convert.ToInt32(TextBox45.Text) + Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox47.Text) + Convert.ToInt32(TextBox48.Text));
        TextBox49.Text = Convert.ToString(Convert.ToInt32(TextBox33.Text) + Convert.ToInt32(TextBox41.Text));
        TextBox52.Focus();
    }

    protected void TextBox58_TextChanged(object sender, EventArgs e)
    {
        TextBox51.Text = Convert.ToString(Convert.ToInt32(TextBox52.Text) + Convert.ToInt32(TextBox53.Text) + Convert.ToInt32(TextBox54.Text) + Convert.ToInt32(TextBox55.Text)
                        + Convert.ToInt32(TextBox56.Text) + Convert.ToInt32(TextBox57.Text) + Convert.ToInt32(TextBox58.Text));
        TextBox60.Focus();
    }
    protected void TextBox66_TextChanged(object sender, EventArgs e)
    {
        TextBox59.Text = Convert.ToString(Convert.ToInt32(TextBox60.Text) + Convert.ToInt32(TextBox61.Text) + Convert.ToInt32(TextBox62.Text)
                    + Convert.ToInt32(TextBox63.Text) + Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox65.Text) + Convert.ToInt32(TextBox66.Text));
        TextBox50.Text = Convert.ToString(Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox59.Text));
        TextBox69.Focus();
    }
    protected void TextBox75_TextChanged(object sender, EventArgs e)
    {
        TextBox68.Text = Convert.ToString(Convert.ToInt32(TextBox69.Text) + Convert.ToInt32(TextBox70.Text) + Convert.ToInt32(TextBox71.Text) + Convert.ToInt32(TextBox72.Text)
                                + Convert.ToInt32(TextBox73.Text) + Convert.ToInt32(TextBox74.Text) + Convert.ToInt32(TextBox75.Text));
        TextBox77.Focus();
    }
    protected void TextBox83_TextChanged(object sender, EventArgs e)
    {
        TextBox76.Text = Convert.ToString(Convert.ToInt32(TextBox77.Text) + Convert.ToInt32(TextBox78.Text) + Convert.ToInt32(TextBox79.Text)
                  + Convert.ToInt32(TextBox80.Text) + Convert.ToInt32(TextBox81.Text) + Convert.ToInt32(TextBox82.Text) + Convert.ToInt32(TextBox83.Text));
        TextBox67.Text = Convert.ToString(Convert.ToInt32(TextBox68.Text) + Convert.ToInt32(TextBox76.Text));
        TextBox86.Focus();
    }
    protected void TextBox92_TextChanged(object sender, EventArgs e)
    {
        TextBox85.Text = Convert.ToString(Convert.ToInt32(TextBox86.Text) + Convert.ToInt32(TextBox87.Text) + Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text)
                                + Convert.ToInt32(TextBox90.Text) + Convert.ToInt32(TextBox91.Text) + Convert.ToInt32(TextBox92.Text));
        TextBox94.Focus();
    }
    protected void TextBox100_TextChanged(object sender, EventArgs e)
    {
        TextBox93.Text = Convert.ToString(Convert.ToInt32(TextBox94.Text) + Convert.ToInt32(TextBox95.Text) + Convert.ToInt32(TextBox96.Text)
                  + Convert.ToInt32(TextBox97.Text) + Convert.ToInt32(TextBox98.Text) + Convert.ToInt32(TextBox99.Text) + Convert.ToInt32(TextBox100.Text));
        TextBox84.Text = Convert.ToString(Convert.ToInt32(TextBox85.Text) + Convert.ToInt32(TextBox93.Text));
        TextBox103.Focus();
    }
    protected void TextBox109_TextChanged(object sender, EventArgs e)
    {
        TextBox102.Text = Convert.ToString(Convert.ToInt32(TextBox103.Text) + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox105.Text) + Convert.ToInt32(TextBox106.Text)
                                + Convert.ToInt32(TextBox107.Text) + Convert.ToInt32(TextBox108.Text) + Convert.ToInt32(TextBox109.Text));
        TextBox111.Focus();
    }
    protected void TextBox117_TextChanged(object sender, EventArgs e)
    {
        TextBox110.Text = Convert.ToString(Convert.ToInt32(TextBox111.Text) + Convert.ToInt32(TextBox112.Text) + Convert.ToInt32(TextBox113.Text)
                  + Convert.ToInt32(TextBox114.Text) + Convert.ToInt32(TextBox115.Text) + Convert.ToInt32(TextBox116.Text) + Convert.ToInt32(TextBox117.Text));
        TextBox101.Text = Convert.ToString(Convert.ToInt32(TextBox102.Text) + Convert.ToInt32(TextBox110.Text));
        TextBox120.Focus();
    }
    protected void TextBox126_TextChanged(object sender, EventArgs e)
    {
        TextBox119.Text = Convert.ToString(Convert.ToInt32(TextBox120.Text) + Convert.ToInt32(TextBox121.Text) + Convert.ToInt32(TextBox122.Text) 
                         + Convert.ToInt32(TextBox123.Text) + Convert.ToInt32(TextBox124.Text) + Convert.ToInt32(TextBox125.Text) + Convert.ToInt32(TextBox126.Text));
        TextBox128.Focus();
    }
    protected void TextBox134_TextChanged(object sender, EventArgs e)
    {
        TextBox127.Text = Convert.ToString(Convert.ToInt32(TextBox128.Text) + Convert.ToInt32(TextBox129.Text) + Convert.ToInt32(TextBox130.Text)
              + Convert.ToInt32(TextBox131.Text) + Convert.ToInt32(TextBox132.Text) + Convert.ToInt32(TextBox133.Text) + Convert.ToInt32(TextBox134.Text));
        TextBox118.Text = Convert.ToString(Convert.ToInt32(TextBox119.Text) + Convert.ToInt32(TextBox127.Text));
        TextBox137.Focus();
    }
    protected void TextBox143_TextChanged(object sender, EventArgs e)
    {
        TextBox136.Text = Convert.ToString(Convert.ToInt32(TextBox137.Text) + Convert.ToInt32(TextBox138.Text) + Convert.ToInt32(TextBox139.Text)
                        + Convert.ToInt32(TextBox140.Text) + Convert.ToInt32(TextBox141.Text) + Convert.ToInt32(TextBox142.Text) + Convert.ToInt32(TextBox143.Text));
        TextBox145.Focus();
    }
    protected void TextBox151_TextChanged(object sender, EventArgs e)
    {
        TextBox144.Text = Convert.ToString(Convert.ToInt32(TextBox145.Text) + Convert.ToInt32(TextBox146.Text) + Convert.ToInt32(TextBox147.Text)
             + Convert.ToInt32(TextBox148.Text) + Convert.ToInt32(TextBox149.Text) + Convert.ToInt32(TextBox150.Text) + Convert.ToInt32(TextBox151.Text));
        TextBox135.Text = Convert.ToString(Convert.ToInt32(TextBox136.Text) + Convert.ToInt32(TextBox144.Text));
        TextBox154.Focus();
    }
    protected void TextBox160_TextChanged(object sender, EventArgs e)
    {
        TextBox153.Text = Convert.ToString(Convert.ToInt32(TextBox154.Text) + Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox156.Text)
                               + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox158.Text) + Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox160.Text));
        TextBox162.Focus();
    }
    protected void TextBox168_TextChanged(object sender, EventArgs e)
    {
        TextBox161.Text = Convert.ToString(Convert.ToInt32(TextBox162.Text) + Convert.ToInt32(TextBox163.Text) + Convert.ToInt32(TextBox164.Text)
                         + Convert.ToInt32(TextBox165.Text) + Convert.ToInt32(TextBox166.Text) + Convert.ToInt32(TextBox167.Text) + Convert.ToInt32(TextBox168.Text));
        TextBox152.Text = Convert.ToString(Convert.ToInt32(TextBox153.Text) + Convert.ToInt32(TextBox161.Text));
        TextBox170.Focus();
    }
    protected void TextBox175_TextChanged(object sender, EventArgs e)
    {
        TextBox176.Text = Convert.ToString(Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text) + Convert.ToInt32(TextBox172.Text)
                               + Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text));
        TextBox178.Focus();
    }
    protected void TextBox183_TextChanged(object sender, EventArgs e)
    {
        TextBox177.Text = Convert.ToString(Convert.ToInt32(TextBox178.Text) + Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text)
                         + Convert.ToInt32(TextBox181.Text) + Convert.ToInt32(TextBox182.Text) + Convert.ToInt32(TextBox183.Text));
        TextBox169.Text = Convert.ToString(Convert.ToInt32(TextBox176.Text) + Convert.ToInt32(TextBox177.Text));
        TextBox185.Focus();
    }
    protected void TextBox186_TextChanged(object sender, EventArgs e)
    {
        TextBox184.Text = Convert.ToString(Convert.ToInt32(TextBox185.Text)+ Convert.ToInt32(TextBox186.Text));
        btnSave.Focus();
    }

    protected  void CLS_OVC()
    {
        TextBox1.Text=string.Empty;
        TextBox2.Text=string.Empty;
        TextBox3.Text=string.Empty;
        TextBox4.Text=string.Empty;
        TextBox5.Text=string.Empty;
        TextBox6.Text=string.Empty;
        TextBox7.Text=string.Empty;
        TextBox8.Text=string.Empty;
        TextBox9.Text=string.Empty;
        TextBox10.Text=string.Empty;
        TextBox11.Text=string.Empty;
        TextBox12.Text=string.Empty;
        TextBox13.Text=string.Empty;
        TextBox14.Text=string.Empty;
        TextBox15.Text=string.Empty;
        TextBox16.Text=string.Empty;
        TextBox17.Text=string.Empty;
        TextBox18.Text=string.Empty;
        TextBox19.Text=string.Empty;
        TextBox20.Text=string.Empty;
        TextBox21.Text=string.Empty;
        TextBox22.Text=string.Empty;
        TextBox23.Text=string.Empty;
        TextBox24.Text=string.Empty;
        TextBox25.Text=string.Empty;
        TextBox26.Text=string.Empty;
        TextBox27.Text=string.Empty;
        TextBox28.Text=string.Empty;
        TextBox29.Text=string.Empty;
        TextBox30.Text=string.Empty;
        TextBox31.Text=string.Empty;
        TextBox32.Text=string.Empty;
        TextBox49.Text=string.Empty;
        TextBox33.Text=string.Empty;
        TextBox34.Text=string.Empty;
        TextBox35.Text=string.Empty;
        TextBox36.Text=string.Empty;
        TextBox37.Text=string.Empty;
        TextBox38.Text=string.Empty;
        TextBox39.Text=string.Empty;
        TextBox40.Text=string.Empty;
        TextBox41.Text=string.Empty;
        TextBox42.Text=string.Empty;
        TextBox43.Text=string.Empty;
        TextBox44.Text=string.Empty;
        TextBox45.Text=string.Empty;
        TextBox46.Text=string.Empty;
        TextBox47.Text=string.Empty;
        TextBox48.Text=string.Empty;
        TextBox50.Text=string.Empty;
        TextBox51.Text=string.Empty;
        TextBox52.Text=string.Empty;
        TextBox53.Text=string.Empty;
        TextBox54.Text=string.Empty;
        TextBox55.Text=string.Empty;
        TextBox56.Text=string.Empty;
        TextBox57.Text=string.Empty;
        TextBox58.Text=string.Empty;
        TextBox59.Text=string.Empty;
        TextBox60.Text=string.Empty;
        TextBox61.Text=string.Empty;
        TextBox62.Text=string.Empty;
        TextBox63.Text=string.Empty;
        TextBox64.Text=string.Empty;
        TextBox65.Text=string.Empty;
        TextBox66.Text=string.Empty;
        TextBox67.Text=string.Empty;
        TextBox68.Text=string.Empty;
        TextBox69.Text=string.Empty;
        TextBox70.Text=string.Empty;
        TextBox71.Text=string.Empty;
        TextBox72.Text=string.Empty;
        TextBox73.Text=string.Empty;
        TextBox74.Text=string.Empty;
        TextBox75.Text=string.Empty;
        TextBox76.Text=string.Empty;
        TextBox77.Text=string.Empty;
        TextBox78.Text=string.Empty;
        TextBox79.Text=string.Empty;
        TextBox80.Text=string.Empty;
        TextBox81.Text=string.Empty;
        TextBox82.Text=string.Empty;
        TextBox83.Text=string.Empty;
        TextBox84.Text=string.Empty;
        TextBox85.Text=string.Empty;
        TextBox86.Text=string.Empty;
        TextBox87.Text=string.Empty;
        TextBox88.Text=string.Empty;
        TextBox89.Text=string.Empty;
        TextBox90.Text=string.Empty;
        TextBox91.Text=string.Empty;
        TextBox92.Text=string.Empty;
        TextBox93.Text=string.Empty;
        TextBox94.Text=string.Empty;
        TextBox95.Text=string.Empty;
        TextBox96.Text=string.Empty;
        TextBox97.Text=string.Empty;
        TextBox98.Text=string.Empty;
        TextBox99.Text=string.Empty;
        TextBox100.Text=string.Empty;
        TextBox101.Text=string.Empty;
        TextBox102.Text=string.Empty;
        TextBox103.Text=string.Empty;
        TextBox104.Text=string.Empty;
        TextBox105.Text=string.Empty;
        TextBox106.Text=string.Empty;
        TextBox107.Text=string.Empty;
        TextBox108.Text=string.Empty;
        TextBox109.Text=string.Empty;
        TextBox110.Text=string.Empty;
        TextBox111.Text=string.Empty;
        TextBox112.Text=string.Empty;
        TextBox113.Text=string.Empty;
        TextBox114.Text=string.Empty;
        TextBox115.Text=string.Empty;
        TextBox116.Text=string.Empty;
        TextBox117.Text=string.Empty;
        TextBox118.Text=string.Empty;
        TextBox119.Text=string.Empty;
        TextBox120.Text=string.Empty;
        TextBox121.Text=string.Empty;
        TextBox122.Text=string.Empty;
        TextBox123.Text=string.Empty;
        TextBox124.Text=string.Empty;
        TextBox125.Text=string.Empty;
        TextBox126.Text=string.Empty;
        TextBox127.Text=string.Empty;
        TextBox128.Text=string.Empty;
        TextBox129.Text=string.Empty;
        TextBox130.Text=string.Empty;
        TextBox131.Text=string.Empty;
        TextBox132.Text=string.Empty;
        TextBox133.Text=string.Empty;
        TextBox134.Text=string.Empty;
        TextBox135.Text=string.Empty;
        TextBox136.Text=string.Empty;
        TextBox137.Text=string.Empty;
        TextBox138.Text=string.Empty;
        TextBox139.Text=string.Empty;
        TextBox140.Text=string.Empty;
        TextBox141.Text=string.Empty;
        TextBox142.Text=string.Empty;
        TextBox143.Text=string.Empty;
        TextBox144.Text=string.Empty;
        TextBox145.Text=string.Empty;
        TextBox146.Text=string.Empty;
        TextBox147.Text=string.Empty;
        TextBox148.Text=string.Empty;
        TextBox149.Text=string.Empty;
        TextBox150.Text=string.Empty;
        TextBox151.Text=string.Empty;
        TextBox152.Text=string.Empty;
        TextBox153.Text=string.Empty;
        TextBox154.Text=string.Empty;
        TextBox155.Text=string.Empty;
        TextBox156.Text=string.Empty;
        TextBox157.Text=string.Empty;
        TextBox158.Text=string.Empty;
        TextBox159.Text=string.Empty;
        TextBox160.Text=string.Empty;
        TextBox161.Text=string.Empty;
        TextBox162.Text=string.Empty;
        TextBox163.Text=string.Empty;
        TextBox164.Text=string.Empty;
        TextBox165.Text=string.Empty;
        TextBox166.Text=string.Empty;
        TextBox167.Text=string.Empty;
        TextBox168.Text=string.Empty;
        TextBox169.Text=string.Empty;
        TextBox176.Text=string.Empty;
        TextBox170.Text=string.Empty;
        TextBox171.Text=string.Empty;
        TextBox172.Text=string.Empty;
        TextBox173.Text=string.Empty;
        TextBox174.Text=string.Empty;
        TextBox175.Text=string.Empty;
        TextBox177.Text=string.Empty;
        TextBox178.Text=string.Empty;
        TextBox179.Text=string.Empty;
        TextBox180.Text=string.Empty;
        TextBox181.Text=string.Empty;
        TextBox182.Text=string.Empty;
        TextBox183.Text=string.Empty;
        TextBox184.Text=string.Empty;
        TextBox185.Text=string.Empty;
        TextBox186.Text=string.Empty;
        TextBox1.Focus();
    }

    protected void EDIT_OVC()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_OVC Where months ='" + FindTable.GetMonths(mMnth) + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                 TextBox1.Text	= r["TOTALG1"].ToString();
                 TextBox2.Text	= r["SUBG1MA"].ToString();
                 TextBox3.Text	= r["G1MA1"].ToString();
                 TextBox4.Text	= r["G1MA1_4"].ToString();
                 TextBox5.Text	= r["G1MA5_9"].ToString();
                 TextBox6.Text	= r["G1MA10_14"].ToString();
                 TextBox7.Text	= r["G1MA15_17"].ToString();
                TextBox8.Text	= r["G1MA18"].ToString();
                 TextBox9.Text	= r["SUBG1FE"].ToString();
                 TextBox10.Text	= r["G1FE1"].ToString();
                 TextBox11.Text	= r["G1FE1_4"].ToString();
                 TextBox12.Text	= r["G1FE5_9"].ToString();
                 TextBox13.Text	= r["G1FE10_14"].ToString();
                 TextBox14.Text	= r["G1FE15_17"].ToString();
                TextBox15.Text	= r["G1FE18"].ToString();
                 TextBox16.Text	= r["TOTALG2"].ToString();
                 TextBox17.Text	= r["SUBG2MA"].ToString();
                 TextBox18.Text	= r["G2MA1"].ToString();
                 TextBox19.Text	= r["G2MA1_4"].ToString();
                 TextBox20.Text	= r["G2MA5_9"].ToString();
                 TextBox21.Text	= r["G2MA10_14"].ToString();
                 TextBox22.Text	= r["G2MA15_17"].ToString();
                 TextBox23.Text	= r["G2MA18_24"].ToString();
                TextBox24.Text	= r["G2MA25"].ToString();
                 TextBox25.Text	= r["SUBG2FE"].ToString();
                 TextBox26.Text	= r["G2FE1"].ToString();
                 TextBox27.Text	= r["G2FE1_4"].ToString();
                 TextBox28.Text	= r["G2FE5_9"].ToString();
                 TextBox29.Text	= r["G2FE10_14"].ToString();
                 TextBox30.Text	= r["G2FE15_17"].ToString();
                 TextBox31.Text	= r["G2FE18_24"].ToString();
                TextBox32.Text	= r["G2FE25"].ToString();
                 TextBox49.Text	= r["TOTALG3"].ToString();
                 TextBox33.Text	= r["SUBG3MA"].ToString();
                 TextBox34.Text	= r["G3MA1"].ToString();
                 TextBox35.Text	= r["G3MA1_4"].ToString();
                 TextBox36.Text	= r["G3MA5_9"].ToString();
                 TextBox37.Text	= r["G3MA10_14"].ToString();
                 TextBox38.Text	= r["G3MA15_17"].ToString();
                 TextBox39.Text	= r["G3MA18_24"].ToString();
                TextBox40.Text	= r["G3MA25"].ToString();
                 TextBox41.Text	= r["SUBG3FE"].ToString();
                 TextBox42.Text	= r["G3FE1"].ToString();
                 TextBox43.Text	= r["G3FE1_4"].ToString();
                 TextBox44.Text	= r["G3FE5_9"].ToString();
                 TextBox45.Text	= r["G3FE10_14"].ToString();
                 TextBox46.Text	= r["G3FE15_17"].ToString();
                 TextBox47.Text	= r["G3FE18_24"].ToString();
                TextBox48.Text	= r["G3FE25"].ToString();
                 TextBox50.Text	= r["TOTALG4"].ToString();
                 TextBox51.Text	= r["SUBG4MA"].ToString();
                 TextBox52.Text	= r["G4MA1"].ToString();
                 TextBox53.Text	= r["G4MA1_4"].ToString();
                 TextBox54.Text	= r["G4MA5_9"].ToString();
                 TextBox55.Text	= r["G4MA10_14"].ToString();
                 TextBox56.Text	= r["G4MA15_17"].ToString();
                 TextBox57.Text	= r["G4MA18_24"].ToString();
                TextBox58.Text	= r["G4MA25"].ToString();
                 TextBox59.Text	= r["SUBG4FE"].ToString();
                 TextBox60.Text	= r["G4FE1"].ToString();
                 TextBox61.Text	= r["G4FE1_4"].ToString();
                 TextBox62.Text	= r["G4FE5_9"].ToString();
                 TextBox63.Text	= r["G4FE10_14"].ToString();
                 TextBox64.Text	= r["G4FE15_17"].ToString();
                 TextBox65.Text	= r["G4FE18_24"].ToString();
                TextBox66.Text	= r["G4FE25"].ToString();
                 TextBox67.Text	= r["TOTALG5"].ToString();
                 TextBox68.Text	= r["SUBG5MA"].ToString();
                 TextBox69.Text	= r["G5MA1"].ToString();
                 TextBox70.Text	= r["G5MA1_4"].ToString();
                 TextBox71.Text	= r["G5MA5_9"].ToString();
                 TextBox72.Text	= r["G5MA10_14"].ToString();
                 TextBox73.Text	= r["G5MA15_17"].ToString();
                 TextBox74.Text	= r["G5MA18_24"].ToString();
                TextBox75.Text	= r["G5MA25"].ToString();
                 TextBox76.Text	= r["SUBG5FE"].ToString();
                 TextBox77.Text	= r["G5FE1"].ToString();
                 TextBox78.Text	= r["G5FE1_4"].ToString();
                 TextBox79.Text	= r["G5FE5_9"].ToString();
                 TextBox80.Text	= r["G5FE10_14"].ToString();
                 TextBox81.Text	= r["G5FE15_17"].ToString();
                 TextBox82.Text	= r["G5FE18_24"].ToString();
                TextBox83.Text 	= r["G5FE25"].ToString();
                 TextBox84.Text	= r["TOTALG6"].ToString();
                 TextBox85.Text	= r["SUBG6MA"].ToString();
                 TextBox86.Text	= r["G6MA1"].ToString();
                 TextBox87.Text	= r["G6MA1_4"].ToString();
                 TextBox88.Text	= r["G6MA5_9"].ToString();
                 TextBox89.Text	= r["G6MA10_14"].ToString();
                 TextBox90.Text	= r["G6MA15_17"].ToString();
                 TextBox91.Text	= r["G6MA18_24"].ToString();
                TextBox92.Text	= r["G6MA25"].ToString();
                 TextBox93.Text	= r["SUBG6FE"].ToString();
                 TextBox94.Text	= r["G6FE1"].ToString();
                 TextBox95.Text	= r["G6FE1_4"].ToString();
                 TextBox96.Text	= r["G6FE5_9"].ToString();
                 TextBox97.Text	= r["G6FE10_14"].ToString();
                 TextBox98.Text	= r["G6FE15_17"].ToString();
                 TextBox99.Text	= r["G6FE18_24"].ToString();
                TextBox100.Text	= r["G6FE25"].ToString();
                 TextBox101.Text= r["TOTALG7"].ToString();
                 TextBox102.Text= r["SUBG7MA"].ToString();
                 TextBox103.Text= r["G7MA1"].ToString();
                 TextBox104.Text= r["G7MA1_4"].ToString();
                 TextBox105.Text= r["G7MA5_9"].ToString();
                 TextBox106.Text= r["G7MA10_14"].ToString();
                 TextBox107.Text= r["G7MA15_17"].ToString();
                 TextBox108.Text= r["G7MA18_24"].ToString();
                TextBox109.Text	= r["G7MA25"].ToString();
                 TextBox110.Text= r["SUBG7FE"].ToString();
                 TextBox111.Text= r["G7FE1"].ToString();
                 TextBox112.Text= r["G7FE1_4"].ToString();
                 TextBox113.Text= r["G7FE5_9"].ToString();
                 TextBox114.Text= r["G7FE10_14"].ToString();
                 TextBox115.Text= r["G7FE15_17"].ToString();
                 TextBox116.Text= r["G7FE18_24"].ToString();
                TextBox117.Text	= r["G7FE25"].ToString();
                 TextBox118.Text= r["TOTALG8"].ToString();
                 TextBox119.Text= r["SUBG8MA"].ToString();
                 TextBox120.Text= r["G8MA1"].ToString();
                 TextBox121.Text= r["G8MA1_4"].ToString();
                 TextBox122.Text	= r["G8MA5_9"].ToString();
                 TextBox123.Text	= r["G8MA10_14"].ToString();
                 TextBox124.Text	= r["G8MA15_17"].ToString();
                 TextBox125.Text	= r["G8MA18_24"].ToString();
                TextBox126.Text	= r["G8MA25"].ToString();
                 TextBox127.Text	= r["SUBG8FE"].ToString();
                 TextBox128.Text	= r["G8FE1"].ToString();
                 TextBox129.Text	= r["G8FE1_4"].ToString();
                 TextBox130.Text	= r["G8FE5_9"].ToString();
                 TextBox131.Text	= r["G8FE10_14"].ToString();
                 TextBox132.Text	= r["G8FE15_17"].ToString();
                 TextBox133.Text	= r["G8FE18_24"].ToString();
                TextBox134.Text	= r["G8FE25"].ToString();
                 TextBox135.Text	= r["TOTALG9"].ToString();
                 TextBox136.Text	= r["SUBG9MA"].ToString();
                 TextBox137.Text	= r["G9MA1"].ToString();
                 TextBox138.Text	= r["G9MA1_4"].ToString();
                 TextBox139.Text	= r["G9MA5_9"].ToString();
                 TextBox140.Text	= r["G9MA10_14"].ToString();
                 TextBox141.Text	= r["G9MA15_17"].ToString();
                 TextBox142.Text	= r["G9MA18_24"].ToString();
                TextBox143.Text	= r["G9MA25"].ToString();
                 TextBox144.Text	= r["SUBG9FE"].ToString();
                 TextBox145.Text	= r["G9FE1"].ToString();
                 TextBox146.Text	= r["G9FE1_4"].ToString();
                 TextBox147.Text	= r["G9FE5_9"].ToString();
                 TextBox148.Text	= r["G9FE10_14"].ToString();
                 TextBox149.Text	= r["G9FE15_17"].ToString();
                 TextBox150.Text	= r["G9FE18_24"].ToString();
                TextBox151.Text	= r["G9FE25"].ToString();
                TextBox152.Text	= r["TOTALG10"].ToString();
                TextBox153.Text	= r["SUBG10MA"].ToString();
                TextBox154.Text	= r["G10MA1"].ToString();
                TextBox155.Text	= r["G10MA1_4"].ToString();
                TextBox156.Text	= r["G10MA5_9"].ToString();
                TextBox157.Text	= r["G10MA10_14"].ToString();
                TextBox158.Text	= r["G10MA15_17"].ToString();
                TextBox159.Text	= r["G10MA18_24"].ToString();
                TextBox160.Text	= r["G10MA25"].ToString();
                TextBox161.Text	= r["SUBG10FE"].ToString();
                TextBox162.Text	= r["G10FE1"].ToString();
                TextBox163.Text	= r["G10FE1_4"].ToString();
                TextBox164.Text	= r["G10FE5_9"].ToString();
                TextBox165.Text	= r["G10FE10_14"].ToString();
                TextBox166.Text	= r["G10FE15_17"].ToString();
                TextBox167.Text	= r["G10FE18_24"].ToString();
                 TextBox168.Text= r["G10FE25"].ToString();
                TextBox169.Text	= r["TOTALG11"].ToString();
                TextBox176.Text	= r["SUBG11MA"].ToString();
                TextBox170.Text	= r["G11MA1"].ToString();
                TextBox171.Text	= r["G11MA1_4"].ToString();
                TextBox172.Text	= r["G11MA5_9"].ToString();
                TextBox173.Text	= r["G11MA10_14"].ToString();
                TextBox174.Text	= r["G11MA15_17"].ToString();
                TextBox175.Text	= r["G11MA18"].ToString();
                TextBox177.Text	= r["SUBG11FE"].ToString();
                TextBox178.Text	= r["G11FE1"].ToString();
                TextBox179.Text	= r["G11FE1_4"].ToString();
                TextBox180.Text	= r["G11FE5_9"].ToString();
                TextBox181.Text	= r["G11FE10_14"].ToString();
                TextBox182.Text	= r["G11FE15_17"].ToString();
                TextBox183.Text	= r["G11FE18_24"].ToString();
                TextBox184.Text	= r["TOTALG12"].ToString();
                 TextBox185.Text	= r["G12MA"].ToString();
                 TextBox186.Text	= r["G12FE"].ToString();

                 Session["Edit"] = "T";
            }
        }
        catch (Exception ex)
        {
            webMessage.Show("ERROR display OVC content :" + ex.Message);
            return;
        }
    }

    protected void OVC_SAVE()
    {
        if(! string.IsNullOrEmpty(Session["Edit"].ToString()))
        {
            if(Session["Edit"].ToString() =="T")
            {
                string SQL = "UPDATE tbl_OVC  SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG1=@TOTALG1,SUBG1MA=@SUBG1MA, G1MA1=@G1MA1, G1MA1_4=@G1MA1_4, G1MA5_9=@G1MA5_9, G1MA10_14=@G1MA10_14, G1MA15_17=@G1MA15_17, G1MA18=@G1MA18,";
                SQL += " SUBG1FE=@SUBG1FE, G1FE1=@G1FE1, G1FE1_4=@G1FE1_4, G1FE5_9=@G1FE5_9, G1FE10_14=@G1FE10_14, G1FE15_17=@G1FE15_17, G1FE18=@G1FE18, TOTALG2=@TOTALG2, SUBG2MA=@SUBG2MA, G2MA1=@G2MA1, G2MA1_4=@G2MA1_4, G2MA5_9=@G2MA5_9, G2MA10_14=@G2MA10_14, G2MA15_17=@G2MA15_17,";
                SQL += "G2MA18_24=@G2MA18_24, G2MA25=@G2MA25, SUBG2FE=@SUBG2FE, G2FE1=@G2FE1,G2FE1_4=@G2FE1_4, G2FE5_9=@G2FE5_9, G2FE10_14=@G2FE10_14, G2FE15_17=@G2FE15_17, G2FE18_24=@G2FE18_24,G2FE25=@G2FE25, TOTALG3=@TOTALG3,";
                SQL += "SUBG3MA=@SUBG3MA, G3MA1=@G3MA1, G3MA1_4=@G3MA1_4, G3MA5_9=@G3MA5_9, G3MA10_14=@G3MA10_14, G3MA15_17=@G3MA15_17, G3MA18_24=@G3MA18_24, G3MA25=@G3MA25, SUBG3FE=@SUBG3FE, G3FE1=@G3FE1, G3FE1_4=@G3FE1_4, G3FE5_9=@G3FE5_9,";
                SQL += "G3FE10_14=@G3FE10_14, G3FE15_17=@G3FE15_17, G3FE18_24=@G3FE18_24, G3FE25=@G3FE25, TOTALG4=@TOTALG4, SUBG4MA=@SUBG4MA, G4MA1=@G4MA1, G4MA1_4=@G4MA1_4, G4MA5_9=@G4MA5_9, G4MA10_14=@G4MA10_14, G4MA15_17=@G4MA15_17,";
                SQL += "G4MA18_24=@G4MA18_24, G4MA25=@G4MA25, SUBG4FE=@SUBG4FE, G4FE1=@G4FE1, G4FE1_4=@G4FE1_4, G4FE5_9=@G4FE5_9, G4FE10_14=@G4FE10_14, G4FE15_17=@G4FE15_17, G4FE18_24=@G4FE18_24, G4FE25=@G4FE25, TOTALG5=@TOTALG5, SUBG5MA=@SUBG5MA,";
                SQL += "G5MA1=@G5MA1, G5MA1_4=@G5MA1_4,G5MA5_9=@G5MA5_9, G5MA10_14=@G5MA10_14, G5MA15_17=@G5MA15_17, G5MA18_24=@G5MA18_24, G5MA25=@G5MA25, SUBG5FE=@SUBG5FE, G5FE1=@G5FE1, G5FE1_4=@G5FE1_4, G5FE5_9=@G5FE5_9, G5FE10_14=@G5FE10_14,";
                SQL += "G5FE15_17=@G5FE15_17, G5FE18_24=@G5FE18_24, G5FE25=@G5FE25, TOTALG6=@TOTALG6, SUBG6MA=@SUBG6MA, G6MA1=@G6MA1, G6MA1_4=@G6MA1_4, G6MA5_9=@G6MA5_9, G6MA10_14=@G6MA10_14,G6MA15_17=@G6MA15_17, G6MA18_24=@G6MA18_24, G6MA25=@G6MA25,";
                SQL += "SUBG6FE=@SUBG6FE, G6FE1=@G6FE1, G6FE1_4=@G6FE1_4, G6FE5_9=@G6FE5_9, G6FE10_14=@G6FE10_14, G6FE15_17=@G6FE15_17, G6FE18_24=@G6FE18_24, G6FE25=@G6FE25, TOTALG7=@TOTALG7, SUBG7MA=@SUBG7MA, G7MA1=@G7MA1, G7MA1_4=@G7MA1_4, G7MA5_9=@G7MA5_9,";
                SQL += "G7MA10_14=@G7MA10_14, G7MA15_17=@G7MA15_17, G7MA18_24=@G7MA18_24, G7MA25=@G7MA25, SUBG7FE=@SUBG7FE, G7FE1=@G7FE1, G7FE1_4=@G7FE1_4, G7FE5_9=@G7FE5_9, G7FE10_14=@G7FE10_14, G7FE15_17=@G7FE15_17, G7FE18_24=@G7FE18_24, G7FE25=@G7FE25,";
                SQL += "TOTALG8=@TOTALG8, SUBG8MA=@SUBG8MA, G8MA1=@G8MA1, G8MA1_4=@G8MA1_4, G8MA5_9=@G8MA5_9, G8MA10_14=@G8MA10_14, G8MA15_17=@G8MA15_17, G8MA18_24=@G8MA18_24, G8MA25=@G8MA25, SUBG8FE=@SUBG8FE, G8FE1=@G8FE1, G8FE1_4=@G8FE1_4, G8FE5_9=@G8FE5_9, G8FE10_14=@G8FE10_14,";
                SQL += "G8FE15_17=@G8FE15_17, G8FE18_24=@G8FE18_24, G8FE25=@G8FE25, TOTALG9=@TOTALG9,SUBG9MA=@SUBG9MA, G9MA1=@G9MA1, G9MA1_4=@G9MA1_4, G9MA5_9=@G9MA5_9, G9MA10_14=@G9MA10_14,G9MA15_17=@G9MA15_17, G9MA18_24=@G9MA18_24, G9MA25=@G9MA25, SUBG9FE=@SUBG9FE, G9FE1=@G9FE1,";
                SQL += "G9FE1_4=@G9FE1_4, G9FE5_9=@G9FE5_9, G9FE10_14=@G9FE10_14, G9FE15_17=@G9FE15_17, G9FE18_24=@G9FE18_24, G9FE25=@G9FE25, TOTALG10=@TOTALG10, SUBG10MA=@SUBG10MA, G10MA1=@G10MA1, G10MA1_4=@G10MA1_4, G10MA5_9=@G10MA5_9, G10MA10_14=@G10MA10_14,";
                SQL += "G10MA15_17=@G10MA15_17, G10MA18_24=@G10MA18_24, G10MA25=@G10MA25, SUBG10FE=@SUBG10FE, G10FE1=@G10FE1, G10FE1_4=@G10FE1_4, G10FE5_9=@G10FE5_9, G10FE10_14=@G10FE10_14, G10FE15_17=@G10FE15_17, G10FE18_24=@G10FE18_24, G10FE25=@G10FE25, TOTALG11=@TOTALG11,";
                SQL += "SUBG11MA=@SUBG11MA, G11MA1=@G11MA1, G11MA1_4=@G11MA1_4, G11MA5_9=@G11MA5_9, G11MA10_14=@G11MA10_14, G11MA15_17=@G11MA15_17, G11MA18=@G11MA18, SUBG11FE=@SUBG11FE, G11FE1=@G11FE1, G11FE1_4=@G11FE1_4, G11FE5_9=@G11FE5_9, G11FE10_14=@G11FE10_14, G11FE15_17=@G11FE15_17,";
                SQL += "G11FE18_24=@G11FE18_24,TOTALG12=@TOTALG12, G12MA=@G12MA, G12FE=@G12FE WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";
                
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                
                    mState = (string)Session["mstate"];
                    mLGA = (string)Session["mLga"];
                    mFacility = (string)Session["mFacility"];
                   Int32 mMnth = FindTable.GetMonths(Session["mMnth"].ToString());
                    mYr = (string)Session["mYr"];
                    mFile = (string)Session["mFile"];
                    //mChoose = (string)Session["choose"];
                    mChoose =  Session["mChoose"].ToString();

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(SQL, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox1.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox2.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox3.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox4.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox5.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox6.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA15_17", SqlDbType.Int).Value = TextBox7.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA18", SqlDbType.Int).Value = TextBox8.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox9.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox10.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox11.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox12.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox13.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE15_17", SqlDbType.Int).Value = TextBox14.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE18", SqlDbType.Int).Value = TextBox15.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox16.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox17.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox18.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox19.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox20.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox21.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA15_17", SqlDbType.Int).Value = TextBox22.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA18_24", SqlDbType.Int).Value = TextBox23.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA25", SqlDbType.Int).Value = TextBox24.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox25.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox26.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox27.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox28.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox29.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE15_17", SqlDbType.Int).Value = TextBox30.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE18_24", SqlDbType.Int).Value = TextBox31.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE25", SqlDbType.Int).Value = TextBox32.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox49.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox33.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox34.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox35.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox36.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox37.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA15_17", SqlDbType.Int).Value = TextBox38.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA18_24", SqlDbType.Int).Value = TextBox39.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA25", SqlDbType.Int).Value = TextBox40.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox41.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox42.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox43.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox44.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox45.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE15_17", SqlDbType.Int).Value = TextBox46.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE18_24", SqlDbType.Int).Value = TextBox47.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE25", SqlDbType.Int).Value = TextBox48.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox50.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox51.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox52.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox53.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox54.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox55.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA15_17", SqlDbType.Int).Value = TextBox56.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA18_24", SqlDbType.Int).Value = TextBox57.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA25", SqlDbType.Int).Value = TextBox58.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox59.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox60.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox61.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox62.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox63.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE15_17", SqlDbType.Int).Value = TextBox64.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE18_24", SqlDbType.Int).Value = TextBox65.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE25", SqlDbType.Int).Value = TextBox66.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox67.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox68.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox69.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox70.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox71.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox72.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA15_17", SqlDbType.Int).Value = TextBox73.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA18_24", SqlDbType.Int).Value = TextBox74.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA25", SqlDbType.Int).Value = TextBox75.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox76.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE1", SqlDbType.Int).Value = TextBox77.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox78.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox79.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox80.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE15_17", SqlDbType.Int).Value = TextBox81.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE18_24", SqlDbType.Int).Value = TextBox82.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE25", SqlDbType.Int).Value = TextBox83.Text.Trim(); ;
                    cmd.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox84.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox85.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox86.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox87.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox88.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox89.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA15_17", SqlDbType.Int).Value = TextBox90.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA18_24", SqlDbType.Int).Value = TextBox91.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA25", SqlDbType.Int).Value = TextBox92.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox93.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox94.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox95.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox96.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox97.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE15_17", SqlDbType.Int).Value = TextBox98.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE18_24", SqlDbType.Int).Value = TextBox99.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE25", SqlDbType.Int).Value = TextBox100.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox101.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox102.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox103.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox104.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox105.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox106.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA15_17", SqlDbType.Int).Value = TextBox107.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA18_24", SqlDbType.Int).Value = TextBox108.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA25", SqlDbType.Int).Value = TextBox109.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox110.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox111.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox112.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox113.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox114.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE15_17", SqlDbType.Int).Value = TextBox115.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE18_24", SqlDbType.Int).Value = TextBox116.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE25", SqlDbType.Int).Value = TextBox117.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox118.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox119.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox120.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox121.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox122.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox123.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA15_17", SqlDbType.Int).Value = TextBox124.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA18_24", SqlDbType.Int).Value = TextBox125.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA25", SqlDbType.Int).Value = TextBox126.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox127.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox128.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox129.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox130.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox131.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE15_17", SqlDbType.Int).Value = TextBox132.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE18_24", SqlDbType.Int).Value = TextBox133.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE25", SqlDbType.Int).Value = TextBox134.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox135.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox136.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox137.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox138.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox139.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox140.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA15_17", SqlDbType.Int).Value = TextBox141.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA18_24", SqlDbType.Int).Value = TextBox142.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA25", SqlDbType.Int).Value = TextBox143.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox144.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox145.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox146.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox147.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox148.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE15_17", SqlDbType.Int).Value = TextBox149.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE18_24", SqlDbType.Int).Value = TextBox150.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE25", SqlDbType.Int).Value = TextBox151.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox152.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox153.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox154.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox155.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox156.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox157.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA15_17", SqlDbType.Int).Value = TextBox158.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA18_24", SqlDbType.Int).Value = TextBox159.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA25", SqlDbType.Int).Value = TextBox160.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox161.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox162.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox163.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox164.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox165.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE15_17", SqlDbType.Int).Value = TextBox166.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE18_24", SqlDbType.Int).Value = TextBox167.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE25", SqlDbType.Int).Value = TextBox168.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox169.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox176.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox170.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox171.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox172.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox173.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA15_17", SqlDbType.Int).Value = TextBox174.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA18", SqlDbType.Int).Value = TextBox175.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox177.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox178.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox179.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox180.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox181.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE15_17", SqlDbType.Int).Value = TextBox182.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE18_24", SqlDbType.Int).Value = TextBox183.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox184.Text.Trim();
                    cmd.Parameters.AddWithValue("@G12MA", SqlDbType.Int).Value = TextBox185.Text.Trim();
                    cmd.Parameters.AddWithValue("@G12FE", SqlDbType.Int).Value = TextBox186.Text.Trim();
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show( Rowsaffected.ToString() + "' Successful");
                        CLS_OVC();
                        return;
                    }

            }
            else
            {
                string sql = "INSERT INTO tbl_OVC ";
                sql += "(states,lga,facname,months,years,grouptype,TOTALG1,SUBG1MA, G1MA1, G1MA1_4, G1MA5_9, G1MA10_14, G1MA15_17, G1MA18,";
                sql += " SUBG1FE, G1FE1, G1FE1_4, G1FE5_9, G1FE10_14, G1FE15_17, G1FE18, TOTALG2, SUBG2MA, G2MA1, G2MA1_4, G2MA5_9, G2MA10_14, G2MA15_17,";
                sql += "G2MA18_24, G2MA25, SUBG2FE, G2FE1,G2FE1_4, G2FE5_9, G2FE10_14, G2FE15_17, G2FE18_24,G2FE25, TOTALG3,";
                sql += "SUBG3MA, G3MA1, G3MA1_4, G3MA5_9, G3MA10_14, G3MA15_17, G3MA18_24, G3MA25, SUBG3FE, G3FE1, G3FE1_4, G3FE5_9,";
                sql += "G3FE10_14, G3FE15_17, G3FE18_24, G3FE25, TOTALG4, SUBG4MA, G4MA1, G4MA1_4, G4MA5_9, G4MA10_14, G4MA15_17,";
                sql += "G4MA18_24, G4MA25, SUBG4FE, G4FE1, G4FE1_4, G4FE5_9, G4FE10_14, G4FE15_17, G4FE18_24, G4FE25, TOTALG5, SUBG5MA,";
                sql += "G5MA1, G5MA1_4,G5MA5_9, G5MA10_14, G5MA15_17, G5MA18_24, G5MA25, SUBG5FE, G5FE1, G5FE1_4, G5FE5_9, G5FE10_14,";
                sql += "G5FE15_17, G5FE18_24, G5FE25, TOTALG6, SUBG6MA, G6MA1, G6MA1_4, G6MA5_9, G6MA10_14,G6MA15_17, G6MA18_24, G6MA25,";
                sql += "SUBG6FE, G6FE1, G6FE1_4, G6FE5_9, G6FE10_14, G6FE15_17, G6FE18_24, G6FE25, TOTALG7, SUBG7MA, G7MA1, G7MA1_4, G7MA5_9,";
                sql += "G7MA10_14, G7MA15_17, G7MA18_24, G7MA25, SUBG7FE, G7FE1, G7FE1_4, G7FE5_9, G7FE10_14, G7FE15_17, G7FE18_24, G7FE25,";
                sql += "TOTALG8, SUBG8MA, G8MA1, G8MA1_4, G8MA5_9, G8MA10_14, G8MA15_17, G8MA18_24, G8MA25, SUBG8FE, G8FE1, G8FE1_4, G8FE5_9, G8FE10_14,";
                sql += "G8FE15_17, G8FE18_24, G8FE25, TOTALG9,SUBG9MA, G9MA1, G9MA1_4, G9MA5_9, G9MA10_14,G9MA15_17, G9MA18_24, G9MA25, SUBG9FE, G9FE1,";
                sql += "G9FE1_4, G9FE5_9, G9FE10_14, G9FE15_17, G9FE18_24, G9FE25, TOTALG10, SUBG10MA, G10MA1, G10MA1_4, G10MA5_9, G10MA10_14,";
                sql += "G10MA15_17, G10MA18_24, G10MA25, SUBG10FE, G10FE1, G10FE1_4, G10FE5_9, G10FE10_14, G10FE15_17, G10FE18_24, G10FE25, TOTALG11,";
                sql += "SUBG11MA, G11MA1, G11MA1_4, G11MA5_9, G11MA10_14, G11MA15_17, G11MA18, SUBG11FE, G11FE1, G11FE1_4, G11FE5_9, G11FE10_14, G11FE15_17,";
                sql += "G11FE18_24,TOTALG12, G12MA, G12FE)";

                sql += "VALUES (@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1,@SUBG1MA, @G1MA1, @G1MA1_4, @G1MA5_9, @G1MA10_14, @G1MA15_17, @G1MA18,";
                sql += " @SUBG1FE, @G1FE1, @G1FE1_4, @G1FE5_9, @G1FE10_14, @G1FE15_17, @G1FE18, @TOTALG2, @SUBG2MA, @G2MA1, @G2MA1_4, @G2MA5_9, @G2MA10_14, @G2MA15_17,";
                sql += "@G2MA18_24, @G2MA25, @SUBG2FE, @G2FE1,@G2FE1_4, @G2FE5_9, @G2FE10_14, @G2FE15_17, @G2FE18_24,@G2FE25, @TOTALG3,";
                sql += "@SUBG3MA, @G3MA1, @G3MA1_4, @G3MA5_9, @G3MA10_14, @G3MA15_17, @G3MA18_24, @G3MA25, @SUBG3FE, @G3FE1, @G3FE1_4, @G3FE5_9,";
                sql += "@G3FE10_14, @G3FE15_17, @G3FE18_24, @G3FE25, @TOTALG4, @SUBG4MA, @G4MA1, @G4MA1_4, @G4MA5_9, @G4MA10_14, @G4MA15_17,";
                sql += "@G4MA18_24, @G4MA25, @SUBG4FE, @G4FE1, @G4FE1_4, @G4FE5_9, @G4FE10_14, @G4FE15_17, @G4FE18_24, @G4FE25, @TOTALG5, @SUBG5MA,";
                sql += "@G5MA1, @G5MA1_4,@G5MA5_9, @G5MA10_14, @G5MA15_17, @G5MA18_24, @G5MA25, @SUBG5FE, @G5FE1, @G5FE1_4, @G5FE5_9, @G5FE10_14,";
                sql += "@G5FE15_17, @G5FE18_24, @G5FE25, @TOTALG6, @SUBG6MA, @G6MA1, @G6MA1_4, @G6MA5_9, @G6MA10_14,@G6MA15_17, @G6MA18_24, @G6MA25,";
                sql += "@SUBG6FE, @G6FE1, @G6FE1_4, @G6FE5_9, @G6FE10_14, @G6FE15_17, @G6FE18_24, @G6FE25, @TOTALG7, @SUBG7MA, @G7MA1, @G7MA1_4, @G7MA5_9,";
                sql += "@G7MA10_14, @G7MA15_17, @G7MA18_24, @G7MA25, @SUBG7FE, @G7FE1, @G7FE1_4, @G7FE5_9, @G7FE10_14, @G7FE15_17, @G7FE18_24, @G7FE25,";
                sql += "@TOTALG8, @SUBG8MA, @G8MA1, @G8MA1_4, @G8MA5_9, @G8MA10_14, @G8MA15_17, @G8MA18_24, @G8MA25, @SUBG8FE, @G8FE1, @G8FE1_4, @G8FE5_9, @G8FE10_14,";
                sql += "@G8FE15_17, @G8FE18_24, @G8FE25, @TOTALG9,@SUBG9MA, @G9MA1, @G9MA1_4, @G9MA5_9, @G9MA10_14,@G9MA15_17, @G9MA18_24, @G9MA25, @SUBG9FE, @G9FE1,";
                sql += "@G9FE1_4, @G9FE5_9, @G9FE10_14, @G9FE15_17, @G9FE18_24, @G9FE25, @TOTALG10, @SUBG10MA, @G10MA1, @G10MA1_4, @G10MA5_9, @G10MA10_14,";
                sql += "@G10MA15_17, @G10MA18_24, @G10MA25, @SUBG10FE, @G10FE1, @G10FE1_4, @G10FE5_9, @G10FE10_14, @G10FE15_17, @G10FE18_24, @G10FE25, @TOTALG11,";
                sql += "@SUBG11MA, @G11MA1, @G11MA1_4, @G11MA5_9, @G11MA10_14, @G11MA15_17, @G11MA18, @SUBG11FE, @G11FE1, @G11FE1_4, @G11FE5_9, @G11FE10_14, @G11FE15_17,";
                sql += "@G11FE18_24,@TOTALG12, @G12MA, @G12FE)";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    mState = (string)Session["mstate"];
                    mLGA = (string)Session["mLga"];
                    mFacility = (string)Session["mFacility"];
                   Int32 mMnth = FindTable.GetMonths(Session["mMnth"].ToString());
                    mYr = (string)Session["mYr"];
                    mFile = (string)Session["mFile"];
                    //mChoose = (string)Session["choose"];
                    mChoose =  Session["mChoose"].ToString();

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox1.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox2.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox3.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox4.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox5.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox6.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA15_17", SqlDbType.Int).Value = TextBox7.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA18", SqlDbType.Int).Value = TextBox8.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox9.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox10.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox11.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox12.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox13.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE15_17", SqlDbType.Int).Value = TextBox14.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE18", SqlDbType.Int).Value = TextBox15.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox16.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox17.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox18.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox19.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox20.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox21.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA15_17", SqlDbType.Int).Value = TextBox22.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA18_24", SqlDbType.Int).Value = TextBox23.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA25", SqlDbType.Int).Value = TextBox24.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox25.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox26.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox27.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox28.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox29.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE15_17", SqlDbType.Int).Value = TextBox30.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE18_24", SqlDbType.Int).Value = TextBox31.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE25", SqlDbType.Int).Value = TextBox32.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox49.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox33.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox34.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox35.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox36.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox37.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA15_17", SqlDbType.Int).Value = TextBox38.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA18_24", SqlDbType.Int).Value = TextBox39.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA25", SqlDbType.Int).Value = TextBox40.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox41.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox42.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox43.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox44.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox45.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE15_17", SqlDbType.Int).Value = TextBox46.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE18_24", SqlDbType.Int).Value = TextBox47.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE25", SqlDbType.Int).Value = TextBox48.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox50.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox51.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox52.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox53.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox54.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox55.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA15_17", SqlDbType.Int).Value = TextBox56.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA18_24", SqlDbType.Int).Value = TextBox57.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA25", SqlDbType.Int).Value = TextBox58.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox59.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox60.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox61.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox62.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox63.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE15_17", SqlDbType.Int).Value = TextBox64.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE18_24", SqlDbType.Int).Value = TextBox65.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE25", SqlDbType.Int).Value = TextBox66.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox67.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox68.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox69.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox70.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox71.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox72.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA15_17", SqlDbType.Int).Value = TextBox73.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA18_24", SqlDbType.Int).Value = TextBox74.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA25", SqlDbType.Int).Value = TextBox75.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox76.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE1", SqlDbType.Int).Value = TextBox77.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox78.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox79.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox80.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE15_17", SqlDbType.Int).Value = TextBox81.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE18_24", SqlDbType.Int).Value = TextBox82.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5FE25", SqlDbType.Int).Value = TextBox83.Text.Trim(); ;
                    cmd.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox84.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox85.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox86.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox87.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox88.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox89.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA15_17", SqlDbType.Int).Value = TextBox90.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA18_24", SqlDbType.Int).Value = TextBox91.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6MA25", SqlDbType.Int).Value = TextBox92.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox93.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox94.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox95.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox96.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox97.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE15_17", SqlDbType.Int).Value = TextBox98.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE18_24", SqlDbType.Int).Value = TextBox99.Text.Trim();
                    cmd.Parameters.AddWithValue("@G6FE25", SqlDbType.Int).Value = TextBox100.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox101.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox102.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox103.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox104.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox105.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox106.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA15_17", SqlDbType.Int).Value = TextBox107.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA18_24", SqlDbType.Int).Value = TextBox108.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7MA25", SqlDbType.Int).Value = TextBox109.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox110.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox111.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox112.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox113.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox114.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE15_17", SqlDbType.Int).Value = TextBox115.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE18_24", SqlDbType.Int).Value = TextBox116.Text.Trim();
                    cmd.Parameters.AddWithValue("@G7FE25", SqlDbType.Int).Value = TextBox117.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox118.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox119.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox120.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox121.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox122.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox123.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA15_17", SqlDbType.Int).Value = TextBox124.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA18_24", SqlDbType.Int).Value = TextBox125.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8MA25", SqlDbType.Int).Value = TextBox126.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox127.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox128.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox129.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox130.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox131.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE15_17", SqlDbType.Int).Value = TextBox132.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE18_24", SqlDbType.Int).Value = TextBox133.Text.Trim();
                    cmd.Parameters.AddWithValue("@G8FE25", SqlDbType.Int).Value = TextBox134.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox135.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox136.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox137.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox138.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox139.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox140.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA15_17", SqlDbType.Int).Value = TextBox141.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA18_24", SqlDbType.Int).Value = TextBox142.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9MA25", SqlDbType.Int).Value = TextBox143.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox144.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox145.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox146.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox147.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox148.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE15_17", SqlDbType.Int).Value = TextBox149.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE18_24", SqlDbType.Int).Value = TextBox150.Text.Trim();
                    cmd.Parameters.AddWithValue("@G9FE25", SqlDbType.Int).Value = TextBox151.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox152.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox153.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox154.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox155.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox156.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox157.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA15_17", SqlDbType.Int).Value = TextBox158.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA18_24", SqlDbType.Int).Value = TextBox159.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10MA25", SqlDbType.Int).Value = TextBox160.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox161.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox162.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox163.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox164.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox165.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE15_17", SqlDbType.Int).Value = TextBox166.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE18_24", SqlDbType.Int).Value = TextBox167.Text.Trim();
                    cmd.Parameters.AddWithValue("@G10FE25", SqlDbType.Int).Value = TextBox168.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox169.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox176.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox170.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox171.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox172.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox173.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA15_17", SqlDbType.Int).Value = TextBox174.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11MA18", SqlDbType.Int).Value = TextBox175.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox177.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox178.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox179.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox180.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox181.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE15_17", SqlDbType.Int).Value = TextBox182.Text.Trim();
                    cmd.Parameters.AddWithValue("@G11FE18_24", SqlDbType.Int).Value = TextBox183.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox184.Text.Trim();
                    cmd.Parameters.AddWithValue("@G12MA", SqlDbType.Int).Value = TextBox185.Text.Trim();
                    cmd.Parameters.AddWithValue("@G12FE", SqlDbType.Int).Value = TextBox186.Text.Trim();
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show( Rowsaffected.ToString() + "' Successful");
                        CLS_OVC();
                        return;
                    }
                    CLS_OVC();

                }
                catch (Exception ex)
                {
                    // error mode
                  webMessage.Show("ERROR Saving OVC :"+ ex.Message.ToString() );
                    return;
                }

            }
        }

    }


    protected void EDIT_FN()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_FN Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                TextBox187.Text = r["TOTALG1"].ToString();
                TextBox188.Text = r["SUBG1MA"].ToString();
                TextBox189.Text = r["G1MA1"].ToString();
                TextBox190.Text = r["G1MA1_4"].ToString();
                TextBox191.Text = r["G1MA5_9"].ToString();
                TextBox192.Text = r["G1MA10_14"].ToString();
                TextBox193.Text = r["G1MA15_18"].ToString();
                TextBox194.Text = r["G1MA18"].ToString();
                TextBox195.Text = r["SUBG1FE"].ToString();
                TextBox196.Text = r["G1FE1"].ToString();
                TextBox197.Text = r["G1FE1_4"].ToString();
                TextBox198.Text = r["G1FE5_9"].ToString();
                TextBox199.Text = r["G1FE10_14"].ToString();
                TextBox200.Text = r["G1FE15_18"].ToString();
                TextBox201.Text = r["G1FE18"].ToString();
                TextBox202.Text = r["TOTALG2"].ToString();
                TextBox203.Text = r["SUBG2MA"].ToString();
                TextBox204.Text = r["G2MA1"].ToString();
                TextBox205.Text = r["G2MA1_4"].ToString();
                TextBox206.Text = r["G2MA5_9"].ToString();
                TextBox207.Text = r["G2MA10_14"].ToString();
                TextBox208.Text = r["G2MA15_18"].ToString();
                TextBox209.Text = r["G2MA18"].ToString();
                TextBox210.Text = r["SUBG2FE"].ToString();
                TextBox211.Text = r["G2FE1"].ToString();
                TextBox212.Text = r["G2FE1_4"].ToString();
                TextBox213.Text = r["G2FE5_9"].ToString();
                TextBox214.Text = r["G2FE10_14"].ToString();
                TextBox215.Text = r["G2FE15_18"].ToString();
                TextBox216.Text = r["G2FE18"].ToString();
                TextBox217.Text = r["PREGNANTG2"].ToString();
                TextBox218.Text = r["POSTPARTUMG2"].ToString();
                TextBox219.Text = r["TOTALG3"].ToString();
                TextBox220.Text = r["SUBG3MA"].ToString();
                TextBox221.Text = r["G3MA1"].ToString();
                TextBox222.Text = r["G3MA1_4"].ToString();
                TextBox223.Text = r["G3MA5_9"].ToString();
                TextBox224.Text = r["G3MA10_14"].ToString();
                TextBox225.Text = r["G3MA15_18"].ToString();
                TextBox226.Text = r["G3MA18"].ToString();
                TextBox227.Text = r["SUBG3FE"].ToString();
                TextBox228.Text = r["G3FE1"].ToString();
                TextBox229.Text = r["G3FE1_4"].ToString();
                TextBox230.Text = r["G3FE5_9"].ToString();
                TextBox231.Text = r["G3FE10_14"].ToString();
                TextBox232.Text = r["G3FE15_18"].ToString();
                TextBox233.Text = r["G3FE18"].ToString();
                TextBox234.Text = r["PREGNANTG3"].ToString();
                TextBox235.Text = r["POSTPARTUMG3"].ToString();
                TextBox236.Text = r["TOTALG4"].ToString();
                TextBox237.Text = r["SUBG4MA"].ToString();
                TextBox238.Text = r["G4MA1"].ToString();
                TextBox239.Text = r["G4MA1_4"].ToString();
                TextBox240.Text = r["G4MA5_9"].ToString();
                TextBox241.Text = r["G4MA10_14"].ToString();
                TextBox242.Text = r["G4MA15_18"].ToString();
                TextBox243.Text = r["G4MA18"].ToString();
                TextBox244.Text = r["SUBG4FE"].ToString();
                TextBox245.Text = r["G4FE1"].ToString();
                TextBox246.Text = r["G4FE1_4"].ToString();
                TextBox247.Text = r["G4FE5_9"].ToString();
                TextBox248.Text = r["G4FE10_14"].ToString();
                TextBox249.Text = r["G4FE15_18"].ToString();
                TextBox250.Text = r["G4FE18"].ToString();
                TextBox251.Text = r["PREGNANTG4"].ToString();
                TextBox252.Text = r["POSTPARTUMG4"].ToString();

                Session["Edit"] = "T";
            }
        }
        catch (Exception ex)
        {
            webMessage.Show("ERROR Saving OVC :" + ex.Message.ToString());
            return;
        }
    }

    protected void FN_SAVE()
    {
        if(! string.IsNullOrEmpty(Session["Edit"].ToString()))
        {
            if(Session["Edit"] =="T")
            {
                //================= UPDATE =============
                string sql = "UPDATE tbl_FN SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG1=@TOTALG1, SUBG1MA=@SUBG1MA,";
                sql += " G1MA1=@G1MA1, G1MA1_4=@G1MA1_4, G1MA5_9=@G1MA5_9, G1MA10_14=@G1MA10_14,G1MA15_18=@G1MA15_18, G1MA18=@G1MA18, SUBG1FE=@SUBG1FE, G1FE1=@G1FE1, G1FE1_4=@G1FE1_4, G1FE5_9=@G1FE5_9, G1FE10_14=@G1FE10_14, G1FE15_18=@G1FE15_18, G1FE18=@G1FE18,";
                sql += "TOTALG2=@TOTALG2, SUBG2MA=@SUBG2MA, G2MA1=@G2MA1, G2MA1_4=@G2MA1_4, G2MA5_9=@G2MA5_9, G2MA10_14=@G2MA10_14, G2MA15_18=@G2MA15_18, G2MA18=@G2MA18, SUBG2FE=@SUBG2FE, G2FE1=@G2FE1";
                sql += "G2FE1_4=@G2FE1_4, G2FE5_9=@G2FE5_9, G2FE10_14=@G2FE10_14, G2FE15_18=@G2FE15_18, G2FE18=@G2FE18, PREGNANTG2=@PREGNANTG2, POSTPARTUMG2=@POSTPARTUMG2, TOTALG3=@TOTALG3,";
                sql += "SUBG3MA=@SUBG3MA, G3MA1=@G3MA1, G3MA1_4=@G3MA1_4, G3MA5_9=@G3MA5_9, G3MA10_14=@G3MA10_14, G3MA15_18=@G3MA15_18, G3MA18=@G3MA18, SUBG3FE=@SUBG3FE, G3FE1=@G3FE1, G3FE1_4=@G3FE1_4,";
                sql += "G3FE5_9=@G3FE5_9, G3FE10_14=@G3FE10_14, G3FE15_18=@G3FE15_18, G3FE18=@G3FE18, PREGNANTG3=@PREGNANTG3, POSTPARTUMG3=@POSTPARTUMG3, TOTALG4=@TOTALG4, SUBG4MA=@SUBG4MA, G4MA1=@G4MA1,";
                sql += "G4MA1_4=@G4MA1_4, G4MA5_9=@G4MA5_9, G4MA10_14=@G4MA10_14, G4MA15_18=@G4MA15_18, G4MA18=@G4MA18, SUBG4FE=@SUBG4FE, G4FE1=@G4FE1, G4FE1_4=@G4FE1_4, G4FE5_9=@G4FE5_9, G4FE10_14=@G4FE10_14,";
                sql += "G4FE15_18=@G4FE15_18, G4FE18=@G4FE18, PREGNANTG4=@PREGNANTG4, @POSTPARTUMG4=POSTPARTUMG4";
                sql += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {

                    mState = (string)Session["mstate"];
                    mLGA = (string)Session["mLga"];
                    mFacility = (string)Session["mFacility"];
                    mMnth = (string)Session["mMnth"];
                    mYr = (string)Session["mYr"];
                    mFile = (string)Session["mFile"];
                    mChoose = (string)Session["mChoose"];

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox187.Text;
                    cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox188.Text;
                    cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox189.Text;
                    cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox190.Text;
                    cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox191.Text;
                    cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox192.Text;
                    cmd.Parameters.AddWithValue("@G1MA15_18", SqlDbType.Int).Value = TextBox193.Text;
                    cmd.Parameters.AddWithValue("@G1MA18", SqlDbType.Int).Value = TextBox194.Text;
                    cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox195.Text;
                    cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox196.Text;
                    cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox197.Text;
                    cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox198.Text;
                    cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox199.Text;
                    cmd.Parameters.AddWithValue("@G1FE15_18", SqlDbType.Int).Value = TextBox200.Text;
                    cmd.Parameters.AddWithValue("@G1FE18", SqlDbType.Int).Value = TextBox201.Text;
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox202.Text;
                    cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox203.Text;
                    cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox204.Text;
                    cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox205.Text;
                    cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox206.Text;
                    cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox207.Text;
                    cmd.Parameters.AddWithValue("@G2MA15_18", SqlDbType.Int).Value = TextBox208.Text;
                    cmd.Parameters.AddWithValue("@G2MA18", SqlDbType.Int).Value = TextBox209.Text;
                    cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox210.Text;
                    cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox211.Text;
                    cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox212.Text;
                    cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox213.Text;
                    cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox214.Text;
                    cmd.Parameters.AddWithValue("@G2FE15_18", SqlDbType.Int).Value = TextBox215.Text;
                    cmd.Parameters.AddWithValue("@G2FE18", SqlDbType.Int).Value = TextBox216.Text;
                    cmd.Parameters.AddWithValue("@PREGNANTG2", SqlDbType.Int).Value = TextBox217.Text;
                    cmd.Parameters.AddWithValue("@POSTPARTUMG2", SqlDbType.Int).Value = TextBox218.Text;
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox219.Text;
                    cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox220.Text;
                    cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox221.Text;
                    cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox222.Text;
                    cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox223.Text;
                    cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox224.Text;
                    cmd.Parameters.AddWithValue("@G3MA15_18", SqlDbType.Int).Value = TextBox225.Text;
                    cmd.Parameters.AddWithValue("@G3MA18", SqlDbType.Int).Value = TextBox226.Text;
                    cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox227.Text;
                    cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox228.Text;
                    cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox229.Text;
                    cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox230.Text;
                    cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox231.Text;
                    cmd.Parameters.AddWithValue("@G3FE15_18", SqlDbType.Int).Value = TextBox232.Text;
                    cmd.Parameters.AddWithValue("@G3FE18", SqlDbType.Int).Value = TextBox233.Text;
                    cmd.Parameters.AddWithValue("@PREGNANTG3", SqlDbType.Int).Value = TextBox234.Text;
                    cmd.Parameters.AddWithValue("@POSTPARTUMG3", SqlDbType.Int).Value = TextBox235.Text;
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox236.Text;
                    cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox237.Text;
                    cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox238.Text;
                    cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox239.Text;
                    cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox240.Text;
                    cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox241.Text;
                    cmd.Parameters.AddWithValue("@G4MA15_18", SqlDbType.Int).Value = TextBox242.Text;
                    cmd.Parameters.AddWithValue("@G4MA18", SqlDbType.Int).Value = TextBox243.Text;
                    cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox244.Text;
                    cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox245.Text;
                    cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox246.Text;
                    cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox247.Text;
                    cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox248.Text;
                    cmd.Parameters.AddWithValue("@G4FE15_18", SqlDbType.Int).Value = TextBox249.Text;
                    cmd.Parameters.AddWithValue("@G4FE18", SqlDbType.Int).Value = TextBox250.Text;
                    cmd.Parameters.AddWithValue("@PREGNANTG4", SqlDbType.Int).Value = TextBox251.Text;
                    cmd.Parameters.AddWithValue("@POSTPARTUMG4", SqlDbType.Int).Value = TextBox252.Text;
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "'Update Successful");
                        return;
                    }
                    CLS_FN();
                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR " + ex.Message.ToString());
                    return;
                }
            }
            else
            {
                //============= INSERT ==================
                string sql = "INSERT INTO tbl_FN (states ,lga ,facname ,months ,year ,grouptyp ,TOTALG1 , SUBG1MA ,";
                sql += " G1MA1 , G1MA1_4 , G1MA5_9 , G1MA10_14 ,G1MA15_18 , G1MA18 , SUBG1FE , G1FE1 , G1FE1_4 , G1FE5_9 , G1FE10_14 , G1FE15_1 , G1FE18 ,";
                sql += "TOTALG2 , SUBG2MA , G2MA1 , G2MA1_4 , G2MA5_9 , G2MA10_14 , G2MA15_18 , G2MA18 , SUBG2FE , G2FE1 ";
                sql += "G2FE1_4 , G2FE5_9 , G2FE10_14 , G2FE15_18 , G2FE18 , PREGNANTG2 , POSTPARTUMG2 , TOTALG3 ,";
                sql += "SUBG3MA , G3MA1 , G3MA1_4 , G3MA5_9 , G3MA10_14 , G3MA15_18 , G3MA18 , SUBG3FE , G3FE1 , G3FE1_4 ,";
                sql += "G3FE5_9 , G3FE10_14 , G3FE15_18 , G3FE18 , PREGNANTG3 , POSTPARTUMG3 , TOTALG4 , SUBG4MA , G4MA1 ,";
                sql += "G4MA1_4 , G4MA5_9 , G4MA10_14 , G4MA15_18 , G4MA18 , SUBG4FE , G4FE1 , G4FE1_4 , G4FE5_9 , G4FE10_14 ,";
                sql += "G4FE15_18 , G4FE18 , PREGNANTG4 , @POSTPARTUMG4  VALUES(@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1, @SUBG1MA, ";
                sql += "@G1MA1, @G1MA1_4, @G1MA5_9, @G1MA10_14,@G1MA15_18, @G1MA18, @SUBG1FE, @G1FE1, @G1FE1_4, @G1FE5_9, @G1FE10_14, @G1FE15_18, @G1FE18,";
                sql += "@TOTALG2, @SUBG2MA, @G2MA1, @G2MA1_4, @G2MA5_9, @G2MA10_14, @G2MA15_18, @G2MA18, @SUBG2FE, @G2FE1";
                sql += "@G2FE1_4, @G2FE5_9, @G2FE10_14, @G2FE15_18, @G2FE18, @PREGNANTG2, @POSTPARTUMG2, @TOTALG3,";
                sql += "@SUBG3MA, @G3MA1, @G3MA1_4, @G3MA5_9, @G3MA10_14, @G3MA15_18, @G3MA18, @SUBG3FE, @G3FE1, @G3FE1_4,";
                sql += "@G3FE5_9, @G3FE10_14, @G3FE15_18, @G3FE18, @PREGNANTG3, @POSTPARTUMG3, @TOTALG4, @SUBG4MA, @G4MA1,";
                sql += "@G4MA1_4, @G4MA5_9, @G4MA10_14, @G4MA15_18, @G4MA18, @SUBG4FE, @G4FE1, @G4FE1_4, @G4FE5_9, @G4FE10_14,";
                sql += "@G4FE15_18, @G4FE18, @PREGNANTG4, @POSTPARTUMG4)";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {

                    mState = (string)Session["mstate"];
                    mLGA = (string)Session["mLga"];
                    mFacility = (string)Session["mFacility"];
                    mMnth = (string)Session["mMnth"];
                    mYr = (string)Session["mYr"];
                    mFile = (string)Session["mFile"];
                    mChoose = (string)Session["mChoose"];

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox187.Text;
                    cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox188.Text;
                    cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox189.Text;
                    cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox190.Text;
                    cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox191.Text;
                    cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox192.Text;
                    cmd.Parameters.AddWithValue("@G1MA15_18", SqlDbType.Int).Value = TextBox193.Text;
                    cmd.Parameters.AddWithValue("@G1MA18", SqlDbType.Int).Value = TextBox194.Text;
                    cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox195.Text;
                    cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox196.Text;
                    cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox197.Text;
                    cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox198.Text;
                    cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox199.Text;
                    cmd.Parameters.AddWithValue("@G1FE15_18", SqlDbType.Int).Value = TextBox200.Text;
                    cmd.Parameters.AddWithValue("@G1FE18", SqlDbType.Int).Value = TextBox201.Text;
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox202.Text;
                    cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox203.Text;
                    cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox204.Text;
                    cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox205.Text;
                    cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox206.Text;
                    cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox207.Text;
                    cmd.Parameters.AddWithValue("@G2MA15_18", SqlDbType.Int).Value = TextBox208.Text;
                    cmd.Parameters.AddWithValue("@G2MA18", SqlDbType.Int).Value = TextBox209.Text;
                    cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox210.Text;
                    cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox211.Text;
                    cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox212.Text;
                    cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox213.Text;
                    cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox214.Text;
                    cmd.Parameters.AddWithValue("@G2FE15_18", SqlDbType.Int).Value = TextBox215.Text;
                    cmd.Parameters.AddWithValue("@G2FE18", SqlDbType.Int).Value = TextBox216.Text;
                    cmd.Parameters.AddWithValue("@PREGNANTG2", SqlDbType.Int).Value = TextBox217.Text;
                    cmd.Parameters.AddWithValue("@POSTPARTUMG2", SqlDbType.Int).Value = TextBox218.Text;
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox219.Text;
                    cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox220.Text;
                    cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox221.Text;
                    cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox222.Text;
                    cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox223.Text;
                    cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox224.Text;
                    cmd.Parameters.AddWithValue("@G3MA15_18", SqlDbType.Int).Value = TextBox225.Text;
                    cmd.Parameters.AddWithValue("@G3MA18", SqlDbType.Int).Value = TextBox226.Text;
                    cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox227.Text;
                    cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox228.Text;
                    cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox229.Text;
                    cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox230.Text;
                    cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox231.Text;
                    cmd.Parameters.AddWithValue("@G3FE15_18", SqlDbType.Int).Value = TextBox232.Text;
                    cmd.Parameters.AddWithValue("@G3FE18", SqlDbType.Int).Value = TextBox233.Text;
                    cmd.Parameters.AddWithValue("@PREGNANTG3", SqlDbType.Int).Value = TextBox234.Text;
                    cmd.Parameters.AddWithValue("@POSTPARTUMG3", SqlDbType.Int).Value = TextBox235.Text;
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox236.Text;
                    cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox237.Text;
                    cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox238.Text;
                    cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox239.Text;
                    cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox240.Text;
                    cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox241.Text;
                    cmd.Parameters.AddWithValue("@G4MA15_18", SqlDbType.Int).Value = TextBox242.Text;
                    cmd.Parameters.AddWithValue("@G4MA18", SqlDbType.Int).Value = TextBox243.Text;
                    cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox244.Text;
                    cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox245.Text;
                    cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox246.Text;
                    cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox247.Text;
                    cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox248.Text;
                    cmd.Parameters.AddWithValue("@G4FE15_18", SqlDbType.Int).Value = TextBox249.Text;
                    cmd.Parameters.AddWithValue("@G4FE18", SqlDbType.Int).Value = TextBox250.Text;
                    cmd.Parameters.AddWithValue("@PREGNANTG4", SqlDbType.Int).Value = TextBox251.Text;
                    cmd.Parameters.AddWithValue("@POSTPARTUMG4", SqlDbType.Int).Value = TextBox252.Text;
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                      webMessage.Show( Rowsaffected.ToString() + "' Successful");
                        return;
                    }
                    CLS_FN();
                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR "+ ex.Message.ToString());
                    return;
                }

            }
        }

       
    }//======== FN_Save end

    protected void CLS_FN()
    {
        TextBox187.Text = string.Empty;
        TextBox188.Text = string.Empty;
        TextBox189.Text = string.Empty;
        TextBox190.Text = string.Empty;
        TextBox191.Text = string.Empty;
        TextBox192.Text = string.Empty;
        TextBox193.Text = string.Empty;
        TextBox194.Text = string.Empty;
        TextBox195.Text = string.Empty;
        TextBox196.Text = string.Empty;
        TextBox197.Text = string.Empty;
        TextBox198.Text = string.Empty;
        TextBox199.Text = string.Empty;
        TextBox200.Text = string.Empty;
        TextBox201.Text = string.Empty;
        TextBox202.Text = string.Empty;
        TextBox203.Text = string.Empty;
        TextBox204.Text = string.Empty;
        TextBox205.Text = string.Empty;
        TextBox206.Text = string.Empty;
        TextBox207.Text = string.Empty;
        TextBox208.Text = string.Empty;
        TextBox209.Text = string.Empty;
        TextBox210.Text = string.Empty;
        TextBox211.Text = string.Empty;
        TextBox212.Text = string.Empty;
        TextBox213.Text = string.Empty;
        TextBox214.Text = string.Empty;
        TextBox215.Text = string.Empty;
        TextBox216.Text = string.Empty;
        TextBox217.Text = string.Empty;
        TextBox218.Text = string.Empty;
        TextBox219.Text = string.Empty;
        TextBox220.Text = string.Empty;
        TextBox221.Text = string.Empty;
        TextBox222.Text = string.Empty;
        TextBox223.Text = string.Empty;
        TextBox224.Text = string.Empty;
        TextBox225.Text = string.Empty;
        TextBox226.Text = string.Empty;
        TextBox227.Text = string.Empty;
        TextBox228.Text = string.Empty;
        TextBox229.Text = string.Empty;
        TextBox230.Text = string.Empty;
        TextBox231.Text = string.Empty;
        TextBox232.Text = string.Empty;
        TextBox233.Text = string.Empty;
        TextBox234.Text = string.Empty;
        TextBox235.Text = string.Empty;
        TextBox236.Text = string.Empty;
        TextBox237.Text = string.Empty;
        TextBox238.Text = string.Empty;
        TextBox239.Text = string.Empty;
        TextBox240.Text = string.Empty;
        TextBox241.Text = string.Empty;
        TextBox242.Text = string.Empty;
        TextBox243.Text = string.Empty;
        TextBox244.Text = string.Empty;
        TextBox245.Text = string.Empty;
        TextBox246.Text = string.Empty;
        TextBox247.Text = string.Empty;
        TextBox248.Text = string.Empty;
        TextBox249.Text = string.Empty;
        TextBox250.Text = string.Empty;
        TextBox251.Text = string.Empty;
        TextBox252.Text = string.Empty;

    } /// ======= CLS FN end


    protected void EDIT_PP()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_PP Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                TextBox253.Text = r["TOTALG1"].ToString();
                TextBox254.Text = r["SCHL_BASEDG1"].ToString();
                TextBox255.Text = r["SB_SUBG1MA"].ToString();
                TextBox256.Text = r["SB_G1MA10_14"].ToString();
                TextBox257.Text = r["SB_G1MA15_19"].ToString();
                TextBox258.Text = r["SB_G1MA20_49"].ToString();
                TextBox259.Text = r["SB_SUBG1FE"].ToString();
                TextBox260.Text = r["SB_G1FE10_14"].ToString();
                TextBox261.Text = r["SB_G1FE15_19"].ToString();
                TextBox262.Text = r["SB_G1FE20_49"].ToString();
                TextBox263.Text = r["COMM_BASEDG1"].ToString();
                TextBox264.Text = r["CB_SUBG1MA"].ToString();
                TextBox265.Text = r["CB_G1MA10_14"].ToString();
                TextBox266.Text = r["CB_G1MA15_19"].ToString();
                TextBox267.Text = r["CB_G1MA20_49"].ToString();
                TextBox268.Text = r["CB_SUBG1FE"].ToString();
                TextBox269.Text = r["CB_G1FE10_14"].ToString();
                TextBox270.Text = r["CB_G1FE15_19"].ToString();
                TextBox271.Text = r["CB_G1FE20_49"].ToString();
                TextBox272.Text = r["TOTALG2"].ToString();
                TextBox273.Text = r["SCHL_BASEDG2"].ToString();
                TextBox274.Text = r["SB_SUBG2MA"].ToString();
                TextBox275.Text = r["SB_G2MA10_14"].ToString();
                TextBox276.Text = r["SB_G2MA15_19"].ToString();
                TextBox277.Text = r["SB_G2MA20_49"].ToString();
                TextBox278.Text = r["SB_SUBG2FE"].ToString();
                TextBox279.Text = r["SB_G2FE10_14"].ToString();
                TextBox280.Text = r["SB_G2FE15_19"].ToString();
                TextBox281.Text = r["SB_G2FE20_49"].ToString();
                TextBox282.Text = r["COMM_BASEDG2"].ToString();
                TextBox283.Text = r["CB_SUBG2MA"].ToString();
                TextBox284.Text = r["CB_G2MA10_14"].ToString();
                TextBox285.Text = r["CB_G2MA15_19"].ToString();
                TextBox286.Text = r["CB_G2MA20_49"].ToString();
                TextBox287.Text = r["CB_SUBG2FE"].ToString();
                TextBox288.Text = r["CB_G2FE10_14"].ToString();
                TextBox289.Text = r["CB_G2FE15_19"].ToString();
                TextBox290.Text = r["CB_G2FE20_49"].ToString();
                TextBox291.Text = r["TOTALG3"].ToString();
                TextBox292.Text = r["G3MA"].ToString();
                TextBox293.Text = r["G3FE"].ToString();
                TextBox294.Text = r["KPG3"].ToString();
                TextBox295.Text = r["TOTALG4"].ToString();
                TextBox296.Text = r["G4FSW"].ToString();
                TextBox297.Text = r["G4PWID"].ToString();
                TextBox298.Text = r["G4MA"].ToString();
                TextBox299.Text = r["G4FE"].ToString();
                TextBox300.Text = r["G4MSM_TG"].ToString();
                TextBox301.Text = r["G4MSM_TG_SEXW"].ToString();
                TextBox302.Text = r["G4OTHER"].ToString();
                TextBox303.Text = r["TOTALG5"].ToString();
                TextBox304.Text = r["G5MA"].ToString();
                TextBox796.Text = r["G5FE"].ToString();

                Session["Edit"] = "T";
            }

        }catch(Exception ex)
        {
            webMessage.Show("ERROR Displaying PP records " + ex.Message);
            return;

        }
    }



    protected void PP_SAVE()
    {
        if (!string.IsNullOrEmpty(Session["Edit"].ToString()))
        {
            if (Session["Edit"] == "T")
            {
                //================ UPDATE EXISTING RECORD =================
                string sql = "UPDATE tbl_PP SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG1=@TOTALG1, SCHL_BASEDG1=@SCHL_BASEDG1,";
                sql += " SB_SUBG1MA=@SB_SUBG1MA, SB_G1MA10_14=@SB_G1MA10_14, SB_G1MA15_19=@SB_G1MA15_19,SB_G1MA20_49=@SB_G1MA20_49, SB_SUBG1FE=@SB_SUBG1FE, SB_G1FE10_14=@SB_G1FE10_14,SB_G1FE15_19=@SB_G1FE15_19, SB_G1FE20_49=@SB_G1FE20_49,";
                sql += "COMM_BASEDG1=@COMM_BASEDG1, CB_SUBG1MA=@CB_SUBG1MA, CB_G1MA10_14=@CB_G1MA10_14, CB_G1MA15_19=@CB_G1MA15_19, CB_G1MA20_49=@CB_G1MA20_49,";
                sql += "CB_SUBG1FE=@CB_SUBG1FE, CB_G1FE10_14=@CB_G1FE10_14, CB_G1FE15_19=@CB_G1FE15_19, CB_G1FE20_49=@CB_G1FE20_49, TOTALG2=@TOTALG2, SCHL_BASEDG2=@SCHL_BASEDG2,";
                sql += "SB_SUBG2MA=@SB_SUBG2MA, SB_G2MA10_14=@SB_G2MA10_14, SB_G2MA15_19=@SB_G2MA15_19, SB_G2MA20_49=@SB_G2MA20_49, SB_SUBG2FE=@SB_SUBG2FE, SB_G2FE10_14=@SB_G2FE10_14,";
                sql += "SB_G2FE15_19=@SB_G2FE15_19, SB_G2FE20_49=@SB_G2FE20_49, COMM_BASEDG2=@COMM_BASEDG2, CB_SUBG2MA=@CB_SUBG2MA, CB_G2MA10_14=@CB_G2MA10_14, CB_G2MA15_19=@CB_G2MA15_19,";
                sql += "CB_G2MA20_49=@CB_G2MA20_49, CB_SUBG2FE=@CB_SUBG2FE, CB_G2FE10_14=@CB_G2FE10_14, CB_G2FE15_19=@CB_G2FE15_19, CB_G2FE20_49=@CB_G2FE20_49, TOTALG3=@TOTALG3, G3MA=@G3MA,";
                sql += "G3FE=@G3FE, KPG3=@KPG3, TOTALG4=@TOTALG4, G4FSW=@G4FSW, G4PWID=@G4PWID, G4MA=@G4MA, G4FE=@G4FE, G4MSM_TG=@G4MSM_TG, G4MSM_TG_SEXWRK=@G4MSM_TG_SEXWRK, G4OTHER=@G4OTHER,";
                sql += "TOTALG5=@TOTALG5, G5MA=@G5MA, G5FE=@G5FE";
                sql += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());

                try
                {
                    mState = (string)Session["mstate"];
                    mLGA = (string)Session["mLga"];
                    mFacility = (string)Session["mFacility"];
                    mMnth = (string)Session["mMnth"];
                    mYr = (string)Session["mYr"];
                    mFile = (string)Session["mFile"];
                    mChoose = (string)Session["mChoose"];

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox253.Text;
                    cmd.Parameters.AddWithValue("@SCHL_BASEDG1", SqlDbType.Int).Value = TextBox254.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG1MA", SqlDbType.Int).Value = TextBox255.Text;
                    cmd.Parameters.AddWithValue("@SB_G1MA10_14", SqlDbType.Int).Value = TextBox256.Text;
                    cmd.Parameters.AddWithValue("@SB_G1MA15_19", SqlDbType.Int).Value = TextBox257.Text;
                    cmd.Parameters.AddWithValue("@SB_G1MA20_49", SqlDbType.Int).Value = TextBox258.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG1FE", SqlDbType.Int).Value = TextBox259.Text;
                    cmd.Parameters.AddWithValue("@SB_G1FE10_14", SqlDbType.Int).Value = TextBox260.Text;
                    cmd.Parameters.AddWithValue("@SB_G1FE15_19", SqlDbType.Int).Value = TextBox261.Text;
                    cmd.Parameters.AddWithValue("@SB_G1FE20_49", SqlDbType.Int).Value = TextBox262.Text;
                    cmd.Parameters.AddWithValue("@COMM_BASEDG1", SqlDbType.Int).Value = TextBox263.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG1MA", SqlDbType.Int).Value = TextBox264.Text;
                    cmd.Parameters.AddWithValue("@CB_G1MA10_14", SqlDbType.Int).Value = TextBox265.Text;
                    cmd.Parameters.AddWithValue("@CB_G1MA15_19", SqlDbType.Int).Value = TextBox266.Text;
                    cmd.Parameters.AddWithValue("@CB_G1MA20_49", SqlDbType.Int).Value = TextBox267.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG1FE", SqlDbType.Int).Value = TextBox268.Text;
                    cmd.Parameters.AddWithValue("@CB_G1FE10_14", SqlDbType.Int).Value = TextBox269.Text;
                    cmd.Parameters.AddWithValue("@CB_G1FE15_19", SqlDbType.Int).Value = TextBox270.Text;
                    cmd.Parameters.AddWithValue("@CB_G1FE20_49", SqlDbType.Int).Value = TextBox271.Text;
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox272.Text;
                    cmd.Parameters.AddWithValue("@SCHL_BASEDG2", SqlDbType.Int).Value = TextBox273.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG2MA", SqlDbType.Int).Value = TextBox274.Text;
                    cmd.Parameters.AddWithValue("@SB_G2MA10_14", SqlDbType.Int).Value = TextBox275.Text;
                    cmd.Parameters.AddWithValue("@SB_G2MA15_19", SqlDbType.Int).Value = TextBox276.Text;
                    cmd.Parameters.AddWithValue("@SB_G2MA20_49", SqlDbType.Int).Value = TextBox277.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG2FE", SqlDbType.Int).Value = TextBox278.Text;
                    cmd.Parameters.AddWithValue("@SB_G2FE10_14", SqlDbType.Int).Value = TextBox279.Text;
                    cmd.Parameters.AddWithValue("@SB_G2FE15_19", SqlDbType.Int).Value = TextBox280.Text;
                    cmd.Parameters.AddWithValue("@SB_G2FE20_49", SqlDbType.Int).Value = TextBox281.Text;
                    cmd.Parameters.AddWithValue("@COMM_BASEDG2", SqlDbType.Int).Value = TextBox282.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG2MA", SqlDbType.Int).Value = TextBox283.Text;
                    cmd.Parameters.AddWithValue("@CB_G2MA10_14", SqlDbType.Int).Value = TextBox284.Text;
                    cmd.Parameters.AddWithValue("@CB_G2MA15_19", SqlDbType.Int).Value = TextBox285.Text;
                    cmd.Parameters.AddWithValue("@CB_G2MA20_49", SqlDbType.Int).Value = TextBox286.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG2FE", SqlDbType.Int).Value = TextBox287.Text;
                    cmd.Parameters.AddWithValue("@CB_G2FE10_14", SqlDbType.Int).Value = TextBox288.Text;
                    cmd.Parameters.AddWithValue("@CB_G2FE15_19", SqlDbType.Int).Value = TextBox289.Text;
                    cmd.Parameters.AddWithValue("@CB_G2FE20_49", SqlDbType.Int).Value = TextBox290.Text;
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox291.Text;
                    cmd.Parameters.AddWithValue("@G3MA", SqlDbType.Int).Value = TextBox292.Text;
                    cmd.Parameters.AddWithValue("@G3FE", SqlDbType.Int).Value = TextBox293.Text;
                    cmd.Parameters.AddWithValue("@KPG3", SqlDbType.Int).Value = TextBox294.Text;
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox295.Text;
                    cmd.Parameters.AddWithValue("@G4FSW", SqlDbType.Int).Value = TextBox296.Text;
                    cmd.Parameters.AddWithValue("@G4PWID", SqlDbType.Int).Value = TextBox297.Text;
                    cmd.Parameters.AddWithValue("@G4MA", SqlDbType.Int).Value = TextBox298.Text;
                    cmd.Parameters.AddWithValue("@G4FE", SqlDbType.Int).Value = TextBox299.Text;
                    cmd.Parameters.AddWithValue("@G4MSM_TG", SqlDbType.Int).Value = TextBox300.Text;
                    cmd.Parameters.AddWithValue("@G4MSM_TG_SEXW", SqlDbType.Int).Value = TextBox301.Text;
                    cmd.Parameters.AddWithValue("@G4OTHER", SqlDbType.Int).Value = TextBox302.Text;
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox303.Text;
                    cmd.Parameters.AddWithValue("@G5MA", SqlDbType.Int).Value = TextBox304.Text;
                    cmd.Parameters.AddWithValue("@G5FE", SqlDbType.Int).Value = TextBox796.Text;
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "'Update Successful");
                        return;
                    }
                    CLS_PP();
                    cn.Close();

                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR Saving PP " + ex.Message.ToString());
                    return;
                }

            }
            else
            {
                //===================== INSERT NEW RECORD ====================
                string sql = "INSERT INTO tbl_PP VALUES (@states,@lga,@facname,@months,@years,@gouptype,@TOTALG1, @SCHL_BASEDG1,";
                sql += " @SB_SUBG1MA, @SB_G1MA10_14, @SB_G1MA15_19,@SB_G1MA20_49, @SB_SUBG1FE, @SB_G1FE10_14,  @SB_G1FE15_19, @SB_G1FE20_49,";
                sql += "@COMM_BASEDG1, @CB_SUBG1MA, @CB_G1MA10_14, @CB_G1MA15_19, @CB_G1MA20_49,";
                sql += "@CB_SUBG1FE, @CB_G1FE10_14, @CB_G1FE15_19, @CB_G1FE20_49, @TOTALG2, @SCHL_BASEDG2,";
                sql += "@SB_SUBG2MA, @SB_G2MA10_14, @SB_G2MA15_19, @SB_G2MA20_49, @SB_SUBG2FE, @SB_G2FE10_14,";
                sql += "@SB_G2FE15_19, @SB_G2FE20_49, @COMM_BASEDG2, @CB_SUBG2MA, @CB_G2MA10_14, @CB_G2MA15_19,";
                sql += "@CB_G2MA20_49, @CB_SUBG2FE, @CB_G2FE10_14, @CB_G2FE15_19, @CB_G2FE20_49, @TOTALG3, @G3MA,";
                sql += "@G3FE, @KPG3, @TOTALG4, @G4FSW, @G4PWID, @G4MA, @G4FE, @G4MSM_TG, @G4MSM_TG_SEXWRK, @G4OTHER,";
                sql += "@TOTALG5, @G5MA, @G5FE)";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());

                try
                {
                    mState = (string)Session["mstate"];
                    mLGA = (string)Session["mLga"];
                    mFacility = (string)Session["mFacility"];
                    mMnth = (string)Session["mMnth"];
                    mYr = (string)Session["mYr"];
                    mFile = (string)Session["mFile"];
                    mChoose = (string)Session["mChoose"];

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox253.Text;
                    cmd.Parameters.AddWithValue("@SCHL_BASEDG1", SqlDbType.Int).Value = TextBox254.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG1MA", SqlDbType.Int).Value = TextBox255.Text;
                    cmd.Parameters.AddWithValue("@SB_G1MA10_14", SqlDbType.Int).Value = TextBox256.Text;
                    cmd.Parameters.AddWithValue("@SB_G1MA15_19", SqlDbType.Int).Value = TextBox257.Text;
                    cmd.Parameters.AddWithValue("@SB_G1MA20_49", SqlDbType.Int).Value = TextBox258.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG1FE", SqlDbType.Int).Value = TextBox259.Text;
                    cmd.Parameters.AddWithValue("@SB_G1FE10_14", SqlDbType.Int).Value = TextBox260.Text;
                    cmd.Parameters.AddWithValue("@SB_G1FE15_19", SqlDbType.Int).Value = TextBox261.Text;
                    cmd.Parameters.AddWithValue("@SB_G1FE20_49", SqlDbType.Int).Value = TextBox262.Text;
                    cmd.Parameters.AddWithValue("@COMM_BASEDG1", SqlDbType.Int).Value = TextBox263.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG1MA", SqlDbType.Int).Value = TextBox264.Text;
                    cmd.Parameters.AddWithValue("@CB_G1MA10_14", SqlDbType.Int).Value = TextBox265.Text;
                    cmd.Parameters.AddWithValue("@CB_G1MA15_19", SqlDbType.Int).Value = TextBox266.Text;
                    cmd.Parameters.AddWithValue("@CB_G1MA20_49", SqlDbType.Int).Value = TextBox267.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG1FE", SqlDbType.Int).Value = TextBox268.Text;
                    cmd.Parameters.AddWithValue("@CB_G1FE10_14", SqlDbType.Int).Value = TextBox269.Text;
                    cmd.Parameters.AddWithValue("@CB_G1FE15_19", SqlDbType.Int).Value = TextBox270.Text;
                    cmd.Parameters.AddWithValue("@CB_G1FE20_49", SqlDbType.Int).Value = TextBox271.Text;
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox272.Text;
                    cmd.Parameters.AddWithValue("@SCHL_BASEDG2", SqlDbType.Int).Value = TextBox273.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG2MA", SqlDbType.Int).Value = TextBox274.Text;
                    cmd.Parameters.AddWithValue("@SB_G2MA10_14", SqlDbType.Int).Value = TextBox275.Text;
                    cmd.Parameters.AddWithValue("@SB_G2MA15_19", SqlDbType.Int).Value = TextBox276.Text;
                    cmd.Parameters.AddWithValue("@SB_G2MA20_49", SqlDbType.Int).Value = TextBox277.Text;
                    cmd.Parameters.AddWithValue("@SB_SUBG2FE", SqlDbType.Int).Value = TextBox278.Text;
                    cmd.Parameters.AddWithValue("@SB_G2FE10_14", SqlDbType.Int).Value = TextBox279.Text;
                    cmd.Parameters.AddWithValue("@SB_G2FE15_19", SqlDbType.Int).Value = TextBox280.Text;
                    cmd.Parameters.AddWithValue("@SB_G2FE20_49", SqlDbType.Int).Value = TextBox281.Text;
                    cmd.Parameters.AddWithValue("@COMM_BASEDG2", SqlDbType.Int).Value = TextBox282.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG2MA", SqlDbType.Int).Value = TextBox283.Text;
                    cmd.Parameters.AddWithValue("@CB_G2MA10_14", SqlDbType.Int).Value = TextBox284.Text;
                    cmd.Parameters.AddWithValue("@CB_G2MA15_19", SqlDbType.Int).Value = TextBox285.Text;
                    cmd.Parameters.AddWithValue("@CB_G2MA20_49", SqlDbType.Int).Value = TextBox286.Text;
                    cmd.Parameters.AddWithValue("@CB_SUBG2FE", SqlDbType.Int).Value = TextBox287.Text;
                    cmd.Parameters.AddWithValue("@CB_G2FE10_14", SqlDbType.Int).Value = TextBox288.Text;
                    cmd.Parameters.AddWithValue("@CB_G2FE15_19", SqlDbType.Int).Value = TextBox289.Text;
                    cmd.Parameters.AddWithValue("@CB_G2FE20_49", SqlDbType.Int).Value = TextBox290.Text;
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox291.Text;
                    cmd.Parameters.AddWithValue("@G3MA", SqlDbType.Int).Value = TextBox292.Text;
                    cmd.Parameters.AddWithValue("@G3FE", SqlDbType.Int).Value = TextBox293.Text;
                    cmd.Parameters.AddWithValue("@KPG3", SqlDbType.Int).Value = TextBox294.Text;
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox295.Text;
                    cmd.Parameters.AddWithValue("@G4FSW", SqlDbType.Int).Value = TextBox296.Text;
                    cmd.Parameters.AddWithValue("@G4PWID", SqlDbType.Int).Value = TextBox297.Text;
                    cmd.Parameters.AddWithValue("@G4MA", SqlDbType.Int).Value = TextBox298.Text;
                    cmd.Parameters.AddWithValue("@G4FE", SqlDbType.Int).Value = TextBox299.Text;
                    cmd.Parameters.AddWithValue("@G4MSM_TG", SqlDbType.Int).Value = TextBox300.Text;
                    cmd.Parameters.AddWithValue("@G4MSM_TG_SEXW", SqlDbType.Int).Value = TextBox301.Text;
                    cmd.Parameters.AddWithValue("@G4OTHER", SqlDbType.Int).Value = TextBox302.Text;
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox303.Text;
                    cmd.Parameters.AddWithValue("@G5MA", SqlDbType.Int).Value = TextBox304.Text;
                    cmd.Parameters.AddWithValue("@G5FE", SqlDbType.Int).Value = TextBox796.Text;
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "' Successful");
                        return;
                    }
                    CLS_PP();
                    cn.Close();

                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR Saving PP " + ex.Message.ToString());
                    return;
                }

            }
        }
       
    }//=========== PP_Save end

    protected void CLS_PP()
    {
        TextBox253.Text = string.Empty;
        TextBox254.Text = string.Empty;
        TextBox255.Text = string.Empty;
        TextBox256.Text = string.Empty;
        TextBox257.Text = string.Empty;
        TextBox258.Text = string.Empty;
        TextBox259.Text = string.Empty;
        TextBox260.Text = string.Empty;
        TextBox261.Text = string.Empty;
        TextBox262.Text = string.Empty;
        TextBox263.Text = string.Empty;
        TextBox264.Text = string.Empty;
        TextBox265.Text = string.Empty;
        TextBox266.Text = string.Empty;
        TextBox267.Text = string.Empty;
        TextBox268.Text = string.Empty;
        TextBox269.Text = string.Empty;
        TextBox270.Text = string.Empty;
        TextBox271.Text = string.Empty;
        TextBox272.Text = string.Empty;
        TextBox273.Text = string.Empty;
        TextBox274.Text = string.Empty;
        TextBox275.Text = string.Empty;
        TextBox276.Text = string.Empty;
        TextBox277.Text = string.Empty;
        TextBox278.Text = string.Empty;
        TextBox279.Text = string.Empty;
        TextBox280.Text = string.Empty;
        TextBox281.Text = string.Empty;
        TextBox282.Text = string.Empty;
        TextBox283.Text = string.Empty;
        TextBox284.Text = string.Empty;
        TextBox285.Text = string.Empty;
        TextBox286.Text = string.Empty;
        TextBox287.Text = string.Empty;
        TextBox288.Text = string.Empty;
        TextBox289.Text = string.Empty;
        TextBox290.Text = string.Empty;
        TextBox291.Text = string.Empty;
        TextBox292.Text = string.Empty;
        TextBox293.Text = string.Empty;
        TextBox294.Text = string.Empty;
        TextBox295.Text = string.Empty;
        TextBox296.Text = string.Empty;
        TextBox297.Text = string.Empty;
        TextBox298.Text = string.Empty;
        TextBox299.Text = string.Empty;
        TextBox300.Text = string.Empty;
        TextBox301.Text = string.Empty;
        TextBox302.Text = string.Empty;
        TextBox303.Text = string.Empty;
        TextBox304.Text = string.Empty;
        TextBox796.Text = string.Empty;    
    }//=========== CLS PP
    protected  void CLS_PEP()
    {
        TextBox306.Text = string.Empty;
        TextBox316.Text = string.Empty;
        TextBox317.Text = string.Empty;
        TextBox318.Text = string.Empty;
        TextBox319.Text = string.Empty;
        TextBox320.Text = string.Empty;
        TextBox321.Text = string.Empty;
        TextBox322.Text = string.Empty;
        TextBox323.Text = string.Empty;
        TextBox324.Text = string.Empty;
        TextBox325.Text = string.Empty;
        TextBox326.Text = string.Empty;
        TextBox327.Text = string.Empty;
        TextBox328.Text = string.Empty;
        TextBox797.Text = string.Empty;
        TextBox319.Focus();

    }// ===========Clear PP

    protected void EDIT_PEP()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_PEP Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                TextBox306.Text = r["TOTALG1"].ToString();
                TextBox316.Text = r["G1MA"].ToString();
                TextBox317.Text = r["G1FE"].ToString();
                TextBox318.Text = r["TOTALG2"].ToString();
                TextBox319.Text = r["G2MA"].ToString();
                TextBox320.Text = r["G2FE"].ToString();
                TextBox321.Text = r["TOTALG3"].ToString();
                TextBox322.Text = r["G3MA"].ToString();
                TextBox323.Text = r["G3FE"].ToString();
                TextBox324.Text = r["TOTALG4"].ToString();
                TextBox325.Text = r["G4MA"].ToString();
                TextBox326.Text = r["G4FE"].ToString();
                TextBox327.Text = r["TOTALG5"].ToString();
                TextBox328.Text = r["G5MA"].ToString();
                TextBox797.Text = r["G5FE"].ToString();

                Session["Edit"] = "T";
            }

        }catch(Exception ex)
        {
            webMessage.Show("ERROR Displaying Record "+ex.Message.ToString());
            return;
        }
    }


    private void PEP_SAVE()
    {
        if(! string.IsNullOrEmpty(Session["Edit"].ToString()))
        {
            if(Session["Edit"] =="T")
            {
                //============= UPDATE RECORDS ==========
                string sql = "UPDATE tbl_PEP SET states=@states,lga=@lga,facname=@facname,months=@months,@years,grouptype=@grouptype,TOTALG1=@TOTALG1, G1MA=@G1MA, G1FE=@G1FE, TOTALG2=@TOTALG2, G2MA=@G2MA, G2FE=@G2FE,";
                sql += "TOTALG3=@TOTALG3, G3MA=@G3MA, G3FE=@G3FE, TOTALG4=@TOTALG4, G4MA=@G4MA, G4FE=@G4FE, TOTALG5=@TOTALG5, G5MA=@G5MA, G5FE=@G5FE";
                sql += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";
                
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox306.Text;
                    cmd.Parameters.AddWithValue("@G1MA", SqlDbType.Int).Value = TextBox316.Text;
                    cmd.Parameters.AddWithValue("@G1FE", SqlDbType.Int).Value = TextBox317.Text;
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox318.Text;
                    cmd.Parameters.AddWithValue("@G2MA", SqlDbType.Int).Value = TextBox319.Text;
                    cmd.Parameters.AddWithValue("@G2FE", SqlDbType.Int).Value = TextBox320.Text;
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox321.Text;
                    cmd.Parameters.AddWithValue("@G3MA", SqlDbType.Int).Value = TextBox322.Text;
                    cmd.Parameters.AddWithValue("@G3FE", SqlDbType.Int).Value = TextBox323.Text;
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox324.Text;
                    cmd.Parameters.AddWithValue("@G4MA", SqlDbType.Int).Value = TextBox325.Text;
                    cmd.Parameters.AddWithValue("@G4FE", SqlDbType.Int).Value = TextBox326.Text;
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox327.Text;
                    cmd.Parameters.AddWithValue("@G5MA", SqlDbType.Int).Value = TextBox328.Text;
                    cmd.Parameters.AddWithValue("@G5FE", SqlDbType.Int).Value = TextBox797.Text;
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "' Successful");
                        return;
                    }
                    CLS_PEP();
                }
                catch (Exception ex)
                {
                    webMessage.Show(ex.Message.ToString());
                    return;

                }

            }
            else
            {
                //========== INSERT NEW RECORDS ==========
                string sql = "INSERT INTO tbl_PEP VALUES (@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1, @G1MA, @G1FE, @TOTALG2, @G2MA, @G2FE,";
                sql += "@TOTALG3, @G3MA, @G3FE, @TOTALG4, @G4MA, @G4FE, @TOTALG5, @G5MA, @G5FE)";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox306.Text;
                    cmd.Parameters.AddWithValue("@G1MA", SqlDbType.Int).Value = TextBox316.Text;
                    cmd.Parameters.AddWithValue("@G1FE", SqlDbType.Int).Value = TextBox317.Text;
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox318.Text;
                    cmd.Parameters.AddWithValue("@G2MA", SqlDbType.Int).Value = TextBox319.Text;
                    cmd.Parameters.AddWithValue("@G2FE", SqlDbType.Int).Value = TextBox320.Text;
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox321.Text;
                    cmd.Parameters.AddWithValue("@G3MA", SqlDbType.Int).Value = TextBox322.Text;
                    cmd.Parameters.AddWithValue("@G3FE", SqlDbType.Int).Value = TextBox323.Text;
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox324.Text;
                    cmd.Parameters.AddWithValue("@G4MA", SqlDbType.Int).Value = TextBox325.Text;
                    cmd.Parameters.AddWithValue("@G4FE", SqlDbType.Int).Value = TextBox326.Text;
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox327.Text;
                    cmd.Parameters.AddWithValue("@G5MA", SqlDbType.Int).Value = TextBox328.Text;
                    cmd.Parameters.AddWithValue("@G5FE", SqlDbType.Int).Value = TextBox797.Text;
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "' Successful");
                        return;
                    }
                    CLS_PEP();
                }
                catch (Exception ex)
                {
                    webMessage.Show(ex.Message.ToString());
                    return;

                }

            }
        }
        
    }//===== End of SAVING PEP




    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
        mState = (string)Session["mstate"];
        mLGA = (string)Session["mLga"];
        mFacility = (string)Session["mFacility"];
        mMnth = (string)Session["mMnth"];
        mYr = (string)Session["mYr"];
        mFile = (string)Session["mFile"];
        mChoose = (string)Session["mChoose"];

        switch (mChoose)
        {
            case "OVC":
                OVC_SAVE();
                break;
            case "FN":
                FN_SAVE();
                break;
            case "PEP":
                PEP_SAVE();
                break;
            case "PP":
                PP_SAVE();
                break;
           
        }
        //Response.Redirect("DataEntries.aspx");
        Console.WriteLine("Thank World......");
    }



    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        switch (mChoose)
        {
            case "OVC":
                CLS_OVC();
                break;
            case "FN":
                CLS_FN();
                break;
            case "PP":
                CLS_PP();
                break;
            case "PEP":
                CLS_PEP();
                break;
            //case "TB":
            //    CLS_TB();
            //    break;
        }
        Response.Redirect("DataEntries.aspx");
    }//=====Clear



    protected void TextBox320_TextChanged(object sender, EventArgs e)
    {
        TextBox318.Text = Convert.ToString(Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox320.Text));
        TextBox322.Focus();
    }
    protected void TextBox323_TextChanged(object sender, EventArgs e)
    {
        TextBox321.Text = Convert.ToString(Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text));
        TextBox316.Text = Convert.ToString(Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox322.Text) );  //+ Convert.ToInt32(TextBox325.Text));
        TextBox317.Text = Convert.ToString(Convert.ToInt32(TextBox320.Text) + Convert.ToInt32(TextBox323.Text)); // + Convert.ToInt32(TextBox326.Text));
        TextBox306.Text = Convert.ToString(Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox321.Text));
        TextBox325.Focus();
    }
    protected void TextBox326_TextChanged(object sender, EventArgs e)
    {
        TextBox324.Text = Convert.ToString(Convert.ToInt32(TextBox325.Text) + Convert.ToInt32(TextBox326.Text));

        TextBox328.Focus();
    }

   
    protected void TextBox194_TextChanged(object sender, EventArgs e)
    {
        TextBox188.Text = Convert.ToString(Convert.ToInt32(TextBox189.Text) + Convert.ToInt32(TextBox190.Text) + Convert.ToInt32(TextBox191.Text) + Convert.ToInt32(TextBox192.Text)
                          + Convert.ToInt32(TextBox193.Text) + Convert.ToInt32(TextBox194.Text));
        TextBox196.Focus();
    }
    protected void TextBox201_TextChanged(object sender, EventArgs e)
    {
        TextBox195.Text = Convert.ToString(Convert.ToInt32(TextBox196.Text) + Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox198.Text) + Convert.ToInt32(TextBox199.Text)
                          + Convert.ToInt32(TextBox200.Text) + Convert.ToInt32(TextBox201.Text));
        TextBox187.Text = Convert.ToString(Convert.ToInt32(TextBox188.Text) + Convert.ToInt32(TextBox195.Text));
        TextBox204.Focus();
    }
    protected void TextBox209_TextChanged(object sender, EventArgs e)
    {
        TextBox203.Text = Convert.ToString(Convert.ToInt32(TextBox204.Text) + Convert.ToInt32(TextBox205.Text)  + Convert.ToInt32(TextBox206.Text)
                          + Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text));
        TextBox211.Focus();
    }
    protected void TextBox216_TextChanged(object sender, EventArgs e)
    {
        TextBox210.Text = Convert.ToString(Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text)
                        + Convert.ToInt32(TextBox215.Text) + Convert.ToInt32(TextBox216.Text));
        TextBox202.Text = Convert.ToString(Convert.ToInt32(TextBox203.Text) + Convert.ToInt32(TextBox210.Text));
        TextBox217.Focus();
    }
    protected void TextBox226_TextChanged(object sender, EventArgs e)
    {
        TextBox220.Text = Convert.ToString(Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text)
                        + Convert.ToInt32(TextBox225.Text) + Convert.ToInt32(TextBox226.Text));
        TextBox228.Focus();
    }
    protected void TextBox233_TextChanged(object sender, EventArgs e)
    {
        TextBox227.Text = Convert.ToString(Convert.ToInt32(TextBox228.Text) + Convert.ToInt32(TextBox229.Text) + Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox231.Text)
                        + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text));
        TextBox219.Text = Convert.ToString(Convert.ToInt32(TextBox220.Text) + Convert.ToInt32(TextBox227.Text));
        TextBox234.Focus();
    }
    protected void TextBox243_TextChanged(object sender, EventArgs e)
    {
        TextBox237.Text = Convert.ToString(Convert.ToInt32(TextBox238.Text) + Convert.ToInt32(TextBox239.Text) + Convert.ToInt32(TextBox240.Text) + Convert.ToInt32(TextBox241.Text)
                       + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text));
        TextBox245.Focus();
    }
    protected void TextBox250_TextChanged(object sender, EventArgs e)
    {
        TextBox244.Text = Convert.ToString(Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox247.Text) + Convert.ToInt32(TextBox248.Text)
                       + Convert.ToInt32(TextBox249.Text) + Convert.ToInt32(TextBox250.Text));
        TextBox236.Text = Convert.ToString(Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox244.Text));
        TextBox251.Focus();
    }
    protected void TextBox258_TextChanged(object sender, EventArgs e)
    {
        TextBox255.Text = Convert.ToString(Convert.ToInt32(TextBox256.Text) + Convert.ToInt32(TextBox257.Text) + Convert.ToInt32(TextBox258.Text));
        TextBox260.Focus();
    }
    protected void TextBox262_TextChanged(object sender, EventArgs e)
    {
        TextBox259.Text = Convert.ToString(Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text));
        TextBox254.Text = Convert.ToString(Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox259.Text));
        TextBox265.Focus();
    }
    protected void TextBox267_TextChanged(object sender, EventArgs e)
    {
        TextBox264.Text = Convert.ToString(Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text) + Convert.ToInt32(TextBox267.Text));
        TextBox269.Focus();
    }
    protected void TextBox271_TextChanged(object sender, EventArgs e)
    {
        TextBox268.Text = Convert.ToString(Convert.ToInt32(TextBox269.Text) + Convert.ToInt32(TextBox270.Text) + Convert.ToInt32(TextBox271.Text));
        TextBox263.Text = Convert.ToString(Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox268.Text));
        TextBox253.Text = Convert.ToString(Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox263.Text));
        TextBox275.Focus();
    }
    protected void TextBox277_TextChanged(object sender, EventArgs e)
    {
        TextBox274.Text = Convert.ToString(Convert.ToInt32(TextBox275.Text) + Convert.ToInt32(TextBox276.Text) + Convert.ToInt32(TextBox277.Text));
        TextBox279.Focus();
    }
    protected void TextBox281_TextChanged(object sender, EventArgs e)
    {
        TextBox278.Text = Convert.ToString(Convert.ToInt32(TextBox279.Text) + Convert.ToInt32(TextBox280.Text) + Convert.ToInt32(TextBox281.Text));
        TextBox273.Text = Convert.ToString(Convert.ToInt32(TextBox274.Text) + Convert.ToInt32(TextBox278.Text));
        TextBox284.Focus();
    }
    protected void TextBox286_TextChanged(object sender, EventArgs e)
    {
        TextBox283.Text = Convert.ToString(Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text) + Convert.ToInt32(TextBox286.Text));
        TextBox288.Focus();
    }
    protected void TextBox290_TextChanged(object sender, EventArgs e)
    {
        TextBox287.Text = Convert.ToString(Convert.ToInt32(TextBox288.Text) + Convert.ToInt32(TextBox289.Text) + Convert.ToInt32(TextBox290.Text));
        TextBox282.Text = Convert.ToString(Convert.ToInt32(TextBox283.Text) + Convert.ToInt32(TextBox287.Text));
        TextBox272.Text = Convert.ToString(Convert.ToInt32(TextBox273.Text) + Convert.ToInt32(TextBox282.Text));
        TextBox292.Focus();
    }
    protected void TextBox294_TextChanged(object sender, EventArgs e)
    {
        TextBox291.Text = Convert.ToString(Convert.ToInt32(TextBox292.Text) + Convert.ToInt32(TextBox293.Text) + Convert.ToInt32(TextBox294.Text));
        TextBox296.Focus();
    }
    protected void TextBox301_TextChanged(object sender, EventArgs e)
    {
        TextBox295.Text = Convert.ToString(Convert.ToInt32(TextBox296.Text) + Convert.ToInt32(TextBox297.Text) + Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text)
                        + Convert.ToInt32(TextBox300.Text) +  Convert.ToInt32(TextBox301.Text));
        TextBox302.Focus();
    }

    protected void TextBox304_TextChanged(object sender, EventArgs e)
    {
        TextBox303.Text = Convert.ToString(Convert.ToInt32(TextBox304.Text) + Convert.ToInt32(TextBox796.Text));
        btnSave.Focus();
    }

    protected void TextBox797_TextChanged(object sender, EventArgs e)
    {
        TextBox327.Text = Convert.ToString(Convert.ToInt32(TextBox328.Text) + Convert.ToInt32(TextBox797.Text));
        btnSave.Focus();
    }
    protected void TextBox339_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox347_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox358_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox367_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox377_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox386_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox397_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox405_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox415_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox423_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox434_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox442_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox453_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox462_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox472_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox480_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox492_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox500_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox511_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox519_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox530_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox538_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox549_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox557_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox786_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox795_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox567_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox575_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox586_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox594_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox605_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox614_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox624_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox632_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox643_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox652_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox662_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox670_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox682_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox690_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox701_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox709_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox720_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox728_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox314_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox738_TextChanged(object sender, EventArgs e)
    {
      
    }
    protected void TextBox748_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox757_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void TextBox768_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void TextBox776_TextChanged(object sender, EventArgs e)
    {
       
    }


    protected void bntComplete_Click(object sender, ImageClickEventArgs e)
    {
        mState = (string)Session["mstate"];
        mLGA = (string)Session["mLga"];
        mFacility = (string)Session["mFacility"];
        mMnth = (string)Session["mMnth"];
        mYr = (string)Session["mYr"];
        mFile = (string)Session["mFile"];
        mChoose = (string)Session["mChoose"];
        //============= Reverse back ============
        Session["mstates"] = mState.Trim();
        Session["mlga"] = mLGA.Trim();
        Session["mFacility"] = mFacility.Trim();
        Session["mMnth"] = mMnth.Trim();
        Session["mYr"] = mYr.Trim();
        Session["mFile"] = mFile.Trim();
        Session["mChoose"] = mChoose.Trim();

        //=========== Call Main Form ===========
        Response.Redirect("DataEntries.aspx");

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim())
                      + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox4.Focus();
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim())
                      + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox5.Focus();
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim())
                      + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox6.Focus();
    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim())
                      + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox7.Focus();
    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim())
                      + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox8.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text.Trim()) + Convert.ToInt32(TextBox4.Text.Trim()) + Convert.ToInt32(TextBox5.Text.Trim())
                          + Convert.ToInt32(TextBox6.Text.Trim()) + Convert.ToInt32(TextBox7.Text.Trim()) + Convert.ToInt32(TextBox8.Text.Trim()));
        TextBox10.Focus();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox9.Text = Convert.ToString(Convert.ToInt32(TextBox10.Text) + Convert.ToInt32(TextBox11.Text) + Convert.ToInt32(TextBox12.Text)
                      + Convert.ToInt32(TextBox13.Text) + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text));
        TextBox1.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox9.Text));
        TextBox18.Focus();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox17.Text = Convert.ToString(Convert.ToInt32(TextBox18.Text.Trim()) + Convert.ToInt32(TextBox19.Text.Trim()) + Convert.ToInt32(TextBox20.Text.Trim())
                   + Convert.ToInt32(TextBox21.Text.Trim()) + Convert.ToInt32(TextBox22.Text.Trim()) + Convert.ToInt32(TextBox23.Text.Trim()) + Convert.ToInt32(TextBox24.Text.Trim()));
        TextBox26.Focus();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox25.Text = Convert.ToString(Convert.ToInt32(TextBox26.Text) + Convert.ToInt32(TextBox27.Text) + Convert.ToInt32(TextBox28.Text)
                     + Convert.ToInt32(TextBox29.Text) + Convert.ToInt32(TextBox30.Text) + Convert.ToInt32(TextBox31.Text) + Convert.ToInt32(TextBox32.Text));
        TextBox16.Text = Convert.ToString(Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox17.Text));
        TextBox34.Focus();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox33.Text = Convert.ToString(Convert.ToInt32(TextBox34.Text) + Convert.ToInt32(TextBox35.Text) + Convert.ToInt32(TextBox36.Text) + Convert.ToInt32(TextBox37.Text)
                        + Convert.ToInt32(TextBox38.Text) + Convert.ToInt32(TextBox39.Text) + Convert.ToInt32(TextBox40.Text));
        TextBox42.Focus();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBox41.Text = Convert.ToString(Convert.ToInt32(TextBox42.Text) + Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox44.Text)
                    + Convert.ToInt32(TextBox45.Text) + Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox47.Text) + Convert.ToInt32(TextBox48.Text));
        TextBox49.Text = Convert.ToString(Convert.ToInt32(TextBox33.Text) + Convert.ToInt32(TextBox41.Text));
        TextBox52.Focus();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        TextBox51.Text = Convert.ToString(Convert.ToInt32(TextBox52.Text) + Convert.ToInt32(TextBox53.Text) + Convert.ToInt32(TextBox54.Text) + Convert.ToInt32(TextBox55.Text)
                        + Convert.ToInt32(TextBox56.Text) + Convert.ToInt32(TextBox57.Text) + Convert.ToInt32(TextBox58.Text));
        TextBox60.Focus();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        TextBox59.Text = Convert.ToString(Convert.ToInt32(TextBox60.Text) + Convert.ToInt32(TextBox61.Text) + Convert.ToInt32(TextBox62.Text)
                    + Convert.ToInt32(TextBox63.Text) + Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox65.Text) + Convert.ToInt32(TextBox66.Text));
        TextBox50.Text = Convert.ToString(Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox59.Text));
        TextBox69.Focus();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        TextBox68.Text = Convert.ToString(Convert.ToInt32(TextBox69.Text) + Convert.ToInt32(TextBox70.Text) + Convert.ToInt32(TextBox71.Text) + Convert.ToInt32(TextBox72.Text)
                                + Convert.ToInt32(TextBox73.Text) + Convert.ToInt32(TextBox74.Text) + Convert.ToInt32(TextBox75.Text));
        TextBox77.Focus();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        TextBox76.Text = Convert.ToString(Convert.ToInt32(TextBox77.Text) + Convert.ToInt32(TextBox78.Text) + Convert.ToInt32(TextBox79.Text)
                  + Convert.ToInt32(TextBox80.Text) + Convert.ToInt32(TextBox81.Text) + Convert.ToInt32(TextBox82.Text) + Convert.ToInt32(TextBox83.Text));
        TextBox67.Text = Convert.ToString(Convert.ToInt32(TextBox68.Text) + Convert.ToInt32(TextBox76.Text));
        TextBox86.Focus();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        TextBox85.Text = Convert.ToString(Convert.ToInt32(TextBox86.Text) + Convert.ToInt32(TextBox87.Text) + Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text)
                                + Convert.ToInt32(TextBox90.Text) + Convert.ToInt32(TextBox91.Text) + Convert.ToInt32(TextBox92.Text));
        TextBox94.Focus();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox93.Text = Convert.ToString(Convert.ToInt32(TextBox94.Text) + Convert.ToInt32(TextBox95.Text) + Convert.ToInt32(TextBox96.Text)
                  + Convert.ToInt32(TextBox97.Text) + Convert.ToInt32(TextBox98.Text) + Convert.ToInt32(TextBox99.Text) + Convert.ToInt32(TextBox100.Text));
        TextBox84.Text = Convert.ToString(Convert.ToInt32(TextBox85.Text) + Convert.ToInt32(TextBox93.Text));
        TextBox103.Focus();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        TextBox102.Text = Convert.ToString(Convert.ToInt32(TextBox103.Text) + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox105.Text) + Convert.ToInt32(TextBox106.Text)
                                + Convert.ToInt32(TextBox107.Text) + Convert.ToInt32(TextBox108.Text) + Convert.ToInt32(TextBox109.Text));
        TextBox111.Focus();
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        TextBox110.Text = Convert.ToString(Convert.ToInt32(TextBox111.Text) + Convert.ToInt32(TextBox112.Text) + Convert.ToInt32(TextBox113.Text)
                  + Convert.ToInt32(TextBox114.Text) + Convert.ToInt32(TextBox115.Text) + Convert.ToInt32(TextBox116.Text) + Convert.ToInt32(TextBox117.Text));
        TextBox101.Text = Convert.ToString(Convert.ToInt32(TextBox102.Text) + Convert.ToInt32(TextBox110.Text));
        TextBox120.Focus();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        TextBox119.Text = Convert.ToString(Convert.ToInt32(TextBox120.Text) + Convert.ToInt32(TextBox121.Text) + Convert.ToInt32(TextBox122.Text)
                         + Convert.ToInt32(TextBox123.Text) + Convert.ToInt32(TextBox124.Text) + Convert.ToInt32(TextBox125.Text) + Convert.ToInt32(TextBox126.Text));
        TextBox128.Focus();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        TextBox127.Text = Convert.ToString(Convert.ToInt32(TextBox128.Text) + Convert.ToInt32(TextBox129.Text) + Convert.ToInt32(TextBox130.Text)
              + Convert.ToInt32(TextBox131.Text) + Convert.ToInt32(TextBox132.Text) + Convert.ToInt32(TextBox133.Text) + Convert.ToInt32(TextBox134.Text));
        TextBox118.Text = Convert.ToString(Convert.ToInt32(TextBox119.Text) + Convert.ToInt32(TextBox127.Text));
        TextBox137.Focus();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        TextBox136.Text = Convert.ToString(Convert.ToInt32(TextBox137.Text) + Convert.ToInt32(TextBox138.Text) + Convert.ToInt32(TextBox139.Text)
                        + Convert.ToInt32(TextBox140.Text) + Convert.ToInt32(TextBox141.Text) + Convert.ToInt32(TextBox142.Text) + Convert.ToInt32(TextBox143.Text));
        TextBox145.Focus();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        TextBox144.Text = Convert.ToString(Convert.ToInt32(TextBox145.Text) + Convert.ToInt32(TextBox146.Text) + Convert.ToInt32(TextBox147.Text)
             + Convert.ToInt32(TextBox148.Text) + Convert.ToInt32(TextBox149.Text) + Convert.ToInt32(TextBox150.Text) + Convert.ToInt32(TextBox151.Text));
        TextBox135.Text = Convert.ToString(Convert.ToInt32(TextBox136.Text) + Convert.ToInt32(TextBox144.Text));
        TextBox154.Focus();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        TextBox153.Text = Convert.ToString(Convert.ToInt32(TextBox154.Text) + Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox156.Text)
                               + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox158.Text) + Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox160.Text));
        TextBox162.Focus();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        TextBox161.Text = Convert.ToString(Convert.ToInt32(TextBox162.Text) + Convert.ToInt32(TextBox163.Text) + Convert.ToInt32(TextBox164.Text)
                         + Convert.ToInt32(TextBox165.Text) + Convert.ToInt32(TextBox166.Text) + Convert.ToInt32(TextBox167.Text) + Convert.ToInt32(TextBox168.Text));
        TextBox152.Text = Convert.ToString(Convert.ToInt32(TextBox153.Text) + Convert.ToInt32(TextBox161.Text));
        TextBox170.Focus();
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        TextBox176.Text = Convert.ToString(Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text) + Convert.ToInt32(TextBox172.Text)
                               + Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text));
        TextBox178.Focus();
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        TextBox177.Text = Convert.ToString(Convert.ToInt32(TextBox178.Text) + Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text)
                         + Convert.ToInt32(TextBox181.Text) + Convert.ToInt32(TextBox182.Text) + Convert.ToInt32(TextBox183.Text));
        TextBox169.Text = Convert.ToString(Convert.ToInt32(TextBox176.Text) + Convert.ToInt32(TextBox177.Text));
        TextBox185.Focus();
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        TextBox184.Text = Convert.ToString(Convert.ToInt32(TextBox185.Text) + Convert.ToInt32(TextBox186.Text));
        btnSave.Focus();
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        TextBox188.Text = Convert.ToString(Convert.ToInt32(TextBox189.Text) + Convert.ToInt32(TextBox190.Text) + Convert.ToInt32(TextBox191.Text) + Convert.ToInt32(TextBox192.Text)
                          + Convert.ToInt32(TextBox193.Text) + Convert.ToInt32(TextBox194.Text));
        TextBox196.Focus();
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        TextBox195.Text = Convert.ToString(Convert.ToInt32(TextBox196.Text) + Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox198.Text) + Convert.ToInt32(TextBox199.Text)
                          + Convert.ToInt32(TextBox200.Text) + Convert.ToInt32(TextBox201.Text));
        TextBox187.Text = Convert.ToString(Convert.ToInt32(TextBox188.Text) + Convert.ToInt32(TextBox195.Text));
        TextBox204.Focus();
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        TextBox203.Text = Convert.ToString(Convert.ToInt32(TextBox204.Text) + Convert.ToInt32(TextBox205.Text) + Convert.ToInt32(TextBox205.Text) + Convert.ToInt32(TextBox206.Text)
                          + Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text));
        TextBox211.Focus();
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        TextBox210.Text = Convert.ToString(Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text)
                        + Convert.ToInt32(TextBox215.Text) + Convert.ToInt32(TextBox216.Text));
        TextBox202.Text = Convert.ToString(Convert.ToInt32(TextBox203.Text) + Convert.ToInt32(TextBox210.Text));
        TextBox217.Focus();
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        TextBox220.Text = Convert.ToString(Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text)
                        + Convert.ToInt32(TextBox225.Text) + Convert.ToInt32(TextBox226.Text));
        TextBox228.Focus();
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        TextBox227.Text = Convert.ToString(Convert.ToInt32(TextBox228.Text) + Convert.ToInt32(TextBox229.Text) + Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox231.Text)
                        + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text));
        TextBox219.Text = Convert.ToString(Convert.ToInt32(TextBox220.Text) + Convert.ToInt32(TextBox227.Text));
        TextBox234.Focus();
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        TextBox237.Text = Convert.ToString(Convert.ToInt32(TextBox238.Text) + Convert.ToInt32(TextBox239.Text) + Convert.ToInt32(TextBox240.Text) + Convert.ToInt32(TextBox241.Text)
                       + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text));
        TextBox245.Focus();
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        TextBox244.Text = Convert.ToString(Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox247.Text) + Convert.ToInt32(TextBox248.Text)
                       + Convert.ToInt32(TextBox249.Text) + Convert.ToInt32(TextBox250.Text));
        TextBox236.Text = Convert.ToString(Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox244.Text));
        TextBox251.Focus();
    }
    
    protected void Button34_Click(object sender, EventArgs e)
    {
        TextBox259.Text = Convert.ToString(Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text));
        TextBox254.Text = Convert.ToString(Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox259.Text));
        TextBox265.Focus();
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        TextBox264.Text = Convert.ToString(Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text) + Convert.ToInt32(TextBox267.Text));
        TextBox269.Focus();
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        TextBox268.Text = Convert.ToString(Convert.ToInt32(TextBox269.Text) + Convert.ToInt32(TextBox270.Text) + Convert.ToInt32(TextBox271.Text));
        TextBox263.Text = Convert.ToString(Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox268.Text));
        TextBox253.Text = Convert.ToString(Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox263.Text));
        TextBox275.Focus();
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        TextBox274.Text = Convert.ToString(Convert.ToInt32(TextBox275.Text) + Convert.ToInt32(TextBox276.Text) + Convert.ToInt32(TextBox277.Text));
        TextBox279.Focus();
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        TextBox278.Text = Convert.ToString(Convert.ToInt32(TextBox279.Text) + Convert.ToInt32(TextBox280.Text) + Convert.ToInt32(TextBox281.Text));
        TextBox273.Text = Convert.ToString(Convert.ToInt32(TextBox274.Text) + Convert.ToInt32(TextBox278.Text));
        TextBox284.Focus();
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        TextBox283.Text = Convert.ToString(Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text) + Convert.ToInt32(TextBox286.Text));
        TextBox288.Focus();
    }
    protected void Button41_Click(object sender, EventArgs e)
    {
        TextBox291.Text = Convert.ToString(Convert.ToInt32(TextBox292.Text) + Convert.ToInt32(TextBox293.Text) + Convert.ToInt32(TextBox294.Text));
        TextBox296.Focus();
    }
    protected void Button42_Click(object sender, EventArgs e)
    {
        TextBox295.Text = Convert.ToString(Convert.ToInt32(TextBox296.Text) + Convert.ToInt32(TextBox297.Text) + Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text)
                        + Convert.ToInt32(TextBox300.Text) + Convert.ToInt32(TextBox301.Text));
        TextBox302.Focus();
    }
    protected void Button43_Click(object sender, EventArgs e)
    {
        TextBox303.Text = Convert.ToString(Convert.ToInt32(TextBox304.Text) + Convert.ToInt32(TextBox796.Text));
        btnSave.Focus();
    }
    protected void Button44_Click(object sender, EventArgs e)
    {
        TextBox318.Text = Convert.ToString(Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox320.Text));
        TextBox322.Focus();
    }
    protected void Button45_Click(object sender, EventArgs e)
    {
        TextBox321.Text = Convert.ToString(Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text));
        TextBox316.Text = Convert.ToString(Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox322.Text));  //+ Convert.ToInt32(TextBox325.Text));
        TextBox317.Text = Convert.ToString(Convert.ToInt32(TextBox320.Text) + Convert.ToInt32(TextBox323.Text)); // + Convert.ToInt32(TextBox326.Text));
        TextBox306.Text = Convert.ToString(Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox321.Text));
        TextBox325.Focus();
    }
    protected void Button46_Click(object sender, EventArgs e)
    {
        TextBox324.Text = Convert.ToString(Convert.ToInt32(TextBox325.Text) + Convert.ToInt32(TextBox326.Text));

        TextBox328.Focus();
    }
    protected void Button47_Click(object sender, EventArgs e)
    {
        TextBox327.Text = Convert.ToString(Convert.ToInt32(TextBox328.Text) + Convert.ToInt32(TextBox797.Text));
        btnSave.Focus();
    }
  
    protected void drpStates_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string SQL, SQL1 = "";
        //if (drpStates.SelectedItem.Text.Trim() == "Ebonyi")
        //{
        //    SQL1 = "Abakaliki";
        //    SQL = "SELECT * from tbl_states where capitals ='" + SQL1 + "' order by lga asc";
        //}
        //else
        //{
        //    SQL = "SELECT * from tbl_states where statename ='" + drpStates.SelectedItem.Text.Trim() + "' order by lga asc";
        //}
        //SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        //cn.Open();
        //SqlCommand cmd = new SqlCommand(SQL, cn);
        //SqlDataReader r = cmd.ExecuteReader();
        //try
        //{
        //    drpLGA.ClearSelection();
        //    drpLGA.Items.Clear();
        //    drpLGA.Items.Add("");
        //    while (r.Read()) { drpLGA.Items.Add(r["lga"].ToString()); }

        //}
        //catch (Exception ex)
        //{
        //    Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
        //    return;
        //}
    }
    protected void drpLGA_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    drpFacility.Items.Clear();
        //    drpFacility.Items.Add("");
        //    string sql = "Select * from tbl_facility where statename ='" + drpStates.SelectedItem.Text.Trim() + "' and lga ='" + drpLGA.SelectedItem.Text.Trim() + "' order by facname asc";
        //    SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand(sql, cn);
        //    SqlDataReader r = cmd.ExecuteReader();
        //    while (r.Read())
        //    {
        //        drpFacility.Items.Add(r["facname"].ToString());
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
        //    return;
        //}
    }

    private void GetThematic(string thematicname, out string fname)
    {
        fname = string.Empty;

        string sql = "Select * from tbl_grpname where fname='" + thematicname + "'";
        try
        {
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                fname = rd["abrv"].ToString();

            }

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }

    }



    protected void drpThematic_SelectedIndexChanged(object sender, EventArgs e)
    {
        ////Thematic Area for selection
        //if (drpStates.SelectedItem.Text.Trim() != string.Empty && drpLGA.SelectedItem.Text.Trim() != string.Empty && drpFacility.SelectedItem.Text.Trim() != string.Empty
        //    && drpMnth.SelectedItem.Text.Trim() != string.Empty && drpYrs.SelectedItem.Text.Trim() != string.Empty && drpThematic.SelectedItem.Text.Trim() != string.Empty)
        //{
        //    string mFile1 = drpThematic.SelectedItem.Text.Trim();
        //    // Console.WriteLine("Hello \n");
        //    string mFile = string.Empty;
        //    MultiView1.Visible = true;

        //    GetThematic(mFile1, out mFile);

        //    if (mFile == "CARE")
        //    {
        //        TextBox608.Text = mFile;
        //        drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();

        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();
        //        Response.Redirect("dataentryform2.aspx");
        //        MultiView1.SetActiveView(View1);

        //        //SAVE_PMTCT();
        //    }
        //    if (mFile == "ART")
        //    {

        //        TextBox608.Text = mFile;
        //        //drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        //drpStates.Style.Clear();
        //        //drpLGA.Style.Clear();
        //        //drpFacility.Style.Clear();
        //        //drpMnth.Style.Clear();
        //        //drpYrs.Style.Clear();
        //        //drpThematic.Style.Clear();

        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();
        //        Response.Redirect("dataentryform2.aspx");
        //        MultiView1.SetActiveView(View2);

        //        // SAVE_HIVI();
        //    }
        //    if (mFile == "HTC")
        //    {

        //        TextBox608.Text = mFile;
        //        //drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        //drpStates.Style.Clear();
        //        //drpLGA.Style.Clear();
        //        //drpFacility.Style.Clear();
        //        //drpMnth.Style.Clear();
        //        //drpYrs.Style.Clear();
        //        //drpThematic.Style.Clear();

        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();
        //        Response.Redirect("dataentryform2.aspx");
        //        MultiView1.SetActiveView(View3);

        //        // SAVE_TRAINING();
        //    }
        //    if (mFile == "GEND NORM")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View4);

        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();
        //        Session["mChoose"] = mFile;

        //        Response.Redirect("dataentries.aspx");

        //    }
        //    if (mFile == "LAB")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        //MultiView1.SetActiveView(View5);
        //        TextBox670.Focus();

        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentries.aspx");
        //    }
        //    if (mFile == "OVC")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        //MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentryform.aspx");

        //    }
        //    if (mFile == "FN")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentryform.aspx");  //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //    if (mFile == "PP")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentryform.aspx");  //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //    if (mFile == "PEP")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentryform.aspx");  //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //    if (mFile == "TB")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentryform.aspx");  //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //    if (mFile == "PMTCT")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentries.aspx");  //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //    if (mFile == "HIVI")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentries.aspx");   //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //    if (mFile == "TRAINING")
        //    {

        //        TextBox608.Text = mFile;
        //        // drpThematic.ClearSelection();
        //        lblmsg.Visible = false;
        //        lblmsg.Text = string.Empty;
        //        drpStates.Style.Clear();
        //        drpLGA.Style.Clear();
        //        drpFacility.Style.Clear();
        //        drpMnth.Style.Clear();
        //        drpYrs.Style.Clear();
        //        drpThematic.Style.Clear();
        //        // MultiView1.SetActiveView(View5);
        //        Session["mChoose"] = mFile;
        //        Session["mState"] = drpStates.SelectedItem.Text.Trim();
        //        Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
        //        Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
        //        Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
        //        Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

        //        Response.Redirect("dataentries.aspx");  //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

        //    }
        //}
        //else
        //{
        //    drpStates.Style.Value = "background-color:red;";
        //    drpLGA.Style.Value = "background-color:red;";
        //    drpFacility.Style.Value = "background-color:red;";
        //    drpMnth.Style.Value = "background-color:red;";
        //    drpYrs.Style.Value = "background-color:red;";
        //    drpThematic.Style.Value = "background-color:red;";
        //    drpThematic.ClearSelection();
        //    lblmsg.Visible = true;
        //    string txt = "Value required in the red section ";
        //    ConnectAll.Show(txt);
        //}
    }
   
    protected void Button2_Click1(object sender, EventArgs e)
    {
        TextBox9.Text = Convert.ToString(Convert.ToInt32(TextBox10.Text) + Convert.ToInt32(TextBox11.Text) + Convert.ToInt32(TextBox12.Text)
                      + Convert.ToInt32(TextBox13.Text) + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text));
        TextBox1.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox9.Text));
        TextBox18.Focus();

    }

    protected void TextBox15_TextChanged1(object sender, EventArgs e)
    {
        TextBox9.Text = Convert.ToString(Convert.ToInt32(TextBox10.Text) + Convert.ToInt32(TextBox11.Text) + Convert.ToInt32(TextBox12.Text)
                      + Convert.ToInt32(TextBox13.Text) + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text));
        TextBox1.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox9.Text));
        TextBox18.Focus();
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        //TextBox184.Text = Convert.ToString(Convert.ToInt32(TextBox185.Text) + Convert.ToInt32(TextBox186.Text));
        btnSave.Focus();
    }
}