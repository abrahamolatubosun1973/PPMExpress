<%@ Page Title="Group Head" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmGhead.aspx.cs" Inherits="Groups_Ghead" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style4
        {
            width: 223px;
        }
        .style5
        {
            width: 552px;
        }
        .style3
        {
            text-align: right;
        }
        .style8
        {
            text-align: right;
            height: 26px;
        }
        .style9
        {
            height: 26px;
        }
        .style6
        {
            width: 132px;
        }
        .style7
        {
            width: 544px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
        Width="871px">
        <asp:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
            <HeaderTemplate>
                Form Entry
            </HeaderTemplate>
            <ContentTemplate>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table align="center" class="style1">
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
                                <td>
                                    <div class="border">
                                        <table class="style1" style="border-style: dashed; border-color: #000000">
                                            <tr>
                                                <td colspan="3" 
                                                    
                                                    style="background-color: #9999FF; font-family: 'Times New Roman', Times, serif; font-size: large; text-align: center; color: #FFFFFF;">
                                                    CLASSIFIED INDICATOR REPORTING FORM</td>
                                            </tr>
                                            <tr>
                                                <td class="style8">
                                                    Form Name :</td>
                                                <td class="style9">
                                                    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
                                                        ontextchanged="TextBox1_TextChanged" Width="250pt"></asp:TextBox>
                                                </td>
                                                <td class="style9">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style3">
                                                    Form ID :</td>
                                                <td>
                                                    <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" 
                                                        ontextchanged="TextBox2_TextChanged"></asp:TextBox>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style3">
                                                    &nbsp;</td>
                                                <td style="text-align: center">
                                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/Submit.png" 
                                                        OnClick="ImageButton1_Click" />
                                                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/image/Update.png" 
                                                        OnClick="ImageButton2_Click" />
                                                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/Clear1.png" 
                                                        OnClick="ImageButton3_Click" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style3">
                                                    &nbsp;</td>
                                                <td>
                                                    <asp:Label ID="lblerr" runat="server" Font-Bold="True" Font-Size="Small" 
                                                        ForeColor="#660066" Visible="False"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style3" colspan="3">
                                                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                                                        AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
                                                        BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                                                        OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%">
                                                        <Columns>
                                                            <asp:BoundField DataField="FID" HeaderText="Form ID">
                                                            <HeaderStyle HorizontalAlign="Left" />
                                                            <ItemStyle HorizontalAlign="Left" Width="110px" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="Fname" HeaderText="Form Name">
                                                            <HeaderStyle HorizontalAlign="Left" />
                                                            <ItemStyle HorizontalAlign="Left" />
                                                            </asp:BoundField>
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
                                    </div>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel runat="server" HeaderText="TabPanel2" ID="TabPanel2">
            <HeaderTemplate>
                Search Form
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
                            <table class="style1" style="border-style: dashed; border-color: #000000">
                                <tr>
                                    <td colspan="3" 
                                        style="background-color: #008080; color: #FFFFFF; font-size: large; text-align: center">
                                        SEARCH FORM</td>
                                </tr>
                                <tr>
                                    <td>
                                        Form Name :</td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        Form ID :</td>
                                    <td>
                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td style="text-align: center">
                                        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/image/find.png" 
                                            OnClick="ImageButton4_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td style="text-align: center">
                                        <asp:Label ID="lblerr2" runat="server" Font-Bold="True" Font-Italic="True" 
                                            Font-Size="Small" Visible="False"></asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="4" DataKeyNames="num" 
                                            OnPageIndexChanging="GridView2_PageIndexChanging" 
                                            OnRowCommand="GridView2_RowCommand" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="FID" HeaderText="FORM ID">
                                                <ItemStyle Width="110px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="FNAME" HeaderText="FORM NAME" />
                                                <asp:ButtonField CommandName="SelectCMD" HeaderText="SELECT" Text="Select">
                                                <ItemStyle Font-Italic="True" Width="70px" />
                                                </asp:ButtonField>
                                            </Columns>
                                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
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
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
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

