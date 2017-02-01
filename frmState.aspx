<%@ Page Title="State Form" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmState.aspx.cs" Inherits="frmState" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            padding:10;
        }
        .style4
        {
            width: 214px;
        }
        .style5
        {
            width: 586px;
        }
        .style6
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table >
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                <table class="style3" style="border-style: dotted">
                    <tr>
                        <td colspan="2">
                        <div id="H1" class="mHead" 
                                style="color: #FFFFFF; font-size: large; text-align: center; background-color: #333399">
                            State and Local Government Area Setup
                        </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            State Name :</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="250pt"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            L G A :</td>
                        <td>
                           <asp:TextBox ID="TextBox2" runat="server" Width="250pt"></asp:TextBox>
                           </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="td">
                            <asp:ImageButton ID="ImageButton1" runat="server" 
                                ImageUrl="~/image/Submit.png" Height="21px" 
                                onclick="ImageButton1_Click" />
&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/Clear1.png" 
                                onclick="ImageButton3_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="td">
                            <asp:Label ID="LblErr" runat="server" Font-Bold="True" Font-Italic="True" 
                                Font-Size="Small" ForeColor="#FFFFCC" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
                                CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="420pt" 
                                AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <Columns>
                                <asp:BoundField DataField="Statename" HeaderText="State Name" />
                                <asp:BoundField DataField="LGA" HeaderText="LGA" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerSettings Mode="NextPreviousFirstLast" 
                                FirstPageImageUrl="~/image/First.ICO" LastPageImageUrl="~/image/Last.ICO" 
                                NextPageImageUrl="~/image/Next.ICO" 
                                PreviousPageImageUrl="~/image/Previous.ICO" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                            </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

