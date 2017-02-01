using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;

/// <summary>
/// Summary description for FindTable
/// </summary>
public class FindTable
{
	public FindTable()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static int ProgramTable(string theTable)
    {
        try
        {
            SqlConnection SC = new SqlConnection(ConnectAll.ConnectMe());
            string cmdText = @"IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_NAME='" + theTable + "') SELECT 1 ELSE SELECT 0";
               SC.Open();
                SqlCommand DateCheck = new SqlCommand(cmdText, SC);
                 int x = Convert.ToInt32(DateCheck.ExecuteScalar());
                 if (x == 1)
                    return 1;
               else
                return 0 ;

                SC.Close();
            
        }
        catch (Exception ex)
        {
            return -1;
        }
         
    }//===end


    public static DataTable GetTableDefin(string fileName)
    {
        var Dat = new DataTable();


        return Dat;
    }

    public static void TestWhile()
    {
        var Dat = GetTableDefin("Ret");

    }

    public static DataTable GetFacilityName(string State, string LGA)
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = new SqlConnection(ConnectAll.ConnectMe()) )
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_GetFacilityName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@State", SqlDbType.NVarChar).Value = State;
            cmd.Parameters.AddWithValue("@LGA", SqlDbType.NVarChar).Value = LGA;
            cmd.Connection = con;
            var sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }
    }

    public static void InsertTempReport(string GroupType,string Code, string Desc)
    {
        var Dat = new DataTable();
        using(SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_InsertTempReport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection=cn;
            cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = GroupType;
            cmd.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = Code;
            cmd.Parameters.AddWithValue("@descrip", SqlDbType.NVarChar).Value = Desc;
             cmd.ExecuteNonQuery();   
        }
    }

    public static DataTable SearchTableDefine(string mFile)
    {
        var Dat = new DataTable();
        using(SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SearchTableDefine";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@mFile", SqlDbType.NVarChar).Value = mFile;
            var sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(Dat);
            return Dat;

        }
    }

    public static DataTable GetDatafromDatabase(string ProgArea,string State,string LGA,string FacName,string Year1,string Year2,Int32 Month1, Int32 Month2)
    {
        string mFile11 = ProgArea;
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
            string SQLL = "Select * from " + mTableName + " WHERE states='" + State+ "' and lga ='" + LGA +
                          "' and Facname ='" + FacName + "' AND years = '" + Year1 + "' OR (years = '" + Year2+
                          "' and months IN ('" + Month1 + "' , '" + Month2 + "'))";
            SqlCommand cmd = new SqlCommand(SQLL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        return dt;


    }

    //This returns the Programm ABRIVIATION Name in the Table
    public static void GetThematic(string thematicname, out string fname)
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
           webMessage.Show("Error :" + ex.Message.ToString() );
            return;
        }

    }

    public enum Lmonth
    {
        January = 1,
        February,
        March, April,
        May, June,
        July, August,
        September, October,
        November, December
    }

    public static int GetMonths(string Mnth)
    {
        switch(Mnth)
        {
            case "January":
                return (int)Lmonth.January;
            case "February":
                return (int)Lmonth.February;
            case "March":
                return (int)Lmonth.March;
            case "April":
                return (int)Lmonth.April;
            case "May":
                return (int)Lmonth.May;
            case "June":
                return (int)Lmonth.June;
            case "July":
                return (int)Lmonth.July;
            case "August":
                return (int)Lmonth.August;
            case "September":
                return (int)Lmonth.September;
            case "October":
                return (int)Lmonth.October;
            case "November":
                return (int)Lmonth.November;
            case "December":
                return (int)Lmonth.December;
            default:
                return 0;
        }
    }
    





}