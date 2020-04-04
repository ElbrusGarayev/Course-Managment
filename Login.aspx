<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <title>Untitled Page</title>
    <style>
        body{
            background-image: linear-gradient(120deg, #84fab0 0%, #8fd3f4 100%);
        }
        
        #tname{
            font-family:'Banjax Notched';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;</div>
        <div class="container">
            <div class="row" style="height:180px;"></div>
            <div class="row">
            <div class="col"></div>
                <div class="col">
        <table>
            <tr>
                <td colspan="4" align="center">
                    <asp:Label ID="lbl2" runat="server" Text="Codex Administration Login" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Black" Width="336px"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" rowspan="3">
                    <asp:Image ID="Image1" runat="server" Height="192px" ImageUrl="~/Educational images/e12.png"
                        Width="192px" /></td>
                <td colspan="2" style="height: 73px">
                    <asp:Label ID="lname" runat="server" Width="268px" Font-Bold="True" Font-Size="Large" Height="24px" Font-Italic="True" Text="Enter Your Username"></asp:Label>
                    <asp:TextBox ID="tname"  CssClass="btn btn-info" runat="server" Width="184px"></asp:TextBox>
                    &nbsp;&nbsp; 
                    <asp:Label ID="Label1" runat="server" Text="Enter Your Password" Font-Italic="True" Width="268px" Font-Bold="True" Font-Size="Large" Height="24px"></asp:Label><br />
                    &nbsp;<asp:TextBox CssClass="btn btn-info" ID="TextBox1" runat="server" Width="184px" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;&nbsp;<asp:Button ID="Button1"  CssClass="btn btn-success" runat="server" Text="Login" Width="72px" />
                    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn btn-danger" Width="80px" /></td>
            </tr>
            <tr>
                <td> 
                    <asp:Label ID="lblmsg" runat="server" ForeColor="Red">Incorrect Password!</asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
                <td style="width: 100px">
                    </td>
            </tr>
        </table></div>
            <div class="col"></div>
            </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
 
</body>
</html>
