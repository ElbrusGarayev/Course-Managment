<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AttendanceReport.aspx.vb" MasterPageFile="~/CMaster.master" Inherits="AttendanceReport" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table width="100%" runat="server">
<tr>
<td>
 <table cellspacing="0" cellpadding="0" runat="server">
  <tr>
  <td>
  <table id="Table1" cellspacing="0" cellpadding="0" runat="server" style="width: 880px" align="center">
  <tr>
   <td>
     <table id="Table2" style="width: 876px" border="1" cellpadding="0" cellspacing="0" runat="server" align="center">
            <tr>
                <td colspan="7">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 32px" align="right">
                    <asp:Label ID="Label1" runat="server" Text="FromDate"></asp:Label></td>
                <td style="width: 80px; height: 32px">
                <asp:TextBox CssClass="btn btn-info" ID="FrmDateTxt" runat="server"></asp:TextBox></td>
                <td style="width:10px; height: 32px;">
                <a href="javascript:void(null)" onclick="showCalendar1('<%=FrmDateTxt.ClientID%>','Frmdateimg')">
                <img id="Frmdateimg" src="./Images/pdate.gif" style="border:0px;margin:5px; vertical-align: middle" /></a>
                </td>
                <td style="width: 100px; height: 32px" align="right">
                    <asp:Label ID="Label2" runat="server" Text="ToDate"></asp:Label></td>
                <td style="width: 100px; height: 32px">
                    <asp:TextBox  CssClass="btn btn-info" ID="ToDateTxt" runat="server"></asp:TextBox></td>
                    <td style="width:10px; height:32px" align="right">
                    <a href="javascript:void(null)" onclick="showCalendar1('<%=ToDateTxt.ClientID%>','Todateimg')">
                    <img id="Todateimg"  src="./Images/pdate.gif" style="border:0px;margin:5px" /></a>
                     
                    </td>
                <td style="width: 100px; height: 32px">
                    <asp:Button ID="Button1" runat="server" Text="ShowReport"  /></td>
            </tr>
            <tr>
            <td colspan="7" align="center" valign="middle">
             <table cellpadding="0"  cellspacing="0" border="0" id="nodatetable" runat="server">
              <tr>
              <td style="height: 16px">
               <asp:Label ID="lblnotfound" runat="server"></asp:Label>
              </td>
              <td style="height: 16px">
               <asp:Label ID="NoDatelbl" runat="server" ForeColor="maroon"></asp:Label>
              </td>
                  </tr>
             </table>
            </td>
            </tr>
        </table>
    
    
        <table>
            <tr>
                <td style="width: 100px; height: 16px;" align="center" valign="top" >
                    &nbsp;
                </td>
            </tr>
            
            <tr>
             
                <td style="width: 100px">
                 <div id="print_area">
                    <asp:GridView ID="grdAttendance" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                         Width="871px" >
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <RowStyle BackColor="#EFF3FB" />
                        <EditRowStyle BackColor="#2461BF" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
            <td align="center">
             <script src="Js/script.js"></script>
             <asp:Button ID="btnprntpreview" runat="server" Text="Print Preview"  OnClientClick ="getPrint('print_area')" Width="136px" />&nbsp;
                &nbsp;<asp:Button ID="Printbuttn" runat="server" Text="Print..." OnClientClick="javascript:window.print();" Width="150px" /></td>
            <td>
                &nbsp;</td>
            </tr>
        </table>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

   </td>
  </tr>
 </table>
   
  </td>
  </tr>
 </table>
 
</td>
</tr>
</table>
</asp:Content>