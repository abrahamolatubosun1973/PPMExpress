using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Groups_frmSubgroup : System.Web.UI.Page
{

    protected void LoadDrp()
    {
        try
        {
            string SQL="Select * from tbl_grpname order by fname asc";

            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = cmd.ExecuteReader();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("");
            while (r.Read())
            {
                DropDownList1.Items.Add(r["fname"].ToString());
            }

            r.Dispose();
            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error :" + ex.Message.Trim();
            return;
        }

    }

    protected void Loadgrd()
    {
        try
        {
            string SQL = " Select * from tbl_subname order by subname asc";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter AD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            GridView1.DataSource = DS;
            GridView1.DataBind();
            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error :" + ex.Message.Trim();
            return;
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TabContainer1.ActiveTabIndex = 0;
            LoadDrp();
            Loadgrd();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string SQL = "Select * from tbl_grpname where fname='" + DropDownList1.SelectedItem.Text.Trim() + "'";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                lblAbrv.Visible = true;
                lblAbrv.Text = r["fid"].ToString();
            }
            cmd.Dispose();
            con.Close();

        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error :" + ex.Message.Trim();
            return;
        }
    }


    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

        //Dim pos As Integer
        //Dim staffname As String = EmployeeListBox.SelectedItem.Text.ToString.Trim
        //'lblStaffName.Text = staffname.ToString.Trim
        //pos = staffname.IndexOf("-")

        //Dim mAcctno As String = Mid(staffname, 1, pos - 1)
        //txtAcctno.Text = mAcctno.ToString.Trim


        Int32  GG = TextBox6.Text.IndexOf(" ");
        TextBox6.Text = TextBox6.Text.Trim().ToUpper();
        TextBox7.Text = TextBox6.Text.Substring(0, 3);
        TextBox8.Text = lblAbrv.Text + "/" + TextBox7.Text;
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }

    protected void CLS()
    {
        DropDownList1.ClearSelection();
        lblAbrv.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
    }

    protected void SaveAll()
    {
        string SQL = "INSERT INTO tbl_subname (fname,fid,subname,subid,code)" +
                     " Values (@fname,@fid,@subname,@subid,@code)";
        try
        {
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = DropDownList1.SelectedItem.Text.Trim();
            cmd.Parameters.AddWithValue("@fid", SqlDbType.NVarChar).Value = lblAbrv.Text.Trim();
            cmd.Parameters.AddWithValue("@subname", SqlDbType.NVarChar).Value = TextBox6.Text.Trim();
            cmd.Parameters.AddWithValue("@subid", SqlDbType.NVarChar).Value = TextBox7.Text.Trim();
            cmd.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = TextBox8.Text.Trim();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            CLS();
            Loadgrd();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error :" + ex.Message.Trim();
            return;
        }
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        SaveAll();
        Loadgrd();
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        ///----- DEL
        CLS();
    }




    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL = "DELETE tbl_subname where code='" + TextBox8.Text.Trim() + "'";
            //ConnectAll.My_SQL(SQL);
            CLS();
            Loadgrd();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error :" + ex.Message.Trim();
            return;
        }
    }
  
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL = "";
            if (TextBox9.Text != "" && TextBox10.Text != "")
            {
                SQL = "Select * from tbl_subname where subname='"+TextBox9.Text.Trim()+"' and subid ='"+TextBox10.Text.Trim()+"'";
            }
            else if (TextBox10.Text != "")
            {
                SQL = "Select * from tbl_subname where subid ='" + TextBox10.Text.Trim() + "'";
            }

            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter AD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            AD.Fill(DS);

            GridView2.DataSource = DS;
            GridView2.DataBind();

            TextBox9.Text = "";
            TextBox10.Text = "";

        }
        catch (Exception ex)
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Error :" + ex.Message.Trim();
            return;
        }
    }

    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {
        TextBox9.Text = TextBox9.Text.ToUpper().Trim();
    }

    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {
        TextBox10.Text = TextBox10.Text.ToUpper().Trim();
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
    }

    protected void CLS2()
    {
        TextBox10.Text = "";
        TextBox9.Text = "";
        TextBox9.Focus();
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
            lblmsg.Visible = true;
            lblmsg.Text = "  " + ex.Message.ToString().Trim();
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

        string KK = "Select * from tbl_subname Where num='" + Convert.ToString(SuppID) + "'";
        using (SqlConnection p = new SqlConnection(ConnectAll.ConnectMe()))
        {
            p.Open();
            SqlCommand Cmd = new SqlCommand(KK, p);

            try
            {
                DataRow dr = ConnectAll.GetDataRow(KK); // ===== Get the datarow from a generic method in a classs
                if (dr != null)
                {
                    DropDownList1.Text = dr["fname"].ToString();
                    lblAbrv.Text= dr["fid"].ToString();
                    TextBox6.Text = dr["subname"].ToString();
                    TextBox7.Text = dr["subid"].ToString();
                    TextBox8.Text = dr["code"].ToString();


                    Session["fname"] = dr["fname"].ToString();
                    CLS2();
                }
                ImageButton6.Visible = true;
                ImageButton8.Visible = true;
                TabContainer1.ActiveTabIndex = 0;
                GridView2.DataSource = null;
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                lblmsg.Visible = true;
                lblmsg.Text = "  " + ex.Message.ToString().Trim();
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



}