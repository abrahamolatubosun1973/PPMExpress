<%@ Page Title="Data Entry Screen" Language="C#" MasterPageFile="~/MasterPage.master" MaintainScrollPositionOnPostback="false" EnableViewState="true" AutoEventWireup="true" CodeFile="DataEntries.aspx.cs" Inherits="DataEntries" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   

    <style type="text/css">
    .showbtn{
        text-align:center;
        background-color:gray;
        
    }
       .modelBackground{
            background-color:black;
            filter:alpha(opacity=90);
            opacity:0.8;
 
       }
       .ModelPopup{
           background-color:#9EBFD8;
           border-width:3px;
           border-style:solid;
           border-color:black;
           padding-top:10px;
           padding-left:10px;
           width:300px;
           height:140px;
       }
        .auto-style2 {
            width: 100%;
        }
        .auto-style5 {
            width: 962px;
            
        }
        .auto-style8 {
            width: 368px;
        }
        .auto-style1 {
            width: 96%;
        }
        .auto-style11 {
            font-weight: bold;
        }
    .auto-style12 {
        text-align: right;
        font-weight: bold;
        width: 142px;
    }
    .auto-style15 {
        width: 1192px;
    }
        .auto-style16 {
            text-align: left;
        }
        .auto-style18 {
            width: 342px;
        }
    .auto-style19 {
        height: 26px;
    }
    .auto-style32 {
        width: 792px;
    }
        .auto-style33 {
            width: 792px;
        }
        .auto-style35 {
            color: black;
        }
        .auto-style37 {
            width: 102px;
        }
        .auto-style38 {
            width: 102px;
            font-weight: bold;
            /*background-color: #FF0000;*/
        }
        .auto-style39 {
            font-weight: bold;
            /*background-color: #FF0000;*/
        }
        .auto-style40 {
            color: #FFFFFF;
        }
        .auto-style42 {
            width: 683px;
            background-color: #FFFFFF;
        }
        .auto-style45 {
        }
        .auto-style46 {
            text-align: center;
        }
        .style2
        {
            text-align: center;
            background-color: #0033CC;
        }
        .style3
        {
            text-align: center;
            <%--background-color: #6A8FFF;--%>
        }
        .style4
        {
            width: 148px;
        }
        .style5
        {
            width: 122px;
        }
        .auto-style49 {
            color: #CC6600;
        }
        .auto-style50 {
            color: black;
            background-color: #99CCFF;
        }
        .auto-style51 {
            font-size: 9px;
            color: #FFFFFF;
        }
        .auto-style52 {
            background-color: #000000;
        }
        .auto-style53 {
            font-size: 9px;
            color: #FFFFFF;
            background-color: #000000;
        }
        </style>
<%--     <script type="text/javascript">

     function stopRKey(evt) {
         var evt = (evt) ? evt : ((event) ? event : null);
         var node = (evt.target) ? evt.target : ((evt.srcElement) ? evt.srcElement : null);
         if ((evt.keyCode == 13) && (node.type == "text")) { return false; }
     }

     document.onkeypress = stopRKey;

</script>--%> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
         <table class="auto-style2" style="clip: rect(0px, auto, auto, auto)">
            <tr>
                <td class="style5" style="vertical-align: top">
                <%--================================================================--%>
                    <asp:Panel ID="PopUpDiv" runat="server" CssClass="ModelPopup " align="center" style="display:none">
                       Before you can use the forms, fill :<br />
                       <b>State</b><br /> <b>LGA</b><br /><b>Facility</b><br /><b>Month and Year</b><br />
                        <asp:Button ID="btnOK" runat="server" Text="Ok   " />
                    </asp:Panel>

                    <%--================================================================--%>

                </td>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;
                   
                    <asp:Label ID="lblThematic" runat="server" style="font-weight: 700"></asp:Label></td>
            </tr>
            <tr>
                <td class="style5" style="vertical-align: top">
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
                        style="text-align: center" Text="PMTCT" Width="61px" Visible="False" />
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" 
                        style="text-align: center" Text="HTC" Width="61px" Visible="False" />
                    <br />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" 
                        Text="TREATMENT" Width="61px" Visible="False" />
                    <br />
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="ART" 
                        Width="61px" Visible="False" />
                    <br />
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="CARE" 
                        Width="61px" Visible="False" />
                    <br />
                    <asp:Button ID="Button6" runat="server" OnClick="Button1_Click" Text="TB" 
                        Width="61px" Visible="False" />
                    <br />
                    <%--====================================================================================================================================================--%>
                   <%-- <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="PopUpDiv" BackgroundCssClass="modelBackground" DropShadow="false" CancelControlID="btnOK" TargetControlID="Button1">
                    </cc1:ModalPopupExtender>
                    <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" PopupControlID="PopUpDiv" BackgroundCssClass="modelBackground" DropShadow="false" CancelControlID="btnOK" TargetControlID="Button2">
                    </cc1:ModalPopupExtender>
                    <cc1:ModalPopupExtender ID="ModalPopupExtender3" runat="server" PopupControlID="PopUpDiv" BackgroundCssClass="modelBackground" DropShadow="false" CancelControlID="btnOK" TargetControlID="Button3">
                    </cc1:ModalPopupExtender>
                    <cc1:ModalPopupExtender ID="ModalPopupExtender4" runat="server" PopupControlID="PopUpDiv" BackgroundCssClass="modelBackground" DropShadow="false" CancelControlID="btnOK" TargetControlID="Button4">
                    </cc1:ModalPopupExtender>
                    <cc1:ModalPopupExtender ID="ModalPopupExtender5" runat="server" PopupControlID="PopUpDiv" BackgroundCssClass="modelBackground" DropShadow="false" CancelControlID="btnOK" TargetControlID="Button5">
                    </cc1:ModalPopupExtender>--%>
            
                    <%--=====================================================================================================================================================--%>
                </td>
                <td class="auto-style5">
                  <%-- <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>--%>
                    <asp:MultiView ID="MultiView1" runat="server">
                        <asp:View ID="View1" runat="server">
                            <table class="auto-style1" style="border-style: solid; border-width: thin">
                                <tr>
                                    <td class="auto-style11" 
                                        style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                        <asp:Label ID="Label201" runat="server" Text="PMTCT"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table>
                                            <tr>
                                                <td class="auto-style18"><asp:Label ID="Label1" runat="server" Text="Number of new ANC attendees" Font-Bold="False" ForeColor="Black" ></asp:Label></td>
                                                <td>
                                                    <asp:TextBox ID="TextBox579" runat="server" ReadOnly="false" Width="50px" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label2" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label3" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label4" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label5" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label6" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                           
                                                <td class="auto-style19">
                                          
                                                    <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
                                                
                                                </td>
                                                <td class="auto-style19">
                                                
                                                    <asp:TextBox ID="TextBox2" runat="server" Width="50px"></asp:TextBox>
                                                
                                                </td>
                                                <td class="auto-style19">
                                                
                                                    <asp:TextBox ID="TextBox3" runat="server" Width="50px"></asp:TextBox>
                                                 
                                                </td>
                                                <td class="auto-style19">
                                                  
                                                    <asp:TextBox ID="TextBox4" runat="server" Width="50px"></asp:TextBox>
                                                
                                                </td>
                                                <td class="auto-style19">
                                                 <asp:Panel ID="Panel2" runat="server" DefaultButton="Button7"> 
                                                   <asp:TextBox ID="TextBox5" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox5_TextChanged"></asp:TextBox> 
                                                     <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Button" style="display:none" />
                                                  </asp:Panel> 
                                                </td>
                                               
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       <hr />
                                        <table>
                                            <tr>
                                                <td> <asp:Label ID="Label7" runat="server" Text="Number of women attending labour and delivery (L&amp;D) with unknown HIV status
