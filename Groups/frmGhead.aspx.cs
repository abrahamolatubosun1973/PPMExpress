using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Groups_Ghead : System.Web.UI.Page
{

    protected void CLS()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox1.Focus();
    }

    protected void CLS2()
    {
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox3.Focus();
    }

    protected void Loadgrd()
    {
        try
        {
            string SQL = "Select * from tbl_grpname order by fname asc";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter AD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            GridView1.DataSource = DS;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error " + ex.Message.ToString().Trim();
            return;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            Loadgrd();
            ImageButton2.Visible = false;
            TabContainer1.ActiveTabIndex = 0;
            lblerr.Visible = false;
        }

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL = "INSERT INTO tbl_grpname (fname,fid) VALUES(@fname,@fid)";

            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@fid", SqlDbType.NVarChar).Value = TextBox2.Text.Trim();
            cmd.ExecuteNonQuery();
            CLS();
            Loadgrd();
            
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error " + ex.Message.ToString().Trim();
            return;
        }
    }
    ///========

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        string SQL="";
        try
        {

            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                SQL = "Delete tbl_grpname where fname ='" + TextBox1.Text.Trim() + "' and fid='" + TextBox2.Text.Trim() + "'";
            }
            else if (TextBox2.Text != "")
            {
                SQL = "Delete tbl_grpname where fid ='" + TextBox2.Text.Trim() + "'";
            }
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@fid", SqlDbType.NVarChar).Value = TextBox2.Text.Trim();
            cmd.ExecuteNonQuery();
            con.Close();
            Loadgrd();
            CLS();
            ImageButton2.Visible = false;
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error " + ex.Message.ToString().Trim();
            return;
        }
     
    }


    //=======
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        string SQL = "";
        try
        {
            if (TextBox3.Text != "" && TextBox4.Text != "")
            {
                SQL = "Select * from tbl_grpname where fname ='" + TextBox3.Text.Trim() + "' and fid='"+TextBox4.Text.Trim()+"'";
            }
            else if (TextBox4.Text != "")
            {
                SQL = "Select * from tbl_grpname where fid ='" + TextBox4.Text.Trim() + "'";
            }else 
            {
                SQL = "Select * from tbl_grpname where fname ='" + TextBox3.Text.Trim() + "'";
            }

                SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
                con.Open();
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataAdapter AD = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                AD.Fill(DS);
                GridView2.DataSource = DS;
                GridView2.DataBind();
                con.Close();
                cmd.Dispose();

        }
        catch (Exception ex)
        {
            lblerr2.Visible = true;
            lblerr2.Text = "Error " + ex.Message.Trim();
            return;
        }

    }
    //



    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        Loadgrd();
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            dynamic SS = null;
            if (e.CommandName == "Page" || e.CommandName == "Sort")
                return;
            int index = Convert.ToInt32(e.CommandArgument);
            DataKey dkKeys = GridView2.DataKeys[index];
            string sKeysArg = "";
            foreach (string s in dkKeys.Values.Keys)
            {
                SS = Convert.ToString(dkKeys[s]);
                //sKeysArg += s + "=" + Convert.ToString(dkKeys(s)) '+ "&"
            }
            //sKeysArg 
            if (SS == string.Empty)
            {
                return;
            }
            //Dim PP = SS
            if (e.CommandName == "SelectCMD")
            {
                EditMe(SS);
            }

        }
        catch (Exception ex)
        {
            lblerr2.Visible = true;
            lblerr2.Text = "  " + ex.Message.ToString().Trim();
            return;
        }
    }

    protected void EditMe(string SuppID)
    {
        if (SuppID == null)
        {
            return;
        }
        Session["fname"] = null;

        string KK = "Select * from tbl_grpname Where num='" + Convert.ToString(SuppID) + "'";
        using (SqlConnection p = new SqlConnection(ConnectAll.ConnectMe()))
        {
            p.Open();
            SqlCommand Cmd = new SqlCommand(KK, p);

            try
            {
                DataRow dr = ConnectAll.GetDataRow(KK); // ===== Get the datarow from a generic method in a classs
                if (dr != null)
                {
                    TextBox1.Text = dr["fname"].ToString();
                    TextBox2.Text = dr["fid"].ToString();

                    Session["fname"] = dr["fname"].ToString();
                    CLS2();
                }
                ImageButton2.Visible = true;
                TabContainer1.ActiveTabIndex = 0;
                GridView2.DataSource = null;
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                lblerr2.Visible = true;
                lblerr2.Text = "Error :" + ex.Message;
                return;
            }
            finally
            {
                p.Close();
                Cmd.Dispose();
                //MultiView1.ActiveViewIndex = 0
            }
        }
    }//=== End of EditMe() Method


    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string PO = Session["fname"].ToString().Trim();

        string SQL = "Update tbl_grpname set fid=@fid,fname=@fname where fname='" + PO + "'";
        try
        {
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@fid", SqlDbType.NVarChar).Value = TextBox2.Text.Trim();
            cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.ExecuteNonQuery();
            CLS();
            Loadgrd();
            con.Close();
            cmd.Dispose();
            PO = null;
        }
        catch (Exception ex)
        {
            lblerr2.Visible = true;
            lblerr2.Text = "Error :" + ex.Message;
            return;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Loadgrd();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text.ToUpper();
        TextBox2.Focus();
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = TextBox2.Text.ToUpper();
        ImageButton1.Focus();
    }
}