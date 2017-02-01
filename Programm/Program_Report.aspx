<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Program_Report.aspx.cs" Inherits="Programm_Program_Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ECEWS Report Module Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 875px;
        }
        .auto-style6 {
            font-weight: bold;
        }
        .auto-style7 {
        }
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            text-align: right;
            font-size: large;
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3"><asp:Image ID="Image1" runat="server" Height="102px" ImageUrl="~/image/unnamed.jpg" Width="523px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; | <a href ="../DataEntries.aspx">Home</a> | <a href="../Default.aspx">DashBoard</a> |
                </td>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <table class="auto-style1" style="border-style: solid">
                        <tr>
                            <td class="auto-style9" colspan="3" style="background-color: #666699; text-align: center;"> <strong>Program 
                                Achievment Report</strong></td>
                            <td class="auto-style9"> &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text="State :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpStates" runat="server" AutoPostBack="True"   Width="60%" OnSelectedIndexChanged="drpStates_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="Local Government Area :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpLGA" runat="server" AutoPostBack="True"   Width="60%" OnSelectedIndexChanged="drpLGA_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label3" runat="server" CssClass="auto-style6" Text="Facility Name :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpFacname" runat="server" Width="60%">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label4" runat="server" CssClass="auto-style6" Text="Month :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpMonths" runat="server" Width="100px">
                                </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label7" runat="server" CssClass="auto-style6" Text="To Month  :"></asp:Label>
                                <asp:DropDownList ID="drpMonths2" runat="server" Width="100px"  >
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label5" runat="server" CssClass="auto-style6" Text="Year :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpYears" runat="server" Width="100px">
                                </asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label8" runat="server" CssClass="auto-style6" Text="To Year :"></asp:Label>
                                <asp:DropDownList ID="drpYears2" runat="server" Width="100px">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label6" runat="server" CssClass="auto-style6" Text="Thematic Area :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpProgramArea" runat="server" Width="300px" OnSelectedIndexChanged="drpProgramArea_SelectedIndexChanged"  >
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>
                                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="500" OnTick="Timer1_Tick">
                                </asp:Timer>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7" colspan="3" style="border-style: inset; border-width: thin; text-align: center; background-color: #999966;">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="Timer1" />
                                    </Triggers>
                                    <ContentTemplate>
                                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Report" />
                                        
                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/image/bar-ajax-loader.gif" Visible="False" />
                                        
                                        <asp:Label ID="lblMsg" runat="server" Visible="False"></asp:Label>
                                        
                                    </ContentTemplate>
                                </asp:UpdatePanel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">

                    <div id="lcenter" 
                        style="font-family: 'Times New Roman', Times, serif; font-size: small; text-align: center; background-color: #C0C0C0; color: #800000; font-weight: bold;">
                    Copyright &copy; 2015 | Property of Excellence Commuinty Education Walfare Scheme (ECEWS )
                            </div>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