" Font-Bold="False" ForeColor="Black"></asp:Label></td>
                                                <td><asp:TextBox ID="TextBox80" runat="server" Width="50px" ReadOnly="false" BackColor="#CCCCCC"></asp:TextBox></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label8" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label9" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label10" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label11" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label12" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox6" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox7" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox8" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox9" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                   <asp:Panel ID="Panel1" runat="server" DefaultButton="Button8">
                                                    <asp:TextBox ID="TextBox10" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
                                                       <asp:Button ID="Button8" runat="server" Text="Button" style="display:none" OnClick="Button8_Click" />
                                                  
                                                   </asp:Panel> 
                                               </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td><asp:Label ID="Label13" runat="server" Text="Number of women with unknown HIV status attending postpartum services within 72 hours of delivery.
" ForeColor="Black"></asp:Label> </td>
                                                <td><asp:TextBox ID="TextBox132" runat="server" Width="50px" ReadOnly="false" BackColor="#CCCCCC"></asp:TextBox> </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label14" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label15" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label16" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label17" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label18" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox11" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox12" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox13" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox14" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel3" runat="server" DefaultButton="Button9">
                                                         <asp:Button ID="Button9" runat="server" Text="Button" OnClick="Button9_Click" style="display:none" />
                                                    <asp:TextBox ID="TextBox15" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox15_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                         <tr>
                                         <td>
                                         <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Medium" Text="Number of pregnant women with known HIV status (includes women who tested for HIV and received their results)
" ForeColor="Black"></asp:Label>
                                         </td>
                                         <td>
                                          <asp:TextBox ID="TextBox16" runat="server" ReadOnly="false" style="margin-top: 0px" Width="52px" BackColor="#CCCCCC"></asp:TextBox>
                                         </td>
                                         </tr>
                                        </table>
                                        <table align="center" class="auto-style1">
                                         <tr>
                                            <td class="style3">
                                               <asp:Label ID="Label60" runat="server" Text="<15"></asp:Label>
                                            </td>
                                            <td class="style3">
                                               <asp:Label ID="Label67" runat="server" Text="15 - 19"></asp:Label>
                                            </td>
                                            <td class="style3">
                                              <asp:Label ID="Label75" runat="server" Text="20 - 24"></asp:Label>
                                            </td>
                                            <td class="style3">
                                                <asp:Label ID="Label81" runat="server" Text="25 - 49"></asp:Label>
                                            </td>
                                            <td class="style3">
                                              <asp:Label ID="Label83" runat="server" Text="50+"></asp:Label>
                                            </td>
                                         </tr>
                                          <tr>
                                            <td class="auto-style46">
                                            
                                                <asp:TextBox ID="TextBox674" runat="server" BackColor="#CCCCCC" ReadOnly="false" 
                                                    Width="50px"></asp:TextBox>
                                            
                                            </td>
                                            <td class="auto-style46">
                                            <asp:TextBox ID="TextBox473" runat="server" BackColor="#CCCCCC" ReadOnly="false" 
                                                    Width="50px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style46">
                                            <asp:TextBox ID="TextBox474" runat="server" BackColor="#CCCCCC" ReadOnly="false" 
                                                    Width="50px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style46">
                                            <asp:TextBox ID="TextBox475" runat="server" BackColor="#CCCCCC" ReadOnly="false" 
                                                    Width="50px"></asp:TextBox>
                                            </td>
                                            <td class="auto-style46">
                                            <asp:TextBox ID="TextBox476" runat="server" BackColor="#CCCCCC" ReadOnly="false" 
                                                    Width="50px"></asp:TextBox>
                                            </td>
                                         </tr>
                                        </table>
                                        
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td><asp:Label ID="Label20" runat="server" Text="Number of women attending ANC who were tested for HIV and received their results (also a subset of #P11.1D)
" ForeColor="Black" style="background-color: #3399FF"></asp:Label> </td>
                                                <td> <asp:TextBox ID="TextBox133" runat="server" ReadOnly="false" style="margin-top: 0px" Width="52px" BackColor="#CCCCCC"></asp:TextBox> </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label21" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label22" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label23" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label24" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label25" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox17" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox18" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox19" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox20" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                       <asp:Panel ID="Panel4" runat="server" DefaultButton="Button10">
                                                         <asp:Button ID="Button10" runat="server" Text="Button" style="display:none" OnClick="Button10_Click" />
                                                    <asp:TextBox ID="TextBox21" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox21_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td><asp:Label ID="Label26" runat="server" Text="Number of women with known (positive) HIV infection attending ANC for a new pregnancy
