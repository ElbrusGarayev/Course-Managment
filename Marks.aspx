<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Marks.aspx.vb" MasterPageFile="~/CMaster.master" Inherits="Marks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellspacing="0" cellpadding="0" runat="server" width="100%">
  <tr>
   <td valign="top">  
   <table border="1" runat="server" bordercolor="gray">    
    <tr> 
     <td>
      
     
        <table border="0" runat="server" bordercolor="gray">
            <tr>
                <td rowspan="11" style="width: 100px" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="363px" Width="287px" ImageUrl="~/Educational images/success.jpg" /></td>
                <td colspan="4" align="left" valign="top" >
                    
                    <asp:Label ID="Label1" runat="server" BackColor="#055FA5" Font-Bold="True" 
                         Font-Size="X-Large" ForeColor="White" Text="SEMESTER MARKS DETAILS"
                        Width="100%"></asp:Label></td>
                <td colspan="1">
                </td>
            </tr>
            <tr>
                <td  align="right">
                    <asp:Label ID="Label2" runat="server" Text="Reg No:" CssClass="Text"></asp:Label>&nbsp;</td>
                <td align="left" >
                    <asp:DropDownList CssClass="btn btn-info" ID="Regddl" runat="server" Width="154px" AutoPostBack="True">
                    </asp:DropDownList></td>
                <td  align="right">
                    <asp:Label ID="Label6" runat="server" Text="Semester III" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="txtsem3" runat="server" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td  align="right">
                    <asp:Label ID="Label3" runat="server" Text="Student Name" Width="85px" CssClass="Text"></asp:Label>&nbsp;</td>
                <td align="left" >
                    <asp:TextBox CssClass="btn btn-info" ID="txtstdname" runat="server" Width="150px"></asp:TextBox></td>
                <td  align="right">
                    <asp:Label ID="Label7" runat="server" Text="Semester IV" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px; height: 21px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="txtsem4" runat="server" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td  align="right">
                    <asp:Label ID="Label4" runat="server" Text="Semester I" CssClass="Text" Width="63px"></asp:Label>&nbsp;</td>
                <td align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="txtsem1" runat="server" Width="150px"></asp:TextBox></td>
                <td align="right">
                    <asp:Label ID="Label8" runat="server" Text="Semester V" CssClass="Text"></asp:Label>&nbsp;</td>
                <td align="left" >
                    <asp:TextBox CssClass="btn btn-info" ID="txtsem5" runat="server" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label5" runat="server" Text="Semester II" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="txtsem2" runat="server" Width="150px"></asp:TextBox></td>
                <td align="right" >
                    <asp:Label ID="Label9" runat="server" Text="Semester VI" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="txtsem6" runat="server" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px">
                </td>
                <td style="width: 100px; height: 21px">
                </td>
                <td style="width: 100px; height: 21px">
                </td>
                <td style="width: 100px; height: 21px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 22px;">
                </td>
                <td  align="right">
                    <asp:Label ID="Label10" runat="server" Text="OverAll Total" CssClass="Text"></asp:Label></td>
                <td style="width: 100px; height: 22px;" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="tot" runat="server" Width="150px"></asp:TextBox></td>
                <td style="width: 100px; height: 22px;" align="left">
                    <asp:Button ID="Btotal" runat="server" CssClass="btn btn-info" Text="Total" Width="70%" /></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="4" rowspan="2" style="height: 59px" align="center">
                    <table>
                        <tr>
                            <td style="width: 100px">
                                <asp:Button ID="BClear" runat="server" CssClass="btn btn-info" Text="Clear" Width="100%" /></td>
                            <td style="width: 100px">
                                <asp:Button ID="Bsave" runat="server" CssClass="btn btn-success" Text="Insert" Width="100%" /></td>
                            <td style="width: 100px">
                                <asp:Button ID="Bedit" runat="server" CssClass="btn btn-primary" Text="Update" Width="100%" /></td>
                            <td style="width: 100px">
                                <asp:Button ID="Bsearch" runat="server" CssClass="btn btn-secondary" Text="Search" Width="100%" /></td>
                            <td style="width: 100px">
                                <asp:Button ID="Bexit"  runat="server" CssClass="btn btn-danger" Text="Exit" Width="100%" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
            </tr>
            <tr>
                <td style="width: 100px; height: 24px">
                </td>
                <td style="width: 100px; height: 24px">
                </td>
                <td style="width: 100px; height: 24px">
                </td>
                <td style="width: 100px; height: 24px">
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