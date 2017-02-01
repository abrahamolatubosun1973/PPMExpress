using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;

public partial class TestCss : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack )
        {

        }

    }

   void Pull_label()
    {
        var lbl = new Label() ;
        var txb = new TextBox();
        int cnt = 3;
        StringBuilder sb = new StringBuilder();
        for (int x = 1; x <= cnt; x++)
        {
            lbl = (Label)this.FindControl("Label" + Convert.ToString(x));
            txb = (TextBox)this.FindControl("Textbox" + Convert.ToString(x));

          
            sb.Append(lbl.Text);
            sb.Append(txb.Text);
           
        }
        Response.Write(sb);
        //Trace.Write(sb);
        //Console.Write(sb);
       // Label4.Text = sb;
    }
   protected void Button1_Click(object sender, EventArgs e)
   {
       Pull_label();
   }

   //public int sumb(int a, int b)
   //{
   //    int c = a + b;
   //}

   protected void Button2_Click(object sender, EventArgs e)
   {
       int num1 = Convert.ToInt32( TextBox4.Text);
       int num2 = Convert.ToInt32( TextBox5.Text);
       //int put = sumb(int num1,int num2);
   }

   protected void Button3_Click(object sender, EventArgs e)
   {
       SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
     
       DataSet reportData = new DataSet();
       string filenames = FileUpload1.FileName.ToString();

       //Server.MapPath(string.Format("~/{0}/", "XML"))
       string Filename = Server.MapPath(string.Format("~/{0}/", "XML")+filenames);
      
       reportData.ReadXml(Filename);
       con.Open();

     DataTable dt2 = new DataTable();
       foreach (DataTable dt in reportData.Tables)
       {
           SqlBulkCopy sbc = new SqlBulkCopy(con);
    
           sbc.DestinationTableName = "tbl_ART";
           foreach(DataColumn dc in dt.Columns)
           {
               sbc.ColumnMappings.Add(dc.ColumnName, dc.ColumnName);
               
           }// Second Foreach
           //dt2 = dt.DefaultView.ToTable(true);
           //sbc.WriteToServer(dt.DefaultView.ToTable(true));
          dt2 =  RemoveDuplicatesRecords(dt);
          sbc.WriteToServer(dt2);
       }// First Foreach
       con.Close();
       
   }

   private DataTable RemoveDuplicatesRecords(DataTable dt)
   {
       //Returns just 5 unique rows
       var UniqueRows = dt.AsEnumerable().Distinct(DataRowComparer.Default);
       DataTable dt2 = UniqueRows.CopyToDataTable();
       return dt2;
   }

   protected void btnExport_Click(object sender, EventArgs e)
   {

   }
}