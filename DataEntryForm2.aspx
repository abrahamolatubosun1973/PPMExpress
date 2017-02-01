<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" EnableViewState="true" CodeFile="DataEntryForm2.aspx.cs" Inherits="DataEntryForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script type="text/javascript">

//     function stopRKey(evt) {
//         var evt = (evt) ? evt : ((event) ? event : null);
//         var node = (evt.target) ? evt.target : ((evt.srcElement) ? evt.srcElement : null);
//         if ((evt.keyCode == 13) && (node.type == "text")) { return false; }
//     }

//     document.onkeypress = stopRKey;

</script> 
       <style type="text/css">
         .auto-style42 {
            width: 683px;
            <%--background-color: #FFFFFF;--%>
        }
           .auto-style2 {
            width: 100%;
        }
        .auto-style12 {
        text-align: right;
        font-weight: bold;
        width: 142px;
    }
        .auto-style8 {
            width: 368px;
        }
        .auto-style16 {
            text-align: left;
        }
           .style2
           {
               background-color: #FF9933;
           }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>&nbsp;</td>
            <td style="vertical-align: top;">
                <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
                   <ContentTemplate>
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">
                                <asp:Label ID="Label1079" runat="server" Text="State :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;">
                                <asp:DropDownList ID="drpStates" runat="server" Width="198px" AutoPostBack="False" OnSelectedIndexChanged="drpStates_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg9" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">
                                <asp:Label ID="Label1080" runat="server" Text="LGA :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;">
                                <asp:DropDownList ID="drpLGA" runat="server" Width="198px" AutoPostBack="False" OnSelectedIndexChanged="drpLGA_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg8" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblmsg" runat="server" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr >
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">Facility :</td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;" >
                                <asp:DropDownList ID="drpFacility" runat="server" Width="198px">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg7" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td >&nbsp;</td>
                        </tr>
                        <tr >
                            <td class="auto-style12" style="border-style: solid; border-width: thin;" >
                                <asp:Label ID="Label1081" runat="server" Text="Month :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;">
                                <asp:DropDownList ID="drpMnth" runat="server" Width="90px">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem>Jan</asp:ListItem>
                                    <asp:ListItem>Feb</asp:ListItem>
                                    <asp:ListItem>Mar</asp:ListItem>
                                    <asp:ListItem>Apr</asp:ListItem>
                                    <asp:ListItem>May</asp:ListItem>
                                    <asp:ListItem>Jun</asp:ListItem>
                                    <asp:ListItem>Jul</asp:ListItem>
                                    <asp:ListItem>Aug</asp:ListItem>
                                    <asp:ListItem>Sep</asp:ListItem>
                                    <asp:ListItem>Oct</asp:ListItem>
                                    <asp:ListItem>Nov</asp:ListItem>
                                    <asp:ListItem>Dec</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg6" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">
                                <asp:Label ID="Label1082" runat="server" Text="Year :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;">
                                <asp:DropDownList ID="drpYrs" runat="server" Width="90px">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg10" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">
                                <asp:Label ID="Label1083" runat="server" Text="Thematic Area :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;">
                                <asp:DropDownList ID="drpThematic" runat="server" AutoPostBack="False" 
                                    onselectedindexchanged="drpThematic_SelectedIndexChanged1" Width="198px">
                                </asp:DropDownList>
                                <asp:TextBox ID="TextBox1076" runat="server" BorderColor="#CCCCCC" ReadOnly="True" Width="95px" style="color: #FF0000" Visible="False"></asp:TextBox>
                                <asp:Label ID="lblmsg5" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                        </tr>
                        <caption class="auto-style16">
                            <strong>PROGRAM INDICATOR ENTRY FORM</strong>&nbsp;</caption>
                    </table>
                </ContentTemplate>
                </asp:UpdatePanel>--%>
                <asp:Label ID="lblThematic" runat="server" style="font-weight: 700"></asp:Label></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
               <%--<asp:UpdatePanel ID="UpdatePanel5" runat="server">
                   <ContentTemplate>--%>

                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View1" runat="server">
                                <table class="style1">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label1" runat="server" Text="CARE AND SUPPORT"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label4" runat="server" Text="Number of HIV-positive adults and children ever enrolled into HIV clinical care (pre ART and ART clients)
