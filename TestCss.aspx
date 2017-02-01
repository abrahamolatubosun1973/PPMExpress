<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestCss.aspx.cs" Inherits="TestCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="Css/myTest.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="left">This is the fashion </div>
    <div class="right">Trust Me I can do all things through Christ that strenghten me</div>
    </div>
        <asp:Label ID="Label1" runat="server" >Enter Name :</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
         <asp:Label ID="Label2" runat="server" >Enter Age :</asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
         <asp:Label ID="Label3" runat="server" >Enter Marital Status : :</asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
         <asp:Label ID="Label4" runat="server" >Enter Marital Status : :</asp:Label>
        
        <br />
        <br />
        Number 1 :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Export Database" Height="251px" Width="498px">
            &nbsp;<asp:Label ID="Label120" runat="server" Text="State Admin Name :"></asp:Label>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <asp:Label ID="Label121" runat="server" Text="Month/Year :"></asp:Label>
            <asp:TextBox ID="TextBox11" runat="server" Height="17px" Width="69px"></asp:TextBox>
            &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="Export Database in Xml" />
            <br />
            <hr />
            Inport Database
            <hr />
            &nbsp; &nbsp;<asp:FileUpload ID="FileUpload1" runat="server" Width="249px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Upload XML Files" />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        Number 2 :<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sum" />
        
        <br />
        <br />
       <hr />
        <div>
        &nbsp;
            <asp:Label ID="Label115" runat="server" Text="Label"/>
       </div>
        
    </form>
</body>
</html>
