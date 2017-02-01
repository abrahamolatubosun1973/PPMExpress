<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDrop.aspx.cs" Inherits="TestDrop" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 79%;
            height: 103px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 34px;
        }
    </style>
   
</head>
<body>
   <form id="form1" runat="server">
<div style="text-align: center">
    <div style="background-color: Aqua; width: 250px;">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </cc1:ToolkitScriptManager>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:PlaceHolder runat="server" ID="myPlaceHolder"></asp:PlaceHolder>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddTextBox" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
    <br />
    </div>
    <br />
    <asp:Button ID="btnAddTextBox" runat="server"  Text="Add TextBox" OnClick="btnAddTextBox_Click" />
    <br /><br />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Button runat="server" ID="MyButton" Text="Get Values." OnClick="MyButton_Click" />
            <br /><br />
            <asp:Label runat="server" ID="MyLabel"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>

    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="border:1px solid black; font-family:Arial;">
                    <tr>
                        <td>
                            <b>Select Chart Type :</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" AutoPostBack="true"  runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                        </td>
                        
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Chart ID="Chart1" runat="server" Height="500px" Width="656px">
                                <Legends>
                                    <asp:Legend Name="Legend1">
                                    </asp:Legend>
                                </Legends>
                                <Titles>
                                    <asp:Title Text="Total Marks of Student"></asp:Title>
                                </Titles>
                                
                                <Series>
                                    <asp:Series Name="Series1" ChartType="Pie" ChartArea="ChartArea1" 
                                        Legend="Legend1">
                                        <%--<Points>
                                            <asp:DataPoint AxisLabel ="Mark" YValues="800" />
                                            <asp:DataPoint AxisLabel ="Muri" YValues="850" />
                                            <asp:DataPoint AxisLabel ="Linus" YValues="700" />
                                            <asp:DataPoint AxisLabel ="John" YValues="300" />
                                            <asp:DataPoint AxisLabel ="Paul" YValues="200" />
                                            <asp:DataPoint AxisLabel ="Abraham" YValues="1800" />
                                        </Points>--%>

                                    </asp:Series>
                                  <%--  <asp:Series Name="Series2" ChartType="Column" ChartArea="ChartArea1">
                                    </asp:Series>--%>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                        
                                        <AxisX Title="Student Name"></AxisX>
                                        <AxisY Title="Marks"></AxisY>
                                        <Area3DStyle Enable3D="True" Inclination="50" />
                                    </asp:ChartArea>
                                </ChartAreas>
                         </asp:Chart>
                        </td>

                    </tr>
                </table>
                


                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" PopupButtonID="TextBox1" TargetControlID="TextBox1" PopupPosition="Right"></cc1:CalendarExtender>

                

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2">
                <asp:Panel ID="Panel1" runat="server" align="center" style="display:none">
                    The Boy is Ok
                    <asp:Button ID="btnClose" runat="server" Text="Close" />
                </asp:Panel>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnChart" runat="server" onclick="btnChart_Click" 
                    Text="Display Chart" />
                <asp:Button ID="btnShow" runat="server" Text="Show Popup" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>        
                <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" 
                    PopupControlID="Panel1" TargetControlID="btnShow" DropShadow="true" 
                    CancelControlID="btnClose" >
                </cc1:ModalPopupExtender> 
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
     <div id="chartContainer" style="height: 500px; width: 50%;"></div>
 </div>
</form>
</body>
</html>
