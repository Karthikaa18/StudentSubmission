<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="myproject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">    
        <center>
            <h1>Student Login</h1>
    <center>
        <br />
        <br />
       
        <table height="400px" width="500px" style="background-color: #808080">
          
                <tr>
                    <td align="center" colspan="2"><h1>Log In Now</h1></td>
                </tr>

                <tr>
                    <td align="center">Student ID</td>
                    <td align="center">
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="center">Password</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /><br>
                        <label>Create New Account - </label>
                        <a href="WebForm3.aspx">Register Here</a>
                    </td>
                </tr>
            
            </table>
        
        <br />
        <br />
    </center>
</center>
    </form>
</body>
    <script src="~/Scripts/bootstrap.min.js"></script>

</html>
