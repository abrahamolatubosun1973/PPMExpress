using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{

    // Get the Names of the Moths in a year using C# code
    protected void Months()
    {
        try
        {
            string[] monthNames = (new System.Globalization.CultureInfo("en-US")).DateTimeFormat.MonthNames;
            foreach (string m in monthNames) // writing out
            {
                drpMnth1.Items.Add(m);
                drpMnth2.Items.Add(m);
            }
            drpMnth1.Items.Insert(0, "Select");
            drpMnth1.SelectedIndex = 0;
            drpMnth2.Items.Insert(0, "Select");
            drpMnth2.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
            return;
        }
    }


    protected void AddYrs()
    {
        int cnt = 2020;
        for (int i = 2001; i <= cnt; i++)
        {
            drpYear.Items.Add(i.ToString());
        }

        drpYear.Items.Insert(0, "Select");
        drpYear.SelectedIndex = 0;
    }

    protected void FillThematic()
    {
        try
        {
        string SQl = "Select * from tbl_grpname order by abrv asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
       
            drpThematic.ClearSelection();
            drpThematic.Items.Clear();
            drpThematic.Items.Add("");
            while (r.Read()) { drpThematic.Items.Add(r["fname"].ToString()); }

        }
        catch (Exception e)
        {
            Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
            return;
        }
    }

    protected void SumTable(string TblName)
    {
        try
        {
            string SQL = "SELECT * from " + TblName + " where num";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cmd = new SqlCommand(SQL, cn);
            int cnt = ((int)cmd.ExecuteScalar());
            cn.Close();
        }
        catch (Exception ex)
        {

        }
    }

    protected void CreateXML(string TblName)
    {
        #region how to create and delete directory

        // string directoryPath = Server.MapPath(string.Format("~/{0}/", txtFolderName.Text.Trim()));
        // if (!Directory.Exists(directoryPath))
        // {
        //     Directory.CreateDirectory(directoryPath);
        // }
        // else
        // {
        //     ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory already exists.');", true);
        // }
        //// =============================================================================================
        // string directoryPath = Server.MapPath(string.Format("~/{0}/", txtFolderName.Text.Trim()));
        // if (Directory.Exists(directoryPath))
        // {
        //     Directory.Delete(directoryPath);
        // }
        // else
        // {
        //     ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory does not exist.');", true);
        // }

        #endregion

        try
        {
            string mName = TblName.Trim() + "_" + TextBox15.Text.Trim() + "_" + drpMnth2.SelectedItem.Text + "_" + DateTime.Now.Year.ToString();
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            string strSQL = "Select * from " + TblName.Trim();

            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);

            DataSet ds = new DataSet();

            dt.Fill(ds, TblName.Trim());

            ds.WriteXml(@"C:\PPMExpress\XML\" + mName + ".xml");

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + TblName.Trim() + " " + ex.Message.ToString() + "');</script>");
            return;
        }
    }


    protected void XMLImport(string Tname, string Tbl_Name)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());


            DataSet reportData = new DataSet();

            reportData.ReadXml(Tname);
            con.Open();

            foreach (DataTable dt in reportData.Tables)
            {
                SqlBulkCopy sbc = new SqlBulkCopy(con);
                sbc.DestinationTableName = Tbl_Name.Trim();
                foreach (DataColumn dc in dt.Columns)
                {
                    sbc.ColumnMappings.Add(dc.ColumnName, dc.ColumnName);

                }// Second Foreach

                sbc.WriteToServer(dt);
            }// First Foreach
            con.Close();


        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('Error " + ex.Message.Trim() + " from table name " + Tname + "');</script>");
            return;
        }
    }

    protected void page_Init(object sender, EventArgs e)
    {
        if (BrowserUpLevel.IsUplevel)
        {
            Page.ClientTarget = "uplevel";
        }

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Session["mChoose"]= null;
            //Session["mState"] = null;
            //Session["mLGA"] = null;
            //Session["mFacility"] = null;
            //Session["mMnth"] = null;
            //Session["mYr"] = null;

            Months();
            AddYrs();
            FillThematic();
            SumThematic();
           
            TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));// ART Thematic Area
            TextBox2.Text = Convert.ToString(SumSQL("dbo.fn_CARESUM()"));// CARE
            TextBox3.Text = Convert.ToString(SumSQL("dbo.fn_HTCSUM()"));// HTC Thematic Area
            //TextBox4.Text = Convert.ToString(SumSQL("dbo.fn_LABSUM()"));//HIVI
            //TextBox5.Text = Convert.ToString(SumSQL("dbo.fn_LABSUM()"));//GN
            TextBox6.Text = Convert.ToString(SumSQL("dbo.fn_LABSUM()"));//LAB
            //TextBox7.Text = Convert.ToString(SumSQL("dbo.fn_LABSUM()"));//FN
            TextBox8.Text = Convert.ToString(SumSQL("dbo.fn_OVCSUM()"));//OVC
            TextBox9.Text = Convert.ToString(SumSQL("dbo.fn_PMTCTSUM()"));//PMTCT
            //TextBox10.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));//PEP
            //TextBox11.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));//PP
            //TextBox12.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));//TB
            //TextBox13.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));//TRAINING

            //TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));// ART Thematic Area
            //TextBox2.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));
            //TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));
            //TextBox3.Text = Convert.ToString(SumSQL("dbo.fn_HTCSUM()"));// HTC Thematic Area
            //TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));// ART Thematic Area
            //TextBox2.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));
            //TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));
            //TextBox3.Text = Convert.ToString(SumSQL("dbo.fn_HTCSUM()"));// HTC Thematic Area
            //TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));// ART Thematic Area
            //TextBox2.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));
            //TextBox1.Text = Convert.ToString(SumSQL("dbo.fn_ARTSUM()"));
        }
    }

    protected void SumThematic()
    {
        int TART = 0; int THTC = 0; int TLAB = 0;
        int ART1 = 0; int ART2 = 0; 

        string SQLART1 = "SELECT * from tbl_ART1 ";
        string SQLART2 = "SELECT * from tbl_ART2 ";

        try{
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(SQLART1,cn);
            SqlDataReader r = cmd.ExecuteReader();
            while(r.Read()){
             ART1 +=(Convert.ToInt32(r["TOTALG1"].ToString())+
                Convert.ToInt32(r["SUBG1MA"].ToString())+
                Convert.ToInt32(r["G1MA1"].ToString())+
                Convert.ToInt32(r["G1MA1_4"].ToString())+
                Convert.ToInt32(r["G1MA5_9"].ToString())+
                Convert.ToInt32(r["G1MA10_14"].ToString())+
                Convert.ToInt32(r["G1MA15_19"].ToString())+
                Convert.ToInt32(r["G1MA20_24"].ToString())+
                Convert.ToInt32(r["G1MA25_49"].ToString())+
                Convert.ToInt32(r["G1MA50"].ToString())+
                Convert.ToInt32(r["SUBG1FE"].ToString())+
                Convert.ToInt32(r["G1FE1"].ToString())+
                Convert.ToInt32(r["G1FE1_4"].ToString())+
                Convert.ToInt32(r["G1FE5_9"].ToString())+
                Convert.ToInt32(r["G1FE10_14"].ToString())+
                Convert.ToInt32(r["G1FE15_19"].ToString())+
                Convert.ToInt32(r["G1FE20_24"].ToString())+
                Convert.ToInt32(r["G1FE25_49"].ToString())+
                Convert.ToInt32(r["G1FE50"].ToString())+
                Convert.ToInt32(r["G1PREGNANT"].ToString())+
                Convert.ToInt32(r["G1BREASTFEED"].ToString())+
                Convert.ToInt32(r["TOTALG2"].ToString())+
                Convert.ToInt32(r["SUBG2MA"].ToString())+
                Convert.ToInt32(r["G2MA1"].ToString())+
                Convert.ToInt32(r["G2MA1_4"].ToString())+
                Convert.ToInt32(r["G2MA5_9"].ToString())+
                Convert.ToInt32(r["G2MA10_14"].ToString())+
                Convert.ToInt32(r["G2MA15_19"].ToString())+
                Convert.ToInt32(r["G2MA20_24"].ToString())+
                Convert.ToInt32(r["G2MA25_49"].ToString())+
                Convert.ToInt32(r["G2MA50"].ToString())+
                Convert.ToInt32(r["SUBG2FE"].ToString())+
                Convert.ToInt32(r["G2FE1"].ToString())+
                Convert.ToInt32(r["G2FE1_4"].ToString())+
                Convert.ToInt32(r["G2FE5_9"].ToString())+
                Convert.ToInt32(r["G2FE10_14"].ToString())+
                Convert.ToInt32(r["G2FE15_19"].ToString())+
                Convert.ToInt32(r["G2FE20_24"].ToString())+
                Convert.ToInt32(r["G2FE25_49"].ToString())+
                Convert.ToInt32(r["G2FE50"].ToString())+
                Convert.ToInt32(r["G2PREGNANT"].ToString())+
                Convert.ToInt32(r["G2BREASTFEED"].ToString())+
                Convert.ToInt32(r["TOTALG3"].ToString())+
                Convert.ToInt32(r["SUBG3MA"].ToString())+
                Convert.ToInt32(r["G3MA1"].ToString())+
                Convert.ToInt32(r["G3MA1_4"].ToString())+
                Convert.ToInt32(r["G3MA5_9"].ToString())+
                Convert.ToInt32(r["G3MA10_14"].ToString())+
                Convert.ToInt32(r["G3MA15_19"].ToString())+
                Convert.ToInt32(r["G3MA20_24"].ToString())+
                Convert.ToInt32(r["G3MA25_49"].ToString())+
                Convert.ToInt32(r["G3MA50"].ToString())+
                Convert.ToInt32(r["SUBG3FE"].ToString())+
                Convert.ToInt32(r["G3FE1"].ToString())+
                Convert.ToInt32(r["G3FE1_4"].ToString())+
                Convert.ToInt32(r["G3FE5_9"].ToString())+
                Convert.ToInt32(r["G3FE10_14"].ToString())+
                Convert.ToInt32(r["G3FE15_19"].ToString())+
                Convert.ToInt32(r["G3FE20_24"].ToString())+
                Convert.ToInt32(r["G3FE25_49"].ToString())+
                Convert.ToInt32(r["G3FE50"].ToString())+
                Convert.ToInt32(r["G3PREGNANT"].ToString())+
                Convert.ToInt32(r["G3BREASTFEED"].ToString())+
                Convert.ToInt32(r["G3FSW"].ToString())+
                Convert.ToInt32(r["G3MSM_TG"].ToString())+
                Convert.ToInt32(r["G3PWID"].ToString())+
                Convert.ToInt32(r["TOTALG4"].ToString())+
                Convert.ToInt32(r["SUBG4MA"].ToString())+
                Convert.ToInt32(r["G4MA1"].ToString())+
                Convert.ToInt32(r["G4MA1_4"].ToString())+
                Convert.ToInt32(r["G4MA5_9"].ToString())+
                Convert.ToInt32(r["G4MA10_14"].ToString())+
                Convert.ToInt32(r["G4MA15_19"].ToString())+
                Convert.ToInt32(r["G4MA20_24"].ToString())+
                Convert.ToInt32(r["G4MA25_49"].ToString())+
                Convert.ToInt32(r["G4MA50"].ToString())+
                Convert.ToInt32(r["SUBG4FE"].ToString())+
                Convert.ToInt32(r["G4FE1"].ToString())+
                Convert.ToInt32(r["G4FE1_4"].ToString())+
                Convert.ToInt32(r["G4FE5_9"].ToString())+
                Convert.ToInt32(r["G4FE10_14"].ToString())+
                Convert.ToInt32(r["G4FE15_19"].ToString())+
                Convert.ToInt32(r["G4FE20_24"].ToString())+
                Convert.ToInt32(r["G4FE25_49"].ToString())+
                Convert.ToInt32(r["G4FE50"].ToString())+
                Convert.ToInt32(r["TOTALG5"].ToString())+
                Convert.ToInt32(r["SUBG5MA"].ToString())+
                Convert.ToInt32(r["G5MA1"].ToString())+
                Convert.ToInt32(r["G5MA1_4"].ToString())+
                Convert.ToInt32(r["G5MA5_9"].ToString())+
                Convert.ToInt32(r["G5MA10_14"].ToString())+
                Convert.ToInt32(r["G5MA15_19"].ToString())+
                Convert.ToInt32(r["G5MA20_24"].ToString())+
                Convert.ToInt32(r["G5MA25_49"].ToString())+
                Convert.ToInt32(r["G5MA50"].ToString())+
                Convert.ToInt32(r["SUBG5FE"].ToString())+
                Convert.ToInt32(r["G54FE1"].ToString())+
                Convert.ToInt32(r["G5FE1_4"].ToString())+
                Convert.ToInt32(r["G5FE5_9"].ToString())+
                Convert.ToInt32(r["G5FE10_14"].ToString())+
                Convert.ToInt32(r["G5FE15_19"].ToString())+
                Convert.ToInt32(r["G5FE20_24"].ToString())+
                Convert.ToInt32(r["G5FE25_49"].ToString())+
                Convert.ToInt32(r["G5FE50"].ToString())+
                Convert.ToInt32(r["TOTALG6"].ToString())+
                Convert.ToInt32(r["SUBG6MA"].ToString())+
                Convert.ToInt32(r["G6MA1"].ToString())+
                Convert.ToInt32(r["G6MA1_4"].ToString())+
                Convert.ToInt32(r["G6MA5_9"].ToString())+
                Convert.ToInt32(r["G6MA10_14"].ToString())+
                Convert.ToInt32(r["G6MA15_19"].ToString())+
                Convert.ToInt32(r["G6MA20_24"].ToString())+
                Convert.ToInt32(r["G6MA25_49"].ToString())+
                Convert.ToInt32(r["G6MA50"].ToString())+
                Convert.ToInt32(r["SUBG6FE"].ToString())+
                Convert.ToInt32(r["G6FE1"].ToString())+
                Convert.ToInt32(r["G6FE1_4"].ToString())+
                Convert.ToInt32(r["G6FE5_9"].ToString())+
                Convert.ToInt32(r["G6FE10_14"].ToString())+
                Convert.ToInt32(r["G6FE15_19"].ToString())+
                Convert.ToInt32(r["G6FE20_24"].ToString())+
                Convert.ToInt32(r["G6FE25_49"].ToString())+
                Convert.ToInt32(r["G6FE50"].ToString())+
                Convert.ToInt32(r["TOTALG7"].ToString())+
                Convert.ToInt32(r["SUBG7MA"].ToString())+
                Convert.ToInt32(r["G7MA1"].ToString())+
                Convert.ToInt32(r["G7MA1_4"].ToString())+
                Convert.ToInt32(r["G7MA5_9"].ToString())+
                Convert.ToInt32(r["G7MA10_14"].ToString())+
                Convert.ToInt32(r["G7MA15_19"].ToString())+
                Convert.ToInt32(r["G7MA20_24"].ToString())+
                Convert.ToInt32(r["G7MA25_49"].ToString())+
                Convert.ToInt32(r["G7MA50"].ToString())+
                Convert.ToInt32(r["SUBG7FE"].ToString())+
                Convert.ToInt32(r["G7FE1"].ToString())+
                Convert.ToInt32(r["G7FE1_4"].ToString())+
                Convert.ToInt32(r["G7FE5_9"].ToString())+
                Convert.ToInt32(r["G7FE10_14"].ToString())+
                Convert.ToInt32(r["G7FE15_19"].ToString())+
                Convert.ToInt32(r["G7FE20_24"].ToString())+
                Convert.ToInt32(r["G7FE25_49"].ToString())+
                Convert.ToInt32(r["G7FE50"].ToString())+
                Convert.ToInt32(r["TOTALG8"].ToString())+
                Convert.ToInt32(r["SUBG8MA"].ToString())+
                Convert.ToInt32(r["G8MA1"].ToString())+
                Convert.ToInt32(r["G8MA1_4"].ToString())+
                Convert.ToInt32(r["G8MA5_9"].ToString())+
                Convert.ToInt32(r["G8MA10_14"].ToString())+
                Convert.ToInt32(r["G8MA15_19"].ToString())+
                Convert.ToInt32(r["G8MA20_24"].ToString())+
                Convert.ToInt32(r["G8MA25_49"].ToString())+
                Convert.ToInt32(r["G8MA50"].ToString())+
                Convert.ToInt32(r["SUBG8FE"].ToString())+
                Convert.ToInt32(r["G8FE1"].ToString())+
                Convert.ToInt32(r["G8FE1_4"].ToString())+
                Convert.ToInt32(r["G8FE5_9"].ToString())+
                Convert.ToInt32(r["G8FE10_14"].ToString())+
                Convert.ToInt32(r["G8FE15_19"].ToString())+
                Convert.ToInt32(r["G8FE20_24"].ToString())+
                Convert.ToInt32(r["G8FE25_49"].ToString())+
                Convert.ToInt32(r["G8FE50"].ToString())+
                Convert.ToInt32(r["TOTALG9"].ToString())+
                Convert.ToInt32(r["SUBG9MA"].ToString())+
                Convert.ToInt32(r["G9MA1"].ToString())+
                Convert.ToInt32(r["G9MA1_4"].ToString())+
                Convert.ToInt32(r["G9MA5_9"].ToString())+
                Convert.ToInt32(r["G9MA10_14"].ToString())+
                Convert.ToInt32(r["G9MA15_19"].ToString())+
                Convert.ToInt32(r["G9MA20_24"].ToString())+
                Convert.ToInt32(r["G9MA25_49"].ToString())+
                Convert.ToInt32(r["G9MA50"].ToString())+
                Convert.ToInt32(r["SUBG9FE"].ToString())+
                Convert.ToInt32(r["G9FE1"].ToString())+
                Convert.ToInt32(r["G9FE1_4"].ToString())+
                Convert.ToInt32(r["G9FE5_9"].ToString())+
                Convert.ToInt32(r["G9FE10_14"].ToString())+
                Convert.ToInt32(r["G9FE15_19"].ToString())+
                Convert.ToInt32(r["G9FE20_24"].ToString())+
                Convert.ToInt32(r["G9FE25_49"].ToString())+
                Convert.ToInt32(r["G9FE50"].ToString())+
                Convert.ToInt32(r["TOTALG10"].ToString())+
                Convert.ToInt32(r["SUBG10MA"].ToString())+
                Convert.ToInt32(r["G10MA1"].ToString())+
                Convert.ToInt32(r["G10MA1_4"].ToString())+
                Convert.ToInt32(r["G10MA5_9"].ToString())+
                Convert.ToInt32(r["G10MA10_14"].ToString())+
                Convert.ToInt32(r["G10MA15_19"].ToString())+
                Convert.ToInt32(r["G10MA20_24"].ToString())+
                Convert.ToInt32(r["G10MA25_49"].ToString()));
            }
            r.Close();

            
            SqlCommand cmd1 = new SqlCommand(SQLART2, cn);
             r = cmd1.ExecuteReader();
             while (r.Read())
             {
                  ART2 += (Convert.ToInt32(r["G10MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG10FE"].ToString()) +
                     Convert.ToInt32(r["G10FE1"].ToString()) +
                     Convert.ToInt32(r["G10FE1_4"].ToString()) +
                     Convert.ToInt32(r["G10FE5_9"].ToString()) +
                     Convert.ToInt32(r["G10FE10_14"].ToString()) +
                     Convert.ToInt32(r["G10FE15_19"].ToString()) +
                     Convert.ToInt32(r["G10FE20_24"].ToString()) +
                     Convert.ToInt32(r["G10FE25_49"].ToString()) +
                     Convert.ToInt32(r["G10FE50"].ToString()) +
                     Convert.ToInt32(r["G10PREGNANT"].ToString()) +
                     Convert.ToInt32(r["G10BREASTFEED"].ToString()) +
                     Convert.ToInt32(r["G10ROUTINE"].ToString()) +
                     Convert.ToInt32(r["G10TARGET"].ToString()) +
                     Convert.ToInt32(r["TOTALG11"].ToString()) +
                     Convert.ToInt32(r["SUBG11MA"].ToString()) +
                     Convert.ToInt32(r["G11MA1"].ToString()) +
                     Convert.ToInt32(r["G11MA1_4"].ToString()) +
                     Convert.ToInt32(r["G11MA5_9"].ToString()) +
                     Convert.ToInt32(r["G11MA10_14"].ToString()) +
                     Convert.ToInt32(r["G11MA15_19"].ToString()) +
                     Convert.ToInt32(r["G11MA20_24"].ToString()) +
                     Convert.ToInt32(r["G11MA25_49"].ToString()) +
                     Convert.ToInt32(r["G11MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG11FE"].ToString()) +
                     Convert.ToInt32(r["G11FE1"].ToString()) +
                     Convert.ToInt32(r["G11FE1_4"].ToString()) +
                     Convert.ToInt32(r["G11FE5_9"].ToString()) +
                     Convert.ToInt32(r["G11FE10_14"].ToString()) +
                     Convert.ToInt32(r["G11FE15_19"].ToString()) +
                     Convert.ToInt32(r["G11FE20_24"].ToString()) +
                     Convert.ToInt32(r["G11FE25_49"].ToString()) +
                     Convert.ToInt32(r["G11FE50"].ToString()) +
                     Convert.ToInt32(r["G11PREGNANT"].ToString()) +
                     Convert.ToInt32(r["G11BREASTFEED"].ToString()) +
                     Convert.ToInt32(r["G11ROUTINE"].ToString()) +
                     Convert.ToInt32(r["G11TARGET"].ToString()) +
                     Convert.ToInt32(r["TOTALG12"].ToString()) +
                     Convert.ToInt32(r["SUBG12MA"].ToString()) +
                     Convert.ToInt32(r["G12MA1"].ToString()) +
                     Convert.ToInt32(r["G12MA1_4"].ToString()) +
                     Convert.ToInt32(r["G12MA5_9"].ToString()) +
                     Convert.ToInt32(r["G12MA10_14"].ToString()) +
                     Convert.ToInt32(r["G12MA15_19"].ToString()) +
                     Convert.ToInt32(r["G12MA20_24"].ToString()) +
                     Convert.ToInt32(r["G12MA25_49"].ToString()) +
                     Convert.ToInt32(r["G12MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG12FE"].ToString()) +
                     Convert.ToInt32(r["G12FE1"].ToString()) +
                     Convert.ToInt32(r["G12FE1_4"].ToString()) +
                     Convert.ToInt32(r["G12FE5_9"].ToString()) +
                     Convert.ToInt32(r["G12FE10_14"].ToString()) +
                     Convert.ToInt32(r["G12FE15_19"].ToString()) +
                     Convert.ToInt32(r["G12FE20_24"].ToString()) +
                     Convert.ToInt32(r["G12FE25_49"].ToString()) +
                     Convert.ToInt32(r["G12FE50"].ToString()) +
                     Convert.ToInt32(r["G12PREGNANT"].ToString()) +
                     Convert.ToInt32(r["G12BREASTFEED"].ToString()) +
                     Convert.ToInt32(r["TOTALG13"].ToString()) +
                     Convert.ToInt32(r["SUBG13MA"].ToString()) +
                     Convert.ToInt32(r["G13MA1"].ToString()) +
                     Convert.ToInt32(r["G13MA1_4"].ToString()) +
                     Convert.ToInt32(r["G13MA5_9"].ToString()) +
                     Convert.ToInt32(r["G13MA10_14"].ToString()) +
                     Convert.ToInt32(r["G13MA15_19"].ToString()) +
                     Convert.ToInt32(r["G13MA20_24"].ToString()) +
                     Convert.ToInt32(r["G13MA25_49"].ToString()) +
                     Convert.ToInt32(r["G13MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG13FE"].ToString()) +
                     Convert.ToInt32(r["G13FE1"].ToString()) +
                     Convert.ToInt32(r["G13FE1_4"].ToString()) +
                     Convert.ToInt32(r["G13FE5_9"].ToString()) +
                     Convert.ToInt32(r["G13FE10_14"].ToString()) +
                     Convert.ToInt32(r["G13FE15_19"].ToString()) +
                     Convert.ToInt32(r["G13FE20_24"].ToString()) +
                     Convert.ToInt32(r["G13FE25_49"].ToString()) +
                     Convert.ToInt32(r["G13FE50"].ToString()) +
                     Convert.ToInt32(r["G13PREGNANT"].ToString()) +
                     Convert.ToInt32(r["G13BREASTFEED"].ToString()) +
                     Convert.ToInt32(r["TOTALG14"].ToString()) +
                     Convert.ToInt32(r["SUBG14MA"].ToString()) +
                     Convert.ToInt32(r["G14MA1"].ToString()) +
                     Convert.ToInt32(r["G14MA1_4"].ToString()) +
                     Convert.ToInt32(r["G14MA5_9"].ToString()) +
                     Convert.ToInt32(r["G14MA10_14"].ToString()) +
                     Convert.ToInt32(r["G14MA15_19"].ToString()) +
                     Convert.ToInt32(r["G14MA20_24"].ToString()) +
                     Convert.ToInt32(r["G14MA25_49"].ToString()) +
                     Convert.ToInt32(r["G14MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG14FE"].ToString()) +
                     Convert.ToInt32(r["G14FE1"].ToString()) +
                     Convert.ToInt32(r["G14FE1_4"].ToString()) +
                     Convert.ToInt32(r["G14FE5_9"].ToString()) +
                     Convert.ToInt32(r["G14FE10_14"].ToString()) +
                     Convert.ToInt32(r["G14FE15_19"].ToString()) +
                     Convert.ToInt32(r["G14FE20_24"].ToString()) +
                     Convert.ToInt32(r["G14FE25_49"].ToString()) +
                     Convert.ToInt32(r["G14FE50"].ToString()) +
                     Convert.ToInt32(r["G14UNDETECTABLE"].ToString()) +
                     Convert.ToInt32(r["G14DETECTABLE"].ToString()) +
                     Convert.ToInt32(r["TOTALG15"].ToString()) +
                     Convert.ToInt32(r["SUBG15MA"].ToString()) +
                     Convert.ToInt32(r["G15MA1"].ToString()) +
                     Convert.ToInt32(r["G15MA1_4"].ToString()) +
                     Convert.ToInt32(r["G15MA5_9"].ToString()) +
                     Convert.ToInt32(r["G15MA10_14"].ToString()) +
                     Convert.ToInt32(r["G15MA15_19"].ToString()) +
                     Convert.ToInt32(r["G15MA20_24"].ToString()) +
                     Convert.ToInt32(r["G15MA25_49"].ToString()) +
                     Convert.ToInt32(r["G15MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG15FE"].ToString()) +
                     Convert.ToInt32(r["G15FE1"].ToString()) +
                     Convert.ToInt32(r["G15FE1_4"].ToString()) +
                     Convert.ToInt32(r["G15FE5_9"].ToString()) +
                     Convert.ToInt32(r["G15FE10_14"].ToString()) +
                     Convert.ToInt32(r["G15FE15_19"].ToString()) +
                     Convert.ToInt32(r["G15FE20_24"].ToString()) +
                     Convert.ToInt32(r["G15FE25_49"].ToString()) +
                     Convert.ToInt32(r["G15FE50"].ToString()) +
                     Convert.ToInt32(r["G15UNDETECTABLE"].ToString()) +
                     Convert.ToInt32(r["G15DETECTABLE"].ToString()) +
                     Convert.ToInt32(r["TOTALG16"].ToString()) +
                     Convert.ToInt32(r["SUBG16MA"].ToString()) +
                     Convert.ToInt32(r["G16MA1"].ToString()) +
                     Convert.ToInt32(r["G16MA1_4"].ToString()) +
                     Convert.ToInt32(r["G16MA5_9"].ToString()) +
                     Convert.ToInt32(r["G16MA10_14"].ToString()) +
                     Convert.ToInt32(r["G16MA15_19"].ToString()) +
                     Convert.ToInt32(r["G16MA20_24"].ToString()) +
                     Convert.ToInt32(r["G16MA25_49"].ToString()) +
                     Convert.ToInt32(r["G16MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG16FE"].ToString()) +
                     Convert.ToInt32(r["G16FE1"].ToString()) +
                     Convert.ToInt32(r["G16FE1_4"].ToString()) +
                     Convert.ToInt32(r["G16FE5_9"].ToString()) +
                     Convert.ToInt32(r["G16FE10_14"].ToString()) +
                     Convert.ToInt32(r["G16FE15_19"].ToString()) +
                     Convert.ToInt32(r["G16FE20_24"].ToString()) +
                     Convert.ToInt32(r["G16FE25_49"].ToString()) +
                     Convert.ToInt32(r["G16FE50"].ToString()) +
                     Convert.ToInt32(r["TOTALG17"].ToString()) +
                     Convert.ToInt32(r["SUBG17MA"].ToString()) +
                     Convert.ToInt32(r["G17MA1"].ToString()) +
                     Convert.ToInt32(r["G17MA1_4"].ToString()) +
                     Convert.ToInt32(r["G17MA5_9"].ToString()) +
                     Convert.ToInt32(r["G17MA10_14"].ToString()) +
                     Convert.ToInt32(r["G17MA15_19"].ToString()) +
                     Convert.ToInt32(r["G17MA20_24"].ToString()) +
                     Convert.ToInt32(r["G17MA25_49"].ToString()) +
                     Convert.ToInt32(r["G17MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG17FE"].ToString()) +
                     Convert.ToInt32(r["G17FE1"].ToString()) +
                     Convert.ToInt32(r["G17FE1_4"].ToString()) +
                     Convert.ToInt32(r["G17FE5_9"].ToString()) +
                     Convert.ToInt32(r["G17FE10_14"].ToString()) +
                     Convert.ToInt32(r["G17FE15_19"].ToString()) +
                     Convert.ToInt32(r["G17FE20_24"].ToString()) +
                     Convert.ToInt32(r["G17FE25_49"].ToString()) +
                     Convert.ToInt32(r["G17FE50"].ToString()) +
                     Convert.ToInt32(r["TOTALG18"].ToString()) +
                     Convert.ToInt32(r["SUBG18MA"].ToString()) +
                     Convert.ToInt32(r["G18MA1"].ToString()) +
                     Convert.ToInt32(r["G18MA1_4"].ToString()) +
                     Convert.ToInt32(r["G18MA5_9"].ToString()) +
                     Convert.ToInt32(r["G18MA10_14"].ToString()) +
                     Convert.ToInt32(r["G18MA15_19"].ToString()) +
                     Convert.ToInt32(r["G18MA20_24"].ToString()) +
                     Convert.ToInt32(r["G18MA25_49"].ToString()) +
                     Convert.ToInt32(r["G18MA50"].ToString()) +
                     Convert.ToInt32(r["SUBG18FE"].ToString()) +
                     Convert.ToInt32(r["G18FE1"].ToString()) +
                     Convert.ToInt32(r["G18FE1_4"].ToString()) +
                     Convert.ToInt32(r["G18FE5_9"].ToString()) +
                     Convert.ToInt32(r["G18FE10_14"].ToString()) +
                     Convert.ToInt32(r["G18FE15_19"].ToString()) +
                     Convert.ToInt32(r["G18FE20_24"].ToString()) +
                     Convert.ToInt32(r["G18FE25_49"].ToString()) +
                     Convert.ToInt32(r["G18FE50"].ToString()));
             }
             r.Close();
             TART = (ART1 + ART2);
             //TextBox1.Text = Convert.ToString(TART);

             string SQLLAB1 = "SELECT * FROM tbl_LAB1";
             string SQLLAB2 = "SELECT * FROM tbl_LAB2";

             int LAB1 = 0; int LAB2 = 0;
             SqlCommand cmdLAB1 = new SqlCommand(SQLLAB1, cn);
             r = cmdLAB1.ExecuteReader();
             while (r.Read())
             {
                 LAB1 += (Convert.ToInt32(r["TOTALG1"].ToString()) +
                        Convert.ToInt32(r["SUBG1MA"].ToString()) +
                        Convert.ToInt32(r["G1MA2"].ToString()) +
                        Convert.ToInt32(r["G1MA2_12"].ToString()) +
                        Convert.ToInt32(r["SUBG1FE"].ToString()) +
                        Convert.ToInt32(r["G1FE2"].ToString()) +
                        Convert.ToInt32(r["G1FE2_12"].ToString()) +
                        Convert.ToInt32(r["TOTALG2"].ToString()) +
                        Convert.ToInt32(r["SUBG2MA"].ToString()) +
                        Convert.ToInt32(r["G2MA1"].ToString()) +
                        Convert.ToInt32(r["G2MA1_4"].ToString()) +
                        Convert.ToInt32(r["G2MA5_9"].ToString()) +
                        Convert.ToInt32(r["G2MA10_14"].ToString()) +
                        Convert.ToInt32(r["G2MA15_19"].ToString()) +
                        Convert.ToInt32(r["G2MA20_24"].ToString()) +
                        Convert.ToInt32(r["G2MA25_49"].ToString()) +
                        Convert.ToInt32(r["G2MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG2FE"].ToString()) +
                        Convert.ToInt32(r["G2FE1"].ToString()) +
                        Convert.ToInt32(r["G2FE1_4"].ToString()) +
                        Convert.ToInt32(r["G2FE5_9"].ToString()) +
                        Convert.ToInt32(r["G2FE10_14"].ToString()) +
                        Convert.ToInt32(r["G2FE15_19"].ToString()) +
                        Convert.ToInt32(r["G2FE20_24"].ToString()) +
                        Convert.ToInt32(r["G2FE25_49"].ToString()) +
                        Convert.ToInt32(r["G2FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG3"].ToString()) +
                        Convert.ToInt32(r["SUBG3MA"].ToString()) +
                        Convert.ToInt32(r["G3MA1"].ToString()) +
                        Convert.ToInt32(r["G3MA1_4"].ToString()) +
                        Convert.ToInt32(r["G3MA5_9"].ToString()) +
                        Convert.ToInt32(r["G3MA10_14"].ToString()) +
                        Convert.ToInt32(r["G3MA15_19"].ToString()) +
                        Convert.ToInt32(r["G3MA20_24"].ToString()) +
                        Convert.ToInt32(r["G3MA25_49"].ToString()) +
                        Convert.ToInt32(r["G3MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG3FE"].ToString()) +
                        Convert.ToInt32(r["G3FE1"].ToString()) +
                        Convert.ToInt32(r["G3FE1_4"].ToString()) +
                        Convert.ToInt32(r["G3FE5_9"].ToString()) +
                        Convert.ToInt32(r["G3FE10_14"].ToString()) +
                        Convert.ToInt32(r["G3FE15_19"].ToString()) +
                        Convert.ToInt32(r["G3FE20_24"].ToString()) +
                        Convert.ToInt32(r["G3FE25_49"].ToString()) +
                        Convert.ToInt32(r["G3FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG4"].ToString()) +
                        Convert.ToInt32(r["SUBG4MA"].ToString()) +
                        Convert.ToInt32(r["G4MA1"].ToString()) +
                        Convert.ToInt32(r["G4MA1_4"].ToString()) +
                        Convert.ToInt32(r["G4MA5_9"].ToString()) +
                        Convert.ToInt32(r["G4MA10_14"].ToString()) +
                        Convert.ToInt32(r["G4MA15_19"].ToString()) +
                        Convert.ToInt32(r["G4MA20_24"].ToString()) +
                        Convert.ToInt32(r["G4MA25_49"].ToString()) +
                        Convert.ToInt32(r["G4MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG4FE"].ToString()) +
                        Convert.ToInt32(r["G4FE1"].ToString()) +
                        Convert.ToInt32(r["G4FE1_4"].ToString()) +
                        Convert.ToInt32(r["G4FE5_9"].ToString()) +
                        Convert.ToInt32(r["G4FE10_14"].ToString()) +
                        Convert.ToInt32(r["G4FE15_19"].ToString()) +
                        Convert.ToInt32(r["G4FE20_24"].ToString()) +
                        Convert.ToInt32(r["G4FE25_49"].ToString()) +
                        Convert.ToInt32(r["G4FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG5"].ToString()) +
                        Convert.ToInt32(r["SUBG5MA"].ToString()) +
                        Convert.ToInt32(r["G5MA1"].ToString()) +
                        Convert.ToInt32(r["G5MA1_4"].ToString()) +
                        Convert.ToInt32(r["G5MA5_9"].ToString()) +
                        Convert.ToInt32(r["G5MA10_14"].ToString()) +
                        Convert.ToInt32(r["G5MA15_19"].ToString()) +
                        Convert.ToInt32(r["G5MA20_24"].ToString()) +
                        Convert.ToInt32(r["G5MA25_49"].ToString()) +
                        Convert.ToInt32(r["G5MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG5FE"].ToString()) +
                        Convert.ToInt32(r["G5FE1"].ToString()) +
                        Convert.ToInt32(r["G5FE1_4"].ToString()) +
                        Convert.ToInt32(r["G5FE5_9"].ToString()) +
                        Convert.ToInt32(r["G5FE10_14"].ToString()) +
                        Convert.ToInt32(r["G5FE15_19"].ToString()) +
                        Convert.ToInt32(r["G5FE20_24"].ToString()) +
                        Convert.ToInt32(r["G5FE25_49"].ToString()) +
                        Convert.ToInt32(r["G5FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG6"].ToString()) +
                        Convert.ToInt32(r["SUBG6MA"].ToString()) +
                        Convert.ToInt32(r["G6MA1"].ToString()) +
                        Convert.ToInt32(r["G6MA1_4"].ToString()) +
                        Convert.ToInt32(r["G6MA5_9"].ToString()) +
                        Convert.ToInt32(r["G6MA10_14"].ToString()) +
                        Convert.ToInt32(r["G6MA15_19"].ToString()) +
                        Convert.ToInt32(r["G6MA20_24"].ToString()) +
                        Convert.ToInt32(r["G6MA25_49"].ToString()) +
                        Convert.ToInt32(r["G6MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG6FE"].ToString()) +
                        Convert.ToInt32(r["G6FE1"].ToString()) +
                        Convert.ToInt32(r["G6FE1_4"].ToString()) +
                        Convert.ToInt32(r["G6FE5_9"].ToString()) +
                        Convert.ToInt32(r["G6FE10_14"].ToString()) +
                        Convert.ToInt32(r["G6FE15_19"].ToString()) +
                        Convert.ToInt32(r["G6FE20_24"].ToString()) +
                        Convert.ToInt32(r["G6FE25_49"].ToString()) +
                        Convert.ToInt32(r["G6FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG7"].ToString()) +
                        Convert.ToInt32(r["SUBG7MA"].ToString()) +
                        Convert.ToInt32(r["G7MA1"].ToString()) +
                        Convert.ToInt32(r["G7MA1_4"].ToString()) +
                        Convert.ToInt32(r["G7MA5_9"].ToString()) +
                        Convert.ToInt32(r["G7MA10_14"].ToString()) +
                        Convert.ToInt32(r["G7MA15_19"].ToString()) +
                        Convert.ToInt32(r["G7MA20_24"].ToString()) +
                        Convert.ToInt32(r["G7MA25_49"].ToString()) +
                        Convert.ToInt32(r["G7MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG7FE"].ToString()) +
                        Convert.ToInt32(r["G7FE1"].ToString()) +
                        Convert.ToInt32(r["G7FE1_4"].ToString()) +
                        Convert.ToInt32(r["G7FE5_9"].ToString()) +
                        Convert.ToInt32(r["G7FE10_14"].ToString()) +
                        Convert.ToInt32(r["G7FE15_19"].ToString()) +
                        Convert.ToInt32(r["G7FE20_24"].ToString()) +
                        Convert.ToInt32(r["G7FE25_49"].ToString()) +
                        Convert.ToInt32(r["G7FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG8"].ToString()) +
                        Convert.ToInt32(r["SUBG8MA"].ToString()) +
                        Convert.ToInt32(r["G8MA1"].ToString()) +
                        Convert.ToInt32(r["G8MA1_4"].ToString()) +
                        Convert.ToInt32(r["G8MA5_9"].ToString()) +
                        Convert.ToInt32(r["G8MA10_14"].ToString()) +
                        Convert.ToInt32(r["G8MA15_19"].ToString()) +
                        Convert.ToInt32(r["G8MA20_24"].ToString()) +
                        Convert.ToInt32(r["G8MA25_49"].ToString()) +
                        Convert.ToInt32(r["G8MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG8FE"].ToString()) +
                        Convert.ToInt32(r["G8FE1"].ToString()) +
                        Convert.ToInt32(r["G8FE1_4"].ToString()) +
                        Convert.ToInt32(r["G8FE5_9"].ToString()) +
                        Convert.ToInt32(r["G8FE10_14"].ToString()) +
                        Convert.ToInt32(r["G8FE15_19"].ToString()) +
                        Convert.ToInt32(r["G8FE20_24"].ToString()) +
                        Convert.ToInt32(r["G8FE25_49"].ToString()) +
                        Convert.ToInt32(r["G8FE50"].ToString()) +
                        Convert.ToInt32(r["TOTALG9"].ToString()) +
                        Convert.ToInt32(r["SUBG9MA"].ToString()) +
                        Convert.ToInt32(r["G9MA1"].ToString()) +
                        Convert.ToInt32(r["G9MA1_4"].ToString()) +
                        Convert.ToInt32(r["G9MA5_9"].ToString()) +
                        Convert.ToInt32(r["G9MA10_14"].ToString()) +
                        Convert.ToInt32(r["G9MA15_19"].ToString()) +
                        Convert.ToInt32(r["G9MA20_24"].ToString()) +
                        Convert.ToInt32(r["G9MA25_49"].ToString()) +
                        Convert.ToInt32(r["G9MA50"].ToString()) +
                        Convert.ToInt32(r["SUBG9FE"].ToString()) +
                        Convert.ToInt32(r["G9FE1"].ToString()) +
                        Convert.ToInt32(r["G9FE1_4"].ToString()) +
                        Convert.ToInt32(r["G9FE5_9"].ToString()) +
                        Convert.ToInt32(r["G9FE10_14"].ToString()) +
                        Convert.ToInt32(r["G9FE15_19"].ToString()) +
                        Convert.ToInt32(r["G9FE20_24"].ToString()) +
                        Convert.ToInt32(r["G9FE25_49"].ToString()) +
                        Convert.ToInt32(r["G9FE50"].ToString()));
             }
             r.Close();

             SqlCommand cmdLAB2 = new SqlCommand(SQLLAB2, cn);
             r = cmdLAB2.ExecuteReader();
             while (r.Read())
             {
                 LAB2 += (Convert.ToInt32(r["TOTALG10"].ToString()) +
                    Convert.ToInt32(r["SUBG10MA"].ToString()) +
                    Convert.ToInt32(r["G10MA1"].ToString()) +
                    Convert.ToInt32(r["G10MA1_4"].ToString()) +
                    Convert.ToInt32(r["G10MA5_9"].ToString()) +
                    Convert.ToInt32(r["G10MA10_14"].ToString()) +
                    Convert.ToInt32(r["G10MA15_19"].ToString()) +
                    Convert.ToInt32(r["G10MA20_24"].ToString()) +
                    Convert.ToInt32(r["G10MA25_49"].ToString()) +
                    Convert.ToInt32(r["G10MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG10FE"].ToString()) +
                    Convert.ToInt32(r["G10FE1"].ToString()) +
                    Convert.ToInt32(r["G10FE1_4"].ToString()) +
                    Convert.ToInt32(r["G10FE5_9"].ToString()) +
                    Convert.ToInt32(r["G10FE10_14"].ToString()) +
                    Convert.ToInt32(r["G10FE15_19"].ToString()) +
                    Convert.ToInt32(r["G10FE20_24"].ToString()) +
                    Convert.ToInt32(r["G10FE25_49"].ToString()) +
                    Convert.ToInt32(r["G10FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG11"].ToString()) +
                    Convert.ToInt32(r["SUBG11MA"].ToString()) +
                    Convert.ToInt32(r["G11MA1"].ToString()) +
                    Convert.ToInt32(r["G11MA1_4"].ToString()) +
                    Convert.ToInt32(r["G11MA5_9"].ToString()) +
                    Convert.ToInt32(r["G11MA10_14"].ToString()) +
                    Convert.ToInt32(r["G11MA15_19"].ToString()) +
                    Convert.ToInt32(r["G11MA20_24"].ToString()) +
                    Convert.ToInt32(r["G11MA25_49"].ToString()) +
                    Convert.ToInt32(r["G11MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG11FE"].ToString()) +
                    Convert.ToInt32(r["G11FE1"].ToString()) +
                    Convert.ToInt32(r["G11FE1_4"].ToString()) +
                    Convert.ToInt32(r["G11FE5_9"].ToString()) +
                    Convert.ToInt32(r["G11FE10_14"].ToString()) +
                    Convert.ToInt32(r["G11FE15_19"].ToString()) +
                    Convert.ToInt32(r["G11FE20_24"].ToString()) +
                    Convert.ToInt32(r["G11FE25_49"].ToString()) +
                    Convert.ToInt32(r["G11FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG12"].ToString()) +
                    Convert.ToInt32(r["SUBG12MA"].ToString()) +
                    Convert.ToInt32(r["G12MA1"].ToString()) +
                    Convert.ToInt32(r["G12MA1_4"].ToString()) +
                    Convert.ToInt32(r["G12MA5_9"].ToString()) +
                    Convert.ToInt32(r["G12MA10_14"].ToString()) +
                    Convert.ToInt32(r["G12MA15_19"].ToString()) +
                    Convert.ToInt32(r["G12MA20_24"].ToString()) +
                    Convert.ToInt32(r["G12MA25_49"].ToString()) +
                    Convert.ToInt32(r["G12MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG12FE"].ToString()) +
                    Convert.ToInt32(r["G12FE1"].ToString()) +
                    Convert.ToInt32(r["G12FE1_4"].ToString()) +
                    Convert.ToInt32(r["G12FE5_9"].ToString()) +
                    Convert.ToInt32(r["G12FE10_14"].ToString()) +
                    Convert.ToInt32(r["G12FE15_19"].ToString()) +
                    Convert.ToInt32(r["G12FE20_24"].ToString()) +
                    Convert.ToInt32(r["G12FE25_49"].ToString()) +
                    Convert.ToInt32(r["G12FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG13"].ToString()) +
                    Convert.ToInt32(r["SUBG13MA"].ToString()) +
                    Convert.ToInt32(r["G13MA1"].ToString()) +
                    Convert.ToInt32(r["G13MA1_4"].ToString()) +
                    Convert.ToInt32(r["G13MA5_9"].ToString()) +
                    Convert.ToInt32(r["G13MA10_14"].ToString()) +
                    Convert.ToInt32(r["G13MA15_19"].ToString()) +
                    Convert.ToInt32(r["G13MA20_24"].ToString()) +
                    Convert.ToInt32(r["G13MA25_49"].ToString()) +
                    Convert.ToInt32(r["G13MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG13FE"].ToString()) +
                    Convert.ToInt32(r["G13FE1"].ToString()) +
                    Convert.ToInt32(r["G13FE1_4"].ToString()) +
                    Convert.ToInt32(r["G13FE5_9"].ToString()) +
                    Convert.ToInt32(r["G13FE10_14"].ToString()) +
                    Convert.ToInt32(r["G13FE15_19"].ToString()) +
                    Convert.ToInt32(r["G13FE20_24"].ToString()) +
                    Convert.ToInt32(r["G13FE25_49"].ToString()) +
                    Convert.ToInt32(r["G13FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG14"].ToString()) +
                    Convert.ToInt32(r["SUBG14MA"].ToString()) +
                    Convert.ToInt32(r["G14MA1"].ToString()) +
                    Convert.ToInt32(r["G14MA1_4"].ToString()) +
                    Convert.ToInt32(r["G14MA5_9"].ToString()) +
                    Convert.ToInt32(r["G14MA10_14"].ToString()) +
                    Convert.ToInt32(r["G14MA15_19"].ToString()) +
                    Convert.ToInt32(r["G14MA20_24"].ToString()) +
                    Convert.ToInt32(r["G14MA25_49"].ToString()) +
                    Convert.ToInt32(r["G14MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG14FE"].ToString()) +
                    Convert.ToInt32(r["G14FE1"].ToString()) +
                    Convert.ToInt32(r["G14FE1_4"].ToString()) +
                    Convert.ToInt32(r["G14FE5_9"].ToString()) +
                    Convert.ToInt32(r["G14FE10_14"].ToString()) +
                    Convert.ToInt32(r["G14FE15_19"].ToString()) +
                    Convert.ToInt32(r["G14FE20_24"].ToString()) +
                    Convert.ToInt32(r["G14FE25_49"].ToString()) +
                    Convert.ToInt32(r["G14FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG15"].ToString()) +
                    Convert.ToInt32(r["SUBG15MA"].ToString()) +
                    Convert.ToInt32(r["G15MA1"].ToString()) +
                    Convert.ToInt32(r["G15MA1_4"].ToString()) +
                    Convert.ToInt32(r["G15MA5_9"].ToString()) +
                    Convert.ToInt32(r["G15MA10_14"].ToString()) +
                    Convert.ToInt32(r["G15MA15_19"].ToString()) +
                    Convert.ToInt32(r["G15MA20_24"].ToString()) +
                    Convert.ToInt32(r["G15MA25_49"].ToString()) +
                    Convert.ToInt32(r["G15MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG15FE"].ToString()) +
                    Convert.ToInt32(r["G15FE1"].ToString()) +
                    Convert.ToInt32(r["G15FE1_4"].ToString()) +
                    Convert.ToInt32(r["G15FE5_9"].ToString()) +
                    Convert.ToInt32(r["G15FE10_14"].ToString()) +
                    Convert.ToInt32(r["G15FE15_19"].ToString()) +
                    Convert.ToInt32(r["G15FE20_24"].ToString()) +
                    Convert.ToInt32(r["G15FE25_49"].ToString()) +
                    Convert.ToInt32(r["G15FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG16"].ToString()) +
                    Convert.ToInt32(r["SUBG16MA"].ToString()) +
                    Convert.ToInt32(r["G16MA1"].ToString()) +
                    Convert.ToInt32(r["G16MA1_4"].ToString()) +
                    Convert.ToInt32(r["G16MA5_9"].ToString()) +
                    Convert.ToInt32(r["G16MA10_14"].ToString()) +
                    Convert.ToInt32(r["G16MA15_19"].ToString()) +
                    Convert.ToInt32(r["G16MA20_24"].ToString()) +
                    Convert.ToInt32(r["G16MA25_49"].ToString()) +
                    Convert.ToInt32(r["G16MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG16FE"].ToString()) +
                    Convert.ToInt32(r["G16FE1"].ToString()) +
                    Convert.ToInt32(r["G16FE1_4"].ToString()) +
                    Convert.ToInt32(r["G16FE5_9"].ToString()) +
                    Convert.ToInt32(r["G16FE10_14"].ToString()) +
                    Convert.ToInt32(r["G16FE15_19"].ToString()) +
                    Convert.ToInt32(r["G16FE20_24"].ToString()) +
                    Convert.ToInt32(r["G16FE25_49"].ToString()) +
                    Convert.ToInt32(r["G16FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG17"].ToString()) +
                    Convert.ToInt32(r["SUBG17MA"].ToString()) +
                    Convert.ToInt32(r["G17MA1"].ToString()) +
                    Convert.ToInt32(r["G17MA1_4"].ToString()) +
                    Convert.ToInt32(r["G17MA5_9"].ToString()) +
                    Convert.ToInt32(r["G17MA10_14"].ToString()) +
                    Convert.ToInt32(r["G17MA15_19"].ToString()) +
                    Convert.ToInt32(r["G17MA20_24"].ToString()) +
                    Convert.ToInt32(r["G17MA25_49"].ToString()) +
                    Convert.ToInt32(r["G17MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG17FE"].ToString()) +
                    Convert.ToInt32(r["G17FE1"].ToString()) +
                    Convert.ToInt32(r["G17FE1_4"].ToString()) +
                    Convert.ToInt32(r["G17FE5_9"].ToString()) +
                    Convert.ToInt32(r["G17FE10_14"].ToString()) +
                    Convert.ToInt32(r["G17FE15_19"].ToString()) +
                    Convert.ToInt32(r["G17FE20_24"].ToString()) +
                    Convert.ToInt32(r["G17FE25_49"].ToString()) +
                    Convert.ToInt32(r["G17FE50"].ToString()));
             }
             r.Close();
             TLAB = (LAB1 + LAB2);
             TextBox6.Text = Convert.ToString(TLAB);

             string SQLHTC1 = "SELECT * FROM tbl_HTC1";
             string SQLHTC2 = "SELECT * FROM tbl_HTC2";
             string SQLHTC3 = "SELECT * FROM tbl_HTC3";

             int HTC1 = 0; int HTC2 = 0; int HTC3 = 0;

             SqlCommand cmdHTC1 = new SqlCommand(SQLHTC1, cn);
             r = cmdHTC1.ExecuteReader();
             while (r.Read())
             {
                 HTC1 +=(Convert.ToInt32(r["TOTALG1"].ToString())+
                        Convert.ToInt32(r["G1MA1"].ToString())+
                        Convert.ToInt32(r["G1MA1_4"].ToString())+
                        Convert.ToInt32(r["G1MA5_9"].ToString())+
                        Convert.ToInt32(r["G1MA10_14"].ToString())+
                        Convert.ToInt32(r["G1MA15_19"].ToString())+
                        Convert.ToInt32(r["G1MA20_24"].ToString())+
                        Convert.ToInt32(r["G1MA25_49"].ToString())+
                        Convert.ToInt32(r["G1MA50"].ToString())+
                        Convert.ToInt32(r["SUBG1FE"].ToString())+
                        Convert.ToInt32(r["G1FE1"].ToString())+
                        Convert.ToInt32(r["G1FE1_4"].ToString())+
                        Convert.ToInt32(r["G1FE5_9"].ToString())+
                        Convert.ToInt32(r["G1FE10_14"].ToString())+
                        Convert.ToInt32(r["G1FE15_19"].ToString())+
                        Convert.ToInt32(r["G1FE20_24"].ToString())+
                        Convert.ToInt32(r["G1FE25_49"].ToString())+
                        Convert.ToInt32(r["G1FE50"].ToString())+
                        Convert.ToInt32(r["TOTALG2"].ToString())+
                        Convert.ToInt32(r["SUBG2M"].ToString())+
                        Convert.ToInt32(r["G2MA1"].ToString())+
                        Convert.ToInt32(r["G2MA1_4"].ToString())+
                        Convert.ToInt32(r["G2MA5_9"].ToString())+
                        Convert.ToInt32(r["G2MA10_14"].ToString())+
                        Convert.ToInt32(r["G2MA15_19"].ToString())+
                        Convert.ToInt32(r["G2MA20_24"].ToString())+
                        Convert.ToInt32(r["G2MA25_49"].ToString())+
                        Convert.ToInt32(r["G2MA50"].ToString())+
                        Convert.ToInt32(r["G2FE1"].ToString())+
                        Convert.ToInt32(r["G2FE1_4"].ToString())+
                        Convert.ToInt32(r["G2FE5_9"].ToString())+
                        Convert.ToInt32(r["G2FE10_14"].ToString())+
                        Convert.ToInt32(r["G2FE15_19"].ToString())+
                        Convert.ToInt32(r["G2FE20_24"].ToString())+
                        Convert.ToInt32(r["G2FE25_49"].ToString())+
                        Convert.ToInt32(r["G2FE50"].ToString())+
                        Convert.ToInt32(r["TOTALG3"].ToString())+
                        Convert.ToInt32(r["SUBG3M"].ToString())+
                        Convert.ToInt32(r["G3MA1"].ToString())+
                        Convert.ToInt32(r["G3MA1_4"].ToString())+
                        Convert.ToInt32(r["G3MA5_9"].ToString())+
                        Convert.ToInt32(r["G3MA10_14"].ToString())+
                        Convert.ToInt32(r["G3MA15_19"].ToString())+
                        Convert.ToInt32(r["G3MA20_24"].ToString())+
                        Convert.ToInt32(r["G3MA25_49"].ToString())+
                        Convert.ToInt32(r["G3MA50"].ToString())+
                        Convert.ToInt32(r["SUBG3F"].ToString())+
                        Convert.ToInt32(r["G3FE1"].ToString())+
                        Convert.ToInt32(r["G3FE1_4"].ToString())+
                        Convert.ToInt32(r["G3FE5_9"].ToString())+
                        Convert.ToInt32(r["G3FE10_14"].ToString())+
                        Convert.ToInt32(r["G3FE15_19"].ToString())+
                        Convert.ToInt32(r["G3FE20_24"].ToString())+
                        Convert.ToInt32(r["G3FE25_49"].ToString())+
                        Convert.ToInt32(r["G3FE50"].ToString())+
                        Convert.ToInt32(r["TOTALG4"].ToString())+
                        Convert.ToInt32(r["SUBG4P"].ToString())+
                        Convert.ToInt32(r["G4P1"].ToString())+
                        Convert.ToInt32(r["G4P1_4"].ToString())+
                        Convert.ToInt32(r["G4P5_9"].ToString())+
                        Convert.ToInt32(r["G4P10_14"].ToString())+
                        Convert.ToInt32(r["G4P15_19"].ToString())+
                        Convert.ToInt32(r["G4P20_24"].ToString())+
                        Convert.ToInt32(r["G4P25_49"].ToString())+
                        Convert.ToInt32(r["G4P50"].ToString())+
                        Convert.ToInt32(r["SUB4N"].ToString())+
                        Convert.ToInt32(r["G4N1"].ToString())+
                        Convert.ToInt32(r["G4N1_4"].ToString())+
                        Convert.ToInt32(r["G4N5_9"].ToString())+
                        Convert.ToInt32(r["G4N10_14"].ToString())+
                        Convert.ToInt32(r["G4N15_19"].ToString())+
                        Convert.ToInt32(r["G4N20_24"].ToString())+
                        Convert.ToInt32(r["G4N25_49"].ToString())+
                        Convert.ToInt32(r["G4N50"].ToString())+
                        Convert.ToInt32(r["TOTALG5"].ToString())+
                        Convert.ToInt32(r["SUBG5M"].ToString())+
                        Convert.ToInt32(r["G5MA1"].ToString())+
                        Convert.ToInt32(r["G5M1_4"].ToString())+
                        Convert.ToInt32(r["G5MA5_9"].ToString())+
                        Convert.ToInt32(r["G5MA10_14"].ToString())+
                        Convert.ToInt32(r["G5MA15_19"].ToString())+
                        Convert.ToInt32(r["G5MA20_24"].ToString())+
                        Convert.ToInt32(r["G5MA25_49"].ToString())+
                        Convert.ToInt32(r["G5MA50"].ToString())+
                        Convert.ToInt32(r["SUBG5F"].ToString())+
                        Convert.ToInt32(r["G5FE1"].ToString())+
                        Convert.ToInt32(r["G5FE1_4"].ToString())+
                        Convert.ToInt32(r["G5FE5_9"].ToString())+
                        Convert.ToInt32(r["G5FE10_14"].ToString())+
                        Convert.ToInt32(r["G5FE15_19"].ToString())+
                        Convert.ToInt32(r["G5FE20_24"].ToString())+
                        Convert.ToInt32(r["G5FE25_49"].ToString())+
                        Convert.ToInt32(r["G5FE50"].ToString())+
                        Convert.ToInt32(r["TOTALG6"].ToString())+
                        Convert.ToInt32(r["SUBG6M"].ToString())+
                        Convert.ToInt32(r["G6MA1"].ToString())+
                        Convert.ToInt32(r["G6M1_4"].ToString())+
                        Convert.ToInt32(r["G6MA5_9"].ToString())+
                        Convert.ToInt32(r["G6MA10_14"].ToString())+
                        Convert.ToInt32(r["G6MA15_19"].ToString())+
                        Convert.ToInt32(r["G6MA20_24"].ToString())+
                        Convert.ToInt32(r["G6MA25_49"].ToString())+
                        Convert.ToInt32(r["G6MA50"].ToString())+
                        Convert.ToInt32(r["SUBG6F"].ToString())+
                        Convert.ToInt32(r["G6FE1"].ToString())+
                        Convert.ToInt32(r["G6FE1_4"].ToString())+
                        Convert.ToInt32(r["G6FE5_9"].ToString())+
                        Convert.ToInt32(r["G6FE10_14"].ToString())+
                        Convert.ToInt32(r["G6FE15_19"].ToString())+
                        Convert.ToInt32(r["G6FE20_24"].ToString())+
                        Convert.ToInt32(r["G6FE25_49"].ToString())+
                        Convert.ToInt32(r["G6FE50"].ToString())+
                        Convert.ToInt32(r["TOTALG7"].ToString())+
                        Convert.ToInt32(r["SUBG7M"].ToString())+
                        Convert.ToInt32(r["G7MA1"].ToString())+
                        Convert.ToInt32(r["G7M1_4"].ToString())+
                        Convert.ToInt32(r["G7MA5_9"].ToString())+
                        Convert.ToInt32(r["G7MA10_14"].ToString())+
                        Convert.ToInt32(r["G7MA15_19"].ToString())+
                        Convert.ToInt32(r["G7MA20_24"].ToString())+
                        Convert.ToInt32(r["G7MA25_49"].ToString())+
                        Convert.ToInt32(r["G7MA50"].ToString())+
                        Convert.ToInt32(r["SUBG7F"].ToString())+
                        Convert.ToInt32(r["G7FE1"].ToString())+
                        Convert.ToInt32(r["G7FE1_4"].ToString())+
                        Convert.ToInt32(r["G7FE5_9"].ToString())+
                        Convert.ToInt32(r["G7FE10_14"].ToString())+
                        Convert.ToInt32(r["G7FE15_19"].ToString())+
                        Convert.ToInt32(r["G7FE20_24"].ToString())+
                        Convert.ToInt32(r["G7FE25_49"].ToString())+
                        Convert.ToInt32(r["G7FE50"].ToString())+
                        Convert.ToInt32(r["TOTALG8"].ToString())+
                        Convert.ToInt32(r["SUBG8M"].ToString())+
                        Convert.ToInt32(r["G8MA10_14"].ToString())+
                        Convert.ToInt32(r["G8M15_19"].ToString())+
                        Convert.ToInt32(r["G8MA20_24"].ToString())+
                        Convert.ToInt32(r["G8MA25_49"].ToString())+
                        Convert.ToInt32(r["G8MA50"].ToString())+
                        Convert.ToInt32(r["SUBG8P"].ToString()));
             }
             r.Close();

             SqlCommand cmdHTC2 = new SqlCommand(SQLHTC2, cn);
             r = cmdHTC2.ExecuteReader();
             while (r.Read())
             {
                 //if (string.IsNullOrEmpty( r["G8P10_14"].ToString()) )
                 //{
                 //    return;
                 //}
                 //else
                 //{
                     HTC2 += (
                         ((r["G8P10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G8P10_14"].ToString()))+
                         ((r["G8P15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G8P15_19"].ToString())) +
                         ((r["G8P20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G8P20_24"].ToString())) +
                         ((r["G8P25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G8P25_49"].ToString())) +
                         ((r["G8P50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G8P50"].ToString())) +
                         ((r["TOTALG9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG9"].ToString())) +
                         ((r["SUBG9M"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG9M"].ToString())) +
                         ((r["G9MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA1"].ToString())) +
                         ((r["G9MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA1_4"].ToString())) +
                         ((r["G9MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA5_9"].ToString())) +
                         ((r["G9MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA10_14"].ToString())) +
                         ((r["G9MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA15_19"].ToString())) +
                         ((r["G9MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA20_24"].ToString())) +
                         ((r["G9MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA25_49"].ToString())) +
                         ((r["G9MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9MA50"].ToString())) +
                         ((r["SUBG9F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG9F"].ToString())) +
                         ((r["G9FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE1"].ToString())) +
                         ((r["G9FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE1_4"].ToString())) +
                         ((r["G9FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE5_9"].ToString())) +
                         ((r["G9FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE10_14"].ToString())) +
                         ((r["G9FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE15_19"].ToString())) +
                         ((r["G9FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE20_24"].ToString())) +
                         ((r["G9FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE25_49"].ToString())) +
                         ((r["G9FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G9FE50"].ToString())) +
                         ((r["TOTALG10"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG10"].ToString())) +
                         ((r["SUBG10P"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG10P"].ToString())) +
                         ((r["G10P1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P1"].ToString())) +
                         ((r["G10P1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P1_4"].ToString())) +
                         ((r["G10P5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P5_9"].ToString())) +
                         ((r["G10P10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P10_14"].ToString())) +
                         ((r["G10P15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P15_19"].ToString())) +
                         ((r["G10P20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P20_24"].ToString())) +
                         ((r["G10P25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P25_49"].ToString())) +
                         ((r["G10P50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10P50"].ToString())) +
                         ((r["SUBG10N"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG10N"].ToString())) +
                         ((r["G10N1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N1"].ToString())) +
                         ((r["G10N1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N1_4"].ToString())) +
                         ((r["G10N5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N5_9"].ToString())) +
                         ((r["G10N10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N10_14"].ToString())) +
                         ((r["G10N15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N15_19"].ToString())) +
                         ((r["G10N20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N20_24"].ToString())) +
                         ((r["G10N25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N25_49"].ToString())) +
                         ((r["G10N50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G10N50"].ToString())) +
                         ((r["G11MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA1"].ToString())) +
                         ((r["G11MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA1_4"].ToString())) +
                         ((r["G11MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA5_9"].ToString())) +
                         ((r["G11MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA10_14"].ToString())) +

                         ((r["G11MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA15_19"].ToString())) +
                         ((r["G11MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA25_49"].ToString())) +
                         ((r["G11MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11MA50"].ToString())) +
                         ((r["SUBG11F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG11F"].ToString())) +
                         ((r["G11FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE1"].ToString())) +
                         ((r["G11FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE1_4"].ToString())) +
                         ((r["G11FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE5_9"].ToString())) +
                         ((r["G11FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE10_14"].ToString())) +
                         ((r["G11FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE15_19"].ToString())) +
                         ((r["G11FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE20_24"].ToString())) +
                         ((r["G11FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE25_49"].ToString())) +
                         ((r["G11FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G11FE50"].ToString())) +
                         ((r["TOTALG12"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG12"].ToString())) +
                         ((r["SUBG12M"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG12M"].ToString())) +
                         ((r["G12MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA1"].ToString())) +
                         ((r["G12MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA1_4"].ToString())) +
                         ((r["G12MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA5_9"].ToString())) +
                         ((r["G12MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA10_14"].ToString())) +
                         ((r["G12MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA15_19"].ToString())) +
                         ((r["G12MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA20_24"].ToString())) +
                         ((r["G12MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA25_49"].ToString())) +
                         ((r["G12MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12MA50"].ToString())) +
                         ((r["SUBG12F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG12F"].ToString())) +
                         ((r["G12FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE1"].ToString())) +
                         ((r["G12FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE1_4"].ToString())) +
                         ((r["G12FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE5_9"].ToString())) +
                         ((r["G12FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE10_14"].ToString())) +
                         ((r["G12FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE15_19"].ToString())) +
                         ((r["G12FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE20_24"].ToString())) +
                         ((r["G12FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE25_49"].ToString())) +
                         ((r["G12FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G12FE50"].ToString())) +
                         ((r["TOTALG13"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG13"].ToString())) +
                         ((r["SUBG13M"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG13M"].ToString())) +
                         ((r["G13MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA1"].ToString())) +
                         ((r["G13MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA1_4"].ToString())) +
                         ((r["G13MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA5_9"].ToString())) +
                         ((r["G13MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA10_14"].ToString())) +
                         ((r["G13MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA15_19"].ToString())) +
                         ((r["G13MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA20_24"].ToString())) +
                         ((r["G13MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA25_49"].ToString())) +
                         ((r["G13MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13MA50"].ToString())) +
                         ((r["SUBG13F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG13F"].ToString())) +
                         ((r["G13FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE1"].ToString())) +
                         ((r["G13FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE1_4"].ToString())) +
                         ((r["G13FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE5_9"].ToString())) +
                         ((r["G13FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE10_14"].ToString())) +
                         ((r["G13FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE15_19"].ToString())) +
                         ((r["G13FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE20_24"].ToString())) +
                         ((r["G13FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE25_49"].ToString())) +
                         ((r["G13FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G13FE50"].ToString())) +
                         ((r["TOTALG14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG14"].ToString())) +
                         ((r["SUBG14M"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG14M"].ToString())) +
                         ((r["G14MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA1"].ToString())) +
                         ((r["G14MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA1_4"].ToString())) +
                         ((r["G14MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA5_9"].ToString())) +
                         ((r["G14MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA10_14"].ToString())) +
                         ((r["G14MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA15_19"].ToString())) +
                         ((r["G14MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA20_24"].ToString())) +
                         ((r["G14MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA25_49"].ToString())) +
                         ((r["G14MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14MA50"].ToString())) +
                         ((r["SUBG14F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG14F"].ToString())) +
                         ((r["G14FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE1"].ToString())) +
                         ((r["G14FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE1_4"].ToString())) +
                         ((r["G14FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE5_9"].ToString())) +
                         ((r["G14FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE10_14"].ToString())) +
                         ((r["G14FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE15_19"].ToString())) +
                         ((r["G14FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE20_24"].ToString())) +
                         ((r["G14FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE25_49"].ToString())) +
                         ((r["G14FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G14FE50"].ToString())) +
                         ((r["TOTALG15"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG15"].ToString())) +
                         ((r["SUBG15M"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG15M"].ToString())) +
                         ((r["G15MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15MA15_19"].ToString())) +
                         ((r["G15MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15MA20_24"].ToString())) +
                         ((r["G15MS25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15MS25_49"].ToString())) +
                         ((r["G15MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15MA50"].ToString())) +
                         ((r["SUBG15F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG15F"].ToString())) +
                         ((r["G15FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15FE15_19"].ToString())) +
                         ((r["G15FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15FE20_24"].ToString())) +
                         ((r["G15FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15FE25_49"].ToString())) +
                         ((r["G15FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G15FE50"].ToString())) +
                         ((r["TOTALG16"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["TOTALG16"].ToString())) +
                         ((r["SUBG16M"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG16M"].ToString())) +
                         ((r["G16MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16MA15_19"].ToString())) +
                         ((r["G16MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16MA20_24"].ToString())) +
                         ((r["G16MS25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16MS25_49"].ToString())) +
                         ((r["G16MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16MA50"].ToString())) +
                         ((r["SUBG16F"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["SUBG16F"].ToString())) +
                         ((r["G16FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16FE15_19"].ToString())) +
                         ((r["G16FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16FE20_24"].ToString())) +
                         ((r["G16FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16FE25_49"].ToString())) +
                         ((r["G16FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(r["G16FE50"].ToString())) 
                   );
                 //}
             }
             r.Close();

             SqlCommand cmdHTC3 = new SqlCommand(SQLHTC3, cn);
             r = cmdHTC3.ExecuteReader();
             while (r.Read())
             {
                 HTC3 += (Convert.ToInt32(r["TOTALG17"].ToString()) +
                    Convert.ToInt32(r["SUBG17M"].ToString()) +
                    Convert.ToInt32(r["G17MA1"].ToString()) +
                    Convert.ToInt32(r["G17MA1_4"].ToString()) +
                    Convert.ToInt32(r["G17MA5_9"].ToString()) +
                    Convert.ToInt32(r["G17MA10_14"].ToString()) +
                    Convert.ToInt32(r["G17MA15_19"].ToString()) +
                    Convert.ToInt32(r["G17MA20_24"].ToString()) +
                    Convert.ToInt32(r["G17MA25_49"].ToString()) +
                    Convert.ToInt32(r["G17MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG17F"].ToString()) +
                    Convert.ToInt32(r["G17FE1"].ToString()) +
                    Convert.ToInt32(r["G17FE1_4"].ToString()) +
                    Convert.ToInt32(r["G17FE5_9"].ToString()) +
                    Convert.ToInt32(r["G17FE10_14"].ToString()) +
                    Convert.ToInt32(r["G17FE15_19"].ToString()) +
                    Convert.ToInt32(r["G17FE20_24"].ToString()) +
                    Convert.ToInt32(r["G17FE25_49"].ToString()) +
                    Convert.ToInt32(r["G17FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG18"].ToString()) +
                    Convert.ToInt32(r["SUBG18M"].ToString()) +
                    Convert.ToInt32(r["G18MA1"].ToString()) +
                    Convert.ToInt32(r["G18MA1_4"].ToString()) +
                    Convert.ToInt32(r["G18MA5_9"].ToString()) +
                    Convert.ToInt32(r["G18MA10_14"].ToString()) +
                    Convert.ToInt32(r["G18MA15_19"].ToString()) +
                    Convert.ToInt32(r["G18MA20_24"].ToString()) +
                    Convert.ToInt32(r["G18MA25_49"].ToString()) +
                    Convert.ToInt32(r["G18MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG18F"].ToString()) +
                    Convert.ToInt32(r["G18FE1"].ToString()) +
                    Convert.ToInt32(r["G18FE1_4"].ToString()) +
                    Convert.ToInt32(r["G18FE5_9"].ToString()) +
                    Convert.ToInt32(r["G18FE10_14"].ToString()) +
                    Convert.ToInt32(r["G18FE15_19"].ToString()) +
                    Convert.ToInt32(r["G18FE20_24"].ToString()) +
                    Convert.ToInt32(r["G18FE25_49"].ToString()) +
                    Convert.ToInt32(r["G18FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG19"].ToString()) +
                    Convert.ToInt32(r["SUBG19M"].ToString()) +
                    Convert.ToInt32(r["G19MA1"].ToString()) +
                    Convert.ToInt32(r["G19MA1_4"].ToString()) +
                    Convert.ToInt32(r["G98MA5_9"].ToString()) +
                    Convert.ToInt32(r["G19MA10_14"].ToString()) +
                    Convert.ToInt32(r["G19MA15_19"].ToString()) +
                    Convert.ToInt32(r["G19MA20_24"].ToString()) +
                    Convert.ToInt32(r["G19MA25_49"].ToString()) +
                    Convert.ToInt32(r["G19MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG19F"].ToString()) +
                    Convert.ToInt32(r["G19FE1"].ToString()) +
                    Convert.ToInt32(r["G19FE1_4"].ToString()) +
                    Convert.ToInt32(r["G19FE5_9"].ToString()) +
                    Convert.ToInt32(r["G19FE10_14"].ToString()) +
                    Convert.ToInt32(r["G19FE15_19"].ToString()) +
                    Convert.ToInt32(r["G19FE20_24"].ToString()) +
                    Convert.ToInt32(r["G19FE25_49"].ToString()) +
                    Convert.ToInt32(r["G19FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG20"].ToString()) +
                    Convert.ToInt32(r["SUBG20M"].ToString()) +  //==============
                    Convert.ToInt32(r["G20MA1"].ToString()) +
                    Convert.ToInt32(r["G20MA1_4"].ToString()) +
                    Convert.ToInt32(r["G20MA5_9"].ToString()) +
                    Convert.ToInt32(r["G20MA10_14"].ToString()) +
                    Convert.ToInt32(r["G20MA15_19"].ToString()) +
                    Convert.ToInt32(r["G20MA20_24"].ToString()) +
                    Convert.ToInt32(r["G20MA25_49"].ToString()) +
                    Convert.ToInt32(r["G20MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG20F"].ToString()) +
                    Convert.ToInt32(r["G20FE1"].ToString()) +
                    Convert.ToInt32(r["G20FE1_4"].ToString()) +
                    Convert.ToInt32(r["G20FE5_9"].ToString()) +
                    Convert.ToInt32(r["G20FE10_14"].ToString()) +
                    Convert.ToInt32(r["G20FE15_19"].ToString()) +
                    Convert.ToInt32(r["G20FE20_24"].ToString()) +
                    Convert.ToInt32(r["G20FE25_49"].ToString()) +
                    Convert.ToInt32(r["G20FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG21"].ToString()) +
                    Convert.ToInt32(r["SUBG21M"].ToString()) +
                    Convert.ToInt32(r["G21MA1"].ToString()) +
                    Convert.ToInt32(r["G21MA1_4"].ToString()) +
                    Convert.ToInt32(r["G21MA5_9"].ToString()) +
                    Convert.ToInt32(r["G21MA10_14"].ToString()) +
                    Convert.ToInt32(r["G21MA15_19"].ToString()) +
                    Convert.ToInt32(r["G21MA20_24"].ToString()) +
                    Convert.ToInt32(r["G21MA25_49"].ToString()) +
                    Convert.ToInt32(r["G21MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG21F"].ToString()) +
                    Convert.ToInt32(r["G21FE1"].ToString()) +
                    Convert.ToInt32(r["G21FE1_4"].ToString()) +
                    Convert.ToInt32(r["G21FE5_9"].ToString()) +
                    Convert.ToInt32(r["G21FE10_14"].ToString()) +
                    Convert.ToInt32(r["G21FE15_19"].ToString()) +
                    Convert.ToInt32(r["G21FE20_24"].ToString()) +
                    Convert.ToInt32(r["G21FE25_49"].ToString()) +
                    Convert.ToInt32(r["G21FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG22"].ToString()) +
                    Convert.ToInt32(r["SUBG22M"].ToString()) +
                    Convert.ToInt32(r["G22MA1"].ToString()) +
                    Convert.ToInt32(r["G22MA1_4"].ToString()) +
                    Convert.ToInt32(r["G22MA5_9"].ToString()) +
                    Convert.ToInt32(r["G22MA10_14"].ToString()) +
                    Convert.ToInt32(r["G22MA15_19"].ToString()) +
                    Convert.ToInt32(r["G22MA20_24"].ToString()) +
                    Convert.ToInt32(r["G22MA25_49"].ToString()) +
                    Convert.ToInt32(r["G22MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG22F"].ToString()) +
                    Convert.ToInt32(r["G22FE1"].ToString()) +
                    Convert.ToInt32(r["G22FE1_4"].ToString()) +
                    Convert.ToInt32(r["G22FE5_9"].ToString()) +
                    Convert.ToInt32(r["G22FE10_14"].ToString()) +
                    Convert.ToInt32(r["G22FE15_19"].ToString()) +
                    Convert.ToInt32(r["G22FE20_24"].ToString()) +
                    Convert.ToInt32(r["G22FE25_49"].ToString()) +
                    Convert.ToInt32(r["G22FE50"].ToString()) +
                    Convert.ToInt32(r["G23_1"].ToString()) +
                    Convert.ToInt32(r["G23_2"].ToString()) +
                    Convert.ToInt32(r["TOTALG24"].ToString()) +
                    Convert.ToInt32(r["SUBG24M"].ToString()) +
                    Convert.ToInt32(r["G24MA15_19"].ToString()) +
                    Convert.ToInt32(r["G24MA20_24"].ToString()) +
                    Convert.ToInt32(r["G24MA25_49"].ToString()) +
                    Convert.ToInt32(r["G24MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG24F"].ToString()) +
                    Convert.ToInt32(r["G24FE15_19"].ToString()) +
                    Convert.ToInt32(r["G24FE20_24"].ToString()) +
                    Convert.ToInt32(r["G24FE25_49"].ToString()) +
                    Convert.ToInt32(r["G24FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG25"].ToString()) +
                    Convert.ToInt32(r["SUBG25M"].ToString()) +
                    Convert.ToInt32(r["G25MA15_19"].ToString()) +
                    Convert.ToInt32(r["G25MA20_24"].ToString()) +
                    Convert.ToInt32(r["G25MA25_49"].ToString()) +
                    Convert.ToInt32(r["G25MA50"].ToString()) +
                    Convert.ToInt32(r["SUBG25F"].ToString()) +
                    Convert.ToInt32(r["G25FE15_19"].ToString()) +
                    Convert.ToInt32(r["G25FE20_24"].ToString()) +
                    Convert.ToInt32(r["G25FE25_49"].ToString()) +
                    Convert.ToInt32(r["G25FE50"].ToString()) +
                    Convert.ToInt32(r["TOTALG26"].ToString()) +
                    Convert.ToInt32(r["G26MA1"].ToString()) +
                    Convert.ToInt32(r["G26FE1"].ToString()));

             }
             r.Close();
             THTC = (HTC1+HTC2+HTC3);
             TextBox3.Text = Convert.ToString(THTC);

        }
        catch(Exception ex)
        {
            webMessage.Show("ERROR Displaying Total Thematic : "+ex.Message);
            return;
        }
       
    }

    protected int SumSQL(string FCTName)
    {
        int totalSum = 0;
        try
        {
            using (SqlConnection con = new SqlConnection(ConnectAll.ConnectMe()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT " + FCTName.Trim(), con);
                totalSum = (int)cmd.ExecuteScalar();
                con.Close();
                cmd.Dispose();
            }
            return totalSum;
        }
        catch (Exception ex)
        {
           //webMessage.Show("ERROR Displaying Total on Daishboard: "+ ex.Message.ToString());
            return 0;
        }

    }

    protected void RemoveDuplicate(string TblName)
    {
        try
        {
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            string SQL = "DELETE FROM " + TblName + " WHERE (ID NOT IN (SELECT MIN(ID) FROM " + TblName + " GROUP BY facname, months))";
            SqlCommand cmd = new SqlCommand(SQL, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Importing Xml Successfull...');", true);
            return;
        }
    }

    protected void btnImportXml_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
        string filenames = FileUpload1.FileName.ToString();

        //Server.MapPath(string.Format("~/{0}/", "XML"))
        string Filename = Server.MapPath(string.Format("~/{0}/", "XML") + filenames);

        //string tbl = "";

        if (Filename.Contains("tbl_art1"))
        {
            XMLImport(Filename, "tbl_art1");
        }
        else if (Filename.Contains("tbl_art2"))
        {
            XMLImport(Filename, "tbl_art2");
        }
        else if (Filename.Contains("tbl_care"))
        {
            XMLImport(Filename, "tbl_care");
        }
        else if (Filename.Contains("tbl_gendnorm"))
        {
            XMLImport(Filename, "tbl_gendnorm");
        }
        else if (Filename.Contains("tbl_hivi"))
        {
            XMLImport(Filename, "tbl_hivi");
        }
        else if (Filename.Contains("tbl_htc1"))
        {
            XMLImport(Filename, "tbl_htc1");
        }
        else if (Filename.Contains("tbl_htc2"))
        {
            XMLImport(Filename, "tbl_htc2");
        }
        else if (Filename.Contains("tbl_htc3"))
        {
            XMLImport(Filename, "tbl_htc3");
        }
        else if (Filename.Contains("tbl_lab1"))
        {
            XMLImport(Filename, "tbl_lab1");
        }
        else if (Filename.Contains("tbl_lab2"))
        {
            XMLImport(Filename, "tbl_lab2");
        }
        else if (Filename.Contains("tbl_ovc"))
        {
            XMLImport(Filename, "tbl_ovc");
        }
        else if (Filename.Contains("tbl_pep"))
        {
            XMLImport(Filename, "tbl_pep");
        }
        else if (Filename.Contains("tbl_pmtct"))
        {
            XMLImport(Filename, "tbl_pmtct");
        }
        else if (Filename.Contains("tbl_pp"))
        {
            XMLImport(Filename, "tbl_pp");
        }
        else if (Filename.Contains("tbl_tb1"))
        {
            XMLImport(Filename, "tbl_tb1");
        }
        else if (Filename.Contains("tbl_tb2"))
        {
            XMLImport(Filename, "tbl_tb2");
        }
        else if (Filename.Contains("tbl_tb3"))
        {
            XMLImport(Filename, "tbl_tb3");
        }
        else if (Filename.Contains("tbl_training"))
        {
            XMLImport(Filename, "tbl_training");
        }


        //=== Erasing Duplicate datas =======


        if (Filename.Contains("tbl_art1"))
        {
            RemoveDuplicate("tbl_art1");
        }
        else if (Filename.Contains("tbl_art2"))
        {
            RemoveDuplicate("tbl_art2");
        }
        else if (Filename.Contains("tbl_care"))
        {
            RemoveDuplicate("tbl_care");
        }
        else if (Filename.Contains("tbl_gendnorm"))
        {
            RemoveDuplicate("tbl_gendnorm");
        }
        else if (Filename.Contains("tbl_hivi"))
        {
            RemoveDuplicate("tbl_hivi");
        }
        else if (Filename.Contains("tbl_htc1"))
        {
            RemoveDuplicate("tbl_htc1");
        }
        else if (Filename.Contains("tbl_htc2"))
        {
            RemoveDuplicate("tbl_htc2");
        }
        else if (Filename.Contains("tbl_htc3"))
        {
            RemoveDuplicate("tbl_htc3");
        }
        else if (Filename.Contains("tbl_lab1"))
        {
            RemoveDuplicate("tbl_lab1");
        }
        else if (Filename.Contains("tbl_lab2"))
        {
            RemoveDuplicate("tbl_lab2");
        }
        else if (Filename.Contains("tbl_ovc"))
        {
            RemoveDuplicate("tbl_ovc");
        }
        else if (Filename.Contains("tbl_pep"))
        {
            RemoveDuplicate("tbl_pep");
        }
        else if (Filename.Contains("tbl_pmtct"))
        {
            RemoveDuplicate("tbl_pmtct");
        }
        else if (Filename.Contains("tbl_pp"))
        {
            RemoveDuplicate("tbl_pp");
        }
        else if (Filename.Contains("tbl_tb1"))
        {
            RemoveDuplicate("tbl_tb1");
        }
        else if (Filename.Contains("tbl_tb2"))
        {
            RemoveDuplicate("tbl_tb2");
        }
        else if (Filename.Contains("tbl_tb3"))
        {
            RemoveDuplicate("tbl_tb3");
        }
        else if (Filename.Contains("tbl_training"))
        {
            RemoveDuplicate("tbl_training");
        }

        webMessage.Show(" Importing Xml Successfull...");
        return;
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        string directoryPath = Server.MapPath(string.Format("~/{0}/", "XML"));
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        CreateXML("tbl_art1");
        CreateXML("tbl_art2");
        CreateXML("tbl_care");
        CreateXML("tbl_gendnorm");
        CreateXML("tbl_hivi");
        CreateXML("tbl_htc1");
        CreateXML("tbl_htc2");
        CreateXML("tbl_htc3");
        CreateXML("tbl_lab");
        CreateXML("tbl_lab2");
        CreateXML("tbl_ovc");
        CreateXML("tbl_pep");
        CreateXML("tbl_pmtct");
        CreateXML("tbl_pp");
        CreateXML("tbl_tb1");
        CreateXML("tbl_tb2");
        CreateXML("tbl_tb3");
        CreateXML("tbl_training");

        drpMnth2.ClearSelection();
        TextBox15.Text = string.Empty;

        // Response.Write("<script language=javascript>alert('Export to Xml Successfull...  ');</script>");
        webMessage.Show(" Export to Xml Successfull...'"); 
        return;
    }
    protected void drpThematic_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);

        try
        {
            Page.Response.Redirect("frmViewChart.aspx");

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        } //======

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string sql1 ="delete from tbl_art1";
            string sql2 ="delete from tbl_art2";
            string sql3 ="delete from tbl_care";
            string sql4 ="delete from tbl_gendnorm";
            string sql5 ="delete from tbl_hivi";
            string sql6 ="delete from tbl_htc1";
            string sql7 ="delete from tbl_htc2";
            string sql8 ="delete from tbl_htc3";
            string sql9 ="delete from tbl_lab1";
            string sql10 ="delete from tbl_lab2";
            string sql11 ="delete from tbl_ovc";
            string sql12 ="delete from tbl_pep";
            string sql13 ="delete from tbl_pp";
            string sql14 ="delete from tbl_pmtct";
            string sql15 ="delete from tbl_tb1";
            string sql16 ="delete from tbl_tb2";
            string sql17 ="delete from tbl_tb3";
            string sql18 = "delete from tbl_training";

            ConnectAll.My_SQLINT(sql1);
            ConnectAll.My_SQLINT(sql2);
            ConnectAll.My_SQLINT(sql3);
            ConnectAll.My_SQLINT(sql4);
            ConnectAll.My_SQLINT(sql5);
            ConnectAll.My_SQLINT(sql6);
            ConnectAll.My_SQLINT(sql7);
            ConnectAll.My_SQLINT(sql8);
            ConnectAll.My_SQLINT(sql9);
            ConnectAll.My_SQLINT(sql10);
            ConnectAll.My_SQLINT(sql11);
            ConnectAll.My_SQLINT(sql12);
            ConnectAll.My_SQLINT(sql13);
            ConnectAll.My_SQLINT(sql14);
            ConnectAll.My_SQLINT(sql15);
            ConnectAll.My_SQLINT(sql16);
            ConnectAll.My_SQLINT(sql17);
            ConnectAll.My_SQLINT(sql18);

            webMessage.Show("Database successfully Erased, You now have Zero records...");
            return;
        }
        catch (Exception ex)
        {
            webMessage.Show("Error data can not be erase :" + ex.Message.ToString());
            return;
        }

    }
}