<%@ Page Title="Home " Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style2 {
        width: 421px;
    }
    .auto-style3 {
        height: 23px;
        width: 489px;
    }
    .auto-style4 {
        width: 149px;
        text-align: center;
    }
    .auto-style5 {
        height: 23px;
        width: 149px;
        text-align: center;
    }
        .auto-style17 {
            width: 489px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     
    
    <table class="style1">
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <table class="style1" style="border-style: solid; width: 98%;">
                <tr>
                    <td colspan="3" style="text-align: center; background-color: #A9B7CA; font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold">Monitoring and Evaluation System DashBoard</td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: solid; border-bottom-width: thin">
                        <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Program Thematic Area"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-bottom-style: solid; border-bottom-width: thin">
                        <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Total Data Captured"></asp:Label>
                    </td>
                    <td style="text-align: center">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label3" runat="server" Text="ART"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox1" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                    <td rowspan="4" style="vertical-align: top">
                        <asp:Panel ID="Panel2" runat="server" GroupingText="Thematic Area Summary ">
                            <table class="style1">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label122" runat="server" Text="Thematic Area :"></asp:Label>
                                        <asp:DropDownList ID="DropDownList4" runat="server" Width="62%">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label123" runat="server" Text="Moth :"></asp:Label>
                                        <asp:DropDownList ID="DropDownList5" runat="server" Width="20%">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label124" runat="server" Text="Year :"></asp:Label>
                                        <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label4" runat="server" Text="CARE "></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label5" runat="server" Text="HIV TESTING AND COUNCELLING"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox3" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label6" runat="server" Text="HIV INTEGRATION"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox4" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label7" runat="server" Text="GENDER NORM"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox5" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                    <td rowspan="11" style="vertical-align: top">
                        <asp:Panel ID="Panel1" runat="server" GroupingText="Data Exchange Section" Height="220px">
                            <table style=" width:100%">
                                <tr>
                                    <td>
                                         <asp:Label ID="Label120" runat="server" Text="State Name :"></asp:Label>
                                        <asp:TextBox ID="TextBox15" runat="server" Width="82px"></asp:TextBox>
                                    </td>
                                    <td>
                                         <asp:Label ID="Label121" runat="server" Text="Month :"></asp:Label>
                                        &nbsp;<asp:ComboBox ID="ComboBox1" runat="server" DropDownStyle="DropDownList" OnSelectedIndexChanged="ComboBox1_SelectedIndexChanged" Width="70px">
                                            <asp:ListItem></asp:ListItem>
                                            <asp:ListItem>January</asp:ListItem>
                                            <asp:ListItem>Feburary</asp:ListItem>
                                            <asp:ListItem>March</asp:ListItem>
                                            <asp:ListItem>April</asp:ListItem>
                                            <asp:ListItem>May</asp:ListItem>
                                            <asp:ListItem>June</asp:ListItem>
                                            <asp:ListItem>July</asp:ListItem>
                                            <asp:ListItem>August</asp:ListItem>
                                            <asp:ListItem>September</asp:ListItem>
                                            <asp:ListItem>October</asp:ListItem>
                                            <asp:ListItem>November</asp:ListItem>
                                            <asp:ListItem>December</asp:ListItem>
                                        </asp:ComboBox>
                                    </td>
                                </tr>
                                <tr>
                                   <td colspan="2" style="text-align: center">
                                     <asp:Button ID="btnExport" runat="server" Text="Export Database in Xml" OnClick="btnExport_Click" />
                                   </td>
                                </tr>
                            </table>
                           
                            <hr />
                            <asp:Label ID="Label16" runat="server" Text="Data Inport Section :"></asp:Label>
                            <hr />
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="249px" />
                            &nbsp;
                            <asp:Button ID="btnImportXml" runat="server" Text="Import Data from Xml" OnClick="btnImportXml_Click" />
                            <br />
                            <br />
                            <br />
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label8" runat="server" Text="LABORATORY SERVICES"></asp:Label>
                    </td>
                    <td class="auto-style5" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox6" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label9" runat="server" Text="FOOD AND NUTRTION"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox7" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label10" runat="server" Text="ORPHANS AND VULNERABLE CHILDREN SERVICE"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox8" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label11" runat="server" Text="(PMTCT) PREVENTION FROM MOTHER TO CHILD TRANSMISSION"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox9" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label12" runat="server" Text="POST EXPOSURE PROFILAXIS"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox10" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label13" runat="server" Text="PRIORITY POPULATION"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox11" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label14" runat="server" Text="TUBERCULOSIS"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox12" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        <asp:Label ID="Label15" runat="server" Text="TRAINING"></asp:Label>
                    </td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        <asp:TextBox ID="TextBox13" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="70px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        &nbsp;</td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17" style="border-bottom-style: dashed; border-bottom-width: thin">
                        &nbsp;</td>
                    <td class="auto-style4" style="border-right-style: dotted; border-left-style: dotted">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    
     
    
</asp:Content>

