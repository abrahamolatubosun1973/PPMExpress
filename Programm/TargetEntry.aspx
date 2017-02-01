<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TargetEntry.aspx.cs" Inherits="Programm_TargetEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 104px;
        }
        .auto-style3 {
            width: 1107px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 124px;
        }
        .auto-style6 {
            height: 23px;
            width: 124px;
            text-align: right;
        }
        .auto-style7 {
            width: 124px;
            text-align: right;
        }
        .auto-style8 {
            width: 945px;
        }
        .auto-style9 {
            height: 23px;
            width: 945px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3"><asp:Image ID="Image1" runat="server" Height="102px" ImageUrl="~/image/unnamed.jpg" Width="523px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; | <a href ="../DataEntries.aspx">Home</a> | <a href="../Default.aspx">DashBoard</a> |

                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <table class="auto-style1" style="border: thin solid #808000;">
                        <tr>
                            <td colspan="3" style="font-family: 'Courier New', Courier, monospace; font-size: large; font-weight: bold; color: #CCCCFF; background-color: #000000; text-align: center;">ASSIGN TARGET</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label2" runat="server" Text="Month :"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:DropDownList ID="drpMonth" runat="server" Width="101px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label3" runat="server" Text="Year :"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:DropDownList ID="drpYear" runat="server" Width="101px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style4"></td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label4" runat="server" CssClass="auto-style6" Text="State :"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:DropDownList ID="drpStates" runat="server" AutoPostBack="True"   Width="40%" OnSelectedIndexChanged="drpStates_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label5" runat="server" CssClass="auto-style6" Text="Local Gov. Area :"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:DropDownList ID="drpLGA" runat="server" AutoPostBack="True"   Width="40%" OnSelectedIndexChanged="drpLGA_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label6" runat="server" CssClass="auto-style6" Text="Facility Name :"></asp:Label>
                            </td>
                            <td class="auto-style9">
                                <asp:DropDownList ID="drpFacname" runat="server" Width="40%">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label1" runat="server" Text="Program Area"></asp:Label>
                            </td>
                            <td class="auto-style8">
                                <asp:DropDownList ID="drpProgram" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpProgram_SelectedIndexChanged">
                                </asp:DropDownList>
                                <%--<div class="progress">
                                    <div class="progress-bar progress-bar-striped" style="width:100%">
                                        100%
                                    </div>
                                </div>--%>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="auto-style8">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%" >
                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                    <Columns>
                                        <asp:BoundField DataField="code" HeaderText="Code" />
                                        <asp:BoundField DataField="grouptype" HeaderText="Group Type" />
                                        <asp:BoundField DataField="Description" HeaderText="Description">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle Width="80%" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Target">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtTarget" runat="server"></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#000065" />
                                </asp:GridView>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td class="auto-style8" style="background-color: #C0C0C0; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large; text-align: center">
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="  Submit   " />
&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Text="Reset" Width="79px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
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
        <script src="../Scripts/bootstrap.min.js"></script>
        <script src="../Scripts/jquery-1.9.1.min.js"></script>
    </form>
</body>
</html>
