<%@ Page Title="Data Element" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" 
    CodeFile="frmDataElement.aspx.cs" Inherits="Groups_frmDataElement"  MaintainScrollPositionOnPostback="true"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 68px;
        }
        .style4
        {
            width: 650px;
        }
        .style5
        {
            width: 172px;
        }
        .auto-style1 {
            width: 97px;
        }
        .auto-style2 {
            width: 759px;
        }
        .auto-style6 {
        }
        .auto-style7 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="624px" Width="1019px">
                <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                    <HeaderTemplate>
                        Data Element Entry Form
                    </HeaderTemplate>
                    <ContentTemplate>
                        <table class="style1">
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td class="auto-style2">
                                    <table class="style1" style="border: thin solid #800000; margin-right: 0px">
                                        <tr>
                                            <td colspan="3" style="text-align: center; font-family: 'Times New Roman', Times, serif; background-color: #008080; color: #FFFFFF; font-size: large">DATA ELEMENT FORM</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6" nowrap="nowrap" style="text-align: right">Form Name :</td>
                                            <td class="auto-style7">
                                                <asp:DropDownList ID="DropDownList1" runat="server" Width="270px">
                                                </asp:DropDownList>
                                                &nbsp; </td>
                                            <td>Abrv. :&nbsp;
                                                <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6" nowrap="nowrap" style="text-align: right">Data Element Code :</td>
                                            <td class="auto-style7">
                                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6" nowrap="nowrap" style="text-align: right">Data Element Descriptin :</td>
                                            <td class="auto-style7">
                                                <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">&nbsp;</td>
                                            <td class="auto-style7">
                                                <asp:Label ID="lblerr" runat="server" Font-Italic="True" Visible="False"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6" style="text-align: right">Bulk file upload :</td>
                                            <td class="auto-style7">
                                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                                &nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="True" OnClick="Button1_Click" Text="Upload now" />
                                                <asp:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" ConfirmText="Are you sure ?" Enabled="True" TargetControlID="Button1">
                                                </asp:ConfirmButtonExtender>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">&nbsp;</td>
                                            <td bgcolor="#999966" class="auto-style7">
                                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/Submit.png" />
                                                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/image/Update.png" Visible="False" />
                                                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/delete_image.jpg" Width="70px" />
                                                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/image/Clear1.png" />
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6" colspan="3">
                                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%">
                                                    <Columns>
                                                        <asp:BoundField DataField="grouptype" HeaderText="Group Type">
                                                        <HeaderStyle Font-Size="Small" />
                                                        <ItemStyle Font-Size="Small" Width="50px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="code" HeaderText="Code">
                                                        <HeaderStyle Font-Size="Small" />
                                                        <ItemStyle Font-Size="Small" Width="50px" />
                                                        </asp:BoundField>
                                                        <asp:BoundField DataField="description" HeaderText="Description">
                                                        <HeaderStyle Font-Size="Small" />
                                                        <ItemStyle Font-Size="Small" />
                                                        </asp:BoundField>
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
                                        </tr>
                                    </table>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style1">&nbsp;</td>
                                <td class="auto-style2">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                    <HeaderTemplate>
                        Find Data Element Form
                    </HeaderTemplate>
                    <ContentTemplate>
                        <table class="style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <table class="style1" style="border: thin solid #008080">
                                        <tr>
                                            <td colspan="3" style="font-family: 'Times New Roman', Times, serif; color: #FFFFFF; background-color: #003399; text-align: center">Find Data Element Form</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
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
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

