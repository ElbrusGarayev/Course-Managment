<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body topmargin="0">
    <form id="form1" runat="server">
    <div>
    <table id="Table1" cellpadding="0" cellspacing="0" runat="server" border="0" width="100%">    
     <tr>     
      <td rowspan="10" height="100%" background="Images/bgleft.jpg" style="background-position:right top; background-repeat:repeat-y; width: 4%"></td>
      <td rowspan="10" width="1"  bgcolor="#000000" valign="top"></td>
      <td colspan="2" valign="top" style="height: 103px">
      <img src="" height="100px" style="width: 891px" />  
      </td>      
      <td rowspan="10" bgcolor="#000000" style="width: 1px"> </td>
      
      <td rowspan="10" width="4%" height="100%" background="Images/bgright.jpg" style="background-position:left top; background-repeat:repeat-y"></td>
     </tr>
     <tr>
      <td colspan="2" style="height:100%" valign="top">
      
        
   <table id="Table2" width="100%" runat="Server" style="height: 500px">
         <tr>
          
          <td style="width:30%" valign="top">
            
            <table  border="0" align="center" cellpadding="0" cellspacing="0" style="width: 257px">
    <tr>
      <td width="16" style="height: 16px"><img src="Images/top_lef.gif"width="16" height="16"></td>
      <td background="Images/top_mid.gif" style="height: 16px">
      <img src="Images/top_mid.gif" width="16" height="16"></td>
      <td style="width: 24px; height: 16px;"><img src="Images/top_rig.gif" width="24" height="16"></td>
    </tr>
    <tr>
      <td width="16" background="Images/cen_lef.gif"><img src="Images/cen_lef.gif" width="16" height="11"></td>
      <td align="center" valign="middle" bgcolor="#FFFFFF" >
      <table width="200" height="150">
       <tr>
        <td>
          <table cellspacing="0" cellpadding="0" border="0" style="height: 160px; width: 247px;">
   <tr>
    <th colspan="3" bgcolor="#333366" style="color:Yellow;">
     <asp:Label id="loginlbl" runat="server" Text="Admin Login" ForeColor="White"></asp:Label>
    </th>
   </tr>
   <tr>   
    <td style="height:10%" colspan="3">
       
    </td>
   </tr>
    <tr>
     <td align="right">
      <asp:Label ID="lbllogusername" runat="server" Text="ID"></asp:Label>&nbsp;
     </td>
     <td style="width: 152px">
      <asp:TextBox CssClass="btn btn-info" ID="txtlogusername" runat="server" Width="150px" ValidationGroup="logc" onfocus="foc1();" onblur="blur1();"></asp:TextBox>
       
     </td>
     <td style="width: 10px">
      <asp:RequiredFieldValidator ID="reqlogusername" runat="server" Text="*" ErrorMessage="Enter Userid" ControlToValidate="txtlogusername" ValidationGroup="logc"></asp:RequiredFieldValidator>
     </td>
    </tr>
              <tr>
                  <td align="right">
       <asp:Label ID="lbllogpassword" runat="server" Text="Password"></asp:Label>&nbsp;</td>
                  <td style="width: 152px">
      <asp:TextBox CssClass="btn btn-info" ID="txtlogpassword" runat="server" TextMode="password" Width="150px" ValidationGroup="logc"></asp:TextBox></td>
                  <td style="width: 10px">
       <asp:RequiredFieldValidator ID="reqlogpassword" runat="server" Text="*" ErrorMessage="Enter Password" ControlToValidate="txtlogpassword" ValidationGroup="logc"></asp:RequiredFieldValidator></td>
              </tr>
    <tr>
     <td colspan="3" align="center">
      <asp:Button ID="btnlogin" runat="server" Text="Login" BorderStyle="Ridge" Width="58px" ValidationGroup="logc"  />
     </td>     
    </tr>
    <tr>
    <td colspan="3" align="center" style="height: 19px">
       <font color="red"><asp:Literal ID="literromsg" runat="server"></asp:Literal></font></td>
    </tr>
       <tr>
           <td align="center" colspan="3">
               <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="34px" ShowMessageBox="True"
                   ShowSummary="False" ValidationGroup="logc" />
           </td>
       </tr>
       <tr>
           <td align="center" colspan="3" style="height: 19px">
      <asp:HyperLink ID="hyperlogforgotpassword" runat="server" NavigateUrl="#">Forgot Password</asp:HyperLink></td>
       </tr>
   </table>
        </td>
       </tr>
      </table>
      </td>
      <td background="Images/cen_rig.gif" style="width: 24px"><img src="Images/cen_rig.gif" width="24" height="11"></td>
    </tr>
    <tr>
      <td width="16" style="height: 16px"><img src="Images/bot_lef.gif" width="16" height="16"></td>
      <td background="Images/bot_mid.gif" style="height: 16px"><img src="Images/bot_mid.gif" width="16" height="16"></td>
      <td style="width: 24px; height: 16px"><img src="Images/bot_rig.gif" width="24" height="16"></td>
    </tr>
  </table>
            
            
            
          </td>
         </tr>
        </table>
        
      </td>
     </tr>
     <tr>
     <td colspan="2" bgcolor="#cccccc" align="center" valign="top">
     <asp:Label ID="lblfooter" runat="server">&copy cccc.com</asp:Label>
     </td>
     </tr>   
    </table>   
    </div>
    </form>
</body>
</html>
