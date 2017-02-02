<%@ Page Title="Facility Name Form" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmFacility.aspx.cs" Inherits="frmFacility" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

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
        .style7
        {
            width: 143px;
        }
        .style8
        {
            width: 577px;
        }
        .style9
        {
            color: #FF0000;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
        Width="936px">
        <asp:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
            <HeaderTemplate>Facility Entry Form</HeaderTemplate>
            <ContentTemplate><table class="style3"><tr><td class="style4">&nbsp;</td><td class="style5">&nbsp;</td><td>&nbsp;</td></tr><tr><td class="style4">&nbsp;</td><td class="style5"><table class="style3" style="border-style: dotted"><tr><td colspan="2">
                <div ID="H1" class="mHead" 
                    style="color: #FFFFFF; font-size: large; text-align: center; background-color: #333399; font-weight: bold;">Facilities&nbsp; Setup </div></td></tr><tr>
                <td class="style6" nowrap="nowrap">State Name :</td><td>
                <asp:DropDownList ID="DrpState" runat="server" AutoPostBack="True" 
                                            
                    OnSelectedIndexChanged="DrpState_SelectedIndexChanged" Width="250pt" 
                    AppendDataBoundItems="True"></asp:DropDownList>
                <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
                </td></tr><tr><td class="style6" nowrap="nowrap">L G A :</td><td>
                    <asp:DropDownList ID="DrpLGA" runat="server" Width="250pt" 
                        AppendDataBoundItems="True"></asp:DropDownList>
                    <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
                    </td></tr><tr><td class="style6" nowrap="nowrap">Facility Name :</td><td><asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" 
                                            Width="213pt"></asp:TextBox></td></tr><tr>
                    <td class="style6" nowrap="nowrap">Facility Level :</td><td>
                    <asp:DropDownList ID="DrpFacname" runat="server" Width="130pt" 
                        AppendDataBoundItems="True"><asp:ListItem></asp:ListItem><asp:ListItem>Primary</asp:ListItem><asp:ListItem>Secondry</asp:ListItem></asp:DropDownList>
                    <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
                    </td></tr><tr><td class="style6" nowrap="nowrap">Facility Type : </td><td>
                    <asp:DropDownList ID="Drpfactype" runat="server" Width="130pt" 
                        AppendDataBoundItems="True"><asp:ListItem></asp:ListItem><asp:ListItem>Public</asp:ListItem><asp:ListItem>Private</asp:ListItem><asp:ListItem>Faith Base</asp:ListItem></asp:DropDownList>
                    <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
                    </td></tr><tr><td class="style6" nowrap="nowrap">Technical Area :</td><td>
                    <asp:DropDownList ID="DrpTechArea" runat="server" Width="130pt" 
                        AppendDataBoundItems="True"><asp:ListItem></asp:ListItem><asp:ListItem>Care and Treatment</asp:ListItem><asp:ListItem>PMTCT</asp:ListItem><asp:ListItem>HCT</asp:ListItem><asp:ListItem>ALL</asp:ListItem></asp:DropDownList>
                    <asp:TextBox ID="TextBox7" runat="server" BorderColor="#FFFFCC" ReadOnly="false" 
                        Visible="False"></asp:TextBox>
                    </td></tr><tr><td class="td" colspan="2"><asp:ImageButton ID="ImageButton1" runat="server" 
                                            ImageUrl="~/image/Submit.png" 
                        OnClick="ImageButton1_Click" />&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" 
                                            ImageUrl="~/image/Update.png" 
                        OnClick="ImageButton2_Click" />
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/image/Clear1.png" 
                        onclick="ImageButton4_Click" />
                    </td></tr><tr><td class="td" colspan="2"><asp:Label ID="lblerr" runat="server" Font-Bold="True" Font-Italic="True" 
                                            Font-Size="Small" ForeColor="#FFFFCC"></asp:Label></td></tr><tr><td colspan="2"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                            BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                                            CellPadding="4" DataKeyNames="num" Width="100%" AllowPaging="True"><Columns><asp:BoundField DataField="facname" HeaderText="Facility Name." /><asp:BoundField DataField="faclevel" HeaderText="Facility Level" /><asp:BoundField DataField="factype" HeaderText="Fac. Type" /><asp:BoundField DataField="techarea" HeaderText="Tech. Area" /></Columns><FooterStyle BackColor="#99CCCC" ForeColor="#003399" /><HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" /><PagerSettings FirstPageImageUrl="~/image/First.ICO" FirstPageText="First page" 
                                                LastPageImageUrl="~/image/Last.ICO" LastPageText="Last page" 
                                                NextPageImageUrl="~/image/Next.ICO" NextPageText="Next page" 
                                                PreviousPageImageUrl="~/image/Previous.ICO" PreviousPageText="Prev. page" /><PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" /><RowStyle BackColor="White" ForeColor="#003399" /><SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" /><SortedAscendingCellStyle BackColor="#EDF6F6" /><SortedAscendingHeaderStyle BackColor="#0D4AC4" /><SortedDescendingCellStyle BackColor="#D6DFDF" /><SortedDescendingHeaderStyle BackColor="#002876" /></asp:GridView></td></tr></table></td><td>&nbsp;</td></tr><tr><td class="style4">&nbsp;</td><td class="style5">&nbsp;</td><td>&nbsp;</td></tr></table></ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
            <HeaderTemplate>
                Search Form</HeaderTemplate>
            <ContentTemplate><table class="style1"><tr><td class="style7">&nbsp;</td><td class="style8">&nbsp;</td><td>&nbsp;</td></tr><tr><td class="style7">&nbsp;</td><td class="style8">
                <table class="style1" style="border-color: #000000; border-style: dashed;"><tr><td colspan="3">
                    <div ID="H2" class="mHead" 
                        style="color: #FFFFFF; font-size: large; text-align: center; background-color: #333399">
                        Seach Facilities&nbsp; Setup </div></td></tr><tr><td class="style6"><span class="style9">*</span> State Name :</td><td><asp:DropDownList ID="drpstate2" runat="server" AutoPostBack="True" 
                                            Width="250pt" onselectedindexchanged="drpstate2_SelectedIndexChanged"></asp:DropDownList></td><td>&nbsp;</td></tr><tr><td class="style6"><span class="style9">*</span> L G A :</td><td><asp:DropDownList ID="drpLGA2" runat="server" Width="250pt"></asp:DropDownList></td><td>&nbsp;</td></tr><tr><td class="style6">Facility Name :</td><td><asp:TextBox ID="TextBox2" runat="server" Width="213pt" 
                                            ontextchanged="TextBox2_TextChanged"></asp:TextBox></td><td>&nbsp;</td></tr><tr>
                    <td colspan="3" style="text-align: center">
                    <asp:Label ID="lblerr2" runat="server" Font-Bold="True" Font-Italic="True" 
                                            Font-Size="Small" ForeColor="#990000"></asp:Label></td></tr><tr>
                        <td colspan="3" style="text-align: center">
                    <asp:ImageButton ID="ImageButton3" runat="server" 
                                            ImageUrl="~/image/find.png" 
                        onclick="ImageButton3_Click" /></td></tr><tr><td colspan="3"><asp:GridView 
                        ID="GridView2" runat="server" AllowPaging="True" 
                                            AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
                                            BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="num" 
                                            Width="100%" onrowcommand="GridView2_RowCommand" 
                            onpageindexchanging="GridView2_PageIndexChanging"><Columns><asp:BoundField DataField="statename" HeaderText="State Name" /><asp:BoundField DataField="lga" HeaderText="L G A" /><asp:BoundField DataField="facname" HeaderText="Facility Name" /><asp:ButtonField 
                            CommandName="SelectCMD" HeaderText="Select" Text="Select" /></Columns><FooterStyle BackColor="#FFFFCC" ForeColor="#330099" /><HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" /><PagerSettings FirstPageImageUrl="~/image/First.ICO" FirstPageText="First page" 
                                                LastPageImageUrl="~/image/Last.ICO" LastPageText="Last Page" 
                                                Mode="NextPreviousFirstLast" NextPageImageUrl="~/image/Next.ICO" 
                                                NextPageText="Next page" PreviousPageImageUrl="~/image/Previous.ICO" 
                                                PreviousPageText="Prev. page" /><PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" /><RowStyle BackColor="White" ForeColor="#330099" /><SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" /><SortedAscendingCellStyle BackColor="#FEFCEB" /><SortedAscendingHeaderStyle BackColor="#AF0101" /><SortedDescendingCellStyle BackColor="#F6F0C0" /><SortedDescendingHeaderStyle BackColor="#7E0000" /></asp:GridView></td></tr></table></td><td>&nbsp;</td></tr><tr><td class="style7">&nbsp;</td><td class="style8">&nbsp;</td><td>&nbsp;</td></tr></table></ContentTemplate>
        </asp:TabPanel>
    </asp:TabContainer>
</asp:Content>

