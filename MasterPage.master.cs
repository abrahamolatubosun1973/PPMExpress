using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{


    string mState = string.Empty;
    string mLGA = string.Empty;
    string mFacility = string.Empty;
    string mMnth = string.Empty;
    string mYr = string.Empty;
    string mChoose = string.Empty;


    protected void Yrs()
    {
        int YrNo = 2020; //Convert.ToInt32(string.Format("{0}",DateTime.Now.AddYears(3)));
        //drpYrs.ClearSelection();
        
        drpYrs.Items.Clear();
        drpYrs.Items.Add("");
        for (int i = 2000; i <= YrNo; i++)
        {
            drpYrs.Items.Add(i.ToString());
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

    protected void FillThematic()
    {
        string SQl = "Select * from tbl_grpname order by abrv asc";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(SQl, cn);
        SqlDataReader r = cmd.ExecuteReader();
        try
        {
            drpThematic.ClearSelection();
            drpThematic.Items.Clear();
            drpThematic.Items.Add("");
            while (r.Read()) { drpThematic.Items.Add(r["fname"].ToString()); }

        }
        catch (Exception e)
        {
            Response.Write("<script language=javascript>alert('" + e.Message.ToString() + "' );</script>");
            return;
        }
    }

    private void LoadMonths()
    {
        try
        {
            string[] monthNames = (new System.Globalization.CultureInfo("en-US")).DateTimeFormat.MonthNames;
            foreach (string m in monthNames) // writing out
            {
                drpMnth.Items.Add(m);
                //  drpMonth1.Items.Add(m);
            }
            drpMnth.Items.Insert(0, "Select");
            drpMnth.SelectedIndex = 0;
            //drpMonth1.Items.Insert(0, "Select");
            //drpMonth1.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            webMessage.Show("Error :" + ex.Message.ToString());
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
       

        if(!IsPostBack )
        {
            Yrs();
            FillState();
            FillThematic();
            LoadMonths();

            if (!string.IsNullOrEmpty(Session["mChoose"] as string))
            {
                //mChoose = Session["mChoose"].ToString();
                //mState = Session["mState"].ToString();
                //mLGA = Session["mLGA"].ToString();
                //mFacility = Session["mFacility"].ToString();
                //mMnth = Session["mMnth"].ToString();
                //mYr = Session["mYr"].ToString();

            }
        }
    }
    protected void drpStates_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
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
            drpFacility.Items.Clear();
            drpFacility.Items.Add("");
            string sql = "Select * from tbl_facility where statename ='" + drpStates.SelectedItem.Text.Trim() + "' and lga ='" + drpLGA.SelectedItem.Text.Trim() + "' order by facname asc";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                drpFacility.Items.Add(r["facname"].ToString());
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
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
            Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "' );</script>");
            return;
        }

    }


    protected void drpThematic_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Thematic Area for selection
        if (drpStates.SelectedItem.Text.Trim() != string.Empty && drpLGA.SelectedItem.Text.Trim() != string.Empty && drpFacility.SelectedItem.Text.Trim() != string.Empty
            && drpMnth.SelectedItem.Text.Trim() != string.Empty && drpYrs.SelectedItem.Text.Trim() != string.Empty && drpThematic.SelectedItem.Text.Trim() != string.Empty)
        {
            string mFile1 = drpThematic.SelectedItem.Text.Trim();
            // Console.WriteLine("Hello \n");
            string mFile = string.Empty;
           // MultiView1.Visible = true;

            GetThematic(mFile1, out mFile);

            //Session["mChoose"] = mFile;
            //Session["mState"] = drpStates.SelectedItem.Text.Trim();
            //Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
            //Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
            //Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
            //Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

           
            if (mFile == "CARE")
            {
               // TextBox608.Text = mFile;
                //drpThematic.ClearSelection();
                //lblmsg.Visible = false;
                //lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();

                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility  = drpFacility.SelectedItem.Text.Trim();
                mMnth  = drpMnth.SelectedItem.Text.Trim();
                mYr  = drpYrs.SelectedItem.Text.Trim();

                //Label lblThematic = Page.FindControlRecursive("lblThematic") as Label;
                
                //lblThematic.Text = " " + drpStates.SelectedItem.Text + "/" + drpLGA.SelectedItem.Text + "/" + drpFacility.SelectedItem.Text + "/" + drpMnth.SelectedItem.Text + "/" + drpYrs.SelectedItem.Text;
               
                Response.Redirect(string.Format("dataentryform2.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose,mState,mLGA,mFacility,mMnth,mYr));

               
                // MultiView1.SetActiveView(View1);

                //SAVE_PMTCT();
            }
            if (mFile == "ART")
            {

               // TextBox608.Text = mFile;
                //drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();

                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform2.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mFile, mState, mLGA, mFacility, mMnth, mYr));
              //  MultiView1.SetActiveView(View2);

                // SAVE_HIVI();
            }
            if (mFile == "HTC")
            {

               // TextBox608.Text = mFile;
                //drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();

                //Session["mChoose"] = mFile;
                //Session["mState"] = drpStates.SelectedItem.Text.Trim();
                //Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                //Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                //Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                //Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();
                mChoose = mFile;

                Response.Redirect(string.Format("dataentryform2.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr));
               // MultiView1.SetActiveView(View3);

                // SAVE_TRAINING();
            }
            if (mFile == "GEND NORM")
            {

                //TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View4);

                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();
                Session["mChoose"] = mFile;

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentries.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr));

            }
            if (mFile == "LAB")
            {

               // TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                //MultiView1.SetActiveView(View5);
               // TextBox670.Focus();

                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform3.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr));
            }
            if (mFile == "OVC")
            {

                //TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                //MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                     mChoose, mState, mLGA, mFacility, mMnth, mYr));
                
            }
            if (mFile == "FN")
            {

               // TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr)); 
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
            if (mFile == "PP")
            {

               // TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr)); 
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
            if (mFile == "PEP")
            {

                //TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr));  
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
            if (mFile == "TB")
            {

                //TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentryform3.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr));  
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
            if (mFile == "PMTCT")
            {

               // TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] =  mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentries.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr)); 
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
            if (mFile == "HIVI")
            {

               // TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentries.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr));  
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
            if (mFile == "TRAINING")
            {

               // TextBox608.Text = mFile;
                // drpThematic.ClearSelection();
                lblmsg.Visible = false;
                lblmsg.Text = string.Empty;
                //drpStates.Style.Clear();
                //drpLGA.Style.Clear();
                //drpFacility.Style.Clear();
                //drpMnth.Style.Clear();
                //drpYrs.Style.Clear();
                //drpThematic.Style.Clear();
                // MultiView1.SetActiveView(View5);
                Session["mChoose"] = mFile;
                Session["mState"] = drpStates.SelectedItem.Text.Trim();
                Session["mLga"] = drpLGA.SelectedItem.Text.Trim();
                Session["mFacility"] = drpFacility.SelectedItem.Text.Trim();
                Session["mMnth"] = drpMnth.SelectedItem.Text.Trim();
                Session["mYr"] = drpYrs.SelectedItem.Text.Trim();

                mChoose = mFile;
                mState = drpStates.SelectedItem.Text.Trim();
                mLGA = drpLGA.SelectedItem.Text.Trim();
                mFacility = drpFacility.SelectedItem.Text.Trim();
                mMnth = drpMnth.SelectedItem.Text.Trim();
                mYr = drpYrs.SelectedItem.Text.Trim();

                Response.Redirect(string.Format("dataentries.aspx?mChoose={0}&mState={1}&mLGA={2}&mFacility={3}&mMnth={4}&mYr={5}",
                    mChoose, mState, mLGA, mFacility, mMnth, mYr)); 
                //?state=" +mState+"&lga="+mLga+"&facility="+mFacility+"&mMnth="+mMnth+"&mYear="+mYear+"&mFile="+mFile  );

            }
        }
        else
        {
            drpStates.Style.Value = "background-color:red;";
            drpLGA.Style.Value = "background-color:red;";
            drpFacility.Style.Value = "background-color:red;";
            drpMnth.Style.Value = "background-color:red;";
            drpYrs.Style.Value = "background-color:red;";
            drpThematic.Style.Value = "background-color:red;";
            drpThematic.ClearSelection();
            lblmsg.Visible = true;
            string txt = "Value required in the red section ";
            ConnectAll.Show(txt);
        }
    }

}// *********************** Master end here **********************
