<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="myproject.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style type="text/css">
        .auto-style2 {
            width: 631px;
        }
        .auto-style3 {
            width: 195px;
        }
    </style>
</head>
<body style="background-image:url(../images/assignment1.jpg)">
    <form id="form1" runat="server">
        <center>
            <h1>Personal information: </h1>
    <center>
        <br />
        <br />
       
        <table height="400px" width="500px" style="background-color: #808080">
          
                <tr>
                    <td align="center" colspan="2"><h1>Sign In Now</h1></td>
                </tr>

                <tr>
                    <td align="right" class="auto-style3">First Name</td>
                    <td align="center" class="auto-style2">
                        <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="right" class="auto-style3">Last Name</td>
                    <td align="center" class="auto-style2">
                        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style3">Email</td>
                    <td align="center" class="auto-style2">
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="right" class="auto-style3">Gender</td>
                        
                            <td align="center" class="auto-style2">
                        <label>Male:</label>
                        <asp:Radiobutton ID="male" runat="server" AutoPostBack="true" Checked="true" GroupName="my" ></asp:Radiobutton>
                        
                           <label>Female</label>
                     
                         <asp:Radiobutton ID="female" runat="server" AutoPostBack="false" GroupName="my" Checked="false"></asp:Radiobutton>
                        </td>
                    
                     </tr>               
             <tr>
                    <td align="right" class="auto-style3">Password</td>
                    <td align="center" class="auto-style2">
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br>

                    </td>
                </tr>
             </tr>
                <tr>
                    <td align="center" colspan="2">
                        <div class="registration">
                Already Registered
                <a class="" href="WebForm1.aspx">
                    Login
                </a>
            </div>

                    </td>
                </tr>
            
            </table>
        
        <br />
        <br />
    </center>
</center>
    
    </form>
</body>
</html>
