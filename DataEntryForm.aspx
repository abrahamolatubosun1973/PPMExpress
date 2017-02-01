<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" MaintainScrollPositionOnPostback="false" EnableViewState="true" AutoEventWireup="true" CodeFile="DataEntryForm.aspx.cs" Inherits="DataEntryForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script type="text/javascript">
          function sumUp() {
              
              document.getElementById('<%=TextBox2.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox3.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox4.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox5.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox6.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox7.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox8.ClientID%>').value);
              document.getElementById('<%=TextBox9.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox10.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox11.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox12.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox13.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox14.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox15.ClientID%>').value);

              document.getElementById('<%=TextBox1.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox2.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox9.ClientID%>').value)
          }
          function sumUp1() {
              document.getElementById('<%=TextBox2.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox3.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox4.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox5.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox6.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox7.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox8.ClientID%>').value);
              document.getElementById('<%=TextBox9.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox10.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox11.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox12.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox13.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox14.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox15.ClientID%>').value);

              document.getElementById('<%=TextBox1.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox2.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox9.ClientID%>').value)
          }
          <%-- Row 2 --%>
          function sumUp2() {

              document.getElementById('<%=TextBox17.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox18.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox19.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox20.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox21.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox22.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox23.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox24.ClientID%>').value);
              document.getElementById('<%=TextBox25.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox26.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox27.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox28.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox29.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox30.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox31.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox32.ClientID%>').value);
              document.getElementById('<%=TextBox16.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox17.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox25.ClientID%>').value)
          }
          function sumUp3() {
              document.getElementById('<%=TextBox25.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox26.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox27.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox28.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox29.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox30.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox31.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox32.ClientID%>').value);
              document.getElementById('<%=TextBox16.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox17.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox25.ClientID%>').value)
          }
           <%-- Row 3 --%>
          function sumUp4() {

              document.getElementById('<%=TextBox33.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox34.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox35.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox36.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox37.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox38.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox39.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox40.ClientID%>').value);
              document.getElementById('<%=TextBox41.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox42.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox43.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox44.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox45.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox46.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox47.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox48.ClientID%>').value);
              document.getElementById('<%=TextBox49.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox33.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox41.ClientID%>').value)
          }
          function sumUp5() {
              document.getElementById('<%=TextBox41.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox42.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox43.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox44.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox45.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox46.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox47.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox48.ClientID%>').value);
              document.getElementById('<%=TextBox49.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox33.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox41.ClientID%>').value)
          }
           <%-- Row 4 --%>
          function sumUp6() {

              document.getElementById('<%=TextBox51.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox52.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox53.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox54.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox55.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox56.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox57.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox58.ClientID%>').value);
              document.getElementById('<%=TextBox59.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox60.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox61.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox62.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox63.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox64.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox65.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox66.ClientID%>').value);
              document.getElementById('<%=TextBox50.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox51.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox59.ClientID%>').value)
          }
          function sumUp7() {
              document.getElementById('<%=TextBox59.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox60.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox61.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox62.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox63.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox64.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox65.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox66.ClientID%>').value);
              document.getElementById('<%=TextBox50.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox51.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox59.ClientID%>').value)
          }
           <%-- Row 5 --%>
          function sumUp8() {

              document.getElementById('<%=TextBox68.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox69.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox70.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox71.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox72.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox73.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox74.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox75.ClientID%>').value);
              document.getElementById('<%=TextBox76.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox77.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox78.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox79.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox80.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox81.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox82.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox83.ClientID%>').value);
              document.getElementById('<%=TextBox67.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox68.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox76.ClientID%>').value)
          }
          function sumUp9() {
              document.getElementById('<%=TextBox76.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox77.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox78.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox79.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox80.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox81.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox82.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox83.ClientID%>').value);
              document.getElementById('<%=TextBox67.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox68.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox76.ClientID%>').value)
          }
            <%-- Row 6 --%>
          function sumUp10() {

              document.getElementById('<%=TextBox85.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox86.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox87.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox88.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox89.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox90.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox91.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox92.ClientID%>').value);
              document.getElementById('<%=TextBox93.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox94.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox95.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox96.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox97.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox98.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox99.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox100.ClientID%>').value);
              document.getElementById('<%=TextBox84.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox85.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox93.ClientID%>').value)
          }
          function sumUp11() {
              document.getElementById('<%=TextBox93.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox94.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox95.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox96.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox97.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox98.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox99.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox100.ClientID%>').value);
              document.getElementById('<%=TextBox84.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox85.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox93.ClientID%>').value)
          }
          <%-- Row 7 --%>
          function sumUp12() {

              document.getElementById('<%=TextBox102.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox103.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox104.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox105.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox106.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox107.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox108.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox109.ClientID%>').value);
              document.getElementById('<%=TextBox110.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox111.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox112.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox113.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox114.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox115.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox116.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox117.ClientID%>').value);
              document.getElementById('<%=TextBox101.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox102.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox110.ClientID%>').value)
          }
          function sumUp13() {
              document.getElementById('<%=TextBox110.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox111.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox112.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox113.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox114.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox115.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox116.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox117.ClientID%>').value);
              document.getElementById('<%=TextBox101.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox102.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox110.ClientID%>').value)
          }
           <%-- Row 8 --%>
          function sumUp14() {
              document.getElementById('<%=TextBox119.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox120.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox121.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox122.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox123.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox124.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox125.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox126.ClientID%>').value);
              document.getElementById('<%=TextBox127.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox128.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox129.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox130.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox131.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox132.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox133.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox134.ClientID%>').value);
              document.getElementById('<%=TextBox118.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox119.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox127.ClientID%>').value)
          }
          function sumUp15() {
              document.getElementById('<%=TextBox127.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox128.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox129.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox130.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox131.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox132.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox133.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox134.ClientID%>').value);
              document.getElementById('<%=TextBox118.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox119.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox127.ClientID%>').value)
          }
          <%-- Row 9 --%>
          function sumUp16() {
              document.getElementById('<%=TextBox136.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox137.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox138.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox139.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox140.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox141.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox142.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox143.ClientID%>').value);
              document.getElementById('<%=TextBox144.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox145.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox146.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox147.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox148.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox149.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox150.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox151.ClientID%>').value);
              document.getElementById('<%=TextBox135.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox136.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox144.ClientID%>').value)
          }
          function sumUp17() {
              document.getElementById('<%=TextBox144.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox145.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox146.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox147.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox148.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox149.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox150.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox151.ClientID%>').value);
              document.getElementById('<%=TextBox135.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox136.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox144.ClientID%>').value)
          }
          <%-- Row 10 --%>
          function sumUp18() {
              document.getElementById('<%=TextBox153.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox154.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox155.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox156.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox157.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox158.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox159.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox160.ClientID%>').value);
              document.getElementById('<%=TextBox161.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox162.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox163.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox164.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox165.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox166.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox167.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox168.ClientID%>').value);
              document.getElementById('<%=TextBox152.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox153.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox161.ClientID%>').value)
          }
          function sumUp19() {
              document.getElementById('<%=TextBox161.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox162.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox163.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox164.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox165.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox166.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox167.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox168.ClientID%>').value);
              document.getElementById('<%=TextBox152.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox153.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox161.ClientID%>').value)
          }
            <%-- Row 11 --%>
          function sumUp20() {

              document.getElementById('<%=TextBox176.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox170.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox171.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox172.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox173.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox174.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox175.ClientID%>').value);
              document.getElementById('<%=TextBox177.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox178.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox179.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox180.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox181.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox182.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox183.ClientID%>').value);
              document.getElementById('<%=TextBox169.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox176.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox177.ClientID%>').value)
          }
          function sumUp21() {
              document.getElementById('<%=TextBox177.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox178.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox179.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox180.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox181.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox182.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox183.ClientID%>').value);
              document.getElementById('<%=TextBox169.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox176.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox177.ClientID%>').value)
          }
            <%-- Row 12 --%>
          function sumUp22() {

              document.getElementById('<%=TextBox184.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox185.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox186.ClientID%>').value);

          }
          <%-- --------- Food And Nutrition ---------- --%>

          <%-- Row 1 --%>
          function sumUpFN1() {

              document.getElementById('<%=TextBox188.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox189.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox190.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox191.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox192.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox193.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox194.ClientID%>').value);
              document.getElementById('<%=TextBox195.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox196.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox197.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox198.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox199.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox200.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox201.ClientID%>').value);
              document.getElementById('<%=TextBox187.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox188.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox195.ClientID%>').value)
          }
          function sumUpFN2() {
              document.getElementById('<%=TextBox195.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox196.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox197.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox198.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox199.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox200.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox201.ClientID%>').value);
              document.getElementById('<%=TextBox187.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox188.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox195.ClientID%>').value)
          }
            <%-- Row 2 --%>
          function sumUpFN3() {

              document.getElementById('<%=TextBox203.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox204.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox205.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox206.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox207.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox208.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox209.ClientID%>').value);
              document.getElementById('<%=TextBox210.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox211.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox212.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox213.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox214.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox215.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox216.ClientID%>').value);
              document.getElementById('<%=TextBox202.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox203.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox210.ClientID%>').value)
          }
          function sumUpFN4() {
              document.getElementById('<%=TextBox210.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox211.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox212.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox213.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox214.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox215.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox216.ClientID%>').value);
              document.getElementById('<%=TextBox202.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox203.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox210.ClientID%>').value)
          }
           <%-- Row 3 --%>
          function sumUpFN5() {

              document.getElementById('<%=TextBox220.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox221.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox222.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox223.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox224.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox225.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox226.ClientID%>').value);
              document.getElementById('<%=TextBox227.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox228.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox229.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox230.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox231.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox232.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox233.ClientID%>').value);
              document.getElementById('<%=TextBox219.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox220.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox227.ClientID%>').value)
          }
          function sumUpFN6() {
              document.getElementById('<%=TextBox227.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox228.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox229.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox230.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox231.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox232.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox233.ClientID%>').value);
              document.getElementById('<%=TextBox219.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox220.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox227.ClientID%>').value)
          }
           <%-- Row 4 --%>
          function sumUpFN7() {

              document.getElementById('<%=TextBox237.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox238.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox239.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox240.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox241.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox242.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox243.ClientID%>').value);
              document.getElementById('<%=TextBox244.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox245.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox246.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox247.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox248.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox249.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox250.ClientID%>').value);
              document.getElementById('<%=TextBox236.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox237.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox244.ClientID%>').value)
          }
          function sumUpFN8() {
              document.getElementById('<%=TextBox244.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox245.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox246.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox247.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox248.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox249.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox250.ClientID%>').value);
              document.getElementById('<%=TextBox236.ClientID%>').value = parseFloat(document.getElementById('<%=TextBox237.ClientID%>').value) + parseFloat(document.getElementById('<%=TextBox244.ClientID%>').value)
          }
      </script>
    <style type="text/css">
        .auto-style17 {
            width: 163px;
        }
        .auto-style18 {
            width: 959px;
        }
         .auto-style42 {
            width: 683px;
            background-color: #FFFFFF;
        }
        .auto-style43 {
            width: 683px;
            background-color: #FFFFFF;
            height: 26px;
        }
        .auto-style44 {
            height: 26px;
        }
        .auto-style45 {
            font-weight: bold;
            /*background-color: #CC3300;*/
        }
        .auto-style46 {
            color: silver;
        }
        .auto-style47 {
            color: #000000;
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
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">
           <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                   <ContentTemplate>
                    <table class="auto-style2"  >
                        <tr >
                            <td class="auto-style12" style="border-style: solid; border-width: thin;" >
                                <asp:Label ID="Label921" runat="server" Text="State :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;" >
                                <asp:DropDownList ID="drpStates" runat="server" Width="198px" AutoPostBack="False" OnSelectedIndexChanged="drpStates_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg9" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">
                                <asp:Label ID="Label922" runat="server" Text="LGA :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;" >
                                <asp:DropDownList ID="drpLGA" runat="server" Width="198px" AutoPostBack="False" OnSelectedIndexChanged="drpLGA_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg8" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblmsg" runat="server" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">Facility :</td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;">
                                <asp:DropDownList ID="drpFacility" runat="server" Width="198px">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg7" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;" >
                                <asp:Label ID="Label923" runat="server" Text="Month :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;" >
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
                                <asp:Label ID="Label924" runat="server" Text="Year :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;" >
                                <asp:DropDownList ID="drpYrs" runat="server" Width="90px">
                                </asp:DropDownList>
                                <asp:Label ID="lblmsg10" runat="server" style="color: #FF0000">*</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style12" style="border-style: solid; border-width: thin;">
                                <asp:Label ID="Label920" runat="server" Text="Thematic Area :"></asp:Label>
                            </td>
                            <td class="auto-style8" style="border-style: solid; border-width: thin;" >
                                <asp:DropDownList ID="drpThematic" runat="server" AutoPostBack="False" Width="198px" OnSelectedIndexChanged="drpThematic_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:TextBox ID="TextBox798" runat="server" BorderColor="#CCCCCC" ReadOnly="True" Width="95px" style="color: #FF0000" Visible="False"></asp:TextBox>
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
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">
               <%-- <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>--%>

                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View1" runat="server">
                                <table width="100%" style="border: thin solid #000000">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">OVC</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <hr />
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                         <asp:Label ID="Label1" runat="server" Text="Number of OVC Newly Enrolled
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label2" runat="server" Text="Males"></asp:Label>
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
                                                        <asp:Label ID="Label3" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label4" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label5" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label6" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label7" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label8" runat="server" Text="Age (18+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox3" runat="server" Width="52px" OnTextChanged="TextBox3_TextChanged" onKeyUp="sumUp()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox4" runat="server" Width="52px" OnTextChanged="TextBox4_TextChanged" onKeyUp="sumUp()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox5" runat="server" Width="52px" OnTextChanged="TextBox5_TextChanged" onKeyUp="sumUp()" ></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox6" runat="server" Width="52px" OnTextChanged="TextBox6_TextChanged" onKeyUp="sumUp()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox7" runat="server" Width="52px" OnTextChanged="TextBox7_TextChanged" onKeyUp="sumUp()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel1" runat="server" DefaultButton="Button1">
                                                            <asp:Button ID="Button1" runat="server" Text="Button" Style="display:none" OnClick="Button1_Click"  />
                                                        <asp:TextBox ID="TextBox8" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox8_TextChanged" onKeyUp="sumUp()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label9" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox9" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label10" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label11" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label12" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label13" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label14" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label15" runat="server" Text="Age (18+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox10" runat="server" Width="52px" onKeyUp="sumUp1()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox11" runat="server" Width="52px" onKeyUp="sumUp1()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox12" runat="server" Width="52px" onKeyUp="sumUp1()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox13" runat="server" Width="52px" onKeyUp="sumUp1()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox14" runat="server" Width="52px" onKeyUp="sumUp1()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel2" runat="server" DefaultButton="Button2">
                                                        <asp:TextBox ID="TextBox15" runat="server" Width="52px"  OnTextChanged="TextBox15_TextChanged1" onKeyUp="sumUp1()" ></asp:TextBox>
                                                            <asp:Button ID="Button2" runat="server" Text="Button" Style="display:none" OnClick="Button2_Click1" />
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
                                                        <asp:Label ID="Label16" runat="server" Text="Number of HIV positive OVC that received clinical  services (including those on ART)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                         <asp:TextBox ID="TextBox16" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label17" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox17" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label18" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label19" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label20" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label21" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label22" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label23" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>

                                                        <asp:Label ID="Label32" runat="server" Text="Age (25+)
"></asp:Label>

                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox18" runat="server" Width="52px" onKeyUp="sumUp2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox19" runat="server" Width="52px" onKeyUp="sumUp2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox20" runat="server" Width="52px" onKeyUp="sumUp2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox21" runat="server" Width="52px" onKeyUp="sumUp2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox22" runat="server" Width="52px" onKeyUp="sumUp2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox23" runat="server" Width="52px" onKeyUp="sumUp2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel3" runat="server" DefaultButton="Button3">
                                                           
                                                        <asp:TextBox ID="TextBox24" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox24_TextChanged" onKeyUp="sumUp2()"></asp:TextBox>
                                                         <asp:Button ID="Button3" runat="server" Text="Button" Style="display:none" OnClick="Button3_Click"  />
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label24" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox25" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label33" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label34" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label35" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label36" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label37" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label38" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label39" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox26" runat="server" Width="52px" onKeyUp="sumUp3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox27" runat="server" Width="52px" onKeyUp="sumUp3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox28" runat="server" Width="52px" onKeyUp="sumUp3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox29" runat="server" Width="52px" onKeyUp="sumUp3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox30" runat="server" Width="52px" onKeyUp="sumUp3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox31" runat="server" Width="52px" onKeyUp="sumUp3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel4" runat="server" DefaultButton="Button4">
                                                           
                                                        <asp:TextBox ID="TextBox32" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox32_TextChanged" onKeyUp="sumUp3()"></asp:TextBox>
                                                         <asp:Button ID="Button4" runat="server" Text="Button" Style="display:none" OnClick="Button4_Click"  />
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
                                                        <asp:Label ID="Label31" runat="server" Text="Number of OVC receiving Supplemental Direct Support (&lt; 3 Services)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox49" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label40" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox33" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label41" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label42" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label43" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label44" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label45" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label46" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label47" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox34" runat="server" Width="52px" onKeyUp="sumUp4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox35" runat="server" Width="52px" onKeyUp="sumUp4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox36" runat="server" Width="52px" onKeyUp="sumUp4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox37" runat="server" Width="52px" onKeyUp="sumUp4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox38" runat="server" Width="52px" onKeyUp="sumUp4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox39" runat="server" Width="52px" onKeyUp="sumUp4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel5" runat="server" DefaultButton="Button5">
                                                            <asp:Button ID="Button5" runat="server" Text="Button" Style="display:none" OnClick="Button5_Click" />
                                                        <asp:TextBox ID="TextBox40" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox40_TextChanged" onKeyUp="sumUp4()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                         <asp:Label ID="Label48" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox41" runat="server" Width="52px" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label49" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label50" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label51" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label52" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label53" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label54" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label55" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox42" runat="server" Width="52px" onKeyUp="sumUp5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox43" runat="server" Width="52px" onKeyUp="sumUp5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox44" runat="server" Width="52px" onKeyUp="sumUp5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox45" runat="server" Width="52px" onKeyUp="sumUp5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox46" runat="server" Width="52px" onKeyUp="sumUp5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox47" runat="server" Width="52px" onKeyUp="sumUp5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel6" runat="server" DefaultButton="Button6">
                                                            <asp:Button ID="Button6" runat="server" Text="Button" Style="display:none" OnClick="Button6_Click"   />
                                                        <asp:TextBox ID="TextBox48" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox48_TextChanged" onKeyUp="sumUp5()"></asp:TextBox>
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
                                                        <asp:Label ID="Label25" runat="server" Text="Number of OVC receiving Supplemental Direct Support (>3 Services)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox50" Width="52px" runat="server" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label26" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox51" Width="52px" runat="server" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
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
                                                        <asp:Label ID="Label56" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label57" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label58" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label59" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label60" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label61" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label62" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox52" runat="server" Width="52px" onKeyUp="sumUp6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox53" runat="server" Width="52px" onKeyUp="sumUp6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox54" runat="server" Width="52px" onKeyUp="sumUp6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox55" runat="server" Width="52px" onKeyUp="sumUp6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox56" runat="server" Width="52px" onKeyUp="sumUp6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox57" runat="server" Width="52px" onKeyUp="sumUp6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel7" runat="server" DefaultButton="Button7">
                                                            <asp:Button ID="Button7" runat="server" Text="Button" Style="display:none" OnClick="Button7_Click"  />
                                                        <asp:TextBox ID="TextBox58" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox58_TextChanged" onKeyUp="sumUp6()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label63" runat="server" Text="Female"></asp:Label>
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
                                                        <asp:Label ID="Label64" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label65" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label66" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label67" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label68" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label69" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label70" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox60" runat="server" Width="52px" onKeyUp="sumUp7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox61" runat="server" Width="52px" onKeyUp="sumUp7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox62" runat="server" Width="52px" onKeyUp="sumUp7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox63" runat="server" Width="52px" onKeyUp="sumUp7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox64" runat="server" Width="52px" onKeyUp="sumUp7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox65" runat="server" Width="52px" onKeyUp="sumUp7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel8" runat="server" DefaultButton="Button8">
                                                            <asp:Button ID="Button8" runat="server" Text="Button" Style="display:none" OnClick="Button8_Click"  />
                                                        <asp:TextBox ID="TextBox66" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox66_TextChanged" onKeyUp="sumUp7()"></asp:TextBox>
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
                                                        <asp:Label ID="Label71" runat="server" Text="Number of eligible adults and children who received food and/or other nutrition services"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox67" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label72" runat="server" Text="Male"></asp:Label>
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
                                                        <asp:Label ID="Label73" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label74" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label75" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label76" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label77" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label78" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label79" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox69" runat="server" Width="52px" onKeyUp="sumUp8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox70" runat="server" Width="52px" onKeyUp="sumUp8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox71" runat="server" Width="52px" onKeyUp="sumUp8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox72" runat="server" Width="52px" onKeyUp="sumUp8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox73" runat="server" Width="52px" onKeyUp="sumUp8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox74" runat="server" Width="52px" onKeyUp="sumUp8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel9" runat="server" DefaultButton="Button9">
                                                            <asp:Button ID="Button9" runat="server" Text="Button" Style="display:none" OnClick="Button9_Click"  />
                                                        <asp:TextBox ID="TextBox75" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox75_TextChanged" onKeyUp="sumUp8()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label80" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox76" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label81" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label82" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label83" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label84" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label85" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label86" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label87" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox77" runat="server" Width="52px" onKeyUp="sumUp9()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox78" runat="server" Width="52px" onKeyUp="sumUp9()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox79" runat="server" Width="52px" onKeyUp="sumUp9()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox80" runat="server" Width="52px" onKeyUp="sumUp9()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox81" runat="server" Width="52px" onKeyUp="sumUp9()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox82" runat="server" Width="52px" onKeyUp="sumUp9()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel10" runat="server" DefaultButton="Button10">
                                                            <asp:Button ID="Button10" runat="server" Text="Button" Style="display:none" OnClick="Button10_Click"  />
                                                        <asp:TextBox ID="TextBox83" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox83_TextChanged" onKeyUp="sumUp9()"></asp:TextBox>
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
                                                        <asp:Label ID="Label88" runat="server" Text="Number of OVC provided with psychosocial support"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox84" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label89" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox85" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label90" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label91" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label92" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label93" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label94" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label95" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label96" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox86" runat="server" Width="52px" onKeyUp="sumUp10()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox87" runat="server" Width="52px" onKeyUp="sumUp10()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox88" runat="server" Width="52px" onKeyUp="sumUp10()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox89" runat="server" Width="52px" onKeyUp="sumUp10()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox90" runat="server" Width="52px" onKeyUp="sumUp10()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox91" runat="server" Width="52px" onKeyUp="sumUp10()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel11" runat="server" DefaultButton="Button11">
                                                            <asp:Button ID="Button11" runat="server" Text="Button" Style="display:none" OnClick="Button11_Click"  />
                                                        <asp:TextBox ID="TextBox92" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox92_TextChanged" onKeyUp="sumUp10()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label97" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox93" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label98" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label99" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label100" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label101" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label102" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label103" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label104" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox94" runat="server" Width="52px" onKeyUp="sumUp11()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox95" runat="server" Width="52px" onKeyUp="sumUp11()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox96" runat="server" Width="52px" onKeyUp="sumUp11()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox97" runat="server" Width="52px" onKeyUp="sumUp11()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox98" runat="server" Width="52px" onKeyUp="sumUp11()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox99" runat="server" Width="52px" onKeyUp="sumUp11()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Panel ID="Panel12" runat="server" DefaultButton="Button12">
                                                            <asp:Button ID="Button12" runat="server" Text="Button" Style="display:none" OnClick="Button12_Click"  />
                                                        <asp:TextBox ID="TextBox100" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox100_TextChanged" onKeyUp="sumUp11()"></asp:TextBox>
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
                                                        <asp:Label ID="Label105" runat="server" Text="Number of OVC provided with legal assistance and protective care services
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox101" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label106" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox102" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label107" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label108" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label109" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label110" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label111" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label112" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label113" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox103" runat="server" Width="52px" onKeyUp="sumUp12()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox104" runat="server" Width="52px" onKeyUp="sumUp12()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox105" runat="server" Width="52px" onKeyUp="sumUp12()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox106" runat="server" Width="52px" onKeyUp="sumUp12()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox107" runat="server" Width="52px" onKeyUp="sumUp12()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox108" runat="server" Width="52px" onKeyUp="sumUp12()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel13" runat="server" DefaultButton="Button13">
                                                            <asp:Button ID="Button13" runat="server" Text="Button" Style="display:none" OnClick="Button13_Click"  />
                                                        <asp:TextBox ID="TextBox109" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox109_TextChanged" onKeyUp="sumUp12()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label114" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox110" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label115" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label116" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label117" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label118" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label119" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label120" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label121" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox111" runat="server" Width="52px" onKeyUp="sumUp13()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox112" runat="server" Width="52px" onKeyUp="sumUp13()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox113" runat="server" Width="52px" onKeyUp="sumUp13()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox114" runat="server" Width="52px" onKeyUp="sumUp13()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox115" runat="server" Width="52px" onKeyUp="sumUp13()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox116" runat="server" Width="52px" onKeyUp="sumUp13()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel14" runat="server" DefaultButton="Button14">
                                                            <asp:Button ID="Button14" runat="server" Text="Button" Style="display:none" OnClick="Button14_Click"  />
                                                        <asp:TextBox ID="TextBox117" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox117_TextChanged" onKeyUp="sumUp13()"></asp:TextBox>
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
                                                        <asp:Label ID="Label122" runat="server" Text="Number of OVC families/care givers provided with economic support or income generating activities (IGA)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox118" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label123" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox119" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label124" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label125" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label126" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label127" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label128" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label129" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label130" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox120" runat="server" Width="52px" onKeyUp="sumUp14()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox121" runat="server" Width="52px" onKeyUp="sumUp14()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox122" runat="server" Width="52px" onKeyUp="sumUp14()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox123" runat="server" Width="52px" onKeyUp="sumUp14()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox124" runat="server" Width="52px" onKeyUp="sumUp14()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox125" runat="server" Width="52px" onKeyUp="sumUp14()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel15" runat="server" DefaultButton="Button15">
                                                            <asp:Button ID="Button15" runat="server" Text="Button" Style="display:none" OnClick="Button15_Click"  />
                                                        <asp:TextBox ID="TextBox126" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox126_TextChanged" onKeyUp="sumUp14()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label131" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox127" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label132" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label133" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label134" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label135" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label136" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label137" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label138" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox128" runat="server" Width="52px" onKeyUp="sumUp15()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox129" runat="server" Width="52px" onKeyUp="sumUp15()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox130" runat="server" Width="52px" onKeyUp="sumUp15()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox131" runat="server" Width="52px" onKeyUp="sumUp15()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox132" runat="server" Width="52px" onKeyUp="sumUp15()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox133" runat="server" Width="52px" onKeyUp="sumUp15()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel16" runat="server" DefaultButton="Button16">
                                                            <asp:Button ID="Button16" runat="server" Text="Button" Style="display:none" OnClick="Button16_Click"  />
                                                        <asp:TextBox ID="TextBox134" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox134_TextChanged" onKeyUp="sumUp15()"></asp:TextBox>
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
                                                        <asp:Label ID="Label139" runat="server" Text="Number of active beneficiaries receiving support from PEPFAR OVC programs to access HIV services"></asp:Label>
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
                                            <table>
                                                <tr>
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label140" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox136" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label141" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label142" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label143" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label144" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label145" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label146" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label147" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox137" runat="server" Width="52px" onKeyUp="sumUp16()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox138" runat="server" Width="52px" onKeyUp="sumUp16()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox139" runat="server" Width="52px" onKeyUp="sumUp16()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox140" runat="server" Width="52px" onKeyUp="sumUp16()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox141" runat="server" Width="52px" onKeyUp="sumUp16()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox142" runat="server" Width="52px" onKeyUp="sumUp16()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel17" runat="server" DefaultButton="Button17">
                                                            <asp:Button ID="Button17" runat="server" Text="Button" Style="display:none" OnClick="Button17_Click"  />
                                                        <asp:TextBox ID="TextBox143" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox143_TextChanged" onKeyUp="sumUp16()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label148" runat="server" Text="Female"></asp:Label>
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
                                                        <asp:Label ID="Label149" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label150" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label151" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label152" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label153" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label154" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label155" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox145" runat="server" Width="52px" onKeyUp="sumUp17()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox146" runat="server" Width="52px" onKeyUp="sumUp17()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox147" runat="server" Width="52px" onKeyUp="sumUp17()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox148" runat="server" Width="52px" onKeyUp="sumUp17()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox149" runat="server" Width="52px" onKeyUp="sumUp17()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox150" runat="server" Width="52px" onKeyUp="sumUp17()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel18" runat="server" DefaultButton="Button18">
                                                            <asp:Button ID="Button18" runat="server" Text="Button" Style="display:none" OnClick="Button18_Click"  />
                                                        <asp:TextBox ID="TextBox151" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox151_TextChanged" onKeyUp="sumUp17()"></asp:TextBox>
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
                                                        <asp:Label ID="Label156" runat="server" Text="Number of active beneficiaries served by PEPFAR programs for children and families affected by HIV/AIDS"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox152" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label157" runat="server" Text="Male"></asp:Label>
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
                                                        <asp:Label ID="Label162" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label163" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label164" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox154" runat="server" Width="52px" onKeyUp="sumUp18()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox155" runat="server" Width="52px" onKeyUp="sumUp18()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox156" runat="server" Width="52px" onKeyUp="sumUp18()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox157" runat="server" Width="52px" onKeyUp="sumUp18()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox158" runat="server" Width="52px" onKeyUp="sumUp18()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox159" runat="server" Width="52px" onKeyUp="sumUp18()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel19" runat="server" DefaultButton="Button19">
                                                            <asp:Button ID="Button19" runat="server" Text="Button" Style="display:none" OnClick="Button19_Click"  />
                                                        <asp:TextBox ID="TextBox160" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox160_TextChanged" onKeyUp="sumUp18()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label165" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox161" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label166" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label167" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label168" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label169" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label170" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label171" runat="server" Text="Age (18-24)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label172" runat="server" Text="Age (25+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox162" runat="server" Width="52px" onKeyUp="sumUp19()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox163" runat="server" Width="52px" onKeyUp="sumUp19()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox164" runat="server" Width="52px" onKeyUp="sumUp19()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox165" runat="server" Width="52px" onKeyUp="sumUp19()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox166" runat="server" Width="52px" onKeyUp="sumUp19()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox167" runat="server" Width="52px" onKeyUp="sumUp19()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel20" runat="server" DefaultButton="Button20">
                                                            <asp:Button ID="Button20" runat="server" Text="Button" Style="display:none" OnClick="Button20_Click"  />
                                                        <asp:TextBox ID="TextBox168" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox168_TextChanged" onKeyUp="sumUp19()"></asp:TextBox>
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
                                                        <asp:Label ID="Label173" runat="server" Text="Number of OVC who graduated
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox169" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label180" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox176" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label174" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label175" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label176" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label177" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label178" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label179" runat="server" Text="Age (18+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox170" runat="server" Width="52px" onKeyUp="sumUp20()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox171" runat="server" Width="52px" onKeyUp="sumUp20()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox172" runat="server" Width="52px" onKeyUp="sumUp20()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox173" runat="server" Width="52px" onKeyUp="sumUp20()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox174" runat="server" Width="52px" onKeyUp="sumUp20()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel21" runat="server" DefaultButton="Button21">
                                                            <asp:Button ID="Button21" runat="server" Text="Button" Style="display: none" OnClick="Button21_Click"  />
                                                        <asp:TextBox ID="TextBox175" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox175_TextChanged" onKeyUp="sumUp20()"></asp:TextBox>
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
                                                    <td class="auto-style42 ">
                                                        <asp:Label ID="Label181" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox177" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label182" runat="server" Text="Age (&lt;1)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label183" runat="server" Text="Age (1-4)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label184" runat="server" Text="Age (5-9)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label185" runat="server" Text="Age (10-14)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label186" runat="server" Text="Age (15-17)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label187" runat="server" Text="Age (18+)
"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox178" runat="server" Width="52px" onKeyUp="sumUp21()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox179" runat="server" Width="52px" onKeyUp="sumUp21()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox180" runat="server" Width="52px" onKeyUp="sumUp21()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox181" runat="server" Width="52px" onKeyUp="sumUp21()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox182" runat="server" Width="52px" onKeyUp="sumUp21()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel22" runat="server" DefaultButton="Button22">
                                                            <asp:Button ID="Button22" runat="server" Text="Button" Style="display:none" OnClick="Button22_Click"  />
                                                        <asp:TextBox ID="TextBox183" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox183_TextChanged" onKeyUp="sumUp21()"></asp:TextBox>
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
                                                        <asp:Label ID="Label188" runat="server" Text="Number of Caregivers provided training to improve their ability in caring for OVC
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox184" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            
                                            <div  class="clearboth ">
                                                <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label27" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label28" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox185" runat="server" Width="52px" onKeyUp="sumUp22()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel23" runat="server" DefaultButton="Button23">
                                                            <asp:Button ID="Button23" runat="server" Text="Button" Style="display:none" OnClick="Button23_Click"  />
                                                        <asp:TextBox ID="TextBox186" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox186_TextChanged" onKeyUp="sumUp22()"></asp:TextBox>
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
                                    <tr>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <hr />
                            <asp:View ID="View2" runat="server">
                                <table class="style1" style="border-style: solid; border-width: thin">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label189" runat="server" Text="Food and Nutrition
"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label190" runat="server" Text="Number of HIV positive adults and children who received care and treatment services
"></asp:Label>
                                                    </td>
                                                    <td> 
                                                        <asp:TextBox ID="TextBox187" Width="52px" BackColor="#CCCCCC" ReadOnly="true"  runat="server"></asp:TextBox>
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
                                                        <asp:Label ID="Label191" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox188" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label29" runat="server" Text="Age (<1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label30" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label192" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label193" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label194" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label195" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>

                                                        <asp:TextBox ID="TextBox189" runat="server" Width="52px" onKeyUp="sumUpFN1()"></asp:TextBox>

                                                    </td>
                                                    <td>

                                                        <asp:TextBox ID="TextBox190" runat="server" Width="52px" onKeyUp="sumUpFN1()"></asp:TextBox>

                                                    </td>
                                                    <td>

                                                        <asp:TextBox ID="TextBox191" runat="server" Width="52px" onKeyUp="sumUpFN1()"></asp:TextBox>

                                                    </td>
                                                    <td>

                                                        <asp:TextBox ID="TextBox192" runat="server" Width="52px" onKeyUp="sumUpFN1()"></asp:TextBox>

                                                    </td>
                                                    <td>

                                                        <asp:TextBox ID="TextBox193" runat="server" Width="52px" onKeyUp="sumUpFN1()"></asp:TextBox>

                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel24" runat="server" DefaultButton="Button24">
                                                            <asp:Button ID="Button24" runat="server" Text="Button" Style="display:none" OnClick="Button24_Click"  />
                                                        <asp:TextBox ID="TextBox194" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox194_TextChanged" onKeyUp="sumUpFN1()"></asp:TextBox>
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
                                                        <asp:Label ID="Label196" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox195" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label197" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label198" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label199" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label200" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label201" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label202" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox196" runat="server" Width="52px" onKeyUp="sumUpFN2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox197" runat="server" Width="52px" onKeyUp="sumUpFN2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox198" runat="server" Width="52px" onKeyUp="sumUpFN2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox199" runat="server" Width="52px" onKeyUp="sumUpFN2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox200" runat="server" Width="52px" onKeyUp="sumUpFN2()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel25" runat="server" DefaultButton="Button25">
                                                            <asp:Button ID="Button25" runat="server" Text="Button" Style="display:none" OnClick="Button25_Click"  />
                                                        <asp:TextBox ID="TextBox201" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox201_TextChanged" onKeyUp="sumUpFN2()"></asp:TextBox>
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
                                                        <asp:Label ID="Label203" runat="server" Text="Number of PLHIV who were nutritionally assessed via anthropometric measurement
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox202" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label204" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox203" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label205" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label206" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label207" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label208" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label209" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label210" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox204" runat="server" Width="52px" onKeyUp="sumUpFN3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox205" runat="server" Width="52px" onKeyUp="sumUpFN3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox206" runat="server" Width="52px" onKeyUp="sumUpFN3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox207" runat="server" Width="52px" onKeyUp="sumUpFN3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox208" runat="server" Width="52px" onKeyUp="sumUpFN3()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel26" runat="server" DefaultButton="Button26">
                                                            <asp:Button ID="Button26" runat="server" Text="Button" Style="display:none" OnClick="Button26_Click"  />
                                                        <asp:TextBox ID="TextBox209" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox209_TextChanged" onKeyUp="sumUpFN3()"></asp:TextBox>
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
                                                        <asp:Label ID="Label211" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox210" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label212" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label213" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label214" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label215" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label216" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label217" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox211" runat="server" Width="52px" onKeyUp="sumUpFN4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox212" runat="server" Width="52px" onKeyUp="sumUpFN4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox213" runat="server" Width="52px" onKeyUp="sumUpFN4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox214" runat="server" Width="52px" onKeyUp="sumUpFN4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox215" runat="server" Width="52px" onKeyUp="sumUpFN4()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel27" runat="server" DefaultButton="Button27">
                                                            <asp:Button ID="Button27" runat="server" Text="Button" Style="display:none" OnClick="Button27_Click"  />
                                                        <asp:TextBox ID="TextBox216" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox216_TextChanged" onKeyUp="sumUpFN4()"></asp:TextBox>
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
                                                            <asp:Label ID="Label218" runat="server" Text="Pregnant"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label219" runat="server" Text="Postpartum
"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox217" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox218" runat="server" AutoPostBack="False" OnTextChanged="TextBox186_TextChanged" Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label220" runat="server" Text="Number of PLHIV that were nutritionally assessed and found to be clinically undernourished 
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox219" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label221" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox220" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label222" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label223" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label224" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label225" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label226" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label227" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox221" runat="server" Width="52px" onKeyUp="sumUpFN5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox222" runat="server" Width="52px" onKeyUp="sumUpFN5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox223" runat="server" Width="52px" onKeyUp="sumUpFN5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox224" runat="server" Width="52px" onKeyUp="sumUpFN5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox225" runat="server" Width="52px" onKeyUp="sumUpFN5()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel28" runat="server" DefaultButton="Button28">
                                                            <asp:Button ID="Button28" runat="server" Text="Button" Style="display:none" OnClick="Button28_Click"  />
                                                        <asp:TextBox ID="TextBox226" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox226_TextChanged" onKeyUp="sumUpFN5()"></asp:TextBox>
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
                                                        <asp:Label ID="Label228" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox227" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label229" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label230" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label231" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label232" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label233" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label234" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox228" runat="server" Width="52px" onKeyUp="sumUpFN6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox229" runat="server" Width="52px" onKeyUp="sumUpFN6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox230" runat="server" Width="52px" onKeyUp="sumUpFN6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox231" runat="server" Width="52px" onKeyUp="sumUpFN6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox232" runat="server" Width="52px" onKeyUp="sumUpFN6()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel29" runat="server" DefaultButton="Button29">
                                                            <asp:Button ID="Button29" runat="server" Text="Button" Style="display:none" OnClick="Button29_Click"  />
                                                        <asp:TextBox ID="TextBox233" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox233_TextChanged" onKeyUp="sumUpFN6()"></asp:TextBox>
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
                                                            <asp:Label ID="Label235" runat="server" Text="Pregnant"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label236" runat="server" Text="Postpartum
"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox234" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox235" runat="server" AutoPostBack="False" OnTextChanged="TextBox186_TextChanged" Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label237" runat="server" Text="Number of clinically undernourished PLHIV who received therapeutic or supplementary food
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox236" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label238" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox237" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label239" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label240" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label241" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label242" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label243" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label244" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox238" runat="server" Width="52px" onKeyUp="sumUpFN7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox239" runat="server" Width="52px" onKeyUp="sumUpFN7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox240" runat="server" Width="52px" onKeyUp="sumUpFN7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox241" runat="server" Width="52px" onKeyUp="sumUpFN7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox242" runat="server" Width="52px" onKeyUp="sumUpFN7()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel30" runat="server" DefaultButton="Button30">
                                                            <asp:Button ID="Button30" runat="server" Text="Button" Style="display:none" OnClick="Button30_Click"  />
                                                        <asp:TextBox ID="TextBox243" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox243_TextChanged" onKeyUp="sumUpFN7()"></asp:TextBox>
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
                                                        <asp:Label ID="Label245" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox244" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1" style="text-align: center;">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label246" runat="server" Text="Age (&lt;1)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label247" runat="server" Text="Age (1-4)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label248" runat="server" Text="Age (5-9)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label249" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label250" runat="server" Text="Age (15-18)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label251" runat="server" Text="Age 18+"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox245" runat="server" Width="52px" onKeyUp="sumUpFN8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox246" runat="server" Width="52px" onKeyUp="sumUpFN8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox247" runat="server" Width="52px" onKeyUp="sumUpFN8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox248" runat="server" Width="52px" onKeyUp="sumUpFN8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox249" runat="server" Width="52px" onKeyUp="sumUpFN8()"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel31" runat="server" DefaultButton="Button31">
                                                            <asp:Button ID="Button31" runat="server" Text="Button" Style="display:none" OnClick="Button31_Click"  />
                                                        <asp:TextBox ID="TextBox250" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox250_TextChanged" onKeyUp="sumUpFN8()"></asp:TextBox>
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
                                                            <asp:Label ID="Label252" runat="server" Text="Pregnant"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label253" runat="server" Text="Postpartum
"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox251" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                           <asp:Panel ID="Panel32" runat="server" DefaultButton="Button31">
                                                            <asp:Button ID="Button32" runat="server" Text="Button" Style="display:none" OnClick="Button32_Click"  />
                                                            <asp:TextBox ID="TextBox252" runat="server" AutoPostBack="False" OnTextChanged="TextBox186_TextChanged" Width="52px"></asp:TextBox>
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
                            <asp:View ID="View3" runat="server">
                                <table class="style1" style="border-style: solid; border-width: thin">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label254" runat="server" Text="Priority Population (PP)
"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label255" runat="server" Text="Number of each priority population who completed a standardized HIV prevention program  including the specified minimum components during the reporting period
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
                                        <td>
                                            <hr />
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label256" runat="server" Text="School Based
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox254" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label257" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox255" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                       <asp:Label ID="Label258" runat="server" Text="Age (10-14)"></asp:Label>
                                                   </td>
                                                   <td>
                                                       <asp:Label ID="Label259" runat="server" Text="Age (15-19)"></asp:Label>
                                                   </td>
                                                   <td>
                                                       <asp:Label ID="Label260" runat="server" Text="Age (20-49)"></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td>
                                                       <asp:TextBox ID="TextBox256" Width="52px" runat="server"></asp:TextBox>
                                                   </td>
                                                   <td>
                                                       <asp:TextBox ID="TextBox257" Width="52px" runat="server"></asp:TextBox>
                                                   </td>
                                                   <td>
                                                         <asp:Panel ID="Panel33" runat="server" DefaultButton="Button33">
                                                            <asp:Button ID="Button33" runat="server" Text="Button" Style="display:none"  />
                                                       <asp:TextBox ID="TextBox258" Width="52px" runat="server" AutoPostBack="False" OnTextChanged="TextBox258_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label261" runat="server" Text="Female
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox259" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label262" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label263" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label264" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox260" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox261" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel34" runat="server" DefaultButton="Button34">
                                                            <asp:Button ID="Button34" runat="server" Text="Button" Style="display:none" OnClick="Button34_Click"  />
                                                        <asp:TextBox ID="TextBox262" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox262_TextChanged" style="height: 22px"></asp:TextBox>
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
                                                        <asp:Label ID="Label265" runat="server" Text="Community based
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox263" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label266" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox264" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label267" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label268" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label269" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox265" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox266" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel35" runat="server" DefaultButton="Button35">
                                                            <asp:Button ID="Button35" runat="server" Text="Button" Style="display:none" OnClick="Button35_Click"  />
                                                        <asp:TextBox ID="TextBox267" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox267_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label270" runat="server" Text="Female
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox268" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label271" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label272" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label273" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox269" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox270" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel36" runat="server" DefaultButton="Button36">
                                                            <asp:Button ID="Button36" runat="server" Text="Button" Style="display:none" OnClick="Button36_Click"  />
                                                        <asp:TextBox ID="TextBox271" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox271_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label274" runat="server" Text="Total number of people in each priority population
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox272" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label275" runat="server" Text="School Based
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox273" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label276" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox274" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label277" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label278" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label279" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox275" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox276" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel37" runat="server" DefaultButton="Button37">
                                                            <asp:Button ID="Button37" runat="server" Text="Button" Style="display:none" OnClick="Button37_Click"  />
                                                        <asp:TextBox ID="TextBox277" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox277_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label280" runat="server" Text="Female
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox278" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label281" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label282" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label283" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox279" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox280" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel38" runat="server" DefaultButton="Button38">
                                                            <asp:Button ID="Button38" runat="server" Text="Button" Style="display:none" OnClick="Button38_Click"  />
                                                        <asp:TextBox ID="TextBox281" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox281_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label284" runat="server" Text="Community based
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox282" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label285" runat="server" Text="Male
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox283" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label286" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label287" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label288" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox284" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox285" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel39" runat="server" DefaultButton="Button39">
                                                            <asp:Button ID="Button39" runat="server" Text="Button" Style="display:none" OnClick="Button39_Click"  />
                                                        <asp:TextBox ID="TextBox286" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox286_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label289" runat="server" Text="Female
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
                                        <td>
                                            <table class="style1" style="text-align: center">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label290" runat="server" Text="Age (10-14)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label291" runat="server" Text="Age (15-19)"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label292" runat="server" Text="Age (20-49)"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox288" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox289" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel40" runat="server" DefaultButton="Button40">
                                                            <asp:Button ID="Button40" runat="server" Text="Button" Style="display:none"  />
                                                        <asp:TextBox ID="TextBox290" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox290_TextChanged"></asp:TextBox>
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
                                                        <asp:Label ID="Label293" runat="server" Text="Number of the targeted population reached with individual and/or small group level HIV prevention interventions that are primarily focused on abstinence and/or being faithful, and are based on evidence and/or meet the minimum standards required.
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox291" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                            <asp:Label ID="Label294" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label295" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label296" runat="server" Text="Key Population"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox292" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox293" runat="server"  Width="52px"></asp:TextBox>
                                                        </td>
                                                    
                                                        <td>
                                                              <asp:Panel ID="Panel41" runat="server" DefaultButton="Button41">
                                                            <asp:Button ID="Button41" runat="server" Text="Button" Style="display:none" OnClick="Button41_Click"  />
                                                            <asp:TextBox ID="TextBox294" runat="server" Width="52px" AutoPostBack="False" OnTextChanged="TextBox294_TextChanged"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label297" runat="server" Text="Number of key populations reached with individual and/or small group level HIV preventive interventions that are based on evidence and/or meet the minimum standards required
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox295" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
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
                                                            <asp:Label ID="Label301" runat="server" Text="FSW:
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label302" runat="server" Text="PWID
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label298" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label299" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label303" runat="server" Text="MSM/TG
"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label300" runat="server" Text="MSM/TG who are sex workers 
"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox296" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox297" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox298" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox299" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox300" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                              <asp:Panel ID="Panel42" runat="server" DefaultButton="Button42">
                                                            <asp:Button ID="Button42" runat="server" Text="Button" Style="display:none" OnClick="Button42_Click"  />
                                                            <asp:TextBox ID="TextBox301" runat="server" AutoPostBack="False" Width="52px" OnTextChanged="TextBox301_TextChanged"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label304" runat="server" Text="Other Vulnerable Populations (Military, incarcerated persons, migrant workers, truck drivers, clients of sex workers and non-injecting drug users)
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox302" runat="server" Width="52px"></asp:TextBox>
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
                                                        <asp:Label ID="Label305" runat="server" Text="Number of individuals trained to promote HIV/AIDS prevention programs 
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox303" runat="server" BackColor="#CCCCCC" ReadOnly="true" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth ">
                                                <table style="width: 158px">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label306" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label307" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox304" runat="server" Width="52px" OnTextChanged="TextBox304_TextChanged"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                          <asp:Panel ID="Panel43" runat="server" DefaultButton="Button43">
                                                            <asp:Button ID="Button43" runat="server" Text="Button" Style="display:none" OnClick="Button43_Click"  />
                                                            <asp:TextBox ID="TextBox796" runat="server" AutoPostBack="False" OnTextChanged="TextBox304_TextChanged" Width="52px"></asp:TextBox>
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
                            <asp:View ID="View4" runat="server">
                                <table class="style1" style="border-style: solid; border-width: thin">
                                    <tr>
                                        <td style="color: #FFFFFF; font-size: medium; font-weight: bold; background-color: #9EBFD8; text-align: center">
                                            <asp:Label ID="Label308" runat="server" Text="Post Exposure Prophylaxis (PEP)
"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table class="style1">
                                                <tr>
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label309" runat="server" Text="Total Number of persons provided with Post Exposure prophylaxis
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
                                        <td>
                                            <div class="clearboth ">
                                                <table style="width: 158px">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label310" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label311" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox316" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="TextBox317" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label312" runat="server" Text="Number of persons provided OCCUPATIONAL Post Exposure prophylaxis
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox318" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth">
                                            <table style="width: 158px">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label313" runat="server" Text="Male"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="Label314" runat="server" Text="Female"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox ID="TextBox319" runat="server" Width="52px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                          <asp:Panel ID="Panel44" runat="server" DefaultButton="Button44">
                                                            <asp:Button ID="Button44" runat="server" Text="Button" Style="display:none" OnClick="Button44_Click"  />
                                                        <asp:TextBox ID="TextBox320" runat="server" OnTextChanged="TextBox320_TextChanged" Width="52px" AutoPostBack="False"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label315" runat="server" Text="Number of persons provided NON OCCUPATIONAL Post Exposure prophylaxis
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox321" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth">
                                                <table style="width: 158px">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label316" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label317" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox322" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                              <asp:Panel ID="Panel45" runat="server" DefaultButton="Button45">
                                                            <asp:Button ID="Button45" runat="server" Text="Button" Style="display:none" OnClick="Button45_Click"  />
                                                            <asp:TextBox ID="TextBox323" runat="server" OnTextChanged="TextBox323_TextChanged" Width="52px" AutoPostBack="False"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label318" runat="server" Text="RAPE/ASSAULT VICTIMS Provided with  Post Exposure prophylaxis
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox324" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth">
                                                <table style="width: 158px">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label319" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label320" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox325" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                              <asp:Panel ID="Panel46" runat="server" DefaultButton="Button46">
                                                            <asp:Button ID="Button46" runat="server" Text="Button" Style="display:none" OnClick="Button46_Click"  />
                                                            <asp:TextBox ID="TextBox326" runat="server" OnTextChanged="TextBox326_TextChanged" Width="52px" AutoPostBack="False"></asp:TextBox>
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
                                                    <td class="auto-style42">
                                                        <asp:Label ID="Label322" runat="server" Text="Number of People Living with HIV/AIDS (PLHIV) reached a minimum package of PwP interventions
"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TextBox327" runat="server" BackColor="#CCCCCC" ReadOnly="True" Width="52px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class="clearboth">
                                                <table style="width: 158px">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label323" runat="server" Text="Male"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label324" runat="server" Text="Female"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox328" runat="server" Width="52px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                          <asp:Panel ID="Panel47" runat="server" DefaultButton="Button47">
                                                            <asp:Button ID="Button47" runat="server" Text="Button" Style="display:none" OnClick="Button47_Click"  />
                                                            <asp:TextBox ID="TextBox797" runat="server" AutoPostBack="False" OnTextChanged="TextBox797_TextChanged" Width="52px"></asp:TextBox>
                                                        </asp:Panel>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </asp:View>
                            <br />
                            <br />
                            <br />
                        </asp:MultiView>
                      <%-- </ContentTemplate>
                </asp:UpdatePanel>--%>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18" style="background-color: #999999; text-align: center">
                <asp:ImageButton ID="bntComplete" runat="server" ImageUrl="~/image/Complete.png" OnClick="bntComplete_Click" Width="90px" Visible="False" />
                <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/image/Submit.png" OnClick="btnSave_Click" CausesValidation="false" />
&nbsp;<asp:ImageButton ID="btnCancel" runat="server" ImageUrl="~/image/Clear1.png" OnClick="btnCancel_Click" Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

