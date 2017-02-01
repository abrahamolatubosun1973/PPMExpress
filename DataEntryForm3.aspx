<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DataEntryForm3.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

         .auto-style42 {
            width: 683px;
            background-color: #FFFFFF;
        }
        .auto-style45 {
            font-weight: bold;
            /*background-color: #CC3300;*/
        }
        .auto-style43 {
            width: 683px;
            background-color: #FFFFFF;
            height: 26px;
        }
        .auto-style44 {
            height: 26px;
        }
        .auto-style46 {
            color: silver;
        }
        .auto-style47 {
            color: #000000;
        }
        .auto-style18 {
            width: 959px;
        }
         .auto-style11 {
            font-weight: bold;
        }
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblThematic" runat="server" style="font-weight: 700"></asp:Label></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <%--<asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>--%>
                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View5" runat="server">
                                <table class="style1" style="border-style: solid; border-width: thin">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label321" runat="server" Text="TB/HIV INTEGRATION
"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label325" runat="server" Text="Number of TB patients (new and relapsed TB cases) and TB suspects who received C&amp;T for HIV and received their test results at a USG supported TB service outlet 
"></asp:Label>
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
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label326" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox331" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label327" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label328" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label329" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label330" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label331" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label332" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label333" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label334" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox332" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox333" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox334" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox335" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox336" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox337" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox338" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel48" runat="server" DefaultButton="Button48">
                                                            <asp:Button ID="Button48" runat="server" OnClick="Button48_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox339" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
                                                            &nbsp;</asp:Panel>
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
                                                        <asp:Label ID="Label343" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox348" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label335" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label336" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label337" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label338" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label339" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label340" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label341" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label342" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox340" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox341" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox342" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox343" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox344" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox345" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox346" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel49" runat="server" DefaultButton="Button49">
                                                            <asp:Button ID="Button49" runat="server" OnClick="Button49_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox347" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label344" runat="server" CssClass="auto-style45" Text="Positive"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox349" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label345" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox350" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label346" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label347" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label348" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label349" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label350" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label351" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label352" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label353" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox351" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox352" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox353" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox354" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox355" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox356" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox357" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel50" runat="server" DefaultButton="Button50">
                                                            <asp:Button ID="Button50" runat="server" OnClick="Button50_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox358" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label354" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox359" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label355" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label356" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label357" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label358" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label359" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label360" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label361" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label362" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox360" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox361" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox362" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox363" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox364" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox365" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox366" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel51" runat="server" DefaultButton="Button51">
                                                            <asp:Button ID="Button51" runat="server" OnClick="Button51_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox367" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label363" runat="server" CssClass="auto-style45" Text="Nagetive"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox368" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label364" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox369" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label365" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label366" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label367" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label368" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label369" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label370" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label371" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label372" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox370" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox371" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox372" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox373" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox374" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox375" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox376" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel52" runat="server" DefaultButton="Button52">
                                                            <asp:Button ID="Button52" runat="server" OnClick="Button52_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox377" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label373" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox378" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label374" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label375" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label376" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label377" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label378" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label379" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label380" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label381" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox379" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox380" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox381" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox382" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox383" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox384" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox385" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel53" runat="server" DefaultButton="Button53">
                                                            <asp:Button ID="Button53" runat="server" OnClick="Button53_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox386" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label382" runat="server" Text="Number of TB patients (new and relapsed TB cases) who received C&amp;T for HIV and received their test results at a USG supported TB service outlet "></asp:Label>
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
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label383" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox388" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label385" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label386" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label387" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label388" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label389" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label390" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label391" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label392" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox390" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox391" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox392" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox393" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox394" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox395" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox396" runat="server" Height="22px" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel54" runat="server" DefaultButton="Button54">
                                                            <asp:Button ID="Button54" runat="server" OnClick="Button54_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox397" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label384" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox389" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label393" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label394" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label395" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label396" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label397" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label398" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label399" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label400" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox398" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox399" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox400" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox401" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox402" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox403" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox404" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel55" runat="server" DefaultButton="Button55">
                                                            <asp:Button ID="Button55" runat="server" OnClick="Button55_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox405" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label401" runat="server" CssClass="auto-style45" Text="Positive"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox406" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label402" runat="server" style="color: #000000" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox407" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label403" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label404" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label405" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label406" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label407" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label408" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label409" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label410" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox408" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox409" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox410" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox411" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox412" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox413" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox414" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel56" runat="server" DefaultButton="Button56">
                                                            <asp:Button ID="Button56" runat="server" OnClick="Button56_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox415" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label419" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox424" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label411" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label412" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label413" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label414" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label415" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label416" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label417" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label418" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox416" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox417" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox418" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox419" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox420" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox421" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox422" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel57" runat="server" DefaultButton="Button57">
                                                            <asp:Button ID="Button57" runat="server" OnClick="Button57_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox423" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label420" runat="server" CssClass="auto-style45" Text="Negative"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox425" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label421" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox426" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label422" runat="server" style="color: #000000" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label423" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label424" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label425" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label426" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label427" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label428" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label429" runat="server" style="color: #000000" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox427" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox428" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox429" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox430" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox431" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox432" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox433" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel58" runat="server" DefaultButton="Button58">
                                                            <asp:Button ID="Button58" runat="server" OnClick="Button58_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox434" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label438" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox443" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label430" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label431" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label432" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label433" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label434" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label435" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label436" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label437" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox435" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox436" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox437" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox438" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox439" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox440" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox441" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel59" runat="server" DefaultButton="Button59">
                                                            <asp:Button ID="Button59" runat="server" OnClick="Button59_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox442" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label439" runat="server" Text="The number of registered new and relapse TB cases with documented HIV-positive status during TB treatment during the reporting period
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox444" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label440" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox445" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label441" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label442" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label443" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label444" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label445" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label446" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label447" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label448" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox446" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox447" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox448" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox449" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox450" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox451" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox452" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel60" runat="server" DefaultButton="Button60">
                                                            <asp:Button ID="Button60" runat="server" OnClick="Button60_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox453" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label449" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox454" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label450" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label451" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label452" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label453" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label454" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label455" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label456" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label457" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox455" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox456" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox457" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox458" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox459" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox460" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox461" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel61" runat="server" DefaultButton="Button61">
                                                            <asp:Button ID="Button61" runat="server" OnClick="Button61_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox462" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label458" runat="server" Text="The number of registered new and relapse TB cases with documented HIV-positive status who are on ART during TB treatment during the reporting period."></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox463" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label459" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox464" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label460" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label461" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label462" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label463" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label464" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label465" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label466" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label467" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox465" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
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
                                                        <asp:TextBox ID="TextBox469" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox470" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox471" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel62" runat="server" DefaultButton="Button62">
                                                            <asp:Button ID="Button62" runat="server" OnClick="Button62_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox472" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label476" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox481" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label468" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label469" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label470" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label471" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label472" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label473" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label474" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label475" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox473" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox474" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox475" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox476" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox477" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox478" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox479" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel63" runat="server" DefaultButton="Button63">
                                                            <asp:Button ID="Button63" runat="server" OnClick="Button63_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox480" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label477" runat="server" Text="Known HIV positive clients who commenced ART while on TB treatment during the reporting period"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox482" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label478" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox483" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label480" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label481" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label482" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label483" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label484" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label485" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label486" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label487" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox485" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox486" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox487" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox488" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox489" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox490" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox491" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel64" runat="server" DefaultButton="Button64">
                                                            <asp:Button ID="Button64" runat="server" OnClick="Button64_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox492" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label479" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox484" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label488" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label489" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label490" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label491" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label492" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label493" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label494" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label495" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox493" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox494" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox495" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox496" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox497" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox498" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox499" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel65" runat="server" DefaultButton="Button65">
                                                            <asp:Button ID="Button65" runat="server" OnClick="Button65_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox500" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label496" runat="server" Text="New HIV positive clients who commenced ART while on TB treatment during the reporting period"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox501" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label497" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox502" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label499" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label500" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label501" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label502" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label503" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label504" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label505" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label506" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox504" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox505" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox506" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox507" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox508" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox509" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox510" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel66" runat="server" DefaultButton="Button66">
                                                            <asp:Button ID="Button66" runat="server" OnClick="Button66_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox511" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label498" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox503" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label507" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label508" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label509" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label510" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label511" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label512" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label513" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label514" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox512" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox513" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox514" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox515" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox516" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox517" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox518" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel67" runat="server" DefaultButton="Button67">
                                                            <asp:Button ID="Button67" runat="server" OnClick="Button67_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox519" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label515" runat="server" Text="ART initiation &lt;= 8 weeks of start of TB treatment"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox520" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label516" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox521" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label518" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label519" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label520" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label521" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label522" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label523" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label524" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label525" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox523" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox524" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox525" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox526" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox527" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox528" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox529" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel68" runat="server" DefaultButton="Button68">
                                                            <asp:Button ID="Button68" runat="server" OnClick="Button68_Click" Style="display:none; height: 26px; width: 56px;" Text="Button" />
                                                            <asp:TextBox ID="TextBox530" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label517" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox522" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:TextBox ID="TextBox531" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox532" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox533" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox534" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox535" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox536" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox537" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel69" runat="server" DefaultButton="Button69">
                                                            <asp:Button ID="Button69" runat="server" OnClick="Button69_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox538" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label534" runat="server" Text="ART initiation &gt; 8 weeks of start of TB treatment"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox539" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label535" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox540" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label537" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label538" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label539" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label540" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label541" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label542" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label543" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label544" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox542" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox543" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox544" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox545" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox546" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox547" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox548" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel70" runat="server" DefaultButton="Button70">
                                                            <asp:Button ID="Button70" runat="server" OnClick="Button70_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox549" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label536" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox541" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label545" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label546" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label547" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label548" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label549" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label550" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label551" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label552" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox550" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox551" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox552" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox553" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox554" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox555" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox556" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel71" runat="server" DefaultButton="Button71">
                                                            <asp:Button ID="Button71" runat="server" OnClick="Button71_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox557" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <%--==================================--%>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label781" runat="server" Text="The total number of registered new and relapsed TB cases who are HIV-positive registered in the treatment cohort
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox777" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label782" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox778" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr class="auto-style46">
                                                    <td>
                                                        <asp:Label ID="Label783" runat="server" CssClass="auto-style47" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label784" runat="server" CssClass="auto-style47" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label785" runat="server" CssClass="auto-style47" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label786" runat="server" CssClass="auto-style47" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label787" runat="server" CssClass="auto-style47" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label788" runat="server" CssClass="auto-style47" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label789" runat="server" CssClass="auto-style47" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label790" runat="server" CssClass="auto-style47" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox779" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox780" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox781" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox782" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox783" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox784" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox785" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel72" runat="server" DefaultButton="Button72">
                                                            <asp:Button ID="Button72" runat="server" OnClick="Button72_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox786" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label791" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox787" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr class="auto-style46">
                                                    <td>
                                                        <asp:Label ID="Label792" runat="server" CssClass="auto-style47" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label793" runat="server" CssClass="auto-style47" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label794" runat="server" CssClass="auto-style47" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label795" runat="server" CssClass="auto-style47" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label796" runat="server" CssClass="auto-style47" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label797" runat="server" CssClass="auto-style47" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label798" runat="server" CssClass="auto-style47" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label799" runat="server" CssClass="auto-style47" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox788" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox789" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox790" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox791" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox792" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox793" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox794" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel73" runat="server" DefaultButton="Button73">
                                                            <asp:Button ID="Button73" runat="server" OnClick="Button73_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox795" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <%--===================================--%>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label553" runat="server" Text="Number of outcomes of TB treatment among registered new and relapsed TB cases who are HIV-positive in the treatment cohort"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox558" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label554" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox559" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label555" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label556" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label557" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label558" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label559" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label560" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label561" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label562" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox560" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox561" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox562" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox563" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox564" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox565" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox566" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel74" runat="server" DefaultButton="Button74">
                                                            <asp:Button ID="Button74" runat="server" OnClick="Button74_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox567" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label571" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox576" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label563" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label564" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label565" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label566" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label567" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label568" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label569" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label570" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox568" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox569" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox570" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox571" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox572" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox573" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox574" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel75" runat="server" DefaultButton="Button75">
                                                            <asp:Button ID="Button75" runat="server" OnClick="Button75_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox575" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label572" runat="server" Text="Cured
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox577" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label573" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox578" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label574" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label575" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label576" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label577" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label578" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label579" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label580" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label581" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox579" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox580" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox581" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox582" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox583" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox584" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox585" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel76" runat="server" DefaultButton="Button76">
                                                            <asp:Button ID="Button76" runat="server" OnClick="Button76_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox586" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label590" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox595" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label582" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label583" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label584" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label585" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label586" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label587" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label588" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label589" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox587" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox588" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox589" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox590" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox591" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox592" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox593" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel77" runat="server" DefaultButton="Button77">
                                                            <asp:Button ID="Button77" runat="server" OnClick="Button77_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox594" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label591" runat="server" Text="Treatment Completed"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox596" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label592" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox597" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label593" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label594" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label595" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label596" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label597" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label598" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label599" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label600" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox598" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox599" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox600" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox601" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox602" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox603" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox604" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel78" runat="server" DefaultButton="Button78">
                                                            <asp:Button ID="Button78" runat="server" OnClick="Button78_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox605" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label601" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox606" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label602" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label603" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label604" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label605" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label606" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label607" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label608" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label609" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox607" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox608" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox609" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox610" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox611" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox612" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox613" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel79" runat="server" DefaultButton="Button79">
                                                            <asp:Button ID="Button79" runat="server" OnClick="Button79_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox614" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label610" runat="server" Text="Treatment Failed
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox615" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label611" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox616" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label612" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label613" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label614" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label615" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label616" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label617" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label618" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label619" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox620" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox621" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox622" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox623" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel80" runat="server" DefaultButton="Button80">
                                                            <asp:Button ID="Button80" runat="server" OnClick="Button80_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox624" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label628" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox633" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label620" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label621" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label622" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label623" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label624" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label625" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label626" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label627" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox629" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox630" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox631" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel81" runat="server" DefaultButton="Button81">
                                                            <asp:Button ID="Button81" runat="server" OnClick="Button81_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox632" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label629" runat="server" Text="Died
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox634" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label630" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox635" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label631" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label632" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label633" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label634" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label635" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label636" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label637" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label638" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox639" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox640" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox641" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox642" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel82" runat="server" DefaultButton="Button82">
                                                            <asp:Button ID="Button82" runat="server" onclick="Button82_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox643" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label639" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox644" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label640" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label641" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label642" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label643" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label644" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label645" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label646" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label647" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox648" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox649" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox650" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox651" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel83" runat="server" DefaultButton="Button83">
                                                            <asp:Button ID="Button83" runat="server" Style="display:none" Text="Button" OnClick="Button83_Click" />
                                                            <asp:TextBox ID="TextBox652" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label648" runat="server" Text="Lost to Follow-Up
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox653" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label649" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox654" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label650" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label651" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label652" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label653" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label654" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label655" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label656" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label657" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox658" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox659" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox660" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox661" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel84" runat="server" DefaultButton="Button84">
                                                            <asp:Button ID="Button84" runat="server" Style="display:none" Text="Button" OnClick="Button84_Click" />
                                                            <asp:TextBox ID="TextBox662" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label666" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox671" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label658" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label659" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label660" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label661" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label662" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label663" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label664" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label665" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox667" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox668" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox669" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel85" runat="server" DefaultButton="Button85">
                                                            <asp:Button ID="Button85" runat="server" Style="display:none" Text="Button" OnClick="Button85_Click" />
                                                            <asp:TextBox ID="TextBox670" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label667" runat="server" Text="Not Evaluated
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox672" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label668" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox673" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label670" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label671" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label672" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label673" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label674" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label675" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label676" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label677" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox675" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox676" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox677" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox678" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
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
                                                        <asp:Panel ID="Panel86" runat="server" DefaultButton="Button86">
                                                            <asp:Button ID="Button86" runat="server" Style="display:none" Text="Button" OnClick="Button86_Click" />
                                                            <asp:TextBox ID="TextBox682" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label669" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox674" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label678" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label679" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label680" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label681" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label682" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label683" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label684" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label685" runat="server" style="color: #000000" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox686" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox687" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox688" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox689" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel87" runat="server" DefaultButton="Button87">
                                                            <asp:Button ID="Button87" runat="server" Style="display:none" Text="Button" OnClick="Button87_Click" />
                                                            <asp:TextBox ID="TextBox690" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label686" runat="server" Text="Number of PLHIV who were screened for TB symptoms at the last clinical visit to an HIV care facility during the reporting period.
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox691" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label687" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox692" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label689" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label690" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label691" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label692" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label693" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label694" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label695" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label696" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox694" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox695" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox696" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox697" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
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
                                                        <asp:Panel ID="Panel88" runat="server" DefaultButton="Button88">
                                                            <asp:Button ID="Button88" runat="server" Style="display:none" Text="Button" OnClick="Button88_Click" />
                                                            <asp:TextBox ID="TextBox701" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label688" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox693" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label697" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label698" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label699" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label700" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label701" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label702" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label703" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label704" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox705" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox706" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox707" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox708" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel89" runat="server" DefaultButton="Button89">
                                                            <asp:Button ID="Button89" runat="server" Style="display:none" Text="Button" OnClick="Button89_Click" />
                                                            <asp:TextBox ID="TextBox709" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label705" runat="server" Text="Number of of TB suspects identified among people living with HIV/AIDS (PLHIV)
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox710" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label706" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox711" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label708" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label709" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label710" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label711" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label712" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label713" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label714" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label715" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox713" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox714" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox715" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox716" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
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
                                                        <asp:Panel ID="Panel90" runat="server" DefaultButton="Button90">
                                                            <asp:Button ID="Button90" runat="server" Style="display:none" Text="Button" OnClick="Button90_Click" />
                                                            <asp:TextBox ID="TextBox720" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label707" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox712" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label716" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label717" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label718" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label719" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label720" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label721" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label722" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label723" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
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
                                                        <asp:TextBox ID="TextBox724" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox725" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox726" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox727" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel91" runat="server" DefaultButton="Button91">
                                                            <asp:Button ID="Button91" runat="server" Style="display:none" Text="Button" OnClick="Button91_Click" />
                                                            <asp:TextBox ID="TextBox728" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label724" runat="server" Text="Number of confirmed TB cases among suspects screened
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox729" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label725" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox730" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label727" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label728" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label729" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label730" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label731" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label732" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label733" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label734" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox307" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox308" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox309" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox310" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox311" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox312" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox313" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel92" runat="server" DefaultButton="Button92">
                                                            <asp:Button ID="Button92" runat="server" Style="display:none" Text="Button" OnClick="Button92_Click" />
                                                            <asp:TextBox ID="TextBox314" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label726" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox731" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label735" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label736" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label737" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label738" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label739" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label740" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label741" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label742" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox315" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox732" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox733" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox734" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox735" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox736" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox737" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel93" runat="server" DefaultButton="Button93">
                                                            <asp:Button ID="Button93" runat="server" Style="display:none" Text="Button" OnClick="Button93_Click" />
                                                            <asp:TextBox ID="TextBox738" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label743" runat="server" Text=" Number of HIV-positive patients (pre-ART or ART) who started TB treatment
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox739" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label744" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox740" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label745" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label746" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label747" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label748" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label749" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label750" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label751" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label752" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox741" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox742" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox743" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox744" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox745" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox746" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox747" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel94" runat="server" DefaultButton="Button94">
                                                            <asp:Button ID="Button94" runat="server" Style="display:none" Text="Button" OnClick="Button94_Click" />
                                                            <asp:TextBox ID="TextBox748" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label753" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox749" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label754" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label755" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label756" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label757" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label758" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label759" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label760" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label761" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox750" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox751" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox752" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox753" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox754" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox755" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox756" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel95" runat="server" DefaultButton="Button95">
                                                            <asp:Button ID="Button95" runat="server" Style="display:none" Text="Button" OnClick="Button95_Click" />
                                                            <asp:TextBox ID="TextBox757" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label762" runat="server" Text="Number of  PLHIV newly enrolled in HIV clinical care who started IPT during the reporting period.
