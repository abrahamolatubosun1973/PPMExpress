using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer;

public partial class Groups_frmDataElement : System.Web.UI.Page
{

    private void LoadFac()
    {
        try
        {
            
            string SQL = " Select distinct * from tbl_facility order by facname asc";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DropDownList1.ClearSelection();
            DropDownList1.Items.Add("");
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr["facname"].ToString());

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
        }catch(Exception e)
        {
            lblerr.Text = "Error : " + e.Message.ToString();
            return;
        }
    }//===== End 

    protected void LoadGrd()
    {
        string SQL = "SELECT * FROM tbl_DataElems";
        SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
        con.Open();
        SqlCommand cmd = new SqlCommand(SQL, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
       DataSet ds = new DataSet();
       da.Fill(ds);
       GridView1.DataSource = ds;
       GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        TabContainer1.ActiveTabIndex = 0;
            LoadFac();
            LoadGrd();
            ImageButton2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //int x = 5;
        //while (0 <= (x - 1))
        //{
        //    Label myLabel = new Label();
        //    myLabel.ID = "myLabel_" + x;
        //    myLabel.Text = "Label No. " + x;
        //    PlaceHolder1.Controls.Add(myLabel);
        //    x += x;
        //}
    }
    //protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    //{
    //    GridView1.PageIndex = e.NewSelectedIndex;
    //    LoadGrd();
    //}
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        LoadGrd();
    }
}