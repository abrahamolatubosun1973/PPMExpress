using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class DataEntryForm2 : System.Web.UI.Page
{
    public string mChoose = string.Empty;
    public string mState = string.Empty;
    public string mLGA = string.Empty;
    public string mFacility = string.Empty;
    public string mMnth = string.Empty;
    public string mYr = string.Empty;
    public string mFile = string.Empty;


    protected void Yrs()
    {
        //int YrNo = 2020; //Convert.ToInt32(string.Format("{0}",DateTime.Now.AddYears(3)));
        //drpYrs.ClearSelection();
        //drpYrs.Items.Clear();
        //drpYrs.Items.Add("");
        //for (int i = 2000; i <= YrNo; i++)
        //{
        //    drpYrs.Items.Add(i.ToString());
        //}
    }

    protected void FillState()
    {
        //string SQl = "Select Distinct statename from tbl_States order by statename asc";
        //SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        //cn.Open();
        //SqlCommand cmd = new SqlCommand(SQl, cn);
        //SqlDataReader r = cmd.ExecuteReader();
        //try
        //{
        //    drpStates.ClearSelection();
        //    drpStates.Items.Clear();
        //    drpStates.Items.Add("");
        //    while (r.Read()) { drpStates.Items.Add(r["statename"].ToString()); }

        //}
        //catch (Exception e)
        //{
        //    Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
        //    return;
        //}
    }

    protected void FillThematic()
    {
        //string SQl = "Select * from tbl_grpname order by abrv asc";
        //SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        //cn.Open();
        //SqlCommand cmd = new SqlCommand(SQl, cn);
        //SqlDataReader r = cmd.ExecuteReader();
        //try
        //{
        //    drpThematic.ClearSelection();
        //    drpThematic.Items.Clear();
        //    drpThematic.Items.Add("");
        //    while (r.Read()) { drpThematic.Items.Add(r["fname"].ToString()); }

        //}
        //catch (Exception e)
        //{
        //    Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
        //    return;
        //}
    }


    protected void Page_Load(object sender, EventArgs e)
    {
       
        if(!IsPostBack )
        {
            Yrs();
            FillState();
            FillThematic();
            Session["editme"] = false;

            //if (!string.IsNullOrEmpty(Session["mChoose"] as string ) && !string.IsNullOrEmpty(Session["mYr"] as string) )
            //{
            
               Session["mChoose"] = Request.QueryString["mChoose"];
                Session["mState"] = Request.QueryString["mState"];
                Session["mLGA"] = Request.QueryString["mLGA"];
                Session["mFacility"] = Request.QueryString["mFacility"];
                Session["mMnth"] = Request.QueryString["mMnth"];
                Session["mYr"] = Request.QueryString["mYr"];

                mChoose = Session["mChoose"].ToString();
                mState = Session["mState"].ToString();
                mLGA = Session["mLGA"].ToString();
                mFacility = Session["mFacility"].ToString();
                mMnth = Session["mMnth"].ToString();
                mYr = Session["mYr"].ToString();

                lblThematic.Text = " " + mState + "/" + mLGA + "/" + mFacility + "/" + mMnth + "-" + mYr;

                switch (mChoose)
                {
                    case "CARE":
                        EDIT_CARE();
                        MultiView1.SetActiveView(View1);
                        //TextBox3.Focus();
                        break;
                    case "ART":
                        Edit_ART();
                        MultiView1.SetActiveView(View2);
                        break;
                    case "HTC":
                        Edit_HTC();
                        MultiView1.SetActiveView(View3);
                        break;
                    default:
                        break;
                }
            //} // end of 2nd IF
            //===================================================
            //drpStates.Text = mState;
            //drpLGA.Text = mLGA;
            //drpFacility.Text = mFacility;
            //drpMnth.Text = mMnth;
            //drpYrs.Text = mYr;
            //drpThematic.Text = mChoose;
            // ch = (string)Session["choose"];

          
        }// end of 1st IF
     }

    protected void Edit_HTC()
    {
        int T1 = -1; int T2 = -1; int T3 = -1;

        //======== HTC1 =======
        string SQL = "SELECT * FROM tbl_HTC1 Where states = '"+mState.Trim()+"' and lga ='"+ mLGA.Trim()+"' and months ='" + mMnth.Trim() + "' and years ='" + mYr.Trim() + "' and grouptype ='" + mChoose.Trim() + "' and facname ='" + mFacility.Trim() + "'";
        try
        {
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(SQL, cn);
            SqlDataReader rd1 = cmd.ExecuteReader();

            if (rd1 != null)
            {
                while (rd1.Read())
                {
                    //========================= HTC 1
                    TextBox611.Text = rd1["TOTALG1"].ToString();
                    TextBox612.Text = rd1["SUBG1MA"].ToString();
                    TextBox613.Text = rd1["G1MA1"].ToString();
                    TextBox614.Text = rd1["G1MA1_4"].ToString();
                    TextBox615.Text = rd1["G1MA5_9"].ToString();
                    TextBox616.Text = rd1["G1MA10_14"].ToString();
                    TextBox617.Text = rd1["G1MA15_19"].ToString();
                    TextBox618.Text = rd1["G1MA20_24"].ToString();
                    TextBox619.Text = rd1["G1MA25_49"].ToString();
                    TextBox620.Text = rd1["G1MA50"].ToString();
                    TextBox621.Text = rd1["SUBG1FE"].ToString();
                    TextBox622.Text = rd1["G1FE1"].ToString();
                    TextBox623.Text = rd1["G1FE1_4"].ToString();
                    TextBox624.Text = rd1["G1FE5_9"].ToString();
                    TextBox625.Text = rd1["G1FE10_14"].ToString();
                    TextBox626.Text = rd1["G1FE15_19"].ToString();
                    TextBox627.Text = rd1["G1FE20_24"].ToString();
                    TextBox628.Text = rd1["G1FE25_49"].ToString();
                    TextBox629.Text = rd1["G1FE50"].ToString();
                    TextBox630.Text = rd1["TOTALG2"].ToString();
                    TextBox631.Text = rd1["SUBG2M"].ToString();
                    TextBox632.Text = rd1["G2MA1"].ToString();
                    TextBox633.Text = rd1["G2MA1_4"].ToString();
                    TextBox634.Text = rd1["G2MA5_9"].ToString();
                    TextBox635.Text = rd1["G2MA10_14"].ToString();
                    TextBox636.Text = rd1["G2MA15_19"].ToString();
                    TextBox637.Text = rd1["G2MA20_24"].ToString();
                    TextBox638.Text = rd1["G2MA25_49"].ToString();
                    TextBox639.Text = rd1["G2MA50"].ToString();
                    TextBox640.Text = rd1["SUBG2F"].ToString();
                    TextBox641.Text = rd1["G2FE1"].ToString();
                    TextBox642.Text = rd1["G2FE1_4"].ToString();
                    TextBox643.Text = rd1["G2FE5_9"].ToString();
                    TextBox644.Text = rd1["G2FE10_14"].ToString();
                    TextBox645.Text = rd1["G2FE15_19"].ToString();
                    TextBox646.Text = rd1["G2FE20_24"].ToString();
                    TextBox647.Text = rd1["G2FE25_49"].ToString();
                    TextBox648.Text = rd1["G2FE50"].ToString();
                    TextBox649.Text = rd1["TOTALG3"].ToString();
                    TextBox650.Text = rd1["SUBG3M"].ToString();
                    TextBox651.Text = rd1["G3MA1"].ToString();
                    TextBox652.Text = rd1["G3MA1_4"].ToString();
                    TextBox653.Text = rd1["G3MA5_9"].ToString();
                    TextBox654.Text = rd1["G3MA10_14"].ToString();
                    TextBox655.Text = rd1["G3MA15_19"].ToString();
                    TextBox656.Text = rd1["G3MA20_24"].ToString();
                    TextBox657.Text = rd1["G3MA25_49"].ToString();
                    TextBox658.Text = rd1["G3MA50"].ToString();
                    TextBox659.Text = rd1["SUBG3F"].ToString();
                    TextBox660.Text = rd1["G3FE1"].ToString();
                    TextBox661.Text = rd1["G3FE1_4"].ToString();
                    TextBox662.Text = rd1["G3FE5_9"].ToString();
                    TextBox663.Text = rd1["G3FE10_14"].ToString();
                    TextBox664.Text = rd1["G3FE15_19"].ToString();
                    TextBox665.Text = rd1["G3FE20_24"].ToString();
                    TextBox666.Text = rd1["G3FE25_49"].ToString();
                    TextBox667.Text = rd1["G3FE50"].ToString();
                    TextBox668.Text = rd1["TOTALG4"].ToString();
                    TextBox669.Text = rd1["SUBG4P"].ToString();
                    TextBox670.Text = rd1["G4P1"].ToString();
                    TextBox671.Text = rd1["G4P1_4"].ToString();
                    TextBox672.Text = rd1["G4P5_9"].ToString();
                    TextBox673.Text = rd1["G4P10_14"].ToString();
                    TextBox674.Text = rd1["G4P15_19"].ToString();
                    TextBox675.Text = rd1["G4P20_24"].ToString();
                    TextBox676.Text = rd1["G4P25_49"].ToString();
                    TextBox677.Text = rd1["G4P50"].ToString();
                    TextBox678.Text = rd1["SUB4N"].ToString();
                    TextBox679.Text = rd1["G4N1"].ToString();
                    TextBox680.Text = rd1["G4N1_4"].ToString();
                    TextBox681.Text = rd1["G4N5_9"].ToString();
                    TextBox682.Text = rd1["G4N10_14"].ToString();
                    TextBox683.Text = rd1["G4N15_19"].ToString();
                    TextBox684.Text = rd1["G4N20_24"].ToString();
                    TextBox685.Text = rd1["G4N25_49"].ToString();
                    TextBox686.Text = rd1["G4N50"].ToString();
                    TextBox687.Text = rd1["TOTALG5"].ToString();
                    TextBox688.Text = rd1["SUBG5M"].ToString();
                    TextBox689.Text = rd1["G5MA1"].ToString();
                    TextBox690.Text = rd1["G5M1_4"].ToString();
                    TextBox691.Text = rd1["G5MA5_9"].ToString();
                    TextBox692.Text = rd1["G5MA10_14"].ToString();
                    TextBox693.Text = rd1["G5MA15_19"].ToString();
                    TextBox694.Text = rd1["G5MA20_24"].ToString();
                    TextBox695.Text = rd1["G5MA25_49"].ToString();
                    TextBox696.Text = rd1["G5MA50"].ToString();
                    TextBox697.Text = rd1["SUBG5F"].ToString();
                    TextBox698.Text = rd1["G5FE1"].ToString();
                    TextBox699.Text = rd1["G5FE1_4"].ToString();
                    TextBox700.Text = rd1["G5FE5_9"].ToString();
                    TextBox701.Text = rd1["G5FE10_14"].ToString();
                    TextBox702.Text = rd1["G5FE15_19"].ToString();
                    TextBox703.Text = rd1["G5FE20_24"].ToString();
                    TextBox704.Text = rd1["G5FE25_49"].ToString();
                    TextBox705.Text = rd1["G5FE50"].ToString();
                    TextBox706.Text = rd1["TOTALG6"].ToString();
                    TextBox707.Text = rd1["SUBG6M"].ToString();
                    TextBox708.Text = rd1["G6MA1"].ToString();
                    TextBox709.Text = rd1["G6M1_4"].ToString();
                    TextBox710.Text = rd1["G6MA5_9"].ToString();
                    TextBox711.Text = rd1["G6MA10_14"].ToString();
                    TextBox712.Text = rd1["G6MA15_19"].ToString();
                    TextBox713.Text = rd1["G6MA20_24"].ToString();
                    TextBox714.Text = rd1["G6MA25_49"].ToString();
                    TextBox715.Text = rd1["G6MA50"].ToString();
                    TextBox716.Text = rd1["SUBG6F"].ToString();
                    TextBox717.Text = rd1["G6FE1"].ToString();
                    TextBox718.Text = rd1["G6FE1_4"].ToString();
                    TextBox719.Text = rd1["G6FE5_9"].ToString();
                    TextBox720.Text = rd1["G6FE10_14"].ToString();
                    TextBox721.Text = rd1["G6FE15_19"].ToString();
                    TextBox722.Text = rd1["G6FE20_24"].ToString();
                    TextBox723.Text = rd1["G6FE25_49"].ToString();
                    TextBox724.Text = rd1["G6FE50"].ToString();
                    TextBox725.Text = rd1["TOTALG7"].ToString();
                    TextBox726.Text = rd1["SUBG7M"].ToString();
                    TextBox727.Text = rd1["G7MA1"].ToString();
                    TextBox728.Text = rd1["G7M1_4"].ToString();
                    TextBox729.Text = rd1["G7MA5_9"].ToString();
                    TextBox730.Text = rd1["G7MA10_14"].ToString();
                    TextBox731.Text = rd1["G7MA15_19"].ToString();
                    TextBox732.Text = rd1["G7MA20_24"].ToString();
                    TextBox733.Text = rd1["G7MA25_49"].ToString();
                    TextBox734.Text = rd1["G7MA50"].ToString();
                    TextBox735.Text = rd1["SUBG7F"].ToString();
                    TextBox736.Text = rd1["G7FE1"].ToString();
                    TextBox737.Text = rd1["G7FE1_4"].ToString();
                    TextBox738.Text = rd1["G7FE5_9"].ToString();
                    TextBox739.Text = rd1["G7FE10_14"].ToString();
                    TextBox740.Text = rd1["G7FE15_19"].ToString();
                    TextBox741.Text = rd1["G7FE20_24"].ToString();
                    TextBox742.Text = rd1["G7FE25_49"].ToString();
                    TextBox743.Text = rd1["G7FE50"].ToString();
                    TextBox782.Text = rd1["TOTALG8"].ToString();
                    TextBox783.Text = rd1["SUBG8M"].ToString();
                    TextBox784.Text = rd1["G8MA10_14"].ToString();
                    TextBox785.Text = rd1["G8M15_19"].ToString();
                    TextBox786.Text = rd1["G8MA20_24"].ToString();
                    TextBox787.Text = rd1["G8MA25_49"].ToString();
                    TextBox788.Text = rd1["G8MA50"].ToString();
                    TextBox789.Text = rd1["SUBG8P"].ToString();
                    #region ============= Temporary Field for reuse =================
                    ////================= HTC 2
                    //TextBox790.Text = rd1["G8P10_14"].ToString();
                    //TextBox791.Text = rd1["G8P15_19"].ToString();
                    //TextBox792.Text = rd1["G8P20_24"].ToString();
                    //TextBox793.Text = rd1["G8P25_49"].ToString();
                    //TextBox794.Text = rd1["G8P50"].ToString();
                    //TextBox795.Text = rd1["TOTALG9"].ToString();
                    //TextBox796.Text = rd1["SUBG9M"].ToString();
                    //TextBox797.Text = rd1["G9MA1"].ToString();
                    //TextBox798.Text = rd1["G9MA1_4"].ToString();
                    //TextBox799.Text = rd1["G9MA5_9"].ToString();
                    //TextBox800.Text = rd1["G9MA10_14"].ToString();
                    //TextBox801.Text = rd1["G9MA15_19"].ToString();
                    //TextBox802.Text = rd1["G9MA20_24"].ToString();
                    //TextBox803.Text = rd1["G9MA25_49"].ToString();
                    //TextBox804.Text = rd1["G9MA50"].ToString();
                    //TextBox805.Text = rd1["SUBG9F"].ToString();
                    //TextBox806.Text = rd1["G9FE1"].ToString();
                    //TextBox807.Text = rd1["G9FE1_4"].ToString();
                    //TextBox808.Text = rd1["G9FE5_9"].ToString();
                    //TextBox809.Text = rd1["G9FE10_14"].ToString();
                    //TextBox810.Text = rd1["G9FE15_19"].ToString();
                    //TextBox811.Text = rd1["G9FE20_24"].ToString();
                    //TextBox812.Text = rd1["G9FE25_49"].ToString();
                    //TextBox813.Text = rd1["G9FE50"].ToString();
                    //TextBox814.Text = rd1["TOTALG10"].ToString();
                    //TextBox815.Text = rd1["SUBG10P"].ToString();
                    //TextBox816.Text = rd1["G10P1"].ToString();
                    //TextBox817.Text = rd1["G10P1_4"].ToString();
                    //TextBox818.Text = rd1["G10P5_9"].ToString();
                    //TextBox819.Text = rd1["G10P10_14"].ToString();
                    //TextBox820.Text = rd1["G10P15_19"].ToString();
                    //TextBox821.Text = rd1["G10P20_24"].ToString();
                    //TextBox822.Text = rd1["G10P25_49"].ToString();
                    //TextBox823.Text = rd1["G10P50"].ToString();
                    //TextBox824.Text = rd1["SUBG10N"].ToString();
                    //TextBox825.Text = rd1["G10N1"].ToString();
                    //TextBox826.Text = rd1["G10N1_4"].ToString();
                    //TextBox827.Text = rd1["G10N5_9"].ToString();
                    //TextBox828.Text = rd1["G10N10_14"].ToString();
                    //TextBox829.Text = rd1["G10N15_19"].ToString();
                    //TextBox830.Text = rd1["G10N20_24"].ToString();
                    //TextBox831.Text = rd1["G10N25_49"].ToString();
                    //TextBox832.Text = rd1["G10N50"].ToString();
                    //TextBox833.Text = rd1["TOTALG11"].ToString();
                    //TextBox834.Text = rd1["SUBG11M"].ToString();
                    //TextBox835.Text = rd1["G11MA1"].ToString();
                    //TextBox836.Text = rd1["G11MA1_4"].ToString();
                    //TextBox837.Text = rd1["G11MA5_9"].ToString();
                    //TextBox838.Text = rd1["G11MA10_14"].ToString();
                    //TextBox839.Text = rd1["G11MA15_19"].ToString();
                    //TextBox840.Text = rd1["G11MA20_24"].ToString();
                    //TextBox841.Text = rd1["G11MA25_49"].ToString();
                    //TextBox842.Text = rd1["G11MA50"].ToString();
                    //TextBox843.Text = rd1["SUBG11F"].ToString();
                    //TextBox844.Text = rd1["G11FE1"].ToString();
                    //TextBox845.Text = rd1["G11FE1_4"].ToString();
                    //TextBox846.Text = rd1["G11FE5_9"].ToString();
                    //TextBox847.Text = rd1["G11FE10_14"].ToString();
                    //TextBox848.Text = rd1["G11FE15_19"].ToString();
                    //TextBox849.Text = rd1["G11FE20_24"].ToString();
                    //TextBox850.Text = rd1["G11FE25_49"].ToString();
                    //TextBox851.Text = rd1["G11FE50"].ToString();
                    //TextBox852.Text = rd1["TOTALG12"].ToString();
                    //TextBox853.Text = rd1["SUBG12M"].ToString();
                    //TextBox854.Text = rd1["G12MA1"].ToString();
                    //TextBox855.Text = rd1["G12MA1_4"].ToString();
                    //TextBox856.Text = rd1["G12MA5_9"].ToString();
                    //TextBox857.Text = rd1["G12MA10_14"].ToString();
                    //TextBox858.Text = rd1["G12MA15_19"].ToString();
                    //TextBox859.Text = rd1["G12MA20_24"].ToString();
                    //TextBox860.Text = rd1["G12MA25_49"].ToString();
                    //TextBox861.Text = rd1["G12MA50"].ToString();
                    //TextBox862.Text = rd1["SUBG12F"].ToString();
                    //TextBox863.Text = rd1["G12FE1"].ToString();
                    //TextBox864.Text = rd1["G12FE1_4"].ToString();
                    //TextBox865.Text = rd1["G12FE5_9"].ToString();
                    //TextBox866.Text = rd1["G12FE10_14"].ToString();
                    //TextBox867.Text = rd1["G12FE15_19"].ToString();
                    //TextBox868.Text = rd1["G12FE20_24"].ToString();
                    //TextBox869.Text = rd1["G12FE25_49"].ToString();
                    //TextBox870.Text = rd1["G12FE50"].ToString();
                    //TextBox871.Text = rd1["TOTALG13"].ToString();
                    //TextBox872.Text = rd1["SUBG13M"].ToString();
                    //TextBox873.Text = rd1["G13MA1"].ToString();
                    //TextBox874.Text = rd1["G13MA1_4"].ToString();
                    //TextBox875.Text = rd1["G13MA5_9"].ToString();
                    //TextBox876.Text = rd1["G13MA10_14"].ToString();
                    //TextBox877.Text = rd1["G13MA15_19"].ToString();
                    //TextBox878.Text = rd1["G13MA20_24"].ToString();
                    //TextBox879.Text = rd1["G13MA25_49"].ToString();
                    //TextBox880.Text = rd1["G13MA50"].ToString();
                    //TextBox881.Text = rd1["SUBG13F"].ToString();
                    //TextBox882.Text = rd1["G13FE1"].ToString();
                    //TextBox883.Text = rd1["G13FE1_4"].ToString();
                    //TextBox884.Text = rd1["G13FE5_9"].ToString();
                    //TextBox885.Text = rd1["G13FE10_14"].ToString();
                    //TextBox886.Text = rd1["G13FE15_19"].ToString();
                    //TextBox887.Text = rd1["G13FE20_24"].ToString();
                    //TextBox888.Text = rd1["G13FE25_49"].ToString();
                    //TextBox889.Text = rd1["G13FE50"].ToString();
                    //TextBox890.Text = rd1["TOTALG14"].ToString();
                    //TextBox891.Text = rd1["SUBG14M"].ToString();
                    //TextBox892.Text = rd1["G14MA1"].ToString();
                    //TextBox893.Text = rd1["G14MA1_4"].ToString();
                    //TextBox894.Text = rd1["G14MA5_9"].ToString();
                    //TextBox895.Text = rd1["G14MA10_14"].ToString();
                    //TextBox896.Text = rd1["G14MA15_19"].ToString();
                    //TextBox897.Text = rd1["G14MA20_24"].ToString();
                    //TextBox898.Text = rd1["G14MA25_49"].ToString();
                    //TextBox899.Text = rd1["G14MA50"].ToString();
                    //TextBox900.Text = rd1["SUBG14F"].ToString();
                    //TextBox901.Text = rd1["G14FE1"].ToString();
                    //TextBox902.Text = rd1["G14FE1_4"].ToString();
                    //TextBox903.Text = rd1["G14FE5_9"].ToString();
                    //TextBox904.Text = rd1["G14FE10_14"].ToString();
                    //TextBox905.Text = rd1["G14FE15_19"].ToString();
                    //TextBox906.Text = rd1["G14FE20_24"].ToString();
                    //TextBox907.Text = rd1["G14FE25_49"].ToString();
                    //TextBox908.Text = rd1["G14FE50"].ToString();
                    //TextBox909.Text = rd1["TOTALG15"].ToString();
                    //TextBox910.Text = rd1["SUBG15M"].ToString();
                    //TextBox911.Text = rd1["G15MA15_19"].ToString();
                    //TextBox912.Text = rd1["G15MA20_24"].ToString();
                    //TextBox913.Text = rd1["G15MS25_49"].ToString();
                    //TextBox914.Text = rd1["G15MA50"].ToString();
                    //TextBox915.Text = rd1["SUBG15F"].ToString();
                    //TextBox916.Text = rd1["G15FE15_19"].ToString();
                    //TextBox917.Text = rd1["G15FE20_24"].ToString();
                    //TextBox918.Text = rd1["G15FE25_49"].ToString();
                    //TextBox919.Text = rd1["G15FE50"].ToString();
                    //TextBox920.Text = rd1["TOTALG16"].ToString();
                    //TextBox921.Text = rd1["SUBG16M"].ToString();
                    //TextBox922.Text = rd1["G16MA15_19"].ToString();
                    //TextBox923.Text = rd1["G16MA20_24"].ToString();
                    //TextBox924.Text = rd1["G16MS25_49"].ToString();
                    //TextBox925.Text = rd1["G16MA50"].ToString();
                    //TextBox926.Text = rd1["SUBG16F"].ToString();
                    //TextBox927.Text = rd1["G16FE15_19"].ToString();
                    //TextBox928.Text = rd1["G16FE20_24"].ToString();
                    //TextBox929.Text = rd1["G16FE25_49"].ToString();
                    //TextBox930.Text = rd1["G16FE50"].ToString();

                    ////================ HTC 3
                    //TextBox931.Text = rd1["TOTALG17"].ToString();
                    //TextBox932.Text = rd1["SUBG17M"].ToString();
                    //TextBox933.Text = rd1["G17MA1"].ToString();
                    //TextBox934.Text = rd1["G17MA1_4"].ToString();
                    //TextBox935.Text = rd1["G17MA5_9"].ToString();
                    //TextBox936.Text = rd1["G17MA10_14"].ToString();
                    //TextBox937.Text = rd1["G17MA15_19"].ToString();
                    //TextBox938.Text = rd1["G17MA20_24"].ToString();
                    //TextBox939.Text = rd1["G17MA25_49"].ToString();
                    //TextBox940.Text = rd1["G17MA50"].ToString();
                    //TextBox941.Text = rd1["SUBG17F"].ToString();
                    //TextBox942.Text = rd1["G17FE1"].ToString();
                    //TextBox943.Text = rd1["G17FE1_4"].ToString();
                    //TextBox944.Text = rd1["G17FE5_9"].ToString();
                    //TextBox945.Text = rd1["G17FE10_14"].ToString();
                    //TextBox946.Text = rd1["G17FE15_19"].ToString();
                    //TextBox947.Text = rd1["G17FE20_24"].ToString();
                    //TextBox948.Text = rd1["G17FE25_49"].ToString();
                    //TextBox949.Text = rd1["G17FE50"].ToString();
                    //TextBox950.Text = rd1["TOTALG18"].ToString();
                    //TextBox951.Text = rd1["SUBG18M"].ToString();
                    //TextBox952.Text = rd1["G18MA1"].ToString();
                    //TextBox953.Text = rd1["G18MA1_4"].ToString();
                    //TextBox954.Text = rd1["G18MA5_9"].ToString();
                    //TextBox955.Text = rd1["G18MA10_14"].ToString();
                    //TextBox956.Text = rd1["G18MA15_19"].ToString();
                    //TextBox957.Text = rd1["G18MA20_24"].ToString();
                    //TextBox958.Text = rd1["G18MA25_49"].ToString();
                    //TextBox959.Text = rd1["G18MA50"].ToString();
                    //TextBox960.Text = rd1["SUBG18F"].ToString();
                    //TextBox961.Text = rd1["G18FE1"].ToString();
                    //TextBox962.Text = rd1["G18FE1_4"].ToString();
                    //TextBox963.Text = rd1["G18FE5_9"].ToString();
                    //TextBox964.Text = rd1["G18FE10_14"].ToString();
                    //TextBox965.Text = rd1["G18FE15_19"].ToString();
                    //TextBox966.Text = rd1["G18FE20_24"].ToString();
                    //TextBox967.Text = rd1["G18FE25_49"].ToString();
                    //TextBox968.Text = rd1["G18FE50"].ToString();
                    //TextBox969.Text = rd1["TOTALG19"].ToString();
                    //TextBox970.Text = rd1["SUBG19M"].ToString();
                    //TextBox971.Text = rd1["G19MA1"].ToString();
                    //TextBox972.Text = rd1["G19MA1_4"].ToString();
                    //TextBox973.Text = rd1["G98MA5_9"].ToString();
                    //TextBox974.Text = rd1["G19MA10_14"].ToString();
                    //TextBox975.Text = rd1["G19MA15_19"].ToString();
                    //TextBox976.Text = rd1["G19MA20_24"].ToString();
                    //TextBox977.Text = rd1["G19MA25_49"].ToString();
                    //TextBox978.Text = rd1["G19MA50"].ToString();
                    //TextBox979.Text = rd1["SUBG19F"].ToString();
                    //TextBox980.Text = rd1["G19FE1"].ToString();
                    //TextBox981.Text = rd1["G19FE1_4"].ToString();
                    //TextBox982.Text = rd1["G19FE5_9"].ToString();
                    //TextBox983.Text = rd1["G19FE10_14"].ToString();
                    //TextBox984.Text = rd1["G19FE15_19"].ToString();
                    //TextBox985.Text = rd1["G19FE20_24"].ToString();
                    //TextBox986.Text = rd1["G19FE25_49"].ToString();
                    //TextBox987.Text = rd1["G19FE50"].ToString();
                    //TextBox988.Text = rd1["TOTALG20"].ToString();
                    //TextBox989.Text = rd1["SUBG20M"].ToString();
                    //TextBox990.Text = rd1["G20MA1"].ToString();
                    //TextBox991.Text = rd1["G20MA1_4"].ToString();
                    //TextBox992.Text = rd1["G20MA5_9"].ToString();
                    //TextBox993.Text = rd1["G20MA10_14"].ToString();
                    //TextBox994.Text = rd1["G20MA15_19"].ToString();
                    //TextBox995.Text = rd1["G20MA20_24"].ToString();
                    //TextBox996.Text = rd1["G20MA25_49"].ToString();
                    //TextBox997.Text = rd1["G20MA50"].ToString();
                    //TextBox998.Text = rd1["SUBG20F"].ToString();
                    //TextBox999.Text = rd1["G20FE1"].ToString();
                    //TextBox1000.Text = rd1["G20FE1_4"].ToString();
                    //TextBox1001.Text = rd1["G20FE5_9"].ToString();
                    //TextBox1002.Text = rd1["G20FE10_14"].ToString();
                    //TextBox1003.Text = rd1["G20FE15_19"].ToString();
                    //TextBox1004.Text = rd1["G20FE20_24"].ToString();
                    //TextBox1005.Text = rd1["G20FE25_49"].ToString();
                    //TextBox1006.Text = rd1["G20FE50"].ToString();
                    //TextBox1007.Text = rd1["TOTALG21"].ToString();
                    //TextBox1008.Text = rd1["SUBG21M"].ToString();
                    //TextBox1009.Text = rd1["G21MA1"].ToString();
                    //TextBox1010.Text = rd1["G21MA1_4"].ToString();
                    //TextBox1011.Text = rd1["G21MA5_9"].ToString();
                    //TextBox1012.Text = rd1["G21MA10_14"].ToString();
                    //TextBox1013.Text = rd1["G21MA15_19"].ToString();
                    //TextBox1014.Text = rd1["G21MA20_24"].ToString();
                    //TextBox1015.Text = rd1["G21MA25_49"].ToString();
                    //TextBox1016.Text = rd1["G21MA50"].ToString();
                    //TextBox1017.Text = rd1["SUBG21F"].ToString();
                    //TextBox1018.Text = rd1["G21FE1"].ToString();
                    //TextBox1019.Text = rd1["G21FE1_4"].ToString();
                    //TextBox1020.Text = rd1["G21FE5_9"].ToString();
                    //TextBox1021.Text = rd1["G21FE10_14"].ToString();
                    //TextBox1022.Text = rd1["G21FE15_19"].ToString();
                    //TextBox1023.Text = rd1["G21FE20_24"].ToString();
                    //TextBox1025.Text = rd1["G21FE25_49"].ToString();
                    //TextBox1026.Text = rd1["TOTALG22"].ToString();
                    //TextBox1027.Text = rd1["SUBG22M"].ToString();
                    //TextBox1028.Text = rd1["G22MA1"].ToString();
                    //TextBox1029.Text = rd1["G22MA1_4"].ToString();
                    //TextBox1030.Text = rd1["G22MA5_9"].ToString();
                    //TextBox1031.Text = rd1["G22MA10_14"].ToString();
                    //TextBox1032.Text = rd1["G22MA15_19"].ToString();
                    //TextBox1033.Text = rd1["G22MA20_24"].ToString();
                    //TextBox1034.Text = rd1["G22MA25_49"].ToString();
                    //TextBox1035.Text = rd1["G22MA50"].ToString();
                    //TextBox1036.Text = rd1["SUBG22F"].ToString();
                    //TextBox1037.Text = rd1["G22FE1"].ToString();
                    //TextBox1038.Text = rd1["G22FE1_4"].ToString();
                    //TextBox1039.Text = rd1["G22FE5_9"].ToString();
                    //TextBox1040.Text = rd1["G22FE10_14"].ToString();
                    //TextBox1041.Text = rd1["G22FE15_19"].ToString();
                    //TextBox1042.Text = rd1["G22FE20_24"].ToString();
                    //TextBox1043.Text = rd1["G22FE25_49"].ToString();
                    //TextBox1044.Text = rd1["G22FE50"].ToString();
                    //TextBox1045.Text = rd1["G23_1"].ToString();
                    //TextBox1046.Text = rd1["G23_2"].ToString();
                    //TextBox1047.Text = rd1["TOTALG24"].ToString();
                    //TextBox1048.Text = rd1["SUBG24M"].ToString();
                    //TextBox1049.Text = rd1["G24MA15_19"].ToString();
                    //TextBox1050.Text = rd1["G24MA20_24"].ToString();
                    //TextBox1051.Text = rd1["G24MA25_49"].ToString();
                    //TextBox1052.Text = rd1["G24MA50"].ToString();
                    //TextBox1053.Text = rd1["SUBG24F"].ToString();
                    //TextBox1054.Text = rd1["G24FE15_19"].ToString();
                    //TextBox1055.Text = rd1["G24FE20_24"].ToString();
                    //TextBox1056.Text = rd1["G24FE25_49"].ToString();
                    //TextBox1057.Text = rd1["G24FE50"].ToString();
                    //TextBox1058.Text = rd1["TOTALG25"].ToString();
                    //TextBox1059.Text = rd1["SUBG25M"].ToString();
                    //TextBox1060.Text = rd1["G25MA15_19"].ToString();
                    //TextBox1061.Text = rd1["G25MA20_24"].ToString();
                    //TextBox1062.Text = rd1["G25MA25_49"].ToString();
                    //TextBox1063.Text = rd1["G25MA50"].ToString();
                    //TextBox1064.Text = rd1["SUBG25F"].ToString();
                    //TextBox1065.Text = rd1["G25FE15_19"].ToString();
                    //TextBox1066.Text = rd1["G25FE20_24"].ToString();
                    //TextBox1067.Text = rd1["G25FE25_49"].ToString();
                    //TextBox1068.Text = rd1["G25FE50"].ToString();
                    //TextBox1069.Text = rd1["TOTALG26"].ToString();
                    //TextBox1070.Text = rd1["G26MA1"].ToString();
                    //TextBox1071.Text = rd1["G26FE1"].ToString();

                    //cmd.ExecuteNonQuery();
                    //rd1.Close();
                    #endregion==============================================
                    T1 = 1;
                }
            }
            //rd1.Close();
            //cn.Close();
            //cmd.Dispose();
            //Session["editme"] = "false";
        }
        catch (Exception ex)
        {
            webMessage.Show(ex.Message.ToString());
            return;
        }
        #region  =========== HTC2 & HTC3
        //=============== HTC2
        string SQL2 = "SELECT * FROM tbl_HTC2 Where states = '" + mState.Trim() + "' and lga ='" + mLGA.Trim() + "' and facname ='" + mFacility.Trim() + "' and months ='" + mMnth.Trim() + "' and years ='" + mYr.Trim() + "' and grouptype ='" + mChoose.Trim() + "'";
        try
        {
            SqlConnection cn2 = new SqlConnection(ConnectAll.ConnectMe());
            cn2.Open();
            SqlCommand cmd2 = new SqlCommand(SQL2, cn2);
            SqlDataReader rd2 = cmd2.ExecuteReader();

            if (rd2 != null)
            {
                while (rd2.Read())
                {
                    TextBox790.Text = rd2["G8P10_14"].ToString();
                    TextBox791.Text = rd2["G8P15_19"].ToString();
                    TextBox792.Text = rd2["G8P20_24"].ToString();
                    TextBox793.Text = rd2["G8P25_49"].ToString();
                    TextBox794.Text = rd2["G8P50"].ToString();
                    TextBox795.Text = rd2["TOTALG9"].ToString();
                    TextBox796.Text = rd2["SUBG9M"].ToString();
                    TextBox797.Text = rd2["G9MA1"].ToString();
                    TextBox798.Text = rd2["G9MA1_4"].ToString();
                    TextBox799.Text = rd2["G9MA5_9"].ToString();
                    TextBox800.Text = rd2["G9MA10_14"].ToString();
                    TextBox801.Text = rd2["G9MA15_19"].ToString();
                    TextBox802.Text = rd2["G9MA20_24"].ToString();
                    TextBox803.Text = rd2["G9MA25_49"].ToString();
                    TextBox804.Text = rd2["G9MA50"].ToString();
                    TextBox805.Text = rd2["SUBG9F"].ToString();
                    TextBox806.Text = rd2["G9FE1"].ToString();
                    TextBox807.Text = rd2["G9FE1_4"].ToString();
                    TextBox808.Text = rd2["G9FE5_9"].ToString();
                    TextBox809.Text = rd2["G9FE10_14"].ToString();//data sent from PMTCT start from here
                    TextBox810.Text = rd2["G9FE15_19"].ToString();
                    TextBox811.Text = rd2["G9FE20_24"].ToString();
                    TextBox812.Text = rd2["G9FE25_49"].ToString();
                    TextBox813.Text = rd2["G9FE50"].ToString();
                    TextBox814.Text = rd2["TOTALG10"].ToString();
                    TextBox815.Text = rd2["SUBG10P"].ToString();
                    TextBox816.Text = rd2["G10P1"].ToString();
                    TextBox817.Text = rd2["G10P1_4"].ToString();
                    TextBox818.Text = rd2["G10P5_9"].ToString();
                    TextBox819.Text = rd2["G10P10_14"].ToString();
                    TextBox820.Text = rd2["G10P15_19"].ToString();
                    TextBox821.Text = rd2["G10P20_24"].ToString();
                    TextBox822.Text = rd2["G10P25_49"].ToString();
                    TextBox823.Text = rd2["G10P50"].ToString();
                    TextBox824.Text = rd2["SUBG10N"].ToString();
                    TextBox825.Text = rd2["G10N1"].ToString();
                    TextBox826.Text = rd2["G10N1_4"].ToString();
                    TextBox827.Text = rd2["G10N5_9"].ToString();
                    TextBox828.Text = rd2["G10N10_14"].ToString();
                    TextBox829.Text = rd2["G10N15_19"].ToString();
                    TextBox830.Text = rd2["G10N20_24"].ToString();
                    TextBox831.Text = rd2["G10N25_49"].ToString();
                    TextBox832.Text = rd2["G10N50"].ToString();
                    TextBox833.Text = rd2["TOTALG11"].ToString();
                    TextBox834.Text = rd2["SUBG11M"].ToString();
                    TextBox835.Text = rd2["G11MA1"].ToString();
                    TextBox836.Text = rd2["G11MA1_4"].ToString();
                    TextBox837.Text = rd2["G11MA5_9"].ToString();
                    TextBox838.Text = rd2["G11MA10_14"].ToString();
                    TextBox839.Text = rd2["G11MA15_19"].ToString();
                    TextBox840.Text = rd2["G11MA20_24"].ToString();
                    TextBox841.Text = rd2["G11MA25_49"].ToString();
                    TextBox842.Text = rd2["G11MA50"].ToString();
                    TextBox843.Text = rd2["SUBG11F"].ToString();
                    TextBox844.Text = rd2["G11FE1"].ToString();
                    TextBox845.Text = rd2["G11FE1_4"].ToString();
                    TextBox846.Text = rd2["G11FE5_9"].ToString();
                    TextBox847.Text = rd2["G11FE10_14"].ToString();
                    TextBox848.Text = rd2["G11FE15_19"].ToString();
                    TextBox849.Text = rd2["G11FE20_24"].ToString();
                    TextBox850.Text = rd2["G11FE25_49"].ToString();
                    TextBox851.Text = rd2["G11FE50"].ToString();
                    TextBox852.Text = rd2["TOTALG12"].ToString();
                    TextBox853.Text = rd2["SUBG12M"].ToString();
                    TextBox854.Text = rd2["G12MA1"].ToString();
                    TextBox855.Text = rd2["G12MA1_4"].ToString();
                    TextBox856.Text = rd2["G12MA5_9"].ToString();
                    TextBox857.Text = rd2["G12MA10_14"].ToString();
                    TextBox858.Text = rd2["G12MA15_19"].ToString();
                    TextBox859.Text = rd2["G12MA20_24"].ToString();
                    TextBox860.Text = rd2["G12MA25_49"].ToString();
                    TextBox861.Text = rd2["G12MA50"].ToString();
                    TextBox862.Text = rd2["SUBG12F"].ToString();
                    TextBox863.Text = rd2["G12FE1"].ToString();
                    TextBox864.Text = rd2["G12FE1_4"].ToString();
                    TextBox865.Text = rd2["G12FE5_9"].ToString();
                    TextBox866.Text = rd2["G12FE10_14"].ToString();
                    TextBox867.Text = rd2["G12FE15_19"].ToString();
                    TextBox868.Text = rd2["G12FE20_24"].ToString();
                    TextBox869.Text = rd2["G12FE25_49"].ToString();
                    TextBox870.Text = rd2["G12FE50"].ToString();
                    TextBox871.Text = rd2["TOTALG13"].ToString();
                    TextBox872.Text = rd2["SUBG13M"].ToString();
                    TextBox873.Text = rd2["G13MA1"].ToString();
                    TextBox874.Text = rd2["G13MA1_4"].ToString();
                    TextBox875.Text = rd2["G13MA5_9"].ToString();
                    TextBox876.Text = rd2["G13MA10_14"].ToString();
                    TextBox877.Text = rd2["G13MA15_19"].ToString();
                    TextBox878.Text = rd2["G13MA20_24"].ToString();
                    TextBox879.Text = rd2["G13MA25_49"].ToString();
                    TextBox880.Text = rd2["G13MA50"].ToString();
                    TextBox881.Text = rd2["SUBG13F"].ToString();
                    TextBox882.Text = rd2["G13FE1"].ToString();
                    TextBox883.Text = rd2["G13FE1_4"].ToString();
                    TextBox884.Text = rd2["G13FE5_9"].ToString();
                    TextBox885.Text = rd2["G13FE10_14"].ToString();
                    TextBox886.Text = rd2["G13FE15_19"].ToString();
                    TextBox887.Text = rd2["G13FE20_24"].ToString();
                    TextBox888.Text = rd2["G13FE25_49"].ToString();
                    TextBox889.Text = rd2["G13FE50"].ToString();
                    TextBox890.Text = rd2["TOTALG14"].ToString();
                    TextBox891.Text = rd2["SUBG14M"].ToString();
                    TextBox892.Text = rd2["G14MA1"].ToString();
                    TextBox893.Text = rd2["G14MA1_4"].ToString();
                    TextBox894.Text = rd2["G14MA5_9"].ToString();
                    TextBox895.Text = rd2["G14MA10_14"].ToString();
                    TextBox896.Text = rd2["G14MA15_19"].ToString();
                    TextBox897.Text = rd2["G14MA20_24"].ToString();
                    TextBox898.Text = rd2["G14MA25_49"].ToString();
                    TextBox899.Text = rd2["G14MA50"].ToString();
                    TextBox900.Text = rd2["SUBG14F"].ToString();
                    TextBox901.Text = rd2["G14FE1"].ToString();
                    TextBox902.Text = rd2["G14FE1_4"].ToString();
                    TextBox903.Text = rd2["G14FE5_9"].ToString();
                    TextBox904.Text = rd2["G14FE10_14"].ToString();
                    TextBox905.Text = rd2["G14FE15_19"].ToString();
                    TextBox906.Text = rd2["G14FE20_24"].ToString();
                    TextBox907.Text = rd2["G14FE25_49"].ToString();
                    TextBox908.Text = rd2["G14FE50"].ToString();
                    TextBox909.Text = rd2["TOTALG15"].ToString();
                    TextBox910.Text = rd2["SUBG15M"].ToString();
                    TextBox911.Text = rd2["G15MA15_19"].ToString();
                    TextBox912.Text = rd2["G15MA20_24"].ToString();
                    TextBox913.Text = rd2["G15MS25_49"].ToString();
                    TextBox914.Text = rd2["G15MA50"].ToString();
                    TextBox915.Text = rd2["SUBG15F"].ToString();
                    TextBox916.Text = rd2["G15FE15_19"].ToString();
                    TextBox917.Text = rd2["G15FE20_24"].ToString();
                    TextBox918.Text = rd2["G15FE25_49"].ToString();
                    TextBox919.Text = rd2["G15FE50"].ToString();
                    TextBox920.Text = rd2["TOTALG16"].ToString();
                    TextBox921.Text = rd2["SUBG16M"].ToString();
                    TextBox922.Text = rd2["G16MA15_19"].ToString();
                    TextBox923.Text = rd2["G16MA20_24"].ToString();
                    TextBox924.Text = rd2["G16MS25_49"].ToString();
                    TextBox925.Text = rd2["G16MA50"].ToString();
                    TextBox926.Text = rd2["SUBG16F"].ToString();
                    TextBox927.Text = rd2["G16FE15_19"].ToString();
                    TextBox928.Text = rd2["G16FE20_24"].ToString();
                    TextBox929.Text = rd2["G16FE25_49"].ToString();
                    TextBox930.Text = rd2["G16FE50"].ToString();
                   // Session["editme"] = "true";
                    T2 = 1;
                }
            }
            //rd2.Close();
            //cn2.Close();
            //cmd2.Dispose();
            Session["editme"] = "false";
        }
        catch (Exception ex)
        {
           webMessage.Show("HTC 2:" + ex.Message.ToString() );
            return;
        }
       // //=========== HTC 3
        string SQL3 = "SELECT * FROM tbl_HTC3 Where states = '" + mState.Trim() + "' and lga ='" + mLGA.Trim() + "' and months ='" + mMnth.Trim() + "' and years ='" + mYr.Trim() + "' and grouptype ='" + mChoose.Trim() + "' and facname ='" + mFacility.Trim() + "'";
        try
        {
            SqlConnection cn3 = new SqlConnection(ConnectAll.ConnectMe());
            cn3.Open();
            SqlCommand cmd3 = new SqlCommand(SQL3, cn3);
            SqlDataReader rd3 = cmd3.ExecuteReader();

            if (rd3 != null)
            {
                while (rd3.Read())
                {
                    TextBox931.Text = rd3["TOTALG17"].ToString();
                    TextBox932.Text = rd3["SUBG17M"].ToString();
                    TextBox933.Text = rd3["G17MA1"].ToString();
                    TextBox934.Text = rd3["G17MA1_4"].ToString();
                    TextBox935.Text = rd3["G17MA5_9"].ToString();
                    TextBox936.Text = rd3["G17MA10_14"].ToString();
                    TextBox937.Text = rd3["G17MA15_19"].ToString();
                    TextBox938.Text = rd3["G17MA20_24"].ToString();
                    TextBox939.Text = rd3["G17MA25_49"].ToString();
                    TextBox940.Text = rd3["G17MA50"].ToString();
                    TextBox941.Text = rd3["SUBG17F"].ToString();
                    TextBox942.Text = rd3["G17FE1"].ToString();
                    TextBox943.Text = rd3["G17FE1_4"].ToString();
                    TextBox944.Text = rd3["G17FE5_9"].ToString();
                    TextBox945.Text = rd3["G17FE10_14"].ToString();
                    TextBox946.Text = rd3["G17FE15_19"].ToString();
                    TextBox947.Text = rd3["G17FE20_24"].ToString();
                    TextBox948.Text = rd3["G17FE25_49"].ToString();
                    TextBox949.Text = rd3["G17FE50"].ToString();
                    TextBox950.Text = rd3["TOTALG18"].ToString();
                    TextBox951.Text = rd3["SUBG18M"].ToString();
                    TextBox952.Text = rd3["G18MA1"].ToString();
                    TextBox953.Text = rd3["G18MA1_4"].ToString();
                    TextBox954.Text = rd3["G18MA5_9"].ToString();
                    TextBox955.Text = rd3["G18MA10_14"].ToString();
                    TextBox956.Text = rd3["G18MA15_19"].ToString();
                    TextBox957.Text = rd3["G18MA20_24"].ToString();
                    TextBox958.Text = rd3["G18MA25_49"].ToString();
                    TextBox959.Text = rd3["G18MA50"].ToString();
                    TextBox960.Text = rd3["SUBG18F"].ToString();
                    TextBox961.Text = rd3["G18FE1"].ToString();
                    TextBox962.Text = rd3["G18FE1_4"].ToString();
                    TextBox963.Text = rd3["G18FE5_9"].ToString();
                    TextBox964.Text = rd3["G18FE10_14"].ToString();
                    TextBox965.Text = rd3["G18FE15_19"].ToString();
                    TextBox966.Text = rd3["G18FE20_24"].ToString();
                    TextBox967.Text = rd3["G18FE25_49"].ToString();
                    TextBox968.Text = rd3["G18FE50"].ToString();
                    TextBox969.Text = rd3["TOTALG19"].ToString();
                    TextBox970.Text = rd3["SUBG19M"].ToString();
                    TextBox971.Text = rd3["G19MA1"].ToString();
                    TextBox972.Text = rd3["G19MA1_4"].ToString();
                    TextBox973.Text = rd3["G98MA5_9"].ToString();
                    TextBox974.Text = rd3["G19MA10_14"].ToString();
                    TextBox975.Text = rd3["G19MA15_19"].ToString();
                    TextBox976.Text = rd3["G19MA20_24"].ToString();
                    TextBox977.Text = rd3["G19MA25_49"].ToString();
                    TextBox978.Text = rd3["G19MA50"].ToString();
                    TextBox979.Text = rd3["SUBG19F"].ToString();
                    TextBox980.Text = rd3["G19FE1"].ToString();
                    TextBox981.Text = rd3["G19FE1_4"].ToString();
                    TextBox982.Text = rd3["G19FE5_9"].ToString();
                    TextBox983.Text = rd3["G19FE10_14"].ToString();
                    TextBox984.Text = rd3["G19FE15_19"].ToString();
                    TextBox985.Text = rd3["G19FE20_24"].ToString();
                    TextBox986.Text = rd3["G19FE25_49"].ToString();
                    TextBox987.Text = rd3["G19FE50"].ToString();
                    TextBox988.Text = rd3["TOTALG20"].ToString();
                    TextBox989.Text = rd3["SUBG20M"].ToString();
                    TextBox990.Text = rd3["G20MA1"].ToString();
                    TextBox991.Text = rd3["G20MA1_4"].ToString();
                    TextBox992.Text = rd3["G20MA5_9"].ToString();
                    TextBox993.Text = rd3["G20MA10_14"].ToString();
                    TextBox994.Text = rd3["G20MA15_19"].ToString();
                    TextBox995.Text = rd3["G20MA20_24"].ToString();
                    TextBox996.Text = rd3["G20MA25_49"].ToString();
                    TextBox997.Text = rd3["G20MA50"].ToString();
                    TextBox998.Text = rd3["SUBG20F"].ToString();
                    TextBox999.Text = rd3["G20FE1"].ToString();
                    TextBox1000.Text = rd3["G20FE1_4"].ToString();
                    TextBox1001.Text = rd3["G20FE5_9"].ToString();
                    TextBox1002.Text = rd3["G20FE10_14"].ToString();
                    TextBox1003.Text = rd3["G20FE15_19"].ToString();
                    TextBox1004.Text = rd3["G20FE20_24"].ToString();
                    TextBox1005.Text = rd3["G20FE25_49"].ToString();
                    TextBox1006.Text = rd3["G20FE50"].ToString();
                    TextBox1007.Text = rd3["TOTALG21"].ToString();
                    TextBox1008.Text = rd3["SUBG21M"].ToString();
                    TextBox1009.Text = rd3["G21MA1"].ToString();
                    TextBox1010.Text = rd3["G21MA1_4"].ToString();
                    TextBox1011.Text = rd3["G21MA5_9"].ToString();
                    TextBox1012.Text = rd3["G21MA10_14"].ToString();
                    TextBox1013.Text = rd3["G21MA15_19"].ToString();
                    TextBox1014.Text = rd3["G21MA20_24"].ToString();
                    TextBox1015.Text = rd3["G21MA25_49"].ToString();
                    TextBox1016.Text = rd3["G21MA50"].ToString();
                    TextBox1017.Text = rd3["SUBG21F"].ToString();
                    TextBox1018.Text = rd3["G21FE1"].ToString();
                    TextBox1019.Text = rd3["G21FE1_4"].ToString();
                    TextBox1020.Text = rd3["G21FE5_9"].ToString();
                    TextBox1021.Text = rd3["G21FE10_14"].ToString();
                    TextBox1022.Text = rd3["G21FE15_19"].ToString();
                    TextBox1023.Text = rd3["G21FE20_24"].ToString();
                    TextBox1025.Text = rd3["G21FE25_49"].ToString();
                    TextBox1026.Text = rd3["TOTALG22"].ToString();
                    TextBox1027.Text = rd3["SUBG22M"].ToString();
                    TextBox1028.Text = rd3["G22MA1"].ToString();
                    TextBox1029.Text = rd3["G22MA1_4"].ToString();
                    TextBox1030.Text = rd3["G22MA5_9"].ToString();
                    TextBox1031.Text = rd3["G22MA10_14"].ToString();
                    TextBox1032.Text = rd3["G22MA15_19"].ToString();
                    TextBox1033.Text = rd3["G22MA20_24"].ToString();
                    TextBox1034.Text = rd3["G22MA25_49"].ToString();
                    TextBox1035.Text = rd3["G22MA50"].ToString();
                    TextBox1036.Text = rd3["SUBG22F"].ToString();
                    TextBox1037.Text = rd3["G22FE1"].ToString();
                    TextBox1038.Text = rd3["G22FE1_4"].ToString();
                    TextBox1039.Text = rd3["G22FE5_9"].ToString();
                    TextBox1040.Text = rd3["G22FE10_14"].ToString();
                    TextBox1041.Text = rd3["G22FE15_19"].ToString();
                    TextBox1042.Text = rd3["G22FE20_24"].ToString();
                    TextBox1043.Text = rd3["G22FE25_49"].ToString();
                    TextBox1044.Text = rd3["G22FE50"].ToString();
                    TextBox1045.Text = rd3["G23_1"].ToString();
                    TextBox1046.Text = rd3["G23_2"].ToString();
                    TextBox1047.Text = rd3["TOTALG24"].ToString();
                    TextBox1048.Text = rd3["SUBG24M"].ToString();
                    TextBox1049.Text = rd3["G24MA15_19"].ToString();
                    TextBox1050.Text = rd3["G24MA20_24"].ToString();
                    TextBox1051.Text = rd3["G24MA25_49"].ToString();
                    TextBox1052.Text = rd3["G24MA50"].ToString();
                    TextBox1053.Text = rd3["SUBG24F"].ToString();
                    TextBox1054.Text = rd3["G24FE15_19"].ToString();
                    TextBox1055.Text = rd3["G24FE20_24"].ToString();
                    TextBox1056.Text = rd3["G24FE25_49"].ToString();
                    TextBox1057.Text = rd3["G24FE50"].ToString();
                    TextBox1058.Text = rd3["TOTALG25"].ToString();
                    TextBox1059.Text = rd3["SUBG25M"].ToString();
                    TextBox1060.Text = rd3["G25MA15_19"].ToString();
                    TextBox1061.Text = rd3["G25MA20_24"].ToString();
                    TextBox1062.Text = rd3["G25MA25_49"].ToString();
                    TextBox1063.Text = rd3["G25MA50"].ToString();
                    TextBox1064.Text = rd3["SUBG25F"].ToString();
                    TextBox1065.Text = rd3["G25FE15_19"].ToString();
                    TextBox1066.Text = rd3["G25FE20_24"].ToString();
                    TextBox1067.Text = rd3["G25FE25_49"].ToString();
                    TextBox1068.Text = rd3["G25FE50"].ToString();
                    TextBox1069.Text = rd3["TOTALG26"].ToString();
                    TextBox1070.Text = rd3["G26MA1"].ToString();
                    TextBox1071.Text = rd3["G26FE1"].ToString();
                   // Session["editme"] = true;
                    T3 = 1;
                }
            }
           //========== checks
            if (T1 != -1 || T2 != -1 || T3 != -1)
            {
                Session["editme"] = "true";
                return;
            }
            else
            {
                Session["editme"] = "false";
                return;
            }
            
        }
        catch (Exception ex)
        {
           webMessage.Show("HTC 3:" + ex.Message.ToString());
            return;
        }
    }
#endregion
    protected void Edit_ART()
    {
        int T1 = -1; int T2 = -1;
      //======== ART=======
        string SQL = "SELECT * FROM tbl_ART1 Where months ='"+mMnth+"' and years ='"+mYr+"' and grouptype ='"+mChoose+"' and facname ='"+mFacility+"'";
        try
        {
         SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()); 
          cn.Open();
         SqlCommand cmd = new SqlCommand(SQL, cn);
        SqlDataReader rd = cmd.ExecuteReader();

        while (rd.Read())
        {
            TextBox87.Text = rd["TOTALG10"].ToString();
            TextBox248.Text = rd["TOTALG1"].ToString();
            TextBox249.Text = rd["SUBG1MA"].ToString();
            TextBox250.Text = rd["G1MA1"].ToString();
            TextBox251.Text = rd["G1MA1_4"].ToString();
            TextBox252.Text = rd["G1MA5_9"].ToString();
            TextBox253.Text = rd["G1MA10_14"].ToString();
            TextBox254.Text = rd["G1MA15_19"].ToString();
            TextBox255.Text = rd["G1MA20_24"].ToString();
            TextBox256.Text = rd["G1MA25_49"].ToString();
            TextBox257.Text = rd["G1MA50"].ToString();
            TextBox258.Text = rd["SUBG1FE"].ToString();
            TextBox259.Text = rd["G1FE1"].ToString();
            TextBox260.Text = rd["G1FE1_4"].ToString();
            TextBox261.Text = rd["G1FE5_9"].ToString();
            TextBox262.Text = rd["G1FE10_14"].ToString();
            TextBox263.Text = rd["G1FE15_19"].ToString();
            TextBox264.Text = rd["G1FE20_24"].ToString();
            TextBox265.Text = rd["G1FE25_49"].ToString();
            TextBox266.Text = rd["G1FE50"].ToString();
            TextBox1074.Text = rd["G1PREGNANT"].ToString();
            TextBox1075.Text = rd["G1BREASTFEED"].ToString();
            TextBox267.Text = rd["TOTALG2"].ToString();
            TextBox268.Text = rd["SUBG2MA"].ToString();
            TextBox269.Text = rd["G2MA1"].ToString();
            TextBox270.Text = rd["G2MA1_4"].ToString();
            TextBox271.Text = rd["G2MA5_9"].ToString();
            TextBox272.Text = rd["G2MA10_14"].ToString();
            TextBox273.Text = rd["G2MA15_19"].ToString();
            TextBox274.Text = rd["G2MA20_24"].ToString();
            TextBox275.Text = rd["G2MA25_49"].ToString();
            TextBox276.Text = rd["G2MA50"].ToString();
            TextBox277.Text = rd["SUBG2FE"].ToString();
            TextBox278.Text = rd["G2FE1"].ToString();
            TextBox279.Text = rd["G2FE1_4"].ToString();
            TextBox280.Text = rd["G2FE5_9"].ToString();
            TextBox281.Text = rd["G2FE10_14"].ToString();
            TextBox282.Text = rd["G2FE15_19"].ToString();
            TextBox283.Text = rd["G2FE20_24"].ToString();
            TextBox284.Text = rd["G2FE25_49"].ToString();
            TextBox285.Text = rd["G2FE50"].ToString();
            TextBox1072.Text = rd["G2PREGNANT"].ToString();
            TextBox1073.Text = rd["G2BREASTFEED"].ToString();
            TextBox286.Text = rd["TOTALG3"].ToString();
            TextBox287.Text = rd["SUBG3MA"].ToString();
            TextBox288.Text = rd["G3MA1"].ToString();
            TextBox289.Text = rd["G3MA1_4"].ToString();
            TextBox290.Text = rd["G3MA5_9"].ToString();
            TextBox291.Text = rd["G3MA10_14"].ToString();
            TextBox292.Text = rd["G3MA15_19"].ToString();
            TextBox293.Text = rd["G3MA20_24"].ToString();
            TextBox294.Text = rd["G3MA25_49"].ToString();
            TextBox295.Text = rd["G3MA50"].ToString();
            TextBox296.Text = rd["SUBG3FE"].ToString();

            TextBox297.Text = rd["G3FE1"].ToString();
            TextBox298.Text = rd["G3FE1_4"].ToString();
            TextBox299.Text = rd["G3FE5_9"].ToString();
            TextBox300.Text = rd["G3FE10_14"].ToString();
            TextBox301.Text = rd["G3FE15_19"].ToString();
            TextBox302.Text = rd["G3FE20_24"].ToString();
            TextBox303.Text = rd["G3FE25_49"].ToString();
            TextBox304.Text = rd["G3FE50"].ToString();
            TextBox305.Text = rd["G3PREGNANT"].ToString();
            TextBox306.Text = rd["G3BREASTFEED"].ToString();
            TextBox307.Text = rd["G3FSW"].ToString();
            TextBox308.Text = rd["G3MSM_TG"].ToString();
            TextBox309.Text = rd["G3PWID"].ToString();
            TextBox310.Text = rd["TOTALG4"].ToString();
            TextBox311.Text = rd["SUBG4MA"].ToString();
            TextBox312.Text = rd["G4MA1"].ToString();
            TextBox313.Text = rd["G4MA1_4"].ToString();
            TextBox314.Text = rd["G4MA5_9"].ToString();
            TextBox315.Text = rd["G4MA10_14"].ToString();
            TextBox316.Text = rd["G4MA15_19"].ToString();
            TextBox317.Text = rd["G4MA20_24"].ToString();
            TextBox318.Text = rd["G4MA25_49"].ToString();
            TextBox319.Text = rd["G4MA50"].ToString();
            TextBox320.Text = rd["SUBG4FE"].ToString();
            TextBox321.Text = rd["G4FE1"].ToString();
            TextBox322.Text = rd["G4FE1_4"].ToString();
            TextBox323.Text = rd["G4FE5_9"].ToString();
            TextBox324.Text = rd["G4FE10_14"].ToString();
            TextBox325.Text = rd["G4FE15_19"].ToString();
            TextBox326.Text = rd["G4FE20_24"].ToString();
            TextBox327.Text = rd["G4FE25_49"].ToString();
            TextBox328.Text = rd["G4FE50"].ToString();
            TextBox329.Text = rd["TOTALG5"].ToString();
            TextBox330.Text = rd["SUBG5MA"].ToString();
            TextBox331.Text = rd["G5MA1"].ToString();
            TextBox332.Text = rd["G5MA1_4"].ToString();
            TextBox333.Text = rd["G5MA5_9"].ToString();
            TextBox334.Text = rd["G5MA10_14"].ToString();
            TextBox335.Text = rd["G5MA15_19"].ToString();
            TextBox336.Text = rd["G5MA20_24"].ToString();
            TextBox337.Text = rd["G5MA25_49"].ToString();
            TextBox338.Text = rd["G5MA50"].ToString();
            TextBox339.Text = rd["SUBG5FE"].ToString();
            TextBox340.Text = rd["G54FE1"].ToString();
            TextBox341.Text = rd["G5FE1_4"].ToString();
            TextBox342.Text = rd["G5FE5_9"].ToString();
            TextBox343.Text = rd["G5FE10_14"].ToString();
            TextBox344.Text = rd["G5FE15_19"].ToString();
            TextBox345.Text = rd["G5FE20_24"].ToString();
            TextBox346.Text = rd["G5FE25_49"].ToString();
            TextBox347.Text = rd["G5FE50"].ToString();
            TextBox348.Text = rd["TOTALG6"].ToString();
            TextBox349.Text = rd["SUBG6MA"].ToString();
            TextBox350.Text = rd["G6MA1"].ToString();
            TextBox351.Text = rd["G6MA1_4"].ToString();
            TextBox352.Text = rd["G6MA5_9"].ToString();
            TextBox353.Text = rd["G6MA10_14"].ToString();
            TextBox354.Text = rd["G6MA15_19"].ToString();
            TextBox355.Text = rd["G6MA20_24"].ToString();
            TextBox356.Text = rd["G6MA25_49"].ToString();
            TextBox357.Text = rd["G6MA50"].ToString();
            TextBox358.Text = rd["SUBG6FE"].ToString();
            TextBox359.Text = rd["G6FE1"].ToString();
            TextBox360.Text = rd["G6FE1_4"].ToString();
            TextBox361.Text = rd["G6FE5_9"].ToString();
            TextBox362.Text = rd["G6FE10_14"].ToString();
            TextBox363.Text = rd["G6FE15_19"].ToString();
            TextBox364.Text = rd["G6FE20_24"].ToString();
            TextBox365.Text = rd["G6FE25_49"].ToString();
            TextBox366.Text = rd["G6FE50"].ToString();
            TextBox367.Text = rd["TOTALG7"].ToString();
            TextBox368.Text = rd["SUBG7MA"].ToString();
            TextBox369.Text = rd["G7MA1"].ToString();
            TextBox370.Text = rd["G7MA1_4"].ToString();
            TextBox371.Text = rd["G7MA5_9"].ToString();
            TextBox372.Text = rd["G7MA10_14"].ToString();
            TextBox373.Text = rd["G7MA15_19"].ToString();
            TextBox374.Text = rd["G7MA20_24"].ToString();
            TextBox375.Text = rd["G7MA25_49"].ToString();
            TextBox376.Text = rd["G7MA50"].ToString();
            TextBox377.Text = rd["SUBG7FE"].ToString();
            TextBox378.Text = rd["G7FE1"].ToString();
            TextBox379.Text = rd["G7FE1_4"].ToString();
            TextBox380.Text = rd["G7FE5_9"].ToString();
            TextBox381.Text = rd["G7FE10_14"].ToString();
            TextBox382.Text = rd["G7FE15_19"].ToString();
            TextBox383.Text = rd["G7FE20_24"].ToString();
            TextBox384.Text = rd["G7FE25_49"].ToString();
            TextBox385.Text = rd["G7FE50"].ToString();
            TextBox386.Text = rd["TOTALG8"].ToString();
            TextBox387.Text = rd["SUBG8MA"].ToString();
            TextBox388.Text = rd["G8MA1"].ToString();
            TextBox389.Text = rd["G8MA1_4"].ToString();
            TextBox390.Text = rd["G8MA5_9"].ToString();
            TextBox391.Text = rd["G8MA10_14"].ToString();
            TextBox392.Text = rd["G8MA15_19"].ToString();
            TextBox393.Text = rd["G8MA20_24"].ToString();
            TextBox394.Text = rd["G8MA25_49"].ToString();
            TextBox395.Text = rd["G8MA50"].ToString();
            TextBox396.Text = rd["SUBG8FE"].ToString();
            TextBox397.Text = rd["G8FE1"].ToString();
            TextBox398.Text = rd["G8FE1_4"].ToString();
            TextBox399.Text = rd["G8FE5_9"].ToString();
            TextBox400.Text = rd["G8FE10_14"].ToString();
            TextBox401.Text = rd["G8FE15_19"].ToString();
            TextBox402.Text = rd["G8FE20_24"].ToString();
            TextBox403.Text = rd["G8FE25_49"].ToString();
            TextBox404.Text = rd["G8FE50"].ToString();
            TextBox405.Text = rd["TOTALG9"].ToString();
            TextBox406.Text = rd["SUBG9MA"].ToString();
            TextBox407.Text = rd["G9MA1"].ToString();
            TextBox408.Text = rd["G9MA1_4"].ToString();
            TextBox409.Text = rd["G9MA5_9"].ToString();
            TextBox410.Text = rd["G9MA10_14"].ToString();
            TextBox411.Text = rd["G9MA15_19"].ToString();
            TextBox412.Text = rd["G9MA20_24"].ToString();
            TextBox413.Text = rd["G9MA25_49"].ToString();
            TextBox414.Text = rd["G9MA50"].ToString();
            TextBox415.Text = rd["SUBG9FE"].ToString();
            TextBox416.Text = rd["G9FE1"].ToString();
            TextBox417.Text = rd["G9FE1_4"].ToString();
            TextBox418.Text = rd["G9FE5_9"].ToString();
            TextBox419.Text = rd["G9FE10_14"].ToString();
            TextBox420.Text = rd["G9FE15_19"].ToString();
            TextBox421.Text = rd["G9FE20_24"].ToString();
            TextBox422.Text = rd["G9FE25_49"].ToString();
            TextBox423.Text = rd["G9FE50"].ToString();
            TextBox424.Text = rd["TOTALG10"].ToString();
            TextBox425.Text = rd["SUBG10MA"].ToString();
            TextBox426.Text = rd["G10MA1"].ToString();
            TextBox427.Text = rd["G10MA1_4"].ToString();
            TextBox428.Text = rd["G10MA5_9"].ToString();
            TextBox429.Text = rd["G10MA10_14"].ToString();
            TextBox430.Text = rd["G10MA15_19"].ToString();
            TextBox431.Text = rd["G10MA20_24"].ToString();
            TextBox432.Text = rd["G10MA25_49"].ToString();
            T1 = 1;
         }
       
        }
        catch (Exception ex)
        {
            webMessage.Show("ERROR ART1: "+ ex.Message.ToString() );
            return;
        }

        try
        {
            string SQL1 = "SELECT * FROM tbl_ART2 Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

             SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()); 
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader rd1 = cmd1.ExecuteReader();

            while (rd1.Read())
            {
                // ============= ART2=============
                //mState.text=rd1["states"].ToString();
                //mLGA.text=rd1["lga"].ToString();
                //mFacility.text=rd1["facname"].ToString();
                // mMnth.text=rd1["months"].ToString();
                //mYr.text=rd1["years"].ToString();
                // mChoose.text=rd1["grouptype"].ToString();

                TextBox433.Text = rd1["G10MA50"].ToString();
                TextBox434.Text = rd1["SUBG10FE"].ToString();
                TextBox435.Text = rd1["G10FE1"].ToString();
                TextBox436.Text = rd1["G10FE1_4"].ToString();
                TextBox437.Text = rd1["G10FE5_9"].ToString();
                TextBox438.Text = rd1["G10FE10_14"].ToString();
                TextBox439.Text = rd1["G10FE15_19"].ToString();
                TextBox440.Text = rd1["G10FE20_24"].ToString();
                TextBox441.Text = rd1["G10FE25_49"].ToString();
                TextBox442.Text = rd1["G10FE50"].ToString();
                TextBox443.Text = rd1["G10PREGNANT"].ToString();
                TextBox444.Text = rd1["G10BREASTFEED"].ToString();
                TextBox445.Text = rd1["G10ROUTINE"].ToString();
                TextBox446.Text = rd1["G10TARGET"].ToString();
                TextBox447.Text = rd1["TOTALG11"].ToString();
                TextBox448.Text = rd1["SUBG11MA"].ToString();
                TextBox449.Text = rd1["G11MA1"].ToString();
                TextBox450.Text = rd1["G11MA1_4"].ToString();
                TextBox451.Text = rd1["G11MA5_9"].ToString();
                TextBox452.Text = rd1["G11MA10_14"].ToString();
                TextBox453.Text = rd1["G11MA15_19"].ToString();
                TextBox454.Text = rd1["G11MA20_24"].ToString();
                TextBox455.Text = rd1["G11MA25_49"].ToString();
                TextBox456.Text = rd1["G11MA50"].ToString();
                TextBox457.Text = rd1["SUBG11FE"].ToString();
                TextBox458.Text = rd1["G11FE1"].ToString();
                TextBox459.Text = rd1["G11FE1_4"].ToString();
                TextBox460.Text = rd1["G11FE5_9"].ToString();
                TextBox461.Text = rd1["G11FE10_14"].ToString();
                TextBox462.Text = rd1["G11FE15_19"].ToString();
                TextBox463.Text = rd1["G11FE20_24"].ToString();
                TextBox464.Text = rd1["G11FE25_49"].ToString();
                TextBox465.Text = rd1["G11FE50"].ToString();
                TextBox466.Text = rd1["G11PREGNANT"].ToString();
                TextBox467.Text = rd1["G11BREASTFEED"].ToString();
                TextBox468.Text = rd1["G11ROUTINE"].ToString();
                TextBox469.Text = rd1["G11TARGET"].ToString();
                TextBox470.Text = rd1["TOTALG12"].ToString();
                TextBox471.Text = rd1["SUBG12MA"].ToString();
                TextBox472.Text = rd1["G12MA1"].ToString();
                TextBox473.Text = rd1["G12MA1_4"].ToString();
                TextBox474.Text = rd1["G12MA5_9"].ToString();
                TextBox475.Text = rd1["G12MA10_14"].ToString();
                TextBox476.Text = rd1["G12MA15_19"].ToString();
                TextBox477.Text = rd1["G12MA20_24"].ToString();
                TextBox478.Text = rd1["G12MA25_49"].ToString();
                TextBox479.Text = rd1["G12MA50"].ToString();
                TextBox480.Text = rd1["SUBG12FE"].ToString();
                TextBox481.Text = rd1["G12FE1"].ToString();
                TextBox482.Text = rd1["G12FE1_4"].ToString();
                TextBox483.Text = rd1["G12FE5_9"].ToString();
                TextBox484.Text = rd1["G12FE10_14"].ToString();
                TextBox485.Text = rd1["G12FE15_19"].ToString();
                TextBox486.Text = rd1["G12FE20_24"].ToString();
                TextBox487.Text = rd1["G12FE25_49"].ToString();
                TextBox488.Text = rd1["G12FE50"].ToString();
                TextBox489.Text = rd1["G12PREGNANT"].ToString();
                TextBox490.Text = rd1["G12BREASTFEED"].ToString();
                TextBox491.Text = rd1["TOTALG13"].ToString();
                TextBox492.Text = rd1["SUBG13MA"].ToString();
                TextBox493.Text = rd1["G13MA1"].ToString();
                TextBox494.Text = rd1["G13MA1_4"].ToString();
                TextBox495.Text = rd1["G13MA5_9"].ToString();
                TextBox496.Text = rd1["G13MA10_14"].ToString();
                TextBox497.Text = rd1["G13MA15_19"].ToString();
                TextBox498.Text = rd1["G13MA20_24"].ToString();
                TextBox499.Text = rd1["G13MA25_49"].ToString();
                TextBox500.Text = rd1["G13MA50"].ToString();
                TextBox501.Text = rd1["SUBG13FE"].ToString();
                TextBox502.Text = rd1["G13FE1"].ToString();
                TextBox503.Text = rd1["G13FE1_4"].ToString();
                TextBox504.Text = rd1["G13FE5_9"].ToString();
                TextBox505.Text = rd1["G13FE10_14"].ToString();
                TextBox506.Text = rd1["G13FE15_19"].ToString();
                TextBox507.Text = rd1["G13FE20_24"].ToString();
                TextBox508.Text = rd1["G13FE25_49"].ToString();
                TextBox509.Text = rd1["G13FE50"].ToString();
                TextBox510.Text = rd1["G13PREGNANT"].ToString();
                TextBox511.Text = rd1["G13BREASTFEED"].ToString();
                TextBox512.Text = rd1["TOTALG14"].ToString();
                TextBox513.Text = rd1["SUBG14MA"].ToString();
                TextBox514.Text = rd1["G14MA1"].ToString();
                TextBox515.Text = rd1["G14MA1_4"].ToString();
                TextBox516.Text = rd1["G14MA5_9"].ToString();
                TextBox517.Text = rd1["G14MA10_14"].ToString();
                TextBox518.Text = rd1["G14MA15_19"].ToString();
                TextBox519.Text = rd1["G14MA20_24"].ToString();
                TextBox520.Text = rd1["G14MA25_49"].ToString();
                TextBox521.Text = rd1["G14MA50"].ToString();
                TextBox522.Text = rd1["SUBG14FE"].ToString();
                TextBox523.Text = rd1["G14FE1"].ToString();
                TextBox524.Text = rd1["G14FE1_4"].ToString();
                TextBox525.Text = rd1["G14FE5_9"].ToString();
                TextBox526.Text = rd1["G14FE10_14"].ToString();
                TextBox527.Text = rd1["G14FE15_19"].ToString();
                TextBox528.Text = rd1["G14FE20_24"].ToString();
                TextBox529.Text = rd1["G14FE25_49"].ToString();
                TextBox530.Text = rd1["G14FE50"].ToString();
                TextBox531.Text = rd1["G14UNDETECTABLE"].ToString();
                TextBox532.Text = rd1["G14DETECTABLE"].ToString();
                TextBox533.Text = rd1["TOTALG15"].ToString();
                TextBox534.Text = rd1["SUBG15MA"].ToString();
                TextBox535.Text = rd1["G15MA1"].ToString();
                TextBox536.Text = rd1["G15MA1_4"].ToString();
                TextBox537.Text = rd1["G15MA5_9"].ToString();
                TextBox538.Text = rd1["G15MA10_14"].ToString();
                TextBox539.Text = rd1["G15MA15_19"].ToString();
                TextBox540.Text = rd1["G15MA20_24"].ToString();
                TextBox541.Text = rd1["G15MA25_49"].ToString();
                TextBox542.Text = rd1["G15MA50"].ToString();
                TextBox543.Text = rd1["SUBG15FE"].ToString();
                TextBox544.Text = rd1["G15FE1"].ToString();
                TextBox545.Text = rd1["G15FE1_4"].ToString();
                TextBox546.Text = rd1["G15FE5_9"].ToString();
                TextBox547.Text = rd1["G15FE10_14"].ToString();
                TextBox548.Text = rd1["G15FE15_19"].ToString();
                TextBox549.Text = rd1["G15FE20_24"].ToString();
                TextBox550.Text = rd1["G15FE25_49"].ToString();
                TextBox551.Text = rd1["G15FE50"].ToString();
                TextBox552.Text = rd1["G15UNDETECTABLE"].ToString();
                TextBox553.Text = rd1["G15DETECTABLE"].ToString();
                TextBox554.Text = rd1["TOTALG16"].ToString();
                TextBox555.Text = rd1["SUBG16MA"].ToString();
                TextBox556.Text = rd1["G16MA1"].ToString();
                TextBox557.Text = rd1["G16MA1_4"].ToString();
                TextBox558.Text = rd1["G16MA5_9"].ToString();
                TextBox559.Text = rd1["G16MA10_14"].ToString();
                TextBox560.Text = rd1["G16MA15_19"].ToString();
                TextBox561.Text = rd1["G16MA20_24"].ToString();
                TextBox562.Text = rd1["G16MA25_49"].ToString();
                TextBox563.Text = rd1["G16MA50"].ToString();
                TextBox564.Text = rd1["SUBG16FE"].ToString();
                TextBox565.Text = rd1["G16FE1"].ToString();
                TextBox566.Text = rd1["G16FE1_4"].ToString();
                TextBox567.Text = rd1["G16FE5_9"].ToString();
                TextBox568.Text = rd1["G16FE10_14"].ToString();
                TextBox569.Text = rd1["G16FE15_19"].ToString();
                TextBox570.Text = rd1["G16FE20_24"].ToString();
                TextBox571.Text = rd1["G16FE25_49"].ToString();
                TextBox572.Text = rd1["G16FE50"].ToString();
                TextBox573.Text = rd1["TOTALG17"].ToString();
                TextBox574.Text = rd1["SUBG17MA"].ToString();
                TextBox575.Text = rd1["G17MA1"].ToString();
                TextBox576.Text = rd1["G17MA1_4"].ToString();
                TextBox577.Text = rd1["G17MA5_9"].ToString();
                TextBox578.Text = rd1["G17MA10_14"].ToString();
                TextBox579.Text = rd1["G17MA15_19"].ToString();
                TextBox580.Text = rd1["G17MA20_24"].ToString();
                TextBox581.Text = rd1["G17MA25_49"].ToString();
                TextBox582.Text = rd1["G17MA50"].ToString();
                TextBox583.Text = rd1["SUBG17FE"].ToString();
                TextBox584.Text = rd1["G17FE1"].ToString();
                TextBox585.Text = rd1["G17FE1_4"].ToString();
                TextBox586.Text = rd1["G17FE5_9"].ToString();
                TextBox587.Text = rd1["G17FE10_14"].ToString();
                TextBox588.Text = rd1["G17FE15_19"].ToString();
                TextBox589.Text = rd1["G17FE20_24"].ToString();
                TextBox590.Text = rd1["G17FE25_49"].ToString();
                TextBox591.Text = rd1["G17FE50"].ToString();
                TextBox592.Text = rd1["TOTALG18"].ToString();
                TextBox593.Text = rd1["SUBG18MA"].ToString();
                TextBox594.Text = rd1["G18MA1"].ToString();
                TextBox595.Text = rd1["G18MA1_4"].ToString();
                TextBox596.Text = rd1["G18MA5_9"].ToString();
                TextBox597.Text = rd1["G18MA10_14"].ToString();
                TextBox598.Text = rd1["G18MA15_19"].ToString();
                TextBox599.Text = rd1["G18MA20_24"].ToString();
                TextBox600.Text = rd1["G18MA25_49"].ToString();
                TextBox601.Text = rd1["G18MA50"].ToString();
                TextBox602.Text = rd1["SUBG18FE"].ToString();
                TextBox603.Text = rd1["G18FE1"].ToString();
                TextBox604.Text = rd1["G18FE1_4"].ToString();
                TextBox605.Text = rd1["G18FE5_9"].ToString();
                TextBox606.Text = rd1["G18FE10_14"].ToString();
                TextBox607.Text = rd1["G18FE15_19"].ToString();
                TextBox608.Text = rd1["G18FE20_24"].ToString();
                TextBox609.Text = rd1["G18FE25_49"].ToString();
                TextBox610.Text = rd1["G18FE50"].ToString();
                T2 = 1;
            }
            if (T1 != -1 || T2 != -1)
            {
                Session["editme"] = "true";
            }
            else
            {
                Session["editme"] = "false";
            }
        }catch(Exception ex)
        {
            
           webMessage.Show("ERROR ART2 : " + ex.Message.ToString());
            return;
        }
     
    }

     protected void TextBox10_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text) + Convert.ToInt32(TextBox6.Text)
                       + Convert.ToInt32(TextBox7.Text) + Convert.ToInt32(TextBox8.Text) + Convert.ToInt32(TextBox9.Text) + Convert.ToInt32(TextBox10.Text));
        TextBox12.Focus();
    }
    protected void TextBox19_TextChanged(object sender, EventArgs e)
    {
        TextBox11.Text = Convert.ToString(Convert.ToInt32(TextBox12.Text) + Convert.ToInt32(TextBox13.Text) + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text)
                       + Convert.ToInt32(TextBox16.Text) + Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox19.Text));
        TextBox1.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox11.Text));
        TextBox22.Focus();
    }
    protected void TextBox29_TextChanged(object sender, EventArgs e)
    {
        TextBox21.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox24.Text) + Convert.ToInt32(TextBox25.Text)
                       + Convert.ToInt32(TextBox26.Text) + Convert.ToInt32(TextBox27.Text) + Convert.ToInt32(TextBox28.Text) + Convert.ToInt32(TextBox29.Text));
        TextBox31.Focus();
    }
    protected void TextBox38_TextChanged(object sender, EventArgs e)
    {
        TextBox30.Text = Convert.ToString(Convert.ToInt32(TextBox31.Text) + Convert.ToInt32(TextBox32.Text) + Convert.ToInt32(TextBox33.Text) + Convert.ToInt32(TextBox34.Text)
                       + Convert.ToInt32(TextBox35.Text) + Convert.ToInt32(TextBox36.Text) + Convert.ToInt32(TextBox37.Text) + Convert.ToInt32(TextBox38.Text));
        TextBox20.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + Convert.ToInt32(TextBox30.Text));
        TextBox41.Focus();
    }
    protected void TextBox48_TextChanged(object sender, EventArgs e)
    {
        TextBox40.Text = Convert.ToString(Convert.ToInt32(TextBox41.Text) + Convert.ToInt32(TextBox42.Text) + Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox44.Text)
                      + Convert.ToInt32(TextBox45.Text) + Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox47.Text) + Convert.ToInt32(TextBox48.Text));
        TextBox50.Focus();
    }
    protected void TextBox57_TextChanged(object sender, EventArgs e)
    {
        TextBox49.Text = Convert.ToString(Convert.ToInt32(TextBox50.Text) + Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox52.Text) + Convert.ToInt32(TextBox53.Text)
                       + Convert.ToInt32(TextBox54.Text) + Convert.ToInt32(TextBox55.Text) + Convert.ToInt32(TextBox56.Text) + Convert.ToInt32(TextBox57.Text));
        TextBox39.Text = Convert.ToString(Convert.ToInt32(TextBox40.Text) + Convert.ToInt32(TextBox49.Text));
        TextBox60.Focus();
    }
    protected void TextBox67_TextChanged(object sender, EventArgs e)
    {
        TextBox59.Text = Convert.ToString(Convert.ToInt32(TextBox60.Text) + Convert.ToInt32(TextBox61.Text) + Convert.ToInt32(TextBox62.Text) + Convert.ToInt32(TextBox63.Text)
                     + Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox65.Text) + Convert.ToInt32(TextBox66.Text) + Convert.ToInt32(TextBox67.Text));
        TextBox69.Focus();
    }
    protected void TextBox76_TextChanged(object sender, EventArgs e)
    {
        TextBox68.Text = Convert.ToString(Convert.ToInt32(TextBox69.Text) + Convert.ToInt32(TextBox70.Text) + Convert.ToInt32(TextBox71.Text) + Convert.ToInt32(TextBox72.Text)
                       + Convert.ToInt32(TextBox73.Text) + Convert.ToInt32(TextBox74.Text) + Convert.ToInt32(TextBox75.Text) + Convert.ToInt32(TextBox76.Text));
        TextBox68.Text = Convert.ToString(Convert.ToInt32(TextBox59.Text) + Convert.ToInt32(TextBox68.Text));
        TextBox79.Focus();
    }
    protected void TextBox86_TextChanged(object sender, EventArgs e)
    {
        TextBox78.Text = Convert.ToString(Convert.ToInt32(TextBox79.Text) + Convert.ToInt32(TextBox80.Text) + Convert.ToInt32(TextBox81.Text) + Convert.ToInt32(TextBox82.Text)
                     + Convert.ToInt32(TextBox83.Text) + Convert.ToInt32(TextBox84.Text) + Convert.ToInt32(TextBox85.Text) + Convert.ToInt32(TextBox86.Text));
        TextBox88.Focus();
    }
    protected void TextBox95_TextChanged(object sender, EventArgs e)
    {
        TextBox87.Text = Convert.ToString(Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text) + Convert.ToInt32(TextBox90.Text) + Convert.ToInt32(TextBox91.Text)
                       + Convert.ToInt32(TextBox92.Text) + Convert.ToInt32(TextBox93.Text) + Convert.ToInt32(TextBox94.Text) + Convert.ToInt32(TextBox95.Text));
        
        TextBox77.Text = Convert.ToString(Convert.ToInt32(TextBox78.Text) + Convert.ToInt32(TextBox87.Text));
        TextBox98.Focus();
    }
    protected void TextBox105_TextChanged(object sender, EventArgs e)
    {
        TextBox97.Text = Convert.ToString(Convert.ToInt32(TextBox98.Text) + Convert.ToInt32(TextBox99.Text) + Convert.ToInt32(TextBox100.Text) + Convert.ToInt32(TextBox101.Text)
                     + Convert.ToInt32(TextBox102.Text) + Convert.ToInt32(TextBox103.Text) + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox105.Text));
        TextBox107.Focus();
    }
    protected void TextBox114_TextChanged(object sender, EventArgs e)
    {
        TextBox106.Text = Convert.ToString(Convert.ToInt32(TextBox107.Text) + Convert.ToInt32(TextBox108.Text) + Convert.ToInt32(TextBox109.Text) + Convert.ToInt32(TextBox110.Text)
                       + Convert.ToInt32(TextBox111.Text) + Convert.ToInt32(TextBox112.Text) + Convert.ToInt32(TextBox113.Text) + Convert.ToInt32(TextBox114.Text));
        
        TextBox96.Text = Convert.ToString(Convert.ToInt32(TextBox97.Text) + Convert.ToInt32(TextBox106.Text));
        TextBox117.Focus();
    }

    protected void TextBox124_TextChanged(object sender, EventArgs e)
    {
        TextBox116.Text = Convert.ToString(Convert.ToInt32(TextBox117.Text) + Convert.ToInt32(TextBox118.Text) + Convert.ToInt32(TextBox119.Text) + Convert.ToInt32(TextBox120.Text)
                    + Convert.ToInt32(TextBox121.Text) + Convert.ToInt32(TextBox122.Text) + Convert.ToInt32(TextBox123.Text) + Convert.ToInt32(TextBox124.Text));
        TextBox126.Focus();
    }
    protected void TextBox133_TextChanged(object sender, EventArgs e)
    {
        TextBox125.Text = Convert.ToString(Convert.ToInt32(TextBox126.Text) + Convert.ToInt32(TextBox127.Text) + Convert.ToInt32(TextBox128.Text) + Convert.ToInt32(TextBox129.Text)
                      + Convert.ToInt32(TextBox130.Text) + Convert.ToInt32(TextBox131.Text) + Convert.ToInt32(TextBox132.Text) + Convert.ToInt32(TextBox133.Text));

        TextBox115.Text = Convert.ToString(Convert.ToInt32(TextBox116.Text) + Convert.ToInt32(TextBox125.Text));
        TextBox136.Focus();
    }
    protected void TextBox143_TextChanged(object sender, EventArgs e)
    {
        TextBox135.Text = Convert.ToString(Convert.ToInt32(TextBox136.Text) + Convert.ToInt32(TextBox137.Text) + Convert.ToInt32(TextBox138.Text) + Convert.ToInt32(TextBox139.Text)
                   + Convert.ToInt32(TextBox140.Text) + Convert.ToInt32(TextBox141.Text) + Convert.ToInt32(TextBox142.Text) + Convert.ToInt32(TextBox143.Text));
        TextBox145.Focus();
    }
    protected void TextBox152_TextChanged(object sender, EventArgs e)
    {
        TextBox144.Text = Convert.ToString(Convert.ToInt32(TextBox145.Text) + Convert.ToInt32(TextBox146.Text) + Convert.ToInt32(TextBox147.Text) + Convert.ToInt32(TextBox148.Text)
                      + Convert.ToInt32(TextBox149.Text) + Convert.ToInt32(TextBox150.Text) + Convert.ToInt32(TextBox151.Text) + Convert.ToInt32(TextBox152.Text));

        TextBox134.Text = Convert.ToString(Convert.ToInt32(TextBox135.Text) + Convert.ToInt32(TextBox144.Text));
        TextBox155.Focus();
    }
    protected void TextBox162_TextChanged(object sender, EventArgs e)
    {
        TextBox154.Text = Convert.ToString(Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox156.Text) + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox158.Text)
                   + Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox160.Text) + Convert.ToInt32(TextBox161.Text) + Convert.ToInt32(TextBox162.Text));
        TextBox164.Focus();
    }
    protected void TextBox171_TextChanged(object sender, EventArgs e)
    {
        TextBox163.Text = Convert.ToString(Convert.ToInt32(TextBox164.Text) + Convert.ToInt32(TextBox165.Text) + Convert.ToInt32(TextBox166.Text) + Convert.ToInt32(TextBox167.Text)
              + Convert.ToInt32(TextBox168.Text) + Convert.ToInt32(TextBox169.Text) + Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text));

        TextBox153.Text = Convert.ToString(Convert.ToInt32(TextBox154.Text) + Convert.ToInt32(TextBox163.Text));
        TextBox174.Focus();
    }
    protected void TextBox181_TextChanged(object sender, EventArgs e)
    {
        TextBox173.Text = Convert.ToString(Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text) + Convert.ToInt32(TextBox176.Text) + Convert.ToInt32(TextBox177.Text)
                 + Convert.ToInt32(TextBox178.Text) + Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text) + Convert.ToInt32(TextBox181.Text));
        TextBox183.Focus();
    }
    protected void TextBox190_TextChanged(object sender, EventArgs e)
    {
        TextBox182.Text = Convert.ToString(Convert.ToInt32(TextBox183.Text) + Convert.ToInt32(TextBox184.Text) + Convert.ToInt32(TextBox185.Text) + Convert.ToInt32(TextBox186.Text)
             + Convert.ToInt32(TextBox187.Text) + Convert.ToInt32(TextBox188.Text) + Convert.ToInt32(TextBox189.Text) + Convert.ToInt32(TextBox190.Text));

        TextBox172.Text = Convert.ToString(Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox182.Text));
        TextBox193.Focus();
    }
    protected void TextBox200_TextChanged(object sender, EventArgs e)
    {
        TextBox192.Text = Convert.ToString(Convert.ToInt32(TextBox193.Text) + Convert.ToInt32(TextBox194.Text) + Convert.ToInt32(TextBox195.Text) + Convert.ToInt32(TextBox196.Text)
               + Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox198.Text) + Convert.ToInt32(TextBox199.Text) + Convert.ToInt32(TextBox200.Text));
        TextBox202.Focus();
    }
    protected void TextBox209_TextChanged(object sender, EventArgs e)
    {
        TextBox201.Text = Convert.ToString(Convert.ToInt32(TextBox202.Text) + Convert.ToInt32(TextBox203.Text) + Convert.ToInt32(TextBox204.Text) + Convert.ToInt32(TextBox205.Text)
             + Convert.ToInt32(TextBox206.Text) + Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text));

        TextBox191.Text = Convert.ToString(Convert.ToInt32(TextBox192.Text) + Convert.ToInt32(TextBox201.Text));
        TextBox212.Focus();
    }
    protected void TextBox219_TextChanged(object sender, EventArgs e)
    {
        TextBox211.Text = Convert.ToString(Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text) + Convert.ToInt32(TextBox215.Text)
               + Convert.ToInt32(TextBox216.Text) + Convert.ToInt32(TextBox217.Text) + Convert.ToInt32(TextBox218.Text) + Convert.ToInt32(TextBox219.Text));
        TextBox221.Focus();
    }
    protected void TextBox228_TextChanged(object sender, EventArgs e)
    {
        TextBox220.Text = Convert.ToString(Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text)
            + Convert.ToInt32(TextBox225.Text) + Convert.ToInt32(TextBox226.Text) + Convert.ToInt32(TextBox227.Text) + Convert.ToInt32(TextBox228.Text));

        TextBox210.Text = Convert.ToString(Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox220.Text));
        TextBox231.Focus();
    }
    protected void TextBox238_TextChanged(object sender, EventArgs e)
    {
        TextBox230.Text = Convert.ToString(Convert.ToInt32(TextBox231.Text) + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text) + Convert.ToInt32(TextBox234.Text)
             + Convert.ToInt32(TextBox235.Text) + Convert.ToInt32(TextBox236.Text) + Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox238.Text));
        TextBox240.Focus();
    }
    protected void TextBox247_TextChanged(object sender, EventArgs e)
    {
        TextBox239.Text = Convert.ToString(Convert.ToInt32(TextBox240.Text) + Convert.ToInt32(TextBox241.Text) + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text)
           + Convert.ToInt32(TextBox244.Text) + Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox247.Text));

        TextBox229.Text = Convert.ToString(Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox239.Text));
       btnSave.Focus();
    }

    //===== CLS for Care
    protected void CLS_CARE()
    {
        try
        {
            //        mState;
            //@lga"   mLGA;
            //@facname"   mFacility;
            //@months"   mMnth;
            //@years"   mYear;
            //@grouptype"   ch;

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
            TextBox49.Text=string.Empty;
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
            TextBox95.Text=string.Empty;
            TextBox96.Text=string.Empty;
            TextBox97.Text=string.Empty;
            TextBox98.Text=string.Empty;
            TextBox99.Text=string.Empty;
            TextBox100.Text=string.Empty;
            TextBox101.Text=string.Empty;
            TextBox102.Text=string.Empty;
            TextBox103.Text=string.Empty;
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
            TextBox170.Text=string.Empty;
            TextBox171.Text=string.Empty;
            TextBox172.Text=string.Empty;
            TextBox173.Text=string.Empty;
            TextBox174.Text=string.Empty;
            TextBox175.Text=string.Empty;
            TextBox176.Text=string.Empty;
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
            TextBox187.Text=string.Empty;
            TextBox188.Text=string.Empty;
            TextBox189.Text=string.Empty;
            TextBox190.Text=string.Empty;
            TextBox191.Text=string.Empty;
            TextBox192.Text=string.Empty;
            TextBox193.Text=string.Empty;
            TextBox194.Text=string.Empty;
            TextBox195.Text=string.Empty;
            TextBox196.Text=string.Empty;
            TextBox197.Text=string.Empty;
            TextBox198.Text=string.Empty;
            TextBox199.Text=string.Empty;
            TextBox200.Text=string.Empty;
            TextBox201.Text=string.Empty;
            TextBox202.Text=string.Empty;
            TextBox203.Text=string.Empty;
            TextBox204.Text=string.Empty;
            TextBox205.Text=string.Empty;
            TextBox206.Text=string.Empty;
            TextBox207.Text=string.Empty;
            TextBox208.Text=string.Empty;
            TextBox209.Text=string.Empty;
            TextBox210.Text=string.Empty;
            TextBox211.Text=string.Empty;
            TextBox212.Text=string.Empty;
            TextBox213.Text=string.Empty;
            TextBox214.Text=string.Empty;
            TextBox215.Text=string.Empty;
            TextBox216.Text=string.Empty;
            TextBox217.Text=string.Empty;
            TextBox218.Text=string.Empty;
            TextBox219.Text=string.Empty;
            TextBox220.Text=string.Empty;
            TextBox221.Text=string.Empty;
            TextBox222.Text=string.Empty;
            TextBox223.Text=string.Empty;
            TextBox224.Text=string.Empty;
            TextBox225.Text=string.Empty;
            TextBox226.Text=string.Empty;
            TextBox227.Text=string.Empty;
            TextBox228.Text=string.Empty;
            TextBox229.Text=string.Empty;
            TextBox230.Text=string.Empty;
            TextBox231.Text=string.Empty;
            TextBox232.Text=string.Empty;
            TextBox233.Text=string.Empty;
            TextBox234.Text=string.Empty;
            TextBox235.Text=string.Empty;
            TextBox236.Text=string.Empty;
            TextBox237.Text=string.Empty;
            TextBox238.Text=string.Empty;
            TextBox239.Text=string.Empty;
            TextBox240.Text=string.Empty;
            TextBox241.Text=string.Empty;
            TextBox242.Text=string.Empty;
            TextBox243.Text=string.Empty;
            TextBox244.Text=string.Empty;
            TextBox245.Text=string.Empty;
            TextBox246.Text=string.Empty;
            TextBox247.Text=string.Empty;
            TextBox1.Focus();
        }catch(Exception ex)
        {
            webMessage.Show( ex.Message.ToString() );
            return;
         }

    }

    /// <summary>
    /// Save and Update Care data
    /// </summary>

    protected void SAVE_CARE()
    {
        string mTest = Session["editme"].ToString();

        if (mTest.ToLower() != "true")
        {

            string sql = "INSERT INTO tbl_CARE VALUES(@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1,@SUBG1MA, @G1MA1,";
            sql += "@G1MA1_4, @G1MA5_9, @G1MA10_14, @G1MA15_19,@G1MA20_24, @G1MA25_49,@G1MA50, @SUBG1FE, @G1FE1, @G1FE1_4,";
            sql += "@G1FE5_9, @G1FE10_14, @G1FE15_19, @G1FE20_24,	@G1FE25_49, @G1FE50,@TOTALG2, @SUBG2MA, @G2MA1, @G2MA1_4,";
            sql += " @G2MA5_9, @G2MA10_14, @G2MA15_19,@G2MA20_24,	@G2MA25_49,	@G2MA50, @SUBG2FE, @G2FE1,@G2FE1_4, @G2FE5_9,";
            sql += "@G2FE10_14, @G2FE15_19, @G2FE20_24, @G2FE25_49,@G2FE50, @TOTALG3, @SUBG3MA, @G3MA1, @G3MA1_4, @G3MA5_9,";
            sql += "@G3MA10_14, @G3MA15_19, @G3MA20_24, @G3MA25_49,@G3MA50,@SUBG3FE, @G3FE1, @G3FE1_4, @G3FE5_9, @G3FE10_14,";
            sql += "@G3FE15_19,@G3FE20_24, @G3FE25_49, @G3FE50, @TOTALG4, @SUBG4MA, @G4MA1,	@G4MA1_4, @G4MA5_9, @G4MA10_14,";
            sql += "@G4MA15_19, @G4MA20_24,@G4MA25_49,@G4MA50, @SUBG4FE, @G4FE1, @G4FE1_4, @G4FE5_9,@G4FE10_14, @G4FE15_19,";
            sql += "@G4FE20_24, @G4FE25_49, @G4FE50,@TOTALG5, @SUBG5MA, @G5MA1, @G5MA1_4, @G5MA5_9, @G5MA10_14, @G5MA15_19,";
            sql += "@G5MA20_24,@G5MA25_49,@G5MA50, @SUBG5FE, @G5FE1, @G5FE1_4,@G5FE5_9, @G5FE10_14, @G5FE15_19, @G5FE20_24,";
            sql += "@G5FE25_49, @G5FE50,@TOTALG6, @SUBG6MA, @G6MA1, @G6MA1_4, @G6MA5_9, @G6MA10_14,@G6MA15_19, @G6MA20_24,";
            sql += "@G6MA25_49, @G6MA50, @SUBG6FE, @G6FE1,@G6FE1_4, @G6FE5_9, @G6FE10_14, @G6FE15_19, @G6FE20_24, @G6FE25_49,";
            sql += "@G6FE50,@TOTALG7, @SUBG7MA, @G7MA1, @G7MA1_4, @G7MA5_9,@G7MA10_14, @G7MA15_19, @G7MA20_24, @G7MA25_49,";
            sql += "@G7MA50,@SUBG7FE, @G7FE1, @G7FE1_4, @G7FE5_9, @G7FE10_14, @G7FE15_19,@G7FE20_24, @G7FE25_49, @G7FE50,";
            sql += "@TOTALG8,@SUBG8MA, @G8MA1,@G8MA1_4, @G8MA5_9, @G8MA10_14, @G8MA15_19, @G8MA20_24,@G8MA25_49,	@G8MA50, ";
            sql += "@SUBG8FE,@G8FE1, @G8FE1_4, @G8FE5_9, @G8FE10_14,	@G8FE15_19, @G8FE20_24, @G8FE25_49, @G8FE50, @TOTALG9,";
            sql += "@SUBG9MA,@G9MA1, @G9MA1_4, @G9MA5_9, @G9MA10_14, @G9MA15_19, @G9MA20_24,	@G9MA25_49,	@G9MA50, @SUBG9FE,";
            sql += "@G9FE1,@G9FE1_4, @G9FE5_9,	@G9FE10_14, @G9FE15_19, @G9FE20_24, @G9FE25_49, @G9FE50,@TOTALG10, @SUBG10MA,";
            sql += "@G10MA1, @G10MA1_4, @G10MA5_9, @G10MA10_14,	@G10MA15_19, @G10MA20_24, @G10MA25_49, @G10MA50, @SUBG10FE, ";
            sql += "@G10FE1, @G10FE1_4, @G10FE5_9, @G10FE10_14, @G10FE15_19, @G10FE20_24, @G10FE25_49,@G10FE50, @TOTALG11, @SUBG11MA,";
            sql += "@G11MA1, @G11MA1_4,@G11MA5_9, @G11MA10_14, @G11MA15_19, @G11MA20_24, @G11MA25_49,	@G11MA50, @SUBG11FE, @G11FE1,";
            sql += "@G11FE1_4, @G11FE5_9, @G11FE10_14,@G11FE15_19, @G11FE20_24, @G11FE25_49, @G11FE50, @TOTALG12, @SUBG12MA, @G12MA1,";
            sql += "@G12MA1_4, @G12MA5_9, @G12MA10_14, @G12MA15_19, @G12MA20_24, @G12MA25_49, @G12MA50,  @SUBG12FE, @G12FE1, @G12FE1_4,";
            sql += "@G12FE5_9,@G12FE10_14,@G12FE15_19, @G12FE20_24, @G12FE25_49, @G12FE50,@TOTALG13, @SUBG13MA, @G13MA1, @G13MA1_4,@G13MA5_9,";
            sql += "@G13MA10_14, @G13MA15_19, @G13MA20_24, @G13MA25_49, @G13MA50, @SUBG13FE, @G13FE1,	@G13FE1_4, @G13FE5_9, @G13FE10_14,";
            sql += "@G13FE15_19, @G13FE20_24,	@G13FE25_49, @G13FE50)";

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

                cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox2.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox3.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox4.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox5.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox6.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA15_19", SqlDbType.Int).Value = TextBox7.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA20_24", SqlDbType.Int).Value = TextBox8.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA25_49", SqlDbType.Int).Value = TextBox9.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA50", SqlDbType.Int).Value = TextBox10.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox11.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox12.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox13.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox14.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox15.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE15_19", SqlDbType.Int).Value = TextBox16.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE20_24", SqlDbType.Int).Value = TextBox17.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE25_49", SqlDbType.Int).Value = TextBox18.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE50", SqlDbType.Int).Value = TextBox19.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox20.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox21.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox22.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox23.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox24.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox25.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA15_19", SqlDbType.Int).Value = TextBox26.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA20_24", SqlDbType.Int).Value = TextBox27.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA25_49", SqlDbType.Int).Value = TextBox28.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA50", SqlDbType.Int).Value = TextBox29.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox30.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox31.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox32.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox33.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox34.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE15_19", SqlDbType.Int).Value = TextBox35.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE20_24", SqlDbType.Int).Value = TextBox36.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE25_49", SqlDbType.Int).Value = TextBox37.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE50", SqlDbType.Int).Value = TextBox38.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox39.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox40.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox41.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox42.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox43.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox44.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA15_19", SqlDbType.Int).Value = TextBox45.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA20_24", SqlDbType.Int).Value = TextBox46.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA25_49", SqlDbType.Int).Value = TextBox47.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA50", SqlDbType.Int).Value = TextBox48.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox49.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox50.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox51.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox52.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox53.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE15_19", SqlDbType.Int).Value = TextBox54.Text.Trim();

                cmd.Parameters.AddWithValue("@G3FE20_24", SqlDbType.Int).Value = TextBox55.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE25_49", SqlDbType.Int).Value = TextBox56.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE50", SqlDbType.Int).Value = TextBox57.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox58.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox59.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox60.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox61.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox62.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox63.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA15_19", SqlDbType.Int).Value = TextBox64.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA20_24", SqlDbType.Int).Value = TextBox65.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA25_49", SqlDbType.Int).Value = TextBox66.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA50", SqlDbType.Int).Value = TextBox67.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox68.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox69.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox70.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox71.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox72.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE15_19", SqlDbType.Int).Value = TextBox73.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE20_24", SqlDbType.Int).Value = TextBox74.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE25_49", SqlDbType.Int).Value = TextBox75.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE50", SqlDbType.Int).Value = TextBox76.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox77.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox78.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox79.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox80.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox81.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox82.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA15_19", SqlDbType.Int).Value = TextBox83.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA20_24", SqlDbType.Int).Value = TextBox84.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA25_49", SqlDbType.Int).Value = TextBox85.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA50", SqlDbType.Int).Value = TextBox86.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox87.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE1", SqlDbType.Int).Value = TextBox88.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox89.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox90.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox91.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE15_19", SqlDbType.Int).Value = TextBox92.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE20_24", SqlDbType.Int).Value = TextBox93.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE25_49", SqlDbType.Int).Value = TextBox94.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE50", SqlDbType.Int).Value = TextBox95.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox96.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox97.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox98.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox99.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox100.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox101.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA15_19", SqlDbType.Int).Value = TextBox102.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA20_24", SqlDbType.Int).Value = TextBox103.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA25_49", SqlDbType.Int).Value = TextBox104.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA50", SqlDbType.Int).Value = TextBox105.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox106.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox107.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox108.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox109.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox110.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE15_19", SqlDbType.Int).Value = TextBox111.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE20_24", SqlDbType.Int).Value = TextBox112.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE25_49", SqlDbType.Int).Value = TextBox113.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE50", SqlDbType.Int).Value = TextBox114.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox115.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox116.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox117.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox118.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox119.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox120.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA15_19", SqlDbType.Int).Value = TextBox121.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA20_24", SqlDbType.Int).Value = TextBox122.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA25_49", SqlDbType.Int).Value = TextBox123.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA50", SqlDbType.Int).Value = TextBox124.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox125.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox126.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox127.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox128.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox129.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE15_19", SqlDbType.Int).Value = TextBox130.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox131.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox132.Text.Trim();

                //cmd.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox131.Text.Trim();
                //cmd.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox132.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE50", SqlDbType.Int).Value = TextBox133.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox134.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox135.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox136.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox137.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox138.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox139.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA15_19", SqlDbType.Int).Value = TextBox140.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA20_24", SqlDbType.Int).Value = TextBox141.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA25_49", SqlDbType.Int).Value = TextBox142.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA50", SqlDbType.Int).Value = TextBox143.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox144.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox145.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox146.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox147.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox148.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE15_19", SqlDbType.Int).Value = TextBox149.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE20_24", SqlDbType.Int).Value = TextBox150.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE25_49", SqlDbType.Int).Value = TextBox151.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE50", SqlDbType.Int).Value = TextBox152.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox153.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox154.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox155.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox156.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox157.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox158.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = TextBox159.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = TextBox160.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = TextBox161.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = TextBox162.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox163.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox164.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox165.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox166.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox167.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = TextBox168.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = TextBox169.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = TextBox170.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = TextBox171.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox172.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox173.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox174.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox175.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox176.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox177.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA15_19", SqlDbType.Int).Value = TextBox178.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA20_24", SqlDbType.Int).Value = TextBox179.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA25_49", SqlDbType.Int).Value = TextBox180.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA50", SqlDbType.Int).Value = TextBox181.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox182.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox183.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox184.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox185.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox186.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE15_19", SqlDbType.Int).Value = TextBox187.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE20_24", SqlDbType.Int).Value = TextBox188.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE25_49", SqlDbType.Int).Value = TextBox189.Text.Trim();
                cmd.Parameters.AddWithValue("@G10FE50", SqlDbType.Int).Value = TextBox190.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox191.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox192.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox193.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox194.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox195.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox196.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = TextBox197.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = TextBox198.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = TextBox199.Text.Trim();
                cmd.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = TextBox200.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox201.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox202.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox203.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox204.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox205.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = TextBox206.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = TextBox207.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = TextBox208.Text.Trim();
                cmd.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = TextBox209.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox210.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG12MA", SqlDbType.Int).Value = TextBox211.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = TextBox212.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = TextBox213.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = TextBox214.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = TextBox215.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = TextBox216.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = TextBox217.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox218.Text.Trim();
                cmd.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = TextBox219.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG12FE", SqlDbType.Int).Value = TextBox220.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = TextBox221.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = TextBox222.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = TextBox223.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = TextBox224.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = TextBox225.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = TextBox226.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = TextBox227.Text.Trim();
                cmd.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = TextBox228.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG13", SqlDbType.Int).Value = TextBox229.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG13MA", SqlDbType.Int).Value = TextBox230.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA1", SqlDbType.Int).Value = TextBox231.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA1_4", SqlDbType.Int).Value = TextBox232.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA5_9", SqlDbType.Int).Value = TextBox233.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA10_14", SqlDbType.Int).Value = TextBox234.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA15_19", SqlDbType.Int).Value = TextBox235.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA20_24", SqlDbType.Int).Value = TextBox236.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA25_49", SqlDbType.Int).Value = TextBox237.Text.Trim();
                cmd.Parameters.AddWithValue("@G13MA50", SqlDbType.Int).Value = TextBox238.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG13FE", SqlDbType.Int).Value = TextBox239.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE1", SqlDbType.Int).Value = TextBox240.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE1_4", SqlDbType.Int).Value = TextBox241.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE5_9", SqlDbType.Int).Value = TextBox242.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE10_14", SqlDbType.Int).Value = TextBox243.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE15_19", SqlDbType.Int).Value = TextBox244.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE20_24", SqlDbType.Int).Value = TextBox245.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE25_49", SqlDbType.Int).Value = TextBox246.Text.Trim();
                cmd.Parameters.AddWithValue("@G13FE50", SqlDbType.Int).Value = TextBox247.Text.Trim();
                int Rowaffected = cmd.ExecuteNonQuery();

                if (Rowaffected != -1)
                {
                    webMessage.Show(Rowaffected.ToString() + " Successful");
                    //Response.Write("<script language=javascript>alert('" + Rowaffected.ToString() + " Successful ');</script>");
                    CLS_CARE();
                    return;
                }

            }
            catch (Exception ex)
            {
                webMessage.Show(ex.Message.ToString());
                //Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
                return;
            }
        }
        else
        {
            string sql = "UPDATE  tbl_CARE SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG1=@TOTALG1,SUBG1MA=@SUBG1MA, G1MA1=@G1MA1,";
            sql += "G1MA1_4=@G1MA1_4, G1MA5_9=@G1MA5_9, G1MA10_14=@G1MA10_14, G1MA15_19=@G1MA15_19,G1MA20_24=@G1MA20_24,G1MA25_49= @G1MA25_49,G1MA50=@G1MA50,SUBG1FE= @SUBG1FE, G1FE1=@G1FE1,G1FE1_4= @G1FE1_4,";
            sql += "G1FE5_9=@G1FE5_9,G1FE10_14= @G1FE10_14, G1FE15_19=@G1FE15_19,G1FE20_24= @G1FE20_24,G1FE25_49=@G1FE25_49, G1FE50=@G1FE50,TOTALG2=@TOTALG2, SUBG2MA=@SUBG2MA, G2MA1=@G2MA1, G2MA1_4=@G2MA1_4,";
            sql += "G2MA5_9= @G2MA5_9, G2MA10_14=@G2MA10_14, G2MA15_19=@G2MA15_19,G2MA20_24=@G2MA20_24,	G2MA25_49=@G2MA25_49,	G2MA50=@G2MA50, SUBG2FE=@SUBG2FE, G2FE1=@G2FE1,G2FE1_4=@G2FE1_4, G2FE5_9=@G2FE5_9,";
            sql += "G2FE10_14=@G2FE10_14, G2FE15_19=@G2FE15_19, G2FE20_24=@G2FE20_24, G2FE25_49=@G2FE25_49,G2FE50=@G2FE50, TOTALG3=@TOTALG3, SUBG3MA=@SUBG3MA, G3MA1=@G3MA1, G3MA1_4=@G3MA1_4, G3MA5_9=@G3MA5_9,";
            sql += "G3MA10_14=@G3MA10_14, G3MA15_19=@G3MA15_19, G3MA20_24=@G3MA20_24, G3MA25_49=@G3MA25_49,G3MA50=@G3MA50,SUBG3FE=@SUBG3FE, G3FE1=@G3FE1, G3FE1_4=@G3FE1_4, G3FE5_9=@G3FE5_9, G3FE10_14=@G3FE10_14,";
            sql += "G3FE15_19=@G3FE15_19,G3FE20_24=@G3FE20_24, G3FE25_49=@G3FE25_49, G3FE50=@G3FE50, TOTALG4=@TOTALG4, SUBG4MA=@SUBG4MA, G4MA1=@G4MA1,	G4MA1_4=@G4MA1_4, G4MA5_9=@G4MA5_9, G4MA10_14=@G4MA10_14,";
            sql += "G4MA15_19=@G4MA15_19, G4MA20_24=@G4MA20_24,G4MA25_49=@G4MA25_49,G4MA50=@G4MA50, SUBG4FE=@SUBG4FE, G4FE1=@G4FE1, G4FE1_4=@G4FE1_4, G4FE5_9=@G4FE5_9,G4FE10_14=@G4FE10_14, G4FE15_19=@G4FE15_19,";
            sql += "G4FE20_24=@G4FE20_24, G4FE25_49=@G4FE25_49, G4FE50=@G4FE50,TOTALG5=@TOTALG5, SUBG5MA=@SUBG5MA, G5MA1=@G5MA1, G5MA1_4=@G5MA1_4, G5MA5_9=@G5MA5_9, G5MA10_14=@G5MA10_14, G5MA15_19=@G5MA15_19,";
            sql += "G5MA20_24=@G5MA20_24,G5MA25_49=@G5MA25_49,G5MA50=@G5MA50, SUBG5FE=@SUBG5FE, G5FE1=@G5FE1, G5FE1_4=@G5FE1_4,G5FE5_9=@G5FE5_9, G5FE10_14=@G5FE10_14, G5FE15_19=@G5FE15_19, G5FE20_24=@G5FE20_24,";
            sql += "G5FE25_49=@G5FE25_49, G5FE50=@G5FE50,TOTALG6=@TOTALG6, SUBG6MA=@SUBG6MA, G6MA1=@G6MA1, G6MA1_4=@G6MA1_4, G6MA5_9=@G6MA5_9, G6MA10_14=@G6MA10_14,G6MA15_19=@G6MA15_19, G6MA20_24=@G6MA20_24,";
            sql += "G6MA25_49=@G6MA25_49, G6MA50=@G6MA50, SUBG6FE=@SUBG6FE, G6FE1=@G6FE1,G6FE1_4=@G6FE1_4, G6FE5_9=@G6FE5_9, G6FE10_14=@G6FE10_14, G6FE15_19=@G6FE15_19, G6FE20_24=@G6FE20_24, G6FE25_49=@G6FE25_49,";
            sql += "G6FE50=@G6FE50,TOTALG7=@TOTALG7, SUBG7MA=@SUBG7MA, G7MA1=@G7MA1, G7MA1_4=@G7MA1_4, G7MA5_9=@G7MA5_9,G7MA10_14=@G7MA10_14, G7MA15_19=@G7MA15_19, G7MA20_24=@G7MA20_24, G7MA25_49=@G7MA25_49,";
            sql += "G7MA50=@G7MA50,SUBG7FE=@SUBG7FE, G7FE1=@G7FE1, G7FE1_4=@G7FE1_4, G7FE5_9=@G7FE5_9, G7FE10_14=@G7FE10_14, G7FE15_19=@G7FE15_19,G7FE20_24=@G7FE20_24, G7FE25_49=@G7FE25_49, G7FE50=@G7FE50,";
            sql += "TOTALG8=@TOTALG8,SUBG8MA=@SUBG8MA,G8MA1= @G8MA1,G8MA1_4=@G8MA1_4, G8MA5_9=@G8MA5_9, G8MA10_14=@G8MA10_14, G8MA15_19=@G8MA15_19, G8MA20_24=@G8MA20_24,G8MA25_49=@G8MA25_49,	G8MA50=@G8MA50, ";
            sql += "SUBG8FE=@SUBG8FE,G8FE1=@G8FE1, G8FE1_4=@G8FE1_4, G8FE5_9=@G8FE5_9, G8FE10_14=@G8FE10_14,	G8FE15_19=@G8FE15_19, G8FE20_24=@G8FE20_24, G8FE25_49=@G8FE25_49, G8FE50=@G8FE50, TOTALG9=@TOTALG9,";
            sql += "SUBG9MA=@SUBG9MA,G9MA1=@G9MA1, G9MA1_4=@G9MA1_4, G9MA5_9=@G9MA5_9, G9MA10_14=@G9MA10_14, G9MA15_19=@G9MA15_19, G9MA20_24=@G9MA20_24,	G9MA25_49=@G9MA25_49,	G9MA50=@G9MA50, SUBG9FE=@SUBG9FE,";
            sql += "G9FE1=@G9FE1,G9FE1_4=@G9FE1_4, G9FE5_9=@G9FE5_9,	G9FE10_14=@G9FE10_14, G9FE15_19=@G9FE15_19, G9FE20_24=@G9FE20_24, G9FE25_49=@G9FE25_49, G9FE50=@G9FE50,TOTALG10=@TOTALG10, SUBG10MA=@SUBG10MA,";
            sql += "G10MA1=@G10MA1, G10MA1_4=@G10MA1_4, G10MA5_9=@G10MA5_9, G10MA10_14=@G10MA10_14,	G10MA15_19=@G10MA15_19, G10MA20_24=@G10MA20_24, G10MA25_49=@G10MA25_49, G10MA50=@G10MA50, SUBG10FE=@SUBG10FE, ";
            sql += "G10FE1=@G10FE1, G10FE1_4=@G10FE1_4, G10FE5_9=@G10FE5_9, G10FE10_14=@G10FE10_14, G10FE15_19=@G10FE15_19, G10FE20_24=@G10FE20_24, G10FE25_49=@G10FE25_49,G10FE50=@G10FE50, TOTALG11=@TOTALG11, SUBG11MA=@SUBG11MA,";
            sql += "G11MA1=@G11MA1, G11MA1_4=@G11MA1_4,G11MA5_9=@G11MA5_9, G11MA10_14=@G11MA10_14, G11MA15_19=@G11MA15_19, G11MA20_24=@G11MA20_24, G11MA25_49=@G11MA25_49,	G11MA50=@G11MA50, SUBG11FE=@SUBG11FE, G11FE1=@G11FE1,";
            sql += "G11FE1_4=@G11FE1_4, G11FE5_9=@G11FE5_9, G11FE10_14=@G11FE10_14,G11FE15_19=@G11FE15_19, G11FE20_24=@G11FE20_24, G11FE25_49=@G11FE25_49, G11FE50=@G11FE50, TOTALG12=@TOTALG12, SUBG12MA=@SUBG12MA, G12MA1=@G12MA1,";
            sql += "G12MA1_4=@G12MA1_4, G12MA5_9=@G12MA5_9, G12MA10_14=@G12MA10_14, G12MA15_19=@G12MA15_19, G12MA20_24=@G12MA20_24, G12MA25_49=@G12MA25_49, G12MA50=@G12MA50,  SUBG12FE=@SUBG12FE, G12FE1=@G12FE1, G12FE1_4=@G12FE1_4,";
            sql += "G12FE5_9=@G12FE5_9,G12FE10_14=@G12FE10_14,G12FE15_19=@G12FE15_19, G12FE20_24=@G12FE20_24, G12FE25_49=@G12FE25_49, G12FE50=@G12FE50,TOTALG13=@TOTALG13, SUBG13MA=@SUBG13MA, G13MA1=@G13MA1, G13MA1_4=@G13MA1_4,G13MA5_9=@G13MA5_9,";
            sql += "G13MA10_14=@G13MA10_14, G13MA15_19=@G13MA15_19, G13MA20_24=@G13MA20_24, G13MA25_49=@G13MA25_49, G13MA50=@G13MA50, SUBG13FE=@SUBG13FE, G13FE1=@G13FE1,	G13FE1_4=@G13FE1_4, G13FE5_9=@G13FE5_9, G13FE10_14=@G13FE10_14,";
            sql += "G13FE15_19=@G13FE15_19, G13FE20_24=@G13FE20_24,	G13FE25_49=@G13FE25_49, G13FE50=@G13FE50";
            sql += "  WHERE states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype ";
            try
            {
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                SqlCommand cmd = new SqlCommand(sql, cn);
                int Rowaffected = cmd.ExecuteNonQuery();

                if (Rowaffected != -1)
                {
                    webMessage.Show(Rowaffected.ToString() + " Update Successful");
                    //Response.Write("<script language=javascript>alert('" + Rowaffected.ToString() + " Successful ');</script>");
                    CLS_CARE();
                    return;
                }
            }catch(Exception ex)
            {
                webMessage.Show(" CARE Update error: "+ex.Message.ToString());
                return;
            }
            
        }
    }//====end of saving Care

    protected void EDIT_CARE()
    {
        try
        {
             string SQL1 = "SELECT * FROM tbl_CARE Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

             SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()); 
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader rd = cmd1.ExecuteReader();

            while (rd.Read())
            {
                
         //mFacility.text=rd["facname"].ToString();
         // mMnth.text=rd["months"].ToString();
         //  mYr.text=rd["years"].ToString();
         //  mChoose.text=rd["grouptype"].ToString();

                    TextBox1.Text=rd["TOTALG1"].ToString(); 
                  TextBox2.Text=rd["SUBG1MA"].ToString();
                   TextBox3.Text=rd["G1MA1"].ToString(); 
                    TextBox4.Text=rd["G1MA1_4"].ToString();
	                TextBox5.Text=rd["G1MA5_9"].ToString(); 
	               TextBox6.Text=rd["G1MA10_14"].ToString(); 
                 TextBox7.Text=rd["G1MA15_19"].ToString();
                 TextBox8.Text=rd["G1MA20_24"].ToString();
                TextBox9.Text=rd["G1MA25_49"].ToString(); 
                 TextBox10.Text=rd["G1MA50"].ToString(); 
               TextBox11.Text=rd["SUBG1FE"].ToString(); 
                 TextBox12.Text=rd["G1FE1"].ToString(); 
                TextBox13.Text=rd["G1FE1_4"].ToString(); 
                TextBox14.Text=rd["G1FE5_9"].ToString(); 
                 TextBox15.Text=rd["G1FE10_14"].ToString(); 
                 TextBox16.Text=rd["G1FE15_19"].ToString(); 
                TextBox17.Text=rd["G1FE20_24"].ToString();
                 TextBox18.Text=rd["G1FE25_49"].ToString(); 
                 TextBox19.Text=rd["G1FE50"].ToString(); 
               TextBox20.Text=rd["TOTALG2"].ToString(); 
                TextBox21.Text=rd["SUBG2MA"].ToString(); 
                 TextBox22.Text=rd["G2MA1"].ToString(); 
                 TextBox23.Text=rd["G2MA1_4"].ToString(); 
                 TextBox24.Text=rd["G2MA5_9"].ToString();
                TextBox25.Text=rd["G2MA10_14"].ToString(); 
                 TextBox26.Text=rd["G2MA15_19"].ToString(); 
                TextBox27.Text=rd["G2MA20_24"].ToString(); 
                 TextBox28.Text=rd["G2MA25_49"].ToString();
                 TextBox29.Text=rd["G2MA50"].ToString();
                 TextBox30.Text=rd["SUBG2FE"].ToString();
                TextBox31.Text=rd["G2FE1"].ToString(); 
                 TextBox32.Text=rd["G2FE1_4"].ToString(); 
                TextBox33.Text=rd["G2FE5_9"].ToString(); 
                TextBox34.Text=rd["G2FE10_14"].ToString(); 
                 TextBox35.Text=rd["G2FE15_19"].ToString();
                TextBox36.Text=rd["G2FE20_24"].ToString(); 
                 TextBox37.Text=rd["G2FE25_49"].ToString(); 
                TextBox38.Text=rd["G2FE50"].ToString(); 
                TextBox39.Text=rd["TOTALG3"].ToString();
                TextBox40.Text=rd["SUBG3MA"].ToString(); 
                 TextBox41.Text=rd["G3MA1"].ToString();
                 TextBox42.Text=rd["G3MA1_4"].ToString(); 
                 TextBox43.Text=rd["G3MA5_9"].ToString(); 
                TextBox44.Text=rd["G3MA10_14"].ToString(); 
                 TextBox45.Text=rd["G3MA15_19"].ToString(); 
                 TextBox46.Text=rd["G3MA20_24"].ToString(); 
                 TextBox47.Text=rd["G3MA25_49"].ToString(); 
                 TextBox48.Text=rd["G3MA50"].ToString();
                TextBox49.Text=rd["SUBG3FE"].ToString(); 
                TextBox50.Text=rd["G3FE1"].ToString(); 
                TextBox51.Text=rd["G3FE1_4"].ToString();
                TextBox52.Text=rd["G3FE5_9"].ToString(); 
                TextBox53.Text=rd["G3FE10_14"].ToString(); 
                 TextBox54.Text=rd["G3FE15_19"].ToString();

                TextBox55.Text=rd["G3FE20_24"].ToString(); 
                 TextBox56.Text=rd["G3FE25_49"].ToString(); 
               TextBox57.Text=rd["G3FE50"].ToString();
                 TextBox58.Text=rd["TOTALG4"].ToString(); 
                TextBox59.Text=rd["SUBG4MA"].ToString(); 
                 TextBox60.Text=rd["G4MA1"].ToString();
                 TextBox61.Text=rd["G4MA1_4"].ToString(); 
               TextBox62.Text=rd["G4MA5_9"].ToString(); 
                TextBox63.Text=rd["G4MA10_14"].ToString(); 
               TextBox64.Text=rd["G4MA15_19"].ToString(); 
               TextBox65.Text=rd["G4MA20_24"].ToString(); 
                 TextBox66.Text=rd["G4MA25_49"].ToString(); 
                 TextBox67.Text=rd["G4MA50"].ToString(); 
               TextBox68.Text=rd["SUBG4FE"].ToString(); 
                TextBox69.Text=rd["G4FE1"].ToString(); 
                 TextBox70.Text=rd["G4FE1_4"].ToString(); 
                TextBox71.Text=rd["G4FE5_9"].ToString();
                TextBox72.Text=rd["G4FE10_14"].ToString(); 
              TextBox73.Text=rd["G4FE15_19"].ToString(); 
                TextBox74.Text=rd["G4FE20_24"].ToString(); 
               TextBox75.Text=rd["G4FE25_49"].ToString(); 
                TextBox76.Text=rd["G4FE50"].ToString(); 
                TextBox77.Text=rd["TOTALG5"].ToString();
               TextBox78.Text=rd["SUBG5MA"].ToString(); 
               TextBox79.Text=rd["G5MA1"].ToString(); 
               TextBox80.Text=rd["G5MA1_4"].ToString();
                TextBox81.Text=rd["G5MA5_9"].ToString(); 
               TextBox82.Text=rd["G5MA10_14"].ToString();
               TextBox83.Text=rd["G5MA15_19"].ToString();
               TextBox84.Text=rd["G5MA20_24"].ToString(); 
                TextBox85.Text=rd["G5MA25_49"].ToString(); 
                TextBox86.Text=rd["G5MA50"].ToString();
              TextBox87.Text=rd["SUBG5FE"].ToString();
                TextBox88.Text=rd["G5FE1"].ToString(); 
               TextBox89.Text=rd["G5FE1_4"].ToString(); 
                TextBox90.Text=rd["G5FE5_9"].ToString(); 
               TextBox91.Text=rd["G5FE10_14"].ToString(); 
                TextBox92.Text=rd["G5FE15_19"].ToString();
              TextBox93.Text=rd["G5FE20_24"].ToString();
                TextBox94.Text=rd["G5FE25_49"].ToString(); 
                TextBox95.Text=rd["G5FE50"].ToString();
                TextBox96.Text=rd["TOTALG6"].ToString(); 
                TextBox97.Text=rd["SUBG6MA"].ToString(); 
               TextBox98.Text=rd["G6MA1"].ToString(); 
               TextBox99.Text=rd["G6MA1_4"].ToString(); 
               TextBox100.Text=rd["G6MA5_9"].ToString();
               TextBox101.Text=rd["G6MA10_14"].ToString(); 
               TextBox102.Text=rd["G6MA15_19"].ToString(); 
                TextBox103.Text=rd["G6MA20_24"].ToString(); 
               TextBox104.Text=rd["G6MA25_49"].ToString();
               TextBox105.Text=rd["G6MA50"].ToString(); 
               TextBox106.Text=rd["SUBG6FE"].ToString();
                TextBox107.Text=rd["G6FE1"].ToString();
                TextBox108.Text=rd["G6FE1_4"].ToString();
                TextBox109.Text=rd["G6FE5_9"].ToString(); 
                TextBox110.Text=rd["G6FE10_14"].ToString(); 
                TextBox111.Text=rd["G6FE15_19"].ToString();
                TextBox112.Text=rd["G6FE20_24"].ToString(); 
                TextBox113.Text=rd["G6FE25_49"].ToString(); 
                TextBox114.Text=rd["G6FE50"].ToString(); 
                TextBox115.Text=rd["TOTALG7"].ToString(); 
              TextBox116.Text=rd["SUBG7MA"].ToString(); 
               TextBox117.Text=rd["G7MA1"].ToString(); 
                TextBox118.Text=rd["G7MA1_4"].ToString();
                TextBox119.Text=rd["G7MA5_9"].ToString(); 
               TextBox120.Text=rd["G7MA10_14"].ToString(); 
             TextBox121.Text=rd["G7MA15_19"].ToString(); 
                TextBox122.Text=rd["G7MA20_24"].ToString(); 
               TextBox123.Text=rd["G7MA25_49"].ToString(); 
                TextBox124.Text=rd["G7MA50"].ToString(); 
                TextBox125.Text=rd["SUBG7FE"].ToString();
               TextBox126.Text=rd["G7FE1"].ToString();
               TextBox127.Text=rd["G7FE1_4"].ToString();
                TextBox128.Text=rd["G7FE5_9"].ToString(); 
               TextBox129.Text=rd["G7FE10_14"].ToString(); 
               TextBox130.Text=rd["G7FE15_19"].ToString();
              TextBox131.Text=rd["G7FE20_24"].ToString();
               TextBox132.Text=rd["G7FE25_49"].ToString(); 
               TextBox133.Text=rd["G7FE50"].ToString(); 
                TextBox134.Text=rd["TOTALG8"].ToString();
              TextBox135.Text=rd["SUBG8MA"].ToString();
              TextBox136.Text=rd["G8MA1"].ToString();
                TextBox137.Text=rd["G8MA1_4"].ToString();
               TextBox138.Text=rd["G8MA5_9"].ToString(); 
               TextBox139.Text=rd["G8MA10_14"].ToString();
               TextBox140.Text=rd["G8MA15_19"].ToString();
              TextBox141.Text=rd["G8MA20_24"].ToString();
               TextBox142.Text=rd["G8MA25_49"].ToString(); 
                TextBox143.Text=rd["G8MA50"].ToString();
              TextBox144.Text=rd["SUBG8FE"].ToString(); 
                TextBox145.Text=rd["G8FE1"].ToString(); 
                TextBox146.Text=rd["G8FE1_4"].ToString(); 
                TextBox147.Text=rd["G8FE5_9"].ToString(); 
                TextBox148.Text=rd["G8FE10_14"].ToString(); 
               TextBox149.Text=rd["G8FE15_19"].ToString();
               TextBox150.Text=rd["G8FE20_24"].ToString(); 
              TextBox151.Text=rd["G8FE25_49"].ToString(); 
               TextBox152.Text=rd["G8FE50"].ToString(); 
              TextBox153.Text=rd["TOTALG9"].ToString(); 
               TextBox154.Text=rd["SUBG9MA"].ToString();
              TextBox155.Text=rd["G9MA1"].ToString();
             TextBox156.Text=rd["G9MA1_4"].ToString(); 
               TextBox157.Text=rd["G9MA5_9"].ToString(); 
               TextBox158.Text=rd["G9MA10_14"].ToString(); 
               TextBox159.Text=rd["G9MA15_19"].ToString(); 
               TextBox160.Text=rd["G9MA20_24"].ToString(); 
                TextBox161.Text=rd["G9MA25_49"].ToString();
               TextBox162.Text=rd["G9MA50"].ToString(); 
               TextBox163.Text=rd["SUBG9FE"].ToString(); 
                TextBox164.Text=rd["G9FE1"].ToString(); 
               TextBox165.Text=rd["G9FE1_4"].ToString(); 
                TextBox166.Text=rd["G9FE5_9"].ToString(); 
               TextBox167.Text=rd["G9FE10_14"].ToString(); 
               TextBox168.Text=rd["G9FE15_19"].ToString(); 
                TextBox169.Text=rd["G9FE20_24"].ToString(); 
                TextBox170.Text=rd["G9FE25_49"].ToString(); 
                TextBox171.Text=rd["G9FE50"].ToString();
               TextBox172.Text=rd["TOTALG10"].ToString();

               TextBox173.Text = rd["SUBG10MA"].ToString();
               TextBox174.Text = rd["G10MA1"].ToString();
               TextBox175.Text = rd["G10MA1_4"].ToString();
               TextBox176.Text = rd["G10MA5_9"].ToString();
               TextBox177.Text = rd["G10MA10_14"].ToString();
               TextBox178.Text = rd["G10MA15_19"].ToString();
               TextBox179.Text = rd["G10MA20_24"].ToString();
               TextBox180.Text = rd["G10MA25_49"].ToString();
               TextBox181.Text = rd["G10MA50"].ToString();
               TextBox182.Text = rd["SUBG10FE"].ToString();
               TextBox183.Text = rd["G10FE1"].ToString();
               TextBox184.Text = rd["G10FE1_4"].ToString();
               TextBox185.Text = rd["G10FE5_9"].ToString();
               TextBox186.Text = rd["G10FE10_14"].ToString();
               TextBox187.Text = rd["G10FE15_19"].ToString();
               TextBox188.Text = rd["G10FE20_24"].ToString();
               TextBox189.Text = rd["G10FE25_49"].ToString();
               TextBox190.Text = rd["G10FE50"].ToString();
               TextBox191.Text = rd["TOTALG11"].ToString();
               TextBox192.Text = rd["SUBG11MA"].ToString();
               TextBox193.Text = rd["G11MA1"].ToString();
               TextBox195.Text = rd["G11MA5_9"].ToString();
               TextBox196.Text = rd["G11MA10_14"].ToString();
               TextBox197.Text = rd["G11MA15_19"].ToString();
               TextBox198.Text = rd["G11MA20_24"].ToString();
               TextBox199.Text = rd["G11MA25_49"].ToString();
               TextBox200.Text = rd["G11MA50"].ToString();
               TextBox201.Text = rd["SUBG11FE"].ToString();
               TextBox202.Text = rd["G11FE1"].ToString();
               TextBox203.Text = rd["G11FE1_4"].ToString();
               TextBox204.Text = rd["G11FE5_9"].ToString();
               TextBox205.Text = rd["G11FE10_14"].ToString();
               TextBox206.Text = rd["G11FE15_19"].ToString();
               TextBox207.Text = rd["G11FE20_24"].ToString();
               TextBox208.Text = rd["G11FE25_49"].ToString();
               TextBox209.Text = rd["G11FE50"].ToString();
               TextBox210.Text = rd["TOTALG12"].ToString();
               TextBox211.Text = rd["SUBG12MA"].ToString();
               TextBox212.Text = rd["G12MA1"].ToString();
               TextBox213.Text = rd["G12MA1_4"].ToString();
               TextBox214.Text = rd["G12MA5_9"].ToString();
               TextBox215.Text = rd["G12MA10_14"].ToString();
               TextBox216.Text = rd["G12MA15_19"].ToString();
               TextBox217.Text = rd["G12MA20_24"].ToString();
               TextBox218.Text = rd["G12MA25_49"].ToString();
               TextBox219.Text = rd["G12MA50"].ToString();
               TextBox220.Text = rd["SUBG12FE"].ToString();
               TextBox221.Text = rd["G12FE1"].ToString();
               TextBox222.Text = rd["G12FE1_4"].ToString();
               TextBox223.Text = rd["G12FE5_9"].ToString();
               TextBox224.Text = rd["G12FE10_14"].ToString();
               TextBox225.Text = rd["G12FE15_19"].ToString();
               TextBox226.Text = rd["G12FE20_24"].ToString();
               TextBox227.Text = rd["G12FE25_49"].ToString();
               TextBox228.Text = rd["G12FE50"].ToString();
               TextBox229.Text = rd["TOTALG13"].ToString();
               TextBox230.Text = rd["SUBG13MA"].ToString();
               TextBox231.Text = rd["G13MA1"].ToString();
               TextBox232.Text = rd["G13MA1_4"].ToString();
               TextBox233.Text = rd["G13MA5_9"].ToString();
               TextBox234.Text = rd["G13MA10_14"].ToString();
               TextBox235.Text = rd["G13MA15_19"].ToString();
               TextBox236.Text = rd["G13MA20_24"].ToString();
               TextBox237.Text = rd["G13MA25_49"].ToString();
               TextBox238.Text = rd["G13MA50"].ToString();
               TextBox239.Text = rd["SUBG13FE"].ToString();
               TextBox240.Text = rd["G13FE1"].ToString();
               TextBox241.Text = rd["G13FE1_4"].ToString();
               TextBox242.Text = rd["G13FE5_9"].ToString();
               TextBox243.Text = rd["G13FE10_14"].ToString();
               TextBox244.Text = rd["G13FE15_19"].ToString();
               TextBox245.Text = rd["G13FE20_24"].ToString();
               TextBox246.Text = rd["G13FE25_49"].ToString();
               TextBox247.Text = rd["G13FE50"].ToString();

               Session["editme"] = true;
            }
            cmd1.Dispose();
            rd.Close();
            cn.Close();
            Session["editme"] = false;
        }catch(Exception ex)
        {
            webMessage.Show(ex.Message.ToString());
            //Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
            return;
        }
    }


    protected void CLS_ART()
    {
        try
        {
    //        ************** tbl_ART1
	    TextBox248.Text=string.Empty;
	    TextBox249.Text=string.Empty;
	    TextBox250.Text=string.Empty;
	    TextBox251.Text=string.Empty;
	    TextBox252.Text=string.Empty;
	    TextBox253.Text=string.Empty;
	    TextBox254.Text=string.Empty;
	    TextBox255.Text=string.Empty;
	    TextBox256.Text=string.Empty;
	    TextBox257.Text=string.Empty;
	    TextBox258.Text=string.Empty;
	    TextBox259.Text=string.Empty;
	    TextBox260.Text=string.Empty;
	    TextBox261.Text=string.Empty;
	    TextBox262.Text=string.Empty;
	    TextBox263.Text=string.Empty;
	    TextBox264.Text=string.Empty;
	    TextBox265.Text=string.Empty;
	    TextBox266.Text=string.Empty;
	    TextBox1074.Text=string.Empty;
	    TextBox1075.Text=string.Empty;
	    TextBox267.Text=string.Empty;
	    TextBox268.Text=string.Empty;
	    TextBox269.Text=string.Empty;
	    TextBox270.Text=string.Empty;
	    TextBox271.Text=string.Empty;
	    TextBox272.Text=string.Empty;
	    TextBox273.Text=string.Empty;
	    TextBox274.Text=string.Empty;
	    TextBox275.Text=string.Empty;
	    TextBox276.Text=string.Empty;
	    TextBox277.Text=string.Empty;
	    TextBox278.Text=string.Empty;
	    TextBox279.Text=string.Empty;
	    TextBox280.Text=string.Empty;
	    TextBox281.Text=string.Empty;
	    TextBox282.Text=string.Empty;
	    TextBox283.Text=string.Empty;
	    TextBox284.Text=string.Empty;
	    TextBox285.Text=string.Empty;
	    TextBox1072.Text=string.Empty;
	    TextBox1073.Text=string.Empty;
	    TextBox286.Text=string.Empty;
	    TextBox287.Text=string.Empty;
	    TextBox288.Text=string.Empty;
	    TextBox289.Text=string.Empty;
	    TextBox290.Text=string.Empty;
	    TextBox291.Text=string.Empty;
	    TextBox292.Text=string.Empty;
	    TextBox293.Text=string.Empty;
	    TextBox294.Text=string.Empty;
	    TextBox295.Text=string.Empty;
	    TextBox296.Text=string.Empty;
	    TextBox297.Text=string.Empty;
	    TextBox298.Text=string.Empty;
	    TextBox299.Text=string.Empty;
	    TextBox300.Text=string.Empty;
	    TextBox301.Text=string.Empty;
	    TextBox302.Text=string.Empty;
	    TextBox303.Text=string.Empty;
	    TextBox304.Text=string.Empty;
	    TextBox305.Text=string.Empty;
	    TextBox306.Text=string.Empty;
	    TextBox307.Text=string.Empty;
	    TextBox308.Text=string.Empty;
	    TextBox309.Text=string.Empty;
	    TextBox310.Text=string.Empty;
	    TextBox311.Text=string.Empty;
	    TextBox312.Text=string.Empty;
	    TextBox313.Text=string.Empty;
	    TextBox314.Text=string.Empty;
	    TextBox315.Text=string.Empty;
	    TextBox316.Text=string.Empty;
	    TextBox317.Text=string.Empty;
	    TextBox318.Text=string.Empty;
	    TextBox319.Text=string.Empty;
	    TextBox320.Text=string.Empty;
	    TextBox321.Text=string.Empty;
	    TextBox322.Text=string.Empty;
	    TextBox323.Text=string.Empty;
	    TextBox324.Text=string.Empty;
	    TextBox325.Text=string.Empty;
	    TextBox326.Text=string.Empty;
	    TextBox327.Text=string.Empty;
	    TextBox328.Text=string.Empty;
	    TextBox329.Text=string.Empty;
	    TextBox330.Text=string.Empty;
	    TextBox331.Text=string.Empty;
	    TextBox332.Text=string.Empty;
	    TextBox333.Text=string.Empty;
	    TextBox334.Text=string.Empty;
	    TextBox335.Text=string.Empty;
	    TextBox336.Text=string.Empty;
	    TextBox337.Text=string.Empty;
	    TextBox338.Text=string.Empty;
	    TextBox339.Text=string.Empty;
	    TextBox340.Text=string.Empty;
	    TextBox341.Text=string.Empty;
	    TextBox342.Text=string.Empty;
	    TextBox343.Text=string.Empty;
	    TextBox344.Text=string.Empty;
	    TextBox345.Text=string.Empty;
	    TextBox346.Text=string.Empty;
	    TextBox347.Text=string.Empty;
	    TextBox348.Text=string.Empty;
	    TextBox349.Text=string.Empty;
	    TextBox350.Text=string.Empty;
	    TextBox351.Text=string.Empty;
	    TextBox352.Text=string.Empty;
	    TextBox353.Text=string.Empty;
	    TextBox354.Text=string.Empty;
	    TextBox355.Text=string.Empty;
	    TextBox356.Text=string.Empty;
	    TextBox357.Text=string.Empty;
	    TextBox358.Text=string.Empty;
	    TextBox359.Text=string.Empty;
	    TextBox360.Text=string.Empty;
	    TextBox361.Text=string.Empty;
	    TextBox362.Text=string.Empty;
	    TextBox363.Text=string.Empty;
	    TextBox364.Text=string.Empty;
	    TextBox365.Text=string.Empty;
	    TextBox366.Text=string.Empty;
	    TextBox367.Text=string.Empty;
	    TextBox368.Text=string.Empty;
	    TextBox369.Text=string.Empty;
	    TextBox370.Text=string.Empty;
	    TextBox371.Text=string.Empty;
	    TextBox372.Text=string.Empty;
	    TextBox373.Text=string.Empty;
	    TextBox374.Text=string.Empty;
	    TextBox375.Text=string.Empty;
	    TextBox376.Text=string.Empty;
	    TextBox377.Text=string.Empty;
	    TextBox378.Text=string.Empty;
	    TextBox379.Text=string.Empty;
	    TextBox380.Text=string.Empty;
	    TextBox381.Text=string.Empty;
	    TextBox382.Text=string.Empty;
	    TextBox383.Text=string.Empty;
	    TextBox384.Text=string.Empty;
	    TextBox385.Text=string.Empty;
	    TextBox386.Text=string.Empty;
	    TextBox387.Text=string.Empty;
	    TextBox388.Text=string.Empty;
	    TextBox389.Text=string.Empty;
	    TextBox390.Text=string.Empty;
	    TextBox391.Text=string.Empty;
	    TextBox392.Text=string.Empty;
	    TextBox393.Text=string.Empty;
	    TextBox394.Text=string.Empty;
	    TextBox395.Text=string.Empty;
	    TextBox396.Text=string.Empty;
	    TextBox397.Text=string.Empty;
	    TextBox398.Text=string.Empty;
	    TextBox399.Text=string.Empty;
	    TextBox400.Text=string.Empty;
	    TextBox401.Text=string.Empty;
	    TextBox402.Text=string.Empty;
	    TextBox403.Text=string.Empty;
	    TextBox404.Text=string.Empty;
	    TextBox405.Text=string.Empty;
	    TextBox406.Text=string.Empty;
	    TextBox407.Text=string.Empty;
	    TextBox408.Text=string.Empty;
	    TextBox409.Text=string.Empty;
	    TextBox410.Text=string.Empty;
	    TextBox411.Text=string.Empty;
	    TextBox412.Text=string.Empty;
	    TextBox413.Text=string.Empty;
	    TextBox414.Text=string.Empty;
	    TextBox415.Text=string.Empty;
	    TextBox416.Text=string.Empty;
	    TextBox417.Text=string.Empty;
	    TextBox418.Text=string.Empty;
	    TextBox419.Text=string.Empty;
	    TextBox420.Text=string.Empty;
	    TextBox421.Text=string.Empty;
	    TextBox422.Text=string.Empty;
	    TextBox423.Text=string.Empty;
	    TextBox424.Text=string.Empty;
	    TextBox425.Text=string.Empty;
	    TextBox426.Text=string.Empty;
	    TextBox427.Text=string.Empty;
	    TextBox428.Text=string.Empty;
	    TextBox429.Text=string.Empty;
	    TextBox430.Text=string.Empty;
	    TextBox431.Text=string.Empty;
	    TextBox432.Text=string.Empty;


    //*************** tbl_ART2 ******************
        TextBox433.Text=string.Empty;
	    TextBox434.Text=string.Empty;
	    TextBox435.Text=string.Empty;
	    TextBox436.Text=string.Empty;
	    TextBox437.Text=string.Empty;
	    TextBox438.Text=string.Empty;
	    TextBox439.Text=string.Empty;
	    TextBox440.Text=string.Empty;
	    TextBox441.Text=string.Empty;
	    TextBox442.Text=string.Empty;
	    TextBox443.Text=string.Empty;
	    TextBox444.Text=string.Empty;
	    TextBox445.Text=string.Empty;
	    TextBox446.Text=string.Empty;
	    TextBox447.Text=string.Empty;
	    TextBox448.Text=string.Empty;
	    TextBox449.Text=string.Empty;
	    TextBox450.Text=string.Empty;
	    TextBox451.Text=string.Empty;
	    TextBox452.Text=string.Empty;
	    TextBox453.Text=string.Empty;
	    TextBox454.Text=string.Empty;
	    TextBox455.Text=string.Empty;
	    TextBox456.Text=string.Empty;
	    TextBox457.Text=string.Empty;
	    TextBox458.Text=string.Empty;
	    TextBox459.Text=string.Empty;
	    TextBox460.Text=string.Empty;
	    TextBox461.Text=string.Empty;
	    TextBox462.Text=string.Empty;
	    TextBox463.Text=string.Empty;
	    TextBox464.Text=string.Empty;
	    TextBox465.Text=string.Empty;
	    TextBox466.Text=string.Empty;
	    TextBox467.Text=string.Empty;
	    TextBox468.Text=string.Empty;
	    TextBox469.Text=string.Empty;
	    TextBox470.Text=string.Empty;
	    TextBox471.Text=string.Empty;
	    TextBox472.Text=string.Empty;
	    TextBox473.Text=string.Empty;
	    TextBox474.Text=string.Empty;
	    TextBox475.Text=string.Empty;
	    TextBox476.Text=string.Empty;
	    TextBox477.Text=string.Empty;
	    TextBox478.Text=string.Empty;
	    TextBox479.Text=string.Empty;
	    TextBox480.Text=string.Empty;
	    TextBox481.Text=string.Empty;
	    TextBox482.Text=string.Empty;
	    TextBox483.Text=string.Empty;
	    TextBox484.Text=string.Empty;
	    TextBox485.Text=string.Empty;
	    TextBox486.Text=string.Empty;
	    TextBox487.Text=string.Empty;
	    TextBox488.Text=string.Empty;
	    TextBox489.Text=string.Empty;
	    TextBox490.Text=string.Empty;
	    TextBox491.Text=string.Empty;
	    TextBox492.Text=string.Empty;
	    TextBox493.Text=string.Empty;
	    TextBox494.Text=string.Empty;
	    TextBox495.Text=string.Empty;
	    TextBox496.Text=string.Empty;
	    TextBox497.Text=string.Empty;
	    TextBox498.Text=string.Empty;
	    TextBox499.Text=string.Empty;
	    TextBox500.Text=string.Empty;
	    TextBox501.Text=string.Empty;
	    TextBox502.Text=string.Empty;
	    TextBox503.Text=string.Empty;
	    TextBox504.Text=string.Empty;
	    TextBox505.Text=string.Empty;
	    TextBox506.Text=string.Empty;
	    TextBox507.Text=string.Empty;
	    TextBox508.Text=string.Empty;
	    TextBox509.Text=string.Empty;
	    TextBox510.Text=string.Empty;
	    TextBox511.Text=string.Empty;
	    TextBox512.Text=string.Empty;
	    TextBox513.Text=string.Empty;
	    TextBox514.Text=string.Empty;
	    TextBox515.Text=string.Empty;
	    TextBox516.Text=string.Empty;
	    TextBox517.Text=string.Empty;
	    TextBox518.Text=string.Empty;
	    TextBox519.Text=string.Empty;
	    TextBox520.Text=string.Empty;
	    TextBox521.Text=string.Empty;
	    TextBox522.Text=string.Empty;
	    TextBox523.Text=string.Empty;
	    TextBox524.Text=string.Empty;
	    TextBox525.Text=string.Empty;
	    TextBox526.Text=string.Empty;
	    TextBox527.Text=string.Empty;
	    TextBox528.Text=string.Empty;
	    TextBox529.Text=string.Empty;
	    TextBox530.Text=string.Empty;
	    TextBox531.Text=string.Empty;
	    TextBox532.Text=string.Empty;
	    TextBox533.Text=string.Empty;
	    TextBox534.Text=string.Empty;
	    TextBox535.Text=string.Empty;
	    TextBox536.Text=string.Empty;
	    TextBox537.Text=string.Empty;
	    TextBox538.Text=string.Empty;
	    TextBox539.Text=string.Empty;
	    TextBox540.Text=string.Empty;
	    TextBox541.Text=string.Empty;
	    TextBox542.Text=string.Empty;
	    TextBox543.Text=string.Empty;
	    TextBox544.Text=string.Empty;
	    TextBox545.Text=string.Empty;
	    TextBox546.Text=string.Empty;
	    TextBox547.Text=string.Empty;
	    TextBox548.Text=string.Empty;
	    TextBox549.Text=string.Empty;
	    TextBox550.Text=string.Empty;
	    TextBox551.Text=string.Empty;
	    TextBox552.Text=string.Empty;
	    TextBox553.Text=string.Empty;
	    TextBox554.Text=string.Empty;
	    TextBox555.Text=string.Empty;
	    TextBox556.Text=string.Empty;
	    TextBox557.Text=string.Empty;
	    TextBox558.Text=string.Empty;
	    TextBox559.Text=string.Empty;
	    TextBox560.Text=string.Empty;
	    TextBox561.Text=string.Empty;
	    TextBox562.Text=string.Empty;
	    TextBox563.Text=string.Empty;
	    TextBox564.Text=string.Empty;
	    TextBox565.Text=string.Empty;
	    TextBox566.Text=string.Empty;
	    TextBox567.Text=string.Empty;
	    TextBox568.Text=string.Empty;
	    TextBox569.Text=string.Empty;
	    TextBox570.Text=string.Empty;
	    TextBox571.Text=string.Empty;
	    TextBox572.Text=string.Empty;
	    TextBox573.Text=string.Empty;
	    TextBox574.Text=string.Empty;
	    TextBox575.Text=string.Empty;
	    TextBox576.Text=string.Empty;
	    TextBox577.Text=string.Empty;
	    TextBox578.Text=string.Empty;
	    TextBox579.Text=string.Empty;
	    TextBox580.Text=string.Empty;
	    TextBox581.Text=string.Empty;
	    TextBox582.Text=string.Empty;
	    TextBox583.Text=string.Empty;
	    TextBox584.Text=string.Empty;
	    TextBox585.Text=string.Empty;
	    TextBox586.Text=string.Empty;
	    TextBox587.Text=string.Empty;
	    TextBox588.Text=string.Empty;
	    TextBox589.Text=string.Empty;
	    TextBox590.Text=string.Empty;
	    TextBox591.Text=string.Empty;
	    TextBox592.Text=string.Empty;
	    TextBox593.Text=string.Empty;
	    TextBox594.Text=string.Empty;
	    TextBox595.Text=string.Empty;
	    TextBox596.Text=string.Empty;
	    TextBox597.Text=string.Empty;
	    TextBox598.Text=string.Empty;
	    TextBox599.Text=string.Empty;
	    TextBox600.Text=string.Empty;
	    TextBox601.Text=string.Empty;
	    TextBox602.Text=string.Empty;
	    TextBox603.Text=string.Empty;
	    TextBox604.Text=string.Empty;
	    TextBox605.Text=string.Empty;
	    TextBox606.Text=string.Empty;
	    TextBox607.Text=string.Empty;
	    TextBox608.Text=string.Empty;
	    TextBox609.Text=string.Empty;
	    TextBox610.Text=string.Empty;
        TextBox248.Focus();
        }catch(Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
            return;
        }
    }//===== end of ART cls ======

    protected void SAVE_ART()
    {
        string mTest = "";
         if(! String.IsNullOrEmpty(Session["editme"].ToString() ))
        {
            mTest = Session["editme"].ToString();
        }

        if (mTest.ToLower() != "true")
        {
            string sql = "INSERT INTO tbl_ART1 (states,lga,facname,months,years,grouptype,TOTALG1,	SUBG1MA,	G1MA1,	G1MA1_4,	G1MA5_9,";
            sql += "G1MA10_14,	G1MA15_19,	G1MA20_24,G1MA25_49,	G1MA50,	SUBG1FE,	G1FE1,	G1FE1_4,	G1FE5_9,	G1FE10_14,	G1FE15_19,	G1FE20_24,	G1FE25_49,";
            sql += "G1FE50,	G1PREGNANT,	G1BREASTFEED,	TOTALG2,	SUBG2MA,	G2MA1,	G2MA1_4,	G2MA5_9,	G2MA10_14,	G2MA15_19,";
            sql += "G2MA20_24,	G2MA25_49,	G2MA50,	SUBG2FE,	G2FE1,	G2FE1_4,	G2FE5_9,	G2FE10_14,	G2FE15_19,	G2FE20_24,	G2FE25_49,";
            sql += "G2FE50,	G2PREGNANT,	G2BREASTFEED,	TOTALG3,	SUBG3MA,	G3MA1,	G3MA1_4,	G3MA5_9,	G3MA10_14,	G3MA15_19,	G3MA20_24,";
            sql += "G3MA25_49,	G3MA50,	SUBG3FE,	G3FE1,	G3FE1_4,	G3FE5_9,	G3FE10_14,	G3FE15_19,	G3FE20_24,	G3FE25_49,	G3FE50,	G3PREGNANT,";
            sql += "G3BREASTFEED,	G3FSW,	G3MSM_TG,	G3PWID,	TOTALG4,	SUBG4MA,	G4MA1,	G4MA1_4,	G4MA5_9,	G4MA10_14,	G4MA15_19,	G4MA20_24,";
            sql += "G4MA25_49,	G4MA50,	SUBG4FE,	G4FE1,	G4FE1_4,	G4FE5_9,	G4FE10_14,	G4FE15_19,	G4FE20_24,	G4FE25_49,	G4FE50,	TOTALG5,	SUBG5MA,";
            sql += "G5MA1,	G5MA1_4,	G5MA5_9,	G5MA10_14,	G5MA15_19,	G5MA20_24,	G5MA25_49,	G5MA50,	SUBG5FE,	G54FE1,	G5FE1_4,	G5FE5_9,	G5FE10_14,";
            sql += "G5FE15_19,	G5FE20_24,	G5FE25_49,	G5FE50,	TOTALG6,	SUBG6MA,	G6MA1,	G6MA1_4,	G6MA5_9,	G6MA10_14,	G6MA15_19,	G6MA20_24,	G6MA25_49,";
            sql += "G6MA50,	SUBG6FE,	G6FE1,	G6FE1_4,	G6FE5_9,	G6FE10_14,	G6FE15_19,	G6FE20_24,	G6FE25_49,	G6FE50,	TOTALG7,	SUBG7MA,	G7MA1,	G7MA1_4,";
            sql += "G7MA5_9,	G7MA10_14,	G7MA15_19,	G7MA20_24,	G7MA25_49,	G7MA50,	SUBG7FE,	G7FE1,	G7FE1_4,	G7FE5_9,	G7FE10_14,	G7FE15_19,	G7FE20_24,	G7FE25_49,";
            sql += "G7FE50,	TOTALG8,	SUBG8MA,	G8MA1,	G8MA1_4,	G8MA5_9,	G8MA10_14,	G8MA15_19,	G8MA20_24,	G8MA25_49,	G8MA50,	SUBG8FE,	G8FE1,	G8FE1_4,";
            sql += "G8FE5_9,	G8FE10_14,	G8FE15_19,	G8FE20_24,	G8FE25_49,	G8FE50,	TOTALG9,	SUBG9MA,	G9MA1,	G9MA1_4,	G9MA5_9,	G9MA10_14,	G9MA15_19,	G9MA20_24,";
            sql += "G9MA25_49,	G9MA50,	SUBG9FE,	G9FE1,	G9FE1_4,	G9FE5_9,	G9FE10_14,	G9FE15_19,	G9FE20_24,	G9FE25_49,	G9FE50,	TOTALG10,	SUBG10MA,	G10MA1,";
            sql += "G10MA1_4,	G10MA5_9,	G10MA10_14,	G10MA15_19,	G10MA20_24,	G10MA25_49)";
            sql += "VALUES (@states,	@lga,	@facname,	@months,	@years,	@grouptype,@TOTALG1,@SUBG1MA,@G1MA1,@G1MA1_4,@G1MA5_9,@G1MA10_14,@G1MA15_19,@G1MA20_24,@G1MA25_49,";
            sql += "@G1MA50,@SUBG1FE,@G1FE1,@G1FE1_4,@G1FE5_9,@G1FE10_14,@G1FE15_19,@G1FE20_24,@G1FE25_49,@G1FE50,@G1PREGNANT,@G1BREASTFEED,@TOTALG2,@SUBG2MA,@G2MA1,@G2MA1_4,@G2MA5_9,";
            sql += "@G2MA10_14,@G2MA15_19,@G2MA20_24,@G2MA25_49,@G2MA50,@SUBG2FE,@G2FE1,@G2FE1_4,@G2FE5_9,@G2FE10_14,@G2FE15_19,@G2FE20_24,@G2FE25_49,@G2FE50,@G2PREGNANT,";
            sql += "@G2BREASTFEED,@TOTALG3,@SUBG3MA,@G3MA1,@G3MA1_4,@G3MA5_9,@G3MA10_14,@G3MA15_19,@G3MA20_24,@G3MA25_49,@G3MA50,@SUBG3FE,@G3FE1,@G3FE1_4,@G3FE5_9,@G3FE10_14,";
            sql += "@G3FE15_19,@G3FE20_24,@G3FE25_49,@G3FE50,@G3PREGNANT,@G3BREASTFEED,@G3FSW,@G3MSM_TG,@G3PWID,@TOTALG4,@SUBG4MA,@G4MA1,@G4MA1_4,@G4MA5_9,@G4MA10_14,@G4MA15_19,";
            sql += "@G4MA20_24,@G4MA25_49,@G4MA50,@SUBG4FE,@G4FE1,@G4FE1_4,@G4FE5_9,@G4FE10_14,@G4FE15_19,@G4FE20_24,@G4FE25_49,@G4FE50,@TOTALG5,@SUBG5MA,@G5MA1,@G5MA1_4,@G5MA5_9,";
            sql += "@G5MA10_14,@G5MA15_19,@G5MA20_24,@G5MA25_49,@G5MA50,@SUBG5FE,@G54FE1,@G5FE1_4,@G5FE5_9,@G5FE10_14,@G5FE15_19,@G5FE20_24,@G5FE25_49,@G5FE50,@TOTALG6,@SUBG6MA,";
            sql += "@G6MA1,@G6MA1_4,@G6MA5_9,@G6MA10_14,@G6MA15_19,@G6MA20_24,@G6MA25_49,@G6MA50,@SUBG6FE,@G6FE1,@G6FE1_4,@G6FE5_9,@G6FE10_14,@G6FE15_19,@G6FE20_24,@G6FE25_49,";
            sql += "@G6FE50,@TOTALG7,@SUBG7MA,@G7MA1,@G7MA1_4,@G7MA5_9,@G7MA10_14,@G7MA15_19,@G7MA20_24,@G7MA25_49,@G7MA50,@SUBG7FE,@G7FE1,@G7FE1_4,@G7FE5_9,@G7FE10_14,@G7FE15_19,";
            sql += "@G7FE20_24,@G7FE25_49,@G7FE50,@TOTALG8,@SUBG8MA,@G8MA1,@G8MA1_4,@G8MA5_9,@G8MA10_14,@G8MA15_19,@G8MA20_24,@G8MA25_49,@G8MA50,@SUBG8FE,@G8FE1,@G8FE1_4,@G8FE5_9,";
            sql += "@G8FE10_14,@G8FE15_19,@G8FE20_24,@G8FE25_49,@G8FE50,@TOTALG9,@SUBG9MA,@G9MA1,@G9MA1_4,@G9MA5_9,@G9MA10_14,@G9MA15_19,@G9MA20_24,@G9MA25_49,@G9MA50,@SUBG9FE,@G9FE1,";
            sql += "@G9FE1_4,@G9FE5_9,@G9FE10_14,@G9FE15_19,@G9FE20_24,@G9FE25_49,@G9FE50,@TOTALG10,@SUBG10MA,@G10MA1,@G10MA1_4,@G10MA5_9,@G10MA10_14,@G10MA15_19,@G10MA20_24,@G10MA25_49)";



            string sql1 = "INSERT INTO tbl_ART2 VALUES (@states,@lga,@facname,@months,@years,@grouptype,@G10MA50,@SUBG10FE,@G10FE1,@G10FE1_4,@G10FE5_9,@G10FE10_14,@G10FE15_19,";
            sql1 += "@G10FE20_24,@G10FE25_49,@G10FE50,@G10PREGNANT,@G10BREASTFEED,@G10ROUTINE,@G10TARGET,@TOTALG11,@SUBG11MA,@G11MA1,@G11MA1_4,@G11MA5_9,@G11MA10_14,@G11MA15_19,";
            sql1 += "@G11MA20_24,@G11MA25_49,@G11MA50,@SUBG11FE,@G11FE1,@G11FE1_4,@G11FE5_9,@G11FE10_14,@G11FE15_19,@G11FE20_24,@G11FE25_49,@G11FE50,@G11PREGNANT,@G11BREASTFEED,@G11ROUTINE,";
            sql1 += "@G11TARGET,@TOTALG12,@SUBG12MA,@G12MA1,@G12MA1_4,@G12MA5_9,@G12MA10_14,@G12MA15_19,@G12MA20_24,@G12MA25_49,@G12MA50,@SUBG12FE,@G12FE1,@G12FE1_4,@G12FE5_9,@G12FE10_14,";
            sql1 += "@G12FE15_19,@G12FE20_24,@G12FE25_49,@G12FE50,@G12PREGNANT,@G12BREASTFEED,@TOTALG13,@SUBG13MA,@G13MA1,@G13MA1_4,@G13MA5_9,@G13MA10_14,@G13MA15_19,@G13MA20_24,@G13MA25_49,";
            sql1 += "@G13MA50,@SUBG13FE,@G13FE1,@G13FE1_4,@G13FE5_9,@G13FE10_14,@G13FE15_19,@G13FE20_24,@G13FE25_49,@G13FE50,@G13PREGNANT,@G13BREASTFEED,@TOTALG14,@SUBG14MA,@G14MA1,@G14MA1_4,";
            sql1 += "@G14MA5_9,@G14MA10_14,@G14MA15_19,@G14MA20_24,@G14MA25_49,@G14MA50,@SUBG14FE,@G14FE1,@G14FE1_4,@G14FE5_9,@G14FE10_14,@G14FE15_19,@G14FE20_24,@G14FE25_49,@G14FE50,@G14UNDETECTABLE,";
            sql1 += "@G14DETECTABLE,@TOTALG15,@SUBG15MA,@G15MA1,@G15MA1_4,@G15MA5_9,@G15MA10_14,@G15MA15_19,@G15MA20_24,@G15MA25_49,@G15MA50,@SUBG15FE,@G15FE1,@G15FE1_4,@G15FE5_9,@G15FE10_14,@G15FE15_19,";
            sql1 += "@G15FE20_24,@G15FE25_49,@G15FE50,@G15UNDETECTABLE,@G15DETECTABLE,@TOTALG16,@SUBG16MA,@G16MA1,@G16MA1_4,@G16MA5_9,@G16MA10_14,@G16MA15_19,@G16MA20_24,@G16MA25_49,@G16MA50,@SUBG16FE,";
            sql1 += "@G16FE1,@G16FE1_4,@G16FE5_9,@G16FE10_14,@G16FE15_19,@G16FE20_24,@G16FE25_49,@G16FE50,@TOTALG17,@SUBG17MA,@G17MA1,@G17MA1_4,@G17MA5_9,@G17MA10_14,@G17MA15_19,@G17MA20_24,@G17MA25_49,";
            sql1 += " @G17MA50,@SUBG17FE,@G17FE1,@G17FE1_4,@G17FE5_9,@G17FE10_14,@G17FE15_19,@G17FE20_24,@G17FE25_49,@G17FE50,@TOTALG18,@SUBG18MA,@G18MA1,@G18MA1_4,@G18MA5_9,@G18MA10_14,@G18MA15_19,@G18MA20_24,";
            sql1 += "@G18MA25_49,@G18MA50,@SUBG18FE,@G18FE1,@G18FE1_4,@G18FE5_9,@G18FE10_14,@G18FE15_19,@G18FE20_24,@G18FE25_49,@G18FE50)";

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

                //*************** tbl_ART1
                cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox248.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox249.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox250.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox251.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox252.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox253.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA15_19", SqlDbType.Int).Value = TextBox254.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA20_24", SqlDbType.Int).Value = TextBox255.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA25_49", SqlDbType.Int).Value = TextBox256.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA50", SqlDbType.Int).Value = TextBox257.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox258.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox259.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox260.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox261.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox262.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE15_19", SqlDbType.Int).Value = TextBox263.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE20_24", SqlDbType.Int).Value = TextBox264.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE25_49", SqlDbType.Int).Value = TextBox265.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE50", SqlDbType.Int).Value = TextBox266.Text.Trim();
                cmd.Parameters.AddWithValue("@G1PREGNANT", SqlDbType.Int).Value = TextBox1074.Text.Trim();
                cmd.Parameters.AddWithValue("@G1BREASTFEED", SqlDbType.Int).Value = TextBox1075.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox267.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox268.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox269.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox270.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox271.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox272.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA15_19", SqlDbType.Int).Value = TextBox273.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA20_24", SqlDbType.Int).Value = TextBox274.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA25_49", SqlDbType.Int).Value = TextBox275.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA50", SqlDbType.Int).Value = TextBox276.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox277.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox278.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox279.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox280.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox281.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE15_19", SqlDbType.Int).Value = TextBox282.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE20_24", SqlDbType.Int).Value = TextBox283.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE25_49", SqlDbType.Int).Value = TextBox284.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE50", SqlDbType.Int).Value = TextBox285.Text.Trim();
                cmd.Parameters.AddWithValue("@G2PREGNANT", SqlDbType.Int).Value = TextBox1072.Text.Trim();
                cmd.Parameters.AddWithValue("@G2BREASTFEED", SqlDbType.Int).Value = TextBox1073.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox286.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox287.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox288.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox289.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox290.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox291.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA15_19", SqlDbType.Int).Value = TextBox292.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA20_24", SqlDbType.Int).Value = TextBox293.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA25_49", SqlDbType.Int).Value = TextBox294.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA50", SqlDbType.Int).Value = TextBox295.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox296.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox297.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox298.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox299.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox300.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE15_19", SqlDbType.Int).Value = TextBox301.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE20_24", SqlDbType.Int).Value = TextBox302.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE25_49", SqlDbType.Int).Value = TextBox303.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE50", SqlDbType.Int).Value = TextBox304.Text.Trim();
                cmd.Parameters.AddWithValue("@G3PREGNANT", SqlDbType.Int).Value = TextBox305.Text.Trim();
                cmd.Parameters.AddWithValue("@G3BREASTFEED", SqlDbType.Int).Value = TextBox306.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FSW", SqlDbType.Int).Value = TextBox307.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MSM_TG", SqlDbType.Int).Value = TextBox308.Text.Trim();
                cmd.Parameters.AddWithValue("@G3PWID", SqlDbType.Int).Value = TextBox309.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox310.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox311.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox312.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox313.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox314.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox315.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA15_19", SqlDbType.Int).Value = TextBox316.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA20_24", SqlDbType.Int).Value = TextBox317.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA25_49", SqlDbType.Int).Value = TextBox318.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA50", SqlDbType.Int).Value = TextBox319.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox320.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox321.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox322.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox323.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox324.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE15_19", SqlDbType.Int).Value = TextBox325.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE20_24", SqlDbType.Int).Value = TextBox326.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE25_49", SqlDbType.Int).Value = TextBox327.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE50", SqlDbType.Int).Value = TextBox328.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox329.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox330.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox331.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox332.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox333.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox334.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA15_19", SqlDbType.Int).Value = TextBox335.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA20_24", SqlDbType.Int).Value = TextBox336.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA25_49", SqlDbType.Int).Value = TextBox337.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA50", SqlDbType.Int).Value = TextBox338.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox339.Text.Trim();
                cmd.Parameters.AddWithValue("@G54FE1", SqlDbType.Int).Value = TextBox340.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox341.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox342.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox343.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE15_19", SqlDbType.Int).Value = TextBox344.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE20_24", SqlDbType.Int).Value = TextBox345.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE25_49", SqlDbType.Int).Value = TextBox346.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE50", SqlDbType.Int).Value = TextBox347.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox348.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox349.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox350.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox351.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox352.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox353.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA15_19", SqlDbType.Int).Value = TextBox354.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA20_24", SqlDbType.Int).Value = TextBox355.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA25_49", SqlDbType.Int).Value = TextBox356.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA50", SqlDbType.Int).Value = TextBox357.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox358.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox359.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox360.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox361.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox362.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE15_19", SqlDbType.Int).Value = TextBox363.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE20_24", SqlDbType.Int).Value = TextBox364.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE25_49", SqlDbType.Int).Value = TextBox365.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE50", SqlDbType.Int).Value = TextBox366.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox367.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox368.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox369.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox370.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox371.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox372.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA15_19", SqlDbType.Int).Value = TextBox373.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA20_24", SqlDbType.Int).Value = TextBox374.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA25_49", SqlDbType.Int).Value = TextBox375.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA50", SqlDbType.Int).Value = TextBox376.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox377.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox378.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox379.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox380.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox381.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE15_19", SqlDbType.Int).Value = TextBox382.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox383.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox384.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE50", SqlDbType.Int).Value = TextBox385.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox386.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox387.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox388.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox389.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox390.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox391.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA15_19", SqlDbType.Int).Value = TextBox392.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA20_24", SqlDbType.Int).Value = TextBox393.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA25_49", SqlDbType.Int).Value = TextBox394.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA50", SqlDbType.Int).Value = TextBox395.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox396.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox397.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox398.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox399.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox400.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE15_19", SqlDbType.Int).Value = TextBox401.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE20_24", SqlDbType.Int).Value = TextBox402.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE25_49", SqlDbType.Int).Value = TextBox403.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE50", SqlDbType.Int).Value = TextBox404.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox405.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox406.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox407.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox408.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox409.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox410.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = TextBox411.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = TextBox412.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = TextBox413.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = TextBox414.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox415.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox416.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox417.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox418.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox419.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = TextBox420.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = TextBox421.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = TextBox422.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = TextBox423.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox424.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox425.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox426.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox427.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox428.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox429.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA15_19", SqlDbType.Int).Value = TextBox430.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA20_24", SqlDbType.Int).Value = TextBox431.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA25_49", SqlDbType.Int).Value = TextBox432.Text.Trim();
                int Rowaffected = cmd.ExecuteNonQuery();

                // ================ ART 2 =======================
                SqlCommand cmd1 = new SqlCommand(sql1, cn);

                cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                cmd1.Parameters.AddWithValue("@G10MA50", SqlDbType.Int).Value = TextBox433.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox434.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox435.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox436.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox437.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox438.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE15_19", SqlDbType.Int).Value = TextBox439.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE20_24", SqlDbType.Int).Value = TextBox440.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE25_49", SqlDbType.Int).Value = TextBox441.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE50", SqlDbType.Int).Value = TextBox442.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10PREGNANT", SqlDbType.Int).Value = TextBox443.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10BREASTFEED", SqlDbType.Int).Value = TextBox444.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10ROUTINE", SqlDbType.Int).Value = TextBox445.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10TARGET", SqlDbType.Int).Value = TextBox446.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox447.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox448.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox449.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox450.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox451.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox452.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = TextBox453.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = TextBox454.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = TextBox455.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = TextBox456.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox457.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox458.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox459.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox460.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox461.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = TextBox462.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = TextBox463.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = TextBox464.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = TextBox465.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11PREGNANT", SqlDbType.Int).Value = TextBox466.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11BREASTFEED", SqlDbType.Int).Value = TextBox467.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11ROUTINE", SqlDbType.Int).Value = TextBox468.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11TARGET", SqlDbType.Int).Value = TextBox469.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox470.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG12MA", SqlDbType.Int).Value = TextBox471.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = TextBox472.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = TextBox473.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = TextBox474.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = TextBox475.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = TextBox476.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = TextBox477.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox478.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = TextBox479.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG12FE", SqlDbType.Int).Value = TextBox480.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = TextBox481.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = TextBox482.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = TextBox483.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = TextBox484.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = TextBox485.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = TextBox486.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = TextBox487.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = TextBox488.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12PREGNANT", SqlDbType.Int).Value = TextBox489.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12BREASTFEED", SqlDbType.Int).Value = TextBox490.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG13", SqlDbType.Int).Value = TextBox491.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG13MA", SqlDbType.Int).Value = TextBox492.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA1", SqlDbType.Int).Value = TextBox493.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA1_4", SqlDbType.Int).Value = TextBox494.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA5_9", SqlDbType.Int).Value = TextBox495.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA10_14", SqlDbType.Int).Value = TextBox496.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA15_19", SqlDbType.Int).Value = TextBox497.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA20_24", SqlDbType.Int).Value = TextBox498.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA25_49", SqlDbType.Int).Value = TextBox499.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA50", SqlDbType.Int).Value = TextBox500.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG13FE", SqlDbType.Int).Value = TextBox501.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE1", SqlDbType.Int).Value = TextBox502.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE1_4", SqlDbType.Int).Value = TextBox503.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE5_9", SqlDbType.Int).Value = TextBox504.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE10_14", SqlDbType.Int).Value = TextBox505.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE15_19", SqlDbType.Int).Value = TextBox506.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE20_24", SqlDbType.Int).Value = TextBox507.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE25_49", SqlDbType.Int).Value = TextBox508.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE50", SqlDbType.Int).Value = TextBox509.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13PREGNANT", SqlDbType.Int).Value = TextBox510.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13BREASTFEED", SqlDbType.Int).Value = TextBox511.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG14", SqlDbType.Int).Value = TextBox512.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG14MA", SqlDbType.Int).Value = TextBox513.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA1", SqlDbType.Int).Value = TextBox514.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA1_4", SqlDbType.Int).Value = TextBox515.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA5_9", SqlDbType.Int).Value = TextBox516.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA10_14", SqlDbType.Int).Value = TextBox517.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA15_19", SqlDbType.Int).Value = TextBox518.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA20_24", SqlDbType.Int).Value = TextBox519.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA25_49", SqlDbType.Int).Value = TextBox520.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA50", SqlDbType.Int).Value = TextBox521.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG14FE", SqlDbType.Int).Value = TextBox522.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE1", SqlDbType.Int).Value = TextBox523.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE1_4", SqlDbType.Int).Value = TextBox524.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE5_9", SqlDbType.Int).Value = TextBox525.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE10_14", SqlDbType.Int).Value = TextBox526.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE15_19", SqlDbType.Int).Value = TextBox527.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE20_24", SqlDbType.Int).Value = TextBox528.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE25_49", SqlDbType.Int).Value = TextBox529.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE50", SqlDbType.Int).Value = TextBox530.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14UNDETECTABLE", SqlDbType.Int).Value = TextBox531.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14DETECTABLE", SqlDbType.Int).Value = TextBox532.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG15", SqlDbType.Int).Value = TextBox533.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG15MA", SqlDbType.Int).Value = TextBox534.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA1", SqlDbType.Int).Value = TextBox535.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA1_4", SqlDbType.Int).Value = TextBox536.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA5_9", SqlDbType.Int).Value = TextBox537.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA10_14", SqlDbType.Int).Value = TextBox538.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA15_19", SqlDbType.Int).Value = TextBox539.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA20_24", SqlDbType.Int).Value = TextBox540.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA25_49", SqlDbType.Int).Value = TextBox541.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA50", SqlDbType.Int).Value = TextBox542.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG15FE", SqlDbType.Int).Value = TextBox543.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE1", SqlDbType.Int).Value = TextBox544.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE1_4", SqlDbType.Int).Value = TextBox545.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE5_9", SqlDbType.Int).Value = TextBox546.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE10_14", SqlDbType.Int).Value = TextBox547.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE15_19", SqlDbType.Int).Value = TextBox548.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE20_24", SqlDbType.Int).Value = TextBox549.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE25_49", SqlDbType.Int).Value = TextBox550.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE50", SqlDbType.Int).Value = TextBox551.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15UNDETECTABLE", SqlDbType.Int).Value = TextBox552.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15DETECTABLE", SqlDbType.Int).Value = TextBox553.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG16", SqlDbType.Int).Value = TextBox554.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG16MA", SqlDbType.Int).Value = TextBox555.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA1", SqlDbType.Int).Value = TextBox556.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA1_4", SqlDbType.Int).Value = TextBox557.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA5_9", SqlDbType.Int).Value = TextBox558.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA10_14", SqlDbType.Int).Value = TextBox559.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA15_19", SqlDbType.Int).Value = TextBox560.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA20_24", SqlDbType.Int).Value = TextBox561.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA25_49", SqlDbType.Int).Value = TextBox562.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA50", SqlDbType.Int).Value = TextBox563.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG16FE", SqlDbType.Int).Value = TextBox564.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE1", SqlDbType.Int).Value = TextBox565.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE1_4", SqlDbType.Int).Value = TextBox566.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE5_9", SqlDbType.Int).Value = TextBox567.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE10_14", SqlDbType.Int).Value = TextBox568.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE15_19", SqlDbType.Int).Value = TextBox569.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE20_24", SqlDbType.Int).Value = TextBox570.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE25_49", SqlDbType.Int).Value = TextBox571.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE50", SqlDbType.Int).Value = TextBox572.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG17", SqlDbType.Int).Value = TextBox573.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG17MA", SqlDbType.Int).Value = TextBox574.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA1", SqlDbType.Int).Value = TextBox575.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA1_4", SqlDbType.Int).Value = TextBox576.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA5_9", SqlDbType.Int).Value = TextBox577.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA10_14", SqlDbType.Int).Value = TextBox578.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA15_19", SqlDbType.Int).Value = TextBox579.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA20_24", SqlDbType.Int).Value = TextBox580.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA25_49", SqlDbType.Int).Value = TextBox581.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA50", SqlDbType.Int).Value = TextBox582.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG17FE", SqlDbType.Int).Value = TextBox583.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE1", SqlDbType.Int).Value = TextBox584.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE1_4", SqlDbType.Int).Value = TextBox585.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE5_9", SqlDbType.Int).Value = TextBox586.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE10_14", SqlDbType.Int).Value = TextBox587.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE15_19", SqlDbType.Int).Value = TextBox588.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE20_24", SqlDbType.Int).Value = TextBox589.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE25_49", SqlDbType.Int).Value = TextBox590.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE50", SqlDbType.Int).Value = TextBox591.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG18", SqlDbType.Int).Value = TextBox592.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG18MA", SqlDbType.Int).Value = TextBox593.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA1", SqlDbType.Int).Value = TextBox594.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA1_4", SqlDbType.Int).Value = TextBox595.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA5_9", SqlDbType.Int).Value = TextBox596.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA10_14", SqlDbType.Int).Value = TextBox597.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA15_19", SqlDbType.Int).Value = TextBox598.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA20_24", SqlDbType.Int).Value = TextBox599.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA25_49", SqlDbType.Int).Value = TextBox600.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA50", SqlDbType.Int).Value = TextBox601.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG18FE", SqlDbType.Int).Value = TextBox602.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE1", SqlDbType.Int).Value = TextBox603.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE1_4", SqlDbType.Int).Value = TextBox604.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE5_9", SqlDbType.Int).Value = TextBox605.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE10_14", SqlDbType.Int).Value = TextBox606.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE15_19", SqlDbType.Int).Value = TextBox607.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE20_24", SqlDbType.Int).Value = TextBox608.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE25_49", SqlDbType.Int).Value = TextBox609.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE50", SqlDbType.Int).Value = TextBox610.Text.Trim();
                int Rowsaffected1 = cmd1.ExecuteNonQuery();

                if (Rowaffected != -1 && Rowsaffected1 != -1)
                    webMessage.Show(Rowaffected.ToString() + " Successful ");
                    //Response.Write("<script language=javascript>alert('" + Rowaffected.ToString() + " Successful ');</script>");
                CLS_ART();
                return;
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
                return;
            }
        }else
        {
   //=============== Updating of ART Records
            string sql = "UPDATE  tbl_ART1 SET states = @states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=	@grouptype,TOTALG1=@TOTALG1,SUBG1MA=@SUBG1MA,G1MA1=@G1MA1,G1MA1_4=@G1MA1_4,G1MA5_9=@G1MA5_9,G1MA10_14=@G1MA10_14,G1MA15_19=@G1MA15_19,G1MA20_24=@G1MA20_24,G1MA25_49=@G1MA25_49,";
            sql += "G1MA50=@G1MA50,SUBG1FE=@SUBG1FE,G1FE1=@G1FE1,G1FE1_4=@G1FE1_4,G1FE5_9=@G1FE5_9,G1FE10_14=@G1FE10_14,G1FE15_19=@G1FE15_19,G1FE20_24=@G1FE20_24,G1FE25_49=@G1FE25_49,G1FE50=@G1FE50,G1PREGNANT=@G1PREGNANT,G1BREASTFEED=@G1BREASTFEED,TOTALG2=@TOTALG2,SUBG2MA=@SUBG2MA,G2MA1=@G2MA1,G2MA1_4=@G2MA1_4,G2MA5_9=@G2MA5_9,";
            sql += "G2MA10_14=@G2MA10_14,G2MA15_19=@G2MA15_19,G2MA20_24=@G2MA20_24,G2MA25_49=@G2MA25_49,G2MA50=@G2MA50,SUBG2FE=@SUBG2FE,G2FE1=@G2FE1,G2FE1_4=@G2FE1_4,G2FE5_9=@G2FE5_9,G2FE10_14=@G2FE10_14,G2FE15_19=@G2FE15_19,G2FE20_24=@G2FE20_24,G2FE25_49=@G2FE25_49,G2FE50=@G2FE50,G2PREGNANT=@G2PREGNANT,";
            sql += "G2BREASTFEED=@G2BREASTFEED,TOTALG3=@TOTALG3,SUBG3MA=@SUBG3MA,G3MA1=@G3MA1,G3MA1_4=@G3MA1_4,G3MA5_9=@G3MA5_9,G3MA10_14=@G3MA10_14,G3MA15_19=@G3MA15_19,G3MA20_24=@G3MA20_24,G3MA25_49=@G3MA25_49,G3MA50=@G3MA50,SUBG3FE=@SUBG3FE,G3FE1=@G3FE1,G3FE1_4=@G3FE1_4,G3FE5_9=@G3FE5_9,G3FE10_14=@G3FE10_14,";
            sql += "G3FE15_19=@G3FE15_19,G3FE20_24=@G3FE20_24,G3FE25_49=@G3FE25_49,G3FE50=@G3FE50,G3PREGNANT=@G3PREGNANT,G3BREASTFEED=@G3BREASTFEED,G3FSW=@G3FSW,G3MSM_TG=@G3MSM_TG,G3PWID=@G3PWID,TOTALG4=@TOTALG4,SUBG4MA=@SUBG4MA,G4MA1=@G4MA1,G4MA1_4=@G4MA1_4,G4MA5_9=@G4MA5_9,G4MA10_14=@G4MA10_14,G4MA15_19=@G4MA15_19,";
            sql += "G4MA20_24=@G4MA20_24,G4MA25_49=@G4MA25_49,G4MA50=@G4MA50,SUBG4FE=@SUBG4FE,G4FE1=@G4FE1,G4FE1_4=@G4FE1_4,G4FE5_9=@G4FE5_9,G4FE10_14=@G4FE10_14,G4FE15_19=@G4FE15_19,G4FE20_24=@G4FE20_24,G4FE25_49=@G4FE25_49,G4FE50=@G4FE50,TOTALG5=@TOTALG5,SUBG5MA=@SUBG5MA,G5MA1=@G5MA1,G5MA1_4=@G5MA1_4,G5MA5_9=@G5MA5_9,";
            sql += "G5MA10_14=@G5MA10_14,G5MA15_19=@G5MA15_19,G5MA20_24=@G5MA20_24,G5MA25_49=@G5MA25_49,G5MA50=@G5MA50,SUBG5FE=@SUBG5FE,G54FE1=@G54FE1,G5FE1_4=@G5FE1_4,G5FE5_9=@G5FE5_9,G5FE10_14=@G5FE10_14,G5FE15_19=@G5FE15_19,G5FE20_24=@G5FE20_24,G5FE25_49=@G5FE25_49,G5FE50=@G5FE50,TOTALG6=@TOTALG6,SUBG6MA=@SUBG6MA,";
            sql += "G6MA1=@G6MA1,G6MA1_4=@G6MA1_4,G6MA5_9=@G6MA5_9,G6MA10_14=@G6MA10_14,G6MA15_19=@G6MA15_19,G6MA20_24=@G6MA20_24,G6MA25_49=@G6MA25_49,G6MA50=@G6MA50,SUBG6FE=@SUBG6FE,G6FE1=@G6FE1,G6FE1_4=@G6FE1_4,G6FE5_9=@G6FE5_9,G6FE10_14=@G6FE10_14,G6FE15_19=@G6FE15_19,G6FE20_24=@G6FE20_24,G6FE25_49=@G6FE25_49,";
            sql += "G6FE50=@G6FE50,TOTALG7=@TOTALG7,SUBG7MA=@SUBG7MA,G7MA1=@G7MA1,G7MA1_4=@G7MA1_4,G7MA5_9=@G7MA5_9,G7MA10_14=@G7MA10_14,G7MA15_19=@G7MA15_19,G7MA20_24=@G7MA20_24,G7MA25_49=@G7MA25_49,G7MA50=@G7MA50,SUBG7FE=@SUBG7FE,G7FE1=@G7FE1,G7FE1_4=@G7FE1_4,G7FE5_9=@G7FE5_9,G7FE10_14=@G7FE10_14,G7FE15_19=@G7FE15_19,";
            sql += "G7FE20_24=@G7FE20_24,G7FE25_49=@G7FE25_49,G7FE50=@G7FE50,TOTALG8=@TOTALG8,SUBG8MA=@SUBG8MA,G8MA1=@G8MA1,G8MA1_4=@G8MA1_4,G8MA5_9=@G8MA5_9,G8MA10_14=@G8MA10_14,G8MA15_19=@G8MA15_19,G8MA20_24=@G8MA20_24,G8MA25_49=@G8MA25_49,G8MA50=@G8MA50,SUBG8FE=@SUBG8FE,G8FE1=@G8FE1,G8FE1_4=@G8FE1_4,G8FE5_9=@G8FE5_9,";
            sql += "G8FE10_14=@G8FE10_14,G8FE15_19=@G8FE15_19,G8FE20_24=@G8FE20_24,G8FE25_49=@G8FE25_49,G8FE50=@G8FE50,TOTALG9=@TOTALG9,SUBG9MA=@SUBG9MA,G9MA1=@G9MA1,G9MA1_4=@G9MA1_4,G9MA5_9=@G9MA5_9,G9MA10_14=@G9MA10_14,G9MA15_19=@G9MA15_19,G9MA20_24=@G9MA20_24,G9MA25_49=@G9MA25_49,G9MA50=@G9MA50,SUBG9FE=@SUBG9FE,G9FE1=@G9FE1,";
            sql += "G9FE1_4=@G9FE1_4,G9FE5_9=@G9FE5_9,G9FE10_14=@G9FE10_14,G9FE15_19=@G9FE15_19,G9FE20_24=@G9FE20_24,G9FE25_49=@G9FE25_49,G9FE50=@G9FE50,TOTALG10=@TOTALG10,SUBG10MA=@SUBG10MA,G10MA1=@G10MA1,G10MA1_4=@G10MA1_4,G10MA5_9=@G10MA5_9,G10MA10_14=@G10MA10_14,G10MA15_19=@G10MA15_19,G10MA20_24=@G10MA20_24,G10MA25_49=@G10MA25_49 ";
            sql += " WHERE  states = @states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=	@grouptype ";


            string sql1 = "UPDATE  tbl_ART2 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,G10MA50=@G10MA50,SUBG10FE=@SUBG10FE,G10FE1=@G10FE1,G10FE1_4=@G10FE1_4,G10FE5_9=@G10FE5_9,G10FE10_14=@G10FE10_14,G10FE15_19=@G10FE15_19,";
            sql1 += "G10FE20_24=@G10FE20_24,G10FE25_49=@G10FE25_49,G10FE50=@G10FE50,G10PREGNANT=@G10PREGNANT,G10BREASTFEED=@G10BREASTFEED,G10ROUTINE=@G10ROUTINE,G10TARGET=@G10TARGET,TOTALG11=@TOTALG11,SUBG11MA=@SUBG11MA,G11MA1=@G11MA1,G11MA1_4=@G11MA1_4,G11MA5_9=@G11MA5_9,G11MA10_14=@G11MA10_14,G11MA15_19=@G11MA15_19,";
            sql1 += "G11MA20_24=@G11MA20_24,G11MA25_49=@G11MA25_49,G11MA50=@G11MA50,SUBG11FE=@SUBG11FE,G11FE1=@G11FE1,G11FE1_4=@G11FE1_4,G11FE5_9=@G11FE5_9,G11FE10_14=@G11FE10_14,G11FE15_19=@G11FE15_19,G11FE20_24=@G11FE20_24,G11FE25_49=@G11FE25_49,G11FE50=@G11FE50,G11PREGNANT=@G11PREGNANT,G11BREASTFEED=@G11BREASTFEED,G11ROUTINE=@G11ROUTINE,";
            sql1 += "G11TARGET=@G11TARGET,TOTALG12=@TOTALG12,SUBG12MA=@SUBG12MA,G12MA1=@G12MA1,G12MA1_4=@G12MA1_4,G12MA5_9=@G12MA5_9,G12MA10_14=@G12MA10_14,G12MA15_19=@G12MA15_19,G12MA20_24=@G12MA20_24,G12MA25_49=@G12MA25_49,G12MA50=@G12MA50,SUBG12FE=@SUBG12FE,G12FE1=@G12FE1,G12FE1_4=@G12FE1_4,G12FE5_9=@G12FE5_9,G12FE10_14=@G12FE10_14,";
            sql1 += "G12FE15_19=@G12FE15_19,G12FE20_24=@G12FE20_24,G12FE25_49=@G12FE25_49,G12FE50=@G12FE50,G12PREGNANT=@G12PREGNANT,G12BREASTFEED=@G12BREASTFEED,TOTALG13=@TOTALG13,SUBG13MA=@SUBG13MA,G13MA1=@G13MA1,G13MA1_4=@G13MA1_4,G13MA5_9=@G13MA5_9,G13MA10_14=@G13MA10_14,G13MA15_19=@G13MA15_19,G13MA20_24=@G13MA20_24,G13MA25_49=@G13MA25_49,";
            sql1 += "G13MA50=@G13MA50,SUBG13FE=@SUBG13FE,G13FE1=@G13FE1,G13FE1_4=@G13FE1_4,G13FE5_9=@G13FE5_9,G13FE10_14=@G13FE10_14,G13FE15_19=@G13FE15_19,G13FE20_24=@G13FE20_24,G13FE25_49=@G13FE25_49,G13FE50=@G13FE50,G13PREGNANT=@G13PREGNANT,G13BREASTFEED=@G13BREASTFEED,TOTALG14=@TOTALG14,SUBG14MA=@SUBG14MA,G14MA1=@G14MA1,G14MA1_4=@G14MA1_4,";
            sql1 += "G14MA5_9=@G14MA5_9,G14MA10_14=@G14MA10_14,G14MA15_19=@G14MA15_19,G14MA20_24=@G14MA20_24,G14MA25_49=@G14MA25_49,G14MA50=@G14MA50,SUBG14FE=@SUBG14FE,G14FE1=@G14FE1,G14FE1_4=@G14FE1_4,G14FE5_9=@G14FE5_9,G14FE10_14=@G14FE10_14,G14FE15_19=@G14FE15_19,G14FE20_24=@G14FE20_24,G14FE25_49=@G14FE25_49,G14FE50=@G14FE50,G14UNDETECTABLE=@G14UNDETECTABLE,";
            sql1 += "G14DETECTABLE=@G14DETECTABLE,TOTALG15=@TOTALG15,SUBG15MA=@SUBG15MA,G15MA1=@G15MA1,G15MA1_4=@G15MA1_4,G15MA5_9=@G15MA5_9,G15MA10_14=@G15MA10_14,G15MA15_19=@G15MA15_19,G15MA20_24=@G15MA20_24,G15MA25_49=@G15MA25_49,G15MA50=@G15MA50,SUBG15FE=@SUBG15FE,G15FE1=@G15FE1,G15FE1_4=@G15FE1_4,G15FE5_9=@G15FE5_9,G15FE10_14=@G15FE10_14,G15FE15_19=@G15FE15_19,";
            sql1 += "G15FE20_24=@G15FE20_24,G15FE25_49=@G15FE25_49,G15FE50=@G15FE50,G15UNDETECTABLE=@G15UNDETECTABLE,G15DETECTABLE=@G15DETECTABLE,TOTALG16=@TOTALG16,SUBG16MA=@SUBG16MA,G16MA1=@G16MA1,G16MA1_4=@G16MA1_4,G16MA5_9=@G16MA5_9,G16MA10_14=@G16MA10_14,G16MA15_19=@G16MA15_19,G16MA20_24=@G16MA20_24,G16MA25_49=@G16MA25_49,G16MA50=@G16MA50,SUBG16FE=@SUBG16FE,";
            sql1 += "G16FE1=@G16FE1,G16FE1_4=@G16FE1_4,G16FE5_9=@G16FE5_9,G16FE10_14=@G16FE10_14,G16FE15_19=@G16FE15_19,G16FE20_24=@G16FE20_24,G16FE25_49=@G16FE25_49,G16FE50=@G16FE50,TOTALG17=@TOTALG17,SUBG17MA=@SUBG17MA,G17MA1=@G17MA1,G17MA1_4=@G17MA1_4,G17MA5_9=@G17MA5_9,G17MA10_14=@G17MA10_14,G17MA15_19=@G17MA15_19,G17MA20_24=@G17MA20_24,G17MA25_49=@G17MA25_49,";
            sql1 += "G17MA50=@G17MA50,SUBG17FE=@SUBG17FE,G17FE1=@G17FE1,G17FE1_4=@G17FE1_4,G17FE5_9=@G17FE5_9,G17FE10_14=@G17FE10_14,G17FE15_19=@G17FE15_19,G17FE20_24=@G17FE20_24,G17FE25_49=@G17FE25_49,G17FE50=@G17FE50,TOTALG18=@TOTALG18,SUBG18MA=@SUBG18MA,G18MA1=@G18MA1,G18MA1_4=@G18MA1_4,G18MA5_9=@G18MA5_9,G18MA10_14=@G18MA10_14,G18MA15_19=@G18MA15_19,G18MA20_24=@G18MA20_24,";
            sql1 += "G18MA25_49=@G18MA25_49,G18MA50=@G18MA50,SUBG18FE=@SUBG18FE,G18FE1=@G18FE1,G18FE1_4=@G18FE1_4,G18FE5_9=@G18FE5_9,G18FE10_14=@G18FE10_14,G18FE15_19=@G18FE15_19,G18FE20_24=@G18FE20_24,G18FE25_49=@G18FE25_49,G18FE50=@G18FE50 ";
            sql1 += "WHERE  states = @states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=	@grouptype ";

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

                //*************** tbl_ART1
                cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox248.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox249.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox250.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox251.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox252.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox253.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA15_19", SqlDbType.Int).Value = TextBox254.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA20_24", SqlDbType.Int).Value = TextBox255.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA25_49", SqlDbType.Int).Value = TextBox256.Text.Trim();
                cmd.Parameters.AddWithValue("@G1MA50", SqlDbType.Int).Value = TextBox257.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox258.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox259.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox260.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox261.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox262.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE15_19", SqlDbType.Int).Value = TextBox263.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE20_24", SqlDbType.Int).Value = TextBox264.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE25_49", SqlDbType.Int).Value = TextBox265.Text.Trim();
                cmd.Parameters.AddWithValue("@G1FE50", SqlDbType.Int).Value = TextBox266.Text.Trim();
                cmd.Parameters.AddWithValue("@G1PREGNANT", SqlDbType.Int).Value = TextBox1074.Text.Trim();
                cmd.Parameters.AddWithValue("@G1BREASTFEED", SqlDbType.Int).Value = TextBox1075.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox267.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox268.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox269.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox270.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox271.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox272.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA15_19", SqlDbType.Int).Value = TextBox273.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA20_24", SqlDbType.Int).Value = TextBox274.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA25_49", SqlDbType.Int).Value = TextBox275.Text.Trim();
                cmd.Parameters.AddWithValue("@G2MA50", SqlDbType.Int).Value = TextBox276.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox277.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox278.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox279.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox280.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox281.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE15_19", SqlDbType.Int).Value = TextBox282.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE20_24", SqlDbType.Int).Value = TextBox283.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE25_49", SqlDbType.Int).Value = TextBox284.Text.Trim();
                cmd.Parameters.AddWithValue("@G2FE50", SqlDbType.Int).Value = TextBox285.Text.Trim();
                cmd.Parameters.AddWithValue("@G2PREGNANT", SqlDbType.Int).Value = TextBox1072.Text.Trim();
                cmd.Parameters.AddWithValue("@G2BREASTFEED", SqlDbType.Int).Value = TextBox1073.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox286.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox287.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox288.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox289.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox290.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox291.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA15_19", SqlDbType.Int).Value = TextBox292.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA20_24", SqlDbType.Int).Value = TextBox293.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA25_49", SqlDbType.Int).Value = TextBox294.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MA50", SqlDbType.Int).Value = TextBox295.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox296.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox297.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox298.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox299.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox300.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE15_19", SqlDbType.Int).Value = TextBox301.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE20_24", SqlDbType.Int).Value = TextBox302.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE25_49", SqlDbType.Int).Value = TextBox303.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FE50", SqlDbType.Int).Value = TextBox304.Text.Trim();
                cmd.Parameters.AddWithValue("@G3PREGNANT", SqlDbType.Int).Value = TextBox305.Text.Trim();
                cmd.Parameters.AddWithValue("@G3BREASTFEED", SqlDbType.Int).Value = TextBox306.Text.Trim();
                cmd.Parameters.AddWithValue("@G3FSW", SqlDbType.Int).Value = TextBox307.Text.Trim();
                cmd.Parameters.AddWithValue("@G3MSM_TG", SqlDbType.Int).Value = TextBox308.Text.Trim();
                cmd.Parameters.AddWithValue("@G3PWID", SqlDbType.Int).Value = TextBox309.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox310.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox311.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox312.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox313.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox314.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox315.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA15_19", SqlDbType.Int).Value = TextBox316.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA20_24", SqlDbType.Int).Value = TextBox317.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA25_49", SqlDbType.Int).Value = TextBox318.Text.Trim();
                cmd.Parameters.AddWithValue("@G4MA50", SqlDbType.Int).Value = TextBox319.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox320.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox321.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox322.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox323.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox324.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE15_19", SqlDbType.Int).Value = TextBox325.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE20_24", SqlDbType.Int).Value = TextBox326.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE25_49", SqlDbType.Int).Value = TextBox327.Text.Trim();
                cmd.Parameters.AddWithValue("@G4FE50", SqlDbType.Int).Value = TextBox328.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox329.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox330.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox331.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox332.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox333.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox334.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA15_19", SqlDbType.Int).Value = TextBox335.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA20_24", SqlDbType.Int).Value = TextBox336.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA25_49", SqlDbType.Int).Value = TextBox337.Text.Trim();
                cmd.Parameters.AddWithValue("@G5MA50", SqlDbType.Int).Value = TextBox338.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox339.Text.Trim();
                cmd.Parameters.AddWithValue("@G54FE1", SqlDbType.Int).Value = TextBox340.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox341.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox342.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox343.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE15_19", SqlDbType.Int).Value = TextBox344.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE20_24", SqlDbType.Int).Value = TextBox345.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE25_49", SqlDbType.Int).Value = TextBox346.Text.Trim();
                cmd.Parameters.AddWithValue("@G5FE50", SqlDbType.Int).Value = TextBox347.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox348.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox349.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox350.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox351.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox352.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox353.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA15_19", SqlDbType.Int).Value = TextBox354.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA20_24", SqlDbType.Int).Value = TextBox355.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA25_49", SqlDbType.Int).Value = TextBox356.Text.Trim();
                cmd.Parameters.AddWithValue("@G6MA50", SqlDbType.Int).Value = TextBox357.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox358.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox359.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox360.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox361.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox362.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE15_19", SqlDbType.Int).Value = TextBox363.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE20_24", SqlDbType.Int).Value = TextBox364.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE25_49", SqlDbType.Int).Value = TextBox365.Text.Trim();
                cmd.Parameters.AddWithValue("@G6FE50", SqlDbType.Int).Value = TextBox366.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox367.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox368.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox369.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox370.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox371.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox372.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA15_19", SqlDbType.Int).Value = TextBox373.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA20_24", SqlDbType.Int).Value = TextBox374.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA25_49", SqlDbType.Int).Value = TextBox375.Text.Trim();
                cmd.Parameters.AddWithValue("@G7MA50", SqlDbType.Int).Value = TextBox376.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox377.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox378.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox379.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox380.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox381.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE15_19", SqlDbType.Int).Value = TextBox382.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox383.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox384.Text.Trim();
                cmd.Parameters.AddWithValue("@G7FE50", SqlDbType.Int).Value = TextBox385.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox386.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox387.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox388.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox389.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox390.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox391.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA15_19", SqlDbType.Int).Value = TextBox392.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA20_24", SqlDbType.Int).Value = TextBox393.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA25_49", SqlDbType.Int).Value = TextBox394.Text.Trim();
                cmd.Parameters.AddWithValue("@G8MA50", SqlDbType.Int).Value = TextBox395.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox396.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox397.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox398.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox399.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox400.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE15_19", SqlDbType.Int).Value = TextBox401.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE20_24", SqlDbType.Int).Value = TextBox402.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE25_49", SqlDbType.Int).Value = TextBox403.Text.Trim();
                cmd.Parameters.AddWithValue("@G8FE50", SqlDbType.Int).Value = TextBox404.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox405.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox406.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox407.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox408.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox409.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox410.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = TextBox411.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = TextBox412.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = TextBox413.Text.Trim();
                cmd.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = TextBox414.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox415.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox416.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox417.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox418.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox419.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = TextBox420.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = TextBox421.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = TextBox422.Text.Trim();
                cmd.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = TextBox423.Text.Trim();
                cmd.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox424.Text.Trim();
                cmd.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox425.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox426.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox427.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox428.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox429.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA15_19", SqlDbType.Int).Value = TextBox430.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA20_24", SqlDbType.Int).Value = TextBox431.Text.Trim();
                cmd.Parameters.AddWithValue("@G10MA25_49", SqlDbType.Int).Value = TextBox432.Text.Trim();
                int Rowaffected = cmd.ExecuteNonQuery();

                // ================ ART 2 =======================
                SqlCommand cmd1 = new SqlCommand(sql1, cn);

                cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                cmd1.Parameters.AddWithValue("@G10MA50", SqlDbType.Int).Value = TextBox433.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox434.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox435.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox436.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox437.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox438.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE15_19", SqlDbType.Int).Value = TextBox439.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE20_24", SqlDbType.Int).Value = TextBox440.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE25_49", SqlDbType.Int).Value = TextBox441.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10FE50", SqlDbType.Int).Value = TextBox442.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10PREGNANT", SqlDbType.Int).Value = TextBox443.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10BREASTFEED", SqlDbType.Int).Value = TextBox444.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10ROUTINE", SqlDbType.Int).Value = TextBox445.Text.Trim();
                cmd1.Parameters.AddWithValue("@G10TARGET", SqlDbType.Int).Value = TextBox446.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox447.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox448.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox449.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox450.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox451.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox452.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = TextBox453.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = TextBox454.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = TextBox455.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = TextBox456.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox457.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox458.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox459.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox460.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox461.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = TextBox462.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = TextBox463.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = TextBox464.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = TextBox465.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11PREGNANT", SqlDbType.Int).Value = TextBox466.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11BREASTFEED", SqlDbType.Int).Value = TextBox467.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11ROUTINE", SqlDbType.Int).Value = TextBox468.Text.Trim();
                cmd1.Parameters.AddWithValue("@G11TARGET", SqlDbType.Int).Value = TextBox469.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox470.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG12MA", SqlDbType.Int).Value = TextBox471.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = TextBox472.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = TextBox473.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = TextBox474.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = TextBox475.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = TextBox476.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = TextBox477.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox478.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = TextBox479.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG12FE", SqlDbType.Int).Value = TextBox480.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = TextBox481.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = TextBox482.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = TextBox483.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = TextBox484.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = TextBox485.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = TextBox486.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = TextBox487.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = TextBox488.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12PREGNANT", SqlDbType.Int).Value = TextBox489.Text.Trim();
                cmd1.Parameters.AddWithValue("@G12BREASTFEED", SqlDbType.Int).Value = TextBox490.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG13", SqlDbType.Int).Value = TextBox491.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG13MA", SqlDbType.Int).Value = TextBox492.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA1", SqlDbType.Int).Value = TextBox493.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA1_4", SqlDbType.Int).Value = TextBox494.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA5_9", SqlDbType.Int).Value = TextBox495.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA10_14", SqlDbType.Int).Value = TextBox496.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA15_19", SqlDbType.Int).Value = TextBox497.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA20_24", SqlDbType.Int).Value = TextBox498.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA25_49", SqlDbType.Int).Value = TextBox499.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13MA50", SqlDbType.Int).Value = TextBox500.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG13FE", SqlDbType.Int).Value = TextBox501.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE1", SqlDbType.Int).Value = TextBox502.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE1_4", SqlDbType.Int).Value = TextBox503.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE5_9", SqlDbType.Int).Value = TextBox504.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE10_14", SqlDbType.Int).Value = TextBox505.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE15_19", SqlDbType.Int).Value = TextBox506.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE20_24", SqlDbType.Int).Value = TextBox507.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE25_49", SqlDbType.Int).Value = TextBox508.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13FE50", SqlDbType.Int).Value = TextBox509.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13PREGNANT", SqlDbType.Int).Value = TextBox510.Text.Trim();
                cmd1.Parameters.AddWithValue("@G13BREASTFEED", SqlDbType.Int).Value = TextBox511.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG14", SqlDbType.Int).Value = TextBox512.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG14MA", SqlDbType.Int).Value = TextBox513.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA1", SqlDbType.Int).Value = TextBox514.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA1_4", SqlDbType.Int).Value = TextBox515.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA5_9", SqlDbType.Int).Value = TextBox516.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA10_14", SqlDbType.Int).Value = TextBox517.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA15_19", SqlDbType.Int).Value = TextBox518.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA20_24", SqlDbType.Int).Value = TextBox519.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA25_49", SqlDbType.Int).Value = TextBox520.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14MA50", SqlDbType.Int).Value = TextBox521.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG14FE", SqlDbType.Int).Value = TextBox522.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE1", SqlDbType.Int).Value = TextBox523.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE1_4", SqlDbType.Int).Value = TextBox524.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE5_9", SqlDbType.Int).Value = TextBox525.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE10_14", SqlDbType.Int).Value = TextBox526.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE15_19", SqlDbType.Int).Value = TextBox527.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE20_24", SqlDbType.Int).Value = TextBox528.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE25_49", SqlDbType.Int).Value = TextBox529.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14FE50", SqlDbType.Int).Value = TextBox530.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14UNDETECTABLE", SqlDbType.Int).Value = TextBox531.Text.Trim();
                cmd1.Parameters.AddWithValue("@G14DETECTABLE", SqlDbType.Int).Value = TextBox532.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG15", SqlDbType.Int).Value = TextBox533.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG15MA", SqlDbType.Int).Value = TextBox534.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA1", SqlDbType.Int).Value = TextBox535.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA1_4", SqlDbType.Int).Value = TextBox536.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA5_9", SqlDbType.Int).Value = TextBox537.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA10_14", SqlDbType.Int).Value = TextBox538.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA15_19", SqlDbType.Int).Value = TextBox539.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA20_24", SqlDbType.Int).Value = TextBox540.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA25_49", SqlDbType.Int).Value = TextBox541.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15MA50", SqlDbType.Int).Value = TextBox542.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG15FE", SqlDbType.Int).Value = TextBox543.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE1", SqlDbType.Int).Value = TextBox544.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE1_4", SqlDbType.Int).Value = TextBox545.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE5_9", SqlDbType.Int).Value = TextBox546.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE10_14", SqlDbType.Int).Value = TextBox547.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE15_19", SqlDbType.Int).Value = TextBox548.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE20_24", SqlDbType.Int).Value = TextBox549.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE25_49", SqlDbType.Int).Value = TextBox550.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15FE50", SqlDbType.Int).Value = TextBox551.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15UNDETECTABLE", SqlDbType.Int).Value = TextBox552.Text.Trim();
                cmd1.Parameters.AddWithValue("@G15DETECTABLE", SqlDbType.Int).Value = TextBox553.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG16", SqlDbType.Int).Value = TextBox554.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG16MA", SqlDbType.Int).Value = TextBox555.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA1", SqlDbType.Int).Value = TextBox556.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA1_4", SqlDbType.Int).Value = TextBox557.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA5_9", SqlDbType.Int).Value = TextBox558.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA10_14", SqlDbType.Int).Value = TextBox559.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA15_19", SqlDbType.Int).Value = TextBox560.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA20_24", SqlDbType.Int).Value = TextBox561.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA25_49", SqlDbType.Int).Value = TextBox562.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16MA50", SqlDbType.Int).Value = TextBox563.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG16FE", SqlDbType.Int).Value = TextBox564.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE1", SqlDbType.Int).Value = TextBox565.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE1_4", SqlDbType.Int).Value = TextBox566.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE5_9", SqlDbType.Int).Value = TextBox567.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE10_14", SqlDbType.Int).Value = TextBox568.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE15_19", SqlDbType.Int).Value = TextBox569.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE20_24", SqlDbType.Int).Value = TextBox570.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE25_49", SqlDbType.Int).Value = TextBox571.Text.Trim();
                cmd1.Parameters.AddWithValue("@G16FE50", SqlDbType.Int).Value = TextBox572.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG17", SqlDbType.Int).Value = TextBox573.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG17MA", SqlDbType.Int).Value = TextBox574.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA1", SqlDbType.Int).Value = TextBox575.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA1_4", SqlDbType.Int).Value = TextBox576.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA5_9", SqlDbType.Int).Value = TextBox577.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA10_14", SqlDbType.Int).Value = TextBox578.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA15_19", SqlDbType.Int).Value = TextBox579.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA20_24", SqlDbType.Int).Value = TextBox580.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA25_49", SqlDbType.Int).Value = TextBox581.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17MA50", SqlDbType.Int).Value = TextBox582.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG17FE", SqlDbType.Int).Value = TextBox583.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE1", SqlDbType.Int).Value = TextBox584.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE1_4", SqlDbType.Int).Value = TextBox585.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE5_9", SqlDbType.Int).Value = TextBox586.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE10_14", SqlDbType.Int).Value = TextBox587.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE15_19", SqlDbType.Int).Value = TextBox588.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE20_24", SqlDbType.Int).Value = TextBox589.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE25_49", SqlDbType.Int).Value = TextBox590.Text.Trim();
                cmd1.Parameters.AddWithValue("@G17FE50", SqlDbType.Int).Value = TextBox591.Text.Trim();
                cmd1.Parameters.AddWithValue("@TOTALG18", SqlDbType.Int).Value = TextBox592.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG18MA", SqlDbType.Int).Value = TextBox593.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA1", SqlDbType.Int).Value = TextBox594.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA1_4", SqlDbType.Int).Value = TextBox595.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA5_9", SqlDbType.Int).Value = TextBox596.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA10_14", SqlDbType.Int).Value = TextBox597.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA15_19", SqlDbType.Int).Value = TextBox598.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA20_24", SqlDbType.Int).Value = TextBox599.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA25_49", SqlDbType.Int).Value = TextBox600.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18MA50", SqlDbType.Int).Value = TextBox601.Text.Trim();
                cmd1.Parameters.AddWithValue("@SUBG18FE", SqlDbType.Int).Value = TextBox602.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE1", SqlDbType.Int).Value = TextBox603.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE1_4", SqlDbType.Int).Value = TextBox604.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE5_9", SqlDbType.Int).Value = TextBox605.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE10_14", SqlDbType.Int).Value = TextBox606.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE15_19", SqlDbType.Int).Value = TextBox607.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE20_24", SqlDbType.Int).Value = TextBox608.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE25_49", SqlDbType.Int).Value = TextBox609.Text.Trim();
                cmd1.Parameters.AddWithValue("@G18FE50", SqlDbType.Int).Value = TextBox610.Text.Trim();
                int Rowsaffected1 = cmd1.ExecuteNonQuery();

                if (Rowaffected != -1 && Rowsaffected1 != -1)
                    webMessage.Show(Rowaffected.ToString() + " updated successful" );
                    //Response.Write("<script language=javascript>alert('" + Rowaffected.ToString() + " Successful ');</script>");
                CLS_ART();
                return;
            }
            catch (Exception ex)
            {
                webMessage.Show(ex.Message.ToString());
                //Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
                return;
            }


        }
    } //=========== End of ART Save and Updating Records

    protected void CLS_HTC()
    {
        TextBox611.Text = String.Empty;
        TextBox612.Text = String.Empty;
        TextBox613.Text = String.Empty;
        TextBox614.Text = String.Empty;
        TextBox615.Text = String.Empty;
        TextBox616.Text = String.Empty;
        TextBox617.Text = String.Empty;
        TextBox618.Text = String.Empty;
        TextBox619.Text = String.Empty;
        TextBox620.Text = String.Empty;
        TextBox621.Text = String.Empty;
        TextBox622.Text = String.Empty;
        TextBox623.Text = String.Empty;
        TextBox624.Text = String.Empty;
        TextBox625.Text = String.Empty;
        TextBox626.Text = String.Empty;
        TextBox627.Text = String.Empty;
        TextBox628.Text = String.Empty;
        TextBox629.Text = String.Empty;
        TextBox630.Text = String.Empty;
        TextBox631.Text = String.Empty;
        TextBox632.Text = String.Empty;
        TextBox633.Text = String.Empty;
        TextBox634.Text = String.Empty;
        TextBox635.Text = String.Empty;
        TextBox636.Text = String.Empty;
        TextBox637.Text = String.Empty;
        TextBox638.Text = String.Empty;
        TextBox639.Text = String.Empty;
        TextBox640.Text = String.Empty;
        TextBox641.Text = String.Empty;
        TextBox642.Text = String.Empty;
        TextBox643.Text = String.Empty;
        TextBox644.Text = String.Empty;
        TextBox645.Text = String.Empty;
        TextBox646.Text = String.Empty;
        TextBox647.Text = String.Empty;
        TextBox648.Text = String.Empty;
        TextBox649.Text = String.Empty;
        TextBox650.Text = String.Empty;
        TextBox651.Text = String.Empty;
        TextBox652.Text = String.Empty;
        TextBox653.Text = String.Empty;
        TextBox654.Text = String.Empty;
        TextBox655.Text = String.Empty;
        TextBox656.Text = String.Empty;
        TextBox657.Text = String.Empty;
        TextBox658.Text = String.Empty;
        TextBox659.Text = String.Empty;
        TextBox660.Text = String.Empty;
        TextBox661.Text = String.Empty;
        TextBox662.Text = String.Empty;
        TextBox663.Text = String.Empty;
        TextBox664.Text = String.Empty;
        TextBox665.Text = String.Empty;
        TextBox666.Text = String.Empty;
        TextBox667.Text = String.Empty;
        TextBox668.Text = String.Empty;
        TextBox669.Text = String.Empty;
        TextBox670.Text = String.Empty;
        TextBox671.Text = String.Empty;
        TextBox672.Text = String.Empty;
        TextBox673.Text = String.Empty;
        TextBox674.Text = String.Empty;
        TextBox675.Text = String.Empty;
        TextBox676.Text = String.Empty;
        TextBox677.Text = String.Empty;
        TextBox678.Text = String.Empty;
        TextBox679.Text = String.Empty;
        TextBox680.Text = String.Empty;
        TextBox681.Text = String.Empty;
        TextBox682.Text = String.Empty;
        TextBox683.Text = String.Empty;
        TextBox684.Text = String.Empty;
        TextBox685.Text = String.Empty;
        TextBox686.Text = String.Empty;
        TextBox687.Text = String.Empty;
        TextBox688.Text = String.Empty;
        TextBox689.Text = String.Empty;
        TextBox690.Text = String.Empty;
        TextBox691.Text = String.Empty;
        TextBox692.Text = String.Empty;
        TextBox693.Text = String.Empty;
        TextBox694.Text = String.Empty;
        TextBox695.Text = String.Empty;
        TextBox696.Text = String.Empty;
        TextBox697.Text = String.Empty;
        TextBox698.Text = String.Empty;
        TextBox699.Text = String.Empty;
        TextBox700.Text = String.Empty;
        TextBox701.Text = String.Empty;
        TextBox702.Text = String.Empty;
        TextBox703.Text = String.Empty;
        TextBox704.Text = String.Empty;
        TextBox705.Text = String.Empty;
        TextBox706.Text = String.Empty;
        TextBox707.Text = String.Empty;
        TextBox708.Text = String.Empty;
        TextBox709.Text = String.Empty;
        TextBox710.Text = String.Empty;
        TextBox711.Text = String.Empty;
        TextBox712.Text = String.Empty;
        TextBox713.Text = String.Empty;
        TextBox714.Text = String.Empty;
        TextBox715.Text = String.Empty;
        TextBox716.Text = String.Empty;
        TextBox717.Text = String.Empty;
        TextBox718.Text = String.Empty;
        TextBox719.Text = String.Empty;
        TextBox720.Text = String.Empty;
        TextBox721.Text = String.Empty;
        TextBox722.Text = String.Empty;
        TextBox723.Text = String.Empty;
        TextBox724.Text = String.Empty;
        TextBox725.Text = String.Empty;
        TextBox726.Text = String.Empty;
        TextBox727.Text = String.Empty;
        TextBox728.Text = String.Empty;
        TextBox729.Text = String.Empty;
        TextBox730.Text = String.Empty;
        TextBox731.Text = String.Empty;
        TextBox732.Text = String.Empty;
        TextBox733.Text = String.Empty;
        TextBox734.Text = String.Empty;
        TextBox735.Text = String.Empty;
        TextBox736.Text = String.Empty;
        TextBox737.Text = String.Empty;
        TextBox738.Text = String.Empty;
        TextBox739.Text = String.Empty;
        TextBox740.Text = String.Empty;
        TextBox741.Text = String.Empty;
        TextBox742.Text = String.Empty;
        TextBox743.Text = String.Empty;
        TextBox782.Text = String.Empty;
        TextBox783.Text = String.Empty;
        TextBox784.Text = String.Empty;
        TextBox785.Text = String.Empty;
        TextBox786.Text = String.Empty;
        TextBox787.Text = String.Empty;
        TextBox788.Text = String.Empty;
        TextBox789.Text = String.Empty;


        TextBox790.Text = String.Empty;
        TextBox791.Text = String.Empty;
        TextBox792.Text = String.Empty;
        TextBox793.Text = String.Empty;
        TextBox794.Text = String.Empty;
        TextBox795.Text = String.Empty;
        TextBox796.Text = String.Empty;
        TextBox797.Text = String.Empty;
        TextBox798.Text = String.Empty;
        TextBox799.Text = String.Empty;
        TextBox800.Text = String.Empty;
        TextBox801.Text = String.Empty;
        TextBox802.Text = String.Empty;
        TextBox803.Text = String.Empty;
        TextBox804.Text = String.Empty;
        TextBox805.Text = String.Empty;
        TextBox806.Text = String.Empty;
        TextBox807.Text = String.Empty;
        TextBox808.Text = String.Empty;
        TextBox809.Text = String.Empty;
        TextBox810.Text = String.Empty;
        TextBox811.Text = String.Empty;
        TextBox812.Text = String.Empty;
        TextBox813.Text = String.Empty;
        TextBox814.Text = String.Empty;
        TextBox815.Text = String.Empty;
        TextBox816.Text = String.Empty;
        TextBox817.Text = String.Empty;
        TextBox818.Text = String.Empty;
        TextBox819.Text = String.Empty;
        TextBox820.Text = String.Empty;
        TextBox821.Text = String.Empty;
        TextBox822.Text = String.Empty;
        TextBox823.Text = String.Empty;
        TextBox824.Text = String.Empty;
        TextBox825.Text = String.Empty;
        TextBox826.Text = String.Empty;
        TextBox827.Text = String.Empty;
        TextBox828.Text = String.Empty;
        TextBox829.Text = String.Empty;
        TextBox830.Text = String.Empty;
        TextBox831.Text = String.Empty;
        TextBox832.Text = String.Empty;
        TextBox833.Text = String.Empty;
        TextBox834.Text = String.Empty;
        TextBox835.Text = String.Empty;
        TextBox836.Text = String.Empty;
        TextBox837.Text = String.Empty;
        TextBox838.Text = String.Empty;
        TextBox839.Text = String.Empty;
        TextBox840.Text = String.Empty;
        TextBox841.Text = String.Empty;
        TextBox842.Text = String.Empty;
        TextBox843.Text = String.Empty;
        TextBox844.Text = String.Empty;
        TextBox845.Text = String.Empty;
        TextBox846.Text = String.Empty;
        TextBox847.Text = String.Empty;
        TextBox848.Text = String.Empty;
        TextBox849.Text = String.Empty;
        TextBox850.Text = String.Empty;
        TextBox851.Text = String.Empty;
        TextBox852.Text = String.Empty;
        TextBox853.Text = String.Empty;
        TextBox854.Text = String.Empty;
        TextBox855.Text = String.Empty;
        TextBox856.Text = String.Empty;
        TextBox857.Text = String.Empty;
        TextBox858.Text = String.Empty;
        TextBox859.Text = String.Empty;
        TextBox860.Text = String.Empty;
        TextBox861.Text = String.Empty;
        TextBox862.Text = String.Empty;
        TextBox863.Text = String.Empty;
        TextBox864.Text = String.Empty;
        TextBox865.Text = String.Empty;
        TextBox866.Text = String.Empty;
        TextBox867.Text = String.Empty;
        TextBox868.Text = String.Empty;
        TextBox869.Text = String.Empty;
        TextBox870.Text = String.Empty;
        TextBox871.Text = String.Empty;
        TextBox872.Text = String.Empty;
        TextBox873.Text = String.Empty;
        TextBox874.Text = String.Empty;
        TextBox875.Text = String.Empty;
        TextBox876.Text = String.Empty;
        TextBox877.Text = String.Empty;
        TextBox878.Text = String.Empty;
        TextBox879.Text = String.Empty;
        TextBox880.Text = String.Empty;
        TextBox881.Text = String.Empty;
        TextBox882.Text = String.Empty;
        TextBox883.Text = String.Empty;
        TextBox884.Text = String.Empty;
        TextBox885.Text = String.Empty;
        TextBox886.Text = String.Empty;
        TextBox887.Text = String.Empty;
        TextBox888.Text = String.Empty;
        TextBox889.Text = String.Empty;
        TextBox890.Text = String.Empty;
        TextBox891.Text = String.Empty;
        TextBox892.Text = String.Empty;
        TextBox893.Text = String.Empty;
        TextBox894.Text = String.Empty;
        TextBox895.Text = String.Empty;
        TextBox896.Text = String.Empty;
        TextBox897.Text = String.Empty;
        TextBox898.Text = String.Empty;
        TextBox899.Text = String.Empty;
        TextBox900.Text = String.Empty;
        TextBox901.Text = String.Empty;
        TextBox902.Text = String.Empty;
        TextBox903.Text = String.Empty;
        TextBox904.Text = String.Empty;
        TextBox905.Text = String.Empty;
        TextBox906.Text = String.Empty;
        TextBox907.Text = String.Empty;
        TextBox908.Text = String.Empty;
        TextBox909.Text = String.Empty;
        TextBox910.Text = String.Empty;
        TextBox911.Text = String.Empty;
        TextBox912.Text = String.Empty;
        TextBox913.Text = String.Empty;
        TextBox914.Text = String.Empty;
        TextBox915.Text = String.Empty;
        TextBox916.Text = String.Empty;
        TextBox917.Text = String.Empty;
        TextBox918.Text = String.Empty;
        TextBox919.Text = String.Empty;
        TextBox920.Text = String.Empty;
        TextBox921.Text = String.Empty;
        TextBox922.Text = String.Empty;
        TextBox923.Text = String.Empty;
        TextBox924.Text = String.Empty;
        TextBox925.Text = String.Empty;
        TextBox926.Text = String.Empty;
        TextBox927.Text = String.Empty;
        TextBox928.Text = String.Empty;
        TextBox929.Text = String.Empty;
        TextBox930.Text = String.Empty;


        TextBox931.Text = String.Empty;
        TextBox932.Text = String.Empty;
        TextBox933.Text = String.Empty;
        TextBox934.Text = String.Empty;
        TextBox935.Text = String.Empty;
        TextBox936.Text = String.Empty;
        TextBox937.Text = String.Empty;
        TextBox938.Text = String.Empty;
        TextBox939.Text = String.Empty;
        TextBox940.Text = String.Empty;
        TextBox941.Text = String.Empty;
        TextBox942.Text = String.Empty;
        TextBox943.Text = String.Empty;
        TextBox944.Text = String.Empty;
        TextBox945.Text = String.Empty;
        TextBox946.Text = String.Empty;
        TextBox947.Text = String.Empty;
        TextBox948.Text = String.Empty;
        TextBox949.Text = String.Empty;
        TextBox950.Text = String.Empty;
        TextBox951.Text = String.Empty;
        TextBox952.Text = String.Empty;
        TextBox953.Text = String.Empty;
        TextBox954.Text = String.Empty;
        TextBox955.Text = String.Empty;
        TextBox956.Text = String.Empty;
        TextBox957.Text = String.Empty;
        TextBox958.Text = String.Empty;
        TextBox959.Text = String.Empty;
        TextBox960.Text = String.Empty;
        TextBox961.Text = String.Empty;
        TextBox962.Text = String.Empty;
        TextBox963.Text = String.Empty;
        TextBox964.Text = String.Empty;
        TextBox965.Text = String.Empty;
        TextBox966.Text = String.Empty;
        TextBox967.Text = String.Empty;
        TextBox968.Text = String.Empty;
        TextBox969.Text = String.Empty;
        TextBox970.Text = String.Empty;
        TextBox971.Text = String.Empty;
        TextBox972.Text = String.Empty;
        TextBox973.Text = String.Empty;
        TextBox974.Text = String.Empty;
        TextBox975.Text = String.Empty;
        TextBox976.Text = String.Empty;
        TextBox977.Text = String.Empty;
        TextBox978.Text = String.Empty;
        TextBox979.Text = String.Empty;
        TextBox980.Text = String.Empty;
        TextBox981.Text = String.Empty;
        TextBox982.Text = String.Empty;
        TextBox983.Text = String.Empty;
        TextBox984.Text = String.Empty;
        TextBox985.Text = String.Empty;
        TextBox986.Text = String.Empty;
        TextBox987.Text = String.Empty;
        TextBox988.Text = String.Empty;
        TextBox989.Text = String.Empty;
        TextBox990.Text = String.Empty;
        TextBox991.Text = String.Empty;
        TextBox992.Text = String.Empty;
        TextBox993.Text = String.Empty;
        TextBox994.Text = String.Empty;
        TextBox995.Text = String.Empty;
        TextBox996.Text = String.Empty;
        TextBox997.Text = String.Empty;
        TextBox998.Text = String.Empty;
        TextBox999.Text = String.Empty;
        TextBox1000.Text = String.Empty;
        TextBox1001.Text = String.Empty;
        TextBox1002.Text = String.Empty;
        TextBox1003.Text = String.Empty;
        TextBox1004.Text = String.Empty;
        TextBox1005.Text = String.Empty;
        TextBox1006.Text = String.Empty;
        TextBox1007.Text = String.Empty;
        TextBox1008.Text = String.Empty;
        TextBox1009.Text = String.Empty;
        TextBox1010.Text = String.Empty;
        TextBox1011.Text = String.Empty;
        TextBox1012.Text = String.Empty;
        TextBox1013.Text = String.Empty;
        TextBox1014.Text = String.Empty;
        TextBox1015.Text = String.Empty;
        TextBox1016.Text = String.Empty;
        TextBox1017.Text = String.Empty;
        TextBox1018.Text = String.Empty;
        TextBox1019.Text = String.Empty;
        TextBox1020.Text = String.Empty;
        TextBox1021.Text = String.Empty;
        TextBox1022.Text = String.Empty;
        TextBox1023.Text = String.Empty;
        TextBox1025.Text = String.Empty;
        TextBox1026.Text = String.Empty;
        TextBox1027.Text = String.Empty;
        TextBox1028.Text = String.Empty;
        TextBox1029.Text = String.Empty;
        TextBox1030.Text = String.Empty;
        TextBox1031.Text = String.Empty;
        TextBox1032.Text = String.Empty;
        TextBox1033.Text = String.Empty;
        TextBox1034.Text = String.Empty;
        TextBox1035.Text = String.Empty;
        TextBox1036.Text = String.Empty;
        TextBox1037.Text = String.Empty;
        TextBox1038.Text = String.Empty;
        TextBox1039.Text = String.Empty;
        TextBox1040.Text = String.Empty;
        TextBox1041.Text = String.Empty;
        TextBox1042.Text = String.Empty;
        TextBox1043.Text = String.Empty;
        TextBox1044.Text = String.Empty;
        TextBox1045.Text = String.Empty;
        TextBox1046.Text = String.Empty;
        TextBox1047.Text = String.Empty;
        TextBox1048.Text = String.Empty;
        TextBox1049.Text = String.Empty;
        TextBox1050.Text = String.Empty;
        TextBox1051.Text = String.Empty;
        TextBox1052.Text = String.Empty;
        TextBox1053.Text = String.Empty;
        TextBox1054.Text = String.Empty;
        TextBox1055.Text = String.Empty;
        TextBox1056.Text = String.Empty;
        TextBox1057.Text = String.Empty;
        TextBox1058.Text = String.Empty;
        TextBox1059.Text = String.Empty;
        TextBox1060.Text = String.Empty;
        TextBox1061.Text = String.Empty;
        TextBox1062.Text = String.Empty;
        TextBox1063.Text = String.Empty;
        TextBox1064.Text = String.Empty;
        TextBox1065.Text = String.Empty;
        TextBox1066.Text = String.Empty;
        TextBox1067.Text = String.Empty;
        TextBox1068.Text = String.Empty;
        TextBox1069.Text = String.Empty;
        TextBox1070.Text = String.Empty;
        TextBox1071.Text = String.Empty; 

        //================== HTC 1=================

    }//====== CLS for HTC

    protected void SAVE_HTC()
    {

        if (!String.IsNullOrEmpty(Session["editme"] as string))
        {
            if (Session["editme"].ToString() == "true")
            {
        //============ UPDATE EXISTING RECORD 
                try
                {
                    string sql = "UPDATE tbl_HTC1  SET states=@states, lga=@lga, facname=@facname, months=@months, years=@years, grouptype=@grouptype, TOTALG1=@TOTALG1,";
                    sql += "SUBG1MA=@SUBG1MA,G1MA1=@G1MA1,G1MA1_4=@G1MA1_4,G1MA5_9=@G1MA5_9,G1MA10_14=@G1MA10_14,G1MA15_19=@G1MA15_19,";
                    sql += " G1MA20_24=@G1MA20_24,G1MA25_49=@G1MA25_49,G1MA50=@G1MA50,SUBG1FE=@SUBG1FE,G1FE1=@G1FE1, G1FE1_4=@G1FE1_4,G1FE5_9=@G1FE5_9,G1FE10_14=@G1FE10_14, G1FE15_19=@G1FE15_19,";
                    sql += " G1FE20_24=@G1FE20_24,G1FE25_49=@G1FE25_49,G1FE50=@G1FE50,TOTALG2=@TOTALG2,SUBG2M=@SUBG2M,G2MA1=@G2MA1,G2MA1_4=@G2MA1_4,G2MA5_9=@G2MA5_9,G2MA10_14=@G2MA10_14,";
                    sql += " G2MA15_19=@G2MA15_19,G2MA20_24=@G2MA20_24,G2MA25_49=@G2MA25_49,G2MA50=@G2MA50, SUBG2F=@SUBG2F,G2FE1=@G2FE1,G2FE1_4=@G2FE1_4,G2FE5_9=@G2FE5_9, G2FE10_14=@G2FE10_14,";
                    sql += " G2FE15_19=@G2FE15_19, G2FE20_24=@G2FE20_24,G2FE25_49=@G2FE25_49,G2FE50=@G2FE50,TOTALG3=@TOTALG3, SUBG3M=@SUBG3M,G3MA1=@G3MA1,G3MA1_4=@G3MA1_4,G3MA5_9=@G3MA5_9,";
                    sql += " G3MA10_14=@G3MA10_14,G3MA15_19=@G3MA15_19,G3MA20_24=@G3MA20_24,G3MA25_49=@G3MA25_49, G3MA50=@G3MA50,SUBG3F=@SUBG3F,G3FE1=@G3FE1,G3FE1_4=@G3FE1_4,G3FE5_9=@G3FE5_9,";
                    sql += " G3FE10_14=@G3FE10_14, G3FE15_19=@G3FE15_19,G3FE20_24=@G3FE20_24,G3FE25_49=@G3FE25_49,G3FE50=@G3FE50,TOTALG4=@TOTALG4,SUBG4P=@SUBG4P,G4P1=@G4P1,G4P1_4=@G4P1_4,";
                    sql += " G4P5_9=@G4P5_9,G4P10_14=@G4P10_14,G4P15_19=@G4P15_19,G4P20_24=@G4P20_24,G4P25_49=@G4P25_49,G4P50=@G4P50,SUB4N=@SUB4N,G4N1=@G4N1, G4N1_4=@G4N1_4,G4N5_9=@G4N5_9,";
                    sql += " G4N10_14=@G4N10_14,G4N15_19=@G4N15_19, G4N20_24=@G4N20_24, G4N25_49=@G4N25_49, G4N50=@G4N50, TOTALG5=@TOTALG5, SUBG5M=@SUBG5M, G5MA1=@G5MA1, G5M1_4=@G5M1_4,";
                    sql += " G5MA5_9=@G5MA5_9,G5MA10_14=@G5MA10_14, G5MA15_19=@G5MA15_19, G5MA20_24=@G5MA20_24, G5MA25_49=@G5MA25_49,G5MA50=@G5MA50, SUBG5F=@SUBG5F, G5FE1=@G5FE1,G5FE1_4=@G5FE1_4,";
                    sql += " G5FE5_9=@G5FE5_9,G5FE10_14=@G5FE10_14, G5FE15_19=@G5FE15_19, G5FE20_24=@G5FE20_24, G5FE25_49=@G5FE25_49,G5FE50=@G5FE50, TOTALG6=@TOTALG6,SUBG6M=@SUBG6M, G6MA1=@G6MA1,";
                    sql += " G6M1_4=@G6M1_4,G6MA5_9=@G6MA5_9, G6MA10_14=@G6MA10_14, G6MA15_19=@G6MA15_19,G6MA20_24=@G6MA20_24,G6MA25_49=@G6MA25_49,G6MA50=@G6MA50,SUBG6F=@SUBG6F, G6FE1=@G6FE1,G6FE1_4=@G6FE1_4,";
                    sql += " G6FE5_9=@G6FE5_9, G6FE10_14=@G6FE10_14,G6FE15_19=@G6FE15_19,G6FE20_24=@G6FE20_24, G6FE25_49=@G6FE25_49,	G6FE50=@G6FE50,TOTALG7=@TOTALG7, SUBG7M=@SUBG7M,G7MA1=@G7MA1,G7M1_4=@G7M1_4,";
                    sql += " G7MA5_9=@G7MA5_9, G7MA10_14=@G7MA10_14,G7MA15_19=@G7MA15_19, G7MA20_24=@G7MA20_24,	G7MA25_49=@G7MA25_49,G7MA50=@G7MA50,SUBG7F=@SUBG7F,G7FE1=@G7FE1, G7FE1_4=@G7FE1_4, G7FE5_9=@G7FE5_9,";
                    sql += " G7FE10_14=@G7FE10_14,G7FE15_19=@G7FE15_19,	 G7FE20_24=@G7FE20_24, G7FE25_49=@G7FE25_49,G7FE50=@G7FE50, TOTALG8=@TOTALG8, SUBG8M=@SUBG8M, G8MA10_14=@G8MA10_14, G8M15_19=@G8M15_19, G8MA20_24=@G8MA20_24,";
                    sql += " G8MA25_49=@G8MA25_49,G8MA50=@G8MA50, SUBG8P=@SUBG8P WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND  grouptype=@grouptype";

                    string sql1 = "UPDATE tbl_HTC2  SET states=@states,lga=@lga,facname=@facname,months=@months, years=@years ,grouptype=@grouptype,G8P10_14=@G8P10_14,";
                    sql1 += "G8P15_19=@G8P15_19, G8P20_24=@G8P20_24, G8P25_49=@G8P25_49,G8P50=@G8P50,TOTALG9=@TOTALG9, SUBG9M=@SUBG9M, G9MA1=@G9MA1, G9MA1_4=@G9MA1_4,	G9MA5_9=@G9MA5_9,";
                    sql1 += "G9MA10_14=@G9MA10_14, G9MA15_19=@G9MA15_19,	G9MA20_24=@G9MA20_24, G9MA25_49=@G9MA25_49, G9MA50=@G9MA50, SUBG9F=@SUBG9F, G9FE1=@G9FE1, G9FE1_4=@G9FE1_4, G9FE5_9=@G9FE5_9,";
                    sql1 += "G9FE10_14=@G9FE10_14,	G9FE15_19=@G9FE15_19, G9FE20_24=@G9FE20_24, G9FE25_49=@G9FE25_49, G9FE50=@G9FE50, TOTALG10=@TOTALG10, SUBG10P=@SUBG10P, G10P1=@G10P1, G10P1_4=@G10P1_4,	";
                    sql1 += "G10P5_9=@G10P5_9, G10P10_14=@G10P10_14, G10P15_19=@G10P15_19, G10P20_24=@G10P20_24, G10P25_49=@G10P25_49, G10P50=@G10P50, SUBG10N=@SUBG10N, G10N1=@G10N1, G10N1_4=@G10N1_4, G10N5_9=@G10N5_9,";
                    sql1 += "G10N10_14=@G10N10_14, G10N15_19=@G10N15_19, G10N20_24=@G10N20_24, G10N25_49=@G10N25_49, G10N50=@G10N50,	TOTALG11=@TOTALG11, SUBG11M=@SUBG11M, G11MA1=@G11MA1, G11MA1_4=@G11MA1_4, G11MA5_9=@G11MA5_9,";
                    sql1 += "G11MA10_14=@G11MA10_14, G11MA15_19=@G11MA15_19,	G11MA20_24=@G11MA20_24, G11MA25_49=@G11MA25_49, G11MA50=@G11MA50, SUBG11F=@SUBG11F, G11FE1=@G11FE1, G11FE1_4=@G11FE1_4, G11FE5_9=@G11FE5_9, G11FE10_14=@G11FE10_14,";
                    sql1 += "G11FE15_19=@G11FE15_19, G11FE20_24=@G11FE20_24, G11FE25_49=@G11FE25_49, G11FE50=@G11FE50, TOTALG12=@TOTALG12, SUBG12M=@SUBG12M,	G12MA1=@G12MA1, G12MA1_4=@G12MA1_4, G12MA5_9=@G12MA5_9, G12MA10_14=@G12MA10_14,";
                    sql1 += "G12MA15_19=@G12MA15_19, G12MA20_24=@G12MA20_24, G12MA25_49=@G12MA25_49,G12MA50=@G12MA50, SUBG12F=@SUBG12F,  G12FE1=@G12FE1, G12FE1_4=@G12FE1_4, G12FE5_9=@G12FE5_9, G12FE10_14=@G12FE10_14, G12FE15_19=@G12FE15_19,";
                    sql1 += "G12FE20_24=@G12FE20_24,	G12FE25_49=@G12FE25_49, G12FE50=@G12FE50, TOTALG13=@TOTALG13, SUBG13M=@SUBG13M, G13MA1=@G13MA1, G13MA1_4=@G13MA1_4, G13MA5_9=@G13MA5_9,	G13MA10_14=@G13MA10_14, G13MA15_19=@G13MA15_19, G13MA20_24=@G13MA20_24,";
                    sql1 += "G13MA25_49=@G13MA25_49, G13MA50=@G13MA50, SUBG13F=@SUBG13F, G13FE1=@G13FE1,	G13FE1_4=@G13FE1_4, G13FE5_9=@G13FE5_9, G13FE10_14=@G13FE10_14, G13FE15_19=@G13FE15_19, G13FE20_24=@G13FE20_24, G13FE25_49=@G13FE25_49, G13FE50=@G13FE50,";
                    sql1 += "TOTALG14=@TOTALG14, SUBG14M=@SUBG14M, G14MA1=@G14MA1, G14MA1_4=@G14MA1_4, G14MA5_9=@G14MA5_9, G14MA10_14=@G14MA10_14, G14MA15_19=@G14MA15_19,	G14MA20_24=@G14MA20_24, G14MA25_49=@G14MA25_49, G14MA50=@G14MA50, SUBG14F=@SUBG14F, G14FE1=@G14FE1,";
                    sql1 += "G14FE1_4=@G14FE1_4, G14FE5_9=@G14FE5_9,G14FE10_14=@G14FE10_14, G14FE15_19=@G14FE15_19, G14FE20_24=@G14FE20_24,  G14FE25_49=@G14FE25_49, G14FE50=@G14FE50, TOTALG15=@TOTALG15, SUBG15M=@SUBG15M, G15MA15_19=@G15MA15_19, G15MA20_24=@G15MA20_24,";
                    sql1 += "G15MS25_49=@G15MS25_49, G15MA50=@G15MA50, SUBG15F=@SUBG15F, G15FE15_19=@G15FE15_19, G15FE20_24=@G15FE20_24, G15FE25_49=@G15FE25_49, G15FE50=@G15FE50, TOTALG16=@TOTALG16, SUBG16M=@SUBG16M, G16MA15_19=@G16MA15_19, G16MA20_24=@G16MA20_24,";
                    sql1 += "G16MS25_49=@G16MS25_49,G16MA50=@G16MA50, SUBG16F=@SUBG16F, G16FE15_19=@G16FE15_19, G16FE20_24=@G16FE20_24, G16FE25_49=@G16FE25_49, G16FE50=@G16FE50 WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";

                   
              string sql3 = " UPDATE tbl_HTC3 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype, TOTALG17=@TOTALG17,SUBG17M=@SUBG17M,	G17MA1=@G17MA1,	G17MA1_4=@G17MA1_4,	G17MA5_9=@G17MA5_9,	G17MA10_14=@G17MA10_14, G17MA15_19=@G17MA15_19,";
                    sql3 += "G17MA20_24=@G17MA20_24,	G17MA25_49=@G17MA25_49,	G17MA50=@G17MA50,	SUBG17F=@SUBG17F,	G17FE1=@G17FE1,	G17FE1_4=@G17FE1_4,	G17FE5_9=@G17FE5_9,	G17FE10_14=@G17FE10_14,	G17FE15_19=@G17FE15_19,	G17FE20_24=@G17FE20_24,G17FE25_49=@G17FE25_49,";
                    sql3 += "G17FE50=@G17FE50,TOTALG18=@TOTALG18,	SUBG18M=@SUBG18M,	G18MA1=@G18MA1,	G18MA1_4=@G18MA1_4,	G18MA5_9=@G18MA5_9,	G18MA10_14=@G18MA10_14,	G18MA15_19=@G18MA15_19,	G18MA20_24=@G18MA20_24,	G18MA25_49=@G18MA25_49,	G18MA50=@G18MA50,";
                    sql3 += "SUBG18F=@SUBG18F,	G18FE1=@G18FE1,	G18FE1_4=@G18FE1_4,	G18FE5_9=@G18FE5_9,	G18FE10_14=@G18FE10_14,	G18FE15_19=@G18FE15_19,	G18FE20_24=@G18FE20_24,	G18FE25_49=@G18FE25_49,	G18FE50=@G18FE50,	TOTALG19=@TOTALG19,	SUBG19M=@SUBG19M,";
                    sql3 += "G19MA1=@G19MA1,	G19MA1_4=@G19MA1_4,	G98MA5_9=@G98MA5_9,	G19MA10_14=@G19MA10_14,	G19MA15_19=@G19MA15_19,	G19MA20_24=@G19MA20_24,	G19MA25_49=@G19MA25_49,	G19MA50=@G19MA50,	SUBG19F=@SUBG19F,	G19FE1=@G19FE1,	G19FE1_4=@G19FE1_4,";
                    sql3 += "G19FE5_9=@G19FE5_9,	G19FE10_14=@G19FE10_14,	G19FE15_19=@G19FE15_19,	G19FE20_24=@G19FE20_24,	G19FE25_49=@G19FE25_49,	G19FE50=@G19FE50,	TOTALG20=@TOTALG20,	SUBG20M=@SUBG20M,	G20MA1=@G20MA1,	G20MA1_4=@G20MA1_4,	G20MA5_9=@G20MA5_9,";
                    sql3 += "G20MA10_14=@G20MA10_14,	G20MA15_19=@G20MA15_19,	G20MA20_24=@G20MA20_24,	G20MA25_49=@G20MA25_49,	G20MA50=@G20MA50,	SUBG20F=@SUBG20F,	G20FE1=@G20FE1,	G20FE1_4=@G20FE1_4,	G20FE5_9=@G20FE5_9,	G20FE10_14=@G20FE10_14,G20FE15_19=@G20FE15_19,";
                    sql3 += "G20FE20_24=@G20FE20_24,	G20FE25_49=@G20FE25_49,	G20FE50=@G20FE50,	TOTALG21=@TOTALG21,	SUBG21M=@SUBG21M,	G21MA1=@G21MA1,	G21MA1_4=@G21MA1_4,	G21MA5_9=@G21MA5_9,	G21MA10_14=@G21MA10_14,	G21MA15_19=@G21MA15_19,	G21MA20_24=@G21MA20_24,";
                    sql3 += "G21MA25_49=@G21MA25_49,	G21MA50=@G21MA50,	SUBG21F=@SUBG21F,	G21FE1=@G21FE1,	G21FE1_4=@G21FE1_4,	G21FE5_9=@G21FE5_9,	G21FE10_14=@G21FE10_14,	G21FE15_19=@G21FE15_19,	G21FE20_24=@G21FE20_24,	G21FE25_49=@G21FE25_49,G21FE50=@G21FE50,";
                    sql3 += "TOTALG22=@TOTALG22,	SUBG22M=@SUBG22M,	G22MA1=@G22MA1,	G22MA1_4=@G22MA1_4,	G22MA5_9=@G22MA5_9,	G22MA10_14=@G22MA10_14,	G22MA15_19=@G22MA15_19,	G22MA20_24=@G22MA20_24,	G22MA25_49=@G22MA25_49,	G22MA50=@G22MA50,	SUBG22F=@SUBG22F,";
                    sql3 += "G22FE1=@G22FE1,	G22FE1_4=@G22FE1_4,	G22FE5_9=@G22FE5_9,	G22FE10_14=@G22FE10_14,	G22FE15_19=@G22FE15_19,	G22FE20_24=@G22FE20_24,	G22FE25_49=@G22FE25_49,	G22FE50=@G22FE50,	G23_1=@G23_1,	G23_2=@G23_2,	TOTALG24=@TOTALG24,	SUBG24M=@SUBG24M,";
                    sql3 += "G24MA15_19=@G24MA15_19,	G24MA20_24=@G24MA20_24,	G24MA25_49=@G24MA25_49,	G24MA50=@G24MA50,	SUBG24F=@SUBG24F,	G24FE15_19=@G24FE15_19,	G24FE20_24=@G24FE20_24,	G24FE25_49=@G24FE25_49,	G24FE50=@G24FE50,	TOTALG25=@TOTALG25,";
                    sql3 += "SUBG25M=@SUBG25M,	G25MA15_19=@G25MA15_19,	G25MA20_24=@G25MA20_24,	G25MA25_49=@G25MA25_49,	G25MA50=@G25MA50,	SUBG25F=@SUBG25F,	G25FE15_19=@G25FE15_19,	G25FE20_24=@G25FE20_24,	G25FE25_49=@G25FE25_49,	G25FE50=@G25FE50,";
                    sql3 += "TOTALG26=@TOTALG26,	G26MA1=@G26MA1,	G26FE1=@G26FE1 WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";

                    //======================= HTC1 ==================================
                   SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                   cn.Open();
                   SqlCommand cmd = new SqlCommand(sql, cn);
                   cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                   cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                   cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                   cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                   cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                   cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                   cmd.Parameters.AddWithValue("@TOTALG1", SqlDbType.Int).Value = TextBox611.Text.Trim();
                   cmd.Parameters.AddWithValue("@SUBG1MA", SqlDbType.Int).Value = TextBox612.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox613.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox614.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox615.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox616.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA15_19", SqlDbType.Int).Value = TextBox617.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA20_24", SqlDbType.Int).Value = TextBox618.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA25_49", SqlDbType.Int).Value = TextBox619.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1MA50", SqlDbType.Int).Value = TextBox620.Text.Trim();
                   cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox621.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox622.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox623.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox624.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox625.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE15_19", SqlDbType.Int).Value = TextBox626.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE20_24", SqlDbType.Int).Value = TextBox627.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE25_49", SqlDbType.Int).Value = TextBox628.Text.Trim();
                   cmd.Parameters.AddWithValue("@G1FE50", SqlDbType.Int).Value = TextBox629.Text.Trim();
                   cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox630.Text.Trim();
                   cmd.Parameters.AddWithValue("@SUBG2M", SqlDbType.Int).Value = TextBox631.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox632.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox633.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox634.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox635.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA15_19", SqlDbType.Int).Value = TextBox636.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA20_24", SqlDbType.Int).Value = TextBox637.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA25_49", SqlDbType.Int).Value = TextBox638.Text.Trim();
                   cmd.Parameters.AddWithValue("@G2MA50", SqlDbType.Int).Value = TextBox639.Text;
                   cmd.Parameters.AddWithValue("@SUBG2F", SqlDbType.Int).Value = TextBox640.Text;
                   cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox641.Text;
                   cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox642.Text;
                   cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox643.Text;
                   cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox644.Text;
                   cmd.Parameters.AddWithValue("@G2FE15_19", SqlDbType.Int).Value = TextBox645.Text;
                   cmd.Parameters.AddWithValue("@G2FE20_24", SqlDbType.Int).Value = TextBox646.Text;
                   cmd.Parameters.AddWithValue("@G2FE25_49", SqlDbType.Int).Value = TextBox647.Text;
                   cmd.Parameters.AddWithValue("@G2FE50", SqlDbType.Int).Value = TextBox648.Text;
                   cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox649.Text;
                   cmd.Parameters.AddWithValue("@SUBG3M", SqlDbType.Int).Value = TextBox650.Text;
                   cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox651.Text;
                   cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox652.Text;
                   cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox653.Text;
                   cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox654.Text;
                   cmd.Parameters.AddWithValue("@G3MA15_19", SqlDbType.Int).Value = TextBox655.Text;
                   cmd.Parameters.AddWithValue("@G3MA20_24", SqlDbType.Int).Value = TextBox656.Text;
                   cmd.Parameters.AddWithValue("@G3MA25_49", SqlDbType.Int).Value = TextBox657.Text;
                   cmd.Parameters.AddWithValue("@G3MA50", SqlDbType.Int).Value = TextBox658.Text;
                   cmd.Parameters.AddWithValue("@SUBG3F", SqlDbType.Int).Value = TextBox659.Text;
                   cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox660.Text;
                   cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox661.Text;
                   cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox662.Text;
                   cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox663.Text;
                   cmd.Parameters.AddWithValue("@G3FE15_19", SqlDbType.Int).Value = TextBox664.Text;
                   cmd.Parameters.AddWithValue("@G3FE20_24", SqlDbType.Int).Value = TextBox665.Text;
                   cmd.Parameters.AddWithValue("@G3FE25_49", SqlDbType.Int).Value = TextBox666.Text;
                   cmd.Parameters.AddWithValue("@G3FE50", SqlDbType.Int).Value = TextBox667.Text;
                   cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox668.Text;
                   cmd.Parameters.AddWithValue("@SUBG4P", SqlDbType.Int).Value = TextBox669.Text;
                   cmd.Parameters.AddWithValue("@G4P1", SqlDbType.Int).Value = TextBox670.Text;
                   cmd.Parameters.AddWithValue("@G4P1_4", SqlDbType.Int).Value = TextBox671.Text;
                   cmd.Parameters.AddWithValue("@G4P5_9", SqlDbType.Int).Value = TextBox672.Text;
                   cmd.Parameters.AddWithValue("@G4P10_14", SqlDbType.Int).Value = TextBox673.Text;
                   cmd.Parameters.AddWithValue("@G4P15_19", SqlDbType.Int).Value = TextBox674.Text;
                   cmd.Parameters.AddWithValue("@G4P20_24", SqlDbType.Int).Value = TextBox675.Text;
                   cmd.Parameters.AddWithValue("@G4P25_49", SqlDbType.Int).Value = TextBox676.Text;
                   cmd.Parameters.AddWithValue("@G4P50", SqlDbType.Int).Value = TextBox677.Text;
                   cmd.Parameters.AddWithValue("@SUB4N", SqlDbType.Int).Value = TextBox678.Text;
                   cmd.Parameters.AddWithValue("@G4N1", SqlDbType.Int).Value = TextBox679.Text;
                   cmd.Parameters.AddWithValue("@G4N1_4", SqlDbType.Int).Value = TextBox680.Text;
                   cmd.Parameters.AddWithValue("@G4N5_9", SqlDbType.Int).Value = TextBox681.Text;
                   cmd.Parameters.AddWithValue("@G4N10_14", SqlDbType.Int).Value = TextBox682.Text;
                   cmd.Parameters.AddWithValue("@G4N15_19", SqlDbType.Int).Value = TextBox683.Text;
                   cmd.Parameters.AddWithValue("@G4N20_24", SqlDbType.Int).Value = TextBox684.Text;
                   cmd.Parameters.AddWithValue("@G4N25_49", SqlDbType.Int).Value = TextBox685.Text;
                   cmd.Parameters.AddWithValue("@G4N50", SqlDbType.Int).Value = TextBox686.Text;
                   cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox687.Text;
                   cmd.Parameters.AddWithValue("@SUBG5M", SqlDbType.Int).Value = TextBox688.Text;
                   cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox689.Text;
                   cmd.Parameters.AddWithValue("@G5M1_4", SqlDbType.Int).Value = TextBox690.Text;
                   cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox691.Text;
                   cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox692.Text;
                   cmd.Parameters.AddWithValue("@G5MA15_19", SqlDbType.Int).Value = TextBox693.Text;
                   cmd.Parameters.AddWithValue("@G5MA20_24", SqlDbType.Int).Value = TextBox694.Text;
                   cmd.Parameters.AddWithValue("@G5MA25_49", SqlDbType.Int).Value = TextBox695.Text;
                   cmd.Parameters.AddWithValue("@G5MA50", SqlDbType.Int).Value = TextBox696.Text;
                   cmd.Parameters.AddWithValue("@SUBG5F", SqlDbType.Int).Value = TextBox697.Text;
                   cmd.Parameters.AddWithValue("@G5FE1", SqlDbType.Int).Value = TextBox698.Text;
                   cmd.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox699.Text;
                   cmd.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox700.Text;
                   cmd.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox701.Text;
                   cmd.Parameters.AddWithValue("@G5FE15_19", SqlDbType.Int).Value = TextBox702.Text;
                   cmd.Parameters.AddWithValue("@G5FE20_24", SqlDbType.Int).Value = TextBox703.Text;
                   cmd.Parameters.AddWithValue("@G5FE25_49", SqlDbType.Int).Value = TextBox704.Text;
                   cmd.Parameters.AddWithValue("@G5FE50", SqlDbType.Int).Value = TextBox705.Text;
                   cmd.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox706.Text;
                   cmd.Parameters.AddWithValue("@SUBG6M", SqlDbType.Int).Value = TextBox707.Text;
                   cmd.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox708.Text;
                   cmd.Parameters.AddWithValue("@G6M1_4", SqlDbType.Int).Value = TextBox709.Text;
                   cmd.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox710.Text;
                   cmd.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox711.Text;
                   cmd.Parameters.AddWithValue("@G6MA15_19", SqlDbType.Int).Value = TextBox712.Text;
                   cmd.Parameters.AddWithValue("@G6MA20_24", SqlDbType.Int).Value = TextBox713.Text;
                   cmd.Parameters.AddWithValue("@G6MA25_49", SqlDbType.Int).Value = TextBox714.Text;
                   cmd.Parameters.AddWithValue("@G6MA50", SqlDbType.Int).Value = TextBox715.Text;
                   cmd.Parameters.AddWithValue("@SUBG6F", SqlDbType.Int).Value = TextBox716.Text;
                   cmd.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox717.Text;
                   cmd.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox718.Text;
                   cmd.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox719.Text;
                   cmd.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox720.Text;
                   cmd.Parameters.AddWithValue("@G6FE15_19", SqlDbType.Int).Value = TextBox721.Text;
                   cmd.Parameters.AddWithValue("@G6FE20_24", SqlDbType.Int).Value = TextBox722.Text;
                   cmd.Parameters.AddWithValue("@G6FE25_49", SqlDbType.Int).Value = TextBox723.Text;
                   cmd.Parameters.AddWithValue("@G6FE50", SqlDbType.Int).Value = TextBox724.Text;
                   cmd.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox725.Text;
                   cmd.Parameters.AddWithValue("@SUBG7M", SqlDbType.Int).Value = TextBox726.Text;
                   cmd.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox727.Text;
                   cmd.Parameters.AddWithValue("@G7M1_4", SqlDbType.Int).Value = TextBox728.Text;
                   cmd.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox729.Text;
                   cmd.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox730.Text;
                   cmd.Parameters.AddWithValue("@G7MA15_19", SqlDbType.Int).Value = TextBox731.Text;
                   cmd.Parameters.AddWithValue("@G7MA20_24", SqlDbType.Int).Value = TextBox732.Text;
                   cmd.Parameters.AddWithValue("@G7MA25_49", SqlDbType.Int).Value = TextBox733.Text;
                   cmd.Parameters.AddWithValue("@G7MA50", SqlDbType.Int).Value = TextBox734.Text;
                   cmd.Parameters.AddWithValue("@SUBG7F", SqlDbType.Int).Value = TextBox735.Text;
                   cmd.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox736.Text;
                   cmd.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox737.Text;
                   cmd.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox738.Text;
                   cmd.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox739.Text;
                   cmd.Parameters.AddWithValue("@G7FE15_19", SqlDbType.Int).Value = TextBox740.Text;
                   cmd.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox741.Text;
                   cmd.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox742.Text;
                   cmd.Parameters.AddWithValue("@G7FE50", SqlDbType.Int).Value = TextBox743.Text;
                   cmd.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox782.Text;
                   cmd.Parameters.AddWithValue("@SUBG8M", SqlDbType.Int).Value = TextBox783.Text;
                   cmd.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox784.Text;
                   cmd.Parameters.AddWithValue("@G8M15_19", SqlDbType.Int).Value = TextBox785.Text;
                   cmd.Parameters.AddWithValue("@G8MA20_24", SqlDbType.Int).Value = TextBox786.Text;
                   cmd.Parameters.AddWithValue("@G8MA25_49", SqlDbType.Int).Value = TextBox787.Text;
                   cmd.Parameters.AddWithValue("@G8MA50", SqlDbType.Int).Value = TextBox788.Text;
                   cmd.Parameters.AddWithValue("@SUBG8P", SqlDbType.Int).Value = TextBox789.Text;
                   int Rowaffected = cmd.ExecuteNonQuery();
                   cmd.Dispose();
                   cn.Close();



                   //========================= HTC 2 ===================================================
                   if (cn.State == ConnectionState.Closed)
                   {
                       cn.Open();
                   }
                   SqlCommand cmd1 = new SqlCommand(sql1, cn);
                   cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                   cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                   cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                   cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                   cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                   cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                   cmd1.Parameters.AddWithValue("@G8P10_14", SqlDbType.Int).Value = TextBox790.Text;
                   cmd1.Parameters.AddWithValue("@G8P15_19", SqlDbType.Int).Value = TextBox791.Text;
                   cmd1.Parameters.AddWithValue("@G8P20_24", SqlDbType.Int).Value = TextBox792.Text;
                   cmd1.Parameters.AddWithValue("@G8P25_49", SqlDbType.Int).Value = TextBox793.Text;
                   cmd1.Parameters.AddWithValue("@G8P50", SqlDbType.Int).Value = TextBox794.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox795.Text;
                   cmd1.Parameters.AddWithValue("@SUBG9M", SqlDbType.Int).Value = TextBox796.Text;
                   cmd1.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox797.Text;
                   cmd1.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox798.Text;
                   cmd1.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox799.Text;
                   cmd1.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox800.Text;
                   cmd1.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = TextBox801.Text;
                   cmd1.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = TextBox802.Text;
                   cmd1.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = TextBox803.Text;
                   cmd1.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = TextBox804.Text;
                   cmd1.Parameters.AddWithValue("@SUBG9F", SqlDbType.Int).Value = TextBox805.Text;
                   cmd1.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox806.Text;
                   cmd1.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox807.Text;
                   cmd1.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox808.Text;
                   cmd1.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox809.Text;
                   cmd1.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = TextBox810.Text;
                   cmd1.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = TextBox811.Text;
                   cmd1.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = TextBox812.Text;
                   cmd1.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = TextBox813.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox814.Text;
                   cmd1.Parameters.AddWithValue("@SUBG10P", SqlDbType.Int).Value = TextBox815.Text;
                   cmd1.Parameters.AddWithValue("@G10P1", SqlDbType.Int).Value = TextBox816.Text;
                   cmd1.Parameters.AddWithValue("@G10P1_4", SqlDbType.Int).Value = TextBox817.Text;
                   cmd1.Parameters.AddWithValue("@G10P5_9", SqlDbType.Int).Value = TextBox818.Text;
                   cmd1.Parameters.AddWithValue("@G10P10_14", SqlDbType.Int).Value = TextBox819.Text;
                   cmd1.Parameters.AddWithValue("@G10P15_19", SqlDbType.Int).Value = TextBox820.Text;
                   cmd1.Parameters.AddWithValue("@G10P20_24", SqlDbType.Int).Value = TextBox821.Text;
                   cmd1.Parameters.AddWithValue("@G10P25_49", SqlDbType.Int).Value = TextBox822.Text;
                   cmd1.Parameters.AddWithValue("@G10P50", SqlDbType.Int).Value = TextBox823.Text;
                   cmd1.Parameters.AddWithValue("@SUBG10N", SqlDbType.Int).Value = TextBox824.Text;
                   cmd1.Parameters.AddWithValue("@G10N1", SqlDbType.Int).Value = TextBox825.Text;
                   cmd1.Parameters.AddWithValue("@G10N1_4", SqlDbType.Int).Value = TextBox826.Text;
                   cmd1.Parameters.AddWithValue("@G10N5_9", SqlDbType.Int).Value = TextBox827.Text;
                   cmd1.Parameters.AddWithValue("@G10N10_14", SqlDbType.Int).Value = TextBox828.Text;
                   cmd1.Parameters.AddWithValue("@G10N15_19", SqlDbType.Int).Value = TextBox829.Text;
                   cmd1.Parameters.AddWithValue("@G10N20_24", SqlDbType.Int).Value = TextBox830.Text;
                   cmd1.Parameters.AddWithValue("@G10N25_49", SqlDbType.Int).Value = TextBox831.Text;
                   cmd1.Parameters.AddWithValue("@G10N50", SqlDbType.Int).Value = TextBox832.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox833.Text;
                   cmd1.Parameters.AddWithValue("@SUBG11M", SqlDbType.Int).Value = TextBox834.Text;
                   cmd1.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox835.Text;
                   cmd1.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox836.Text;
                   cmd1.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox837.Text;
                   cmd1.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox838.Text;
                   cmd1.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = TextBox839.Text;
                   cmd1.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = TextBox840.Text;
                   cmd1.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = TextBox841.Text;
                   cmd1.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = TextBox842.Text;
                   cmd1.Parameters.AddWithValue("@SUBG11F", SqlDbType.Int).Value = TextBox843.Text;
                   cmd1.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox844.Text;
                   cmd1.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox845.Text;
                   cmd1.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox846.Text;
                   cmd1.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox847.Text;
                   cmd1.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = TextBox848.Text;
                   cmd1.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = TextBox849.Text;
                   cmd1.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = TextBox850.Text;
                   cmd1.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = TextBox851.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox852.Text;
                   cmd1.Parameters.AddWithValue("@SUBG12M", SqlDbType.Int).Value = TextBox853.Text;
                   cmd1.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = TextBox854.Text;
                   cmd1.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = TextBox855.Text;
                   cmd1.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = TextBox856.Text;
                   cmd1.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = TextBox857.Text;
                   cmd1.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = TextBox858.Text;
                   cmd1.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = TextBox859.Text;
                   cmd1.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox860.Text;
                   cmd1.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = TextBox861.Text;
                   cmd1.Parameters.AddWithValue("@SUBG12F", SqlDbType.Int).Value = TextBox862.Text;
                   cmd1.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = TextBox863.Text;
                   cmd1.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = TextBox864.Text;
                   cmd1.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = TextBox865.Text;
                   cmd1.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = TextBox866.Text;
                   cmd1.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = TextBox867.Text;
                   cmd1.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = TextBox868.Text;
                   cmd1.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = TextBox869.Text;
                   cmd1.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = TextBox870.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG13", SqlDbType.Int).Value = TextBox871.Text;
                   cmd1.Parameters.AddWithValue("@SUBG13M", SqlDbType.Int).Value = TextBox872.Text;
                   cmd1.Parameters.AddWithValue("@G13MA1", SqlDbType.Int).Value = TextBox873.Text;
                   cmd1.Parameters.AddWithValue("@G13MA1_4", SqlDbType.Int).Value = TextBox874.Text;
                   cmd1.Parameters.AddWithValue("@G13MA5_9", SqlDbType.Int).Value = TextBox875.Text;
                   cmd1.Parameters.AddWithValue("@G13MA10_14", SqlDbType.Int).Value = TextBox876.Text;
                   cmd1.Parameters.AddWithValue("@G13MA15_19", SqlDbType.Int).Value = TextBox877.Text;
                   cmd1.Parameters.AddWithValue("@G13MA20_24", SqlDbType.Int).Value = TextBox878.Text;
                   cmd1.Parameters.AddWithValue("@G13MA25_49", SqlDbType.Int).Value = TextBox879.Text;
                   cmd1.Parameters.AddWithValue("@G13MA50", SqlDbType.Int).Value = TextBox880.Text;
                   cmd1.Parameters.AddWithValue("@SUBG13F", SqlDbType.Int).Value = TextBox881.Text;
                   cmd1.Parameters.AddWithValue("@G13FE1", SqlDbType.Int).Value = TextBox882.Text;
                   cmd1.Parameters.AddWithValue("@G13FE1_4", SqlDbType.Int).Value = TextBox883.Text;
                   cmd1.Parameters.AddWithValue("@G13FE5_9", SqlDbType.Int).Value = TextBox884.Text;
                   cmd1.Parameters.AddWithValue("@G13FE10_14", SqlDbType.Int).Value = TextBox885.Text;
                   cmd1.Parameters.AddWithValue("@G13FE15_19", SqlDbType.Int).Value = TextBox886.Text;
                   cmd1.Parameters.AddWithValue("@G13FE20_24", SqlDbType.Int).Value = TextBox887.Text;
                   cmd1.Parameters.AddWithValue("@G13FE25_49", SqlDbType.Int).Value = TextBox888.Text;
                   cmd1.Parameters.AddWithValue("@G13FE50", SqlDbType.Int).Value = TextBox889.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG14", SqlDbType.Int).Value = TextBox890.Text;
                   cmd1.Parameters.AddWithValue("@SUBG14M", SqlDbType.Int).Value = TextBox891.Text;
                   cmd1.Parameters.AddWithValue("@G14MA1", SqlDbType.Int).Value = TextBox892.Text;
                   cmd1.Parameters.AddWithValue("@G14MA1_4", SqlDbType.Int).Value = TextBox893.Text;
                   cmd1.Parameters.AddWithValue("@G14MA5_9", SqlDbType.Int).Value = TextBox894.Text;
                   cmd1.Parameters.AddWithValue("@G14MA10_14", SqlDbType.Int).Value = TextBox895.Text;
                   cmd1.Parameters.AddWithValue("@G14MA15_19", SqlDbType.Int).Value = TextBox896.Text;
                   cmd1.Parameters.AddWithValue("@G14MA20_24", SqlDbType.Int).Value = TextBox897.Text;
                   cmd1.Parameters.AddWithValue("@G14MA25_49", SqlDbType.Int).Value = TextBox898.Text;
                   cmd1.Parameters.AddWithValue("@G14MA50", SqlDbType.Int).Value = TextBox899.Text;
                   cmd1.Parameters.AddWithValue("@SUBG14F", SqlDbType.Int).Value = TextBox900.Text;
                   cmd1.Parameters.AddWithValue("@G14FE1", SqlDbType.Int).Value = TextBox901.Text;
                   cmd1.Parameters.AddWithValue("@G14FE1_4", SqlDbType.Int).Value = TextBox902.Text;
                   cmd1.Parameters.AddWithValue("@G14FE5_9", SqlDbType.Int).Value = TextBox903.Text;
                   cmd1.Parameters.AddWithValue("@G14FE10_14", SqlDbType.Int).Value = TextBox904.Text;
                   cmd1.Parameters.AddWithValue("@G14FE15_19", SqlDbType.Int).Value = TextBox905.Text;
                   cmd1.Parameters.AddWithValue("@G14FE20_24", SqlDbType.Int).Value = TextBox906.Text;
                   cmd1.Parameters.AddWithValue("@G14FE25_49", SqlDbType.Int).Value = TextBox907.Text;
                   cmd1.Parameters.AddWithValue("@G14FE50", SqlDbType.Int).Value = TextBox908.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG15", SqlDbType.Int).Value = TextBox909.Text;
                   cmd1.Parameters.AddWithValue("@SUBG15M", SqlDbType.Int).Value = TextBox910.Text;
                   cmd1.Parameters.AddWithValue("@G15MA15_19", SqlDbType.Int).Value = TextBox911.Text;
                   cmd1.Parameters.AddWithValue("@G15MA20_24", SqlDbType.Int).Value = TextBox912.Text;
                   cmd1.Parameters.AddWithValue("@G15MS25_49", SqlDbType.Int).Value = TextBox913.Text;
                   cmd1.Parameters.AddWithValue("@G15MA50", SqlDbType.Int).Value = TextBox914.Text;
                   cmd1.Parameters.AddWithValue("@SUBG15F", SqlDbType.Int).Value = TextBox915.Text;
                   cmd1.Parameters.AddWithValue("@G15FE15_19", SqlDbType.Int).Value = TextBox916.Text;
                   cmd1.Parameters.AddWithValue("@G15FE20_24", SqlDbType.Int).Value = TextBox917.Text;
                   cmd1.Parameters.AddWithValue("@G15FE25_49", SqlDbType.Int).Value = TextBox918.Text;
                   cmd1.Parameters.AddWithValue("@G15FE50", SqlDbType.Int).Value = TextBox919.Text;
                   cmd1.Parameters.AddWithValue("@TOTALG16", SqlDbType.Int).Value = TextBox920.Text;
                   cmd1.Parameters.AddWithValue("@SUBG16M", SqlDbType.Int).Value = TextBox921.Text;
                   cmd1.Parameters.AddWithValue("@G16MA15_19", SqlDbType.Int).Value = TextBox922.Text;
                   cmd1.Parameters.AddWithValue("@G16MA20_24", SqlDbType.Int).Value = TextBox923.Text;
                   cmd1.Parameters.AddWithValue("@G16MS25_49", SqlDbType.Int).Value = TextBox924.Text;
                   cmd1.Parameters.AddWithValue("@G16MA50", SqlDbType.Int).Value = TextBox925.Text;
                   cmd1.Parameters.AddWithValue("@SUBG16F", SqlDbType.Int).Value = TextBox926.Text;
                   cmd1.Parameters.AddWithValue("@G16FE15_19", SqlDbType.Int).Value = TextBox927.Text;
                   cmd1.Parameters.AddWithValue("@G16FE20_24", SqlDbType.Int).Value = TextBox928.Text;
                   cmd1.Parameters.AddWithValue("@G16FE25_49", SqlDbType.Int).Value = TextBox929.Text;
                   cmd1.Parameters.AddWithValue("@G16FE50", SqlDbType.Int).Value = TextBox930.Text;
                   int Rowaffected1 = cmd1.ExecuteNonQuery();
                   cmd1.Dispose();
                   cn.Close();

                    //==============================HTC3 =============================================
                    if(cn.State== ConnectionState.Closed)
            {
                cn.Open();
            }

             SqlCommand cmd2 = new SqlCommand(sql3, cn);
             cmd2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
             cmd2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
             cmd2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
             cmd2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
             cmd2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
             cmd2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

            cmd2.Parameters.AddWithValue("@TOTALG17",SqlDbType.Int).Value=	TextBox931.Text;
            cmd2.Parameters.AddWithValue("@SUBG17M",SqlDbType.Int).Value=	TextBox932.Text;
            cmd2.Parameters.AddWithValue("@G17MA1",SqlDbType.Int).Value=	TextBox933.Text;
            cmd2.Parameters.AddWithValue("@G17MA1_4",SqlDbType.Int).Value=	TextBox934.Text;
            cmd2.Parameters.AddWithValue("@G17MA5_9",SqlDbType.Int).Value=	TextBox935.Text;
            cmd2.Parameters.AddWithValue("@G17MA10_14",SqlDbType.Int).Value=	TextBox936.Text;
            cmd2.Parameters.AddWithValue("@G17MA15_19",SqlDbType.Int).Value=	TextBox937.Text;
            cmd2.Parameters.AddWithValue("@G17MA20_24",SqlDbType.Int).Value=	TextBox938.Text;
            cmd2.Parameters.AddWithValue("@G17MA25_49",SqlDbType.Int).Value=	TextBox939.Text;
            cmd2.Parameters.AddWithValue("@G17MA50",SqlDbType.Int).Value=	TextBox940.Text;
            cmd2.Parameters.AddWithValue("@SUBG17F",SqlDbType.Int).Value=	TextBox941.Text;
            cmd2.Parameters.AddWithValue("@G17FE1",SqlDbType.Int).Value=	TextBox942.Text;
            cmd2.Parameters.AddWithValue("@G17FE1_4", SqlDbType.Int).Value = TextBox943.Text;
            cmd2.Parameters.AddWithValue("@G17FE5_9",SqlDbType.Int).Value=	TextBox944.Text;
            cmd2.Parameters.AddWithValue("@G17FE10_14",SqlDbType.Int).Value=	TextBox945.Text;
            cmd2.Parameters.AddWithValue("@G17FE15_19",SqlDbType.Int).Value=	TextBox946.Text;
            cmd2.Parameters.AddWithValue("@G17FE20_24",SqlDbType.Int).Value=	TextBox947.Text;
            cmd2.Parameters.AddWithValue("@G17FE25_49",SqlDbType.Int).Value=	TextBox948.Text;
            cmd2.Parameters.AddWithValue("@G17FE50",SqlDbType.Int).Value=	TextBox949.Text;
            cmd2.Parameters.AddWithValue("@TOTALG18",SqlDbType.Int).Value=	TextBox950.Text;
            cmd2.Parameters.AddWithValue("@SUBG18M",SqlDbType.Int).Value=	TextBox951.Text;
            cmd2.Parameters.AddWithValue("@G18MA1",SqlDbType.Int).Value=	TextBox952.Text;
            cmd2.Parameters.AddWithValue("@G18MA1_4",SqlDbType.Int).Value=	TextBox953.Text;
            cmd2.Parameters.AddWithValue("@G18MA5_9",SqlDbType.Int).Value=	TextBox954.Text;
            cmd2.Parameters.AddWithValue("@G18MA10_14",SqlDbType.Int).Value=	TextBox955.Text;
            cmd2.Parameters.AddWithValue("@G18MA15_19",SqlDbType.Int).Value=	TextBox956.Text;
            cmd2.Parameters.AddWithValue("@G18MA20_24",SqlDbType.Int).Value=	TextBox957.Text;
            cmd2.Parameters.AddWithValue("@G18MA25_49",SqlDbType.Int).Value=	TextBox958.Text;
            cmd2.Parameters.AddWithValue("@G18MA50",SqlDbType.Int).Value=	TextBox959.Text;
            cmd2.Parameters.AddWithValue("@SUBG18F",SqlDbType.Int).Value=	TextBox960.Text;
            cmd2.Parameters.AddWithValue("@G18FE1",SqlDbType.Int).Value=	TextBox961.Text;
            cmd2.Parameters.AddWithValue("@G18FE1_4",SqlDbType.Int).Value=	TextBox962.Text;
            cmd2.Parameters.AddWithValue("@G18FE5_9",SqlDbType.Int).Value=	TextBox963.Text;
            cmd2.Parameters.AddWithValue("@G18FE10_14",SqlDbType.Int).Value=	TextBox964.Text;
            cmd2.Parameters.AddWithValue("@G18FE15_19",SqlDbType.Int).Value=	TextBox965.Text;
            cmd2.Parameters.AddWithValue("@G18FE20_24",SqlDbType.Int).Value=	TextBox966.Text;
            cmd2.Parameters.AddWithValue("@G18FE25_49",SqlDbType.Int).Value=	TextBox967.Text;
            cmd2.Parameters.AddWithValue("@G18FE50",SqlDbType.Int).Value=	TextBox968.Text;
            cmd2.Parameters.AddWithValue("@TOTALG19",SqlDbType.Int).Value=	TextBox969.Text;
            cmd2.Parameters.AddWithValue("@SUBG19M",SqlDbType.Int).Value=	TextBox970.Text;
            cmd2.Parameters.AddWithValue("@G19MA1",SqlDbType.Int).Value=	TextBox971.Text;
            cmd2.Parameters.AddWithValue("@G19MA1_4",SqlDbType.Int).Value=	TextBox972.Text;
            cmd2.Parameters.AddWithValue("@G98MA5_9",SqlDbType.Int).Value=	TextBox973.Text;
            cmd2.Parameters.AddWithValue("@G19MA10_14",SqlDbType.Int).Value=	TextBox974.Text;
            cmd2.Parameters.AddWithValue("@G19MA15_19",SqlDbType.Int).Value=	TextBox975.Text;
            cmd2.Parameters.AddWithValue("@G19MA20_24",SqlDbType.Int).Value=	TextBox976.Text;
            cmd2.Parameters.AddWithValue("@G19MA25_49",SqlDbType.Int).Value=	TextBox977.Text;
            cmd2.Parameters.AddWithValue("@G19MA50",SqlDbType.Int).Value=	TextBox978.Text;
            cmd2.Parameters.AddWithValue("@SUBG19F",SqlDbType.Int).Value=	TextBox979.Text;
            cmd2.Parameters.AddWithValue("@G19FE1",SqlDbType.Int).Value=	TextBox980.Text;
            cmd2.Parameters.AddWithValue("@G19FE1_4",SqlDbType.Int).Value=	TextBox981.Text;
            cmd2.Parameters.AddWithValue("@G19FE5_9",SqlDbType.Int).Value=	TextBox982.Text;
            cmd2.Parameters.AddWithValue("@G19FE10_14",SqlDbType.Int).Value=	TextBox983.Text;
            cmd2.Parameters.AddWithValue("@G19FE15_19",SqlDbType.Int).Value=	TextBox984.Text;
            cmd2.Parameters.AddWithValue("@G19FE20_24",SqlDbType.Int).Value=	TextBox985.Text;
            cmd2.Parameters.AddWithValue("@G19FE25_49",SqlDbType.Int).Value=	TextBox986.Text;
            cmd2.Parameters.AddWithValue("@G19FE50",SqlDbType.Int).Value=	TextBox987.Text;
            cmd2.Parameters.AddWithValue("@TOTALG20",SqlDbType.Int).Value=	TextBox988.Text;
            cmd2.Parameters.AddWithValue("@SUBG20M",SqlDbType.Int).Value=	TextBox989.Text;
            cmd2.Parameters.AddWithValue("@G20MA1",SqlDbType.Int).Value=	TextBox990.Text;
            cmd2.Parameters.AddWithValue("@G20MA1_4",SqlDbType.Int).Value=	TextBox991.Text;
            cmd2.Parameters.AddWithValue("@G20MA5_9",SqlDbType.Int).Value=	TextBox992.Text;
            cmd2.Parameters.AddWithValue("@G20MA10_14",SqlDbType.Int).Value=	TextBox993.Text;
            cmd2.Parameters.AddWithValue("@G20MA15_19",SqlDbType.Int).Value=	TextBox994.Text;
            cmd2.Parameters.AddWithValue("@G20MA20_24",SqlDbType.Int).Value=	TextBox995.Text;
            cmd2.Parameters.AddWithValue("@G20MA25_49",SqlDbType.Int).Value=	TextBox996.Text;
            cmd2.Parameters.AddWithValue("@G20MA50",SqlDbType.Int).Value=	TextBox997.Text;
            cmd2.Parameters.AddWithValue("@SUBG20F",SqlDbType.Int).Value=	TextBox998.Text;
            cmd2.Parameters.AddWithValue("@G20FE1",SqlDbType.Int).Value=	TextBox999.Text;
            cmd2.Parameters.AddWithValue("@G20FE1_4",SqlDbType.Int).Value=	TextBox1000.Text;
            cmd2.Parameters.AddWithValue("@G20FE5_9",SqlDbType.Int).Value=	TextBox1001.Text;
            cmd2.Parameters.AddWithValue("@G20FE10_14",SqlDbType.Int).Value=	TextBox1002.Text;
            cmd2.Parameters.AddWithValue("@G20FE15_19",SqlDbType.Int).Value=	TextBox1003.Text;
            cmd2.Parameters.AddWithValue("@G20FE20_24",SqlDbType.Int).Value=	TextBox1004.Text;
            cmd2.Parameters.AddWithValue("@G20FE25_49",SqlDbType.Int).Value=	TextBox1005.Text;
            cmd2.Parameters.AddWithValue("@G20FE50",SqlDbType.Int).Value=	TextBox1006.Text;
            cmd2.Parameters.AddWithValue("@TOTALG21",SqlDbType.Int).Value=	TextBox1007.Text;
            cmd2.Parameters.AddWithValue("@SUBG21M",SqlDbType.Int).Value=	TextBox1008.Text;
            cmd2.Parameters.AddWithValue("@G21MA1",SqlDbType.Int).Value=	TextBox1009.Text;
            cmd2.Parameters.AddWithValue("@G21MA1_4",SqlDbType.Int).Value= TextBox1010.Text;
            cmd2.Parameters.AddWithValue("@G21MA5_9",SqlDbType.Int).Value=	TextBox1011.Text;
            cmd2.Parameters.AddWithValue("@G21MA10_14",SqlDbType.Int).Value=	TextBox1012.Text;
            cmd2.Parameters.AddWithValue("@G21MA15_19",SqlDbType.Int).Value=	TextBox1013.Text;
            cmd2.Parameters.AddWithValue("@G21MA20_24",SqlDbType.Int).Value=	TextBox1014.Text;
            cmd2.Parameters.AddWithValue("@G21MA25_49",SqlDbType.Int).Value=	TextBox1015.Text;
            cmd2.Parameters.AddWithValue("@G21MA50",SqlDbType.Int).Value=	TextBox1016.Text;
            cmd2.Parameters.AddWithValue("@SUBG21F", SqlDbType.Int ).Value=	TextBox1017.Text;
            cmd2.Parameters.AddWithValue("@G21FE1",SqlDbType.Int).Value=	TextBox1018.Text;
            cmd2.Parameters.AddWithValue("@G21FE1_4",SqlDbType.Int).Value=	TextBox1019.Text;
            cmd2.Parameters.AddWithValue("@G21FE5_9",SqlDbType.Int).Value=	TextBox1020.Text;
            cmd2.Parameters.AddWithValue("@G21FE10_14",SqlDbType.Int).Value=	TextBox1021.Text;
            cmd2.Parameters.AddWithValue("@G21FE15_19",SqlDbType.Int).Value=	TextBox1022.Text;
            cmd2.Parameters.AddWithValue("@G21FE20_24",SqlDbType.Int).Value=	TextBox1023.Text;
            cmd2.Parameters.AddWithValue("@G21FE25_49",SqlDbType.Int).Value=	TextBox1024.Text;
            cmd2.Parameters.AddWithValue("@G21FE50",SqlDbType.Int).Value=	TextBox1025.Text;
            cmd2.Parameters.AddWithValue("@TOTALG22",SqlDbType.Int).Value=	TextBox1026.Text;
            cmd2.Parameters.AddWithValue("@SUBG22M",SqlDbType.Int).Value=	TextBox1027.Text;
            cmd2.Parameters.AddWithValue("@G22MA1",SqlDbType.Int).Value=	TextBox1028.Text;
            cmd2.Parameters.AddWithValue("@G22MA1_4",SqlDbType.Int).Value=	TextBox1029.Text;
            cmd2.Parameters.AddWithValue("@G22MA5_9",SqlDbType.Int).Value=	TextBox1030.Text;
            cmd2.Parameters.AddWithValue("@G22MA10_14",SqlDbType.Int).Value=	TextBox1031.Text;
            cmd2.Parameters.AddWithValue("@G22MA15_19",SqlDbType.Int).Value=	TextBox1032.Text;
            cmd2.Parameters.AddWithValue("@G22MA20_24",SqlDbType.Int).Value=	TextBox1033.Text;
            cmd2.Parameters.AddWithValue("@G22MA25_49",SqlDbType.Int).Value=	TextBox1034.Text;
            cmd2.Parameters.AddWithValue("@G22MA50",SqlDbType.Int).Value=	TextBox1035.Text;
            cmd2.Parameters.AddWithValue("@SUBG22F",SqlDbType.Int).Value=	TextBox1036.Text;
            cmd2.Parameters.AddWithValue("@G22FE1",SqlDbType.Int).Value=	TextBox1037.Text;
            cmd2.Parameters.AddWithValue("@G22FE1_4",SqlDbType.Int).Value=	TextBox1038.Text;
            cmd2.Parameters.AddWithValue("@G22FE5_9",SqlDbType.Int).Value=	TextBox1039.Text;
            cmd2.Parameters.AddWithValue("@G22FE10_14",SqlDbType.Int).Value=	TextBox1040.Text;
            cmd2.Parameters.AddWithValue("@G22FE15_19",SqlDbType.Int).Value=	TextBox1041.Text;
            cmd2.Parameters.AddWithValue("@G22FE20_24",SqlDbType.Int).Value=	TextBox1042.Text;
            cmd2.Parameters.AddWithValue("@G22FE25_49",SqlDbType.Int).Value=	TextBox1043.Text;
            cmd2.Parameters.AddWithValue("@G22FE50",SqlDbType.Int).Value=	TextBox1044.Text;
            cmd2.Parameters.AddWithValue("@G23_1",SqlDbType.Int).Value=	TextBox1045.Text;
            cmd2.Parameters.AddWithValue("@G23_2",SqlDbType.Int).Value=	TextBox1046.Text;
            cmd2.Parameters.AddWithValue("@TOTALG24",SqlDbType.Int).Value=	TextBox1047.Text;
            cmd2.Parameters.AddWithValue("@SUBG24M",SqlDbType.Int).Value=	TextBox1048.Text;
            cmd2.Parameters.AddWithValue("@G24MA15_19",SqlDbType.Int).Value=	TextBox1049.Text;
            cmd2.Parameters.AddWithValue("@G24MA20_24",SqlDbType.Int).Value=	TextBox1050.Text;
            cmd2.Parameters.AddWithValue("@G24MA25_49",SqlDbType.Int).Value=	TextBox1051.Text;
            cmd2.Parameters.AddWithValue("@G24MA50",SqlDbType.Int).Value=	TextBox1052.Text;
            cmd2.Parameters.AddWithValue("@SUBG24F",SqlDbType.Int).Value=	TextBox1053.Text;
            cmd2.Parameters.AddWithValue("@G24FE15_19",SqlDbType.Int).Value=	TextBox1054.Text;
            cmd2.Parameters.AddWithValue("@G24FE20_24",SqlDbType.Int).Value=	TextBox1055.Text;
            cmd2.Parameters.AddWithValue("@G24FE25_49",SqlDbType.Int).Value=	TextBox1056.Text;
            cmd2.Parameters.AddWithValue("@G24FE50",SqlDbType.Int).Value=	TextBox1057.Text;
            cmd2.Parameters.AddWithValue("@TOTALG25",SqlDbType.Int).Value=	TextBox1058.Text;
            cmd2.Parameters.AddWithValue("@SUBG25M",SqlDbType.Int).Value=	TextBox1059.Text;
            cmd2.Parameters.AddWithValue("@G25MA15_19",SqlDbType.Int).Value=	TextBox1060.Text;
            cmd2.Parameters.AddWithValue("@G25MA20_24",SqlDbType.Int).Value=	TextBox1061.Text;
            cmd2.Parameters.AddWithValue("@G25MA25_49",SqlDbType.Int).Value=	TextBox1062.Text;
            cmd2.Parameters.AddWithValue("@G25MA50",SqlDbType.Int).Value=	TextBox1063.Text;
            cmd2.Parameters.AddWithValue("@SUBG25F",SqlDbType.Int).Value=	TextBox1064.Text;
            cmd2.Parameters.AddWithValue("@G25FE15_19",SqlDbType.Int).Value=	TextBox1065.Text;
            cmd2.Parameters.AddWithValue("@G25FE20_24",SqlDbType.Int).Value=	TextBox1066.Text;
            cmd2.Parameters.AddWithValue("@G25FE25_49",SqlDbType.Int).Value=	TextBox1067.Text;
            cmd2.Parameters.AddWithValue("@G25FE50",SqlDbType.Int).Value=	TextBox1068.Text;
            cmd2.Parameters.AddWithValue("@TOTALG26",SqlDbType.Int).Value=	TextBox1069.Text;
            cmd2.Parameters.AddWithValue("@G26MA1",SqlDbType.Int).Value=	TextBox1070.Text;
            cmd2.Parameters.AddWithValue("@G26FE1",SqlDbType.Int).Value=	TextBox1071.Text;
            int Rowaffected2 = cmd2.ExecuteNonQuery();

            if (Rowaffected != -1 && Rowaffected1 != -1 && Rowaffected2 != -1)
            {
                webMessage.Show(Rowaffected2 + " UPDATE SUCCESSFUL......");
                return;
                CLS_HTC();

                cmd2.Dispose();
                cn.Close();
                return;
            }
                   
                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR UPDATING HTC : " + ex.Message);
                    return;
                }
                
            }
            else
            {
         //===================== INSERT NEW HTC RECORD
              string sql = "INSERT INTO tbl_HTC1  ( states, lga, facname, months, years, grouptype, TOTALG1, SUBG1MA,	G1MA1,G1MA1_4,G1MA5_9,G1MA10_14,G1MA15_19,";
               sql +=" G1MA20_24,G1MA25_49,	G1MA50,	SUBG1FE,G1FE1, G1FE1_4,	G1FE5_9,	G1FE10_14,	 G1FE15_19,";
               sql += " G1FE20_24,G1FE25_49,G1FE50,TOTALG2,SUBG2M,G2MA1, G2MA1_4,G2MA5_9,G2MA10_14,";
               sql += " G2MA15_19,G2MA20_24,G2MA25_49,G2MA50, SUBG2F,G2FE1,	 G2FE1_4, G2FE5_9, G2FE10_14,";
               sql += " G2FE15_19, G2FE20_24,G2FE25_49,G2FE50,	TOTALG3, SUBG3M,G3MA1,G3MA1_4,G3MA5_9,";
               sql += " G3MA10_14,G3MA15_19,G3MA20_24,G3MA25_49, G3MA50,SUBG3F,G3FE1,G3FE1_4,G3FE5_9,";
               sql += " G3FE10_14, G3FE15_19,G3FE20_24,	G3FE25_49,G3FE50,TOTALG4,SUBG4P,G4P1,G4P1_4,";
               sql += " G4P5_9,	 G4P10_14,G4P15_19,G4P20_24,G4P25_49,G4P50,	SUB4N, G4N1, G4N1_4,G4N5_9,";
               sql += " G4N10_14,G4N15_19, G4N20_24, G4N25_49, G4N50, TOTALG5, SUBG5M, G5MA1, G5M1_4,";
               sql += " G5MA5_9,G5MA10_14, G5MA15_19, G5MA20_24, G5MA25_49,	 G5MA50, SUBG5F, G5FE1,	 G5FE1_4,";
               sql += " G5FE5_9,G5FE10_14, G5FE15_19, G5FE20_24, G5FE25_49,	 G5FE50, TOTALG6,SUBG6M, G6MA1,";
               sql += " G6M1_4,	 G6MA5_9, G6MA10_14, G6MA15_19,	 G6MA20_24,	 G6MA25_49,	 G6MA50, SUBG6F, G6FE1,	 G6FE1_4,";
               sql += " G6FE5_9, G6FE10_14,	 G6FE15_19,	 G6FE20_24,	 G6FE25_49,	 G6FE50,TOTALG7, SUBG7M,	 G7MA1,	 G7M1_4,";
               sql += " G7MA5_9, G7MA10_14,	 G7MA15_19,	 G7MA20_24,	 G7MA25_49,	 G7MA50,SUBG7F,	 G7FE1, G7FE1_4, G7FE5_9,";
               sql += " G7FE10_14,	G7FE15_19,	 G7FE20_24,	 G7FE25_49,	 G7FE50, TOTALG8, SUBG8M, G8MA10_14, G8M15_19, G8MA20_24,";
               sql += " G8MA25_49,	 G8MA50, SUBG8P  ) "; 
               sql +="VALUES(@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1,	@SUBG1MA,	@G1MA1,	@G1MA1_4,	@G1MA5_9,	@G1MA10_14,	@G1MA15_19,";
               sql +="@G1MA20_24,	@G1MA25_49,	@G1MA50,	@SUBG1FE,	@G1FE1,	@G1FE1_4,	@G1FE5_9,	@G1FE10_14,	@G1FE15_19,";
               sql += "@G1FE20_24,	@G1FE25_49,	@G1FE50,	@TOTALG2,	@SUBG2M,	@G2MA1,	@G2MA1_4,	@G2MA5_9,	@G2MA10_14,";
               sql += "@G2MA15_19,	@G2MA20_24,	@G2MA25_49,	@G2MA50,	@SUBG2F,	@G2FE1,	@G2FE1_4,	@G2FE5_9,	@G2FE10_14,";
               sql += "@G2FE15_19,	@G2FE20_24,	@G2FE25_49,	@G2FE50,	@TOTALG3,	@SUBG3M,	@G3MA1,	@G3MA1_4,	@G3MA5_9,";
               sql += "@G3MA10_14,	@G3MA15_19,	@G3MA20_24,	@G3MA25_49,	@G3MA50,	@SUBG3F,	@G3FE1,	@G3FE1_4,	@G3FE5_9,";
               sql += "@G3FE10_14,	@G3FE15_19,	@G3FE20_24,	@G3FE25_49,	@G3FE50 ,	@TOTALG4,	@SUBG4P,	@G4P1,	@G4P1_4,";
               sql += "@G4P5_9,	@G4P10_14,	@G4P15_19,	@G4P20_24,	@G4P25_49,	@G4P50,	@SUB4N,	@G4N1, 	@G4N1_4,	@G4N5_9,";
               sql += "@G4N10_14,	@G4N15_19,	@G4N20_24,	@G4N25_49,	@G4N50,	@TOTALG5,	@SUBG5M,	@G5MA1,	@G5M1_4,";
               sql += "@G5MA5_9,	@G5MA10_14,	@G5MA15_19,	@G5MA20_24,	@G5MA25_49,	@G5MA50,	@SUBG5F,	@G5FE1,	@G5FE1_4,";
               sql += "@G5FE5_9,	@G5FE10_14,	@G5FE15_19,	@G5FE20_24,	@G5FE25_49,	@G5FE50,	@TOTALG6,	@SUBG6M,	@G6MA1,";
               sql += "@G6M1_4,	@G6MA5_9,	@G6MA10_14,	@G6MA15_19,	@G6MA20_24,	@G6MA25_49,	@G6MA50,	@SUBG6F,	@G6FE1,	@G6FE1_4,";
               sql += "@G6FE5_9,	@G6FE10_14,	@G6FE15_19,	@G6FE20_24,	@G6FE25_49,	@G6FE50,	@TOTALG7,	@SUBG7M,	@G7MA1,	@G7M1_4,";
               sql += "@G7MA5_9,	@G7MA10_14,	@G7MA15_19,	@G7MA20_24,	@G7MA25_49,	@G7MA50,	@SUBG7F,	@G7FE1,	@G7FE1_4,	@G7FE5_9,";
               sql += "@G7FE10_14,	@G7FE15_19,	@G7FE20_24,	@G7FE25_49,	@G7FE50,	@TOTALG8,	@SUBG8M,	@G8MA10_14,	@G8M15_19,	@G8MA20_24,";
               sql += "@G8MA25_49,	@G8MA50,	@SUBG8P  ) ";

               //================== tbl_HTC2====================================
               string sql1 = "INSERT INTO tbl_HTC2 (states, lga, facname, months, years, grouptype,G8P10_14,";
               sql1 += "G8P15_19, G8P20_24, G8P25_49,	G8P50,	TOTALG9, SUBG9M, G9MA1, G9MA1_4,	G9MA5_9,";
               sql1 += "G9MA10_14, G9MA15_19,	G9MA20_24, G9MA25_49, G9MA50, SUBG9F, G9FE1, G9FE1_4, G9FE5_9,";
               sql1 += "G9FE10_14,	G9FE15_19, G9FE20_24, G9FE25_49, G9FE50, TOTALG10, SUBG10P, G10P1, G10P1_4,	";
               sql1 += "G10P5_9, G10P10_14, G10P15_19, G10P20_24, G10P25_49, G10P50, SUBG10N, G10N1, G10N1_4, G10N5_9,";
               sql1 += "G10N10_14, G10N15_19, G10N20_24, G10N25_49, G10N50,	TOTALG11, SUBG11M, G11MA1, G11MA1_4, G11MA5_9,";
               sql1 += "G11MA10_14, G11MA15_19,	G11MA20_24, G11MA25_49, G11MA50, SUBG11F, G11FE1, G11FE1_4, G11FE5_9, G11FE10_14,";
               sql1 += "G11FE15_19, G11FE20_24, G11FE25_49, G11FE50, TOTALG12, SUBG12M,	G12MA1, G12MA1_4, G12MA5_9, G12MA10_14,";
               sql1 += "G12MA15_19, G12MA20_24, G12MA25_49,	G12MA50, SUBG12F, G12FE1, G12FE1_4, G12FE5_9, G12FE10_14, G12FE15_19,";
               sql1 += "G12FE20_24,	G12FE25_49, G12FE50, TOTALG13, SUBG13M, G13MA1, G13MA1_4, G13MA5_9,	G13MA10_14, G13MA15_19, G13MA20_24,";
               sql1 += "G13MA25_49, G13MA50, SUBG13F, G13FE1,	G13FE1_4, G13FE5_9, G13FE10_14, G13FE15_19, G13FE20_24, G13FE25_49, G13FE50,";
               sql1 += "TOTALG14, SUBG14M, G14MA1, G14MA1_4, G14MA5_9, G14MA10_14, G14MA15_19,	G14MA20_24, G14MA25_49, G14MA50, SUBG14F, G14FE1,";
               sql1 += "G14FE1_4, G14FE5_9,	G14FE10_14, G14FE15_19, G14FE20_24,  G14FE25_49, G14FE50, TOTALG15, SUBG15M, G15MA15_19, G15MA20_24,";
               sql1 += "G15MS25_49, G15MA50, SUBG15F, G15FE15_19, G15FE20_24, G15FE25_49, G15FE50, TOTALG16, SUBG16M, G16MA15_19, G16MA20_24,";
               sql1 += "G16MS25_49,	G16MA50, SUBG16F, G16FE15_19, G16FE20_24, G16FE25_49, G16FE50 )";

               sql1 += "VALUES (@states, @lga, @facname, @months, @years, @grouptype, @G8P10_14, @G8P15_19, @G8P20_24, @G8P25_49, @G8P50, @TOTALG9, @SUBG9M,";
               sql1 += "@G9MA1, @G9MA1_4, @G9MA5_9, @G9MA10_14, @G9MA15_19,	@G9MA20_24, @G9MA25_49, @G9MA50, @SUBG9F, @G9FE1, @G9FE1_4, @G9FE5_9, @G9FE10_14,";
               sql1 += "@G9FE15_19, @G9FE20_24, @G9FE25_49, @G9FE50, @TOTALG10, @SUBG10P, @G10P1, @G10P1_4, @G10P5_9, @G10P10_14, @G10P15_19, @G10P20_24, @G10P25_49,";
               sql1 += "@G10P50, @SUBG10N, @G10N1,	@G10N1_4,@G10N5_9, @G10N10_14, @G10N15_19, @G10N20_24, @G10N25_49, @G10N50, @TOTALG11, @SUBG11M, @G11MA1, @G11MA1_4,";
               sql1 += "@G11MA5_9, @G11MA10_14, @G11MA15_19,	@G11MA20_24, @G11MA25_49, @G11MA50, @SUBG11F, @G11FE1, @G11FE1_4, @G11FE5_9, @G11FE10_14, @G11FE15_19,";
               sql1 += "@G11FE20_24, @G11FE25_49, @G11FE50, @TOTALG12, @SUBG12M,	@G12MA1, @G12MA1_4, @G12MA5_9, @G12MA10_14, @G12MA15_19, @G12MA20_24, @G12MA25_49,";
               sql1 += "@G12MA50, @SUBG12F, @G12FE1, @G12FE1_4, @G12FE5_9, @G12FE10_14, @G12FE15_19, @G12FE20_24, @G12FE25_49, @G12FE50, @TOTALG13, @SUBG13M, @G13MA1,";
               sql1 += "@G13MA1_4, @G13MA5_9, @G13MA10_14, @G13MA15_19, @G13MA20_24, @G13MA25_49, @G13MA50, @SUBG13F, @G13FE1, @G13FE1_4, @G13FE5_9, @G13FE10_14, @G13FE15_19,";
               sql1 += "@G13FE20_24, @G13FE25_49, @G13FE50, @TOTALG14, @SUBG14M, @G14MA1, @G14MA1_4, @G14MA5_9, @G14MA10_14, @G14MA15_19, @G14MA20_24, @G14MA25_49, @G14MA50,";
               sql1 += "@SUBG14F, @G14FE1, @G14FE1_4, @G14FE5_9, @G14FE10_14, @G14FE15_19, @G14FE20_24,  @G14FE25_49, @G14FE50, @TOTALG15, @SUBG15M,	@G15MA15_19, @G15MA20_24,";
               sql1 += "@G15MS25_49, @G15MA50, @SUBG15F, @G15FE15_19, @G15FE20_24, @G15FE25_49, @G15FE50, @TOTALG16, @SUBG16M, @G16MA15_19, @G16MA20_24, @G16MS25_49, @G16MA50,";
               sql1 += "@SUBG16F, @G16FE15_19, @G16FE20_24, @G16FE25_49,@G16FE50 )";


               //=============== HTC3 ======================
               string sql3 = "INSERT INTO tbl_HTC3 ";
               sql3 += " VALUES (@states, @lga, @facname, @months, @years, @grouptype, @TOTALG17,@SUBG17M,	@G17MA1,	@G17MA1_4,	@G17MA5_9,	@G17MA10_14, @G17MA15_19,";
               sql3 += "@G17MA20_24,	@G17MA25_49,	@G17MA50,	@SUBG17F,	@G17FE1,	@G17FE1_4,	@G17FE5_9,	@G17FE10_14,	@G17FE15_19,	@G17FE20_24,@G17FE25_49,";
               sql3 += "@G17FE50,	@TOTALG18,	@SUBG18M,	@G18MA1,	@G18MA1_4,	@G18MA5_9,	@G18MA10_14,	@G18MA15_19,	@G18MA20_24,	@G18MA25_49,	@G18MA50,";
               sql3 += "@SUBG18F,	@G18FE1,	@G18FE1_4,	@G18FE5_9,	@G18FE10_14,	@G18FE15_19,	@G18FE20_24,	@G18FE25_49,	@G18FE50,	@TOTALG19,	@SUBG19M,";
               sql3 += "@G19MA1,	@G19MA1_4,	@G98MA5_9,	@G19MA10_14,	@G19MA15_19,	@G19MA20_24,	@G19MA25_49,	@G19MA50,	@SUBG19F,	@G19FE1,	@G19FE1_4,";
               sql3 += "@G19FE5_9,	@G19FE10_14,	@G19FE15_19,	@G19FE20_24,	@G19FE25_49,	@G19FE50,	@TOTALG20,	@SUBG20M,	@G20MA1,	@G20MA1_4,	@G20MA5_9,";
               sql3 += "@G20MA10_14,	@G20MA15_19,	@G20MA20_24,	@G20MA25_49,	@G20MA50,	@SUBG20F,	@G20FE1,	@G20FE1_4,	@G20FE5_9,	@G20FE10_14,@G20FE15_19,";
               sql3 += "@G20FE20_24,	@G20FE25_49,	@G20FE50,	@TOTALG21,	@SUBG21M,	@G21MA1,	@G21MA1_4,	@G21MA5_9,	@G21MA10_14,	@G21MA15_19,	@G21MA20_24,";
               sql3 += "@G21MA25_49,	@G21MA50,	@SUBG21F,	@G21FE1,	@G21FE1_4,	@G21FE5_9,	@G21FE10_14,	@G21FE15_19,	@G21FE20_24,	@G21FE25_49,@G21FE50,";
               sql3 += "@TOTALG22,	@SUBG22M,	@G22MA1,	@G22MA1_4,	@G22MA5_9,	@G22MA10_14,	@G22MA15_19,	@G22MA20_24,	@G22MA25_49,	@G22MA50,	@SUBG22F,";
               sql3 += "@G22FE1,	@G22FE1_4,	@G22FE5_9,	@G22FE10_14,	@G22FE15_19,	@G22FE20_24,	@G22FE25_49,	@G22FE50,	@G23_1,	@G23_2,	@TOTALG24,	@SUBG24M,";
               sql3 += "@G24MA15_19,	@G24MA20_24,	@G24MA25_49,	@G24MA50,	@SUBG24F,	@G24FE15_19,	@G24FE20_24,	@G24FE25_49,	@G24FE50,	@TOTALG25,";
               sql3 += "@SUBG25M,	@G25MA15_19,	@G25MA20_24,	@G25MA25_49,	@G25MA50,	@SUBG25F,	@G25FE15_19,	@G25FE20_24,	@G25FE25_49,	@G25FE50,";
               sql3 += "@TOTALG26,	@G26MA1,	@G26FE1)";
        try
        {
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
            cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
            cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
            cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
            cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
            cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

           cmd.Parameters.AddWithValue("@TOTALG1",SqlDbType.Int).Value=	TextBox611.Text.Trim();
            cmd.Parameters.AddWithValue("@SUBG1MA",SqlDbType.Int).Value=	TextBox612.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA1",SqlDbType.Int).Value=	TextBox613.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA1_4",SqlDbType.Int).Value=	TextBox614.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA5_9",SqlDbType.Int).Value=	TextBox615.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA10_14",SqlDbType.Int).Value=	TextBox616.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA15_19",SqlDbType.Int).Value =	TextBox617.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA20_24",SqlDbType.Int).Value=	TextBox618.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA25_49",SqlDbType.Int).Value=	TextBox619.Text.Trim();
            cmd.Parameters.AddWithValue("@G1MA50",SqlDbType.Int).Value=	TextBox620.Text.Trim();
            cmd.Parameters.AddWithValue("@SUBG1FE",SqlDbType.Int).Value=	TextBox621.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE1",SqlDbType.Int).Value=	TextBox622.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE1_4",SqlDbType.Int).Value=	TextBox623.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE5_9",SqlDbType.Int).Value=	TextBox624.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE10_14",SqlDbType.Int).Value=	TextBox625.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE15_19",SqlDbType.Int).Value=	TextBox626.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE20_24",SqlDbType.Int).Value=	TextBox627.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE25_49",SqlDbType.Int).Value=	TextBox628.Text.Trim();
            cmd.Parameters.AddWithValue("@G1FE50",SqlDbType.Int).Value=	TextBox629.Text.Trim();
            cmd.Parameters.AddWithValue("@TOTALG2",SqlDbType.Int).Value=	TextBox630.Text.Trim();
            cmd.Parameters.AddWithValue("@SUBG2M",SqlDbType.Int).Value=	TextBox631.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA1",SqlDbType.Int).Value=	TextBox632.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA1_4",SqlDbType.Int).Value=	TextBox633.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA5_9",SqlDbType.Int).Value=	TextBox634.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA10_14",SqlDbType.Int).Value=	TextBox635.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA15_19",SqlDbType.Int).Value=	TextBox636.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA20_24",SqlDbType.Int).Value=	TextBox637.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA25_49",SqlDbType.Int).Value=	TextBox638.Text.Trim();
            cmd.Parameters.AddWithValue("@G2MA50",SqlDbType.Int).Value=	TextBox639.Text;
            cmd.Parameters.AddWithValue("@SUBG2F",SqlDbType.Int).Value=	TextBox640.Text;
            cmd.Parameters.AddWithValue("@G2FE1",SqlDbType.Int).Value= TextBox641.Text;
            cmd.Parameters.AddWithValue("@G2FE1_4",SqlDbType.Int).Value=	TextBox642.Text;
            cmd.Parameters.AddWithValue("@G2FE5_9",SqlDbType.Int).Value=	TextBox643.Text;
            cmd.Parameters.AddWithValue("@G2FE10_14",SqlDbType.Int).Value=	TextBox644.Text;
            cmd.Parameters.AddWithValue("@G2FE15_19",SqlDbType.Int).Value=	TextBox645.Text;
            cmd.Parameters.AddWithValue("@G2FE20_24",SqlDbType.Int).Value=	TextBox646.Text;
            cmd.Parameters.AddWithValue("@G2FE25_49",SqlDbType.Int).Value=	TextBox647.Text;
            cmd.Parameters.AddWithValue("@G2FE50",SqlDbType.Int).Value=	TextBox648.Text;
            cmd.Parameters.AddWithValue("@TOTALG3",SqlDbType.Int).Value=	TextBox649.Text;
            cmd.Parameters.AddWithValue("@SUBG3M",SqlDbType.Int).Value=	TextBox650.Text;
            cmd.Parameters.AddWithValue("@G3MA1",SqlDbType.Int).Value=	TextBox651.Text;
            cmd.Parameters.AddWithValue("@G3MA1_4",SqlDbType.Int).Value=	TextBox652.Text;
            cmd.Parameters.AddWithValue("@G3MA5_9",SqlDbType.Int).Value=	TextBox653.Text;
            cmd.Parameters.AddWithValue("@G3MA10_14",SqlDbType.Int).Value=	TextBox654.Text;
            cmd.Parameters.AddWithValue("@G3MA15_19",SqlDbType.Int).Value=	TextBox655.Text;
            cmd.Parameters.AddWithValue("@G3MA20_24",SqlDbType.Int).Value=	TextBox656.Text;
            cmd.Parameters.AddWithValue("@G3MA25_49",SqlDbType.Int).Value=	TextBox657.Text;
            cmd.Parameters.AddWithValue("@G3MA50",SqlDbType.Int).Value=	TextBox658.Text;
            cmd.Parameters.AddWithValue("@SUBG3F",SqlDbType.Int).Value=	TextBox659.Text;
            cmd.Parameters.AddWithValue("@G3FE1",SqlDbType.Int).Value=	TextBox660.Text;
            cmd.Parameters.AddWithValue("@G3FE1_4",SqlDbType.Int).Value=	TextBox661.Text;
            cmd.Parameters.AddWithValue("@G3FE5_9",SqlDbType.Int).Value=	TextBox662.Text;
            cmd.Parameters.AddWithValue("@G3FE10_14",SqlDbType.Int).Value=	TextBox663.Text;
            cmd.Parameters.AddWithValue("@G3FE15_19",SqlDbType.Int).Value=	TextBox664.Text;
            cmd.Parameters.AddWithValue("@G3FE20_24",SqlDbType.Int).Value=	TextBox665.Text;
            cmd.Parameters.AddWithValue("@G3FE25_49",SqlDbType.Int).Value=	TextBox666.Text;
            cmd.Parameters.AddWithValue("@G3FE50",SqlDbType.Int).Value=	TextBox667.Text;
            cmd.Parameters.AddWithValue("@TOTALG4",SqlDbType.Int).Value=	TextBox668.Text;
            cmd.Parameters.AddWithValue("@SUBG4P",SqlDbType.Int).Value=	TextBox669.Text;
            cmd.Parameters.AddWithValue("@G4P1",SqlDbType.Int).Value=	TextBox670.Text;
            cmd.Parameters.AddWithValue("@G4P1_4",SqlDbType.Int).Value=	TextBox671.Text;
            cmd.Parameters.AddWithValue("@G4P5_9",SqlDbType.Int).Value=	TextBox672.Text;
            cmd.Parameters.AddWithValue("@G4P10_14",SqlDbType.Int).Value=	TextBox673.Text;
            cmd.Parameters.AddWithValue("@G4P15_19",SqlDbType.Int).Value=	TextBox674.Text;
            cmd.Parameters.AddWithValue("@G4P20_24",SqlDbType.Int).Value=	TextBox675.Text;
            cmd.Parameters.AddWithValue("@G4P25_49",SqlDbType.Int).Value=	TextBox676.Text;
            cmd.Parameters.AddWithValue("@G4P50",SqlDbType.Int).Value=	TextBox677.Text;
            cmd.Parameters.AddWithValue("@SUB4N",SqlDbType.Int).Value=	TextBox678.Text;
            cmd.Parameters.AddWithValue("@G4N1",SqlDbType.Int).Value=	TextBox679.Text;
            cmd.Parameters.AddWithValue("@G4N1_4",SqlDbType.Int).Value=	TextBox680.Text;
            cmd.Parameters.AddWithValue("@G4N5_9",SqlDbType.Int).Value=	TextBox681.Text;
            cmd.Parameters.AddWithValue("@G4N10_14",SqlDbType.Int).Value=	TextBox682.Text;
            cmd.Parameters.AddWithValue("@G4N15_19",SqlDbType.Int).Value=	TextBox683.Text;
            cmd.Parameters.AddWithValue("@G4N20_24",SqlDbType.Int).Value=	TextBox684.Text;
            cmd.Parameters.AddWithValue("@G4N25_49",SqlDbType.Int).Value=	TextBox685.Text;
            cmd.Parameters.AddWithValue("@G4N50",SqlDbType.Int).Value=	TextBox686.Text;
            cmd.Parameters.AddWithValue("@TOTALG5",SqlDbType.Int).Value=	TextBox687.Text;
            cmd.Parameters.AddWithValue("@SUBG5M",SqlDbType.Int).Value=	TextBox688.Text;
            cmd.Parameters.AddWithValue("@G5MA1",SqlDbType.Int).Value=	TextBox689.Text;
            cmd.Parameters.AddWithValue("@G5M1_4",SqlDbType.Int).Value=	TextBox690.Text;
            cmd.Parameters.AddWithValue("@G5MA5_9",SqlDbType.Int).Value=	TextBox691.Text;
            cmd.Parameters.AddWithValue("@G5MA10_14",SqlDbType.Int).Value=	TextBox692.Text;
            cmd.Parameters.AddWithValue("@G5MA15_19",SqlDbType.Int).Value=	TextBox693.Text;
            cmd.Parameters.AddWithValue("@G5MA20_24",SqlDbType.Int).Value=	TextBox694.Text;
            cmd.Parameters.AddWithValue("@G5MA25_49",SqlDbType.Int).Value=	TextBox695.Text;
            cmd.Parameters.AddWithValue("@G5MA50",SqlDbType.Int).Value=	TextBox696.Text;
            cmd.Parameters.AddWithValue("@SUBG5F",SqlDbType.Int).Value=	TextBox697.Text;
            cmd.Parameters.AddWithValue("@G5FE1",SqlDbType.Int).Value=	TextBox698.Text;
            cmd.Parameters.AddWithValue("@G5FE1_4",SqlDbType.Int).Value=	TextBox699.Text;
            cmd.Parameters.AddWithValue("@G5FE5_9",SqlDbType.Int).Value=	TextBox700.Text;
            cmd.Parameters.AddWithValue("@G5FE10_14",SqlDbType.Int).Value=	TextBox701.Text;
            cmd.Parameters.AddWithValue("@G5FE15_19",SqlDbType.Int).Value=	TextBox702.Text;
            cmd.Parameters.AddWithValue("@G5FE20_24",SqlDbType.Int).Value=	TextBox703.Text;
            cmd.Parameters.AddWithValue("@G5FE25_49",SqlDbType.Int).Value=	TextBox704.Text;
            cmd.Parameters.AddWithValue("@G5FE50",SqlDbType.Int).Value=	TextBox705.Text;
            cmd.Parameters.AddWithValue("@TOTALG6",SqlDbType.Int).Value=	TextBox706.Text;
            cmd.Parameters.AddWithValue("@SUBG6M",SqlDbType.Int).Value=	TextBox707.Text;
            cmd.Parameters.AddWithValue("@G6MA1",SqlDbType.Int).Value=	TextBox708.Text;
            cmd.Parameters.AddWithValue("@G6M1_4",SqlDbType.Int).Value=	TextBox709.Text;
            cmd.Parameters.AddWithValue("@G6MA5_9",SqlDbType.Int).Value=	TextBox710.Text;
            cmd.Parameters.AddWithValue("@G6MA10_14",SqlDbType.Int).Value=	TextBox711.Text;
            cmd.Parameters.AddWithValue("@G6MA15_19",SqlDbType.Int).Value=	TextBox712.Text;
            cmd.Parameters.AddWithValue("@G6MA20_24",SqlDbType.Int).Value=	TextBox713.Text;
            cmd.Parameters.AddWithValue("@G6MA25_49",SqlDbType.Int).Value=	TextBox714.Text;
            cmd.Parameters.AddWithValue("@G6MA50",SqlDbType.Int).Value=	TextBox715.Text;
            cmd.Parameters.AddWithValue("@SUBG6F",SqlDbType.Int).Value=	TextBox716.Text;
            cmd.Parameters.AddWithValue("@G6FE1",SqlDbType.Int).Value=	TextBox717.Text;
            cmd.Parameters.AddWithValue("@G6FE1_4",SqlDbType.Int).Value=	TextBox718.Text;
            cmd.Parameters.AddWithValue("@G6FE5_9",SqlDbType.Int).Value=	TextBox719.Text;
            cmd.Parameters.AddWithValue("@G6FE10_14",SqlDbType.Int).Value=	TextBox720.Text;
            cmd.Parameters.AddWithValue("@G6FE15_19",SqlDbType.Int).Value=	TextBox721.Text;
            cmd.Parameters.AddWithValue("@G6FE20_24",SqlDbType.Int).Value=	TextBox722.Text;
            cmd.Parameters.AddWithValue("@G6FE25_49",SqlDbType.Int).Value=	TextBox723.Text;
            cmd.Parameters.AddWithValue("@G6FE50",SqlDbType.Int).Value=	TextBox724.Text;
            cmd.Parameters.AddWithValue("@TOTALG7",SqlDbType.Int).Value=	TextBox725.Text;
            cmd.Parameters.AddWithValue("@SUBG7M",SqlDbType.Int).Value=	TextBox726.Text;
            cmd.Parameters.AddWithValue("@G7MA1",SqlDbType.Int).Value=	TextBox727.Text;
            cmd.Parameters.AddWithValue("@G7M1_4",SqlDbType.Int).Value=	TextBox728.Text;
            cmd.Parameters.AddWithValue("@G7MA5_9",SqlDbType.Int).Value=	TextBox729.Text;
            cmd.Parameters.AddWithValue("@G7MA10_14",SqlDbType.Int).Value=	TextBox730.Text;
            cmd.Parameters.AddWithValue("@G7MA15_19",SqlDbType.Int).Value=	TextBox731.Text;
            cmd.Parameters.AddWithValue("@G7MA20_24",SqlDbType.Int).Value=	TextBox732.Text;
            cmd.Parameters.AddWithValue("@G7MA25_49",SqlDbType.Int).Value=	TextBox733.Text;
            cmd.Parameters.AddWithValue("@G7MA50",SqlDbType.Int).Value=	TextBox734.Text;
            cmd.Parameters.AddWithValue("@SUBG7F",SqlDbType.Int).Value=	TextBox735.Text;
            cmd.Parameters.AddWithValue("@G7FE1",SqlDbType.Int).Value=	TextBox736.Text;
            cmd.Parameters.AddWithValue("@G7FE1_4",SqlDbType.Int).Value=	TextBox737.Text;
            cmd.Parameters.AddWithValue("@G7FE5_9",SqlDbType.Int).Value=	TextBox738.Text;
            cmd.Parameters.AddWithValue("@G7FE10_14",SqlDbType.Int).Value=	TextBox739.Text;
            cmd.Parameters.AddWithValue("@G7FE15_19",SqlDbType.Int).Value=	TextBox740.Text;
            cmd.Parameters.AddWithValue("@G7FE20_24",SqlDbType.Int).Value=	TextBox741.Text;
            cmd.Parameters.AddWithValue("@G7FE25_49",SqlDbType.Int).Value=	TextBox742.Text;
            cmd.Parameters.AddWithValue("@G7FE50",SqlDbType.Int).Value=	TextBox743.Text;
            cmd.Parameters.AddWithValue("@TOTALG8",SqlDbType.Int).Value=	TextBox782.Text;
            cmd.Parameters.AddWithValue("@SUBG8M",SqlDbType.Int).Value=	TextBox783.Text;
            cmd.Parameters.AddWithValue("@G8MA10_14",SqlDbType.Int).Value=	TextBox784.Text;
            cmd.Parameters.AddWithValue("@G8M15_19",SqlDbType.Int).Value=	TextBox785.Text;
            cmd.Parameters.AddWithValue("@G8MA20_24",SqlDbType.Int).Value=	TextBox786.Text;
            cmd.Parameters.AddWithValue("@G8MA25_49",SqlDbType.Int).Value=	TextBox787.Text;
            cmd.Parameters.AddWithValue("@G8MA50",SqlDbType.Int).Value=	TextBox788.Text;
            cmd.Parameters.AddWithValue("@SUBG8P", SqlDbType.Int).Value = TextBox789.Text;
            int Rowaffected = cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
      
            //========================= HTC 2 ===================================================
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
             SqlCommand cmd1 = new SqlCommand(sql1, cn);
             cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
             cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
             cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
             cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
             cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
             cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

            cmd1.Parameters.AddWithValue("@G8P10_14",SqlDbType.Int).Value=	TextBox790.Text;
            cmd1.Parameters.AddWithValue("@G8P15_19",SqlDbType.Int).Value=	TextBox791.Text;
            cmd1.Parameters.AddWithValue("@G8P20_24",SqlDbType.Int).Value=	TextBox792.Text;
            cmd1.Parameters.AddWithValue("@G8P25_49",SqlDbType.Int).Value=	TextBox793.Text;
            cmd1.Parameters.AddWithValue("@G8P50",SqlDbType.Int).Value=	TextBox794.Text;
            cmd1.Parameters.AddWithValue("@TOTALG9",SqlDbType.Int).Value=	TextBox795.Text;
            cmd1.Parameters.AddWithValue("@SUBG9M",SqlDbType.Int).Value=	TextBox796.Text;
            cmd1.Parameters.AddWithValue("@G9MA1",SqlDbType.Int).Value=	TextBox797.Text;
            cmd1.Parameters.AddWithValue("@G9MA1_4",SqlDbType.Int).Value=	TextBox798.Text;
            cmd1.Parameters.AddWithValue("@G9MA5_9",SqlDbType.Int).Value=	TextBox799.Text;
            cmd1.Parameters.AddWithValue("@G9MA10_14",SqlDbType.Int).Value=	TextBox800.Text;
            cmd1.Parameters.AddWithValue("@G9MA15_19",SqlDbType.Int).Value=	TextBox801.Text;
            cmd1.Parameters.AddWithValue("@G9MA20_24",SqlDbType.Int).Value=	TextBox802.Text;
            cmd1.Parameters.AddWithValue("@G9MA25_49",SqlDbType.Int).Value=	TextBox803.Text;
            cmd1.Parameters.AddWithValue("@G9MA50",SqlDbType.Int).Value=	TextBox804.Text;
            cmd1.Parameters.AddWithValue("@SUBG9F",SqlDbType.Int).Value=	TextBox805.Text;
            cmd1.Parameters.AddWithValue("@G9FE1",SqlDbType.Int).Value=	TextBox806.Text;
            cmd1.Parameters.AddWithValue("@G9FE1_4",SqlDbType.Int).Value=	TextBox807.Text;
            cmd1.Parameters.AddWithValue("@G9FE5_9",SqlDbType.Int).Value=	TextBox808.Text;
            cmd1.Parameters.AddWithValue("@G9FE10_14",SqlDbType.Int).Value=	TextBox809.Text;
            cmd1.Parameters.AddWithValue("@G9FE15_19",SqlDbType.Int).Value=	TextBox810.Text;
            cmd1.Parameters.AddWithValue("@G9FE20_24",SqlDbType.Int).Value=	TextBox811.Text;
            cmd1.Parameters.AddWithValue("@G9FE25_49",SqlDbType.Int).Value=	TextBox812.Text;
            cmd1.Parameters.AddWithValue("@G9FE50",SqlDbType.Int).Value=	TextBox813.Text;
            cmd1.Parameters.AddWithValue("@TOTALG10",SqlDbType.Int).Value=	TextBox814.Text;
            cmd1.Parameters.AddWithValue("@SUBG10P",SqlDbType.Int).Value=	TextBox815.Text;
            cmd1.Parameters.AddWithValue("@G10P1",SqlDbType.Int).Value=	TextBox816.Text;
            cmd1.Parameters.AddWithValue("@G10P1_4",SqlDbType.Int).Value=	TextBox817.Text;
            cmd1.Parameters.AddWithValue("@G10P5_9",SqlDbType.Int).Value=	TextBox818.Text;
            cmd1.Parameters.AddWithValue("@G10P10_14",SqlDbType.Int).Value=	TextBox819.Text;
            cmd1.Parameters.AddWithValue("@G10P15_19",SqlDbType.Int).Value=	TextBox820.Text;
            cmd1.Parameters.AddWithValue("@G10P20_24",SqlDbType.Int).Value=	TextBox821.Text;
            cmd1.Parameters.AddWithValue("@G10P25_49",SqlDbType.Int).Value=	TextBox822.Text;
            cmd1.Parameters.AddWithValue("@G10P50",SqlDbType.Int).Value=	TextBox823.Text;
            cmd1.Parameters.AddWithValue("@SUBG10N",SqlDbType.Int).Value=	TextBox824.Text;
            cmd1.Parameters.AddWithValue("@G10N1",SqlDbType.Int).Value=	TextBox825.Text;
            cmd1.Parameters.AddWithValue("@G10N1_4",SqlDbType.Int).Value=	TextBox826.Text;
            cmd1.Parameters.AddWithValue("@G10N5_9",SqlDbType.Int).Value=	TextBox827.Text;
            cmd1.Parameters.AddWithValue("@G10N10_14",SqlDbType.Int).Value=	TextBox828.Text;
            cmd1.Parameters.AddWithValue("@G10N15_19",SqlDbType.Int).Value=	TextBox829.Text;
            cmd1.Parameters.AddWithValue("@G10N20_24",SqlDbType.Int).Value=	TextBox830.Text;
            cmd1.Parameters.AddWithValue("@G10N25_49",SqlDbType.Int).Value=	TextBox831.Text;
            cmd1.Parameters.AddWithValue("@G10N50",SqlDbType.Int).Value=	TextBox832.Text;
            cmd1.Parameters.AddWithValue("@TOTALG11",SqlDbType.Int).Value=	TextBox833.Text;
            cmd1.Parameters.AddWithValue("@SUBG11M",SqlDbType.Int).Value=	TextBox834.Text;
            cmd1.Parameters.AddWithValue("@G11MA1",SqlDbType.Int).Value=	TextBox835.Text;
            cmd1.Parameters.AddWithValue("@G11MA1_4",SqlDbType.Int).Value=	TextBox836.Text;
            cmd1.Parameters.AddWithValue("@G11MA5_9",SqlDbType.Int).Value=	TextBox837.Text;
            cmd1.Parameters.AddWithValue("@G11MA10_14",SqlDbType.Int).Value=	TextBox838.Text;
            cmd1.Parameters.AddWithValue("@G11MA15_19",SqlDbType.Int).Value=	TextBox839.Text;
            cmd1.Parameters.AddWithValue("@G11MA20_24",SqlDbType.Int).Value=	TextBox840.Text;
            cmd1.Parameters.AddWithValue("@G11MA25_49",SqlDbType.Int).Value=	TextBox841.Text;
            cmd1.Parameters.AddWithValue("@G11MA50",SqlDbType.Int).Value=	TextBox842.Text;
            cmd1.Parameters.AddWithValue("@SUBG11F",SqlDbType.Int).Value=	TextBox843.Text;
            cmd1.Parameters.AddWithValue("@G11FE1",SqlDbType.Int).Value=	TextBox844.Text;
            cmd1.Parameters.AddWithValue("@G11FE1_4",SqlDbType.Int).Value=	TextBox845.Text;
            cmd1.Parameters.AddWithValue("@G11FE5_9",SqlDbType.Int).Value=	TextBox846.Text;
            cmd1.Parameters.AddWithValue("@G11FE10_14",SqlDbType.Int ).Value=	TextBox847.Text;
            cmd1.Parameters.AddWithValue("@G11FE15_19",SqlDbType.Int).Value=	TextBox848.Text;
            cmd1.Parameters.AddWithValue("@G11FE20_24",SqlDbType.Int).Value=	TextBox849.Text;
            cmd1.Parameters.AddWithValue("@G11FE25_49",SqlDbType.Int).Value=	TextBox850.Text;
            cmd1.Parameters.AddWithValue("@G11FE50",SqlDbType.Int).Value=	TextBox851.Text;
            cmd1.Parameters.AddWithValue("@TOTALG12",SqlDbType.Int).Value=	TextBox852.Text;
            cmd1.Parameters.AddWithValue("@SUBG12M",SqlDbType.Int).Value=	TextBox853.Text;
            cmd1.Parameters.AddWithValue("@G12MA1",SqlDbType.Int).Value=	TextBox854.Text;
            cmd1.Parameters.AddWithValue("@G12MA1_4",SqlDbType.Int).Value=	TextBox855.Text;
            cmd1.Parameters.AddWithValue("@G12MA5_9",SqlDbType.Int).Value=	TextBox856.Text;
            cmd1.Parameters.AddWithValue("@G12MA10_14",SqlDbType.Int).Value=	TextBox857.Text;
            cmd1.Parameters.AddWithValue("@G12MA15_19",SqlDbType.Int).Value=	TextBox858.Text;
            cmd1.Parameters.AddWithValue("@G12MA20_24",SqlDbType.Int).Value=	TextBox859.Text;
            cmd1.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox860.Text;
            cmd1.Parameters.AddWithValue("@G12MA50",SqlDbType.Int).Value=	TextBox861.Text;
            cmd1.Parameters.AddWithValue("@SUBG12F",SqlDbType.Int).Value=	TextBox862.Text;
            cmd1.Parameters.AddWithValue("@G12FE1",SqlDbType.Int).Value=	TextBox863.Text;
            cmd1.Parameters.AddWithValue("@G12FE1_4",SqlDbType.Int).Value=	TextBox864.Text;
            cmd1.Parameters.AddWithValue("@G12FE5_9",SqlDbType.Int).Value= TextBox865.Text;
            cmd1.Parameters.AddWithValue("@G12FE10_14",SqlDbType.Int).Value=	TextBox866.Text;
            cmd1.Parameters.AddWithValue("@G12FE15_19",SqlDbType.Int).Value=	TextBox867.Text;
            cmd1.Parameters.AddWithValue("@G12FE20_24",SqlDbType.Int).Value=	TextBox868.Text;
            cmd1.Parameters.AddWithValue("@G12FE25_49",SqlDbType.Int).Value=	TextBox869.Text;
            cmd1.Parameters.AddWithValue("@G12FE50",SqlDbType.Int).Value=	TextBox870.Text;
            cmd1.Parameters.AddWithValue("@TOTALG13",SqlDbType.Int).Value=	TextBox871.Text;
            cmd1.Parameters.AddWithValue("@SUBG13M",SqlDbType.Int).Value=	TextBox872.Text;
            cmd1.Parameters.AddWithValue("@G13MA1",SqlDbType.Int).Value=	TextBox873.Text;
            cmd1.Parameters.AddWithValue("@G13MA1_4",SqlDbType.Int).Value=	TextBox874.Text;
            cmd1.Parameters.AddWithValue("@G13MA5_9",SqlDbType.Int).Value=	TextBox875.Text;
            cmd1.Parameters.AddWithValue("@G13MA10_14",SqlDbType.Int).Value=	TextBox876.Text;
            cmd1.Parameters.AddWithValue("@G13MA15_19",SqlDbType.Int).Value=	TextBox877.Text;
            cmd1.Parameters.AddWithValue("@G13MA20_24",SqlDbType.Int).Value=	TextBox878.Text;
            cmd1.Parameters.AddWithValue("@G13MA25_49",SqlDbType.Int).Value=	TextBox879.Text;
            cmd1.Parameters.AddWithValue("@G13MA50",SqlDbType.Int).Value=	TextBox880.Text;
            cmd1.Parameters.AddWithValue("@SUBG13F",SqlDbType.Int).Value=	TextBox881.Text;
            cmd1.Parameters.AddWithValue("@G13FE1",SqlDbType.Int).Value=	TextBox882.Text;
            cmd1.Parameters.AddWithValue("@G13FE1_4",SqlDbType.Int).Value=	TextBox883.Text;
            cmd1.Parameters.AddWithValue("@G13FE5_9",SqlDbType.Int).Value=	TextBox884.Text;
            cmd1.Parameters.AddWithValue("@G13FE10_14",SqlDbType.Int).Value=	TextBox885.Text;
            cmd1.Parameters.AddWithValue("@G13FE15_19",SqlDbType.Int).Value=	TextBox886.Text;
            cmd1.Parameters.AddWithValue("@G13FE20_24",SqlDbType.Int).Value=	TextBox887.Text;
            cmd1.Parameters.AddWithValue("@G13FE25_49",SqlDbType.Int).Value=	TextBox888.Text;
            cmd1.Parameters.AddWithValue("@G13FE50",SqlDbType.Int).Value=	TextBox889.Text;
            cmd1.Parameters.AddWithValue("@TOTALG14",SqlDbType.Int).Value=	TextBox890.Text;
            cmd1.Parameters.AddWithValue("@SUBG14M",SqlDbType.Int).Value=	TextBox891.Text;
            cmd1.Parameters.AddWithValue("@G14MA1",SqlDbType.Int).Value=	TextBox892.Text;
            cmd1.Parameters.AddWithValue("@G14MA1_4",SqlDbType.Int).Value=	TextBox893.Text;
            cmd1.Parameters.AddWithValue("@G14MA5_9",SqlDbType.Int).Value=	TextBox894.Text;
            cmd1.Parameters.AddWithValue("@G14MA10_14",SqlDbType.Int).Value=	TextBox895.Text;
            cmd1.Parameters.AddWithValue("@G14MA15_19",SqlDbType.Int).Value=	TextBox896.Text;
            cmd1.Parameters.AddWithValue("@G14MA20_24",SqlDbType.Int).Value=	TextBox897.Text;
            cmd1.Parameters.AddWithValue("@G14MA25_49",SqlDbType.Int).Value=	TextBox898.Text;
            cmd1.Parameters.AddWithValue("@G14MA50",SqlDbType.Int).Value=	TextBox899.Text;
            cmd1.Parameters.AddWithValue("@SUBG14F",SqlDbType.Int).Value=	TextBox900.Text;
            cmd1.Parameters.AddWithValue("@G14FE1",SqlDbType.Int).Value=	TextBox901.Text;
            cmd1.Parameters.AddWithValue("@G14FE1_4",SqlDbType.Int).Value=	TextBox902.Text;
            cmd1.Parameters.AddWithValue("@G14FE5_9",SqlDbType.Int).Value=	TextBox903.Text;
            cmd1.Parameters.AddWithValue("@G14FE10_14",SqlDbType.Int).Value=	TextBox904.Text;
            cmd1.Parameters.AddWithValue("@G14FE15_19",SqlDbType.Int).Value=	TextBox905.Text;
            cmd1.Parameters.AddWithValue("@G14FE20_24",SqlDbType.Int).Value=	TextBox906.Text;
            cmd1.Parameters.AddWithValue("@G14FE25_49",SqlDbType.Int).Value=	TextBox907.Text;
            cmd1.Parameters.AddWithValue("@G14FE50",SqlDbType.Int).Value=	TextBox908.Text;
            cmd1.Parameters.AddWithValue("@TOTALG15",SqlDbType.Int).Value=	TextBox909.Text;
            cmd1.Parameters.AddWithValue("@SUBG15M",SqlDbType.Int).Value=	TextBox910.Text;
            cmd1.Parameters.AddWithValue("@G15MA15_19",SqlDbType.Int).Value=	TextBox911.Text;
            cmd1.Parameters.AddWithValue("@G15MA20_24",SqlDbType.Int).Value=	TextBox912.Text;
            cmd1.Parameters.AddWithValue("@G15MS25_49",SqlDbType.Int).Value=	TextBox913.Text;
            cmd1.Parameters.AddWithValue("@G15MA50",SqlDbType.Int).Value=	TextBox914.Text;
            cmd1.Parameters.AddWithValue("@SUBG15F",SqlDbType.Int).Value=	TextBox915.Text;
            cmd1.Parameters.AddWithValue("@G15FE15_19",SqlDbType.Int).Value=	TextBox916.Text;
            cmd1.Parameters.AddWithValue("@G15FE20_24",SqlDbType.Int).Value=	TextBox917.Text;
            cmd1.Parameters.AddWithValue("@G15FE25_49",SqlDbType.Int).Value=	TextBox918.Text;
            cmd1.Parameters.AddWithValue("@G15FE50",SqlDbType.Int).Value=	TextBox919.Text;
            cmd1.Parameters.AddWithValue("@TOTALG16",SqlDbType.Int).Value=	TextBox920.Text;
            cmd1.Parameters.AddWithValue("@SUBG16M",SqlDbType.Int).Value=	TextBox921.Text;
            cmd1.Parameters.AddWithValue("@G16MA15_19",SqlDbType.Int).Value=	TextBox922.Text;
            cmd1.Parameters.AddWithValue("@G16MA20_24",SqlDbType.Int).Value=	TextBox923.Text;
            cmd1.Parameters.AddWithValue("@G16MS25_49",SqlDbType.Int).Value=	TextBox924.Text;
            cmd1.Parameters.AddWithValue("@G16MA50",SqlDbType.Int).Value=	TextBox925.Text;
            cmd1.Parameters.AddWithValue("@SUBG16F",SqlDbType.Int).Value=	TextBox926.Text;
            cmd1.Parameters.AddWithValue("@G16FE15_19",SqlDbType.Int).Value=	TextBox927.Text;
            cmd1.Parameters.AddWithValue("@G16FE20_24",SqlDbType.Int).Value=	TextBox928.Text;
            cmd1.Parameters.AddWithValue("@G16FE25_49",SqlDbType.Int).Value=	TextBox929.Text;
            cmd1.Parameters.AddWithValue("@G16FE50", SqlDbType.Int).Value = TextBox930.Text;
            int Rowaffected1 = cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            cn.Close();

            //========================= HTC 3 ===================================================
            if(cn.State== ConnectionState.Closed)
            {
                cn.Open();
            }

             SqlCommand cmd2 = new SqlCommand(sql3, cn);
             cmd2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
             cmd2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
             cmd2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
             cmd2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
             cmd2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
             cmd2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

            cmd2.Parameters.AddWithValue("@TOTALG17",SqlDbType.Int).Value=	TextBox931.Text;
            cmd2.Parameters.AddWithValue("@SUBG17M",SqlDbType.Int).Value=	TextBox932.Text;
            cmd2.Parameters.AddWithValue("@G17MA1",SqlDbType.Int).Value=	TextBox933.Text;
            cmd2.Parameters.AddWithValue("@G17MA1_4",SqlDbType.Int).Value=	TextBox934.Text;
            cmd2.Parameters.AddWithValue("@G17MA5_9",SqlDbType.Int).Value=	TextBox935.Text;
            cmd2.Parameters.AddWithValue("@G17MA10_14",SqlDbType.Int).Value=	TextBox936.Text;
            cmd2.Parameters.AddWithValue("@G17MA15_19",SqlDbType.Int).Value=	TextBox937.Text;
            cmd2.Parameters.AddWithValue("@G17MA20_24",SqlDbType.Int).Value=	TextBox938.Text;
            cmd2.Parameters.AddWithValue("@G17MA25_49",SqlDbType.Int).Value=	TextBox939.Text;
            cmd2.Parameters.AddWithValue("@G17MA50",SqlDbType.Int).Value=	TextBox940.Text;
            cmd2.Parameters.AddWithValue("@SUBG17F",SqlDbType.Int).Value=	TextBox941.Text;
            cmd2.Parameters.AddWithValue("@G17FE1",SqlDbType.Int).Value=	TextBox942.Text;
            cmd2.Parameters.AddWithValue("@G17FE1_4", SqlDbType.Int).Value = TextBox943.Text;
            cmd2.Parameters.AddWithValue("@G17FE5_9",SqlDbType.Int).Value=	TextBox944.Text;
            cmd2.Parameters.AddWithValue("@G17FE10_14",SqlDbType.Int).Value=	TextBox945.Text;
            cmd2.Parameters.AddWithValue("@G17FE15_19",SqlDbType.Int).Value=	TextBox946.Text;
            cmd2.Parameters.AddWithValue("@G17FE20_24",SqlDbType.Int).Value=	TextBox947.Text;
            cmd2.Parameters.AddWithValue("@G17FE25_49",SqlDbType.Int).Value=	TextBox948.Text;
            cmd2.Parameters.AddWithValue("@G17FE50",SqlDbType.Int).Value=	TextBox949.Text;
            cmd2.Parameters.AddWithValue("@TOTALG18",SqlDbType.Int).Value=	TextBox950.Text;
            cmd2.Parameters.AddWithValue("@SUBG18M",SqlDbType.Int).Value=	TextBox951.Text;
            cmd2.Parameters.AddWithValue("@G18MA1",SqlDbType.Int).Value=	TextBox952.Text;
            cmd2.Parameters.AddWithValue("@G18MA1_4",SqlDbType.Int).Value=	TextBox953.Text;
            cmd2.Parameters.AddWithValue("@G18MA5_9",SqlDbType.Int).Value=	TextBox954.Text;
            cmd2.Parameters.AddWithValue("@G18MA10_14",SqlDbType.Int).Value=	TextBox955.Text;
            cmd2.Parameters.AddWithValue("@G18MA15_19",SqlDbType.Int).Value=	TextBox956.Text;
            cmd2.Parameters.AddWithValue("@G18MA20_24",SqlDbType.Int).Value=	TextBox957.Text;
            cmd2.Parameters.AddWithValue("@G18MA25_49",SqlDbType.Int).Value=	TextBox958.Text;
            cmd2.Parameters.AddWithValue("@G18MA50",SqlDbType.Int).Value=	TextBox959.Text;
            cmd2.Parameters.AddWithValue("@SUBG18F",SqlDbType.Int).Value=	TextBox960.Text;
            cmd2.Parameters.AddWithValue("@G18FE1",SqlDbType.Int).Value=	TextBox961.Text;
            cmd2.Parameters.AddWithValue("@G18FE1_4",SqlDbType.Int).Value=	TextBox962.Text;
            cmd2.Parameters.AddWithValue("@G18FE5_9",SqlDbType.Int).Value=	TextBox963.Text;
            cmd2.Parameters.AddWithValue("@G18FE10_14",SqlDbType.Int).Value=	TextBox964.Text;
            cmd2.Parameters.AddWithValue("@G18FE15_19",SqlDbType.Int).Value=	TextBox965.Text;
            cmd2.Parameters.AddWithValue("@G18FE20_24",SqlDbType.Int).Value=	TextBox966.Text;
            cmd2.Parameters.AddWithValue("@G18FE25_49",SqlDbType.Int).Value=	TextBox967.Text;
            cmd2.Parameters.AddWithValue("@G18FE50",SqlDbType.Int).Value=	TextBox968.Text;
            cmd2.Parameters.AddWithValue("@TOTALG19",SqlDbType.Int).Value=	TextBox969.Text;
            cmd2.Parameters.AddWithValue("@SUBG19M",SqlDbType.Int).Value=	TextBox970.Text;
            cmd2.Parameters.AddWithValue("@G19MA1",SqlDbType.Int).Value=	TextBox971.Text;
            cmd2.Parameters.AddWithValue("@G19MA1_4",SqlDbType.Int).Value=	TextBox972.Text;
            cmd2.Parameters.AddWithValue("@G98MA5_9",SqlDbType.Int).Value=	TextBox973.Text;
            cmd2.Parameters.AddWithValue("@G19MA10_14",SqlDbType.Int).Value=	TextBox974.Text;
            cmd2.Parameters.AddWithValue("@G19MA15_19",SqlDbType.Int).Value=	TextBox975.Text;
            cmd2.Parameters.AddWithValue("@G19MA20_24",SqlDbType.Int).Value=	TextBox976.Text;
            cmd2.Parameters.AddWithValue("@G19MA25_49",SqlDbType.Int).Value=	TextBox977.Text;
            cmd2.Parameters.AddWithValue("@G19MA50",SqlDbType.Int).Value=	TextBox978.Text;
            cmd2.Parameters.AddWithValue("@SUBG19F",SqlDbType.Int).Value=	TextBox979.Text;
            cmd2.Parameters.AddWithValue("@G19FE1",SqlDbType.Int).Value=	TextBox980.Text;
            cmd2.Parameters.AddWithValue("@G19FE1_4",SqlDbType.Int).Value=	TextBox981.Text;
            cmd2.Parameters.AddWithValue("@G19FE5_9",SqlDbType.Int).Value=	TextBox982.Text;
            cmd2.Parameters.AddWithValue("@G19FE10_14",SqlDbType.Int).Value=	TextBox983.Text;
            cmd2.Parameters.AddWithValue("@G19FE15_19",SqlDbType.Int).Value=	TextBox984.Text;
            cmd2.Parameters.AddWithValue("@G19FE20_24",SqlDbType.Int).Value=	TextBox985.Text;
            cmd2.Parameters.AddWithValue("@G19FE25_49",SqlDbType.Int).Value=	TextBox986.Text;
            cmd2.Parameters.AddWithValue("@G19FE50",SqlDbType.Int).Value=	TextBox987.Text;
            cmd2.Parameters.AddWithValue("@TOTALG20",SqlDbType.Int).Value=	TextBox988.Text;
            cmd2.Parameters.AddWithValue("@SUBG20M",SqlDbType.Int).Value=	TextBox989.Text;
            cmd2.Parameters.AddWithValue("@G20MA1",SqlDbType.Int).Value=	TextBox990.Text;
            cmd2.Parameters.AddWithValue("@G20MA1_4",SqlDbType.Int).Value=	TextBox991.Text;
            cmd2.Parameters.AddWithValue("@G20MA5_9",SqlDbType.Int).Value=	TextBox992.Text;
            cmd2.Parameters.AddWithValue("@G20MA10_14",SqlDbType.Int).Value=	TextBox993.Text;
            cmd2.Parameters.AddWithValue("@G20MA15_19",SqlDbType.Int).Value=	TextBox994.Text;
            cmd2.Parameters.AddWithValue("@G20MA20_24",SqlDbType.Int).Value=	TextBox995.Text;
            cmd2.Parameters.AddWithValue("@G20MA25_49",SqlDbType.Int).Value=	TextBox996.Text;
            cmd2.Parameters.AddWithValue("@G20MA50",SqlDbType.Int).Value=	TextBox997.Text;
            cmd2.Parameters.AddWithValue("@SUBG20F",SqlDbType.Int).Value=	TextBox998.Text;
            cmd2.Parameters.AddWithValue("@G20FE1",SqlDbType.Int).Value=	TextBox999.Text;
            cmd2.Parameters.AddWithValue("@G20FE1_4",SqlDbType.Int).Value=	TextBox1000.Text;
            cmd2.Parameters.AddWithValue("@G20FE5_9",SqlDbType.Int).Value=	TextBox1001.Text;
            cmd2.Parameters.AddWithValue("@G20FE10_14",SqlDbType.Int).Value=	TextBox1002.Text;
            cmd2.Parameters.AddWithValue("@G20FE15_19",SqlDbType.Int).Value=	TextBox1003.Text;
            cmd2.Parameters.AddWithValue("@G20FE20_24",SqlDbType.Int).Value=	TextBox1004.Text;
            cmd2.Parameters.AddWithValue("@G20FE25_49",SqlDbType.Int).Value=	TextBox1005.Text;
            cmd2.Parameters.AddWithValue("@G20FE50",SqlDbType.Int).Value=	TextBox1006.Text;
            cmd2.Parameters.AddWithValue("@TOTALG21",SqlDbType.Int).Value=	TextBox1007.Text;
            cmd2.Parameters.AddWithValue("@SUBG21M",SqlDbType.Int).Value=	TextBox1008.Text;
            cmd2.Parameters.AddWithValue("@G21MA1",SqlDbType.Int).Value=	TextBox1009.Text;
            cmd2.Parameters.AddWithValue("@G21MA1_4",SqlDbType.Int).Value= TextBox1010.Text;
            cmd2.Parameters.AddWithValue("@G21MA5_9",SqlDbType.Int).Value=	TextBox1011.Text;
            cmd2.Parameters.AddWithValue("@G21MA10_14",SqlDbType.Int).Value=	TextBox1012.Text;
            cmd2.Parameters.AddWithValue("@G21MA15_19",SqlDbType.Int).Value=	TextBox1013.Text;
            cmd2.Parameters.AddWithValue("@G21MA20_24",SqlDbType.Int).Value=	TextBox1014.Text;
            cmd2.Parameters.AddWithValue("@G21MA25_49",SqlDbType.Int).Value=	TextBox1015.Text;
            cmd2.Parameters.AddWithValue("@G21MA50",SqlDbType.Int).Value=	TextBox1016.Text;
            cmd2.Parameters.AddWithValue("@SUBG21F", SqlDbType.Int ).Value=	TextBox1017.Text;
            cmd2.Parameters.AddWithValue("@G21FE1",SqlDbType.Int).Value=	TextBox1018.Text;
            cmd2.Parameters.AddWithValue("@G21FE1_4",SqlDbType.Int).Value=	TextBox1019.Text;
            cmd2.Parameters.AddWithValue("@G21FE5_9",SqlDbType.Int).Value=	TextBox1020.Text;
            cmd2.Parameters.AddWithValue("@G21FE10_14",SqlDbType.Int).Value=	TextBox1021.Text;
            cmd2.Parameters.AddWithValue("@G21FE15_19",SqlDbType.Int).Value=	TextBox1022.Text;
            cmd2.Parameters.AddWithValue("@G21FE20_24",SqlDbType.Int).Value=	TextBox1023.Text;
            cmd2.Parameters.AddWithValue("@G21FE25_49",SqlDbType.Int).Value=	TextBox1024.Text;
            cmd2.Parameters.AddWithValue("@G21FE50",SqlDbType.Int).Value=	TextBox1025.Text;
            cmd2.Parameters.AddWithValue("@TOTALG22",SqlDbType.Int).Value=	TextBox1026.Text;
            cmd2.Parameters.AddWithValue("@SUBG22M",SqlDbType.Int).Value=	TextBox1027.Text;
            cmd2.Parameters.AddWithValue("@G22MA1",SqlDbType.Int).Value=	TextBox1028.Text;
            cmd2.Parameters.AddWithValue("@G22MA1_4",SqlDbType.Int).Value=	TextBox1029.Text;
            cmd2.Parameters.AddWithValue("@G22MA5_9",SqlDbType.Int).Value=	TextBox1030.Text;
            cmd2.Parameters.AddWithValue("@G22MA10_14",SqlDbType.Int).Value=	TextBox1031.Text;
            cmd2.Parameters.AddWithValue("@G22MA15_19",SqlDbType.Int).Value=	TextBox1032.Text;
            cmd2.Parameters.AddWithValue("@G22MA20_24",SqlDbType.Int).Value=	TextBox1033.Text;
            cmd2.Parameters.AddWithValue("@G22MA25_49",SqlDbType.Int).Value=	TextBox1034.Text;
            cmd2.Parameters.AddWithValue("@G22MA50",SqlDbType.Int).Value=	TextBox1035.Text;
            cmd2.Parameters.AddWithValue("@SUBG22F",SqlDbType.Int).Value=	TextBox1036.Text;
            cmd2.Parameters.AddWithValue("@G22FE1",SqlDbType.Int).Value=	TextBox1037.Text;
            cmd2.Parameters.AddWithValue("@G22FE1_4",SqlDbType.Int).Value=	TextBox1038.Text;
            cmd2.Parameters.AddWithValue("@G22FE5_9",SqlDbType.Int).Value=	TextBox1039.Text;
            cmd2.Parameters.AddWithValue("@G22FE10_14",SqlDbType.Int).Value=	TextBox1040.Text;
            cmd2.Parameters.AddWithValue("@G22FE15_19",SqlDbType.Int).Value=	TextBox1041.Text;
            cmd2.Parameters.AddWithValue("@G22FE20_24",SqlDbType.Int).Value=	TextBox1042.Text;
            cmd2.Parameters.AddWithValue("@G22FE25_49",SqlDbType.Int).Value=	TextBox1043.Text;
            cmd2.Parameters.AddWithValue("@G22FE50",SqlDbType.Int).Value=	TextBox1044.Text;
            cmd2.Parameters.AddWithValue("@G23_1",SqlDbType.Int).Value=	TextBox1045.Text;
            cmd2.Parameters.AddWithValue("@G23_2",SqlDbType.Int).Value=	TextBox1046.Text;
            cmd2.Parameters.AddWithValue("@TOTALG24",SqlDbType.Int).Value=	TextBox1047.Text;
            cmd2.Parameters.AddWithValue("@SUBG24M",SqlDbType.Int).Value=	TextBox1048.Text;
            cmd2.Parameters.AddWithValue("@G24MA15_19",SqlDbType.Int).Value=	TextBox1049.Text;
            cmd2.Parameters.AddWithValue("@G24MA20_24",SqlDbType.Int).Value=	TextBox1050.Text;
            cmd2.Parameters.AddWithValue("@G24MA25_49",SqlDbType.Int).Value=	TextBox1051.Text;
            cmd2.Parameters.AddWithValue("@G24MA50",SqlDbType.Int).Value=	TextBox1052.Text;
            cmd2.Parameters.AddWithValue("@SUBG24F",SqlDbType.Int).Value=	TextBox1053.Text;
            cmd2.Parameters.AddWithValue("@G24FE15_19",SqlDbType.Int).Value=	TextBox1054.Text;
            cmd2.Parameters.AddWithValue("@G24FE20_24",SqlDbType.Int).Value=	TextBox1055.Text;
            cmd2.Parameters.AddWithValue("@G24FE25_49",SqlDbType.Int).Value=	TextBox1056.Text;
            cmd2.Parameters.AddWithValue("@G24FE50",SqlDbType.Int).Value=	TextBox1057.Text;
            cmd2.Parameters.AddWithValue("@TOTALG25",SqlDbType.Int).Value=	TextBox1058.Text;
            cmd2.Parameters.AddWithValue("@SUBG25M",SqlDbType.Int).Value=	TextBox1059.Text;
            cmd2.Parameters.AddWithValue("@G25MA15_19",SqlDbType.Int).Value=	TextBox1060.Text;
            cmd2.Parameters.AddWithValue("@G25MA20_24",SqlDbType.Int).Value=	TextBox1061.Text;
            cmd2.Parameters.AddWithValue("@G25MA25_49",SqlDbType.Int).Value=	TextBox1062.Text;
            cmd2.Parameters.AddWithValue("@G25MA50",SqlDbType.Int).Value=	TextBox1063.Text;
            cmd2.Parameters.AddWithValue("@SUBG25F",SqlDbType.Int).Value=	TextBox1064.Text;
            cmd2.Parameters.AddWithValue("@G25FE15_19",SqlDbType.Int).Value=	TextBox1065.Text;
            cmd2.Parameters.AddWithValue("@G25FE20_24",SqlDbType.Int).Value=	TextBox1066.Text;
            cmd2.Parameters.AddWithValue("@G25FE25_49",SqlDbType.Int).Value=	TextBox1067.Text;
            cmd2.Parameters.AddWithValue("@G25FE50",SqlDbType.Int).Value=	TextBox1068.Text;
            cmd2.Parameters.AddWithValue("@TOTALG26",SqlDbType.Int).Value=	TextBox1069.Text;
            cmd2.Parameters.AddWithValue("@G26MA1",SqlDbType.Int).Value=	TextBox1070.Text;
            cmd2.Parameters.AddWithValue("@G26FE1",SqlDbType.Int).Value=	TextBox1071.Text;
            int Rowaffected2 = cmd2.ExecuteNonQuery();

            if (Rowaffected != -1 && Rowaffected1 != -1 && Rowaffected2 !=-1)
               webMessage.Show( Rowaffected.ToString() + " Successful ");
                CLS_HTC();
               
                cmd2.Dispose();
                cn.Close();
                return;
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
            return;
        }

            }
        }
        
    }

 
    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
                if (!string.IsNullOrEmpty(Session["mChoose"] as string) && !string.IsNullOrEmpty(Session["mYr"] as string))
                {
                    mState = Session["mState"].ToString();
                    mLGA = Session["mLga"].ToString();
                    mFacility = Session["mFacility"].ToString();
                    mMnth = Session["mMnth"].ToString();
                    mYr = Session["mYr"].ToString();
                   // mFile = Session["mFile"].ToString();
                    mChoose = Session["mChoose"].ToString();

                    switch (mChoose)
                    {
                        case "CARE":
                            SAVE_CARE();
                            break;
                        case "ART":
                            SAVE_ART();
                            break;
                        case "HTC":
                            SAVE_HTC();
                            break;
                        default:
                            Response.Write("<script language=javascript>alert('Wrong Selection ');</script>");
                            return;
                    }

                }
                return;
           
        }catch(Exception ex)
        {
            Response.Write("<script language=javascript>alert('"+ex.Message.ToString()+"');</script>");
            return;
        }

    }

    protected void TextBox257_TextChanged(object sender, EventArgs e)
    {
        TextBox249.Text = Convert.ToString(Convert.ToInt32(TextBox250.Text) + Convert.ToInt32(TextBox251.Text) + Convert.ToInt32(TextBox252.Text) + Convert.ToInt32(TextBox253.Text)
            + Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox256.Text) + Convert.ToInt32(TextBox257.Text));
        TextBox259.Focus();
    }
    protected void TextBox266_TextChanged(object sender, EventArgs e)
    {
        TextBox258.Text = Convert.ToString(Convert.ToInt32(TextBox259.Text) + Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text)
           + Convert.ToInt32(TextBox263.Text) + Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text));

        TextBox248.Text = Convert.ToString(Convert.ToInt32(TextBox249.Text) + Convert.ToInt32(TextBox258.Text));
        TextBox1074.Focus();
    }
    protected void TextBox276_TextChanged(object sender, EventArgs e)
    {
        TextBox268.Text = Convert.ToString(Convert.ToInt32(TextBox269.Text) + Convert.ToInt32(TextBox270.Text) + Convert.ToInt32(TextBox271.Text) + Convert.ToInt32(TextBox272.Text)
           + Convert.ToInt32(TextBox273.Text) + Convert.ToInt32(TextBox274.Text) + Convert.ToInt32(TextBox275.Text) + Convert.ToInt32(TextBox276.Text));
        TextBox278.Focus();
       
    }
    protected void TextBox285_TextChanged(object sender, EventArgs e)
    {
        TextBox277.Text = Convert.ToString(Convert.ToInt32(TextBox278.Text) + Convert.ToInt32(TextBox279.Text) + Convert.ToInt32(TextBox280.Text) + Convert.ToInt32(TextBox281.Text)
           + Convert.ToInt32(TextBox282.Text) + Convert.ToInt32(TextBox283.Text) + Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text));
        TextBox267.Text = Convert.ToString(Convert.ToInt32(TextBox268.Text) + Convert.ToInt32(TextBox277.Text));
        TextBox288.Focus();
    }
    protected void TextBox295_TextChanged(object sender, EventArgs e)
    {
        TextBox287.Text = Convert.ToString(Convert.ToInt32(TextBox288.Text) + Convert.ToInt32(TextBox289.Text) + Convert.ToInt32(TextBox290.Text) + Convert.ToInt32(TextBox291.Text)
           + Convert.ToInt32(TextBox292.Text) + Convert.ToInt32(TextBox293.Text) + Convert.ToInt32(TextBox294.Text) + Convert.ToInt32(TextBox295.Text));
        TextBox297.Focus();
    }
    protected void TextBox304_TextChanged(object sender, EventArgs e)
    {
        TextBox296.Text = Convert.ToString(Convert.ToInt32(TextBox297.Text) + Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text) + Convert.ToInt32(TextBox300.Text)
           + Convert.ToInt32(TextBox301.Text) + Convert.ToInt32(TextBox302.Text) + Convert.ToInt32(TextBox303.Text) + Convert.ToInt32(TextBox304.Text));
        TextBox286.Text = Convert.ToString(Convert.ToInt32(TextBox287.Text) + Convert.ToInt32(TextBox296.Text));
        TextBox305.Focus();
    }
    protected void TextBox308_TextChanged(object sender, EventArgs e)
    {
        TextBox312.Focus();
    }
    protected void TextBox319_TextChanged(object sender, EventArgs e)
    {
        TextBox311.Text = Convert.ToString(Convert.ToInt32(TextBox312.Text) + Convert.ToInt32(TextBox313.Text) + Convert.ToInt32(TextBox314.Text) + Convert.ToInt32(TextBox315.Text)
          + Convert.ToInt32(TextBox316.Text) + Convert.ToInt32(TextBox317.Text) + Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox319.Text));
        TextBox321.Focus();
    }
    protected void TextBox328_TextChanged(object sender, EventArgs e)
    {
        TextBox320.Text = Convert.ToString(Convert.ToInt32(TextBox321.Text) + Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text) + Convert.ToInt32(TextBox324.Text)
           + Convert.ToInt32(TextBox325.Text) + Convert.ToInt32(TextBox326.Text) + Convert.ToInt32(TextBox327.Text) + Convert.ToInt32(TextBox328.Text));
        TextBox310.Text = Convert.ToString(Convert.ToInt32(TextBox311.Text) + Convert.ToInt32(TextBox320.Text));
        TextBox331.Focus();
    }
    protected void TextBox338_TextChanged(object sender, EventArgs e)
    {
        TextBox330.Text = Convert.ToString(Convert.ToInt32(TextBox331.Text) + Convert.ToInt32(TextBox332.Text) + Convert.ToInt32(TextBox333.Text) + Convert.ToInt32(TextBox334.Text)
          + Convert.ToInt32(TextBox335.Text) + Convert.ToInt32(TextBox336.Text) + Convert.ToInt32(TextBox337.Text) + Convert.ToInt32(TextBox338.Text));
        TextBox340.Focus();
    }
    protected void TextBox347_TextChanged(object sender, EventArgs e)
    {
        TextBox339.Text = Convert.ToString(Convert.ToInt32(TextBox340.Text) + Convert.ToInt32(TextBox341.Text) + Convert.ToInt32(TextBox342.Text) + Convert.ToInt32(TextBox343.Text)
         + Convert.ToInt32(TextBox344.Text) + Convert.ToInt32(TextBox345.Text) + Convert.ToInt32(TextBox346.Text) + Convert.ToInt32(TextBox347.Text));
        TextBox329.Text = Convert.ToString(Convert.ToInt32(TextBox330.Text) + Convert.ToInt32(TextBox339.Text));
        TextBox350.Focus();
    }
    protected void TextBox357_TextChanged(object sender, EventArgs e)
    {
        TextBox349.Text = Convert.ToString(Convert.ToInt32(TextBox350.Text) + Convert.ToInt32(TextBox351.Text) + Convert.ToInt32(TextBox352.Text) + Convert.ToInt32(TextBox353.Text)
          + Convert.ToInt32(TextBox354.Text) + Convert.ToInt32(TextBox355.Text) + Convert.ToInt32(TextBox356.Text) + Convert.ToInt32(TextBox357.Text));
        TextBox359.Focus();
    }
    protected void TextBox366_TextChanged(object sender, EventArgs e)
    {
        TextBox358.Text = Convert.ToString(Convert.ToInt32(TextBox359.Text) + Convert.ToInt32(TextBox360.Text) + Convert.ToInt32(TextBox361.Text) + Convert.ToInt32(TextBox362.Text)
        + Convert.ToInt32(TextBox363.Text) + Convert.ToInt32(TextBox364.Text) + Convert.ToInt32(TextBox365.Text) + Convert.ToInt32(TextBox366.Text));
        TextBox348.Text = Convert.ToString(Convert.ToInt32(TextBox349.Text) + Convert.ToInt32(TextBox358.Text));
        TextBox369.Focus();
    }
    protected void TextBox376_TextChanged(object sender, EventArgs e)
    {
        TextBox368.Text = Convert.ToString(Convert.ToInt32(TextBox369.Text) + Convert.ToInt32(TextBox370.Text) + Convert.ToInt32(TextBox371.Text) + Convert.ToInt32(TextBox372.Text)
          + Convert.ToInt32(TextBox373.Text) + Convert.ToInt32(TextBox374.Text) + Convert.ToInt32(TextBox375.Text) + Convert.ToInt32(TextBox376.Text));
        TextBox378.Focus();
    }
    protected void TextBox385_TextChanged(object sender, EventArgs e)
    {
        TextBox377.Text = Convert.ToString(Convert.ToInt32(TextBox378.Text) + Convert.ToInt32(TextBox379.Text) + Convert.ToInt32(TextBox380.Text) + Convert.ToInt32(TextBox381.Text)
        + Convert.ToInt32(TextBox382.Text) + Convert.ToInt32(TextBox383.Text) + Convert.ToInt32(TextBox384.Text) + Convert.ToInt32(TextBox385.Text));
        TextBox367.Text = Convert.ToString(Convert.ToInt32(TextBox368.Text) + Convert.ToInt32(TextBox377.Text));
        TextBox388.Focus();
    }
    protected void TextBox395_TextChanged(object sender, EventArgs e)
    {
        TextBox387.Text = Convert.ToString(Convert.ToInt32(TextBox388.Text) + Convert.ToInt32(TextBox389.Text) + Convert.ToInt32(TextBox390.Text) + Convert.ToInt32(TextBox391.Text)
        + Convert.ToInt32(TextBox392.Text) + Convert.ToInt32(TextBox393.Text) + Convert.ToInt32(TextBox394.Text) + Convert.ToInt32(TextBox395.Text));
        TextBox397.Focus();
    }
    protected void TextBox404_TextChanged(object sender, EventArgs e)
    {
        TextBox396.Text = Convert.ToString(Convert.ToInt32(TextBox397.Text) + Convert.ToInt32(TextBox398.Text) + Convert.ToInt32(TextBox399.Text) + Convert.ToInt32(TextBox400.Text)
        + Convert.ToInt32(TextBox401.Text) + Convert.ToInt32(TextBox402.Text) + Convert.ToInt32(TextBox403.Text) + Convert.ToInt32(TextBox404.Text));
        TextBox386.Text = Convert.ToString(Convert.ToInt32(TextBox387.Text) + Convert.ToInt32(TextBox396.Text));
        TextBox407.Focus();
    }
    protected void TextBox414_TextChanged(object sender, EventArgs e)
    {
        TextBox406.Text = Convert.ToString(Convert.ToInt32(TextBox407.Text) + Convert.ToInt32(TextBox408.Text) + Convert.ToInt32(TextBox409.Text) + Convert.ToInt32(TextBox410.Text)
        + Convert.ToInt32(TextBox411.Text) + Convert.ToInt32(TextBox412.Text) + Convert.ToInt32(TextBox413.Text) + Convert.ToInt32(TextBox414.Text));
        TextBox416.Focus();
    }
    protected void TextBox423_TextChanged(object sender, EventArgs e)
    {
        TextBox415.Text = Convert.ToString(Convert.ToInt32(TextBox416.Text) + Convert.ToInt32(TextBox417.Text) + Convert.ToInt32(TextBox418.Text) + Convert.ToInt32(TextBox419.Text)
       + Convert.ToInt32(TextBox420.Text) + Convert.ToInt32(TextBox421.Text) + Convert.ToInt32(TextBox422.Text) + Convert.ToInt32(TextBox423.Text));
        TextBox405.Text = Convert.ToString(Convert.ToInt32(TextBox406.Text) + Convert.ToInt32(TextBox415.Text));
        TextBox426.Focus();
    }
    protected void TextBox433_TextChanged(object sender, EventArgs e)
    {
        TextBox425.Text = Convert.ToString(Convert.ToInt32(TextBox426.Text) + Convert.ToInt32(TextBox427.Text) + Convert.ToInt32(TextBox428.Text) + Convert.ToInt32(TextBox429.Text)
       + Convert.ToInt32(TextBox430.Text) + Convert.ToInt32(TextBox431.Text) + Convert.ToInt32(TextBox432.Text) + Convert.ToInt32(TextBox433.Text));
        TextBox435.Focus();
    }
    protected void TextBox442_TextChanged(object sender, EventArgs e)
    {
        TextBox434.Text = Convert.ToString(Convert.ToInt32(TextBox435.Text) + Convert.ToInt32(TextBox436.Text) + Convert.ToInt32(TextBox437.Text) + Convert.ToInt32(TextBox438.Text)
       + Convert.ToInt32(TextBox439.Text) + Convert.ToInt32(TextBox440.Text) + Convert.ToInt32(TextBox441.Text) + Convert.ToInt32(TextBox442.Text));
        TextBox424.Text = Convert.ToString(Convert.ToInt32(TextBox425.Text) + Convert.ToInt32(TextBox434.Text));
        TextBox443.Focus();
    }
    protected void TextBox446_TextChanged(object sender, EventArgs e)
    {
        TextBox449.Focus();
    }
    protected void TextBox456_TextChanged(object sender, EventArgs e)
    {
        TextBox448.Text = Convert.ToString(Convert.ToInt32(TextBox449.Text) + Convert.ToInt32(TextBox450.Text) + Convert.ToInt32(TextBox451.Text) + Convert.ToInt32(TextBox452.Text)
    + Convert.ToInt32(TextBox453.Text) + Convert.ToInt32(TextBox454.Text) + Convert.ToInt32(TextBox455.Text) + Convert.ToInt32(TextBox456.Text));
        TextBox458.Focus();
    }
    protected void TextBox465_TextChanged(object sender, EventArgs e)
    {
        TextBox457.Text = Convert.ToString(Convert.ToInt32(TextBox458.Text) + Convert.ToInt32(TextBox459.Text) + Convert.ToInt32(TextBox460.Text) + Convert.ToInt32(TextBox461.Text)
      + Convert.ToInt32(TextBox462.Text) + Convert.ToInt32(TextBox463.Text) + Convert.ToInt32(TextBox464.Text) + Convert.ToInt32(TextBox465.Text));
        TextBox447.Text = Convert.ToString(Convert.ToInt32(TextBox448.Text) + Convert.ToInt32(TextBox457.Text));
        TextBox466.Focus();
    }
    protected void TextBox469_TextChanged(object sender, EventArgs e)
    {
        TextBox472.Focus();
    }
    protected void TextBox479_TextChanged(object sender, EventArgs e)
    {
        TextBox471.Text = Convert.ToString(Convert.ToInt32(TextBox472.Text) + Convert.ToInt32(TextBox473.Text) + Convert.ToInt32(TextBox474.Text) + Convert.ToInt32(TextBox475.Text)
  + Convert.ToInt32(TextBox476.Text) + Convert.ToInt32(TextBox477.Text) + Convert.ToInt32(TextBox478.Text) + Convert.ToInt32(TextBox479.Text));
        TextBox481.Focus();
    }
    protected void TextBox488_TextChanged(object sender, EventArgs e)
    {
        TextBox480.Text = Convert.ToString(Convert.ToInt32(TextBox481.Text) + Convert.ToInt32(TextBox482.Text) + Convert.ToInt32(TextBox483.Text) + Convert.ToInt32(TextBox484.Text)
     + Convert.ToInt32(TextBox485.Text) + Convert.ToInt32(TextBox486.Text) + Convert.ToInt32(TextBox487.Text) + Convert.ToInt32(TextBox488.Text));
        TextBox470.Text = Convert.ToString(Convert.ToInt32(TextBox471.Text) + Convert.ToInt32(TextBox480.Text));
        TextBox489.Focus();
    }
    protected void TextBox490_TextChanged(object sender, EventArgs e)
    {
        TextBox493.Focus();
    }
    protected void TextBox500_TextChanged(object sender, EventArgs e)
    {
        TextBox492.Text = Convert.ToString(Convert.ToInt32(TextBox493.Text) + Convert.ToInt32(TextBox494.Text) + Convert.ToInt32(TextBox495.Text) + Convert.ToInt32(TextBox496.Text)
                    + Convert.ToInt32(TextBox497.Text) + Convert.ToInt32(TextBox498.Text) + Convert.ToInt32(TextBox499.Text) + Convert.ToInt32(TextBox500.Text));
        TextBox502.Focus();
    }
    protected void TextBox509_TextChanged(object sender, EventArgs e)
    {
        TextBox501.Text = Convert.ToString(Convert.ToInt32(TextBox502.Text) + Convert.ToInt32(TextBox503.Text) + Convert.ToInt32(TextBox504.Text) + Convert.ToInt32(TextBox505.Text)
  + Convert.ToInt32(TextBox506.Text) + Convert.ToInt32(TextBox507.Text) + Convert.ToInt32(TextBox508.Text) + Convert.ToInt32(TextBox509.Text));
        TextBox491.Text = Convert.ToString(Convert.ToInt32(TextBox492.Text) + Convert.ToInt32(TextBox501.Text));
        TextBox510.Focus();
    }
    protected void TextBox511_TextChanged(object sender, EventArgs e)
    {
        TextBox514.Focus();
    }
    protected void TextBox521_TextChanged(object sender, EventArgs e)
    {
        TextBox513.Text = Convert.ToString(Convert.ToInt32(TextBox514.Text) + Convert.ToInt32(TextBox515.Text) + Convert.ToInt32(TextBox516.Text) + Convert.ToInt32(TextBox517.Text)
                    + Convert.ToInt32(TextBox518.Text) + Convert.ToInt32(TextBox519.Text) + Convert.ToInt32(TextBox520.Text) + Convert.ToInt32(TextBox521.Text));
        TextBox523.Focus();
    }
    protected void TextBox530_TextChanged(object sender, EventArgs e)
    {
        TextBox522.Text = Convert.ToString(Convert.ToInt32(TextBox523.Text) + Convert.ToInt32(TextBox524.Text) + Convert.ToInt32(TextBox525.Text) + Convert.ToInt32(TextBox526.Text)
                            + Convert.ToInt32(TextBox527.Text) + Convert.ToInt32(TextBox528.Text) + Convert.ToInt32(TextBox529.Text) + Convert.ToInt32(TextBox530.Text));
        TextBox512.Text = Convert.ToString(Convert.ToInt32(TextBox513.Text) + Convert.ToInt32(TextBox522.Text));
        TextBox531.Focus();
    }
    protected void TextBox532_TextChanged(object sender, EventArgs e)
    {
        TextBox535.Focus();
    }
    protected void TextBox542_TextChanged(object sender, EventArgs e)
    {
        TextBox534.Text = Convert.ToString(Convert.ToInt32(TextBox535.Text) + Convert.ToInt32(TextBox536.Text) + Convert.ToInt32(TextBox537.Text) + Convert.ToInt32(TextBox538.Text)
                   + Convert.ToInt32(TextBox539.Text) + Convert.ToInt32(TextBox540.Text) + Convert.ToInt32(TextBox541.Text) + Convert.ToInt32(TextBox542.Text));
        TextBox544.Focus();
    }
    protected void TextBox551_TextChanged(object sender, EventArgs e)
    {
        TextBox543.Text = Convert.ToString(Convert.ToInt32(TextBox544.Text) + Convert.ToInt32(TextBox545.Text) + Convert.ToInt32(TextBox546.Text) + Convert.ToInt32(TextBox547.Text)
                           + Convert.ToInt32(TextBox548.Text) + Convert.ToInt32(TextBox549.Text) + Convert.ToInt32(TextBox550.Text) + Convert.ToInt32(TextBox551.Text));
        TextBox533.Text = Convert.ToString(Convert.ToInt32(TextBox534.Text) + Convert.ToInt32(TextBox543.Text));
        TextBox552.Focus();
    }
    protected void TextBox553_TextChanged(object sender, EventArgs e)
    {
        TextBox556.Focus();
    }
    protected void TextBox563_TextChanged(object sender, EventArgs e)
    {
        TextBox555.Text = Convert.ToString(Convert.ToInt32(TextBox556.Text) + Convert.ToInt32(TextBox557.Text) + Convert.ToInt32(TextBox558.Text) + Convert.ToInt32(TextBox559.Text)
                   + Convert.ToInt32(TextBox560.Text) + Convert.ToInt32(TextBox561.Text) + Convert.ToInt32(TextBox562.Text) + Convert.ToInt32(TextBox563.Text));
        TextBox565.Focus();
    }
    protected void TextBox572_TextChanged(object sender, EventArgs e)
    {
        TextBox564.Text = Convert.ToString(Convert.ToInt32(TextBox565.Text) + Convert.ToInt32(TextBox566.Text) + Convert.ToInt32(TextBox567.Text) + Convert.ToInt32(TextBox568.Text)
                           + Convert.ToInt32(TextBox569.Text) + Convert.ToInt32(TextBox570.Text) + Convert.ToInt32(TextBox571.Text) + Convert.ToInt32(TextBox572.Text));
        TextBox554.Text = Convert.ToString(Convert.ToInt32(TextBox555.Text) + Convert.ToInt32(TextBox564.Text));
        TextBox575.Focus();
    }
    protected void TextBox582_TextChanged(object sender, EventArgs e)
    {
        TextBox574.Text = Convert.ToString(Convert.ToInt32(TextBox575.Text) + Convert.ToInt32(TextBox576.Text) + Convert.ToInt32(TextBox577.Text) + Convert.ToInt32(TextBox578.Text)
                  + Convert.ToInt32(TextBox579.Text) + Convert.ToInt32(TextBox580.Text) + Convert.ToInt32(TextBox581.Text) + Convert.ToInt32(TextBox582.Text));
        TextBox584.Focus();
    }
    protected void TextBox591_TextChanged(object sender, EventArgs e)
    {
        TextBox583.Text = Convert.ToString(Convert.ToInt32(TextBox584.Text) + Convert.ToInt32(TextBox585.Text) + Convert.ToInt32(TextBox586.Text) + Convert.ToInt32(TextBox587.Text)
                           + Convert.ToInt32(TextBox588.Text) + Convert.ToInt32(TextBox589.Text) + Convert.ToInt32(TextBox590.Text) + Convert.ToInt32(TextBox591.Text));
        TextBox573.Text = Convert.ToString(Convert.ToInt32(TextBox574.Text) + Convert.ToInt32(TextBox583.Text));
        TextBox594.Focus();
    }
    protected void TextBox601_TextChanged(object sender, EventArgs e)
    {
        TextBox593.Text = Convert.ToString(Convert.ToInt32(TextBox594.Text) + Convert.ToInt32(TextBox595.Text) + Convert.ToInt32(TextBox596.Text) + Convert.ToInt32(TextBox597.Text)
                  + Convert.ToInt32(TextBox598.Text) + Convert.ToInt32(TextBox599.Text) + Convert.ToInt32(TextBox600.Text) + Convert.ToInt32(TextBox601.Text));
        TextBox603.Focus();
    }
    protected void TextBox610_TextChanged(object sender, EventArgs e)
    {
        TextBox602.Text = Convert.ToString(Convert.ToInt32(TextBox603.Text) + Convert.ToInt32(TextBox604.Text) + Convert.ToInt32(TextBox605.Text) + Convert.ToInt32(TextBox606.Text)
                           + Convert.ToInt32(TextBox607.Text) + Convert.ToInt32(TextBox608.Text) + Convert.ToInt32(TextBox609.Text) + Convert.ToInt32(TextBox610.Text));
        TextBox592.Text = Convert.ToString(Convert.ToInt32(TextBox593.Text) + Convert.ToInt32(TextBox602.Text));
        btnSave.Focus();
    }
    protected void TextBox620_TextChanged(object sender, EventArgs e)
    {
        TextBox612.Text = Convert.ToString(Convert.ToInt32(TextBox613.Text) + Convert.ToInt32(TextBox614.Text) + Convert.ToInt32(TextBox615.Text) + Convert.ToInt32(TextBox616.Text)
                  + Convert.ToInt32(TextBox617.Text) + Convert.ToInt32(TextBox618.Text) + Convert.ToInt32(TextBox619.Text) + Convert.ToInt32(TextBox620.Text));
        TextBox622.Focus();
    }
    protected void TextBox309_TextChanged(object sender, EventArgs e)
    {
        TextBox321.Focus();
    }
    protected void TextBox1073_TextChanged(object sender, EventArgs e)
    {
        TextBox288.Focus();
    }
    protected void TextBox629_TextChanged(object sender, EventArgs e)
    {
        TextBox621.Text = Convert.ToString(Convert.ToInt32(TextBox622.Text) + Convert.ToInt32(TextBox623.Text) + Convert.ToInt32(TextBox624.Text) + Convert.ToInt32(TextBox625.Text)
                          + Convert.ToInt32(TextBox626.Text) + Convert.ToInt32(TextBox627.Text) + Convert.ToInt32(TextBox628.Text) + Convert.ToInt32(TextBox629.Text));
        TextBox611.Text = Convert.ToString(Convert.ToInt32(TextBox612.Text) + Convert.ToInt32(TextBox621.Text));
        TextBox632.Focus();
    }
    protected void TextBox639_TextChanged(object sender, EventArgs e)
    {
        TextBox631.Text = Convert.ToString(Convert.ToInt32(TextBox632.Text) + Convert.ToInt32(TextBox633.Text) + Convert.ToInt32(TextBox634.Text) + Convert.ToInt32(TextBox635.Text)
                 + Convert.ToInt32(TextBox636.Text) + Convert.ToInt32(TextBox637.Text) + Convert.ToInt32(TextBox638.Text) + Convert.ToInt32(TextBox639.Text));
        TextBox641.Focus();
    }
    protected void TextBox648_TextChanged(object sender, EventArgs e)
    {
        TextBox640.Text = Convert.ToString(Convert.ToInt32(TextBox641.Text) + Convert.ToInt32(TextBox642.Text) + Convert.ToInt32(TextBox643.Text) + Convert.ToInt32(TextBox644.Text)
                          + Convert.ToInt32(TextBox645.Text) + Convert.ToInt32(TextBox646.Text) + Convert.ToInt32(TextBox647.Text) + Convert.ToInt32(TextBox648.Text));
        TextBox630.Text = Convert.ToString(Convert.ToInt32(TextBox631.Text) + Convert.ToInt32(TextBox640.Text));
        TextBox651.Focus();
    }
    //protected void TextBox658_TextChanged(object sender, EventArgs e)
    //{
    //    try{
    //    //======== MALE
    //    TextBox650.Text = Convert.ToString(Convert.ToInt32(TextBox651.Text) + Convert.ToInt32(TextBox652.Text) + Convert.ToInt32(TextBox653.Text) + Convert.ToInt32(TextBox654.Text)
    //            + Convert.ToInt32(TextBox655.Text) + Convert.ToInt32(TextBox656.Text) + Convert.ToInt32(TextBox657.Text) + Convert.ToInt32(TextBox658.Text));
       
    //    if(TextBox797.Text!="")
    //    {
    //        TextBox797.Text = Convert.ToString(Convert.ToInt32(TextBox651.Text) + Convert.ToInt32(TextBox797.Text));
    //    }
    //    else 
    //    {
    //        TextBox797.Text = TextBox651.Text;
    //    }
    //    if (TextBox798.Text != "")
    //    {
    //        TextBox798.Text = Convert.ToString(Convert.ToInt32(TextBox652.Text) + Convert.ToInt32(TextBox798.Text));
    //    }
    //    else { TextBox798.Text = TextBox652.Text; }
    //    if (TextBox799.Text != "")
    //    {
    //        TextBox799.Text = Convert.ToString(Convert.ToInt32(TextBox653.Text) + Convert.ToInt32(TextBox799.Text));
    //    }
    //    else { TextBox799.Text = TextBox653.Text; }
    //    if (TextBox800.Text != "")
    //    {
    //        TextBox800.Text = Convert.ToString(Convert.ToInt32(TextBox654.Text) + Convert.ToInt32(TextBox800.Text));
    //    }
    //    else { TextBox800.Text = TextBox654.Text; }
    //    if (TextBox801.Text != "")
    //    {
    //        TextBox801.Text = Convert.ToString(Convert.ToInt32(TextBox655.Text) + Convert.ToInt32(TextBox801.Text));
    //    }
    //    else { TextBox801.Text = TextBox655.Text; }
    //    if (TextBox802.Text != "")
    //    {
    //        TextBox802.Text = Convert.ToString(Convert.ToInt32(TextBox656.Text) + Convert.ToInt32(TextBox802.Text));
    //    }
    //    else { TextBox802.Text = TextBox656.Text; }
    //    if (TextBox803.Text != "")
    //    {
    //        TextBox803.Text = Convert.ToString(Convert.ToInt32(TextBox657.Text) + Convert.ToInt32(TextBox803.Text));
    //    }
    //    else { TextBox803.Text = TextBox657.Text; }
    //    if (TextBox804.Text != "")
    //    {
    //        TextBox804.Text = Convert.ToString(Convert.ToInt32(TextBox658.Text) + Convert.ToInt32(TextBox804.Text));
    //    }
    //    else { TextBox804.Text = TextBox658.Text; }
    //    if (TextBox797.Text != "" && TextBox798.Text != "" && TextBox799.Text != "" && TextBox800.Text != "" && TextBox801.Text != "" && TextBox802.Text != "" && TextBox803.Text != "" && TextBox804.Text != "")
    //    {
    //            TextBox796.Text = Convert.ToString(Convert.ToInt32(TextBox797.Text) + Convert.ToInt32(TextBox798.Text) + Convert.ToInt32(TextBox799.Text) + Convert.ToInt32(TextBox800.Text)
    //                           + Convert.ToInt32(TextBox801.Text) + Convert.ToInt32(TextBox802.Text) + Convert.ToInt32(TextBox803.Text) + Convert.ToInt32(TextBox804.Text));
    //        }
    //    TextBox660.Focus();
    // }catch(Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    //protected void TextBox667_TextChanged(object sender, EventArgs e)
    //{
    //    try{
    //    TextBox659.Text = Convert.ToString(Convert.ToInt32(TextBox660.Text) + Convert.ToInt32(TextBox661.Text) + Convert.ToInt32(TextBox662.Text) + Convert.ToInt32(TextBox663.Text)
    //                      + Convert.ToInt32(TextBox664.Text) + Convert.ToInt32(TextBox665.Text) + Convert.ToInt32(TextBox666.Text) + Convert.ToInt32(TextBox667.Text));
    //    TextBox649.Text = Convert.ToString(Convert.ToInt32(TextBox650.Text) + Convert.ToInt32(TextBox659.Text));

    //    if (TextBox806.Text != "")
    //    {
    //        TextBox806.Text = Convert.ToString(Convert.ToInt32(TextBox660.Text) + Convert.ToInt32(TextBox806.Text));
    //    }
    //    else { TextBox806.Text = TextBox660.Text; }
    //    if (TextBox807.Text != "")
    //    {
    //        TextBox807.Text = Convert.ToString(Convert.ToInt32(TextBox661.Text) + Convert.ToInt32(TextBox807.Text));
    //    }
    //    else { TextBox807.Text = TextBox661.Text; }
    //    if (TextBox808.Text != "")
    //    {
    //        TextBox808.Text = Convert.ToString(Convert.ToInt32(TextBox662.Text) + Convert.ToInt32(TextBox808.Text));
    //    }
    //    else { TextBox808.Text = TextBox662.Text; }
    //    if (TextBox809.Text != "")
    //    {
    //        TextBox809.Text = Convert.ToString(Convert.ToInt32(TextBox663.Text) + Convert.ToInt32(TextBox809.Text));
    //    }
    //    else { TextBox809.Text = TextBox663.Text; }
    //    if (TextBox810.Text != "")
    //    {
    //        TextBox810.Text = Convert.ToString(Convert.ToInt32(TextBox664.Text) + Convert.ToInt32(TextBox810.Text));
    //    }
    //    else { TextBox810.Text = TextBox664.Text; }
    //    if (TextBox811.Text != "")
    //    {
    //        TextBox811.Text = Convert.ToString(Convert.ToInt32(TextBox665.Text) + Convert.ToInt32(TextBox811.Text));
    //    }
    //    else { TextBox811.Text = TextBox665.Text; }
    //    if (TextBox812.Text != "")
    //    {
    //        TextBox812.Text = Convert.ToString(Convert.ToInt32(TextBox666.Text) + Convert.ToInt32(TextBox812.Text));
    //    }
    //    else { TextBox812.Text = TextBox666.Text; }
    //    if (TextBox813.Text != "")
    //    {
    //        TextBox813.Text = Convert.ToString(Convert.ToInt32(TextBox667.Text) + Convert.ToInt32(TextBox813.Text));
    //    }
    //    else { TextBox813.Text = TextBox667.Text; }
    //    if (TextBox806.Text !="" && TextBox807.Text !="" && TextBox808.Text !="" && TextBox809.Text !="" && TextBox810.Text !="" && TextBox811.Text !=""&& TextBox812.Text !="" && TextBox813.Text !="")
    //    {
    //    TextBox805.Text = Convert.ToString(Convert.ToInt32(TextBox806.Text) + Convert.ToInt32(TextBox807.Text) + Convert.ToInt32(TextBox808.Text) + Convert.ToInt32(TextBox809.Text)
    //                 + Convert.ToInt32(TextBox810.Text) + Convert.ToInt32(TextBox811.Text) + Convert.ToInt32(TextBox812.Text) + Convert.ToInt32(TextBox813.Text));
    //    TextBox795.Text = Convert.ToString(Convert.ToInt32(TextBox796.Text) + Convert.ToInt32(TextBox805.Text));
    //    }
           
    //        TextBox670.Focus();
    //    }catch(Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    //protected void TextBox677_TextChanged(object sender, EventArgs e)
    //{
    //    //=========== POSITIVE
    //    try
    //    {
    //        TextBox669.Text = Convert.ToString(Convert.ToInt32(TextBox670.Text) + Convert.ToInt32(TextBox671.Text) + Convert.ToInt32(TextBox672.Text) + Convert.ToInt32(TextBox673.Text)
    //                 + Convert.ToInt32(TextBox674.Text) + Convert.ToInt32(TextBox675.Text) + Convert.ToInt32(TextBox676.Text) + Convert.ToInt32(TextBox677.Text));

    //        if (TextBox816.Text != "")
    //        {
    //            TextBox816.Text = Convert.ToString(Convert.ToInt32(TextBox670.Text) + Convert.ToInt32(TextBox816.Text));
    //        }
    //        else { TextBox816.Text = TextBox670.Text; }
    //        if (TextBox817.Text != "")
    //        {
    //            TextBox817.Text = Convert.ToString(Convert.ToInt32(TextBox671.Text) + Convert.ToInt32(TextBox817.Text));
    //        }
    //        else { TextBox817.Text = TextBox671.Text; }
    //        if (TextBox818.Text != "")
    //        {
    //            TextBox818.Text = Convert.ToString(Convert.ToInt32(TextBox672.Text) + Convert.ToInt32(TextBox818.Text));
    //        }
    //        else { TextBox818.Text = TextBox672.Text; }
    //        if (TextBox819.Text != "")
    //        {
    //            TextBox819.Text = Convert.ToString(Convert.ToInt32(TextBox673.Text) + Convert.ToInt32(TextBox819.Text));
    //        }
    //        else { TextBox819.Text = TextBox673.Text; }
    //        if (TextBox820.Text != "")
    //        {
    //            TextBox820.Text = Convert.ToString(Convert.ToInt32(TextBox674.Text) + Convert.ToInt32(TextBox820.Text));
    //        }
    //        else { TextBox820.Text = TextBox674.Text; }
    //        if (TextBox821.Text != "")
    //        {
    //            TextBox821.Text = Convert.ToString(Convert.ToInt32(TextBox675.Text) + Convert.ToInt32(TextBox821.Text));
    //        }
    //        else { TextBox821.Text = TextBox675.Text; }
    //        if (TextBox822.Text != "")
    //        {
    //            TextBox822.Text = Convert.ToString(Convert.ToInt32(TextBox676.Text) + Convert.ToInt32(TextBox822.Text));
    //        }
    //        else { TextBox822.Text = TextBox676.Text; }
    //        if (TextBox823.Text != "")
    //        {
    //            TextBox823.Text = Convert.ToString(Convert.ToInt32(TextBox677.Text) + Convert.ToInt32(TextBox823.Text));
    //        }
    //        else { TextBox823.Text = TextBox677.Text; }
    //        if (TextBox816.Text != "" && TextBox817.Text != "" && TextBox818.Text != "" && TextBox819.Text != "" && TextBox820.Text != "" && TextBox821.Text != "" && TextBox822.Text != "" && TextBox823.Text != "")
    //        {
    //            TextBox815.Text = Convert.ToString(Convert.ToInt32(TextBox816.Text) + Convert.ToInt32(TextBox817.Text) + Convert.ToInt32(TextBox818.Text) + Convert.ToInt32(TextBox819.Text)
    //                    + Convert.ToInt32(TextBox820.Text) + Convert.ToInt32(TextBox821.Text) + Convert.ToInt32(TextBox822.Text) + Convert.ToInt32(TextBox823.Text));
    //        }
    //            TextBox679.Focus();
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
       
    //}
    //protected void TextBox686_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        TextBox678.Text = Convert.ToString(Convert.ToInt32(TextBox679.Text) + Convert.ToInt32(TextBox680.Text) + Convert.ToInt32(TextBox681.Text) + Convert.ToInt32(TextBox682.Text)
    //                          + Convert.ToInt32(TextBox683.Text) + Convert.ToInt32(TextBox684.Text) + Convert.ToInt32(TextBox685.Text) + Convert.ToInt32(TextBox686.Text));
    //        TextBox668.Text = Convert.ToString(Convert.ToInt32(TextBox669.Text) + Convert.ToInt32(TextBox678.Text));

    //        if (TextBox825.Text != "")
    //        {
    //            TextBox825.Text = Convert.ToString(Convert.ToInt32(TextBox679.Text) + Convert.ToInt32(TextBox825.Text));
    //        }
    //        else { TextBox825.Text = TextBox679.Text; }
    //        if (TextBox826.Text != "")
    //        {
    //            TextBox826.Text = Convert.ToString(Convert.ToInt32(TextBox680.Text) + Convert.ToInt32(TextBox826.Text));
    //        }
    //        else { TextBox826.Text = TextBox680.Text; }
    //        if (TextBox827.Text != "")
    //        {
    //            TextBox827.Text = Convert.ToString(Convert.ToInt32(TextBox681.Text) + Convert.ToInt32(TextBox827.Text));
    //        }
    //        else { TextBox827.Text = TextBox681.Text; }
    //        if (TextBox828.Text != "")
    //        {
    //            TextBox828.Text = Convert.ToString(Convert.ToInt32(TextBox682.Text) + Convert.ToInt32(TextBox828.Text));
    //        }
    //        else { TextBox828.Text = TextBox682.Text; }
    //        if (TextBox829.Text != "")
    //        {
    //            TextBox829.Text = Convert.ToString(Convert.ToInt32(TextBox683.Text) + Convert.ToInt32(TextBox829.Text));
    //        }
    //        else { TextBox829.Text = TextBox683.Text; }
    //        if (TextBox830.Text != "")
    //        {
    //            TextBox830.Text = Convert.ToString(Convert.ToInt32(TextBox684.Text) + Convert.ToInt32(TextBox830.Text));
    //        }
    //        else { TextBox830.Text = TextBox684.Text; }
    //        if (TextBox831.Text != "")
    //        {
    //            TextBox831.Text = Convert.ToString(Convert.ToInt32(TextBox685.Text) + Convert.ToInt32(TextBox831.Text));
    //        }
    //        else { TextBox831.Text = TextBox685.Text; }
    //        if (TextBox832.Text != "")
    //        {
    //            TextBox832.Text = Convert.ToString(Convert.ToInt32(TextBox686.Text) + Convert.ToInt32(TextBox832.Text));
    //        }
    //        else { TextBox832.Text = TextBox686.Text; }
    //        if (TextBox825.Text != "" && TextBox826.Text != "" && TextBox827.Text != "" && TextBox828.Text != "" && TextBox829.Text != "" && TextBox830.Text != "" && TextBox831.Text != "" && TextBox832.Text != "")
    //        {
    //            TextBox824.Text = Convert.ToString(Convert.ToInt32(TextBox825.Text) + Convert.ToInt32(TextBox826.Text) + Convert.ToInt32(TextBox827.Text) + Convert.ToInt32(TextBox828.Text)
    //                        + Convert.ToInt32(TextBox829.Text) + Convert.ToInt32(TextBox830.Text) + Convert.ToInt32(TextBox831.Text) + Convert.ToInt32(TextBox832.Text));
    //            TextBox814.Text = Convert.ToString(Convert.ToInt32(TextBox815.Text) + Convert.ToInt32(TextBox824.Text));
    //        }
    //         TextBox689.Focus();
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    //protected void TextBox696_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        TextBox688.Text = Convert.ToString(Convert.ToInt32(TextBox689.Text) + Convert.ToInt32(TextBox690.Text) + Convert.ToInt32(TextBox691.Text) + Convert.ToInt32(TextBox692.Text)
    //          + Convert.ToInt32(TextBox693.Text) + Convert.ToInt32(TextBox694.Text) + Convert.ToInt32(TextBox695.Text) + Convert.ToInt32(TextBox696.Text));
    //        if (TextBox835.Text != "")
    //        {
    //            TextBox835.Text = Convert.ToString(Convert.ToInt32(TextBox689.Text) + Convert.ToInt32(TextBox835.Text));
    //        }
    //        else { TextBox835.Text = TextBox689.Text; }
    //        if (TextBox836.Text != "")
    //        {
    //            TextBox836.Text = Convert.ToString(Convert.ToInt32(TextBox690.Text) + Convert.ToInt32(TextBox836.Text));
    //        }
    //        else { TextBox836.Text = TextBox690.Text; }
    //        if (TextBox837.Text != "")
    //        {
    //            TextBox837.Text = Convert.ToString(Convert.ToInt32(TextBox691.Text) + Convert.ToInt32(TextBox837.Text));
    //        }
    //        else { TextBox837.Text = TextBox691.Text; }
    //        if (TextBox838.Text != "")
    //        {
    //            TextBox838.Text = Convert.ToString(Convert.ToInt32(TextBox692.Text) + Convert.ToInt32(TextBox838.Text));
    //        }
    //        else { TextBox838.Text = TextBox692.Text; }
    //        if (TextBox839.Text != "")
    //        {
    //            TextBox839.Text = Convert.ToString(Convert.ToInt32(TextBox693.Text) + Convert.ToInt32(TextBox839.Text));
    //        }
    //        else { TextBox839.Text = TextBox693.Text; }
    //        if (TextBox840.Text != "")
    //        {
    //            TextBox840.Text = Convert.ToString(Convert.ToInt32(TextBox694.Text) + Convert.ToInt32(TextBox840.Text));
    //        }
    //        else { TextBox840.Text = TextBox694.Text; }
    //        if (TextBox841.Text != "")
    //        {
    //            TextBox841.Text = Convert.ToString(Convert.ToInt32(TextBox695.Text) + Convert.ToInt32(TextBox841.Text));
    //        }
    //        else { TextBox841.Text = TextBox695.Text; }
    //        if (TextBox842.Text != "")
    //        {
    //            TextBox842.Text = Convert.ToString(Convert.ToInt32(TextBox696.Text) + Convert.ToInt32(TextBox842.Text));
    //        }
    //        else { TextBox842.Text = TextBox696.Text; }
    //        if (TextBox835.Text != "" && TextBox836.Text != "" && TextBox837.Text != "" && TextBox838.Text != "" && TextBox839.Text != "" && TextBox840.Text != "" && TextBox841.Text != "" && TextBox842.Text != "")
    //        {
    //            TextBox834.Text = Convert.ToString(Convert.ToInt32(TextBox835.Text) + Convert.ToInt32(TextBox836.Text) + Convert.ToInt32(TextBox837.Text) + Convert.ToInt32(TextBox838.Text)
    //                        + Convert.ToInt32(TextBox839.Text) + Convert.ToInt32(TextBox840.Text) + Convert.ToInt32(TextBox841.Text) + Convert.ToInt32(TextBox842.Text));
    //        }
    //        TextBox698.Focus();
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}

    //protected void TextBox705_TextChanged(object sender, EventArgs e)
    //{
    //    try { 
    //        TextBox697.Text = Convert.ToString(Convert.ToInt32(TextBox698.Text) + Convert.ToInt32(TextBox699.Text) + Convert.ToInt32(TextBox700.Text) + Convert.ToInt32(TextBox701.Text)
    //                          + Convert.ToInt32(TextBox702.Text) + Convert.ToInt32(TextBox703.Text) + Convert.ToInt32(TextBox704.Text) + Convert.ToInt32(TextBox705.Text));
    //        TextBox687.Text = Convert.ToString(Convert.ToInt32(TextBox688.Text) + Convert.ToInt32(TextBox697.Text));

    //        if (TextBox844.Text != "")
    //        {
    //            TextBox844.Text = Convert.ToString(Convert.ToInt32(TextBox698.Text) + Convert.ToInt32(TextBox844.Text));
    //        }
    //        else { TextBox844.Text = TextBox698.Text; }
    //        if (TextBox845.Text != "")
    //        {
    //            TextBox845.Text = Convert.ToString(Convert.ToInt32(TextBox699.Text) + Convert.ToInt32(TextBox845.Text));
    //        }
    //        else { TextBox845.Text = TextBox699.Text; }
    //        if (TextBox846.Text != "")
    //        {
    //            TextBox846.Text = Convert.ToString(Convert.ToInt32(TextBox700.Text) + Convert.ToInt32(TextBox846.Text));
    //        }
    //        else { TextBox846.Text = TextBox700.Text; }
    //        if (TextBox847.Text != "")
    //        {
    //            TextBox847.Text = Convert.ToString(Convert.ToInt32(TextBox701.Text) + Convert.ToInt32(TextBox847.Text));
    //        }
    //        else { TextBox847.Text = TextBox701.Text; }
    //        if (TextBox848.Text != "")
    //        {
    //            TextBox848.Text = Convert.ToString(Convert.ToInt32(TextBox702.Text) + Convert.ToInt32(TextBox848.Text));
    //        }
    //        else { TextBox848.Text = TextBox702.Text; }
    //        if (TextBox849.Text != "")
    //        {
    //            TextBox849.Text = Convert.ToString(Convert.ToInt32(TextBox703.Text) + Convert.ToInt32(TextBox849.Text));
    //        }
    //        else { TextBox849.Text = TextBox703.Text; }
    //        if (TextBox850.Text != "")
    //        {
    //            TextBox850.Text = Convert.ToString(Convert.ToInt32(TextBox704.Text) + Convert.ToInt32(TextBox850.Text));
    //        }
    //        else { TextBox850.Text = TextBox704.Text; }
    //        if (TextBox851.Text != "")
    //        {
    //            TextBox851.Text = Convert.ToString(Convert.ToInt32(TextBox705.Text) + Convert.ToInt32(TextBox851.Text));
    //        }
    //        else { TextBox851.Text = TextBox705.Text; }
    //        if (TextBox844.Text != "" && TextBox845.Text != "" && TextBox846.Text != "" && TextBox847.Text != "" && TextBox848.Text != "" && TextBox849.Text != "" && TextBox850.Text != "" && TextBox851.Text != "")
    //        {
    //            TextBox843.Text = Convert.ToString(Convert.ToInt32(TextBox844.Text) + Convert.ToInt32(TextBox845.Text) + Convert.ToInt32(TextBox846.Text) + Convert.ToInt32(TextBox847.Text)
    //                        + Convert.ToInt32(TextBox848.Text) + Convert.ToInt32(TextBox849.Text) + Convert.ToInt32(TextBox850.Text) + Convert.ToInt32(TextBox851.Text));
    //            TextBox833.Text = Convert.ToString(Convert.ToInt32(TextBox834.Text) + Convert.ToInt32(TextBox843.Text));
    //         }
    //        TextBox708.Focus();
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    //protected void TextBox715_TextChanged(object sender, EventArgs e)
    //{
    //    try { 
    //    TextBox707.Text = Convert.ToString(Convert.ToInt32(TextBox708.Text) + Convert.ToInt32(TextBox709.Text) + Convert.ToInt32(TextBox710.Text) + Convert.ToInt32(TextBox711.Text)
    //      + Convert.ToInt32(TextBox712.Text) + Convert.ToInt32(TextBox713.Text) + Convert.ToInt32(TextBox714.Text) + Convert.ToInt32(TextBox715.Text));

    //    if (TextBox854.Text != "")
    //    {
    //        TextBox854.Text = Convert.ToString(Convert.ToInt32(TextBox708.Text) + Convert.ToInt32(TextBox854.Text));
    //    }
    //    else { TextBox854.Text = TextBox708.Text; }
    //    if (TextBox855.Text != "")
    //    {
    //        TextBox855.Text = Convert.ToString(Convert.ToInt32(TextBox709.Text) + Convert.ToInt32(TextBox855.Text));
    //    }
    //    else { TextBox855.Text = TextBox709.Text; }
    //    if (TextBox856.Text != "")
    //    {
    //        TextBox856.Text = Convert.ToString(Convert.ToInt32(TextBox710.Text) + Convert.ToInt32(TextBox856.Text));
    //    }
    //    else { TextBox856.Text = TextBox710.Text; }
    //    if (TextBox857.Text != "")
    //    {
    //        TextBox857.Text = Convert.ToString(Convert.ToInt32(TextBox711.Text) + Convert.ToInt32(TextBox857.Text));
    //    }
    //    else { TextBox857.Text = TextBox711.Text; }
    //    if (TextBox858.Text != "")
    //    {
    //        TextBox858.Text = Convert.ToString(Convert.ToInt32(TextBox712.Text) + Convert.ToInt32(TextBox858.Text));
    //    }
    //    else { TextBox858.Text = TextBox712.Text; }
    //    if (TextBox859.Text != "")
    //    {
    //        TextBox859.Text = Convert.ToString(Convert.ToInt32(TextBox713.Text) + Convert.ToInt32(TextBox859.Text));
    //    }
    //    else { TextBox859.Text = TextBox713.Text; }
    //    if (TextBox860.Text != "")
    //    {
    //        TextBox860.Text = Convert.ToString(Convert.ToInt32(TextBox714.Text) + Convert.ToInt32(TextBox860.Text));
    //    }
    //    else { TextBox860.Text = TextBox714.Text; }
    //    if (TextBox861.Text != "")
    //    {
    //        TextBox861.Text = Convert.ToString(Convert.ToInt32(TextBox715.Text) + Convert.ToInt32(TextBox861.Text));
    //    }
    //    else { TextBox861.Text = TextBox715.Text; }
    //    if (TextBox854.Text != "" && TextBox855.Text != "" && TextBox856.Text != "" && TextBox857.Text != "" && TextBox858.Text != "" && TextBox859.Text != "" && TextBox860.Text != "" && TextBox861.Text != "")
    //    {
    //        TextBox853.Text = Convert.ToString(Convert.ToInt32(TextBox854.Text) + Convert.ToInt32(TextBox855.Text) + Convert.ToInt32(TextBox856.Text) + Convert.ToInt32(TextBox857.Text)
    //               + Convert.ToInt32(TextBox858.Text) + Convert.ToInt32(TextBox859.Text) + Convert.ToInt32(TextBox860.Text) + Convert.ToInt32(TextBox861.Text));
    //        // TextBox833.Text = Convert.ToString(Convert.ToInt32(TextBox834.Text) + Convert.ToInt32(TextBox843.Text));
    //    }
       

    //    TextBox717.Focus();
    //    }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    //protected void TextBox724_TextChanged(object sender, EventArgs e)
    //{
    //    try{
    //    TextBox716.Text = Convert.ToString(Convert.ToInt32(TextBox717.Text) + Convert.ToInt32(TextBox718.Text) + Convert.ToInt32(TextBox719.Text) + Convert.ToInt32(TextBox720.Text)
    //                 + Convert.ToInt32(TextBox721.Text) + Convert.ToInt32(TextBox722.Text) + Convert.ToInt32(TextBox723.Text) + Convert.ToInt32(TextBox724.Text));
    //    TextBox706.Text = Convert.ToString(Convert.ToInt32(TextBox707.Text) + Convert.ToInt32(TextBox716.Text));
    //    //=====
    //    if (TextBox863.Text != "")
    //    {
    //        TextBox863.Text = Convert.ToString(Convert.ToInt32(TextBox717.Text) + Convert.ToInt32(TextBox863.Text));
    //    }
    //    else { TextBox863.Text = TextBox717.Text; }
    //    if (TextBox864.Text != "")
    //    {
    //        TextBox864.Text = Convert.ToString(Convert.ToInt32(TextBox718.Text) + Convert.ToInt32(TextBox864.Text));
    //    }
    //    else { TextBox864.Text = TextBox718.Text; }
    //    if (TextBox865.Text != "")
    //    {
    //        TextBox865.Text = Convert.ToString(Convert.ToInt32(TextBox719.Text) + Convert.ToInt32(TextBox865.Text));
    //    }
    //    else { TextBox865.Text = TextBox719.Text; }
    //    if (TextBox866.Text != "")
    //    {
    //        TextBox866.Text = Convert.ToString(Convert.ToInt32(TextBox720.Text) + Convert.ToInt32(TextBox866.Text));
    //    }
    //    else { TextBox866.Text = TextBox720.Text; }
    //    if (TextBox867.Text != "")
    //    {
    //        TextBox867.Text = Convert.ToString(Convert.ToInt32(TextBox721.Text) + Convert.ToInt32(TextBox867.Text));
    //    }
    //    else { TextBox867.Text = TextBox721.Text; }
    //    if (TextBox868.Text != "")
    //    {
    //        TextBox868.Text = Convert.ToString(Convert.ToInt32(TextBox722.Text) + Convert.ToInt32(TextBox868.Text));
    //    }
    //    else { TextBox868.Text = TextBox722.Text; }
    //    if (TextBox869.Text != "")
    //    {
    //        TextBox869.Text = Convert.ToString(Convert.ToInt32(TextBox723.Text) + Convert.ToInt32(TextBox869.Text));
    //    }
    //    else { TextBox869.Text = TextBox723.Text; }
    //    if (TextBox870.Text != "")
    //    {
    //        TextBox870.Text = Convert.ToString(Convert.ToInt32(TextBox724.Text) + Convert.ToInt32(TextBox870.Text));
    //    }
    //    else { TextBox870.Text = TextBox724.Text; }
    //    if (TextBox863.Text != "" && TextBox864.Text != "" && TextBox865.Text != "" && TextBox866.Text != "" && TextBox867.Text != "" && TextBox868.Text != "" && TextBox869.Text != "" && TextBox870.Text != "")
    //    {
    //            TextBox862.Text = Convert.ToString(Convert.ToInt32(TextBox863.Text) + Convert.ToInt32(TextBox864.Text) + Convert.ToInt32(TextBox865.Text) + Convert.ToInt32(TextBox866.Text)
    //                        + Convert.ToInt32(TextBox867.Text) + Convert.ToInt32(TextBox868.Text) + Convert.ToInt32(TextBox869.Text) + Convert.ToInt32(TextBox870.Text));
    //            TextBox852.Text = Convert.ToString(Convert.ToInt32(TextBox853.Text) + Convert.ToInt32(TextBox862.Text));
    //        }
    //    TextBox727.Focus();
    //     }
    //    catch (Exception ex)
    //    {
    //        Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
    //        return;
    //    }
    //}
    protected void TextBox734_TextChanged(object sender, EventArgs e)
    {
        TextBox726.Text = Convert.ToString(Convert.ToInt32(TextBox727.Text) + Convert.ToInt32(TextBox728.Text) + Convert.ToInt32(TextBox729.Text) + Convert.ToInt32(TextBox730.Text)
         + Convert.ToInt32(TextBox731.Text) + Convert.ToInt32(TextBox732.Text) + Convert.ToInt32(TextBox733.Text) + Convert.ToInt32(TextBox734.Text));
        TextBox736.Focus();
    }
    protected void TextBox743_TextChanged(object sender, EventArgs e)
    {
        TextBox735.Text = Convert.ToString(Convert.ToInt32(TextBox736.Text) + Convert.ToInt32(TextBox737.Text) + Convert.ToInt32(TextBox738.Text) + Convert.ToInt32(TextBox739.Text)
                     + Convert.ToInt32(TextBox740.Text) + Convert.ToInt32(TextBox741.Text) + Convert.ToInt32(TextBox742.Text) + Convert.ToInt32(TextBox743.Text));
        TextBox725.Text = Convert.ToString(Convert.ToInt32(TextBox726.Text) + Convert.ToInt32(TextBox735.Text));
        TextBox784.Focus();
    }
    //protected void TextBox753_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox745.Text = Convert.ToString(Convert.ToInt32(TextBox746.Text) + Convert.ToInt32(TextBox747.Text) + Convert.ToInt32(TextBox748.Text) + Convert.ToInt32(TextBox749.Text)
    //     + Convert.ToInt32(TextBox750.Text) + Convert.ToInt32(TextBox751.Text) + Convert.ToInt32(TextBox752.Text) + Convert.ToInt32(TextBox753.Text));
    //    TextBox755.Focus();
    //}
    //protected void TextBox762_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox754.Text = Convert.ToString(Convert.ToInt32(TextBox755.Text) + Convert.ToInt32(TextBox756.Text) + Convert.ToInt32(TextBox757.Text) + Convert.ToInt32(TextBox758.Text)
    //                 + Convert.ToInt32(TextBox759.Text) + Convert.ToInt32(TextBox760.Text) + Convert.ToInt32(TextBox761.Text) + Convert.ToInt32(TextBox762.Text));
    //    TextBox744.Text = Convert.ToString(Convert.ToInt32(TextBox745.Text) + Convert.ToInt32(TextBox754.Text));
    //    TextBox765.Focus();
    //}
    //protected void TextBox772_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox764.Text = Convert.ToString(Convert.ToInt32(TextBox765.Text) + Convert.ToInt32(TextBox766.Text) + Convert.ToInt32(TextBox767.Text) + Convert.ToInt32(TextBox768.Text)
    //     + Convert.ToInt32(TextBox769.Text) + Convert.ToInt32(TextBox770.Text) + Convert.ToInt32(TextBox771.Text) + Convert.ToInt32(TextBox772.Text));
    //    TextBox774.Focus();
    //}
    //protected void TextBox781_TextChanged(object sender, EventArgs e)
    //{
    //    TextBox773.Text = Convert.ToString(Convert.ToInt32(TextBox774.Text) + Convert.ToInt32(TextBox775.Text) + Convert.ToInt32(TextBox776.Text) + Convert.ToInt32(TextBox777.Text)
    //                 + Convert.ToInt32(TextBox778.Text) + Convert.ToInt32(TextBox779.Text) + Convert.ToInt32(TextBox780.Text) + Convert.ToInt32(TextBox781.Text));
    //    TextBox763.Text = Convert.ToString(Convert.ToInt32(TextBox764.Text) + Convert.ToInt32(TextBox773.Text));
    //    TextBox784.Focus();
    //}
    protected void TextBox788_TextChanged(object sender, EventArgs e)
    {
        TextBox783.Text = Convert.ToString(Convert.ToInt32(TextBox784.Text) + Convert.ToInt32(TextBox785.Text) + Convert.ToInt32(TextBox786.Text) + Convert.ToInt32(TextBox787.Text)
         + Convert.ToInt32(TextBox788.Text));
        TextBox790.Focus();
    }
    protected void TextBox794_TextChanged(object sender, EventArgs e)
    {
        TextBox789.Text = Convert.ToString(Convert.ToInt32(TextBox790.Text) + Convert.ToInt32(TextBox791.Text) + Convert.ToInt32(TextBox792.Text) + Convert.ToInt32(TextBox793.Text)
                    + Convert.ToInt32(TextBox794.Text));
        TextBox782.Text = Convert.ToString(Convert.ToInt32(TextBox783.Text) + Convert.ToInt32(TextBox789.Text));
        TextBox873.Focus();
    }
    protected void TextBox804_TextChanged(object sender, EventArgs e)
    {
        TextBox796.Text = Convert.ToString(Convert.ToInt32(TextBox797.Text) + Convert.ToInt32(TextBox798.Text) + Convert.ToInt32(TextBox799.Text) + Convert.ToInt32(TextBox800.Text)
         + Convert.ToInt32(TextBox801.Text) + Convert.ToInt32(TextBox802.Text) + Convert.ToInt32(TextBox803.Text) + Convert.ToInt32(TextBox804.Text));
        TextBox806.Focus();
    }
    protected void TextBox813_TextChanged(object sender, EventArgs e)
    {
        TextBox805.Text = Convert.ToString(Convert.ToInt32(TextBox806.Text) + Convert.ToInt32(TextBox807.Text) + Convert.ToInt32(TextBox808.Text) + Convert.ToInt32(TextBox809.Text)
                    + Convert.ToInt32(TextBox810.Text) + Convert.ToInt32(TextBox811.Text) + Convert.ToInt32(TextBox812.Text) + Convert.ToInt32(TextBox813.Text));
        TextBox795.Text = Convert.ToString(Convert.ToInt32(TextBox796.Text) + Convert.ToInt32(TextBox805.Text));
        TextBox816.Focus();
    }
    protected void TextBox823_TextChanged(object sender, EventArgs e)
    {
        //TextBox815.Text = Convert.ToString(Convert.ToInt32(TextBox816.Text) + Convert.ToInt32(TextBox817.Text) + Convert.ToInt32(TextBox818.Text) + Convert.ToInt32(TextBox819.Text)
        // + Convert.ToInt32(TextBox820.Text) + Convert.ToInt32(TextBox821.Text) + Convert.ToInt32(TextBox822.Text) + Convert.ToInt32(TextBox823.Text));
        //TextBox825.Focus();
    }
    protected void TextBox832_TextChanged(object sender, EventArgs e)
    {
        TextBox824.Text = Convert.ToString(Convert.ToInt32(TextBox825.Text) + Convert.ToInt32(TextBox826.Text) + Convert.ToInt32(TextBox827.Text) + Convert.ToInt32(TextBox828.Text)
                    + Convert.ToInt32(TextBox829.Text) + Convert.ToInt32(TextBox830.Text) + Convert.ToInt32(TextBox831.Text) + Convert.ToInt32(TextBox832.Text));
        TextBox814.Text = Convert.ToString(Convert.ToInt32(TextBox815.Text) + Convert.ToInt32(TextBox824.Text));
        TextBox835.Focus();
    }
    protected void TextBox842_TextChanged(object sender, EventArgs e)
    {
        TextBox834.Text = Convert.ToString(Convert.ToInt32(TextBox835.Text) + Convert.ToInt32(TextBox836.Text) + Convert.ToInt32(TextBox837.Text) + Convert.ToInt32(TextBox838.Text)
         + Convert.ToInt32(TextBox839.Text) + Convert.ToInt32(TextBox840.Text) + Convert.ToInt32(TextBox841.Text) + Convert.ToInt32(TextBox842.Text));
        TextBox844.Focus();
    }
    protected void TextBox851_TextChanged(object sender, EventArgs e)
    {
        TextBox843.Text = Convert.ToString(Convert.ToInt32(TextBox844.Text) + Convert.ToInt32(TextBox845.Text) + Convert.ToInt32(TextBox846.Text) + Convert.ToInt32(TextBox847.Text)
                    + Convert.ToInt32(TextBox848.Text) + Convert.ToInt32(TextBox849.Text) + Convert.ToInt32(TextBox850.Text) + Convert.ToInt32(TextBox851.Text));
        TextBox833.Text = Convert.ToString(Convert.ToInt32(TextBox834.Text) + Convert.ToInt32(TextBox843.Text));
        TextBox854.Focus();
    }
    protected void TextBox861_TextChanged(object sender, EventArgs e)
    {
        TextBox853.Text = Convert.ToString(Convert.ToInt32(TextBox854.Text) + Convert.ToInt32(TextBox855.Text) + Convert.ToInt32(TextBox856.Text) + Convert.ToInt32(TextBox857.Text)
         + Convert.ToInt32(TextBox858.Text) + Convert.ToInt32(TextBox859.Text) + Convert.ToInt32(TextBox860.Text) + Convert.ToInt32(TextBox861.Text));
        TextBox863.Focus();
    }
    protected void TextBox870_TextChanged(object sender, EventArgs e)
    {
        TextBox862.Text = Convert.ToString(Convert.ToInt32(TextBox863.Text) + Convert.ToInt32(TextBox864.Text) + Convert.ToInt32(TextBox865.Text) + Convert.ToInt32(TextBox866.Text)
                    + Convert.ToInt32(TextBox867.Text) + Convert.ToInt32(TextBox868.Text) + Convert.ToInt32(TextBox869.Text) + Convert.ToInt32(TextBox870.Text));
        TextBox852.Text = Convert.ToString(Convert.ToInt32(TextBox853.Text) + Convert.ToInt32(TextBox862.Text));
        TextBox873.Focus();
    }
    protected void TextBox880_TextChanged(object sender, EventArgs e)
    {
        TextBox872.Text = Convert.ToString(Convert.ToInt32(TextBox873.Text) + Convert.ToInt32(TextBox874.Text) + Convert.ToInt32(TextBox875.Text) + Convert.ToInt32(TextBox876.Text)
         + Convert.ToInt32(TextBox877.Text) + Convert.ToInt32(TextBox878.Text) + Convert.ToInt32(TextBox879.Text) + Convert.ToInt32(TextBox880.Text));
        TextBox882.Focus();
    }
    protected void TextBox889_TextChanged(object sender, EventArgs e)
    {
        TextBox881.Text = Convert.ToString(Convert.ToInt32(TextBox882.Text) + Convert.ToInt32(TextBox883.Text) + Convert.ToInt32(TextBox884.Text) + Convert.ToInt32(TextBox885.Text)
                    + Convert.ToInt32(TextBox886.Text) + Convert.ToInt32(TextBox887.Text) + Convert.ToInt32(TextBox888.Text) + Convert.ToInt32(TextBox889.Text));
        TextBox871.Text = Convert.ToString(Convert.ToInt32(TextBox872.Text) + Convert.ToInt32(TextBox881.Text));
        TextBox892.Focus();
    }
    protected void TextBox899_TextChanged(object sender, EventArgs e)
    {
        TextBox891.Text = Convert.ToString(Convert.ToInt32(TextBox892.Text) + Convert.ToInt32(TextBox893.Text) + Convert.ToInt32(TextBox894.Text) + Convert.ToInt32(TextBox895.Text)
        + Convert.ToInt32(TextBox896.Text) + Convert.ToInt32(TextBox897.Text) + Convert.ToInt32(TextBox898.Text) + Convert.ToInt32(TextBox899.Text));
        TextBox901.Focus();
    }
    protected void TextBox908_TextChanged(object sender, EventArgs e)
    {
        TextBox900.Text = Convert.ToString(Convert.ToInt32(TextBox901.Text) + Convert.ToInt32(TextBox902.Text) + Convert.ToInt32(TextBox903.Text) + Convert.ToInt32(TextBox904.Text)
                    + Convert.ToInt32(TextBox905.Text) + Convert.ToInt32(TextBox906.Text) + Convert.ToInt32(TextBox907.Text) + Convert.ToInt32(TextBox908.Text));
        TextBox890.Text = Convert.ToString(Convert.ToInt32(TextBox891.Text) + Convert.ToInt32(TextBox900.Text));
        TextBox911.Focus();
    }
    protected void TextBox914_TextChanged(object sender, EventArgs e)
    {
        TextBox910.Text = Convert.ToString(Convert.ToInt32(TextBox911.Text) + Convert.ToInt32(TextBox912.Text) + Convert.ToInt32(TextBox913.Text) + Convert.ToInt32(TextBox914.Text));
        TextBox916.Focus();
    }
    protected void TextBox919_TextChanged(object sender, EventArgs e)
    {
        TextBox915.Text = Convert.ToString(Convert.ToInt32(TextBox916.Text) + Convert.ToInt32(TextBox917.Text) + Convert.ToInt32(TextBox918.Text) + Convert.ToInt32(TextBox919.Text));
        TextBox909.Text = Convert.ToString(Convert.ToInt32(TextBox910.Text) + Convert.ToInt32(TextBox915.Text));
        TextBox922.Focus();
    }
    protected void TextBox925_TextChanged(object sender, EventArgs e)
    {
        TextBox921.Text = Convert.ToString(Convert.ToInt32(TextBox922.Text) + Convert.ToInt32(TextBox923.Text) + Convert.ToInt32(TextBox924.Text) + Convert.ToInt32(TextBox925.Text));
        TextBox927.Focus();
    }
    protected void TextBox930_TextChanged(object sender, EventArgs e)
    {
        TextBox926.Text = Convert.ToString(Convert.ToInt32(TextBox927.Text) + Convert.ToInt32(TextBox928.Text) + Convert.ToInt32(TextBox929.Text) + Convert.ToInt32(TextBox930.Text));
        TextBox920.Text = Convert.ToString(Convert.ToInt32(TextBox921.Text) + Convert.ToInt32(TextBox926.Text));
        TextBox933.Focus();
    }
    protected void TextBox940_TextChanged(object sender, EventArgs e)
    {
        TextBox932.Text = Convert.ToString(Convert.ToInt32(TextBox933.Text) + Convert.ToInt32(TextBox934.Text) + Convert.ToInt32(TextBox935.Text) + Convert.ToInt32(TextBox936.Text)
                        + Convert.ToInt32(TextBox937.Text) + Convert.ToInt32(TextBox938.Text) + Convert.ToInt32(TextBox939.Text) + Convert.ToInt32(TextBox940.Text));
        TextBox942.Focus();
    }
    protected void TextBox949_TextChanged(object sender, EventArgs e)
    {
        TextBox941.Text = Convert.ToString(Convert.ToInt32(TextBox942.Text) + Convert.ToInt32(TextBox943.Text) + Convert.ToInt32(TextBox944.Text) + Convert.ToInt32(TextBox945.Text)
                        + Convert.ToInt32(TextBox946.Text) + Convert.ToInt32(TextBox947.Text) + Convert.ToInt32(TextBox948.Text) + Convert.ToInt32(TextBox949.Text));
        TextBox931.Text = Convert.ToString(Convert.ToInt32(TextBox932.Text) + Convert.ToInt32(TextBox941.Text));
        TextBox952.Focus();
    }
    protected void TextBox959_TextChanged(object sender, EventArgs e)
    {
        TextBox951.Text = Convert.ToString(Convert.ToInt32(TextBox952.Text) + Convert.ToInt32(TextBox953.Text) + Convert.ToInt32(TextBox954.Text) + Convert.ToInt32(TextBox955.Text)
                        + Convert.ToInt32(TextBox956.Text) + Convert.ToInt32(TextBox957.Text) + Convert.ToInt32(TextBox958.Text) + Convert.ToInt32(TextBox959.Text));
        TextBox961.Focus();
    }
    protected void TextBox968_TextChanged(object sender, EventArgs e)
    {
        TextBox960.Text = Convert.ToString(Convert.ToInt32(TextBox961.Text) + Convert.ToInt32(TextBox962.Text) + Convert.ToInt32(TextBox963.Text) + Convert.ToInt32(TextBox964.Text)
                        + Convert.ToInt32(TextBox965.Text) + Convert.ToInt32(TextBox966.Text) + Convert.ToInt32(TextBox967.Text) + Convert.ToInt32(TextBox968.Text));
        TextBox950.Text = Convert.ToString(Convert.ToInt32(TextBox951.Text) + Convert.ToInt32(TextBox960.Text));
        TextBox971.Focus();
    }
    protected void TextBox978_TextChanged(object sender, EventArgs e)
    {
        TextBox970.Text = Convert.ToString(Convert.ToInt32(TextBox971.Text) + Convert.ToInt32(TextBox972.Text) + Convert.ToInt32(TextBox973.Text) + Convert.ToInt32(TextBox974.Text)
                       + Convert.ToInt32(TextBox975.Text) + Convert.ToInt32(TextBox976.Text) + Convert.ToInt32(TextBox977.Text) + Convert.ToInt32(TextBox978.Text));
        TextBox980.Focus();
    }
    protected void TextBox987_TextChanged(object sender, EventArgs e)
    {
        TextBox979.Text = Convert.ToString(Convert.ToInt32(TextBox980.Text) + Convert.ToInt32(TextBox981.Text) + Convert.ToInt32(TextBox982.Text) + Convert.ToInt32(TextBox983.Text)
                        + Convert.ToInt32(TextBox984.Text) + Convert.ToInt32(TextBox985.Text) + Convert.ToInt32(TextBox986.Text) + Convert.ToInt32(TextBox987.Text));
        TextBox969.Text = Convert.ToString(Convert.ToInt32(TextBox970.Text) + Convert.ToInt32(TextBox979.Text));
        TextBox990.Focus();
    }
    protected void TextBox997_TextChanged(object sender, EventArgs e)
    {
        TextBox989.Text = Convert.ToString(Convert.ToInt32(TextBox990.Text) + Convert.ToInt32(TextBox991.Text) + Convert.ToInt32(TextBox992.Text) + Convert.ToInt32(TextBox993.Text)
                       + Convert.ToInt32(TextBox994.Text) + Convert.ToInt32(TextBox995.Text) + Convert.ToInt32(TextBox996.Text) + Convert.ToInt32(TextBox997.Text));
        TextBox999.Focus();
    }
    protected void TextBox1006_TextChanged(object sender, EventArgs e)
    {
        TextBox998.Text = Convert.ToString(Convert.ToInt32(TextBox999.Text) + Convert.ToInt32(TextBox1000.Text) + Convert.ToInt32(TextBox1001.Text) + Convert.ToInt32(TextBox1002.Text)
                        + Convert.ToInt32(TextBox1003.Text) + Convert.ToInt32(TextBox1004.Text) + Convert.ToInt32(TextBox1005.Text) + Convert.ToInt32(TextBox1006.Text));
        TextBox988.Text = Convert.ToString(Convert.ToInt32(TextBox989.Text) + Convert.ToInt32(TextBox998.Text));
        TextBox1009.Focus();
    }
    protected void TextBox1016_TextChanged(object sender, EventArgs e)
    {
        TextBox1008.Text = Convert.ToString(Convert.ToInt32(TextBox1009.Text) + Convert.ToInt32(TextBox1010.Text) + Convert.ToInt32(TextBox1011.Text) + Convert.ToInt32(TextBox1012.Text)
                       + Convert.ToInt32(TextBox1013.Text) + Convert.ToInt32(TextBox1014.Text) + Convert.ToInt32(TextBox1015.Text) + Convert.ToInt32(TextBox1016.Text));
        TextBox1018.Focus();
    }
    protected void TextBox1025_TextChanged(object sender, EventArgs e)
    {
        TextBox1017.Text = Convert.ToString(Convert.ToInt32(TextBox1018.Text) + Convert.ToInt32(TextBox1019.Text) + Convert.ToInt32(TextBox1020.Text) + Convert.ToInt32(TextBox1021.Text)
                        + Convert.ToInt32(TextBox1022.Text) + Convert.ToInt32(TextBox1023.Text) + Convert.ToInt32(TextBox1024.Text) + Convert.ToInt32(TextBox1025.Text));
        TextBox1007.Text = Convert.ToString(Convert.ToInt32(TextBox1008.Text) + Convert.ToInt32(TextBox1017.Text));
        TextBox1028.Focus();
    }
    protected void TextBox1035_TextChanged(object sender, EventArgs e)
    {
        TextBox1027.Text = Convert.ToString(Convert.ToInt32(TextBox1028.Text) + Convert.ToInt32(TextBox1029.Text) + Convert.ToInt32(TextBox1030.Text) + Convert.ToInt32(TextBox1031.Text)
                      + Convert.ToInt32(TextBox1032.Text) + Convert.ToInt32(TextBox1033.Text) + Convert.ToInt32(TextBox1034.Text) + Convert.ToInt32(TextBox1035.Text));
        TextBox1037.Focus();
    }
    protected void TextBox1044_TextChanged(object sender, EventArgs e)
    {
        TextBox1036.Text = Convert.ToString(Convert.ToInt32(TextBox1037.Text) + Convert.ToInt32(TextBox1038.Text) + Convert.ToInt32(TextBox1039.Text) + Convert.ToInt32(TextBox1040.Text)
                        + Convert.ToInt32(TextBox1041.Text) + Convert.ToInt32(TextBox1042.Text) + Convert.ToInt32(TextBox1043.Text) + Convert.ToInt32(TextBox1044.Text));
        TextBox1026.Text = Convert.ToString(Convert.ToInt32(TextBox1027.Text) + Convert.ToInt32(TextBox1036.Text));
        TextBox1045.Focus();
    }
    protected void TextBox1052_TextChanged(object sender, EventArgs e)
    {
        TextBox1048.Text = Convert.ToString(Convert.ToInt32(TextBox1049.Text) + Convert.ToInt32(TextBox1050.Text) + Convert.ToInt32(TextBox1051.Text) + Convert.ToInt32(TextBox1052.Text));
        TextBox1054.Focus();
    }
    protected void TextBox1057_TextChanged(object sender, EventArgs e)
    {
        TextBox1053.Text = Convert.ToString(Convert.ToInt32(TextBox1054.Text) + Convert.ToInt32(TextBox1055.Text) + Convert.ToInt32(TextBox1056.Text) + Convert.ToInt32(TextBox1057.Text));
        TextBox1047.Text = Convert.ToString(Convert.ToInt32(TextBox1048.Text) + Convert.ToInt32(TextBox1053.Text));
        TextBox1060.Focus();
    }
    protected void TextBox1063_TextChanged(object sender, EventArgs e)
    {
        TextBox1059.Text = Convert.ToString(Convert.ToInt32(TextBox1060.Text) + Convert.ToInt32(TextBox1061.Text) + Convert.ToInt32(TextBox1062.Text) + Convert.ToInt32(TextBox1063.Text));
        TextBox1065.Focus();
    }
    protected void TextBox1068_TextChanged(object sender, EventArgs e)
    {
        TextBox1064.Text = Convert.ToString(Convert.ToInt32(TextBox1065.Text) + Convert.ToInt32(TextBox1066.Text) + Convert.ToInt32(TextBox1067.Text) + Convert.ToInt32(TextBox1068.Text));
        TextBox1058.Text = Convert.ToString(Convert.ToInt32(TextBox1059.Text) + Convert.ToInt32(TextBox1064.Text));
        TextBox1070.Focus();
    }
    protected void TextBox1071_TextChanged(object sender, EventArgs e)
    {
        TextBox1069.Text = Convert.ToString(Convert.ToInt32(TextBox1070.Text) + Convert.ToInt32(TextBox1071.Text));
        btnSave.Focus();
    }
    protected void TextBox1075_TextChanged(object sender, EventArgs e)
    {
        TextBox269.Focus();
    }
    protected void btnClear_Click(object sender, ImageClickEventArgs e)
    {
        try
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
                case "CARE":
                    CLS_CARE();
                    break;
                case "ART":
                    CLS_ART();
                    break;
                case "HTC":
                    CLS_HTC();
                    break;
                default:
                    Response.Write("<script language=javascript>alert('Wrong Selection ');</script>");
                    return;
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
            return;
        }
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

        string sql = "Select * from tbl_grpname where fname='" + thematicname.Trim() + "'";
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


    
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(TextBox4.Text) + Convert.ToInt32(TextBox5.Text) + Convert.ToInt32(TextBox6.Text)
                       + Convert.ToInt32(TextBox7.Text) + Convert.ToInt32(TextBox8.Text) + Convert.ToInt32(TextBox9.Text) + Convert.ToInt32(TextBox10.Text));
        TextBox12.Focus();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox11.Text = Convert.ToString(Convert.ToInt32(TextBox12.Text) + Convert.ToInt32(TextBox13.Text) + Convert.ToInt32(TextBox14.Text) + Convert.ToInt32(TextBox15.Text)
                       + Convert.ToInt32(TextBox16.Text) + Convert.ToInt32(TextBox17.Text) + Convert.ToInt32(TextBox18.Text) + Convert.ToInt32(TextBox19.Text));
        TextBox1.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox11.Text));
        TextBox22.Focus();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox21.Text = Convert.ToString(Convert.ToInt32(TextBox22.Text) + Convert.ToInt32(TextBox23.Text) + Convert.ToInt32(TextBox24.Text) + Convert.ToInt32(TextBox25.Text)
                       + Convert.ToInt32(TextBox26.Text) + Convert.ToInt32(TextBox27.Text) + Convert.ToInt32(TextBox28.Text) + Convert.ToInt32(TextBox29.Text));
        TextBox31.Focus();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox30.Text = Convert.ToString(Convert.ToInt32(TextBox31.Text) + Convert.ToInt32(TextBox32.Text) + Convert.ToInt32(TextBox33.Text) + Convert.ToInt32(TextBox34.Text)
                       + Convert.ToInt32(TextBox35.Text) + Convert.ToInt32(TextBox36.Text) + Convert.ToInt32(TextBox37.Text) + Convert.ToInt32(TextBox38.Text));
        TextBox20.Text = Convert.ToString(Convert.ToInt32(TextBox21.Text) + Convert.ToInt32(TextBox30.Text));
        TextBox41.Focus();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox40.Text = Convert.ToString(Convert.ToInt32(TextBox41.Text) + Convert.ToInt32(TextBox42.Text) + Convert.ToInt32(TextBox43.Text) + Convert.ToInt32(TextBox44.Text)
                      + Convert.ToInt32(TextBox45.Text) + Convert.ToInt32(TextBox46.Text) + Convert.ToInt32(TextBox47.Text) + Convert.ToInt32(TextBox48.Text));
        TextBox50.Focus();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBox49.Text = Convert.ToString(Convert.ToInt32(TextBox50.Text) + Convert.ToInt32(TextBox51.Text) + Convert.ToInt32(TextBox52.Text) + Convert.ToInt32(TextBox53.Text)
                       + Convert.ToInt32(TextBox54.Text) + Convert.ToInt32(TextBox55.Text) + Convert.ToInt32(TextBox56.Text) + Convert.ToInt32(TextBox57.Text));
        TextBox39.Text = Convert.ToString(Convert.ToInt32(TextBox40.Text) + Convert.ToInt32(TextBox49.Text));
        TextBox60.Focus();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        TextBox59.Text = Convert.ToString(Convert.ToInt32(TextBox60.Text) + Convert.ToInt32(TextBox61.Text) + Convert.ToInt32(TextBox62.Text) + Convert.ToInt32(TextBox63.Text)
                     + Convert.ToInt32(TextBox64.Text) + Convert.ToInt32(TextBox65.Text) + Convert.ToInt32(TextBox66.Text) + Convert.ToInt32(TextBox67.Text));
        TextBox69.Focus();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        TextBox68.Text = Convert.ToString(Convert.ToInt32(TextBox69.Text) + Convert.ToInt32(TextBox70.Text) + Convert.ToInt32(TextBox71.Text) + Convert.ToInt32(TextBox72.Text)
                       + Convert.ToInt32(TextBox73.Text) + Convert.ToInt32(TextBox74.Text) + Convert.ToInt32(TextBox75.Text) + Convert.ToInt32(TextBox76.Text));
        TextBox68.Text = Convert.ToString(Convert.ToInt32(TextBox59.Text) + Convert.ToInt32(TextBox68.Text));
        TextBox79.Focus();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        TextBox78.Text = Convert.ToString(Convert.ToInt32(TextBox79.Text) + Convert.ToInt32(TextBox80.Text) + Convert.ToInt32(TextBox81.Text) + Convert.ToInt32(TextBox82.Text)
                     + Convert.ToInt32(TextBox83.Text) + Convert.ToInt32(TextBox84.Text) + Convert.ToInt32(TextBox85.Text) + Convert.ToInt32(TextBox86.Text));
        TextBox88.Focus();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        TextBox87.Text = Convert.ToString(Convert.ToInt32(TextBox88.Text) + Convert.ToInt32(TextBox89.Text) + Convert.ToInt32(TextBox90.Text) + Convert.ToInt32(TextBox91.Text)
                       + Convert.ToInt32(TextBox92.Text) + Convert.ToInt32(TextBox93.Text) + Convert.ToInt32(TextBox94.Text) + Convert.ToInt32(TextBox95.Text));

        TextBox77.Text = Convert.ToString(Convert.ToInt32(TextBox78.Text) + Convert.ToInt32(TextBox87.Text));
        TextBox98.Focus();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        TextBox97.Text = Convert.ToString(Convert.ToInt32(TextBox98.Text) + Convert.ToInt32(TextBox99.Text) + Convert.ToInt32(TextBox100.Text) + Convert.ToInt32(TextBox101.Text)
                     + Convert.ToInt32(TextBox102.Text) + Convert.ToInt32(TextBox103.Text) + Convert.ToInt32(TextBox104.Text) + Convert.ToInt32(TextBox105.Text));
        TextBox107.Focus();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox106.Text = Convert.ToString(Convert.ToInt32(TextBox107.Text) + Convert.ToInt32(TextBox108.Text) + Convert.ToInt32(TextBox109.Text) + Convert.ToInt32(TextBox110.Text)
                       + Convert.ToInt32(TextBox111.Text) + Convert.ToInt32(TextBox112.Text) + Convert.ToInt32(TextBox113.Text) + Convert.ToInt32(TextBox114.Text));

        TextBox96.Text = Convert.ToString(Convert.ToInt32(TextBox97.Text) + Convert.ToInt32(TextBox106.Text));
        TextBox117.Focus();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        TextBox116.Text = Convert.ToString(Convert.ToInt32(TextBox117.Text) + Convert.ToInt32(TextBox118.Text) + Convert.ToInt32(TextBox119.Text) + Convert.ToInt32(TextBox120.Text)
                    + Convert.ToInt32(TextBox121.Text) + Convert.ToInt32(TextBox122.Text) + Convert.ToInt32(TextBox123.Text) + Convert.ToInt32(TextBox124.Text));
        TextBox126.Focus();
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        TextBox125.Text = Convert.ToString(Convert.ToInt32(TextBox126.Text) + Convert.ToInt32(TextBox127.Text) + Convert.ToInt32(TextBox128.Text) + Convert.ToInt32(TextBox129.Text)
                      + Convert.ToInt32(TextBox130.Text) + Convert.ToInt32(TextBox131.Text) + Convert.ToInt32(TextBox132.Text) + Convert.ToInt32(TextBox133.Text));

        TextBox115.Text = Convert.ToString(Convert.ToInt32(TextBox116.Text) + Convert.ToInt32(TextBox125.Text));
        TextBox136.Focus();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        TextBox135.Text = Convert.ToString(Convert.ToInt32(TextBox136.Text) + Convert.ToInt32(TextBox137.Text) + Convert.ToInt32(TextBox138.Text) + Convert.ToInt32(TextBox139.Text)
                   + Convert.ToInt32(TextBox140.Text) + Convert.ToInt32(TextBox141.Text) + Convert.ToInt32(TextBox142.Text) + Convert.ToInt32(TextBox143.Text));
        TextBox145.Focus();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        TextBox144.Text = Convert.ToString(Convert.ToInt32(TextBox145.Text) + Convert.ToInt32(TextBox146.Text) + Convert.ToInt32(TextBox147.Text) + Convert.ToInt32(TextBox148.Text)
                      + Convert.ToInt32(TextBox149.Text) + Convert.ToInt32(TextBox150.Text) + Convert.ToInt32(TextBox151.Text) + Convert.ToInt32(TextBox152.Text));

        TextBox134.Text = Convert.ToString(Convert.ToInt32(TextBox135.Text) + Convert.ToInt32(TextBox144.Text));
        TextBox155.Focus();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        TextBox154.Text = Convert.ToString(Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox156.Text) + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox158.Text)
                   + Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox160.Text) + Convert.ToInt32(TextBox161.Text) + Convert.ToInt32(TextBox162.Text));
        TextBox164.Focus();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        TextBox163.Text = Convert.ToString(Convert.ToInt32(TextBox164.Text) + Convert.ToInt32(TextBox165.Text) + Convert.ToInt32(TextBox166.Text) + Convert.ToInt32(TextBox167.Text)
              + Convert.ToInt32(TextBox168.Text) + Convert.ToInt32(TextBox169.Text) + Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text));

        TextBox153.Text = Convert.ToString(Convert.ToInt32(TextBox154.Text) + Convert.ToInt32(TextBox163.Text));
        TextBox174.Focus();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        TextBox173.Text = Convert.ToString(Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text) + Convert.ToInt32(TextBox176.Text) + Convert.ToInt32(TextBox177.Text)
                 + Convert.ToInt32(TextBox178.Text) + Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text) + Convert.ToInt32(TextBox181.Text));
        TextBox183.Focus();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        TextBox182.Text = Convert.ToString(Convert.ToInt32(TextBox183.Text) + Convert.ToInt32(TextBox184.Text) + Convert.ToInt32(TextBox185.Text) + Convert.ToInt32(TextBox186.Text)
             + Convert.ToInt32(TextBox187.Text) + Convert.ToInt32(TextBox188.Text) + Convert.ToInt32(TextBox189.Text) + Convert.ToInt32(TextBox190.Text));

        TextBox172.Text = Convert.ToString(Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox182.Text));
        TextBox193.Focus();
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        TextBox192.Text = Convert.ToString(Convert.ToInt32(TextBox193.Text) + Convert.ToInt32(TextBox194.Text) + Convert.ToInt32(TextBox195.Text) + Convert.ToInt32(TextBox196.Text)
               + Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox198.Text) + Convert.ToInt32(TextBox199.Text) + Convert.ToInt32(TextBox200.Text));
        TextBox202.Focus();
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        TextBox201.Text = Convert.ToString(Convert.ToInt32(TextBox202.Text) + Convert.ToInt32(TextBox203.Text) + Convert.ToInt32(TextBox204.Text) + Convert.ToInt32(TextBox205.Text)
             + Convert.ToInt32(TextBox206.Text) + Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text));

        TextBox191.Text = Convert.ToString(Convert.ToInt32(TextBox192.Text) + Convert.ToInt32(TextBox201.Text));
        TextBox212.Focus();
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        TextBox211.Text = Convert.ToString(Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text) + Convert.ToInt32(TextBox215.Text)
               + Convert.ToInt32(TextBox216.Text) + Convert.ToInt32(TextBox217.Text) + Convert.ToInt32(TextBox218.Text) + Convert.ToInt32(TextBox219.Text));
        TextBox221.Focus();
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        TextBox220.Text = Convert.ToString(Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text)
            + Convert.ToInt32(TextBox225.Text) + Convert.ToInt32(TextBox226.Text) + Convert.ToInt32(TextBox227.Text) + Convert.ToInt32(TextBox228.Text));

        TextBox210.Text = Convert.ToString(Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox220.Text));
        TextBox231.Focus();
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        TextBox230.Text = Convert.ToString(Convert.ToInt32(TextBox231.Text) + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text) + Convert.ToInt32(TextBox234.Text)
             + Convert.ToInt32(TextBox235.Text) + Convert.ToInt32(TextBox236.Text) + Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox238.Text));
        TextBox240.Focus();
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        TextBox239.Text = Convert.ToString(Convert.ToInt32(TextBox240.Text) + Convert.ToInt32(TextBox241.Text) + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text)
           + Convert.ToInt32(TextBox244.Text) + Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox247.Text));

        TextBox229.Text = Convert.ToString(Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox239.Text));
        btnSave.Focus();
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        TextBox249.Text = Convert.ToString(Convert.ToInt32(TextBox250.Text) + Convert.ToInt32(TextBox251.Text) + Convert.ToInt32(TextBox252.Text) + Convert.ToInt32(TextBox253.Text)
            + Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox256.Text) + Convert.ToInt32(TextBox257.Text));
        TextBox259.Focus();
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        TextBox258.Text = Convert.ToString(Convert.ToInt32(TextBox259.Text) + Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text)
           + Convert.ToInt32(TextBox263.Text) + Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text));

        TextBox248.Text = Convert.ToString(Convert.ToInt32(TextBox249.Text) + Convert.ToInt32(TextBox258.Text));
        TextBox1074.Focus();
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        TextBox268.Text = Convert.ToString(Convert.ToInt32(TextBox269.Text) + Convert.ToInt32(TextBox270.Text) + Convert.ToInt32(TextBox271.Text) + Convert.ToInt32(TextBox272.Text)
           + Convert.ToInt32(TextBox273.Text) + Convert.ToInt32(TextBox274.Text) + Convert.ToInt32(TextBox275.Text) + Convert.ToInt32(TextBox276.Text));
        TextBox278.Focus();
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        TextBox277.Text = Convert.ToString(Convert.ToInt32(TextBox278.Text) + Convert.ToInt32(TextBox279.Text) + Convert.ToInt32(TextBox280.Text) + Convert.ToInt32(TextBox281.Text)
           + Convert.ToInt32(TextBox282.Text) + Convert.ToInt32(TextBox283.Text) + Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text));
        TextBox267.Text = Convert.ToString(Convert.ToInt32(TextBox268.Text) + Convert.ToInt32(TextBox277.Text));
        TextBox288.Focus();
    }
    protected void Button116_Click(object sender, EventArgs e)
    {
        TextBox288.Focus();
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        TextBox287.Text = Convert.ToString(Convert.ToInt32(TextBox288.Text) + Convert.ToInt32(TextBox289.Text) + Convert.ToInt32(TextBox290.Text) + Convert.ToInt32(TextBox291.Text)
           + Convert.ToInt32(TextBox292.Text) + Convert.ToInt32(TextBox293.Text) + Convert.ToInt32(TextBox294.Text) + Convert.ToInt32(TextBox295.Text));
        TextBox297.Focus();
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        TextBox296.Text = Convert.ToString(Convert.ToInt32(TextBox297.Text) + Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text) + Convert.ToInt32(TextBox300.Text)
           + Convert.ToInt32(TextBox301.Text) + Convert.ToInt32(TextBox302.Text) + Convert.ToInt32(TextBox303.Text) + Convert.ToInt32(TextBox304.Text));
        TextBox286.Text = Convert.ToString(Convert.ToInt32(TextBox287.Text) + Convert.ToInt32(TextBox296.Text));
        TextBox305.Focus();
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        TextBox321.Focus();
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        TextBox311.Text = Convert.ToString(Convert.ToInt32(TextBox312.Text) + Convert.ToInt32(TextBox313.Text) + Convert.ToInt32(TextBox314.Text) + Convert.ToInt32(TextBox315.Text)
          + Convert.ToInt32(TextBox316.Text) + Convert.ToInt32(TextBox317.Text) + Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox319.Text));
        TextBox321.Focus();
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        TextBox320.Text = Convert.ToString(Convert.ToInt32(TextBox321.Text) + Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text) + Convert.ToInt32(TextBox324.Text)
           + Convert.ToInt32(TextBox325.Text) + Convert.ToInt32(TextBox326.Text) + Convert.ToInt32(TextBox327.Text) + Convert.ToInt32(TextBox328.Text));
        TextBox310.Text = Convert.ToString(Convert.ToInt32(TextBox311.Text) + Convert.ToInt32(TextBox320.Text));
        TextBox331.Focus();
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        TextBox320.Text = Convert.ToString(Convert.ToInt32(TextBox321.Text) + Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text) + Convert.ToInt32(TextBox324.Text)
           + Convert.ToInt32(TextBox325.Text) + Convert.ToInt32(TextBox326.Text) + Convert.ToInt32(TextBox327.Text) + Convert.ToInt32(TextBox328.Text));
        TextBox310.Text = Convert.ToString(Convert.ToInt32(TextBox311.Text) + Convert.ToInt32(TextBox320.Text));
        TextBox331.Focus();
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        TextBox349.Text = Convert.ToString(Convert.ToInt32(TextBox350.Text) + Convert.ToInt32(TextBox351.Text) + Convert.ToInt32(TextBox352.Text) + Convert.ToInt32(TextBox353.Text)
          + Convert.ToInt32(TextBox354.Text) + Convert.ToInt32(TextBox355.Text) + Convert.ToInt32(TextBox356.Text) + Convert.ToInt32(TextBox357.Text));
        TextBox359.Focus();
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        TextBox358.Text = Convert.ToString(Convert.ToInt32(TextBox359.Text) + Convert.ToInt32(TextBox360.Text) + Convert.ToInt32(TextBox361.Text) + Convert.ToInt32(TextBox362.Text)
        + Convert.ToInt32(TextBox363.Text) + Convert.ToInt32(TextBox364.Text) + Convert.ToInt32(TextBox365.Text) + Convert.ToInt32(TextBox366.Text));
        TextBox348.Text = Convert.ToString(Convert.ToInt32(TextBox349.Text) + Convert.ToInt32(TextBox358.Text));
        TextBox369.Focus();
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        TextBox368.Text = Convert.ToString(Convert.ToInt32(TextBox369.Text) + Convert.ToInt32(TextBox370.Text) + Convert.ToInt32(TextBox371.Text) + Convert.ToInt32(TextBox372.Text)
          + Convert.ToInt32(TextBox373.Text) + Convert.ToInt32(TextBox374.Text) + Convert.ToInt32(TextBox375.Text) + Convert.ToInt32(TextBox376.Text));
        TextBox378.Focus();
    }
    protected void Button41_Click(object sender, EventArgs e)
    {
        TextBox377.Text = Convert.ToString(Convert.ToInt32(TextBox378.Text) + Convert.ToInt32(TextBox379.Text) + Convert.ToInt32(TextBox380.Text) + Convert.ToInt32(TextBox381.Text)
        + Convert.ToInt32(TextBox382.Text) + Convert.ToInt32(TextBox383.Text) + Convert.ToInt32(TextBox384.Text) + Convert.ToInt32(TextBox385.Text));
        TextBox367.Text = Convert.ToString(Convert.ToInt32(TextBox368.Text) + Convert.ToInt32(TextBox377.Text));
        TextBox388.Focus();
    }
    protected void Button42_Click(object sender, EventArgs e)
    {
        TextBox387.Text = Convert.ToString(Convert.ToInt32(TextBox388.Text) + Convert.ToInt32(TextBox389.Text) + Convert.ToInt32(TextBox390.Text) + Convert.ToInt32(TextBox391.Text)
        + Convert.ToInt32(TextBox392.Text) + Convert.ToInt32(TextBox393.Text) + Convert.ToInt32(TextBox394.Text) + Convert.ToInt32(TextBox395.Text));
        TextBox397.Focus();
    }
    protected void Button43_Click(object sender, EventArgs e)
    {
        TextBox396.Text = Convert.ToString(Convert.ToInt32(TextBox397.Text) + Convert.ToInt32(TextBox398.Text) + Convert.ToInt32(TextBox399.Text) + Convert.ToInt32(TextBox400.Text)
        + Convert.ToInt32(TextBox401.Text) + Convert.ToInt32(TextBox402.Text) + Convert.ToInt32(TextBox403.Text) + Convert.ToInt32(TextBox404.Text));
        TextBox386.Text = Convert.ToString(Convert.ToInt32(TextBox387.Text) + Convert.ToInt32(TextBox396.Text));
        TextBox407.Focus();
    }
    protected void Button44_Click(object sender, EventArgs e)
    {
        TextBox406.Text = Convert.ToString(Convert.ToInt32(TextBox407.Text) + Convert.ToInt32(TextBox408.Text) + Convert.ToInt32(TextBox409.Text) + Convert.ToInt32(TextBox410.Text)
        + Convert.ToInt32(TextBox411.Text) + Convert.ToInt32(TextBox412.Text) + Convert.ToInt32(TextBox413.Text) + Convert.ToInt32(TextBox414.Text));
        TextBox416.Focus();
    }
    protected void Button45_Click(object sender, EventArgs e)
    {
        TextBox415.Text = Convert.ToString(Convert.ToInt32(TextBox416.Text) + Convert.ToInt32(TextBox417.Text) + Convert.ToInt32(TextBox418.Text) + Convert.ToInt32(TextBox419.Text)
       + Convert.ToInt32(TextBox420.Text) + Convert.ToInt32(TextBox421.Text) + Convert.ToInt32(TextBox422.Text) + Convert.ToInt32(TextBox423.Text));
        TextBox405.Text = Convert.ToString(Convert.ToInt32(TextBox406.Text) + Convert.ToInt32(TextBox415.Text));
        TextBox426.Focus();
    }
    protected void Button46_Click(object sender, EventArgs e)
    {
        TextBox425.Text = Convert.ToString(Convert.ToInt32(TextBox426.Text) + Convert.ToInt32(TextBox427.Text) + Convert.ToInt32(TextBox428.Text) + Convert.ToInt32(TextBox429.Text)
       + Convert.ToInt32(TextBox430.Text) + Convert.ToInt32(TextBox431.Text) + Convert.ToInt32(TextBox432.Text) + Convert.ToInt32(TextBox433.Text));
        TextBox435.Focus();
    }
    protected void Button47_Click(object sender, EventArgs e)
    {
        TextBox434.Text = Convert.ToString(Convert.ToInt32(TextBox435.Text) + Convert.ToInt32(TextBox436.Text) + Convert.ToInt32(TextBox437.Text) + Convert.ToInt32(TextBox438.Text)
       + Convert.ToInt32(TextBox439.Text) + Convert.ToInt32(TextBox440.Text) + Convert.ToInt32(TextBox441.Text) + Convert.ToInt32(TextBox442.Text));
        TextBox424.Text = Convert.ToString(Convert.ToInt32(TextBox425.Text) + Convert.ToInt32(TextBox434.Text));
        TextBox443.Focus();
    }
    protected void Button48_Click(object sender, EventArgs e)
    {
        TextBox449.Focus();
    }
    protected void Button49_Click(object sender, EventArgs e)
    {
        TextBox448.Text = Convert.ToString(Convert.ToInt32(TextBox449.Text) + Convert.ToInt32(TextBox450.Text) + Convert.ToInt32(TextBox451.Text) + Convert.ToInt32(TextBox452.Text)
    + Convert.ToInt32(TextBox453.Text) + Convert.ToInt32(TextBox454.Text) + Convert.ToInt32(TextBox455.Text) + Convert.ToInt32(TextBox456.Text));
        TextBox458.Focus();
    }
    protected void Button50_Click(object sender, EventArgs e)
    {
        TextBox457.Text = Convert.ToString(Convert.ToInt32(TextBox458.Text) + Convert.ToInt32(TextBox459.Text) + Convert.ToInt32(TextBox460.Text) + Convert.ToInt32(TextBox461.Text)
      + Convert.ToInt32(TextBox462.Text) + Convert.ToInt32(TextBox463.Text) + Convert.ToInt32(TextBox464.Text) + Convert.ToInt32(TextBox465.Text));
        TextBox447.Text = Convert.ToString(Convert.ToInt32(TextBox448.Text) + Convert.ToInt32(TextBox457.Text));
        TextBox466.Focus();
    }
    protected void Button51_Click(object sender, EventArgs e)
    {
        TextBox472.Focus();
    }
    protected void Button52_Click(object sender, EventArgs e)
    {
        TextBox471.Text = Convert.ToString(Convert.ToInt32(TextBox472.Text) + Convert.ToInt32(TextBox473.Text) + Convert.ToInt32(TextBox474.Text) + Convert.ToInt32(TextBox475.Text)
  + Convert.ToInt32(TextBox476.Text) + Convert.ToInt32(TextBox477.Text) + Convert.ToInt32(TextBox478.Text) + Convert.ToInt32(TextBox479.Text));
        TextBox481.Focus();
    }
    protected void Button53_Click(object sender, EventArgs e)
    {
        TextBox480.Text = Convert.ToString(Convert.ToInt32(TextBox481.Text) + Convert.ToInt32(TextBox482.Text) + Convert.ToInt32(TextBox483.Text) + Convert.ToInt32(TextBox484.Text)
     + Convert.ToInt32(TextBox485.Text) + Convert.ToInt32(TextBox486.Text) + Convert.ToInt32(TextBox487.Text) + Convert.ToInt32(TextBox488.Text));
        TextBox470.Text = Convert.ToString(Convert.ToInt32(TextBox471.Text) + Convert.ToInt32(TextBox480.Text));
        TextBox489.Focus();
    }
    protected void Button54_Click(object sender, EventArgs e)
    {
        TextBox493.Focus();
    }
    protected void Button55_Click(object sender, EventArgs e)
    {
        TextBox492.Text = Convert.ToString(Convert.ToInt32(TextBox493.Text) + Convert.ToInt32(TextBox494.Text) + Convert.ToInt32(TextBox495.Text) + Convert.ToInt32(TextBox496.Text)
                    + Convert.ToInt32(TextBox497.Text) + Convert.ToInt32(TextBox498.Text) + Convert.ToInt32(TextBox499.Text) + Convert.ToInt32(TextBox500.Text));
        TextBox502.Focus();
    }
    protected void Button117_Click(object sender, EventArgs e)
    {
        TextBox501.Text = Convert.ToString(Convert.ToInt32(TextBox502.Text) + Convert.ToInt32(TextBox503.Text) + Convert.ToInt32(TextBox504.Text) + Convert.ToInt32(TextBox505.Text)
  + Convert.ToInt32(TextBox506.Text) + Convert.ToInt32(TextBox507.Text) + Convert.ToInt32(TextBox508.Text) + Convert.ToInt32(TextBox509.Text));
        TextBox491.Text = Convert.ToString(Convert.ToInt32(TextBox492.Text) + Convert.ToInt32(TextBox501.Text));
        TextBox510.Focus();
    }
    protected void Button56_Click(object sender, EventArgs e)
    {
        TextBox514.Focus();
    }
    protected void Button57_Click(object sender, EventArgs e)
    {
        TextBox513.Text = Convert.ToString(Convert.ToInt32(TextBox514.Text) + Convert.ToInt32(TextBox515.Text) + Convert.ToInt32(TextBox516.Text) + Convert.ToInt32(TextBox517.Text)
                    + Convert.ToInt32(TextBox518.Text) + Convert.ToInt32(TextBox519.Text) + Convert.ToInt32(TextBox520.Text) + Convert.ToInt32(TextBox521.Text));
        TextBox523.Focus();
    }
    protected void Button58_Click(object sender, EventArgs e)
    {
        TextBox522.Text = Convert.ToString(Convert.ToInt32(TextBox523.Text) + Convert.ToInt32(TextBox524.Text) + Convert.ToInt32(TextBox525.Text) + Convert.ToInt32(TextBox526.Text)
                            + Convert.ToInt32(TextBox527.Text) + Convert.ToInt32(TextBox528.Text) + Convert.ToInt32(TextBox529.Text) + Convert.ToInt32(TextBox530.Text));
        TextBox512.Text = Convert.ToString(Convert.ToInt32(TextBox513.Text) + Convert.ToInt32(TextBox522.Text));
        TextBox531.Focus();
    }
    protected void Button59_Click(object sender, EventArgs e)
    {
        TextBox534.Text = Convert.ToString(Convert.ToInt32(TextBox535.Text) + Convert.ToInt32(TextBox536.Text) + Convert.ToInt32(TextBox537.Text) + Convert.ToInt32(TextBox538.Text)
                   + Convert.ToInt32(TextBox539.Text) + Convert.ToInt32(TextBox540.Text) + Convert.ToInt32(TextBox541.Text) + Convert.ToInt32(TextBox542.Text));
        TextBox544.Focus();
    }
    protected void Button60_Click(object sender, EventArgs e)
    {
        TextBox543.Text = Convert.ToString(Convert.ToInt32(TextBox544.Text) + Convert.ToInt32(TextBox545.Text) + Convert.ToInt32(TextBox546.Text) + Convert.ToInt32(TextBox547.Text)
                           + Convert.ToInt32(TextBox548.Text) + Convert.ToInt32(TextBox549.Text) + Convert.ToInt32(TextBox550.Text) + Convert.ToInt32(TextBox551.Text));
        TextBox533.Text = Convert.ToString(Convert.ToInt32(TextBox534.Text) + Convert.ToInt32(TextBox543.Text));
        TextBox552.Focus();
    }
    protected void Button61_Click(object sender, EventArgs e)
    {
        TextBox555.Text = Convert.ToString(Convert.ToInt32(TextBox556.Text) + Convert.ToInt32(TextBox557.Text) + Convert.ToInt32(TextBox558.Text) + Convert.ToInt32(TextBox559.Text)
                   + Convert.ToInt32(TextBox560.Text) + Convert.ToInt32(TextBox561.Text) + Convert.ToInt32(TextBox562.Text) + Convert.ToInt32(TextBox563.Text));
        TextBox565.Focus();
    }
    protected void Button62_Click(object sender, EventArgs e)
    {
        TextBox564.Text = Convert.ToString(Convert.ToInt32(TextBox565.Text) + Convert.ToInt32(TextBox566.Text) + Convert.ToInt32(TextBox567.Text) + Convert.ToInt32(TextBox568.Text)
                           + Convert.ToInt32(TextBox569.Text) + Convert.ToInt32(TextBox570.Text) + Convert.ToInt32(TextBox571.Text) + Convert.ToInt32(TextBox572.Text));
        TextBox554.Text = Convert.ToString(Convert.ToInt32(TextBox555.Text) + Convert.ToInt32(TextBox564.Text));
        TextBox575.Focus();
    }
    protected void Button63_Click(object sender, EventArgs e)
    {
        TextBox574.Text = Convert.ToString(Convert.ToInt32(TextBox575.Text) + Convert.ToInt32(TextBox576.Text) + Convert.ToInt32(TextBox577.Text) + Convert.ToInt32(TextBox578.Text)
                  + Convert.ToInt32(TextBox579.Text) + Convert.ToInt32(TextBox580.Text) + Convert.ToInt32(TextBox581.Text) + Convert.ToInt32(TextBox582.Text));
        TextBox584.Focus();
    }
    protected void Button64_Click(object sender, EventArgs e)
    {
        TextBox583.Text = Convert.ToString(Convert.ToInt32(TextBox584.Text) + Convert.ToInt32(TextBox585.Text) + Convert.ToInt32(TextBox586.Text) + Convert.ToInt32(TextBox587.Text)
                           + Convert.ToInt32(TextBox588.Text) + Convert.ToInt32(TextBox589.Text) + Convert.ToInt32(TextBox590.Text) + Convert.ToInt32(TextBox591.Text));
        TextBox573.Text = Convert.ToString(Convert.ToInt32(TextBox574.Text) + Convert.ToInt32(TextBox583.Text));
        TextBox594.Focus();
    }
    protected void Button65_Click(object sender, EventArgs e)
    {
        TextBox593.Text = Convert.ToString(Convert.ToInt32(TextBox594.Text) + Convert.ToInt32(TextBox595.Text) + Convert.ToInt32(TextBox596.Text) + Convert.ToInt32(TextBox597.Text)
                  + Convert.ToInt32(TextBox598.Text) + Convert.ToInt32(TextBox599.Text) + Convert.ToInt32(TextBox600.Text) + Convert.ToInt32(TextBox601.Text));
        TextBox603.Focus();
    }
    protected void Button66_Click(object sender, EventArgs e)
    {
        TextBox602.Text = Convert.ToString(Convert.ToInt32(TextBox603.Text) + Convert.ToInt32(TextBox604.Text) + Convert.ToInt32(TextBox605.Text) + Convert.ToInt32(TextBox606.Text)
                           + Convert.ToInt32(TextBox607.Text) + Convert.ToInt32(TextBox608.Text) + Convert.ToInt32(TextBox609.Text) + Convert.ToInt32(TextBox610.Text));
        TextBox592.Text = Convert.ToString(Convert.ToInt32(TextBox593.Text) + Convert.ToInt32(TextBox602.Text));
        btnSave.Focus();
    }
    protected void Button67_Click(object sender, EventArgs e)
    {
        TextBox612.Text = Convert.ToString(Convert.ToInt32(TextBox613.Text) + Convert.ToInt32(TextBox614.Text) + Convert.ToInt32(TextBox615.Text) + Convert.ToInt32(TextBox616.Text)
                 + Convert.ToInt32(TextBox617.Text) + Convert.ToInt32(TextBox618.Text) + Convert.ToInt32(TextBox619.Text) + Convert.ToInt32(TextBox620.Text));
        TextBox622.Focus();
    }
    protected void Button68_Click(object sender, EventArgs e)
    {
        TextBox621.Text = Convert.ToString(Convert.ToInt32(TextBox622.Text) + Convert.ToInt32(TextBox623.Text) + Convert.ToInt32(TextBox624.Text) + Convert.ToInt32(TextBox625.Text)
                          + Convert.ToInt32(TextBox626.Text) + Convert.ToInt32(TextBox627.Text) + Convert.ToInt32(TextBox628.Text) + Convert.ToInt32(TextBox629.Text));
        TextBox611.Text = Convert.ToString(Convert.ToInt32(TextBox612.Text) + Convert.ToInt32(TextBox621.Text));
        TextBox632.Focus();
    }
    protected void Button69_Click(object sender, EventArgs e)
    {
        TextBox631.Text = Convert.ToString(Convert.ToInt32(TextBox632.Text) + Convert.ToInt32(TextBox633.Text) + Convert.ToInt32(TextBox634.Text) + Convert.ToInt32(TextBox635.Text)
                 + Convert.ToInt32(TextBox636.Text) + Convert.ToInt32(TextBox637.Text) + Convert.ToInt32(TextBox638.Text) + Convert.ToInt32(TextBox639.Text));
        TextBox641.Focus();
    }
    protected void Button70_Click(object sender, EventArgs e)
    {
        TextBox640.Text = Convert.ToString(Convert.ToInt32(TextBox641.Text) + Convert.ToInt32(TextBox642.Text) + Convert.ToInt32(TextBox643.Text) + Convert.ToInt32(TextBox644.Text)
                          + Convert.ToInt32(TextBox645.Text) + Convert.ToInt32(TextBox646.Text) + Convert.ToInt32(TextBox647.Text) + Convert.ToInt32(TextBox648.Text));
        TextBox630.Text = Convert.ToString(Convert.ToInt32(TextBox631.Text) + Convert.ToInt32(TextBox640.Text));
        TextBox651.Focus();
    }
    protected void Button71_Click(object sender, EventArgs e)
    {
        TextBox650.Text = Convert.ToString(Convert.ToInt32(TextBox651.Text) + Convert.ToInt32(TextBox652.Text) + Convert.ToInt32(TextBox653.Text) + Convert.ToInt32(TextBox654.Text)
                + Convert.ToInt32(TextBox655.Text) + Convert.ToInt32(TextBox656.Text) + Convert.ToInt32(TextBox657.Text) + Convert.ToInt32(TextBox658.Text));
        if (TextBox797.Text != "")
        {
            TextBox797.Text = Convert.ToString(Convert.ToInt32(TextBox797.Text) + Convert.ToInt32(TextBox651.Text));
        }else
        {
            TextBox797.Text = Convert.ToString(Convert.ToInt32(TextBox651.Text));
        }
        if (TextBox798.Text != "")
        {
            TextBox798.Text = Convert.ToString(Convert.ToInt32(TextBox652.Text) + Convert.ToInt32(TextBox798.Text));
        }
        else
        {
            TextBox798.Text = Convert.ToString(Convert.ToInt32(TextBox652.Text));
        }
        if (TextBox799.Text != "")
        {
            TextBox799.Text = Convert.ToString(Convert.ToInt32(TextBox653.Text) + Convert.ToInt32(TextBox799.Text));
        }
        else { TextBox799.Text = Convert.ToString(Convert.ToInt32(TextBox653.Text)); }
        if (TextBox800.Text != "")
        {
            TextBox800.Text = Convert.ToString(Convert.ToInt32(TextBox654.Text) + Convert.ToInt32(TextBox800.Text));
        }
        else { TextBox800.Text = Convert.ToString(Convert.ToInt32(TextBox654.Text)); }
        if (TextBox801.Text != "")
        {
            TextBox801.Text = Convert.ToString(Convert.ToInt32(TextBox655.Text) + Convert.ToInt32(TextBox801.Text));
        }
        else { TextBox801.Text = Convert.ToString(Convert.ToInt32(TextBox655.Text)); }
        if (TextBox802.Text != "")
        {
            TextBox802.Text = Convert.ToString(Convert.ToInt32(TextBox656.Text) + Convert.ToInt32(TextBox802.Text));
        }
        else { TextBox802.Text = Convert.ToString(Convert.ToInt32(TextBox656.Text)); }
        if (TextBox803.Text != "")
        {
            TextBox803.Text = Convert.ToString(Convert.ToInt32(TextBox657.Text) + Convert.ToInt32(TextBox803.Text));
        }
        else { TextBox803.Text = Convert.ToString(Convert.ToInt32(TextBox657.Text)); }
        if (TextBox804.Text != "")
        {
            TextBox804.Text = Convert.ToString(Convert.ToInt32(TextBox658.Text) + Convert.ToInt32(TextBox804.Text));
        }
        else { TextBox804.Text = Convert.ToString(Convert.ToInt32(TextBox658.Text)); }
        TextBox796.Text = Convert.ToString(Convert.ToInt32(TextBox797.Text) + Convert.ToInt32(TextBox798.Text) + Convert.ToInt32(TextBox799.Text) + Convert.ToInt32(TextBox800.Text)
                     + Convert.ToInt32(TextBox801.Text) + Convert.ToInt32(TextBox802.Text) + Convert.ToInt32(TextBox803.Text) + Convert.ToInt32(TextBox804.Text));

        TextBox660.Focus();
    }
    protected void Button72_Click(object sender, EventArgs e)
    {
        TextBox659.Text = Convert.ToString(Convert.ToInt32(TextBox660.Text) + Convert.ToInt32(TextBox661.Text) + Convert.ToInt32(TextBox662.Text) + Convert.ToInt32(TextBox663.Text)
                          + Convert.ToInt32(TextBox664.Text) + Convert.ToInt32(TextBox665.Text) + Convert.ToInt32(TextBox666.Text) + Convert.ToInt32(TextBox667.Text));
        TextBox649.Text = Convert.ToString(Convert.ToInt32(TextBox650.Text) + Convert.ToInt32(TextBox659.Text));

        if (TextBox806.Text != "")
        {
            TextBox806.Text = Convert.ToString(Convert.ToInt32(TextBox660.Text) + Convert.ToInt32(TextBox806.Text));
        }
        else { TextBox806.Text = Convert.ToString(Convert.ToInt32(TextBox660.Text)); }
        if (TextBox807.Text != "")
        {
            TextBox807.Text = Convert.ToString(Convert.ToInt32(TextBox661.Text) + Convert.ToInt32(TextBox807.Text));
        }
        else { TextBox807.Text = Convert.ToString(Convert.ToInt32(TextBox661.Text)); }
        if (TextBox808.Text != "")
        {
            TextBox808.Text = Convert.ToString(Convert.ToInt32(TextBox662.Text) + Convert.ToInt32(TextBox808.Text));
        }
        else { TextBox808.Text = Convert.ToString(Convert.ToInt32(TextBox662.Text)); }
        if (TextBox809.Text != "")
        {
            TextBox809.Text = Convert.ToString(Convert.ToInt32(TextBox663.Text) + Convert.ToInt32(TextBox809.Text));
        }
        else { TextBox809.Text = Convert.ToString(Convert.ToInt32(TextBox663.Text)); }
        if (TextBox810.Text != "")
        {
            TextBox810.Text = Convert.ToString(Convert.ToInt32(TextBox664.Text) + Convert.ToInt32(TextBox810.Text));
        }
        else { TextBox810.Text = Convert.ToString(Convert.ToInt32(TextBox664.Text)); }
        if (TextBox811.Text != "")
        {
            TextBox811.Text = Convert.ToString(Convert.ToInt32(TextBox665.Text) + Convert.ToInt32(TextBox811.Text));
        }
        else { TextBox811.Text = Convert.ToString(Convert.ToInt32(TextBox665.Text)); }
        if (TextBox812.Text != "")
        {
            TextBox812.Text = Convert.ToString(Convert.ToInt32(TextBox666.Text) + Convert.ToInt32(TextBox812.Text));
        }
        else { TextBox812.Text = Convert.ToString(Convert.ToInt32(TextBox666.Text)); }
        if (TextBox813.Text != "")
        {
            TextBox813.Text = Convert.ToString(Convert.ToInt32(TextBox667.Text) + Convert.ToInt32(TextBox813.Text));
        }
        else { TextBox813.Text = Convert.ToString(Convert.ToInt32(TextBox667.Text)); }
        TextBox805.Text = Convert.ToString(Convert.ToInt32(TextBox806.Text) + Convert.ToInt32(TextBox807.Text) + Convert.ToInt32(TextBox808.Text) + Convert.ToInt32(TextBox809.Text)
                    + Convert.ToInt32(TextBox810.Text) + Convert.ToInt32(TextBox811.Text) + Convert.ToInt32(TextBox812.Text) + Convert.ToInt32(TextBox813.Text));
        TextBox795.Text = Convert.ToString(Convert.ToInt32(TextBox796.Text) + Convert.ToInt32(TextBox805.Text));
        TextBox670.Focus();
    }
    protected void Button73_Click(object sender, EventArgs e)
    {
        //=========== POSITIVE
        try
        {
            TextBox669.Text = Convert.ToString(Convert.ToInt32(TextBox670.Text) + Convert.ToInt32(TextBox671.Text) + Convert.ToInt32(TextBox672.Text) + Convert.ToInt32(TextBox673.Text)
                     + Convert.ToInt32(TextBox674.Text) + Convert.ToInt32(TextBox675.Text) + Convert.ToInt32(TextBox676.Text) + Convert.ToInt32(TextBox677.Text));

            if (TextBox816.Text != "")
            {
                TextBox816.Text = Convert.ToString(Convert.ToInt32(TextBox670.Text) + Convert.ToInt32(TextBox816.Text));
            }
            else { TextBox816.Text = Convert.ToString(Convert.ToInt32(TextBox670.Text)); }
            if (TextBox817.Text != "")
            {
                TextBox817.Text = Convert.ToString(Convert.ToInt32(TextBox671.Text) + Convert.ToInt32(TextBox817.Text));
            }
            else { TextBox817.Text = Convert.ToString(Convert.ToInt32(TextBox671.Text)); }
            if (TextBox818.Text != "")
            {
                TextBox818.Text = Convert.ToString(Convert.ToInt32(TextBox672.Text) + Convert.ToInt32(TextBox818.Text));
            }
            else { TextBox818.Text = Convert.ToString(Convert.ToInt32(TextBox672.Text)); }
            if (TextBox819.Text != "")
            {
                TextBox819.Text = Convert.ToString(Convert.ToInt32(TextBox673.Text) + Convert.ToInt32(TextBox819.Text));
            }
            else { TextBox819.Text = Convert.ToString(Convert.ToInt32(TextBox673.Text)); }
            if (TextBox820.Text != "")
            {
                TextBox820.Text = Convert.ToString(Convert.ToInt32(TextBox674.Text) + Convert.ToInt32(TextBox820.Text));
            }
            else { TextBox820.Text = Convert.ToString(Convert.ToInt32(TextBox674.Text)); }
            if (TextBox821.Text != "")
            {
                TextBox821.Text = Convert.ToString(Convert.ToInt32(TextBox675.Text) + Convert.ToInt32(TextBox821.Text));
            }
            else { TextBox821.Text = Convert.ToString(Convert.ToInt32(TextBox675.Text)); }
            if (TextBox822.Text != "")
            {
                TextBox822.Text = Convert.ToString(Convert.ToInt32(TextBox676.Text) + Convert.ToInt32(TextBox822.Text));
            }
            else { TextBox822.Text = Convert.ToString(Convert.ToInt32(TextBox676.Text)); }
            if (TextBox823.Text != "")
            {
                TextBox823.Text = Convert.ToString(Convert.ToInt32(TextBox677.Text) + Convert.ToInt32(TextBox823.Text));
            }
            else { TextBox823.Text = Convert.ToString(Convert.ToInt32(TextBox677.Text)); }
            if (TextBox816.Text != "" && TextBox817.Text != "" && TextBox818.Text != "" && TextBox819.Text != "" && TextBox820.Text != "" && TextBox821.Text != "" && TextBox822.Text != "" && TextBox823.Text != "")
            {
                TextBox815.Text = Convert.ToString(Convert.ToInt32(TextBox816.Text) + Convert.ToInt32(TextBox817.Text) + Convert.ToInt32(TextBox818.Text) + Convert.ToInt32(TextBox819.Text)
                        + Convert.ToInt32(TextBox820.Text) + Convert.ToInt32(TextBox821.Text) + Convert.ToInt32(TextBox822.Text) + Convert.ToInt32(TextBox823.Text));
            }
            TextBox679.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void Button74_Click(object sender, EventArgs e)
    {
        try
        {
            TextBox678.Text = Convert.ToString(Convert.ToInt32(TextBox679.Text) + Convert.ToInt32(TextBox680.Text) + Convert.ToInt32(TextBox681.Text) + Convert.ToInt32(TextBox682.Text)
                              + Convert.ToInt32(TextBox683.Text) + Convert.ToInt32(TextBox684.Text) + Convert.ToInt32(TextBox685.Text) + Convert.ToInt32(TextBox686.Text));
            TextBox668.Text = Convert.ToString(Convert.ToInt32(TextBox669.Text) + Convert.ToInt32(TextBox678.Text));

            if (TextBox825.Text != "")
            {
                TextBox825.Text = Convert.ToString(Convert.ToInt32(TextBox679.Text) + Convert.ToInt32(TextBox825.Text));
            }
            else { TextBox825.Text = Convert.ToString(Convert.ToInt32(TextBox679.Text)); }
            if (TextBox826.Text != "")
            {
                TextBox826.Text = Convert.ToString(Convert.ToInt32(TextBox680.Text) + Convert.ToInt32(TextBox826.Text));
            }
            else { TextBox826.Text = Convert.ToString(Convert.ToInt32(TextBox680.Text)); }
            if (TextBox827.Text != "")
            {
                TextBox827.Text = Convert.ToString(Convert.ToInt32(TextBox681.Text) + Convert.ToInt32(TextBox827.Text));
            }
            else { TextBox827.Text = Convert.ToString(Convert.ToInt32(TextBox681.Text)); }
            if (TextBox828.Text != "")
            {
                TextBox828.Text = Convert.ToString(Convert.ToInt32(TextBox682.Text) + Convert.ToInt32(TextBox828.Text));
            }
            else { TextBox828.Text = Convert.ToString(Convert.ToInt32(TextBox682.Text)); }
            if (TextBox829.Text != "")
            {
                TextBox829.Text = Convert.ToString(Convert.ToInt32(TextBox683.Text) + Convert.ToInt32(TextBox829.Text));
            }
            else { TextBox829.Text = Convert.ToString(Convert.ToInt32(TextBox683.Text)); }
            if (TextBox830.Text != "")
            {
                TextBox830.Text = Convert.ToString(Convert.ToInt32(TextBox684.Text) + Convert.ToInt32(TextBox830.Text));
            }
            else { TextBox830.Text = Convert.ToString(Convert.ToInt32(TextBox684.Text)); }
            if (TextBox831.Text != "")
            {
                TextBox831.Text = Convert.ToString(Convert.ToInt32(TextBox685.Text) + Convert.ToInt32(TextBox831.Text));
            }
            else { TextBox831.Text = Convert.ToString(Convert.ToInt32(TextBox685.Text)); }
            if (TextBox832.Text != "")
            {
                TextBox832.Text = Convert.ToString(Convert.ToInt32(TextBox686.Text) + Convert.ToInt32(TextBox832.Text));
            }
            else { TextBox832.Text = Convert.ToString(Convert.ToInt32(TextBox686.Text)); }
            if (TextBox825.Text != "" && TextBox826.Text != "" && TextBox827.Text != "" && TextBox828.Text != "" && TextBox829.Text != "" && TextBox830.Text != "" && TextBox831.Text != "" && TextBox832.Text != "")
            {
                TextBox824.Text = Convert.ToString(Convert.ToInt32(TextBox825.Text) + Convert.ToInt32(TextBox826.Text) + Convert.ToInt32(TextBox827.Text) + Convert.ToInt32(TextBox828.Text)
                            + Convert.ToInt32(TextBox829.Text) + Convert.ToInt32(TextBox830.Text) + Convert.ToInt32(TextBox831.Text) + Convert.ToInt32(TextBox832.Text));
                TextBox814.Text = Convert.ToString(Convert.ToInt32(TextBox815.Text) + Convert.ToInt32(TextBox824.Text));
            }
            TextBox689.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void Button75_Click(object sender, EventArgs e)
    {
        try
        {
            TextBox688.Text = Convert.ToString(Convert.ToInt32(TextBox689.Text) + Convert.ToInt32(TextBox690.Text) + Convert.ToInt32(TextBox691.Text) + Convert.ToInt32(TextBox692.Text)
              + Convert.ToInt32(TextBox693.Text) + Convert.ToInt32(TextBox694.Text) + Convert.ToInt32(TextBox695.Text) + Convert.ToInt32(TextBox696.Text));
            if (TextBox835.Text != "")
            {
                TextBox835.Text = Convert.ToString(Convert.ToInt32(TextBox689.Text) + Convert.ToInt32(TextBox835.Text));
            }
            else { TextBox835.Text = Convert.ToString(Convert.ToInt32(TextBox689.Text)); }
            if (TextBox836.Text != "")
            {
                TextBox836.Text = Convert.ToString(Convert.ToInt32(TextBox690.Text) + Convert.ToInt32(TextBox836.Text));
            }
            else {  TextBox836.Text = Convert.ToString(Convert.ToInt32(TextBox690.Text)); }
            if (TextBox837.Text != "")
            {
                TextBox837.Text = Convert.ToString(Convert.ToInt32(TextBox691.Text) + Convert.ToInt32(TextBox837.Text));
            }
            else {  TextBox837.Text = Convert.ToString(Convert.ToInt32(TextBox691.Text)); }
            if (TextBox838.Text != "")
            {
                TextBox838.Text = Convert.ToString(Convert.ToInt32(TextBox692.Text) + Convert.ToInt32(TextBox838.Text));
            }
            else { TextBox838.Text = Convert.ToString(Convert.ToInt32(TextBox692.Text)); }
            if (TextBox839.Text != "")
            {
                TextBox839.Text = Convert.ToString(Convert.ToInt32(TextBox693.Text) + Convert.ToInt32(TextBox839.Text));
            }
            else { TextBox839.Text = Convert.ToString(Convert.ToInt32(TextBox693.Text)); }
            if (TextBox840.Text != "")
            {
                TextBox840.Text = Convert.ToString(Convert.ToInt32(TextBox694.Text) + Convert.ToInt32(TextBox840.Text));
            }
            else { TextBox840.Text = Convert.ToString(Convert.ToInt32(TextBox694.Text)); }
            if (TextBox841.Text != "")
            {
                TextBox841.Text = Convert.ToString(Convert.ToInt32(TextBox695.Text) + Convert.ToInt32(TextBox841.Text));
            }
            else { TextBox841.Text = Convert.ToString(Convert.ToInt32(TextBox695.Text) ); }
            if (TextBox842.Text != "")
            {
                TextBox842.Text = Convert.ToString(Convert.ToInt32(TextBox696.Text) + Convert.ToInt32(TextBox842.Text));
            }
            else { TextBox842.Text = Convert.ToString(Convert.ToInt32(TextBox696.Text)); }
            if (TextBox835.Text != "" && TextBox836.Text != "" && TextBox837.Text != "" && TextBox838.Text != "" && TextBox839.Text != "" && TextBox840.Text != "" && TextBox841.Text != "" && TextBox842.Text != "")
            {
                TextBox834.Text = Convert.ToString(Convert.ToInt32(TextBox835.Text) + Convert.ToInt32(TextBox836.Text) + Convert.ToInt32(TextBox837.Text) + Convert.ToInt32(TextBox838.Text)
                            + Convert.ToInt32(TextBox839.Text) + Convert.ToInt32(TextBox840.Text) + Convert.ToInt32(TextBox841.Text) + Convert.ToInt32(TextBox842.Text));
            }
            TextBox698.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void Button76_Click(object sender, EventArgs e)
    {
        try
        {
            TextBox697.Text = Convert.ToString(Convert.ToInt32(TextBox698.Text) + Convert.ToInt32(TextBox699.Text) + Convert.ToInt32(TextBox700.Text) + Convert.ToInt32(TextBox701.Text)
                              + Convert.ToInt32(TextBox702.Text) + Convert.ToInt32(TextBox703.Text) + Convert.ToInt32(TextBox704.Text) + Convert.ToInt32(TextBox705.Text));
            TextBox687.Text = Convert.ToString(Convert.ToInt32(TextBox688.Text) + Convert.ToInt32(TextBox697.Text));

            if (TextBox844.Text != "")
            {
                TextBox844.Text = Convert.ToString(Convert.ToInt32(TextBox698.Text) + Convert.ToInt32(TextBox844.Text));
            }
            else { TextBox844.Text = Convert.ToString(Convert.ToInt32(TextBox698.Text)); }
            if (TextBox845.Text != "")
            {
                TextBox845.Text = Convert.ToString(Convert.ToInt32(TextBox699.Text) + Convert.ToInt32(TextBox845.Text));
            }
            else { TextBox845.Text = Convert.ToString(Convert.ToInt32(TextBox699.Text)); }
            if (TextBox846.Text != "")
            {
                TextBox846.Text = Convert.ToString(Convert.ToInt32(TextBox700.Text) + Convert.ToInt32(TextBox846.Text));
            }
            else { TextBox846.Text = Convert.ToString(Convert.ToInt32(TextBox700.Text)); }
            if (TextBox847.Text != "")
            {
                TextBox847.Text = Convert.ToString(Convert.ToInt32(TextBox701.Text) + Convert.ToInt32(TextBox847.Text));
            }
            else { TextBox847.Text = Convert.ToString(Convert.ToInt32(TextBox701.Text)); }
            if (TextBox848.Text != "")
            {
                TextBox848.Text = Convert.ToString(Convert.ToInt32(TextBox702.Text) + Convert.ToInt32(TextBox848.Text));
            }
            else { TextBox848.Text = Convert.ToString(Convert.ToInt32(TextBox702.Text)); }
            if (TextBox849.Text != "")
            {
                TextBox849.Text = Convert.ToString(Convert.ToInt32(TextBox703.Text) + Convert.ToInt32(TextBox849.Text));
            }
            else { TextBox849.Text = Convert.ToString(Convert.ToInt32(TextBox703.Text)); }
            if (TextBox850.Text != "")
            {
                TextBox850.Text = Convert.ToString(Convert.ToInt32(TextBox704.Text) + Convert.ToInt32(TextBox850.Text));
            }
            else { TextBox850.Text = Convert.ToString(Convert.ToInt32(TextBox704.Text)); }
            if (TextBox851.Text != "")
            {
                TextBox851.Text = Convert.ToString(Convert.ToInt32(TextBox705.Text) + Convert.ToInt32(TextBox851.Text));
            }
            else { TextBox851.Text = Convert.ToString(Convert.ToInt32(TextBox705.Text) ); }
            if (TextBox844.Text != "" && TextBox845.Text != "" && TextBox846.Text != "" && TextBox847.Text != "" && TextBox848.Text != "" && TextBox849.Text != "" && TextBox850.Text != "" && TextBox851.Text != "")
            {
                TextBox843.Text = Convert.ToString(Convert.ToInt32(TextBox844.Text) + Convert.ToInt32(TextBox845.Text) + Convert.ToInt32(TextBox846.Text) + Convert.ToInt32(TextBox847.Text)
                            + Convert.ToInt32(TextBox848.Text) + Convert.ToInt32(TextBox849.Text) + Convert.ToInt32(TextBox850.Text) + Convert.ToInt32(TextBox851.Text));
                TextBox833.Text = Convert.ToString(Convert.ToInt32(TextBox834.Text) + Convert.ToInt32(TextBox843.Text));
            }
            TextBox708.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void Button77_Click(object sender, EventArgs e)
    {
        try
        {
            TextBox707.Text = Convert.ToString(Convert.ToInt32(TextBox708.Text) + Convert.ToInt32(TextBox709.Text) + Convert.ToInt32(TextBox710.Text) + Convert.ToInt32(TextBox711.Text)
              + Convert.ToInt32(TextBox712.Text) + Convert.ToInt32(TextBox713.Text) + Convert.ToInt32(TextBox714.Text) + Convert.ToInt32(TextBox715.Text));

            if (TextBox854.Text != "")
            {
                TextBox854.Text = Convert.ToString(Convert.ToInt32(TextBox708.Text) + Convert.ToInt32(TextBox854.Text));
            }
            else { TextBox854.Text = Convert.ToString(Convert.ToInt32(TextBox708.Text)); }
            if (TextBox855.Text != "")
            {
                TextBox855.Text = Convert.ToString(Convert.ToInt32(TextBox709.Text) + Convert.ToInt32(TextBox855.Text));
            }
            else { TextBox855.Text = Convert.ToString(Convert.ToInt32(TextBox709.Text)); }
            if (TextBox856.Text != "")
            {
                TextBox856.Text = Convert.ToString(Convert.ToInt32(TextBox710.Text) + Convert.ToInt32(TextBox856.Text));
            }
            else { TextBox856.Text = Convert.ToString(Convert.ToInt32(TextBox710.Text)); }
            if (TextBox857.Text != "")
            {
                TextBox857.Text = Convert.ToString(Convert.ToInt32(TextBox711.Text) + Convert.ToInt32(TextBox857.Text));
            }
            else { TextBox857.Text = Convert.ToString(Convert.ToInt32(TextBox711.Text)); }
            if (TextBox858.Text != "")
            {
                TextBox858.Text = Convert.ToString(Convert.ToInt32(TextBox712.Text) + Convert.ToInt32(TextBox858.Text));
            }
            else { TextBox858.Text = Convert.ToString(Convert.ToInt32(TextBox712.Text)); }
            if (TextBox859.Text != "")
            {
                TextBox859.Text = Convert.ToString(Convert.ToInt32(TextBox713.Text) + Convert.ToInt32(TextBox859.Text));
            }
            else { TextBox859.Text = Convert.ToString(Convert.ToInt32(TextBox713.Text)); }
            if (TextBox860.Text != "")
            {
                TextBox860.Text = Convert.ToString(Convert.ToInt32(TextBox714.Text) + Convert.ToInt32(TextBox860.Text));
            }
            else { TextBox860.Text = Convert.ToString(Convert.ToInt32(TextBox714.Text)); }
            if (TextBox861.Text != "")
            {
                TextBox861.Text = Convert.ToString(Convert.ToInt32(TextBox715.Text) + Convert.ToInt32(TextBox861.Text));
            }
            else { TextBox861.Text = Convert.ToString(Convert.ToInt32(TextBox715.Text)); }
            if (TextBox854.Text != "" && TextBox855.Text != "" && TextBox856.Text != "" && TextBox857.Text != "" && TextBox858.Text != "" && TextBox859.Text != "" && TextBox860.Text != "" && TextBox861.Text != "")
            {
                TextBox853.Text = Convert.ToString(Convert.ToInt32(TextBox854.Text) + Convert.ToInt32(TextBox855.Text) + Convert.ToInt32(TextBox856.Text) + Convert.ToInt32(TextBox857.Text)
                       + Convert.ToInt32(TextBox858.Text) + Convert.ToInt32(TextBox859.Text) + Convert.ToInt32(TextBox860.Text) + Convert.ToInt32(TextBox861.Text));
                // TextBox833.Text = Convert.ToString(Convert.ToInt32(TextBox834.Text) + Convert.ToInt32(TextBox843.Text));
            }


            TextBox717.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void Button78_Click(object sender, EventArgs e)
    {
        try
        {
            TextBox716.Text = Convert.ToString(Convert.ToInt32(TextBox717.Text) + Convert.ToInt32(TextBox718.Text) + Convert.ToInt32(TextBox719.Text) + Convert.ToInt32(TextBox720.Text)
                         + Convert.ToInt32(TextBox721.Text) + Convert.ToInt32(TextBox722.Text) + Convert.ToInt32(TextBox723.Text) + Convert.ToInt32(TextBox724.Text));
            TextBox706.Text = Convert.ToString(Convert.ToInt32(TextBox707.Text) + Convert.ToInt32(TextBox716.Text));
            //=====
            if (TextBox863.Text != "")
            {
                TextBox863.Text = Convert.ToString(Convert.ToInt32(TextBox717.Text) + Convert.ToInt32(TextBox863.Text));
            }
            else { TextBox863.Text = Convert.ToString(Convert.ToInt32(TextBox717.Text)); }
            if (TextBox864.Text != "")
            {
                TextBox864.Text = Convert.ToString(Convert.ToInt32(TextBox718.Text) + Convert.ToInt32(TextBox864.Text));
            }
            else { TextBox864.Text = Convert.ToString(Convert.ToInt32(TextBox718.Text)); }
            if (TextBox865.Text != "")
            {
                TextBox865.Text = Convert.ToString(Convert.ToInt32(TextBox719.Text) + Convert.ToInt32(TextBox865.Text));
            }
            else { TextBox865.Text = Convert.ToString(Convert.ToInt32(TextBox719.Text)); }
            if (TextBox866.Text != "")
            {
                TextBox866.Text = Convert.ToString(Convert.ToInt32(TextBox720.Text) + Convert.ToInt32(TextBox866.Text));
            }
            else { TextBox866.Text = Convert.ToString(Convert.ToInt32(TextBox720.Text)); }
            if (TextBox867.Text != "")
            {
                TextBox867.Text = Convert.ToString(Convert.ToInt32(TextBox721.Text) + Convert.ToInt32(TextBox867.Text));
            }
            else { TextBox867.Text = Convert.ToString(Convert.ToInt32(TextBox721.Text)); }
            if (TextBox868.Text != "")
            {
                TextBox868.Text = Convert.ToString(Convert.ToInt32(TextBox722.Text) + Convert.ToInt32(TextBox868.Text));
            }
            else { TextBox868.Text = Convert.ToString(Convert.ToInt32(TextBox722.Text)); }
            if (TextBox869.Text != "")
            {
                TextBox869.Text = Convert.ToString(Convert.ToInt32(TextBox723.Text) + Convert.ToInt32(TextBox869.Text));
            }
            else { TextBox869.Text = Convert.ToString(Convert.ToInt32(TextBox723.Text)); }
            if (TextBox870.Text != "")
            {
                TextBox870.Text = Convert.ToString(Convert.ToInt32(TextBox724.Text) + Convert.ToInt32(TextBox870.Text));
            }
            else { TextBox870.Text = Convert.ToString(Convert.ToInt32(TextBox724.Text)); }
            if (TextBox863.Text != "" && TextBox864.Text != "" && TextBox865.Text != "" && TextBox866.Text != "" && TextBox867.Text != "" && TextBox868.Text != "" && TextBox869.Text != "" && TextBox870.Text != "")
            {
                TextBox862.Text = Convert.ToString(Convert.ToInt32(TextBox863.Text) + Convert.ToInt32(TextBox864.Text) + Convert.ToInt32(TextBox865.Text) + Convert.ToInt32(TextBox866.Text)
                            + Convert.ToInt32(TextBox867.Text) + Convert.ToInt32(TextBox868.Text) + Convert.ToInt32(TextBox869.Text) + Convert.ToInt32(TextBox870.Text));
                TextBox852.Text = Convert.ToString(Convert.ToInt32(TextBox853.Text) + Convert.ToInt32(TextBox862.Text));
            }
            TextBox727.Focus();
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void Button79_Click(object sender, EventArgs e)
    {
        TextBox726.Text = Convert.ToString(Convert.ToInt32(TextBox727.Text) + Convert.ToInt32(TextBox728.Text) + Convert.ToInt32(TextBox729.Text) + Convert.ToInt32(TextBox730.Text)
         + Convert.ToInt32(TextBox731.Text) + Convert.ToInt32(TextBox732.Text) + Convert.ToInt32(TextBox733.Text) + Convert.ToInt32(TextBox734.Text));
        TextBox736.Focus();
    }
    protected void Button80_Click(object sender, EventArgs e)
    {
        TextBox735.Text = Convert.ToString(Convert.ToInt32(TextBox736.Text) + Convert.ToInt32(TextBox737.Text) + Convert.ToInt32(TextBox738.Text) + Convert.ToInt32(TextBox739.Text)
                     + Convert.ToInt32(TextBox740.Text) + Convert.ToInt32(TextBox741.Text) + Convert.ToInt32(TextBox742.Text) + Convert.ToInt32(TextBox743.Text));
        TextBox725.Text = Convert.ToString(Convert.ToInt32(TextBox726.Text) + Convert.ToInt32(TextBox735.Text));
        TextBox784.Focus();
    }
    protected void Button81_Click(object sender, EventArgs e)
    {
        TextBox783.Text = Convert.ToString(Convert.ToInt32(TextBox784.Text) + Convert.ToInt32(TextBox785.Text) + Convert.ToInt32(TextBox786.Text) + Convert.ToInt32(TextBox787.Text)
         + Convert.ToInt32(TextBox788.Text));
        TextBox790.Focus();
    }
    protected void Button82_Click(object sender, EventArgs e)
    {
        TextBox789.Text = Convert.ToString(Convert.ToInt32(TextBox790.Text) + Convert.ToInt32(TextBox791.Text) + Convert.ToInt32(TextBox792.Text) + Convert.ToInt32(TextBox793.Text)
                    + Convert.ToInt32(TextBox794.Text));
        TextBox782.Text = Convert.ToString(Convert.ToInt32(TextBox783.Text) + Convert.ToInt32(TextBox789.Text));
        TextBox873.Focus();
    }
    protected void Button83_Click(object sender, EventArgs e)
    {
        TextBox796.Text = Convert.ToString(Convert.ToInt32(TextBox797.Text) + Convert.ToInt32(TextBox798.Text) + Convert.ToInt32(TextBox799.Text) + Convert.ToInt32(TextBox800.Text)
         + Convert.ToInt32(TextBox801.Text) + Convert.ToInt32(TextBox802.Text) + Convert.ToInt32(TextBox803.Text) + Convert.ToInt32(TextBox804.Text));
        TextBox806.Focus();
    }
    protected void Button84_Click(object sender, EventArgs e)
    {
        TextBox805.Text = Convert.ToString(Convert.ToInt32(TextBox806.Text) + Convert.ToInt32(TextBox807.Text) + Convert.ToInt32(TextBox808.Text) + Convert.ToInt32(TextBox809.Text)
                    + Convert.ToInt32(TextBox810.Text) + Convert.ToInt32(TextBox811.Text) + Convert.ToInt32(TextBox812.Text) + Convert.ToInt32(TextBox813.Text));
        TextBox795.Text = Convert.ToString(Convert.ToInt32(TextBox796.Text) + Convert.ToInt32(TextBox805.Text));
        TextBox816.Focus();
    }
    protected void Button85_Click(object sender, EventArgs e)
    {
        TextBox815.Text = Convert.ToString(Convert.ToInt32(TextBox816.Text) + Convert.ToInt32(TextBox817.Text) + Convert.ToInt32(TextBox818.Text) + Convert.ToInt32(TextBox819.Text)
         + Convert.ToInt32(TextBox820.Text) + Convert.ToInt32(TextBox821.Text) + Convert.ToInt32(TextBox822.Text) + Convert.ToInt32(TextBox823.Text));
        TextBox825.Focus();
    }
    protected void Button86_Click(object sender, EventArgs e)
    {
        TextBox824.Text = Convert.ToString(Convert.ToInt32(TextBox825.Text) + Convert.ToInt32(TextBox826.Text) + Convert.ToInt32(TextBox827.Text) + Convert.ToInt32(TextBox828.Text)
                    + Convert.ToInt32(TextBox829.Text) + Convert.ToInt32(TextBox830.Text) + Convert.ToInt32(TextBox831.Text) + Convert.ToInt32(TextBox832.Text));
        TextBox814.Text = Convert.ToString(Convert.ToInt32(TextBox815.Text) + Convert.ToInt32(TextBox824.Text));
        TextBox835.Focus();
    }
    protected void Button87_Click(object sender, EventArgs e)
    {
        TextBox834.Text = Convert.ToString(Convert.ToInt32(TextBox835.Text) + Convert.ToInt32(TextBox836.Text) + Convert.ToInt32(TextBox837.Text) + Convert.ToInt32(TextBox838.Text)
         + Convert.ToInt32(TextBox839.Text) + Convert.ToInt32(TextBox840.Text) + Convert.ToInt32(TextBox841.Text) + Convert.ToInt32(TextBox842.Text));
        TextBox844.Focus();
    }
    protected void Button88_Click(object sender, EventArgs e)
    {
        TextBox843.Text = Convert.ToString(Convert.ToInt32(TextBox844.Text) + Convert.ToInt32(TextBox845.Text) + Convert.ToInt32(TextBox846.Text) + Convert.ToInt32(TextBox847.Text)
                    + Convert.ToInt32(TextBox848.Text) + Convert.ToInt32(TextBox849.Text) + Convert.ToInt32(TextBox850.Text) + Convert.ToInt32(TextBox851.Text));
        TextBox833.Text = Convert.ToString(Convert.ToInt32(TextBox834.Text) + Convert.ToInt32(TextBox843.Text));
        TextBox854.Focus();
    }
    protected void Button89_Click(object sender, EventArgs e)
    {
        TextBox853.Text = Convert.ToString(Convert.ToInt32(TextBox854.Text) + Convert.ToInt32(TextBox855.Text) + Convert.ToInt32(TextBox856.Text) + Convert.ToInt32(TextBox857.Text)
         + Convert.ToInt32(TextBox858.Text) + Convert.ToInt32(TextBox859.Text) + Convert.ToInt32(TextBox860.Text) + Convert.ToInt32(TextBox861.Text));
        TextBox863.Focus();
    }
    protected void Button90_Click(object sender, EventArgs e)
    {
        TextBox862.Text = Convert.ToString(Convert.ToInt32(TextBox863.Text) + Convert.ToInt32(TextBox864.Text) + Convert.ToInt32(TextBox865.Text) + Convert.ToInt32(TextBox866.Text)
                    + Convert.ToInt32(TextBox867.Text) + Convert.ToInt32(TextBox868.Text) + Convert.ToInt32(TextBox869.Text) + Convert.ToInt32(TextBox870.Text));
        TextBox852.Text = Convert.ToString(Convert.ToInt32(TextBox853.Text) + Convert.ToInt32(TextBox862.Text));
        TextBox873.Focus();
    }
    protected void Button91_Click(object sender, EventArgs e)
    {
        TextBox872.Text = Convert.ToString(Convert.ToInt32(TextBox873.Text) + Convert.ToInt32(TextBox874.Text) + Convert.ToInt32(TextBox875.Text) + Convert.ToInt32(TextBox876.Text)
         + Convert.ToInt32(TextBox877.Text) + Convert.ToInt32(TextBox878.Text) + Convert.ToInt32(TextBox879.Text) + Convert.ToInt32(TextBox880.Text));
        TextBox882.Focus();
    }
    protected void Button92_Click(object sender, EventArgs e)
    {
        TextBox881.Text = Convert.ToString(Convert.ToInt32(TextBox882.Text) + Convert.ToInt32(TextBox883.Text) + Convert.ToInt32(TextBox884.Text) + Convert.ToInt32(TextBox885.Text)
                    + Convert.ToInt32(TextBox886.Text) + Convert.ToInt32(TextBox887.Text) + Convert.ToInt32(TextBox888.Text) + Convert.ToInt32(TextBox889.Text));
        TextBox871.Text = Convert.ToString(Convert.ToInt32(TextBox872.Text) + Convert.ToInt32(TextBox881.Text));
        TextBox892.Focus();
    }
    protected void Button93_Click(object sender, EventArgs e)
    {
        TextBox891.Text = Convert.ToString(Convert.ToInt32(TextBox892.Text) + Convert.ToInt32(TextBox893.Text) + Convert.ToInt32(TextBox894.Text) + Convert.ToInt32(TextBox895.Text)
        + Convert.ToInt32(TextBox896.Text) + Convert.ToInt32(TextBox897.Text) + Convert.ToInt32(TextBox898.Text) + Convert.ToInt32(TextBox899.Text));
        TextBox901.Focus();
    }
    protected void Button94_Click(object sender, EventArgs e)
    {
        TextBox900.Text = Convert.ToString(Convert.ToInt32(TextBox901.Text) + Convert.ToInt32(TextBox902.Text) + Convert.ToInt32(TextBox903.Text) + Convert.ToInt32(TextBox904.Text)
                    + Convert.ToInt32(TextBox905.Text) + Convert.ToInt32(TextBox906.Text) + Convert.ToInt32(TextBox907.Text) + Convert.ToInt32(TextBox908.Text));
        TextBox890.Text = Convert.ToString(Convert.ToInt32(TextBox891.Text) + Convert.ToInt32(TextBox900.Text));
        TextBox911.Focus();
    }
    protected void Button95_Click(object sender, EventArgs e)
    {
        TextBox910.Text = Convert.ToString(Convert.ToInt32(TextBox911.Text) + Convert.ToInt32(TextBox912.Text) + Convert.ToInt32(TextBox913.Text) + Convert.ToInt32(TextBox914.Text));
        TextBox916.Focus();
    }
    protected void Button96_Click(object sender, EventArgs e)
    {
        TextBox915.Text = Convert.ToString(Convert.ToInt32(TextBox916.Text) + Convert.ToInt32(TextBox917.Text) + Convert.ToInt32(TextBox918.Text) + Convert.ToInt32(TextBox919.Text));
        TextBox909.Text = Convert.ToString(Convert.ToInt32(TextBox910.Text) + Convert.ToInt32(TextBox915.Text));
        TextBox922.Focus();
    }
    protected void Button97_Click(object sender, EventArgs e)
    {
        TextBox921.Text = Convert.ToString(Convert.ToInt32(TextBox922.Text) + Convert.ToInt32(TextBox923.Text) + Convert.ToInt32(TextBox924.Text) + Convert.ToInt32(TextBox925.Text));
        TextBox927.Focus();
    }
    protected void Button98_Click(object sender, EventArgs e)
    {
        TextBox926.Text = Convert.ToString(Convert.ToInt32(TextBox927.Text) + Convert.ToInt32(TextBox928.Text) + Convert.ToInt32(TextBox929.Text) + Convert.ToInt32(TextBox930.Text));
        TextBox920.Text = Convert.ToString(Convert.ToInt32(TextBox921.Text) + Convert.ToInt32(TextBox926.Text));
        TextBox933.Focus();
    }
    protected void Button99_Click(object sender, EventArgs e)
    {
        TextBox932.Text = Convert.ToString(Convert.ToInt32(TextBox933.Text) + Convert.ToInt32(TextBox934.Text) + Convert.ToInt32(TextBox935.Text) + Convert.ToInt32(TextBox936.Text)
                        + Convert.ToInt32(TextBox937.Text) + Convert.ToInt32(TextBox938.Text) + Convert.ToInt32(TextBox939.Text) + Convert.ToInt32(TextBox940.Text));
        TextBox942.Focus();
    }
    protected void Button100_Click(object sender, EventArgs e)
    {
        TextBox941.Text = Convert.ToString(Convert.ToInt32(TextBox942.Text) + Convert.ToInt32(TextBox943.Text) + Convert.ToInt32(TextBox944.Text) + Convert.ToInt32(TextBox945.Text)
                        + Convert.ToInt32(TextBox946.Text) + Convert.ToInt32(TextBox947.Text) + Convert.ToInt32(TextBox948.Text) + Convert.ToInt32(TextBox949.Text));
        TextBox931.Text = Convert.ToString(Convert.ToInt32(TextBox932.Text) + Convert.ToInt32(TextBox941.Text));
        TextBox952.Focus();
    }
    protected void Button101_Click(object sender, EventArgs e)
    {
        TextBox951.Text = Convert.ToString(Convert.ToInt32(TextBox952.Text) + Convert.ToInt32(TextBox953.Text) + Convert.ToInt32(TextBox954.Text) + Convert.ToInt32(TextBox955.Text)
                        + Convert.ToInt32(TextBox956.Text) + Convert.ToInt32(TextBox957.Text) + Convert.ToInt32(TextBox958.Text) + Convert.ToInt32(TextBox959.Text));
        TextBox961.Focus();
    }
    protected void Button102_Click(object sender, EventArgs e)
    {
        TextBox960.Text = Convert.ToString(Convert.ToInt32(TextBox961.Text) + Convert.ToInt32(TextBox962.Text) + Convert.ToInt32(TextBox963.Text) + Convert.ToInt32(TextBox964.Text)
                        + Convert.ToInt32(TextBox965.Text) + Convert.ToInt32(TextBox966.Text) + Convert.ToInt32(TextBox967.Text) + Convert.ToInt32(TextBox968.Text));
        TextBox950.Text = Convert.ToString(Convert.ToInt32(TextBox951.Text) + Convert.ToInt32(TextBox960.Text));
        TextBox971.Focus();
    }
    protected void Button103_Click(object sender, EventArgs e)
    {
        TextBox970.Text = Convert.ToString(Convert.ToInt32(TextBox971.Text) + Convert.ToInt32(TextBox972.Text) + Convert.ToInt32(TextBox973.Text) + Convert.ToInt32(TextBox974.Text)
                       + Convert.ToInt32(TextBox975.Text) + Convert.ToInt32(TextBox976.Text) + Convert.ToInt32(TextBox977.Text) + Convert.ToInt32(TextBox978.Text));
        TextBox980.Focus();
    }
    protected void Button104_Click(object sender, EventArgs e)
    {
        TextBox979.Text = Convert.ToString(Convert.ToInt32(TextBox980.Text) + Convert.ToInt32(TextBox981.Text) + Convert.ToInt32(TextBox982.Text) + Convert.ToInt32(TextBox983.Text)
                        + Convert.ToInt32(TextBox984.Text) + Convert.ToInt32(TextBox985.Text) + Convert.ToInt32(TextBox986.Text) + Convert.ToInt32(TextBox987.Text));
        TextBox969.Text = Convert.ToString(Convert.ToInt32(TextBox970.Text) + Convert.ToInt32(TextBox979.Text));
        TextBox990.Focus();
    }
    protected void Button105_Click(object sender, EventArgs e)
    {
        TextBox989.Text = Convert.ToString(Convert.ToInt32(TextBox990.Text) + Convert.ToInt32(TextBox991.Text) + Convert.ToInt32(TextBox992.Text) + Convert.ToInt32(TextBox993.Text)
                       + Convert.ToInt32(TextBox994.Text) + Convert.ToInt32(TextBox995.Text) + Convert.ToInt32(TextBox996.Text) + Convert.ToInt32(TextBox997.Text));
        TextBox999.Focus();
    }
    protected void Button106_Click(object sender, EventArgs e)
    {
        TextBox998.Text = Convert.ToString(Convert.ToInt32(TextBox999.Text) + Convert.ToInt32(TextBox1000.Text) + Convert.ToInt32(TextBox1001.Text) + Convert.ToInt32(TextBox1002.Text)
                        + Convert.ToInt32(TextBox1003.Text) + Convert.ToInt32(TextBox1004.Text) + Convert.ToInt32(TextBox1005.Text) + Convert.ToInt32(TextBox1006.Text));
        TextBox988.Text = Convert.ToString(Convert.ToInt32(TextBox989.Text) + Convert.ToInt32(TextBox998.Text));
        TextBox1009.Focus();
    }
    protected void Button107_Click(object sender, EventArgs e)
    {
        TextBox1008.Text = Convert.ToString(Convert.ToInt32(TextBox1009.Text) + Convert.ToInt32(TextBox1010.Text) + Convert.ToInt32(TextBox1011.Text) + Convert.ToInt32(TextBox1012.Text)
                       + Convert.ToInt32(TextBox1013.Text) + Convert.ToInt32(TextBox1014.Text) + Convert.ToInt32(TextBox1015.Text) + Convert.ToInt32(TextBox1016.Text));
        TextBox1018.Focus();
    }
    protected void Button108_Click(object sender, EventArgs e)
    {
        TextBox1017.Text = Convert.ToString(Convert.ToInt32(TextBox1018.Text) + Convert.ToInt32(TextBox1019.Text) + Convert.ToInt32(TextBox1020.Text) + Convert.ToInt32(TextBox1021.Text)
                        + Convert.ToInt32(TextBox1022.Text) + Convert.ToInt32(TextBox1023.Text) + Convert.ToInt32(TextBox1024.Text) + Convert.ToInt32(TextBox1025.Text));
        TextBox1007.Text = Convert.ToString(Convert.ToInt32(TextBox1008.Text) + Convert.ToInt32(TextBox1017.Text));
        TextBox1028.Focus();
    }
    protected void Button109_Click(object sender, EventArgs e)
    {
        TextBox1027.Text = Convert.ToString(Convert.ToInt32(TextBox1028.Text) + Convert.ToInt32(TextBox1029.Text) + Convert.ToInt32(TextBox1030.Text) + Convert.ToInt32(TextBox1031.Text)
                      + Convert.ToInt32(TextBox1032.Text) + Convert.ToInt32(TextBox1033.Text) + Convert.ToInt32(TextBox1034.Text) + Convert.ToInt32(TextBox1035.Text));
        TextBox1037.Focus();

    }
    protected void Button110_Click(object sender, EventArgs e)
    {
        TextBox1036.Text = Convert.ToString(Convert.ToInt32(TextBox1037.Text) + Convert.ToInt32(TextBox1038.Text) + Convert.ToInt32(TextBox1039.Text) + Convert.ToInt32(TextBox1040.Text)
                        + Convert.ToInt32(TextBox1041.Text) + Convert.ToInt32(TextBox1042.Text) + Convert.ToInt32(TextBox1043.Text) + Convert.ToInt32(TextBox1044.Text));
        TextBox1026.Text = Convert.ToString(Convert.ToInt32(TextBox1027.Text) + Convert.ToInt32(TextBox1036.Text));
        TextBox1045.Focus();
    }
    protected void Button111_Click(object sender, EventArgs e)
    {
        TextBox1048.Text = Convert.ToString(Convert.ToInt32(TextBox1049.Text) + Convert.ToInt32(TextBox1050.Text) + Convert.ToInt32(TextBox1051.Text) + Convert.ToInt32(TextBox1052.Text));
        TextBox1054.Focus();
    }
    protected void Button112_Click(object sender, EventArgs e)
    {
        TextBox1053.Text = Convert.ToString(Convert.ToInt32(TextBox1054.Text) + Convert.ToInt32(TextBox1055.Text) + Convert.ToInt32(TextBox1056.Text) + Convert.ToInt32(TextBox1057.Text));
        TextBox1047.Text = Convert.ToString(Convert.ToInt32(TextBox1048.Text) + Convert.ToInt32(TextBox1053.Text));
        TextBox1060.Focus();
    }
    protected void Button113_Click(object sender, EventArgs e)
    {
        TextBox1059.Text = Convert.ToString(Convert.ToInt32(TextBox1060.Text) + Convert.ToInt32(TextBox1061.Text) + Convert.ToInt32(TextBox1062.Text) + Convert.ToInt32(TextBox1063.Text));
        TextBox1065.Focus();
    }
    protected void Button114_Click(object sender, EventArgs e)
    {
        TextBox1064.Text = Convert.ToString(Convert.ToInt32(TextBox1065.Text) + Convert.ToInt32(TextBox1066.Text) + Convert.ToInt32(TextBox1067.Text) + Convert.ToInt32(TextBox1068.Text));
        TextBox1058.Text = Convert.ToString(Convert.ToInt32(TextBox1059.Text) + Convert.ToInt32(TextBox1064.Text));
        TextBox1070.Focus();
    }
    protected void Button115_Click(object sender, EventArgs e)
    {
        TextBox1069.Text = Convert.ToString(Convert.ToInt32(TextBox1070.Text) + Convert.ToInt32(TextBox1071.Text));
        btnSave.Focus();
    }
    protected void drpThematic_SelectedIndexChanged1(object sender, EventArgs e)
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
    protected void TextBox1046_TextChanged(object sender, EventArgs e)
    {
        TextBox1049.Focus();
    }
    protected void Button118_Click(object sender, EventArgs e)
    {
        TextBox1049.Focus();
    }
}