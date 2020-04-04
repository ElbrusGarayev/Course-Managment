<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PaySlipNew.aspx.vb"  MasterPageFile="~/CMaster.master" Inherits="PaySlipNew" Title="PaySlipNew Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table id="Table1" width="100%" runat="server" cellpadding="0" cellspacing="0" >
  <tr>
   <td>
    
    <table id="Table2" width="100%" runat="server" border="0" bordercolor="gray"  cellpadding="0" cellspacing="0" >
            <tr>
                <td rowspan="5" style="width: 100px">
                    <asp:Image ID="Image1" runat="server" Height="173px" ImageUrl="~/images/pay.png"
                        Width="254px" /></td>
                <td colspan="5" style="height: 27px" align="center" >
                    <asp:Label ID="Label1" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="STAFF PAYSLIP DETAILS"
                        Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label2" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Staff Details"
                        Width="278px"></asp:Label></td>
                <td colspan="3">
                    <asp:Label ID="Label11" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Deduction Details"
                        Width="268px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label3" runat="server" Text="Date" Width="30px"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtdate" runat="server"></asp:TextBox></td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px" align="right">
                    <asp:Label ID="Label12" runat="server" Text="Tax"></asp:Label>&nbsp;</td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtpf" runat="server"></asp:TextBox></td>
                <td style="width: 100px" bordercolor="#ff3366" bordercolordark="#ff3300">
                </td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label4" runat="server" Text="Staff id" Width="45px"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:DropDownList CssClass="btn btn-info" ID="ddlsid" runat="server" AutoPostBack="True" Width="160px">
                    </asp:DropDownList></td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px" align="right">
                    <asp:Label ID="Label13" runat="server" Text="Insurance"></asp:Label>&nbsp;</td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtlic" runat="server"></asp:TextBox></td>
                <td style="width: 100px" bordercolor="#ff3366" bordercolordark="#ff3300">
                </td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label5" runat="server" Text="Staff Name"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtsname" runat="server"></asp:TextBox></td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px" align="right">
                    <asp:Label ID="Label14" runat="server" Text="Transport"></asp:Label>&nbsp;</td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txttrans" runat="server"></asp:TextBox></td>
                <td style="width: 100px" bordercolor="#ff3366" bordercolordark="#ff3300">
                </td>
            </tr>
            <tr>
                <td rowspan="6" style="width: 100px">
                    <asp:Image ID="Image2" runat="server" Height="289px" ImageUrl="~/images/pay.jpg"
                        Width="253px" /></td>
                <td style="height: 8px;" colspan="2">
                    <asp:Label ID="Label6" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Earning Details"
                        Width="277px"></asp:Label></td>
                <td style="width: 100px; height: 8px;" bordercolor="#ff3366" bordercolordark="#ff3300">
                </td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label7" runat="server" Text="Basic Pay" Width="64px"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtbpay" runat="server"></asp:TextBox></td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px" align="right">
                    <asp:Label ID="Label16" runat="server" Text="Total"></asp:Label>&nbsp;</td>
                <td bordercolor="#ff3366" bordercolordark="#ff3300" style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txttotal" runat="server"></asp:TextBox></td>
                <td style="width: 100px" bordercolor="#ff3366" bordercolordark="#ff3300">
                </td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label8" runat="server" Text="Extra hour"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtda" runat="server"></asp:TextBox></td>
                <td colspan="3">
                </td>
            </tr>
            <tr>
                
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label17" runat="server" Text="Net Salary"></asp:Label>&nbsp;</td>
                <td style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txtnet" runat="server"></asp:TextBox></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px" align="right">
                    <asp:Label ID="Label10" runat="server" Text="Total Earnings" Width="85px"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox CssClass="btn btn-info" ID="txttotearn" runat="server"></asp:TextBox></td>
                <td colspan="3">
                    <table>
                        <tr>
                            <td style="width: 100px">
                                <asp:Button ID="Btotearn" runat="server" Text="TOTAL EARNINGS" Width="100%" CssClass="btn btn-secondary"/>
                                </td>
                            <td style="width: 100px">
                                <asp:Button ID="Btotal" runat="server" Text="TOTAL" Width="100%" CssClass="btn btn-info" />
                                </td>
                            <td style="width: 100px">
                                <asp:Button ID="Bnet" runat="server" Text="NET SALARY" Width="100%" CssClass="btn btn-primary"/></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td >
                </td>
                <td >
                    <asp:Button ID="Bclear" runat="server" CssClass="btn btn-info" Text="CLEAR" Width="100%" />
                    </td>
                <td >
                    <asp:Button ID="Bsave" runat="server" Text="PAY" CssClass="btn btn-success" Width="100%" />
                    </td>
                <td >
                    <asp:Button ID="Bexit" runat="server" Text="EXIT" CssClass="btn btn-danger" Width="100%" />
                    </td>
                <td >
                </td>
            </tr>
        </table>
    
   </td>
  </tr>
 </table>

        
    
   </asp:Content>