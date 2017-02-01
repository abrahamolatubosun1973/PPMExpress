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
using OfficeOpenXml;
using System.Net;

public partial class Frm_ReportTemp : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillState();
            FillThematic();
            LoadMonths();
            AddYrs();
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



    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DataEntries.aspx");
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
           webMessage.Show("Error Message : " + ex.Message.ToString()   ) ;
            return;
        }
    }
    protected void drpLGA_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            drpFacname.Items.Clear();
            drpFacname.Items.Add("");
            var Dat = FindTable.GetFacilityName(drpStates.SelectedItem.Text.Trim(), drpLGA.SelectedItem.Text.Trim());
            foreach(DataRow r in Dat.Rows)
            {
                drpFacname.Items.Add(r["facname"].ToString());
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
        DropTable();
        CREATTable();

        //==================================================
        string mFile1 = drpProgramArea.SelectedItem.Text.Trim();
        // Console.WriteLine("Hello \n");
        string mFile = string.Empty;
        string mTableName = string.Empty;

      FindTable.GetThematic(mFile1, out mFile);  //<====== return groupType
        //===============================================================

        //string SQLH = "SELECT * FROM tbl_defn WHERE grouptype = '" + mFile + "' ";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        //SqlCommand cmd = new SqlCommand(SQLH, cn);
        //SqlDataReader r = cmd.ExecuteReader();
        //while (r.Read())
        //{
            var Dat = new DataTable();
            Dat = FindTable.SearchTableDefine(mFile);
            foreach (DataRow r in Dat.Rows)
            {
                //insert via procedure
                FindTable.InsertTempReport(r["grouptype"].ToString(), r["code"].ToString(), r["description"].ToString());
            }

            var Mnth1 = FindTable.GetMonths(drpMonths.SelectedItem.Text.Trim());
            var Mnth2 = FindTable.GetMonths(drpMonths2.SelectedItem.Text.Trim());

            //DataTable dt = GetDatafromDatabase(drpProgramArea.SelectedItem.Text.Trim(),); //===== returns a DataTable
            DataTable dt = FindTable.GetDatafromDatabase(drpProgramArea.SelectedItem.Text.Trim(), drpStates.SelectedItem.Text.Trim(),
                                                         drpLGA.SelectedItem.Text.Trim(), drpFacname.SelectedItem.Text.Trim(), 
                                                         drpYears.SelectedItem.Text.Trim(), drpYears2.SelectedItem.Text.Trim(),
                                                        Mnth1, Mnth2);
        string SQLT = "SELECT * FROM tbl_TempReport";
        string colname;
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }
        SqlCommand cmdT = new SqlCommand(SQLT, cn);
        SqlDataReader rt = cmdT.ExecuteReader();
        while (rt.Read())
        {
            //==== For each row, print the values of each column.
            int mValue = 0;

            foreach (DataColumn column in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    colname = column.ColumnName.ToString();

                    
                    string m_Code = rt["code"].ToString();
                   
                    if (m_Code == colname)
                    {
                       // mValue = Convert.ToInt32((! string.IsNullOrEmpty(rt["ValueP"].ToString()) ? rt["ValueP"].ToString() :"0") );
                        if (!string.IsNullOrEmpty(row[column].ToString()))
                        {
                            //&& mValue > 0
                               if (m_Code == colname) { mValue += Convert.ToInt32(row[column].ToString()); } else { mValue = Convert.ToInt32(row[column].ToString()); }
                        
                          
                        }
                  
                     //============ insert into tbl_TempReport to match the appropriate column ====================
                        string SQLP = "UPDATE tbl_TempReport SET VALUEP = @VALUEP WHERE code = @code";
                        SqlCommand cmdp = new SqlCommand(SQLP, cn);
                        cmdp.Parameters.AddWithValue("@VALUEP", SqlDbType.Int).Value = mValue;
                        cmdp.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rt["code"].ToString();
                        cmdp.ExecuteNonQuery();
                    }
                }
            }
        }
        //==============================================================================================
        //==========      Display the Data to Excel                             ========================
        //==============================================================================================
             DisplayExcel(); //

    }

    private void DisplayExcel()
    {
        //========== Write to Excel
      //  Microsoft.Office.Interop.Excel.Application xlApp;
        ExcelPackage ps = new ExcelPackage();
        ps.Workbook.Worksheets.Add("DATA_SHEET");
        ExcelWorksheet ws = ps.Workbook.Worksheets[1];
        
        //Microsoft.Office.Interop.Excel.Workbook xlWBK;
        //Microsoft.Office.Interop.Excel.Worksheet xlWS;
        object misValue = System.Reflection.Missing.Value;
         
        ExcelRange ChartRange = ws.Cells["A1:C1"];

        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        try
        {
            DataSet ds = new DataSet();
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            string SQLL = "SELECT descrip,valuep FROM tbl_TempReport ";
            SqlCommand cmd1 = new SqlCommand(SQLL, cn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd1);
            cmd1.Connection = cn;
            DA.SelectCommand = cmd1;

            DA.Fill(ds);

            //=====================================================
            string directoryPath = Server.MapPath(string.Format("~/{0}/", "XLS"));
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //xlApp = new Microsoft.Office.Interop.Excel.Application();
            //xlWBK = xlApp.Workbooks.Add(misValue);
            //xlWS = (Microsoft.Office.Interop.Excel.Worksheet)xlWBK.Worksheets.get_Item(1);
            //xlApp.Visible = false;

            //ChartRange = xlWS.get_Range("A1","C2");
            //ChartRange.Font.Bold = true;
            
            ws.Cells[1, 1].Value ="Facility Name :"+ drpFacname.SelectedItem.Text.Trim();
            ws.Cells[2, 1].Value = "Period From :" + drpMonths.SelectedItem.Text.Trim() + "/" + drpYears.SelectedItem.Text.Trim() + "      " + 
                                "TO :" + drpMonths2.SelectedItem.Text.Trim() + "/" + drpYears2.SelectedItem.Text.Trim();
            
           //xlWS.Columns.Font.Bold = false;
            //ChartRange = xlWS.get_Range("A4", "B4");
            //ChartRange.Font.Bold = true;
            ws.Cells["A4"].Value = "Description";
            ws.Cells["B4"].Value = "Data";
            //for (int t =4; t <= 4; t++)
            //{
            //    for (int l = 0; l <= ds.Tables[0].Columns.Count - 1; l++)
            //    {
            //        ws.Cells[t, l + 1].Value = ds.Tables[0].Columns[l].ColumnName.Trim();
            //    }
            //}

            int p = 4;
            int cnt = 4;
            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    ws.Cells.Style.WrapText = false;
                    var data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    ws.Column(1).AutoFit();
                    
                    ws.Cells[p + 1, j + 1].Value = data;
                }
                p += 1;
                cnt = p;
            }

            //ChartRange = xlWS.get_Range("A4", Convert.ToString(cnt));
            //ChartRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);

            //string path = @"C:\EMR_INTERFACE\XLS\";  // HttpContext.Current.Server.MapPath("/");
            string PathsTo = directoryPath +drpProgramArea.SelectedItem.Text.Trim()+"-"+drpYears.SelectedItem.Text.Trim()+"-"+drpYears2.SelectedItem.Text + ".xls";
            //xlWBK.SaveAs(PathsTo, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            //    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            //============ Download Excel file =====================
            //Generate A File with Random name
            Byte[] bin = ps.GetAsByteArray();
            string files = PathsTo; 
            File.WriteAllBytes(files, bin);
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("Content-Disposition",string.Format("attachment; filename={0}",files));
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(files);
            Response.End();
            //========================================================================

            //xlWBK.Close(true, misValue, misValue);
            //xlApp.Quit();
            cn.Close();

            //releaseObject(xlWS);
            //releaseObject(xlWBK);
            //releaseObject(xlApp);

        }
        catch (Exception ex)
        {
            // webMessage.Show("Error Displaying Excel Content :" + ex.Message.ToString());
        }//======== Excel 

    }

    private void DropTable()
    {
        try
        {
            string SQLT = "drop table tbl_TempReport";
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
            string SQLT = "CREATE TABLE tbl_TempReport ( GROUPTYPE NVARCHAR(50),code NVARCHAR(50), DESCRIP NVARCHAR(MAX),VALUEP NVARCHAR(50))";
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

    

    protected void drpMonths0_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void drpProgramArea_SelectedIndexChanged(object sender, EventArgs e)
    {

    }







    
}