"></asp:Label> </td>
                                                <td><asp:TextBox ID="TextBox134" runat="server" ReadOnly="false"  Width="52px" BackColor="#CCCCCC"></asp:TextBox> </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label27" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label28" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label29" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label30" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label31" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox22" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox23" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox24" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox25" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel5" runat="server" DefaultButton="Button11">
                                                         <asp:Button ID="Button11" runat="server" Text="Button" style="display:none" OnClick="Button11_Click"  />
                                                    <asp:TextBox ID="TextBox26" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox26_TextChanged"></asp:TextBox>
                                                   </asp:Panel> 
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td>
                                                     <asp:Label ID="Label32" runat="server" Font-Size="Small" Text="Number of women attending labour and delivery (L&amp;D) who were tested for HIV and received their results (also a subset of #P11.1D)
                                        " ForeColor="Black" style="background-color: #3399FF"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox27" runat="server" ReadOnly="false" style="margin-top: 0px" Width="52px" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label33" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label34" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label35" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label36" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label37" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox28" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox29" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox30" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox31" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel6" runat="server" DefaultButton="Button12">
                                                         <asp:Button ID="Button12" runat="server" Text="Button" style="display:none" OnClick="Button12_Click"  />
                                                    <asp:TextBox ID="TextBox32" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox32_TextChanged"></asp:TextBox>
                                                          </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       <hr />
                                        <table>
                                            <tr>
                                                <td> <asp:Label ID="Label38" runat="server" Text="Number of women with unknown HIV status attending postpartum services within 72 hours of delivery who were tested and received results (also a subset of #P11.1D)" ForeColor="Black" style="background-color: #3399FF"></asp:Label> </td>
                                                <td style="vertical-align: top"> <asp:TextBox ID="TextBox135" runat="server" ReadOnly="false"  Width="50px" BackColor="#CCCCCC"></asp:TextBox> </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label43" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label44" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label45" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label46" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label47" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                     <asp:Panel ID="Panel8" runat="server" DefaultButton="Button130">
                                                         <asp:Button ID="Button130" runat="server" Text="Button" style="display:none" OnClick="Button130_Click" />
                                                    <asp:TextBox ID="TextBox33" runat="server" Width="50px" AutoPostBack="False"  ></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel16" runat="server" DefaultButton="Button131">
                                                         <asp:Button ID="Button131" runat="server" Text="Button" style="display:none" OnClick="Button131_Click" />
                                                    <asp:TextBox ID="TextBox34" runat="server" Width="50px" AutoPostBack="False" ></asp:TextBox>
                                                </asp:Panel>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel22" runat="server" DefaultButton="Button132">
                                                         <asp:Button ID="Button132" runat="server" Text="Button" style="display:none" OnClick="Button132_Click" />
                                                    <asp:TextBox ID="TextBox35" runat="server" Width="50px" AutoPostBack="False" ></asp:TextBox>
                                                </asp:Panel>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel79" runat="server" DefaultButton="Button133">
                                                         <asp:Button ID="Button133" runat="server" Text="Button" style="display:none" OnClick="Button133_Click" />
                                                    <asp:TextBox ID="TextBox36" runat="server" Width="50px" AutoPostBack="False" ></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel7" runat="server" DefaultButton="Button13">
                                                         <asp:Button ID="Button13" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button13_Click"   />
                                                    <asp:TextBox ID="TextBox37" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox37_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td><asp:Label ID="Label48" runat="server" Text="Number of pregnant women who tested HIV positive 
" ForeColor="Black" style="font-weight: 700; color: #000000; background-color: #FF3300;"></asp:Label> </td>
                                                <td> <asp:TextBox ID="TextBox136" runat="server" ReadOnly="false"  Width="50px" Visible="False" BackColor="#CCCCCC" ></asp:TextBox> </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label49" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label50" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label51" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label52" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td class="auto-style38">
                                                    <asp:Label ID="Label53" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox38" runat="server" Width="50px" CssClass="auto-style35" 
                                                        ReadOnly="false" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox39" runat="server" Width="50px" CssClass="auto-style35" 
                                                        ReadOnly="false" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox40" runat="server" Width="50px" ReadOnly="false" 
                                                        BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox41" runat="server" Width="50px" CssClass="auto-style35" 
                                                        ReadOnly="false" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td class="auto-style37">
                                                   
                                                    <asp:TextBox ID="TextBox42" runat="server" Width="50px" CssClass="auto-style35" 
                                                        ReadOnly="false" OnTextChanged="TextBox42_TextChanged" BackColor="#CCCCCC" ></asp:TextBox>
                                                   
                                                </td>
                                                
                                            </tr>
                                        </table>
                                      
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td><asp:Label ID="Label54" runat="server" Text="Number of pregnant women who tested HIV positive  in ANC
" ForeColor="Black"></asp:Label> </td>
                                                <td><asp:TextBox ID="TextBox137" runat="server" ReadOnly="false"  Width="50px" BackColor="#CCCCCC"></asp:TextBox> </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label55" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label56" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label57" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label58" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label59" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox43" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox44" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox45" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox46" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel9" runat="server" DefaultButton="Button15">
                                                         <asp:Button ID="Button15" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button15_Click"   />
                                                    <asp:TextBox ID="TextBox47" runat="server" Width="50px" OnTextChanged="TextBox47_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                    <table>
                                        <tr>
                                            <td>
                                        <asp:Label ID="Label61" runat="server" Text="Number of pregnant women who tested HIV positive  in L&amp;D
                                        "></asp:Label></td>
                                       <td>
                                        <asp:TextBox ID="TextBox581" runat="server" ReadOnly="false" Width="50px" BackColor="#CCCCCC"></asp:TextBox>
                                       </td>
                                      </tr>
                                    </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label62" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label63" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label64" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label65" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label66" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox48" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox49" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox50" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox51" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel10" runat="server" DefaultButton="Button16">
                                                         <asp:Button ID="Button16" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button16_Click"   />
                                                    <asp:TextBox ID="TextBox52" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox52_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label68" runat="server" Text="Number of pregnant women who tested HIV positive  in 72 hours post partum 
                                                     "></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox582" runat="server" ReadOnly="false" Width="50px" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label69" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label70" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label71" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label72" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label73" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox53" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox54" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox55" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox56" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel11" runat="server" DefaultButton="Button17">
                                                         <asp:Button ID="Button17" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button17_Click"   />
                                                    <asp:TextBox ID="TextBox57" runat="server" Width="50px" OnTextChanged="TextBox57_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                    <table>
                                        <tr>
                                            <td>
                                            <asp:Label ID="Label74" runat="server" Text="Number of pregnant women who tested HIV negative
                                            " style="font-weight: 700; background-color: #FF9900; color: #000000;"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox583" runat="server" ReadOnly="false" Width="50px" Visible="False" BackColor="#CCCCCC"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr class="auto-style40">
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label76" runat="server" Text="&lt; 15" CssClass="auto-style35"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label77" runat="server" Text="15 - 19" CssClass="auto-style35"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label78" runat="server" Text="20 - 24" CssClass="auto-style35"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label79" runat="server" Text="25 - 49" CssClass="auto-style35"></asp:Label>
                                                </td>
                                                <td class="auto-style39">
                                                    <asp:Label ID="Label80" runat="server" Text="50 +" CssClass="auto-style35"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox58" runat="server" Width="50px" ReadOnly="false" 
                                                        BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox59" runat="server" Width="50px" ReadOnly="false" 
                                                        BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox60" runat="server" Width="50px" ReadOnly="false" 
                                                        BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox61" runat="server" Width="50px" ReadOnly="false" 
                                                        BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel12" runat="server" DefaultButton="Button18">
                                                         <asp:Button ID="Button18" runat="server" Text="Button" style="display:none"   />
                                                    <asp:TextBox ID="TextBox62" runat="server" Width="50px" 
                                                              OnTextChanged="TextBox62_TextChanged" ReadOnly="false" BackColor="#CCCCCC"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label82" runat="server" Text="Number of pregnant women who tested HIV Negative in ANC
                                                       "></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox584" runat="server" ReadOnly="false" Width="50px" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label87" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label88" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label89" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label90" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label91" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox63" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox64" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox65" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox66" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel13" runat="server" DefaultButton="Button19">
                                                         <asp:Button ID="Button19" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button19_Click"   />
                                                    <asp:TextBox ID="TextBox67" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox67_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label84" runat="server" Text="Number of pregnant women who tested HIV Negative  in L&amp;D
                                                    "></asp:Label>
                                                </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox585" runat="server" ReadOnly="false" Width="50px" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label92" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label93" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label94" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label95" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label96" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox68" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox69" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox70" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox71" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel14" runat="server" DefaultButton="Button20">
                                                         <asp:Button ID="Button20" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button20_Click"   />
                                                    <asp:TextBox ID="TextBox72" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox72_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <hr />
                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label86" runat="server" Text="Number of pregnant women who tested HIV Negative  in 72 hours post partum 
                                                     "></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox586" runat="server" ReadOnly="false" Width="50px" BackColor="#CCCCCC"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table align="center" class="auto-style1" style="text-align: center">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label97" runat="server" Text="&lt; 15"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label98" runat="server" Text="15 - 19"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label99" runat="server" Text="20 - 24"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label100" runat="server" Text="25 - 49"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label101" runat="server" Text="50 +"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox73" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox74" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox75" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox76" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel15" runat="server" DefaultButton="Button21">
                                                         <asp:Button ID="Button21" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button21_Click"   />
                                                    <asp:TextBox ID="TextBox77" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox77_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr >
                                                <td class="auto-style33" nowrap="nowrap">
                                                    <asp:Label ID="Label103" runat="server" Text="Number of new ANC Clients tested for syphilis
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox78" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32" nowrap="nowrap">
                                                    <asp:Label ID="Label105" runat="server" Text="Number of new ANC Clients tested positive for syphilis
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox79" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label919" runat="server" Text="Number of the ANC Clients treated for syphilis
"></asp:Label>
                                                </td>
                                                <td style="">
                                                    <asp:TextBox ID="TextBox578" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label109" runat="server" Text="Number of  ANC Clients who tested positive for HIV and were screened for TB
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox81" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                    <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                     <asp:Label ID="Label111" runat="server" Text="Number of  ANC Clients who tested positive for HIV and were identified as TB Suspect
"></asp:Label>
                                                </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox82" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>    
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label113" runat="server" Text="Number of HIV positive pregnant women assessed for ART eligibility by Clinical Stage
"></asp:Label>
                                                </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox83" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table></td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label115" runat="server" Text="Number  of HIV positive pregnant women assessed for ART eligibility by CD4
