using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default5 : System.Web.UI.Page
{
      public string mChoose = string.Empty;
    public string mState = string.Empty;
    public string mLGA = string.Empty;
    public string mFacility = string.Empty;
    public string mMnth = string.Empty;
    public string mYr = string.Empty;
    public string mFile = string.Empty;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Session["mChoose"] as string))
            {
                mChoose = Session["mChoose"].ToString();
                mState = Session["mState"].ToString();
                mLGA = Session["mLGA"].ToString();
                mFacility = Session["mFacility"].ToString();
                mMnth = Session["mMnth"].ToString();
                mYr = Session["mYr"].ToString();
            }

            lblThematic.Text = " " + mState + "/" + mLGA + "/" + mFacility + "/" + mMnth + "-" + mYr;
            switch (mChoose)
            {
                case "TB":
                    Edit_TB();
                    TextBox332.Focus();
                    MultiView1.SetActiveView(View5);
                    break;
                case "LAB":
                    EDIT_LAB();
                    TextBox799.Focus();
                    MultiView1.SetActiveView(View6);
                    break;
            }

        }
       
    }

    protected void TextBox339_TextChanged(object sender, EventArgs e)
    {

    }

    //====== CLS TB
    protected void CLS_TB()
    {

        TextBox330.Text = string.Empty;
        TextBox331.Text = string.Empty;
        TextBox332.Text = string.Empty;
        TextBox333.Text = string.Empty;
        TextBox334.Text = string.Empty;
        TextBox335.Text = string.Empty;
        TextBox336.Text = string.Empty;
        TextBox337.Text = string.Empty;
        TextBox338.Text = string.Empty;
        TextBox339.Text = string.Empty;
        TextBox348.Text = string.Empty;
        TextBox340.Text = string.Empty;
        TextBox341.Text = string.Empty;
        TextBox342.Text = string.Empty;
        TextBox343.Text = string.Empty;
        TextBox344.Text = string.Empty;
        TextBox345.Text = string.Empty;
        TextBox346.Text = string.Empty;
        TextBox347.Text = string.Empty;
        TextBox349.Text = string.Empty;
        TextBox350.Text = string.Empty;
        TextBox351.Text = string.Empty;
        TextBox352.Text = string.Empty;
        TextBox353.Text = string.Empty;
        TextBox354.Text = string.Empty;
        TextBox355.Text = string.Empty;
        TextBox356.Text = string.Empty;
        TextBox357.Text = string.Empty;
        TextBox358.Text = string.Empty;
        TextBox359.Text = string.Empty;
        TextBox360.Text = string.Empty;
        TextBox361.Text = string.Empty;
        TextBox362.Text = string.Empty;
        TextBox363.Text = string.Empty;
        TextBox364.Text = string.Empty;
        TextBox365.Text = string.Empty;
        TextBox366.Text = string.Empty;
        TextBox367.Text = string.Empty;
        TextBox368.Text = string.Empty;
        TextBox369.Text = string.Empty;
        TextBox370.Text = string.Empty;
        TextBox371.Text = string.Empty;
        TextBox372.Text = string.Empty;
        TextBox373.Text = string.Empty;
        TextBox374.Text = string.Empty;
        TextBox375.Text = string.Empty;
        TextBox376.Text = string.Empty;
        TextBox377.Text = string.Empty;
        TextBox378.Text = string.Empty;
        TextBox379.Text = string.Empty;
        TextBox380.Text = string.Empty;
        TextBox381.Text = string.Empty;
        TextBox382.Text = string.Empty;
        TextBox383.Text = string.Empty;
        TextBox384.Text = string.Empty;
        TextBox385.Text = string.Empty;
        TextBox386.Text = string.Empty;
        TextBox387.Text = string.Empty;
        TextBox388.Text = string.Empty;
        TextBox390.Text = string.Empty;
        TextBox391.Text = string.Empty;
        TextBox392.Text = string.Empty;
        TextBox393.Text = string.Empty;
        TextBox394.Text = string.Empty;
        TextBox395.Text = string.Empty;
        TextBox396.Text = string.Empty;
        TextBox397.Text = string.Empty;
        TextBox389.Text = string.Empty;
        TextBox398.Text = string.Empty;
        TextBox399.Text = string.Empty;
        TextBox400.Text = string.Empty;
        TextBox401.Text = string.Empty;
        TextBox402.Text = string.Empty;
        TextBox403.Text = string.Empty;
        TextBox404.Text = string.Empty;
        TextBox405.Text = string.Empty;
        TextBox406.Text = string.Empty;
        TextBox407.Text = string.Empty;
        TextBox408.Text = string.Empty;
        TextBox409.Text = string.Empty;
        TextBox410.Text = string.Empty;
        TextBox411.Text = string.Empty;
        TextBox412.Text = string.Empty;
        TextBox413.Text = string.Empty;
        TextBox414.Text = string.Empty;
        TextBox415.Text = string.Empty;
        TextBox424.Text = string.Empty;
        TextBox416.Text = string.Empty;
        TextBox417.Text = string.Empty;
        TextBox418.Text = string.Empty;
        TextBox419.Text = string.Empty;
        TextBox420.Text = string.Empty;
        TextBox421.Text = string.Empty;
        TextBox425.Text = string.Empty;
        TextBox423.Text = string.Empty;
        TextBox425.Text = string.Empty;
        TextBox426.Text = string.Empty;
        TextBox427.Text = string.Empty;
        TextBox428.Text = string.Empty;
        TextBox429.Text = string.Empty;
        TextBox430.Text = string.Empty;
        TextBox431.Text = string.Empty;
        TextBox432.Text = string.Empty;
        TextBox433.Text = string.Empty;
        TextBox434.Text = string.Empty;
        TextBox443.Text = string.Empty;
        TextBox435.Text = string.Empty;
        TextBox436.Text = string.Empty;
        TextBox437.Text = string.Empty;
        TextBox438.Text = string.Empty;
        TextBox439.Text = string.Empty;
        TextBox440.Text = string.Empty;
        TextBox441.Text = string.Empty;
        TextBox442.Text = string.Empty;
        TextBox444.Text = string.Empty;
        TextBox445.Text = string.Empty;
        TextBox446.Text = string.Empty;
        TextBox447.Text = string.Empty;
        TextBox448.Text = string.Empty;
        TextBox449.Text = string.Empty;
        TextBox450.Text = string.Empty;
        TextBox451.Text = string.Empty;
        TextBox452.Text = string.Empty;
        TextBox453.Text = string.Empty;
        TextBox454.Text = string.Empty;
        TextBox455.Text = string.Empty;
        TextBox456.Text = string.Empty;
        TextBox457.Text = string.Empty;
        TextBox458.Text = string.Empty;
        TextBox459.Text = string.Empty;
        TextBox460.Text = string.Empty;
        TextBox461.Text = string.Empty;
        TextBox462.Text = string.Empty;
        TextBox463.Text = string.Empty;
        TextBox464.Text = string.Empty;
        TextBox465.Text = string.Empty;
        TextBox466.Text = string.Empty;
        TextBox467.Text = string.Empty;
        TextBox468.Text = string.Empty;
        TextBox469.Text = string.Empty;
        TextBox470.Text = string.Empty;
        TextBox471.Text = string.Empty;
        TextBox472.Text = string.Empty;
        TextBox481.Text = string.Empty;
        TextBox473.Text = string.Empty;
        TextBox474.Text = string.Empty;
        TextBox475.Text = string.Empty;
        TextBox476.Text = string.Empty;
        TextBox477.Text = string.Empty;
        TextBox478.Text = string.Empty;
        TextBox479.Text = string.Empty;
        TextBox480.Text = string.Empty;
        TextBox482.Text = string.Empty;
        TextBox483.Text = string.Empty;
        TextBox485.Text = string.Empty;
        TextBox486.Text = string.Empty;
        TextBox487.Text = string.Empty;
        TextBox488.Text = string.Empty;
        TextBox489.Text = string.Empty;
        TextBox490.Text = string.Empty;
        TextBox491.Text = string.Empty;
        TextBox492.Text = string.Empty;
        TextBox484.Text = string.Empty;
        TextBox493.Text = string.Empty;
        TextBox494.Text = string.Empty;
        TextBox495.Text = string.Empty;
        TextBox496.Text = string.Empty;
        TextBox497.Text = string.Empty;
        TextBox498.Text = string.Empty;
        TextBox499.Text = string.Empty;
        TextBox500.Text = string.Empty;
        TextBox501.Text = string.Empty;
        TextBox502.Text = string.Empty;
        TextBox504.Text = string.Empty;
        TextBox505.Text = string.Empty;
        TextBox506.Text = string.Empty;
        TextBox507.Text = string.Empty;
        TextBox508.Text = string.Empty;
        TextBox509.Text = string.Empty;
        TextBox510.Text = string.Empty;
        TextBox511.Text = string.Empty;
        TextBox503.Text = string.Empty;
        TextBox512.Text = string.Empty;
        TextBox513.Text = string.Empty;
        TextBox514.Text = string.Empty;
        TextBox515.Text = string.Empty;
        TextBox516.Text = string.Empty;
        TextBox517.Text = string.Empty;
        TextBox518.Text = string.Empty;
        TextBox519.Text = string.Empty;
        TextBox520.Text = string.Empty;
        TextBox521.Text = string.Empty;
        TextBox523.Text = string.Empty;
        TextBox524.Text = string.Empty;
        TextBox525.Text = string.Empty;
        TextBox526.Text = string.Empty;
        TextBox527.Text = string.Empty;
        TextBox528.Text = string.Empty;
        TextBox529.Text = string.Empty;
        TextBox530.Text = string.Empty;
        TextBox522.Text = string.Empty;
        TextBox531.Text = string.Empty;
        TextBox532.Text = string.Empty;
        TextBox533.Text = string.Empty;
        TextBox534.Text = string.Empty;
        TextBox535.Text = string.Empty;
        TextBox536.Text = string.Empty;
        TextBox537.Text = string.Empty;
        TextBox538.Text = string.Empty;
        TextBox539.Text = string.Empty;
        TextBox540.Text = string.Empty;
        TextBox542.Text = string.Empty;
        TextBox543.Text = string.Empty;
        TextBox544.Text = string.Empty;
        TextBox545.Text = string.Empty;
        TextBox546.Text = string.Empty;
        TextBox547.Text = string.Empty;
        TextBox548.Text = string.Empty;
        TextBox549.Text = string.Empty;
        TextBox541.Text = string.Empty;
        TextBox550.Text = string.Empty;
        TextBox551.Text = string.Empty;
        TextBox552.Text = string.Empty;
        TextBox553.Text = string.Empty;
        TextBox554.Text = string.Empty;
        TextBox555.Text = string.Empty;
        TextBox556.Text = string.Empty;
        TextBox557.Text = string.Empty;
        TextBox777.Text = string.Empty;
        TextBox778.Text = string.Empty;
        TextBox779.Text = string.Empty;
        TextBox780.Text = string.Empty;
        TextBox781.Text = string.Empty;
        TextBox782.Text = string.Empty;
        TextBox783.Text = string.Empty;
        TextBox784.Text = string.Empty;
        TextBox785.Text = string.Empty;
        TextBox786.Text = string.Empty;
        TextBox787.Text = string.Empty;
        TextBox788.Text = string.Empty;
        TextBox789.Text = string.Empty;
        TextBox790.Text = string.Empty;
        TextBox791.Text = string.Empty;
        TextBox792.Text = string.Empty;
        TextBox793.Text = string.Empty;
        TextBox794.Text = string.Empty;
        TextBox795.Text = string.Empty;

        TextBox558.Text = string.Empty;
        TextBox559.Text = string.Empty;
        TextBox560.Text = string.Empty;
        TextBox561.Text = string.Empty;
        TextBox562.Text = string.Empty;
        TextBox563.Text = string.Empty;
        TextBox564.Text = string.Empty;
        TextBox565.Text = string.Empty;
        TextBox566.Text = string.Empty;
        TextBox567.Text = string.Empty;
        TextBox576.Text = string.Empty;
        TextBox568.Text = string.Empty;
        TextBox569.Text = string.Empty;
        TextBox570.Text = string.Empty;
        TextBox571.Text = string.Empty;
        TextBox572.Text = string.Empty;
        TextBox573.Text = string.Empty;
        TextBox574.Text = string.Empty;
        TextBox575.Text = string.Empty;
        TextBox577.Text = string.Empty;
        TextBox578.Text = string.Empty;
        TextBox579.Text = string.Empty;
        TextBox580.Text = string.Empty;
        TextBox581.Text = string.Empty;
        TextBox582.Text = string.Empty;
        TextBox583.Text = string.Empty;
        TextBox584.Text = string.Empty;
        TextBox585.Text = string.Empty;
        TextBox586.Text = string.Empty;
        TextBox595.Text = string.Empty;
        TextBox587.Text = string.Empty;
        TextBox588.Text = string.Empty;
        TextBox589.Text = string.Empty;
        TextBox590.Text = string.Empty;
        TextBox591.Text = string.Empty;
        TextBox592.Text = string.Empty;
        TextBox593.Text = string.Empty;
        TextBox594.Text = string.Empty;
        TextBox596.Text = string.Empty;
        TextBox597.Text = string.Empty;
        TextBox598.Text = string.Empty;
        TextBox599.Text = string.Empty;
        TextBox600.Text = string.Empty;
        TextBox601.Text = string.Empty;
        TextBox602.Text = string.Empty;
        TextBox603.Text = string.Empty;
        TextBox604.Text = string.Empty;
        TextBox605.Text = string.Empty;
        TextBox606.Text = string.Empty;
        TextBox607.Text = string.Empty;
        TextBox608.Text = string.Empty;
        TextBox609.Text = string.Empty;
        TextBox610.Text = string.Empty;
        TextBox611.Text = string.Empty;
        TextBox612.Text = string.Empty;
        TextBox613.Text = string.Empty;
        TextBox614.Text = string.Empty;
        TextBox615.Text = string.Empty;
        TextBox616.Text = string.Empty;
        TextBox617.Text = string.Empty;
        TextBox618.Text = string.Empty;
        TextBox619.Text = string.Empty;
        TextBox620.Text = string.Empty;
        TextBox621.Text = string.Empty;
        TextBox622.Text = string.Empty;
        TextBox623.Text = string.Empty;
        TextBox624.Text = string.Empty;
        TextBox633.Text = string.Empty;
        TextBox625.Text = string.Empty;
        TextBox626.Text = string.Empty;
        TextBox627.Text = string.Empty;
        TextBox628.Text = string.Empty;
        TextBox629.Text = string.Empty;
        TextBox630.Text = string.Empty;
        TextBox631.Text = string.Empty;
        TextBox632.Text = string.Empty;
        TextBox634.Text = string.Empty;
        TextBox635.Text = string.Empty;
        TextBox636.Text = string.Empty;
        TextBox637.Text = string.Empty;
        TextBox638.Text = string.Empty;
        TextBox639.Text = string.Empty;
        TextBox640.Text = string.Empty;
        TextBox641.Text = string.Empty;
        TextBox642.Text = string.Empty;
        TextBox643.Text = string.Empty;
        TextBox644.Text = string.Empty;
        TextBox645.Text = string.Empty;
        TextBox646.Text = string.Empty;
        TextBox647.Text = string.Empty;
        TextBox648.Text = string.Empty;
        TextBox649.Text = string.Empty;
        TextBox650.Text = string.Empty;
        TextBox651.Text = string.Empty;
        TextBox652.Text = string.Empty;
        TextBox653.Text = string.Empty;
        TextBox654.Text = string.Empty;
        TextBox655.Text = string.Empty;
        TextBox656.Text = string.Empty;
        TextBox657.Text = string.Empty;
        TextBox658.Text = string.Empty;
        TextBox659.Text = string.Empty;
        TextBox660.Text = string.Empty;
        TextBox661.Text = string.Empty;
        TextBox662.Text = string.Empty;
        TextBox671.Text = string.Empty;
        TextBox663.Text = string.Empty;
        TextBox664.Text = string.Empty;
        TextBox665.Text = string.Empty;
        TextBox666.Text = string.Empty;
        TextBox667.Text = string.Empty;
        TextBox668.Text = string.Empty;
        TextBox669.Text = string.Empty;
        TextBox670.Text = string.Empty;
        TextBox672.Text = string.Empty;
        TextBox673.Text = string.Empty;
        TextBox674.Text = string.Empty;
        TextBox675.Text = string.Empty;
        TextBox676.Text = string.Empty;
        TextBox677.Text = string.Empty;
        TextBox678.Text = string.Empty;
        TextBox679.Text = string.Empty;
        TextBox680.Text = string.Empty;
        TextBox681.Text = string.Empty;
        TextBox682.Text = string.Empty;
        TextBox674.Text = string.Empty;
        TextBox683.Text = string.Empty;
        TextBox684.Text = string.Empty;
        TextBox685.Text = string.Empty;
        TextBox686.Text = string.Empty;
        TextBox687.Text = string.Empty;
        TextBox689.Text = string.Empty;
        TextBox690.Text = string.Empty;
        TextBox691.Text = string.Empty;
        TextBox692.Text = string.Empty;
        TextBox694.Text = string.Empty;
        TextBox695.Text = string.Empty;
        TextBox696.Text = string.Empty;
        TextBox697.Text = string.Empty;
        TextBox698.Text = string.Empty;
        TextBox699.Text = string.Empty;
        TextBox700.Text = string.Empty;
        TextBox701.Text = string.Empty;
        TextBox693.Text = string.Empty;
        TextBox702.Text = string.Empty;
        TextBox703.Text = string.Empty;
        TextBox704.Text = string.Empty;
        TextBox705.Text = string.Empty;
        TextBox706.Text = string.Empty;
        TextBox707.Text = string.Empty;
        TextBox708.Text = string.Empty;
        TextBox709.Text = string.Empty;
        TextBox710.Text = string.Empty;
        TextBox711.Text = string.Empty;
        TextBox713.Text = string.Empty;
        TextBox714.Text = string.Empty;
        TextBox715.Text = string.Empty;
        TextBox716.Text = string.Empty;
        TextBox717.Text = string.Empty;
        TextBox718.Text = string.Empty;
        TextBox719.Text = string.Empty;
        TextBox720.Text = string.Empty;
        TextBox712.Text = string.Empty;
        TextBox721.Text = string.Empty;
        TextBox722.Text = string.Empty;
        TextBox723.Text = string.Empty;
        TextBox724.Text = string.Empty;
        TextBox725.Text = string.Empty;
        TextBox726.Text = string.Empty;
        TextBox727.Text = string.Empty;
        TextBox728.Text = string.Empty;
        TextBox729.Text = string.Empty;
        TextBox730.Text = string.Empty;
        TextBox307.Text = string.Empty;
        TextBox308.Text = string.Empty;
        TextBox309.Text = string.Empty;
        TextBox310.Text = string.Empty;
        TextBox311.Text = string.Empty;
        TextBox312.Text = string.Empty;
        TextBox313.Text = string.Empty;
        TextBox314.Text = string.Empty;
        TextBox731.Text = string.Empty;
        TextBox315.Text = string.Empty;
        TextBox732.Text = string.Empty;
        TextBox733.Text = string.Empty;
        TextBox734.Text = string.Empty;
        TextBox735.Text = string.Empty;
        TextBox736.Text = string.Empty;
        TextBox737.Text = string.Empty;
        TextBox738.Text = string.Empty;
        TextBox739.Text = string.Empty;
        TextBox740.Text = string.Empty;
        TextBox741.Text = string.Empty;
        TextBox742.Text = string.Empty;
        TextBox743.Text = string.Empty;
        TextBox744.Text = string.Empty;
        TextBox745.Text = string.Empty;
        TextBox746.Text = string.Empty;
        TextBox747.Text = string.Empty;
        TextBox748.Text = string.Empty;
        TextBox749.Text = string.Empty;
        TextBox750.Text = string.Empty;
        TextBox751.Text = string.Empty;
        TextBox752.Text = string.Empty;
        TextBox753.Text = string.Empty;
        TextBox754.Text = string.Empty;
        TextBox755.Text = string.Empty;
        TextBox756.Text = string.Empty;
        TextBox757.Text = string.Empty;
        TextBox758.Text = string.Empty;
        TextBox759.Text = string.Empty;
        TextBox761.Text = string.Empty;
        TextBox762.Text = string.Empty;
        TextBox763.Text = string.Empty;
        TextBox764.Text = string.Empty;
        TextBox765.Text = string.Empty;
        TextBox766.Text = string.Empty;
        TextBox767.Text = string.Empty;
        TextBox768.Text = string.Empty;
        TextBox760.Text = string.Empty;
        TextBox769.Text = string.Empty;
        TextBox770.Text = string.Empty;
        TextBox771.Text = string.Empty;
        TextBox772.Text = string.Empty;
        TextBox773.Text = string.Empty;
        TextBox774.Text = string.Empty;
        TextBox775.Text = string.Empty;
        TextBox776.Text = string.Empty;
    }

    protected void Edit_TB()
    {
        try
        {
            int t1 = -1; int t2 = -1; int t3 = -1;
             string SQL1 = "SELECT * FROM tbl_TB1 Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                TextBox330.Text = r["totalg1"].ToString();
                TextBox331.Text = r["Subg1ma"].ToString();
                TextBox332.Text = r["G1MA1"].ToString();
                TextBox333.Text = r["G1MA1_4"].ToString();
                TextBox334.Text = r["G1MA5_9"].ToString();
                TextBox335.Text = r["G1MA10_14"].ToString();
                TextBox336.Text = r["G1MA15_19"].ToString();
                TextBox337.Text = r["G1MA20_24"].ToString();
                TextBox338.Text = r["G1MA25_49"].ToString();
                TextBox339.Text = r["G1MA50"].ToString();
                TextBox348.Text = r["SUBG1FE"].ToString();
                TextBox340.Text = r["G1FE1"].ToString();
                TextBox341.Text = r["G1FE1_4"].ToString();
                TextBox342.Text = r["G1FE5_9"].ToString();
                TextBox343.Text = r["G1FE10_14"].ToString();
                TextBox344.Text = r["G1FE15_19"].ToString();
                TextBox345.Text = r["G1FE20_24"].ToString();
                TextBox346.Text = r["G1FE25_49"].ToString();
                TextBox347.Text = r["G1FE50"].ToString();
                TextBox349.Text = r["POS_G1STOTAL"].ToString();
                TextBox350.Text = r["POS_SUBG1MA"].ToString();
                TextBox351.Text = r["POS_G1MA1"].ToString();
                TextBox352.Text = r["POS_G1MA1_4"].ToString();
                TextBox353.Text = r["POS_G1MA5_9"].ToString();
                TextBox354.Text = r["POS_G1MA10_14"].ToString();
                TextBox355.Text = r["POS_G1MA15_19"].ToString();
                TextBox356.Text = r["POS_G1MA20_24"].ToString();
                TextBox357.Text = r["POS_G1MA25_49"].ToString();
                TextBox358.Text = r["POS_G1MA50"].ToString();
                TextBox359.Text = r["POS_SUBG1FE"].ToString();
                TextBox360.Text = r["POS_G1FE1"].ToString();
                TextBox361.Text = r["POS_G1FE1_4"].ToString();
                TextBox362.Text = r["POS_G1FE5_9"].ToString();
                TextBox363.Text = r["POS_G1FE10_14"].ToString();
                TextBox364.Text = r["POS_G1FE15_19"].ToString();
                TextBox365.Text = r["POS_G1FE20_24"].ToString();
                TextBox366.Text = r["POS_G1FE25_49"].ToString();
                TextBox367.Text = r["POS_G1FE50"].ToString();
                TextBox368.Text = r["NEG_G1TOTAL"].ToString();
                TextBox369.Text = r["NEG_SUBG1MA"].ToString();
                TextBox370.Text = r["NEG_G1MA1"].ToString();
                TextBox371.Text = r["NEG_G1MA1_4"].ToString();
                TextBox372.Text = r["NEG_G1MA5_9"].ToString();
                TextBox373.Text = r["NEG_G1MA10_14"].ToString();
                TextBox374.Text = r["NEG_G1MA15_19"].ToString();
                TextBox375.Text = r["NEG_G1MA20_24"].ToString();
                TextBox376.Text = r["NEG_G1MA25_49"].ToString();
                TextBox377.Text = r["NEG_G1MA50"].ToString();
                TextBox378.Text = r["NEG_SUBG1FE"].ToString();
                TextBox379.Text = r["NEG_G1FE1"].ToString();
                TextBox380.Text = r["NEG_G1FE1_4"].ToString();
                TextBox381.Text = r["NEG_G1FE5_9"].ToString();
                TextBox382.Text = r["NEG_G1FE10_14"].ToString();
                TextBox383.Text = r["NEG_G1FE15_19"].ToString();
                TextBox384.Text = r["NEG_G1FE20_24"].ToString();
                TextBox385.Text = r["NEG_G1FE25_49"].ToString();
                TextBox386.Text = r["NEG_G1FE50"].ToString();
                TextBox387.Text = r["TOTALG2"].ToString();
                TextBox388.Text = r["SUBG2MA"].ToString();
                TextBox390.Text = r["G2MA1"].ToString();
                TextBox391.Text = r["G2MA1_4"].ToString();
                TextBox392.Text = r["G2MA5_9"].ToString();
                TextBox393.Text = r["G2MA10_14"].ToString();
                TextBox394.Text = r["G2MA15_19"].ToString();
                TextBox395.Text = r["G2MA20_24"].ToString();
                TextBox396.Text = r["G2MA25_49"].ToString();
                TextBox397.Text = r["G2MA50"].ToString();
                TextBox389.Text = r["SUBG2FE"].ToString();
                TextBox398.Text = r["G2FE1"].ToString();
                TextBox399.Text = r["G2FE1_4"].ToString();
                TextBox400.Text = r["G2FE5_9"].ToString();
                TextBox401.Text = r["G2FE10_14"].ToString();
                TextBox402.Text = r["G2FE15_19"].ToString();
                TextBox403.Text = r["G2FE20_24"].ToString();
                TextBox404.Text = r["G2FE25_49"].ToString();
                TextBox405.Text = r["G2FE50"].ToString();
                TextBox406.Text = r["POS_G2STOTAL"].ToString();
                TextBox407.Text = r["POS_SUBG2MA"].ToString();
                TextBox408.Text = r["POS_G2MA1"].ToString();
                TextBox409.Text = r["POS_G2MA1_4"].ToString();
                TextBox410.Text = r["POS_G2MA5_9"].ToString();
                TextBox411.Text = r["POS_G2MA10_14"].ToString();
                TextBox412.Text = r["POS_G2MA15_19"].ToString();
                TextBox413.Text = r["POS_G2MA20_24"].ToString();
                TextBox414.Text = r["POS_G2MA25_49"].ToString();
                TextBox415.Text = r["POS_G2MA50"].ToString();
                TextBox424.Text = r["POS_SUBG2FE"].ToString();
                TextBox416.Text = r["POS_G2FE1"].ToString();
                TextBox417.Text = r["POS_G2FE1_4"].ToString();
                TextBox418.Text = r["POS_G2FE5_9"].ToString();
                TextBox419.Text = r["POS_G2FE10_14"].ToString();
                TextBox420.Text = r["POS_G2FE15_19"].ToString();
                TextBox421.Text = r["POS_G2FE20_24"].ToString();
                TextBox425.Text = r["POS_G2FE25_49"].ToString();
                TextBox423.Text = r["POS_G2FE50"].ToString();
                TextBox425.Text = r["NEG_G2TOTAL"].ToString();
                TextBox426.Text = r["NEG_SUBG2MA"].ToString();
                TextBox427.Text = r["NEG_G2MA1"].ToString();
                TextBox428.Text = r["NEG_G2MA1_4"].ToString();
                TextBox429.Text = r["NEG_G2MA5_9"].ToString();
                TextBox430.Text = r["NEG_G2MA10_14"].ToString();
                TextBox431.Text = r["NEG_G2MA15_19"].ToString();
                TextBox432.Text = r["NEG_G2MA20_24"].ToString();
                TextBox433.Text = r["NEG_G2MA25_49"].ToString();
                TextBox434.Text = r["NEG_G2MA50"].ToString();
                TextBox443.Text = r["NEG_SUBG2FE"].ToString();
                TextBox435.Text = r["NEG_G2FE1"].ToString();
                TextBox436.Text = r["NEG_G2FE1_4"].ToString();
                TextBox437.Text = r["NEG_G2FE5_9"].ToString();
                TextBox438.Text = r["NEG_G2FE10_14"].ToString();
                TextBox439.Text = r["NEG_G2FE15_19"].ToString();
                TextBox440.Text = r["NEG_G2FE20_24"].ToString();
                TextBox441.Text = r["NEG_G2FE25_49"].ToString();
                TextBox442.Text = r["NEG_G2FE50"].ToString();
                TextBox444.Text = r["TOTALG3"].ToString();
                TextBox445.Text = r["SUBG3MA"].ToString();
                TextBox446.Text = r["G3MA1"].ToString();
                TextBox447.Text = r["G3MA1_4"].ToString();
                TextBox448.Text = r["G3MA5_9"].ToString();
                TextBox449.Text = r["G3MA10_14"].ToString();
                TextBox450.Text = r["G3MA15_19"].ToString();
                TextBox451.Text = r["G3MA20_24"].ToString();
                TextBox452.Text = r["G3MA25_49"].ToString();
                TextBox453.Text = r["G3MA50"].ToString();
                TextBox454.Text = r["SUBG3FE"].ToString();
                TextBox455.Text = r["G3FE1"].ToString();
                TextBox456.Text = r["G3FE1_4"].ToString();
                TextBox457.Text = r["G3FE5_9"].ToString();
                TextBox458.Text = r["G3FE10_14"].ToString();
                TextBox459.Text = r["G3FE15_19"].ToString();
                TextBox460.Text = r["G3FE20_24"].ToString();
                TextBox461.Text = r["G3FE25_49"].ToString();
                TextBox462.Text = r["G3FE50"].ToString();
                TextBox463.Text = r["TOTALG4"].ToString();
                TextBox464.Text = r["SUBG4MA"].ToString();
                TextBox465.Text = r["G4MA1"].ToString();
                TextBox466.Text = r["G4MA1_4"].ToString();
                TextBox467.Text = r["G4MA5_9"].ToString();
                TextBox468.Text = r["G4MA10_14"].ToString();
                TextBox469.Text = r["G4MA15_19"].ToString();
                TextBox470.Text = r["G4MA20_24"].ToString();
                TextBox471.Text = r["G4MA25_49"].ToString();
                TextBox472.Text = r["G4MA50"].ToString();
                TextBox481.Text = r["SUBG4FE"].ToString();
                TextBox473.Text = r["G4FE1"].ToString();
                TextBox474.Text = r["G4FE1_4"].ToString();
                TextBox475.Text = r["G4FE5_9"].ToString();
                TextBox476.Text = r["G4FE10_14"].ToString();
                TextBox477.Text = r["G4FE15_19"].ToString();
                TextBox478.Text = r["G4FE20_24"].ToString();
                TextBox479.Text = r["G4FE25_49"].ToString();
                TextBox480.Text = r["G4FE50"].ToString();
                TextBox482.Text = r["TOTALG5"].ToString();
                TextBox483.Text = r["SUBG5MA"].ToString();
                TextBox485.Text = r["G5MA1"].ToString();
                TextBox486.Text = r["G5MA1_4"].ToString();
                TextBox487.Text = r["G5MA5_9"].ToString();
                TextBox488.Text = r["G5MA10_14"].ToString();

               t1=1;
            }
            cn.Close();
             string SQL2 = "SELECT * FROM tbl_TB2 Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

             if (cn.State == ConnectionState.Closed)
             {
                 cn.Open();
             }
            SqlCommand cmd2 = new SqlCommand(SQL2, cn);
            SqlDataReader r2 = cmd2.ExecuteReader();

            while (r2.Read())
            {
                TextBox489.Text = r2["G5MA15_19"].ToString();
                TextBox490.Text = r2["G5MA20_24"].ToString();
                TextBox491.Text = r2["G5MA25_49"].ToString();
                TextBox492.Text = r2["G5MA50"].ToString();
                TextBox484.Text = r2["SUBG5FE"].ToString();
                TextBox493.Text = r2["G5FE1"].ToString();
                TextBox494.Text = r2["G5FE1_4"].ToString();
                TextBox495.Text = r2["G5FE5_9"].ToString();
                TextBox496.Text = r2["G5FE10_14"].ToString();
                TextBox497.Text = r2["G5FE15_19"].ToString();
                TextBox498.Text = r2["G5FE20_24"].ToString();
                TextBox499.Text = r2["G5FE25_49"].ToString();
                TextBox500.Text = r2["G5FE50"].ToString();
                TextBox501.Text = r2["TOTALG6"].ToString();
                TextBox502.Text = r2["SUBG6MA"].ToString();
                TextBox504.Text = r2["G6MA1"].ToString();
                TextBox505.Text = r2["G6MA1_4"].ToString();
                TextBox506.Text = r2["G6MA5_9"].ToString();
                TextBox507.Text = r2["G6MA10_14"].ToString();
                TextBox508.Text = r2["G6MA15_19"].ToString();
                TextBox509.Text = r2["G6MA20_24"].ToString();
                TextBox510.Text = r2["G6MA25_49"].ToString();
                TextBox511.Text = r2["G6MA50"].ToString();
                TextBox503.Text = r2["SUBG6FE"].ToString();
                TextBox512.Text = r2["G6FE1"].ToString();
                TextBox513.Text = r2["G6FE1_4"].ToString();
                TextBox514.Text = r2["G6FE5_9"].ToString();
                TextBox515.Text = r2["G6FE10_14"].ToString();
                TextBox516.Text = r2["G6FE15_19"].ToString();
                TextBox517.Text = r2["G6FE20_24"].ToString();
                TextBox518.Text = r2["G6FE25_49"].ToString();
                TextBox519.Text = r2["G6FE50"].ToString();
                TextBox520.Text = r2["TOTALG7"].ToString();
                TextBox521.Text = r2["SUBG7MA"].ToString();
                TextBox523.Text = r2["G7MA1"].ToString();
                TextBox524.Text = r2["G7MA1_4"].ToString();
                TextBox525.Text = r2["G7MA5_9"].ToString();
                TextBox526.Text = r2["G7MA10_14"].ToString();
                TextBox527.Text = r2["G7MA15_19"].ToString();
                TextBox528.Text = r2["G7MA20_24"].ToString();
                TextBox529.Text = r2["G7MA25_49"].ToString();
                TextBox530.Text = r2["G7MA50"].ToString();
                TextBox522.Text = r2["SUBG7FE"].ToString();
                TextBox531.Text = r2["G7FE1"].ToString();
                TextBox532.Text = r2["G7FE1_4"].ToString();
                TextBox533.Text = r2["G7FE5_9"].ToString();
                TextBox534.Text = r2["G7FE10_14"].ToString();
                TextBox535.Text = r2["G7FE15_19"].ToString();
                TextBox536.Text = r2["G7FE20_24"].ToString();
                TextBox537.Text = r2["G7FE25_49"].ToString();
                TextBox538.Text = r2["G7FE50"].ToString();
                TextBox539.Text = r2["TOTALG8"].ToString();
                TextBox540.Text = r2["SUBG8MA"].ToString();
                TextBox542.Text = r2["G8MA1"].ToString();
                TextBox543.Text = r2["G8MA1_4"].ToString();
                TextBox544.Text = r2["G8MA5_9"].ToString();
                TextBox545.Text = r2["G8MA10_14"].ToString();
                TextBox546.Text = r2["G8MA15_19"].ToString();
                TextBox547.Text = r2["G8MA20_24"].ToString();
                TextBox548.Text = r2["G8MA25_49"].ToString();
                TextBox549.Text = r2["G8MA50"].ToString();
                TextBox541.Text = r2["SUBG8FE"].ToString();
                TextBox550.Text = r2["G8FE1"].ToString();
                TextBox551.Text = r2["G8FE1_4"].ToString();
                TextBox552.Text = r2["G8FE5_9"].ToString();
                TextBox553.Text = r2["G8FE10_14"].ToString();
                TextBox554.Text = r2["G8FE15_19"].ToString();
                TextBox555.Text = r2["G8FE20_24"].ToString();
                TextBox556.Text = r2["G8FE25_49"].ToString();
                TextBox557.Text = r2["G8FE50"].ToString();
                TextBox777.Text = r2["TOTALG9"].ToString();
                TextBox778.Text = r2["SUBG9MA"].ToString();
                TextBox779.Text = r2["G9MA1"].ToString();
                TextBox780.Text = r2["G9MA1_4"].ToString();
                TextBox781.Text = r2["G9MA5_9"].ToString();
                TextBox782.Text = r2["G9MA10_14"].ToString();
                TextBox783.Text = r2["G9MA15_19"].ToString();
                TextBox784.Text = r2["G9MA20_24"].ToString();
                TextBox785.Text = r2["G9MA25_49"].ToString();
                TextBox786.Text = r2["G9MA50"].ToString();
                TextBox787.Text = r2["SUBG9FE"].ToString();
                TextBox788.Text = r2["G9FE1"].ToString();
                TextBox789.Text = r2["G9FE1_4"].ToString();
                TextBox790.Text = r2["G9FE5_9"].ToString();
                TextBox791.Text = r2["G9FE10_14"].ToString();
                TextBox792.Text = r2["G9FE15_19"].ToString();
                TextBox793.Text = r2["G9FE20_24"].ToString();
                TextBox794.Text = r2["G9FE25_49"].ToString();
                TextBox795.Text = r2["G9FE50"].ToString();
                TextBox558.Text = r2["TOTALG10"].ToString();
                TextBox559.Text = r2["SUBG10MA"].ToString();
                TextBox560.Text = r2["G10MA1"].ToString();
                TextBox561.Text = r2["G10MA1_4"].ToString();
                TextBox562.Text = r2["G10MA5_9"].ToString();
                TextBox563.Text = r2["G10MA10_14"].ToString();
                TextBox564.Text = r2["G10MA15_19"].ToString();
                TextBox565.Text = r2["G10MA20_24"].ToString();
                TextBox566.Text = r2["G10MA25_49"].ToString();
                TextBox567.Text = r2["G10MA50"].ToString();
                TextBox576.Text = r2["SUBG10FE"].ToString();
                TextBox568.Text = r2["G10FE1"].ToString();
                TextBox569.Text = r2["G10FE1_4"].ToString();
                TextBox570.Text = r2["G10FE5_9"].ToString();
                TextBox571.Text = r2["G10FE10_14"].ToString();
                TextBox572.Text = r2["G10FE15_19"].ToString();
                TextBox573.Text = r2["G10FE20_24"].ToString();
                TextBox574.Text = r2["G10FE25_49"].ToString();
                TextBox575.Text = r2["G10FE50"].ToString();
                TextBox577.Text = r2["TOTALG11"].ToString();
                TextBox578.Text = r2["SUBG11MA"].ToString();
                TextBox579.Text = r2["G11MA1"].ToString();
                TextBox580.Text = r2["G11MA1_4"].ToString();
                TextBox581.Text = r2["G11MA5_9"].ToString();
                TextBox582.Text = r2["G11MA10_14"].ToString();
                TextBox583.Text = r2["G11MA15_19"].ToString();
                TextBox584.Text = r2["G11MA20_24"].ToString();
                TextBox585.Text = r2["G11MA25_49"].ToString();
                TextBox586.Text = r2["G11MA50"].ToString();
                TextBox595.Text = r2["SUBG11FE"].ToString();
                TextBox587.Text = r2["G11FE1"].ToString();
                TextBox588.Text = r2["G11FE1_4"].ToString();
                TextBox589.Text = r2["G11FE5_9"].ToString();
                TextBox590.Text = r2["G11FE10_14"].ToString();
                TextBox591.Text = r2["G11FE15_19"].ToString();
                TextBox592.Text = r2["G11FE20_24"].ToString();
                TextBox593.Text = r2["G11FE25_49"].ToString();
                TextBox594.Text = r2["G11FE50"].ToString();
                TextBox596.Text = r2["TOTALG12"].ToString();
                TextBox597.Text = r2["SUBG12MA"].ToString();
                TextBox598.Text = r2["G12MA1"].ToString();
                TextBox599.Text = r2["G12MA1_4"].ToString();
                TextBox600.Text = r2["G12MA5_9"].ToString();
                TextBox601.Text = r2["G12MA10_14"].ToString();
                TextBox602.Text = r2["G12MA15_19"].ToString();
                TextBox603.Text = r2["G12MA20_24"].ToString();
                TextBox604.Text = r2["G12MA25_49"].ToString();
                TextBox605.Text = r2["G12MA50"].ToString();
                TextBox606.Text = r2["SUBG12FE"].ToString();
                TextBox607.Text = r2["G12FE1"].ToString();
                TextBox608.Text = r2["G12FE1_4"].ToString();
                TextBox609.Text = r2["G12FE5_9"].ToString();
                TextBox610.Text = r2["G12FE10_14"].ToString();
                TextBox611.Text = r2["G12FE15_19"].ToString();
                TextBox612.Text = r2["G12FE20_24"].ToString();
                TextBox613.Text = r2["G12FE25_49"].ToString();
                TextBox614.Text = r2["G12FE50"].ToString();
                TextBox615.Text = r2["TOTALG13"].ToString();
                TextBox616.Text = r2["SUBG13MA"].ToString();
                TextBox617.Text = r2["G13MA1"].ToString();
                TextBox618.Text = r2["G13MA1_4"].ToString();
                TextBox619.Text = r2["G13MA5_9"].ToString();
                TextBox620.Text = r2["G13MA10_14"].ToString();
                TextBox621.Text = r2["G13MA15_19"].ToString();
                TextBox622.Text = r2["G13MA20_24"].ToString();
                TextBox623.Text = r2["G13MA25_49"].ToString();
                TextBox624.Text = r2["G13MA50"].ToString();
                TextBox633.Text = r2["SUBG13FE"].ToString();
                TextBox625.Text = r2["G13FE1"].ToString(); 

                t2 = 1;
            }
            cn.Close();
            string SQL3 = "SELECT * FROM tbl_TB3 Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";

             if (cn.State == ConnectionState.Closed)
             {
                 cn.Open();
             }
            SqlCommand cmd3 = new SqlCommand(SQL3, cn);
            SqlDataReader r3 = cmd3.ExecuteReader();

            while (r3.Read())
            {
                TextBox626.Text = r3["G13FE1_4"].ToString();
                TextBox627.Text = r3["G13FE5_9"].ToString();
                TextBox628.Text = r3["G13FE10_14"].ToString();
                TextBox629.Text = r3["G13FE15_19"].ToString();
                TextBox630.Text = r3["G13FE20_24"].ToString();
                TextBox631.Text = r3["G13FE25_49"].ToString();
                TextBox632.Text = r3["G13FE50"].ToString();
                TextBox634.Text = r3["TOTALG14"].ToString();
                TextBox635.Text = r3["SUBG14MA"].ToString();
                TextBox636.Text = r3["G14MA1"].ToString();
                TextBox637.Text = r3["G14MA1_4"].ToString();
                TextBox638.Text = r3["G14MA5_9"].ToString();
                TextBox639.Text = r3["G14MA10_14"].ToString();
                TextBox640.Text = r3["G14MA15_19"].ToString();
                TextBox641.Text = r3["G14MA20_24"].ToString();
                TextBox642.Text = r3["G14MA25_49"].ToString();
                TextBox643.Text = r3["G14MA50"].ToString();
                TextBox644.Text = r3["SUBG14FE"].ToString();
                TextBox645.Text = r3["G14FE1"].ToString();
                TextBox646.Text = r3["G14FE1_4"].ToString();
                TextBox647.Text = r3["G14FE5_9"].ToString();
                TextBox648.Text = r3["G14FE10_14"].ToString();
                TextBox649.Text = r3["G14FE15_19"].ToString();
                TextBox650.Text = r3["G14FE20_24"].ToString();
                TextBox651.Text = r3["G14FE25_49"].ToString();
                TextBox652.Text = r3["G14FE50"].ToString();
                TextBox653.Text = r3["TOTALG15"].ToString();
                TextBox654.Text = r3["SUBG15MA"].ToString();
                TextBox655.Text = r3["G15MA1"].ToString();
                TextBox656.Text = r3["G15MA1_4"].ToString();
                TextBox657.Text = r3["G15MA5_9"].ToString();
                TextBox658.Text = r3["G15MA10_14"].ToString();
                TextBox659.Text = r3["G15MA15_19"].ToString();
                TextBox660.Text = r3["G15MA20_24"].ToString();
                TextBox661.Text = r3["G15MA25_49"].ToString();
                TextBox662.Text = r3["G15MA50"].ToString();
                TextBox671.Text = r3["SUBG15FE"].ToString();
                TextBox663.Text = r3["G15FE1"].ToString();
                TextBox664.Text = r3["G15FE1_4"].ToString();
                TextBox665.Text = r3["G15FE5_9"].ToString();
                TextBox666.Text = r3["G15FE10_14"].ToString();
                TextBox667.Text = r3["G15FE15_19"].ToString();
                TextBox668.Text = r3["G15FE20_24"].ToString();
                TextBox669.Text = r3["G15FE25_49"].ToString();
                TextBox670.Text = r3["G15FE50"].ToString();
                TextBox672.Text = r3["TOTALG16"].ToString();
                TextBox673.Text = r3["SUBG16MA"].ToString();
                TextBox674.Text = r3["G16MA1"].ToString();
                TextBox675.Text = r3["G16MA1_4"].ToString();
                TextBox676.Text = r3["G16MA5_9"].ToString();
                TextBox677.Text = r3["G16MA10_14"].ToString();
                TextBox678.Text = r3["G16MA15_19"].ToString();
                TextBox679.Text = r3["G16MA20_24"].ToString();
                TextBox680.Text = r3["G16MA25_49"].ToString();
                TextBox681.Text = r3["G16MA50"].ToString();
                TextBox682.Text = r3["SUBG16FE"].ToString();
                TextBox674.Text = r3["G16FE1"].ToString();
                TextBox683.Text = r3["G16FE1_4"].ToString();
                TextBox684.Text = r3["G16FE5_9"].ToString();
                TextBox685.Text = r3["G16FE10_14"].ToString();
                TextBox686.Text = r3["G16FE15_19"].ToString();
                TextBox687.Text = r3["G16FE20_24"].ToString();
                TextBox689.Text = r3["G16FE25_49"].ToString();
                TextBox690.Text = r3["G16FE50"].ToString();
                TextBox691.Text = r3["TOTALG17"].ToString();
                TextBox692.Text = r3["SUBG17MA"].ToString();
                TextBox694.Text = r3["G17MA1"].ToString();
                TextBox695.Text = r3["G17MA1_4"].ToString();
                TextBox696.Text = r3["G17MA5_9"].ToString();
                TextBox697.Text = r3["G17MA10_14"].ToString();
                TextBox698.Text = r3["G17MA15_19"].ToString();
                TextBox699.Text = r3["G17MA20_24"].ToString();
                TextBox700.Text = r3["G17MA25_49"].ToString();
                TextBox701.Text = r3["G17MA50"].ToString();
                TextBox693.Text = r3["SUBG17FE"].ToString();
                TextBox702.Text = r3["G17FE1"].ToString();
                TextBox703.Text = r3["G17FE1_4"].ToString();
                TextBox704.Text = r3["G17FE5_9"].ToString();
                TextBox705.Text = r3["G17FE10_14"].ToString();
                TextBox706.Text = r3["G17FE15_19"].ToString();
                TextBox707.Text = r3["G17FE20_24"].ToString();
                TextBox708.Text = r3["G17FE25_49"].ToString();
                TextBox709.Text = r3["G17FE50"].ToString();
                TextBox710.Text = r3["TOTALG18"].ToString();
                TextBox711.Text = r3["SUBG18MA"].ToString();
                TextBox713.Text = r3["G18MA1"].ToString();
                TextBox714.Text = r3["G18MA1_4"].ToString();
                TextBox715.Text = r3["G18MA5_9"].ToString();
                TextBox716.Text = r3["G18MA10_14"].ToString();
                TextBox717.Text = r3["G18MA15_19"].ToString();
                TextBox718.Text = r3["G18MA20_24"].ToString();
                TextBox719.Text = r3["G18MA25_49"].ToString();
                TextBox720.Text = r3["G18MA50"].ToString();
                TextBox712.Text = r3["SUBG18FE"].ToString();
                TextBox721.Text = r3["G18FE1"].ToString();
                TextBox722.Text = r3["G18FE1_4"].ToString();
                TextBox723.Text = r3["G18FE5_9"].ToString();
                TextBox724.Text = r3["G18FE10_14"].ToString();
                TextBox725.Text = r3["G18FE15_19"].ToString();
                TextBox726.Text = r3["G18FE20_24"].ToString();
                TextBox727.Text = r3["G18FE25_49"].ToString();
                TextBox728.Text = r3["G18FE50"].ToString();
                TextBox729.Text = r3["TOTALG19"].ToString();
                TextBox730.Text = r3["SUBG19MA"].ToString();
                TextBox307.Text = r3["G19MA1"].ToString();
                TextBox308.Text = r3["G19MA1_4"].ToString();
                TextBox309.Text = r3["G19MA5_9"].ToString();
                TextBox310.Text = r3["G19MA10_14"].ToString();
                TextBox311.Text = r3["G19MA15_19"].ToString();
                TextBox312.Text = r3["G19MA20_24"].ToString();
                TextBox313.Text = r3["G19MA25_49"].ToString();
                TextBox314.Text = r3["G19MA50"].ToString();
                TextBox731.Text = r3["SUBG19FE"].ToString();
                TextBox315.Text = r3["G19FE1"].ToString();
                TextBox732.Text = r3["G19FE1_4"].ToString();
                TextBox733.Text = r3["G19FE5_9"].ToString();
                TextBox734.Text = r3["G19FE10_14"].ToString();
                TextBox735.Text = r3["G19FE15_19"].ToString();
                TextBox736.Text = r3["G19FE20_24"].ToString();
                TextBox737.Text = r3["G19FE25_49"].ToString();
                TextBox738.Text = r3["G19FE50"].ToString();
                TextBox739.Text = r3["TOTALG20"].ToString();
                TextBox740.Text = r3["SUBG20MA"].ToString();
                TextBox741.Text = r3["G20MA1"].ToString();
                TextBox742.Text = r3["G20MA1_4"].ToString();
                TextBox743.Text = r3["G20MA5_9"].ToString();
                TextBox744.Text = r3["G20MA10_14"].ToString();
                TextBox745.Text = r3["G20MA15_19"].ToString();
                TextBox746.Text = r3["G20MA20_24"].ToString();
                TextBox747.Text = r3["G20MA25_49"].ToString();
                TextBox748.Text = r3["G20MA50"].ToString();
                TextBox749.Text = r3["SUBG20FE"].ToString();
                TextBox750.Text = r3["G20FE1"].ToString();
                TextBox751.Text = r3["G20FE1_4"].ToString();
                TextBox752.Text = r3["G20FE5_9"].ToString();
                TextBox753.Text = r3["G20FE10_14"].ToString();
                TextBox754.Text = r3["G20FE15_19"].ToString();
                TextBox755.Text = r3["G20FE20_24"].ToString();
                TextBox756.Text = r3["G20FE25_49"].ToString();
                TextBox757.Text = r3["G20FE50"].ToString();
                TextBox758.Text = r3["TOTALG21"].ToString();
                TextBox759.Text = r3["SUBG21MA"].ToString();
                TextBox761.Text = r3["G21MA1"].ToString();
                TextBox762.Text = r3["G21MA1_4"].ToString();
                TextBox763.Text = r3["G21MA5_9"].ToString();
                TextBox764.Text = r3["G21MA10_14"].ToString();
                TextBox765.Text = r3["G21MA15_19"].ToString();
                TextBox766.Text = r3["G21MA20_24"].ToString();
                TextBox767.Text = r3["G21MA25_49"].ToString();
                TextBox768.Text = r3["G21MA50"].ToString();
                TextBox760.Text = r3["SUBG21FE"].ToString();
                TextBox769.Text = r3["G21FE1"].ToString();
                TextBox770.Text = r3["G21FE1_4"].ToString();
                TextBox771.Text = r3["G21FE5_9"].ToString();
                TextBox772.Text = r3["G21FE10_14"].ToString();
                TextBox773.Text = r3["G21FE15_19"].ToString();
                TextBox774.Text = r3["G21FE20_24"].ToString();
                TextBox775.Text = r3["G21FE25_49"].ToString();
                TextBox776.Text = r3["G21FE50"].ToString();

                t3 = 1;
            }

            if (t1 != -1 && t2 != -1 && t3 != -1)
            {
                Session["Edit"] = "T";
                    return;
            }
        }catch(Exception ex)
        {
            webMessage.Show("ERROR TB Edit record " + ex.Message.Trim());
            return;
        }
    }
    //======= INSERTING INTO tbl_TB1 and TB2 and TB3
    protected void SAVE_TB()
    {
        if (!string.IsNullOrEmpty(Session["Edit"].ToString()))
        {
            if (Session["Edit"].ToString() != "T")
            {
                //============ INSERT NEW RECORD ========
                string sql = "INSERT INTO tbl_TB1 (states,	lga,	facname,	months, 	years, 	grouptype, 	TOTALG1, 	SUBG1MA,";
                sql += "G1MA1,	G1MA1_4,	G1MA5_9,	G1MA10_14,	G1MA15_19,	G1MA20_24,	G1MA25_49,	G1MA50,	SUBG1FE,G1FE1,";
                sql += "G1FE1_4,	G1FE5_9,	G1FE10_14,	G1FE15_19,	G1FE20_24,	G1FE25_49,	G1FE50,	POS_G1STOTAL,	POS_SUBG1MA,";
                sql += "POS_G1MA1,	POS_G1MA1_4,	POS_G1MA5_9,	POS_G1MA10_14,	POS_G1MA15_19,	POS_G1MA20_24,	POS_G1MA25_49,";
                sql += "POS_G1MA50,	POS_SUBG1FE,	POS_G1FE1,	POS_G1FE1_4,	POS_G1FE5_9,	POS_G1FE10_14,	POS_G1FE15_19,";
                sql += "POS_G1FE20_24,	POS_G1FE25_49,	POS_G1FE50,	NEG_G1TOTAL,	NEG_SUBG1MA,	NEG_G1MA1,	NEG_G1MA1_4,NEG_G1MA5_9,";
                sql += "NEG_G1MA10_14,	NEG_G1MA15_19,	NEG_G1MA20_24,	NEG_G1MA25_49,	NEG_G1MA50,	NEG_SUBG1FE,NEG_G1FE1,	NEG_G1FE1_4,";
                sql += "NEG_G1FE5_9,	NEG_G1FE10_14,	NEG_G1FE15_19,	NEG_G1FE20_24,	NEG_G1FE25_49,	NEG_G1FE50,	TOTALG2,	SUBG2MA,	G2MA1,";
                sql += "G2MA1_4, G2MA5_9,	G2MA15_19,	G2MA20_24,	G2MA25_49,	G2MA50,	SUBG2FE,	G2FE1,	G2FE1_4,	G2FE5_9,	G2FE10_14,";
                sql += "G2FE15_19,	G2FE20_24,	G2FE25_49,	G2FE50,	POS_G2STOTAL,	POS_SUBG2MA,	POS_G2MA1,	POS_G2MA1_4,	POS_G2MA5_9,";
                sql += "POS_G2MA10_14,	POS_G2MA15_19,	POS_G2MA20_24,	POS_G2MA25_49,	POS_G2MA50,	POS_SUBG2FE,	POS_G2FE1,	POS_G2FE1_4,";
                sql += "POS_G2FE5_9,	POS_G2FE10_14,	POS_G2FE15_19,	POS_G2FE20_24,	POS_G2FE25_49,	POS_G2FE50,	NEG_G2TOTAL,	NEG_SUBG2MA,";
                sql += "NEG_G2MA1,	NEG_G2MA1_4,	NEG_G2MA5_9,	NEG_G2MA10_14,	NEG_G2MA15_19,	NEG_G2MA20_24,	NEG_G2MA25_49,	NEG_G2MA50,";
                sql += "NEG_SUBG2FE,	NEG_G2FE1,	NEG_G2FE1_4,	NEG_G2FE5_9,	NEG_G2FE10_14,	NEG_G2FE15_19,	NEG_G2FE20_24,	NEG_G2FE25_49,";
                sql += "NEG_G2FE50,	TOTALG3,	SUBG3MA,	G3MA1,	G3MA1_4,	G3MA5_9,	G3MA10_14,	G3MA15_19,	G3MA20_24,	G3MA25_49,	G3MA50,";
                sql += "SUBG3FE,	G3FE1,	G3FE1_4,	G3FE5_9,	G3FE10_14,	G3FE15_19,	G3FE20_24,	G3FE25_49,	G3FE50,	TOTALG4,	SUBG4MA,	G4MA1,";
                sql += "G4MA1_4,	G4MA5_9,	G4MA10_14,	G4MA15_19,	G4MA20_24,	G4MA25_49,	G4MA50,	SUBG4FE,	G4FE1,	G4FE1_4,	G4FE5_9,	G4FE10_14,";
                sql += "G4FE15_19,	G4FE20_24,	G4FE25_49,	G4FE50,	TOTALG5,	SUBG5MA,	G5MA1,	G5MA1_4,	G5MA5_9,	G5MA10_14)";
                sql += " VALUES(@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1,@SUBG1MA,";
                sql += "@G1MA1,	@G1MA1_4,	@G1MA5_9,	@G1MA10_14,	@G1MA15_19,	@G1MA20_24,	@G1MA25_49,	@G1MA50,";
                sql += "@SUBG1FE,	@G1FE1,	@G1FE1_4,	@G1FE5_9,	@G1FE10_14,	@G1FE15_19,	@G1FE20_24,@G1FE25_49,@G1FE50,";
                sql += "@POS_G1STOTAL,	@POS_SUBG1MA,	@POS_G1MA1,	@POS_G1MA1_4,	@POS_G1MA5_9,@POS_G1MA10_14,@POS_G1MA15_19,";
                sql += "@POS_G1MA20_24,	@POS_G1MA25_49,	@POS_G1MA50,	@POS_SUBG1FE,	@POS_G1FE1,	@POS_G1FE1_4,";
                sql += "@POS_G1FE5_9,	@POS_G1FE10_14,	@POS_G1FE15_19,	@POS_G1FE20_24,	@POS_G1FE25_49,	@POS_G1FE50,";
                sql += "@NEG_G1TOTAL,	@NEG_SUBG1MA,	@NEG_G1MA1,	@NEG_G1MA1_4,	@NEG_G1MA5_9,	@NEG_G1MA10_14,	@NEG_G1MA15_19,	";
                sql += "@NEG_G1MA20_24,	@NEG_G1MA25_49,	@NEG_G1MA50,	@NEG_SUBG1FE,	@NEG_G1FE1,	@NEG_G1FE1_4,	@NEG_G1FE5_9,";
                sql += "@NEG_G1FE10_14,	@NEG_G1FE15_19,	@NEG_G1FE20_24,	@NEG_G1FE25_49,	@NEG_G1FE50,	@TOTALG2,	@SUBG2MA,";
                sql += "@G2MA1,	@G2MA1_4,	@G2MA5_9,	@G2MA15_19,	@G2MA20_24,	@G2MA25_49,	@G2MA50,	@SUBG2FE,";
                sql += "@G2FE1,	@G2FE1_4,	@G2FE5_9,	@G2FE10_14,	@G2FE15_19,	@G2FE20_24,	@G2FE25_49,	@G2FE50,";
                sql += "@POS_G2STOTAL,	@POS_SUBG2MA,	@POS_G2MA1,	@POS_G2MA1_4,	@POS_G2MA5_9,	@POS_G2MA10_14,	@POS_G2MA15_19,";
                sql += "@POS_G2MA20_24,	@POS_G2MA25_49,	@POS_G2MA50,	@POS_SUBG2FE,	@POS_G2FE1,	@POS_G2FE1_4,	@POS_G2FE5_9,";
                sql += "@POS_G2FE10_14,	@POS_G2FE15_19,	@POS_G2FE20_24,	@POS_G2FE25_49,	@POS_G2FE50,	@NEG_G2TOTAL,	@NEG_SUBG2MA,";
                sql += "@NEG_G2MA1,	@NEG_G2MA1_4,	@NEG_G2MA5_9,	@NEG_G2MA10_14,	@NEG_G2MA15_19,	@NEG_G2MA20_24,	@NEG_G2MA25_49,";
                sql += "@NEG_G2MA50,	@NEG_SUBG2FE,	@NEG_G2FE1,	@NEG_G2FE1_4,	@NEG_G2FE5_9,	@NEG_G2FE10_14,	@NEG_G2FE15_19,";
                sql += "@NEG_G2FE20_24,	@NEG_G2FE25_49,	@NEG_G2FE50,	@TOTALG3,	@SUBG3MA,	@G3MA1,	@G3MA1_4,	@G3MA5_9,";
                sql += "@G3MA10_14,	@G3MA15_19,	@G3MA20_24,	@G3MA25_49,	@G3MA50,	@SUBG3FE,	@G3FE1,	@G3FE1_4,";
                sql += "@G3FE5_9,	@G3FE10_14,	@G3FE15_19,	@G3FE20_24,	@G3FE25_49,	@G3FE50,	@TOTALG4,";
                sql += "@SUBG4MA,	@G4MA1,	@G4MA1_4,	@G4MA5_9,	@G4MA10_14,	@G4MA15_19,	@G4MA20_24,	";
                sql += "@G4MA25_49,	@G4MA50,	@SUBG4FE,	@G4FE1,	@G4FE1_4,	@G4FE5_9,	@G4FE10_14,";
                sql += "@G4FE15_19,	@G4FE20_24,	@G4FE25_49,	@G4FE50,	@TOTALG5,	@SUBG5MA,	@G5MA1,	@G5MA1_4,@G5MA5_9,	@G5MA10_14)";

                // =================== INSERTION FOR TABLE 2 =====================
                string sql1 = "INSERT INTO tbl_TB2 (states,lga,facname,months,years,	grouptype,	G5MA15_19,	G5MA20_24,	G5MA25_49,";
                sql1 += "G5MA50,	SUBG5FE,	G5FE1,	G5FE1_4,	G5FE5_9,	G5FE10_14,	G5FE15_19,	G5FE20_24,	G5FE25_49,	G5FE50,";
                sql1 += "TOTALG6,	SUBG6MA,	G6MA1,	G6MA1_4,	G6MA5_9,	G6MA10_14,	G6MA15_19,	G6MA20_24,	G6MA25_49,	G6MA50,";
                sql1 += "SUBG6FE,	G6FE1,	G6FE1_4,	G6FE5_9,	G6FE10_14,	G6FE15_19,	G6FE20_24,	G6FE25_49,	G6FE50,	TOTALG7,";
                sql1 += "SUBG7MA,	G7MA1,	G7MA1_4,	G7MA5_9,	G7MA10_14,	G7MA15_19,	G7MA20_24,	G7MA25_49,	G7MA50,	SUBG7FE,";
                sql1 += "G7FE1,	G7FE1_4,	G7FE5_9,	G7FE10_14,	G7FE15_19,	G7FE20_24,	G7FE25_49,	G7FE50,	TOTALG8,	SUBG8MA,";
                sql1 += "G8MA1,	G8MA1_4,	G8MA5_9,	G8MA10_14,	G8MA15_19,	G8MA20_24,	G8MA25_49,	G8MA50,	SUBG8FE,	G8FE1,	G8FE1_4,";
                sql1 += "G8FE5_9,	G8FE10_14,	G8FE15_19,	G8FE20_24,	G8FE25_49,	G8FE50,	TOTALG9,	SUBG9MA,	G9MA1,	G9MA1_4,	G9MA5_9,";
                sql1 += "G9MA10_14,	G9MA15_19,	G9MA20_24,	G9MA25_49,	G9MA50,	SUBG9FE,	G9FE1,	G9FE1_4,	G9FE5_9,	G9FE10_14,	G9FE15_19,";
                sql1 += "G9FE20_24,	G9FE25_49,	G9FE50,	TOTALG10,	SUBG10MA,	G10MA1,	G10MA1_4,	G10MA5_9,	G10MA10_14,	G10MA15_19,";
                sql1 += "G10MA20_24,	G10MA25_49,	G10MA50,	SUBG10FE,	G10FE1,	G10FE1_4,	G10FE5_9,	G10FE10_14,	G10FE15_19,";
                sql1 += "G10FE20_24,	G10FE25_49,	G10FE50,	TOTALG11,	SUBG11MA,	G11MA1,	G11MA1_4,	G11MA5_9,	G11MA10_14,G11MA15_19,";
                sql1 += "G11MA20_24,	G11MA25_49,	G11MA50,	SUBG11FE,	G11FE1,	G11FE1_4,	G11FE5_9,	G11FE10_14,	G11FE15_19,G11FE20_24,";
                sql1 += "G11FE25_49,	G11FE50,	TOTALG12,	SUBG12MA,	G12MA1,	G12MA1_4,	G12MA5_9,	G12MA10_14,	G12MA15_19,	G12MA20_24,";
                sql1 += "G12MA25_49,	G12MA50,	SUBG12FE,	G12FE1,	G12FE1_4,	G12FE5_9,	G12FE10_14,	G12FE15_19,	G12FE20_24,	G12FE25_49,";
                sql1 += "G12FE50,	TOTALG13,	SUBG13MA,	G13MA1,	G13MA1_4,	G13MA5_9,	G13MA10_14,	G13MA15_19,	G13MA20_24,	G13MA25_49,G13MA50,";
                sql1 += "SUBG13FE,	G13FE1)";
                sql1 += "VALUES(@states,	@lga,	@facname,	@months,	@years,	@grouptype,	@G5MA15_19,	@G5MA20_24,";
                sql1 += "@G5MA25_49,	@G5MA50,	@SUBG5FE,	@G5FE1,	@G5FE1_4,	@G5FE5_9,	@G5FE10_14,";
                sql1 += "@G5FE15_19,	@G5FE20_24,	@G5FE25_49,	@G5FE50,	@TOTALG6,	@SUBG6MA,	@G6MA1,	@G6MA1_4,";
                sql1 += "@G6MA5_9,	@G6MA10_14,	@G6MA15_19,	@G6MA20_24,	@G6MA25_49,	@G6MA50,	@SUBG6FE,";
                sql1 += "@G6FE1,	@G6FE1_4,	@G6FE5_9,	@G6FE10_14,	@G6FE15_19,	@G6FE20_24,	@G6FE25_49,	@G6FE50,";
                sql1 += "@TOTALG7,	@SUBG7MA,	@G7MA1,	@G7MA1_4,	@G7MA5_9,	@G7MA10_14,	@G7MA15_19,";
                sql1 += "@G7MA20_24,	@G7MA25_49,	@G7MA50,	@SUBG7FE,	@G7FE1,	@G7FE1_4,	@G7FE5_9,";
                sql1 += "@G7FE10_14,	@G7FE15_19,	@G7FE20_24,	@G7FE25_49,	@G7FE50,	@TOTALG8,	@SUBG8MA,";
                sql1 += "@G8MA1,	@G8MA1_4,	@G8MA5_9,	@G8MA10_14,	@G8MA15_19,	@G8MA20_24,	@G8MA25_49,	@G8MA50,";
                sql1 += "@SUBG8FE,	@G8FE1,	@G8FE1_4,	@G8FE5_9,	@G8FE10_14,	@G8FE15_19,	@G8FE20_24,";
                sql1 += "@G8FE25_49,	@G8FE50,	@TOTALG9,	@SUBG9MA,	@G9MA1,	@G9MA1_4,	@G9MA5_9,	";
                sql1 += "@G9MA10_14,	@G9MA15_19,	@G9MA20_24,	@G9MA25_49,	@G9MA50,	@SUBG9FE,	@G9FE1,	@G9FE1_4,";
                sql1 += "@G9FE5_9,	@G9FE10_14,	@G9FE15_19,	@G9FE20_24,	@G9FE25_49,	@G9FE50,	@TOTALG10,";
                sql1 += "@SUBG10MA,	@G10MA1,	@G10MA1_4,	@G10MA5_9,	@G10MA10_14,	@G10MA15_19,	@G10MA20_24,";
                sql1 += "@G10MA25_49,	@G10MA50,	@SUBG10FE,	@G10FE1,	@G10FE1_4,	@G10FE5_9,	@G10FE10_14,";
                sql1 += "@G10FE15_19,	@G10FE20_24,	@G10FE25_49,	@G10FE50,	@TOTALG11,	@SUBG11MA,	@G11MA1,";
                sql1 += "@G11MA1_4,	@G11MA5_9,	@G11MA10_14,	@G11MA15_19,	@G11MA20_24,	@G11MA25_49,	@G11MA50,";
                sql1 += "@SUBG11FE,	@G11FE1,	@G11FE1_4,	@G11FE5_9,	@G11FE10_14,	@G11FE15_19,	@G11FE20_24,";
                sql1 += "@G11FE25_49,	@G11FE50,	@TOTALG12,	@SUBG12MA,	@G12MA1,	@G12MA1_4,	@G12MA5_9,";
                sql1 += "@G12MA10_14,	@G12MA15_19,	@G12MA20_24,	@G12MA25_49,	@G12MA50,	@SUBG12FE,	@G12FE1,";
                sql1 += "@G12FE1_4,	@G12FE5_9,	@G12FE10_14,	@G12FE15_19,	@G12FE20_24,	@G12FE25_49,	@G12FE50,";
                sql1 += "@TOTALG13,	@SUBG13MA,	@G13MA1,	@G13MA1_4,	@G13MA5_9,	@G13MA10_14,	@G13MA15_19,";
                sql1 += "@G13MA20_24,	@G13MA25_49,	@G13MA50,	@SUBG13FE,	@G13FE1)";

                // =================== INSERTION FOR TABLE 3 =====================
                string sql2 = "INSERT INTO tbl_TB3 (states,lga,facname,	months,	years,	grouptype,	G13FE1_4,	G13FE5_9,";
                sql2 += "G13FE10_14,	G13FE15_19,	G13FE20_24,	G13FE25_49,	G13FE50,	TOTALG14,	SUBG14MA,	G14MA1,";
                sql2 += "G14MA1_4,	G14MA5_9,	G14MA10_14,	G14MA15_19,	G14MA20_24,	G14MA25_49,	G14MA50,	SUBG14FE,";
                sql2 += "G14FE1,	G14FE1_4,	G14FE5_9,	G14FE10_14,	G14FE15_19,	G14FE20_24,	G14FE25_49,	G14FE50,";
                sql2 += "TOTALG15,	SUBG15MA,	G15MA1,	G15MA1_4,	G15MA5_9,	G15MA10_14,	G15MA15_19,	G15MA20_24,G15MA25_49,";
                sql2 += "G15MA50,	SUBG15FE,	G15FE1,	G15FE1_4,	G15FE5_9,	G15FE10_14,	G15FE15_19,	G15FE20_24,G15FE25_49,";
                sql2 += "G15FE50,	TOTALG16,	SUBG16MA,	G16MA1,	G16MA1_4,	G16MA5_9,	G16MA10_14,	G16MA15_19,G16MA20_24,G16MA25_49,";
                sql2 += "G16MA50,	SUBG16FE,	G16FE1,	G16FE5_9,	G16FE10_14,	G16FE15_19,	G16FE20_24,	G16FE25_49,	G16FE50,";
                sql2 += "TOTALG17,	SUBG17MA,	G17MA1,	G17MA1_4,	G17MA5_9,	G17MA10_14,	G17MA15_19,	G17MA20_24,	G17MA25_49,";
                sql2 += "G17MA50,	SUBG17FE,	G17FE1,	G17FE1_4,	G17FE5_9,	G17FE10_14,	G17FE15_19,	G17FE20_24,	G17FE25_49,";
                sql2 += "G17FE50,	TOTALG18,	SUBG18MA,	G18MA1,	G18MA1_4,	G18MA5_9,	G18MA10_14,	G18MA15_19,G18MA20_24,G18MA25_49,";
                sql2 += "G18MA50,	SUBG18FE,	G18FE1,	G18FE1_4,	G18FE5_9,	G18FE10_14,	G18FE15_19,	G18FE20_24,	G18FE25_49,G18FE50,";
                sql2 += "TOTALG19,	SUBG19MA,	G19MA1,	G19MA1_4,	G19MA5_9,	G19MA10_14,	G19MA15_19,	G19MA20_24,	G19MA25_49,G19MA50,";
                sql2 += "SUBG19FE,	G19FE1,	G19FE1_4,	G19FE5_9,	G19FE10_14,	G19FE15_19,	G19FE20_24,	G19FE25_49,	G19FE50,	TOTALG20,";
                sql2 += "SUBG20MA,	G20MA1,	G20MA1_4,	G20MA5_9,	G20MA10_14,	G20MA15_19,	G20MA20_24,	G20MA25_49,	G20MA50,	SUBG20FE,";
                sql2 += "G20FE1,	G20FE1_4,	G20FE5_9,	G20FE10_14,	G20FE15_19,	G20FE20_24,	G20FE25_49,	G20FE50,	TOTALG21,	SUBG21MA,";
                sql2 += "G21MA1,	G21MA1_4,	G21MA5_9,	G21MA10_14,	G21MA15_19,	G21MA20_24,	G21MA25_49,	G21MA50,	SUBG21FE,	G21FE1,G21FE1_4,";
                sql2 += "G21FE5_9,	G21FE10_14,	G21FE15_19,	G21FE20_24,	G21FE25_49,	G21FE50)";
                sql2 += "VALUES(@states,	@lga,	@facname,	@months,	@years,	@grouptype,	@G13FE1_4,	@G13FE5_9,";
                sql2 += "@G13FE10_14,	@G13FE15_19,	@G13FE20_24,	@G13FE25_49,	@G13FE50,	@TOTALG14,	@SUBG14MA,";
                sql2 += "@G14MA1,	@G14MA1_4,	@G14MA5_9,	@G14MA10_14,	@G14MA15_19,	@G14MA20_24,	@G14MA25_49,";
                sql2 += "@G14MA50,	@SUBG14FE,	@G14FE1,	@G14FE1_4,	@G14FE5_9,	@G14FE10_14,	@G14FE15_19,";
                sql2 += "@G14FE20_24,	@G14FE25_49,	@G14FE50,	@TOTALG15,	@SUBG15MA,	@G15MA1,	@G15MA1_4,";
                sql2 += "@G15MA5_9,	@G15MA10_14,	@G15MA15_19,	@G15MA20_24,	@G15MA25_49,	@G15MA50,	@SUBG15FE,";
                sql2 += "@G15FE1,	@G15FE1_4,	@G15FE5_9,	@G15FE10_14,	@G15FE15_19,	@G15FE20_24,	@G15FE25_49,";
                sql2 += "@G15FE50,	@TOTALG16,	@SUBG16MA,	@G16MA1,	@G16MA1_4,	@G16MA5_9,	@G16MA10_14,";
                sql2 += "@G16MA15_19,	@G16MA20_24,	@G16MA25_49,	@G16MA50,	@SUBG16FE,	@G16FE1,	@G16FE5_9,";
                sql2 += "@G16FE10_14,	@G16FE15_19,	@G16FE20_24,	@G16FE25_49,	@G16FE50,	@TOTALG17,	@SUBG17MA,";
                sql2 += "@G17MA1,	@G17MA1_4,	@G17MA5_9,	@G17MA10_14,	@G17MA15_19,	@G17MA20_24,	@G17MA25_49,";
                sql2 += "@G17MA50,	@SUBG17FE,	@G17FE1,	@G17FE1_4,	@G17FE5_9,	@G17FE10_14,	@G17FE15_19,";
                sql2 += "@G17FE20_24,	@G17FE25_49,	@G17FE50,	@TOTALG18,	@SUBG18MA,	@G18MA1,	@G18MA1_4,	";
                sql2 += "@G18MA5_9,	@G18MA10_14,	@G18MA15_19,	@G18MA20_24,	@G18MA25_49,	@G18MA50,	@SUBG18FE,";
                sql2 += "@G18FE1,	@G18FE1_4,	@G18FE5_9,	@G18FE10_14,	@G18FE15_19,	@G18FE20_24,	@G18FE25_49,";
                sql2 += "@G18FE50,	@TOTALG19,	@SUBG19MA,	@G19MA1,	@G19MA1_4,	@G19MA5_9,	@G19MA10_14,";
                sql2 += "@G19MA15_19,	@G19MA20_24,	@G19MA25_49,	@G19MA50,	@SUBG19FE,	@G19FE1,	@G19FE1_4,";
                sql2 += "@G19FE5_9,	@G19FE10_14,	@G19FE15_19,	@G19FE20_24,	@G19FE25_49,	@G19FE50,	@TOTALG20,";
                sql2 += "@SUBG20MA,	@G20MA1,	@G20MA1_4,	@G20MA5_9,	@G20MA10_14,	@G20MA15_19,	@G20MA20_24,";
                sql2 += "@G20MA25_49,	@G20MA50,	@SUBG20FE,	@G20FE1,	@G20FE1_4,	@G20FE5_9,	@G20FE10_14,";
                sql2 += "@G20FE15_19,	@G20FE20_24,	@G20FE25_49,	@G20FE50,	@TOTALG21,	@SUBG21MA,	@G21MA1,";
                sql2 += "@G21MA1_4,	@G21MA5_9,	@G21MA10_14,	@G21MA15_19,	@G21MA20_24,	@G21MA25_49,	@G21MA50,";
                sql2 += "@SUBG21FE,	@G21FE1,	@G21FE1_4,	@G21FE5_9,	@G21FE10_14,	@G21FE15_19,	@G21FE20_24,@G21FE25_49,	@G21FE50)";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox330.Text.Trim();
                    cmd.Parameters.AddWithValue("@Subg1ma", SqlDbType.Int).Value = TextBox331.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox332.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox333.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox334.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox335.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA15_19", SqlDbType.Int).Value = TextBox336.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA20_24", SqlDbType.Int).Value = TextBox337.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA25_49", SqlDbType.Int).Value = TextBox338.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1MA50", SqlDbType.Int).Value = TextBox339.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox348.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox340.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox341.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox342.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox343.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE15_19", SqlDbType.Int).Value = TextBox344.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE20_24", SqlDbType.Int).Value = TextBox345.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE25_49", SqlDbType.Int).Value = TextBox346.Text.Trim();
                    cmd.Parameters.AddWithValue("@G1FE50", SqlDbType.Int).Value = TextBox347.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1STOTAL", SqlDbType.Int).Value = TextBox349.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_SUBG1MA", SqlDbType.Int).Value = TextBox350.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA1", SqlDbType.Int).Value = TextBox351.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA1_4", SqlDbType.Int).Value = TextBox352.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA5_9", SqlDbType.Int).Value = TextBox353.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA10_14", SqlDbType.Int).Value = TextBox354.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA15_19", SqlDbType.Int).Value = TextBox355.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA20_24", SqlDbType.Int).Value = TextBox356.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA25_49", SqlDbType.Int).Value = TextBox357.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1MA50", SqlDbType.Int).Value = TextBox358.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_SUBG1FE", SqlDbType.Int).Value = TextBox359.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE1", SqlDbType.Int).Value = TextBox360.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE1_4", SqlDbType.Int).Value = TextBox361.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE5_9", SqlDbType.Int).Value = TextBox362.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE10_14", SqlDbType.Int).Value = TextBox363.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE15_19", SqlDbType.Int).Value = TextBox364.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE20_24", SqlDbType.Int).Value = TextBox365.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE25_49", SqlDbType.Int).Value = TextBox366.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G1FE50", SqlDbType.Int).Value = TextBox367.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1TOTAL", SqlDbType.Int).Value = TextBox368.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_SUBG1MA", SqlDbType.Int).Value = TextBox369.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA1", SqlDbType.Int).Value = TextBox370.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA1_4", SqlDbType.Int).Value = TextBox371.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA5_9", SqlDbType.Int).Value = TextBox372.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA10_14", SqlDbType.Int).Value = TextBox373.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA15_19", SqlDbType.Int).Value = TextBox374.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA20_24", SqlDbType.Int).Value = TextBox375.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA25_49", SqlDbType.Int).Value = TextBox376.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1MA50", SqlDbType.Int).Value = TextBox377.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_SUBG1FE", SqlDbType.Int).Value = TextBox378.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE1", SqlDbType.Int).Value = TextBox379.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE1_4", SqlDbType.Int).Value = TextBox380.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE5_9", SqlDbType.Int).Value = TextBox381.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE10_14", SqlDbType.Int).Value = TextBox382.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE15_19", SqlDbType.Int).Value = TextBox383.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE20_24", SqlDbType.Int).Value = TextBox384.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE25_49", SqlDbType.Int).Value = TextBox385.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G1FE50", SqlDbType.Int).Value = TextBox386.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox387.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox388.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox390.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox391.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox392.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox393.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA15_19", SqlDbType.Int).Value = TextBox394.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA20_24", SqlDbType.Int).Value = TextBox395.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA25_49", SqlDbType.Int).Value = TextBox396.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2MA50", SqlDbType.Int).Value = TextBox397.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox389.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox398.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox399.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox400.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox401.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE15_19", SqlDbType.Int).Value = TextBox402.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE20_24", SqlDbType.Int).Value = TextBox403.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE25_49", SqlDbType.Int).Value = TextBox404.Text.Trim();
                    cmd.Parameters.AddWithValue("@G2FE50", SqlDbType.Int).Value = TextBox405.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2STOTAL", SqlDbType.Int).Value = TextBox406.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_SUBG2MA", SqlDbType.Int).Value = TextBox407.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA1", SqlDbType.Int).Value = TextBox408.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA1_4", SqlDbType.Int).Value = TextBox409.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA5_9", SqlDbType.Int).Value = TextBox410.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA10_14", SqlDbType.Int).Value = TextBox411.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA15_19", SqlDbType.Int).Value = TextBox412.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA20_24", SqlDbType.Int).Value = TextBox413.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA25_49", SqlDbType.Int).Value = TextBox414.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2MA50", SqlDbType.Int).Value = TextBox415.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_SUBG2FE", SqlDbType.Int).Value = TextBox424.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE1", SqlDbType.Int).Value = TextBox416.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE1_4", SqlDbType.Int).Value = TextBox417.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE5_9", SqlDbType.Int).Value = TextBox418.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE10_14", SqlDbType.Int).Value = TextBox419.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE15_19", SqlDbType.Int).Value = TextBox420.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE20_24", SqlDbType.Int).Value = TextBox421.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE25_49", SqlDbType.Int).Value = TextBox425.Text.Trim();
                    cmd.Parameters.AddWithValue("@POS_G2FE50", SqlDbType.Int).Value = TextBox423.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2TOTAL", SqlDbType.Int).Value = TextBox425.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_SUBG2MA", SqlDbType.Int).Value = TextBox426.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA1", SqlDbType.Int).Value = TextBox427.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA1_4", SqlDbType.Int).Value = TextBox428.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA5_9", SqlDbType.Int).Value = TextBox429.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA10_14", SqlDbType.Int).Value = TextBox430.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA15_19", SqlDbType.Int).Value = TextBox431.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA20_24", SqlDbType.Int).Value = TextBox432.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA25_49", SqlDbType.Int).Value = TextBox433.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2MA50", SqlDbType.Int).Value = TextBox434.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_SUBG2FE", SqlDbType.Int).Value = TextBox443.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE1", SqlDbType.Int).Value = TextBox435.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE1_4", SqlDbType.Int).Value = TextBox436.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE5_9", SqlDbType.Int).Value = TextBox437.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE10_14", SqlDbType.Int).Value = TextBox438.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE15_19", SqlDbType.Int).Value = TextBox439.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE20_24", SqlDbType.Int).Value = TextBox440.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE25_49", SqlDbType.Int).Value = TextBox441.Text.Trim();
                    cmd.Parameters.AddWithValue("@NEG_G2FE50", SqlDbType.Int).Value = TextBox442.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox444.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox445.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox446.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox447.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox448.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox449.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA15_19", SqlDbType.Int).Value = TextBox450.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA20_24", SqlDbType.Int).Value = TextBox451.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA25_49", SqlDbType.Int).Value = TextBox452.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3MA50", SqlDbType.Int).Value = TextBox453.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox454.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox455.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox456.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox457.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox458.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE15_19", SqlDbType.Int).Value = TextBox459.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE20_24", SqlDbType.Int).Value = TextBox460.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE25_49", SqlDbType.Int).Value = TextBox461.Text.Trim();
                    cmd.Parameters.AddWithValue("@G3FE50", SqlDbType.Int).Value = TextBox462.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox463.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox464.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox465.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox466.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox467.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox468.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA15_19", SqlDbType.Int).Value = TextBox469.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA20_24", SqlDbType.Int).Value = TextBox470.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA25_49", SqlDbType.Int).Value = TextBox471.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4MA50", SqlDbType.Int).Value = TextBox472.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox481.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox473.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox474.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox475.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox476.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE15_19", SqlDbType.Int).Value = TextBox477.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE20_24", SqlDbType.Int).Value = TextBox478.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE25_49", SqlDbType.Int).Value = TextBox479.Text.Trim();
                    cmd.Parameters.AddWithValue("@G4FE50", SqlDbType.Int).Value = TextBox480.Text.Trim();
                    cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox482.Text.Trim();
                    cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox483.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox485.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox486.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox487.Text.Trim();
                    cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox488.Text.Trim();
                    int Rowsaffected1 = cmd.ExecuteNonQuery();
                    //==================================== INSERT INTO tbl_TB2
                    SqlCommand cmd1 = new SqlCommand(sql1, cn);
                    cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd1.Parameters.AddWithValue("@G5MA15_19", SqlDbType.Int).Value = TextBox489.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5MA20_24", SqlDbType.Int).Value = TextBox490.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5MA25_49", SqlDbType.Int).Value = TextBox491.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5MA50", SqlDbType.Int).Value = TextBox492.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox484.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE1", SqlDbType.Int).Value = TextBox493.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox494.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox495.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox496.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE15_19", SqlDbType.Int).Value = TextBox497.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE20_24", SqlDbType.Int).Value = TextBox498.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE25_49", SqlDbType.Int).Value = TextBox499.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G5FE50", SqlDbType.Int).Value = TextBox500.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox501.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox502.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox504.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox505.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox506.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox507.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA15_19", SqlDbType.Int).Value = TextBox508.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA20_24", SqlDbType.Int).Value = TextBox509.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA25_49", SqlDbType.Int).Value = TextBox510.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6MA50", SqlDbType.Int).Value = TextBox511.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox503.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox512.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox513.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox514.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox515.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE15_19", SqlDbType.Int).Value = TextBox516.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE20_24", SqlDbType.Int).Value = TextBox517.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE25_49", SqlDbType.Int).Value = TextBox518.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G6FE50", SqlDbType.Int).Value = TextBox519.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox520.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox521.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox523.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox524.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox525.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox526.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA15_19", SqlDbType.Int).Value = TextBox527.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA20_24", SqlDbType.Int).Value = TextBox528.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA25_49", SqlDbType.Int).Value = TextBox529.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7MA50", SqlDbType.Int).Value = TextBox530.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox522.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox531.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox532.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox533.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox534.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE15_19", SqlDbType.Int).Value = TextBox535.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox536.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox537.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G7FE50", SqlDbType.Int).Value = TextBox538.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox539.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox540.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox542.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox543.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox544.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox545.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA15_19", SqlDbType.Int).Value = TextBox546.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA20_24", SqlDbType.Int).Value = TextBox547.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA25_49", SqlDbType.Int).Value = TextBox548.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8MA50", SqlDbType.Int).Value = TextBox549.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox541.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox550.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox551.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox552.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox553.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE15_19", SqlDbType.Int).Value = TextBox554.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE20_24", SqlDbType.Int).Value = TextBox555.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE25_49", SqlDbType.Int).Value = TextBox556.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G8FE50", SqlDbType.Int).Value = TextBox557.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox777.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox778.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox779.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox780.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox781.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox782.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = TextBox783.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = TextBox784.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = TextBox785.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = TextBox786.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox787.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox788.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox789.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox790.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox791.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = TextBox792.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = TextBox793.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = TextBox794.Text.Trim(); //============
                    cmd1.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = TextBox795.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox558.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox559.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox560.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox561.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox562.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox563.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA15_19", SqlDbType.Int).Value = TextBox564.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA20_24", SqlDbType.Int).Value = TextBox565.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA25_49", SqlDbType.Int).Value = TextBox566.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10MA50", SqlDbType.Int).Value = TextBox567.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox576.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox568.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox569.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox570.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox571.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE15_19", SqlDbType.Int).Value = TextBox572.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE20_24", SqlDbType.Int).Value = TextBox573.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE25_49", SqlDbType.Int).Value = TextBox574.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G10FE50", SqlDbType.Int).Value = TextBox575.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox577.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox578.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox579.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox580.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox581.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox582.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = TextBox583.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = TextBox584.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = TextBox585.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = TextBox586.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox595.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox587.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox588.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox589.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox590.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = TextBox591.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = TextBox592.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = TextBox593.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = TextBox594.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox596.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG12MA", SqlDbType.Int).Value = TextBox597.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = TextBox598.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = TextBox599.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = TextBox600.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = TextBox601.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = TextBox602.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = TextBox603.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox604.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = TextBox605.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG12FE", SqlDbType.Int).Value = TextBox606.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = TextBox607.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = TextBox608.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = TextBox609.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = TextBox610.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = TextBox611.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = TextBox612.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = TextBox613.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = TextBox614.Text.Trim();
                    cmd1.Parameters.AddWithValue("@TOTALG13", SqlDbType.Int).Value = TextBox615.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG13MA", SqlDbType.Int).Value = TextBox616.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA1", SqlDbType.Int).Value = TextBox617.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA1_4", SqlDbType.Int).Value = TextBox618.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA5_9", SqlDbType.Int).Value = TextBox619.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA10_14", SqlDbType.Int).Value = TextBox620.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA15_19", SqlDbType.Int).Value = TextBox621.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA20_24", SqlDbType.Int).Value = TextBox622.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA25_49", SqlDbType.Int).Value = TextBox623.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13MA50", SqlDbType.Int).Value = TextBox624.Text.Trim();
                    cmd1.Parameters.AddWithValue("@SUBG13FE", SqlDbType.Int).Value = TextBox633.Text.Trim();
                    cmd1.Parameters.AddWithValue("@G13FE1", SqlDbType.Int).Value = TextBox625.Text.Trim();
                    int Rowsaffected2 = cmd1.ExecuteNonQuery();

                    //======================================= tbl_TB3
                    SqlCommand cmd2 = new SqlCommand(sql2, cn);
                    cmd2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd2.Parameters.AddWithValue("@G13FE1_4", SqlDbType.Int).Value = TextBox626.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G13FE5_9", SqlDbType.Int).Value = TextBox627.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G13FE10_14", SqlDbType.Int).Value = TextBox628.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G13FE15_19", SqlDbType.Int).Value = TextBox629.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G13FE20_24", SqlDbType.Int).Value = TextBox630.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G13FE25_49", SqlDbType.Int).Value = TextBox631.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G13FE50", SqlDbType.Int).Value = TextBox632.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG14", SqlDbType.Int).Value = TextBox634.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG14MA", SqlDbType.Int).Value = TextBox635.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA1", SqlDbType.Int).Value = TextBox636.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA1_4", SqlDbType.Int).Value = TextBox637.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA5_9", SqlDbType.Int).Value = TextBox638.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA10_14", SqlDbType.Int).Value = TextBox639.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA15_19", SqlDbType.Int).Value = TextBox640.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA20_24", SqlDbType.Int).Value = TextBox641.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA25_49", SqlDbType.Int).Value = TextBox642.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14MA50", SqlDbType.Int).Value = TextBox643.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG14FE", SqlDbType.Int).Value = TextBox644.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE1", SqlDbType.Int).Value = TextBox645.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE1_4", SqlDbType.Int).Value = TextBox646.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE5_9", SqlDbType.Int).Value = TextBox647.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE10_14", SqlDbType.Int).Value = TextBox648.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE15_19", SqlDbType.Int).Value = TextBox649.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE20_24", SqlDbType.Int).Value = TextBox650.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE25_49", SqlDbType.Int).Value = TextBox651.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G14FE50", SqlDbType.Int).Value = TextBox652.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG15", SqlDbType.Int).Value = TextBox653.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG15MA", SqlDbType.Int).Value = TextBox654.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA1", SqlDbType.Int).Value = TextBox655.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA1_4", SqlDbType.Int).Value = TextBox656.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA5_9", SqlDbType.Int).Value = TextBox657.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA10_14", SqlDbType.Int).Value = TextBox658.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA15_19", SqlDbType.Int).Value = TextBox659.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA20_24", SqlDbType.Int).Value = TextBox660.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA25_49", SqlDbType.Int).Value = TextBox661.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15MA50", SqlDbType.Int).Value = TextBox662.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG15FE", SqlDbType.Int).Value = TextBox671.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE1", SqlDbType.Int).Value = TextBox663.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE1_4", SqlDbType.Int).Value = TextBox664.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE5_9", SqlDbType.Int).Value = TextBox665.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE10_14", SqlDbType.Int).Value = TextBox666.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE15_19", SqlDbType.Int).Value = TextBox667.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE20_24", SqlDbType.Int).Value = TextBox668.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE25_49", SqlDbType.Int).Value = TextBox669.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G15FE50", SqlDbType.Int).Value = TextBox670.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG16", SqlDbType.Int).Value = TextBox672.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG16MA", SqlDbType.Int).Value = TextBox673.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA1", SqlDbType.Int).Value = TextBox674.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA1_4", SqlDbType.Int).Value = TextBox675.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA5_9", SqlDbType.Int).Value = TextBox676.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA10_14", SqlDbType.Int).Value = TextBox677.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA15_19", SqlDbType.Int).Value = TextBox678.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA20_24", SqlDbType.Int).Value = TextBox679.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA25_49", SqlDbType.Int).Value = TextBox680.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16MA50", SqlDbType.Int).Value = TextBox681.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG16FE", SqlDbType.Int).Value = TextBox682.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE1", SqlDbType.Int).Value = TextBox674.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE1_4", SqlDbType.Int).Value = TextBox683.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE5_9", SqlDbType.Int).Value = TextBox684.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE10_14", SqlDbType.Int).Value = TextBox685.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE15_19", SqlDbType.Int).Value = TextBox686.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE20_24", SqlDbType.Int).Value = TextBox687.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE25_49", SqlDbType.Int).Value = TextBox689.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G16FE50", SqlDbType.Int).Value = TextBox690.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG17", SqlDbType.Int).Value = TextBox691.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG17MA", SqlDbType.Int).Value = TextBox692.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA1", SqlDbType.Int).Value = TextBox694.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA1_4", SqlDbType.Int).Value = TextBox695.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA5_9", SqlDbType.Int).Value = TextBox696.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA10_14", SqlDbType.Int).Value = TextBox697.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA15_19", SqlDbType.Int).Value = TextBox698.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA20_24", SqlDbType.Int).Value = TextBox699.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA25_49", SqlDbType.Int).Value = TextBox700.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17MA50", SqlDbType.Int).Value = TextBox701.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG17FE", SqlDbType.Int).Value = TextBox693.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE1", SqlDbType.Int).Value = TextBox702.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE1_4", SqlDbType.Int).Value = TextBox703.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE5_9", SqlDbType.Int).Value = TextBox704.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE10_14", SqlDbType.Int).Value = TextBox705.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE15_19", SqlDbType.Int).Value = TextBox706.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE20_24", SqlDbType.Int).Value = TextBox707.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE25_49", SqlDbType.Int).Value = TextBox708.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G17FE50", SqlDbType.Int).Value = TextBox709.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG18", SqlDbType.Int).Value = TextBox710.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG18MA", SqlDbType.Int).Value = TextBox711.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA1", SqlDbType.Int).Value = TextBox713.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA1_4", SqlDbType.Int).Value = TextBox714.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA5_9", SqlDbType.Int).Value = TextBox715.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA10_14", SqlDbType.Int).Value = TextBox716.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA15_19", SqlDbType.Int).Value = TextBox717.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA20_24", SqlDbType.Int).Value = TextBox718.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA25_49", SqlDbType.Int).Value = TextBox719.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18MA50", SqlDbType.Int).Value = TextBox720.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG18FE", SqlDbType.Int).Value = TextBox712.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE1", SqlDbType.Int).Value = TextBox721.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE1_4", SqlDbType.Int).Value = TextBox722.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE5_9", SqlDbType.Int).Value = TextBox723.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE10_14", SqlDbType.Int).Value = TextBox724.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE15_19", SqlDbType.Int).Value = TextBox725.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE20_24", SqlDbType.Int).Value = TextBox726.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE25_49", SqlDbType.Int).Value = TextBox727.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G18FE50", SqlDbType.Int).Value = TextBox728.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG19", SqlDbType.Int).Value = TextBox729.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG19MA", SqlDbType.Int).Value = TextBox730.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA1", SqlDbType.Int).Value = TextBox307.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA1_4", SqlDbType.Int).Value = TextBox308.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA5_9", SqlDbType.Int).Value = TextBox309.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA10_14", SqlDbType.Int).Value = TextBox310.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA15_19", SqlDbType.Int).Value = TextBox311.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA20_24", SqlDbType.Int).Value = TextBox312.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA25_49", SqlDbType.Int).Value = TextBox313.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19MA50", SqlDbType.Int).Value = TextBox314.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG19FE", SqlDbType.Int).Value = TextBox731.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE1", SqlDbType.Int).Value = TextBox315.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE1_4", SqlDbType.Int).Value = TextBox732.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE5_9", SqlDbType.Int).Value = TextBox733.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE10_14", SqlDbType.Int).Value = TextBox734.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE15_19", SqlDbType.Int).Value = TextBox735.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE20_24", SqlDbType.Int).Value = TextBox736.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE25_49", SqlDbType.Int).Value = TextBox737.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G19FE50", SqlDbType.Int).Value = TextBox738.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG20", SqlDbType.Int).Value = TextBox739.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG20MA", SqlDbType.Int).Value = TextBox740.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA1", SqlDbType.Int).Value = TextBox741.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA1_4", SqlDbType.Int).Value = TextBox742.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA5_9", SqlDbType.Int).Value = TextBox743.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA10_14", SqlDbType.Int).Value = TextBox744.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA15_19", SqlDbType.Int).Value = TextBox745.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA20_24", SqlDbType.Int).Value = TextBox746.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA25_49", SqlDbType.Int).Value = TextBox747.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20MA50", SqlDbType.Int).Value = TextBox748.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG20FE", SqlDbType.Int).Value = TextBox749.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE1", SqlDbType.Int).Value = TextBox750.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE1_4", SqlDbType.Int).Value = TextBox751.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE5_9", SqlDbType.Int).Value = TextBox752.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE10_14", SqlDbType.Int).Value = TextBox753.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE15_19", SqlDbType.Int).Value = TextBox754.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE20_24", SqlDbType.Int).Value = TextBox755.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE25_49", SqlDbType.Int).Value = TextBox756.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G20FE50", SqlDbType.Int).Value = TextBox757.Text.Trim();
                    cmd2.Parameters.AddWithValue("@TOTALG21", SqlDbType.Int).Value = TextBox758.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG21MA", SqlDbType.Int).Value = TextBox759.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA1", SqlDbType.Int).Value = TextBox761.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA1_4", SqlDbType.Int).Value = TextBox762.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA5_9", SqlDbType.Int).Value = TextBox763.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA10_14", SqlDbType.Int).Value = TextBox764.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA15_19", SqlDbType.Int).Value = TextBox765.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA20_24", SqlDbType.Int).Value = TextBox766.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA25_49", SqlDbType.Int).Value = TextBox767.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21MA50", SqlDbType.Int).Value = TextBox768.Text.Trim();
                    cmd2.Parameters.AddWithValue("@SUBG21FE", SqlDbType.Int).Value = TextBox760.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE1", SqlDbType.Int).Value = TextBox769.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE1_4", SqlDbType.Int).Value = TextBox770.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE5_9", SqlDbType.Int).Value = TextBox771.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE10_14", SqlDbType.Int).Value = TextBox772.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE15_19", SqlDbType.Int).Value = TextBox773.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE20_24", SqlDbType.Int).Value = TextBox774.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE25_49", SqlDbType.Int).Value = TextBox775.Text.Trim();
                    cmd2.Parameters.AddWithValue("@G21FE50", SqlDbType.Int).Value = TextBox776.Text.Trim();
                    int Rowsaffected3 = cmd2.ExecuteNonQuery();
                    Aggregate_HTC();
                    CLS_TB();
                    if (Rowsaffected1 != -1 && Rowsaffected2 != -1 && Rowsaffected3 != -1)
                    {
                        //Response.Write("<script language=javascript>alert('" + Rowsaffected3.ToString() + "' Successful);</script>");
                        webMessage.Show(Rowsaffected3.ToString() + "' Successful");
                        cmd.Dispose();
                        cmd1.Dispose();
                        cmd2.Dispose();
                        return;
                    }


                }
                catch (Exception ex)
                {
                    //Response.Write("<script language=javascript>alert('" + ex.Message.ToString() + "');</script>");
                    webMessage.Show("Error Saving TB: " + ex.Message.ToString());
                    return;
                }


            }
            else
            {
                //=========== UPDATE EXISTING RECORDS =============

                string sql = "UPDATE tbl_TB1 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG1=@TOTALG1, SUBG1MA=@SUBG1MA,";
                sql += "G1MA1=@G1MA1,	G1MA1_4=@G1MA1_4,G1MA5_9=@G1MA5_9,G1MA10_14=@G1MA10_14,G1MA15_19=@G1MA15_19,G1MA20_24=@G1MA20_24,G1MA25_49=@G1MA25_49,G1MA50=@G1MA50,SUBG1FE=@SUBG1FE,G1FE1=@G1FE1,";
                sql += "G1FE1_4=@G1FE1_4,G1FE5_9=@G1FE5_9,G1FE10_14=@G1FE10_14,G1FE15_19=@G1FE15_19,G1FE20_24=@G1FE20_24,G1FE25_49=@G1FE25_49,G1FE50=@G1FE50,POS_G1STOTAL=@POS_G1STOTAL,POS_SUBG1MA=@POS_SUBG1MA,";
                sql += "POS_G1MA1=@POS_G1MA1,POS_G1MA1_4=@POS_G1MA1_4,POS_G1MA5_9=@POS_G1MA5_9,POS_G1MA10_14=@POS_G1MA10_14,POS_G1MA15_19=@POS_G1MA15_19,POS_G1MA20_24=@POS_G1MA20_24,POS_G1MA25_49=@POS_G1MA25_49,";
                sql += "POS_G1MA50=@POS_G1MA50,POS_SUBG1FE=@POS_SUBG1FE,POS_G1FE1=@POS_G1FE1,POS_G1FE1_4=@POS_G1FE1_4,POS_G1FE5_9=@POS_G1FE5_9,POS_G1FE10_14=@POS_G1FE10_14,POS_G1FE15_19=@POS_G1FE15_19,";
                sql += "POS_G1FE20_24=@POS_G1FE20_24,POS_G1FE25_49=@POS_G1FE25_49,POS_G1FE50=@POS_G1FE50,NEG_G1TOTAL=@NEG_G1TOTAL,NEG_SUBG1MA=@NEG_SUBG1MA,NEG_G1MA1=@NEG_G1MA1,NEG_G1MA1_4=@NEG_G1MA1_4,NEG_G1MA5_9=@NEG_G1MA5_9,";
                sql += "NEG_G1MA10_14=@NEG_G1MA10_14, NEG_G1MA15_19=@NEG_G1MA15_19,NEG_G1MA20_24=@NEG_G1MA20_24, NEG_G1MA25_49=@NEG_G1MA25_49,	NEG_G1MA50=@NEG_G1MA50, NEG_SUBG1FE=@NEG_SUBG1FE,NEG_G1FE1=@NEG_G1FE1,	NEG_G1FE1_4=@NEG_G1FE1_4,";
                sql += "NEG_G1FE5_9=@NEG_G1MA10_14, NEG_G1FE10_14=@NEG_G1FE10_14,NEG_G1FE15_19=@NEG_G1FE15_19, NEG_G1FE20_24=@NEG_G1FE20_24, NEG_G1FE25_49=@NEG_G1FE25_49,	NEG_G1FE50=@NEG_G1FE50,	TOTALG2=@TOTALG2,SUBG2MA=@SUBG2MA,G2MA1=@G2MA1,";
                sql += "G2MA1_4=@G2MA1_4, G2MA5_9=@G2MA5_9,G2MA15_19=@G2MA15_19,G2MA20_24=@G2MA20_24,G2MA25_49=@G2MA25_49,G2MA50=@G2MA50,SUBG2FE=@SUBG2FE,G2FE1=@G2FE1,G2FE1_4=@G2FE1_4,G2FE5_9=@G2FE5_9,G2FE10_14=@G2FE10_14,";
                sql += "G2FE15_19=@G2FE15_19,G2FE20_24=@G2FE20_24,G2FE25_49=@G2FE25_49,	G2FE50=@G2FE50,POS_G2STOTAL=@POS_G2STOTAL,POS_SUBG2MA=@POS_SUBG2MA,POS_G2MA1=@POS_G2MA1,POS_G2MA1_4=@POS_G2MA1_4,POS_G2MA5_9=@POS_G2MA5_9,";
                sql += "POS_G2MA10_14=@POS_G2MA10_14,POS_G2MA15_19=@POS_G2MA15_19,POS_G2MA20_24=@POS_G2MA20_24,POS_G2MA25_49=@POS_G2MA25_49,POS_G2MA50=@POS_G2MA50,	POS_SUBG2FE=@POS_SUBG2FE,POS_G2FE1=@POS_G2FE1,POS_G2FE1_4=@POS_G2FE1_4,";
                sql += "POS_G2FE5_9=@POS_G2FE5_9,POS_G2FE10_14=@POS_G2FE10_14,POS_G2FE15_19=@POS_G2FE15_19,POS_G2FE20_24=@POS_G2FE20_24,POS_G2FE25_49=@POS_G2FE25_49,POS_G2FE50=@POS_G2FE50,NEG_G2TOTAL=@NEG_G2TOTAL,NEG_SUBG2MA=@NEG_SUBG2MA,";
                sql += "NEG_G2MA1=@NEG_G2MA1,NEG_G2MA1_4=@NEG_G2MA1_4,NEG_G2MA5_9=@NEG_G2MA5_9,NEG_G2MA10_14=@NEG_G2MA10_14,NEG_G2MA15_19=@NEG_G2MA15_19,NEG_G2MA20_24=@NEG_G2MA20_24,NEG_G2MA25_49=@NEG_G2MA25_49,NEG_G2MA50=@NEG_G2MA50,";
                sql += "NEG_SUBG2FE=@NEG_SUBG2FE,NEG_G2FE1=@NEG_G2FE1,NEG_G2FE1_4=@NEG_G2FE1_4, NEG_G2FE5_9=@NEG_G2FE5_9,NEG_G2FE10_14=@NEG_G2FE10_14,NEG_G2FE15_19=@NEG_G2FE15_19,NEG_G2FE20_24=@NEG_G2FE20_24,NEG_G2FE25_49=@NEG_G2FE25_49,";
                sql += "NEG_G2FE50=@NEG_G2FE50,TOTALG3=@TOTALG3,SUBG3MA=@SUBG3MA,G3MA1=@G3MA1,G3MA1_4=@G3MA1_4,G3MA5_9=@G3MA5_9,G3MA10_14=@G3MA10_14,G3MA15_19=@G3MA15_19,G3MA20_24=@G3MA20_24,G3MA25_49=@G3MA25_49,G3MA50=@G3MA50,";
                sql += "SUBG3FE=@SUBG3FE,G3FE1=@G3FE1,G3FE1_4=@G3FE1_4,G3FE5_9=@G3FE5_9,G3FE10_14=@G3FE10_14,G3FE15_19=@G3FE15_19,G3FE20_24=@G3FE20_24,G3FE25_49=@G3FE25_49,G3FE50=@G3FE50,TOTALG4=@TOTALG4,SUBG4MA=@SUBG4MA,G4MA1=@G4MA1,";
                sql += "G4MA1_4=@G4MA1_4,G4MA5_9=@G4MA5_9,G4MA10_14=@G4MA10_14,G4MA15_19=@G4MA15_19,G4MA20_24=@G4MA20_24,G4MA25_49=@G4MA25_49,G4MA50=@G4MA50, SUBG4FE=@SUBG4FE,G4FE1=@G4FE1,G4FE1_4=@G4FE1_4,G4FE5_9=@G4FE5_9,G4FE10_14=@G4FE10_14,";
                sql += "G4FE15_19=@G4FE15_19,G4FE20_24=@G4FE20_24,G4FE25_49=@G4FE25_49,G4FE50=@G4FE50,TOTALG5=@TOTALG5,SUBG5MA=@SUBG5MA,G5MA1=@G5MA1,G5MA1_4=@G5MA1_4,G5MA5_9=@G5MA5_9,G5MA10_14=@G5MA10_14";
                sql += " WHERE  states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";

                string sql1 = "UPDATE tbl_TB2 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype, G5MA15_19=@G5MA15_19,	G5MA20_24=@G5MA20_24,	G5MA25_49=@G5MA25_49,";
                sql1 += "G5MA50=@G5MA50,SUBG5FE=@SUBG5FE,G5FE1=@G5FE1,G5FE1_4=@G5FE1_4,G5FE5_9=@G5FE5_9,G5FE10_14=@G5FE10_14,G5FE15_19=@G5FE15_19,G5FE20_24=@G5FE20_24,G5FE25_49=@G5FE25_49,G5FE50=@G5FE50,";
                sql1 += "TOTALG6=@TOTALG6,SUBG6MA=@SUBG6MA,G6MA1=@G6MA1,G6MA1_4=@G6MA1_4,G6MA5_9=@G6MA5_9,G6MA10_14=@G6MA10_14,G6MA15_19=@G6MA15_19,G6MA20_24=@G6MA20_24,G6MA25_49=@G6MA25_49,G6MA50=@G6MA50,";
                sql1 += "SUBG6FE=@SUBG6FE,G6FE1=@G6FE1,G6FE1_4=@G6FE1_4,G6FE5_9=@G6FE5_9,G6FE10_14=@G6FE10_14,G6FE15_19=@G6FE15_19,G6FE20_24=@G6FE20_24,G6FE25_49=@G6FE25_49,G6FE50=@G6FE50,TOTALG7=@TOTALG7,";
                sql1 += "SUBG7MA=@SUBG7MA,G7MA1=@G7MA1,G7MA1_4=@G7MA1_4,G7MA5_9=@G7MA5_9,G7MA10_14=@G7MA10_14,G7MA15_19=@G7MA15_19,G7MA20_24=@G7MA20_24,G7MA25_49=@G7MA25_49,G7MA50=@G7MA50,SUBG7FE=@SUBG7FE,";
                sql1 += "G7FE1=@G7FE1,G7FE1_4=@G7FE1_4,G7FE5_9=@G7FE5_9,G7FE10_14=@G7FE10_14,G7FE15_19=@G7FE15_19,G7FE20_24=@G7FE20_24,G7FE25_49=@G7FE25_49,G7FE50=@G7FE50,TOTALG8=@TOTALG8,SUBG8MA=@SUBG8MA,";
                sql1 += "G8MA1=@G8MA1,G8MA1_4=@G8MA1_4,G8MA5_9=@G8MA5_9,G8MA10_14=@G8MA10_14,G8MA15_19=@G8MA15_19,G8MA20_24=@G8MA20_24,G8MA25_49=@G8MA25_49,G8MA50=@G8MA50,SUBG8FE=@SUBG8FE,G8FE1=@G8FE1,G8FE1_4=@G8FE1_4,";
                sql1 += "G8FE5_9=@G8FE5_9,G8FE10_14=@G8FE10_14,G8FE15_19=@G8FE15_19,G8FE20_24=@G8FE20_24,G8FE25_49=@G8FE25_49,G8FE50=@G8FE50,TOTALG9=@TOTALG9,SUBG9MA=@SUBG9MA,G9MA1=@G9MA1,G9MA1_4=@G9MA1_4,G9MA5_9=@G9MA5_9,";
                sql1 += "G9MA10_14=@G9MA10_14,G9MA15_19=@G9MA15_19,G9MA20_24=@G9MA20_24,G9MA25_49=@G9MA25_49,G9MA50=@G9MA50,SUBG9FE=@SUBG9FE,G9FE1=@G9FE1,G9FE1_4=@G9FE1_4,G9FE5_9=@G9FE5_9,G9FE10_14=@G9FE10_14,G9FE15_19=@G9FE15_19,";
                sql1 += "G9FE20_24=@G9FE20_24,G9FE25_49=@G9FE25_49,G9FE50=@G9FE50,TOTALG10=@TOTALG10,SUBG10MA=@SUBG10MA,G10MA1=@G10MA1,G10MA1_4=@G10MA1_4,G10MA5_9=@G10MA5_9,G10MA10_14=@G10MA10_14,G10MA15_19=@G10MA15_19,";
                sql1 += "G10MA20_24=@G10MA20_24,G10MA25_49=@G10MA25_49,G10MA50=@G10MA50,SUBG10FE=@SUBG10FE,G10FE1=@G10FE1,G10FE1_4=@G10FE1_4,G10FE5_9=@G10FE5_9,G10FE10_14=@G10FE10_14,G10FE15_19=@G10FE15_19,";
                sql1 += "G10FE20_24=@G10FE20_24,G10FE25_49=@G10FE25_49,	G10FE50=@G10FE50,TOTALG11=@TOTALG11,SUBG11MA=@SUBG11MA,G11MA1=@G11MA1,G11MA1_4=@G11MA1_4,G11MA5_9=@G11MA5_9,G11MA10_14=@G11MA10_14,G11MA15_19=@G11MA15_19,";
                sql1 += "G11MA20_24=@G11MA20_24,G11MA25_49=@G11MA25_49,	G11MA50=@G11MA50,SUBG11FE=@SUBG11FE,G11FE1=@G11FE1,G11FE1_4=@G11FE1_4,G11FE5_9=@G11FE5_9,G11FE10_14=@G11FE10_14,G11FE15_19=@G11FE15_19,G11FE20_24=@G11FE20_24,";
                sql1 += "G11FE25_49=@G11FE25_49,G11FE50=@G11FE50,TOTALG12=@TOTALG12,SUBG12MA=@SUBG12MA,G12MA1=@G12MA1,G12MA1_4=@G12MA1_4,G12MA5_9=@G12MA5_9,G12MA10_14=@G12MA10_14,G12MA15_19=@G12MA15_19,G12MA20_24=@G12MA20_24,";
                sql1 += "G12MA25_49=@G12MA25_49,G12MA50=@G12MA50,SUBG12FE=@SUBG12FE,G12FE1=@G12FE1,G12FE1_4=@G12FE1_4,G12FE5_9=@G12FE5_9,G12FE10_14=@G12FE10_14,G12FE15_19=@G12FE15_19,	G12FE20_24=@G12FE20_24,	G12FE25_49=@G12FE25_49,";
                sql1 += "G12FE50=@G12FE50,TOTALG13=@TOTALG13,SUBG13MA=@SUBG13MA,G13MA1=@G13MA1,G13MA1_4=@G13MA1_4,G13MA5_9=@G13MA5_9,G13MA10_14=@G13MA10_14,G13MA15_19=@G13MA15_19,G13MA20_24=@G13MA20_24,	G13MA25_49=@G13MA25_49,G13MA50=@G13MA50,";
                sql1 += "SUBG13FE=@SUBG13FE,G13FE1=@G13FE1  WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";


                string sql2 = "UPDATE tbl_TB3 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,G13FE1_4=@G13FE1_4,	G13FE5_9=@G13FE5_9,";
                sql2 += "G13FE10_14=@G13FE10_14,G13FE15_19=@G13FE15_19,	G13FE20_24=@G13FE20_24,	G13FE25_49=@G13FE25_49,	G13FE50=@G13FE50,TOTALG14=@TOTALG14,SUBG14MA=@SUBG14MA,G14MA1=@G14MA1,";
                sql2 += "G14MA1_4=@G14MA1_4,G14MA5_9=@G14MA5_9,G14MA10_14=@G14MA10_14,G14MA15_19=@G14MA15_19,G14MA20_24=@G14MA20_24,G14MA25_49=@G14MA25_49,G14MA50=@G14MA50,SUBG14FE=@SUBG14FE,";
                sql2 += "G14FE1=@G14FE1,G14FE1_4=@G14FE1_4,G14FE5_9=@G14FE5_9,G14FE10_14=@G14FE10_14,G14FE15_19=@G14FE15_19,G14FE20_24=@G14FE20_24,G14FE25_49=@G14FE25_49,G14FE50=@G14FE50,";
                sql2 += "TOTALG15=@TOTALG15,SUBG15MA=@SUBG15MA,G15MA1=@G15MA1,G15MA1_4=@G15MA1_4,G15MA5_9=@G15MA5_9,G15MA10_14=@G15MA10_14,G15MA15_19=@G15MA15_19,G15MA20_24=@G15MA20_24,G15MA25_49=@G15MA25_49,";
                sql2 += "G15MA50=@G15MA50,SUBG15FE=@SUBG15FE,G15FE1=@G15FE1,G15FE1_4=@G15FE1_4,G15FE5_9=@G15FE5_9,G15FE10_14=@G15FE10_14,G15FE15_19=@G15FE15_19,G15FE20_24=@G15FE20_24,G15FE25_49=@G15FE25_49,";
                sql2 += "G15FE50=@G15FE50,TOTALG16=@TOTALG16,SUBG16MA=@SUBG16MA,G16MA1=@G16MA1,	G16MA1_4=@G16MA1_4,G16MA5_9=@G16MA5_9,G16MA10_14=@G16MA10_14,G16MA15_19=@G16MA15_19,G16MA20_24=@G16MA20_24,G16MA25_49=@G16MA25_49,";
                sql2 += "G16MA50=@G16MA50,SUBG16FE=@SUBG16FE,G16FE1=@G16FE1,G16FE5_9=@G16FE5_9,G16FE10_14=@G16FE10_14,G16FE15_19=@G16FE15_19,G16FE20_24=@G16FE20_24,G16FE25_49=@G16FE25_49,G16FE50=@G16FE50,";
                sql2 += "TOTALG17=@TOTALG17,SUBG17MA=@SUBG17MA,G17MA1=@G17MA1,G17MA1_4=@G17MA1_4,G17MA5_9=@G17MA5_9,G17MA10_14=@G17MA10_14,G17MA15_19=@G17MA15_19,G17MA20_24=@G17MA20_24,G17MA25_49=@G17MA25_49,";
                sql2 += "G17MA50=@G17MA50,SUBG17FE=@SUBG17FE,G17FE1=@G17FE1,G17FE1_4=@G17FE1_4,G17FE5_9=@G17FE5_9,G17FE10_14=@G17FE10_14,G17FE15_19=@G17FE15_19,G17FE20_24=@G17FE20_24,G17FE25_49=@G17FE25_49,";
                sql2 += "G17FE50=@G17FE50,TOTALG18=@TOTALG18,SUBG18MA=@SUBG18MA,G18MA1=@G18MA1,G18MA1_4=@G18MA1_4,G18MA5_9=@G18MA5_9,G18MA10_14=@G18MA10_14,G18MA15_19=@G18MA15_19,G18MA20_24=@G18MA20_24,G18MA25_49=@G18MA25_49,";
                sql2 += "G18MA50=@G18MA50,SUBG18FE=@SUBG18FE,G18FE1=@G18FE1,G18FE1_4=@G18FE1_4,G18FE5_9=@G18FE5_9,G18FE10_14=@G18FE10_14,G18FE15_19=@G18FE15_19,G18FE20_24=@G18FE20_24,G18FE25_49=@G18FE25_49,G18FE50=@G18FE50,";
                sql2 += "TOTALG19=@TOTALG19,SUBG19MA=@SUBG19MA,G19MA1=@G19MA1,G19MA1_4=@G19MA1_4,G19MA5_9=@G19MA5_9,G19MA10_14=@G19MA10_14,G19MA15_19=@G19MA15_19,G19MA20_24=@G19MA20_24,G19MA25_49=@G19MA25_49,G19MA50=@G19MA50,";
                sql2 += "SUBG19FE=@SUBG19FE,G19FE1=@G19FE1,G19FE1_4=@G19FE1_4,G19FE5_9=@G19FE5_9,G19FE10_14=@G19FE10_14,G19FE15_19=@G19FE15_19,	G19FE20_24=@G19FE20_24,	G19FE25_49=@G19FE25_49,	G19FE50=@G19FE50,TOTALG20=@TOTALG20,";
                sql2 += "SUBG20MA=@SUBG20MA,G20MA1=@G20MA1,G20MA1_4=@G20MA1_4,G20MA5_9=@G20MA5_9,G20MA10_14=@G20MA10_14,G20MA15_19=@G20MA15_19,	G20MA20_24=@G20MA20_24,	G20MA25_49=@G20MA25_49,	G20MA50=@G20MA50,SUBG20FE=@SUBG20FE,";
                sql2 += "G20FE1=@G20FE1,G20FE1_4=@G20FE1_4,G20FE5_9=@G20FE5_9,G20FE10_14=@G20FE10_14,G20FE15_19=@G20FE15_19,G20FE20_24=@G20FE20_24,G20FE25_49=@G20FE25_49,G20FE50=@G20FE50,TOTALG21=@TOTALG21,SUBG21MA=@SUBG21MA,";
                sql2 += "G21MA1=@G21MA1,G21MA1_4=@G21MA1_4,G21MA5_9=@G21MA5_9,G21MA10_14=@G21MA10_14,G21MA15_19=@G21MA15_19,G21MA20_24=@G21MA20_24,G21MA25_49=@G21MA25_49,G21MA50=@G21MA50,SUBG21FE=@SUBG21FE,G21FE1=@G21FE1,G21FE1_4=@G21FE1_4,";
                sql2 += "G21FE5_9=@G21FE5_9,G21FE10_14=@G21FE10_14,G21FE15_19=@G21FE15_19,G21FE20_24=@G21FE20_24,G21FE25_49=@G21FE25_49,G21FE50=@G21FE50";
                sql2 += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                 try
                 {
                     cn.Open();
                     SqlCommand cmd = new SqlCommand(sql, cn);
                     cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                     cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                     cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                     cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                     cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                     cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                     cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox330.Text.Trim();
                     cmd.Parameters.AddWithValue("@Subg1ma", SqlDbType.Int).Value = TextBox331.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA1", SqlDbType.Int).Value = TextBox332.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA1_4", SqlDbType.Int).Value = TextBox333.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA5_9", SqlDbType.Int).Value = TextBox334.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA10_14", SqlDbType.Int).Value = TextBox335.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA15_19", SqlDbType.Int).Value = TextBox336.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA20_24", SqlDbType.Int).Value = TextBox337.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA25_49", SqlDbType.Int).Value = TextBox338.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1MA50", SqlDbType.Int).Value = TextBox339.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG1FE", SqlDbType.Int).Value = TextBox348.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE1", SqlDbType.Int).Value = TextBox340.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE1_4", SqlDbType.Int).Value = TextBox341.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE5_9", SqlDbType.Int).Value = TextBox342.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE10_14", SqlDbType.Int).Value = TextBox343.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE15_19", SqlDbType.Int).Value = TextBox344.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE20_24", SqlDbType.Int).Value = TextBox345.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE25_49", SqlDbType.Int).Value = TextBox346.Text.Trim();
                     cmd.Parameters.AddWithValue("@G1FE50", SqlDbType.Int).Value = TextBox347.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1STOTAL", SqlDbType.Int).Value = TextBox349.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_SUBG1MA", SqlDbType.Int).Value = TextBox350.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA1", SqlDbType.Int).Value = TextBox351.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA1_4", SqlDbType.Int).Value = TextBox352.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA5_9", SqlDbType.Int).Value = TextBox353.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA10_14", SqlDbType.Int).Value = TextBox354.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA15_19", SqlDbType.Int).Value = TextBox355.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA20_24", SqlDbType.Int).Value = TextBox356.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA25_49", SqlDbType.Int).Value = TextBox357.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1MA50", SqlDbType.Int).Value = TextBox358.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_SUBG1FE", SqlDbType.Int).Value = TextBox359.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE1", SqlDbType.Int).Value = TextBox360.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE1_4", SqlDbType.Int).Value = TextBox361.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE5_9", SqlDbType.Int).Value = TextBox362.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE10_14", SqlDbType.Int).Value = TextBox363.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE15_19", SqlDbType.Int).Value = TextBox364.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE20_24", SqlDbType.Int).Value = TextBox365.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE25_49", SqlDbType.Int).Value = TextBox366.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G1FE50", SqlDbType.Int).Value = TextBox367.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1TOTAL", SqlDbType.Int).Value = TextBox368.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_SUBG1MA", SqlDbType.Int).Value = TextBox369.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA1", SqlDbType.Int).Value = TextBox370.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA1_4", SqlDbType.Int).Value = TextBox371.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA5_9", SqlDbType.Int).Value = TextBox372.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA10_14", SqlDbType.Int).Value = TextBox373.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA15_19", SqlDbType.Int).Value = TextBox374.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA20_24", SqlDbType.Int).Value = TextBox375.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA25_49", SqlDbType.Int).Value = TextBox376.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1MA50", SqlDbType.Int).Value = TextBox377.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_SUBG1FE", SqlDbType.Int).Value = TextBox378.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE1", SqlDbType.Int).Value = TextBox379.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE1_4", SqlDbType.Int).Value = TextBox380.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE5_9", SqlDbType.Int).Value = TextBox381.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE10_14", SqlDbType.Int).Value = TextBox382.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE15_19", SqlDbType.Int).Value = TextBox383.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE20_24", SqlDbType.Int).Value = TextBox384.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE25_49", SqlDbType.Int).Value = TextBox385.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G1FE50", SqlDbType.Int).Value = TextBox386.Text.Trim();
                     cmd.Parameters.AddWithValue("@TOTALG2", SqlDbType.Int).Value = TextBox387.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG2MA", SqlDbType.Int).Value = TextBox388.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA1", SqlDbType.Int).Value = TextBox390.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA1_4", SqlDbType.Int).Value = TextBox391.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA5_9", SqlDbType.Int).Value = TextBox392.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA10_14", SqlDbType.Int).Value = TextBox393.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA15_19", SqlDbType.Int).Value = TextBox394.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA20_24", SqlDbType.Int).Value = TextBox395.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA25_49", SqlDbType.Int).Value = TextBox396.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2MA50", SqlDbType.Int).Value = TextBox397.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG2FE", SqlDbType.Int).Value = TextBox389.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE1", SqlDbType.Int).Value = TextBox398.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE1_4", SqlDbType.Int).Value = TextBox399.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE5_9", SqlDbType.Int).Value = TextBox400.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE10_14", SqlDbType.Int).Value = TextBox401.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE15_19", SqlDbType.Int).Value = TextBox402.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE20_24", SqlDbType.Int).Value = TextBox403.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE25_49", SqlDbType.Int).Value = TextBox404.Text.Trim();
                     cmd.Parameters.AddWithValue("@G2FE50", SqlDbType.Int).Value = TextBox405.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2STOTAL", SqlDbType.Int).Value = TextBox406.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_SUBG2MA", SqlDbType.Int).Value = TextBox407.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA1", SqlDbType.Int).Value = TextBox408.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA1_4", SqlDbType.Int).Value = TextBox409.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA5_9", SqlDbType.Int).Value = TextBox410.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA10_14", SqlDbType.Int).Value = TextBox411.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA15_19", SqlDbType.Int).Value = TextBox412.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA20_24", SqlDbType.Int).Value = TextBox413.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA25_49", SqlDbType.Int).Value = TextBox414.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2MA50", SqlDbType.Int).Value = TextBox415.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_SUBG2FE", SqlDbType.Int).Value = TextBox424.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE1", SqlDbType.Int).Value = TextBox416.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE1_4", SqlDbType.Int).Value = TextBox417.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE5_9", SqlDbType.Int).Value = TextBox418.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE10_14", SqlDbType.Int).Value = TextBox419.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE15_19", SqlDbType.Int).Value = TextBox420.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE20_24", SqlDbType.Int).Value = TextBox421.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE25_49", SqlDbType.Int).Value = TextBox425.Text.Trim();
                     cmd.Parameters.AddWithValue("@POS_G2FE50", SqlDbType.Int).Value = TextBox423.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2TOTAL", SqlDbType.Int).Value = TextBox425.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_SUBG2MA", SqlDbType.Int).Value = TextBox426.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA1", SqlDbType.Int).Value = TextBox427.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA1_4", SqlDbType.Int).Value = TextBox428.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA5_9", SqlDbType.Int).Value = TextBox429.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA10_14", SqlDbType.Int).Value = TextBox430.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA15_19", SqlDbType.Int).Value = TextBox431.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA20_24", SqlDbType.Int).Value = TextBox432.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA25_49", SqlDbType.Int).Value = TextBox433.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2MA50", SqlDbType.Int).Value = TextBox434.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_SUBG2FE", SqlDbType.Int).Value = TextBox443.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE1", SqlDbType.Int).Value = TextBox435.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE1_4", SqlDbType.Int).Value = TextBox436.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE5_9", SqlDbType.Int).Value = TextBox437.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE10_14", SqlDbType.Int).Value = TextBox438.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE15_19", SqlDbType.Int).Value = TextBox439.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE20_24", SqlDbType.Int).Value = TextBox440.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE25_49", SqlDbType.Int).Value = TextBox441.Text.Trim();
                     cmd.Parameters.AddWithValue("@NEG_G2FE50", SqlDbType.Int).Value = TextBox442.Text.Trim();
                     cmd.Parameters.AddWithValue("@TOTALG3", SqlDbType.Int).Value = TextBox444.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG3MA", SqlDbType.Int).Value = TextBox445.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA1", SqlDbType.Int).Value = TextBox446.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA1_4", SqlDbType.Int).Value = TextBox447.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA5_9", SqlDbType.Int).Value = TextBox448.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA10_14", SqlDbType.Int).Value = TextBox449.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA15_19", SqlDbType.Int).Value = TextBox450.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA20_24", SqlDbType.Int).Value = TextBox451.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA25_49", SqlDbType.Int).Value = TextBox452.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3MA50", SqlDbType.Int).Value = TextBox453.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG3FE", SqlDbType.Int).Value = TextBox454.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE1", SqlDbType.Int).Value = TextBox455.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE1_4", SqlDbType.Int).Value = TextBox456.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE5_9", SqlDbType.Int).Value = TextBox457.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE10_14", SqlDbType.Int).Value = TextBox458.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE15_19", SqlDbType.Int).Value = TextBox459.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE20_24", SqlDbType.Int).Value = TextBox460.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE25_49", SqlDbType.Int).Value = TextBox461.Text.Trim();
                     cmd.Parameters.AddWithValue("@G3FE50", SqlDbType.Int).Value = TextBox462.Text.Trim();
                     cmd.Parameters.AddWithValue("@TOTALG4", SqlDbType.Int).Value = TextBox463.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG4MA", SqlDbType.Int).Value = TextBox464.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA1", SqlDbType.Int).Value = TextBox465.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA1_4", SqlDbType.Int).Value = TextBox466.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA5_9", SqlDbType.Int).Value = TextBox467.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA10_14", SqlDbType.Int).Value = TextBox468.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA15_19", SqlDbType.Int).Value = TextBox469.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA20_24", SqlDbType.Int).Value = TextBox470.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA25_49", SqlDbType.Int).Value = TextBox471.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4MA50", SqlDbType.Int).Value = TextBox472.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG4FE", SqlDbType.Int).Value = TextBox481.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE1", SqlDbType.Int).Value = TextBox473.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE1_4", SqlDbType.Int).Value = TextBox474.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE5_9", SqlDbType.Int).Value = TextBox475.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE10_14", SqlDbType.Int).Value = TextBox476.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE15_19", SqlDbType.Int).Value = TextBox477.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE20_24", SqlDbType.Int).Value = TextBox478.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE25_49", SqlDbType.Int).Value = TextBox479.Text.Trim();
                     cmd.Parameters.AddWithValue("@G4FE50", SqlDbType.Int).Value = TextBox480.Text.Trim();
                     cmd.Parameters.AddWithValue("@TOTALG5", SqlDbType.Int).Value = TextBox482.Text.Trim();
                     cmd.Parameters.AddWithValue("@SUBG5MA", SqlDbType.Int).Value = TextBox483.Text.Trim();
                     cmd.Parameters.AddWithValue("@G5MA1", SqlDbType.Int).Value = TextBox485.Text.Trim();
                     cmd.Parameters.AddWithValue("@G5MA1_4", SqlDbType.Int).Value = TextBox486.Text.Trim();
                     cmd.Parameters.AddWithValue("@G5MA5_9", SqlDbType.Int).Value = TextBox487.Text.Trim();
                     cmd.Parameters.AddWithValue("@G5MA10_14", SqlDbType.Int).Value = TextBox488.Text.Trim();
                     int Rowsaffected1 = cmd.ExecuteNonQuery();

            //=================== TB2 ==========================
 

        SqlCommand cmd1 = new SqlCommand(sql1, cn);
        cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
        cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
        cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
        cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
        cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
        cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

        cmd1.Parameters.AddWithValue("@G5MA15_19", SqlDbType.Int).Value = TextBox489.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5MA20_24", SqlDbType.Int).Value = TextBox490.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5MA25_49", SqlDbType.Int).Value = TextBox491.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5MA50", SqlDbType.Int).Value = TextBox492.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG5FE", SqlDbType.Int).Value = TextBox484.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE1", SqlDbType.Int).Value = TextBox493.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE1_4", SqlDbType.Int).Value = TextBox494.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE5_9", SqlDbType.Int).Value = TextBox495.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE10_14", SqlDbType.Int).Value = TextBox496.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE15_19", SqlDbType.Int).Value = TextBox497.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE20_24", SqlDbType.Int).Value = TextBox498.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE25_49", SqlDbType.Int).Value = TextBox499.Text.Trim();
        cmd1.Parameters.AddWithValue("@G5FE50", SqlDbType.Int).Value = TextBox500.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG6", SqlDbType.Int).Value = TextBox501.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG6MA", SqlDbType.Int).Value = TextBox502.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA1", SqlDbType.Int).Value = TextBox504.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA1_4", SqlDbType.Int).Value = TextBox505.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA5_9", SqlDbType.Int).Value = TextBox506.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA10_14", SqlDbType.Int).Value = TextBox507.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA15_19", SqlDbType.Int).Value = TextBox508.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA20_24", SqlDbType.Int).Value = TextBox509.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA25_49", SqlDbType.Int).Value = TextBox510.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6MA50", SqlDbType.Int).Value = TextBox511.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG6FE", SqlDbType.Int).Value = TextBox503.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE1", SqlDbType.Int).Value = TextBox512.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE1_4", SqlDbType.Int).Value = TextBox513.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE5_9", SqlDbType.Int).Value = TextBox514.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE10_14", SqlDbType.Int).Value = TextBox515.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE15_19", SqlDbType.Int).Value = TextBox516.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE20_24", SqlDbType.Int).Value = TextBox517.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE25_49", SqlDbType.Int).Value = TextBox518.Text.Trim();
        cmd1.Parameters.AddWithValue("@G6FE50", SqlDbType.Int).Value = TextBox519.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG7", SqlDbType.Int).Value = TextBox520.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG7MA", SqlDbType.Int).Value = TextBox521.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA1", SqlDbType.Int).Value = TextBox523.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA1_4", SqlDbType.Int).Value = TextBox524.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA5_9", SqlDbType.Int).Value = TextBox525.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA10_14", SqlDbType.Int).Value = TextBox526.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA15_19", SqlDbType.Int).Value = TextBox527.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA20_24", SqlDbType.Int).Value = TextBox528.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA25_49", SqlDbType.Int).Value = TextBox529.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7MA50", SqlDbType.Int).Value = TextBox530.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG7FE", SqlDbType.Int).Value = TextBox522.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE1", SqlDbType.Int).Value = TextBox531.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE1_4", SqlDbType.Int).Value = TextBox532.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE5_9", SqlDbType.Int).Value = TextBox533.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE10_14", SqlDbType.Int).Value = TextBox534.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE15_19", SqlDbType.Int).Value = TextBox535.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE20_24", SqlDbType.Int).Value = TextBox536.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE25_49", SqlDbType.Int).Value = TextBox537.Text.Trim();
        cmd1.Parameters.AddWithValue("@G7FE50", SqlDbType.Int).Value = TextBox538.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG8", SqlDbType.Int).Value = TextBox539.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG8MA", SqlDbType.Int).Value = TextBox540.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA1", SqlDbType.Int).Value = TextBox542.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA1_4", SqlDbType.Int).Value = TextBox543.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA5_9", SqlDbType.Int).Value = TextBox544.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA10_14", SqlDbType.Int).Value = TextBox545.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA15_19", SqlDbType.Int).Value = TextBox546.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA20_24", SqlDbType.Int).Value = TextBox547.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA25_49", SqlDbType.Int).Value = TextBox548.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8MA50", SqlDbType.Int).Value = TextBox549.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG8FE", SqlDbType.Int).Value = TextBox541.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE1", SqlDbType.Int).Value = TextBox550.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE1_4", SqlDbType.Int).Value = TextBox551.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE5_9", SqlDbType.Int).Value = TextBox552.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE10_14", SqlDbType.Int).Value = TextBox553.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE15_19", SqlDbType.Int).Value = TextBox554.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE20_24", SqlDbType.Int).Value = TextBox555.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE25_49", SqlDbType.Int).Value = TextBox556.Text.Trim();
        cmd1.Parameters.AddWithValue("@G8FE50", SqlDbType.Int).Value = TextBox557.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG9", SqlDbType.Int).Value = TextBox777.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG9MA", SqlDbType.Int).Value = TextBox778.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = TextBox779.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = TextBox780.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = TextBox781.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = TextBox782.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = TextBox783.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = TextBox784.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = TextBox785.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = TextBox786.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG9FE", SqlDbType.Int).Value = TextBox787.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = TextBox788.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = TextBox789.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = TextBox790.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = TextBox791.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = TextBox792.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = TextBox793.Text.Trim();
        cmd1.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = TextBox794.Text.Trim(); //============
        cmd1.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = TextBox795.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG10", SqlDbType.Int).Value = TextBox558.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG10MA", SqlDbType.Int).Value = TextBox559.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA1", SqlDbType.Int).Value = TextBox560.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA1_4", SqlDbType.Int).Value = TextBox561.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA5_9", SqlDbType.Int).Value = TextBox562.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA10_14", SqlDbType.Int).Value = TextBox563.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA15_19", SqlDbType.Int).Value = TextBox564.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA20_24", SqlDbType.Int).Value = TextBox565.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA25_49", SqlDbType.Int).Value = TextBox566.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10MA50", SqlDbType.Int).Value = TextBox567.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG10FE", SqlDbType.Int).Value = TextBox576.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE1", SqlDbType.Int).Value = TextBox568.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE1_4", SqlDbType.Int).Value = TextBox569.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE5_9", SqlDbType.Int).Value = TextBox570.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE10_14", SqlDbType.Int).Value = TextBox571.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE15_19", SqlDbType.Int).Value = TextBox572.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE20_24", SqlDbType.Int).Value = TextBox573.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE25_49", SqlDbType.Int).Value = TextBox574.Text.Trim();
        cmd1.Parameters.AddWithValue("@G10FE50", SqlDbType.Int).Value = TextBox575.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG11", SqlDbType.Int).Value = TextBox577.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG11MA", SqlDbType.Int).Value = TextBox578.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = TextBox579.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = TextBox580.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = TextBox581.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = TextBox582.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = TextBox583.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = TextBox584.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = TextBox585.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = TextBox586.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG11FE", SqlDbType.Int).Value = TextBox595.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = TextBox587.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = TextBox588.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = TextBox589.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = TextBox590.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = TextBox591.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = TextBox592.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = TextBox593.Text.Trim();
        cmd1.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = TextBox594.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG12", SqlDbType.Int).Value = TextBox596.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG12MA", SqlDbType.Int).Value = TextBox597.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = TextBox598.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = TextBox599.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = TextBox600.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = TextBox601.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = TextBox602.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = TextBox603.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = TextBox604.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = TextBox605.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG12FE", SqlDbType.Int).Value = TextBox606.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = TextBox607.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = TextBox608.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = TextBox609.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = TextBox610.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = TextBox611.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = TextBox612.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = TextBox613.Text.Trim();
        cmd1.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = TextBox614.Text.Trim();
        cmd1.Parameters.AddWithValue("@TOTALG13", SqlDbType.Int).Value = TextBox615.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG13MA", SqlDbType.Int).Value = TextBox616.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA1", SqlDbType.Int).Value = TextBox617.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA1_4", SqlDbType.Int).Value = TextBox618.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA5_9", SqlDbType.Int).Value = TextBox619.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA10_14", SqlDbType.Int).Value = TextBox620.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA15_19", SqlDbType.Int).Value = TextBox621.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA20_24", SqlDbType.Int).Value = TextBox622.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA25_49", SqlDbType.Int).Value = TextBox623.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13MA50", SqlDbType.Int).Value = TextBox624.Text.Trim();
        cmd1.Parameters.AddWithValue("@SUBG13FE", SqlDbType.Int).Value = TextBox633.Text.Trim();
        cmd1.Parameters.AddWithValue("@G13FE1", SqlDbType.Int).Value = TextBox625.Text.Trim();
        int Rowsaffected2 = cmd1.ExecuteNonQuery();

        //======================================= tbl_TB3
        SqlCommand cmd2 = new SqlCommand(sql2, cn);
        cmd2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
        cmd2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
        cmd2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
        cmd2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
        cmd2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
        cmd2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

        cmd2.Parameters.AddWithValue("@G13FE1_4", SqlDbType.Int).Value = TextBox626.Text.Trim();
        cmd2.Parameters.AddWithValue("@G13FE5_9", SqlDbType.Int).Value = TextBox627.Text.Trim();
        cmd2.Parameters.AddWithValue("@G13FE10_14", SqlDbType.Int).Value = TextBox628.Text.Trim();
        cmd2.Parameters.AddWithValue("@G13FE15_19", SqlDbType.Int).Value = TextBox629.Text.Trim();
        cmd2.Parameters.AddWithValue("@G13FE20_24", SqlDbType.Int).Value = TextBox630.Text.Trim();
        cmd2.Parameters.AddWithValue("@G13FE25_49", SqlDbType.Int).Value = TextBox631.Text.Trim();
        cmd2.Parameters.AddWithValue("@G13FE50", SqlDbType.Int).Value = TextBox632.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG14", SqlDbType.Int).Value = TextBox634.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG14MA", SqlDbType.Int).Value = TextBox635.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA1", SqlDbType.Int).Value = TextBox636.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA1_4", SqlDbType.Int).Value = TextBox637.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA5_9", SqlDbType.Int).Value = TextBox638.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA10_14", SqlDbType.Int).Value = TextBox639.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA15_19", SqlDbType.Int).Value = TextBox640.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA20_24", SqlDbType.Int).Value = TextBox641.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA25_49", SqlDbType.Int).Value = TextBox642.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14MA50", SqlDbType.Int).Value = TextBox643.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG14FE", SqlDbType.Int).Value = TextBox644.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE1", SqlDbType.Int).Value = TextBox645.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE1_4", SqlDbType.Int).Value = TextBox646.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE5_9", SqlDbType.Int).Value = TextBox647.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE10_14", SqlDbType.Int).Value = TextBox648.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE15_19", SqlDbType.Int).Value = TextBox649.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE20_24", SqlDbType.Int).Value = TextBox650.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE25_49", SqlDbType.Int).Value = TextBox651.Text.Trim();
        cmd2.Parameters.AddWithValue("@G14FE50", SqlDbType.Int).Value = TextBox652.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG15", SqlDbType.Int).Value = TextBox653.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG15MA", SqlDbType.Int).Value = TextBox654.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA1", SqlDbType.Int).Value = TextBox655.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA1_4", SqlDbType.Int).Value = TextBox656.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA5_9", SqlDbType.Int).Value = TextBox657.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA10_14", SqlDbType.Int).Value = TextBox658.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA15_19", SqlDbType.Int).Value = TextBox659.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA20_24", SqlDbType.Int).Value = TextBox660.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA25_49", SqlDbType.Int).Value = TextBox661.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15MA50", SqlDbType.Int).Value = TextBox662.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG15FE", SqlDbType.Int).Value = TextBox671.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE1", SqlDbType.Int).Value = TextBox663.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE1_4", SqlDbType.Int).Value = TextBox664.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE5_9", SqlDbType.Int).Value = TextBox665.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE10_14", SqlDbType.Int).Value = TextBox666.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE15_19", SqlDbType.Int).Value = TextBox667.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE20_24", SqlDbType.Int).Value = TextBox668.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE25_49", SqlDbType.Int).Value = TextBox669.Text.Trim();
        cmd2.Parameters.AddWithValue("@G15FE50", SqlDbType.Int).Value = TextBox670.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG16", SqlDbType.Int).Value = TextBox672.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG16MA", SqlDbType.Int).Value = TextBox673.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA1", SqlDbType.Int).Value = TextBox674.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA1_4", SqlDbType.Int).Value = TextBox675.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA5_9", SqlDbType.Int).Value = TextBox676.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA10_14", SqlDbType.Int).Value = TextBox677.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA15_19", SqlDbType.Int).Value = TextBox678.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA20_24", SqlDbType.Int).Value = TextBox679.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA25_49", SqlDbType.Int).Value = TextBox680.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16MA50", SqlDbType.Int).Value = TextBox681.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG16FE", SqlDbType.Int).Value = TextBox682.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE1", SqlDbType.Int).Value = TextBox674.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE1_4", SqlDbType.Int).Value = TextBox683.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE5_9", SqlDbType.Int).Value = TextBox684.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE10_14", SqlDbType.Int).Value = TextBox685.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE15_19", SqlDbType.Int).Value = TextBox686.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE20_24", SqlDbType.Int).Value = TextBox687.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE25_49", SqlDbType.Int).Value = TextBox689.Text.Trim();
        cmd2.Parameters.AddWithValue("@G16FE50", SqlDbType.Int).Value = TextBox690.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG17", SqlDbType.Int).Value = TextBox691.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG17MA", SqlDbType.Int).Value = TextBox692.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA1", SqlDbType.Int).Value = TextBox694.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA1_4", SqlDbType.Int).Value = TextBox695.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA5_9", SqlDbType.Int).Value = TextBox696.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA10_14", SqlDbType.Int).Value = TextBox697.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA15_19", SqlDbType.Int).Value = TextBox698.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA20_24", SqlDbType.Int).Value = TextBox699.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA25_49", SqlDbType.Int).Value = TextBox700.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17MA50", SqlDbType.Int).Value = TextBox701.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG17FE", SqlDbType.Int).Value = TextBox693.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE1", SqlDbType.Int).Value = TextBox702.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE1_4", SqlDbType.Int).Value = TextBox703.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE5_9", SqlDbType.Int).Value = TextBox704.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE10_14", SqlDbType.Int).Value = TextBox705.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE15_19", SqlDbType.Int).Value = TextBox706.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE20_24", SqlDbType.Int).Value = TextBox707.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE25_49", SqlDbType.Int).Value = TextBox708.Text.Trim();
        cmd2.Parameters.AddWithValue("@G17FE50", SqlDbType.Int).Value = TextBox709.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG18", SqlDbType.Int).Value = TextBox710.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG18MA", SqlDbType.Int).Value = TextBox711.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA1", SqlDbType.Int).Value = TextBox713.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA1_4", SqlDbType.Int).Value = TextBox714.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA5_9", SqlDbType.Int).Value = TextBox715.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA10_14", SqlDbType.Int).Value = TextBox716.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA15_19", SqlDbType.Int).Value = TextBox717.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA20_24", SqlDbType.Int).Value = TextBox718.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA25_49", SqlDbType.Int).Value = TextBox719.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18MA50", SqlDbType.Int).Value = TextBox720.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG18FE", SqlDbType.Int).Value = TextBox712.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE1", SqlDbType.Int).Value = TextBox721.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE1_4", SqlDbType.Int).Value = TextBox722.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE5_9", SqlDbType.Int).Value = TextBox723.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE10_14", SqlDbType.Int).Value = TextBox724.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE15_19", SqlDbType.Int).Value = TextBox725.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE20_24", SqlDbType.Int).Value = TextBox726.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE25_49", SqlDbType.Int).Value = TextBox727.Text.Trim();
        cmd2.Parameters.AddWithValue("@G18FE50", SqlDbType.Int).Value = TextBox728.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG19", SqlDbType.Int).Value = TextBox729.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG19MA", SqlDbType.Int).Value = TextBox730.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA1", SqlDbType.Int).Value = TextBox307.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA1_4", SqlDbType.Int).Value = TextBox308.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA5_9", SqlDbType.Int).Value = TextBox309.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA10_14", SqlDbType.Int).Value = TextBox310.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA15_19", SqlDbType.Int).Value = TextBox311.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA20_24", SqlDbType.Int).Value = TextBox312.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA25_49", SqlDbType.Int).Value = TextBox313.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19MA50", SqlDbType.Int).Value = TextBox314.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG19FE", SqlDbType.Int).Value = TextBox731.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE1", SqlDbType.Int).Value = TextBox315.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE1_4", SqlDbType.Int).Value = TextBox732.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE5_9", SqlDbType.Int).Value = TextBox733.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE10_14", SqlDbType.Int).Value = TextBox734.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE15_19", SqlDbType.Int).Value = TextBox735.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE20_24", SqlDbType.Int).Value = TextBox736.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE25_49", SqlDbType.Int).Value = TextBox737.Text.Trim();
        cmd2.Parameters.AddWithValue("@G19FE50", SqlDbType.Int).Value = TextBox738.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG20", SqlDbType.Int).Value = TextBox739.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG20MA", SqlDbType.Int).Value = TextBox740.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA1", SqlDbType.Int).Value = TextBox741.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA1_4", SqlDbType.Int).Value = TextBox742.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA5_9", SqlDbType.Int).Value = TextBox743.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA10_14", SqlDbType.Int).Value = TextBox744.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA15_19", SqlDbType.Int).Value = TextBox745.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA20_24", SqlDbType.Int).Value = TextBox746.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA25_49", SqlDbType.Int).Value = TextBox747.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20MA50", SqlDbType.Int).Value = TextBox748.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG20FE", SqlDbType.Int).Value = TextBox749.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE1", SqlDbType.Int).Value = TextBox750.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE1_4", SqlDbType.Int).Value = TextBox751.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE5_9", SqlDbType.Int).Value = TextBox752.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE10_14", SqlDbType.Int).Value = TextBox753.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE15_19", SqlDbType.Int).Value = TextBox754.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE20_24", SqlDbType.Int).Value = TextBox755.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE25_49", SqlDbType.Int).Value = TextBox756.Text.Trim();
        cmd2.Parameters.AddWithValue("@G20FE50", SqlDbType.Int).Value = TextBox757.Text.Trim();
        cmd2.Parameters.AddWithValue("@TOTALG21", SqlDbType.Int).Value = TextBox758.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG21MA", SqlDbType.Int).Value = TextBox759.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA1", SqlDbType.Int).Value = TextBox761.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA1_4", SqlDbType.Int).Value = TextBox762.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA5_9", SqlDbType.Int).Value = TextBox763.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA10_14", SqlDbType.Int).Value = TextBox764.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA15_19", SqlDbType.Int).Value = TextBox765.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA20_24", SqlDbType.Int).Value = TextBox766.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA25_49", SqlDbType.Int).Value = TextBox767.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21MA50", SqlDbType.Int).Value = TextBox768.Text.Trim();
        cmd2.Parameters.AddWithValue("@SUBG21FE", SqlDbType.Int).Value = TextBox760.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE1", SqlDbType.Int).Value = TextBox769.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE1_4", SqlDbType.Int).Value = TextBox770.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE5_9", SqlDbType.Int).Value = TextBox771.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE10_14", SqlDbType.Int).Value = TextBox772.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE15_19", SqlDbType.Int).Value = TextBox773.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE20_24", SqlDbType.Int).Value = TextBox774.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE25_49", SqlDbType.Int).Value = TextBox775.Text.Trim();
        cmd2.Parameters.AddWithValue("@G21FE50", SqlDbType.Int).Value = TextBox776.Text.Trim();
        int Rowsaffected3 = cmd2.ExecuteNonQuery();

        if (Rowsaffected1 != -1 && Rowsaffected2 != -1 && Rowsaffected3 != -1)
        {
            CLS_TB();
            webMessage.Show("Update TB "+Rowsaffected3 + " Successful");
            cmd.Dispose();
            cmd1.Dispose();
            cmd2.Dispose();
            return;
        }
                 }
                 catch (Exception ex)
                 {
                     webMessage.Show("ERROR UPDATING TB : " + ex.Message);
                     return;
                 }
            }
        }
       

    }
    //======== END TB1 and TB2

   
    private void Aggregate_HTC()
    {
        try
        {
            #region ======== Declearing Variables ======
            int DMA1 = 0;
            int DMA2 = 0;
            int DMA3 = 0;
            int DMA4 = 0;
            int DMA5 = 0;
            int DMA6 = 0;
            int DMA7 = 0;
            int DMA8 = 0;

            int DFE1 = 0;
            int DFE2 = 0;
            int DFE3 = 0;
            int DFE4 = 0;
            int DFE5 = 0;
            int DFE6 = 0;
            int DFE7 = 0;
            int DFE8 = 0;

            int PMA1 = 0;
            int PMA2 = 0;
            int PMA3 = 0;
            int PMA4 = 0;
            int PMA5 = 0;
            int PMA6 = 0;
            int PMA7 = 0;
            int PMA8 = 0;

            int PFE1 = 0;
            int PFE2 = 0;
            int PFE3 = 0;
            int PFE4 = 0;
            int PFE5 = 0;
            int PFE6 = 0;
            int PFE7 = 0;
            int PFE8 = 0;

            int TP1 = 0;
            int TP2 = 0;
            int TP3 = 0;
            int TP4 = 0;
            int TP5 = 0;
            int TP6 = 0;
            int TP7 = 0;
            int TP8 = 0;

            int TN1 = 0;
            int TN2 = 0;
            int TN3 = 0;
            int TN4 = 0;
            int TN5 = 0;
            int TN6 = 0;
            int TN7 = 0;
            int TN8 = 0;

            int NMA1 = 0;
            int NMA2 = 0;
            int NMA3 = 0;
            int NMA4 = 0;
            int NMA5 = 0;
            int NMA6 = 0;
            int NMA7 = 0;
            int NMA8 = 0;

            int NFE1 = 0;
            int NFE2 = 0;
            int NFE3 = 0;
            int NFE4 = 0;
            int NFE5 = 0;
            int NFE6 = 0;
            int NFE7 = 0;
            int NFE8 = 0;
            #endregion

            string SQL1 = "select * from tbl_TB1 where states ='" + mState + "' and lga='" + mLGA + "' and facname='" + mFacility + "' and months='" + mMnth + "' and years='" + mYr + "'";
            SQL1 += " and grouptype = '" + mChoose + "'";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            if (cn.State != ConnectionState.Open)
                cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                // Number of TB client both suspect who received C&T for HIV and received their test result
                //Male
                DMA1 = Convert.ToInt32(rd1["G1MA1"].ToString());
                DMA2 = Convert.ToInt32(rd1["G1MA1_4"].ToString());
                DMA3 = Convert.ToInt32(rd1["G1MA5_9"].ToString());
                DMA4 = Convert.ToInt32(rd1["G1MA10_14"].ToString());
                DMA5 = Convert.ToInt32(rd1["G1MA15_19"].ToString());
                DMA6 = Convert.ToInt32(rd1["G1MA20_24"].ToString());
                DMA7 = Convert.ToInt32(rd1["G1MA25_49"].ToString());
                DMA8 = Convert.ToInt32(rd1["G1MA50"].ToString());
                //Female
                DFE1 = Convert.ToInt32(rd1["G1FE1"].ToString());
                DFE2 = Convert.ToInt32(rd1["G1FE1_4"].ToString());
                DFE3 = Convert.ToInt32(rd1["G1FE5_9"].ToString());
                DFE4 = Convert.ToInt32(rd1["G1FE10_14"].ToString());
                DFE5 = Convert.ToInt32(rd1["G1FE15_19"].ToString());
                DFE6 = Convert.ToInt32(rd1["G1FE20_24"].ToString());
                DFE7 = Convert.ToInt32(rd1["G1FE25_49"].ToString());
                DFE8 = Convert.ToInt32(rd1["G1FE50"].ToString());

                //Number of TB client tested Positve for HIV
                //Male
                PMA1 = Convert.ToInt32(rd1["POS_G1MA1"].ToString());
                PMA2 = Convert.ToInt32(rd1["POS_G1MA1_4"].ToString());
                PMA3 = Convert.ToInt32(rd1["POS_G1MA5_9"].ToString());
                PMA4 = Convert.ToInt32(rd1["POS_G1MA10_14"].ToString());
                PMA5 = Convert.ToInt32(rd1["POS_G1MA15_19"].ToString());
                PMA6 = Convert.ToInt32(rd1["POS_G1MA20_24"].ToString());
                PMA7 = Convert.ToInt32(rd1["POS_G1MA25_49"].ToString());
                PMA8 = Convert.ToInt32(rd1["POS_G1MA50"].ToString());
                //Female
                PFE1 = Convert.ToInt32(rd1["POS_G1FE1"].ToString());
                PFE2 = Convert.ToInt32(rd1["POS_G1FE1_4"].ToString());
                PFE3 = Convert.ToInt32(rd1["POS_G1FE5_9"].ToString());
                PFE4 = Convert.ToInt32(rd1["POS_G1FE10_14"].ToString());
                PFE5 = Convert.ToInt32(rd1["POS_G1FE15_19"].ToString());
                PFE6 = Convert.ToInt32(rd1["POS_G1FE20_24"].ToString());
                PFE7 = Convert.ToInt32(rd1["POS_G1FE25_49"].ToString());
                PFE8 = Convert.ToInt32(rd1["POS_G1FE50"].ToString());
                //No of TB Client tested Nagative for HIV
                //MAle
                NMA1 = Convert.ToInt32(rd1["NEG_G1MA1"].ToString());
                NMA2 = Convert.ToInt32(rd1["NEG_G1MA1_4"].ToString());
                NMA3 = Convert.ToInt32(rd1["NEG_G1MA5_9"].ToString());
                NMA4 = Convert.ToInt32(rd1["NEG_G1MA10_14"].ToString());
                NMA5 = Convert.ToInt32(rd1["NEG_G1MA15_19"].ToString());
                NMA6 = Convert.ToInt32(rd1["NEG_G1MA20_24"].ToString());
                NMA7 = Convert.ToInt32(rd1["NEG_G1MA25_49"].ToString());
                NMA8 = Convert.ToInt32(rd1["NEG_G1MA50"].ToString());
                //Female
                NFE1 = Convert.ToInt32(rd1["NEG_G1FE1"].ToString());
                NFE2 = Convert.ToInt32(rd1["NEG_G1FE1_4"].ToString());
                NFE3 = Convert.ToInt32(rd1["NEG_G1FE5_9"].ToString());
                NFE4 = Convert.ToInt32(rd1["NEG_G1FE10_14"].ToString());
                NFE5 = Convert.ToInt32(rd1["NEG_G1FE15_19"].ToString());
                NFE6 = Convert.ToInt32(rd1["NEG_G1FE20_24"].ToString());
                NFE7 = Convert.ToInt32(rd1["NEG_G1FE25_49"].ToString());
                NFE8 = Convert.ToInt32(rd1["NEG_G1FE50"].ToString());
                //POSITIVE
                TP1 = PMA1 + PFE1;
                TP2 = PMA2 + PFE2;
                TP3 = PMA3 + PFE3;
                TP4 = PMA4 + PFE4;
                TP5 = PMA5 + PFE5;
                TP6 = PMA6 + PFE6;
                TP7 = PMA7 + PFE7;
                TP8 = PMA8 + PFE8;
                //NEGATIVE
                TN1 = NMA1 + NFE1;
                TN2 = NMA2 + NFE2;
                TN3 = NMA3 + NFE3;
                TN4 = NMA4 + NFE4;
                TN5 = NMA5 + NFE5;
                TN6 = NMA6 + NFE6;
                TN7 = NMA7 + NFE7;
                TN8 = NMA8 + NFE8;

            }
            rd1.Close();
            cmd1.Dispose();
            cn.Close();

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            string SQLHTC = "select * from tbl_HTC2 where states ='" + mState + "' and lga='" + mLGA + "' and facname='" + mFacility + "' and months='" + mMnth + "' and years='" + mYr + "'";
            // SQLHTC += " and grouptype = '" + mChoose + "'";
            SqlCommand cmd2 = new SqlCommand(SQLHTC, cn);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.HasRows == true)
            {
                while (rd2.Read())
                {
                    // == Read the Total number of people who C&T and recieved their result (PMTCT,HTC,TB)
                    //Male  iif( (t == 4) ? true : false );
                    DMA1 = ((rd2["G9MA1"].ToString() == string.Empty) ? DMA1 : DMA1 + Convert.ToInt32(rd2["G9MA1"].ToString()));
                    DMA2 = ((rd2["G9MA1_4"].ToString() ==string.Empty) ? DMA2 : DMA2 + Convert.ToInt32(rd2["G9MA1_4"].ToString()));
                    DMA3 = ((rd2["G9MA5_9"].ToString() == string.Empty) ? DMA3 :DMA3 +  Convert.ToInt32(rd2["G9MA5_9"].ToString()));
                    DMA4 = ((rd2["G9MA10_14"].ToString() == string.Empty) ? DMA4 :DMA4 + Convert.ToInt32(rd2["G9MA10_14"].ToString()));
                    DMA5 = ((rd2["G9MA15_19"].ToString() == string.Empty) ? DMA5 :DMA5 +  Convert.ToInt32(rd2["G9MA15_19"].ToString()));
                    DMA6 = ((rd2["G9MA20_24"].ToString() == string.Empty) ? DMA6 :DMA6 +  Convert.ToInt32(rd2["G9MA20_24"].ToString()));
                    DMA7 = ((rd2["G9MA25_49"].ToString() == string.Empty) ? DMA7 :DMA7 + Convert.ToInt32(rd2["G9MA25_49"].ToString()));
                    DMA8 = ((rd2["G9MA50"].ToString() == string.Empty) ? DMA8 :DMA8 + Convert.ToInt32(rd2["G9MA50"].ToString()));
                    //Female
                    DFE1 = ((rd2["G9FE1"].ToString() == string.Empty) ? DFE1 :DFE1 + Convert.ToInt32(rd2["G9FE1"].ToString()));
                    DFE2 = ((rd2["G9FE1_4"].ToString() == string.Empty) ? DFE2 :DFE2 +  Convert.ToInt32(rd2["G9FE1_4"].ToString()));
                    DFE3 = ((rd2["G9FE5_9"].ToString() == string.Empty) ? DFE3 :DFE3 +  Convert.ToInt32(rd2["G9FE5_9"].ToString()));
                    DFE4 = ((rd2["G9FE10_14"].ToString() == string.Empty) ? DFE4 :DFE4 +  Convert.ToInt32(rd2["G9FE10_14"].ToString()));
                    DFE5 = ((rd2["G9FE15_19"].ToString() == string.Empty) ? DFE5 :DFE5 + Convert.ToInt32(rd2["G9FE15_19"].ToString()));
                    DFE6 = ((rd2["G9FE20_24"].ToString() == string.Empty) ? DFE6 :DFE6 + Convert.ToInt32(rd2["G9FE20_24"].ToString()));
                    DFE7 = ((rd2["G9FE25_49"].ToString() == string.Empty) ? DFE7 :DFE7 + Convert.ToInt32(rd2["G9FE25_49"].ToString()));
                    DFE8 = ((rd2["G9FE50"].ToString() == string.Empty) ? DFE8 :DFE8 + Convert.ToInt32(rd2["G9FE50"].ToString()));

                    //=== Number of individual who recieve Councelling and Testing services for HIV and recieved their test results
                    //=== (PMTCT,HTC,TB) disggregated by by test results
                    //POSITIVE
                    TP1 = ((rd2["G10P1"].ToString() == string.Empty) ? TP1 : TP1 + Convert.ToInt32(rd2["G10P1"].ToString()));
                    TP2 = ((rd2["G10P1_4"].ToString() == string.Empty) ? TP2 : TP2 + Convert.ToInt32(rd2["G10P1_4"].ToString()));
                    TP3 = ((rd2["G10P5_9"].ToString() == string.Empty) ? TP3 : TP3 + Convert.ToInt32(rd2["G10P5_9"].ToString()));
                    TP4 = ((rd2["G10P10_14"].ToString() == string.Empty) ? TP4 : TP4 + Convert.ToInt32(rd2["G10P10_14"].ToString()));
                    TP5 = ((rd2["G10P15_19"].ToString() == string.Empty) ? TP5 : TP5 + Convert.ToInt32(rd2["G10P15_19"].ToString()));
                    TP6 = ((rd2["G10P20_24"].ToString() == string.Empty) ? TP6 : TP6 + Convert.ToInt32(rd2["G10P20_24"].ToString()));
                    TP7 = ((rd2["G10P25_49"].ToString() == string.Empty) ? TP7 : TP7 + Convert.ToInt32(rd2["G10P25_49"].ToString()));
                    TP8 = ((rd2["G10P50"].ToString() == string.Empty) ? TP8 : TP8 + Convert.ToInt32(rd2["G10P50"].ToString()));
                    //NAGATIVE
                    TN1 = ((rd2["G10P1"].ToString() == string.Empty) ? TN1 : TN1 + Convert.ToInt32(rd2["G10P1"].ToString()));
                    TN2 = ((rd2["G10P1_4"].ToString() == string.Empty) ? TN2 : TN2 + Convert.ToInt32(rd2["G10P1_4"].ToString()));
                    TN3 = ((rd2["G10P5_9"].ToString() == string.Empty) ? TN3 : TN3 + Convert.ToInt32(rd2["G10P5_9"].ToString()));
                    TN4 = ((rd2["G10P10_14"].ToString() == string.Empty) ? TN4 : TN4 + Convert.ToInt32(rd2["G10P10_14"].ToString()));
                    TN5 = ((rd2["G10P15_19"].ToString() == string.Empty) ? TN5 : TN5 + Convert.ToInt32(rd2["G10P15_19"].ToString()));
                    TN6 = ((rd2["G10P20_24"].ToString() == string.Empty) ? TN6 : TN6 + Convert.ToInt32(rd2["G10P20_24"].ToString()));
                    TN7 = ((rd2["G10P25_49"].ToString() == string.Empty) ? TN7 : TN7 + Convert.ToInt32(rd2["G10P25_49"].ToString()));
                    TN8 = ((rd2["G10P50"].ToString() == string.Empty) ? TN8 : TN8 + Convert.ToInt32(rd2["G10P50"].ToString()));

                    // == Read the Total number of people who where tested Positive and received their result (PMTCT,HTC,TB)
                    //Male
                    PMA1 += ((rd2["G11MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA1"].ToString()));
                    PMA2 += ((rd2["G11MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA1_4"].ToString()));
                    PMA3 += ((rd2["G11MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA5_9"].ToString()));
                    PMA4 += ((rd2["G11MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA10_14"].ToString()));
                    PMA5 += ((rd2["G11MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA15_19"].ToString()));
                    PMA6 += ((rd2["G11MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA20_24"].ToString()));
                    PMA7 += ((rd2["G11MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11MA25_49"].ToString()));
                    PMA8 += ((rd2["G11MA50"].ToString() == "") ? 0 : Convert.ToInt32(rd2["G11MA50"].ToString()));
                    //Female
                    PFE1 += ((rd2["G11FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE1"].ToString()));
                    PFE2 += ((rd2["G11FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE1_4"].ToString()));
                    PFE3 += ((rd2["G11FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE5_9"].ToString()));
                    PFE4 += ((rd2["G11FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE10_14"].ToString()));
                    PFE5 += ((rd2["G11FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE15_19"].ToString()));
                    PFE6 += ((rd2["G11FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE20_24"].ToString()));
                    PFE7 += ((rd2["G11FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE25_49"].ToString()));
                    PFE8 += ((rd2["G11FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G11FE50"].ToString()));
                    // == Read the Total number of people who where tested Negative and received their result (PMTCT,HTC,TB)
                    //Male
                    NMA1 += ((rd2["G12MA1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA1"].ToString()));
                    NMA2 += ((rd2["G12MA1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA1_4"].ToString()));
                    NMA3 += ((rd2["G12MA5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA5_9"].ToString()));
                    NMA4 += ((rd2["G12MA10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA10_14"].ToString()));
                    NMA5 += ((rd2["G12MA15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA15_19"].ToString()));
                    NMA6 += ((rd2["G12MA20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA20_24"].ToString()));
                    NMA7 += ((rd2["G12MA25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA25_49"].ToString()));
                    NMA8 += ((rd2["G12MA50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12MA50"].ToString()));
                    //Female
                    NFE1 += ((rd2["G12FE1"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE1"].ToString()));
                    NFE2 += ((rd2["G12FE1_4"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE1_4"].ToString()));
                    NFE3 += ((rd2["G12FE5_9"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE5_9"].ToString()));
                    NFE4 += ((rd2["G12FE10_14"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE10_14"].ToString()));
                    NFE5 += ((rd2["G12FE15_19"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE15_19"].ToString()));
                    NFE6 += ((rd2["G12FE20_24"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE20_24"].ToString()));
                    NFE7 += ((rd2["G12FE25_49"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE25_49"].ToString()));
                    NFE8 += ((rd2["G12FE50"].ToString() == string.Empty) ? 0 : Convert.ToInt32(rd2["G12FE50"].ToString()));
                }
                rd2.Close();
                cmd2.Dispose();
                cn.Close();

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //Update HTC2 with new Values
                string UPDATE_HTC = "UPDATE tbl_HTC2 SET G9MA1= @G9MA1,G9MA1_4= @G9MA1_4,G9MA5_9= @G9MA5_9,G9MA10_14= @G9MA10_14,G9MA15_19= @G9MA15_19,G9MA20_24= @G9MA20_24,";
                UPDATE_HTC += "G9MA25_49= @G9MA25_49,G9MA50= @G9MA50,G9FE1= @G9FE1,G9FE1_4= @G9FE1_4,G9FE5_9= @G9FE5_9,G9FE10_14= @G9FE10_14,G9FE15_19= @G9FE15_19,";
                UPDATE_HTC += "G9FE20_24= @G9FE20_24,G9FE25_49= @G9FE25_49,G9FE50= @G9FE50,G11MA1= @G11MA1,G11MA1_4= @G11MA1_4,G11MA5_9= @G11MA5_9,G11MA10_14= @G11MA10_14,";
                UPDATE_HTC += "G11MA15_19= @G11MA15_19,G11MA20_24= @G11MA20_24,G11MA25_49= @G11MA25_49,G11MA50= @G11MA50,G11FE1= @G11FE1,G11FE1_4= @G11FE1_4,G11FE5_9= @G11FE5_9,";
                UPDATE_HTC += "G11FE10_14= @G11FE10_14,G11FE15_19= @G11FE15_19,G11FE20_24= @G11FE20_24,G11FE25_49= @G11FE25_49,G11FE50= @G11FE50,G12MA1= @G12MA1,G12MA1_4= @G12MA1_4,";
                UPDATE_HTC += "G12MA5_9= @G12MA5_9,G12MA10_14= @G12MA10_14,G12MA15_19= @G12MA15_19,G12MA20_24= @G12MA20_24,G12MA25_49= @G12MA25_49,G12MA50= @G12MA50,G12FE1= @G12FE1,";
                UPDATE_HTC += "G12FE1_4= @G12FE1_4,G12FE5_9= @G12FE5_9,G12FE10_14= @G12FE10_14,G12FE15_19= @G12FE15_19,G12FE20_24= @G12FE20_24,G12FE25_49= @G12FE25_49,G12FE50= @G12FE50";
                UPDATE_HTC += " where states = @states and lga=@lga and facname=@facname and months=@months and years=@years AND grouptype=@grouptype";
                SqlCommand cmd3 = new SqlCommand(UPDATE_HTC, cn);

                cmd3.Parameters.AddWithValue("@states", SqlDbType.Int).Value = mState;
                cmd3.Parameters.AddWithValue("@lga", SqlDbType.Int).Value = mLGA;
                cmd3.Parameters.AddWithValue("@facname", SqlDbType.Int).Value = mFacility;
                cmd3.Parameters.AddWithValue("@months", SqlDbType.Int).Value = mMnth;
                cmd3.Parameters.AddWithValue("@years", SqlDbType.Int).Value = mYr;
                cmd3.Parameters.AddWithValue("@grouptype", SqlDbType.Int).Value = "HTC";
                //MALE
                cmd3.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = Convert.ToString(DMA1);
                cmd3.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = Convert.ToString(DMA2);
                cmd3.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = Convert.ToString(DMA3);
                cmd3.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = Convert.ToString(DMA4);
                cmd3.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = Convert.ToString(DMA5);
                cmd3.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = Convert.ToString(DMA6);
                cmd3.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = Convert.ToString(DMA7);
                cmd3.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = Convert.ToString(DMA8);
                //FEMALE
                cmd3.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = Convert.ToString(DFE1);
                cmd3.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = Convert.ToString(DFE2);
                cmd3.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = Convert.ToString(DFE3);
                cmd3.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = Convert.ToString(DFE4);
                cmd3.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = Convert.ToString(DFE5);
                cmd3.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = Convert.ToString(DFE6);
                cmd3.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = Convert.ToString(DFE7);
                cmd3.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = Convert.ToString(DFE8);

                // POSITIVE 
                cmd3.Parameters.AddWithValue("@G10P1", SqlDbType.Int).Value = Convert.ToString(TP1);
                cmd3.Parameters.AddWithValue("@G10P1_4", SqlDbType.Int).Value = Convert.ToString(TP2);
                cmd3.Parameters.AddWithValue("@G10P5_9", SqlDbType.Int).Value = Convert.ToString(TP3);
                cmd3.Parameters.AddWithValue("@G10P10_14", SqlDbType.Int).Value = Convert.ToString(TP4);
                cmd3.Parameters.AddWithValue("@G10P15_19", SqlDbType.Int).Value = Convert.ToString(TP5);
                cmd3.Parameters.AddWithValue("@G10P20_24", SqlDbType.Int).Value = Convert.ToString(TP6);
                cmd3.Parameters.AddWithValue("@G10P25_49", SqlDbType.Int).Value = Convert.ToString(TP7);
                cmd3.Parameters.AddWithValue("@G10P50", SqlDbType.Int).Value = Convert.ToString(TP8);
                //NEGATIVE
                cmd3.Parameters.AddWithValue("@G0N1", SqlDbType.Int).Value = Convert.ToString(TN1);
                cmd3.Parameters.AddWithValue("@G10N1_4", SqlDbType.Int).Value = Convert.ToString(TN2);
                cmd3.Parameters.AddWithValue("@G10N5_9", SqlDbType.Int).Value = Convert.ToString(TN3);
                cmd3.Parameters.AddWithValue("@G10N10_14", SqlDbType.Int).Value = Convert.ToString(TN4);
                cmd3.Parameters.AddWithValue("@G10N15_19", SqlDbType.Int).Value = Convert.ToString(TN5);
                cmd3.Parameters.AddWithValue("@G10N20_24", SqlDbType.Int).Value = Convert.ToString(TN6);
                cmd3.Parameters.AddWithValue("@G10N25_49", SqlDbType.Int).Value = Convert.ToString(TN7);
                cmd3.Parameters.AddWithValue("@G10N50", SqlDbType.Int).Value = Convert.ToString(TN8);//===================
                
                // POSITIVE MALE
                cmd3.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = Convert.ToString(PMA1);
                cmd3.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = Convert.ToString(PMA2);
                cmd3.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = Convert.ToString(PMA3);
                cmd3.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = Convert.ToString(PMA4);
                cmd3.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = Convert.ToString(PMA5);
                cmd3.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = Convert.ToString(PMA6);
                cmd3.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = Convert.ToString(PMA7);
                cmd3.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = Convert.ToString(PMA8);
                //POSITIVE FEMALE
                cmd3.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = Convert.ToString(PFE1);
                cmd3.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = Convert.ToString(PFE2);
                cmd3.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = Convert.ToString(PFE3);
                cmd3.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = Convert.ToString(PFE4);
                cmd3.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = Convert.ToString(PFE5);
                cmd3.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = Convert.ToString(PFE6);
                cmd3.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = Convert.ToString(PFE7);
                cmd3.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = Convert.ToString(PFE8);
                // NAGATIVE MALE
                cmd3.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = Convert.ToString(NMA1);
                cmd3.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = Convert.ToString(NMA2);
                cmd3.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = Convert.ToString(NMA3);
                cmd3.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = Convert.ToString(NMA4);
                cmd3.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = Convert.ToString(NMA5);
                cmd3.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = Convert.ToString(NMA6);
                cmd3.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = Convert.ToString(NMA7);
                cmd3.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = Convert.ToString(NMA8);
                //NAGATIVE FEMALE
                cmd3.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = Convert.ToString(NFE1);
                cmd3.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = Convert.ToString(NFE2);
                cmd3.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = Convert.ToString(NFE3);
                cmd3.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = Convert.ToString(NFE4);
                cmd3.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = Convert.ToString(NFE5);
                cmd3.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = Convert.ToString(NFE6);
                cmd3.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = Convert.ToString(NFE7);
                cmd3.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = Convert.ToString(NFE8);
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                cn.Close();


               // SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                string SQLHTC1 = "UPDATE tbl_HTC1 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype";
                SQLHTC1 += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype";
                SqlCommand cmdHTC1 = new SqlCommand(SQLHTC1, cn);
                cmdHTC1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                cmdHTC1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                cmdHTC1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                cmdHTC1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                cmdHTC1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                cmdHTC1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
                cmdHTC1.ExecuteNonQuery();
                cn.Close();

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                string SQLHTC2 = "INSERT INTO tbl_HTC3 states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype";
                SQLHTC2 += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";
                SqlCommand cmdHTC2 = new SqlCommand(SQLHTC2, cn);
                cmdHTC2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                cmdHTC2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                cmdHTC2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                cmdHTC2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                cmdHTC2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                cmdHTC2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
                cmdHTC2.ExecuteNonQuery();
                cn.Close();


            }
            else
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //INSERT HTC2 with new Values
                string UPDATE_HTC = "INSERT INTO tbl_HTC2 (states,lga,facname,months,years,grouptype,G9MA1,G9MA1_4,G9MA5_9,G9MA10_14,G9MA15_19,G9MA20_24,G9MA25_49,G9MA50,G9FE1,G9FE1_4,G9FE5_9,G9FE10_14,G9FE15_19,";
                UPDATE_HTC += "G9FE20_24,G9FE25_4,G9FE50,G11MA1,G11MA1_4,G11MA5_9,G11MA10_14,G11MA15_19,G11MA20_24,G11MA25_49,G11MA50,G11FE1,G11FE1_4,G11FE5_9,G11FE10_14,";
                UPDATE_HTC += "G11FE15_19,G11FE20_24,G11FE25_49,G11FE50,G12MA1,G12MA1_4,G12MA5_9,G12MA10_14,G12MA15_19,G12MA20_24,G12MA25_49,G12MA50,G12FE1,G12FE1_4,";
                UPDATE_HTC += "G12FE5_9,G12FE10_14,G12FE15_19,G12FE20_24,G12FE25_49,G12FE50)";
                UPDATE_HTC = "VALUES (@states,@lga,@facname,@months,@years,@grouptype,@G9MA1,@G9MA1_4,@G9MA5_9,@G9MA10_14,@G9MA15_19,@G9MA20_24,@G9MA25_49,@G9MA50,@G9FE1,@G9FE1_4,@G9FE5_9,@G9FE10_14,@G9FE15_19,@G9FE20_24,@G9FE25_4,@G9FE50,";
                UPDATE_HTC += "@G11MA1,@G11MA1_4,@G11MA5_9,@G11MA10_14,@G11MA15_19,@G11MA20_24,@G11MA25_49,@G11MA50,@G11FE1,@G11FE1_4,@G11FE5_9,@G11FE10_14,@G11FE15_19,@G11FE20_24,@G11FE25_49,";
                UPDATE_HTC += "@G11FE50,@G12MA1,@G12MA1_4,@G12MA5_9,@G12MA10_14,@G12MA15_19,@G12MA20_24,@G12MA25_49,@G12MA50,@G12FE1,@G12FE1_4,@G12FE5_9,@G12FE10_14,@G12FE15_19,@G12FE20_24,@G12FE25_49,@G12FE50)";

                SqlCommand cmd3 = new SqlCommand(UPDATE_HTC, cn);
                cmd3.Parameters.AddWithValue("@states", SqlDbType.Int).Value = mState;
                cmd3.Parameters.AddWithValue("@lga", SqlDbType.Int).Value = mLGA;
                cmd3.Parameters.AddWithValue("@facname", SqlDbType.Int).Value = mFacility;
                cmd3.Parameters.AddWithValue("@months", SqlDbType.Int).Value = mMnth;
                cmd3.Parameters.AddWithValue("@years", SqlDbType.Int).Value = mYr;
                cmd3.Parameters.AddWithValue("@grouptype", SqlDbType.Int).Value = "HTC";
                //MALE
                cmd3.Parameters.AddWithValue("@G9MA1", SqlDbType.Int).Value = Convert.ToString(DMA1);
                cmd3.Parameters.AddWithValue("@G9MA1_4", SqlDbType.Int).Value = Convert.ToString(DMA2);
                cmd3.Parameters.AddWithValue("@G9MA5_9", SqlDbType.Int).Value = Convert.ToString(DMA3);
                cmd3.Parameters.AddWithValue("@G9MA10_14", SqlDbType.Int).Value = Convert.ToString(DMA4);
                cmd3.Parameters.AddWithValue("@G9MA15_19", SqlDbType.Int).Value = Convert.ToString(DMA5);
                cmd3.Parameters.AddWithValue("@G9MA20_24", SqlDbType.Int).Value = Convert.ToString(DMA6);
                cmd3.Parameters.AddWithValue("@G9MA25_49", SqlDbType.Int).Value = Convert.ToString(DMA7);
                cmd3.Parameters.AddWithValue("@G9MA50", SqlDbType.Int).Value = Convert.ToString(DMA8);
                //FEMALE
                cmd3.Parameters.AddWithValue("@G9FE1", SqlDbType.Int).Value = Convert.ToString(DFE1);
                cmd3.Parameters.AddWithValue("@G9FE1_4", SqlDbType.Int).Value = Convert.ToString(DFE2);
                cmd3.Parameters.AddWithValue("@G9FE5_9", SqlDbType.Int).Value = Convert.ToString(DFE3);
                cmd3.Parameters.AddWithValue("@G9FE10_14", SqlDbType.Int).Value = Convert.ToString(DFE4);
                cmd3.Parameters.AddWithValue("@G9FE15_19", SqlDbType.Int).Value = Convert.ToString(DFE5);
                cmd3.Parameters.AddWithValue("@G9FE20_24", SqlDbType.Int).Value = Convert.ToString(DFE6);
                cmd3.Parameters.AddWithValue("@G9FE25_49", SqlDbType.Int).Value = Convert.ToString(DFE7);
                cmd3.Parameters.AddWithValue("@G9FE50", SqlDbType.Int).Value = Convert.ToString(DFE8);

                // POSITIVE 
                cmd3.Parameters.AddWithValue("@G10P1", SqlDbType.Int).Value = Convert.ToString(TP1);
                cmd3.Parameters.AddWithValue("@G10P1_4", SqlDbType.Int).Value = Convert.ToString(TP2);
                cmd3.Parameters.AddWithValue("@G10P5_9", SqlDbType.Int).Value = Convert.ToString(TP3);
                cmd3.Parameters.AddWithValue("@G10P10_14", SqlDbType.Int).Value = Convert.ToString(TP4);
                cmd3.Parameters.AddWithValue("@G10P15_19", SqlDbType.Int).Value = Convert.ToString(TP5);
                cmd3.Parameters.AddWithValue("@G10P20_24", SqlDbType.Int).Value = Convert.ToString(TP6);
                cmd3.Parameters.AddWithValue("@G10P25_49", SqlDbType.Int).Value = Convert.ToString(TP7);
                cmd3.Parameters.AddWithValue("@G10P50", SqlDbType.Int).Value = Convert.ToString(TP8);
                //NEGATIVE
                cmd3.Parameters.AddWithValue("@G0N1", SqlDbType.Int).Value = Convert.ToString(TN1);
                cmd3.Parameters.AddWithValue("@G10N1_4", SqlDbType.Int).Value = Convert.ToString(TN2);
                cmd3.Parameters.AddWithValue("@G10N5_9", SqlDbType.Int).Value = Convert.ToString(TN3);
                cmd3.Parameters.AddWithValue("@G10N10_14", SqlDbType.Int).Value = Convert.ToString(TN4);
                cmd3.Parameters.AddWithValue("@G10N15_19", SqlDbType.Int).Value = Convert.ToString(TN5);
                cmd3.Parameters.AddWithValue("@G10N20_24", SqlDbType.Int).Value = Convert.ToString(TN6);
                cmd3.Parameters.AddWithValue("@G10N25_49", SqlDbType.Int).Value = Convert.ToString(TN7);
                cmd3.Parameters.AddWithValue("@G10N50", SqlDbType.Int).Value = Convert.ToString(TN8);//===================

                // POSITIVE MALE
                cmd3.Parameters.AddWithValue("@G11MA1", SqlDbType.Int).Value = Convert.ToString(PMA1);
                cmd3.Parameters.AddWithValue("@G11MA1_4", SqlDbType.Int).Value = Convert.ToString(PMA2);
                cmd3.Parameters.AddWithValue("@G11MA5_9", SqlDbType.Int).Value = Convert.ToString(PMA3);
                cmd3.Parameters.AddWithValue("@G11MA10_14", SqlDbType.Int).Value = Convert.ToString(PMA4);
                cmd3.Parameters.AddWithValue("@G11MA15_19", SqlDbType.Int).Value = Convert.ToString(PMA5);
                cmd3.Parameters.AddWithValue("@G11MA20_24", SqlDbType.Int).Value = Convert.ToString(PMA6);
                cmd3.Parameters.AddWithValue("@G11MA25_49", SqlDbType.Int).Value = Convert.ToString(PMA7);
                cmd3.Parameters.AddWithValue("@G11MA50", SqlDbType.Int).Value = Convert.ToString(PMA8);
                //POSITIVE FEMALE
                cmd3.Parameters.AddWithValue("@G11FE1", SqlDbType.Int).Value = Convert.ToString(PFE1);
                cmd3.Parameters.AddWithValue("@G11FE1_4", SqlDbType.Int).Value = Convert.ToString(PFE2);
                cmd3.Parameters.AddWithValue("@G11FE5_9", SqlDbType.Int).Value = Convert.ToString(PFE3);
                cmd3.Parameters.AddWithValue("@G11FE10_14", SqlDbType.Int).Value = Convert.ToString(PFE4);
                cmd3.Parameters.AddWithValue("@G11FE15_19", SqlDbType.Int).Value = Convert.ToString(PFE5);
                cmd3.Parameters.AddWithValue("@G11FE20_24", SqlDbType.Int).Value = Convert.ToString(PFE6);
                cmd3.Parameters.AddWithValue("@G11FE25_49", SqlDbType.Int).Value = Convert.ToString(PFE7);
                cmd3.Parameters.AddWithValue("@G11FE50", SqlDbType.Int).Value = Convert.ToString(PFE8);
                // NAGATIVE MALE
                cmd3.Parameters.AddWithValue("@G12MA1", SqlDbType.Int).Value = Convert.ToString(NMA1);
                cmd3.Parameters.AddWithValue("@G12MA1_4", SqlDbType.Int).Value = Convert.ToString(NMA2);
                cmd3.Parameters.AddWithValue("@G12MA5_9", SqlDbType.Int).Value = Convert.ToString(NMA3);
                cmd3.Parameters.AddWithValue("@G12MA10_14", SqlDbType.Int).Value = Convert.ToString(NMA4);
                cmd3.Parameters.AddWithValue("@G12MA15_19", SqlDbType.Int).Value = Convert.ToString(NMA5);
                cmd3.Parameters.AddWithValue("@G12MA20_24", SqlDbType.Int).Value = Convert.ToString(NMA6);
                cmd3.Parameters.AddWithValue("@G12MA25_49", SqlDbType.Int).Value = Convert.ToString(NMA7);
                cmd3.Parameters.AddWithValue("@G12MA50", SqlDbType.Int).Value = Convert.ToString(NMA8);
                //NAGATIVE FEMALE
                cmd3.Parameters.AddWithValue("@G12FE1", SqlDbType.Int).Value = Convert.ToString(NFE1);
                cmd3.Parameters.AddWithValue("@G12FE1_4", SqlDbType.Int).Value = Convert.ToString(NFE2);
                cmd3.Parameters.AddWithValue("@G12FE5_9", SqlDbType.Int).Value = Convert.ToString(NFE3);
                cmd3.Parameters.AddWithValue("@G12FE10_14", SqlDbType.Int).Value = Convert.ToString(NFE4);
                cmd3.Parameters.AddWithValue("@G12FE15_19", SqlDbType.Int).Value = Convert.ToString(NFE5);
                cmd3.Parameters.AddWithValue("@G12FE20_24", SqlDbType.Int).Value = Convert.ToString(NFE6);
                cmd3.Parameters.AddWithValue("@G12FE25_49", SqlDbType.Int).Value = Convert.ToString(NFE7);
                cmd3.Parameters.AddWithValue("@G12FE50", SqlDbType.Int).Value = Convert.ToString(NFE8);
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                cn.Close();

                if(cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                string SQLHTC1 = "INSERT INTO tbl_HTC1 VALUES(@states,@lga,@facname,@months,@years,@grouptype)";
            SqlCommand cmdHTC1 = new SqlCommand(SQLHTC1, cn);
            cmdHTC1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
            cmdHTC1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
            cmdHTC1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
            cmdHTC1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
            cmdHTC1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
            cmdHTC1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
            cmdHTC1.ExecuteNonQuery();
            cn.Close();

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            string SQLHTC2 = "INSERT INTO tbl_HTC3 VALUES(@states,@lga,@facname,@months,@years,@grouptype)";
            SqlCommand cmdHTC2 = new SqlCommand(SQLHTC2, cn);
            cmdHTC2.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
            cmdHTC2.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
            cmdHTC2.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
            cmdHTC2.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
            cmdHTC2.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
            cmdHTC2.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = "HTC";
            cmdHTC2.ExecuteNonQuery();
            cn.Close();
            
            }

        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert('" + ex.Message.Trim() + "');</script>");
            return;
        }
    }


    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
         mState = (string)Session["mstate"];
        mLGA = (string)Session["mLga"];
        mFacility = (string)Session["mFacility"];
        mMnth = (string)Session["mMnth"];
        mYr = (string)Session["mYr"];
        mFile = (string)Session["mFile"];
        mChoose = (string)Session["mChoose"];

        switch (mChoose)
        {
            case "TB":
                SAVE_TB();
                break;
            case "LAB":
              SAVE_LAB();
              break;
        }
   }


    
    protected void Button48_Click(object sender, EventArgs e)
    {
        TextBox331.Text = Convert.ToString(Convert.ToInt32(TextBox332.Text) + Convert.ToInt32(TextBox333.Text) + Convert.ToInt32(TextBox334.Text)
                         + Convert.ToInt32(TextBox335.Text) + Convert.ToInt32(TextBox336.Text) + Convert.ToInt32(TextBox337.Text) + Convert.ToInt32(TextBox338.Text)
                          + Convert.ToInt32(TextBox339.Text));
        TextBox340.Focus();
    }
    protected void Button49_Click(object sender, EventArgs e)
    {
        TextBox348.Text = Convert.ToString(Convert.ToInt32(TextBox340.Text) + Convert.ToInt32(TextBox341.Text) + Convert.ToInt32(TextBox342.Text) + Convert.ToInt32(TextBox343.Text)
                        + Convert.ToInt32(TextBox344.Text) + Convert.ToInt32(TextBox345.Text) + Convert.ToInt32(TextBox346.Text) + Convert.ToInt32(TextBox347.Text));
        TextBox330.Text = Convert.ToString(Convert.ToInt32(TextBox331.Text) + Convert.ToInt32(TextBox348.Text));
        TextBox351.Focus();
    }
    protected void Button50_Click(object sender, EventArgs e)
    {
        TextBox350.Text = Convert.ToString(Convert.ToInt32(TextBox351.Text) + Convert.ToInt32(TextBox352.Text) + Convert.ToInt32(TextBox353.Text)
                        + Convert.ToInt32(TextBox354.Text) + Convert.ToInt32(TextBox355.Text) + Convert.ToInt32(TextBox356.Text) + Convert.ToInt32(TextBox357.Text)
                         + Convert.ToInt32(TextBox358.Text));
        TextBox360.Focus();
    }
    protected void Button51_Click(object sender, EventArgs e)
    {
        TextBox359.Text = Convert.ToString(Convert.ToInt32(TextBox360.Text) + Convert.ToInt32(TextBox361.Text) + Convert.ToInt32(TextBox362.Text) + Convert.ToInt32(TextBox363.Text)
                        + Convert.ToInt32(TextBox364.Text) + Convert.ToInt32(TextBox365.Text) + Convert.ToInt32(TextBox366.Text) + Convert.ToInt32(TextBox367.Text));
        TextBox349.Text = Convert.ToString(Convert.ToInt32(TextBox350.Text) + Convert.ToInt32(TextBox359.Text));
        TextBox370.Focus();
    }
    protected void Button52_Click(object sender, EventArgs e)
    {
        TextBox369.Text = Convert.ToString(Convert.ToInt32(TextBox370.Text) + Convert.ToInt32(TextBox371.Text) + Convert.ToInt32(TextBox372.Text)
                         + Convert.ToInt32(TextBox373.Text) + Convert.ToInt32(TextBox374.Text) + Convert.ToInt32(TextBox375.Text) + Convert.ToInt32(TextBox376.Text)
                          + Convert.ToInt32(TextBox377.Text));
        TextBox379.Focus();
    }
    protected void Button53_Click(object sender, EventArgs e)
    {
        TextBox378.Text = Convert.ToString(Convert.ToInt32(TextBox379.Text) + Convert.ToInt32(TextBox380.Text) + Convert.ToInt32(TextBox381.Text) + Convert.ToInt32(TextBox382.Text)
                  + Convert.ToInt32(TextBox383.Text) + Convert.ToInt32(TextBox384.Text) + Convert.ToInt32(TextBox385.Text) + Convert.ToInt32(TextBox386.Text));
        TextBox368.Text = Convert.ToString(Convert.ToInt32(TextBox369.Text) + Convert.ToInt32(TextBox378.Text));
        TextBox390.Focus();
    }
    protected void Button54_Click(object sender, EventArgs e)
    {
        TextBox388.Text = Convert.ToString(Convert.ToInt32(TextBox390.Text) + Convert.ToInt32(TextBox391.Text) + Convert.ToInt32(TextBox392.Text)
                      + Convert.ToInt32(TextBox393.Text) + Convert.ToInt32(TextBox394.Text) + Convert.ToInt32(TextBox395.Text) + Convert.ToInt32(TextBox396.Text)
                       + Convert.ToInt32(TextBox397.Text));
        TextBox398.Focus();
    }
    protected void Button55_Click(object sender, EventArgs e)
    {
        TextBox389.Text = Convert.ToString(Convert.ToInt32(TextBox398.Text) + Convert.ToInt32(TextBox399.Text) + Convert.ToInt32(TextBox400.Text) + Convert.ToInt32(TextBox401.Text)
                 + Convert.ToInt32(TextBox402.Text) + Convert.ToInt32(TextBox403.Text) + Convert.ToInt32(TextBox404.Text) + Convert.ToInt32(TextBox405.Text));
        TextBox387.Text = Convert.ToString(Convert.ToInt32(TextBox388.Text) + Convert.ToInt32(TextBox389.Text));
        TextBox408.Focus();
    }
    protected void Button56_Click(object sender, EventArgs e)
    {
        TextBox407.Text = Convert.ToString(Convert.ToInt32(TextBox408.Text) + Convert.ToInt32(TextBox409.Text) + Convert.ToInt32(TextBox410.Text) + Convert.ToInt32(TextBox411.Text)
                         + Convert.ToInt32(TextBox412.Text) + Convert.ToInt32(TextBox413.Text) + Convert.ToInt32(TextBox414.Text) + Convert.ToInt32(TextBox415.Text));
        TextBox416.Focus();
    }
    protected void Button57_Click(object sender, EventArgs e)
    {
        TextBox424.Text = Convert.ToString(Convert.ToInt32(TextBox416.Text) + Convert.ToInt32(TextBox417.Text) + Convert.ToInt32(TextBox418.Text) + Convert.ToInt32(TextBox419.Text)
            + Convert.ToInt32(TextBox420.Text) + Convert.ToInt32(TextBox421.Text) + Convert.ToInt32(TextBox422.Text) + Convert.ToInt32(TextBox423.Text));
        TextBox406.Text = Convert.ToString(Convert.ToInt32(TextBox407.Text) + Convert.ToInt32(TextBox424.Text));
        TextBox427.Focus();
    }
    protected void Button58_Click(object sender, EventArgs e)
    {
        TextBox426.Text = Convert.ToString(Convert.ToInt32(TextBox427.Text) + Convert.ToInt32(TextBox428.Text) + Convert.ToInt32(TextBox429.Text) + Convert.ToInt32(TextBox430.Text)
                          + Convert.ToInt32(TextBox431.Text) + Convert.ToInt32(TextBox432.Text) + Convert.ToInt32(TextBox433.Text) + Convert.ToInt32(TextBox434.Text));
        TextBox435.Focus();
    }
    protected void Button59_Click(object sender, EventArgs e)
    {
        TextBox443.Text = Convert.ToString(Convert.ToInt32(TextBox435.Text) + Convert.ToInt32(TextBox436.Text) + Convert.ToInt32(TextBox437.Text) + Convert.ToInt32(TextBox438.Text)
                        + Convert.ToInt32(TextBox439.Text) + Convert.ToInt32(TextBox440.Text) + Convert.ToInt32(TextBox441.Text) + Convert.ToInt32(TextBox442.Text));
        TextBox425.Text = Convert.ToString(Convert.ToInt32(TextBox426.Text) + Convert.ToInt32(TextBox443.Text));
        TextBox446.Focus();
    }
    protected void Button60_Click(object sender, EventArgs e)
    {
        TextBox445.Text = Convert.ToString(Convert.ToInt32(TextBox446.Text) + Convert.ToInt32(TextBox447.Text) + Convert.ToInt32(TextBox448.Text) + Convert.ToInt32(TextBox449.Text)
                        + Convert.ToInt32(TextBox450.Text) + Convert.ToInt32(TextBox451.Text) + Convert.ToInt32(TextBox452.Text) + Convert.ToInt32(TextBox453.Text));
        TextBox455.Focus();
    }
    protected void Button61_Click(object sender, EventArgs e)
    {
        TextBox454.Text = Convert.ToString(Convert.ToInt32(TextBox455.Text) + Convert.ToInt32(TextBox456.Text) + Convert.ToInt32(TextBox457.Text) + Convert.ToInt32(TextBox458.Text)
                        + Convert.ToInt32(TextBox459.Text) + Convert.ToInt32(TextBox460.Text) + Convert.ToInt32(TextBox461.Text) + Convert.ToInt32(TextBox462.Text));
        TextBox444.Text = Convert.ToString(Convert.ToInt32(TextBox445.Text) + Convert.ToInt32(TextBox454.Text));
        TextBox465.Focus();
    }
    protected void Button62_Click(object sender, EventArgs e)
    {
        TextBox464.Text = Convert.ToString(Convert.ToInt32(TextBox465.Text) + Convert.ToInt32(TextBox466.Text) + Convert.ToInt32(TextBox467.Text) + Convert.ToInt32(TextBox468.Text)
                       + Convert.ToInt32(TextBox469.Text) + Convert.ToInt32(TextBox470.Text) + Convert.ToInt32(TextBox471.Text) + Convert.ToInt32(TextBox472.Text));
        TextBox473.Focus();
    }
    protected void Button63_Click(object sender, EventArgs e)
    {
        TextBox481.Text = Convert.ToString(Convert.ToInt32(TextBox473.Text) + Convert.ToInt32(TextBox474.Text) + Convert.ToInt32(TextBox475.Text) + Convert.ToInt32(TextBox476.Text)
                       + Convert.ToInt32(TextBox477.Text) + Convert.ToInt32(TextBox478.Text) + Convert.ToInt32(TextBox479.Text) + Convert.ToInt32(TextBox480.Text));
        TextBox463.Text = Convert.ToString(Convert.ToInt32(TextBox464.Text) + Convert.ToInt32(TextBox481.Text));
        TextBox485.Focus();
    }
    protected void Button64_Click(object sender, EventArgs e)
    {
        TextBox483.Text = Convert.ToString(Convert.ToInt32(TextBox485.Text) + Convert.ToInt32(TextBox486.Text) + Convert.ToInt32(TextBox487.Text) + Convert.ToInt32(TextBox488.Text)
                       + Convert.ToInt32(TextBox489.Text) + Convert.ToInt32(TextBox490.Text) + Convert.ToInt32(TextBox491.Text) + Convert.ToInt32(TextBox492.Text));
        TextBox493.Focus();
    }
    protected void Button65_Click(object sender, EventArgs e)
    {
        TextBox484.Text = Convert.ToString(Convert.ToInt32(TextBox493.Text) + Convert.ToInt32(TextBox494.Text) + Convert.ToInt32(TextBox495.Text) + Convert.ToInt32(TextBox496.Text)
                       + Convert.ToInt32(TextBox497.Text) + Convert.ToInt32(TextBox498.Text) + Convert.ToInt32(TextBox499.Text) + Convert.ToInt32(TextBox500.Text));
        TextBox482.Text = Convert.ToString(Convert.ToInt32(TextBox483.Text) + Convert.ToInt32(TextBox484.Text));
        TextBox504.Focus();
    }
    protected void Button66_Click(object sender, EventArgs e)
    {
        TextBox502.Text = Convert.ToString(Convert.ToInt32(TextBox504.Text) + Convert.ToInt32(TextBox505.Text) + Convert.ToInt32(TextBox506.Text) + Convert.ToInt32(TextBox507.Text)
                     + Convert.ToInt32(TextBox508.Text) + Convert.ToInt32(TextBox509.Text) + Convert.ToInt32(TextBox510.Text) + Convert.ToInt32(TextBox511.Text));
        TextBox512.Focus();
    }
    protected void Button67_Click(object sender, EventArgs e)
    {
        TextBox503.Text = Convert.ToString(Convert.ToInt32(TextBox512.Text) + Convert.ToInt32(TextBox513.Text) + Convert.ToInt32(TextBox514.Text) + Convert.ToInt32(TextBox515.Text)
                     + Convert.ToInt32(TextBox516.Text) + Convert.ToInt32(TextBox517.Text) + Convert.ToInt32(TextBox518.Text) + Convert.ToInt32(TextBox519.Text));
        TextBox501.Text = Convert.ToString(Convert.ToInt32(TextBox502.Text) + Convert.ToInt32(TextBox503.Text));
        TextBox523.Focus();
    }
    protected void Button68_Click(object sender, EventArgs e)
    {
        TextBox521.Text = Convert.ToString(Convert.ToInt32(TextBox523.Text) + Convert.ToInt32(TextBox524.Text) + Convert.ToInt32(TextBox525.Text) + Convert.ToInt32(TextBox526.Text)
                    + Convert.ToInt32(TextBox527.Text) + Convert.ToInt32(TextBox528.Text) + Convert.ToInt32(TextBox529.Text) + Convert.ToInt32(TextBox530.Text));
        TextBox531.Focus();
    }
    protected void Button69_Click(object sender, EventArgs e)
    {
        TextBox522.Text = Convert.ToString(Convert.ToInt32(TextBox531.Text) + Convert.ToInt32(TextBox532.Text) + Convert.ToInt32(TextBox533.Text) + Convert.ToInt32(TextBox534.Text)
                     + Convert.ToInt32(TextBox535.Text) + Convert.ToInt32(TextBox536.Text) + Convert.ToInt32(TextBox537.Text) + Convert.ToInt32(TextBox538.Text));
        TextBox520.Text = Convert.ToString(Convert.ToInt32(TextBox521.Text) + Convert.ToInt32(TextBox522.Text));
        TextBox542.Focus();
    }
    protected void Button70_Click(object sender, EventArgs e)
    {
        TextBox540.Text = Convert.ToString(Convert.ToInt32(TextBox542.Text) + Convert.ToInt32(TextBox543.Text) + Convert.ToInt32(TextBox544.Text) + Convert.ToInt32(TextBox545.Text)
                + Convert.ToInt32(TextBox546.Text) + Convert.ToInt32(TextBox547.Text) + Convert.ToInt32(TextBox548.Text) + Convert.ToInt32(TextBox549.Text));
        TextBox550.Focus();
    }
    protected void Button71_Click(object sender, EventArgs e)
    {
        TextBox541.Text = Convert.ToString(Convert.ToInt32(TextBox550.Text) + Convert.ToInt32(TextBox551.Text) + Convert.ToInt32(TextBox552.Text) + Convert.ToInt32(TextBox553.Text)
                    + Convert.ToInt32(TextBox554.Text) + Convert.ToInt32(TextBox555.Text) + Convert.ToInt32(TextBox556.Text) + Convert.ToInt32(TextBox557.Text));
        TextBox539.Text = Convert.ToString(Convert.ToInt32(TextBox540.Text) + Convert.ToInt32(TextBox541.Text));
        TextBox779.Focus();
    }
    protected void Button72_Click(object sender, EventArgs e)
    {
        TextBox778.Text = Convert.ToString(Convert.ToInt32(TextBox779.Text) + Convert.ToInt32(TextBox780.Text) + Convert.ToInt32(TextBox781.Text) + Convert.ToInt32(TextBox782.Text)
               + Convert.ToInt32(TextBox783.Text) + Convert.ToInt32(TextBox784.Text) + Convert.ToInt32(TextBox785.Text) + Convert.ToInt32(TextBox786.Text));
        TextBox788.Focus();
    }
    protected void Button73_Click(object sender, EventArgs e)
    {
        TextBox787.Text = Convert.ToString(Convert.ToInt32(TextBox788.Text) + Convert.ToInt32(TextBox789.Text) + Convert.ToInt32(TextBox790.Text) + Convert.ToInt32(TextBox791.Text)
                   + Convert.ToInt32(TextBox792.Text) + Convert.ToInt32(TextBox793.Text) + Convert.ToInt32(TextBox794.Text) + Convert.ToInt32(TextBox795.Text));
        TextBox777.Text = Convert.ToString(Convert.ToInt32(TextBox778.Text) + Convert.ToInt32(TextBox787.Text));
        TextBox560.Focus();
    }
    protected void Button74_Click(object sender, EventArgs e)
    {
        TextBox559.Text = Convert.ToString(Convert.ToInt32(TextBox560.Text) + Convert.ToInt32(TextBox561.Text) + Convert.ToInt32(TextBox562.Text) + Convert.ToInt32(TextBox563.Text)
               + Convert.ToInt32(TextBox564.Text) + Convert.ToInt32(TextBox565.Text) + Convert.ToInt32(TextBox566.Text) + Convert.ToInt32(TextBox567.Text));
        TextBox568.Focus();
    }
    protected void Button75_Click(object sender, EventArgs e)
    {
        TextBox576.Text = Convert.ToString(Convert.ToInt32(TextBox568.Text) + Convert.ToInt32(TextBox569.Text) + Convert.ToInt32(TextBox570.Text) + Convert.ToInt32(TextBox571.Text)
                + Convert.ToInt32(TextBox572.Text) + Convert.ToInt32(TextBox573.Text) + Convert.ToInt32(TextBox574.Text) + Convert.ToInt32(TextBox575.Text));
        TextBox558.Text = Convert.ToString(Convert.ToInt32(TextBox559.Text) + Convert.ToInt32(TextBox576.Text));
        TextBox579.Focus();
    }
    protected void Button76_Click(object sender, EventArgs e)
    {
        TextBox578.Text = Convert.ToString(Convert.ToInt32(TextBox579.Text) + Convert.ToInt32(TextBox580.Text) + Convert.ToInt32(TextBox581.Text) + Convert.ToInt32(TextBox582.Text)
                + Convert.ToInt32(TextBox583.Text) + Convert.ToInt32(TextBox584.Text) + Convert.ToInt32(TextBox585.Text) + Convert.ToInt32(TextBox586.Text));
        TextBox587.Focus();
    }
    protected void Button77_Click(object sender, EventArgs e)
    {
        TextBox595.Text = Convert.ToString(Convert.ToInt32(TextBox587.Text) + Convert.ToInt32(TextBox588.Text) + Convert.ToInt32(TextBox589.Text) + Convert.ToInt32(TextBox590.Text)
              + Convert.ToInt32(TextBox591.Text) + Convert.ToInt32(TextBox592.Text) + Convert.ToInt32(TextBox593.Text) + Convert.ToInt32(TextBox594.Text));
        TextBox577.Text = Convert.ToString(Convert.ToInt32(TextBox578.Text) + Convert.ToInt32(TextBox595.Text));
        TextBox598.Focus();
    }
    protected void Button78_Click(object sender, EventArgs e)
    {
        TextBox597.Text = Convert.ToString(Convert.ToInt32(TextBox598.Text) + Convert.ToInt32(TextBox599.Text) + Convert.ToInt32(TextBox600.Text) + Convert.ToInt32(TextBox601.Text)
             + Convert.ToInt32(TextBox602.Text) + Convert.ToInt32(TextBox603.Text) + Convert.ToInt32(TextBox604.Text) + Convert.ToInt32(TextBox605.Text));
        TextBox607.Focus();
    }
    protected void Button79_Click(object sender, EventArgs e)
    {
        TextBox606.Text = Convert.ToString(Convert.ToInt32(TextBox607.Text) + Convert.ToInt32(TextBox608.Text) + Convert.ToInt32(TextBox609.Text) + Convert.ToInt32(TextBox610.Text)
                + Convert.ToInt32(TextBox611.Text) + Convert.ToInt32(TextBox612.Text) + Convert.ToInt32(TextBox613.Text) + Convert.ToInt32(TextBox614.Text));
        TextBox596.Text = Convert.ToString(Convert.ToInt32(TextBox597.Text) + Convert.ToInt32(TextBox606.Text));
        TextBox617.Focus();
    }
    protected void Button80_Click(object sender, EventArgs e)
    {
        TextBox616.Text = Convert.ToString(Convert.ToInt32(TextBox617.Text) + Convert.ToInt32(TextBox618.Text) + Convert.ToInt32(TextBox619.Text) + Convert.ToInt32(TextBox620.Text)
              + Convert.ToInt32(TextBox621.Text) + Convert.ToInt32(TextBox622.Text) + Convert.ToInt32(TextBox623.Text) + Convert.ToInt32(TextBox624.Text));
        TextBox625.Focus();
    }
    protected void Button81_Click(object sender, EventArgs e)
    {
        TextBox633.Text = Convert.ToString(Convert.ToInt32(TextBox625.Text) + Convert.ToInt32(TextBox626.Text) + Convert.ToInt32(TextBox627.Text) + Convert.ToInt32(TextBox628.Text)
               + Convert.ToInt32(TextBox629.Text) + Convert.ToInt32(TextBox630.Text) + Convert.ToInt32(TextBox631.Text) + Convert.ToInt32(TextBox632.Text));
        TextBox615.Text = Convert.ToString(Convert.ToInt32(TextBox616.Text) + Convert.ToInt32(TextBox633.Text));
        TextBox636.Focus();
    }
    protected void Button82_Click(object sender, EventArgs e)
    {
        TextBox635.Text = Convert.ToString(Convert.ToInt32(TextBox636.Text) + Convert.ToInt32(TextBox637.Text) + Convert.ToInt32(TextBox638.Text) + Convert.ToInt32(TextBox639.Text)
              + Convert.ToInt32(TextBox640.Text) + Convert.ToInt32(TextBox641.Text) + Convert.ToInt32(TextBox642.Text) + Convert.ToInt32(TextBox643.Text));
        TextBox645.Focus();
    }
    protected void Button83_Click(object sender, EventArgs e)
    {
        TextBox644.Text = Convert.ToString(Convert.ToInt32(TextBox645.Text) + Convert.ToInt32(TextBox646.Text) + Convert.ToInt32(TextBox647.Text) + Convert.ToInt32(TextBox648.Text)
               + Convert.ToInt32(TextBox649.Text) + Convert.ToInt32(TextBox650.Text) + Convert.ToInt32(TextBox651.Text) + Convert.ToInt32(TextBox652.Text));
        TextBox634.Text = Convert.ToString(Convert.ToInt32(TextBox635.Text) + Convert.ToInt32(TextBox644.Text));
        TextBox655.Focus();
    }
    protected void Button84_Click(object sender, EventArgs e)
    {
        TextBox654.Text = Convert.ToString(Convert.ToInt32(TextBox655.Text) + Convert.ToInt32(TextBox656.Text) + Convert.ToInt32(TextBox657.Text) + Convert.ToInt32(TextBox658.Text)
              + Convert.ToInt32(TextBox659.Text) + Convert.ToInt32(TextBox660.Text) + Convert.ToInt32(TextBox661.Text) + Convert.ToInt32(TextBox662.Text));
        TextBox663.Focus();
    }
    protected void Button85_Click(object sender, EventArgs e)
    {
        TextBox671.Text = Convert.ToString(Convert.ToInt32(TextBox663.Text) + Convert.ToInt32(TextBox664.Text) + Convert.ToInt32(TextBox665.Text) + Convert.ToInt32(TextBox666.Text)
              + Convert.ToInt32(TextBox667.Text) + Convert.ToInt32(TextBox668.Text) + Convert.ToInt32(TextBox669.Text) + Convert.ToInt32(TextBox670.Text));
        TextBox653.Text = Convert.ToString(Convert.ToInt32(TextBox654.Text) + Convert.ToInt32(TextBox671.Text));
        TextBox675.Focus();
    }
    protected void Button86_Click(object sender, EventArgs e)
    {
        TextBox673.Text = Convert.ToString(Convert.ToInt32(TextBox675.Text) + Convert.ToInt32(TextBox676.Text) + Convert.ToInt32(TextBox677.Text) + Convert.ToInt32(TextBox678.Text)
             + Convert.ToInt32(TextBox679.Text) + Convert.ToInt32(TextBox680.Text) + Convert.ToInt32(TextBox681.Text) + Convert.ToInt32(TextBox682.Text));
        TextBox683.Focus();
    }
    protected void Button87_Click(object sender, EventArgs e)
    {
        TextBox674.Text = Convert.ToString(Convert.ToInt32(TextBox683.Text) + Convert.ToInt32(TextBox684.Text) + Convert.ToInt32(TextBox685.Text) + Convert.ToInt32(TextBox686.Text)
             + Convert.ToInt32(TextBox687.Text) + Convert.ToInt32(TextBox688.Text) + Convert.ToInt32(TextBox689.Text) + Convert.ToInt32(TextBox690.Text));
        TextBox672.Text = Convert.ToString(Convert.ToInt32(TextBox673.Text) + Convert.ToInt32(TextBox674.Text));
        TextBox694.Focus();
    }
    protected void Button88_Click(object sender, EventArgs e)
    {
        TextBox692.Text = Convert.ToString(Convert.ToInt32(TextBox694.Text) + Convert.ToInt32(TextBox695.Text) + Convert.ToInt32(TextBox696.Text) + Convert.ToInt32(TextBox697.Text)
             + Convert.ToInt32(TextBox698.Text) + Convert.ToInt32(TextBox699.Text) + Convert.ToInt32(TextBox700.Text) + Convert.ToInt32(TextBox701.Text));
        TextBox702.Focus();
    }
    protected void Button89_Click(object sender, EventArgs e)
    {
        TextBox693.Text = Convert.ToString(Convert.ToInt32(TextBox702.Text) + Convert.ToInt32(TextBox703.Text) + Convert.ToInt32(TextBox704.Text) + Convert.ToInt32(TextBox705.Text)
              + Convert.ToInt32(TextBox706.Text) + Convert.ToInt32(TextBox707.Text) + Convert.ToInt32(TextBox708.Text) + Convert.ToInt32(TextBox709.Text));
        TextBox691.Text = Convert.ToString(Convert.ToInt32(TextBox692.Text) + Convert.ToInt32(TextBox693.Text));
        TextBox713.Focus();
    }
    protected void Button90_Click(object sender, EventArgs e)
    {
        TextBox711.Text = Convert.ToString(Convert.ToInt32(TextBox713.Text) + Convert.ToInt32(TextBox714.Text) + Convert.ToInt32(TextBox715.Text) + Convert.ToInt32(TextBox716.Text)
                            + Convert.ToInt32(TextBox717.Text) + Convert.ToInt32(TextBox718.Text) + Convert.ToInt32(TextBox719.Text) + Convert.ToInt32(TextBox720.Text));
        TextBox721.Focus();
    }
    protected void Button91_Click(object sender, EventArgs e)
    {
        TextBox712.Text = Convert.ToString(Convert.ToInt32(TextBox721.Text) + Convert.ToInt32(TextBox722.Text) + Convert.ToInt32(TextBox723.Text) + Convert.ToInt32(TextBox724.Text)
              + Convert.ToInt32(TextBox725.Text) + Convert.ToInt32(TextBox726.Text) + Convert.ToInt32(TextBox727.Text) + Convert.ToInt32(TextBox728.Text));
        TextBox710.Text = Convert.ToString(Convert.ToInt32(TextBox711.Text) + Convert.ToInt32(TextBox712.Text));
        TextBox307.Focus();
    }
    protected void Button92_Click(object sender, EventArgs e)
    {
        TextBox730.Text = Convert.ToString(Convert.ToInt32(TextBox307.Text) + Convert.ToInt32(TextBox308.Text) + Convert.ToInt32(TextBox309.Text) + Convert.ToInt32(TextBox310.Text)
                          + Convert.ToInt32(TextBox311.Text) + Convert.ToInt32(TextBox312.Text) + Convert.ToInt32(TextBox313.Text) + Convert.ToInt32(TextBox314.Text));
        TextBox315.Focus();
    }
    protected void Button93_Click(object sender, EventArgs e)
    {
        TextBox731.Text = Convert.ToString(Convert.ToInt32(TextBox315.Text) + Convert.ToInt32(TextBox732.Text) + Convert.ToInt32(TextBox733.Text) + Convert.ToInt32(TextBox734.Text)
             + Convert.ToInt32(TextBox735.Text) + Convert.ToInt32(TextBox736.Text) + Convert.ToInt32(TextBox737.Text) + Convert.ToInt32(TextBox738.Text));
        TextBox729.Text = Convert.ToString(Convert.ToInt32(TextBox730.Text) + Convert.ToInt32(TextBox731.Text));
        TextBox741.Focus();
    }
    protected void Button94_Click(object sender, EventArgs e)
    {
        TextBox740.Text = Convert.ToString(Convert.ToInt32(TextBox741.Text) + Convert.ToInt32(TextBox742.Text) + Convert.ToInt32(TextBox743.Text) + Convert.ToInt32(TextBox744.Text)
                          + Convert.ToInt32(TextBox745.Text) + Convert.ToInt32(TextBox746.Text) + Convert.ToInt32(TextBox747.Text) + Convert.ToInt32(TextBox748.Text));
        TextBox750.Focus();
    }
    protected void Button95_Click(object sender, EventArgs e)
    {
        TextBox749.Text = Convert.ToString(Convert.ToInt32(TextBox750.Text) + Convert.ToInt32(TextBox751.Text) + Convert.ToInt32(TextBox752.Text) + Convert.ToInt32(TextBox753.Text)
              + Convert.ToInt32(TextBox754.Text) + Convert.ToInt32(TextBox755.Text) + Convert.ToInt32(TextBox756.Text) + Convert.ToInt32(TextBox757.Text));
        TextBox739.Text = Convert.ToString(Convert.ToInt32(TextBox740.Text) + Convert.ToInt32(TextBox749.Text));
        TextBox761.Focus();
    }
    protected void Button96_Click(object sender, EventArgs e)
    {
        TextBox759.Text = Convert.ToString(Convert.ToInt32(TextBox761.Text) + Convert.ToInt32(TextBox762.Text) + Convert.ToInt32(TextBox763.Text) + Convert.ToInt32(TextBox764.Text)
                          + Convert.ToInt32(TextBox765.Text) + Convert.ToInt32(TextBox766.Text) + Convert.ToInt32(TextBox767.Text) + Convert.ToInt32(TextBox768.Text));
        TextBox769.Focus();
    }
    protected void Button97_Click(object sender, EventArgs e)
    {
        TextBox760.Text = Convert.ToString(Convert.ToInt32(TextBox769.Text) + Convert.ToInt32(TextBox770.Text) + Convert.ToInt32(TextBox771.Text) + Convert.ToInt32(TextBox772.Text)
            + Convert.ToInt32(TextBox773.Text) + Convert.ToInt32(TextBox774.Text) + Convert.ToInt32(TextBox775.Text) + Convert.ToInt32(TextBox776.Text));
        TextBox758.Text = Convert.ToString(Convert.ToInt32(TextBox759.Text) + Convert.ToInt32(TextBox760.Text));
        btnSave.Focus();
    }

 //=========== SAVING OF LAB1 and LAB2
    protected void SAVE_LAB()
    {
        if (!string.IsNullOrEmpty(Session["Edit"].ToString()))
        {
            if (Session["Edit"].ToString().Trim() != "T")
            {
                //=================== INSERT INTO LAB ============
                string sql = "INSERT INTO tbl_lab1 (states,lga,facname,months,years,grouptype,TOTALG1,SUBG1MA,G1MA2,G1MA2_12,SUBG1FE,G1FE2,G1FE2_12,TOTALG2,SUBG2MA,";
                sql += "G2MA1,G2MA1_4,G2MA5_9,G2MA10_14,G2MA15_19,G2MA20_24,G2MA25_49,G2MA50,SUBG2FE,G2FE1,G2FE1_4,G2FE5_9,G2FE10_14,G2FE15_19,G2FE20_24,G2FE25_49,G2FE50,";
                sql += "TOTALG3,SUBG3MA,G3MA1,G3MA1_4,G3MA5_9,G3MA10_14,G3MA15_19,G3MA20_24, G3MA25_49,G3MA50,SUBG3FE,G3FE1,G3FE1_4,G3FE5_9,G3FE10_14,G3FE15_19,G3FE20_24,";
                sql += "G3FE25_49,G3FE50,TOTALG4,SUBG4MA,G4MA1,G4MA1_4,G4MA5_9,G4MA10_14,G4MA15_19,G4MA20_24,G4MA25_49,G4MA50,SUBG4FE,G4FE1,G4FE1_4,G4FE5_9,G4FE10_14,G4FE15_19,";
                sql += "G4FE20_24,G4FE25_49,G4FE50,TOTALG5,SUBG5MA,G5MA1,G5MA1_4,G5MA5_9,G5MA10_14,G5MA15_19,G5MA20_24,G5MA25_49,G5MA50,SUBG5FE,G5FE1,G5FE1_4,G5FE5_9,G5FE10_14,";
                sql += "G5FE15_19,G5FE20_24,G5FE25_49,G5FE50,TOTALG6,SUBG6MA,G6MA1,G6MA1_4,G6MA5_9,G6MA10_14,G6MA15_19,G6MA20_24,G6MA25_49,G6MA50,SUBG6FE,G6FE1,G6FE1_4,G6FE5_9,";
                sql += "G6FE10_14,G6FE15_19,G6FE20_24,G6FE25_49,G6FE50,TOTALG7,SUBG7MA,G7MA1,G7MA1_4,G7MA5_9,G7MA10_14, G7MA15_19,G7MA20_24,G7MA25_49,G7MA50,SUBG7FE,G7FE1,G7FE1_4,";
                sql += "G7FE5_9,G7FE10_14,G7FE15_19,G7FE20_24,G7FE25_49,G7FE50,TOTALG8,SUBG8MA,G8MA1, G8MA1_4, G8MA5_9,G8MA10_14, G8MA15_19,G8MA20_24,G8MA25_49,G8MA50,";
                sql += "SUBG8FE, G8FE1, G8FE1_4,G8FE5_9, G8FE10_14,G8FE15_19, G8FE20_24,G8FE25_49, G8FE50, TOTALG9, SUBG9MA,G9MA1, G9MA1_4, G9MA5_9, G9MA10_14,";
                sql += "G9MA15_19, G9MA20_24,	G9MA25_49, G9MA50,SUBG9FE, G9FE1, G9FE1_4, G9FE5_9, G9FE10_14, G9FE15_19, G9FE20_24, G9FE25_49, G9FE50)";
                sql += " VALUES(@states,@lga,@facname,@months,@years,@grouptype,@TOTALG1,@SUBG1MA,@G1MA2,@G1MA2_12,@SUBG1FE,@G1FE2,@G1FE2_12,@TOTALG2,@SUBG2MA,";
                sql += "@G2MA1,@G2MA1_4,@G2MA5_9,@G2MA10_14,@G2MA15_19,@G2MA20_24,@G2MA25_49,@G2MA50,@SUBG2FE,@G2FE1,@G2FE1_4,@G2FE5_9,@G2FE10_14,@G2FE15_19,@G2FE20_24,@G2FE25_49,@G2FE50,";
                sql += "@TOTALG3,@SUBG3MA,@G3MA1,@G3MA1_4,@G3MA5_9,@G3MA10_14,@G3MA15_19,@G3MA20_24, @G3MA25_49,@G3MA50,@SUBG3FE,@G3FE1,@G3FE1_4,@G3FE5_9,@G3FE10_14,@G3FE15_19,@G3FE20_24,";
                sql += "@G3FE25_49,@G3FE50,@TOTALG4,@SUBG4MA,@G4MA1,@G4MA1_4,@G4MA5_9,@G4MA10_14,@G4MA15_19,@G4MA20_24,@G4MA25_49,@G4MA50,@SUBG4FE,@G4FE1,@G4FE1_4,@G4FE5_9,@G4FE10_14,@G4FE15_19,";
                sql += "@G4FE20_24,@G4FE25_49,@G4FE50,@TOTALG5,@SUBG5MA,@G5MA1,@G5MA1_4,@G5MA5_9,@G5MA10_14,@G5MA15_19,@G5MA20_24,@G5MA25_49,@G5MA50,@SUBG5FE,@G5FE1,@G5FE1_4,@G5FE5_9,@G5FE10_14,";
                sql += "@G5FE15_19,@G5FE20_24,@G5FE25_49,@G5FE50,@TOTALG6,@SUBG6MA,@G6MA1,@G6MA1_4,@G6MA5_9,@G6MA10_14,@G6MA15_19,@G6MA20_24,@G6MA25_49,@G6MA50,@SUBG6FE,@G6FE1,@G6FE1_4,@G6FE5_9,";
                sql += "@G6FE10_14,@G6FE15_19,@G6FE20_24,@G6FE25_49,@G6FE50,@TOTALG7,@SUBG7MA,@G7MA1,@G7MA1_4,@G7MA5_9,@G7MA10_14, @G7MA15_19,@G7MA20_24,@G7MA25_49,@G7MA50,@SUBG7FE,@G7FE1,@G7FE1_4,";
                sql += "@G7FE5_9,@G7FE10_14,@G7FE15_19,@G7FE20_24,@G7FE25_49,@G7FE50,@TOTALG8,@SUBG8MA,@G8MA1, @G8MA1_4, @G8MA5_9,@G8MA10_14, @G8MA15_19,@G8MA20_24,@G8MA25_49,@G8MA50,";
                sql += "@SUBG8FE, @G8FE1, @G8FE1_4,@G8FE5_9, @G8FE10_14,@G8FE15_19, @G8FE20_24,@G8FE25_49, @G8FE50, @TOTALG9, @SUBG9MA,@G9MA1, @G9MA1_4, @G9MA5_9, @G9MA10_14,";
                sql += "@G9MA15_19, @G9MA20_24,	@G9MA25_49, @G9MA50,@SUBG9FE, @G9FE1, @G9FE1_4, @G9FE5_9, @G9FE10_14, @G9FE15_19, @G9FE20_24, @G9FE25_49, @G9FE50)";


                string sql1 = "INSERT INTO tbl_lab2 (states,lga,facname,months,years,grouptype,  TOTALG10,  SUBG10MA,	G10MA1,G10MA1_4,  G10MA5_9,  G10MA10_14, G10MA15_19, G10MA20_24,";
                sql1 += "G10MA25_49, G10MA50,  SUBG10FE, G10FE1 ,G10FE1_4, G10FE5_9, G10FE10_14, G10FE15_19, G10FE20_24, G10FE25_49,G10FE50,  TOTALG11,SUBG11MA, G11MA1,G11MA1_4, G11MA5_9, G11MA10_14, ";
                sql1 += "G11MA15_19, G11MA20_24, G11MA25_49, G11MA50, SUBG11FE, G11FE1,  G11FE1_4, G11FE5_9,  G11FE10_14, G11FE15_19, G11FE20_24, G11FE25_49, G11FE50, TOTALG12,SUBG12MA, G12MA1, G12MA1_4,";
                sql1 += "G12MA5_9, G12MA10_14, G12MA15_19, G12MA20_24, G12MA25_49, G12MA50, SUBG12FE,  G12FE1, G12FE1_4, G12FE5_9, G12FE10_14, G12FE15_19, G12FE20_24, G12FE25_49, G12FE50, TOTALG13, SUBG13MA,";
                sql1 += "G13MA1, G13MA1_4, G13MA5_9, G13MA10_14, G13MA15_19, G13MA20_24, G13MA25_49, G13MA50, SUBG13FE, G13FE1, G13FE1_4, G13FE5_9, G13FE10_14, G13FE15_19, G13FE20_24, G13FE25_49, G13FE50, ";
                sql1 += "TOTALG14, SUBG14MA, G14MA1, G14MA1_4, G14MA5_9, G14MA10_14, G14MA15_19, G14MA20_24, G14MA25_49, G14MA50, SUBG14FE, G14FE1, G14FE1_4, G14FE5_9, G14FE10_14, G14FE15_19, G14FE20_24,";
                sql1 += "G14FE25_49, G14FE50, TOTALG15, SUBG15MA,  G15MA1,  G15MA1_4, G15MA5_9, G15MA10_14, G15MA15_19, G15MA20_24,G15MA25_49, G15MA50, SUBG15FE, G15FE1, G15FE1_4, G15FE5_9, G15FE10_14, ";
                sql1 += "G15FE15_19, G15FE20_24, G15FE25_49, G15FE50, TOTALG16, SUBG16MA, G16MA1, G16MA1_4, G16MA5_9, G16MA10_14, G16MA15_19, G16MA20_24, G16MA25_49, G16MA50, SUBG16FE, G16FE1,G16FE1_4, ";
                sql1 += "G16FE5_9, G16FE10_14, G16FE15_19, G16FE20_24, G16FE25_49, G16FE50, TOTALG17, SUBG17MA, G17MA1, G17MA1_4, G17MA5_9, G17MA10_14, G17MA15_19, G17MA20_24, G17MA25_49, G17MA50, SUBG17FE,";
                sql1 += "G17FE1, G17FE1_4, G17FE5_9, G17FE10_14, G17FE15_19, G17FE20_24, G17FE25_49, G17FE50) ";
                sql1 += "VALUES(@states,@lga,@facname,@months,@years,@grouptype,  @TOTALG10,  @SUBG10MA,	@G10MA,@G10MA1_4,  @G10MA5_9,  @G10MA10_14, @G10MA15_19, @G10MA20_24,";
                sql1 += "@G10MA25_49, @G10MA50,  @SUBG10FE, @G10FE1 ,@G10FE1_4, @G10FE5_9, @G10FE10_14, @G10FE15_19, @G10FE20_24, @G10FE25_49,@G10FE50,  @TOTALG11,@SUBG11MA, @G11MA1,@G11MA1_4, @G11MA5_9, @G11MA10_14, ";
                sql1 += "@G11MA15_19, @G11MA20_24, @G11MA25_49, @G11MA50, @SUBG11FE, @G11FE1,  @G11FE1_4, @G11FE5_9,  @G11FE10_14, @G11FE15_19, @G11FE20_24, @G11FE25_49, @G11FE50, @TOTALG12,@SUBG12MA, @G12MA1, @G12MA1_4,";
                sql1 += "@G12MA5_9, @G12MA10_14, @G12MA15_19, @G12MA20_24, @G12MA25_49, @G12MA50, @SUBG12FE,  @G12FE1, @G12FE1_4, @G12FE5_9, @G12FE10_14, @G12FE15_19, @G12FE20_24,@G12FE25_49, @G12FE50, @TOTALG13, @SUBG13MA,";
                sql1 += "@G13MA1, @G13MA1_4, @G13MA5_9, @G13MA10_14, @G13MA15_19, @G13MA20_24, @G13MA25_49, @G13MA50, @SUB13FE, @G13FE1, @G13FE1_4, @G13FE5_9, @G13FE10_14, @G13FE15_19,@G13FE20_24, @G13FE25_49, @G13FE50, ";
                sql1 += "@TOTALG14, @SUBG14MA, @G14MA1, @G14MA1_4, @G14MA5_9, @G14MA10_14, @G14MA15_19, @G14MA20_24, @G14MA25_49, @G14MA50, @SUBG14FE, @G14FE1, @G14FE1_4, @G14FE5_9, @G14FE10_14, @G14FE15_19, @G14FE20_24,";
                sql1 += "@G14FE25_49, @G14FE50, @TOTALG15, @SUBG15MA,  @G15MA1,  @G15MA1_4, @G15MA5_9, @G15MA10_14, @G15MA15_19, @G15MA20_24,@G15MA25_49, @G15MA50, @SUBG15FE, @G15FE1, @G15FE1_4, @G15FE5_9, @G15FE10_14, ";
                sql1 += "@G15FE15_19, @G15FE20_24, @G15FE25_49, @G15FE50, @TOTALG16, @SUBG16MA, @G16MA1, @G16MA1_4, @G16MA5_9, @G16MA10_14, @G15MA15_19, @G15MA20_24, @G15MA25_49, @G15MA50, @SUBG16FE, @G16FE1,@G16FE1_4, ";
                sql1 += "@G16FE5_9, @G16FE10_14, @G16FE15_19, @G16FE20_24, @G16FE25_49, @G16FE50, @TOTALG17, @SUBG17MA, @G17MA1, @G17MA1_4, @G17MA5_9, @G17MA10_14, @G17MA15_19, @G17MA20_24, @G17MA25_49, @G17MA50, @SUBG17FE,";
                sql1 += "@G17FE1, @G17FE1_4, @G17FE5_9, @G17FE10_14, @G17FE15_19, @G17FE20_24, @G17FE25_49, @G17FE50) ";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox796.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1ma", SqlDbType.Int).Value = TextBox797.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma2", SqlDbType.Int).Value = TextBox799.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma2_12", SqlDbType.Int).Value = TextBox801.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1fe", SqlDbType.Int).Value = TextBox798.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe2", SqlDbType.Int).Value = TextBox800.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe2_12", SqlDbType.Int).Value = TextBox802.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox803.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2ma", SqlDbType.Int).Value = TextBox804.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma1", SqlDbType.Int).Value = TextBox805.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma1_4", SqlDbType.Int).Value = TextBox806.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma5_9", SqlDbType.Int).Value = TextBox807.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma10_14", SqlDbType.Int).Value = TextBox808.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma15_19 ", SqlDbType.Int).Value = TextBox809.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma20_24", SqlDbType.Int).Value = TextBox810.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma25_49", SqlDbType.Int).Value = TextBox811.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma50", SqlDbType.Int).Value = TextBox812.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2fe", SqlDbType.Int).Value = TextBox813.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe1", SqlDbType.Int).Value = TextBox814.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe1_4", SqlDbType.Int).Value = TextBox815.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe5_9", SqlDbType.Int).Value = TextBox816.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe10_14", SqlDbType.Int).Value = TextBox817.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe15_19", SqlDbType.Int).Value = TextBox818.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe20_24", SqlDbType.Int).Value = TextBox819.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe25_49", SqlDbType.Int).Value = TextBox820.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe50", SqlDbType.Int).Value = TextBox821.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox158.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3ma", SqlDbType.Int).Value = TextBox159.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma1", SqlDbType.Int).Value = TextBox160.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma1_4", SqlDbType.Int).Value = TextBox161.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma5_9", SqlDbType.Int).Value = TextBox162.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma10_14", SqlDbType.Int).Value = TextBox163.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma15_19", SqlDbType.Int).Value = TextBox164.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma20_24", SqlDbType.Int).Value = TextBox165.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma25_49", SqlDbType.Int).Value = TextBox166.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma50", SqlDbType.Int).Value = TextBox167.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3fe", SqlDbType.Int).Value = TextBox168.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe1", SqlDbType.Int).Value = TextBox169.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe1_4", SqlDbType.Int).Value = TextBox170.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe5_9", SqlDbType.Int).Value = TextBox171.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe10_14", SqlDbType.Int).Value = TextBox172.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe15_19", SqlDbType.Int).Value = TextBox173.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe20_24", SqlDbType.Int).Value = TextBox174.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe25_49", SqlDbType.Int).Value = TextBox175.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe50", SqlDbType.Int).Value = TextBox176.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox177.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4ma", SqlDbType.Int).Value = TextBox178.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma1", SqlDbType.Int).Value = TextBox179.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma1_4", SqlDbType.Int).Value = TextBox180.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma5_9", SqlDbType.Int).Value = TextBox181.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma10_14", SqlDbType.Int).Value = TextBox182.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma15_19", SqlDbType.Int).Value = TextBox183.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma20_24", SqlDbType.Int).Value = TextBox184.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma25_49", SqlDbType.Int).Value = TextBox185.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma50", SqlDbType.Int).Value = TextBox186.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4fe", SqlDbType.Int).Value = TextBox187.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe1", SqlDbType.Int).Value = TextBox188.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe1_4", SqlDbType.Int).Value = TextBox189.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe5_9", SqlDbType.Int).Value = TextBox190.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe10_14", SqlDbType.Int).Value = TextBox191.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe15_19", SqlDbType.Int).Value = TextBox192.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe20_24", SqlDbType.Int).Value = TextBox193.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe25_49", SqlDbType.Int).Value = TextBox194.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe50", SqlDbType.Int).Value = TextBox195.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox196.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg5ma", SqlDbType.Int).Value = TextBox197.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma1", SqlDbType.Int).Value = TextBox198.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma1_4", SqlDbType.Int).Value = TextBox199.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma5_9", SqlDbType.Int).Value = TextBox200.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma10_14", SqlDbType.Int).Value = TextBox201.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma15_19", SqlDbType.Int).Value = TextBox202.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma20_24", SqlDbType.Int).Value = TextBox203.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma25_49", SqlDbType.Int).Value = TextBox204.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma50", SqlDbType.Int).Value = TextBox205.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg5fe", SqlDbType.Int).Value = TextBox206.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe1", SqlDbType.Int).Value = TextBox207.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe1_4", SqlDbType.Int).Value = TextBox208.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe5_9", SqlDbType.Int).Value = TextBox209.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe10_14", SqlDbType.Int).Value = TextBox210.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe15_19", SqlDbType.Int).Value = TextBox211.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe20_24", SqlDbType.Int).Value = TextBox212.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe25_49", SqlDbType.Int).Value = TextBox213.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe50", SqlDbType.Int).Value = TextBox214.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg6", SqlDbType.Int).Value = TextBox215.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg6ma", SqlDbType.Int).Value = TextBox216.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma1", SqlDbType.Int).Value = TextBox217.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma1_4", SqlDbType.Int).Value = TextBox218.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma5_9", SqlDbType.Int).Value = TextBox219.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma10_14", SqlDbType.Int).Value = TextBox220.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma15_19", SqlDbType.Int).Value = TextBox221.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma20_24", SqlDbType.Int).Value = TextBox222.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma25_49", SqlDbType.Int).Value = TextBox223.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma50", SqlDbType.Int).Value = TextBox224.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg6fe", SqlDbType.Int).Value = TextBox225.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe1", SqlDbType.Int).Value = TextBox226.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe1_4", SqlDbType.Int).Value = TextBox227.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe5_9", SqlDbType.Int).Value = TextBox228.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe10_14", SqlDbType.Int).Value = TextBox229.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe15_19", SqlDbType.Int).Value = TextBox230.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe20_24", SqlDbType.Int).Value = TextBox231.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe25_49", SqlDbType.Int).Value = TextBox232.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe50", SqlDbType.Int).Value = TextBox233.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg7", SqlDbType.Int).Value = TextBox154.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg7ma", SqlDbType.Int).Value = TextBox155.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma1", SqlDbType.Int).Value = TextBox156.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma1_4 ", SqlDbType.Int).Value = TextBox157.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma5_9", SqlDbType.Int).Value = TextBox239.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma10_14", SqlDbType.Int).Value = TextBox247.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma15_19", SqlDbType.Int).Value = TextBox822.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma20_24", SqlDbType.Int).Value = TextBox823.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma25_49", SqlDbType.Int).Value = TextBox824.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma50", SqlDbType.Int).Value = TextBox825.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg7fe", SqlDbType.Int).Value = TextBox826.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe1", SqlDbType.Int).Value = TextBox827.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe1_4", SqlDbType.Int).Value = TextBox828.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe5_9", SqlDbType.Int).Value = TextBox829.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe10_14", SqlDbType.Int).Value = TextBox830.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe15_19", SqlDbType.Int).Value = TextBox831.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe20_24", SqlDbType.Int).Value = TextBox832.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe25_49", SqlDbType.Int).Value = TextBox833.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe50", SqlDbType.Int).Value = TextBox834.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg8", SqlDbType.Int).Value = TextBox234.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg8ma", SqlDbType.Int).Value = TextBox235.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma1", SqlDbType.Int).Value = TextBox236.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma1_4", SqlDbType.Int).Value = TextBox237.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma5_9", SqlDbType.Int).Value = TextBox238.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma10_14", SqlDbType.Int).Value = TextBox239.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma15_19", SqlDbType.Int).Value = TextBox240.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma20_24", SqlDbType.Int).Value = TextBox241.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma25_49", SqlDbType.Int).Value = TextBox242.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma50", SqlDbType.Int).Value = TextBox835.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg8fe", SqlDbType.Int).Value = TextBox244.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe1", SqlDbType.Int).Value = TextBox245.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe1_4", SqlDbType.Int).Value = TextBox246.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe5_9", SqlDbType.Int).Value = TextBox248.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe10_14", SqlDbType.Int).Value = TextBox249.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe15_19", SqlDbType.Int).Value = TextBox250.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe20_24", SqlDbType.Int).Value = TextBox251.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe25_49", SqlDbType.Int).Value = TextBox252.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe50", SqlDbType.Int).Value = TextBox836.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg9", SqlDbType.Int).Value = TextBox253.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg9ma", SqlDbType.Int).Value = TextBox254.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma1", SqlDbType.Int).Value = TextBox255.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma1_4", SqlDbType.Int).Value = TextBox256.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma5_9", SqlDbType.Int).Value = TextBox257.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma10_14", SqlDbType.Int).Value = TextBox258.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma15_19", SqlDbType.Int).Value = TextBox259.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma20_24", SqlDbType.Int).Value = TextBox260.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma25_49", SqlDbType.Int).Value = TextBox261.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma50 ", SqlDbType.Int).Value = TextBox262.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg9fe", SqlDbType.Int).Value = TextBox263.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe1", SqlDbType.Int).Value = TextBox264.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe1_4", SqlDbType.Int).Value = TextBox265.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe5_9", SqlDbType.Int).Value = TextBox266.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe10_14", SqlDbType.Int).Value = TextBox267.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe15_19", SqlDbType.Int).Value = TextBox268.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe20_24", SqlDbType.Int).Value = TextBox284.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe25_49", SqlDbType.Int).Value = TextBox285.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe50", SqlDbType.Int).Value = TextBox286.Text.Trim();

                    int Rowsaffected1 = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    //============================tbl_Lab2========================================================
                    SqlCommand cmd1 = new SqlCommand(sql1, cn);
                    cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd1.Parameters.AddWithValue("@totalg10", SqlDbType.Int).Value = TextBox287.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg10ma", SqlDbType.Int).Value = TextBox288.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma", SqlDbType.Int).Value = TextBox289.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma1_4", SqlDbType.Int).Value = TextBox290.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma5_9", SqlDbType.Int).Value = TextBox291.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma10_14", SqlDbType.Int).Value = TextBox292.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma15_19", SqlDbType.Int).Value = TextBox293.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma20_24", SqlDbType.Int).Value = TextBox294.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma25_49", SqlDbType.Int).Value = TextBox295.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma50", SqlDbType.Int).Value = TextBox296.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg10fe", SqlDbType.Int).Value = TextBox297.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe1", SqlDbType.Int).Value = TextBox298.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe1_4", SqlDbType.Int).Value = TextBox299.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe5_9", SqlDbType.Int).Value = TextBox300.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe10_14", SqlDbType.Int).Value = TextBox301.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe15_19", SqlDbType.Int).Value = TextBox302.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe20_24", SqlDbType.Int).Value = TextBox303.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe25_49", SqlDbType.Int).Value = TextBox304.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe50", SqlDbType.Int).Value = TextBox305.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg11", SqlDbType.Int).Value = TextBox306.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg11ma", SqlDbType.Int).Value = TextBox307.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma1", SqlDbType.Int).Value = TextBox837.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma1_4", SqlDbType.Int).Value = TextBox838.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma5_9", SqlDbType.Int).Value = TextBox839.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma10_14", SqlDbType.Int).Value = TextBox840.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma15_19", SqlDbType.Int).Value = TextBox841.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma20_24", SqlDbType.Int).Value = TextBox842.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma25_49", SqlDbType.Int).Value = TextBox843.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma50", SqlDbType.Int).Value = TextBox844.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg11fe", SqlDbType.Int).Value = TextBox316.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe1", SqlDbType.Int).Value = TextBox317.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe1_4", SqlDbType.Int).Value = TextBox318.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe5_9", SqlDbType.Int).Value = TextBox319.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe10_14", SqlDbType.Int).Value = TextBox320.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe15_19", SqlDbType.Int).Value = TextBox321.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe20_24", SqlDbType.Int).Value = TextBox322.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe25_49", SqlDbType.Int).Value = TextBox323.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe50", SqlDbType.Int).Value = TextBox324.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg12", SqlDbType.Int).Value = TextBox325.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg12ma", SqlDbType.Int).Value = TextBox326.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma1", SqlDbType.Int).Value = TextBox327.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma1_4 ", SqlDbType.Int).Value = TextBox328.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma5_9 ", SqlDbType.Int).Value = TextBox329.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma10_14", SqlDbType.Int).Value = TextBox846.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma15_19", SqlDbType.Int).Value = TextBox847.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma20_24", SqlDbType.Int).Value = TextBox848.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma25_49", SqlDbType.Int).Value = TextBox849.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma50", SqlDbType.Int).Value = TextBox850.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg12fe", SqlDbType.Int).Value = TextBox851.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe1", SqlDbType.Int).Value = TextBox852.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe1_4", SqlDbType.Int).Value = TextBox853.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe5_9", SqlDbType.Int).Value = TextBox854.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe10_14", SqlDbType.Int).Value = TextBox855.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe15_19", SqlDbType.Int).Value = TextBox856.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe20_24", SqlDbType.Int).Value = TextBox857.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe25_49", SqlDbType.Int).Value = TextBox858.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe50 ", SqlDbType.Int).Value = TextBox859.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg13", SqlDbType.Int).Value = TextBox860.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg13ma", SqlDbType.Int).Value = TextBox861.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma1", SqlDbType.Int).Value = TextBox862.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma1_4", SqlDbType.Int).Value = TextBox863.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma5_9 ", SqlDbType.Int).Value = TextBox864.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma10_14 ", SqlDbType.Int).Value = TextBox865.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma15_19", SqlDbType.Int).Value = TextBox866.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma20_24", SqlDbType.Int).Value = TextBox867.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma25_49", SqlDbType.Int).Value = TextBox868.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma50", SqlDbType.Int).Value = TextBox869.Text.Trim();
                    cmd1.Parameters.AddWithValue("@sub13fe", SqlDbType.Int).Value = TextBox870.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe1", SqlDbType.Int).Value = TextBox871.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe1_4", SqlDbType.Int).Value = TextBox872.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe5_9 ", SqlDbType.Int).Value = TextBox873.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe10_14", SqlDbType.Int).Value = TextBox874.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe15_19", SqlDbType.Int).Value = TextBox875.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe20_24 ", SqlDbType.Int).Value = TextBox876.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe25_49", SqlDbType.Int).Value = TextBox877.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe50", SqlDbType.Int).Value = TextBox878.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg14", SqlDbType.Int).Value = TextBox879.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg14ma", SqlDbType.Int).Value = TextBox880.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma1", SqlDbType.Int).Value = TextBox881.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma1_4", SqlDbType.Int).Value = TextBox882.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma5_9", SqlDbType.Int).Value = TextBox883.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma10_14", SqlDbType.Int).Value = TextBox884.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma15_19", SqlDbType.Int).Value = TextBox885.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma20_24", SqlDbType.Int).Value = TextBox886.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma25_49", SqlDbType.Int).Value = TextBox887.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma50", SqlDbType.Int).Value = TextBox888.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg14fe", SqlDbType.Int).Value = TextBox889.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe1", SqlDbType.Int).Value = TextBox890.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe1_4", SqlDbType.Int).Value = TextBox891.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe5_9", SqlDbType.Int).Value = TextBox892.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe10_14", SqlDbType.Int).Value = TextBox893.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe15_19", SqlDbType.Int).Value = TextBox894.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe20_24", SqlDbType.Int).Value = TextBox895.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe25_49", SqlDbType.Int).Value = TextBox896.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe50", SqlDbType.Int).Value = TextBox897.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg15", SqlDbType.Int).Value = TextBox898.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg15ma", SqlDbType.Int).Value = TextBox899.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma1", SqlDbType.Int).Value = TextBox900.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma1_4", SqlDbType.Int).Value = TextBox901.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma5_9", SqlDbType.Int).Value = TextBox902.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma10_14", SqlDbType.Int).Value = TextBox903.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma15_19", SqlDbType.Int).Value = TextBox904.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma20_24", SqlDbType.Int).Value = TextBox905.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma25_49", SqlDbType.Int).Value = TextBox906.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma50", SqlDbType.Int).Value = TextBox907.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg15fe", SqlDbType.Int).Value = TextBox908.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe1", SqlDbType.Int).Value = TextBox909.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe1_4 ", SqlDbType.Int).Value = TextBox910.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe5_9", SqlDbType.Int).Value = TextBox911.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe10_14", SqlDbType.Int).Value = TextBox912.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe15_19", SqlDbType.Int).Value = TextBox913.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe20_24", SqlDbType.Int).Value = TextBox914.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe25_49", SqlDbType.Int).Value = TextBox915.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe50", SqlDbType.Int).Value = TextBox916.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg16", SqlDbType.Int).Value = TextBox917.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg16ma", SqlDbType.Int).Value = TextBox918.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma1", SqlDbType.Int).Value = TextBox919.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma1_4", SqlDbType.Int).Value = TextBox920.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma5_9", SqlDbType.Int).Value = TextBox921.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma10_14", SqlDbType.Int).Value = TextBox922.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma15_19", SqlDbType.Int).Value = TextBox923.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma20_24", SqlDbType.Int).Value = TextBox924.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma25_49", SqlDbType.Int).Value = TextBox925.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma50", SqlDbType.Int).Value = TextBox926.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg16fe", SqlDbType.Int).Value = TextBox927.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe1", SqlDbType.Int).Value = TextBox928.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe1_4", SqlDbType.Int).Value = TextBox929.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe5_9", SqlDbType.Int).Value = TextBox930.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe10_14", SqlDbType.Int).Value = TextBox931.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe15_19", SqlDbType.Int).Value = TextBox932.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe20_24", SqlDbType.Int).Value = TextBox933.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe25_49", SqlDbType.Int).Value = TextBox934.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe50", SqlDbType.Int).Value = TextBox935.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg17", SqlDbType.Int).Value = TextBox936.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg17ma", SqlDbType.Int).Value = TextBox937.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma1", SqlDbType.Int).Value = TextBox938.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma1_4", SqlDbType.Int).Value = TextBox939.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma5_9", SqlDbType.Int).Value = TextBox940.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma10_14", SqlDbType.Int).Value = TextBox941.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma15_19", SqlDbType.Int).Value = TextBox942.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma20_24 ", SqlDbType.Int).Value = TextBox943.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma25_49", SqlDbType.Int).Value = TextBox944.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma50", SqlDbType.Int).Value = TextBox945.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg17fe", SqlDbType.Int).Value = TextBox946.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe1", SqlDbType.Int).Value = TextBox947.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe1_4", SqlDbType.Int).Value = TextBox948.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe5_9", SqlDbType.Int).Value = TextBox949.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe10_14", SqlDbType.Int).Value = TextBox950.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe15_19", SqlDbType.Int).Value = TextBox951.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe20_24", SqlDbType.Int).Value = TextBox952.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe25_49", SqlDbType.Int).Value = TextBox953.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe50", SqlDbType.Int).Value = TextBox954.Text.Trim();


                    int Rowsaffected2 = cmd1.ExecuteNonQuery();
                    if (Rowsaffected1 != -1 && Rowsaffected2 != -1)
                    {
                        webMessage.Show("Save Record Successful");
                        //Response.Write("<script language=javascript>alert('Record Successful ');</script>");
                        CLS_LAB();
                        return;
                    }
                    cn.Close();
                    cmd1.Dispose();
                }
                catch (Exception ex)
                {
                    webMessage.Show("ERROR SAVING LAB : "+ ex.Message.Trim() );
                    return;
                }


            }
            else
            {
                //=============== UPDATE LAB ================
                string sql = "UPDATE tbl_lab1 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG1=@TOTALG1,SUBG1MA=@SUBG1MA,G1MA2=@G1MA2,G1MA2_12=@G1MA2_12,SUBG1FE=@SUBG1FE,G1FE2=@G1FE2,G1FE2_12=@G1FE2_12,TOTALG2=@TOTALG2,SUBG2MA=@SUBG2MA,";
                sql += " G2MA1=@G2MA1,G2MA1_4=@G2MA1_4,G2MA5_9=@G2MA5_9,G2MA10_14=@G2MA10_14,G2MA15_19=@G2MA15_19,G2MA20_24=@G2MA20_24,G2MA25_49=@G2MA25_49,G2MA50=@G2MA50,SUBG2FE=@SUBG2FE,G2FE1=@G2FE1,G2FE1_4=@G2FE1_4,G2FE5_9=@G2FE5_9,G2FE10_14=@G2FE10_14,G2FE15_19=@G2FE15_19,G2FE20_24=@G2FE20_24,G2FE25_49=@G2FE25_49,G2FE50=@G2FE50,";
                sql += " TOTALG3=@TOTALG3,SUBG3MA=@SUBG3MA,G3MA1=@G3MA1,G3MA1_4=@G3MA1_4,G3MA5_9=@G3MA5_9,G3MA10_14=@G3MA10_14,G3MA15_19=@G3MA15_19,G3MA20_24=@G3MA20_24, G3MA25_49=@G3MA25_49,G3MA50=@G3MA50,SUBG3FE=@SUBG3FE,G3FE1=@G3FE1,G3FE1_4=@G3FE1_4,G3FE5_9=@G3FE5_9,G3FE10_14=@G3FE10_14,G3FE15_19=@G3FE15_19,G3FE20_24=@G3FE20_24,";
                sql += " G3FE25_49=@G3FE25_49,G3FE50=@G3FE50,TOTALG4=@TOTALG4,SUBG4MA=@SUBG4MA,G4MA1=@G4MA1,G4MA1_4=@G4MA1_4,G4MA5_9=@G4MA5_9,G4MA10_14=@G4MA10_14,G4MA15_19=@G4MA15_19,G4MA20_24=@G4MA20_24,G4MA25_49=@G4MA25_49,G4MA50=@G4MA50,SUBG4FE=@SUBG4FE,G4FE1=@G4FE1,G4FE1_4=@G4FE1_4,G4FE5_9=@G4FE5_9,G4FE10_14=@G4FE10_14,G4FE15_19=@G4FE15_19,";
                sql += " G4FE20_24=@G4FE20_24,G4FE25_49=@G4FE25_49,G4FE50=@G4FE50,TOTALG5=@TOTALG5,SUBG5MA=@SUBG5MA,G5MA1=@G5MA1,G5MA1_4=@G5MA1_4,G5MA5_9=@G5MA5_9,G5MA10_14=@G5MA10_14,G5MA15_19=@G5MA15_19,G5MA20_24=@G5MA20_24,G5MA25_49=@G5MA25_49,G5MA50=@G5MA50,SUBG5FE=@SUBG5FE,G5FE1=@G5FE1,G5FE1_4=@G5FE1_4,G5FE5_9=@G5FE5_9,G5FE10_14=@G5FE10_14,";
                sql += " G5FE15_19=@G5FE15_19,G5FE20_24=@G5FE20_24,G5FE25_49=@G5FE25_49,G5FE50=@G5FE50,TOTALG6=@TOTALG6,SUBG6MA=@SUBG6MA,G6MA1=@G6MA1,G6MA1_4=@G6MA1_4,G6MA5_9=@G6MA5_9,G6MA10_14=@G6MA10_14,G6MA15_19=@G6MA15_19,G6MA20_24=@G6MA20_24,G6MA25_49=@G6MA25_49,G6MA50=@G6MA50,SUBG6FE=@SUBG6FE,G6FE1=@G6FE1,G6FE1_4=@G6FE1_4,G6FE5_9=@G6FE5_9,";
                sql += " G6FE10_14=@G6FE10_14,G6FE15_19=@G6FE15_19,G6FE20_24=@G6FE20_24,G6FE25_49=@G6FE25_49,G6FE50=@G6FE50,TOTALG7=@TOTALG7,SUBG7MA=@SUBG7MA,G7MA1=@G7MA1,G7MA1_4=@G7MA1_4,G7MA5_9=@G7MA5_9,G7MA10_14=@G7MA10_14,G7MA15_19=@G7MA15_19,G7MA20_24=@G7MA20_24,G7MA25_49=@G7MA25_49,G7MA50=@G7MA50,SUBG7FE=@SUBG7FE,G7FE1=@G7FE1,G7FE1_4=@G7FE1_4,";
                sql += " G7FE5_9=@G7FE5_9,G7FE10_14=@G7FE10_14,G7FE15_19=@G7FE15_19,G7FE20_24=@G7FE20_24,G7FE25_49=@G7FE25_49,G7FE50=@G7FE50,TOTALG8=@TOTALG8,SUBG8MA=@SUBG8MA,G8MA1=@G8MA1, G8MA1_4=@G8MA1_4, G8MA5_9=@G8MA5_9,G8MA10_14=@G8MA10_14, G8MA15_19=@G8MA15_19,G8MA20_24=@G8MA20_24,G8MA25_49=@G8MA25_49,G8MA50=@G8MA50,";
                sql += " SUBG8FE=@SUBG8FE, G8FE1=@G8FE1, G8FE1_4=@G8FE1_4,G8FE5_9=@G8FE5_9, G8FE10_14=@G8FE10_14,G8FE15_19=@G8FE15_19, G8FE20_24=@G8FE20_24,G8FE25_49=@G8FE25_49, G8FE50=@G8FE50, TOTALG9=@TOTALG9, SUBG9MA=@SUBG9MA,G9MA1=@G9MA1, G9MA1_4=@G9MA1_4, G9MA5_9=@G9MA5_9, G9MA10_14=@G9MA10_14,";
                sql += " G9MA15_19=@G9MA15_19, G9MA20_24=@G9MA20_24,G9MA25_49=@G9MA25_49,G9MA50=@G9MA50,SUBG9FE=@SUBG9FE, G9FE1=@G9FE1,G9FE1_4=@G9FE1_4, G9FE5_9=@G9FE5_9, G9FE10_14=@G9FE10_14,G9FE15_19=@G9FE15_19, G9FE20_24=@G9FE20_24,G9FE25_49= @G9FE25_49, G9FE50=@G9FE50 ";
                sql += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";

                string sql1 = "UPDATE tbl_lab2 SET states=@states,lga=@lga,facname=@facname,months=@months,years=@years,grouptype=@grouptype,TOTALG10=@TOTALG10,SUBG10MA=@SUBG10MA,G10MA1=@G10MA1,G10MA1_4=@G10MA1_4,G10MA5_9= @G10MA5_9,G10MA10_14= @G10MA10_14,G10MA15_19=@G10MA15_19,G10MA20_24= @G10MA20_24,";
                sql1 += "G10MA25_49=@G10MA25_49,G10MA50=@G10MA50, SUBG10FE=@SUBG10FE,G10FE1=@G10FE1,G10FE1_4=@G10FE1_4,G10FE5_9=@G10FE5_9,G10FE10_14=@G10FE10_14,G10FE15_19=@G10FE15_19,G10FE20_24=@G10FE20_24,G10FE25_49=@G10FE25_49,G10FE50=@G10FE50, TOTALG11=@TOTALG11,SUBG11MA=@SUBG11MA,G11MA1=@G11MA1,G11MA1_4=@G11MA1_4,G11MA5_9=@G11MA5_9,G11MA10_14=@G11MA10_14,";
                sql1 += "G11MA15_19=@G11MA15_19,G11MA20_24= @G11MA20_24,G11MA25_49=@G11MA25_49,G11MA50=@G11MA50,SUBG11FE=@SUBG11FE,G11FE1=@G11FE1, G11FE1_4=@G11FE1_4,G11FE5_9=@G11FE5_9, G11FE10_14=@G11FE10_14,G11FE15_19=@G11FE15_19,G11FE20_24=@G11FE20_24,G11FE25_49=@G11FE25_49,G11FE50=@G11FE50,TOTALG12=@TOTALG12,SUBG12MA=@SUBG12MA,G12MA1=@G12MA1,G12MA1_4=@G12MA1_4,";
                sql1 += "G12MA5_9=@G12MA5_9,G12MA10_14=@G12MA10_14,G12MA15_19=@G12MA15_19,G12MA20_24=@G12MA20_24,G12MA25_49=@G12MA25_49,G12MA50=@G12MA50,SUBG12FE=@SUBG12FE, G12FE1=@G12FE1,G12FE1_4=@G12FE1_4,G12FE5_9=@G12FE5_9,G12FE10_14=@G12FE10_14,G12FE15_19=@G12FE15_19,G12FE20_24=@G12FE20_24,G12FE25_49=@G12FE25_49,G12FE50=@G12FE50,TOTALG13=@TOTALG13,SUBG13MA=@SUBG13MA,";
                sql1 += "G13MA1=@G13MA1,G13MA1_4=@G13MA1_4,G13MA5_9=@G13MA5_9,G13MA10_14=@G13MA10_14,G13MA15_19=@G13MA15_19,G13MA20_24=@G13MA20_24,G13MA25_49=@G13MA25_49,G13MA50=@G13MA50,SUBG13FE=@SUBG13FE,G13FE1=@G13FE1,G13FE1_4=@G13FE1_4,G13FE5_9=@G13FE5_9,G13FE10_14=@G13FE10_14,G13FE15_19=@G13FE15_19,G13FE20_24=@G13FE20_24,G13FE25_49=@G13FE25_49,G13FE50=@G13FE50,";
                sql1 += "TOTALG14=@TOTALG14,SUBG14MA=@SUBG14MA,G14MA1=@G14MA1,G14MA1_4=@G14MA1_4,G14MA5_9=@G14MA5_9,G14MA10_14=@G14MA10_14,G14MA15_19=@G14MA15_19,G14MA20_24=@G14MA20_24,G14MA25_49=@G14MA25_49,G14MA50=@G14MA50,SUBG14FE=@SUBG14FE,G14FE1=@G14FE1,G14FE1_4=@G14FE1_4,G14FE5_9=@G14FE5_9,G14FE10_14=@G14FE10_14,G14FE15_19=@G14FE15_19,G14FE20_24=@G14FE20_24,";
                sql1 += "G14FE25_49=@G14FE25_49,G14FE50=@G14FE50,TOTALG15=@TOTALG15,SUBG15MA=@SUBG15MA, G15MA1=@G15MA1,G15MA1_4= @G15MA1_4,G15MA5_9=@G15MA5_9,G15MA10_14=@G15MA10_14,G15MA15_19=@G15MA15_19,G15MA20_24=@G15MA20_24,G15MA25_49=@G15MA25_49,G15MA50=@G15MA50,SUBG15FE=@SUBG15FE,G15FE1=@G15FE1,G15FE1_4=@G15FE1_4,G15FE5_9=@G15FE5_9,G15FE10_14=@G15FE10_14,";
                sql1 += "G15FE15_19=@G15FE15_19,G15FE20_24=@G15FE20_24,G15FE25_49=@G15FE25_49,G15FE50=@G15FE50,TOTALG16=@TOTALG16,SUBG16MA=@SUBG16MA,G16MA1=@G16MA1,G16MA1_4=@G16MA1_4,G16MA5_9=@G16MA5_9,G16MA10_14=@G16MA10_14,G16MA15_19=@G16MA15_19,G16MA20_24=@G16MA20_24,G16MA25_49=@G16MA25_49,G16MA50=@G16MA50,SUBG16FE=@SUBG16FE,G16FE1=@G16FE1,G16FE1_4=@G16FE1_4,";
                sql1 += "G16FE5_9=@G16FE5_9,G16FE10_14=@G16FE10_14,G16FE15_19=@G16FE15_19,G16FE20_24=@G16FE20_24,G16FE25_49=@G16FE25_49,G16FE50=@G16FE50,TOTALG17=@TOTALG17,SUBG17MA=@SUBG17MA,G17MA1=@G17MA1,G17MA1_4=@G17MA1_4,G17MA5_9=@G17MA5_9,G17MA10_14=@G17MA10_14,G17MA15_19=@G17MA15_19,G17MA20_24= @G17MA20_24,G17MA25_49=@G17MA25_49,G17MA50= @G17MA50,SUBG17FE=@SUBG17FE,";
                sql1 += "G17FE1=@G17FE1,G17FE1_4=@G17FE1_4,G17FE5_9=@G17FE5_9,G17FE10_14=@G17FE10_14,G17FE15_19=@G17FE15_19,G17FE20_24=@G17FE20_24,G17FE25_49=@G17FE25_49,G17FE50=@G17FE50 ";
                sql1 += " WHERE states=@states AND lga=@lga AND facname=@facname AND months=@months AND years=@years AND grouptype=@grouptype ";

                SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd.Parameters.AddWithValue("@totalg1", SqlDbType.Int).Value = TextBox796.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1ma", SqlDbType.Int).Value = TextBox797.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma2", SqlDbType.Int).Value = TextBox799.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1ma2_12", SqlDbType.Int).Value = TextBox801.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg1fe", SqlDbType.Int).Value = TextBox798.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe2", SqlDbType.Int).Value = TextBox800.Text.Trim();
                    cmd.Parameters.AddWithValue("@g1fe2_12", SqlDbType.Int).Value = TextBox802.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg2", SqlDbType.Int).Value = TextBox803.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2ma", SqlDbType.Int).Value = TextBox804.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma1", SqlDbType.Int).Value = TextBox805.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma1_4", SqlDbType.Int).Value = TextBox806.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma5_9", SqlDbType.Int).Value = TextBox807.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma10_14", SqlDbType.Int).Value = TextBox808.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma15_19", SqlDbType.Int).Value = TextBox809.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma20_24", SqlDbType.Int).Value = TextBox810.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma25_49", SqlDbType.Int).Value = TextBox811.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2ma50", SqlDbType.Int).Value = TextBox812.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg2fe", SqlDbType.Int).Value = TextBox813.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe1", SqlDbType.Int).Value = TextBox814.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe1_4", SqlDbType.Int).Value = TextBox815.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe5_9", SqlDbType.Int).Value = TextBox816.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe10_14", SqlDbType.Int).Value = TextBox817.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe15_19", SqlDbType.Int).Value = TextBox818.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe20_24", SqlDbType.Int).Value = TextBox819.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe25_49", SqlDbType.Int).Value = TextBox820.Text.Trim();
                    cmd.Parameters.AddWithValue("@g2fe50", SqlDbType.Int).Value = TextBox821.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg3", SqlDbType.Int).Value = TextBox158.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3ma", SqlDbType.Int).Value = TextBox159.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma1", SqlDbType.Int).Value = TextBox160.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma1_4", SqlDbType.Int).Value = TextBox161.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma5_9", SqlDbType.Int).Value = TextBox162.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma10_14", SqlDbType.Int).Value = TextBox163.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma15_19", SqlDbType.Int).Value = TextBox164.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma20_24", SqlDbType.Int).Value = TextBox165.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma25_49", SqlDbType.Int).Value = TextBox166.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3ma50", SqlDbType.Int).Value = TextBox167.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg3fe", SqlDbType.Int).Value = TextBox168.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe1", SqlDbType.Int).Value = TextBox169.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe1_4", SqlDbType.Int).Value = TextBox170.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe5_9", SqlDbType.Int).Value = TextBox171.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe10_14", SqlDbType.Int).Value = TextBox172.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe15_19", SqlDbType.Int).Value = TextBox173.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe20_24", SqlDbType.Int).Value = TextBox174.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe25_49", SqlDbType.Int).Value = TextBox175.Text.Trim();
                    cmd.Parameters.AddWithValue("@g3fe50", SqlDbType.Int).Value = TextBox176.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg4", SqlDbType.Int).Value = TextBox177.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4ma", SqlDbType.Int).Value = TextBox178.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma1", SqlDbType.Int).Value = TextBox179.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma1_4", SqlDbType.Int).Value = TextBox180.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma5_9", SqlDbType.Int).Value = TextBox181.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma10_14", SqlDbType.Int).Value = TextBox182.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma15_19", SqlDbType.Int).Value = TextBox183.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma20_24", SqlDbType.Int).Value = TextBox184.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma25_49", SqlDbType.Int).Value = TextBox185.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4ma50", SqlDbType.Int).Value = TextBox186.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg4fe", SqlDbType.Int).Value = TextBox187.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe1", SqlDbType.Int).Value = TextBox188.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe1_4", SqlDbType.Int).Value = TextBox189.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe5_9", SqlDbType.Int).Value = TextBox190.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe10_14", SqlDbType.Int).Value = TextBox191.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe15_19", SqlDbType.Int).Value = TextBox192.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe20_24", SqlDbType.Int).Value = TextBox193.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe25_49", SqlDbType.Int).Value = TextBox194.Text.Trim();
                    cmd.Parameters.AddWithValue("@g4fe50", SqlDbType.Int).Value = TextBox195.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg5", SqlDbType.Int).Value = TextBox196.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg5ma", SqlDbType.Int).Value = TextBox197.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma1", SqlDbType.Int).Value = TextBox198.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma1_4", SqlDbType.Int).Value = TextBox199.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma5_9", SqlDbType.Int).Value = TextBox200.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma10_14", SqlDbType.Int).Value = TextBox201.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma15_19", SqlDbType.Int).Value = TextBox202.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma20_24", SqlDbType.Int).Value = TextBox203.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma25_49", SqlDbType.Int).Value = TextBox204.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5ma50", SqlDbType.Int).Value = TextBox205.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg5fe", SqlDbType.Int).Value = TextBox206.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe1", SqlDbType.Int).Value = TextBox207.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe1_4", SqlDbType.Int).Value = TextBox208.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe5_9", SqlDbType.Int).Value = TextBox209.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe10_14", SqlDbType.Int).Value = TextBox210.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe15_19", SqlDbType.Int).Value = TextBox211.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe20_24", SqlDbType.Int).Value = TextBox212.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe25_49", SqlDbType.Int).Value = TextBox213.Text.Trim();
                    cmd.Parameters.AddWithValue("@g5fe50", SqlDbType.Int).Value = TextBox214.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg6", SqlDbType.Int).Value = TextBox215.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg6ma", SqlDbType.Int).Value = TextBox216.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma1", SqlDbType.Int).Value = TextBox217.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma1_4", SqlDbType.Int).Value = TextBox218.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma5_9", SqlDbType.Int).Value = TextBox219.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma10_14", SqlDbType.Int).Value = TextBox220.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma15_19", SqlDbType.Int).Value = TextBox221.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma20_24", SqlDbType.Int).Value = TextBox222.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma25_49", SqlDbType.Int).Value = TextBox223.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6ma50", SqlDbType.Int).Value = TextBox224.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg6fe", SqlDbType.Int).Value = TextBox225.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe1", SqlDbType.Int).Value = TextBox226.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe1_4", SqlDbType.Int).Value = TextBox227.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe5_9", SqlDbType.Int).Value = TextBox228.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe10_14", SqlDbType.Int).Value = TextBox229.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe15_19", SqlDbType.Int).Value = TextBox230.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe20_24", SqlDbType.Int).Value = TextBox231.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe25_49", SqlDbType.Int).Value = TextBox232.Text.Trim();
                    cmd.Parameters.AddWithValue("@g6fe50", SqlDbType.Int).Value = TextBox233.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg7", SqlDbType.Int).Value = TextBox154.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg7ma", SqlDbType.Int).Value = TextBox155.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma1", SqlDbType.Int).Value = TextBox156.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma1_4", SqlDbType.Int).Value = TextBox157.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma5_9", SqlDbType.Int).Value = TextBox239.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma10_14", SqlDbType.Int).Value = TextBox247.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma15_19", SqlDbType.Int).Value = TextBox822.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma20_24", SqlDbType.Int).Value = TextBox823.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma25_49", SqlDbType.Int).Value = TextBox824.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7ma50", SqlDbType.Int).Value = TextBox825.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg7fe", SqlDbType.Int).Value = TextBox826.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe1", SqlDbType.Int).Value = TextBox827.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe1_4", SqlDbType.Int).Value = TextBox828.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe5_9", SqlDbType.Int).Value = TextBox829.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe10_14", SqlDbType.Int).Value = TextBox830.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe15_19", SqlDbType.Int).Value = TextBox831.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe20_24", SqlDbType.Int).Value = TextBox832.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe25_49", SqlDbType.Int).Value = TextBox833.Text.Trim();
                    cmd.Parameters.AddWithValue("@g7fe50", SqlDbType.Int).Value = TextBox834.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg8", SqlDbType.Int).Value = TextBox234.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg8ma", SqlDbType.Int).Value = TextBox235.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma1", SqlDbType.Int).Value = TextBox236.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma1_4", SqlDbType.Int).Value = TextBox237.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma5_9", SqlDbType.Int).Value = TextBox238.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma10_14", SqlDbType.Int).Value = TextBox239.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma15_19", SqlDbType.Int).Value = TextBox240.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma20_24", SqlDbType.Int).Value = TextBox241.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma25_49", SqlDbType.Int).Value = TextBox242.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8ma50", SqlDbType.Int).Value = TextBox835.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg8fe", SqlDbType.Int).Value = TextBox244.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe1", SqlDbType.Int).Value = TextBox245.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe1_4", SqlDbType.Int).Value = TextBox246.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe5_9", SqlDbType.Int).Value = TextBox248.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe10_14", SqlDbType.Int).Value = TextBox249.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe15_19", SqlDbType.Int).Value = TextBox250.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe20_24", SqlDbType.Int).Value = TextBox251.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe25_49", SqlDbType.Int).Value = TextBox252.Text.Trim();
                    cmd.Parameters.AddWithValue("@g8fe50", SqlDbType.Int).Value = TextBox836.Text.Trim();
                    cmd.Parameters.AddWithValue("@totalg9", SqlDbType.Int).Value = TextBox253.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg9ma", SqlDbType.Int).Value = TextBox254.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma1", SqlDbType.Int).Value = TextBox255.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma1_4", SqlDbType.Int).Value = TextBox256.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma5_9", SqlDbType.Int).Value = TextBox257.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma10_14", SqlDbType.Int).Value = TextBox258.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma15_19", SqlDbType.Int).Value = TextBox259.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma20_24", SqlDbType.Int).Value = TextBox260.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma25_49", SqlDbType.Int).Value = TextBox261.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9ma50", SqlDbType.Int).Value = TextBox262.Text.Trim();
                    cmd.Parameters.AddWithValue("@subg9fe", SqlDbType.Int).Value = TextBox263.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe1", SqlDbType.Int).Value = TextBox264.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe1_4", SqlDbType.Int).Value = TextBox265.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe5_9", SqlDbType.Int).Value = TextBox266.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe10_14", SqlDbType.Int).Value = TextBox267.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe15_19", SqlDbType.Int).Value = TextBox268.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe20_24", SqlDbType.Int).Value = TextBox284.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe25_49", SqlDbType.Int).Value = TextBox285.Text.Trim();
                    cmd.Parameters.AddWithValue("@g9fe50", SqlDbType.Int).Value = TextBox286.Text.Trim();

                    int Rowsaffected1 = cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    //============================tbl_Lab2========================================================
                    SqlCommand cmd1 = new SqlCommand(sql1, cn);
                    cmd1.Parameters.AddWithValue("@states", SqlDbType.NVarChar).Value = mState;
                    cmd1.Parameters.AddWithValue("@lga", SqlDbType.NVarChar).Value = mLGA;
                    cmd1.Parameters.AddWithValue("@facname", SqlDbType.NVarChar).Value = mFacility;
                    cmd1.Parameters.AddWithValue("@months", SqlDbType.NVarChar).Value = mMnth;
                    cmd1.Parameters.AddWithValue("@years", SqlDbType.NVarChar).Value = mYr;
                    cmd1.Parameters.AddWithValue("@grouptype", SqlDbType.NVarChar).Value = mChoose;

                    cmd1.Parameters.AddWithValue("@totalg10", SqlDbType.Int).Value = TextBox287.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg10ma", SqlDbType.Int).Value = TextBox288.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma1", SqlDbType.Int).Value = TextBox289.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma1_4", SqlDbType.Int).Value = TextBox290.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma5_9", SqlDbType.Int).Value = TextBox291.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma10_14", SqlDbType.Int).Value = TextBox292.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma15_19", SqlDbType.Int).Value = TextBox293.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma20_24", SqlDbType.Int).Value = TextBox294.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma25_49", SqlDbType.Int).Value = TextBox295.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10ma50", SqlDbType.Int).Value = TextBox296.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg10fe", SqlDbType.Int).Value = TextBox297.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe1", SqlDbType.Int).Value = TextBox298.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe1_4", SqlDbType.Int).Value = TextBox299.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe5_9", SqlDbType.Int).Value = TextBox300.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe10_14", SqlDbType.Int).Value = TextBox301.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe15_19", SqlDbType.Int).Value = TextBox302.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe20_24", SqlDbType.Int).Value = TextBox303.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe25_49", SqlDbType.Int).Value = TextBox304.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g10fe50", SqlDbType.Int).Value = TextBox305.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg11", SqlDbType.Int).Value = TextBox306.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg11ma", SqlDbType.Int).Value = TextBox307.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma1", SqlDbType.Int).Value = TextBox837.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma1_4", SqlDbType.Int).Value = TextBox838.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma5_9", SqlDbType.Int).Value = TextBox839.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma10_14", SqlDbType.Int).Value = TextBox840.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma15_19", SqlDbType.Int).Value = TextBox841.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma20_24", SqlDbType.Int).Value = TextBox842.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma25_49", SqlDbType.Int).Value = TextBox843.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11ma50", SqlDbType.Int).Value = TextBox844.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg11fe", SqlDbType.Int).Value = TextBox316.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe1", SqlDbType.Int).Value = TextBox317.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe1_4", SqlDbType.Int).Value = TextBox318.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe5_9", SqlDbType.Int).Value = TextBox319.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe10_14", SqlDbType.Int).Value = TextBox320.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe15_19", SqlDbType.Int).Value = TextBox321.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe20_24", SqlDbType.Int).Value = TextBox322.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe25_49", SqlDbType.Int).Value = TextBox323.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g11fe50", SqlDbType.Int).Value = TextBox324.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg12", SqlDbType.Int).Value = TextBox325.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg12ma", SqlDbType.Int).Value = TextBox326.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma1", SqlDbType.Int).Value = TextBox327.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma1_4", SqlDbType.Int).Value = TextBox328.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma5_9", SqlDbType.Int).Value = TextBox329.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma10_14", SqlDbType.Int).Value = TextBox846.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma15_19", SqlDbType.Int).Value = TextBox847.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma20_24", SqlDbType.Int).Value = TextBox848.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma25_49", SqlDbType.Int).Value = TextBox849.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12ma50", SqlDbType.Int).Value = TextBox850.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg12fe", SqlDbType.Int).Value = TextBox851.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe1", SqlDbType.Int).Value = TextBox852.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe1_4", SqlDbType.Int).Value = TextBox853.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe5_9", SqlDbType.Int).Value = TextBox854.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe10_14", SqlDbType.Int).Value = TextBox855.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe15_19", SqlDbType.Int).Value = TextBox856.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe20_24", SqlDbType.Int).Value = TextBox857.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe25_49", SqlDbType.Int).Value = TextBox858.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g12fe50", SqlDbType.Int).Value = TextBox859.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg13", SqlDbType.Int).Value = TextBox860.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg13ma", SqlDbType.Int).Value = TextBox861.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma1", SqlDbType.Int).Value = TextBox862.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma1_4", SqlDbType.Int).Value = TextBox863.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma5_9", SqlDbType.Int).Value = TextBox864.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma10_14", SqlDbType.Int).Value = TextBox865.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma15_19", SqlDbType.Int).Value = TextBox866.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma20_24", SqlDbType.Int).Value = TextBox867.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma25_49", SqlDbType.Int).Value = TextBox868.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13ma50", SqlDbType.Int).Value = TextBox869.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg13fe", SqlDbType.Int).Value = TextBox870.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe1", SqlDbType.Int).Value = TextBox871.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe1_4", SqlDbType.Int).Value = TextBox872.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe5_9", SqlDbType.Int).Value = TextBox873.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe10_14", SqlDbType.Int).Value = TextBox874.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe15_19", SqlDbType.Int).Value = TextBox875.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe20_24", SqlDbType.Int).Value = TextBox876.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe25_49", SqlDbType.Int).Value = TextBox877.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g13fe50", SqlDbType.Int).Value = TextBox878.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg14", SqlDbType.Int).Value = TextBox879.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg14ma", SqlDbType.Int).Value = TextBox880.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma1", SqlDbType.Int).Value = TextBox881.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma1_4", SqlDbType.Int).Value = TextBox882.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma5_9", SqlDbType.Int).Value = TextBox883.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma10_14", SqlDbType.Int).Value = TextBox884.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma15_19", SqlDbType.Int).Value = TextBox885.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma20_24", SqlDbType.Int).Value = TextBox886.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma25_49", SqlDbType.Int).Value = TextBox887.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14ma50", SqlDbType.Int).Value = TextBox888.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg14fe", SqlDbType.Int).Value = TextBox889.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe1", SqlDbType.Int).Value = TextBox890.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe1_4", SqlDbType.Int).Value = TextBox891.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe5_9", SqlDbType.Int).Value = TextBox892.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe10_14", SqlDbType.Int).Value = TextBox893.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe15_19", SqlDbType.Int).Value = TextBox894.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe20_24", SqlDbType.Int).Value = TextBox895.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe25_49", SqlDbType.Int).Value = TextBox896.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g14fe50", SqlDbType.Int).Value = TextBox897.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg15", SqlDbType.Int).Value = TextBox898.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg15ma", SqlDbType.Int).Value = TextBox899.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma1", SqlDbType.Int).Value = TextBox900.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma1_4", SqlDbType.Int).Value = TextBox901.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma5_9", SqlDbType.Int).Value = TextBox902.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma10_14", SqlDbType.Int).Value = TextBox903.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma15_19", SqlDbType.Int).Value = TextBox904.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma20_24", SqlDbType.Int).Value = TextBox905.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma25_49", SqlDbType.Int).Value = TextBox906.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15ma50", SqlDbType.Int).Value = TextBox907.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg15fe", SqlDbType.Int).Value = TextBox908.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe1", SqlDbType.Int).Value = TextBox909.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe1_4 ", SqlDbType.Int).Value = TextBox910.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe5_9", SqlDbType.Int).Value = TextBox911.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe10_14", SqlDbType.Int).Value = TextBox912.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe15_19", SqlDbType.Int).Value = TextBox913.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe20_24", SqlDbType.Int).Value = TextBox914.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe25_49", SqlDbType.Int).Value = TextBox915.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g15fe50", SqlDbType.Int).Value = TextBox916.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg16", SqlDbType.Int).Value = TextBox917.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg16ma", SqlDbType.Int).Value = TextBox918.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma1", SqlDbType.Int).Value = TextBox919.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma1_4", SqlDbType.Int).Value = TextBox920.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma5_9", SqlDbType.Int).Value = TextBox921.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma10_14", SqlDbType.Int).Value = TextBox922.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma15_19", SqlDbType.Int).Value = TextBox923.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma20_24", SqlDbType.Int).Value = TextBox924.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma25_49", SqlDbType.Int).Value = TextBox925.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16ma50", SqlDbType.Int).Value = TextBox926.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg16fe", SqlDbType.Int).Value = TextBox927.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe1", SqlDbType.Int).Value = TextBox928.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe1_4", SqlDbType.Int).Value = TextBox929.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe5_9", SqlDbType.Int).Value = TextBox930.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe10_14", SqlDbType.Int).Value = TextBox931.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe15_19", SqlDbType.Int).Value = TextBox932.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe20_24", SqlDbType.Int).Value = TextBox933.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe25_49", SqlDbType.Int).Value = TextBox934.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g16fe50", SqlDbType.Int).Value = TextBox935.Text.Trim();
                    cmd1.Parameters.AddWithValue("@totalg17", SqlDbType.Int).Value = TextBox936.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg17ma", SqlDbType.Int).Value = TextBox937.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma1", SqlDbType.Int).Value = TextBox938.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma1_4", SqlDbType.Int).Value = TextBox939.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma5_9", SqlDbType.Int).Value = TextBox940.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma10_14", SqlDbType.Int).Value = TextBox941.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma15_19", SqlDbType.Int).Value = TextBox942.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma20_24", SqlDbType.Int).Value = TextBox943.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma25_49", SqlDbType.Int).Value = TextBox944.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17ma50", SqlDbType.Int).Value = TextBox945.Text.Trim();
                    cmd1.Parameters.AddWithValue("@subg17fe", SqlDbType.Int).Value = TextBox946.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe1", SqlDbType.Int).Value = TextBox947.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe1_4", SqlDbType.Int).Value = TextBox948.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe5_9", SqlDbType.Int).Value = TextBox949.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe10_14", SqlDbType.Int).Value = TextBox950.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe15_19", SqlDbType.Int).Value = TextBox951.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe20_24", SqlDbType.Int).Value = TextBox952.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe25_49", SqlDbType.Int).Value = TextBox953.Text.Trim();
                    cmd1.Parameters.AddWithValue("@g17fe50", SqlDbType.Int).Value = TextBox954.Text.Trim();
                    int Rowsaffected2 = cmd1.ExecuteNonQuery();
                    if (Rowsaffected1 != -1 && Rowsaffected2 != -1)
                    {
                        webMessage.Show("Save Record Successful");
                        //Response.Write("<script language=javascript>alert('Record Successful ');</script>");
                        CLS_LAB();
                        return;
                    }
                    cn.Close();
                    cmd1.Dispose();
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert('" + ex.Message.Trim() + "');</script>");
                    return;
                }

            }// if to check for T or F
        } //if to check for empty or null session
       

    }

//============ EDIT LAB1 and LAB2
    protected void EDIT_LAB()
    {
        try
        {
            string SQL1 = "SELECT * FROM vw_Lab Where months ='" + mMnth + "' and years ='" + mYr + "' and grouptype ='" + mChoose + "' and facname ='" + mFacility + "'";
            SqlConnection cn = new SqlConnection(ConnectAll.ConnectMe());
            cn.Open();
            SqlCommand cmd1 = new SqlCommand(SQL1, cn);
            SqlDataReader r = cmd1.ExecuteReader();

            while (r.Read())
            {
                    TextBox796.Text	=r["totalg1"].ToString(); 
                    TextBox797.Text	=r["subg1ma"].ToString(); 
                    TextBox799.Text	=r["g1ma2"].ToString(); 
                    TextBox801.Text	=r["g1ma2_12"].ToString(); 
                    TextBox798.Text	=r["subg1fe"].ToString(); 
                    TextBox800.Text	=r["g1fe2"].ToString(); 
                    TextBox802.Text	=r["g1fe2_12"].ToString(); 
                    TextBox803.Text	=r["totalg2"].ToString(); 
                    TextBox804.Text	=r["subg2ma"].ToString(); 
                    TextBox805.Text	=r["g2ma1"].ToString(); 
                    TextBox806.Text	=r["g2ma1_4"].ToString(); 
                    TextBox807.Text	=r["g2ma5_9"].ToString(); 
                    TextBox808.Text	=r["g2ma10_14"].ToString();
                    TextBox809.Text	=r["g2ma15_19"].ToString();
                    TextBox810.Text	=r["g2ma20_24"].ToString();
                    TextBox811.Text	=r["g2ma25_49"].ToString();
                    TextBox812.Text	=r["g2ma50"].ToString(); 
                    TextBox813.Text	=r["subg2fe"].ToString(); 
                    TextBox814.Text	=r["g2fe1"].ToString(); 
                    TextBox815.Text	=r["g2fe1_4"].ToString(); 
                    TextBox816.Text	=r["g2fe5_9"].ToString(); 
                    TextBox817.Text	=r["g2fe10_14"].ToString();
                    TextBox818.Text	=r["g2fe15_19"].ToString();
                    TextBox819.Text	=r["g2fe20_24"].ToString();
                    TextBox820.Text	=r["g2fe25_49"].ToString();
                    TextBox821.Text	=r["g2fe50"].ToString(); 
                    TextBox158.Text	=r["totalg3"].ToString(); 
                    TextBox159.Text	=r["subg3ma"].ToString(); 
                    TextBox160.Text	=r["g3ma1"].ToString(); 
                    TextBox161.Text	=r["g3ma1_4"].ToString(); 
                    TextBox162.Text	=r["g3ma5_9"].ToString(); 
                    TextBox163.Text	=r["g3ma10_14"].ToString();
                    TextBox164.Text	=r["g3ma15_19"].ToString();
                    TextBox165.Text	=r["g3ma20_24"].ToString();
                    TextBox166.Text	=r["g3ma25_49"].ToString();
                    TextBox167.Text	=r["g3ma50"].ToString(); 
                    TextBox168.Text	=r["subg3fe"].ToString(); 
                    TextBox169.Text	=r["g3fe1"].ToString(); 
                    TextBox170.Text	=r["g3fe1_4"].ToString(); 
                    TextBox171.Text	=r["g3fe5_9"].ToString(); 
                    TextBox172.Text	=r["g3fe10_14"].ToString();
                    TextBox173.Text	=r["g3fe15_19"].ToString();
                    TextBox174.Text	=r["g3fe20_24"].ToString();
                    TextBox175.Text	=r["g3fe25_49"].ToString();
                    TextBox176.Text	=r["g3fe50"].ToString(); 
                    TextBox177.Text	=r["totalg4"].ToString(); 
                    TextBox178.Text	=r["subg4ma"].ToString(); 
                    TextBox179.Text	=r["g4ma1"].ToString(); 
                    TextBox180.Text	=r["g4ma1_4"].ToString(); 
                    TextBox181.Text	=r["g4ma5_9"].ToString();
                    TextBox182.Text	=r["g4ma10_14"].ToString();
                    TextBox183.Text	=r["g4ma15_19"].ToString();
                    TextBox184.Text	=r["g4ma20_24"].ToString();
                    TextBox185.Text	=r["g4ma25_49"].ToString();
                    TextBox186.Text	=r["g4ma50"].ToString(); 
                    TextBox187.Text	=r["subg4fe"].ToString(); 
                    TextBox188.Text	=r["g4fe1"].ToString(); 
                    TextBox189.Text	=r["g4fe1_4"].ToString(); 
                    TextBox190.Text	=r["g4fe5_9"].ToString(); 
                    TextBox191.Text	=r["g4fe10_14"].ToString();
                    TextBox192.Text	=r["g4fe15_19"].ToString();
                    TextBox193.Text	=r["g4fe20_24"].ToString();
                    TextBox194.Text	=r["g4fe25_49"].ToString();
                    TextBox195.Text	=r["g4fe50"].ToString(); 
                    TextBox196.Text	=r["totalg5"].ToString(); 
                    TextBox197.Text	=r["subg5ma"].ToString(); 
                    TextBox198.Text	=r["g5ma1"].ToString(); 
                    TextBox199.Text	=r["g5ma1_4"].ToString(); 
                    TextBox200.Text	=r["g5ma5_9"].ToString(); 
                    TextBox201.Text	=r["g5ma10_14"].ToString();
                    TextBox202.Text	=r["g5ma15_19"].ToString();
                    TextBox203.Text	=r["g5ma20_24"].ToString();
                    TextBox204.Text	=r["g5ma25_49"].ToString();
                    TextBox205.Text	=r["g5ma50"].ToString(); 
                    TextBox206.Text	=r["subg5fe"].ToString(); 
                    TextBox207.Text	=r["g5fe1"].ToString(); 
                    TextBox208.Text	=r["g5fe1_4"].ToString(); 
                    TextBox209.Text	=r["g5fe5_9"].ToString(); 
                    TextBox210.Text	=r["g5fe10_14"].ToString();
                    TextBox211.Text	=r["g5fe15_19"].ToString();
                    TextBox212.Text	=r["g5fe20_24"].ToString();
                    TextBox213.Text	=r["g5fe25_49"].ToString();
                    TextBox214.Text	=r["g5fe50"].ToString(); 
                    TextBox215.Text	=r["totalg6"].ToString(); 
                    TextBox216.Text	=r["subg6ma"].ToString(); 
                    TextBox217.Text	=r["g6ma1"].ToString(); 
                    TextBox218.Text	=r["g6ma1_4"].ToString(); 
                    TextBox219.Text	=r["g6ma5_9"].ToString(); 
                    TextBox220.Text	=r["g6ma10_14"].ToString();
                    TextBox221.Text	=r["g6ma15_19"].ToString();
                    TextBox222.Text	=r["g6ma20_24"].ToString();
                    TextBox223.Text	=r["g6ma25_49"].ToString();
                    TextBox224.Text	=r["g6ma50"].ToString(); 
                    TextBox225.Text	=r["subg6fe"].ToString(); 
                    TextBox226.Text	=r["g6fe1"].ToString(); 
                    TextBox227.Text	=r["g6fe1_4"].ToString(); 
                    TextBox228.Text	=r["g6fe5_9"].ToString(); 
                    TextBox229.Text	=r["g6fe10_14"].ToString();
                    TextBox230.Text	=r["g6fe15_19"].ToString();
                    TextBox231.Text	=r["g6fe20_24"].ToString();
                    TextBox232.Text	=r["g6fe25_49"].ToString();
                    TextBox233.Text	=r["g6fe50"].ToString(); 
                    TextBox154.Text	=r["totalg7"].ToString(); 
                    TextBox155.Text	=r["subg7ma"].ToString(); 
                    TextBox156.Text	=r["g7ma1"].ToString(); 
                    TextBox157.Text	=r["g7ma1_4"].ToString(); 
                    TextBox239.Text	=r["g7ma5_9"].ToString(); 
                    TextBox247.Text	=r["g7ma10_14"].ToString();
                    TextBox822.Text	=r["g7ma15_19"].ToString();
                    TextBox823.Text	=r["g7ma20_24"].ToString();
                    TextBox824.Text	=r["g7ma25_49"].ToString();
                    TextBox825.Text	=r["g7ma50"].ToString(); 
                    TextBox826.Text	=r["subg7fe"].ToString(); 
                    TextBox827.Text	=r["g7fe1"].ToString(); 
                    TextBox828.Text	=r["g7fe1_4"].ToString(); 
                    TextBox829.Text	=r["g7fe5_9"].ToString(); 
                    TextBox830.Text	=r["g7fe10_14"].ToString();
                    TextBox831.Text	=r["g7fe15_19"].ToString();
                    TextBox832.Text	=r["g7fe20_24"].ToString();
                    TextBox833.Text	=r["g7fe25_49"].ToString();
                    TextBox834.Text	=r["g7fe50"].ToString(); 
                    TextBox234.Text	=r["totalg8"].ToString(); 
                    TextBox235.Text	=r["subg8ma"].ToString(); 
                    TextBox236.Text	=r["g8ma1"].ToString(); 
                    TextBox237.Text	=r["g8ma1_4"].ToString(); 
                    TextBox238.Text	=r["g8ma5_9"].ToString(); 
                    TextBox239.Text	=r["g8ma10_14"].ToString();
                    TextBox240.Text	=r["g8ma15_19"].ToString();
                    TextBox241.Text	=r["g8ma20_24"].ToString();
                    TextBox242.Text	=r["g8ma25_49"].ToString();
                    TextBox835.Text	=r["g8ma50"].ToString(); 
                    TextBox244.Text	=r["subg8fe"].ToString(); 
                    TextBox245.Text	=r["g8fe1"].ToString(); 
                    TextBox246.Text	=r["g8fe1_4"].ToString(); 
                    TextBox248.Text	=r["g8fe5_9"].ToString(); 
                    TextBox249.Text	=r["g8fe10_14"].ToString();
                    TextBox250.Text	=r["g8fe15_19"].ToString();
                    TextBox251.Text	=r["g8fe20_24"].ToString();
                    TextBox252.Text	=r["g8fe25_49"].ToString();
                    TextBox836.Text	=r["g8fe50"].ToString(); 
                    TextBox253.Text	=r["totalg9"].ToString(); 
                    TextBox254.Text	=r["subg9ma"].ToString(); 
                    TextBox255.Text	=r["g9ma1"].ToString(); 
                    TextBox256.Text	=r["g9ma1_4"].ToString(); 
                    TextBox257.Text	=r["g9ma5_9"].ToString();
                    TextBox258.Text	=r["g9ma10_14"].ToString();
                    TextBox259.Text	=r["g9ma15_19"].ToString();
                    TextBox260.Text	=r["g9ma20_24"].ToString();
                    TextBox261.Text	=r["g9ma25_49"].ToString();
                    TextBox262.Text	=r["g9ma50"].ToString(); 
                    TextBox263.Text	=r["subg9fe"].ToString(); 
                    TextBox264.Text	=r["g9fe1"].ToString(); 
                    TextBox265.Text	=r["g9fe1_4"].ToString(); 
                    TextBox266.Text	=r["g9fe5_9"].ToString(); 
                    TextBox267.Text	=r["g9fe10_14"].ToString();
                    TextBox268.Text	=r["g9fe15_19"].ToString();
                    TextBox284.Text	=r["g9fe20_24"].ToString();
                    TextBox285.Text	=r["g9fe25_49"].ToString();
                    TextBox286.Text	=r["g9fe50"].ToString(); 
                     TextBox287.Text=r["totalg10"].ToString();
                     TextBox288.Text=r["subg10ma"].ToString();
                    TextBox289.Text	=r["g10ma1"].ToString();
                     TextBox290.Text=r["g10ma1_4"].ToString();
                     TextBox291.Text=r["g10ma5_9"].ToString();
                    TextBox292.Text	=r["g10ma10_14"].ToString();
                    TextBox293.Text	=r["g10ma15_19"].ToString();
                    TextBox294.Text	=r["g10ma20_24"].ToString();
                    TextBox295.Text	=r["g10ma25_49"].ToString();
                    TextBox296.Text	=r["g10ma50"].ToString();
                     TextBox297.Text=r["subg10fe"].ToString();
                    TextBox298.Text	=r["g10fe1"].ToString();
                     TextBox299.Text=r["g10fe1_4"].ToString();
                     TextBox300.Text=r["g10fe5_9"].ToString();
                    TextBox301.Text	=r["g10fe10_14"].ToString();
                    TextBox302.Text	=r["g10fe15_19"].ToString();
                    TextBox303.Text	=r["g10fe20_24"].ToString();
                    TextBox304.Text	=r["g10fe25_49"].ToString();
                    TextBox305.Text	=r["g10fe50"].ToString();
                     TextBox306.Text=r["totalg11"].ToString();
                     TextBox307.Text=r["subg11ma"].ToString();
                    TextBox837.Text	=r["g11ma1"].ToString();
                     TextBox838.Text=r["g11ma1_4"].ToString();
                     TextBox839.Text=r["g11ma5_9"].ToString();
                    TextBox840.Text	=r["g11ma10_14"].ToString();
                    TextBox841.Text	=r["g11ma15_19"].ToString();
                    TextBox842.Text	=r["g11ma20_24"].ToString();
                    TextBox843.Text	=r["g11ma25_49"].ToString();
                    TextBox844.Text	=r["g11ma50"].ToString();
                     TextBox316.Text=r["subg11fe"].ToString();
                    TextBox317.Text	=r["g11fe1"].ToString();
                     TextBox318.Text=r["g11fe1_4"].ToString();
                     TextBox319.Text=r["g11fe5_9"].ToString();
                    TextBox320.Text	=r["g11fe10_14"].ToString();
                    TextBox321.Text	=r["g11fe15_19"].ToString();
                    TextBox322.Text	=r["g11fe20_24"].ToString();
                    TextBox323.Text	=r["g11fe25_49"].ToString();
                    TextBox324.Text	=r["g11fe50"].ToString();
                     TextBox325.Text=r["totalg12"].ToString();
                     TextBox326.Text=r["subg12ma"].ToString();
                    TextBox327.Text	=r["g12ma1"].ToString();
                    TextBox328.Text	=r["g12ma1_4"].ToString();
                    TextBox329.Text	=r["g12ma5_9"].ToString();
                    TextBox846.Text	=r["g12ma10_14"].ToString();
                    TextBox847.Text	=r["g12ma15_19"].ToString();
                    TextBox848.Text	=r["g12ma20_24"].ToString();
                    TextBox849.Text	=r["g12ma25_49"].ToString();
                    TextBox850.Text	=r["g12ma50"].ToString();
                     TextBox851.Text=r["subg12fe"].ToString();
                    TextBox852.Text	=r["g12fe1"].ToString();
                     TextBox853.Text=r["g12fe1_4"].ToString();
                     TextBox854.Text=r["g12fe5_9"].ToString();
                    TextBox855.Text	=r["g12fe10_14"].ToString();
                    TextBox856.Text	=r["g12fe15_19"].ToString();
                    TextBox857.Text	=r["g12fe20_24"].ToString();
                    TextBox858.Text	=r["g12fe25_49"].ToString();
                     TextBox859.Text=r["g12fe50"].ToString();
                     TextBox860.Text=r["totalg13"].ToString();
                     TextBox861.Text=r["subg13ma"].ToString();
                    TextBox862.Text	=r["g13ma1"].ToString();
                     TextBox863.Text=r["g13ma1_4"].ToString();
                    TextBox864.Text	=r["g13ma5_9"].ToString();
                    TextBox865.Text = r["g13ma10_14"].ToString();
                    TextBox866.Text	=r["g13ma15_19"].ToString();
                    TextBox867.Text	=r["g13ma20_24"].ToString();
                    TextBox868.Text	=r["g13ma25_49"].ToString();
                    TextBox869.Text	=r["g13ma50"].ToString();
                    TextBox870.Text	=r["subg13fe"].ToString();
                    TextBox871.Text	=r["g13fe1"].ToString();
                     TextBox872.Text=r["g13fe1_4"].ToString();
                    TextBox873.Text	=r["g13fe5_9"].ToString();
                    TextBox874.Text	=r["g13fe10_14"].ToString();
                    TextBox875.Text	=r["g13fe15_19"].ToString();
                    TextBox876.Text	=r["g13fe20_24"].ToString();
                    TextBox877.Text	=r["g13fe25_49"].ToString();
                    TextBox878.Text	=r["g13fe50"].ToString();
                     TextBox879.Text=r["totalg14"].ToString();
                     TextBox880.Text=r["subg14ma"].ToString();
                    TextBox881.Text	=r["g14ma1"].ToString();
                     TextBox882.Text=r["g14ma1_4"].ToString();
                     TextBox883.Text=r["g14ma5_9"].ToString();
                    TextBox884.Text	=r["g14ma10_14"].ToString();
                    TextBox885.Text	=r["g14ma15_19"].ToString();
                    TextBox886.Text	=r["g14ma20_24"].ToString();
                    TextBox887.Text	=r["g14ma25_49"].ToString();
                    TextBox888.Text	=r["g14ma50"].ToString();
                     TextBox889.Text=r["subg14fe"].ToString();
                    TextBox890.Text	=r["g14fe1"].ToString();
                     TextBox891.Text=r["g14fe1_4"].ToString();
                     TextBox892.Text=r["g14fe5_9"].ToString();
                    TextBox893.Text	=r["g14fe10_14"].ToString();
                    TextBox894.Text	=r["g14fe15_19"].ToString();
                    TextBox895.Text	=r["g14fe20_24"].ToString();
                    TextBox896.Text	=r["g14fe25_49"].ToString();
                    TextBox897.Text	=r["g14fe50"].ToString();
                     TextBox898.Text=r["totalg15"].ToString();
                     TextBox899.Text=r["subg15ma"].ToString();
                    TextBox900.Text	=r["g15ma1"].ToString();
                     TextBox901.Text=r["g15ma1_4"].ToString();
                     TextBox902.Text=r["g15ma5_9"].ToString();
                    TextBox903.Text	=r["g15ma10_14"].ToString();
                    TextBox904.Text	=r["g15ma15_19"].ToString();
                    TextBox905.Text	=r["g15ma20_24"].ToString();
                    TextBox906.Text	=r["g15ma25_49"].ToString();
                    TextBox907.Text	=r["g15ma50"].ToString();
                     TextBox908.Text=r["subg15fe"].ToString();
                    TextBox909.Text	=r["g15fe1"].ToString();
                    TextBox910.Text	=r["g15fe1_4"].ToString();
                     TextBox911.Text=r["g15fe5_9"].ToString();
                    TextBox912.Text	=r["g15fe10_14"].ToString();
                    TextBox913.Text	=r["g15fe15_19"].ToString();
                    TextBox914.Text	=r["g15fe20_24"].ToString();
                    TextBox915.Text	=r["g15fe25_49"].ToString();
                    TextBox916.Text	=r["g15fe50"].ToString();
                     TextBox917.Text=r["totalg16"].ToString();
                     TextBox918.Text=r["subg16ma"].ToString();
                    TextBox919.Text	=r["g16ma1"].ToString();
                     TextBox920.Text=r["g16ma1_4"].ToString();
                     TextBox921.Text=r["g16ma5_9"].ToString();
                    TextBox922.Text	=r["g16ma10_14"].ToString();
                    TextBox923.Text	=r["g16ma15_19"].ToString();
                    TextBox924.Text	=r["g16ma20_24"].ToString();
                    TextBox925.Text	=r["g16ma25_49"].ToString();
                    TextBox926.Text	=r["g16ma50"].ToString();
                     TextBox927.Text=r["subg16fe"].ToString();
                    TextBox928.Text	=r["g16fe1"].ToString();
                     TextBox929.Text=r["g16fe1_4"].ToString();
                     TextBox930.Text=r["g16fe5_9"].ToString();
                    TextBox931.Text	=r["g16fe10_14"].ToString();
                    TextBox932.Text	=r["g16fe15_19"].ToString();
                    TextBox933.Text	=r["g16fe20_24"].ToString();
                    TextBox934.Text	=r["g16fe25_49"].ToString();
                    TextBox935.Text	=r["g16fe50"].ToString();
                     TextBox936.Text=r["totalg17"].ToString();
                     TextBox937.Text=r["subg17ma"].ToString();
                    TextBox938.Text	=r["g17ma1"].ToString();
                     TextBox939.Text=r["g17ma1_4"].ToString();
                     TextBox940.Text=r["g17ma5_9"].ToString();
                    TextBox941.Text	=r["g17ma10_14"].ToString();
                    TextBox942.Text	=r["g17ma15_19"].ToString();
                    TextBox943.Text	=r["g17ma20_24"].ToString();
                    TextBox944.Text	=r["g17ma25_49"].ToString();
                    TextBox945.Text	=r["g17ma50"].ToString();
                     TextBox946.Text=r["subg17fe"].ToString();
                    TextBox947.Text	=r["g17fe1"].ToString();
                     TextBox948.Text=r["g17fe1_4"].ToString();
                     TextBox949.Text=r["g17fe5_9"].ToString();
                    TextBox950.Text	=r["g17fe10_14"].ToString();
                    TextBox951.Text	=r["g17fe15_19"].ToString();
                    TextBox952.Text	=r["g17fe20_24"].ToString();
                    TextBox953.Text	=r["g17fe25_49"].ToString();
                    TextBox954.Text	=r["g17fe50"].ToString();

                    Session["Edit"] = "T";
            }
          
        }
        catch (Exception ex)
        {
            webMessage.Show("Error Searching Lab: " + ex.Message.ToString());
            return;
        }
    }
    //=========== Clear LAB1 and LAB2 screen
    protected void CLS_LAB()
    {

        TextBox796.Text = string.Empty;
        TextBox797.Text = string.Empty;
        TextBox799.Text = string.Empty;
        TextBox801.Text = string.Empty;
        TextBox798.Text = string.Empty;
        TextBox800.Text = string.Empty;
        TextBox802.Text = string.Empty;
        TextBox803.Text = string.Empty;
        TextBox804.Text = string.Empty;
        TextBox805.Text = string.Empty;
        TextBox806.Text = string.Empty;
        TextBox807.Text = string.Empty;
        TextBox808.Text = string.Empty;
        TextBox809.Text = string.Empty;
        TextBox810.Text = string.Empty;
        TextBox811.Text = string.Empty;
        TextBox812.Text = string.Empty;
        TextBox813.Text = string.Empty;
        TextBox814.Text = string.Empty;
        TextBox815.Text = string.Empty;
        TextBox816.Text = string.Empty;
        TextBox817.Text = string.Empty;
        TextBox818.Text = string.Empty;
        TextBox819.Text = string.Empty;
        TextBox820.Text = string.Empty;
        TextBox821.Text = string.Empty;
        TextBox158.Text = string.Empty;
        TextBox159.Text = string.Empty;
        TextBox160.Text = string.Empty;
        TextBox161.Text = string.Empty;
        TextBox162.Text = string.Empty;
        TextBox163.Text = string.Empty;
        TextBox164.Text = string.Empty;
        TextBox165.Text = string.Empty;
        TextBox166.Text = string.Empty;
        TextBox167.Text = string.Empty;
        TextBox168.Text = string.Empty;
        TextBox169.Text = string.Empty;
        TextBox170.Text = string.Empty;
        TextBox171.Text = string.Empty;
        TextBox172.Text = string.Empty;
        TextBox173.Text = string.Empty;
        TextBox174.Text = string.Empty;
        TextBox175.Text = string.Empty;
        TextBox176.Text = string.Empty;
        TextBox177.Text = string.Empty;
        TextBox178.Text = string.Empty;
        TextBox179.Text = string.Empty;
        TextBox180.Text = string.Empty;
        TextBox181.Text = string.Empty;
        TextBox182.Text = string.Empty;
        TextBox183.Text = string.Empty;
        TextBox184.Text = string.Empty;
        TextBox185.Text = string.Empty;
        TextBox186.Text = string.Empty;
        TextBox187.Text = string.Empty;
        TextBox188.Text = string.Empty;
        TextBox189.Text = string.Empty;
        TextBox190.Text = string.Empty;
        TextBox191.Text = string.Empty;
        TextBox192.Text = string.Empty;
        TextBox193.Text = string.Empty;
        TextBox194.Text = string.Empty;
        TextBox195.Text = string.Empty;
        TextBox196.Text = string.Empty;
        TextBox197.Text = string.Empty;
        TextBox198.Text = string.Empty;
        TextBox199.Text = string.Empty;
        TextBox200.Text = string.Empty;
        TextBox201.Text = string.Empty;
        TextBox202.Text = string.Empty;
        TextBox203.Text = string.Empty;
        TextBox204.Text = string.Empty;
        TextBox205.Text = string.Empty;
        TextBox206.Text = string.Empty;
        TextBox207.Text = string.Empty;
        TextBox208.Text = string.Empty;
        TextBox209.Text = string.Empty;
        TextBox210.Text = string.Empty;
        TextBox211.Text = string.Empty;
        TextBox212.Text = string.Empty;
        TextBox213.Text = string.Empty;
        TextBox214.Text = string.Empty;
        TextBox215.Text = string.Empty;
        TextBox216.Text = string.Empty;
        TextBox217.Text = string.Empty;
        TextBox218.Text = string.Empty;
        TextBox219.Text = string.Empty;
        TextBox220.Text = string.Empty;
        TextBox221.Text = string.Empty;
        TextBox222.Text = string.Empty;
        TextBox223.Text = string.Empty;
        TextBox224.Text = string.Empty;
        TextBox225.Text = string.Empty;
        TextBox226.Text = string.Empty;
        TextBox227.Text = string.Empty;
        TextBox228.Text = string.Empty;
        TextBox229.Text = string.Empty;
        TextBox230.Text = string.Empty;
        TextBox231.Text = string.Empty;
        TextBox232.Text = string.Empty;
        TextBox233.Text = string.Empty;
        TextBox154.Text = string.Empty;
        TextBox155.Text = string.Empty;
        TextBox156.Text = string.Empty;
        TextBox157.Text = string.Empty;
        TextBox239.Text = string.Empty;
        TextBox247.Text = string.Empty;
        TextBox822.Text = string.Empty;
        TextBox823.Text = string.Empty;
        TextBox824.Text = string.Empty;
        TextBox825.Text = string.Empty;
        TextBox826.Text = string.Empty;
        TextBox827.Text = string.Empty;
        TextBox828.Text = string.Empty;
        TextBox829.Text = string.Empty;
        TextBox830.Text = string.Empty;
        TextBox831.Text = string.Empty;
        TextBox832.Text = string.Empty;
        TextBox833.Text = string.Empty;
        TextBox834.Text = string.Empty;
        TextBox234.Text = string.Empty;
        TextBox235.Text = string.Empty;
        TextBox236.Text = string.Empty;
        TextBox237.Text = string.Empty;
        TextBox238.Text = string.Empty;
        TextBox239.Text = string.Empty;
        TextBox240.Text = string.Empty;
        TextBox241.Text = string.Empty;
        TextBox242.Text = string.Empty;
        TextBox835.Text = string.Empty;
        TextBox244.Text = string.Empty;
        TextBox245.Text = string.Empty;
        TextBox246.Text = string.Empty;
        TextBox248.Text = string.Empty;
        TextBox249.Text = string.Empty;
        TextBox250.Text = string.Empty;
        TextBox251.Text = string.Empty;
        TextBox252.Text = string.Empty;
        TextBox836.Text = string.Empty;
        TextBox253.Text = string.Empty;
        TextBox254.Text = string.Empty;
        TextBox255.Text = string.Empty;
        TextBox256.Text = string.Empty;
        TextBox257.Text = string.Empty;
        TextBox258.Text = string.Empty;
        TextBox259.Text = string.Empty;
        TextBox260.Text = string.Empty;
        TextBox261.Text = string.Empty;
        TextBox262.Text = string.Empty;
        TextBox263.Text = string.Empty;
        TextBox264.Text = string.Empty;
        TextBox265.Text = string.Empty;
        TextBox266.Text = string.Empty;
        TextBox267.Text = string.Empty;
        TextBox268.Text = string.Empty;
        TextBox284.Text = string.Empty;
        TextBox285.Text = string.Empty;
        TextBox286.Text = string.Empty;
        //===================================
        //============================= LAB 2 ==
        TextBox287.Text = string.Empty;
        TextBox288.Text = string.Empty;
        TextBox289.Text = string.Empty;
        TextBox290.Text = string.Empty;
        TextBox291.Text = string.Empty;
        TextBox292.Text = string.Empty;
        TextBox293.Text = string.Empty;
        TextBox294.Text = string.Empty;
        TextBox295.Text = string.Empty;
        TextBox296.Text = string.Empty;
        TextBox297.Text = string.Empty;
        TextBox298.Text = string.Empty;
        TextBox299.Text = string.Empty;
        TextBox300.Text = string.Empty;
        TextBox301.Text = string.Empty;
        TextBox302.Text = string.Empty;
        TextBox303.Text = string.Empty;
        TextBox304.Text = string.Empty;
        TextBox305.Text = string.Empty;
        TextBox306.Text = string.Empty;
        TextBox307.Text = string.Empty;
        TextBox837.Text = string.Empty;
        TextBox838.Text = string.Empty;
        TextBox839.Text = string.Empty;
        TextBox840.Text = string.Empty;
        TextBox841.Text = string.Empty;
        TextBox842.Text = string.Empty;
        TextBox843.Text = string.Empty;
        TextBox844.Text = string.Empty;
        TextBox316.Text = string.Empty;
        TextBox317.Text = string.Empty;
        TextBox318.Text = string.Empty;
        TextBox319.Text = string.Empty;
        TextBox320.Text = string.Empty;
        TextBox321.Text = string.Empty;
        TextBox322.Text = string.Empty;
        TextBox323.Text = string.Empty;
        TextBox324.Text = string.Empty;
        TextBox325.Text = string.Empty;
        TextBox326.Text = string.Empty;
        TextBox327.Text = string.Empty;
        TextBox328.Text = string.Empty;
        TextBox329.Text = string.Empty;
        TextBox846.Text = string.Empty;
        TextBox847.Text = string.Empty;
        TextBox848.Text = string.Empty;
        TextBox849.Text = string.Empty;
        TextBox850.Text = string.Empty;
        TextBox851.Text = string.Empty;
        TextBox852.Text = string.Empty;
        TextBox853.Text = string.Empty;
        TextBox854.Text = string.Empty;
        TextBox855.Text = string.Empty;
        TextBox856.Text = string.Empty;
        TextBox857.Text = string.Empty;
        TextBox858.Text = string.Empty;
        TextBox859.Text = string.Empty;
        TextBox860.Text = string.Empty;
        TextBox861.Text = string.Empty;
        TextBox862.Text = string.Empty;
        TextBox863.Text = string.Empty;
        TextBox864.Text = string.Empty;
        TextBox865.Text = string.Empty;
        TextBox866.Text = string.Empty;
        TextBox867.Text = string.Empty;
        TextBox868.Text = string.Empty;
        TextBox869.Text = string.Empty;
        TextBox870.Text = string.Empty;
        TextBox871.Text = string.Empty;
        TextBox872.Text = string.Empty;
        TextBox873.Text = string.Empty;
        TextBox874.Text = string.Empty;
        TextBox875.Text = string.Empty;
        TextBox876.Text = string.Empty;
        TextBox877.Text = string.Empty;
        TextBox878.Text = string.Empty;
        TextBox879.Text = string.Empty;
        TextBox880.Text = string.Empty;
        TextBox881.Text = string.Empty;
        TextBox882.Text = string.Empty;
        TextBox883.Text = string.Empty;
        TextBox884.Text = string.Empty;
        TextBox885.Text = string.Empty;
        TextBox886.Text = string.Empty;
        TextBox887.Text = string.Empty;
        TextBox888.Text = string.Empty;
        TextBox889.Text = string.Empty;
        TextBox890.Text = string.Empty;
        TextBox891.Text = string.Empty;
        TextBox892.Text = string.Empty;
        TextBox893.Text = string.Empty;
        TextBox894.Text = string.Empty;
        TextBox895.Text = string.Empty;
        TextBox896.Text = string.Empty;
        TextBox897.Text = string.Empty;
        TextBox898.Text = string.Empty;
        TextBox899.Text = string.Empty;
        TextBox900.Text = string.Empty;
        TextBox901.Text = string.Empty;
        TextBox902.Text = string.Empty;
        TextBox903.Text = string.Empty;
        TextBox904.Text = string.Empty;
        TextBox905.Text = string.Empty;
        TextBox906.Text = string.Empty;
        TextBox907.Text = string.Empty;
        TextBox908.Text = string.Empty;
        TextBox909.Text = string.Empty;
        TextBox910.Text = string.Empty;
        TextBox911.Text = string.Empty;
        TextBox912.Text = string.Empty;
        TextBox913.Text = string.Empty;
        TextBox914.Text = string.Empty;
        TextBox915.Text = string.Empty;
        TextBox916.Text = string.Empty;
        TextBox917.Text = string.Empty;
        TextBox918.Text = string.Empty;
        TextBox919.Text = string.Empty;
        TextBox920.Text = string.Empty;
        TextBox921.Text = string.Empty;
        TextBox922.Text = string.Empty;
        TextBox923.Text = string.Empty;
        TextBox924.Text = string.Empty;
        TextBox925.Text = string.Empty;
        TextBox926.Text = string.Empty;
        TextBox927.Text = string.Empty;
        TextBox928.Text = string.Empty;
        TextBox929.Text = string.Empty;
        TextBox930.Text = string.Empty;
        TextBox931.Text = string.Empty;
        TextBox932.Text = string.Empty;
        TextBox933.Text = string.Empty;
        TextBox934.Text = string.Empty;
        TextBox935.Text = string.Empty;
        TextBox936.Text = string.Empty;
        TextBox937.Text = string.Empty;
        TextBox938.Text = string.Empty;
        TextBox939.Text = string.Empty;
        TextBox940.Text = string.Empty;
        TextBox941.Text = string.Empty;
        TextBox942.Text = string.Empty;
        TextBox943.Text = string.Empty;
        TextBox944.Text = string.Empty;
        TextBox945.Text = string.Empty;
        TextBox946.Text = string.Empty;
        TextBox947.Text = string.Empty;
        TextBox948.Text = string.Empty;
        TextBox949.Text = string.Empty;
        TextBox950.Text = string.Empty;
        TextBox951.Text = string.Empty;
        TextBox952.Text = string.Empty;
        TextBox953.Text = string.Empty;
        TextBox954.Text = string.Empty; 

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox797.Text = Convert.ToString(Convert.ToInt32(TextBox799.Text) + Convert.ToInt32(TextBox801.Text));
        TextBox800.Focus();
    }
    protected void TextBox799_TextChanged(object sender, EventArgs e)
    {
        TextBox801.Focus();
    }
    protected void TextBox802_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox798.Text = Convert.ToString(Convert.ToInt32(TextBox800.Text) + Convert.ToInt32(TextBox802.Text));
        TextBox796.Text = Convert.ToString(Convert.ToInt32(TextBox797.Text) + Convert.ToInt32(TextBox798.Text));
         TextBox805.Focus();
    }
    protected void TextBox800_TextChanged(object sender, EventArgs e)
        {
            TextBox802.Focus();
        }

    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox804.Text = Convert.ToString(Convert.ToInt32(TextBox805.Text) + Convert.ToInt32(TextBox806.Text) + Convert.ToInt32(TextBox807.Text) + Convert.ToInt32(TextBox808.Text)
                  + Convert.ToInt32(TextBox809.Text) + Convert.ToInt32(TextBox810.Text) + Convert.ToInt32(TextBox811.Text) + Convert.ToInt32(TextBox812.Text));
        TextBox814.Focus();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox813.Text = Convert.ToString(Convert.ToInt32(TextBox814.Text) + Convert.ToInt32(TextBox815.Text) + Convert.ToInt32(TextBox816.Text) + Convert.ToInt32(TextBox817.Text)
                  + Convert.ToInt32(TextBox818.Text) + Convert.ToInt32(TextBox819.Text) + Convert.ToInt32(TextBox820.Text) + Convert.ToInt32(TextBox821.Text));
        TextBox803.Text = Convert.ToString(Convert.ToInt32(TextBox804.Text) + Convert.ToInt32(TextBox813.Text));
        TextBox160.Focus();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox159.Text = Convert.ToString(Convert.ToInt32(TextBox160.Text) + Convert.ToInt32(TextBox161.Text) + Convert.ToInt32(TextBox162.Text) + Convert.ToInt32(TextBox163.Text)
                 + Convert.ToInt32(TextBox164.Text) + Convert.ToInt32(TextBox165.Text) + Convert.ToInt32(TextBox166.Text) + Convert.ToInt32(TextBox167.Text));
        TextBox169.Focus();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        TextBox168.Text = Convert.ToString(Convert.ToInt32(TextBox169.Text) + Convert.ToInt32(TextBox170.Text) + Convert.ToInt32(TextBox171.Text) + Convert.ToInt32(TextBox172.Text)
                    + Convert.ToInt32(TextBox173.Text) + Convert.ToInt32(TextBox174.Text) + Convert.ToInt32(TextBox175.Text)+Convert.ToInt32(TextBox176.Text));
        TextBox158.Text = Convert.ToString(Convert.ToInt32(TextBox159.Text) + Convert.ToInt32(TextBox168.Text));
        TextBox179.Focus();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        TextBox178.Text = Convert.ToString(Convert.ToInt32(TextBox179.Text) + Convert.ToInt32(TextBox180.Text) + Convert.ToInt32(TextBox181.Text) + Convert.ToInt32(TextBox182.Text)
                 + Convert.ToInt32(TextBox183.Text) + Convert.ToInt32(TextBox184.Text) + Convert.ToInt32(TextBox185.Text) + Convert.ToInt32(TextBox186.Text));
        TextBox188.Focus();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        TextBox187.Text = Convert.ToString(Convert.ToInt32(TextBox188.Text) + Convert.ToInt32(TextBox189.Text) + Convert.ToInt32(TextBox190.Text) + Convert.ToInt32(TextBox191.Text)
                      + Convert.ToInt32(TextBox192.Text) + Convert.ToInt32(TextBox193.Text) + Convert.ToInt32(TextBox194.Text) + Convert.ToInt32(TextBox195.Text));
        TextBox177.Text = Convert.ToString(Convert.ToInt32(TextBox178.Text) + Convert.ToInt32(TextBox187.Text));
        TextBox198.Focus();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        TextBox197.Text = Convert.ToString(Convert.ToInt32(TextBox198.Text) + Convert.ToInt32(TextBox199.Text) + Convert.ToInt32(TextBox200.Text) + Convert.ToInt32(TextBox201.Text)
                + Convert.ToInt32(TextBox202.Text) + Convert.ToInt32(TextBox203.Text) + Convert.ToInt32(TextBox204.Text) + Convert.ToInt32(TextBox205.Text));
        TextBox207.Focus();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        TextBox206.Text = Convert.ToString(Convert.ToInt32(TextBox207.Text) + Convert.ToInt32(TextBox208.Text) + Convert.ToInt32(TextBox209.Text) + Convert.ToInt32(TextBox210.Text)
              + Convert.ToInt32(TextBox211.Text) + Convert.ToInt32(TextBox212.Text) + Convert.ToInt32(TextBox213.Text) + Convert.ToInt32(TextBox214.Text));
        TextBox196.Text = Convert.ToString(Convert.ToInt32(TextBox197.Text) + Convert.ToInt32(TextBox206.Text));
        TextBox217.Focus();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        TextBox216.Text = Convert.ToString(Convert.ToInt32(TextBox217.Text) + Convert.ToInt32(TextBox218.Text) + Convert.ToInt32(TextBox219.Text) + Convert.ToInt32(TextBox220.Text)
               + Convert.ToInt32(TextBox221.Text) + Convert.ToInt32(TextBox222.Text) + Convert.ToInt32(TextBox223.Text) + Convert.ToInt32(TextBox224.Text));
        TextBox226.Focus();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        TextBox225.Text = Convert.ToString(Convert.ToInt32(TextBox226.Text) + Convert.ToInt32(TextBox227.Text) + Convert.ToInt32(TextBox228.Text) + Convert.ToInt32(TextBox229.Text)
              + Convert.ToInt32(TextBox230.Text) + Convert.ToInt32(TextBox231.Text) + Convert.ToInt32(TextBox232.Text) + Convert.ToInt32(TextBox233.Text));
        TextBox215.Text = Convert.ToString(Convert.ToInt32(TextBox216.Text) + Convert.ToInt32(TextBox225.Text));
        TextBox156.Focus();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        TextBox155.Text = Convert.ToString(Convert.ToInt32(TextBox156.Text) + Convert.ToInt32(TextBox157.Text) + Convert.ToInt32(TextBox239.Text) + Convert.ToInt32(TextBox247.Text)
              + Convert.ToInt32(TextBox822.Text) + Convert.ToInt32(TextBox823.Text) + Convert.ToInt32(TextBox824.Text) + Convert.ToInt32(TextBox825.Text));
        TextBox827.Focus();
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        TextBox826.Text = Convert.ToString(Convert.ToInt32(TextBox827.Text) + Convert.ToInt32(TextBox828.Text) + Convert.ToInt32(TextBox829.Text) + Convert.ToInt32(TextBox830.Text)
             + Convert.ToInt32(TextBox831.Text) + Convert.ToInt32(TextBox832.Text) + Convert.ToInt32(TextBox833.Text) + Convert.ToInt32(TextBox834.Text));
        TextBox154.Text = Convert.ToString(Convert.ToInt32(TextBox155.Text) + Convert.ToInt32(TextBox826.Text));
        TextBox236.Focus();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        TextBox235.Text = Convert.ToString(Convert.ToInt32(TextBox236.Text) + Convert.ToInt32(TextBox237.Text) + Convert.ToInt32(TextBox238.Text) + Convert.ToInt32(TextBox240.Text)
             + Convert.ToInt32(TextBox241.Text) + Convert.ToInt32(TextBox242.Text) + Convert.ToInt32(TextBox243.Text) + Convert.ToInt32(TextBox835.Text));
        TextBox245.Focus();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        TextBox244.Text = Convert.ToString(Convert.ToInt32(TextBox245.Text) + Convert.ToInt32(TextBox246.Text) + Convert.ToInt32(TextBox248.Text) + Convert.ToInt32(TextBox249.Text)
            + Convert.ToInt32(TextBox250.Text) + Convert.ToInt32(TextBox251.Text) + Convert.ToInt32(TextBox252.Text) + Convert.ToInt32(TextBox836.Text));
        TextBox234.Text = Convert.ToString(Convert.ToInt32(TextBox235.Text) + Convert.ToInt32(TextBox244.Text));
        TextBox255.Focus();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        TextBox254.Text = Convert.ToString(Convert.ToInt32(TextBox255.Text) + Convert.ToInt32(TextBox256.Text) + Convert.ToInt32(TextBox257.Text) + Convert.ToInt32(TextBox258.Text)
            + Convert.ToInt32(TextBox259.Text) + Convert.ToInt32(TextBox260.Text) + Convert.ToInt32(TextBox261.Text) + Convert.ToInt32(TextBox262.Text));
        TextBox264.Focus();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        TextBox263.Text = Convert.ToString(Convert.ToInt32(TextBox264.Text) + Convert.ToInt32(TextBox265.Text) + Convert.ToInt32(TextBox266.Text) + Convert.ToInt32(TextBox267.Text)
            + Convert.ToInt32(TextBox268.Text) + Convert.ToInt32(TextBox284.Text) + Convert.ToInt32(TextBox285.Text) + Convert.ToInt32(TextBox286.Text));
        TextBox253.Text = Convert.ToString(Convert.ToInt32(TextBox254.Text) + Convert.ToInt32(TextBox263.Text));
        TextBox289.Focus();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        TextBox288.Text = Convert.ToString(Convert.ToInt32(TextBox289.Text) + Convert.ToInt32(TextBox290.Text) + Convert.ToInt32(TextBox291.Text) + Convert.ToInt32(TextBox292.Text)
           + Convert.ToInt32(TextBox293.Text) + Convert.ToInt32(TextBox294.Text) + Convert.ToInt32(TextBox295.Text) + Convert.ToInt32(TextBox296.Text));
        TextBox298.Focus();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        TextBox297.Text = Convert.ToString(Convert.ToInt32(TextBox298.Text) + Convert.ToInt32(TextBox299.Text) + Convert.ToInt32(TextBox300.Text) + Convert.ToInt32(TextBox301.Text)
            + Convert.ToInt32(TextBox302.Text) + Convert.ToInt32(TextBox303.Text) + Convert.ToInt32(TextBox304.Text) + Convert.ToInt32(TextBox305.Text));
        TextBox287.Text = Convert.ToString(Convert.ToInt32(TextBox288.Text) + Convert.ToInt32(TextBox297.Text));
        TextBox838.Focus();
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        TextBox837.Text = Convert.ToString(Convert.ToInt32(TextBox838.Text) + Convert.ToInt32(TextBox839.Text) + Convert.ToInt32(TextBox840.Text) + Convert.ToInt32(TextBox841.Text)
           + Convert.ToInt32(TextBox842.Text) + Convert.ToInt32(TextBox843.Text) + Convert.ToInt32(TextBox844.Text) + Convert.ToInt32(TextBox845.Text));
        TextBox317.Focus();
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        TextBox316.Text = Convert.ToString(Convert.ToInt32(TextBox317.Text) + Convert.ToInt32(TextBox318.Text) + Convert.ToInt32(TextBox319.Text) + Convert.ToInt32(TextBox320.Text)
                  + Convert.ToInt32(TextBox321.Text) + Convert.ToInt32(TextBox322.Text) + Convert.ToInt32(TextBox323.Text) + Convert.ToInt32(TextBox324.Text));
        TextBox306.Text = Convert.ToString(Convert.ToInt32(TextBox837.Text) + Convert.ToInt32(TextBox316.Text));
        TextBox327.Focus();
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        TextBox326.Text = Convert.ToString(Convert.ToInt32(TextBox327.Text) + Convert.ToInt32(TextBox328.Text) + Convert.ToInt32(TextBox329.Text) + Convert.ToInt32(TextBox846.Text)
          + Convert.ToInt32(TextBox847.Text) + Convert.ToInt32(TextBox848.Text) + Convert.ToInt32(TextBox849.Text) + Convert.ToInt32(TextBox850.Text));
        TextBox852.Focus();
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        TextBox851.Text = Convert.ToString(Convert.ToInt32(TextBox852.Text) + Convert.ToInt32(TextBox853.Text) + Convert.ToInt32(TextBox854.Text) + Convert.ToInt32(TextBox855.Text)
                  + Convert.ToInt32(TextBox856.Text) + Convert.ToInt32(TextBox857.Text) + Convert.ToInt32(TextBox858.Text) + Convert.ToInt32(TextBox859.Text));
        TextBox325.Text = Convert.ToString(Convert.ToInt32(TextBox326.Text) + Convert.ToInt32(TextBox851.Text));
        TextBox862.Focus();
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        TextBox861.Text = Convert.ToString(Convert.ToInt32(TextBox862.Text) + Convert.ToInt32(TextBox863.Text) + Convert.ToInt32(TextBox864.Text) + Convert.ToInt32(TextBox865.Text)
          + Convert.ToInt32(TextBox866.Text) + Convert.ToInt32(TextBox867.Text) + Convert.ToInt32(TextBox868.Text) + Convert.ToInt32(TextBox869.Text));
        TextBox871.Focus();
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        TextBox870.Text = Convert.ToString(Convert.ToInt32(TextBox871.Text) + Convert.ToInt32(TextBox872.Text) + Convert.ToInt32(TextBox873.Text) + Convert.ToInt32(TextBox874.Text)
                 + Convert.ToInt32(TextBox875.Text) + Convert.ToInt32(TextBox876.Text) + Convert.ToInt32(TextBox877.Text) + Convert.ToInt32(TextBox878.Text));
        TextBox860.Text = Convert.ToString(Convert.ToInt32(TextBox861.Text) + Convert.ToInt32(TextBox870.Text));
        TextBox881.Focus();
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        TextBox880.Text = Convert.ToString(Convert.ToInt32(TextBox881.Text) + Convert.ToInt32(TextBox882.Text) + Convert.ToInt32(TextBox883.Text) + Convert.ToInt32(TextBox884.Text)
         + Convert.ToInt32(TextBox885.Text) + Convert.ToInt32(TextBox886.Text) + Convert.ToInt32(TextBox887.Text) + Convert.ToInt32(TextBox888.Text));
        TextBox890.Focus();
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        TextBox889.Text = Convert.ToString(Convert.ToInt32(TextBox890.Text) + Convert.ToInt32(TextBox891.Text) + Convert.ToInt32(TextBox892.Text) + Convert.ToInt32(TextBox893.Text)
                + Convert.ToInt32(TextBox894.Text) + Convert.ToInt32(TextBox895.Text) + Convert.ToInt32(TextBox896.Text) + Convert.ToInt32(TextBox897.Text));
        TextBox879.Text = Convert.ToString(Convert.ToInt32(TextBox880.Text) + Convert.ToInt32(TextBox889.Text));
        TextBox900.Focus();
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        TextBox899.Text = Convert.ToString(Convert.ToInt32(TextBox900.Text) + Convert.ToInt32(TextBox901.Text) + Convert.ToInt32(TextBox902.Text) + Convert.ToInt32(TextBox903.Text)
        + Convert.ToInt32(TextBox904.Text) + Convert.ToInt32(TextBox905.Text) + Convert.ToInt32(TextBox906.Text) + Convert.ToInt32(TextBox907.Text));
        TextBox909.Focus();
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        TextBox908.Text = Convert.ToString(Convert.ToInt32(TextBox909.Text) + Convert.ToInt32(TextBox910.Text) + Convert.ToInt32(TextBox911.Text) + Convert.ToInt32(TextBox912.Text)
               + Convert.ToInt32(TextBox913.Text) + Convert.ToInt32(TextBox914.Text) + Convert.ToInt32(TextBox915.Text) + Convert.ToInt32(TextBox916.Text));
        TextBox898.Text = Convert.ToString(Convert.ToInt32(TextBox899.Text) + Convert.ToInt32(TextBox908.Text));
        TextBox919.Focus();
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        TextBox918.Text = Convert.ToString(Convert.ToInt32(TextBox919.Text) + Convert.ToInt32(TextBox920.Text) + Convert.ToInt32(TextBox921.Text) + Convert.ToInt32(TextBox922.Text)
       + Convert.ToInt32(TextBox923.Text) + Convert.ToInt32(TextBox924.Text) + Convert.ToInt32(TextBox925.Text) + Convert.ToInt32(TextBox926.Text));
        TextBox928.Focus();
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        TextBox927.Text = Convert.ToString(Convert.ToInt32(TextBox928.Text) + Convert.ToInt32(TextBox929.Text) + Convert.ToInt32(TextBox930.Text) + Convert.ToInt32(TextBox931.Text)
               + Convert.ToInt32(TextBox932.Text) + Convert.ToInt32(TextBox933.Text) + Convert.ToInt32(TextBox934.Text) + Convert.ToInt32(TextBox935.Text));
        TextBox917.Text = Convert.ToString(Convert.ToInt32(TextBox918.Text) + Convert.ToInt32(TextBox927.Text));
        TextBox938.Focus();
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        TextBox937.Text = Convert.ToString(Convert.ToInt32(TextBox938.Text) + Convert.ToInt32(TextBox939.Text) + Convert.ToInt32(TextBox940.Text) + Convert.ToInt32(TextBox941.Text)
       + Convert.ToInt32(TextBox942.Text) + Convert.ToInt32(TextBox943.Text) + Convert.ToInt32(TextBox944.Text) + Convert.ToInt32(TextBox945.Text));
        TextBox947.Focus();
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        TextBox946.Text = Convert.ToString(Convert.ToInt32(TextBox947.Text) + Convert.ToInt32(TextBox948.Text) + Convert.ToInt32(TextBox949.Text) + Convert.ToInt32(TextBox950.Text)
               + Convert.ToInt32(TextBox951.Text) + Convert.ToInt32(TextBox952.Text) + Convert.ToInt32(TextBox953.Text) + Convert.ToInt32(TextBox954.Text));
        TextBox936.Text = Convert.ToString(Convert.ToInt32(TextBox937.Text) + Convert.ToInt32(TextBox946.Text));
        btnSave.Focus();
    }
    protected void TextBox821_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox232_TextChanged(object sender, EventArgs e)
    {
         
    }
}
