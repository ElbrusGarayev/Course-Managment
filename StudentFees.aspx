<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="StudentFees.aspx.vb" Inherits="StudentFees" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" runat="server">
        <tr>
            <td  align="center">
             <table cellspacing="0" cellpadding="0" runat="server" border="1" bordercolor="gray">
              <tr>
               <td>               
               
                <table style="width: 392px; height: 325px">
                    <tr>
                        <td style="width: 100px">
                            <asp:Image ID="Image1" runat="server" Height="218px" ImageUrl="~/Educational images/financial.jpg"
                                Width="394px" /></td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                        </td>
                    </tr>
                    <tr>
                        <td rowspan="5" style="width: 100px">
                            <table style="width: 388px; height: 182px">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label1" runat="server" Text="Date" Width="38px" CssClass="Text"></asp:Label>&nbsp;</td>
                                    <td align="left" >
                                        <asp:TextBox CssClass="btn btn-info" ID="txtdate" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td align="right" >
                                        <asp:Label ID="Label2" runat="server" Text="RegNo" CssClass="Text"></asp:Label>&nbsp;</td>
                                    <td align="left" >
                                        <asp:DropDownList CssClass="btn btn-info" ID="ddlregno" runat="server" AutoPostBack="True" Width="154px">
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td align="right" >
                                        <asp:Label ID="Label3" runat="server" Text="Student Name" CssClass="Text"></asp:Label>&nbsp;</td>
                                    <td align="left" >
                                        <asp:TextBox CssClass="btn btn-info" ID="txtsname" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td align="right" >
                                        <asp:Label ID="Label4" runat="server" Text="Semester" CssClass="Text"></asp:Label>&nbsp;</td>
                                    <td align="left" >
                                        <asp:DropDownList CssClass="btn btn-info" ID="ddlsem" runat="server" AutoPostBack="True" Width="146px">
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td align="right" >
                                        <asp:Label ID="Label5" runat="server" Text="Fees" CssClass="Text"></asp:Label>&nbsp;</td>
                                    <td align="left" >
                                        <asp:TextBox CssClass="btn btn-info" ID="txtfees" runat="server"></asp:TextBox></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <table style="width: 382px">
                                <tr>
                                    <td style="width: 100px; height: 40px" align="right">
                                        <asp:Button ID="Bclear" runat="server" CssClass="btn btn-info" Text="CLEAR" Width="100%" /></td>
                                    <td style="width: 100px; height: 40px"  align="center">
                                        <asp:Button ID="Bsave" runat="server" class="btn btn-success" Text="SAVE" Width="100%" /></td>
                                    <td style="width: 100px; height: 40px"  align="left">
                                        <asp:Button ID="Bexit" runat="server" class="btn btn-danger" Text="EXIT" Width="100%" /></td>
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