"></asp:Label>
                                                </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox84" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label117" runat="server" Font-Size="Small" Text="Number of HIV-positive pregnant women eligible for ART according to national guidelines (based on CD4 count and/or WHO staging)
"></asp:Label>                              </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox85" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label119" runat="server" Text="Number of HIV-positive pregnant women who have documented CD4 results
"></asp:Label>                             </td>
                                                <td>
                                                       
                                                  <asp:TextBox ID="TextBox86" runat="server" Width="50px" AutoPostBack="False" OnTextChanged="TextBox86_TextChanged"></asp:TextBox>
                                                          
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                 <asp:Label ID="Label121" runat="server" Text="(Numerator) Number of HIV-positive pregnant women who received antiretrovirals to reduce risk of mother-to-child-transmission
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label>                            </td>
                                                <td>
                                                <asp:TextBox ID="TextBox87" runat="server" Width="50px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                        <%--<hr />--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                     
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                 <asp:Label ID="Label123" runat="server" Text="Life-long ART for Eligible women (including Option B+)
" CssClass="auto-style49"></asp:Label>                            </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox88" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label125" runat="server" Text="Newly initiated on treatment during the current pregnancy:
" CssClass="auto-style49"></asp:Label>                           </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox89" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label127" runat="server" Text="Already on treatment at the beginning of pregnancy:
" CssClass="auto-style49"></asp:Label>                           </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox90" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label129" runat="server" Text="Maternal triple ARV prophylaxis (prophylaxis component of WHO Option B during pregnancy and delivery)
" CssClass="auto-style49"></asp:Label>                          </td>
                                                <td>
                                                     <asp:Panel ID="Panel38" runat="server" DefaultButton="Button14">
                                                         <asp:Button ID="Button14" runat="server" Text="Button" style="display:none" OnClick="Button14_Click" /> 
                                                  <asp:TextBox ID="TextBox91" runat="server" Width="50px"></asp:TextBox>
                                                         <span class="auto-style51"><strong><span class="auto-style52">Press enter key</span></strong></span></asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label131" runat="server" Text="Maternal AZT (prophylaxis component of WHO Option A during pregnancy and delivery)
" CssClass="auto-style49" Visible="False"></asp:Label>                         </td>
                                                <td>
                                                  <asp:TextBox ID="TextBox274" runat="server" Width="50px" ReadOnly="false" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label133" runat="server" Text="Single-dose nevirapine (with or without tail)
" CssClass="auto-style49" Visible="False"></asp:Label>                        </td>
                                                <td>
                                                    
                                                    <asp:TextBox ID="TextBox275" runat="server" Width="50px" ReadOnly="false" Visible="False"></asp:TextBox>
                                                
                                            </tr>
                                        </table>
                                       <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label135" runat="server" Text="Number of HIV-positive pregnant women who were counselled on infant feeding practice
"></asp:Label>                        </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox276" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label137" runat="server" Text="Number of HIV-positive pregnant women who received CTX
"></asp:Label>                       </td>
                                                <td>
                                                   <asp:TextBox ID="TextBox277" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label139" runat="server" Text="Number of HIV-positive pregnant women who received Anti-Malaria Drugs
"></asp:Label>                       </td>
                                                <td>
                                                  <asp:TextBox ID="TextBox278" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label141" runat="server" Text="Number of HIV-positive pregnant women who received Haematinics (Blood Capsules)
"></asp:Label>                      </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox279" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label143" runat="server" Text="No. of partners of HIV neg. pregnant women tested HIV negative
"></asp:Label>                     </td>
                                                <td>
                                                <asp:TextBox ID="TextBox280" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label145" runat="server" Text="No. of partners of HIV neg. pregnant women tested HIV positive
"></asp:Label>                    </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox281" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label147" runat="server" Text="No. of partners of HIV pos. pregnant women  tested HIV negative
"></asp:Label>                  </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox282" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label149" runat="server" Text="No. of partners of HIV pos. pregnant women  tested HIV positive
"></asp:Label>                  </td>
                                                <td>
                                                <asp:TextBox ID="TextBox283" runat="server" Width="50px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label151" runat="server" Text="Number of couples counselled, tested and received result (should carry numbers like:001a &amp; 001b)
"></asp:Label>                  </td>
                                                <td>
                                                <asp:TextBox ID="TextBox92" runat="server" style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label153" runat="server" Text="Number of couples with discordant HIV test results (should carry numbers like:001a &amp; 001b)
"></asp:Label>                  </td>
                                                <td>
                                                <asp:TextBox ID="TextBox93" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label155" runat="server" Text="Number of HIV positive pregnant women were counselled on RH/FP
"></asp:Label>                 </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox94" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label157" runat="server" Text="Number of HIV positive pregnant women counselled on RH/FP were referred to family planning clinic/unit
"></asp:Label>                </td>
                                                <td>
                                                <asp:TextBox ID="TextBox273" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label159" runat="server" Text="Number of pregnant women given condom
