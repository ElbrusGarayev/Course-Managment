<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LibraryDetails.aspx.vb"  MasterPageFile="~/CMaster.master" Inherits="_Default" Title="Library Details Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table  cellpadding="0" runat="server" width="100%">
 <tr>
  <td align="center"> 
   <table cellspacing="0" cellpadding="0" runat="server" border="1" bordercolor="gray" style="width: 380px; height: 261px">
    <tr>
     <td style="height: 240px" valign="top">
       <table>
            <tr>
                <td colspan="3" >
                                    <asp:Label ID="Label5" runat="server" BackColor="#055FA5" Font-Bold="True" 
                         Font-Size="X-Large" ForeColor="White" Text="LIBRARY DETAILS"
                        Width="426px"></asp:Label></td>
                <td style="width: 100px; height: 21px;">
                </td>
               
            </tr>
           <tr>
               <td colspan="3">
                   <asp:Image ID="Image1" runat="server" Height="156px" ImageUrl="~/images/library.jpg"
                       Width="426px" />
               </td>
           </tr>
            <tr>
                <td style="width: 96px" align="right">
                    <asp:Label ID="Label1" runat="server" Text="Course Name" Width="84px" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px" align="left">
                    <asp:DropDownList CssClass="btn btn-info" ID="ddlcname" runat="server">
                    </asp:DropDownList></td>
                <td rowspan="4" style="width: 100px">
                    <asp:ListBox CssClass="btn btn-info" ID="ListBox1" runat="server" Height="118px" Width="143px" AutoPostBack="True"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td style="width: 96px; height: 21px" align="right">
                    <asp:Label ID="Label2" runat="server" Text="Book Name" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px; height: 21px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 96px; height: 21px" align="right">
                    <asp:Label ID="Label3" runat="server" Text="Author Name" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px; height: 21px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 96px; height: 21px" align="right">
                    <asp:Label ID="Label4" runat="server" Text="Block No" CssClass="Text"></asp:Label>&nbsp;</td>
                <td style="width: 100px; height: 21px" align="left">
                    <asp:TextBox CssClass="btn btn-info" ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 96px; height: 21px">
                </td>
                <td style="width: 100px; height: 21px">
                </td>
                <td rowspan="1" style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="height: 21px" colspan="6">
                 <table cellpadding="0" cellspacing="0" width="100%" >
                  <tr>
                   <td>
                    <asp:Button ID="Bdelete" runat="server" CssClass="btn btn-danger" Text="DELETE" width="100%"/></td>
                   <td>
                   
                   <asp:Button ID="Bsave" runat="server" CssClass="btn btn-success" Text="INSERT" width="100%"/></td>                   
                    <td>
                     <asp:Button ID="Bclear" runat="server" CssClass="btn btn-primary" Text="CLEAR"  width="100%"/>
                   </td>
                   <td>
                    <asp:Button ID="Bedit" runat="server" CssClass="btn btn-info" Text="UPDATE" width="100%" />
                   </td>
                   <td>
                    <asp:Button ID="Bexit" runat="server" Text="Exit" CssClass="btn btn-danger" width="100%" />
                   </td>
                  </tr>
                 </table>
     </td>     
    </tr>
    <tr>     
      <td colspan="3">
      
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