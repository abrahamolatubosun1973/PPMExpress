<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
        .style1 {
            width: 517px;
        }
    </style>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Css/myTest.css" rel="stylesheet" />
</head>
<body style="margin-top:0; margin-left:0;">
    <form id="form1" runat="server">
  <div class=" navbar navbar-default navbar-fixed-top">
   <table style="width: 1224px" class="table-condensed table-responsive">
       <tr>
           <td>
              
                <div class="left" >
                    <asp:Image ID="Image1" runat="server" Height="96px" 
                        ImageUrl="~/image/unnamed.jpg" Width="489px" />

                    </div>
           </td>
          
       </tr>
        <tr>
             <td>
               <div class =" alignme">
                        <a href="DataEntries.aspx">| Home |</a>
                        <a href="Default.aspx"> DashBoard|</a>
                    </div>
           </td>
        </tr>
   </table>
      </div>
        <hr />
       
                    

     <table style="width: 1230px">
    <tr>
        <td>
            

            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            

        </td>
    </tr>
    <tr>
        <td>
            <table style="border-style: solid; width: 90%; margin-top:60px;" class="table-condensed table-responsive">
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
                        <asp:Panel ID="Panel2" runat="server" GroupingText="Thematic Area Summary Chart" Height="124px">
                            <table class="style1">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label123" runat="server" Text="Month :"></asp:Label>
                                        <asp:DropDownList ID="drpMnth1" runat="server" Width="20%">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label124" runat="server" Text="Year :"></asp:Label>
                                        &nbsp;&nbsp;
                                        <asp:DropDownList ID="drpYear" runat="server" AutoPostBack="True">
                                        </asp:DropDownList>
                                        <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel3">
                                            <ProgressTemplate>
                                                <img src="image/bar-ajax-loader.gif" style="height: 16px; width: 137px" />
                                                <%--<div style="width:101px; height:20px;"></div>--%>
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                         <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                        <asp:Label ID="Label122" runat="server" Text="Thematic Area :"></asp:Label>
                                        <asp:DropDownList ID="drpThematic" runat="server" Width="60%" AutoPostBack="True" OnSelectedIndexChanged="drpThematic_SelectedIndexChanged">
                                        </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
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
                    &nbsp;(HTC)</td>
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
                    <td rowspan="9" style="vertical-align: top">
                        <asp:Panel ID="Panel1" runat="server" GroupingText="Data Exchange Section" Height="296px">
                            <table style=" width:100%">
                                <tr>
                                    <td>
                                         <asp:Label ID="Label120" runat="server" Text="State Name :"></asp:Label>
                                        <asp:TextBox ID="TextBox15" runat="server" Width="82px"></asp:TextBox>
                                    </td>
                                    <td>
                                         <asp:Label ID="Label121" runat="server" Text="Month :"></asp:Label>
                                        
                                         <asp:DropDownList ID="drpMnth2" runat="server" Width="120px">
                                         </asp:DropDownList>
                                        
                                    </td>
                                </tr>
                                <tr>
                                   <td colspan="2" style="text-align: center">
                                     <asp:Button ID="btnExport" runat="server" Text="Export Database in Xml" OnClick="btnExport_Click"  />
                                   </td>
                                </tr>
                            </table>
                           
                            <hr />
                            <asp:Label ID="Label16" runat="server" Text="Data Onboarding Section :" style="font-weight: 700"></asp:Label>
                            <hr />
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="249px" />
                            &nbsp;
                            <%--<asp:UpdatePanel ID="UpdatePanel4" runat="server">
                              <ContentTemplate>--%>
                                   <br />
                                   <asp:Button ID="btnImportXml" runat="server" Text="Import Data from Xml" OnClick="btnImportXml_Click"  />
                             <%-- </ContentTemplate>
                           </asp:UpdatePanel>--%>
                             
                         <%-- <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel4">
                             <ProgressTemplate>
                                  <img src="image/bar-ajax-loader.gif" style="height: 16px; width: 137px" />
                              </ProgressTemplate>
                            </asp:UpdateProgress>--%>
                           <br /><br />
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Erase entire database ?" />
                            <asp:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" BehaviorID="Button1_ConfirmButtonExtender" ConfirmText="This is Critical, your entire data's will be lost, are you sure ?" TargetControlID="Button1">
                            </asp:ConfirmButtonExtender>
                           
                            
                           
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
                </table>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>
     <div id="lcenter" 
                        style="font-family: 'Times New Roman', Times, serif; font-size: small; text-align: center; background-color: #C0C0C0; color: #800000; font-weight: bold;">
                    Copyright &copy; 2015 | Property of Excellence Commuinty Education Walfare Scheme (ECEWS )
    </div>                        
    </form>
</body>
</html>
