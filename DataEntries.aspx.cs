using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DataEntries : System.Web.UI.Page
{
    string mTest = string.Empty;

    string mChoose = string.Empty;  // Thematic Area
    string mState = string.Empty;  //State
    string mLGA = string.Empty;  //LGA
    string mFacility = string.Empty;  //Facility
    string mMnth = string.Empty;  //Month
    string mYr = string.Empty; //Year


    //public void ShowMe(string msg)
    //{
    //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('"+ msg +"');", true);
    //}
    #region ================== Some Definations=============
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
    //        while (r.Read()) { drpStates.Items.Add(r["statename"].ToString());}
            
    //    }catch(Exception e)
    //    {
    //        Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
    //        return;
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
    //        Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
       if (!IsPostBack)
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
            //drpThematic.Text = mChoose;

            //ch = (string)Session["choose"];

            lblThematic.Text = " " + mState + "/" + mLGA + "/" + mFacility + "/" + mMnth + "-" + mYr;
           
           Session["Edit"] = "F";

            switch (mChoose)
            {
                case "PMTCT":
                    EDIT_PMTCT();
                    MultiView1.SetActiveView(View1);
                    break;
                case "HIVI":
                    EDIT_HIVI();
                    MultiView1.SetActiveView(View2);
                    break;
                case "TRAINING":
                    EDIT_TRAINING();
                    MultiView1.SetActiveView(View3);
                    break;
                case "GN":
                    EDIT_GN();
                    MultiView1.SetActiveView(View4);
                    break;
               
                default:
                    break;
            }
        }
    }
    #region "=============== PopUp Buttons Not Used ============================"
    protected void Button1_Click(object sender, EventArgs e)
    {
      //  if (drpStates.Text != string.Empty && drpLGA.Text != string.Empty && drpFacility.Text != string.Empty && drpMnth.Text != string.Empty && drpYrs.Text != string.Empty)
        //{
        if(mTest != string.Empty )
        {
            mTest = string.Empty;
            mTest = "PMTCT";
        }
        else
        {
            mTest = "PMTCT";
        }
            MultiView1.SetActiveView(View1);

     //   }
     //   else
      //  {
           // ClientScriptManager CSM = Page.ClientScript;
            //string strconfirm = "<script>if(!window.confirm('Are you sure?')){window.location.href='~/DataEnteries.aspx'}</script>";
            //CSM.RegisterClientScriptBlock(this.GetType(), "Confirm", strconfirm, false);

            string display = "hhhhhhhhhhhhhhhhhhhhh";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scriptkey", "<script>alart('"+display+"')</script>");

            //Response.Write("<script type=\"text/javascript\">alert('"+display +"');</script>");
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            //return;
       // }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (mTest != string.Empty)
        {
            mTest = string.Empty;
            mTest = "HCT";
        }
        else
        {
            mTest = "HCT";
        }
        MultiView1.SetActiveView(View2);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        if (mTest != string.Empty)
        {
            mTest = string.Empty;
            mTest = "TREATMENT";
        }
        else
        {
            mTest = "TREATMENT";
        }
        MultiView1.SetActiveView(View3);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        if (mTest != string.Empty)
        {
            mTest = string.Empty;
            mTest = "HCT";
        }
        else
        {
            mTest = "HCT";
        }
        MultiView1.SetActiveView(View4);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        if (mTest != string.Empty)
        {
            mTest = string.Empty;
            mTest = "HCT";
        }
        else
        {
            mTest = "HCT";
        }
        //MultiView1.SetActiveView(View5);
    }
#endregion

    protected void EDIT_TRAINING()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_CARE Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                mState = Session["mState"].ToString();
                mLGA = Session["mLGA"].ToString();
                mFacility = Session["mFacility"].ToString();
                mMnth = Session[" mMnth"].ToString();
                mYr = Session["mYr"].ToString();
                mChoose = Session[" mChoose"].ToString();
                TextBox606.Text = r["totalg1"].ToString();
                TextBox138.Text = r["g1ma"].ToString();
                TextBox139.Text = r["g1fe"].ToString();
                TextBox140.Text = r["totalg2"].ToString();
                TextBox141.Text = r["g2ma"].ToString();
                TextBox142.Text = r["g2fe"].ToString();
                TextBox143.Text = r["totalg3"].ToString();
                TextBox144.Text = r["g3ma"].ToString();
                TextBox145.Text = r["g3fe"].ToString();
                TextBox607.Text = r["totalg4"].ToString();
                TextBox146.Text = r["g4ma"].ToString();
                TextBox147.Text = r["g4fe"].ToString();
                TextBox148.Text = r["totalg5"].ToString();
                TextBox149.Text = r["g5ma"].ToString();
                TextBox150.Text = r["g5fe"].ToString();
                TextBox151.Text = r["totalg6"].ToString();
                TextBox152.Text = r["g6ma"].ToString();
                TextBox153.Text = r["g6fe"].ToString();

                Session["Edit"] = "T";
            }

           
        }
        catch (Exception ex)
        {
            webMessage.Show(" PMTCT Search error: " + ex.Message.ToString());
            return;
        }
    }

    protected void EDIT_GN()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_GENDNORM Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                mState = Session["mState"].ToString();
                mLGA = Session["mLGA"].ToString();
                mFacility = Session["mFacility"].ToString();
                mMnth = Session[" mMnth"].ToString();
                mYr = Session["mYr"].ToString();
                mChoose = Session[" mChoose"].ToString();

                TextBox609.Text = r["totalg1"].ToString();
                TextBox610.Text = r["subg1ma"].ToString();
                TextBox611.Text = r["g1ma0_9"].ToString();
                TextBox612.Text = r["g1ma10_14"].ToString();
                TextBox613.Text = r["g1ma15_19"].ToString();
                TextBox614.Text = r["g1ma20_24"].ToString();
                TextBox615.Text = r["g1ma25"].ToString();
                TextBox616.Text = r["subg1fe"].ToString();
                TextBox617.Text = r["g1fe0_9"].ToString();
                TextBox618.Text = r["g1fe10_14"].ToString();
                TextBox619.Text = r["g1fe15_19"].ToString();
                TextBox620.Text = r["g1fe20_24"].ToString();
                TextBox621.Text = r["g1fe25"].ToString();
                TextBox622.Text = r["g1_1"].ToString();
                TextBox623.Text = r["g1_2"].ToString();
                TextBox624.Text = r["g1_3"].ToString();
                TextBox625.Text = r["totalg2"].ToString();
                TextBox626.Text = r["subg2ma"].ToString();
                TextBox627.Text = r["g2ma0_9"].ToString();
                TextBox628.Text = r["g2ma10_14"].ToString();
                TextBox629.Text = r["g2ma15_19"].ToString();
                TextBox630.Text = r["g2ma20_24"].ToString();
                TextBox631.Text = r["g2ma25"].ToString();
                TextBox632.Text = r["subg2fe"].ToString();
                TextBox633.Text = r["g2fe0_9"].ToString();
                TextBox634.Text = r["g2fe10_14"].ToString();
                TextBox635.Text = r["g2fe15_19"].ToString();
                TextBox666.Text = r["g2fe20_24"].ToString();
                TextBox636.Text = r["g2fe25"].ToString();
                TextBox637.Text = r["totalg3"].ToString();
                TextBox638.Text = r["subg3ma"].ToString();
                TextBox639.Text = r["g3ma0_9"].ToString();
                TextBox640.Text = r["g3ma10_14"].ToString();
                TextBox641.Text = r["g3ma15_19"].ToString();
                TextBox642.Text = r["g3ma20_24"].ToString();
                TextBox643.Text = r["g3ma25"].ToString();
                TextBox644.Text = r["subg3fe"].ToString();
                TextBox645.Text = r["g3fe0_9"].ToString();
                TextBox646.Text = r["g3fe10_14"].ToString();
                TextBox647.Text = r["g3fe15_19"].ToString();
                TextBox648.Text = r["g3fe20_24"].ToString();
                TextBox649.Text = r["g3fe25"].ToString();
                TextBox650.Text = r["totalg4"].ToString();
                TextBox651.Text = r[" subg4ma"].ToString();
                TextBox652.Text = r["g4ma0_9"].ToString();
                TextBox653.Text = r["g4ma10_14"].ToString();
                TextBox654.Text = r["g4ma15_19"].ToString();
                TextBox655.Text = r["g4ma20_24"].ToString();
                TextBox656.Text = r["g4ma25"].ToString();
                TextBox657.Text = r["subg4fe"].ToString();
                TextBox658.Text = r["g4fe0_9"].ToString();
                TextBox659.Text = r["g4fe10_14"].ToString();
                TextBox660.Text = r["g4fe15_19"].ToString();
                TextBox661.Text = r["g4fe20_24"].ToString();
                TextBox662.Text = r["g4fe25"].ToString();
                TextBox663.Text = r["totalg5"].ToString();
                TextBox664.Text = r["g5ma"].ToString();
                TextBox665.Text = r["g5fe"].ToString();

                Session["Edit"] = "T";
            }
         
        }
        catch (Exception ex)
        {
            webMessage.Show(" GEND NORM Search error: " + ex.Message.ToString());
            return;
        }
    }

    protected void EDIT_PMTCT()
    {
        try
        {
             string SQL1 = "SELECT * FROM tbl_PMTCT Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

             SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()); 
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
               TextBox579.Text=r["SUBTOTALG1"].ToString() ; 
       TextBox1.Text=r["G1A15"].ToString() ;
        TextBox2.Text=r["G1A1519"].ToString() ;
       TextBox3.Text=r["G1A2024"].ToString()  ;
      TextBox4.Text=r["G1A2549"].ToString() ;
       TextBox5.Text=r["G1A50"].ToString() ;
       TextBox80.Text=r["SUBTOTALG2"].ToString() ;
       TextBox6.Text=r["G2A15"].ToString() ;
    TextBox7.Text=r["G2A1519"].ToString() ;
        TextBox8.Text=r["G2A2024"].ToString() ;
       TextBox9.Text=r["G2A2549"].ToString() ;
        TextBox10.Text=r["G2A50"].ToString() ;
        TextBox132.Text=r["SUBTOTALG3"].ToString() ;
        TextBox11.Text=r["G3A15"].ToString() ;
       TextBox12.Text=r["G3A1519"].ToString() ;
        TextBox13.Text=r["G3A2024"].ToString() ;
       TextBox14.Text=r["G3A2549"].ToString() ;
       TextBox15.Text=r["G3A50"].ToString() ;
       TextBox16.Text=r["TOTALG1"].ToString() ;
        TextBox674.Text=r["GTA15"].ToString() ;
        TextBox473.Text=r["GTA1519"].ToString() ;
        TextBox474.Text=r["GTA2024"].ToString() ;
       TextBox475.Text=r["GTA2549"].ToString() ;
       TextBox476.Text=r["GTA50"].ToString() ;
        TextBox133.Text=r["SUBTOTALG4"].ToString() ;
       TextBox17.Text=r["G4A15"].ToString() ;
       TextBox18.Text=r["G4A1519"].ToString() ;
        TextBox19.Text=r["G4A2024"].ToString() ;
        TextBox20.Text=r["G4A2549"].ToString() ;
        TextBox21.Text=r["G4A50"].ToString() ;
        TextBox134.Text=r["SUBTOTALG5"].ToString() ;
        TextBox22.Text=r["G5A15"].ToString() ;
        TextBox23.Text=r["G5A1519"].ToString() ;
        TextBox24.Text=r["G5A2024"].ToString() ;
        TextBox25.Text=r["G5A2549"].ToString() ;
        TextBox26.Text=r["G5A50"].ToString() ;
        TextBox27.Text=r["SUBTOTALG6"].ToString() ;
        TextBox28.Text=r["G6A15"].ToString() ;
        TextBox29.Text=r["G6A1519"].ToString() ;
       TextBox30.Text=r["G6A2024"].ToString() ;
        TextBox31.Text=r["G6A2549"].ToString() ;
       TextBox32.Text=r["G6A50"].ToString() ;
       TextBox135.Text=r["SUBTOTALG7"].ToString() ;
        TextBox33.Text=r["G7A15"].ToString() ;
       TextBox34.Text=r["G7A1519"].ToString() ;
       TextBox35.Text=r["G7A2024"].ToString()  ;
      TextBox36.Text=r["G7A2549"].ToString()  ;
        TextBox37.Text=r["G7A50"].ToString() ;
        TextBox136.Text=r["TOTALG2"].ToString() ;
         TextBox38.Text=r["TOTAL1A15"].ToString() ;
        TextBox39.Text=r["TOTAL1A1519"].ToString() ;
       TextBox40.Text=r["TOTAL1A2024"].ToString() ;
        TextBox41.Text=r["TOTAL1A2549"].ToString() ;
        TextBox42.Text=r["TOTAL1A50"].ToString() ;
        TextBox137.Text=r["SUBTOTALG8"].ToString() ;
        TextBox43.Text=r["G8A15"].ToString() ;
        TextBox44.Text=r["G8A1519"].ToString() ;
        TextBox45.Text=r["G8A2024"].ToString() ;
        TextBox46.Text=r["G8A2549"].ToString() ;
        TextBox47.Text=r["G8A50"].ToString() ;
       TextBox581.Text=r["SUBTOTALG9"].ToString() ;
        TextBox48.Text=r["G9A15"].ToString() ;
       TextBox49.Text=r["G9A1519"].ToString() ;
      TextBox50.Text=r["G9A2024"].ToString() ;
        TextBox51.Text=r["G9A2549"].ToString() ; 
       TextBox52.Text =r["G9A50"].ToString() ; 
        TextBox582.Text=r["SUBTOTALG10"].ToString() ; 
        TextBox53.Text=r["G10A15"].ToString() ; 
       TextBox54.Text =r["G10A1519"].ToString() ; 
      TextBox55.Text =r["G10A2024"].ToString() ; 
        TextBox56.Text =r["G10A2549"].ToString() ; 
       TextBox57.Text =r["G10A50"].ToString() ;
       TextBox583.Text=r["TOTALG3"].ToString() ; 
       TextBox58.Text=r["TOTAL2A15"].ToString() ; 
        TextBox59.Text=r["TOTAL2A1519"].ToString() ; 
        TextBox60.Text=r["TOTAL2A2024"].ToString() ; 
        TextBox61.Text=r["TOTAL2A2549"].ToString() ; 
        TextBox62.Text=r["TOTAL2A50"].ToString() ; 
       TextBox584.Text =r["SUBTOTALG11"].ToString() ; 
        TextBox63.Text =r["G11A15"].ToString() ; 
        TextBox64.Text=r["G11A1519"].ToString() ;
       TextBox65.Text=r["G11A2024"].ToString() ; 
       TextBox66.Text=r["G11A2549"].ToString() ; 
       TextBox67.Text =r["G11A50"].ToString() ; 
       TextBox585.Text =r["SUBTOTALG12"].ToString() ; 
       TextBox68.Text =r["G12A15"].ToString() ;
        TextBox69.Text=r["G12A1519"].ToString() ; 
        TextBox70.Text =r["G12A2024"].ToString() ;
        TextBox71.Text =r["G12A2549"].ToString() ; 
       TextBox72.Text =r["G12A50"].ToString() ; 
       TextBox586.Text=r["SUBTOTALG13"].ToString() ; 
        TextBox73.Text =r["G13A15"].ToString() ; 
        TextBox74.Text =r["G13A1519"].ToString() ; 
        TextBox75.Text =r["G13A2024"].ToString() ; 
       TextBox76.Text =r["G13A2549"].ToString() ; 
        TextBox77.Text =r["G13A50"].ToString() ; 
        TextBox78.Text=r["G13_1"].ToString() ; 
        TextBox79.Text =r["G13_2"].ToString() ;
        TextBox578.Text =r["G13_3"].ToString() ; 
        TextBox81.Text =r["G13_4"].ToString() ;
        TextBox82.Text =r["G13_5"].ToString() ;
       TextBox83.Text =r["G13_6"].ToString() ; 
        TextBox84.Text =r["G13_7"].ToString() ; 
        TextBox85.Text=r["G13_8"].ToString() ; 
      TextBox86.Text =r["G13_9"].ToString() ; 
       TextBox87.Text =r["SUBTOTALG14"].ToString() ; 
      TextBox88.Text =r["G14_1"].ToString() ; 
        TextBox89.Text =r["G14_2"].ToString() ; 
       TextBox90.Text =r["G14_3"].ToString() ; 
       TextBox91.Text =r["G14_4"].ToString() ; 
      TextBox154.Text =r["G14_5"].ToString() ; 
       TextBox155.Text =r["G14_6"].ToString() ; 
       TextBox276.Text =r["G14_7"].ToString() ;
       TextBox277.Text =r["G14_8"].ToString() ;
     TextBox278.Text =r["G14_9"].ToString() ;
      TextBox279.Text =r["G14_10"].ToString() ; 
       TextBox280.Text =r["G14_11"].ToString() ; 
        TextBox281.Text =r["G14_12"].ToString() ; 
       TextBox282.Text =r["G14_13"].ToString() ; 
        TextBox283.Text =r["G14_14"].ToString() ;
       TextBox92.Text=r["G14_15"].ToString() ;
        TextBox93.Text =r["G14_16"].ToString() ;
        TextBox94.Text =r["G14_17"].ToString() ; 
        TextBox273.Text =r["G14_18"].ToString() ; 
        TextBox95.Text =r["G14_19"].ToString() ; 
        TextBox96.Text =r["G14_20"].ToString() ; 
       TextBox97.Text =r["G14_21"].ToString() ; 
      TextBox98.Text =r["G14_22"].ToString() ; 
       TextBox99.Text=r["SUBTOTALG15"].ToString() ; 
       TextBox100.Text =r["G15_1"].ToString() ; 
        TextBox101.Text =r["G15_2"].ToString() ; 
        TextBox102.Text =r["G15_3"].ToString() ; 
        TextBox103.Text=r["G15_4"].ToString() ; 
        TextBox104.Text=r["G15_5"].ToString() ; 
       TextBox105.Text =r["G15_6"].ToString() ; 
      TextBox106.Text =r["G15_7"].ToString() ; 
       TextBox107.Text =r["SUBTOTALG16"].ToString() ; 
        TextBox108.Text=r["G16_1"].ToString() ; 
       TextBox109.Text =r["G16_2"].ToString() ; 
       TextBox110.Text =r["SUBTOTALG17"].ToString() ; 
        TextBox269.Text=r["G17_1"].ToString() ; 
       TextBox587.Text=r["G17_2"].ToString() ; 
        TextBox270.Text=r["SUBTOTALG18"].ToString() ; 
       TextBox111.Text =r["G18_1"].ToString() ; 
        TextBox112.Text=r["G18_2"].ToString() ; 
      TextBox113.Text=r["SUBTOTALG19"].ToString() ; 
       TextBox114.Text =r["G19_1"].ToString() ;
      TextBox115.Text =r["G19_2"].ToString() ;
       TextBox116.Text=r["G19_3"].ToString() ;
       TextBox117.Text =r["G19_4"].ToString() ;
        TextBox118.Text=r["G19_5"].ToString() ; 
       TextBox119.Text =r["G19_6"].ToString() ;
       TextBox271.Text =r["G19_7"].ToString() ; 
        TextBox272.Text =r["SUBTOTALG20"].ToString() ; 
        TextBox122.Text =r["G20_1"].ToString() ; 
      TextBox123.Text =r["G20_2"].ToString() ;
        TextBox124.Text =r["G20_3"].ToString() ; ;
       TextBox125.Text=r["G20_4"].ToString() ; 
       TextBox126.Text =r["G20_5"].ToString() ; 
      TextBox127.Text =r["G20_6"].ToString() ; 
       TextBox128.Text =r["G20_7"].ToString() ;
        TextBox129.Text =r["G20_8"].ToString() ; 
       TextBox130.Text =r["G20_9"].ToString() ;
      TextBox131.Text =r["G20_10"].ToString() ;
      TextBox580.Text =r["SUBTOTALG21"].ToString() ; 
       TextBox121.Text=r["G21_1"].ToString() ; 
       TextBox120.Text =r["G21_2"].ToString() ;

       Session["Edit"] = "T";
            }
            
        }catch(Exception ex)
        {
            webMessage.Show(" PMTCT Search error: " + ex.Message.ToString());
            return;
        }
    }

    
    protected void EDIT_HIVI()
    {
        try
        {
            string SQL1 = "SELECT * FROM tbl_HIVI Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                mState = Session["mState"].ToString();
                mLGA = Session["mLGA"].ToString();
                mFacility = Session["mFacility"].ToString();
                mMnth = Session["mMnth"].ToString();
                mYr = Session["mYr"].ToString();
                mChoose = Session["mChoose"].ToString();

                TextBox588.Text = r["totalg1"].ToString();
                TextBox589.Text = r["g1ma"].ToString();
                TextBox590.Text = r["g1fe"].ToString();
                TextBox591.Text = r["totalg2"].ToString();
                TextBox592.Text = r["g2ma"].ToString();
                TextBox593.Text = r["g2fe"].ToString();
                TextBox594.Text = r["totalg3"].ToString();
                TextBox595.Text = r["g3ma"].ToString();
                TextBox596.Text = r["g3fe"].ToString();
                TextBox597.Text = r["totalg4"].ToString();
                TextBox598.Text = r["g4ma"].ToString();
                TextBox599.Text = r["g4fe"].ToString();
                TextBox600.Text = r["totalg5"].ToString();
                TextBox601.Text = r["g5ma"].ToString();
                TextBox602.Text = r["g5fe"].ToString();
                TextBox603.Text = r["totalg6"].ToString();
                TextBox604.Text = r["g6ma"].ToString();
                TextBox605.Text = r["g6fe"].ToString();

                Session["Edit"] = "T";
            }
            
        }
        catch (Exception ex)
        {
            webMessage.Show(" HIVI Search error: " + ex.Message.ToString());
            return;
        }
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
        //}catch(Exception ex)
        //{
        //    Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
        //    return;
        //}
        
    }//--------


    //=========== Load LGA when State is Selected
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

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

        TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text)
                          + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
        TextBox6.Focus();

    }

    #region Error
    
    //protected void TextBox1_TextChanged(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty && TextBox4.Text != string.Empty && TextBox5.Text != string.Empty)
    //    {
    //        TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
    //        return;
    //    }
    //}
    //protected void TextBox2_TextChanged(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty && TextBox4.Text != string.Empty && TextBox5.Text != string.Empty)
    //    {
    //        TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
    //        return;
    //    }
    //}
    //protected void TextBox3_TextChanged(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty && TextBox4.Text != string.Empty && TextBox5.Text != string.Empty)
    //    {
    //        TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
    //        return;
    //    }
    //}
    //protected void TextBox4_TextChanged(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty && TextBox4.Text != string.Empty && TextBox5.Text != string.Empty)
    //    {
    //        TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
    //        return;
    //    }
    //}
    #endregion

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
            
        }catch(Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }

    }

    protected void drpThematic_SelectedIndexChanged(object sender, EventArgs e)
    {
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

    }// end drpThematic

    #region "======== Clear Text ========="
    protected void PMTCT_CLS()
    {
TextBox579.Text = string.Empty;
TextBox1.Text = string.Empty;
TextBox2.Text = string.Empty;
TextBox3.Text = string.Empty;
TextBox4.Text = string.Empty;
TextBox5.Text = string.Empty;
TextBox80.Text = string.Empty;
TextBox6.Text = string.Empty;
TextBox7.Text = string.Empty;
TextBox8.Text = string.Empty;
TextBox9.Text = string.Empty;
TextBox10.Text = string.Empty;
TextBox132.Text = string.Empty;
TextBox11.Text = string.Empty;
TextBox12.Text = string.Empty;
TextBox13.Text = string.Empty;
TextBox14.Text = string.Empty;
TextBox15.Text = string.Empty;
 TextBox16.Text = string.Empty;
 TextBox674.Text = string.Empty;
 TextBox473.Text = string.Empty;
 TextBox474.Text = string.Empty;
 TextBox475.Text = string.Empty;
TextBox133.Text = string.Empty;
 TextBox17.Text = string.Empty;
TextBox18.Text = string.Empty;
TextBox19.Text = string.Empty;
TextBox20.Text = string.Empty;
TextBox21.Text = string.Empty;
TextBox134.Text = string.Empty;
TextBox22.Text = string.Empty;
TextBox23.Text = string.Empty;
TextBox24.Text = string.Empty;
TextBox25.Text = string.Empty;
TextBox26.Text = string.Empty;
TextBox27.Text = string.Empty;
TextBox28.Text = string.Empty;
TextBox29.Text = string.Empty;
TextBox30.Text = string.Empty;
TextBox31.Text = string.Empty;
TextBox32.Text = string.Empty;
TextBox135.Text = string.Empty;
TextBox33.Text = string.Empty;
TextBox34.Text = string.Empty;
TextBox35.Text = string.Empty;
TextBox36.Text = string.Empty;
TextBox37.Text = string.Empty;
TextBox136.Text= string.Empty;
 TextBox38.Text= string.Empty;
TextBox39.Text= string.Empty;
TextBox40.Text= string.Empty;
TextBox41.Text= string.Empty;
TextBox42.Text= string.Empty;
TextBox137.Text= string.Empty;
TextBox43.Text= string.Empty;
TextBox44.Text= string.Empty;
TextBox45.Text= string.Empty;
TextBox46.Text= string.Empty;
TextBox47.Text= string.Empty;
TextBox581.Text= string.Empty;
TextBox48.Text= string.Empty;
TextBox49.Text= string.Empty;
TextBox50.Text= string.Empty;
TextBox51.Text= string.Empty;
TextBox52.Text= string.Empty;
TextBox582.Text= string.Empty;
          TextBox53.Text= string.Empty;
          TextBox54.Text= string.Empty;
          TextBox55.Text= string.Empty;
          TextBox56.Text= string.Empty;
          TextBox57.Text= string.Empty;
          TextBox583.Text= string.Empty;
          TextBox58.Text= string.Empty;
          TextBox59.Text= string.Empty;
          TextBox60.Text= string.Empty;
          TextBox61.Text= string.Empty;
          TextBox62.Text= string.Empty;
          TextBox584.Text= string.Empty;
          TextBox63.Text= string.Empty;
          TextBox64.Text= string.Empty;
          TextBox65.Text= string.Empty;
          TextBox66.Text= string.Empty;
          TextBox67.Text= string.Empty;
          TextBox585.Text= string.Empty;
          TextBox68.Text= string.Empty;
          TextBox69.Text= string.Empty;
          TextBox70.Text= string.Empty;
          TextBox71.Text= string.Empty;
          TextBox72.Text= string.Empty;
          TextBox586.Text= string.Empty;
          TextBox73.Text= string.Empty;
          TextBox74.Text= string.Empty;
          TextBox75.Text= string.Empty;
          TextBox76.Text= string.Empty;
          TextBox77.Text= string.Empty;
          TextBox78.Text= string.Empty;
         TextBox79.Text= string.Empty;
          TextBox578.Text= string.Empty;
          TextBox81.Text= string.Empty;
          TextBox82.Text= string.Empty;
          TextBox83.Text= string.Empty;
          TextBox84.Text= string.Empty;
          TextBox85.Text= string.Empty;
          TextBox86.Text= string.Empty;
          TextBox87.Text= string.Empty;
          TextBox88.Text= string.Empty;
          TextBox89.Text= string.Empty;
          TextBox90.Text= string.Empty;
          TextBox91.Text= string.Empty;
          TextBox274.Text= string.Empty;
          TextBox275.Text= string.Empty;
          TextBox276.Text= string.Empty;
          TextBox277.Text= string.Empty;
          TextBox278.Text= string.Empty;
          TextBox279.Text= string.Empty;
          TextBox280.Text= string.Empty;
          TextBox281.Text= string.Empty;
          TextBox282.Text= string.Empty;
          TextBox283.Text= string.Empty;
          TextBox92.Text= string.Empty;
          TextBox93.Text= string.Empty;
          TextBox94.Text= string.Empty;
          TextBox273.Text= string.Empty;
          TextBox95.Text= string.Empty;
          TextBox96.Text= string.Empty;
          TextBox97.Text= string.Empty;
          TextBox98.Text= string.Empty;
          TextBox99.Text= string.Empty;
          TextBox100.Text= string.Empty;
          TextBox101.Text= string.Empty;
          TextBox102.Text= string.Empty;
          TextBox103.Text= string.Empty;
          TextBox104.Text= string.Empty;
          TextBox105.Text= string.Empty;
          TextBox106.Text= string.Empty;
          TextBox107.Text= string.Empty;
          TextBox108.Text= string.Empty;
          TextBox109.Text= string.Empty;
          TextBox110.Text= string.Empty;
          TextBox269.Text= string.Empty;
          TextBox587.Text= string.Empty;
          TextBox270.Text= string.Empty;
          TextBox111.Text= string.Empty;
          TextBox112.Text= string.Empty;
          TextBox113.Text= string.Empty;
          TextBox114.Text= string.Empty;
          TextBox115.Text= string.Empty;
          TextBox116.Text= string.Empty;
          TextBox117.Text= string.Empty;
          TextBox118.Text= string.Empty;
          TextBox119.Text= string.Empty;
          TextBox271.Text= string.Empty;
          TextBox272.Text= string.Empty;
          TextBox122.Text= string.Empty;
          TextBox123.Text= string.Empty;
          TextBox124.Text= string.Empty;
          TextBox125.Text= string.Empty;
          TextBox126.Text= string.Empty;
          TextBox127.Text= string.Empty;
          TextBox128.Text= string.Empty;
          TextBox129.Text= string.Empty;
          TextBox130.Text= string.Empty;
          TextBox131.Text= string.Empty;
          TextBox580.Text= string.Empty;
          TextBox121.Text= string.Empty;
          TextBox120.Text= string.Empty;
          //drpStates.ClearSelection();
          //drpLGA.ClearSelection();
          //drpFacility.ClearSelection();
          //drpMnth.ClearSelection();
          //drpYrs.ClearSelection();
          //drpThematic.ClearSelection();
          //MultiView1.SetActiveView(View5);

    }
