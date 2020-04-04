<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LabEntry.aspx.vb" MasterPageFile="~/CMaster.master" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td align="center">
                    <table border="1" cellpadding="0" cellspacing="0" style="width: 720px">
                        <tr>
                            <th > 
                                <asp:Label ID="lblheader" ForeColor="White" runat="server" Width="716px" BackColor="#055FA5" style="text-align:center" Font-Size="X-Large" Text="Computer Lab Entry"></asp:Label>
                            </th>
                        </tr>
                        <tr>
                            <td height="200" style="width: 609px">
                                <table id="Table1" runat="server" cellpadding="0" cellspacing="0" >
                                    <tr>
                                        <td valign="top">
                                            <asp:Image ID="img1labentry" runat="server" Height="200px" ImageUrl="~/images/lab.jpg"
                                                Width="100%" />
                                        </td>
                                        
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" >
                             <table cellspacin="0" cellpadding="0" runat="server" border="1" bordercolor="gray" style="height: 238px"> 
                              <tr>
                               <td>
                               
                              
                        <table cellpadding="0" cellspacing="0" runat="server" width="50%">
                            <tr>
                                <td align="right" style="width: 112px">
                                </td>
                                <td align="left">
                                </td>
                            </tr>
                         <tr>
                          <td align="right" style="width: 112px">
                                            <asp:Label ID="lbldate" runat="server" Text="Date" CssClass="Text"></asp:Label>&nbsp;</td>
                          <td align="left">
                                            <asp:TextBox CssClass="btn btn-info" ID="txtdate" runat="server" Width="150px"></asp:TextBox></td>
                         </tr>
                            <tr>
                                <td align="right" style="width: 112px">
                                            <asp:Label ID="Label1" runat="server" Text="Course Id" Width="69px" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td align="left">
                                            <asp:DropDownList CssClass="btn btn-info" ID="ddlcrslist" runat="server" AutoPostBack="True" Width="158px">
                                            </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 112px">
                                            <asp:Label ID="Label2" runat="server" Text="Course Name" Width="92px" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td align="left">
                                            <asp:TextBox CssClass="btn btn-info" ID="txtcname" runat="server" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right" style="height: 24px; width: 112px;">
                                            <asp:Label ID="Label3" runat="server" Text="Department Name" Width="107px" CssClass="Text"></asp:Label></td>
                                <td align="left" style="height: 24px">
                                            <asp:TextBox CssClass="btn btn-info" ID="txtdeptname" runat="server" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 112px">
                                            <asp:Label ID="Label4" runat="server" Text="In Time" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td align="left">
                                            <asp:TextBox CssClass="btn btn-info" ID="txtintime" runat="server" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 112px">
                                            <asp:Label ID="Label5" runat="server" Text="Out Time" CssClass="Text"></asp:Label>&nbsp;</td>
                                <td align="left">
                                            <asp:TextBox CssClass="btn btn-info" ID="txtouttime" runat="server" Width="150px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td >
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>

                                                    <td>
                                                        <asp:Button ID="Bclear" CssClass="btn btn-info" runat="server" Text="Clear" Width="100%" /></td>
                                                    <td >
                                                        <asp:Button ID="Bsave" CssClass="btn btn-success" runat="server" Text="Insert" Width="100%"/></td>
                                                    <td >
                                                        <asp:Button ID="Bexit" runat="server" CssClass="btn btn-danger" Text="Exit" Width="100%"/></td>
 
                            </tr>
                        </table>
                                 </td>
                              </tr>
                             </table>
                            </td>
                        </tr>
                        <tr>
                       <td>
                       </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
   </asp:Content>