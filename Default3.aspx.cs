using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Office.Interop;
using System.IO;


public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadMonths();
        AddYrs();
        FillThematic();
      
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
            DropDownList1.ClearSelection();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("");
            while (r.Read()) { DropDownList1.Items.Add(r["fname"].ToString()); }

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
                drpMonth.Items.Add(m);
                drpMonth1.Items.Add(m);
            }
            drpMonth.Items.Insert(0, "Select");
            drpMonth.SelectedIndex = 0;
            drpMonth1.Items.Insert(0, "Select");
            drpMonth1.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message.ToString());
        }
    }

    protected void AddYrs()
    {
        int cnt = 2020;
        for (int i = 2001; i <= cnt; i++)
        {
            drpYear.Items.Add(i.ToString());
            drpYear1.Items.Add(i.ToString());
        }

        drpYear.Items.Insert(0, "Select");
        drpYear.SelectedIndex = 0;
        drpYear1.Items.Insert(0, "Select");
        drpYear1.SelectedIndex = 0;
    }





    protected void btnExport_Click(object sender, EventArgs e)
    {
        //Response.ClearContent();
        //Response.Buffer = true;
        //Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Customers.xls"));
        //Response.ContentType = "application/ms-excel";

        DataTable dt = GetDatafromDatabase();
        string str = string.Empty;
        string str1 = string.Empty;
        #region ============ some codes =========
        //foreach (DataColumn dtcol in dt.Columns)
        //{
        //    Response.Write(str + dtcol.ColumnName);
        //    str = "\t";
        //}
        //Response.Write("\n");
        //foreach (DataRow dr in dt.Rows)
        //{
        //    str = "";
        //    for (int j = 0; j < dt.Columns.Count; j++)
        //    {
        //        Response.Write(str + Convert.ToString(dr[j]));
        //        str = "\t";
        //    }
        //    Response.Write("\n");
        //}
        //Response.End();
        #endregion

        // My own Testing Code
        foreach(DataColumn dc in dt.Columns)
        {
            foreach(DataRow dr in dt.Rows)
            {
                ChkLoadData(dr, dc.ColumnName);
            }
        }
    }
    // code to check the compatibily of column and get the row item 
    protected void ChkLoadData(DataRow r, string c)
    {
        string names;
        if (c.Trim() == "state" || c.Trim() == "LGA" || c.Trim() == "months" || c.Trim() == "years" || c.Trim() == "Facname")
        {

        }
        string SQL = "Select * from tbl_defn where code='"+c.Trim()+"' and grouptype = '";

        using (SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
        {
            if(cn.State== ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cmd = new SqlCommand(SQL, cn);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                names = rd["description"].ToString();
            }
        }
    }

    protected DataTable GetDatafromDatabase()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(ConnectAll.ConnectMe()))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from VW_htc",con);    // "Select TOP 10 UserName,LastName,Location FROM UserInformation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        return dt;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
        DropTable();
        CREATTable();
        LoadThematic();
    }
    //IF TABLE tbl_TempReport IF FOUND DROP IT AND RECREATE IT
    private void LoadThematic()
    {
        string m_code;
        string m_descrip;
        object m_value;
        string m_grouptype;
        DataTable dt = GetDatafromDatabase();

        // My own Testing Code
        foreach (DataColumn dc in dt.Columns)
        {
            foreach (DataRow dr in dt.Rows)
            {
                string SQL = "Select * from tbl_defn where code='" + dc.ToString().Trim() + "'";  // and grouptype = 'htc'";
                using (SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand(SQL, cn);
                    SqlDataReader rd = cmd.ExecuteReader();
                   
                    while (rd.Read())
                    {
                        m_code = dc.ToString();
                        m_descrip = rd["description"].ToString();
                        m_value = dr.ToString();
                        m_grouptype = rd["grouptype"].ToString();
                        rd.Close();
                        //pass the code and description and value to the reporting table
                        string sqlIN = "INSERT INTO tbl_TempReport (code,descrip,value,grouptype) VALUES(@code,@descrip,@value,@grouptype)";
                        if(cn.State== ConnectionState.Closed)
                        {
                            cn.Open();
                        }
                        SqlCommand cmdIN = new SqlCommand(sqlIN, cn);
                        cmdIN.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = m_code;
                        cmdIN.Parameters.AddWithValue("@descrip", SqlDbType.NVarChar).Value = m_descrip;
                        cmdIN.Parameters.AddWithValue("@value", SqlDbType.Int).Value = m_value;
                        cmdIN.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = m_grouptype;
                        cmdIN.ExecuteNonQuery();
                       // names = rd["description"].ToString();
                    }
                }
               /// ChkLoadData(dr, dc.ColumnName);
            }
        }
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
            using(SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQLT, cn);
                done= cmd.ExecuteNonQuery();
            }
        }catch(Exception ex)
        {
            webMessage.Show("Error check for temp table :"+ex.Message);
        }
    }

    protected void btnReport_Click(object sender, EventArgs e)
    {
        try
        {
            DropTable();
            CREATTable();

    //========= Return a data table ============
            DataTable dt = GetDatafromDatabase();


        }catch(Exception ex)
        {
            webMessage.Show("Error check for temp table :" + ex.Message);
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DropTable();
        CREATTable();

        string SQLH = "SELECT * FROM tbl_defn WHERE grouptype = '" + "HTC" + "' ";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQLH, cn);
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read())
        {
            string SQLIN = "INSERT INTO tbl_TempReport(grouptype,code,descrip) VALUES(@grouptype,@code,@descrip) ";
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cmdINS = new SqlCommand(SQLIN, cn);
          
            cmdINS.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = r["grouptype"].ToString();
            cmdINS.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = r["code"].ToString();
            cmdINS.Parameters.AddWithValue("@descrip", SqlDbType.NVarChar).Value = r["description"].ToString();
            cmdINS.ExecuteNonQuery();
        }

        DataTable dt = GetDatafromDatabase(); //===== returns a DataTable
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
            // For each row, print the values of each column.
            foreach (DataColumn column in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    colname = column.ColumnName.ToString();
                    //if (colname == "ID")
                    //{
                    //   // break;
                    //    rt.NextResult();
                    //}
                    //else
                    //{
                    string m_Code = rt["code"].ToString();
                        if (m_Code == colname)
                        {
                            //insert into tbl_TempReport to match the appropriate column
                            string SQLP = "UPDATE tbl_TempReport SET VALUEP = @VALUEP WHERE code = @code";
                            SqlCommand cmdp = new SqlCommand(SQLP, cn);
                            cmdp.Parameters.AddWithValue("@VALUEP", SqlDbType.Int).Value =  row[column].ToString();
                            cmdp.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = rt["code"].ToString();
                            cmdp.ExecuteNonQuery();
                        }
                        //ListBox1.Items.Add(row[column.ColumnName].ToString());
                    //}
                    //======
                }
            }
        }

        //========== Write to Excel
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Workbook xlWBK;
        Microsoft.Office.Interop.Excel.Worksheet xlWS;
        object misValue = System.Reflection.Missing.Value;

        try
        {
            DataSet ds = new DataSet();
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            string SQLL = "SELECT * FROM tbl_TempReport ";
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

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWBK = xlApp.Workbooks.Add(misValue);
            xlWS = (Microsoft.Office.Interop.Excel.Worksheet)xlWBK.Worksheets.get_Item(1);
            xlApp.Visible = true;

            xlWS.Columns.Font.Bold = true;
            for (int l = 0; l <= ds.Tables[0].Columns.Count - 1; l++)
            {
                xlWS.Columns.AutoFit();
                xlWS.Columns.Font.Bold=true;

                xlWS.Cells[1, l + 1] = ds.Tables[0].Columns[l].ColumnName.Trim();
            }
            xlWS.Columns.Font.Bold = false;

            for (int i = 1; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    var data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWS.Columns.AutoFit();
                    xlWS.Cells[i + 1, j + 1] = data;
                }
            }

            //string path = @"C:\EMR_INTERFACE\XLS\";  // HttpContext.Current.Server.MapPath("/");
            xlWBK.SaveAs(directoryPath + "HTC" + ".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWBK.Close(true, misValue, misValue);
            //xlApp.Quit();
            cn.Close();

            //releaseObject(xlWS);
            //releaseObject(xlWBK);
            //releaseObject(xlApp);
            
        }
        catch (Exception ex)
        {

        }//======== Excel 



    }
}

