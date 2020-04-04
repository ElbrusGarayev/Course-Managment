<%@ Page Language="VB" MasterPageFile="~/CMaster.master" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table id="Table1" cellpadding="0" cellspacing="0" runat="server" width="100%">
         <tr>
          <td>
            <table id="Table2" runat="server" cellspacing="0" border="1" width="100%" >
             <tr>
              <td valign="top" style="width: 191px; height:100%">               
              <asp:Image ID="Image1" runat="server" Height="194px" ImageUrl="~/images/staff.png" Width="193px" />
                <td  valign="top" style="width: 417px">
               <table id="Table3" cellspacing="0" runat="server">
                <tr>
                 <th colspan="3">
                  <asp:Label ID="Label1" runat="server" Text="Staff Details" Width="416px" BackColor="#055FA5" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="33px"></asp:Label>
                 </th>
                </tr>
                <tr>
                 <td>
                                <asp:Label ID="Label2" runat="server" Text="Staff Id" Width="63px"></asp:Label></td>
                 <td>
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtsid" runat="server"></asp:TextBox></td>
                </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label></td>
                       <td>
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtname" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label></td>
                       <td>
                                <asp:RadioButton CssClass="btn btn-info" Width="100%" ID="rmale" runat="server" AutoPostBack="True" GroupName="Gender"
                                    Text="Male"  />
                                <asp:RadioButton CssClass="btn btn-info" Width="100%" ID="rfemale" runat="server" AutoPostBack="True" GroupName="Gender"
                                    Text="Female" /></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label  ID="Label5" runat="server" Text="Date Of Birth" ></asp:Label></td>
                       <td>
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtdob" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label6" runat="server" Text="Present Address" ></asp:Label></td>
                       <td>
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtpresent" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label7" runat="server" Text="Permanent Address"></asp:Label></td>
                       <td>
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtpermanent" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label8" runat="server" Text="Contact No"></asp:Label></td>
                       <td>
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtcno" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td style="height: 26px">
                                <asp:Label ID="Label9" runat="server" Text="Profession" ></asp:Label></td>
                       <td style="height: 26px">
                                <asp:TextBox CssClass="btn btn-info" Width="100%" ID="txtqual" runat="server"></asp:TextBox></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label10" runat="server" Text="Department" ></asp:Label></td>
                       <td>
                                <asp:DropDownList CssClass="btn btn-info" ID="ddldept" Width="100%" runat="server" AutoPostBack="True">
                                </asp:DropDownList></td>
                   </tr>
                   <tr>
                       <td>
                                <asp:Label ID="Label11" runat="server" Text="Category"></asp:Label></td>
                       <td>
                                <asp:DropDownList CssClass="btn btn-info" ID="ddlcat" runat="server" AutoPostBack="True" Width="100%">
                                </asp:DropDownList></td>
                   </tr>
                   <tr>
                       <td>
                       </td>
                       <td>
                       </td>
                   </tr>
                   <tr>
                       <td colspan="2">
                                <table style="height: 30px">
                                    <tr>
                                        <td >
                                            &nbsp;
                                            <asp:Button ID="Bclear" CssClass="btn btn-info" runat="server" Text="Clear" /></td>
                                        <td >
                                            &nbsp;
                                            <asp:Button ID="Bsave" CssClass="btn btn-success" runat="server" Text="Insert" /></td>
                                        <td >
                                            &nbsp;&nbsp;
                                            <asp:Button ID="Bedit" CssClass="btn btn-primary" runat="server" Text="Update" /></td>
                                        <td >
                                            &nbsp;
                                            <asp:Button ID="Bdelete" CssClass="btn btn-danger" runat="server" Text="Delete" /></td>
                                        <td >
                                            &nbsp;<asp:Button ID="Bexit" CssClass="btn btn-info" runat="server" Text="Exit" /></td>
                                    </tr>
                                </table>
                       </td>
                   </tr>
               </table>
                </td> 
                </td>
               <td valign="top">
                <table>
                 <tr>
                  <td><asp:ListBox CssClass="btn btn-info" ID="lbval" runat="server" AutoPostBack="True" Height="344px" Width="224px">
                  </asp:ListBox>
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

