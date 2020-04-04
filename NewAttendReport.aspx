<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="NewAttendReport.aspx.vb" Inherits="NewAttendReport" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="100%" runat="server">
        <tr>
            <td style="width: 100px; height: 16px;">
                <br />
                <br />
                <br />
                <br />
                <table style="width: 744px; margin-left:180px; height: 81px">
                    <tr>
                        <td colspan="3" align="center">
                            <asp:Label ID="Label1" runat="server" BackColor="#055FA5" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="DATEWISE ATTENDENCE REPORT"
                                Width="727px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:DataGrid ID="dg" runat="server" Height="98px" Width="746px" DataKeyField="sregno"/></td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                        </td>
                        <td style="width: 100px">
                            <table style="width: 176px; height: 21px">
                                <tr>
                                    <td style="width: 100px">
                                        <asp:Button ID="Bview" runat="server" CssClass="btn btn-info" Text="VIEW" /></td>
                                    <td style="width: 100px">
                                        <asp:Button ID="Bexit" CssClass="btn btn-danger" runat="server" Text="EXIT" /></td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 100px">
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

