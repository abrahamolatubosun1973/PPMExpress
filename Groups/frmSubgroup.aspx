<%@ Page Title="Sub Group" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmSubgroup.aspx.cs" Inherits="Groups_frmSubgroup" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 9px;
        }
        .style3
        {
            width: 146px;
        }
        .style4
        {
            text-align: right;
        }
        .style5
        {
            width: 631px;
        }
        .style6
        {
            width: 184px;
        }
        .style7
        {
            width: 565px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
        Width="872px">
        <asp:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
            <HeaderTemplate>
                Sub Category Form
            </HeaderTemplate>
            <ContentTemplate>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table class="style1">
                            <tr>
                                <td class="style3">
                                    &nbsp;</td>
                                <td class="style5">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    &nbsp;</td>
                                <td class="style5">
                                    <table class="style1" 
                                        style="font-family: 'Times New Roman', Times, serif; border-style: dashed; border-color: #000000">
                                        <tr>
                                            <td colspan="3" 
                                                style="text-align: center; font-family: 'Times New Roman', Times, serif; font-size: large; color: #FFFFFF; background-color: #009933">
                                                SUB CATEGORY FORM</td>
                                        </tr>
                                        <tr>
                                            <td class="style4">
                                                Form Name :</td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="305px">
                                                </asp:DropDownList>
                                            </td>
                                            <td nowrap="nowrap">
                                                <asp:Label ID="lblAbrv" runat="server" BackColor="#999999" Font-Bold="True" 
                                                    Font-Italic="True" ForeColor="#CC0000"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4">
                                                Sub Name :</td>
                                            <td>
                                                <asp:TextBox ID="TextBox6" runat="server" AutoPostBack="True" 
                                                    ontextchanged="TextBox6_TextChanged" Width="250px"></asp:TextBox>
                                            </td>
                                            <td nowrap="nowrap">
                                                Abriviation :&nbsp;&nbsp;
                                                <asp:TextBox ID="TextBox7" runat="server" Width="50pt"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style4">
                                                Sub Name Code:</td>
                                            <td>
                                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="3" style="background-color: #C0C0C0; text-align: center">
                                                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/image/Submit.png" 
                                                    onclick="ImageButton5_Click" />
                                                <asp:ImageButton ID="ImageButton6" runat="server" 
                                                    ImageUrl="~/image/Update.png" onclick="ImageButton6_Click" />
                                                <asp:ImageButton ID="ImageButton8" runat="server" Height="20pt" 
                                                    ImageUrl="~/image/delete_image.jpg" onclick="ImageButton8_Click" Width="70pt" />
                                                <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/image/Clear1.png" 
                                                    onclick="ImageButton7_Click" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td style="text-align: center; font-family: 'Times New Roman', Times, serif; color: #990000; font-size: medium; font-style: italic;">
                                                <asp:Label ID="lblerr" runat="server" Visible="False"></asp:Label>
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                                    AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
                                                    BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="num" 
                                                    onpageindexchanging="GridView1_PageIndexChanging" Width="100%">
                                                    <Columns>
                                                        <asp:BoundField DataField="fid" HeaderText="Abrv." />
                                                        <asp:BoundField DataField="fname" HeaderText="Form Name" />
                                                        <asp:BoundField DataField="subname" HeaderText="Sub-Name" />
                                                        <asp:BoundField DataField="subid" HeaderText="Sub-Abrv" />
                                                        <asp:BoundField DataField="code" HeaderText="Code" />
                                                    </Columns>
                                                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                                    <PagerSettings Mode="NumericFirstLast" />
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
                                    </table>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    &nbsp;</td>
                                <td class="style5">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
            <HeaderTemplate>
                Find Sub CategoryForm
            </HeaderTemplate>
            <ContentTemplate>
                <table class="style1">
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            <table class="style1">
                                <tr>
                                    <td colspan="3" 
                                        style="font-family: 'Times New Roman', Times, serif; font-size: large; text-align: center; color: #FFFFFF; background-color: #808080">
                                        SEARCH FORM</td>
                                </tr>
                                <tr>
                                    <td class="style4">
                                        Sub - Name :</td>
                                    <td>
                                        <asp:TextBox ID="TextBox9" runat="server" ontextchanged="TextBox9_TextChanged" 
                                            Width="220pt"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style4">
                                        Sub-Abriviation :</td>
                                    <td>
                                        <asp:TextBox ID="TextBox10" runat="server" 
                                            ontextchanged="TextBox10_TextChanged"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td style="text-align: center">
                                        <asp:Label ID="lblmsg" runat="server" Font-Bold="True" Font-Italic="True" 
                                            Font-Size="Small" Visible="False"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td style="text-align: center">
                                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/image/find.png" 
                                            onclick="ImageButton9_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
                                            AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
                                            BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="num" 
                                            onpageindexchanging="GridView2_PageIndexChanging" 
                                            onrowcommand="GridView2_RowCommand" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="fid" HeaderText="Abrv." />
                                                <asp:BoundField DataField="fname" HeaderText="Form Name" />
                                                <asp:BoundField DataField="subname" HeaderText="Sub-Name" />
                                                <asp:BoundField DataField="subid" HeaderText="Sub-Abrv" />
                                                <asp:BoundField DataField="code" HeaderText="Code" />
                                                <asp:ButtonField CommandName="SelectCMD" HeaderText="Select" Text="Select">
                                                <ItemStyle Font-Italic="True" />
                                                </asp:ButtonField>
                                            </Columns>
                                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                            <PagerSettings Mode="NumericFirstLast" />
                                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                            <RowStyle BackColor="White" ForeColor="#330099" />
                                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                        </asp:GridView>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:TabPanel>
    </asp:TabContainer>
</asp:Content>

