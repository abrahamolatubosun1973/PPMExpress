using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;


/// <summary>
/// Summary description for ConnectAll
/// </summary>
public class ConnectAll
{

    
	public ConnectAll()
	{
		//
		// TODO: Add constructor logic here
		//
        
	}

    //public static void ShowMe(string message)
    //{
    //    // Cleans the message to allow single quotation marks
    //    string cleanMessage = message.Replace("'", "\\'");
    //    string wsScript = "<script type=\"text/javascript\">alert('" + cleanMessage + "');</script>";

    //    // Gets the executing web page
    //    Page page = HttpContext.Current.CurrentHandler as Page;

    //    // Checks if the handler is a Page and that the script isn't allready on the Page
    //    if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
    //    {
    //        //ClientScript.RegisterStartupScript(this.GetType(), "MessageBox", wsScript, true);
    //        page.ClientScript.RegisterClientScriptBlock(typeof(ConnectAll ), "alert", wsScript, false);
    //    }
    //}  

   
    public static void Show(string message)
    {
        string cleanMessage = message.Replace("'", "\'");
        Page page = HttpContext.Current.CurrentHandler as Page;
        string script = string.Format("alert('{0}');", cleanMessage);
        if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
        {
            page.ClientScript.RegisterClientScriptBlock(page.GetType(), "alert", script, true /* addScriptTags */);
        }
    } // end of Alart

    public static String ConnectMe()
    {
        string Constring = "Data Source=.\\SQLExpress;AttachDBFilename=|DataDirectory|EAGMEExpress.mdf;Integrated Security=SSPI;User Instance=False;Trusted_Connection=True;MultipleActiveResultSets=true;";
       //string Constring = "Data Source=mssql4.gear.host;Initial Catalog=dbeagmeexpress;User ID=dbeagmeexpress;Password=Ppmexpress2016@;MultipleActiveResultSets=true;";
        return Constring;
    } //===== End of Connection String


    public static DataRow GetDataRow(string SQL)
    {
        SqlConnection con = new SqlConnection(ConnectMe());
        con.Open();
        SqlDataAdapter AD = new SqlDataAdapter(SQL, con);
        DataSet DS = new DataSet();
        AD.Fill(DS);

        if (DS.Tables[0].Rows.Count > 0)
        {
            return DS.Tables[0].Rows[0];
        }
        return DS.Tables[0].Rows[0];
             
    }

    public static object IIf(bool Expression, object TruePart, object FalsePart)
    {
        object ReturnValue = Expression == true ? TruePart : FalsePart;

        return ReturnValue;
    }

    public static string IIf(bool Expression, string TruePart, string FalsePart)
    {
        string ReturnValue = Expression == true ? TruePart : FalsePart;

        return ReturnValue;
    }

    public static bool IIf(bool Expression, bool TruePart, bool FalsePart)
    {
        bool ReturnValue = Expression == true ? TruePart : FalsePart;

        return ReturnValue;
    }

    public static int IIf(bool Expression, int TruePart, int FalsePart)
    {
        int ReturnValue = Expression == true ? TruePart : FalsePart;

        return ReturnValue;
    }

    public static int My_SQLINT(string SQL)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return 1;
        }catch(Exception ex)
        {
            webMessage.Show(ex.Message.ToString());
            return -1;
        }
        
    }

}