#endregion

    protected void SAVE_PMTCT(string mHold)
    {
#region "====== Assign textbox to Variables====="
        int SUBTOTALG1 = Convert.ToInt32(TextBox579.Text);
        int G1A15 = Convert.ToInt32(TextBox1.Text);
        int G1A1519 = Convert.ToInt32(TextBox2.Text) ;
        int G1A2024 = Convert.ToInt32(TextBox3.Text) ;
        int G1A2549 = Convert.ToInt32(TextBox4.Text) ;
        int G1A50 = Convert.ToInt32(TextBox5.Text) ;
        int SUBTOTALG2 = Convert.ToInt32(TextBox80.Text) ;
        int G2A15 = Convert.ToInt32(TextBox6.Text) ;
        int G2A1519 = Convert.ToInt32(TextBox7.Text) ;
        int G2A2024 = Convert.ToInt32(TextBox8.Text) ;
        int G2A2549 = Convert.ToInt32(TextBox9.Text) ;
        int G2A50 = Convert.ToInt32(TextBox10.Text) ;
        int SUBTOTALG3 = Convert.ToInt32(TextBox132.Text) ;
        int G3A15 = Convert.ToInt32(TextBox11.Text) ;
        int G3A1519 = Convert.ToInt32(TextBox12.Text) ;
        int G3A2024 = Convert.ToInt32(TextBox13.Text) ;
        int G3A2549 = Convert.ToInt32(TextBox14.Text) ;
        int G3A50 = Convert.ToInt32(TextBox15.Text) ;
        int TOTALG1 = Convert.ToInt32(TextBox16.Text) ;
        int GTA15 = Convert.ToInt32(TextBox674.Text);
        int GTA1519 = Convert.ToInt32(TextBox473.Text);
        int GTA2024 = Convert.ToInt32(TextBox474.Text);
        int GTA2549 = Convert.ToInt32(TextBox475.Text);
        int GTA50 = Convert.ToInt32(TextBox476.Text);
        int SUBTOTALG4 = Convert.ToInt32(TextBox133.Text) ;
        int G4A15 = Convert.ToInt32(TextBox17.Text) ;
        int G4A1519 = Convert.ToInt32(TextBox18.Text) ;
        int G4A2024 = Convert.ToInt32(TextBox19.Text) ;
        int G4A2549 = Convert.ToInt32(TextBox20.Text) ;
        int G4A50 = Convert.ToInt32(TextBox21.Text) ;
        int SUBTOTALG5 = Convert.ToInt32(TextBox134.Text) ;
        int G5A15 = Convert.ToInt32(TextBox22.Text) ;
        int G5A1519 = Convert.ToInt32(TextBox23.Text) ;
        int G5A2024 = Convert.ToInt32(TextBox24.Text) ;
        int G5A2549 = Convert.ToInt32(TextBox25.Text) ;
        int G5A50 = Convert.ToInt32(TextBox26.Text) ;
        int SUBTOTALG6 = Convert.ToInt32(TextBox27.Text) ;
        int G6A15 = Convert.ToInt32(TextBox28.Text);
        int G6A1519 = Convert.ToInt32(TextBox29.Text) ;
        int G6A2024 = Convert.ToInt32(TextBox30.Text) ;
        int G6A2549 = Convert.ToInt32(TextBox31.Text) ;
        int G6A50 = Convert.ToInt32(TextBox32.Text) ;
        int SUBTOTALG7 = Convert.ToInt32(TextBox135.Text) ;
        int G7A15 = Convert.ToInt32(TextBox33.Text) ;
        int G7A1519 = Convert.ToInt32(TextBox34.Text) ;
        int G7A2024 = Convert.ToInt32(TextBox35.Text) ;
        int G7A2549 = Convert.ToInt32(TextBox36.Text) ;
        int G7A50 = Convert.ToInt32(TextBox37.Text) ;
        int TOTALG2 = Convert.ToInt32(TextBox136.Text);
        int TOTAL1A15 = Convert.ToInt32(TextBox38.Text);
        int TOTAL1A1519 = Convert.ToInt32(TextBox39.Text);
        int TOTAL1A2024 = Convert.ToInt32(TextBox40.Text);
        int TOTAL1A2549 = Convert.ToInt32(TextBox41.Text);
        int TOTAL1A50 = Convert.ToInt32(TextBox42.Text);
        int SUBTOTALG8 = Convert.ToInt32(TextBox137.Text);
        int G8A15 = Convert.ToInt32(TextBox43.Text);
        int G8A1519 = Convert.ToInt32(TextBox44.Text);
        int G8A2024 = Convert.ToInt32(TextBox45.Text);
        int G8A2549 = Convert.ToInt32(TextBox46.Text);
        int G8A50 = Convert.ToInt32(TextBox47.Text);
        int SUBTOTALG9 = Convert.ToInt32(TextBox581.Text);
        int G9A15 = Convert.ToInt32(TextBox48.Text);
        int G9A1519 = Convert.ToInt32(TextBox49.Text);
        int G9A2024 = Convert.ToInt32(TextBox50.Text);
        int G9A2549 = Convert.ToInt32(TextBox51.Text);
        int G9A50 = Convert.ToInt32(TextBox52.Text);
        int SUBTOTALG10 = Convert.ToInt32(TextBox582.Text);
        int G10A15 = Convert.ToInt32(TextBox53.Text);
        int G10A1519 = Convert.ToInt32(TextBox54.Text);
        int G10A2024 = Convert.ToInt32(TextBox55.Text);
        int G10A2549 = Convert.ToInt32(TextBox56.Text);
        int G10A50 = Convert.ToInt32(TextBox57.Text);
        int TOTALG3 = Convert.ToInt32(TextBox583.Text);
        int TOTAL2A15 = Convert.ToInt32(TextBox58.Text);
        int TOTAL2A1519 = Convert.ToInt32(TextBox59.Text);
        int TOTAL2A2024 = Convert.ToInt32(TextBox60.Text);
        int TOTAL2A2549 = Convert.ToInt32(TextBox61.Text) ;
        int TOTAL2A50 = Convert.ToInt32(TextBox62.Text);
        int SUBTOTALG11 = Convert.ToInt32(TextBox584.Text);
        int G11A15 = Convert.ToInt32(TextBox63.Text);
        int G11A1519 = Convert.ToInt32(TextBox64.Text);
        int G11A2024 = Convert.ToInt32(TextBox65.Text);
        int G11A2549 = Convert.ToInt32(TextBox66.Text);
        int G11A50 = Convert.ToInt32(TextBox67.Text);
        int SUBTOTALG12 = Convert.ToInt32(TextBox585.Text);
        int G12A15 = Convert.ToInt32(TextBox68.Text);
        int G12A1519 = Convert.ToInt32(TextBox69.Text);
        int G12A2024 = Convert.ToInt32(TextBox70.Text);
        int G12A2549 = Convert.ToInt32(TextBox71.Text);
        int G12A50 = Convert.ToInt32(TextBox72.Text);
        int SUBTOTALG13 = Convert.ToInt32(TextBox586.Text);
        int G13A15 = Convert.ToInt32(TextBox73.Text);
        int G13A1519 = Convert.ToInt32(TextBox74.Text);
        int G13A2024 = Convert.ToInt32(TextBox75.Text);
        int G13A2549 = Convert.ToInt32(TextBox76.Text);
        int G13A50 = Convert.ToInt32(TextBox77.Text);
        int G13_1 = Convert.ToInt32(TextBox78.Text);
        int G13_2 = Convert.ToInt32(TextBox79.Text);
        int G13_3 = Convert.ToInt32(TextBox578.Text);
        int G13_4 = Convert.ToInt32(TextBox81.Text);
        int G13_5 = Convert.ToInt32(TextBox82.Text);
        int G13_6 = Convert.ToInt32(TextBox83.Text);
        int G13_7 = Convert.ToInt32(TextBox84.Text);
        int G13_8 = Convert.ToInt32(TextBox85.Text);
        int G13_9 = Convert.ToInt32(TextBox86.Text);
        int SUBTOTALG14 = Convert.ToInt32(TextBox87.Text);
        int G14_1 = Convert.ToInt32(TextBox88.Text);
        int G14_2 = Convert.ToInt32(TextBox89.Text);
        int G14_3 = Convert.ToInt32(TextBox90.Text);
        int G14_4 = Convert.ToInt32(TextBox91.Text);
        int G14_5 = Convert.ToInt32(TextBox154.Text);
        int G14_6 = Convert.ToInt32(TextBox155.Text);
        int G14_7 = Convert.ToInt32(TextBox276.Text);
        int G14_8 = Convert.ToInt32(TextBox277.Text);
        int G14_9 = Convert.ToInt32(TextBox278.Text);
        int G14_10 = Convert.ToInt32(TextBox279.Text);
        int G14_11 = Convert.ToInt32(TextBox280.Text);
        int G14_12 = Convert.ToInt32(TextBox281.Text);
        int G14_13 = Convert.ToInt32(TextBox282.Text);
        int G14_14 = Convert.ToInt32(TextBox283.Text);
        int G14_15 = Convert.ToInt32(TextBox92.Text);
        int G14_16 = Convert.ToInt32(TextBox93.Text);
        int G14_17 = Convert.ToInt32(TextBox94.Text);
        int G14_18 = Convert.ToInt32(TextBox273.Text);
        int G14_19 = Convert.ToInt32(TextBox95.Text);
        int G14_20 = Convert.ToInt32(TextBox96.Text);
        int G14_21 = Convert.ToInt32(TextBox97.Text);
        int G14_22 = Convert.ToInt32(TextBox98.Text);
        int SUBTOTALG15 = Convert.ToInt32(TextBox99.Text);
        int G15_1 = Convert.ToInt32(TextBox100.Text);
        int G15_2 = Convert.ToInt32(TextBox101.Text);
        int G15_3 = Convert.ToInt32(TextBox102.Text);
        int G15_4 = Convert.ToInt32(TextBox103.Text);
        int G15_5 = Convert.ToInt32(TextBox104.Text);
        int G15_6 = Convert.ToInt32(TextBox105.Text);
        int G15_7 = Convert.ToInt32(TextBox106.Text);
        int SUBTOTALG16 = Convert.ToInt32(TextBox107.Text);
        int G16_1 = Convert.ToInt32(TextBox108.Text);
        int G16_2 = Convert.ToInt32(TextBox109.Text);
        int SUBTOTALG17 = Convert.ToInt32(TextBox110.Text);
        int G17_1 = Convert.ToInt32(TextBox269.Text);
        int G17_2 = Convert.ToInt32(TextBox587.Text);
        int SUBTOTALG18 = Convert.ToInt32(TextBox270.Text);
        int G18_1 = Convert.ToInt32(TextBox111.Text);
        int G18_2 = Convert.ToInt32(TextBox112.Text);
        int SUBTOTALG19 = Convert.ToInt32(TextBox113.Text);
        int G19_1 = Convert.ToInt32(TextBox114.Text);
        int G19_2 = Convert.ToInt32(TextBox115.Text);
        int G19_3 = Convert.ToInt32(TextBox116.Text);
        int G19_4 = Convert.ToInt32(TextBox117.Text);
        int G19_5 = Convert.ToInt32(TextBox118.Text);
        int G19_6 = Convert.ToInt32(TextBox119.Text);
        int G19_7 = Convert.ToInt32(TextBox271.Text);
        int SUBTOTALG20 = Convert.ToInt32(TextBox272.Text);
        int G20_1 = Convert.ToInt32(TextBox122.Text);
        int G20_2 = Convert.ToInt32(TextBox123.Text);
        int G20_3 = Convert.ToInt32(TextBox124.Text);
        int G20_4 = Convert.ToInt32(TextBox125.Text);
        int G20_5 = Convert.ToInt32(TextBox126.Text);
        int G20_6 = Convert.ToInt32(TextBox127.Text);
        int G20_7 = Convert.ToInt32(TextBox128.Text);
        int G20_8 = Convert.ToInt32(TextBox129.Text);
        int G20_9 = Convert.ToInt32(TextBox130.Text);
        int G20_10 = Convert.ToInt32(TextBox131.Text);
        int SUBTOTALG21 = Convert.ToInt32(TextBox580.Text);
        int G21_1 = Convert.ToInt32(TextBox121.Text);
        int G21_2 = Convert.ToInt32(TextBox120.Text);

        mChoose = Session["mChoose"].ToString();
        mState = Session["mState"].ToString();
        mLGA = Session["mLGA"].ToString();
        mFacility = Session["mFacility"].ToString();
        mMnth = Session["mMnth"].ToString();
        mYr = Session["mYr"].ToString();
        
        if(!string.IsNullOrEmpty(Session["Edit"] as string))
        {
            if(Session["Edit"].ToString() == "T")
            {
                //==== Update Level 1=====
                string sql = "UPDATE tbl_PMTCT SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,SUBTOTALG1=@SUBTOTALG1,G1A15=@G1A15,G1A1519=@G1A1519,G1A2024=@G1A2024,G1A2549=@G1A2549,G1A50=@G1A50,SUBTOTALG2=@SUBTOTALG2,G2A15=@G2A15,";
                sql += "G2A1519=@G2A1519,G2A2024=@G2A2024,G2A2549=@G2A2549,G2A50=@G2A50,SUBTOTALG3=@SUBTOTALG3,G3A15=@G3A15,G3A1519=@G3A1519,G3A2024=@G3A2024,G3A2549=@G3A2549,G3A50=@G3A50,TOTALG1=@TOTALG1,GTA15=@GTA15,GTA1519=@GTA1519,GTA2024=@GTA2024,GTA2549=@GTA2549,GTA50=@GTA50,SUBTOTALG4=@SUBTOTALG4,";
                sql += "G4A15=@G4A15,G4A1519=@G4A1519,G4A2024=@G4A2024,G4A2549=@G4A2549,G4A50=@G4A50,SUBTOTALG5=@SUBTOTALG5,G5A15=@G5A15,G5A1519=@G5A1519,G5A2024=@G5A2024,G5A2549=@G5A2549,G5A50=@G5A50,SUBTOTALG6=@SUBTOTALG6,";
                sql += " G6A15=@G6A15,G6A1519=@G6A1519,G6A2024=@G6A2024,G6A2549=@G6A2549,G6A50=@G6A50,SUBTOTALG7=@SUBTOTALG7,G7A15=@G7A15,G7A1519=@G7A1519,G7A2024=@G7A2024,G7A2549=@G7A2549,G7A50=@G7A50,TOTALG2=@TOTALG2,TOTAL1A15=@TOTAL1A15,";
                sql += " TOTAL1A1519=@TOTAL1A1519,TOTAL1A2024=@TOTAL1A2024,TOTAL1A2549=@TOTAL1A2549,TOTAL1A50=@TOTAL1A50,SUBTOTALG8=@SUBTOTALG8,G8A15=@G8A15,G8A1519=@G8A1519,G8A2024=@G8A2024,G8A2549=@G8A2549,G8A50=@G8A50,SUBTOTALG9=@SUBTOTALG9,";
                sql += " G9A15=@G9A15,G9A1519=@G9A1519,G9A2024=@G9A2024,G9A2549=@G9A2549,G9A50=@G9A50,SUBTOTALG10=@SUBTOTALG10,G10A15=@G10A15,G10A1519=@G10A1519,G10A2024=@G10A2024,G10A2549=@G10A2549,G10A50=@G10A50,TOTALG3=@TOTALG3,";
                sql += " TOTAL2A15=@TOTAL2A15,TOTAL2A1519=@TOTAL2A1519,TOTAL2A2024=@TOTAL2A2024,TOTAL2A2549=@TOTAL2A2549,TOTAL2A50=@TOTAL2A50,SUBTOTALG11=@SUBTOTALG11,G11A15=@G11A15,G11A1519=@G11A1519,G11A2024=@G11A2024,G11A2549=@G11A2549,";
                sql += " G11A50=@G11A50,SUBTOTALG12=@SUBTOTALG12,G12A15=@G12A15,G12A1519=@G12A1519,G12A2024=@G12A2024,G12A2549=@G12A2549,G12A50=@G12A50,SUBTOTALG13=@SUBTOTALG13,G13A15=@G13A15,G13A1519=@G13A1519,G13A2024=@G13A2024,";
                sql += " G13A2549=@G13A2549,G13A50=@G13A50,G13_1=@G13_1,G13_2=@G13_2,G13_3=@G13_3,G13_4=@G13_4,G13_5=@G13_5,G13_6=@G13_6,G13_7=@G13_7,G13_8=@G13_8,G13_9=@G13_9,SUBTOTALG14=@SUBTOTALG14,G14_1=@G14_1,";
                sql += "G14_2=@G14_2,G14_3=@G14_3,G14_4=@G14_4,G14_5=@G14_5,G14_6=@G14_6,G14_7=@G14_7,G14_8=@G14_8,G14_9=@G14_9,G14_10=@G14_10,G14_11=@G14_11,G14_12=@G14_12,G14_13=@G14_13,G14_14=@G14_14,G14_15=@G14_15,";
                sql += "G14_16=@G14_16,G14_17=@G14_17,G14_18=@G14_18,G14_19=@G14_19,G14_20=@G14_20,G14_21=@G14_21,G14_22=@G14_22,SUBTOTALG15=@SUBTOTALG15,G15_1=@G15_1,G15_2=@G15_2,G15_3=@G15_3,G15_4=@G15_4,G15_5=@G15_5,G15_6=@G15_6,";
                sql += " G15_7=@G15_7,SUBTOTALG16=@SUBTOTALG16,G16_1=@G16_1,G16_2=@G16_2,SUBTOTALG17=@SUBTOTALG17,G17_1=@G17_1,G17_2=@G17_2,SUBTOTALG18=@SUBTOTALG18,G18_1=@G18_1,G18_2=@G18_2,SUBTOTALG19=@SUBTOTALG19,G19_1=@G19_1,G19_2=@G19_2,";
                sql += "G19_3=@G19_3,G19_4=@G19_4,G19_5=@G19_5,G19_6=@G19_6,G19_7=@G19_7,SUBTOTALG20=@SUBTOTALG20,G20_1=@G20_1,G20_2=@G20_2,G20_3=@G20_3,G20_4=@G20_4,G20_5=@G20_5,G20_6=@G20_6,G20_7=@G20_7,G20_8=@G20_8,G20_9=@G20_9,";
                sql += "G20_10=@G20_10,SUBTOTALG21=@SUBTOTALG21,G21_1=@G21_1,G21_2=@G21_2 WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";
                
                try
                {
                    SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql,cn );
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.Add("@SUBTOTALG1", SqlDbType.Int).Value = TextBox579.Text.Trim();
                    cmd.Parameters.Add("@G1A15", SqlDbType.Int).Value = TextBox1.Text.Trim();
                    cmd.Parameters.Add("@G1A1519", SqlDbType.Int).Value = TextBox2.Text.Trim();
                    cmd.Parameters.Add("@G1A2024", SqlDbType.Int).Value = TextBox3.Text.Trim();
                    cmd.Parameters.Add("@G1A2549", SqlDbType.Int).Value = TextBox4.Text.Trim();
                    cmd.Parameters.Add("@G1A50", SqlDbType.Int).Value = TextBox5.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG2", SqlDbType.Int).Value = TextBox80.Text.Trim();
                    cmd.Parameters.Add("@G2A15", SqlDbType.Int).Value = TextBox6.Text.Trim();
                    cmd.Parameters.Add("@G2A1519", SqlDbType.Int).Value = TextBox7.Text.Trim();
                    cmd.Parameters.Add("@G2A2024", SqlDbType.Int).Value = TextBox8.Text.Trim();
                    cmd.Parameters.Add("@G2A2549", SqlDbType.Int).Value = TextBox9.Text.Trim();
                    cmd.Parameters.Add("@G2A50", SqlDbType.Int).Value = TextBox10.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG3", SqlDbType.Int).Value = TextBox132.Text.Trim();
                    cmd.Parameters.Add("@G3A15", SqlDbType.Int).Value = TextBox11.Text.Trim();
                    cmd.Parameters.Add("@G3A1519", SqlDbType.Int).Value = TextBox12.Text.Trim();
                    cmd.Parameters.Add("@G3A2024", SqlDbType.Int).Value = TextBox13.Text.Trim();
                    cmd.Parameters.Add("@G3A2549", SqlDbType.Int).Value = TextBox14.Text.Trim();
                    cmd.Parameters.Add("@G3A50", SqlDbType.Int).Value = TextBox15.Text.Trim();
                    cmd.Parameters.Add("@TOTALG1", SqlDbType.Int).Value = TextBox16.Text.Trim();
                    cmd.Parameters.Add("@GTA15", SqlDbType.Int).Value = TextBox674.Text.Trim();
                    cmd.Parameters.Add("@GTA1519", SqlDbType.Int).Value = TextBox473.Text.Trim();
                    cmd.Parameters.Add("@GTA2024", SqlDbType.Int).Value = TextBox474.Text.Trim();
                    cmd.Parameters.Add("@GTA2549", SqlDbType.Int).Value = TextBox475.Text.Trim();
                    cmd.Parameters.Add("@GTA50", SqlDbType.Int).Value = TextBox476.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG4", SqlDbType.Int).Value = TextBox133.Text.Trim();
                    cmd.Parameters.Add("@G4A15", SqlDbType.Int).Value = TextBox17.Text.Trim();
                    cmd.Parameters.Add("@G4A1519", SqlDbType.Int).Value = TextBox18.Text.Trim();
                    cmd.Parameters.Add("@G4A2024", SqlDbType.Int).Value = TextBox19.Text.Trim();
                    cmd.Parameters.Add("@G4A2549", SqlDbType.Int).Value = TextBox20.Text.Trim();
                    cmd.Parameters.Add("@G4A50", SqlDbType.Int).Value = TextBox21.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG5", SqlDbType.Int).Value = TextBox134.Text.Trim();
                    cmd.Parameters.Add("@G5A15", SqlDbType.Int).Value = TextBox22.Text.Trim();
                    cmd.Parameters.Add("@G5A1519", SqlDbType.Int).Value = TextBox23.Text.Trim();
                    cmd.Parameters.Add("@G5A2024", SqlDbType.Int).Value = TextBox24.Text.Trim();
                    cmd.Parameters.Add("@G5A2549", SqlDbType.Int).Value = TextBox25.Text.Trim();
                    cmd.Parameters.Add("@G5A50", SqlDbType.Int).Value = TextBox26.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG6", SqlDbType.Int).Value = TextBox27.Text.Trim();
                    cmd.Parameters.Add("@G6A15", SqlDbType.Int).Value = TextBox28.Text.Trim();
                    cmd.Parameters.Add("@G6A1519", SqlDbType.Int).Value = TextBox29.Text.Trim();
                    cmd.Parameters.Add("@G6A2024", SqlDbType.Int).Value = TextBox30.Text.Trim();
                    cmd.Parameters.Add("@G6A2549", SqlDbType.Int).Value = TextBox31.Text.Trim();
                    cmd.Parameters.Add("@G6A50", SqlDbType.Int).Value = TextBox32.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG7", SqlDbType.Int).Value = TextBox135.Text.Trim();
                    cmd.Parameters.Add("@G7A15", SqlDbType.Int).Value = TextBox33.Text.Trim();
                    cmd.Parameters.Add("@G7A1519", SqlDbType.Int).Value = TextBox34.Text.Trim();
                    cmd.Parameters.Add("@G7A2024", SqlDbType.Int).Value = TextBox35.Text.Trim();
                    cmd.Parameters.Add("@G7A2549", SqlDbType.Int).Value = TextBox36.Text.Trim();
                    cmd.Parameters.Add("@G7A50", SqlDbType.Int).Value = TextBox37.Text.Trim();
                    cmd.Parameters.Add("@TOTALG2", SqlDbType.Int).Value = TextBox136.Text.Trim();
                    cmd.Parameters.Add("@TOTAL1A15", SqlDbType.Int).Value = TextBox38.Text.Trim();
                    cmd.Parameters.Add("@TOTAL1A1519", SqlDbType.Int).Value = TextBox39.Text.Trim();
                    cmd.Parameters.Add("@TOTAL1A2024", SqlDbType.Int).Value = TextBox40.Text.Trim();
                    cmd.Parameters.Add("@TOTAL1A2549", SqlDbType.Int).Value = TextBox41.Text.Trim();
                    cmd.Parameters.Add("@TOTAL1A50", SqlDbType.Int).Value = TextBox42.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG8", SqlDbType.Int).Value = TextBox137.Text.Trim();
                    cmd.Parameters.Add("@G8A15", SqlDbType.Int).Value = TextBox43.Text.Trim();
                    cmd.Parameters.Add("@G8A1519", SqlDbType.Int).Value = TextBox44.Text.Trim();
                    cmd.Parameters.Add("@G8A2024", SqlDbType.Int).Value = TextBox45.Text.Trim();
                    cmd.Parameters.Add("@G8A2549", SqlDbType.Int).Value = TextBox46.Text.Trim();
                    cmd.Parameters.Add("@G8A50", SqlDbType.Int).Value = TextBox47.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG9", SqlDbType.Int).Value = TextBox581.Text.Trim();
                    cmd.Parameters.Add("@G9A15", SqlDbType.Int).Value = TextBox48.Text.Trim();
                    cmd.Parameters.Add("@G9A1519", SqlDbType.Int).Value = TextBox49.Text.Trim();
                    cmd.Parameters.Add("@G9A2024", SqlDbType.Int).Value = TextBox50.Text.Trim();
                    cmd.Parameters.Add("@G9A2549", SqlDbType.Int).Value = TextBox51.Text.Trim();
                    cmd.Parameters.Add("@G9A50", SqlDbType.Int).Value = TextBox52.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG10", SqlDbType.Int).Value = TextBox582.Text.Trim();
                    cmd.Parameters.Add("@G10A15", SqlDbType.Int).Value = TextBox53.Text.Trim();
                    cmd.Parameters.Add("@G10A1519", SqlDbType.Int).Value = TextBox54.Text.Trim();
                    cmd.Parameters.Add("@G10A2024", SqlDbType.Int).Value = TextBox55.Text.Trim();
                    cmd.Parameters.Add("@G10A2549", SqlDbType.Int).Value = TextBox56.Text.Trim();
                    cmd.Parameters.Add("@G10A50", SqlDbType.Int).Value = TextBox57.Text.Trim();
                    cmd.Parameters.Add("@TOTALG3", SqlDbType.Int).Value = TextBox583.Text.Trim();
                    cmd.Parameters.Add("@TOTAL2A15", SqlDbType.Int).Value = TextBox58.Text.Trim();
                    cmd.Parameters.Add("@TOTAL2A1519", SqlDbType.Int).Value = TextBox59.Text.Trim();
                    cmd.Parameters.Add("@TOTAL2A2024", SqlDbType.Int).Value = TextBox60.Text.Trim();
                    cmd.Parameters.Add("@TOTAL2A2549", SqlDbType.Int).Value = TextBox61.Text.Trim();
                    cmd.Parameters.Add("@TOTAL2A50", SqlDbType.Int).Value = TextBox62.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG11", SqlDbType.Int).Value = TextBox584.Text.Trim();
                    cmd.Parameters.Add("@G11A15", SqlDbType.Int).Value = TextBox63.Text.Trim();
                    cmd.Parameters.Add("@G11A1519", SqlDbType.Int).Value = TextBox64.Text.Trim();
                    cmd.Parameters.Add("@G11A2024", SqlDbType.Int).Value = TextBox65.Text.Trim();
                    cmd.Parameters.Add("@G11A2549", SqlDbType.Int).Value = TextBox66.Text.Trim();
                    cmd.Parameters.Add("@G11A50", SqlDbType.Int).Value = TextBox67.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG12", SqlDbType.Int).Value = TextBox585.Text.Trim();
                    cmd.Parameters.Add("@G12A15", SqlDbType.Int).Value = TextBox68.Text.Trim();
                    cmd.Parameters.Add("@G12A1519", SqlDbType.Int).Value = TextBox69.Text.Trim();
                    cmd.Parameters.Add("@G12A2024", SqlDbType.Int).Value = TextBox70.Text.Trim();
                    cmd.Parameters.Add("@G12A2549", SqlDbType.Int).Value = TextBox71.Text.Trim();
                    cmd.Parameters.Add("@G12A50", SqlDbType.Int).Value = TextBox72.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG13", SqlDbType.Int).Value = TextBox586.Text.Trim();
                    cmd.Parameters.Add("@G13A15", SqlDbType.Int).Value = TextBox73.Text.Trim();
                    cmd.Parameters.Add("@G13A1519", SqlDbType.Int).Value = TextBox74.Text.Trim();
                    cmd.Parameters.Add("@G13A2024", SqlDbType.Int).Value = TextBox75.Text.Trim();
                    cmd.Parameters.Add("@G13A2549", SqlDbType.Int).Value = TextBox76.Text.Trim();
                    cmd.Parameters.Add("@G13A50", SqlDbType.Int).Value = TextBox77.Text.Trim();
                    cmd.Parameters.Add("@G13_1", SqlDbType.Int).Value = TextBox78.Text.Trim();
                    cmd.Parameters.Add("@G13_2", SqlDbType.Int).Value = TextBox79.Text.Trim();
                    cmd.Parameters.Add("@G13_3", SqlDbType.Int).Value = TextBox578.Text.Trim();
                    cmd.Parameters.Add("@G13_4", SqlDbType.Int).Value = TextBox81.Text.Trim();
                    cmd.Parameters.Add("@G13_5", SqlDbType.Int).Value = TextBox82.Text.Trim();
                    cmd.Parameters.Add("@G13_6", SqlDbType.Int).Value = TextBox83.Text.Trim();
                    cmd.Parameters.Add("@G13_7", SqlDbType.Int).Value = TextBox84.Text.Trim();
                    cmd.Parameters.Add("@G13_8", SqlDbType.Int).Value = TextBox85.Text.Trim();
                    cmd.Parameters.Add("@G13_9", SqlDbType.Int).Value = TextBox86.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG14", SqlDbType.Int).Value = TextBox87.Text.Trim();
                    cmd.Parameters.Add("@G14_1", SqlDbType.Int).Value = TextBox88.Text.Trim();
                    cmd.Parameters.Add("@G14_2", SqlDbType.Int).Value = TextBox89.Text.Trim();
                    cmd.Parameters.Add("@G14_3", SqlDbType.Int).Value = TextBox90.Text.Trim();
                    cmd.Parameters.Add("@G14_4", SqlDbType.Int).Value = TextBox91.Text.Trim();
                    cmd.Parameters.Add("@G14_5", SqlDbType.Int).Value = TextBox154.Text.Trim();
                    cmd.Parameters.Add("@G14_6", SqlDbType.Int).Value = TextBox155.Text.Trim();
                    cmd.Parameters.Add("@G14_7", SqlDbType.Int).Value = TextBox276.Text.Trim();
                    cmd.Parameters.Add("@G14_8", SqlDbType.Int).Value = TextBox277.Text.Trim();
                    cmd.Parameters.Add("@G14_9", SqlDbType.Int).Value = TextBox278.Text.Trim();
                    cmd.Parameters.Add("@G14_10", SqlDbType.Int).Value = TextBox279.Text.Trim();
                    cmd.Parameters.Add("@G14_11", SqlDbType.Int).Value = TextBox280.Text.Trim();
                    cmd.Parameters.Add("@G14_12", SqlDbType.Int).Value = TextBox281.Text.Trim();
                    cmd.Parameters.Add("@G14_13", SqlDbType.Int).Value = TextBox282.Text.Trim();
                    cmd.Parameters.Add("@G14_14", SqlDbType.Int).Value = TextBox283.Text.Trim();
                    cmd.Parameters.Add("@G14_15", SqlDbType.Int).Value = TextBox92.Text.Trim();
                    cmd.Parameters.Add("@G14_16", SqlDbType.Int).Value = TextBox93.Text.Trim();
                    cmd.Parameters.Add("@G14_17", SqlDbType.Int).Value = TextBox94.Text.Trim();
                    cmd.Parameters.Add("@G14_18", SqlDbType.Int).Value = TextBox273.Text.Trim();
                    cmd.Parameters.Add("@G14_19", SqlDbType.Int).Value = TextBox95.Text.Trim();
                    cmd.Parameters.Add("@G14_20", SqlDbType.Int).Value = TextBox96.Text.Trim();
                    cmd.Parameters.Add("@G14_21", SqlDbType.Int).Value = TextBox97.Text.Trim();
                    cmd.Parameters.Add("@G14_22", SqlDbType.Int).Value = TextBox98.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG15", SqlDbType.Int).Value = TextBox99.Text.Trim();
                    cmd.Parameters.Add("@G15_1", SqlDbType.Int).Value = TextBox100.Text.Trim();
                    cmd.Parameters.Add("@G15_2", SqlDbType.Int).Value = TextBox101.Text.Trim();
                    cmd.Parameters.Add("@G15_3", SqlDbType.Int).Value = TextBox102.Text.Trim();
                    cmd.Parameters.Add("@G15_4", SqlDbType.Int).Value = TextBox103.Text.Trim();
                    cmd.Parameters.Add("@G15_5", SqlDbType.Int).Value = TextBox104.Text.Trim();
                    cmd.Parameters.Add("@G15_6", SqlDbType.Int).Value = TextBox105.Text.Trim();
                    cmd.Parameters.Add("@G15_7", SqlDbType.Int).Value = TextBox106.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG16", SqlDbType.Int).Value = TextBox107.Text.Trim();
                    cmd.Parameters.Add("@G16_1", SqlDbType.Int).Value = TextBox108.Text.Trim();
                    cmd.Parameters.Add("@G16_2", SqlDbType.Int).Value = TextBox109.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG17", SqlDbType.Int).Value = TextBox110.Text.Trim();
                    cmd.Parameters.Add("@G17_1", SqlDbType.Int).Value = TextBox269.Text.Trim();
                    cmd.Parameters.Add("@G17_2", SqlDbType.Int).Value = TextBox587.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG18", SqlDbType.Int).Value = TextBox270.Text.Trim();
                    cmd.Parameters.Add("@G18_1", SqlDbType.Int).Value = TextBox111.Text.Trim();
                    cmd.Parameters.Add("@G18_2", SqlDbType.Int).Value = TextBox112.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG19", SqlDbType.Int).Value = TextBox113.Text.Trim();
                    cmd.Parameters.Add("@G19_1", SqlDbType.Int).Value = TextBox114.Text.Trim();
                    cmd.Parameters.Add("@G19_2", SqlDbType.Int).Value = TextBox115.Text.Trim();
                    cmd.Parameters.Add("@G19_3", SqlDbType.Int).Value = TextBox116.Text.Trim();
                    cmd.Parameters.Add("@G19_4", SqlDbType.Int).Value = TextBox117.Text.Trim();
                    cmd.Parameters.Add("@G19_5", SqlDbType.Int).Value = TextBox118.Text.Trim();
                    cmd.Parameters.Add("@G19_6", SqlDbType.Int).Value = TextBox119.Text.Trim();
                    cmd.Parameters.Add("@G19_7", SqlDbType.Int).Value = TextBox271.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG20", SqlDbType.Int).Value = TextBox272.Text.Trim();
                    cmd.Parameters.Add("@G20_1", SqlDbType.Int).Value = TextBox122.Text.Trim();
                    cmd.Parameters.Add("@G20_2", SqlDbType.Int).Value = TextBox123.Text.Trim();
                    cmd.Parameters.Add("@G20_3", SqlDbType.Int).Value = TextBox124.Text.Trim();
                    cmd.Parameters.Add("@G20_4", SqlDbType.Int).Value = TextBox125.Text.Trim();
                    cmd.Parameters.Add("@G20_5", SqlDbType.Int).Value = TextBox126.Text.Trim();
                    cmd.Parameters.Add("@G20_6", SqlDbType.Int).Value = TextBox127.Text.Trim();
                    cmd.Parameters.Add("@G20_7", SqlDbType.Int).Value = TextBox128.Text.Trim();
                    cmd.Parameters.Add("@G20_8", SqlDbType.Int).Value = TextBox129.Text.Trim();
                    cmd.Parameters.Add("@G20_9", SqlDbType.Int).Value = TextBox130.Text.Trim();
                    cmd.Parameters.Add("@G20_10", SqlDbType.Int).Value = TextBox131.Text.Trim();
                    cmd.Parameters.Add("@SUBTOTALG21", SqlDbType.Int).Value = TextBox580.Text.Trim();
                    cmd.Parameters.Add("@G21_1", SqlDbType.Int).Value = TextBox121.Text.Trim();
                    cmd.Parameters.Add("@G21_2", SqlDbType.Int).Value = TextBox120.Text.Trim();
                    int foundRow = cmd.ExecuteNonQuery();
                    lblThematic.Visible = false;
                    if (foundRow != -1)
                    {
                        webMessage.Show("PMTCT Update Successful....");
                            return;
                    }
                }catch(Exception ex)
                {
                    webMessage.Show("ERROR UPDATING PMTCT :" + ex.Message.Trim());
                    return;
                }
            }
            else
            {
                //"============== INSERT Statement ====================
                string sql = "INSERT INTO tbl_PMTCT (states,lga,facname,months,years,grouptype,SUBTOTALG1,G1A15,G1A1519,G1A2024,G1A2549,G1A50,SUBTOTALG2,G2A15,";
                sql += "G2A1519, G2A2024, G2A2549, G2A50, SUBTOTALG3, G3A15, G3A1519, G3A2024, G3A2549, G3A50, TOTALG1,GTA15,GTA1519,GTA2024,GTA2549,GTA50,SUBTOTALG4,";
                sql += "G4A15,	G4A1519, G4A2024, G4A2549, G4A50, SUBTOTALG5, G5A15, G5A1519,G5A2024,G5A2549,G5A50,SUBTOTALG6,";
                sql += " G6A15,G6A1519,G6A2024,G6A2549,G6A50,SUBTOTALG7,G7A15,G7A1519,G7A2024,G7A2549,G7A50,TOTALG2,TOTAL1A15,";
                sql += " TOTAL1A1519,TOTAL1A2024,TOTAL1A2549,TOTAL1A50,SUBTOTALG8,G8A15,G8A1519,G8A2024,G8A2549,G8A50,SUBTOTALG9,";
                sql += " G9A15,G9A1519,G9A2024,G9A2549,G9A50,SUBTOTALG10,G10A15,G10A1519,G10A2024,G10A2549,G10A50,TOTALG3,";
                sql += " TOTAL2A15,TOTAL2A1519,TOTAL2A2024,TOTAL2A2549,TOTAL2A50,SUBTOTALG11,G11A15,G11A1519,G11A2024,G11A2549,";
                sql += " G11A50,SUBTOTALG12,G12A15,G12A1519,G12A2024,G12A2549,G12A50,SUBTOTALG13,G13A15,G13A1519,G13A2024,";
                sql += " G13A2549,G13A50,G13_1,G13_2,G13_3,G13_4,G13_5,G13_6,G13_7,G13_8,G13_9,SUBTOTALG14,G14_1,";
                sql += "G14_2,	G14_3,	G14_4,	G14_5,	G14_6,	G14_7,	G14_8,	G14_9,	G14_10,	G14_11,	G14_12,	G14_13,	G14_14,	G14_15,";
                sql += "G14_16,G14_17,	G14_18	,G14_19,G14_20,	G14_21,	G14_22,	SUBTOTALG15,	G15_1,	G15_2,	G15_3,	G15_4,	G15_5,	G15_6,";
                sql += " G15_7,SUBTOTALG16,G16_1,	G16_2,	SUBTOTALG17,G17_1,	G17_2,	SUBTOTALG18,	G18_1,	G18_2,	SUBTOTALG19,G19_1,	G19_2,";
                sql += "G19_3,	G19_4,	G19_5,	G19_6,	G19_7,	SUBTOTALG20,	G20_1,	G20_2,	G20_3,	G20_4,	G20_5,	G20_6,	G20_7,	G20_8,	G20_9,";
                sql += "G20_10,	SUBTOTALG21,G21_1,	G21_2) VALUES ('" + mState + "','" + mLGA + "','" + mFacility + "','" + mMnth + "','" + mYr + "','" + mChoose + "',";
                sql += "'" + SUBTOTALG1 + "','" + G1A15 + "','" + G1A1519 + "','" + G1A2024 + "','" + G1A2549 + "','" + G1A50 + "','" + SUBTOTALG2 + "','" + G2A15 + "',";
                //========================================== Values
                sql += "'" + G2A1519 + "','" + G2A2024 + "','" + G2A2549 + "','" + G2A50 + "','" + SUBTOTALG3 + "','" + G3A15 + "','" + G3A1519 + "','" + G3A2024 + "','" + G3A2549 + "','" + G3A50 + "','" + TOTALG1 + "','" + GTA15 + "','" + GTA1519 + "','" + GTA2024 + "','" + GTA2549 + "','" + GTA50 + "','" + SUBTOTALG4 + "',";
                sql += "'" + G4A15 + "','" + G4A1519 + "','" + G4A2024 + "','" + G4A2549 + "','" + G4A50 + "','" + SUBTOTALG5 + "','" + G5A15 + "','" + G5A1519 + "','" + G5A2024 + "','" + G5A2549 + "','" + G5A50 + "','" + SUBTOTALG6 + "',	";
                sql += "'" + G6A15 + "','" + G6A1519 + "','" + G6A2024 + "','" + G6A2549 + "','" + G6A50 + "','" + SUBTOTALG7 + "','" + G7A15 + "','" + G7A1519 + "','" + G7A2024 + "','" + G7A2549 + "','" + G7A50 + "','" + TOTALG2 + "','" + TOTAL1A15 + "',";
                sql += "'" + TOTAL1A1519 + "','" + TOTAL1A2024 + "','" + TOTAL1A2549 + "','" + TOTAL1A50 + "','" + SUBTOTALG8 + "','" + G8A15 + "','" + G8A1519 + "','" + G8A2024 + "','" + G8A2549 + "','" + G8A50 + "','" + SUBTOTALG9 + "',";
                sql += "'" + G9A15 + "','" + G9A1519 + "','" + G9A2024 + "','" + G9A2549 + "','" + G9A50 + "','" + SUBTOTALG10 + "','" + G10A15 + "','" + G10A1519 + "','" + G10A2024 + "','" + G10A2549 + "','" + G10A50 + "','" + TOTALG3 + "',";
                sql += "'" + TOTAL2A15 + "','" + TOTAL2A1519 + "','" + TOTAL2A2024 + "','" + TOTAL2A2549 + "','" + TOTAL2A50 + "','" + SUBTOTALG11 + "','" + G11A15 + "','" + G11A1519 + "','" + G11A2024 + "','" + G11A2549 + "',";
                sql += "'" + G11A50 + "','" + SUBTOTALG12 + "','" + G12A15 + "','" + G12A1519 + "','" + G12A2024 + "','" + G12A2549 + "','" + G12A50 + "','" + SUBTOTALG13 + "','" + G13A15 + "','" + G13A1519 + "','" + G13A2024 + "',";
                sql += "'" + G13A2549 + "','" + G13A50 + "','" + G13_1 + "','" + G13_2 + "','" + G13_3 + "','" + G13_4 + "','" + G13_5 + "','" + G13_6 + "','" + G13_7 + "','" + G13_8 + "','" + G13_9 + "','" + SUBTOTALG14 + "','" + G14_1 + "',";
                sql += "'" + G14_2 + "','" + G14_3 + "','" + G14_4 + "','" + G14_5 + "','" + G14_6 + "','" + G14_7 + "','" + G14_8 + "','" + G14_9 + "','" + G14_10 + "','" + G14_11 + "','" + G14_12 + "','" + G14_13 + "','" + G14_14 + "','" + G14_15 + "',";
                sql += "'" + G14_16 + "','" + G14_17 + "','" + G14_18 + "','" + G14_19 + "','" + G14_20 + "','" + G14_21 + "','" + G14_22 + "','" + SUBTOTALG15 + "','" + G15_1 + "','" + G15_2 + "','" + G15_3 + "','" + G15_4 + "','" + G15_5 + "','" + G15_6 + "',";
                sql += "'" + G15_7 + "','" + SUBTOTALG16 + "','" + G16_1 + "','" + G16_2 + "','" + SUBTOTALG17 + "','" + G17_1 + "','" + G17_2 + "','" + SUBTOTALG18 + "','" + G18_1 + "','" + G18_2 + "','" + SUBTOTALG19 + "','" + G19_1 + "','" + G19_2 + "',";
                sql += "'" + G19_3 + "','" + G19_4 + "','" + G19_5 + "','" + G19_6 + "','" + G19_7 + "','" + SUBTOTALG20 + "','" + G20_1 + "','" + G20_2 + "','" + G20_3 + "','" + G20_4 + "','" + G20_5 + "','" + G20_6 + "','" + G20_7 + "','" + G20_8 + "','" + G20_9 + "',";
                sql += "'" + G20_10 + "','" + SUBTOTALG21 + "','" + G21_1 + "','" + G21_2 + "')";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    Aggregate_HTC();
                    cmd.Dispose();
                    cn.Close();
                    lblThematic.Visible = false;
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show("Submitting PMTCT Record :" + Rowsaffected.ToString() + "' Successful");
                        PMTCT_CLS();
                    }
                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR Saving PMTCT " + ex.Message.Trim());
                    return;
                }
                
            }
        }
                    

    }//end Save PMTCT
