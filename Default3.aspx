<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Export data from sql server database to excel in asp.net using c#</title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
        .auto-style2 {
            font-weight: bold;
        }
        .auto-style3 {
            width: 116px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
<asp:Button ID="btnExport" Text="Export Data" runat="server" onclick="btnExport_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" Format="dd/MM/yyyy" PopupButtonID="TextBox1" TargetControlID="TextBox1">
    </asp:CalendarExtender>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" style="font-weight: 700" Text="REPORT GENERATION FORM"></asp:Label>
    <br />
    <table border="1" class="auto-style1">
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="From :"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" CssClass="auto-style2" Text="Month"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" CssClass="auto-style2" Text="Year"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:DropDownList ID="drpMonth" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="drpYear" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Label ID="Label4" runat="server" style="font-weight: 700" Text="To :"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" CssClass="auto-style2" Text="Month"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" CssClass="auto-style2" Text="Year"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:DropDownList ID="drpMonth1" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="drpYear1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="1" rowspan="1">
                <asp:Label ID="Label8" runat="server" Text="Thematic Area :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="150px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" Text="Generate Report" OnClick="Button1_Click" />
                <asp:Button ID="btnReport" runat="server" OnClick="btnReport_Click" Text="Report" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Height="213px" Width="324px"></asp:ListBox>
    <br />
    <br />
    <br />
    <br />
    <br />
</div>
</form>
</body>
</html>