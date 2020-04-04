<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Exam.aspx.vb" Inherits="Exam" MasterPageFile="~/CMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellspacing="0" cellpadding="0" runat="server"  width="100%" border="0" bordercolor="gray">
     <tr>
     <td align="center">
      <table border="1" bordercolor="gray">
       <tr>
       <td >
              <table >         
            <tr>
                <td rowspan="11" style="width: 100px" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="340px" ImageUrl="~/images/exam.jpg"
                        Width="274px" /></td>
                <td colspan="5" align="center" valign="top">
                    <asp:Label ID="Label1" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="EXAMINATION DETAILS"
                        Width="519px"></asp:Label></td>
            </tr>
            <tr>
                <td  align="right">
                    <asp:Label ID="Label2" runat="server" Text="Date" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtdate" CssClass="btn btn-info" runat="server" Width="100%"></asp:TextBox></td>
                <td colspan="3" rowspan="10">
                </td>
            </tr>
            <tr>
                <td align="right" >
                    <asp:Label ID="Label3" runat="server" Text="From RegNo" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:DropDownList Width="100%" ID="ddlfromreg" CssClass="btn btn-info" runat="server" AutoPostBack="True">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right" >
                    <asp:Label ID="Label4" runat="server" Text="To RegNo" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:DropDownList Width="100%" ID="ddltoreg" CssClass="btn btn-info" runat="server" AutoPostBack="True" >
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label5" runat="server" Text="Hall No" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:DropDownList Width="100%" ID="ddlhallno" CssClass="btn btn-info" runat="server" AutoPostBack="True" >
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label6" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Noon"
                        Width="246px"></asp:Label></td>
            </tr>
            <tr>
                <td  >
                    <asp:RadioButton Width="100%" ID="rfore" CssClass="btn btn-info" runat="server" AutoPostBack="True" GroupName="Noon" Text="Fore Noon" />
                
                    <asp:RadioButton Width="100%" ID="rafter" CssClass="btn btn-info"  runat="server" AutoPostBack="True" GroupName="Noon" Text="After Noon" /></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label7" runat="server" Text="Timings" CssClass="Text"></asp:Label>&nbsp;</td>
                <td >
                    <asp:TextBox Width="100%" ID="txttimings"  CssClass="btn btn-info" runat="server" ></asp:TextBox>
                    <asp:Button Width="100%" ID="Btime" runat="server" CssClass="btn btn-outline-dark" Text="Get Your Timings" /></td>
            </tr>
            <tr>
                <td align="right" >
                    <asp:Label ID="Label8" runat="server"  Text="Sheets" CssClass="Text"></asp:Label>&nbsp;</td>
                <td >
                    <asp:TextBox ID="txtsheets"  CssClass="btn btn-info" runat="server" Width="100%"></asp:TextBox>
                    <asp:Button ID="Bsheets" Width="100%" runat="server" CssClass="btn btn-outline-dark" Text="Get Your Available Sheets" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <table>
                        <tr>
                            <td >
                                <asp:Button ID="Bclear" runat="server" CssClass="btn btn-info" Text="CLEAR" BorderStyle="Ridge" Width="100%"/></td>
                            <td >
                                <asp:Button ID="Bsave" runat="server" CssClass="btn btn-success" Text="SET" BorderStyle="Ridge" Width="100%"/></td>
                            <td >
                                <asp:Button ID="Bexit" runat="server" CssClass="btn btn-danger" Text="EXIT" BorderStyle="Ridge" Width="100%"/></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
       
       
       </td>
       </tr> 
       
       
      </table>
     </td>
     </tr>
     <tr>
      <td align="center">     
   
     </td>
     </tr>
    </table>
    
</asp:Content>
