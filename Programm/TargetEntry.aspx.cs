using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Programm_TargetEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillState();
            LoadData();
            LoadMonths();
            Yrs();
        }
    }

    protected void FillState()
    {
        string SQl = "Select Distinct statename from tbl_States order by statename asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpStates.ClearSelection();
            drpStates.Items.Clear();
            drpStates.Items.Add("");
            while (r.Read()) { drpStates.Items.Add(r["statename"].ToString()); }

        }
        catch (Exception e)
        {
            Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
            return;
        }
    }

    private void LoadData()
    {
        string SQl = "Select * from tbl_grpname order by abrv asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpProgram.ClearSelection();
            drpProgram.Items.Clear();
            drpProgram.Items.Add("");
            while (r.Read()) { drpProgram.Items.Add(r["fname"].ToString()); }

        }
        catch (Exception e)
        {
            webMessage.Show("Error :"+ e.Message.ToString() );
            return;
        }
    }

    protected void Yrs()
    {
        int YrNo = 2020; //Convert.ToInt32(string.Format("{0}",DateTime.Now.AddYears(3)));
        //drpYrs.ClearSelection();

        drpYear.Items.Clear();
        drpYear.Items.Add("");
        for (int i = 2000; i <= YrNo; i++)
        {
            drpYear.Items.Add(i.ToString());
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
                //  drpMonth1.Items.Add(m);
            }
            drpMonth.Items.Insert(0, "Select");
            drpMonth.SelectedIndex = 0;
            //drpMonth1.Items.Insert(0, "Select");
            //drpMonth1.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message.ToString());
        }
    }

    protected void drpProgram_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string mFile1 = drpProgram.SelectedItem.Text.Trim();
            string mFile = string.Empty;

            GetThematic(mFile1, out mFile);

            string SQL = "SELECT * from tbl_TargetDefine where grouptype ='" + mFile + "'";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(SQL, cn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message.ToString()) ;
            return;
        }
        
    }

    private void GetThematic(string thematicname, out string fname)
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
           webMessage.Show("Error :" + ex.Message.ToString());
            return;
        }

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        drpMonth.ClearSelection();
            drpProgram.ClearSelection();
            drpYear.ClearSelection();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                TextBox Tx = (TextBox)row.FindControl("txtTarget");
                if (Tx.Text != string.Empty)
                {
                    string mCode, mGroup, mDescrip,mMonth,mYear;
                   // Button btn = sender as Button;
                   // GridViewRow row = btn.NamingContainer as GridViewRow;
                   // string pk = GridView1.DataKeys[row.RowIndex].Values["Id"].ToString();
                    mMonth = drpMonth.SelectedItem.Text.Trim();
                    mYear = drpYear.SelectedItem.Text.Trim();
                    TextBox ss = GridView1.Rows[row.RowIndex].Cells[3].FindControl("txtTarget") as TextBox;
                    mCode = GridView1.Rows[row.RowIndex].Cells[0].Text;
                    mGroup = GridView1.Rows[row.RowIndex].Cells[1].Text;
                    mDescrip = GridView1.Rows[row.RowIndex].Cells[2].Text;

                    string SQL = "INSERT INTO tbl_TargetAssin (grouptype,code,description,myears,months,targetvalue,facname)";
                    SQL += " VALUES (@grouptype,@code,@description,@myears,@months,@targetvalue,@facname)";
                    SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(SQL, cn);
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mGroup.Trim();
                    cmd.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = mCode.Trim();
                    cmd.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = mDescrip.Trim();
                    cmd.Parameters.AddWithValue("@myears", SqlDbType.NVarChar).Value = mYear.Trim();
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMonth.Trim();
                    cmd.Parameters.AddWithValue("@targetvalue", SqlDbType.Int).Value = Convert.ToInt32(ss.Text.Trim());
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = drpFacname.SelectedItem.Text.Trim();
                    cmd.ExecuteNonQuery();
                    
                }
            }
            webMessage.Show("Records saved sucessfully");
        }
        catch (Exception ex)
        {
            webMessage.Show("Error Saving Record :" + ex.Message.ToString());
            return;
        }
    }


    protected void drpStates_SelectedIndexChanged(object sender, EventArgs e)
    {
        string SQL, SQL1 = "";
        if (drpStates.SelectedItem.Text.Trim() == "Ebonyi")
        {
            SQL1 = "Abakaliki";
            SQL = "SELECT * from tbl_states where capitals ='" + SQL1 + "' order by lga asc";
        }
        else
        {
            SQL = "SELECT * from tbl_states where statename ='" + drpStates.SelectedItem.Text.Trim() + "' order by lga asc";
        }
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQL, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpLGA.ClearSelection();
            drpLGA.Items.Clear();
            drpLGA.Items.Add("");
            while (r.Read()) { drpLGA.Items.Add(r["lga"].ToString()); }

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }
    }
    protected void drpLGA_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            drpFacname.Items.Clear();
            drpFacname.Items.Add("");
            string sql = "Select * from tbl_facility where statename ='" + drpStates.SelectedItem.Text.Trim() + "' and lga ='" + drpLGA.SelectedItem.Text.Trim() + "' order by facname asc";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                drpFacname.Items.Add(r["facname"].ToString());
            }
        }
        catch (Exception ex)
        {
            webMessage.Show("Error : " + ex.Message.ToString());
            return;
        }
    }
}