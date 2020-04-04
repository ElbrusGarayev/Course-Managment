<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StudentDetails.aspx.vb" Inherits="StudentDetails" MasterPageFile="~/CMaster.master" Title="StudentDetails Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


        <table width="100%" runat="server" cellspacing="0" cellpadding="0" >
            <tr>
                <td colspan="4" align="center">
                    <asp:Label ID="Label1" runat="server" BackColor="#055FA5" Font-Bold="True"
                        Font-Size="X-Large" ForeColor="White" Text="STUDENT DETAILS" Width="582px"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Image ID="Image1" runat="server" Height="276px" Width="100%" ImageUrl="~/images/details.png" /></td>
            </tr>
            <tr>
                <td align="right" style="height: 22px">
                    <asp:Label ID="Label2" runat="server" Text="Course Name" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White" ></asp:Label></td>
                <td style="width: 100px; height: 22px;">
                    <asp:DropDownList CssClass="btn btn-info" ID="ddlcname" runat="server" AutoPostBack="True" Width="150px">
                    </asp:DropDownList></td>
                <td  align="right" style="height: 22px">
                    <asp:Label ID="Label3" runat="server" Text="Department Name" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label></td>
                <td style="width: 100px; height: 22px;">
                    <asp:DropDownList CssClass="btn btn-info" ID="dname" runat="server" AutoPostBack="True" Width="150px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="4">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label4" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Students Information:"
                        Width="190px"></asp:Label></td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td colspan="4" align="center">
                    <asp:DataGrid ID="dg" runat="server"  Width="100%" DataKeyField="sregno" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                        <FooterStyle BackColor="#CCCCCC" />
                        <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <AlternatingItemStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="#055FA5" Font-Bold="True" ForeColor="White" />
                    </asp:DataGrid>
                    
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="Bview" CssClass="btn btn-info" runat="server" Text="VIEW" Width="91px" BorderStyle="Ridge" /></td>
                <td style="width: 100px">
                    <asp:Button ID="Bexit" CssClass="btn btn-info" runat="server" Text="EXIT" Width="90px" BorderStyle="Ridge" /></td>
                <td style="width: 100px">
                </td>
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
        </table>
    
   </asp:Content>