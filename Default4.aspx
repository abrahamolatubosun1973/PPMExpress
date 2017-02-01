<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title>Untitled Page</title>
<script type="text/javascript">

    
    //function doClick(buttonName,e)
    //{
    //    //the purpose of this function is to allow the enter key to 
    //    //point to the correct button to click.
    //    var key;

    //    if(window.event)
    //        key = window.event.keyCode;     //IE
    //    else
    //        key = e.which;     //firefox
    
    //    if (key == 13)
    //    {
    //        //Get the button the user wants to have clicked
    //        var btn = document.getElementById(buttonName);
    //        if (btn != null)
    //        { //If we find the button click it
    //            btn.click();
    //            event.keyCode = 0
    //        }
    //    }
    //}
 
    
</script>
</head>
<body>
<form id="form1" runat="server">
<div>
    <table>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" DefaultButton="Button1">
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"></asp:TextBox>
                 <asp:Button ID="Button1" runat="server"  Text="Button" OnClick="Button1_Click" Style="display:none" />
                </asp:Panel>
            </td>
         </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel2" runat="server" DefaultButton="Button2">
                <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="true"></asp:TextBox>
                 <asp:Button ID="Button2" runat="server"  Text="Button" OnClick="Button2_Click" Style="display:none" />
                 </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="true" ></asp:TextBox>
                  <asp:Button ID="Button3" runat="server"  Text="Button" OnClientClick="Button3_Click"  OnClick="Button3_Click" />
            </td>
        </tr>
        <tr>
            <td>
                 <asp:TextBox ID="TextBox4" runat="server" AutoPostBack="true" OnKeyPress="if(event.keyCode==13)document.getElementById('Button4').Click()"></asp:TextBox>
                  <asp:Button ID="Button4" runat="server"  Text="Button"   OnClick="Button4_Click" />
            </td>
        </tr>
        <tr>
            <td>
                 <asp:TextBox ID="TextBox5" runat="server" AutoPostBack="true" OnKeyPress="if(event.keyCode==13)document.getElementById('Button5').Click()"></asp:TextBox>
                 <asp:Button ID="Button5" runat="server"  Text="Button"   OnClick="Button5_Click" />
            </td>
        </tr>
    </table>
</div>
</form>
</body>
</html>