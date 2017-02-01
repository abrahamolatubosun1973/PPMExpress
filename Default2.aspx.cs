using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.IO;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.EnableViewState = false;
    }

    protected void Fillgrd()
    {
        try
        {
            string SQL = "Select * from tbl_facility";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(' Facility "+ex.Message.ToString()+"';", true);
            return;
        }
    }

    protected void drpTest_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    protected void btnExport_Click(object sender, EventArgs e)
    {
        string directoryPath = Server.MapPath(string.Format("~/{0}/", "XML"));
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        CreateXML("tbl_art");
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

        ComboBox1.ClearSelection();
        TextBox15.Text = string.Empty;

       // Response.Write("<script language=javascript>alert('Export to Xml Successfull...  ');</script>");
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Export to Xml Successfull...');", true);
        return;
    }

    protected void CreateXML(string TblName)
    {
        #region how to create and delete directory

        //string directoryPath = Server.MapPath(string.Format("~/{0}/", txtFolderName.Text.Trim()));
        //if (!Directory.Exists(directoryPath))
        //{
        //    Directory.CreateDirectory(directoryPath);
        //}
        //else
        //{
        //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory already exists.');", true);
        //}
        //=============================================================================================
        //string directoryPath = Server.MapPath(string.Format("~/{0}/", txtFolderName.Text.Trim()));
        //if (Directory.Exists(directoryPath))
        //{
        //    Directory.Delete(directoryPath);
        //}
        //else
        //{
        //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory does not exist.');", true);
        //}

        #endregion

        try
        {
            string mName = TextBox15.Text.Trim() + "_"+TblName.Trim()+"_" + ComboBox1.SelectedItem.Text + "_" + DateTime.Now.Year.ToString();
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            string strSQL = "Select * from "+TblName.Trim();

           

            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);

            DataSet ds = new DataSet();

            dt.Fill(ds, TblName.Trim());

            ds.WriteXml(@"C:\PPMExpress\XML\" + mName + ".xml");
          
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + TblName.Trim()+" "+ ex.Message.ToString() + "');</script>");
            return;
        }
    }



    protected void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      //  TextBox15.Text = ComboBox1.SelectedItem.Text +"/"+ DateTime.Now.Year.ToString(); 
    }

    protected void btnImportXml_Click(object sender, EventArgs e)
    {
        
        
        Response.Write("<script language=javascript>alert('Section Admin. Responsible ........');</script>");
        return;
    }




}