#endregion

    private void Aggregate_HTC()
    {
        try
        {
            
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;
            int d6 = 0;
            //===== PMTCT HIV+
            int d17 = 0;
            int d18 = 0;
            int d19 = 0;
            int d20 = 0;
            int d21 = 0;
            //===== PMTCT HIV-
            int d22 = 0;
            int d23 = 0;
            int d24 = 0;
            int d25 = 0;
            int d26 = 0;

            //=========== From HTC 
            int hd2 = 0;
            int hd3 = 0;
            int hd4 = 0;
            int hd5 = 0;
            int hd6 = 0;
            //==hd== PMTCT HIV+
            int hd17 = 0;
            int hd18 = 0;
            int hd19 = 0;
            int hd20 = 0;
            int hd21 = 0;
            //==hd== PMTCT HIV-
            int hd22 = 0;
            int hd23 = 0;
            int hd24 = 0;
            int hd25 = 0;
            int hd26 = 0;

            //====== Total Variables
            int td2 = 0;
            int td3 = 0;
            int td4 = 0;
            int td5 = 0;
            int td6 = 0;
            //==td== PMTCT HIV+
            int td17 = 0;
            int td18 = 0;
            int td19 = 0;
            int td20 = 0;
            int td21 = 0;
            //==td== PMTCT HIV-
            int td22 = 0;
            int td23 = 0;
            int td24 = 0;
            int td25 = 0;
            int td26 = 0;

            string SQL1 = "select * from tbl_pmtct where states ='" + mState + "' and lga='" + mLGA + "' and facname='" + mFacility + "' and months='" + mMnth + "' and years='" + mYr + "'";
            SQL1 += " and grouptype = '" + mChoose + "'";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader rd1 = cmd1.ExecuteReader();

            while (rd1.Read())
            {
                d2 += Convert.ToInt32(rd1["G4A15"].ToString()) + Convert.ToInt32(rd1["G6A15"].ToString()) +  Convert.ToInt32(rd1["G7A15"].ToString());
                d3 += Convert.ToInt32(rd1["G4A1519"].ToString()) + Convert.ToInt32(rd1["G6A1519"].ToString()) +  Convert.ToInt32(rd1["G7A1519"].ToString());
                d4 += Convert.ToInt32(rd1["G4A2024"].ToString()) + Convert.ToInt32(rd1["G6A2024"].ToString()) + Convert.ToInt32(rd1["G7A2024"].ToString());
                d5 += Convert.ToInt32(rd1["G4A2549"].ToString()) + Convert.ToInt32(rd1["G6A2549"].ToString()) + Convert.ToInt32(rd1["G7A2549"].ToString());
                d6 += Convert.ToInt32(rd1["G4A50"].ToString()) + Convert.ToInt32(rd1["G6A50"].ToString()) + Convert.ToInt32(rd1["G7A50"].ToString());
                // ================ PMTCT HIV+ ====================
                d17 += Convert.ToInt32(rd1["TOTAL1A15"].ToString());
                d18 += Convert.ToInt32(rd1["TOTAL1A1519"].ToString());
                d19 += Convert.ToInt32(rd1["TOTAL1A2024"].ToString());
                d20 += Convert.ToInt32(rd1["TOTAL1A2549"].ToString());
                d21 += Convert.ToInt32(rd1["TOTAL1A50"].ToString());
                //=============== PMTCT HIV- ======================
                d22 += Convert.ToInt32(rd1["TOTAL2A15"].ToString());
                d23 += Convert.ToInt32(rd1["TOTAL2A1519"].ToString());
                d24 += Convert.ToInt32(rd1["TOTAL2A2024"].ToString());
                d25 += Convert.ToInt32(rd1["TOTAL2A2549"].ToString());
                d26 += Convert.ToInt32(rd1["TOTAL2A50"].ToString());
            }
            rd1.Close();
            cmd1.Dispose();
            cn.Close();

            
            // CHECK FOR THE EXISTANCE OF DATA BEFORE ALLOWING UPDATING ELSE INSERT
            string PSQL ="SELECT * FROM tbl_HTC2 where states ='"+ mState +"' and lga='"+mLGA+"' and facname='"+ mFacility+"' and months='"+mMnth+"' and years='"+mYr+"'";
                  // PSQL +="and grouptype = '" + mChoose + "'";
            SqlConnection cn1 = new SqlConnection(ConnectAll.ConnectMe());
            cn1.Open();
            SqlCommand cmd = new SqlCommand(PSQL,cn1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows==true)
            {
                // has rows then read all
                while(dr.Read())
                {     
                    hd2 += Convert.ToInt32(dr["G9FE10_14"].ToString());
                    hd3 += Convert.ToInt32(dr["G9FE15_19"].ToString());
                    hd4 += Convert.ToInt32(dr["G9FE20_24"].ToString());
                    hd5 += Convert.ToInt32(dr["G9FE25_49"].ToString());
                    hd6 += Convert.ToInt32(dr["G9FE50"].ToString());
                 //===========HIV + ====================================
                    hd17 += Convert.ToInt32(dr["G10P10_14"].ToString());
                    hd18 += Convert.ToInt32(dr["G10P15_19"].ToString());
                    hd19 += Convert.ToInt32(dr["G10P20_24"].ToString());
                    hd20 += Convert.ToInt32(dr["G10P25_49"].ToString());
                    hd21 += Convert.ToInt32(dr["G10P50"].ToString());
               //===========HIV - ====================================
                    hd22 += Convert.ToInt32(dr["G10P10_14"].ToString());
                    hd23 += Convert.ToInt32(dr["G10P15_19"].ToString());
                    hd24 += Convert.ToInt32(dr["G10P20_24"].ToString());
                    hd25 += Convert.ToInt32(dr["G10P25_49"].ToString());
                    hd26 += Convert.ToInt32(dr["G10P50"].ToString());
                }
                cmd.Dispose();
                dr.Close();
                cn1.Close();

                //=== Summation Level
                td2 = d2 + hd2;
                td3 = d3 + hd3;
                td4 = d4 + hd4;
                td5 = d5 + hd5;
                td6 = d6 + hd6;
               //===== PMTCT HIV+
                td17 = d17 + hd17;
                td18 = d18 + hd18;
                td19 = d19 + hd19;
                td20 = d20 + hd20;
                td21 = d21 + hd21;
              //===== PMTCT HIV-
                td22 = d22 + hd22;
                td23 = d23 + hd23;
                td24 = d24 + hd24;
                td25 = d25 + hd25;
                td26 = d26 + hd26;

                //=====================

                if (cn1.State == ConnectionState.Closed) { cn1.Open(); }

                    string SQLUPDATE = " UPDATE tbl_htc2 set  G9FE10_14=@G9FE10_14, G9FE15_19=@G9FE15_19, G9FE20_24=@G9FE20_24, G9FE25_49=@G9FE25_49, G9FE50=@G9FE50,";
                  //== HIV + ====
                SQLUPDATE += "G10P10_14 = @G10P10_14, G10P15_19 = @G10P15_19, G10P20_24 = @G10P20_24,G10P25_49 = @G10P25_49,G10P50 = @G10P50,";
                //== HIV - ====
                SQLUPDATE += "G10N10_14 = @G10N10_14, G10N15_19 = @G10N15_19, G10N20_24 = @G10N20_24,G10N25_49 = @G10N25_49,G10N50 = @G10N50,";
                SQLUPDATE += "G11FE10_14=@G11FE10_14,G11FE15_19=@G11FE15_19,G11FE20_24=@G11FE20_24,G11FE25_49=@G11FE25_49,G11FE50=@G11FE50, ";
                SQLUPDATE += "G12FE10_14=@G12FE10_14,G12FE15_19=@G12FE15_19,G12FE20_24=@G12FE20_24,G12FE25_49=@G12FE25_49,G12FE50=@G12FE50 ";
                SQLUPDATE += " where states =@states and lga=@lga and facname=@facname and months=@months and years=@years and grouptype = @grouptype";

                SqlCommand CMD2 = new SqlCommand(SQLUPDATE, cn1);
                CMD2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                CMD2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                CMD2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                CMD2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                CMD2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                CMD2.Parameters.AddWithValue("@grouptype",SqlDbType.NVarChar).Value=mChoose;

                    CMD2.Parameters.AddWithValue("@G9FE10_14",SqlDbType.Int).Value=td2;
                    CMD2.Parameters.AddWithValue("@G9FE15_19",SqlDbType.Int).Value=td3;
                    CMD2.Parameters.AddWithValue("@G9FE20_24",SqlDbType.Int).Value=td4;
                    CMD2.Parameters.AddWithValue("@G9FE25_49",SqlDbType.Int).Value=td5;
                    CMD2.Parameters.AddWithValue("@G9FE50",SqlDbType.Int).Value=td6;
                   //=========== 1 HIV + ====================================
                    CMD2.Parameters.AddWithValue("@G10P10_14",SqlDbType.Int).Value=td17;
                    CMD2.Parameters.AddWithValue("@G10P15_19",SqlDbType.Int).Value=td18;
                    CMD2.Parameters.AddWithValue("@G10P20_24",SqlDbType.Int).Value=td19;
                    CMD2.Parameters.AddWithValue("@G10P25_49",SqlDbType.Int).Value=td20;
                    CMD2.Parameters.AddWithValue("@G10P50",SqlDbType.Int).Value=td21;
                    //=========== 1 HIV - ====================================
                    CMD2.Parameters.AddWithValue("@G10N10_14",SqlDbType.Int).Value=td22;
                    CMD2.Parameters.AddWithValue("@G10N15_19",SqlDbType.Int).Value=td23;
                    CMD2.Parameters.AddWithValue("@G10N20_24",SqlDbType.Int).Value=td24;
                    CMD2.Parameters.AddWithValue("@G10N25_49",SqlDbType.Int).Value=td25;
                    CMD2.Parameters.AddWithValue("@G10N50",SqlDbType.Int).Value=td26;

                    //=========== 2 HIV + ====================================
                    CMD2.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = td17;
                    CMD2.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = td18;
                    CMD2.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = td19;
                    CMD2.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = td20;
                    CMD2.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = td21;
                    //=========== 2 HIV - ====================================
                    CMD2.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = td22;
                    CMD2.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = td23;
                    CMD2.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = td24;
                    CMD2.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = td25;
                    CMD2.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = td26;

                CMD2.ExecuteNonQuery();
                CMD2.Dispose();

                SqlConnection cn2 = new SqlConnection(ConnectAll.ConnectMe());
                if (cn2.State == ConnectionState.Closed)
                {
                    cn2.Open();
                }
                string SQLHTC1 = "UPDATE tbl_HTC1 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype";
                SQLHTC1 += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";
                SqlCommand cmdHTC1 = new SqlCommand(SQLHTC1, cn2);
                cmdHTC1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                cmdHTC1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                cmdHTC1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                cmdHTC1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                cmdHTC1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                cmdHTC1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
                cmdHTC1.ExecuteNonQuery();
                cn2.Close();

                if (cn2.State == ConnectionState.Closed)
                {
                    cn2.Open();
                }
                string SQLHTC2 = "UPDATE tbl_HTC3 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype";
                SQLHTC2 += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";
                SqlCommand cmdHTC2 = new SqlCommand(SQLHTC2, cn2);
                cmdHTC2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                cmdHTC2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                cmdHTC2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                cmdHTC2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                cmdHTC2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                cmdHTC2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
                cmdHTC2.ExecuteNonQuery();
                cn2.Close();

            }
            else
            {
                // Now rows
                cmd.Dispose();
                cmd1.Dispose();
                dr.Close();
                string SQLUPDATE = " INSERT INTO tbl_htc2 (G9FE10_14,G9FE15_19,G9FE20_24,G9FE25_49, G9FE50,G10P10_14, G10P15_19,G10P20_24,G10P25_49,G10P50,G10N10_14,";
                SQLUPDATE += "G10N15_19,G10N20_24,G10N25_49,G10N50,G11FE10_14,G11FE15_19,G11FE20_24,G11FE25_49,G11FE50,G12FE10_14,G12FE15_19,G12FE20_24,G12FE25_49,G12FE50,states,lga,facname,months, years,grouptype)";
                SQLUPDATE += "VALUES(@G9FE10_14, @G9FE15_19, @G9FE20_24,@G9FE25_49,@G9FE50, @G10P10_14,@G11FE10_14,@G11FE15_19,@G11FE20_24,@G11FE25_49,@G11FE50, @G12FE10_14,@G12FE15_19,@G12FE20_24,@G12FE25_49,@G12FE50,";
               SQLUPDATE += "@G10P15_19, @G10P20_24, @G10P25_49, @G10P50,  @G10N10_14, @G10N15_19,  @G10N20_24, @G10N25_49, @G10N50,@states,@lga, @facname, @months,@years,@grouptype)";

            SqlConnection cn2 = new SqlConnection(ConnectAll.ConnectMe());
            cn2.Open();
            SqlCommand CMD2 = new SqlCommand(SQLUPDATE, cn2);
                CMD2.Parameters.AddWithValue("@states",SqlDbType.NVarChar).Value= mState;
                CMD2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                CMD2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                CMD2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                CMD2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                CMD2.Parameters.AddWithValue("@grouptype",SqlDbType.NVarChar).Value="HTC";

                CMD2.Parameters.AddWithValue("@G9FE10_14",SqlDbType.Int).Value=d2;
                CMD2.Parameters.AddWithValue("@G9FE15_19",SqlDbType.Int).Value=d3;
                CMD2.Parameters.AddWithValue("@G9FE20_24",SqlDbType.Int).Value=d4;
                CMD2.Parameters.AddWithValue("@G9FE25_49",SqlDbType.Int).Value=d5;
                CMD2.Parameters.AddWithValue("@G9FE50",SqlDbType.Int).Value=d6;
               //=========== 1 HIV + ====================================
                CMD2.Parameters.AddWithValue("@G10P10_14",SqlDbType.Int).Value=d17;
                CMD2.Parameters.AddWithValue("@G10P15_19",SqlDbType.Int).Value=d18;
                CMD2.Parameters.AddWithValue("@G10P20_24",SqlDbType.Int).Value=d19;
                CMD2.Parameters.AddWithValue("@G10P25_49",SqlDbType.Int).Value=d20;
                CMD2.Parameters.AddWithValue("@G10P50",SqlDbType.Int).Value=d21;
                //=========== 1 HIV - ====================================
                CMD2.Parameters.AddWithValue("@G10N10_14",SqlDbType.Int).Value=d22;
                CMD2.Parameters.AddWithValue("@G10N15_19",SqlDbType.Int).Value=d23;
                CMD2.Parameters.AddWithValue("@G10N20_24",SqlDbType.Int).Value=d24;
                CMD2.Parameters.AddWithValue("@G10N25_49",SqlDbType.Int).Value=d25;
                CMD2.Parameters.AddWithValue("@G10N50",SqlDbType.Int).Value=d26;

                //=========== 2 HIV + ====================================
                CMD2.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = d17;
                CMD2.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = d18;
                CMD2.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = d19;
                CMD2.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = d20;
                CMD2.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = d21;
                //=========== 2 HIV - ====================================
                CMD2.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = d22;
                CMD2.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = d23;
                CMD2.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = d24;
                CMD2.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = d25;
                CMD2.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = d26;
            CMD2.ExecuteNonQuery();
            cn2.Close();

                if(cn2.State == ConnectionState.Closed)
                {
                    cn2.Open();
                }
                string SQLHTC1 = "INSERT INTO tbl_HTC1 (states,lga,facname,months,years,grouptype) VALUES(@states,@lga,@facname,@months,@years,@grouptype)";
                    SqlCommand cmdHTC1 = new SqlCommand(SQLHTC1, cn2);
                    cmdHTC1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmdHTC1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmdHTC1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmdHTC1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmdHTC1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmdHTC1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
                    cmdHTC1.ExecuteNonQuery();
                    cn2.Close();
                  
            if (cn2.State == ConnectionState.Closed)
            {
                cn2.Open();
            }
            string SQLHTC2 = "INSERT INTO tbl_HTC3 (states,lga,facname,months,years,grouptype) VALUES(@states,@lga,@facname,@months,@years,@grouptype)";
            SqlCommand cmdHTC2 = new SqlCommand(SQLHTC2, cn2);
            cmdHTC2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
            cmdHTC2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
            cmdHTC2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
            cmdHTC2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
            cmdHTC2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
            cmdHTC2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
            cmdHTC2.ExecuteNonQuery();
            cn2.Close();
            }
            lblThematic.Visible = false;
        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message.ToString());
            //Response.Write("<script language=javascript>alert('" + ex.Message.Trim() + "');</script>");
            return;
        }

    }


    protected void SAVE_HIVI()
    {
        if (!string.IsNullOrEmpty(Session["Edit"] as string))
        {
            if (Session["Edit"].ToString() == "T")
            {
                //==== Update Level 1=====
                string sql = "UPDTE tbl_HIVI SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,totalg1=@totalg1,g1ma=@g1ma,";
                sql += "g1fe=@g1fe,totalg2=@totalg2,g2ma=@g2ma,g2fe=@g2fe,totalg3=@totalg3,g3ma=@g3ma,g3fe=@g3fe,totalg4=@totalg4,g4ma=@g4ma,g4fe=@g4fe,";
                sql += "totalg5=@totalg5,g5ma=@g5ma,g5fe=@g5fe,totalg6=@totalg6,g6ma=@g6ma,g6fe=@g6fe";
                sql += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    if (mChoose != "")
                    {

                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                        cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                        cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                        cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                        cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                        cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                        cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox588.Text.Trim();
                        cmd.Parameters.AddWithValue("@g1ma", SqlDbType.Int).Value = TextBox589.Text.Trim();
                        cmd.Parameters.AddWithValue("@g1fe", SqlDbType.Int).Value = TextBox590.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox591.Text.Trim();
                        cmd.Parameters.AddWithValue("@g2ma", SqlDbType.Int).Value = TextBox592.Text.Trim();
                        cmd.Parameters.AddWithValue("@g2fe", SqlDbType.Int).Value = TextBox593.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox594.Text.Trim();
                        cmd.Parameters.AddWithValue("@g3ma", SqlDbType.Int).Value = TextBox595.Text.Trim();
                        cmd.Parameters.AddWithValue("@g3fe", SqlDbType.Int).Value = TextBox596.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox597.Text.Trim();
                        cmd.Parameters.AddWithValue("@g4ma", SqlDbType.Int).Value = TextBox598.Text.Trim();
                        cmd.Parameters.AddWithValue("@g4fe", SqlDbType.Int).Value = TextBox599.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox600.Text.Trim();
                        cmd.Parameters.AddWithValue("@g5ma", SqlDbType.Int).Value = TextBox601.Text.Trim();
                        cmd.Parameters.AddWithValue("@g5fe", SqlDbType.Int).Value = TextBox602.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg6", SqlDbType.Int).Value = TextBox603.Text.Trim();
                        cmd.Parameters.AddWithValue("@g6ma", SqlDbType.Int).Value = TextBox604.Text.Trim();
                        cmd.Parameters.AddWithValue("@g6fe", SqlDbType.Int).Value = TextBox605.Text.Trim();
                        int Rowsaffected = cmd.ExecuteNonQuery();
                        if (Rowsaffected != -1)
                        {
                            webMessage.Show( Rowsaffected.ToString() + "' Successful");
                            return;
                        }
                        HIVI_CLS();
                        lblThematic.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR updating hivi "+ ex.Message.ToString() );
                    return;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                //============ Insert Level 1 =========
                string sql = "INSERT INTO tbl_HIVI (states,lga,facname,months,years,grouptype,totalg1,g1ma,g1fe,totalg2,g2ma,g2fe,totalg3,g3ma,g3fe,totalg4,g4ma,g4fe,";
                sql += "totalg5,g5ma,g5fe,totalg6,g6ma,g6fe) Values";
                sql += "(@states,@lga,@facname,@months,@years,@grouptype,@totalg1,@g1ma,@g1fe,@totalg2,@g2ma,@g2fe,@totalg3,@g3ma,@g3fe,@totalg4,@g4ma,@g4fe,";
                sql += "@totalg5,@g5ma,@g5fe,@totalg6,@g6ma,@g6fe)";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    if (mChoose != "")
                    {

                        cn.Open();
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                        cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                        cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                        cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                        cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                        cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                        cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox588.Text.Trim();
                        cmd.Parameters.AddWithValue("@g1ma", SqlDbType.Int).Value = TextBox589.Text.Trim();
                        cmd.Parameters.AddWithValue("@g1fe", SqlDbType.Int).Value = TextBox590.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox591.Text.Trim();
                        cmd.Parameters.AddWithValue("@g2ma", SqlDbType.Int).Value = TextBox592.Text.Trim();
                        cmd.Parameters.AddWithValue("@g2fe", SqlDbType.Int).Value = TextBox593.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox594.Text.Trim();
                        cmd.Parameters.AddWithValue("@g3ma", SqlDbType.Int).Value = TextBox595.Text.Trim();
                        cmd.Parameters.AddWithValue("@g3fe", SqlDbType.Int).Value = TextBox596.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox597.Text.Trim();
                        cmd.Parameters.AddWithValue("@g4ma", SqlDbType.Int).Value = TextBox598.Text.Trim();
                        cmd.Parameters.AddWithValue("@g4fe", SqlDbType.Int).Value = TextBox599.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox600.Text.Trim();
                        cmd.Parameters.AddWithValue("@g5ma", SqlDbType.Int).Value = TextBox601.Text.Trim();
                        cmd.Parameters.AddWithValue("@g5fe", SqlDbType.Int).Value = TextBox602.Text.Trim();
                        cmd.Parameters.AddWithValue("@totalg6", SqlDbType.Int).Value = TextBox603.Text.Trim();
                        cmd.Parameters.AddWithValue("@g6ma", SqlDbType.Int).Value = TextBox604.Text.Trim();
                        cmd.Parameters.AddWithValue("@g6fe", SqlDbType.Int).Value = TextBox605.Text.Trim();
                        int Rowsaffected = cmd.ExecuteNonQuery();
                        if (Rowsaffected != -1)
                        {
                           webMessage.Show( Rowsaffected.ToString() + "' Successful");
                            return;
                        }
                        HIVI_CLS();
                        lblThematic.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                   webMessage.Show("ERROR Saving hivi :" + ex.Message.ToString() );
                    return;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        

    }//end Save HIVI

    protected void HIVI_CLS()
    {
        //drpStates.ClearSelection();
        //drpLGA.ClearSelection();
        //drpFacility.ClearSelection();
        //drpMnth.ClearSelection();
        //drpYrs.ClearSelection();
        TextBox588.Text = string.Empty;
        TextBox589.Text = string.Empty;
        TextBox590.Text = string.Empty;
        TextBox591.Text = string.Empty;
        TextBox592.Text = string.Empty;
        TextBox593.Text = string.Empty;
        TextBox594.Text = string.Empty;
        TextBox595.Text = string.Empty;
        TextBox596.Text = string.Empty;
        TextBox597.Text = string.Empty;
        TextBox598.Text = string.Empty;
        TextBox599.Text = string.Empty;
        TextBox600.Text = string.Empty;
        TextBox601.Text = string.Empty;
        TextBox602.Text = string.Empty;
        TextBox603.Text = string.Empty;
        TextBox604.Text = string.Empty;
        TextBox605.Text = string.Empty;
    }// end of HIVI_CLS

    protected void TRAINING_CLS()
    {
        try
        {
            //drpStates.ClearSelection();
            //drpLGA.ClearSelection();
            //drpFacility.ClearSelection();
            //drpMnth.ClearSelection();
            //drpYrs.ClearSelection();
            TextBox606.Text = string.Empty;
            TextBox138.Text = string.Empty;
            TextBox139.Text = string.Empty;
            TextBox140.Text = string.Empty;
            TextBox141.Text = string.Empty;
            TextBox142.Text = string.Empty;
            TextBox143.Text = string.Empty;
            TextBox144.Text = string.Empty;
            TextBox145.Text = string.Empty;
            TextBox607.Text = string.Empty;
            TextBox146.Text = string.Empty;
            TextBox148.Text = string.Empty;
            TextBox149.Text = string.Empty;
            TextBox150.Text = string.Empty;
            TextBox151.Text = string.Empty;
            TextBox152.Text = string.Empty;
            TextBox153.Text = string.Empty;
            TextBox606.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }// end of trining cls

    protected void GENDNORM_CLS()
    {
        
        TextBox609.Text = string.Empty;
        TextBox610.Text = string.Empty;
        TextBox611.Text = string.Empty;
        TextBox612.Text = string.Empty;
        TextBox613.Text = string.Empty;
        TextBox614.Text = string.Empty;
        TextBox615.Text = string.Empty;
        TextBox616.Text = string.Empty;
        TextBox617.Text = string.Empty;
        TextBox618.Text = string.Empty;
        TextBox619.Text = string.Empty;
        TextBox620.Text = string.Empty;
        TextBox621.Text = string.Empty;
        TextBox622.Text = string.Empty;
        TextBox623.Text = string.Empty;
        TextBox624.Text = string.Empty;
        TextBox625.Text = string.Empty;
        TextBox626.Text = string.Empty;
        TextBox627.Text = string.Empty;
        TextBox628.Text = string.Empty;
        TextBox629.Text = string.Empty;
        TextBox630.Text = string.Empty;
        TextBox631.Text = string.Empty;
        TextBox632.Text = string.Empty;
        TextBox633.Text = string.Empty;
        TextBox634.Text = string.Empty;
        TextBox635.Text = string.Empty;
        TextBox666.Text = string.Empty;
        TextBox636.Text = string.Empty;
        TextBox637.Text = string.Empty;
        TextBox638.Text = string.Empty;
        TextBox639.Text = string.Empty;
        TextBox640.Text = string.Empty;
        TextBox641.Text = string.Empty;
        TextBox642.Text = string.Empty;
        TextBox643.Text = string.Empty;
        TextBox644.Text = string.Empty;
        TextBox645.Text = string.Empty;
        TextBox646.Text = string.Empty;
        TextBox647.Text = string.Empty;
        TextBox648.Text = string.Empty;
        TextBox649.Text = string.Empty;
        TextBox650.Text = string.Empty;
        TextBox651.Text = string.Empty;
        TextBox652.Text = string.Empty;
        TextBox653.Text = string.Empty;
        TextBox654.Text = string.Empty;
        TextBox655.Text = string.Empty;
        TextBox656.Text = string.Empty;
        TextBox657.Text = string.Empty;
        TextBox658.Text = string.Empty;
        TextBox659.Text = string.Empty;
        TextBox660.Text = string.Empty;
        TextBox661.Text = string.Empty;
        TextBox662.Text = string.Empty;
        TextBox663.Text = string.Empty;
        TextBox664.Text = string.Empty;
        TextBox665.Text = string.Empty;
        //drpThematic.Focus();
    }// end of Gend Norm Cls
    
    //protected void CLS_TRAINING()
    //{
    //    try
    //    {
    //        TextBox138.Text = string.Empty;
    //        TextBox139.Text = string.Empty;
    //        TextBox140.Text = string.Empty;
    //        TextBox141.Text = string.Empty;
    //        TextBox142.Text = string.Empty;
    //        TextBox143.Text = string.Empty;
    //        TextBox144.Text = string.Empty;
    //        TextBox145.Text = string.Empty;
    //        TextBox607.Text = string.Empty;
    //        TextBox146.Text = string.Empty;
    //        TextBox147.Text = string.Empty;
    //        TextBox148.Text = string.Empty;
    //        TextBox149.Text = string.Empty;
    //        TextBox150.Text = string.Empty;
    //        TextBox151.Text = string.Empty;
    //        TextBox152.Text = string.Empty;
    //        TextBox153.Text = string.Empty;
    //    }catch(Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    // ================= Saving Training Record =================
    protected void Save_Training()
    {
        if (!string.IsNullOrEmpty(Session["Edit"] as string))
        {
            if (Session["Edit"].ToString() == "T")
            {
                //==== Update Level 1=====


            }
            else
            {
                //============ Insert Level 1 =========
                string sql = "INSERT INTO tbl_TRAINING (states,lga,facname,months,years,grouptype,totalg1,g1ma,g1fe,totalg2,g2ma,g2fe,totalg3,g3ma,g3fe,totalg4,g4ma,g4fe,";
                sql += "totalg5,g5ma,g5fe,totalg6,g6ma,g6fe) Values";
                sql += "(@states,@lga,@facname,@months,@years,@grouptype,@totalg1,@g1ma,@g1fe,@totalg2,@g2ma,@g2fe,@totalg3,@g3ma,@g3fe,@totalg4,@g4ma,@g4fe,";
                sql += "@totalg5,@g5ma,@g5fe,@totalg6,@g6ma,@g6fe)";

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

                    cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox606.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma", SqlDbType.Int).Value = TextBox138.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe", SqlDbType.Int).Value = TextBox139.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox140.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma", SqlDbType.Int).Value = TextBox141.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe", SqlDbType.Int).Value = TextBox142.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox143.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma", SqlDbType.Int).Value = TextBox144.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe", SqlDbType.Int).Value = TextBox145.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox607.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma", SqlDbType.Int).Value = TextBox146.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe", SqlDbType.Int).Value = TextBox147.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox148.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma", SqlDbType.Int).Value = TextBox149.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe", SqlDbType.Int).Value = TextBox150.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg6", SqlDbType.Int).Value = TextBox151.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma", SqlDbType.Int).Value = TextBox152.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe", SqlDbType.Int).Value = TextBox153.Text.Trim();
                    int Rowsaffected = cmd.ExecuteNonQuery();

                    if (Rowsaffected != -1)
                    {
                         webMessage.Show( Rowsaffected.ToString() + "' Successful");
                        TRAINING_CLS();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    webMessage.Show(ex.Message.ToString());
                    return;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        
    }// end Saving Record Training

    protected void SAVE_GN()
    {
        if (!string.IsNullOrEmpty(Session["Edit"] as string))
        {
            if (Session["Edit"].ToString() == "T")
            {
                //==== Update Level 1=====
                string sql = "UPDATE tbl_GENDNORM SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,";
                sql += "TOTALG1=@TOTALG1,SUBG1MA=@SUBG1MA,G1MA0_9=@G1MA0_9,G1MA10_14=@G1MA10_14,G1MA15_19=@G1MA15_19,G1MA20_24=@G1MA20_24,G1MA25=@G1MA25,";
                sql +=" SUBG1FE=@SUBG1FE,G1FE0_9=@G1FE0_9,G1FE10_14=@G1FE10_14,G1FE15_19=@G1FE15_19,G1FE20_24=@G1FE20_24,G1FE25=@G1FE25,G1_1=@G1_1,G1_2=@G1_2,";
                sql += "G1_3=@G1_3,TOTALG2=@TOTALG2,SUBG2MA=@SUBG2MA,G2MA0_9=@G2MA0_9,G2MA10_14=@G2MA10_14,	G2MA15_19=@G2MA15_19,G2MA20_24=@G2MA20_24,G2MA25=@G2MA25,";
                sql +=" SUBG2FE=@SUBG2FE,G2FE0_9=@G2FE0_9,G2FE10_14=@G2FE10_14,G2FE15_19=@G2FE15_19,G2FE20_24=@G2FE20_24,G2FE25=@G2FE25,";
                sql += "TOTALG3=@TOTALG3,SUBG3MA=@SUBG3MA,G3MA0_9=@G3MA0_9,G3MA10_14=@G3MA10_14,G3MA15_19=@G3MA15_19,G3MA20_24=@G3MA20_24,G3MA25=@G3MA25,SUBG3FE=@SUBG3FE,";
                sql += "G3FE0_9=@G3FE0_9,G3FE10_14=@G3FE10_14,G3FE15_19=@G3FE15_19,G3FE20_24=@G3FE20_24,G3FE25=@G3FE25,TOTALG4=@TOTALG4,";
                sql += "SUBG4MA=@SUBG4MA,G4MA0_9=@G4MA0_9,G4MA10_14=@G4MA10_14,G4MA15_19=@G4MA15_19,G4MA20_24=@G4MA20_24,G4MA25=@G4MA25,SUBG4FE=@SUBG4FE,G4FE0_9=@G4FE0_9,";
                sql += "G4FE10_14=@G4FE10_14,G4FE15_19=@G4FE15_19,G4FE20_24=@G4FE20_24,G4FE25=@G4FE25,TOTALG5=@TOTALG5,G5MA=@G5MA,G5FE=@G5FE";
                sql += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@monthsAND years=@years AND grouptype=@grouptype";
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

                    cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox609.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1ma", SqlDbType.Int).Value = TextBox610.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma0_9", SqlDbType.Int).Value = TextBox611.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma10_14", SqlDbType.Int).Value = TextBox612.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma15_19", SqlDbType.Int).Value = TextBox613.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma20_24", SqlDbType.Int).Value = TextBox614.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma25", SqlDbType.Int).Value = TextBox615.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1fe", SqlDbType.Int).Value = TextBox616.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe0_9", SqlDbType.Int).Value = TextBox617.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe10_14", SqlDbType.Int).Value = TextBox618.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe15_19", SqlDbType.Int).Value = TextBox619.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe20_24", SqlDbType.Int).Value = TextBox620.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe25", SqlDbType.Int).Value = TextBox621.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1_1", SqlDbType.Int).Value = TextBox622.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1_2", SqlDbType.Int).Value = TextBox623.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1_3", SqlDbType.Int).Value = TextBox624.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox625.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2ma", SqlDbType.Int).Value = TextBox626.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma0_9", SqlDbType.Int).Value = TextBox627.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma10_14", SqlDbType.Int).Value = TextBox628.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma15_19", SqlDbType.Int).Value = TextBox629.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma20_24", SqlDbType.Int).Value = TextBox630.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma25", SqlDbType.Int).Value = TextBox631.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2fe", SqlDbType.Int).Value = TextBox632.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe0_9", SqlDbType.Int).Value = TextBox633.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe10_14", SqlDbType.Int).Value = TextBox634.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe15_19", SqlDbType.Int).Value = TextBox635.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe20_24", SqlDbType.Int).Value = TextBox666.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe25", SqlDbType.Int).Value = TextBox636.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox637.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3ma", SqlDbType.Int).Value = TextBox638.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma0_9", SqlDbType.Int).Value = TextBox639.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma10_14", SqlDbType.Int).Value = TextBox640.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma15_19", SqlDbType.Int).Value = TextBox641.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma20_24", SqlDbType.Int).Value = TextBox642.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma25", SqlDbType.Int).Value = TextBox643.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3fe", SqlDbType.Int).Value = TextBox644.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe0_9", SqlDbType.Int).Value = TextBox645.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe10_14", SqlDbType.Int).Value = TextBox646.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe15_19", SqlDbType.Int).Value = TextBox647.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe20_24", SqlDbType.Int).Value = TextBox648.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe25", SqlDbType.Int).Value = TextBox649.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox650.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4ma", SqlDbType.Int).Value = TextBox651.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma0_9", SqlDbType.Int).Value = TextBox652.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma10_14", SqlDbType.Int).Value = TextBox653.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma15_19", SqlDbType.Int).Value = TextBox654.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma20_24", SqlDbType.Int).Value = TextBox655.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma25", SqlDbType.Int).Value = TextBox656.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4fe", SqlDbType.Int).Value = TextBox657.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe0_9", SqlDbType.Int).Value = TextBox658.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe10_14", SqlDbType.Int).Value = TextBox659.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe15_19", SqlDbType.Int).Value = TextBox660.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe20_24", SqlDbType.Int).Value = TextBox661.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe25", SqlDbType.Int).Value = TextBox662.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox663.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma", SqlDbType.Int).Value = TextBox664.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe", SqlDbType.Int).Value = TextBox665.Text.Trim();
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "' Successful");
                        return;
                    }
                    GENDNORM_CLS();
                    lblThematic.Visible = false;
                }
                catch (Exception ex)
                {
                    webMessage.Show(ex.Message.ToString() + "' Successful ");
                    return;
                }
                finally
                {
                    cn.Close();
                }

            }
            else
            {
                //============ Insert Level 1 =========
                string sql = "INSERT INTO tbl_GENDNORM (states,lga,facname,months,years,grouptype,TOTALG1,SUBG1MA,G1MA0_9,G1MA10_14,G1MA15_19,G1MA20_24,";
                sql += "G1MA25,	SUBG1FE,G1FE0_9,G1FE10_14,G1FE15_19,G1FE20_24,G1FE25,G1_1,G1_2,	G1_3,TOTALG2,SUBG2MA,G2MA0_9,G2MA10_14,	G2MA15_19,";
                sql += "G2MA20_24,G2MA25,SUBG2FE,G2FE0_9,G2FE10_14,	G2FE15_19,G2FE20_24,G2FE25,	TOTALG3,SUBG3MA,G3MA0_9,G3MA10_14,G3MA15_19,G3MA20_24,";
                sql += "G3MA25,SUBG3FE,G3FE0_9,G3FE10_14,G3FE15_19,G3FE20_24,G3FE25,TOTALG4,SUBG4MA,G4MA0_9,G4MA10_14,G4MA15_19,G4MA20_24,G4MA25,";
                sql += " SUBG4FE,G4FE0_9,G4FE10_14,G4FE15_19,G4FE20_24,G4FE25,TOTALG5,G5MA,G5FE) Values (@states,@lga,@facname,@months,@years,@grouptype,";
                sql += "@TOTALG1,@SUBG1MA,@G1MA0_9,@G1MA10_14,@G1MA15_19,@G1MA20_24,@G1MA25,@SUBG1FE,@G1FE0_9,@G1FE10_14,@G1FE15_19,@G1FE20_24,@G1FE25,@G1_1,@G1_2,";
                sql += "@G1_3,@TOTALG2,@SUBG2MA,@G2MA0_9,@G2MA10_14,	@G2MA15_19,@G2MA20_24,@G2MA25,@SUBG2FE,@G2FE0_9,@G2FE10_14,	@G2FE15_19,@G2FE20_24,@G2FE25,	";
                sql += "@TOTALG3,@SUBG3MA,@G3MA0_9,@G3MA10_14,@G3MA15_19,@G3MA20_24,@G3MA25,@SUBG3FE,@G3FE0_9,@G3FE10_14,@G3FE15_19,@G3FE20_24,@G3FE25,@TOTALG4,";
                sql += "@SUBG4MA,@G4MA0_9,@G4MA10_14,@G4MA15_19,@G4MA20_24,@G4MA25,  @SUBG4FE,@G4FE0_9,@G4FE10_14,@G4FE15_19,@G4FE20_24,@G4FE25,@TOTALG5,@G5MA,@G5FE)";


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

                    cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox609.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1ma", SqlDbType.Int).Value = TextBox610.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma0_9", SqlDbType.Int).Value = TextBox611.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma10_14", SqlDbType.Int).Value = TextBox612.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma15_19", SqlDbType.Int).Value = TextBox613.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma20_24", SqlDbType.Int).Value = TextBox614.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma25", SqlDbType.Int).Value = TextBox615.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1fe", SqlDbType.Int).Value = TextBox616.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe0_9", SqlDbType.Int).Value = TextBox617.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe10_14", SqlDbType.Int).Value = TextBox618.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe15_19", SqlDbType.Int).Value = TextBox619.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe20_24", SqlDbType.Int).Value = TextBox620.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe25", SqlDbType.Int).Value = TextBox621.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1_1", SqlDbType.Int).Value = TextBox622.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1_2", SqlDbType.Int).Value = TextBox623.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1_3", SqlDbType.Int).Value = TextBox624.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox625.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2ma", SqlDbType.Int).Value = TextBox626.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma0_9", SqlDbType.Int).Value = TextBox627.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma10_14", SqlDbType.Int).Value = TextBox628.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma15_19", SqlDbType.Int).Value = TextBox629.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma20_24", SqlDbType.Int).Value = TextBox630.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma25", SqlDbType.Int).Value = TextBox631.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2fe", SqlDbType.Int).Value = TextBox632.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe0_9", SqlDbType.Int).Value = TextBox633.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe10_14", SqlDbType.Int).Value = TextBox634.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe15_19", SqlDbType.Int).Value = TextBox635.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe20_24", SqlDbType.Int).Value = TextBox666.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe25", SqlDbType.Int).Value = TextBox636.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox637.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3ma", SqlDbType.Int).Value = TextBox638.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma0_9", SqlDbType.Int).Value = TextBox639.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma10_14", SqlDbType.Int).Value = TextBox640.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma15_19", SqlDbType.Int).Value = TextBox641.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma20_24", SqlDbType.Int).Value = TextBox642.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma25", SqlDbType.Int).Value = TextBox643.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3fe", SqlDbType.Int).Value = TextBox644.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe0_9", SqlDbType.Int).Value = TextBox645.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe10_14", SqlDbType.Int).Value = TextBox646.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe15_19", SqlDbType.Int).Value = TextBox647.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe20_24", SqlDbType.Int).Value = TextBox648.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe25", SqlDbType.Int).Value = TextBox649.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox650.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4ma", SqlDbType.Int).Value = TextBox651.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma0_9", SqlDbType.Int).Value = TextBox652.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma10_14", SqlDbType.Int).Value = TextBox653.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma15_19", SqlDbType.Int).Value = TextBox654.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma20_24", SqlDbType.Int).Value = TextBox655.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma25", SqlDbType.Int).Value = TextBox656.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4fe", SqlDbType.Int).Value = TextBox657.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe0_9", SqlDbType.Int).Value = TextBox658.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe10_14", SqlDbType.Int).Value = TextBox659.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe15_19", SqlDbType.Int).Value = TextBox660.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe20_24", SqlDbType.Int).Value = TextBox661.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe25", SqlDbType.Int).Value = TextBox662.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox663.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma", SqlDbType.Int).Value = TextBox664.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe", SqlDbType.Int).Value = TextBox665.Text.Trim();
                    int Rowsaffected = cmd.ExecuteNonQuery();
                    if (Rowsaffected != -1)
                    {
                        webMessage.Show(Rowsaffected.ToString() + "' Successful");
                        return;
                    }
                    GENDNORM_CLS();
                    lblThematic.Visible = false;
                }
                catch (Exception ex)
                {
                    webMessage.Show(ex.Message.ToString() + "' Successful ");
                    return;
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        
    }

   

    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {

        try
        {
 
            if (!string.IsNullOrEmpty(Session["mChoose"] as string))
            {
                mChoose = Session["mchoose"].ToString();
                if (mChoose == "PMTCT")
                {
                    SAVE_PMTCT(mChoose);
                }
                
                if (mChoose == "HIVI")
                {
                    SAVE_HIVI();
                    
                }
                if (mChoose == "ART")
                {

                }
               
                if (mChoose == "CARE")
                {

                }
                if (mChoose == "GN")
                {
                    SAVE_GN();
                }
                if (mChoose == "OVC")
                {

                }
                if (mChoose == "PEP")
                {

                }
                if (mChoose == "PP")
                {

                }
                if (mChoose == "TB")
                {

                }
                if (mChoose == "TRAINING")
                {
                    Save_Training();
                }
            }
            MultiView1.Visible = false;
            mChoose = string.Empty;
        }
        catch (Exception ex)
        {
           webMessage.Show(ex.Message.ToString() );
            return;
        }
    } // end of save button
    
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {
        TextBox80.Text = (Convert.ToInt32(TextBox6.Text) + Convert.ToInt32(TextBox7.Text) + Convert.ToInt32(TextBox8.Text)
                         + Convert.ToInt32(TextBox9.Text) + Convert.ToInt32(TextBox10.Text)).ToString();
        TextBox11.Focus();
       
    }

    protected void TextBox15_TextChanged(object sender, EventArgs e)
    {
        TextBox132.Text = (Convert.ToInt32(TextBox11.Text) + Convert.ToInt32(TextBox12.Text) + Convert.ToInt32(TextBox13.Text)
                         + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text)).ToString();
       
        TextBox17.Focus();
       
    }
    protected void TextBox21_TextChanged(object sender, EventArgs e)
    {
        TextBox133.Text = (Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox19.Text)
                         + Convert.ToInt32(TextBox20.Text) + Convert.ToInt32(TextBox21.Text)).ToString();
        TextBox22.Focus();
    }
    protected void TextBox26_TextChanged(object sender, EventArgs e)
    {
        TextBox134.Text = (Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox24.Text)
                        + Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox26.Text)).ToString();
        TextBox28.Focus();
    }
    protected void TextBox32_TextChanged(object sender, EventArgs e)
    {
        TextBox27.Text = (Convert.ToInt32(TextBox28.Text) + Convert.ToInt32(TextBox29.Text) + Convert.ToInt32(TextBox30.Text)
                       + Convert.ToInt32(TextBox31.Text) + Convert.ToInt32(TextBox32.Text)).ToString();
        TextBox33.Focus();
    }
    protected void TextBox37_TextChanged(object sender, EventArgs e)
    {
        TextBox135.Text = (Convert.ToInt32(TextBox33.Text) + Convert.ToInt32(TextBox34.Text) + Convert.ToInt32(TextBox35.Text)
                      + Convert.ToInt32(TextBox36.Text) + Convert.ToInt32(TextBox37.Text)).ToString();
        TextBox16.Text = (Convert.ToInt32(TextBox133.Text) + Convert.ToInt32(TextBox134.Text) + Convert.ToInt32(TextBox27.Text) 
                      + Convert.ToInt32(TextBox135.Text)).ToString();

        TextBox476.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + Convert.ToInt32(TextBox26.Text) + Convert.ToInt32(TextBox32.Text) +
       Convert.ToInt32(TextBox37.Text));
       
        TextBox43.Focus();
    }
    protected void TextBox67_TextChanged(object sender, EventArgs e)
    {
        TextBox584.Text = (Convert.ToInt32(TextBox63.Text) + Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox65.Text)
                     + Convert.ToInt32(TextBox66.Text) + Convert.ToInt32(TextBox67.Text)).ToString();
        TextBox68.Focus();
    }
    protected void TextBox72_TextChanged(object sender, EventArgs e)
    {
        TextBox585.Text = (Convert.ToInt32(TextBox68.Text) + Convert.ToInt32(TextBox69.Text) + Convert.ToInt32(TextBox70.Text)
                     + Convert.ToInt32(TextBox71.Text) + Convert.ToInt32(TextBox72.Text)).ToString();
        TextBox73.Focus();
    }
    protected void TextBox77_TextChanged(object sender, EventArgs e)
    {
        TextBox586.Text = (Convert.ToInt32(TextBox73.Text) + Convert.ToInt32(TextBox74.Text) + Convert.ToInt32(TextBox75.Text)
                     + Convert.ToInt32(TextBox76.Text) + Convert.ToInt32(TextBox77.Text)).ToString();
        //=========== Total Number of pregnant women tested Hiv -ve ============================
        TextBox583.Text = Convert.ToString(Convert.ToInt32(TextBox584.Text)+Convert.ToInt32(TextBox585.Text)+Convert.ToInt32(TextBox586.Text));
       //========== Total <15 ============
        TextBox58.Text = Convert.ToString(Convert.ToInt32(TextBox63.Text)+Convert.ToInt32(TextBox68.Text)+Convert.ToInt32(TextBox73.Text));
        //======== Total 15 - 19 =========
        TextBox59.Text = Convert.ToString(Convert.ToInt32(TextBox64.Text)+Convert.ToInt32(TextBox69.Text)+Convert.ToInt32(TextBox74.Text));
        //======= Total 20-24 ========
        TextBox60.Text = Convert.ToString(Convert.ToInt32(TextBox65.Text)+Convert.ToInt32(TextBox70.Text)+Convert.ToInt32(TextBox75.Text));
        //====== Total 25 - 49 =====
        TextBox61.Text = Convert.ToString(Convert.ToInt32(TextBox66.Text)+Convert.ToInt32(TextBox71.Text)+Convert.ToInt32(TextBox76.Text));
        //====== Total 50+ ========
        TextBox62.Text = Convert.ToString(Convert.ToInt32(TextBox67.Text)+Convert.ToInt32(TextBox72.Text)+Convert.ToInt32(TextBox77.Text));
        TextBox78.Focus();
    }
    protected void TextBox62_TextChanged(object sender, EventArgs e)
    {
        TextBox583.Text = Convert.ToString(Convert.ToInt32(TextBox58.Text )+Convert.ToInt32(TextBox59.Text)+Convert.ToInt32(TextBox60.Text)
                      +Convert.ToInt32(TextBox61.Text)+Convert.ToInt32(TextBox62.Text));
       
    }

    protected void TextBox47_TextChanged(object sender, EventArgs e)
    {
        TextBox137.Text = Convert.ToString(Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox44.Text) + Convert.ToInt32(TextBox45.Text)
                      + Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox47.Text));
        TextBox48.Focus();
    }

    protected void TextBox57_TextChanged(object sender, EventArgs e)
    {
        TextBox582.Text = Convert.ToString(Convert.ToInt32(TextBox53.Text) + Convert.ToInt32(TextBox54.Text) + Convert.ToInt32(TextBox55.Text)
                      + Convert.ToInt32(TextBox56.Text) + Convert.ToInt32(TextBox57.Text));

        //=========== Total No. Pregnant Women who tested +tiv to HIV==============
        TextBox136.Text = Convert.ToString(Convert.ToInt32(TextBox137.Text )+Convert.ToInt32(TextBox581.Text)+Convert.ToInt32(TextBox582.Text ));
        //========== Total <15 ============
        TextBox38.Text = Convert.ToString(Convert.ToInt32(TextBox48.Text) + Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox53.Text));
        //======== Total 15 - 19 =========
        TextBox39.Text = Convert.ToString(Convert.ToInt32(TextBox44.Text) + Convert.ToInt32(TextBox49.Text) + Convert.ToInt32(TextBox54.Text));
        //======= Total 20-24 ========
        TextBox40.Text = Convert.ToString(Convert.ToInt32(TextBox45.Text) + Convert.ToInt32(TextBox50.Text) + Convert.ToInt32(TextBox55.Text));
        //====== Total 25 - 49 =====
        TextBox41.Text = Convert.ToString(Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox56.Text));
        //====== Total 50+ ========
        TextBox42.Text = Convert.ToString(Convert.ToInt32(TextBox47.Text) + Convert.ToInt32(TextBox52.Text) + Convert.ToInt32(TextBox57.Text));
        TextBox63.Focus();
    }
    //protected void TextBox98_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox87.Text = Convert.ToString(Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text) + Convert.ToInt32(TextBox90.Text) 
    //                    + Convert.ToInt32(TextBox91.Text)+Convert.ToInt32(TextBox274.Text )+Convert.ToInt32(TextBox275.Text)+Convert.ToInt32(TextBox276.Text)
    //                    +Convert.ToInt32(TextBox277.Text)+Convert.ToInt32(TextBox278.Text)+Convert.ToInt32(TextBox279.Text)+Convert.ToInt32(TextBox280.Text)
    //                    +Convert.ToInt32(TextBox281.Text)+Convert.ToInt32(TextBox282.Text)+Convert.ToInt32(TextBox283.Text)+Convert.ToInt32(TextBox92.Text)
    //                    +Convert.ToInt32(TextBox93.Text)+Convert.ToInt32(TextBox94.Text)+Convert.ToInt32(TextBox273.Text)+Convert.ToInt32(TextBox95.Text)
    //                    +Convert.ToInt32(TextBox96.Text )+Convert.ToInt32(TextBox97.Text)+Convert.ToInt32(TextBox98.Text));
    //    TextBox100.Focus();
    //}

   
    protected void TextBox106_TextChanged(object sender, EventArgs e)
    {
        TextBox99.Text = Convert.ToString(Convert.ToInt32(TextBox100.Text) + Convert.ToInt32(TextBox101.Text) + Convert.ToInt32(TextBox102.Text) + Convert.ToInt32(TextBox103.Text)
                                + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox105.Text) + Convert.ToInt32(TextBox106.Text));
        TextBox108.Focus();
    }
    protected void TextBox109_TextChanged(object sender, EventArgs e)
    {
        TextBox107.Text = Convert.ToString(Convert.ToInt32(TextBox108.Text)+Convert.ToInt32(TextBox109.Text));
        TextBox269.Focus();
    }
    //protected void TextBox587_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox110.Text = Convert.ToString(Convert.ToInt32( TextBox269.Text)+Convert.ToInt32(TextBox587.Text));
    //    TextBox111.Focus();
    //}
    //protected void TextBox271_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox113.Text = Convert.ToString(Convert.ToInt32(TextBox114.Text)+Convert.ToInt32(TextBox115.Text)+Convert.ToInt32(TextBox116.Text)+Convert.ToInt32(TextBox117.Text)
    //                      +Convert.ToInt32(TextBox118.Text)+Convert.ToInt32(TextBox119.Text)+Convert.ToInt32(TextBox271.Text));
    //        TextBox122.Focus();
    //}
    protected void TextBox131_TextChanged(object sender, EventArgs e)
    {
        TextBox272.Text = Convert.ToString(Convert.ToInt32( TextBox122.Text)+Convert.ToInt32(TextBox123.Text)+Convert.ToInt32(TextBox124.Text)+Convert.ToInt32(TextBox125.Text)
                          + Convert.ToInt32(TextBox126.Text)+ Convert.ToInt32(TextBox127.Text)+Convert.ToInt32(TextBox128.Text)+Convert.ToInt32(TextBox129.Text)
                          + Convert.ToInt32(TextBox130.Text)+Convert.ToInt32(TextBox131.Text));
        TextBox121.Focus();
    }
    protected void TextBox120_TextChanged(object sender, EventArgs e)
    {
        TextBox580.Text = Convert.ToString(Convert.ToInt32(TextBox121.Text)+Convert.ToInt32(TextBox120.Text));
        btnSave.Focus();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //MultiView1.ActiveViewIndex = 0;
        
         mChoose = Session["choose"].ToString();
        if (mChoose == "PMTCT")
        {
            PMTCT_CLS();
            
        }
        if (mChoose == "HTC")
        {
            
        }
        if (mChoose == "HIVI")
        {

        }
        if (mChoose == "ART")
        {

        }
        if (mChoose == "LAB")
        {

        }
        if (mChoose == "CARE")
        {

        }
        if (mChoose == "GN")
        {
            GENDNORM_CLS();
        }
        if (mChoose == "OVC")
        {

        }
        if (mChoose == "PEP")
        {

        }
        if (mChoose == "PP")
        {

        }
        if (mChoose == "TB")
        {

        }
        if (mChoose == "TRAINING")
        {
            TRAINING_CLS();
        }
        mChoose = string.Empty;
        MultiView1.Visible = false;

    }// end of cls


    protected void TextBox590_TextChanged(object sender, EventArgs e)
    {
        TextBox588.Text = Convert.ToString(Convert.ToInt32(TextBox589.Text)+Convert.ToInt32(TextBox590.Text));
        TextBox592.Focus();
    }
    protected void TextBox593_TextChanged(object sender, EventArgs e)
    {
        TextBox591.Text = Convert.ToString(Convert.ToInt32(TextBox592.Text) + Convert.ToInt32(TextBox593.Text));
        TextBox595.Focus();
    }
    protected void TextBox596_TextChanged(object sender, EventArgs e)
    {
        TextBox594.Text = Convert.ToString(Convert.ToInt32(TextBox595.Text) + Convert.ToInt32(TextBox596.Text));
        TextBox598.Focus();
    }
    protected void TextBox599_TextChanged(object sender, EventArgs e)
    {
        TextBox597.Text = Convert.ToString(Convert.ToInt32(TextBox598.Text) + Convert.ToInt32(TextBox599.Text));
        TextBox601.Focus();
    }
    protected void TextBox602_TextChanged(object sender, EventArgs e)
    {
        TextBox600.Text = Convert.ToString(Convert.ToInt32(TextBox601.Text) + Convert.ToInt32(TextBox602.Text));
        TextBox604.Focus();
    }
    protected void TextBox605_TextChanged(object sender, EventArgs e)
    {
        TextBox603.Text = Convert.ToString(Convert.ToInt32(TextBox604.Text) + Convert.ToInt32(TextBox605.Text));
        btnSave.Focus();
    }