"></asp:Label>
                                                    </td>
                                                    <td>

                                                        <asp:TextBox ID="TextBox1" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>

                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label5" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox2" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label6" runat="server" Text="Age (<1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label7" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label8" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label9" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label10" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label11" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label12" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label13" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox3" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox4" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox5" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox6" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox7" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox8" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox9" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel1" runat="server" DefaultButton="Button1">
                                                            <asp:Button ID="Button1" runat="server" Text="Button" Style="display:none" OnClick="Button1_Click"  />
                                                        <asp:TextBox ID="TextBox10" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
                                                           </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label14" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox11" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label15" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label16" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label17" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label18" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label19" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label20" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label21" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label22" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox12" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox13" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox14" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox15" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox16" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox17" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox18" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel2" runat="server" DefaultButton="Button2">
                                                            <asp:Button ID="Button2" runat="server" Text="Button" Style="display:none" OnClick="Button2_Click"  />
                                                        <asp:TextBox ID="TextBox19" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox19_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label23" runat="server" Text="Number of HIV-positive adults and children currently receiving HIV clinical care (pre ART and ART clients)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox20" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label24" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox21" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label25" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label26" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label27" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label28" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label29" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label30" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label31" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label32" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox22" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox23" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox24" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox25" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox26" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox27" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox28" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel3" runat="server" DefaultButton="Button3">
                                                            <asp:Button ID="Button3" runat="server" Text="Button" Style="display:none" OnClick="Button3_Click"  />
                                                        <asp:TextBox ID="TextBox29" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox29_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label33" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox30" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label34" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label35" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label36" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label37" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label38" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label39" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label40" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label41" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox31" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox32" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox33" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox34" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox35" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox36" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox37" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel4" runat="server" DefaultButton="Button4">
                                                            <asp:Button ID="Button4" runat="server" Text="Button" Style="display:none" OnClick="Button4_Click"  />
                                                        <asp:TextBox ID="TextBox38" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox38_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label42" runat="server" Text="Number of HIV-positive adults and children currently receiving HIV clinical care ( only pre ART clients)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox39" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label43" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox40" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label44" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label45" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label46" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label47" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label48" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label49" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label50" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label51" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox41" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox42" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox43" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox44" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox45" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox46" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox47" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel5" runat="server" DefaultButton="Button5">
                                                            <asp:Button ID="Button5" runat="server" Text="Button" Style="display:none" OnClick="Button5_Click"  />
                                                        <asp:TextBox ID="TextBox48" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox48_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label52" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox49" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label53" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label54" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label55" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label56" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label57" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label58" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label59" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label60" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox50" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox51" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox52" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox53" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox54" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox55" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox56" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel6" runat="server" DefaultButton="Button6">
                                                            <asp:Button ID="Button6" runat="server" Text="Button" Style="display:none" OnClick="Button6_Click"  />
                                                        <asp:TextBox ID="TextBox57" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox57_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label61" runat="server" Text="Number of HIV-positive adults and children newly enrolled into HIV clinical care during the reporting month (Pre ART and ART clients)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox58" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label62" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox59" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label63" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label64" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label65" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label66" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label67" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label68" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label69" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label70" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox60" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox61" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox62" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox63" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox64" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox65" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox66" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel7" runat="server" DefaultButton="Button7">
                                                            <asp:Button ID="Button7" runat="server" Text="Button" Style="display:none" OnClick="Button7_Click"  />
                                                        <asp:TextBox ID="TextBox67" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox67_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label71" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox68" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label72" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label73" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label74" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label75" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label76" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label77" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label78" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label79" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox69" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox70" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox71" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox72" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox73" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox74" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox75" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel8" runat="server" DefaultButton="Button8">
                                                            <asp:Button ID="Button8" runat="server" Text="Button" Style="display:none" OnClick="Button8_Click"  />
                                                        <asp:TextBox ID="TextBox76" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox76_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label80" runat="server" Text="Number of HIV-positive adults and children newly enrolled in clinical care during the reporting period who received at least one of the following at enrollment: clinical assessment (WHO staging) OR CD4 count OR viral load (pre ART and ART clients)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox77" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label81" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox78" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label82" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label83" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label84" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label85" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label86" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label87" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label88" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label89" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox79" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox80" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox81" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox82" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox83" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox84" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox85" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel9" runat="server" DefaultButton="Button9">
                                                            <asp:Button ID="Button9" runat="server" Text="Button" Style="display:none" OnClick="Button9_Click"  />
                                                        <asp:TextBox ID="TextBox86" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox86_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label90" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox87" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label91" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label92" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label93" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label94" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label95" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label96" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label97" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label98" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox88" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox89" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox90" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox91" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox92" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox93" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox94" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel10" runat="server" DefaultButton="Button10">
                                                            <asp:Button ID="Button10" runat="server" Text="Button" Style="display:none" OnClick="Button10_Click"  />
                                                        <asp:TextBox ID="TextBox95" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox95_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                     </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label99" runat="server" Text="Number of HIV-positive adults and children newly enrolled into HIV clinical care during the reporting month (pre ART clients only) 
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox96" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label100" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox97" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label101" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label102" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label103" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label104" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label105" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label106" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label107" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label108" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox98" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox99" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox100" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox101" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox102" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox103" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox104" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel11" runat="server" DefaultButton="Button11">
                                                            <asp:Button ID="Button11" runat="server" Text="Button" Style="display:none" OnClick="Button11_Click"  />
                                                        <asp:TextBox ID="TextBox105" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox105_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label109" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox106" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label110" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label111" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label112" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label113" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label114" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label115" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label116" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label117" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox107" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox108" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox109" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox110" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox111" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox112" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox113" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel12" runat="server" DefaultButton="Button12">
                                                            <asp:Button ID="Button12" runat="server" Text="Button" Style="display:none" OnClick="Button12_Click"  />
                                                        <asp:TextBox ID="TextBox114" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox114_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label118" runat="server" Text="Number of patients NOT on ART who were transferred in during the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox115" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label119" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox116" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label120" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label121" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label122" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label123" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label124" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label125" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label126" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label127" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox117" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox118" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox119" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox120" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox121" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox122" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox123" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel13" runat="server" DefaultButton="Button13">
                                                            <asp:Button ID="Button13" runat="server" Text="Button" Style="display:none" OnClick="Button13_Click"  />
                                                        <asp:TextBox ID="TextBox124" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox124_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label128" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox125" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label129" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label130" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label131" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label132" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label133" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label134" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label135" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label136" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox126" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox127" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox128" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox129" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox130" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox131" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox132" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel14" runat="server" DefaultButton="Button14">
                                                            <asp:Button ID="Button14" runat="server" Text="Button" Style="display:none" OnClick="Button14_Click"  />
                                                        <asp:TextBox ID="TextBox133" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox133_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label137" runat="server" Text="Number of patients NOT on ART that returned to treatment during the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox134" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label138" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox135" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label139" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label140" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label141" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label142" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label143" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label144" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label145" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label146" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox136" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox137" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox138" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox139" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox140" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox141" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox142" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel15" runat="server" DefaultButton="Button15">
                                                            <asp:Button ID="Button15" runat="server" Text="Button" Style="display:none" OnClick="Button15_Click"  />
                                                        <asp:TextBox ID="TextBox143" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox143_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label147" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox144" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label148" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label149" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label150" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label151" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label152" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label153" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label154" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label155" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox145" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox146" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox147" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox148" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox149" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox150" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox151" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel16" runat="server" DefaultButton="Button16">
                                                            <asp:Button ID="Button16" runat="server" Text="Button" Style="display:none" OnClick="Button16_Click"  />
                                                        <asp:TextBox ID="TextBox152" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox152_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label156" runat="server" Text="Number of patients NOT on ART who were lost to follow up (LTFU) during the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox153" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label157" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox154" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label158" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label159" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label160" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label161" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label162" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label163" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label164" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label165" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox155" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox156" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox157" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox158" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox159" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox160" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox161" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel17" runat="server" DefaultButton="Button17">
                                                            <asp:Button ID="Button17" runat="server" Text="Button" Style="display:none" OnClick="Button17_Click"  />
                                                        <asp:TextBox ID="TextBox162" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox162_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label166" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox163" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label167" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label168" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label169" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label170" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label171" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label172" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label173" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label174" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox164" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox165" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox166" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox167" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox168" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox169" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox170" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel18" runat="server" DefaultButton="Button18">
                                                            <asp:Button ID="Button18" runat="server" Text="Button" Style="display:none" OnClick="Button18_Click"  />
                                                        <asp:TextBox ID="TextBox171" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox171_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label175" runat="server" Text="Number of patients who were NOT on ART that died in the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox172" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label176" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox173" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label177" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label178" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label179" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label180" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label181" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label182" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label183" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label184" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox174" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox175" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox176" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox177" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox178" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox179" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox180" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel19" runat="server" DefaultButton="Button19">
                                                            <asp:Button ID="Button19" runat="server" Text="Button" Style="display:none" OnClick="Button19_Click"  />
                                                        <asp:TextBox ID="TextBox181" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox181_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label185" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox182" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label186" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label187" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label188" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label189" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label190" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label191" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label192" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label193" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox183" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox184" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox185" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox186" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox187" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox188" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox189" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel20" runat="server" DefaultButton="Button20">
                                                            <asp:Button ID="Button20" runat="server" Text="Button" Style="display:none" OnClick="Button20_Click"  />
                                                        <asp:TextBox ID="TextBox190" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox190_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label194" runat="server" Text="Number of patients who were NOT on ART that transferred out the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox191" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label195" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox192" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label196" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label197" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label198" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label199" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label200" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label201" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label202" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label203" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox193" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox194" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox195" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox196" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox197" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox198" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox199" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel21" runat="server" DefaultButton="Button21">
                                                            <asp:Button ID="Button21" runat="server" Text="Button" Style="display:none" OnClick="Button21_Click"  />
                                                        <asp:TextBox ID="TextBox200" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox200_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label204" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox201" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label205" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label206" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label207" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label208" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label209" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label210" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label211" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label212" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox202" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox203" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox204" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox205" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox206" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox207" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox208" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel22" runat="server" DefaultButton="Button22">
                                                            <asp:Button ID="Button22" runat="server" Text="Button" Style="display:none" OnClick="Button22_Click"  />
                                                        <asp:TextBox ID="TextBox209" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox209_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label213" runat="server" Text="Number of patients who were NOT on ART that stopped treatment in the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox210" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label214" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox211" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label215" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label216" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label217" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label218" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label219" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label220" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label221" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label222" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox212" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox213" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox214" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox215" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox216" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox217" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox218" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel23" runat="server" DefaultButton="Button2">
                                                            <asp:Button ID="Button23" runat="server" Text="Button" Style="display:none" OnClick="Button23_Click"  />
                                                        <asp:TextBox ID="TextBox219" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox219_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label223" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox220" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label224" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label225" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label226" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label227" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label228" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label229" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label230" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label231" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox221" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox222" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox223" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox224" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox225" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox226" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox227" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel24" runat="server" DefaultButton="Button24">
                                                            <asp:Button ID="Button24" runat="server" Text="Button" Style="display:none" OnClick="Button24_Click"  />
                                                        <asp:TextBox ID="TextBox228" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox228_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label232" runat="server" Text="Number of HIV positive adults and children who received at least one of the following during the reporting period: clinical assessment (WHO staging) OR CD4 count OR viral load (preART and ART clients)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox229" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label233" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox230" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label234" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label235" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label236" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label237" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label238" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label239" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label240" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label241" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox231" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox232" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox233" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox234" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox235" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox236" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox237" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel25" runat="server" DefaultButton="Button25">
                                                            <asp:Button ID="Button25" runat="server" Text="Button" Style="display:none" OnClick="Button25_Click"  />
                                                        <asp:TextBox ID="TextBox238" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox238_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label242" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox239" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label243" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label244" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label245" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label246" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label247" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label248" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label249" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label250" runat="server" Text="Age (50&gt;)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox240" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox241" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox242" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox243" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox244" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox245" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox246" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel26" runat="server" DefaultButton="Button26">
                                                            <asp:Button ID="Button26" runat="server" Text="Button" Style="display:none" OnClick="Button26_Click"  />
                                                        <asp:TextBox ID="TextBox247" runat="server" AutoPostBack="False" OnTextChanged="TextBox247_TextChanged" Width="52px"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <asp:View ID="View2" runat="server">
                                <table class="style1" style="border-style: solid; border-width: thin">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label2" runat="server" Text="ART"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label251" runat="server" Text="Number of adults and children with HIV infection ever enrolled on ART
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox248" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label252" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox249" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table style="text-align: center" class="style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label254" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label255" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label256" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label257" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label258" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label259" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label260" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label261" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox250" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox251" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox252" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox253" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox254" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox255" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox256" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel27" runat="server" DefaultButton="Button27">
                                                            <asp:Button ID="Button27" runat="server" Text="Button" Style="display:none" OnClick="Button27_Click"  />
                                                        <asp:TextBox ID="TextBox257" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox257_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label253" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox258" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label262" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label263" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label264" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label265" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label266" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label267" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label268" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label269" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox259" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox260" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox261" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox262" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox263" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox264" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox265" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel28" runat="server" DefaultButton="Button28">
                                                            <asp:Button ID="Button28" runat="server" Text="Button" Style="display:none" OnClick="Button28_Click"  />
                                                        <asp:TextBox ID="TextBox266" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox266_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                          
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth ">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label1077" runat="server" Text="Preganat"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label1078" runat="server" Text="Breastfeeding"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox1074"  Width="52px" runat="server"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox1075" Width="52px" AutoPostBack="False"  runat="server" OnTextChanged="TextBox1075_TextChanged"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                              <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label270" runat="server" Text="Number of adults and children with HIV infection currently receiving antiretroviral therapy (ART)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox267" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label271" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox268" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label272" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label273" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label274" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label275" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label276" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label277" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label278" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label279" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox269" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox270" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox271" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox272" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox273" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox274" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox275" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel29" runat="server" DefaultButton="Button29">
                                                            <asp:Button ID="Button29" runat="server" Text="Button" Style="display:none" OnClick="Button29_Click"  />
                                                        <asp:TextBox ID="TextBox276" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox276_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label280" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox277" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label281" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label282" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label283" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label284" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label285" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label286" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label287" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label288" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox278" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox279" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox280" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox281" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox282" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox283" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox284" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel30" runat="server" DefaultButton="Button30">
                                                            <asp:Button ID="Button30" runat="server" Text="Button" Style="display:none" OnClick="Button30_Click"  />
                                                        <asp:TextBox ID="TextBox285" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox285_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                          
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth ">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label1075" runat="server" Text="Preganat"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label1076" runat="server" Text="Breastfeeding"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox1072"  Width="52px" runat="server"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                             <asp:Panel ID="Panel116" runat="server" DefaultButton="Button116">
                                                            <asp:Button ID="Button116" runat="server" Text="Button" Style="display:none" OnClick="Button116_Click"  />
                                                            <asp:TextBox ID="TextBox1073" Width="52px" AutoPostBack="False"  runat="server" OnTextChanged="TextBox1073_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                              <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label289" runat="server" Text="Number of adults and children with HIV infection newly enrolled on ART   
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox286" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label290" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox287" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label291" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label292" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label293" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label294" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label295" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label296" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label297" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label298" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox288" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox289" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox290" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox291" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox292" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox293" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox294" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel31" runat="server" DefaultButton="Button31">
                                                            <asp:Button ID="Button31" runat="server" Text="Button" Style="display:none" OnClick="Button31_Click"  />
                                                        <asp:TextBox ID="TextBox295" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox295_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label299" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox296" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label300" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label301" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label302" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label303" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label304" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label305" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label306" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label307" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox297" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox298" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox299" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox300" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox301" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox302" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox303" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel32" runat="server" DefaultButton="Button32">
                                                            <asp:Button ID="Button32" runat="server" Text="Button" Style="display:none" OnClick="Button32_Click"  />
                                                        <asp:TextBox ID="TextBox304" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox304_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>

                                            <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label308" runat="server" Text="Pregnant  women:"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label309" runat="server" Text="Breastfeeding women"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label310" runat="server" Text="FSW"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label311" runat="server" Text="MSM/TG"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label312" runat="server" Text="PWID"></asp:Label>
                                                           
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                             <asp:TextBox ID="TextBox305" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox306" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox307" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox308" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:Panel ID="Panel33" runat="server" DefaultButton="Button33">
                                                            <asp:Button ID="Button33" runat="server" Text="Button" Style="display:none" OnClick="Button33_Click"  />
                                                            <asp:TextBox ID="TextBox309" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox309_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label313" runat="server" Text="Number of patients on ART who were transferred in during the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox310" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label314" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox311" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label315" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label316" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label317" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label318" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label319" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label320" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label321" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label322" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox312" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox313" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox314" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox315" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox316" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox317" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox318" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel34" runat="server" DefaultButton="Button34">
                                                            <asp:Button ID="Button34" runat="server" Text="Button" Style="display:none" OnClick="Button34_Click"  />
                                                        <asp:TextBox ID="TextBox319" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox319_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label323" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox320" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label324" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label325" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label326" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label327" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label328" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label329" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label330" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label331" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox321" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox322" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox323" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox324" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox325" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox326" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox327" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel35" runat="server" DefaultButton="Button35">
                                                            <asp:Button ID="Button35" runat="server" Text="Button" Style="display:none" OnClick="Button35_Click"  />
                                                        <asp:TextBox ID="TextBox328" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox328_TextChanged"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label332" runat="server" Text="Number of patients on ART that returned to treatment during the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox329" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label333" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox330" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label334" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label335" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label336" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label337" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label338" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label339" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label340" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label341" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox331" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox332" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox333" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox334" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox335" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox336" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox337" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel36" runat="server" DefaultButton="Button36">
                                                            <asp:Button ID="Button36" runat="server" Text="Button" Style="display:none"  />
                                                        <asp:TextBox ID="TextBox338" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox338_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label342" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox339" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label343" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label344" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label345" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label346" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label347" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label348" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label349" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label350" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox340" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox341" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox342" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox343" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox344" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox345" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox346" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel37" runat="server" DefaultButton="Button37">
                                                            <asp:Button ID="Button37" runat="server" Text="Button" Style="display:none" OnClick="Button37_Click"  />
                                                        <asp:TextBox ID="TextBox347" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox347_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label351" runat="server" Text="Number of patients on ART who were lost to follow up (LTFU) during the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox348" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label352" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox349" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label353" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label354" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label355" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label356" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label357" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label358" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label359" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label360" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox350" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox351" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox352" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox353" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox354" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox355" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox356" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel38" runat="server" DefaultButton="Button38">
                                                            <asp:Button ID="Button38" runat="server" Text="Button" Style="display:none" OnClick="Button38_Click"  />
                                                        <asp:TextBox ID="TextBox357" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox357_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label361" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox358" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label362" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label363" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label364" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label365" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label366" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label367" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label368" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label369" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox359" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox360" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox361" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox362" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox363" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox364" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox365" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel39" runat="server" DefaultButton="Button39">
                                                            <asp:Button ID="Button39" runat="server" Text="Button" Style="display:none" OnClick="Button39_Click"  />
                                                        <asp:TextBox ID="TextBox366" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox366_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label370" runat="server" Text="Number of patients who were on ART that died in the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox367" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label371" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox368" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label372" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label373" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label374" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label375" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label376" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label377" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label378" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label379" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox369" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox370" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox371" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox372" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox373" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox374" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox375" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel40" runat="server" DefaultButton="Button40">
                                                            <asp:Button ID="Button40" runat="server" Text="Button" Style="display:none" OnClick="Button40_Click"  />
                                                        <asp:TextBox ID="TextBox376" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox376_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label380" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox377" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label381" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label382" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label383" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label384" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label385" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label386" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label387" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label388" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox378" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox379" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox380" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox381" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox382" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox383" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox384" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel41" runat="server" DefaultButton="Button41">
                                                            <asp:Button ID="Button41" runat="server" Text="Button" Style="display:none" OnClick="Button41_Click"  />
                                                        <asp:TextBox ID="TextBox385" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox385_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label389" runat="server" Text="Number of patients who were on ART that transferred out the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox386" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label390" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox387" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label391" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label392" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label393" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label394" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label395" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label396" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label397" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label398" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox388" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox389" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox390" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox391" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox392" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox393" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox394" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel42" runat="server" DefaultButton="Button42">
                                                            <asp:Button ID="Button42" runat="server" Text="Button" Style="display:none" OnClick="Button42_Click"  />
                                                        <asp:TextBox ID="TextBox395" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox395_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label399" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox396" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label400" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label401" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label402" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label403" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label404" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label405" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label406" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label407" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox397" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox398" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox399" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox400" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox401" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox402" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox403" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel43" runat="server" DefaultButton="Button43">
                                                            <asp:Button ID="Button43" runat="server" Text="Button" Style="display:none" OnClick="Button43_Click"  />
                                                        <asp:TextBox ID="TextBox404" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox404_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label408" runat="server" Text="Number of patients who were on ART that stopped treatment in the reporting month
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox405" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label409" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox406" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label410" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label411" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label412" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label413" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label414" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label415" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label416" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label417" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox407" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox408" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox409" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox410" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox411" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox412" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox413" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel44" runat="server" DefaultButton="Button44">
                                                            <asp:Button ID="Button44" runat="server" Text="Button" Style="display:none" OnClick="Button44_Click"  />
                                                        <asp:TextBox ID="TextBox414" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox414_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label418" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox415" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label419" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label420" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label421" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label422" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label423" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label424" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label425" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label426" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox416" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox417" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox418" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox419" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox420" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox421" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox422" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel45" runat="server" DefaultButton="Button45">
                                                            <asp:Button ID="Button45" runat="server" Text="Button" Style="display:none" OnClick="Button45_Click"  />
                                                        <asp:TextBox ID="TextBox423" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox423_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label427" runat="server" Text="Number of viral load tests performed for adults and children on ART within the past 12 months.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox424" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label428" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox425" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label429" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label430" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label431" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label432" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label433" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label434" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label435" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label436" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox426" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox427" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox428" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox429" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox430" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox431" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox432" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel46" runat="server" DefaultButton="Button46">
                                                            <asp:Button ID="Button46" runat="server" Text="Button" Style="display:none" OnClick="Button46_Click"  />
                                                        <asp:TextBox ID="TextBox433" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox433_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label437" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox434" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label438" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label439" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label440" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label441" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label442" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label443" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label444" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label445" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox435" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox436" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox437" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox438" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox439" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox440" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox441" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel47" runat="server" DefaultButton="Button47">
                                                            <asp:Button ID="Button47" runat="server" Text="Button" Style="display:none" OnClick="Button47_Click"  />
                                                        <asp:TextBox ID="TextBox442" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox442_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>

                                            <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label446" runat="server" Text="Pregnant  women:
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label447" runat="server" Text="Breastfeeding women
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label448" runat="server" Text="Routine monitoring
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label449" runat="server" Text="Targeted monitoring
"></asp:Label>
                                                        </td>
                                                        
                                                    </tr>
                                                    <tr>
                                                         <td>
                                                            <asp:TextBox ID="TextBox443" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox444" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox445" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                             <asp:Panel ID="Panel48" runat="server" DefaultButton="Button48">
                                                            <asp:Button ID="Button48" runat="server" Text="Button" Style="display:none" OnClick="Button48_Click"  />
                                                            <asp:TextBox ID="TextBox446" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox446_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                     
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label450" runat="server" Text="Number of viral load tests from adult and pediatric ART patients conducted in the past 12 months with a viral load <1,000 copies/ml
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox447" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label451" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox448" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label452" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label453" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label454" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label455" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label456" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label457" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label458" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label459" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox449" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox450" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox451" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox452" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox453" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox454" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox455" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel49" runat="server" DefaultButton="Button49">
                                                            <asp:Button ID="Button49" runat="server" Text="Button" Style="display:none" OnClick="Button49_Click"  />
                                                        <asp:TextBox ID="TextBox456" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox456_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label460" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox457" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label461" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label462" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label463" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label464" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label465" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label466" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label467" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label468" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox458" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox459" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox460" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox461" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox462" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox463" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox464" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel50" runat="server" DefaultButton="Button50">
                                                            <asp:Button ID="Button50" runat="server" Text="Button" Style="display:none" OnClick="Button50_Click"  />
                                                        <asp:TextBox ID="TextBox465" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox465_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label469" runat="server" Text="Pregnant  women:
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label470" runat="server" Text="Breastfeeding women
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label471" runat="server" Text="Routine monitoring
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label472" runat="server" Text="Targeted monitoring
"></asp:Label>
                                                        </td>
                                                        
                                                    </tr>
                                                    <tr>
                                                         <td>
                                                            <asp:TextBox ID="TextBox466" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox467" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox468" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                             <asp:Panel ID="Panel51" runat="server" DefaultButton="Button51">
                                                            <asp:Button ID="Button51" runat="server" Text="Button" Style="display:none" OnClick="Button51_Click"  />
                                                            <asp:TextBox ID="TextBox469" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox469_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                     
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label473" runat="server" Text="Number of adults and children who are still alive and on treatment at 12 months after initiating ART
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox470" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label474" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox471" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label475" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label476" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label477" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label478" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label479" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label480" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label481" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label482" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox472" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox473" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox474" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox475" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox476" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox477" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox478" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel52" runat="server" DefaultButton="Button52">
                                                            <asp:Button ID="Button52" runat="server" Text="Button" Style="display:none" OnClick="Button52_Click"  />
                                                        <asp:TextBox ID="TextBox479" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox479_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label483" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox480" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label484" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label485" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label486" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label487" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label488" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label489" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label490" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label491" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox481" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox482" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox483" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox484" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox485" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox486" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox487" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel53" runat="server" DefaultButton="Button53">
                                                            <asp:Button ID="Button53" runat="server" Text="Button" Style="display:none" OnClick="Button53_Click"  />
                                                        <asp:TextBox ID="TextBox488" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox488_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label492" runat="server" Text="Pregnant  women:
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label493" runat="server" Text="Breastfeeding women
"></asp:Label>
                                                        </td>
                                                       
                                                        
                                                    </tr>
                                                    <tr>
                                                         <td>
                                                            <asp:TextBox ID="TextBox489" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                             <asp:Panel ID="Panel54" runat="server" DefaultButton="Button54">
                                                            <asp:Button ID="Button54" runat="server" Text="Button" Style="display:none" OnClick="Button54_Click"  />
                                                            <asp:TextBox ID="TextBox490" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox490_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                       
                                                     
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label494" runat="server" Text="Total number of adults and children who initiated ART in the 12 months prior to the beginning of the reporting period, including those who have died, those who have stopped ART, and those lost to follow-up
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox491" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label495" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox492" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label496" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label497" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label498" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label499" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label500" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label501" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label502" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label503" runat="server" Text="Age (50&gt;)
" style="background-color: #FFFFFF"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox493" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox494" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox495" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox496" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox497" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox498" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox499" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel55" runat="server" DefaultButton="Button55">
                                                            <asp:Button ID="Button55" runat="server" Text="Button" Style="display:none" OnClick="Button55_Click"  />
                                                        <asp:TextBox ID="TextBox500" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox500_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label504" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox501" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label505" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label506" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label507" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label508" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label509" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label510" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label511" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label512" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox502" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox503" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox504" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox505" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox506" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox507" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox508" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel117" runat="server" DefaultButton="Button117">
                                                            <asp:Button ID="Button117" runat="server" Text="Button" Style="display:none" OnClick="Button117_Click"  />
                                                        <asp:TextBox ID="TextBox509" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox509_TextChanged" ></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label513" runat="server" Text="Pregnant  women:
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label514" runat="server" Text="Breastfeeding women
"></asp:Label>
                                                        </td>
                                                       
                                                        
                                                    </tr>
                                                    <tr>
                                                         <td>
                                                            <asp:TextBox ID="TextBox510" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                             <asp:Panel ID="Panel56" runat="server" DefaultButton="Button56">
                                                            <asp:Button ID="Button56" runat="server" Text="Button" Style="display:none" OnClick="Button56_Click"  />
                                                            <asp:TextBox ID="TextBox511" runat="server" Width="52px" OnTextChanged="TextBox511_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                       
                                                     
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label515" runat="server" Text="Number of adult and pediatric ART patients with a viral load result documented in the patient medical record within the past 12 months.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox512" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label516" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox513" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label517" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label518" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label519" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label520" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label521" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label522" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label523" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label524" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox514" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox515" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox516" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox517" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox518" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox519" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox520" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel57" runat="server" DefaultButton="Button57">
                                                            <asp:Button ID="Button57" runat="server" Text="Button" Style="display:none" OnClick="Button57_Click"  />
                                                        <asp:TextBox ID="TextBox521" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox521_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label525" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox522" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label526" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label527" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label528" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label529" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label530" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label531" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label532" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label533" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox523" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox524" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox525" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox526" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox527" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox528" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox529" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel58" runat="server" DefaultButton="Button58">
                                                            <asp:Button ID="Button58" runat="server" Text="Button" Style="display:none" OnClick="Button58_Click"  />
                                                        <asp:TextBox ID="TextBox530" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox530_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label534" runat="server" Text="Undetectable"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label535" runat="server" Text="Detectable"></asp:Label>
                                                        </td>
                                                       
                                                        
                                                    </tr>
                                                    <tr>
                                                         <td>
                                                            <asp:TextBox ID="TextBox531" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox532" runat="server" Width="52px" OnTextChanged="TextBox532_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                        </td>
                                                       
                                                     
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                                <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label536" runat="server" Text="Number of adults and children on ART at least 6 months whose medical records were reviewed.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox533" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                                <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label537" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox534" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label538" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label539" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label540" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label541" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label542" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label543" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label544" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label545" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox535" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox536" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox537" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox538" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox539" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox540" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox541" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel59" runat="server" DefaultButton="Button59">
                                                            <asp:Button ID="Button59" runat="server" Text="Button" Style="display:none" OnClick="Button59_Click"  />
                                                        <asp:TextBox ID="TextBox542" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox542_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label546" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox543" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label547" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label548" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label549" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label550" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label551" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label552" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label553" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label554" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox544" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox545" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox546" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox547" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox548" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox549" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox550" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel60" runat="server" DefaultButton="Button60">
                                                            <asp:Button ID="Button60" runat="server" Text="Button" Style="display:none" OnClick="Button60_Click"  />
                                                        <asp:TextBox ID="TextBox551" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox551_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                               <div class="clearboth ">
                                                <table style="width: 429px; text-align: center;">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label555" runat="server" Text="Undetectable"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label556" runat="server" Text="Detectable"></asp:Label>
                                                        </td>
                                                       
                                                        
                                                    </tr>
                                                    <tr>
                                                         <td>
                                                            <asp:TextBox ID="TextBox552" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox553" runat="server" Width="52px" OnTextChanged="TextBox553_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                        </td>
                                                       
                                                     
                                                    </tr>
                                                </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label557" runat="server" Text="Number of adults and children on currently on 1st line regimen
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox554" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label558" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox555" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label559" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label560" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label561" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label562" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label563" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label564" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label565" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label566" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox556" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox557" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox558" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox559" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox560" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox561" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox562" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel61" runat="server" DefaultButton="Button61">
                                                            <asp:Button ID="Button61" runat="server" Text="Button" Style="display:none" OnClick="Button61_Click"  />
                                                        <asp:TextBox ID="TextBox563" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox563_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label567" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox564" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label568" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label569" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label570" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label571" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label572" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label573" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label574" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label575" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox565" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox566" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox567" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox568" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox569" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox570" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox571" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel62" runat="server" DefaultButton="Button62">
                                                            <asp:Button ID="Button62" runat="server" Text="Button" Style="display:none" OnClick="Button62_Click"  />
                                                        <asp:TextBox ID="TextBox572" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox572_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label576" runat="server" Text="Number of adults and children currently on 2nd line regimen
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox573" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label577" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox574" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label578" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label579" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label580" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label581" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label582" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label583" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label584" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label585" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox575" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox576" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox577" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox578" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox579" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox580" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox581" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel63" runat="server" DefaultButton="Button63">
                                                            <asp:Button ID="Button63" runat="server" Text="Button" Style="display:none" OnClick="Button63_Click"  />
                                                        <asp:TextBox ID="TextBox582" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox582_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label586" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox583" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label587" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label588" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label589" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label590" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label591" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label592" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label593" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label594" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox584" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox585" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox586" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox587" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox588" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox589" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox590" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel64" runat="server" DefaultButton="Button64">
                                                            <asp:Button ID="Button64" runat="server" Text="Button" Style="display:none" OnClick="Button64_Click"  />
                                                        <asp:TextBox ID="TextBox591" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox591_TextChanged" ></asp:TextBox>
                                                            </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label595" runat="server" Text="Number of adults and children currently on salvage
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox592" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label596" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox593" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label597" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label598" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label599" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label600" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label601" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label602" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label603" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label604" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox594" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox595" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox596" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox597" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox598" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox599" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox600" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel65" runat="server" DefaultButton="Button65">
                                                            <asp:Button ID="Button65" runat="server" Text="Button" Style="display:none" OnClick="Button65_Click"  />
                                                        <asp:TextBox ID="TextBox601" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox601_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label605" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox602" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                     <td>
                                                        <asp:Label ID="Label606" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label607" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label608" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label609" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label610" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                           <asp:Label ID="Label611" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label612" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label613" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox603" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox604" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox605" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox606" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox607" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox608" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox609" Width="52px" runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel66" runat="server" DefaultButton="Button66">
                                                            <asp:Button ID="Button66" runat="server" Text="Button" Style="display:none" OnClick="Button66_Click"  />
                                                        <asp:TextBox ID="TextBox610" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox610_TextChanged" ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                        </td>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <asp:View ID="View3" runat="server">
                                <table class="style1" style="border: thin solid #000000">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label3" runat="server" Text="HTC"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label614" runat="server" Text="Number of clients pretest counselled for HIV
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox611" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label615" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox612" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label616" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label617" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label618" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label619" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label620" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label621" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label622" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label623" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox613" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox614" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox615" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox616" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox617" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox618" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox619" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel67" runat="server" DefaultButton="Button67">
                                                            <asp:Button ID="Button67" runat="server" Text="Button" Style="display:none" OnClick="Button67_Click"  />
                                                        <asp:TextBox ID="TextBox620" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox620_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label624" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox621" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label625" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label626" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label627" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label628" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label629" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label630" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label631" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label632" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox622" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox623" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox624" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox625" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox626" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox627" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox628" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel68" runat="server" DefaultButton="Button68">
                                                            <asp:Button ID="Button68" runat="server" Text="Button" Style="display:none" OnClick="Button68_Click"  />
                                                        <asp:TextBox ID="TextBox629" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox629_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label633" runat="server" Text="Number of clients pretest counselled and tested for HIV
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox630" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label634" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox631" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label635" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label636" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label637" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label638" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label639" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label640" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label641" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label642" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox632" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox633" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox634" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox635" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox636" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox637" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox638" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel69" runat="server" DefaultButton="Button69">
                                                            <asp:Button ID="Button69" runat="server" Text="Button" Style="display:none" OnClick="Button69_Click"  />
                                                        <asp:TextBox ID="TextBox639" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox639_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label643" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox640" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label644" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label645" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label646" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label647" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label648" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label649" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label650" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label651" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox641" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox642" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox643" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox644" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox645" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox646" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox647" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                     <asp:Panel ID="Panel70" runat="server" DefaultButton="Button70">
                                                            <asp:Button ID="Button70" runat="server" Text="Button" Style="display:none" OnClick="Button70_Click"  />
                                                        <asp:TextBox ID="TextBox648" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox648_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label652" runat="server" Text="Number of individuals who received counseling and testing services for HIV and received their test results disagregated by Sex/Age 
" style="background-color: #FFFF66"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox649" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label653" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox650" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label654" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label655" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label656" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label657" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label658" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label659" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label660" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label661" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox651" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox652" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox653" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox654" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox655" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox656" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox657" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                     <asp:Panel ID="Panel71" runat="server" DefaultButton="Button71">
                                                            <asp:Button ID="Button71" runat="server" Text="Button" Style="display:none" OnClick="Button71_Click"  />
                                                        <asp:TextBox ID="TextBox658" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label662" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox659" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label663" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label664" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label665" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label666" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label667" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label668" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label669" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label670" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox660" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox661" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox662" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox663" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox664" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox665" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox666" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel72" runat="server" DefaultButton="Button72">
                                                            <asp:Button ID="Button72" runat="server" Text="Button" Style="display:none" OnClick="Button72_Click"  />
                                                        <asp:TextBox ID="TextBox667" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label671" runat="server" Text="Number of individuals who received counseling and testing services for HIV and received their test results disagregated by Test Results 
" style="background-color: #FFCC66"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox668" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label672" runat="server" Text="Positives
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox669" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label673" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label674" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label675" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label676" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label677" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label678" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label679" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label680" runat="server" Text="Age (50&gt;)
" style="background-color: #FFFFFF"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox670" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox671" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox672" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox673" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox674" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox675" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox676" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel73" runat="server" DefaultButton="Button73">
                                                            <asp:Button ID="Button73" runat="server" Text="Button" Style="display:none" OnClick="Button73_Click"  />
                                                        <asp:TextBox ID="TextBox677" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label681" runat="server" Text="Negatives
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox678" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label682" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label683" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label684" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label685" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label686" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label687" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label688" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label689" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox679" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox680" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox681" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox682" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox683" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox684" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox685" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel74" runat="server" DefaultButton="Button74">
                                                            <asp:Button ID="Button74" runat="server" Text="Button" Style="display:none" OnClick="Button74_Click"  />
                                                        <asp:TextBox ID="TextBox686" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label690" runat="server" Text="Number of individuals who tested positive disagregated by Sex/Age 
" style="background-color: #FFCC66"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox687" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label691" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox688" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label692" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label693" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label694" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label695" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label696" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label697" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label698" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label699" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox689" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox690" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox691" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox692" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox693" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox694" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox695" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                     <asp:Panel ID="Panel75" runat="server" DefaultButton="Button75">
                                                            <asp:Button ID="Button75" runat="server" Text="Button" Style="display:none" OnClick="Button75_Click"  />
                                                        <asp:TextBox ID="TextBox696" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label700" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox697" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label701" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label702" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label703" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label704" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label705" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label706" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label707" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label708" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox698" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox699" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox700" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox701" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox702" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox703" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox704" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel76" runat="server" DefaultButton="Button76">
                                                            <asp:Button ID="Button76" runat="server" Text="Button" Style="display:none" OnClick="Button76_Click"  />
                                                        <asp:TextBox ID="TextBox705" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label709" runat="server" Text="Number of individuals who tested Negative disagregated by Sex/Age 
" style="background-color: #FF0000"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox706" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                               <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label710" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox707" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label711" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label712" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label713" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label714" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label715" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label716" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label717" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label718" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox708" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox709" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox710" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox711" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox712" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox713" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox714" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel77" runat="server" DefaultButton="Button77">
                                                            <asp:Button ID="Button77" runat="server" Text="Button" Style="display:none" OnClick="Button77_Click"  />
                                                        <asp:TextBox ID="TextBox715" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label719" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox716" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label720" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label721" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label722" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label723" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label724" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label725" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label726" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label727" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox717" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox718" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox719" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox720" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox721" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox722" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox723" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel78" runat="server" DefaultButton="Button78">
                                                            <asp:Button ID="Button78" runat="server" Text="Button" Style="display:none" OnClick="Button78_Click"  />
                                                        <asp:TextBox ID="TextBox724" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label728" runat="server" Text="Number of individuals who where previously tested during the reporting period (subset of total tested and received result)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox725" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label729" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox726" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label730" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label731" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label732" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label733" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label734" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label735" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label736" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label737" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox727" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox728" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox729" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox730" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox731" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox732" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox733" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel79" runat="server" DefaultButton="Button79">
                                                            <asp:Button ID="Button79" runat="server" Text="Button" Style="display:none" OnClick="Button79_Click"  />
                                                        <asp:TextBox ID="TextBox734" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label738" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox735" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label739" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label740" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label741" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label742" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label743" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label744" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label745" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label746" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox736" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox737" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox738" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox739" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox740" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox741" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox742" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel80" runat="server" DefaultButton="Button80">
                                                            <asp:Button ID="Button80" runat="server" Text="Button" Style="display:none" OnClick="Button80_Click"  />
                                                        <asp:TextBox ID="TextBox743" runat="server" AutoPostBack="False"  Width="52px"  ></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <%--<tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label747" runat="server" Text="Number of individuals who tested Negative disagregated by Sex/Age 
" CssClass="auto-style43"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox744" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label748" runat="server" Text="Male" CssClass="auto-style43"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox745" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>  <table class="style1" style="text-align: center">
                                                <tr class="auto-style43">
                                                    <td>
                                                        <asp:Label ID="Label749" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label750" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label751" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label752" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label753" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label754" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label755" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label756" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox746" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox747" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox748" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox749" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox750" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox751" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox752" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox753" runat="server" AutoPostBack="False"  Width="52px" CssClass="auto-style43" OnTextChanged="TextBox753_TextChanged"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label757" runat="server" Text="Female" CssClass="auto-style43"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox754" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr class="auto-style43">
                                                    <td>
                                                        <asp:Label ID="Label758" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label759" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label760" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label761" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label762" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label763" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label764" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label765" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox755" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox756" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox757" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox758" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox759" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox760" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox761" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox762" runat="server" AutoPostBack="False"  Width="52px" CssClass="auto-style43" OnTextChanged="TextBox762_TextChanged"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>--%>
                                  <%--  <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label766" runat="server" Text="Number of individuals who where previously tested during the reporting period (subset of total tested and received result)
" CssClass="auto-style43"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox763" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label767" runat="server" Text="Male" CssClass="auto-style43"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox764" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr class="auto-style43">
                                                    <td>
                                                        <asp:Label ID="Label768" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label769" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label770" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label771" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label772" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label773" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label774" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label775" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox765" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox766" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox767" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox768" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox769" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox770" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox771" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox772" runat="server" AutoPostBack="False"  Width="52px" CssClass="auto-style43" OnTextChanged="TextBox772_TextChanged"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label776" runat="server" Text="Female" CssClass="auto-style43"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox773" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>--%>
                                   <%-- <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr class="auto-style43">
                                                    <td>
                                                        <asp:Label ID="Label777" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label778" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label779" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label780" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label781" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label782" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label783" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label784" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox774" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox775" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox776" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox777" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox778" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox779" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox780" runat="server" Width="52px" CssClass="auto-style43"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox781" runat="server" AutoPostBack="False"  Width="52px" CssClass="auto-style43" OnTextChanged="TextBox781_TextChanged"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label785" runat="server" Text="Number of individuals who received counseling and testing services for HIV and received their test results disagregated by Key Population type (subset of total tested and received result)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox782" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label786" runat="server" Text="FSW total:"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox783" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            
                                            <table class="style1">
                                                <tr>
                                                   <td>
                                                       <asp:Label ID="Label787" runat="server" Text="Age (10-14)"></asp:Label>
                                                   </td>
                                                    <td>
                                                         <asp:Label ID="Label788" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label789" runat="server" Text="Age (20-24)"></asp:Label>
                                                    </td>
                                                     <td>
                                                          <asp:Label ID="Label790" runat="server" Text="Age (25-49)"></asp:Label>
                                                   </td>
                                                    <td>
                                                         <asp:Label ID="Label791" runat="server" Text="Age (50>)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                   <td>
                                                       <asp:TextBox ID="TextBox784" Width="52px"  runat="server"></asp:TextBox>
                                                   </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox785" Width="52px"  runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox786" Width="52px"  runat="server"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                         <asp:TextBox ID="TextBox787" Width="52px"  runat="server"></asp:TextBox>
                                                   </td>
                                                    <td>
                                                         <asp:Panel ID="Panel81" runat="server" DefaultButton="Button81">
                                                            <asp:Button ID="Button81" runat="server" Text="Button" Style="display:none" OnClick="Button81_Click"  />
                                                        <asp:TextBox ID="TextBox788" AutoPostBack="False" Width="52px"  runat="server" OnTextChanged="TextBox788_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                         
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label792" runat="server" Text="FSW Positives (subset of total)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox789" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                         </td>
                                    </tr>
                                    <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                   <td>
                                                       <asp:Label ID="Label793" runat="server" Text="Age (10-14)"></asp:Label>
                                                   </td>
                                                    <td>
                                                         <asp:Label ID="Label794" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:Label ID="Label795" runat="server" Text="Age (20-24)"></asp:Label>
                                                    </td>
                                                     <td>
                                                          <asp:Label ID="Label796" runat="server" Text="Age (25-49)"></asp:Label>
                                                   </td>
                                                    <td>
                                                         <asp:Label ID="Label797" runat="server" Text="Age (50>)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                   <td>
                                                       <asp:TextBox ID="TextBox790" Width="52px"  runat="server"></asp:TextBox>
                                                   </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox791" Width="52px"  runat="server"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox792" Width="52px"  runat="server"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                         <asp:TextBox ID="TextBox793" Width="52px"  runat="server"></asp:TextBox>
                                                   </td>
                                                    <td>
                                                         <asp:Panel ID="Panel82" runat="server" DefaultButton="Button82">
                                                            <asp:Button ID="Button82" runat="server" Text="Button" Style="display:none" OnClick="Button82_Click"  />
                                                        <asp:TextBox ID="TextBox794" AutoPostBack="False" Width="52px"  runat="server" OnTextChanged="TextBox794_TextChanged"></asp:TextBox>
                                                    </asp:Panel>

                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="background-color: #DEBE9E">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label798" runat="server" 
                                                            Text="Number of individuals who received counseling and testing services for HIV and received their test results (PMTCT, HTC, TBHIV)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox795" runat="server" BackColor="#CCCCCC" ReadOnly="True" 
                                                            Width="52px" CssClass="style2"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label799" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox796" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label800" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label801" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label802" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label803" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label804" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label805" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label806" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label807" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox797" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox798" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox799" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox800" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox801" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox802" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox803" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel83" runat="server" DefaultButton="Button83">
                                                            <asp:Button ID="Button83" runat="server" Text="Button" Style="display:none" OnClick="Button83_Click"  />
                                                        <asp:TextBox ID="TextBox804" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox804_TextChanged" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label808" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox805" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label809" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label810" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label811" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label812" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label813" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label814" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label815" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label816" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox806" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox807" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox808" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox809" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox810" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox811" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox812" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel84" runat="server" DefaultButton="Button84">
                                                            <asp:Button ID="Button84" runat="server" Text="Button" Style="display:none" OnClick="Button84_Click"  />
                                                        <asp:TextBox ID="TextBox813" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox813_TextChanged" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="background-color: #DEBE9E">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label817" runat="server" Text="Number of individuals who received counseling and testing services for HIV and received their test results (PMTCT, HTC, TBHIV) disggregated by by test results
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox814" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label818" runat="server" Text="Positive"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox815" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label819" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label820" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label821" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label822" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label823" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label824" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label825" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label826" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox816" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox817" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox818" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox819" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox820" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox821" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox822" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel85" runat="server" DefaultButton="Button85">
                                                            <asp:Button ID="Button85" runat="server" Text="Button" Style="display:none" OnClick="Button85_Click"  />
                                                        <asp:TextBox ID="TextBox823" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox823_TextChanged" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label827" runat="server" Text="Nagetive"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox824" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label828" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label829" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label830" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label831" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label832" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label833" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label834" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label835" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox825" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox826" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox827" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox828" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox829" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox830" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox831" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel86" runat="server" DefaultButton="Button86">
                                                            <asp:Button ID="Button86" runat="server" Text="Button" Style="display:none" OnClick="Button86_Click"  />
                                                        <asp:TextBox ID="TextBox832" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox832_TextChanged" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                             <table class="style1" style="background-color: #DEBE9E">
                                                <tr style="background-color: #FFCC66">
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label836" runat="server" Text="Number of individuals who tested positive for HIV (PMTCT, HTC, TBHIV) disaggregated by age/sex
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox833" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label837" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox834" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label838" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label839" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label840" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label841" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label842" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label843" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label844" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label845" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox835" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox836" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox837" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox838" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox839" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox840" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox841" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True" Height="22px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel87" runat="server" DefaultButton="Button87">
                                                            <asp:Button ID="Button87" runat="server" Text="Button" Style="display:none" OnClick="Button87_Click"  />
                                                        <asp:TextBox ID="TextBox842" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox842_TextChanged" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label846" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox843" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label847" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label848" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label849" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label850" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label851" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label852" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label853" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label854" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox844" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox845" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox846" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox847" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox848" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox849" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox850" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel88" runat="server" DefaultButton="Button88">
                                                            <asp:Button ID="Button88" runat="server" Text="Button" Style="display:none" OnClick="Button88_Click"  />
                                                        <asp:TextBox ID="TextBox851" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox851_TextChanged" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="background-color: #DEBE9E; height: 26px;">
                                                <tr style="background-color: #FF0000">
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label855" runat="server" Text="Number of individuals who tested Negative for HIV (PMTCT, HTC, TBHIV) disaggregated by age/sex
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox852" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label856" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox853" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label857" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label858" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label859" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label860" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label861" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label862" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label863" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label864" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox854" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox855" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox856" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox857" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox858" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox859" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox860" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel89" runat="server" DefaultButton="Button89">
                                                            <asp:Button ID="Button89" runat="server" Text="Button" Style="display:none" OnClick="Button89_Click"  />
                                                        <asp:TextBox ID="TextBox861" runat="server" AutoPostBack="False"  Width="52px"  BackColor="#F3F3F3" ReadOnly="True" OnTextChanged="TextBox861_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label865" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox862" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label866" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label867" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label868" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label869" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label870" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label871" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label872" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label873" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox863" runat="server" Width="52px"  BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox864" runat="server" Width="52px"  BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox865" runat="server" Width="52px"  BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox866" runat="server" Width="52px" BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox867" runat="server" Width="52px"  BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox868" runat="server" Width="52px"  BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox869" runat="server" Width="52px"  BackColor="#F3F3F3" ReadOnly="True"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel90" runat="server" DefaultButton="Button90">
                                                            <asp:Button ID="Button90" runat="server" Text="Button" Style="display:none" OnClick="Button90_Click"  />
                                                        <asp:TextBox ID="TextBox870" runat="server" AutoPostBack="False"  BackColor="#F3F3F3" ReadOnly="True" Width="52px" OnTextChanged="TextBox870_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label874" runat="server" Text="Number of clients tested HIV positive and successfully enrolled in care
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox871" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label875" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox872" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label876" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label877" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label878" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label879" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label880" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label881" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label882" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label883" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox873" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox874" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox875" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox876" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox877" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox878" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox879" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel91" runat="server" DefaultButton="Button91">
                                                            <asp:Button ID="Button91" runat="server" Text="Button" Style="display:none" OnClick="Button91_Click"  />
                                                        <asp:TextBox ID="TextBox880" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox880_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label884" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox881" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                               <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label885" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label886" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label887" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label888" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label889" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label890" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label891" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label892" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox882" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox883" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox884" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox885" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox886" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox887" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox888" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel92" runat="server" DefaultButton="Button92">
                                                            <asp:Button ID="Button92" runat="server" Text="Button" Style="display:none" OnClick="Button92_Click"  />
                                                        <asp:TextBox ID="TextBox889" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox889_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label893" runat="server" Text="Number of clients who were not tested due to stockout of test kits during the reporting period
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox890" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label894" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox891" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label895" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label896" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label897" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label898" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label899" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label900" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label901" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label902" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox892" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox893" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox894" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox895" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox896" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox897" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox898" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel93" runat="server" DefaultButton="Button93">
                                                            <asp:Button ID="Button93" runat="server" Text="Button" Style="display:none" OnClick="Button93_Click"  />
                                                        <asp:TextBox ID="TextBox899" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox899_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label903" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox900" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label904" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label905" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label906" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label907" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label908" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label909" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label910" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label911" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox901" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox902" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox903" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox904" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox905" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox906" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox907" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel94" runat="server" DefaultButton="Button94">
                                                            <asp:Button ID="Button94" runat="server" Text="Button" Style="display:none" OnClick="Button94_Click"  />
                                                        <asp:TextBox ID="TextBox908" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox908_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label912" runat="server" Text="Number Of STI clients tested HIV negative (score 0 or >=1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox909" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td> <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label913" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox910" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label914" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label915" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label916" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label917" runat="server" Text="50+"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox911" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox912" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox913" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:Panel ID="Panel95" runat="server" DefaultButton="Button95">
                                                            <asp:Button ID="Button95" runat="server" Text="Button" Style="display:none" OnClick="Button95_Click"  />
                                                          <asp:TextBox ID="TextBox914" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox914_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label918" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox915" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label919" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label920" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label921" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label922" runat="server" Text="50+"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox916" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox917" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox918" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:Panel ID="Panel96" runat="server" DefaultButton="Button96">
                                                            <asp:Button ID="Button96" runat="server" Text="Button" Style="display:none" OnClick="Button96_Click"  />
                                                          <asp:TextBox ID="TextBox919" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox919_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label923" runat="server" Text="Number of STI clients tested HIV positive (Score 0 or >=1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox920" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label924" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox921" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label925" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label926" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label927" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label928" runat="server" Text="50+"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox922" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox923" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox924" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:Panel ID="Panel97" runat="server" DefaultButton="Button97">
                                                            <asp:Button ID="Button97" runat="server" Text="Button" Style="display:none" OnClick="Button97_Click"  />
                                                          <asp:TextBox ID="TextBox925" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox925_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label929" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox926" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label930" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label931" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label932" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                     <td>
                                                         <asp:Label ID="Label933" runat="server" Text="50+"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox927" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox928" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:TextBox ID="TextBox929" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                     <td>
                                                          <asp:Panel ID="Panel98" runat="server" DefaultButton="Button98">
                                                            <asp:Button ID="Button98" runat="server" Text="Button" Style="display:none" OnClick="Button98_Click"  />
                                                          <asp:TextBox ID="TextBox930" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox930_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                       <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label934" runat="server" Text="Number of TB patients tested HIV negative
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox931" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label935" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox932" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label936" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label937" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label938" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label939" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label940" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label941" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label942" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label943" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox933" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox934" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox935" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox936" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox937" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox938" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox939" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel99" runat="server" DefaultButton="Button99">
                                                            <asp:Button ID="Button99" runat="server" Text="Button" Style="display:none" OnClick="Button99_Click"  />
                                                        <asp:TextBox ID="TextBox940" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox940_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                         </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label944" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox941" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                         </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label945" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label946" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label947" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label948" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label949" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label950" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label951" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label952" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox942" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox943" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox944" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox945" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox946" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox947" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox948" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel100" runat="server" DefaultButton="Button100">
                                                            <asp:Button ID="Button100" runat="server" Text="Button" Style="display:none" OnClick="Button100_Click"  />
                                                        <asp:TextBox ID="TextBox949" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox949_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                         </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label953" runat="server" Text="Number of TB patients tested HIV positive
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox950" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label954" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox951" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label955" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label956" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label957" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label958" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label959" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label960" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label961" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label962" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox952" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox953" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox954" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox955" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox956" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox957" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox958" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel101" runat="server" DefaultButton="Button101">
                                                            <asp:Button ID="Button101" runat="server" Text="Button" Style="display:none" OnClick="Button101_Click"  />
                                                        <asp:TextBox ID="TextBox959" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox959_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                         </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label963" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox960" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                         </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label964" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label965" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label966" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label967" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label968" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label969" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label970" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label971" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox961" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox962" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox963" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox964" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox965" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox966" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox967" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel102" runat="server" DefaultButton="Button102">
                                                            <asp:Button ID="Button102" runat="server" Text="Button" Style="display:none" OnClick="Button102_Click"  />
                                                        <asp:TextBox ID="TextBox968" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox968_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                         </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label972" runat="server" Text="Number of HIV neg. clients clinically screened for TB score 0
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox969" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label973" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox970" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label974" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label975" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label976" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label977" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label978" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label979" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label980" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label981" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox971" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox972" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox973" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox974" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox975" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox976" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox977" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel103" runat="server" DefaultButton="Button103">
                                                            <asp:Button ID="Button103" runat="server" Text="Button" Style="display:none" OnClick="Button103_Click"  />
                                                        <asp:TextBox ID="TextBox978" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox978_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label982" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox979" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label983" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label984" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label985" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label986" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label987" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label988" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label989" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label990" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox980" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox981" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox982" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox983" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox984" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox985" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox986" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                         <asp:Panel ID="Panel104" runat="server" DefaultButton="Button104">
                                                            <asp:Button ID="Button104" runat="server" Text="Button" Style="display:none" OnClick="Button104_Click"  />
                                                        <asp:TextBox ID="TextBox987" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox987_TextChanged"></asp:TextBox>-
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                       <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label991" runat="server" Text="Number of HIV Positive clients clinically screened for TB score 0
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox988" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label992" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox989" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label993" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label994" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label995" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label996" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label997" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label998" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label999" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1000" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox990" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox991" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox992" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox993" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox994" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox995" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox996" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel105" runat="server" DefaultButton="Button105">
                                                            <asp:Button ID="Button105" runat="server" Text="Button" Style="display:none" OnClick="Button105_Click"  />
                                                        <asp:TextBox ID="TextBox997" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox997_TextChanged"></asp:TextBox>
                                                            </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1001" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox998" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1002" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1003" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1004" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1005" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1006" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1007" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1008" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1009" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox999" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1000" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1001" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1002" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1003" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1004" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1005" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel106" runat="server" DefaultButton="Button106">
                                                            <asp:Button ID="Button106" runat="server" Text="Button" Style="display:none" OnClick="Button106_Click"  />
                                                        <asp:TextBox ID="TextBox1006" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1006_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1010" runat="server" Text="Number of HIV neg. clients clinically screened for TB score 1+
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1007" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1011" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1008" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1012" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1013" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1014" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1015" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1016" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1017" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1018" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1019" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1009" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1010" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1011" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1012" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1013" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1014" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1015" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel107" runat="server" DefaultButton="Button107">
                                                            <asp:Button ID="Button107" runat="server" Text="Button" Style="display:none" OnClick="Button107_Click"  />
                                                        <asp:TextBox ID="TextBox1016" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox1016_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1020" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1017" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1021" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1022" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1023" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1024" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1025" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1026" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1027" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1028" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1018" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1019" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1020" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1021" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1022" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1023" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1024" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel108" runat="server" DefaultButton="Button108">
                                                            <asp:Button ID="Button108" runat="server" Text="Button" Style="display:none" OnClick="Button108_Click"  />
                                                        <asp:TextBox ID="TextBox1025" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1025_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1029" runat="server" Text="Number of HIV pos. clients clinically screened for TB score 1+
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1026" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1030" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1027" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1031" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1032" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1033" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1034" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1035" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1036" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1037" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1038" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1028" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1029" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1030" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1031" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1032" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1033" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1034" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel109" runat="server" DefaultButton="Button109">
                                                            <asp:Button ID="Button109" runat="server" Text="Button" Style="display:none" OnClick="Button109_Click"  />
                                                        <asp:TextBox ID="TextBox1035" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1035_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1039" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1036" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1040" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1041" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1042" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1043" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1044" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1045" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1046" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1047" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1037" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1038" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1039" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1040" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1041" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1042" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1043" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel110" runat="server" DefaultButton="Button110">
                                                            <asp:Button ID="Button110" runat="server" Text="Button" Style="display:none" OnClick="Button110_Click"  />
                                                        <asp:TextBox ID="TextBox1044" runat="server" AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1044_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            <hr />
                                        </td>
                                    </tr>
                                       <tr>
                                        <td>
                                              <table class="style1">
                                                <tr >
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1048" runat="server" Text="Number of couples counselled, tested and received result (subset)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1045" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1049" runat="server" Text="Number of couples with discordant HIV test results (subset)
"></asp:Label>
                                                    </td>
                                                    <td >
                                                        <asp:Panel ID="Panel118" runat="server" DefaultButton="Button118">
                                                            <asp:Button ID="Button118" runat="server" Text="Button" style="display:none" OnClick="Button118_Click"/>
                                                        <asp:TextBox ID="TextBox1046" runat="server"  Width="52px" OnTextChanged="TextBox1046_TextChanged"></asp:TextBox>
                                                       </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <hr />
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1050" runat="server" Text="Number of clients reached with Condom"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1047" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1051" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1048" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <div class="clearboth">
                                            <table>
                                                <tr>
                                                    <td>
                                                          <asp:Label ID="Label1052" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1053" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1054" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1055" runat="server" Text="50>"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1049" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1050" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1051" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel111" runat="server" DefaultButton="Button111">
                                                            <asp:Button ID="Button111" runat="server" Text="Button" Style="display:none" OnClick="Button111_Click"  />
                                                           <asp:TextBox ID="TextBox1052" runat="server"  AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1052_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            </div>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1056" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1053" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <div class="clearboth">
                                            <table>
                                                <tr>
                                                    <td>
                                                          <asp:Label ID="Label1057" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1058" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1059" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1060" runat="server" Text="50>"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1054" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1055" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1056" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel112" runat="server" DefaultButton="Button112">
                                                            <asp:Button ID="Button112" runat="server" Text="Button" Style="display:none" OnClick="Button112_Click"  />
                                                           <asp:TextBox ID="TextBox1057" runat="server"  AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1057_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            </div>
                                            <hr />
                                        </td>
                                    </tr>
                                     <tr>
                                        <td> <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1061" runat="server" Text="Number of Condoms given"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1058" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>

                                        </td>
                                    </tr>
                                     <tr>
                                        <td> <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1062" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1059" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            </td>
                                    </tr>
                                     <tr>
                                        <td>
                                              <div class="clearboth">
                                            <table>
                                                <tr>
                                                    <td>
                                                          <asp:Label ID="Label1063" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1064" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1065" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1066" runat="server" Text="50>"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1060" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1061" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1062" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel113" runat="server" DefaultButton="Button113">
                                                            <asp:Button ID="Button113" runat="server" Text="Button" Style="display:none" OnClick="Button113_Click"  />
                                                           <asp:TextBox ID="TextBox1063" runat="server"  AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1063_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            </div>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1067" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1064" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                             <div class="clearboth">
                                            <table>
                                                <tr>
                                                    <td>
                                                          <asp:Label ID="Label1068" runat="server" Text="15-19"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1069" runat="server" Text="20-24"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1070" runat="server" Text="25-49"></asp:Label>
                                                    </td>
                                                    <td>
                                                          <asp:Label ID="Label1071" runat="server" Text="50>"></asp:Label>
                                                    </td>
                                                </tr>
                                                 <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1065" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1066" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                           <asp:TextBox ID="TextBox1067" runat="server"  Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel114" runat="server" DefaultButton="Button114">
                                                            <asp:Button ID="Button114" runat="server" Text="Button" Style="display:none" OnClick="Button114_Click"  />
                                                           <asp:TextBox ID="TextBox1068" runat="server"  AutoPostBack="False"  Width="52px" OnTextChanged="TextBox1068_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                            </div>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1072" runat="server" Text="Number of individuals trained in testing and counseling according to national and international standards
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox1069" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table></td>
                                    </tr>
                                     <tr>
                                        <td>
                                            <div class="clearboth">
                                                <table>
                                                    <tr>
                                                        <td>
                                                             <asp:Label ID="Label1073" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                             <asp:Label ID="Label1074" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                    </tr>
                                                     <tr>
                                                        <td>
                                                             <asp:TextBox ID="TextBox1070" runat="server"  Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:Panel ID="Panel115" runat="server" DefaultButton="Button115">
                                                            <asp:Button ID="Button115" runat="server" Text="Button" Style="display:none" OnClick="Button115_Click"  />
                                                             <asp:TextBox ID="TextBox1071" runat="server"  Width="52px" OnTextChanged="TextBox1071_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                            </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <br />
                        </asp:MultiView>
                  <%-- </ContentTemplate>
                   </asp:UpdatePanel>--%>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="background-color: #999999; text-align: center">
                <asp:ImageButton ID="btnComplete" runat="server" ImageUrl="~/image/Complete.png" Width="90px" Visible="False" />
                <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/image/Submit.png" OnClick="btnSave_Click" CausesValidation="False" />
                <asp:ImageButton ID="btnClear" runat="server" ImageUrl="~/image/Clear1.png" OnClick="btnClear_Click" Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