"></asp:Label>              </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox95" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label160" runat="server" Text="Number of Condom given
"></asp:Label>             </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox96" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label161" runat="server" Text="Total number of deliveries at the facility (booked and unbooked cases)
"></asp:Label>           </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox97" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label39" runat="server" Text="Number of known positive women booked at ANC and delivered at facility (Not yet codedd)"></asp:Label> </td>
                                                <td><asp:TextBox ID="TextBox154" runat="server" Width="52px"></asp:TextBox></td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label40" runat="server" Text="Number of known HIV+ women Unbooked at ANC but delivered at facility (Not Yet Coded)"></asp:Label> </td>
                                                <td><asp:TextBox ID="TextBox155" runat="server" Width="52px"></asp:TextBox></td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label162" runat="server" Text="Total number of HIV positive women delivering at facility
"></asp:Label>          </td>
                                                <td>
                                                      <asp:Panel ID="Panel17" runat="server" DefaultButton="Button23">
                                                         <asp:Button ID="Button23" runat="server" Text="Button" style="display:none" 
                                                                />   <%-- onclick="Button23_Click"--%>
                                                 <asp:TextBox ID="TextBox98" runat="server" style="margin-top: 0px" Width="52px" AutoPostBack="False" ></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label163" runat="server" Text="Total number of live births by  HIV+ women
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label>         </td>
                                                <td>
                                                <asp:TextBox ID="TextBox99" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                          <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                 <asp:Label ID="Label164" runat="server" Text="Male
" CssClass="auto-style50"></asp:Label>     </td>
                                                <td>
                                                <asp:TextBox ID="TextBox100" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                      

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                <asp:Label ID="Label165" runat="server" Text="Female 
" CssClass="auto-style50"></asp:Label>  </td>
                                                <td>
                                                     <asp:Panel ID="Panel40" runat="server" DefaultButton="Button28">
                                                         <asp:Button ID="Button28" runat="server" Text="Button" style="display:none" OnClick="Button28_Click" />
                                                 <asp:TextBox ID="TextBox101" runat="server" style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                         <span class="auto-style53">Press enter key</span> </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                 <asp:Label ID="Label166" runat="server" Text="Number of HIV positive women who delivered in maternity and took ARV prophylaxis during pregnancy
"></asp:Label> </td>
                                                <td>
                                                 <asp:TextBox ID="TextBox102" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                <asp:Label ID="Label167" runat="server" Text="Number of HIV positive women who delivered in maternity and already receiving  ART for their health prior or during index pregnancy
" style="color: #CC6600"></asp:Label> </td>
                                                <td>
                                                  <asp:TextBox ID="TextBox103" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                               <asp:Label ID="Label168" runat="server" Text="Number of HIV positive women who received triple ARV prophylaxis at labour
" style="color: #CC6600"></asp:Label></td>
                                                <td>
                                                    <asp:Panel ID="Panel39" runat="server" DefaultButton="Button22">
                                                        <asp:Button ID="Button22" runat="server" Text="Button" style="display:none" OnClick="Button22_Click" />
                                                 <asp:TextBox ID="TextBox104" runat="server" style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                        <span class="auto-style53">Press enter key</span></asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                         bb<br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                      
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                 <asp:Label ID="Label169" runat="server" Text="Mama Pack Given(Quantity)
"></asp:Label></td>
                                                <td>
                                                  <asp:TextBox ID="TextBox105" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                 <asp:Label ID="Label170" runat="server" Text="Number of infants born to HIV-positive pregnant women who were started on cotrimoxazole (CTX) prophylaxis within two months of birth
"></asp:Label></td>
                                                <td>
                                                     <%-- <asp:Panel ID="Panel18" runat="server" DefaultButton="Button24">
                                                         <asp:Button ID="Button24" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button24_Click"   />--%>
                                                  <asp:TextBox ID="TextBox106" runat="server" style="margin-top: 0px" Width="52px" AutoPostBack="False" OnTextChanged="TextBox106_TextChanged"></asp:TextBox>
                                                   <%-- </asp:Panel>--%>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                      
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label171" runat="server" Text="Number of exposed infants who received Daily-NVP as complete course of PMTCT prophylaxis for the infant
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label></td>
                                                <td>

                                                <asp:TextBox ID="TextBox107" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>



                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label172" runat="server" Text="Number of exposed infants born in facility who received NVP as complete course of PMTCT prophylaxis for the infant
"></asp:Label></td>
                                                <td>
                                                 <asp:TextBox ID="TextBox108" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>



                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label173" runat="server" Text="Number of exposed infants born at home who received NVP 
"></asp:Label></td>
                                                <td>
                                                      <asp:Panel ID="Panel19" runat="server" DefaultButton="Button25">
                                                         <asp:Button ID="Button25" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button25_Click"   />
                                                <asp:TextBox ID="TextBox109" runat="server" style="margin-top: 0px" Width="52px" OnTextChanged="TextBox109_TextChanged" AutoPostBack="False"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        
                                        
                                         
                                    </td>
                                </tr>
                                <tr>
                                      
                                          <td class="auto-style15">
                                   

                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label174" runat="server" Text="Number of infants born to HIV positive women who received virological testing within 12 months and received test result
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label></td>
                                                <td>
                                               <asp:TextBox ID="TextBox110" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       

                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label175" runat="server" Text="Number of infants born to HIV postive women who received virological testing in the first 2 months of life and received result"></asp:Label>

                                                </td>
                                                <td>
                                               <asp:TextBox ID="TextBox269" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label922" runat="server" Text="Number of infants to HIV positive women who received virological testing between &gt;2 to 12 months of life and received result"></asp:Label>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel20" runat="server" DefaultButton="Button26">
                                                         <asp:Button ID="Button26" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button26_Click"   />
                                                     <asp:TextBox ID="TextBox587" runat="server" style="margin-top: 0px" Width="52px" AutoPostBack="False" ></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                    <asp:Label ID="Label176" runat="server" Text="Number of infants born to HIV positive women who received virological testing within 12 months and received test result
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label>
                                                </td>
                                                <td>
                                              <asp:TextBox ID="TextBox270" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label177" runat="server" Text="Male
"></asp:Label>
                                                </td>
                                                <td>
                                                       
                                              <asp:TextBox ID="TextBox111" runat="server" style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                        
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label178" runat="server" Text="Female
"></asp:Label>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel21" runat="server" DefaultButton="Button27">
                                                         <asp:Button ID="Button27" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button27_Click"   />
                                              <asp:TextBox ID="TextBox112" runat="server" style="margin-top: 0px" Width="52px" AutoPostBack="False" OnTextChanged="TextBox112_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label179" runat="server" Text="Number of infants born to HIV positive women who received virological testing within 12 months and received test result