//=================================== End of HIVI ===============================================
    protected void TextBox139_TextChanged(object sender, EventArgs e)
    {
        TextBox606.Text = Convert.ToString(Convert.ToInt32(TextBox138.Text) + Convert.ToInt32(TextBox139.Text));
        TextBox141.Focus();
    }
    protected void TextBox142_TextChanged(object sender, EventArgs e)
    {
        TextBox140.Text = Convert.ToString(Convert.ToInt32(TextBox141.Text) + Convert.ToInt32(TextBox142.Text));
        TextBox144.Focus();
    }
    protected void TextBox145_TextChanged(object sender, EventArgs e)
    {
        TextBox143.Text = Convert.ToString(Convert.ToInt32(TextBox144.Text) + Convert.ToInt32(TextBox145.Text));
        TextBox146.Focus();
    }
    protected void TextBox147_TextChanged(object sender, EventArgs e)
    {
        TextBox607.Text = Convert.ToString(Convert.ToInt32(TextBox146.Text) + Convert.ToInt32(TextBox147.Text));
        TextBox149.Focus();
    }
    protected void TextBox150_TextChanged(object sender, EventArgs e)
    {
        TextBox148.Text = Convert.ToString(Convert.ToInt32(TextBox149.Text) + Convert.ToInt32(TextBox150.Text));
        TextBox152.Focus();
    }
    protected void TextBox153_TextChanged(object sender, EventArgs e)
    {
        TextBox151.Text = Convert.ToString(Convert.ToInt32(TextBox152.Text) + Convert.ToInt32(TextBox153.Text));
        btnSave.Focus();
    }
    protected void TextBox615_TextChanged(object sender, EventArgs e)
    {
        TextBox610.Text = Convert.ToString(Convert.ToInt32(TextBox611.Text) + Convert.ToInt32(TextBox612.Text)
                  + Convert.ToInt32(TextBox613.Text) + Convert.ToInt32(TextBox614.Text)+Convert.ToInt32(TextBox615.Text));
        TextBox617.Focus();
    }
    protected void TextBox621_TextChanged(object sender, EventArgs e)
    {
        TextBox616.Text = Convert.ToString(Convert.ToInt32(TextBox617.Text) + Convert.ToInt32(TextBox618.Text)
                  + Convert.ToInt32(TextBox619.Text) + Convert.ToInt32(TextBox620.Text) + Convert.ToInt32(TextBox621.Text));
        TextBox609.Text = Convert.ToString(Convert.ToInt32(TextBox610.Text)+Convert.ToInt32(TextBox616.Text));
        TextBox622.Focus();
    }
    protected void TextBox631_TextChanged(object sender, EventArgs e)
    {
        TextBox626.Text  = Convert.ToString(Convert.ToInt32(TextBox627.Text) + Convert.ToInt32(TextBox628.Text) 
                         + Convert.ToInt32(TextBox629.Text) + Convert.ToInt32(TextBox630.Text) + Convert.ToInt32(TextBox631.Text));
        TextBox633.Focus();
    }
    protected void TextBox636_TextChanged(object sender, EventArgs e)
    {
        TextBox632.Text = Convert.ToString(Convert.ToInt32(TextBox633.Text)+Convert.ToInt32(TextBox634.Text)
                          +Convert.ToInt32(TextBox635.Text)+Convert.ToInt32(TextBox666.Text)+Convert.ToInt32(TextBox636.Text));
        TextBox625.Text = Convert.ToString(Convert.ToInt32(TextBox626.Text) + Convert.ToInt32(TextBox632.Text));
    }
    protected void TextBox643_TextChanged(object sender, EventArgs e)
    {
        TextBox638.Text = Convert.ToString(Convert.ToInt32(TextBox639.Text)+Convert.ToInt32(TextBox640.Text)
                         +Convert.ToInt32(TextBox641.Text)+Convert.ToInt32(TextBox642.Text)+Convert.ToInt32(TextBox643.Text));
        TextBox645.Focus();
    }
    protected void TextBox649_TextChanged(object sender, EventArgs e)
    {
        TextBox644.Text = Convert.ToString(Convert.ToInt32(TextBox645.Text)+Convert.ToInt32(TextBox646.Text)
                        +Convert.ToInt32(TextBox647.Text)+Convert.ToInt32(TextBox648.Text)+Convert.ToInt32(TextBox649.Text));
        TextBox637.Text = Convert.ToString(Convert.ToInt32(TextBox638.Text)+Convert.ToInt32(TextBox644.Text));
        TextBox652.Focus();
    }

    protected void TextBox656_TextChanged(object sender, EventArgs e)
    {
        TextBox651.Text = Convert.ToString(Convert.ToInt32(TextBox652.Text)+Convert.ToInt32(TextBox653.Text)
                        +Convert.ToInt32(TextBox654.Text)+Convert.ToInt32(TextBox655.Text)+Convert.ToInt32(TextBox656.Text));
        TextBox658.Focus();
    }
    protected void TextBox662_TextChanged(object sender, EventArgs e)
    {
        TextBox657.Text = Convert.ToString(Convert.ToInt32(TextBox658.Text) + Convert.ToInt32(TextBox659.Text)
                        +Convert.ToInt32(TextBox660.Text)+Convert.ToInt32(TextBox661.Text)+Convert.ToInt32(TextBox662.Text));
        TextBox650.Text = Convert.ToString(Convert.ToInt32(TextBox651.Text) + Convert.ToInt32(TextBox657.Text));
        TextBox664.Focus();
    }
    protected void TextBox665_TextChanged(object sender, EventArgs e)
    {
        TextBox663.Text=Convert.ToString(Convert.ToInt32(TextBox664.Text)+Convert.ToInt32(TextBox665.Text));
        btnSave.Focus();
    }
    protected void TextBox670_TextChanged(object sender, EventArgs e)
    {
        //TextBox672.Focus();
    }
    //protected void TextBox672_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox668.Text = Convert.ToString( Convert.ToInt32(TextBox670.Text)+ Convert.ToInt32(TextBox672.Text));
    //    TextBox671.Focus();
    //}
    //protected void TextBox671_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox673.Focus();
    //}
    //protected void TextBox673_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox669.Text = Convert.ToString( Convert.ToInt32(TextBox671.Text) + Convert.ToInt32(TextBox673.Text));
    //    TextBox667.Text = Convert.ToString( Convert.ToInt32(TextBox668.Text) + Convert.ToInt32(TextBox669.Text));
    //   TextBox453.Focus();
    //}
    ////protected void TextBox681_TextChanged(object sender, EventArgs e)
    ////{
    ////    TextBox441.Text = Convert.ToString( Convert.ToInt32(TextBox674.Text) + Convert.ToInt32(TextBox675.Text)+Convert.ToInt32(TextBox676.Text) + Convert.ToInt32(TextBox677.Text)
    ////                     + Convert.ToInt32(TextBox678.Text) + Convert.ToInt32(TextBox679.Text) + Convert.ToInt32(TextBox680.Text) + Convert.ToInt32(TextBox681.Text));
    ////    TextBox682.Focus();
    ////}
    ////protected void TextBox157_TextChanged(object sender, EventArgs e)
    ////{
    ////    TextBox443.Text = Convert.ToString( Convert.ToInt32(TextBox682.Text) + Convert.ToInt32(TextBox683.Text)+ Convert.ToInt32(TextBox684.Text)+ Convert.ToInt32(TextBox685.Text)
    ////                     + Convert.ToInt32(TextBox154.Text)+ Convert.ToInt32(TextBox155.Text)+ Convert.ToInt32(TextBox156.Text)+ Convert.ToInt32(TextBox157.Text));
    ////    TextBox442.Text = Convert.ToString(Convert.ToInt32(TextBox441.Text) + Convert.ToInt32(TextBox443.Text));
    ////    TextBox160.Focus();
    ////}
    //protected void TextBox167_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox159.Text = Convert.ToString( Convert.ToInt32(TextBox160.Text)+Convert.ToInt32(TextBox161.Text)+Convert.ToInt32(TextBox162.Text)+ Convert.ToInt32(TextBox163.Text)
    //                      + Convert.ToInt32(TextBox164.Text)+ Convert.ToInt32(TextBox165.Text)+ Convert.ToInt32(TextBox166.Text)+Convert.ToInt32(TextBox167.Text));
    //    TextBox169.Focus();
    //}
    //protected void TextBox176_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox168.Text = Convert.ToString(Convert.ToInt32(TextBox169.Text) + Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text) + Convert.ToInt32(TextBox172.Text)
    //                      + Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text) + Convert.ToInt32(TextBox176.Text));
    //    TextBox158.Text = Convert.ToString(Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox168.Text));
    //    TextBox179.Focus();
    //}
    //protected void TextBox186_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox178.Text = Convert.ToString(Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text) + Convert.ToInt32(TextBox180.Text)+ Convert.ToInt32(TextBox181.Text)
    //                   + Convert.ToInt32(TextBox182.Text)+ Convert.ToInt32(TextBox183.Text)+ Convert.ToInt32(TextBox184.Text)+ Convert.ToInt32(TextBox185.Text)
    //                   + Convert.ToInt32(TextBox186.Text));
    //    TextBox188.Focus();
    //}
    //protected void TextBox195_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox187.Text = Convert.ToString( Convert.ToInt32(TextBox188.Text)+ Convert.ToInt32(TextBox189.Text)+ Convert.ToInt32(TextBox190.Text)+ Convert.ToInt32(TextBox191.Text)
    //                     + Convert.ToInt32(TextBox192.Text)+ Convert.ToInt32(TextBox193.Text)+ Convert.ToInt32(TextBox194.Text)+ Convert.ToInt32(TextBox195.Text));
    //    TextBox177.Text = Convert.ToString( Convert.ToInt32(TextBox178.Text)+ Convert.ToInt32(TextBox187.Text));
    //    TextBox198.Focus();
    //}
    //protected void TextBox205_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox197.Text = Convert.ToString(Convert.ToInt32(TextBox198.Text)+ Convert.ToInt32(TextBox199.Text)+Convert.ToInt32(TextBox200.Text)+ Convert.ToInt32(TextBox201.Text)
    //                     + Convert.ToInt32(TextBox202.Text)+ Convert.ToInt32(TextBox203.Text)+ Convert.ToInt32(TextBox204.Text)+ Convert.ToInt32(TextBox205.Text));
    //    TextBox207.Focus();
    //}
    //protected void TextBox214_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox206.Text = Convert.ToString(Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text) + Convert.ToInt32(TextBox210.Text)
    //                   + Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text));
    //    TextBox196.Text = Convert.ToString(Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox206.Text));
    //    TextBox217.Focus();
    //}
    //protected void TextBox224_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox216.Text = Convert.ToString(Convert.ToInt32(TextBox217.Text) + Convert.ToInt32(TextBox218.Text) + Convert.ToInt32(TextBox219.Text) + Convert.ToInt32(TextBox220.Text)
    //                 + Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text));
    //    TextBox226.Focus();
    //}
    //protected void TextBox233_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox225.Text = Convert.ToString(Convert.ToInt32(TextBox226.Text) + Convert.ToInt32(TextBox227.Text) + Convert.ToInt32(TextBox228.Text) + Convert.ToInt32(TextBox229.Text)
    //                 + Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox231.Text) + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text));
    //    TextBox215.Text = Convert.ToString(Convert.ToInt32(TextBox216.Text) + Convert.ToInt32(TextBox225.Text));
    //    TextBox236.Focus();
    //}
    //protected void TextBox439_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox235.Text = Convert.ToString(Convert.ToInt32(TextBox236.Text) + Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox238.Text) + Convert.ToInt32(TextBox240.Text)
    //                 + Convert.ToInt32(TextBox241.Text) + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text) + Convert.ToInt32(TextBox439.Text));
    //    TextBox245.Focus();
    //}
    //protected void TextBox440_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox244.Text = Convert.ToString(Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox248.Text) + Convert.ToInt32(TextBox249.Text)
    //                + Convert.ToInt32(TextBox250.Text) + Convert.ToInt32(TextBox251.Text) + Convert.ToInt32(TextBox252.Text) + Convert.ToInt32(TextBox440.Text));
    //    TextBox234.Text = Convert.ToString(Convert.ToInt32(TextBox235.Text) + Convert.ToInt32(TextBox244.Text));
    //    TextBox255.Focus();
    //}
    //protected void TextBox262_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox254.Text = Convert.ToString(Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox256.Text) + Convert.ToInt32(TextBox257.Text) + Convert.ToInt32(TextBox258.Text)
    //                        + Convert.ToInt32(TextBox259.Text) + Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text));
    //    TextBox264.Focus();
    //}
    //protected void TextBox286_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox263.Text = Convert.ToString(Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text) + Convert.ToInt32(TextBox267.Text)
    //                       + Convert.ToInt32(TextBox268.Text) + Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text) + Convert.ToInt32(TextBox286.Text));
    //    TextBox253.Text = Convert.ToString(Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox263.Text));
    //    TextBox289.Focus();
    //}
    //protected void TextBox305_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox297.Text = Convert.ToString(Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text) + Convert.ToInt32(TextBox300.Text) + Convert.ToInt32(TextBox301.Text)
    //                       + Convert.ToInt32(TextBox302.Text) + Convert.ToInt32(TextBox303.Text) + Convert.ToInt32(TextBox304.Text) + Convert.ToInt32(TextBox305.Text));
    //    TextBox287.Text = Convert.ToString(Convert.ToInt32(TextBox288.Text) + Convert.ToInt32(TextBox297.Text));
    //    TextBox308.Focus();
    //}
    //protected void TextBox296_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox288.Text = Convert.ToString(Convert.ToInt32(TextBox289.Text) + Convert.ToInt32(TextBox290.Text) + Convert.ToInt32(TextBox291.Text) + Convert.ToInt32(TextBox292.Text)
    //                        + Convert.ToInt32(TextBox293.Text) + Convert.ToInt32(TextBox294.Text) + Convert.ToInt32(TextBox296.Text) + Convert.ToInt32(TextBox296.Text));
    //    TextBox298.Focus();
    //}
    //protected void TextBox444_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox307.Text = Convert.ToString(Convert.ToInt32(TextBox308.Text) + Convert.ToInt32(TextBox309.Text) + Convert.ToInt32(TextBox310.Text) + Convert.ToInt32(TextBox311.Text)
    //                        + Convert.ToInt32(TextBox312.Text) + Convert.ToInt32(TextBox314.Text) + Convert.ToInt32(TextBox315.Text) + Convert.ToInt32(TextBox444.Text));
    //    TextBox317.Focus(); 
    //}
    //protected void TextBox324_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox316.Text = Convert.ToString(Convert.ToInt32(TextBox317.Text) + Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox320.Text)
    //                       + Convert.ToInt32(TextBox321.Text) + Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text) + Convert.ToInt32(TextBox324.Text));
    //    TextBox306.Text = Convert.ToString(Convert.ToInt32(TextBox307.Text) + Convert.ToInt32(TextBox316.Text));
    //    TextBox327.Focus();
    //}
    //protected void TextBox334_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox326.Text = Convert.ToString(Convert.ToInt32(TextBox327.Text) + Convert.ToInt32(TextBox328.Text) + Convert.ToInt32(TextBox329.Text) + Convert.ToInt32(TextBox330.Text)
    //                        + Convert.ToInt32(TextBox331.Text) + Convert.ToInt32(TextBox332.Text) + Convert.ToInt32(TextBox333.Text) + Convert.ToInt32(TextBox334.Text));
    //    TextBox336.Focus(); 
    //}
    //protected void TextBox343_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox335.Text = Convert.ToString(Convert.ToInt32(TextBox336.Text) + Convert.ToInt32(TextBox337.Text) + Convert.ToInt32(TextBox338.Text) + Convert.ToInt32(TextBox339.Text)
    //                      + Convert.ToInt32(TextBox340.Text) + Convert.ToInt32(TextBox341.Text) + Convert.ToInt32(TextBox342.Text) + Convert.ToInt32(TextBox343.Text));
    //    TextBox325.Text = Convert.ToString(Convert.ToInt32(TextBox326.Text) + Convert.ToInt32(TextBox335.Text));
    //    TextBox346.Focus();
    //}
    //protected void TextBox353_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox345.Text = Convert.ToString(Convert.ToInt32(TextBox346.Text) + Convert.ToInt32(TextBox347.Text) + Convert.ToInt32(TextBox348.Text) + Convert.ToInt32(TextBox349.Text)
    //                        + Convert.ToInt32(TextBox350.Text) + Convert.ToInt32(TextBox351.Text) + Convert.ToInt32(TextBox352.Text) + Convert.ToInt32(TextBox353.Text));
    //    TextBox355.Focus(); 
    //}
    //protected void TextBox362_TextChanged(object sender, EventArgs e)
    //{ 
    //    TextBox354.Text = Convert.ToString(Convert.ToInt32(TextBox355.Text) + Convert.ToInt32(TextBox356.Text) + Convert.ToInt32(TextBox357.Text) + Convert.ToInt32(TextBox358.Text)
    //                      + Convert.ToInt32(TextBox359.Text) + Convert.ToInt32(TextBox360.Text) + Convert.ToInt32(TextBox361.Text) + Convert.ToInt32(TextBox362.Text));
    //    TextBox344.Text = Convert.ToString(Convert.ToInt32(TextBox345.Text) + Convert.ToInt32(TextBox354.Text));
    //    TextBox365.Focus();
    //}
    //protected void TextBox372_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox364.Text = Convert.ToString(Convert.ToInt32(TextBox365.Text) + Convert.ToInt32(TextBox366.Text) + Convert.ToInt32(TextBox367.Text) + Convert.ToInt32(TextBox368.Text)
    //                        + Convert.ToInt32(TextBox369.Text) + Convert.ToInt32(TextBox370.Text) + Convert.ToInt32(TextBox371.Text) + Convert.ToInt32(TextBox372.Text));
    //    TextBox374.Focus(); 
    //}
    //protected void TextBox381_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox373.Text = Convert.ToString(Convert.ToInt32(TextBox374.Text) + Convert.ToInt32(TextBox375.Text) + Convert.ToInt32(TextBox376.Text) + Convert.ToInt32(TextBox377.Text)
    //                      + Convert.ToInt32(TextBox378.Text) + Convert.ToInt32(TextBox379.Text) + Convert.ToInt32(TextBox380.Text) + Convert.ToInt32(TextBox381.Text));
    //    TextBox363.Text = Convert.ToString(Convert.ToInt32(TextBox364.Text) + Convert.ToInt32(TextBox373.Text));
    //    TextBox384.Focus();
    //}
    //protected void TextBox391_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox383.Text = Convert.ToString(Convert.ToInt32(TextBox384.Text) + Convert.ToInt32(TextBox385.Text) + Convert.ToInt32(TextBox386.Text) + Convert.ToInt32(TextBox387.Text)
    //                        + Convert.ToInt32(TextBox388.Text) + Convert.ToInt32(TextBox389.Text) + Convert.ToInt32(TextBox390.Text) + Convert.ToInt32(TextBox391.Text));
    //    TextBox393.Focus(); 
    //}
    //protected void TextBox400_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox392.Text = Convert.ToString(Convert.ToInt32(TextBox393.Text) + Convert.ToInt32(TextBox394.Text) + Convert.ToInt32(TextBox395.Text) + Convert.ToInt32(TextBox396.Text)
    //                      + Convert.ToInt32(TextBox397.Text) + Convert.ToInt32(TextBox398.Text) + Convert.ToInt32(TextBox399.Text) + Convert.ToInt32(TextBox400.Text));
    //    TextBox382.Text = Convert.ToString(Convert.ToInt32(TextBox383.Text) + Convert.ToInt32(TextBox392.Text));
    //    TextBox403.Focus();
    //}
    //protected void TextBox410_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox402.Text = Convert.ToString(Convert.ToInt32(TextBox403.Text) + Convert.ToInt32(TextBox404.Text) + Convert.ToInt32(TextBox405.Text) + Convert.ToInt32(TextBox406.Text)
    //                       + Convert.ToInt32(TextBox407.Text) + Convert.ToInt32(TextBox408.Text) + Convert.ToInt32(TextBox409.Text) + Convert.ToInt32(TextBox410.Text));
    //    TextBox412.Focus(); 
    //}
    //protected void TextBox419_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox411.Text = Convert.ToString(Convert.ToInt32(TextBox412.Text) + Convert.ToInt32(TextBox413.Text) + Convert.ToInt32(TextBox414.Text) + Convert.ToInt32(TextBox415.Text)
    //                      + Convert.ToInt32(TextBox416.Text) + Convert.ToInt32(TextBox417.Text) + Convert.ToInt32(TextBox418.Text) + Convert.ToInt32(TextBox419.Text));
    //    TextBox401.Text = Convert.ToString(Convert.ToInt32(TextBox402.Text) + Convert.ToInt32(TextBox411.Text));
    //    TextBox422.Focus();
    //}
    //protected void TextBox429_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox421.Text = Convert.ToString(Convert.ToInt32(TextBox422.Text) + Convert.ToInt32(TextBox423.Text) + Convert.ToInt32(TextBox424.Text) + Convert.ToInt32(TextBox425.Text)
    //                     + Convert.ToInt32(TextBox426.Text) + Convert.ToInt32(TextBox427.Text) + Convert.ToInt32(TextBox428.Text) + Convert.ToInt32(TextBox429.Text));
    //    TextBox431.Focus(); 
    //}
    //protected void TextBox438_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox430.Text = Convert.ToString(Convert.ToInt32(TextBox431.Text) + Convert.ToInt32(TextBox432.Text) + Convert.ToInt32(TextBox433.Text) + Convert.ToInt32(TextBox434.Text)
    //                     + Convert.ToInt32(TextBox435.Text) + Convert.ToInt32(TextBox436.Text) + Convert.ToInt32(TextBox437.Text) + Convert.ToInt32(TextBox438.Text));
    //    TextBox420.Text = Convert.ToString(Convert.ToInt32(TextBox421.Text) + Convert.ToInt32(TextBox430.Text));
    //    btnSave.Focus();
    //}


    //protected void TextBox460_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox452.Text = Convert.ToString(Convert.ToInt32(TextBox453.Text) + Convert.ToInt32(TextBox454.Text) + Convert.ToInt32(TextBox455.Text) + Convert.ToInt32(TextBox456.Text)
    //                     + Convert.ToInt32(TextBox457.Text) + Convert.ToInt32(TextBox458.Text) + Convert.ToInt32(TextBox459.Text) + Convert.ToInt32(TextBox460.Text));
    //    TextBox462.Focus(); 
    //}
    //protected void TextBox469_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox461.Text = Convert.ToString(Convert.ToInt32(TextBox462.Text) + Convert.ToInt32(TextBox463.Text) + Convert.ToInt32(TextBox464.Text) + Convert.ToInt32(TextBox465.Text)
    //                    + Convert.ToInt32(TextBox466.Text) + Convert.ToInt32(TextBox467.Text) + Convert.ToInt32(TextBox468.Text) + Convert.ToInt32(TextBox469.Text));
    //    TextBox451.Text = Convert.ToString(Convert.ToInt32(TextBox452.Text) + Convert.ToInt32(TextBox461.Text));
    //    TextBox160.Focus();
    //}

    //protected void TextBox471_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox155.Text = Convert.ToString(Convert.ToInt32(TextBox156.Text) + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox239.Text) + Convert.ToInt32(TextBox247.Text)
    //                   + Convert.ToInt32(TextBox313.Text) + Convert.ToInt32(TextBox441.Text) + Convert.ToInt32(TextBox442.Text) + Convert.ToInt32(TextBox471.Text));
    //    TextBox443.Focus(); 
    //}
    //protected void TextBox472_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox445.Text = Convert.ToString(Convert.ToInt32(TextBox443.Text) + Convert.ToInt32(TextBox446.Text) + Convert.ToInt32(TextBox447.Text) + Convert.ToInt32(TextBox448.Text)
    //                    + Convert.ToInt32(TextBox449.Text) + Convert.ToInt32(TextBox450.Text) + Convert.ToInt32(TextBox470.Text) + Convert.ToInt32(TextBox472.Text));
    //    TextBox154.Text = Convert.ToString(Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox445.Text));
    //    TextBox236.Focus();
    //}
    protected void TextBox42_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox52_TextChanged(object sender, EventArgs e)
    {
        TextBox581.Text = Convert.ToString(Convert.ToInt32(TextBox48.Text) + Convert.ToInt32(TextBox49.Text) + Convert.ToInt32(TextBox50.Text) 
                       + Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox52.Text));
        TextBox53.Focus();
    }
    protected void TextBox86_TextChanged(object sender, EventArgs e)
    {
        TextBox88.Focus();
    }
    protected void TextBox112_TextChanged(object sender, EventArgs e)
    {
        TextBox270.Text = Convert.ToString(Convert.ToInt32(TextBox111.Text) + Convert.ToInt32(TextBox112.Text));
        TextBox114.Focus();
    }
    protected void btnClick1_Click(object sender, EventArgs e)
    {
        TextBox2.Focus();
    }

    protected void btnClick_Click(object sender, EventArgs e)
    {

    }

    protected void btnClick2_Click(object sender, EventArgs e)
    {

    }

    protected void btnClick3_Click(object sender, EventArgs e)
    {

    }

    protected void btnClick4_Click(object sender, EventArgs e)
    {
        //TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text)
        //                      + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
        //TextBox6.Focus();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        TextBox579.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text)
                         + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text)).ToString();
        TextBox6.Focus();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        TextBox80.Text = (Convert.ToInt32(TextBox6.Text) + Convert.ToInt32(TextBox7.Text) + Convert.ToInt32(TextBox8.Text)
                       + Convert.ToInt32(TextBox9.Text) + Convert.ToInt32(TextBox10.Text)).ToString();
        TextBox11.Focus();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        TextBox132.Text = (Convert.ToInt32(TextBox11.Text) + Convert.ToInt32(TextBox12.Text) + Convert.ToInt32(TextBox13.Text)
                       + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text)).ToString();

        TextBox17.Focus();
       
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        TextBox133.Text = (Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox19.Text)
                        + Convert.ToInt32(TextBox20.Text) + Convert.ToInt32(TextBox21.Text)).ToString();
        TextBox22.Focus();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        TextBox134.Text = (Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox24.Text)
                       + Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox26.Text)).ToString();
        TextBox28.Focus();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox27.Text = (Convert.ToInt32(TextBox28.Text) + Convert.ToInt32(TextBox29.Text) + Convert.ToInt32(TextBox30.Text)
                      + Convert.ToInt32(TextBox31.Text) + Convert.ToInt32(TextBox32.Text)).ToString();
        TextBox33.Focus();
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        TextBox606.Text = Convert.ToString(Convert.ToInt32(TextBox138.Text) + Convert.ToInt32(TextBox139.Text));
        TextBox141.Focus();
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        TextBox140.Text = Convert.ToString(Convert.ToInt32(TextBox141.Text) + Convert.ToInt32(TextBox142.Text));
        TextBox144.Focus();
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        TextBox143.Text = Convert.ToString(Convert.ToInt32(TextBox144.Text) + Convert.ToInt32(TextBox145.Text));
        TextBox146.Focus();
    }
    protected void Button41_Click(object sender, EventArgs e)
    {
        TextBox607.Text = Convert.ToString(Convert.ToInt32(TextBox146.Text) + Convert.ToInt32(TextBox147.Text));
        TextBox149.Focus();
    }
    protected void Button42_Click(object sender, EventArgs e)
    {
        TextBox148.Text = Convert.ToString(Convert.ToInt32(TextBox149.Text) + Convert.ToInt32(TextBox150.Text));
        TextBox152.Focus();
    }
    protected void Button43_Click(object sender, EventArgs e)
    {
        TextBox151.Text = Convert.ToString(Convert.ToInt32(TextBox152.Text) + Convert.ToInt32(TextBox153.Text));
        btnSave.Focus();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        TextBox135.Text = (Convert.ToInt32(TextBox33.Text) + Convert.ToInt32(TextBox34.Text) + Convert.ToInt32(TextBox35.Text)
                      + Convert.ToInt32(TextBox36.Text) + Convert.ToInt32(TextBox37.Text)).ToString();

        TextBox16.Text = (Convert.ToInt32(TextBox133.Text) + Convert.ToInt32(TextBox134.Text) + Convert.ToInt32(TextBox27.Text)
                      + Convert.ToInt32(TextBox135.Text)).ToString();

        //================== < 15 ===============
        TextBox674.Text = Convert.ToString(Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox28.Text));
        //================= 15 - 19 ==============
        TextBox473.Text = Convert.ToString(Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox29.Text));
        //================ 20 -24 ===============
        TextBox474.Text = Convert.ToString(Convert.ToInt32(TextBox19.Text) + Convert.ToInt32(TextBox24.Text) + Convert.ToInt32(TextBox30.Text));
        //=============== 25 - 49 ===============
        TextBox475.Text = Convert.ToString(Convert.ToInt32(TextBox20.Text) + Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox31.Text));
        //============== 50 +

        TextBox476.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + Convert.ToInt32(TextBox26.Text) + Convert.ToInt32(TextBox32.Text));
       //Convert.ToInt32(TextBox37.Text));

        TextBox43.Focus();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        TextBox137.Text = Convert.ToString(Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox44.Text) + Convert.ToInt32(TextBox45.Text)
                     + Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox47.Text));
        TextBox48.Focus();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        TextBox581.Text = Convert.ToString(Convert.ToInt32(TextBox48.Text) + Convert.ToInt32(TextBox49.Text) + Convert.ToInt32(TextBox50.Text)
                      + Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox52.Text));
        TextBox53.Focus();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        TextBox582.Text = Convert.ToString(Convert.ToInt32(TextBox53.Text) + Convert.ToInt32(TextBox54.Text) + Convert.ToInt32(TextBox55.Text)
                      + Convert.ToInt32(TextBox56.Text) + Convert.ToInt32(TextBox57.Text));

        //=========== Total No. Pregnant Women who tested +tiv to HIV==============
        TextBox136.Text = Convert.ToString(Convert.ToInt32(TextBox137.Text) + Convert.ToInt32(TextBox581.Text) + Convert.ToInt32(TextBox582.Text));
        //========== Total <15 ============
        TextBox38.Text = Convert.ToString(Convert.ToInt32(TextBox48.Text) + Convert.ToInt32(TextBox43.Text));
        //======== Total 15 - 19 =========
        TextBox39.Text = Convert.ToString(Convert.ToInt32(TextBox44.Text) + Convert.ToInt32(TextBox49.Text));
        //======= Total 20-24 ========
        TextBox40.Text = Convert.ToString(Convert.ToInt32(TextBox45.Text) + Convert.ToInt32(TextBox50.Text));
        //====== Total 25 - 49 =====
        TextBox41.Text = Convert.ToString(Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox51.Text));
        //====== Total 50+ ========
        TextBox42.Text = Convert.ToString(Convert.ToInt32(TextBox47.Text) + Convert.ToInt32(TextBox52.Text));
        TextBox63.Focus();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        TextBox584.Text = (Convert.ToInt32(TextBox63.Text) + Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox65.Text)
                    + Convert.ToInt32(TextBox66.Text) + Convert.ToInt32(TextBox67.Text)).ToString();
        TextBox68.Focus();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        TextBox585.Text = (Convert.ToInt32(TextBox68.Text) + Convert.ToInt32(TextBox69.Text) + Convert.ToInt32(TextBox70.Text)
                  + Convert.ToInt32(TextBox71.Text) + Convert.ToInt32(TextBox72.Text)).ToString();
        TextBox73.Focus();
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        TextBox586.Text = (Convert.ToInt32(TextBox73.Text) + Convert.ToInt32(TextBox74.Text) + Convert.ToInt32(TextBox75.Text)
                     + Convert.ToInt32(TextBox76.Text) + Convert.ToInt32(TextBox77.Text)).ToString();
        //=========== Total Number of pregnant women tested Hiv -ve ============================
        TextBox583.Text = Convert.ToString(Convert.ToInt32(TextBox584.Text) + Convert.ToInt32(TextBox585.Text) + Convert.ToInt32(TextBox586.Text));
        //========== Total <15 ============
        TextBox58.Text = Convert.ToString(Convert.ToInt32(TextBox63.Text) + Convert.ToInt32(TextBox68.Text));
        //======== Total 15 - 19 =========
        TextBox59.Text = Convert.ToString(Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox69.Text));
        //======= Total 20-24 ========
        TextBox60.Text = Convert.ToString(Convert.ToInt32(TextBox65.Text) + Convert.ToInt32(TextBox70.Text));
        //====== Total 25 - 49 =====
        TextBox61.Text = Convert.ToString(Convert.ToInt32(TextBox66.Text) + Convert.ToInt32(TextBox71.Text));
        //====== Total 50+ ========
        TextBox62.Text = Convert.ToString(Convert.ToInt32(TextBox67.Text) + Convert.ToInt32(TextBox72.Text));
        TextBox78.Focus();
    }
    //protected void Button23_Click(object sender, EventArgs e)
    //{
    //    //TextBox87.Text = Convert.ToString(Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text) + Convert.ToInt32(TextBox90.Text) + Convert.ToInt32(TextBox91.Text) + Convert.ToInt32(TextBox274.Text)
    //    //                + Convert.ToInt32(TextBox275.Text) + Convert.ToInt32(TextBox276.Text) + Convert.ToInt32(TextBox277.Text) + Convert.ToInt32(TextBox278.Text) + Convert.ToInt32(TextBox279.Text)
    //    //                + Convert.ToInt32(TextBox280.Text) + Convert.ToInt32(TextBox281.Text) + Convert.ToInt32(TextBox282.Text) + Convert.ToInt32(TextBox283.Text) + Convert.ToInt32(TextBox92.Text)
    //    //                + Convert.ToInt32(TextBox93.Text) + Convert.ToInt32(TextBox94.Text) + Convert.ToInt32(TextBox273.Text) + Convert.ToInt32(TextBox95.Text) + Convert.ToInt32(TextBox96.Text)
    //    //                + Convert.ToInt32(TextBox97.Text) + Convert.ToInt32(TextBox98.Text));
    //    TextBox100.Focus();
    //}
    //protected void Button24_Click(object sender, EventArgs e)
    //{
    //    TextBox99.Text = Convert.ToString(Convert.ToInt32(TextBox100.Text) + Convert.ToInt32(TextBox101.Text) + Convert.ToInt32(TextBox102.Text) + Convert.ToInt32(TextBox103.Text)
    //                            + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox105.Text) + Convert.ToInt32(TextBox106.Text));
    //    TextBox108.Focus();
    //}
    protected void Button25_Click(object sender, EventArgs e)
    {
        TextBox107.Text = Convert.ToString(Convert.ToInt32(TextBox108.Text) + Convert.ToInt32(TextBox109.Text));
        TextBox269.Focus();
        
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        TextBox110.Text = Convert.ToString(Convert.ToInt32(TextBox269.Text) + Convert.ToInt32(TextBox587.Text));
        TextBox111.Focus();
    }

    protected void Button27_Click(object sender, EventArgs e)
    {
        TextBox270.Text = Convert.ToString(Convert.ToInt32(TextBox111.Text) + Convert.ToInt32(TextBox112.Text));
        TextBox114.Focus();
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        TextBox113.Text = Convert.ToString(Convert.ToInt32(TextBox114.Text) + Convert.ToInt32(TextBox115.Text) + Convert.ToInt32(TextBox116.Text) + Convert.ToInt32(TextBox117.Text)
                         + Convert.ToInt32(TextBox118.Text) + Convert.ToInt32(TextBox119.Text) + Convert.ToInt32(TextBox271.Text));
        TextBox122.Focus();
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        TextBox272.Text = Convert.ToString(Convert.ToInt32(TextBox122.Text) + Convert.ToInt32(TextBox123.Text) + Convert.ToInt32(TextBox124.Text) + Convert.ToInt32(TextBox125.Text)
                          + Convert.ToInt32(TextBox126.Text) + Convert.ToInt32(TextBox127.Text) + Convert.ToInt32(TextBox128.Text) + Convert.ToInt32(TextBox129.Text)
                          + Convert.ToInt32(TextBox130.Text) + Convert.ToInt32(TextBox131.Text));
        TextBox121.Focus();
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        TextBox580.Text = Convert.ToString(Convert.ToInt32(TextBox121.Text) + Convert.ToInt32(TextBox120.Text));
        btnSave.Focus();
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        TextBox588.Text = Convert.ToString(Convert.ToInt32(TextBox589.Text) + Convert.ToInt32(TextBox590.Text));
        TextBox592.Focus();
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        TextBox591.Text = Convert.ToString(Convert.ToInt32(TextBox592.Text) + Convert.ToInt32(TextBox593.Text));
        TextBox595.Focus();
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        TextBox594.Text = Convert.ToString(Convert.ToInt32(TextBox595.Text) + Convert.ToInt32(TextBox596.Text));
        TextBox598.Focus();
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        TextBox597.Text = Convert.ToString(Convert.ToInt32(TextBox598.Text) + Convert.ToInt32(TextBox599.Text));
        TextBox601.Focus();
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        TextBox600.Text = Convert.ToString(Convert.ToInt32(TextBox601.Text) + Convert.ToInt32(TextBox602.Text));
        TextBox604.Focus();
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        TextBox603.Text = Convert.ToString(Convert.ToInt32(TextBox604.Text) + Convert.ToInt32(TextBox605.Text));
        btnSave.Focus();
    }
    protected void Button87_Click(object sender, EventArgs e)
    {
        TextBox610.Text = Convert.ToString(Convert.ToInt32(TextBox611.Text) + Convert.ToInt32(TextBox612.Text)
                  + Convert.ToInt32(TextBox613.Text) + Convert.ToInt32(TextBox614.Text) + Convert.ToInt32(TextBox615.Text));
        TextBox617.Focus();
    }
    protected void Button86_Click(object sender, EventArgs e)
    {
        TextBox616.Text = Convert.ToString(Convert.ToInt32(TextBox617.Text) + Convert.ToInt32(TextBox618.Text)
                  + Convert.ToInt32(TextBox619.Text) + Convert.ToInt32(TextBox620.Text) + Convert.ToInt32(TextBox621.Text));
        TextBox609.Text = Convert.ToString(Convert.ToInt32(TextBox610.Text) + Convert.ToInt32(TextBox616.Text));
        TextBox622.Focus();
    }
    protected void TextBox624_TextChanged(object sender, EventArgs e)
    {
        TextBox627.Focus();
    }
    protected void TextBox623_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button84_Click(object sender, EventArgs e)
    {
        TextBox626.Text = Convert.ToString(Convert.ToInt32(TextBox627.Text) + Convert.ToInt32(TextBox628.Text)
                         + Convert.ToInt32(TextBox629.Text) + Convert.ToInt32(TextBox630.Text) + Convert.ToInt32(TextBox631.Text));
        TextBox633.Focus();
    }
    protected void Button83_Click(object sender, EventArgs e)
    {
        TextBox632.Text = Convert.ToString(Convert.ToInt32(TextBox633.Text) + Convert.ToInt32(TextBox634.Text)
                          + Convert.ToInt32(TextBox635.Text) + Convert.ToInt32(TextBox666.Text) + Convert.ToInt32(TextBox636.Text));
        TextBox625.Text = Convert.ToString(Convert.ToInt32(TextBox626.Text) + Convert.ToInt32(TextBox632.Text));
    }
    protected void Button82_Click(object sender, EventArgs e)
    {
        TextBox638.Text = Convert.ToString(Convert.ToInt32(TextBox639.Text) + Convert.ToInt32(TextBox640.Text)
                         + Convert.ToInt32(TextBox641.Text) + Convert.ToInt32(TextBox642.Text) + Convert.ToInt32(TextBox643.Text));
        TextBox645.Focus();
    }
    protected void Button81_Click(object sender, EventArgs e)
    {
        TextBox644.Text = Convert.ToString(Convert.ToInt32(TextBox645.Text) + Convert.ToInt32(TextBox646.Text)
                        + Convert.ToInt32(TextBox647.Text) + Convert.ToInt32(TextBox648.Text) + Convert.ToInt32(TextBox649.Text));
        TextBox637.Text = Convert.ToString(Convert.ToInt32(TextBox638.Text) + Convert.ToInt32(TextBox644.Text));
        TextBox652.Focus();
    }
    protected void Button80_Click(object sender, EventArgs e)
    {
        TextBox651.Text = Convert.ToString(Convert.ToInt32(TextBox652.Text) + Convert.ToInt32(TextBox653.Text)
                        + Convert.ToInt32(TextBox654.Text) + Convert.ToInt32(TextBox655.Text) + Convert.ToInt32(TextBox656.Text));
        TextBox658.Focus();
    }
    protected void Button79_Click(object sender, EventArgs e)
    {
        TextBox657.Text = Convert.ToString(Convert.ToInt32(TextBox658.Text) + Convert.ToInt32(TextBox659.Text)
                        + Convert.ToInt32(TextBox660.Text) + Convert.ToInt32(TextBox661.Text) + Convert.ToInt32(TextBox662.Text));
        TextBox650.Text = Convert.ToString(Convert.ToInt32(TextBox651.Text) + Convert.ToInt32(TextBox657.Text));
        TextBox664.Focus();
    }
    protected void Button78_Click(object sender, EventArgs e)
    {
        TextBox663.Text = Convert.ToString(Convert.ToInt32(TextBox664.Text) + Convert.ToInt32(TextBox665.Text));
        btnSave.Focus();
    }
    //protected void Button77_Click(object sender, EventArgs e)
    //{
    //    //TextBox668.Text = Convert.ToString(Convert.ToInt32(TextBox670.Text) + Convert.ToInt32(TextBox672.Text));
    //    //TextBox671.Focus();
    //}
    //protected void Button76_Click(object sender, EventArgs e)
    //{
    //    TextBox669.Text = Convert.ToString(Convert.ToInt32(TextBox671.Text) + Convert.ToInt32(TextBox673.Text));
    //    TextBox667.Text = Convert.ToString(Convert.ToInt32(TextBox668.Text) + Convert.ToInt32(TextBox669.Text));
    //    TextBox453.Focus();
    //}
    //protected void Button75_Click(object sender, EventArgs e)
    //{
    //    TextBox452.Text = Convert.ToString(Convert.ToInt32(TextBox453.Text) + Convert.ToInt32(TextBox454.Text) + Convert.ToInt32(TextBox455.Text) + Convert.ToInt32(TextBox456.Text)
    //                     + Convert.ToInt32(TextBox457.Text) + Convert.ToInt32(TextBox458.Text) + Convert.ToInt32(TextBox459.Text) + Convert.ToInt32(TextBox460.Text));
    //    TextBox462.Focus(); 
    //}
    //protected void Button74_Click(object sender, EventArgs e)
    //{
    //    TextBox461.Text = Convert.ToString(Convert.ToInt32(TextBox462.Text) + Convert.ToInt32(TextBox463.Text) + Convert.ToInt32(TextBox464.Text) + Convert.ToInt32(TextBox465.Text)
    //                    + Convert.ToInt32(TextBox466.Text) + Convert.ToInt32(TextBox467.Text) + Convert.ToInt32(TextBox468.Text) + Convert.ToInt32(TextBox469.Text));
    //    TextBox451.Text = Convert.ToString(Convert.ToInt32(TextBox452.Text) + Convert.ToInt32(TextBox461.Text));
    //    TextBox160.Focus();
    //}
    //protected void Button73_Click(object sender, EventArgs e)
    //{
    //    TextBox159.Text = Convert.ToString(Convert.ToInt32(TextBox160.Text) + Convert.ToInt32(TextBox161.Text) + Convert.ToInt32(TextBox162.Text) + Convert.ToInt32(TextBox163.Text)
    //                      + Convert.ToInt32(TextBox164.Text) + Convert.ToInt32(TextBox165.Text) + Convert.ToInt32(TextBox166.Text) + Convert.ToInt32(TextBox167.Text));
    //    TextBox169.Focus();
    //}
    //protected void Button72_Click(object sender, EventArgs e)
    //{
    //    TextBox168.Text = Convert.ToString(Convert.ToInt32(TextBox169.Text) + Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text) + Convert.ToInt32(TextBox172.Text)
    //                      + Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text) + Convert.ToInt32(TextBox176.Text));
    //    TextBox158.Text = Convert.ToString(Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox168.Text));
    //    TextBox179.Focus();
    //}
    //protected void Button71_Click(object sender, EventArgs e)
    //{
    //    TextBox178.Text = Convert.ToString(Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text) + Convert.ToInt32(TextBox180.Text) + Convert.ToInt32(TextBox181.Text)
    //                   + Convert.ToInt32(TextBox182.Text) + Convert.ToInt32(TextBox183.Text) + Convert.ToInt32(TextBox184.Text) + Convert.ToInt32(TextBox185.Text)
    //                   + Convert.ToInt32(TextBox186.Text));
    //    TextBox188.Focus();
    //}
    //protected void Button70_Click(object sender, EventArgs e)
    //{
    //    TextBox187.Text = Convert.ToString(Convert.ToInt32(TextBox188.Text) + Convert.ToInt32(TextBox189.Text) + Convert.ToInt32(TextBox190.Text) + Convert.ToInt32(TextBox191.Text)
    //                     + Convert.ToInt32(TextBox192.Text) + Convert.ToInt32(TextBox193.Text) + Convert.ToInt32(TextBox194.Text) + Convert.ToInt32(TextBox195.Text));
    //    TextBox177.Text = Convert.ToString(Convert.ToInt32(TextBox178.Text) + Convert.ToInt32(TextBox187.Text));
    //    TextBox198.Focus();
    //}
    //protected void Button69_Click(object sender, EventArgs e)
    //{
    //    TextBox197.Text = Convert.ToString(Convert.ToInt32(TextBox198.Text) + Convert.ToInt32(TextBox199.Text) + Convert.ToInt32(TextBox200.Text) + Convert.ToInt32(TextBox201.Text)
    //                     + Convert.ToInt32(TextBox202.Text) + Convert.ToInt32(TextBox203.Text) + Convert.ToInt32(TextBox204.Text) + Convert.ToInt32(TextBox205.Text));
    //    TextBox207.Focus();
    //}
    //protected void Button68_Click(object sender, EventArgs e)
    //{
    //    TextBox206.Text = Convert.ToString(Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text) + Convert.ToInt32(TextBox210.Text)
    //                   + Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text));
    //    TextBox196.Text = Convert.ToString(Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox206.Text));
    //    TextBox217.Focus();
    //}
    //protected void Button67_Click(object sender, EventArgs e)
    //{
    //    TextBox216.Text = Convert.ToString(Convert.ToInt32(TextBox217.Text) + Convert.ToInt32(TextBox218.Text) + Convert.ToInt32(TextBox219.Text) + Convert.ToInt32(TextBox220.Text)
    //                 + Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text));
    //    TextBox226.Focus();
    //}
    //protected void Button66_Click(object sender, EventArgs e)
    //{
    //    TextBox225.Text = Convert.ToString(Convert.ToInt32(TextBox226.Text) + Convert.ToInt32(TextBox227.Text) + Convert.ToInt32(TextBox228.Text) + Convert.ToInt32(TextBox229.Text)
    //                 + Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox231.Text) + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text));
    //    TextBox215.Text = Convert.ToString(Convert.ToInt32(TextBox216.Text) + Convert.ToInt32(TextBox225.Text));
    //    TextBox236.Focus();
    //}
    //protected void Button65_Click(object sender, EventArgs e)
    //{
    //    TextBox155.Text = Convert.ToString(Convert.ToInt32(TextBox156.Text) + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox239.Text) + Convert.ToInt32(TextBox247.Text)
    //                   + Convert.ToInt32(TextBox313.Text) + Convert.ToInt32(TextBox441.Text) + Convert.ToInt32(TextBox442.Text) + Convert.ToInt32(TextBox471.Text));
    //    TextBox443.Focus();
    //}
    //protected void Button64_Click(object sender, EventArgs e)
    //{
    //    TextBox445.Text = Convert.ToString(Convert.ToInt32(TextBox443.Text) + Convert.ToInt32(TextBox446.Text) + Convert.ToInt32(TextBox447.Text) + Convert.ToInt32(TextBox448.Text)
    //                    + Convert.ToInt32(TextBox449.Text) + Convert.ToInt32(TextBox450.Text) + Convert.ToInt32(TextBox470.Text) + Convert.ToInt32(TextBox472.Text));
    //    TextBox154.Text = Convert.ToString(Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox445.Text));
    //    TextBox236.Focus();
    //}
    //protected void Button63_Click(object sender, EventArgs e)
    //{
    //    TextBox235.Text = Convert.ToString(Convert.ToInt32(TextBox236.Text) + Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox238.Text) + Convert.ToInt32(TextBox240.Text)
    //                 + Convert.ToInt32(TextBox241.Text) + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text) + Convert.ToInt32(TextBox439.Text));
    //    TextBox245.Focus();
    //}
    //protected void Button62_Click(object sender, EventArgs e)
    //{
    //    TextBox244.Text = Convert.ToString(Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox248.Text) + Convert.ToInt32(TextBox249.Text)
    //                + Convert.ToInt32(TextBox250.Text) + Convert.ToInt32(TextBox251.Text) + Convert.ToInt32(TextBox252.Text) + Convert.ToInt32(TextBox440.Text));
    //    TextBox234.Text = Convert.ToString(Convert.ToInt32(TextBox235.Text) + Convert.ToInt32(TextBox244.Text));
    //    TextBox255.Focus();
    //}
    //protected void Button61_Click(object sender, EventArgs e)
    //{
    //    TextBox254.Text = Convert.ToString(Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox256.Text) + Convert.ToInt32(TextBox257.Text) + Convert.ToInt32(TextBox258.Text)
    //                        + Convert.ToInt32(TextBox259.Text) + Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text));
    //    TextBox264.Focus();
    //}
    //protected void Button60_Click(object sender, EventArgs e)
    //{
    //    TextBox263.Text = Convert.ToString(Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text) + Convert.ToInt32(TextBox267.Text)
    //                       + Convert.ToInt32(TextBox268.Text) + Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text) + Convert.ToInt32(TextBox286.Text));
    //    TextBox253.Text = Convert.ToString(Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox263.Text));
    //    TextBox289.Focus();
    //}
    //protected void Button59_Click(object sender, EventArgs e)
    //{
    //    TextBox263.Text = Convert.ToString(Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text) + Convert.ToInt32(TextBox267.Text)
    //                       + Convert.ToInt32(TextBox268.Text) + Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text) + Convert.ToInt32(TextBox286.Text));
    //    TextBox253.Text = Convert.ToString(Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox263.Text));
    //    TextBox289.Focus();
    //}
    //protected void Button58_Click(object sender, EventArgs e)
    //{
    //    TextBox297.Text = Convert.ToString(Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text) + Convert.ToInt32(TextBox300.Text) + Convert.ToInt32(TextBox301.Text)
    //                       + Convert.ToInt32(TextBox302.Text) + Convert.ToInt32(TextBox303.Text) + Convert.ToInt32(TextBox304.Text) + Convert.ToInt32(TextBox305.Text));
    //    TextBox287.Text = Convert.ToString(Convert.ToInt32(TextBox288.Text) + Convert.ToInt32(TextBox297.Text));
    //    TextBox308.Focus();
    //}
    //protected void Button57_Click(object sender, EventArgs e)
    //{
    //    TextBox307.Text = Convert.ToString(Convert.ToInt32(TextBox308.Text) + Convert.ToInt32(TextBox309.Text) + Convert.ToInt32(TextBox310.Text) + Convert.ToInt32(TextBox311.Text)
    //                                + Convert.ToInt32(TextBox312.Text) + Convert.ToInt32(TextBox314.Text) + Convert.ToInt32(TextBox315.Text) + Convert.ToInt32(TextBox444.Text));
    //    TextBox317.Focus(); 
    //}
    //protected void Button56_Click(object sender, EventArgs e)
    //{
    //    TextBox316.Text = Convert.ToString(Convert.ToInt32(TextBox317.Text) + Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox320.Text)
    //                       + Convert.ToInt32(TextBox321.Text) + Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text) + Convert.ToInt32(TextBox324.Text));
    //    TextBox306.Text = Convert.ToString(Convert.ToInt32(TextBox307.Text) + Convert.ToInt32(TextBox316.Text));
    //    TextBox327.Focus();
    //}
    //protected void Button55_Click(object sender, EventArgs e)
    //{
    //    TextBox326.Text = Convert.ToString(Convert.ToInt32(TextBox327.Text) + Convert.ToInt32(TextBox328.Text) + Convert.ToInt32(TextBox329.Text) + Convert.ToInt32(TextBox330.Text)
    //                        + Convert.ToInt32(TextBox331.Text) + Convert.ToInt32(TextBox332.Text) + Convert.ToInt32(TextBox333.Text) + Convert.ToInt32(TextBox334.Text));
    //    TextBox336.Focus(); 
    //}
    //protected void Button54_Click(object sender, EventArgs e)
    //{
    //    TextBox335.Text = Convert.ToString(Convert.ToInt32(TextBox336.Text) + Convert.ToInt32(TextBox337.Text) + Convert.ToInt32(TextBox338.Text) + Convert.ToInt32(TextBox339.Text)
    //                      + Convert.ToInt32(TextBox340.Text) + Convert.ToInt32(TextBox341.Text) + Convert.ToInt32(TextBox342.Text) + Convert.ToInt32(TextBox343.Text));
    //    TextBox325.Text = Convert.ToString(Convert.ToInt32(TextBox326.Text) + Convert.ToInt32(TextBox335.Text));
    //    TextBox346.Focus();
    //}
    //protected void Button53_Click(object sender, EventArgs e)
    //{
    //    TextBox345.Text = Convert.ToString(Convert.ToInt32(TextBox346.Text) + Convert.ToInt32(TextBox347.Text) + Convert.ToInt32(TextBox348.Text) + Convert.ToInt32(TextBox349.Text)
    //                        + Convert.ToInt32(TextBox350.Text) + Convert.ToInt32(TextBox351.Text) + Convert.ToInt32(TextBox352.Text) + Convert.ToInt32(TextBox353.Text));
    //    TextBox355.Focus(); 
    //}
    //protected void Button52_Click(object sender, EventArgs e)
    //{
    //    TextBox354.Text = Convert.ToString(Convert.ToInt32(TextBox355.Text) + Convert.ToInt32(TextBox356.Text) + Convert.ToInt32(TextBox357.Text) + Convert.ToInt32(TextBox358.Text)
    //                      + Convert.ToInt32(TextBox359.Text) + Convert.ToInt32(TextBox360.Text) + Convert.ToInt32(TextBox361.Text) + Convert.ToInt32(TextBox362.Text));
    //    TextBox344.Text = Convert.ToString(Convert.ToInt32(TextBox345.Text) + Convert.ToInt32(TextBox354.Text));
    //    TextBox365.Focus();
    //}
    //protected void Button51_Click(object sender, EventArgs e)
    //{
    //    TextBox364.Text = Convert.ToString(Convert.ToInt32(TextBox365.Text) + Convert.ToInt32(TextBox366.Text) + Convert.ToInt32(TextBox367.Text) + Convert.ToInt32(TextBox368.Text)
    //                        + Convert.ToInt32(TextBox369.Text) + Convert.ToInt32(TextBox370.Text) + Convert.ToInt32(TextBox371.Text) + Convert.ToInt32(TextBox372.Text));
    //    TextBox374.Focus(); 
    //}
    //protected void Button50_Click(object sender, EventArgs e)
    //{
    //    TextBox373.Text = Convert.ToString(Convert.ToInt32(TextBox374.Text) + Convert.ToInt32(TextBox375.Text) + Convert.ToInt32(TextBox376.Text) + Convert.ToInt32(TextBox377.Text)
    //                      + Convert.ToInt32(TextBox378.Text) + Convert.ToInt32(TextBox379.Text) + Convert.ToInt32(TextBox380.Text) + Convert.ToInt32(TextBox381.Text));
    //    TextBox363.Text = Convert.ToString(Convert.ToInt32(TextBox364.Text) + Convert.ToInt32(TextBox373.Text));
    //    TextBox384.Focus();
    //}
    //protected void Button49_Click(object sender, EventArgs e)
    //{
    //    TextBox383.Text = Convert.ToString(Convert.ToInt32(TextBox384.Text) + Convert.ToInt32(TextBox385.Text) + Convert.ToInt32(TextBox386.Text) + Convert.ToInt32(TextBox387.Text)
    //                        + Convert.ToInt32(TextBox388.Text) + Convert.ToInt32(TextBox389.Text) + Convert.ToInt32(TextBox390.Text) + Convert.ToInt32(TextBox391.Text));
    //    TextBox393.Focus();
    //}
    //protected void Button48_Click(object sender, EventArgs e)
    //{
    //    TextBox392.Text = Convert.ToString(Convert.ToInt32(TextBox393.Text) + Convert.ToInt32(TextBox394.Text) + Convert.ToInt32(TextBox395.Text) + Convert.ToInt32(TextBox396.Text)
    //                      + Convert.ToInt32(TextBox397.Text) + Convert.ToInt32(TextBox398.Text) + Convert.ToInt32(TextBox399.Text) + Convert.ToInt32(TextBox400.Text));
    //    TextBox382.Text = Convert.ToString(Convert.ToInt32(TextBox383.Text) + Convert.ToInt32(TextBox392.Text));
    //    TextBox403.Focus();
    //}
    //protected void Button48_Click1(object sender, EventArgs e)
    //{
    //    TextBox392.Text = Convert.ToString(Convert.ToInt32(TextBox393.Text) + Convert.ToInt32(TextBox394.Text) + Convert.ToInt32(TextBox395.Text) + Convert.ToInt32(TextBox396.Text)
    //                      + Convert.ToInt32(TextBox397.Text) + Convert.ToInt32(TextBox398.Text) + Convert.ToInt32(TextBox399.Text) + Convert.ToInt32(TextBox400.Text));
    //    TextBox382.Text = Convert.ToString(Convert.ToInt32(TextBox383.Text) + Convert.ToInt32(TextBox392.Text));
    //    TextBox403.Focus();
    //}
    //protected void Button47_Click(object sender, EventArgs e)
    //{
    //    TextBox402.Text = Convert.ToString(Convert.ToInt32(TextBox403.Text) + Convert.ToInt32(TextBox404.Text) + Convert.ToInt32(TextBox405.Text) + Convert.ToInt32(TextBox406.Text)
    //                       + Convert.ToInt32(TextBox407.Text) + Convert.ToInt32(TextBox408.Text) + Convert.ToInt32(TextBox409.Text) + Convert.ToInt32(TextBox410.Text));
    //    TextBox412.Focus(); 
    //}
    //protected void Button46_Click(object sender, EventArgs e)
    //{
    //    TextBox411.Text = Convert.ToString(Convert.ToInt32(TextBox412.Text) + Convert.ToInt32(TextBox413.Text) + Convert.ToInt32(TextBox414.Text) + Convert.ToInt32(TextBox415.Text)
    //                      + Convert.ToInt32(TextBox416.Text) + Convert.ToInt32(TextBox417.Text) + Convert.ToInt32(TextBox418.Text) + Convert.ToInt32(TextBox419.Text));
    //    TextBox401.Text = Convert.ToString(Convert.ToInt32(TextBox402.Text) + Convert.ToInt32(TextBox411.Text));
    //    TextBox422.Focus();
    //}
    //protected void Button45_Click(object sender, EventArgs e)
    //{
    //    TextBox421.Text = Convert.ToString(Convert.ToInt32(TextBox422.Text) + Convert.ToInt32(TextBox423.Text) + Convert.ToInt32(TextBox424.Text) + Convert.ToInt32(TextBox425.Text)
    //                     + Convert.ToInt32(TextBox426.Text) + Convert.ToInt32(TextBox427.Text) + Convert.ToInt32(TextBox428.Text) + Convert.ToInt32(TextBox429.Text));
    //    TextBox431.Focus(); 
    //}
    //protected void Button44_Click(object sender, EventArgs e)
    //{
    //    TextBox430.Text = Convert.ToString(Convert.ToInt32(TextBox431.Text) + Convert.ToInt32(TextBox432.Text) + Convert.ToInt32(TextBox433.Text) + Convert.ToInt32(TextBox434.Text)
    //                     + Convert.ToInt32(TextBox435.Text) + Convert.ToInt32(TextBox436.Text) + Convert.ToInt32(TextBox437.Text) + Convert.ToInt32(TextBox438.Text));
    //    TextBox420.Text = Convert.ToString(Convert.ToInt32(TextBox421.Text) + Convert.ToInt32(TextBox430.Text));
    //    btnSave.Focus();
    //}
    //protected void TextBox33_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox674.Text = Convert.ToString(Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox28.Text) );
    //        //Convert.ToInt32(TextBox33.Text));
    //    TextBox34.Focus();
    //}
    protected void Button130_Click(object sender, EventArgs e)
    {
        TextBox674.Text = Convert.ToString(Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox28.Text));
           //Convert.ToInt32(TextBox33.Text));
        TextBox34.Focus();
    }
    //protected void TextBox34_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox473.Text = Convert.ToString(Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox29.Text) +
    //       Convert.ToInt32(TextBox34.Text));
    //    TextBox35.Focus();
    //}
    protected void Button131_Click(object sender, EventArgs e)
    {
        TextBox473.Text = Convert.ToString(Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox29.Text));
         //Convert.ToInt32(TextBox34.Text));
        TextBox35.Focus();
    }
    //protected void TextBox35_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox474.Text = Convert.ToString(Convert.ToInt32(TextBox19.Text) + Convert.ToInt32(TextBox24.Text) + Convert.ToInt32(TextBox30.Text) +
    //     Convert.ToInt32(TextBox35.Text));
    //    TextBox36.Focus();
    //}
    protected void Button132_Click(object sender, EventArgs e)
    {
        TextBox474.Text = Convert.ToString(Convert.ToInt32(TextBox19.Text) + Convert.ToInt32(TextBox24.Text) + Convert.ToInt32(TextBox30.Text));
        //Convert.ToInt32(TextBox35.Text));
        TextBox36.Focus();
    }
    //protected void TextBox36_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox475.Text = Convert.ToString(Convert.ToInt32(TextBox20.Text) + Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox31.Text) +
    //    Convert.ToInt32(TextBox36.Text));
    //    TextBox37.Focus();
    //}
    protected void Button133_Click(object sender, EventArgs e)
    {
        TextBox475.Text = Convert.ToString(Convert.ToInt32(TextBox20.Text) + Convert.ToInt32(TextBox25.Text) + Convert.ToInt32(TextBox31.Text) );
       //Convert.ToInt32(TextBox36.Text));
        TextBox37.Focus();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        TextBox87.Text = Convert.ToString(Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text) + Convert.ToInt32(TextBox90.Text) + Convert.ToInt32(TextBox91.Text));
                         
        TextBox276.Focus();
    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        TextBox87.Text = Convert.ToString(Convert.ToInt32(TextBox103.Text) + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox87.Text));
        TextBox105.Focus();
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        TextBox99.Text = Convert.ToString(Convert.ToInt32(TextBox100.Text) + Convert.ToInt32(TextBox101.Text));
        TextBox102.Focus();
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        TextBox116.Text = Convert.ToString(Convert.ToInt32(TextBox117.Text) + Convert.ToInt32(TextBox118.Text));
        TextBox119.Focus();
    }
    protected void Button44_Click(object sender, EventArgs e)
    {
        TextBox113.Text = Convert.ToString(Convert.ToInt32(TextBox114.Text) + Convert.ToInt32(TextBox114.Text));
        TextBox117.Focus();
    }
}