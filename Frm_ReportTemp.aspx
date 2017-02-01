<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Frm_ReportTemp.aspx.cs" Inherits="Frm_ReportTemp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ECEWS Report Module Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 152px;
        }
        .auto-style2 {
            width: 199px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            text-align: center;
            color: #FFFFFF;
        }
        .auto-style5 {
            text-align: right;
            }
        .auto-style6 {
            font-weight: bold;
        }
        .auto-style7 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table style="height: 124px; width: 1220px">
            <tr>
                <td class="auto-style2">

                </td>
                <td>

                    <asp:Image ID="Image1" runat="server" Height="102px" ImageUrl="~/image/unnamed.jpg" Width="523px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; | <a href ="DataEntries.aspx">Home</a> | <a href="Default.aspx">DashBoard</a> |</td>
                <td class="auto-style1">

                </td>
            </tr>
               <tr>
                <td class="auto-style2">

                </td>
                <td style="vertical-align: top">

                    <table class="auto-style3" style="border-style: solid; border-width: thin">
                        <tr>
                            <td class="auto-style4" colspan="4" style="background-color: #666699"><strong style="text-align: center"> PERIODIC REPORT </strong></td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text="State :"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:DropDownList ID="drpStates" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpStates_SelectedIndexChanged" Width="60%">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="Local Government Area :"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:DropDownList ID="drpLGA" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpLGA_SelectedIndexChanged" Width="60%">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label3" runat="server" CssClass="auto-style6" Text="Facility Name :"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:DropDownList ID="drpFacname" runat="server" Width="60%">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label4" runat="server" CssClass="auto-style6" Text="From Month :"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:DropDownList ID="drpMonths" runat="server" Width="100px">
                                </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label7" runat="server" CssClass="auto-style6" Text="To Month  :"></asp:Label>
                                <asp:DropDownList ID="drpMonths2" runat="server" Width="100px" OnSelectedIndexChanged="drpMonths0_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label5" runat="server" CssClass="auto-style6" Text="From Year :"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:DropDownList ID="drpYears" runat="server" Width="100px">
                                </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label8" runat="server" CssClass="auto-style6" Text="To Year :"></asp:Label>
                            &nbsp;<asp:DropDownList ID="drpYears2" runat="server" Width="100px">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label6" runat="server" CssClass="auto-style6" Text="Thematic Area :"></asp:Label>
                            </td>
                            <td class="auto-style7">
                                <asp:DropDownList ID="drpProgramArea" runat="server" Width="300px" OnSelectedIndexChanged="drpProgramArea_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="4" style="border-style: inset; border-width: thin; text-align: center; background-color: #999966;">
                                <asp:Button ID="Button1" runat="server" Text="Generate Report" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back to Home" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                </td>
                <td class="auto-style1">

                </td>
            </tr>
                <tr>
                <td class="auto-style2">

                </td>
                <td>
                    <div id="lcenter" 
                        style="font-family: 'Times New Roman', Times, serif; font-size: small; text-align: center; background-color: #C0C0C0; color: #800000; font-weight: bold;">
                    Copyright &copy; 2015 | Property of Excellence Commuinty Education Walfare Scheme (ECEWS )
                            </div>
                </td>
                <td class="auto-style1">

                </td>
            </tr>
            </table>
    </div>
    </form>
</body>
</html>