" style="background-color: #999999"></asp:Label>
                                                </td>
                                                <td>
                                             <asp:TextBox ID="TextBox113" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                      
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label180" runat="server" Text="By test result:positive
"></asp:Label>
                                                </td>
                                                <td>
                                              <asp:TextBox ID="TextBox114" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                   <asp:Label ID="Label181" runat="server" Text="By test result:Negative
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Panel ID="Panel41" runat="server" DefaultButton="Button44">
                                                        <asp:Button ID="Button44" runat="server" Text="Button" style="display:none" OnClick="Button44_Click" />
                                              <asp:TextBox ID="TextBox115" runat="server" style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                        <span class="auto-style53">Press enter key</span></asp:Panel>
                                                </td>
                                                
                                            </tr>
                                             <tr>
                                                 <td>
                                                    <asp:Label ID="Label41" runat="server" Text="Label" Visible="False"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label42" runat="server" Text="Label" Visible="False"></asp:Label>
                                                </td>

                                             </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label182" runat="server" Text="Disaggregated by Positive Results:
" style="font-weight: 700; background-color: #999999"></asp:Label>
                                                </td>
                                                <td>
                                              <asp:TextBox ID="TextBox116" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                          <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                                  <asp:Label ID="Label183" runat="server" Text="Infants with a positive virologic test results within 2 months of birth
"></asp:Label>
                                                </td>
                                                <td>
                                            <asp:TextBox ID="TextBox117" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                               <asp:Label ID="Label184" runat="server" Text="Infants with a positive virologic test result between 2 and 12 months of age
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Panel ID="Panel18" runat="server" DefaultButton="Button24">
                                                        <asp:Button ID="Button24" runat="server" Text="Button" style="display:none" OnClick="Button24_Click" />
                                                            <asp:TextBox ID="TextBox118" runat="server" style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                        <span class="auto-style53">Press enter key</span></asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                               <asp:Label ID="Label185" runat="server" Text="Number of HIV-exposed infants registered in the birth cohort at any time between 0 and 18 months of age (including transfer-ins)
 (Denominator)"></asp:Label>
                                                </td>
                                                <td>
                                             <asp:TextBox ID="TextBox119" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                               <asp:Label ID="Label186" runat="server" Text="Number of HIV-exposed infants with a documented outcome by 18 months of age 
 (Numerator)"></asp:Label>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel23" runat="server" DefaultButton="Button29">
                                                         <asp:Button ID="Button29" runat="server" Text="Button" style="display:none" 
                                                                />   <%--onclick="Button29_Click"--%>
                                            <asp:TextBox ID="TextBox271" runat="server" 
                                            style="margin-top: 0px" Width="52px" AutoPostBack="False" ></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    
                                    <td class="auto-style15">
                                        
                                        
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label413" runat="server" Text="Number of HIV-exposed infants with a documented outcome by 18 months of age disaggregated by outcome type
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label>
                                                </td>
                                                <td>
                                            <asp:TextBox ID="TextBox272" runat="server" 
                                            style="margin-top: 0px" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                            <asp:Label ID="Label188" runat="server" Text="HIV-infected: Linked to ART
"></asp:Label>
                                                </td>
                                                <td>
                                            <asp:TextBox ID="TextBox122" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                        
                                        
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                            <asp:Label ID="Label189" runat="server" Text="HIV-infected: Not linked to ART
"></asp:Label>
                                                </td>
                                                <td>
                                            <asp:TextBox ID="TextBox123" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                      
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                           <asp:Label ID="Label190" runat="server" Text="HIV-infected: Unknown link
"></asp:Label>
                                                </td>
                                                <td>
                                             <asp:TextBox ID="TextBox124" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                      
                                      
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                            <asp:Label ID="Label191" runat="server" Text="HIV-uninfected: Not breastfeeding
"></asp:Label>
                                                </td>
                                                <td>
                                             <asp:TextBox ID="TextBox125" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                      
                                       
                                        <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label192" runat="server" Text="HIV-uninfected: Still breastfeeding
"></asp:Label>
                                                </td>
                                                <td>
                                             <asp:TextBox ID="TextBox126" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                      
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label193" runat="server" Text="HIV-uninfected: Breastfeeding unknown
"></asp:Label>
                                                </td>
                                                <td>
                                               <asp:TextBox ID="TextBox127" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label194" runat="server" Text="Other outcomes: In care but no test done
"></asp:Label>
                                                </td>
                                                <td>
                                               <asp:TextBox ID="TextBox128" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       
                                         <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label195" runat="server" Text="Other outcomes: Lost to follow up
"></asp:Label>
                                                </td>
                                                <td>
                                               <asp:TextBox ID="TextBox129" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>



                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                      
                                          <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                              <asp:Label ID="Label196" runat="server" Text="Other outcomes: Died
"></asp:Label>
                                                </td>
                                                <td>
                                                <asp:TextBox ID="TextBox130" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>



                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style15">
                                       
                                       
                                          <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                              <asp:Label ID="Label197" runat="server" Text="Other outcomes: Transferred out
"></asp:Label>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel24" runat="server" DefaultButton="Button30">
                                                         <asp:Button ID="Button30" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button30_Click"   />
                                                <asp:TextBox ID="TextBox131" runat="server" 
                                            style="margin-top: 0px" Width="52px" AutoPostBack="False" OnTextChanged="TextBox131_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>


                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td nowrap="nowrap" class="auto-style32">
<asp:Label ID="Label203" runat="server" Text="Number of health workers trained in the provision of PMTCT services according to national and international standards
" style="background-color: #CCCCCC; font-weight: 700;"></asp:Label>
                                                </td>
                                                <td><asp:TextBox ID="TextBox580" runat="server" ReadOnly="false" Width="52px" BackColor="#CCCCCC"></asp:TextBox>
                                                    </td>
                                            </tr>
                                        </table>
                                         </td>
                                </tr>
                               <tr>
                                   <td> 
                                        
                                       <table class="style1" style="border-bottom-style: solid; border-bottom-width: thin">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label187" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                <asp:TextBox ID="TextBox121" runat="server" 
                                            style="margin-top: 0px" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>

                                   </td>
                               </tr>
                                <tr>
                                    <td>
                                        

                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style32">
                                             <asp:Label ID="Label198" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                      <asp:Panel ID="Panel25" runat="server" DefaultButton="Button31">
                                                         <asp:Button ID="Button31" runat="server" Text="Button" style="display:none" 
                                                              onclick="Button31_Click"   />
                                               <asp:TextBox ID="TextBox120" runat="server" 
                                            style="margin-top: 0px" Width="52px" AutoPostBack="False" OnTextChanged="TextBox120_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>

                                    </td>
                                </tr>
                            </table>
                            </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                </td>
                                <td class="auto-style15">
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                </td>
                                <td class="auto-style15">
                                </td>
                            </tr>
                            </tr>
                            </table>
                        </asp:View>
                        <br />
                        <asp:View ID="View2" runat="server">
                            <table class="style1" style="border: thin solid #000000">
                                <tr>
                                    <td class="auto-style11" style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                        <asp:Label ID="Label923" runat="server" Text="HIV/RHFP Integration"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42">
