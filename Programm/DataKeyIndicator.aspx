<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataKeyIndicator.aspx.cs" Inherits="DataKeyIndicator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 115px;
        }
        .auto-style3 {
            width: 1036px;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            text-align: right;
        }
        .auto-style6 {
            text-align: right;
            width: 229px;
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
                    <table class="auto-style1" style="border-style: dotted; border-width: medium">
                        <tr>
                            <td class="auto-style5" colspan="2" style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large; font-weight: bold; color: #FFFFFF; background-color: #000000; text-align: center">KEY INDICATORS FOR TARGET ASSIGNMENT</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">&nbsp;</td>
                            <td aria-checked="undefined">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label1" runat="server" Text="Program Area :" style="font-weight: 700"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpProgramArea" runat="server" Width="65%" AutoPostBack="True" OnSelectedIndexChanged="drpProgramArea_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2" style="font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; text-decoration: underline; font-size: large; font-weight: bold; text-align: center;">
                                LIST OF INDICATORS</td>
                        </tr>
                        <tr>
                            <td class="auto-style4" colspan="2">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="100%"  DataKeyNames="ID" style="font-weight: 700" Font-Names="Arial" Font-Size="11pt" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True"  >
                                    <Columns>
                                        <asp:BoundField HeaderText="Description" DataField="description" >
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <ItemStyle HorizontalAlign="Left" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Select">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="ChkSelect" runat="server" Text="Select"  />
                                            </ItemTemplate>
                                            <ItemStyle Width="90px" Font-Italic="True" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" Font-Size="XX-Small" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                    <PagerSettings FirstPageImageUrl="~/image/first.png" LastPageImageUrl="~/image/last.png" Mode="NextPreviousFirstLast" NextPageImageUrl="~/image/next.png" PreviousPageImageUrl="~/image/previous.png" />
                                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                    <RowStyle BackColor="White" ForeColor="#330099" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2" aria-live="off" style="text-align: center">
&nbsp;
                                &nbsp;
                                &nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="lblcount" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
&nbsp;
                                </td>
                        </tr>
                        <tr>
                            <td class="auto-style5" colspan="2" style="text-align: center; background-color: #999999">
                                <asp:Button ID="Button1" runat="server" Text="Submit" Width="121px" OnClick="Button1_Click" />
&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="Reset" Width="79px" OnClick="Button2_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