"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox758" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label763" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox759" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label765" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label766" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label767" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label768" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label769" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label770" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label771" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label772" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox761" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox762" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox763" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox764" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox765" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox766" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox767" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel96" runat="server" DefaultButton="Button96">
                                                            <asp:Button ID="Button96" runat="server" Style="display:none" Text="Button" OnClick="Button96_Click" />
                                                            <asp:TextBox ID="TextBox768" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style43">
                                                        <asp:Label ID="Label764" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="TextBox760" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label773" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label774" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label775" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label776" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label777" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label778" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label779" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label780" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox769" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox770" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox771" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox772" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox773" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox774" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox775" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel97" runat="server" DefaultButton="Button97">
                                                            <asp:Button ID="Button97" runat="server" OnClick="Button97_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox776" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <asp:View ID="View6" runat="server">
                                <table class="style1" style="border: thin solid #000000">
                                    <tr>
                                        <td colspan="2" style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label1062" runat="server" Text="LABORATORY SERVICES
"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Label ID="Label1063" runat="server" Text="No of Dry Blood Samples (DBS) collected 
"></asp:Label>
                                            <asp:TextBox ID="TextBox796" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td align="center" style="text-align:center;">
                                            <table class="style1" style="height: 57px; width: 42%">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1064" runat="server" CssClass="auto-style11" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox797" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1352" runat="server" CssClass="auto-style11" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox798" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1065" runat="server" Text="&lt; 2 Mths
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox799" runat="server"  Width="52px" AutoPostBack="True" OnTextChanged="TextBox799_TextChanged"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1353" runat="server" Text="&lt; 2 Mths
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox800" runat="server"   Width="52px" AutoPostBack="True" OnTextChanged="TextBox800_TextChanged"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1066" runat="server" Text="2-12 Mths
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel98" runat="server" DefaultButton="Button1">
                                                            <asp:Button ID="Button1" runat="server" Text="Button" Style="display:none" OnClick="Button1_Click" />
                                                            <asp:TextBox ID="TextBox801" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label1354" runat="server" Text="2-12 Mths
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel99" runat="server" DefaultButton="Button2">
                                                            <asp:Button ID="Button2" runat="server" Text="Button" Style="display:none" OnClick="Button2_Click" />
                                                            <asp:TextBox ID="TextBox802" runat="server"   Width="52px" OnTextChanged="TextBox802_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1067" runat="server" Text="Number of patients newly enrolled into HIV care
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox803" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1068" runat="server" Text="Males
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox804" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1069" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1070" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1071" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1072" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1073" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1074" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1075" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1076" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox805" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox806" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox807" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox808" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox809" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox810" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox811" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel100" runat="server" DefaultButton="Button3">
                                                            <asp:Button ID="Button3" runat="server" Style="display:none" Text="Button" OnClick="Button3_Click" />
                                                            <asp:TextBox ID="TextBox812" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1077" runat="server" Text="Females
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox813" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1078" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1079" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1080" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1081" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1082" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1083" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1084" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1085" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox814" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox815" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox816" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox817" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox818" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox819" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox820" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel101" runat="server" DefaultButton="Button4">
                                                            <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox821" runat="server" AutoPostBack="False"   Width="52px" OnTextChanged="TextBox821_TextChanged"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1086" runat="server" Text="Number of patients newly enrolled into HIV care who had CD4 test done.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox158" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1087" runat="server" Text="Males
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox159" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1089" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1090" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1091" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1092" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1093" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1094" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1095" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1096" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox160" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox161" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox162" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox163" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox164" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox165" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox166" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel102" runat="server" DefaultButton="Button5">
                                                            <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox167" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1088" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox168" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1097" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1098" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1099" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1100" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1101" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1102" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1103" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1104" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox169" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox170" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox171" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox172" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox173" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox174" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox175" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel103" runat="server" DefaultButton="Button6">
                                                            <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox176" runat="server" AutoPostBack="False"  style="color: #000000" Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1105" runat="server" Text="Number of patients newly enrolled into HIV care who had CD4 &lt;500 and initiated on HAART.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox177" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1106" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox178" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1108" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1109" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1110" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1111" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1112" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1113" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1114" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1115" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox179" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox180" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox181" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox182" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox183" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox184" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox185" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel104" runat="server" DefaultButton="Button7">
                                                            <asp:Button ID="Button7" runat="server" onclick="Button7_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox186" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1107" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox187" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1116" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1117" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1118" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1119" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1120" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1121" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1122" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1123" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox188" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox189" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox190" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox191" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox192" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox193" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox194" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center" >
                                                        <asp:Panel ID="Panel105" runat="server" DefaultButton="Button8">
                                                            <asp:Button ID="Button8" runat="server" onclick="Button8_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox195" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1124" runat="server" Text="Number of patients newly enrolled into HIV care who had CD4 &lt;500 and initiated on HAART.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox196" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1125" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox197" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1127" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1128" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1129" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1130" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1131" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1132" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1133" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1134" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox198" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox199" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox200" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox201" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox202" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox203" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox204" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel106" runat="server" DefaultButton="Button9">
                                                            <asp:Button ID="Button9" runat="server" onclick="Button9_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox205" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1126" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox206" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1135" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1136" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1137" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1138" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1139" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1140" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1141" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1142" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox207" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox208" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox209" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox210" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox211" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox212" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox213" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel107" runat="server" DefaultButton="Button10">
                                                            <asp:Button ID="Button10" runat="server" onclick="Button10_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox214" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1143" runat="server" Text="Number of patients identified in the ART Clinic for repeat CD4 count                                       
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox215" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1144" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox216" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1146" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1147" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1148" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1149" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1150" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1151" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1152" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1153" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox217" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center; margin-left: 40px;">
                                                        <asp:TextBox ID="TextBox218" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox219" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox220" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox221" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox222" runat="server" Height="22px" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox223" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel108" runat="server" DefaultButton="Button11">
                                                            <asp:Button ID="Button11" runat="server" onclick="Button11_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox224" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1145" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox225" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1154" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1155" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1156" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1157" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1158" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1159" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1160" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1161" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox226" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox227" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox228" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox229" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox230" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox231" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox232" runat="server" Width="52px" OnTextChanged="TextBox232_TextChanged"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel109" runat="server" DefaultButton="Button12">
                                                            <asp:Button ID="Button12" runat="server" onclick="Button12_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox233" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label218" runat="server" Text="Number of patients identified in the ART Clinic who had repeat CD4 done                                      
                                                    "></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox154" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <%-- ==== MALE ENTRY====--%>
                                        <td></td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label219" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox155" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <%-- ====== AGE AGGREGATION FOR MALE ===--%>
                                        <td></td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label220" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label221" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label222" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label223" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label224" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label225" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label226" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label227" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox156" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox157" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox239" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox247" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox822" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox823" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox824" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel110" runat="server" DefaultButton="Button13">
                                                            <asp:Button ID="Button13" runat="server" onclick="Button13_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox825" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <%-- ===== FEMALE ENTRY ====--%>
                                        <td>
                                            <td>
                                                <table>
                                                    <tr>
                                                        <td class="auto-style42 ">
                                                            <asp:Label ID="Label228" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox826" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <%--====== AGE DISAGGREGATION FOR FEMALE =====--%>
                                        <td></td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label229" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label230" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label231" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label232" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label233" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label234" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label235" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label236" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox827" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox828" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox829" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox830" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox831" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox832" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox833" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel111" runat="server" DefaultButton="Button14">
                                                            <asp:Button ID="Button14" runat="server" onclick="Button14_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox834" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1162" runat="server" Text="Number  of patients with repeat CD4 count less than 500                    
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox234" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1163" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td style="background-color: #FFFFFF">
                                                        <asp:TextBox ID="TextBox235" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1165" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1166" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1167" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1168" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1169" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1170" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1171" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1172" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox236" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox237" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox238" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <%--<asp:TextBox ID="TextBox239" runat="server" Width="52px"></asp:TextBox>
                                                </td>--%>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox240" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox241" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox242" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox243" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel112" runat="server" DefaultButton="Button15">
                                                            <asp:Button ID="Button15" runat="server" onclick="Button15_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox835" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1164" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox244" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1173" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1174" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1175" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1176" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1177" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1178" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1179" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1180" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox245" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox246" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <%--<asp:TextBox ID="TextBox247" runat="server" Width="52px"></asp:TextBox>
                                                </td>--%>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox248" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox249" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox250" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox251" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox252" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel113" runat="server" DefaultButton="Button16">
                                                            <asp:Button ID="Button16" runat="server" onclick="Button16_Click" Style="display:none" Text="Button" Height="27px" />
                                                            <asp:TextBox ID="TextBox836" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1181" runat="server" Text="Number  of patients with repeat CD4 count less than 500  placed on HAART                  
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox253" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1182" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox254" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1184" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1185" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1186" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1187" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1188" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1189" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1190" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1191" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox255" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox256" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox257" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox258" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox259" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox260" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox261" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel114" runat="server" DefaultButton="Button17">
                                                            <asp:Button ID="Button17" runat="server" onclick="Button17_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox262" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1183" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox263" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1192" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1193" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1194" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1195" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1196" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1197" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1198" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1199" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox264" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox265" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox266" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox267" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox268" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox284" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox285" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center;">
                                                        <asp:Panel ID="Panel115" runat="server" DefaultButton="Button18">
                                                            <asp:Button ID="Button18" runat="server" onclick="Button18_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox286" runat="server" AutoPostBack="False" Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1200" runat="server" style="background-color: #FFFFFF" Text="No. of units of blood collected and screened for all the four TTI (HBV, HCV, HIV, Syphilis)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox287" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1201" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox288" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1203" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1204" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1205" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1206" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1207" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1208" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1209" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1210" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox289" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox290" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox291" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox292" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox293" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox294" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox295" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel116" runat="server" DefaultButton="Button19">
                                                            <asp:Button ID="Button19" runat="server" onclick="Button19_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox296" runat="server" AutoPostBack="False"   style="height: 22px" Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1202" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox297" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1211" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1212" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1213" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1214" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1215" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1216" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1217" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1218" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox298" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox299" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox300" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox301" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox302" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox303" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox304" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel117" runat="server" DefaultButton="Button20">
                                                            <asp:Button ID="Button20" runat="server" onclick="Button20_Click" style="display:none; height: 26px; width: 56px;" Text="Button" />
                                                            <asp:TextBox ID="TextBox305" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1219" runat="server" Text="No. of units of blood collected and screened for all the four TTI (HBV, HCV, HIV, Syphilis) that are identfied as reactive for HIV
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox306" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1220" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox837" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1222" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1223" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1224" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1225" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1226" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1227" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1228" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1229" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox838" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox839" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox840" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox841" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox842" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <%--<asp:TextBox ID="TextBox313" runat="server" Width="52px"></asp:TextBox>
                                                </td>--%>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox843" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox844" runat="server" AutoPostBack="False" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style=" text-align:center ">
                                                        <asp:Panel ID="Panel118" runat="server" DefaultButton="Button21">
                                                            <asp:Button ID="Button21" runat="server" onclick="Button21_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox845" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1221" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox316" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1230" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1231" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1232" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1233" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1234" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1235" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1236" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1237" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox317" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox318" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox319" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox320" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox321" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox322" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox323" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel119" runat="server" DefaultButton="Button22">
                                                            <asp:Button ID="Button22" runat="server" onclick="Button22_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox324" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1238" runat="server" Text="No. of clients sent for GeneXpert test 
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox325" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1239" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox326" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1249" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1250" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1251" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1252" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1253" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1254" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1255" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1256" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox327" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox328" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox329" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox846" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox847" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox848" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox849" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel120" runat="server" DefaultButton="Button23">
                                                            <asp:Button ID="Button23" runat="server" onclick="Button23_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox850" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1240" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox851" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1241" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1242" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1243" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1244" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1245" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1246" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1247" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1248" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox852" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox853" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox854" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox855" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox856" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox857" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox858" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel121" runat="server" DefaultButton="Button24">
                                                            <asp:Button ID="Button24" runat="server" onclick="Button24_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox859" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1257" runat="server" Text="No. of clients with GeneXpert test result diagnosed Negative
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox860" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1258" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox861" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1260" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1261" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1262" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1263" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1264" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1265" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1266" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1267" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox862" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox863" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox864" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox865" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox866" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox867" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox868" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel47" runat="server" DefaultButton="Button25">
                                                            <asp:Button ID="Button25" runat="server" onclick="Button25_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox869" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1259" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox870" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1268" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1269" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1270" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1271" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1272" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1273" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1274" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1275" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox871" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox872" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox873" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox874" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox875" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox876" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox877" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel46" runat="server" DefaultButton="Button26">
                                                            <asp:Button ID="Button26" runat="server" onclick="Button26_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox878" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1276" runat="server" Text="No. of clients with GeneXpert test result diagnosed Positive
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox879" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1277" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox880" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1278" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1279" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1280" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1281" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1282" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1283" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1284" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1285" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox881" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox882" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox883" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox884" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox885" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox886" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox887" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel45" runat="server" DefaultButton="Button27">
                                                            <asp:Button ID="Button27" runat="server" onclick="Button27_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox888" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1294" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox889" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1286" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1287" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1288" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1289" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1290" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1291" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1292" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1293" runat="server" style="background-color: #FFFFFF" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox890" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox891" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox892" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox893" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox894" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox895" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox896" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel44" runat="server" DefaultButton="Button28">
                                                            <asp:Button ID="Button28" runat="server" onclick="Button28_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox897" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1295" runat="server" Text="No. of AFB diagnoses done
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox898" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1296" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox899" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1297" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1298" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1299" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1300" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1301" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1302" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1303" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1304" runat="server" style="background-color: #FFFFFF" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox900" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox901" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox902" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox903" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox904" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox905" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox906" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel43" runat="server" DefaultButton="Button29">
                                                            <asp:Button ID="Button29" runat="server" onclick="Button29_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox907" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1305" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox908" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1306" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1307" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1308" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1309" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1310" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1311" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1312" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1313" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox909" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox910" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox911" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox912" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox913" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox914" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox915" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel42" runat="server" DefaultButton="Button30">
                                                            <asp:Button ID="Button30" runat="server" onclick="Button30_Click"  Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox916" runat="server" AutoPostBack="False"   style="height: 22px" Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1314" runat="server" Text="No. of clients with AFB diagnosed Negative
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox917" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1315" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox918" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1317" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1318" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1319" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1320" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1321" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1322" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1323" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1324" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox919" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox920" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox921" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox922" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox923" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox924" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox925" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel41" runat="server" DefaultButton="Button31">
                                                            <asp:Button ID="Button31" runat="server" onclick="Button31_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox926" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1316" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox927" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1325" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1326" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1327" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1328" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1329" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1330" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1331" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1332" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox928" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox929" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox930" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox931" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox932" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox933" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox934" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel40" runat="server" DefaultButton="Button32">
                                                            <asp:Button ID="Button32" runat="server" onclick="Button32_Click"  Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox935" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1333" runat="server" Text="No. of clients with AFB diagnosed Positive
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox936" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1334" runat="server" CssClass="auto-style11" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox937" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1336" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1337" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1338" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1339" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1340" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1341" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1342" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1343" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox938" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox939" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox940" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox941" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox942" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox943" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox944" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel39" runat="server" DefaultButton="Button33">
                                                            <asp:Button ID="Button33" runat="server" onclick="Button33_Click"  Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox945" runat="server" AutoPostBack="False"  Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label1335" runat="server" CssClass="auto-style11" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox946" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1344" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1345" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1346" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1347" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1348" runat="server" Text="Age (15-19)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1349" runat="server" Text="Age (20-24)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1350" runat="server" Text="Age (25-49)
"></asp:Label>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Label ID="Label1351" runat="server" Text="Age (50&gt;)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox947" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox948" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox949" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox950" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox951" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox952" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:TextBox ID="TextBox953" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td style="text-align: center">
                                                        <asp:Panel ID="Panel38" runat="server" DefaultButton="Button34">
                                                            <asp:Button ID="Button34" runat="server" onclick="Button34_Click" Style="display:none" Text="Button" />
                                                            <asp:TextBox ID="TextBox954" runat="server" AutoPostBack="False"   Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <br />
                        </asp:MultiView>
                   <%-- </ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style18" style="background-color: #999999; text-align: center">
                <asp:ImageButton ID="bntComplete" runat="server" ImageUrl="~/image/Complete.png"   Width="90px" Visible="False" />
                <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/image/Submit.png" OnClick="btnSave_Click" CausesValidation="false" />
&nbsp;<asp:ImageButton ID="btnCancel" runat="server" ImageUrl="~/image/Clear1.png"   Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

