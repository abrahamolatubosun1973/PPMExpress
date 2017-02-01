using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Office.Interop;

public partial class Programm_Program_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            FillState();
            FillThematic();
            LoadMonths();
            AddYrs();
            StartLongRunningTask();
        }
    }

    protected void FillState()
    {
        string SQl = "Select Distinct statename from tbl_States order by statename asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpStates.ClearSelection();
            drpStates.Items.Clear();
            drpStates.Items.Add("");
            while (r.Read()) { drpStates.Items.Add(r["statename"].ToString()); }

        }
        catch (Exception e)
        {
            Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
            return;
        }
    }


    protected void FillThematic()
    {
        string SQl = "Select * from tbl_grpname order by abrv asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpProgramArea.ClearSelection();
            drpProgramArea.Items.Clear();
            drpProgramArea.Items.Add("");
            while (r.Read()) { drpProgramArea.Items.Add(r["fname"].ToString()); }

        }
        catch (Exception e)
        {
            Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
            return;
        }
    }


    private void LoadMonths()
    {
        try
        {
            string[] monthNames = (new System.Globalization.CultureInfo("en-US")).DateTimeFormat.MonthNames;
            foreach (string m in monthNames) // writing out
            {
                drpMonths.Items.Add(m);
                drpMonths2.Items.Add(m);
            }
            drpMonths.Items.Insert(0, "Select");
            drpMonths.SelectedIndex = 0;
            drpMonths2.Items.Insert(0, "Select");
            drpMonths2.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message.ToString());
        }
    }

    protected void AddYrs()
    {
        int cnt = 2020;
        int starts = 0;

        for (int i = 2001; i <= cnt; i++)
        {
            drpYears.Items.Add(i.ToString());
            drpYears2.Items.Add(i.ToString());
        }

        drpYears.Items.Insert(0, "Select");
        drpYears.SelectedIndex = 0;
        drpYears2.Items.Insert(0, "Select");
        drpYears2.SelectedIndex = 0;
    }





    protected void drpStates_SelectedIndexChanged(object sender, EventArgs e)
    {
        string SQL, SQL1 = "";
        if (drpStates.SelectedItem.Text.Trim() == "Ebonyi")
        {
            SQL1 = "Abakaliki";
            SQL = "SELECT * from tbl_states where capitals ='" + SQL1 + "' order by lga asc";
        }
        else
        {
            SQL = "SELECT * from tbl_states where statename ='" + drpStates.SelectedItem.Text.Trim() + "' order by lga asc";
        }
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQL, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpLGA.ClearSelection();
            drpLGA.Items.Clear();
            drpLGA.Items.Add("");
            while (r.Read()) { drpLGA.Items.Add(r["lga"].ToString()); }

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void drpLGA_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            drpFacname.Items.Clear();
            drpFacname.Items.Add("");
            string sql = "Select * from tbl_facility where statename ='" + drpStates.SelectedItem.Text.Trim() + "' and lga ='" + drpLGA.SelectedItem.Text.Trim() + "' order by facname asc";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                drpFacname.Items.Add(r["facname"].ToString());
            }
        }
        catch (Exception ex)
        {
            webMessage.Show("Error : " + ex.Message.ToString());
            return;
        }
    }
    protected void drpProgramArea_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    /* 
     // http://localhost:26994/image/bar-ajax-loader.gif
     * */
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.lblMsg.Visible = this.Image2.Visible = true;
        this.Timer1.Enabled = true;

        DropTable();
        CREATTable();
        //return;
         string mFile11 = drpProgramArea.SelectedItem.Text.Trim();
        // Console.WriteLine("Hello \n");

        string mFile1 = string.Empty;
        string mTableName = string.Empty;

        GetThematic(mFile11, out mFile1);

        //string SQL = "SELECT * FROM tbl_TargetAssin where grouptype ='" + mFile1.Trim() + "' and facname ='" + drpFacname.SelectedItem.Text.Trim() +
        //              "' and (myears =  '" + drpYears.SelectedItem.Text.Trim() + "') and (myears= '" + drpYears2.SelectedItem.Text.Trim() +
        //             "' and months IN ('" + drpMonths.SelectedItem.Text.Trim() + "' , '" + drpMonths2.SelectedItem.Text.Trim() + "'))";

        string SQL = string.Concat("SELECT * FROM tbl_TargetAssin where grouptype ='" + mFile1.Trim() + "' and facname ='" + drpFacname.SelectedItem.Text.Trim() +"' and ",
                                   "myears Between  '" + drpYears.SelectedItem.Text.Trim() + "' and '" + drpYears2.SelectedItem.Text.Trim() + "' and months between ",
                                   "'"+ drpMonths.SelectedItem.Text.Trim() + "' and '" + drpMonths2.SelectedItem.Text.Trim() + "'");

        try
        {
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()); 
               cn.Open();
             SqlCommand cmd = new SqlCommand(SQL, cn);
             SqlDataReader r = cmd.ExecuteReader();
             while (r.Read())
             {
                 string SQLA = "INSERT INTO tbl_PROGACHIVE (GROUPTYPE,code,MONTHS,mYEAR,DESCRIP,TARGETVALUE) VALUES(@GROUPTYPE,@code,@MONTHS,@mYEAR,@DESCRIP,@TARGETVALUE) ";
                 if (cn.State == ConnectionState.Closed)
                 {
                     cn.Open();
                 }
                 SqlCommand cmds = new SqlCommand(SQLA, cn);
                 cmds.Parameters.AddWithValue("@GROUPTYPE", SqlDbType.NVarChar).Value = r["grouptype"].ToString();
                 cmds.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = r["code"].ToString();
                 cmds.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = r["months"].ToString();
                 cmds.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = r["myears"].ToString();
                 cmds.Parameters.AddWithValue("@descrip", SqlDbType.NVarChar).Value = r["DESCRIPTION"].ToString();
                     cmds.Parameters.AddWithValue("@targetvalue",SqlDbType.Int).Value = Convert.ToInt32(r["targetvalue"].ToString());
                 cmds.ExecuteNonQuery();
             }

            
             //for (int i=1; i < DT.Rows.Count; i++)
             //{

             //}
             string Colname = string.Empty;
             DataTable DT = new DataTable();
             DT = GetDatafromDatabase();

             string SQLP = "Select * from tbl_PROGACHIVE WHERE   (myear= '" + drpYears.SelectedItem.Text.Trim() + "') OR (myear= '" + drpYears2.SelectedItem.Text.Trim() +
                           "' and months IN ('" + drpMonths.SelectedItem.Text.Trim() + "' , '" + drpMonths2.SelectedItem.Text.Trim() + "'))";
             if (cn.State == ConnectionState.Closed)
             {
                 cn.Open();
             }
             SqlCommand cmdP = new SqlCommand(SQLP, cn);
             SqlDataReader rp = cmdP.ExecuteReader();
             while (rp.Read())
             {
                 int Values = 0;

                 foreach (DataColumn col in DT.Columns)
                 {
                     foreach (DataRow row in DT.Rows)
                     {
                           string codep = rp["code"].ToString();
                        
                           Colname = col.ColumnName.ToString();
                         
                          
                           if (codep.Trim() == Colname.Trim())
                           {
                               string UpdateMonth = rp["months"].ToString().ToUpper(); ;
                                                            
                              if(UpdateMonth== "JANUARY")
                              {
                                  string SQLUPDATEJAN = "UPDATE tbl_PROGACHIVE SET JANUARY=@JANUARY WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd1 = new SqlCommand(SQLUPDATEJAN, cn);
                                       vcmd1.Parameters.AddWithValue("@JANUARY", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd1.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd1.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd1.ExecuteNonQuery();
                              }else if(UpdateMonth== "FEBRUARY")
                              {
                                  string SQLUPDATEFEB = "UPDATE tbl_PROGACHIVE SET FEBRUARY=@FEBRUARY WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd2 = new SqlCommand(SQLUPDATEFEB, cn);
                                       vcmd2.Parameters.AddWithValue("@FEBRUARY", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd2.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd2.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd2.ExecuteNonQuery();
                              }else if(UpdateMonth == "MARCH")
                              {
                                  string SQLUPDATEMAR = "UPDATE tbl_PROGACHIVE SET MARCH=@MARCH WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd3 = new SqlCommand(SQLUPDATEMAR, cn);
                                       vcmd3.Parameters.AddWithValue("@MARCH", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd3.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd3.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd3.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd3.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd3.ExecuteNonQuery();
                              }else if(UpdateMonth == "APRIL")
                              {
                                  string SQLUPDATEAPR = "UPDATE tbl_PROGACHIVE SET APRIL=@APRIL WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd4 = new SqlCommand(SQLUPDATEAPR, cn);
                                       vcmd4.Parameters.AddWithValue("@APRIL", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd4.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd4.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd4.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd4.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd4.ExecuteNonQuery();
                              }else if(UpdateMonth == "MAY")
                              {
                                  string SQLUPDATEMAY = "UPDATE tbl_PROGACHIVE SET MAY=@MAY WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd5 = new SqlCommand(SQLUPDATEMAY, cn);
                                       vcmd5.Parameters.AddWithValue("@MAY", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd5.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd5.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd5.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd5.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd5.ExecuteNonQuery();
                              }else if(UpdateMonth == "JUNE")
                              {
                                  string SQLUPDATEJUNE = "UPDATE tbl_PROGACHIVE SET JUNE=@JUNE WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd6 = new SqlCommand(SQLUPDATEJUNE, cn);
                                       vcmd6.Parameters.AddWithValue("@JUNE", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd6.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd6.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd6.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd6.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd6.ExecuteNonQuery();
                              }else if(UpdateMonth == "JULY")
                              {
                                  string SQLUPDATEJULY = "UPDATE tbl_PROGACHIVE SET JULY=@JULY WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd7 = new SqlCommand(SQLUPDATEJULY, cn);
                                       vcmd7.Parameters.AddWithValue("@JULY", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd7.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd7.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd7.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd7.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd7.ExecuteNonQuery();
                              }else if(UpdateMonth == "AUGUST")
                              {
                                  string SQLUPDATEAUG = "UPDATE tbl_PROGACHIVE SET AUGUST=@AUGUST WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd8 = new SqlCommand(SQLUPDATEAUG, cn);
                                       vcmd8.Parameters.AddWithValue("@AUGUST", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd8.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd8.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd8.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd8.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd8.ExecuteNonQuery();
                              }else if(UpdateMonth == "SEPTEMBER")
                              {
                                  string SQLUPDATESEPT = "UPDATE tbl_PROGACHIVE SET SEPTEMBER=@SEPTEMBER WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd9 = new SqlCommand(SQLUPDATESEPT, cn);
                                       vcmd9.Parameters.AddWithValue("@SEPTEMBER", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd9.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd9.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd9.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd9.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd9.ExecuteNonQuery();
                              }else if(UpdateMonth == "OCTOBER")
                              {
                                  string SQLUPDATEOCT = "UPDATE tbl_PROGACHIVE SET OCTOBER=@OCTOBER WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd10 = new SqlCommand(SQLUPDATEOCT, cn);
                                       vcmd10.Parameters.AddWithValue("@OCTOBER", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd10.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd10.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd10.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd10.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd10.ExecuteNonQuery();
                              }else if(UpdateMonth == "NOVEMBER")
                              {
                                  string SQLUPDATE = "UPDATE tbl_PROGACHIVE SET NOVEMBER=@NOVEMBER WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd11 = new SqlCommand(SQLUPDATE, cn);
                                       vcmd11.Parameters.AddWithValue("@NOVEMBER", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd11.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd11.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd11.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd11.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd11.ExecuteNonQuery();
                              }else if(UpdateMonth == "DECEMBER")
                              {
                                  string SQLUPDATEDEC = "UPDATE tbl_PROGACHIVE SET DECEMBER=@DECEMBER WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                                       if (cn.State == ConnectionState.Closed)
                                       {
                                           cn.Open();
                                       }
                                       SqlCommand vcmd12 = new SqlCommand(SQLUPDATEDEC, cn);
                                       vcmd12.Parameters.AddWithValue("@DECEMBER", SqlDbType.Int).Value = Convert.ToInt32(row[col].ToString());
                                       vcmd12.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = rp["grouptype"].ToString();
                                       vcmd12.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rp["code"].ToString();
                                       vcmd12.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = rp["months"].ToString();
                                       vcmd12.Parameters.AddWithValue("@myear", SqlDbType.NVarChar).Value = rp["myear"].ToString();
                                       vcmd12.ExecuteNonQuery();
                               }
                                                            
                               //string SQLUPDATE = "UPDATE tbl_PROGARCHIVE SET  WHERE grouptype=@grouptype and code=@code and months=@months and myear =@myear";
                           }
                     }
                 }
             }
        }
        catch (Exception ex)
        {
            webMessage.Show("Error : " + ex.Message.ToString());
            return;
        }

    }

   
 
    private void DropTable()
    {
        try
        {
            string SQLT = "Drop Table tbl_PROGACHIVE";
            int done = 0;
            using (SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQLT, cn);
                done = cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            webMessage.Show("Error check for temp table :" + ex.Message);
        }
    }
    private void CREATTable()
    {
        try
        {
            string SQLT = string.Concat("CREATE TABLE tbl_PROGACHIVE (ID INT IDENTITY (1,1) NOT NULL, GROUPTYPE NVARCHAR(50),code NVARCHAR(50),MONTHS NVARCHAR(50),",
                                        "mYEAR NVARCHAR(50),DESCRIP NVARCHAR(MAX),TARGETVALUE INT, JANUARY INT, FEBRUARY INT, MARCH INT, APRIL INT, MAY INT, JUNE INT,",
                                        "JULY INT, AUGUST INT, SEPTEMBER INT, OCTOBER INT, NOVEMBER INT, DECEMBER INT)");
            int done = 0;
            using (SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQLT, cn);
                done = cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            webMessage.Show("Error check for temp table :" + ex.Message);
        }
    }

    public DataTable GetDatafromDatabase()
    {
        string mFile11 = drpProgramArea.SelectedItem.Text.Trim();
        // Console.WriteLine("Hello \n");
        string mFile1 = string.Empty;
        string mTableName = string.Empty;

        GetThematic(mFile11, out mFile1);

        if (mFile1 == "PMTCT")
        {
            mTableName = "VW_PMTCT";
        }
        if (mFile1 == "HTC")
        {
            mTableName = "VW_HTC";
        }
        if (mFile1 == "TB")
        {
            mTableName = "VW_TB";
        }
        if (mFile1 == "LAB")
        {
            mTableName = "VW_LAB";
        }
        if (mFile1 == "ART")
        {
            mTableName = "VW_ART";
        }
        if (mFile1 == "CARE")
        {
            mTableName = "VW_CARE";
        }
        if (mFile1 == "OVC")
        {
            mTableName = "tbl_OVC";
        }
        if (mFile1 == "GN")
        {
            mTableName = "tbl_GendNorm";
        }
        if (mFile1 == "PEP")
        {
            mTableName = "tbl_PEP";
        }
        if (mFile1 == "PP")
        {
            mTableName = "tbl_PP";
        }
        if (mFile1 == "HIVI")
        {
            mTableName = "tbl_HIVI";
        }
        if (mFile1 == "TRAINING")
        {
            mTableName = "tbl_TRAINING";
        }

        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(ConnectAll.ConnectMe()))
        {

            con.Open();
            string SQLL = "Select * from " + mTableName + " WHERE states='" + drpStates.SelectedItem.Text.Trim() + "' and lga ='" + drpLGA.SelectedItem.Text.Trim() +
                          "' and Facname ='" + drpFacname.SelectedItem.Text.Trim() + "' AND (years= '" + drpYears.SelectedItem.Text.Trim() + "') OR (years= '" + drpYears2.SelectedItem.Text.Trim() +
                          "' and months IN ('" + drpMonths.SelectedItem.Text.Trim() + "' , '" + drpMonths2.SelectedItem.Text.Trim() + "'))";
            SqlCommand cmd = new SqlCommand(SQLL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        return dt;
    }

    //This returns the Programm ABRIVIATION Name in the Table
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
                fname = rd["FID"].ToString();

            }

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int maxIndex = Convert.ToInt32(this.Application["MaxIndex"]);
        int counetr = Convert.ToInt32(this.Application["Counter"]);
        
        if(counetr>=maxIndex)
        {
            this.Image2.Visible = false;
            this.Timer1.Enabled = false;
            lblMsg.Text = "Process Complete.....";
        }
        else
        {
            this.lblMsg.Text = "Processing "+counetr+" of "+maxIndex+" files";
            this.Application["Counter"] = ++counetr;
        }
    }

    protected void StartLongRunningTask()
    {
        this.Application["MaxIndex"] = "200";
        this.Application["Counter"] = "1";
    }






}