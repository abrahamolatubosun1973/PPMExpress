using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections;
using System.IO.Compression; 

public partial class DataKeyIndicator : System.Web.UI.Page
{
    private static string CHECKED_ITEMS = "CheckedItems";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillThematic();
        }

    }

    protected void FillThematic()
    {
        string SQl = "Select * from tbl_grpname order by abrv asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpProgramArea.ClearSelection();
            drpProgramArea.Items.Clear();
            drpProgramArea.Items.Add("");
            while (r.Read()) { drpProgramArea.Items.Add(r["fname"].ToString()); }

        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message);
            return;
        }
    }


    protected void LoaDGrid()
    {
        try
        {
                string mFile1 = drpProgramArea.SelectedItem.Text.Trim();
                string mFile = string.Empty;
                DataTable dt = new DataTable();

                GetThematic(mFile1, out mFile);

                string SQL = " SELECT * FROM tbl_defn where grouptype ='" + mFile.Trim() + "'";
                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                cn.Open();
                SqlCommand cmd = new SqlCommand(SQL, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
               
                GridView1.DataSource = dt;
                GridView1.DataBind();
                
        }
        catch (Exception ex)
        {
            webMessage.Show("ERROR :" + ex.Message);
            return;
        }
    }

    protected void drpProgramArea_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoaDGrid();
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
           webMessage.Show("Error :" +ex.Message);
            return;
        }

    }

    

    private void TableCreate()
    {
        try
        {
            Object I;
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            SqlCommand cmd;
            if (FindTable.ProgramTable("tbl_TargetDefine") == 1)
            {
                return;
            }
            else
            {
                string sqlCreate1 = "CREATE TABLE tbl_TargetDefine ( ID int IDENTITY(1,1) NOT NULL,";
                sqlCreate1 += "Grouptype Nvarchar(50) Null, Code Nvarchar(50) Null, Description Nvarchar(2000) Null)ON [PRIMARY] ";
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand(sqlCreate1, cn);
                I = cmd.ExecuteScalar();
                cmd.Dispose();
                cn.Close();
            }
            if (FindTable.ProgramTable("tbl_TargetAssin") == 1)
            {
                return;
            }
            else
            {
                string sqlCreate2 = "CREATE TABLE tbl_TargetAssin ( ID int IDENTITY(1,1) NOT NULL,";
                sqlCreate2 += "Grouptype Nvarchar(50) Null, Code Nvarchar(50) Null, Description Nvarchar(2000) Null,";
                sqlCreate2 +="mYears nvarchar(20) Null, Months Nvarchar(20) Null, TargetValue Int)ON [PRIMARY] ";

                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd = new SqlCommand(sqlCreate2, cn);
                I = cmd.ExecuteScalar();
                cmd.Dispose();
                cn.Close();
            }
        }catch(Exception ex)
        {
            webMessage.Show("Error Creating Report Table :" + ex.Message);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //==== Create SQL Table for storage
            TableCreate();

            foreach (GridViewRow row in GridView1.Rows)
            {
                //===== Accessing the checkbox
                CheckBox cb = (CheckBox)row.FindControl("ChkSelect");
                
                if (cb!= null && cb.Checked )
                {
                    int ID = Convert.ToInt32(GridView1.DataKeys[row.RowIndex].Value);
                    
                    //== Search for the records and store in datatbase
                    string SQLP = "SELECT * FROM tbl_defn where ID ='" + Convert.ToString(ID)+"'";
                    SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                    cn.Open();
                    SqlCommand cmd1 = new SqlCommand(SQLP, cn);
                    SqlDataReader r = cmd1.ExecuteReader();
                    while (r.Read())
                    {
                        string SQL = "INSERT INTO tbl_TargetDefine (grouptype,code,description) VALUES(@grouptype,@code,@description)";
                        if (cn.State == ConnectionState.Closed)
                            cn.Open();
                        SqlCommand cmd = new SqlCommand(SQL, cn);
                        cmd.Parameters.AddWithValue("@code", SqlDbType.NVarChar).Value = r["code"].ToString();
                        cmd.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = r["description"].ToString();
                        cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = r["grouptype"].ToString();
                        cmd.ExecuteReader();
                    }
                }
            }

        }
        catch (Exception ex)
        {
            webMessage.Show("ERROR :"+ex.Message.ToString());
            return;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        drpProgramArea.ClearSelection();
        GridView1.DataSource = "";
    }



    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        RememberOldValues();
        GridView1.PageIndex = e.NewPageIndex;
        LoaDGrid();
        RePopulateValues();
    }

    private void RePopulateValues()
    {
        ArrayList categoryIDList = (ArrayList)Session[CHECKED_ITEMS];

        if ((categoryIDList != null) && categoryIDList.Count > 0)
        {
            // use if not variable is Nothing .....Avoid < > operator any where 
            foreach (GridViewRow row in GridView1.Rows)
            {
                int index = (int)GridView1.DataKeys[row.RowIndex].Value;

                if (categoryIDList.Contains(index))
                {
                    CheckBox myCheckBox = (CheckBox)row.FindControl("ChkSelect");
                    myCheckBox.Checked = true;
                }
            }
        }

    }


    private void RememberOldValues()
    {
        ArrayList categoryIDList = new ArrayList();
        int index = -1;
        foreach (GridViewRow row in GridView1.Rows)
        {
            index = (int)GridView1.DataKeys[row.RowIndex].Value;

            bool result = ((CheckBox)row.FindControl("ChkSelect")).Checked;

            // Check in the Session 
            if ((Session[CHECKED_ITEMS] != null))
            {
                categoryIDList = (ArrayList)Session[CHECKED_ITEMS];
            }

            if (result)
            {
                if (!categoryIDList.Contains(index))
                {
                    categoryIDList.Add(index);
                }
            }
            else
            {
                categoryIDList.Remove(index);

            }
        }

        if ((categoryIDList != null) && categoryIDList.Count > 0)
        {
            Session[CHECKED_ITEMS] = categoryIDList;
        }
    }





}