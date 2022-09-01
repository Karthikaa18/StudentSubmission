<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="myproject.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment portal</title>
</head>
<body style="background-image:url(../images/assignment1.jpg)">
     
    <form id="form1" runat="server">
        <center>
            <h1>Student Assignment Form</h1>
    <center>
        <br />
        <br />
       
        <table height="400px" width="500px" style="background-color: #808080">
          
                <tr>
                    <td align="center" colspan="2"><h1>Sign In Now</h1></td>
                </tr>

                <tr>
                    <td align="center">Name</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="center">Student ID</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center">Mobile</td>
                    <td align="center">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td align="center">Email</td>
                    <td align="center">
                       <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
             <tr>
                    <td align="center">File</td>
                    <td align="center">
                       <asp:FileUpload ID="FileUpload1" runat="server" />
            
            <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="File Name"/>
                    <asp:TemplateField ItemStyle-HorizontalAlign = "Center">
                        <ItemTemplate>
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                         <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

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
