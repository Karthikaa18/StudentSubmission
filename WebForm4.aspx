<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="myproject.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Submitted</title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body style="background-image:url(../images/assignment1.jpg)">
    <form id="form1" runat="server">
        <table align="center" colspan="2" height="400px" width="500px" style="background-color: #808080" class="auto-style1">
          
                <tr>
                    <td align="center" colspan="2"> <center>
            <h1>Assignment has been submitted</h1>
                        <h1>Thank You</h1>
    <center>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go To Home</asp:LinkButton>
                    </td>
                </tr>
       
        </table>
    </form>
</body>
</html>
