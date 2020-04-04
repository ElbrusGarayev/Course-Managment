<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="Course.aspx.vb" Inherits="Course" title="Course Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" runat="server" cellpadding="0" cellspacing="0">
     <tr>
      <td align="center">
       <table cellspacing="0" cellpadding="0" runat="server" width="100%">
        <tr>
         <td height="100%" style="width:25% ">
          <table cellspacing="0" cellpadding="0" runat="server">
           <tr>
            <td>
             <asp:Image ID="Image1" runat="server" Height="225px" ImageUrl="~/images/detail.png"
              Width="226px" />
            </td>
            
           </tr>
           
          </table>
         </td>
         <td valign="top" align="left">
         
              
              
             <table  style="width: 600px; height: 145px">
                    <tr>
                       
                        <td colspan="2" align="center" valign="top">
                            <asp:Label ID="Label1" runat="server" BackColor="#055FA5" Font-Bold="True" 
                                Font-Size="X-Large" ForeColor="White" Text="COURSE DETAILS"
                                Width="427px"></asp:Label></td>
                        <td align="center" colspan="1" rowspan="6" style="width: 100px">
                            <asp:ListBox CssClass="btn btn-primary" ID="lbval" runat="server" AutoPostBack="True" Height="100%" Width="100%">
                            </asp:ListBox></td>
                    </tr>
                    <tr>
                        <td  align="right" >
                            <asp:Label ID="Label2" runat="server"  Text="Course ID"  CssClass="Text"></asp:Label>&nbsp;</td>
                        <td style="height: 2px">
                            <asp:TextBox CssClass="btn btn-info" ID="txtcid" runat="server" Width="80%"></asp:TextBox>
                         </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label3" runat="server"  Text="Course Name"  CssClass="Text"></asp:Label>&nbsp;
                        </td>
                        <td>
                            <asp:DropDownList CssClass="btn btn-info" ID="ddlcname" runat="server" AutoPostBack="True" Width="80%">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" >
                            <asp:Label ID="Label4" runat="server"  Text="Duration"  CssClass="Text"></asp:Label>&nbsp;</td>
                        <td >
                            <asp:DropDownList ID="ddldur" CssClass="btn btn-info" runat="server" AutoPostBack="True" Width="80%">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" >
                            <asp:Label ID="Label5" runat="server"  Text="Department Name"  CssClass="Text"></asp:Label>&nbsp;</td>
                        <td align="left" >
                             <asp:DropDownList ID="ddldept" CssClass="btn btn-info" runat="server" AutoPostBack="True" Width="80%">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" >
                            <asp:Label ID="Label6" runat="server"  Text="Category"  CssClass="Text"></asp:Label>&nbsp;</td>
                        <td align="left" >
                            <asp:DropDownList ID="ddlcat" CssClass="btn btn-info" runat="server" AutoPostBack="True" Width="80%">
                            </asp:DropDownList></td>
                       
                    </tr>
                    <tr>
                        <td colspan="2" rowspan="2" align="right">
                            <table style="width: 382px; height: 38px">
                                <tr>
                                    <td style="width: 100px">
                                        <asp:Button ID="Bclear" runat="server" CssClass="btn btn-info" Text="CLEAR"  /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="BSave" runat="server" CssClass="btn btn-success" Text="INSERT"  /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Bedit" runat="server" CssClass="btn btn-primary" Text="UPDATE" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Bdelete" runat="server" CssClass="btn btn-danger" Text="DELETE"  /></td>
                                    <td style="width: 100px"> 
                                        <asp:Button ID="Bexit" runat="server" CssClass="btn btn-info" Text="EXIT"  /></td>
                                    <td style="width: 100px">
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td colspan="1" rowspan="2" style="width: 100px">
                        </td>
                    </tr>
                    <tr>
                    </tr>
                </table>
         </td>
         
        </tr>
       </table>
      </td>
     </tr>
        <tr>
            <td  align="center">
                        
             <table border="1" bordercolor="gray">
              <tr>
              <td>
                </td>
              </tr>
             </table>
            
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
               
            </td>
        </tr>
    </table>
</asp:Content>

