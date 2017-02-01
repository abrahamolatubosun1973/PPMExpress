using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmState : System.Web.UI.Page
{
    private void FillGrd()
    {
        using (SqlConnection Sqlcon = new SqlConnection(ConnectAll.ConnectMe()))
        {
            string strSelQuery = "SELECT distinct [statename],[lga] FROM tbl_states order by statename asc";
            using (SqlCommand cmd = new SqlCommand())
            {
                Sqlcon.Open();
                cmd.Connection = Sqlcon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSelQuery;
                SqlDataAdapter SqlAda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                SqlAda.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }

    //============

    protected void Page_Load(object sender, EventArgs e)
    {
        LblErr.Visible = false;
        if (!IsPostBack)
        {
            FillGrd();
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string SQL = "INSERT INTO tbl_states (statename,lga) Values (@statename,@lga)";
        try
        {
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@statename", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = TextBox2.Text.Trim();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            LblErr.Visible = true;
            LblErr.Text = "Document not saved......." + ex.Message.ToString().Trim();
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string sql = "DELETE tbl_States where statename ='" + TextBox1.Text.Trim() + "'";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            LblErr.Visible = true;
            LblErr.Text = "Can not Erase this document.....: " + ex.Message.ToString().Trim();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        FillGrd();
    }
}