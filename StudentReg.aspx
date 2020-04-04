<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/CMaster.master" CodeFile="StudentReg.aspx.vb" Inherits="_Default" Title="StudentregistrationPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" runat="server" width="100%">
 <tr>
  <td align="center" >
   <table cellspacing="0" width="600">
    <tr>
    <td>           
        <asp:Panel ID="Panel1" runat="server" Height="100%" Width="100%">
            <table cellspacing="0" cellpadding="0" width="100%"  border="0">
                <tr>
                    <td rowspan="13" valign="top" style="width: 29%">
                      <asp:Image ID="imgreg" runat="server" ImageUrl="~/images/registration.png" Height="200px" Width="148px" />
                     </td>
                    <td  colspan="4"  align="center" bgcolor="#055FA5" style="height: 16px; font-size:x-large;">
                     <asp:Label ID="lblregistration" runat="server" Text="Registration" Font-Bold="true" ForeColor="white"></asp:Label>
                    </td>
                    <td style="height: 16px">
                    </td>
                    <td align="right" style="height: 16px">
                    </td>
                    <td style="height: 16px">
                    </td>
                </tr>
                
                <tr>
                 
                     
                    <td  align="right">
                        <asp:Label ID="Label1" runat="server" Text="Date" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="rdate" runat="server" ReadOnly="True" ></asp:TextBox></td>
                    <td align="right" >
                        <asp:Label ID="Label11" runat="server" Text="CourseId" CssClass="Text"></asp:Label></td>
                    <td > 
                        <asp:DropDownList CssClass="btn btn-info" ID="cid" runat="server" AutoPostBack="True" >
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label2" runat="server" Text="RegNo" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="sregno" runat="server" ReadOnly="False" ></asp:TextBox></td>
                    <td align="right" >
                        <asp:Label ID="Label12" runat="server" Text="CourseName" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="cname" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label3" runat="server" Text="Name" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="sname" runat="server" ></asp:TextBox></td>
                    <td align="right" >
                        <asp:Label ID="Label13" runat="server" Text="Department" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="cdept" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label4" runat="server" Text="Gender" CssClass="Text"></asp:Label></td>
                    <td align="left" >
                        <asp:RadioButton CssClass="btn btn-info" ID="gmale" runat="server" Checked="True" GroupName="g" Text="male" />
                        <asp:RadioButton CssClass="btn btn-info" ID="gfemale" runat="server" GroupName="g" Text="female" /></td>
                    <td align="right" >
                        <asp:Label  ID="Label14" runat="server" Text="Duration" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="cdur" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label5" runat="server" Text="DateOfBirth" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="sdob" runat="server" ></asp:TextBox></td>
                    <td align="right">
                        <asp:Label ID="Label15" runat="server" Text="Category" CssClass="Text"></asp:Label></td>
                    <td>
                        <asp:TextBox CssClass="btn btn-info" ID="ccat" runat="server" ></asp:TextBox></td>
                    <td rowspan="5" >
                        </td>
                </tr>

                <tr>
                    <td align="right">
                        <asp:Label ID="Label6" runat="server" Text="FatherName" CssClass="Text"></asp:Label></td>
                    
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="fname" runat="server"></asp:TextBox></td>
                    <td rowspan="5" colspan="2"><asp:ListBox ID="lregno" Width="100%" Height="200px" runat="server" AutoPostBack="True"></asp:ListBox></td>
                    
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label7" runat="server" Text="FatherOccupation" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="foccup" runat="server" ></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label8" runat="server" Text="Present Address" Width="100px" CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="spreaddr" runat="server" ></asp:TextBox></td>
                   
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label9" runat="server" Text="Permanent Address"  CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="speraddr" runat="server" ></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td align="right" >
                        <asp:Label ID="Label10" runat="server" Text="ContactNo."  CssClass="Text"></asp:Label></td>
                    <td >
                        <asp:TextBox CssClass="btn btn-info" ID="sphno" runat="server" ></asp:TextBox></td>

                    
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="Bclear" runat="server" Text="Clear" CssClass="btn btn-info" width="100%"/></td>
                    <td >
                        <asp:Button ID="Bsave" runat="server" Text="Insert" CssClass="btn btn-success"  width="100%" /></td>
                    <td >
                        <asp:Button ID="Bedit" runat="server" Text="Update" CssClass="btn btn-primary"   width="100%"/></td>
                    <td >
                        <asp:Button ID="Bdelete" runat="server" CssClass="btn btn-danger" Text="Delete"  width="100%"/>

                    </td>
                    <td >
                        <asp:Button ID="bexit" runat="server" Text="Exit" CssClass="btn btn-info"  width="100%"/></td>
                </tr>
                <tr>
                    <td align="right">
                    </td>
                    <td>
                    </td>
                    <td rowspan="1" style="width: 100px">
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        </td>
     </tr>
   </table>
   
  </td>
 </tr>
</table>
    
</asp:Content>