using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (IsPostBack)
        //{
        //    TextBox1.Attributes.Add("onKeyPress", "doClick('" + Button1.ClientID + "',event)");
        //    TextBox2.Attributes.Add("onKeyPress", "doClick('" + Button2.ClientID + "',event)");
        //    TextBox3.Attributes.Add("onKeyPress", "doClick('" + Button3.ClientID + "',event)");
        //}
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "I JUST GOT IT";
        TextBox2.Focus();
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        //TextBox1.Text = "You are cool";
        TextBox2.Text = "Thank you";
        TextBox3.Focus();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox3.Text = "3";
        TextBox4.Focus();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox4.Text = "4";
        TextBox5.Focus();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        TextBox5.Text = "5";
        TextBox1.Focus();
    }
}