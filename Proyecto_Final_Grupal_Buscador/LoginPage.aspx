<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>



   <link rel="stylesheet" type="text/css" href="LoginPageComp/LoginPageStyles.css"/>
    <link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/a81368914c.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
</head>
<body>
    <asp:Image class="wave" src="LoginPageComp/beigeWave.png" runat="server"/>
    <div class="container">
        <div class="img">
            <asp:Image runat="server" src="LoginPageComp/eat-shop-logo.png"/>
        </div>
        <div class="login-content">
            <form action="index.html">
                <asp:Image runat="server" src="LoginPageComp/avatar.png"/>
                <h2 class="title">Welcome</h2>
                   <div class="input-div one">
                      <div class="i">
                              <i class="fas fa-user"></i>
                      </div>
                      <div class="div">
                              <h5>Username</h5>
                              <input type="text" class="input"/>
                      </div>
                   </div>
                   <div class="input-div pass">
                      <div class="i">
                           <i class="fas fa-lock"></i>
                      </div>
                      <div class="div">
                           <h5>Password</h5>
                           <input type="password" class="input"/>
                   </div>
                </div>
                <a href="#">Forgot Password?</a>
                <input type="submit" class="btn" value="Login"/>
            </form>
        </div>
    </div>
    <script type="text/javascript" src="LoginPageComp/LoginPageScript.js"></script>
</body>
</html>
