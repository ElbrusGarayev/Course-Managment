<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="LibraryEntry.aspx.vb" Inherits="LibraryEntry" title="Library Entry Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="100%" runat="server">
        <tr>
            <td style="height: 8px" colspan="2" align="center">
              <table border="1" runat="server" bordercolor="gray">
               <tr>
                <td>
                
                
                <table style="width: 368px; height: 109px" id="TABLE1" language="javascript" onclick="return TABLE1_onclick()">
                    <tr>
                    
                        <td rowspan="5" valign="top" style="width: 286px">
                        <table background="images/bookent.jpg" width="200px" style="height:200px;"  >
                         <tr>
                          <td>
                          
                          </td>
                         </tr>
                        </table>
                            </td>
                        <td colspan="4" valign="top" style="height: 19px">
                        <table cellspacing="0" cellpadding="0" border="0" runat="server" width="100%">
                         <tr>
                          <th colspan="2">
                             <asp:Label ID="Label1" runat="server" Text="LIBRARY ENTRY DETAILS" Width="376px" BackColor="#055FA5" Font-Bold="True"  Font-Size="X-Large" ForeColor="White"></asp:Label>
                          </th>
                         </tr>
                         <tr>
                          <td>
                              &nbsp;</td>
                          <td>
                          </td>
                         </tr>
                            <tr>
                                <td>
                            <asp:Label ID="Label2" runat="server" Text="Date" Width="100%" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td>
                            <asp:TextBox CssClass="btn btn-info" ID="txtdate" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                            <asp:Label ID="Label3" runat="server" Text="Reg No" Width="100%" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td>
                            <asp:DropDownList CssClass="btn btn-info" ID="ddlregno" runat="server" AutoPostBack="True" Width="100%">
                            </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                            <asp:Label ID="Label4" runat="server" Text="Student Name" Width="100%" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td>
                            <asp:TextBox CssClass="btn btn-info" ID="ddlsname" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                            <asp:Label ID="Label5" runat="server" Text="Book Name" Width="100%" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td>
                            <asp:DropDownList CssClass="btn btn-info" ID="ddlbname" runat="server" AutoPostBack="True" Width="100%">
                            </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td align="right">
                            <asp:Label ID="Label6" runat="server" Text="Author Name" Width="100%" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td align="left">
                            <asp:TextBox CssClass="btn btn-info" ID="txtaname" runat="server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                            <table style="width: 373px">
                                <tr>
                                    <td>
                                        <asp:Button ID="Bclear" runat="server" CssClass="btn btn-info" Text="CLEAR" Width="100%"  />
                                        &nbsp;
                                    </td>
                                    
                                    <td>
                                        <asp:Button ID="Bsave" runat="server" CssClass="btn btn-success" Text="INSERT" Width="100%"  />
                                        &nbsp;</td>
                                    
                                    <td>
                                        <asp:Button ID="Bexit" runat="server" CssClass="btn btn-danger" Text="EXIT" Width="100%"  />&nbsp;</td>
                                    <td>
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
                
            </td>
        </tr>
    </table>
</asp:Content>

