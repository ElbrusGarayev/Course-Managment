<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="PaySlipReport.aspx.vb" Inherits="PaySlipReport" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Label ID="Label1" CssClass="alert-info" runat="server" BackColor="#055FA5" Font-Bold="True" style="text-align:center"  Font-Size="Large" ForeColor="White" Text="Payslip Report"
                    Width="100%"></asp:Label>
                   <asp:Button ID="Bshow" CssClass="btn btn-outline-info" runat="server" Text="SHOW DETAILS" Width="100%" />                  
                   
                    <asp:DataGrid ID="dg" runat="server" DataKeyField="eid"  Width="100%" BackColor="#055FA5" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                        <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                        <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                        <HeaderStyle BackColor="#055FA5" Font-Bold="True" ForeColor="#E7E7FF" />
                    </asp:DataGrid>    
                   
</asp:Content>

