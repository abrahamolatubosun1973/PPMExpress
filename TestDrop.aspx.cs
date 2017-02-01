using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.DataVisualization.Charting;


public partial class TestDrop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            BindEnumToListControls(typeof(SeriesChartType), DropDownList1 );
            GetChartData();
            GetChartTypes();
        }
    }

   
    public void BindEnumToListControls(Type enumType, ListControl listcontrol)
    {
        string[] names = Enum.GetNames(enumType);
        listcontrol.DataSource = names.Select((key, value) =>
                                    new { key, value }).ToDictionary(x => x.key, x => x.value + 1);
        listcontrol.DataTextField = "Key";
        listcontrol.DataValueField = "Value";
        listcontrol.DataBind();
    }

    #region =========== Not part of Chart ============
    static int myCount = 0;
    private TextBox[] dynamicTextBoxes;
    
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Control myControl = GetPostBackControl(this.Page);

        if ((myControl != null))
        {
            if ((myControl.ClientID.ToString() == "btnAddTextBox"))
            {
                myCount = myCount + 1;
            }
        }
    }

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        dynamicTextBoxes = new TextBox[myCount];
        int i;
        for (i = 0; i < myCount; i += 1)
        {
            TextBox textBox = new TextBox();
            textBox.ID = "myTextBox" + i.ToString();
            myPlaceHolder.Controls.Add(textBox);
            dynamicTextBoxes[i] = textBox;
            LiteralControl literalBreak = new LiteralControl("<br />");
            myPlaceHolder.Controls.Add(literalBreak);
        }
    }

    protected void btnAddTextBox_Click(object sender, EventArgs e)
    {
        // Handled in preInit due to event sequencing.
        string sql = "select * from tbl_art1";
        DataTable dt;
        using(SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe()))
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            dt = new DataTable("tbl_htc2");
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {

                    }//dc loop
                }//row loop
            }// while loop
        }// using
    }

    protected void MyButton_Click(object sender, EventArgs e)
    {
        MyLabel.Text = "";
        foreach (TextBox tb in dynamicTextBoxes)
        {
            MyLabel.Text += tb.Text + " :: ";
        }
    }

    public static Control GetPostBackControl(Page thePage)
    {
        Control myControl = null;
        string ctrlName = thePage.Request.Params.Get("__EVENTTARGET");
        if (((ctrlName != null) & (ctrlName != string.Empty)))
        {
            myControl = thePage.FindControl(ctrlName);
        }
        else
        {
            foreach (string Item in thePage.Request.Form)
            {
                Control c = thePage.FindControl(Item);
                if (((c) is System.Web.UI.WebControls.Button))
                {
                    myControl = c;
                }
            }
        }
        return myControl;
    }

    #endregion


    protected void btnChart_Click(object sender, EventArgs e)
    {

        string st = string.Empty;
        string mMnth = string.Empty;
        string mYr = string.Empty;
        int Cnt = 0;
        
        string sql = "Select * from tbl_ART1";
        SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
        cn.Open();
        SqlCommand cmd = new SqlCommand(sql, cn);
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read())
        {
            st = r["grouptype"].ToString();
            mMnth = r["months"].ToString();
            mYr = r["years"].ToString();
            Cnt += Convert.ToInt32(r["TOTALG1"].ToString());

        }
        Chart1.Series[0].ChartType = (SeriesChartType)DropDownList1.SelectedIndex;
        Chart1.Series[0].YValueMembers = "Volume1";
        Chart1.Series[1].YValueMembers = "Volume2";
        Chart1.Series[0].XValueMember = "Date";
       // Chart1.ChartAreas = "Div1";


#region Sample Chart
     ////============================ Sample
     //   double[] yValues = { 15, 60, 12, 13 };
     //   string[] xValues = { "September", "October", "November", "December" };


     //   // Create a pie chart
     //   Chart chart = new Chart();


     //   // Build a pie series
     //   Series series = new Series("Default");
     //   series.ChartType = SeriesChartType.Pie;
     //   series["PieLabelStyle"] = "Disabled";
     //   chart.Series.Add(series);


     //   // Define the chart area
     //   ChartArea chartArea = new ChartArea();
     //   ChartArea3DStyle areaStyle = new ChartArea3DStyle(chartArea);
     //   areaStyle.Rotation = 0;


     //   Axis yAxis = new Axis(chartArea, AxisName.Y);
     //   Axis xAxis = new Axis(chartArea, AxisName.X);


     //   // Bind the data to the chart
     //   chart.Series["Default"].Points.DataBindXY(xValues, yValues);


     //   // Save the chart as a 300 x 200 image
     //   chart.Width = new System.Web.UI.WebControls.Unit(300, System.Web.UI.WebControls.UnitType.Pixel);
     //   chart.Height = new System.Web.UI.WebControls.Unit(200, System.Web.UI.WebControls.UnitType.Pixel);
     //   string filename = Server.MapPath("~") + "/Chart.png";
     //   chart.SaveImage(filename, ChartImageFormat.Png);
#endregion          



    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedItem.Text);
      }

    #region ======= The Right way to represent Chart====
    private void GetChartTypes()
    {
        DropDownList2.Items.Add("");
        foreach (int ChartType in Enum.GetValues(typeof(SeriesChartType)))
        {
            ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType), ChartType), ChartType.ToString());
            DropDownList2.Items.Add(li);
        }
    }

    private void GetChartData()
    {
        try
        {
            Series series = Chart1.Series["Series1"];
            series.AxisLabel = "Student Mark";
            
            series.Points.AddXY("Mark", 800);
            series.Points.AddXY("Muri", 850);
            series.Points.AddXY("John", 300);
            series.Points.AddXY("Paul", 200);
            series.Points.AddXY("Linus", 100);
            series.Points.AddXY("Abraham", 1800);

        }catch(Exception ex)
        {

        }

    }


    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetChartData();
        Chart1.Series["Series1"].ChartType =(SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList2.SelectedValue);
    }

    #endregion
}
