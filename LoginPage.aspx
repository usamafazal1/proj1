<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="proj1.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"
        integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N"
        crossorigin="anonymous"/>
    <title>LoginPage</title>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <div class="row justify-content-center m-5">
                <asp:Label ID="WelcomeMessage" Class="display-4 bg-dark font-weight-bold p-5" Style="border-radius: 10px; color:white;" runat="server" Text="Inventory System"></asp:Label>

                <div class="m-3 p-5 w-50 text-center font-weight-bolder bg-secondary  " style="color:white; border-radius: 50px">

                    <h1>Login Page</h1>

                    <asp:Label ID="LbluserName" runat="server" Text="Username"></asp:Label>
                    <br />
                    <asp:TextBox ID="userName" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="LblpassWord" runat="server" Text="Password"></asp:Label>
                    <br />
                    <asp:TextBox ID="passWord" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Login" Class="btn btn-dark" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Status"></asp:Label>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