<asp:Label ID="Label924" runat="server" Text=" Total number of clients registered for FP services
" style="font-weight: 700"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox588" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                     <asp:Label ID="Label942" runat="server" Text="Male
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox589" runat="server" Width="52px"></asp:TextBox>
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
<asp:Label ID="Label943" runat="server" Text="Female
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel26" runat="server" DefaultButton="Button32">
                                                         <asp:Button ID="Button32" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button32_Click"   />
                                                    <asp:TextBox ID="TextBox590" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox590_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table><hr />
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                <asp:Label ID="Label944" runat="server" style="font-weight: 700" Text="Total number of clients registered for FP services counseled and tested for HIV
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox591" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                     <asp:Label ID="Label945" runat="server" Text="Male
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox592" runat="server" Width="52px"></asp:TextBox>
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
                                                <asp:Label ID="Label946" runat="server" Text="Female
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel27" runat="server" DefaultButton="Button33">
                                                         <asp:Button ID="Button33" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button33_Click"   />
                                                    <asp:TextBox ID="TextBox593" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox593_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table><hr />
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label947" runat="server" style="font-weight: 700" Text=" Total number of clients registered for FP services tested positive
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox594" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                     <asp:Label ID="Label948" runat="server" Text="Male
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox595" runat="server" Width="52px"></asp:TextBox>
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
                                                     <asp:Label ID="Label949" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel28" runat="server" DefaultButton="Button34">
                                                         <asp:Button ID="Button34" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button34_Click"   />
                                                    <asp:TextBox ID="TextBox596" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox596_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                       <hr />
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label950" runat="server" style="font-weight: 700" Text=" Total number of clients registered for FP services tested positive and refered to ART clinic
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox597" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                    <asp:Label ID="Label951" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox598" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label952" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel29" runat="server" DefaultButton="Button35">
                                                         <asp:Button ID="Button35" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button35_Click"   />
                                                     <asp:TextBox ID="TextBox599" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox599_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label953" runat="server" style="font-weight: 700" Text="Total Number of Clients reached with Condom
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox600" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                    <asp:Label ID="Label954" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox601" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label955" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel30" runat="server" DefaultButton="Button36">
                                                         <asp:Button ID="Button36" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button36_Click"   />
                                                     <asp:TextBox ID="TextBox602" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox602_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label956" runat="server" style="font-weight: 700" Text="Total Number of Condom Given
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox603" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                     <asp:Label ID="Label957" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox604" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label958" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel31" runat="server" DefaultButton="Button37">
                                                         <asp:Button ID="Button37" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button37_Click"   />
                                                     <asp:TextBox ID="TextBox605" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox605_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                    </td>
                                </tr>
                            </table>
                              
                        </asp:View>
                      
                        <br />
                        <asp:View ID="View3" runat="server">
                            <table class="style1" style="border: thin solid #000000">
                                <tr>
                                    <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">TRAINING</td>
                                </tr>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                     <asp:Label ID="Label960" runat="server" Text="Number of individuals trained in strategic information
" CssClass="auto-style11"></asp:Label>
                                                </td>
                                                <td>

                                                    <asp:TextBox ID="TextBox606" runat="server" AutoPostBack="False" OnTextChanged="TextBox605_TextChanged" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>

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
                                                    <asp:Label ID="Label200" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox138" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label204" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel32" runat="server" DefaultButton="Button38">
                                                         <asp:Button ID="Button38" runat="server" Text="Button" style="display:none" OnClick="Button38_Click"   />
                                                    <asp:TextBox ID="TextBox139" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox139_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <hr />
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label205" runat="server" Text="Number of individuals trained in commodity logistics
" CssClass="auto-style11"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox140" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                    <asp:Label ID="Label206" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox141" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label207" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel33" runat="server" DefaultButton="Button39">
                                                         <asp:Button ID="Button39" runat="server" Text="Button" style="display:none" OnClick="Button39_Click"   />
                                                    <asp:TextBox ID="TextBox142" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox142_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <hr />
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label208" runat="server" Text="Number of individuals trained in ART/Care and support/TB HIV integration
" CssClass="auto-style11"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox143" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                    <asp:Label ID="Label209" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox144" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label210" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel34" runat="server" DefaultButton="Button40">
                                                         <asp:Button ID="Button40" runat="server" Text="Button" style="display:none" OnClick="Button40_Click"   />
                                                    <asp:TextBox ID="TextBox145" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox145_TextChanged"></asp:TextBox>
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
                                                    <asp:Label ID="Label978" runat="server" Text="Number of individuals trained in PMTCT/family planning HIV integration
" CssClass="auto-style11"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox607" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                    <asp:Label ID="Label211" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox146" runat="server" Width="52px"></asp:TextBox>
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
                                                    <asp:Label ID="Label212" runat="server" Text="Female"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:Panel ID="Panel35" runat="server" DefaultButton="Button31">
                                                         <asp:Button ID="Button41" runat="server" Text="Button" style="display:none" OnClick="Button41_Click"   />
                                                    <asp:TextBox ID="TextBox147" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox147_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <hr />
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
<asp:Label ID="Label979" runat="server" Text="Number of individuals trained in Gender norm, GBV, Prevention, HTC
" CssClass="auto-style11"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox148" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
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
                                                    <asp:Label ID="Label213" runat="server" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox149" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                
                                <tr>
                                    <td><table>
                                        <tr>
                                            <td class="auto-style42 ">
                                                <asp:Label ID="Label214" runat="server" Text="Female"></asp:Label>
                                            </td>
                                            <td>
                                                 <asp:Panel ID="Panel36" runat="server" DefaultButton="Button42">
                                                         <asp:Button ID="Button42" runat="server" Text="Button" style="display:none" OnClick="Button42_Click"   />
                                                <asp:TextBox ID="TextBox150" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox150_TextChanged"></asp:TextBox>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                        </table></td>
                                </tr>
                                <tr>
                                    <td>
                                        <hr />
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label215" runat="server" Text="Number of individuals trained in commodity logistics
" CssClass="auto-style11"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox151" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="false"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td><table>
                                        <tr>
                                            <td class="auto-style42 ">
                                                <asp:Label ID="Label216" runat="server" Text="Male"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox152" runat="server" Width="52px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        </table></td>
                                </tr>
                                <tr>
                                    <td><table>
                                        <tr>
                                            <td class="auto-style42 ">
                                                <asp:Label ID="Label217" runat="server" Text="Female"></asp:Label>
                                            </td>
                                            <td>
                                                 <asp:Panel ID="Panel37" runat="server" DefaultButton="Button43">
                                                         <asp:Button ID="Button43" runat="server" Text="Button" style="display:none" OnClick="Button43_Click"   />
                                                <asp:TextBox ID="TextBox153" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox153_TextChanged"></asp:TextBox>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                        </table>

                                    </td>
                                </tr>
                            </table>
                        </asp:View>
                        <br />
                        <asp:View ID="View4" runat="server">
                            <table class="style1" style="border: thin solid #000000">
                                <tr>
                                    <td class="auto-style45" colspan="2" style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                        <asp:Label ID="Label982" runat="server" Text="Gender Norm
