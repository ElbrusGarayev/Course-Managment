<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="StudentRegReport.aspx.vb" Inherits="StudentRegReport" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    
                <asp:Label ID="Label1" CssClass="alert-info" style="text-align:center" runat="server" BackColor="#055FA5" Font-Bold="True"  Font-Size="Large" ForeColor="White" Text="STUDENT REGISTRATION REPORT"
                    Width="100%"></asp:Label>
        
              <asp:Button ID="Bshow" CssClass="btn btn-outline-info" Width="100%" runat="server" Text="SHOW DETAILS" />
            
                <asp:DataGrid ID="dg" runat="server" DataKeyField="sregno"  Width="100%" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <HeaderStyle BackColor="#055FA5" Font-Bold="True" ForeColor="#E7E7FF" />
                </asp:DataGrid>
             
</asp:Content>

