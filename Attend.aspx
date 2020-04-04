<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Attend.aspx.vb" MasterPageFile="~/CMaster.master" Inherits="Attend" Theme="Theme1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellspacing="0" cellpadding="0" runat="server" width="100%">
<tr>
<td style="height:50px">

</td>
</tr>
<tr>
<td align="center" valign="top">
      <table border="1" bordercolor="gray" style="width: 577px" >
      <tr>
      <td>
      
      
        <table style="z-index: 100; left: 24px;  top: 24px">
            <tr>
                <td align="center" colspan="1" rowspan="5">
                    <asp:Image ID="Image1" runat="server" Height="278px" ImageUrl="~/images/atted.jpg"
                        Width="227px" /></td>
                <td colspan="3" align="center" valign="top" >
                <table cellspacing="0" cellpadding="0" runat="server">
                <tr>
                 <th colspan="3" align="center">
                     <asp:Label ID="Label1" runat="server" Text="Attendence Details" BackColor="#055FA5" Font-Bold="True"   Font-Size="X-Large" Width="349px" ForeColor="White"></asp:Label>
                 </th>
                </tr>
                    <tr>
                        <td align="right" style="width: 404px; height:50px">
                         
                        </td>
                        <td align="left" colspan="2">
                        
                        </td>
                    </tr>
                    <tr>
                    <td align="center">
                      <table style="width:50%">
                       <tr>
                <td >
                    <asp:Label ID="Label2" runat="server" Text="Date" CssClass="Text"></asp:Label></td>
                <td colspan="2"  >
                    <asp:TextBox ID="TextBox1" CssClass="btn btn-info" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="Label3" runat="server" Text="Reg no" Width="100%" CssClass="Text"></asp:Label></td>
                <td colspan="2">
                    <asp:DropDownList ID="Regddl" CssClass="btn btn-info" runat="server" AutoPostBack="True" Width="100%">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList></td>
                
            </tr>
            <tr>
                <td >
                    <asp:Label ID="Label4" runat="server"  Text="Student Name" Width="100%" CssClass="Text"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox2" CssClass="btn btn-info" runat="server" Width="144px"></asp:TextBox></td>
            <tr>
                <td >
                    <asp:Label ID="Label5" runat="server" Text="Attendance" CssClass="Text"></asp:Label></td>
                <td colspan="2">
                    <asp:DropDownList ID="attendddl" CssClass="btn btn-info" runat="server" Width="100%">
                    </asp:DropDownList></td>
            </tr>
                          <tr>
                                <td >
                                    <asp:Button ID="Bclear" runat="server" CssClass="btn btn-primary" Text="Clear" Width="100%" BorderStyle="Ridge" /></td>
                                <td>
                                    <asp:Button ID="Bsave" runat="server" CssClass="btn btn-success" Text="Save" Width="100%" BorderStyle="Ridge" /></td>
                                <td >
                                    <asp:Button ID="Bexit" runat="server" CssClass="btn btn-danger" Text="Exit" Width="100%" BorderStyle="Ridge" /></td>
            </tr>
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
      </table>
        </td>
</tr>
</table>

    </asp:Content>
