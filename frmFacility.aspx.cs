using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmFacility : System.Web.UI.Page
{

    void CLS()
    {
        DrpTechArea.ClearSelection();
        DrpState.ClearSelection();
        DrpLGA.ClearSelection();
        Drpfactype.ClearSelection();
        DrpFacname.ClearSelection();
        TextBox1.Text = "";
        DrpState.Focus();
    }

    void HideText()
    {
        TextBox3.Visible = false;
        TextBox4.Visible = false;
        TextBox5.Visible = false;
        TextBox6.Visible = false;
        TextBox7.Visible = false;
    }///===== End


    void FillstateDp()
    {
        try
        {
            string sqlstate = "Select distinct statename from tbl_state order by statename asc";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlstate, con);
            SqlDataReader r = cmd.ExecuteReader();
            DrpState.Items.Clear();
            DrpState.Items.Add("");
            drpstate2.Items.Clear();
            drpstate2.Items.Add("");
            while (r.Read())
            {
                DrpState.Items.Add(r["statename"].ToString());
                drpstate2.Items.Add(r["statename"].ToString());
            }
            
            DrpState.DataBind();
            drpstate2.DataBind();
            con.Close();
            r.Dispose();
           
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "  " + ex.Message.ToString().Trim();
        }
       

    }

   // ===============

    void Fillgrd()
    {
        try
        {
            string sql = "select * from tbl_facility order by facname asc";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter sqlad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            GridView1.DataSource=ds;
            GridView1.DataBind();
            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "  " + ex.Message.ToString().Trim();
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        lblerr.Visible = false;
        if (!IsPostBack)
        {
            FillstateDp();
            Fillgrd();
            HideText();
            ImageButton2.Visible = false;
            TabContainer1.ActiveTabIndex =0;
        }

    }
    protected void DrpState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string SQL, SQL1="";
            if (DrpState.SelectedItem.Text.Trim() == "Ebonyi")
            {
                SQL1 = "Abakaliki";
                SQL = "SELECT * from tbl_states where capitals ='" + SQL1  + "'";
            }
            else
            {
                SQL = "SELECT * from tbl_states where statename ='" + DrpState.SelectedItem.Text.Trim() + "'";
            }
            
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader R = cmd.ExecuteReader();
            DrpLGA.Items.Clear();
            DrpLGA.Items.Add("");
             
            while (R.Read())
            {
                DrpLGA.Items.Add(R["lga"].ToString());
            }

            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "  " + ex.Message.ToString().Trim();
        }
    }

    /// <summary>
    /// Module to store data into sql server
    /// </summary>
   

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL = "INSERT INTO tbl_facility (statename,lga,facname,faclevel,techarea) VALUES (@statename,@lga,@facname,@faclevel,@techarea)";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.Add("@statename", SqlDbType.NVarChar).Value = DrpState.SelectedItem.Text.Trim();
            cmd.Parameters.Add("@lga", SqlDbType.NVarChar).Value = DrpLGA.SelectedItem.Text.Trim();
            cmd.Parameters.Add("@facname", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.Parameters.Add("@faclevel", SqlDbType.NVarChar).Value = DrpFacname.SelectedItem.Text.Trim();
            cmd.Parameters.Add("@factype", SqlDbType.NVarChar).Value = Drpfactype.SelectedItem.Text.Trim();
            cmd.Parameters.Add("@techarea", SqlDbType.NVarChar).Value = DrpTechArea.SelectedItem.Text.Trim();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Fillgrd();
            CLS();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "  " + ex.Message.ToString().Trim();
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL = "Update tbl_facility set facname=@facname,statename=@statename,lga=@lga,faclevel=@faclevel," +
                         "factype=@factype,techarea=@techarea where facname=@facname";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL,con);
            cmd.Parameters.Add("@statename", SqlDbType.NVarChar).Value = DrpState.Text.Trim();
            cmd.Parameters.Add("@lga", SqlDbType.NVarChar).Value = DrpLGA.Text.Trim();
            cmd.Parameters.Add("@facname", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.Parameters.Add("@faclevel", SqlDbType.NVarChar).Value = DrpFacname.Text.Trim();
            cmd.Parameters.Add("@factype",SqlDbType.NVarChar).Value =Drpfactype.Text.Trim();
            cmd.Parameters.Add("@techarea",SqlDbType.NVarChar).Value=DrpTechArea.Text.Trim();
            cmd.ExecuteNonQuery();
            Fillgrd();
            HideText();
            CLS();
            ImageButton2.Visible = false;
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "  " + ex.Message.ToString().Trim();
        }
    }
   


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox1.Text.ToUpper().Trim();
        
    }
    protected void drpstate2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string SQL, SQL1 = "";
            if (drpstate2.SelectedItem.Text.Trim() == "Ebonyi")
            {
                SQL1 = "Abakaliki";
                SQL = "SELECT * from tbl_states where capitals ='" + SQL1 + "'";
            }
            else
            {
                SQL = "SELECT * from tbl_states where statename ='" + drpstate2.SelectedItem.Text.Trim() + "'";
            }

            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader R = cmd.ExecuteReader();
            drpLGA2.Items.Clear();
            drpLGA2.Items.Add("");

            while (R.Read())
            {
                drpLGA2.Items.Add(R["lga"].ToString());
            }

            cmd.Dispose();
            con.Close();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "  " + ex.Message.ToString().Trim();
        }
    }

    //==== textbox2
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = TextBox2.Text.ToUpper().Trim();
    }


   //===== Search Button
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL="";

            if (drpstate2.SelectedItem.Text.Trim() !="" && drpLGA2.SelectedItem.Text.Trim() !="")
            {
                SQL = " Select * from tbl_facility where statename='"+drpstate2.SelectedItem.Text.Trim()+"' and lga ='"+drpLGA2.SelectedItem.Text.Trim()+"'";

            }
            else if (drpstate2.SelectedItem.Text.Trim() !="" && drpLGA2.SelectedItem.Text.Trim() !="" && TextBox2.Text !="")
            {
                SQL = " Select * from tbl_facility where statename='"+drpstate2.SelectedItem.Text.Trim()+"' and lga ='"+drpLGA2.SelectedItem.Text.Trim()+"' and "+
                      "Facname ='"+TextBox2.Text.ToUpper()+"'";
            }
            else if (drpstate2.SelectedItem.Text.Trim() != "")
            {
                SQL = " Select * from tbl_facility where statename='" + drpstate2.SelectedItem.Text.Trim() + "'";

            }
            else
            {
                SQL = " Select * from tbl_facility where facname='" + TextBox2.Text.Trim() + "'";
            }

            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd= new SqlCommand(SQL,con);
            SqlDataAdapter AD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            AD.Fill(DS);
            GridView2.DataSource=DS;
            GridView2.DataBind();
        }
        catch (Exception ex)
        {
            lblerr2.Visible = true;
            lblerr2.Text = "  " + ex.Message.ToString().Trim();
            return;
        }
        
    }
  //==== End of Search Button
  
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
//======== End

   protected void EditMe(string SuppID)
    {
        if (SuppID == null)
        {
            return;
        }

        string KK = "Select * from tbl_facility Where num='" + Convert.ToString(SuppID) + "'";
        using (SqlConnection p = new SqlConnection(ConnectAll.ConnectMe()))
        {
            p.Open();
            SqlCommand Cmd = new SqlCommand(KK, p);
            
            try
            {
                //DataRow dr = ConnectAll.GetDataRow(KK); // ===== Get the datarow from a generic method in a classs
                SqlDataReader dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection );
                while (dr.Read())
                {
                    if (dr != null)
                    {
                        TextBox3.Visible = true;
                        TextBox4.Visible = true;
                        TextBox5.Visible = true;
                        TextBox6.Visible = true;
                        TextBox7.Visible = true;

                        //DrpState.Items.Clear();
                        //ListItem newItem = new ListItem();
                        //newItem.Text = dr["statename"].ToString();
                        //DrpState.Text = dr["statename"].ToString();

                        TextBox3.Text = dr["statename"].ToString();
                        TextBox4.Text = dr["lga"].ToString();
                        TextBox1.Text = dr["facname"].ToString();
                        TextBox5.Text = dr["faclevel"].ToString();
                        TextBox6.Text = dr["factype"].ToString();
                        TextBox7.Text = dr["techarea"].ToString();
                    }
                }

                    ImageButton2.Visible = true;
                TabContainer1.ActiveTabIndex = 0;
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

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string SQL = "Delete tbl_facility where facname=@facname";
            SqlConnection con = new SqlConnection(ConnectAll.ConnectMe());
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.Add("@statename", SqlDbType.NVarChar).Value = DrpState.Text.Trim();
            cmd.Parameters.Add("@lga", SqlDbType.NVarChar).Value = DrpLGA.Text.Trim();
            cmd.Parameters.Add("@facname", SqlDbType.NVarChar).Value = TextBox1.Text.Trim();
            cmd.Parameters.Add("@faclevel", SqlDbType.NVarChar).Value = DrpFacname.Text.Trim();
            cmd.Parameters.Add("@factype", SqlDbType.NVarChar).Value = Drpfactype.Text.Trim();
            cmd.Parameters.Add("@techarea", SqlDbType.NVarChar).Value = DrpTechArea.Text.Trim();
            cmd.ExecuteNonQuery();
            Fillgrd();
            HideText();
            CLS();
        }
        catch (Exception ex)
        {
            lblerr.Visible = true;
            lblerr.Text = "Error :" + ex.Message;
            return;
        }
    }

    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        Fillgrd();
    }
}