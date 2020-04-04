<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="LibBooksReport.aspx.vb" Inherits="LibBooksReport" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" CssClass="alert-info" runat="server" BackColor="#055FA5" Font-Bold="True" style="text-align:center"
        Font-Size="Large" ForeColor="White" Text="Library Book Report"
                    Width="100%"></asp:Label>
<asp:Button ID="BShow" runat="server" CssClass="btn btn-outline-info" Text="SHOW DETAILS" Width="100%" />
               
                <asp:DataGrid ID="dg" DataKeyField="cname" runat="server" Width="100%" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <HeaderStyle BackColor="#055FA5" Font-Bold="True" ForeColor="#E7E7FF" />
                </asp:DataGrid>
                
</asp:Content>