"></asp:Label>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">
                                        &nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                     <asp:Label ID="Label981" runat="server" Text="Number of people completing an intervention pertaining to gender norms, that meets minimum criteria
"></asp:Label>
                                                </td>
                                                <td>

                                                    <asp:TextBox ID="TextBox609" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>

                                                </td>
                                            </tr>
                                        </table>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
<asp:Label ID="Label983" runat="server" CssClass="auto-style11" Text="Males
"></asp:Label>
                                                </td>
                                                <td>
 <asp:TextBox ID="TextBox610" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label984" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label985" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1011" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1012" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1013" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox611" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox612" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox613" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox614" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel81" runat="server" DefaultButton="Button87">
                                                         <asp:Button ID="Button87" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button87_Click"   />
                                                    <asp:TextBox ID="TextBox615" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox615_TextChanged"></asp:TextBox>
                                                         </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
<asp:Label ID="Label1014" runat="server" CssClass="auto-style11" Text="Females
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox616" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1015" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1016" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1017" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1018" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1019" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox617" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox618" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox619" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox620" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel80" runat="server" DefaultButton="Button86">
                                                         <asp:Button ID="Button86" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button86_Click"   />
                                                    <asp:TextBox ID="TextBox621" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox621_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1" style="width: 62%">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1020" runat="server" style="font-weight: 700" Text="Individual
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1021" runat="server" style="font-weight: 700" Text="Small Group
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1022" runat="server" style="font-weight: 700" Text="Community Level
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox622" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox623" runat="server" Width="52px" 
                                                        ontextchanged="TextBox623_TextChanged"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    
                                                    <asp:TextBox ID="TextBox624" runat="server" Width="52px" AutoPostBack="False" 
                                                             ontextchanged="TextBox624_TextChanged"></asp:TextBox>
                                                   
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                     <asp:Label ID="Label998" runat="server" Text="Number of people receiving post-GBV care
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox625" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
                                                        <asp:Label ID="Label999" runat="server" style="font-weight: 700" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox626" BackColor="#CCCCCC" ReadOnly="false" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1023" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1024" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1025" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1026" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1027" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox627" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox628" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox629" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox630" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel78" runat="server" DefaultButton="Button84">
                                                         <asp:Button ID="Button84" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button84_Click"   />
                                                    <asp:TextBox ID="TextBox631" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox631_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
<asp:Label ID="Label1004" runat="server" style="font-weight: 700" Text="Females
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox632" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1028" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1029" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1030" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1031" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1032" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox633" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox634" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox635" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox666" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel77" runat="server" DefaultButton="Button83">
                                                         <asp:Button ID="Button83" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button83_Click"   />
                                                    <asp:TextBox ID="TextBox636" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox636_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
 <asp:Label ID="Label1033" runat="server" Text="SEXUAL Violence (Post-Rape Care)
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox637" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class ="auto-style42 " style="text-align: right">
                                                    <asp:Label ID="Label1034" runat="server" style="font-weight: 700" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox638" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1035" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1036" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1037" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1038" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1039" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox639" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox640" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox641" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox642" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                <asp:Panel ID="Panel76" runat="server" DefaultButton="Button82">
                                                         <asp:Button ID="Button82" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button82_Click"   />
                                                    <asp:TextBox ID="TextBox643" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox643_TextChanged"></asp:TextBox>
                                                </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
                                                    <asp:Label ID="Label1045" runat="server" style="font-weight: 700" Text="Females
"></asp:Label>
                                                </td>
                                                <td>
                                                      <asp:TextBox ID="TextBox644" runat="server" BackColor="#CCCCCC" ReadOnly="false"  Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                      
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1040" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1041" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1042" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1043" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1044" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox645" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox646" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox647" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox648" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel75" runat="server" DefaultButton="Button81">
                                                         <asp:Button ID="Button81" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button81_Click"   />
                                                    <asp:TextBox ID="TextBox649" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox649_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                    <asp:Label ID="Label1046" runat="server" Text="PHYSICAL and/or EMOTIONAL Violence (Other Post-GBV Care)
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox650" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                        
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
                                                     <asp:Label ID="Label1047" runat="server" style="font-weight: 700" Text="Male"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox651" runat="server" BackColor="#CCCCCC" ReadOnly="false"  Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1049" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1050" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1051" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1052" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1053" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox652" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox653" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox654" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox655" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel74" runat="server" DefaultButton="Button80">
                                                         <asp:Button ID="Button80" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button80_Click"   />
                                                    <asp:TextBox ID="TextBox656" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox656_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 " style="text-align: right">
                                                     <asp:Label ID="Label1048" runat="server" style="font-weight: 700" Text="Females
"></asp:Label>
                                                </td>
                                                <td>
                                                     <asp:TextBox ID="TextBox657" runat="server" BackColor="#CCCCCC" ReadOnly="false" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table class="style1">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1054" runat="server" Text="Age (0-9)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1055" runat="server" Text="Age (10-14)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1056" runat="server" Text="Age (15-19)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1057" runat="server" Text="Age (20-24)
"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1058" runat="server" Text="Age (25+)
"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox658" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox659" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox660" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:TextBox ID="TextBox661" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Panel ID="Panel73" runat="server" DefaultButton="Button79">
                                                         <asp:Button ID="Button79" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button79_Click"   />
                                                    <asp:TextBox ID="TextBox662" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox662_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                        <hr />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td class="auto-style42 ">
                                                     <asp:Label ID="Label1059" runat="server" Text="Number of individuals trained on gender norms and post gender based violence care
"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox663" runat="server"  ReadOnly="false" BackColor="#cccccc" Width="52px"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td style="text-align: center">
                                        <table class="style1" style="width: 33%">
                                            <tr>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1060" runat="server" style="font-weight: 700" Text="Male"></asp:Label>
                                                </td>
                                                <td class="auto-style46">
                                                    <asp:Label ID="Label1061" runat="server" style="font-weight: 700" Text="Female"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="TextBox664" runat="server" Width="52px"></asp:TextBox>
                                                </td>
                                                <td>
                                                    <asp:Panel ID="Panel72" runat="server" DefaultButton="Button78">
                                                         <asp:Button ID="Button78" runat="server" Text="Button" style="display:none" 
                                                             onclick="Button78_Click"   />
                                                    <asp:TextBox ID="TextBox665" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox665_TextChanged"></asp:TextBox>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style45">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </asp:View>
                        <br />
                        <br />
                    </asp:MultiView>
            <%--  </ContentTemplate>
                </asp:UpdatePanel>--%>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13" style="vertical-align: top">&nbsp;</td>
                <td class="auto-style5">
                   
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
       
       <%-- </div>
        </form>--%>

     <div id="showbtn" class="showbtn ";>
                    <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/image/Submit.png" 
                        OnClick="btnSave_Click" />
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/Clear1.png" OnClick="ImageButton1_Click" Visible="false" />
                    </div>
</asp:Content>

