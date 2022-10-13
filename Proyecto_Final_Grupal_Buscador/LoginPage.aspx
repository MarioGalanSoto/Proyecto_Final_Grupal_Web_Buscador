<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>



 <link rel="stylesheet" type="text/css" href="LoginPageComp/LoginPageStyles.css"/>    
    <link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet"/>      
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="icon" href="eat-shop-icon.png" />
    <style type="text/css">
        .errorMessage{
            color:red;
            font-family: 'Poppins', sans-serif;
        }
    </style>
</head>
    <body>    
        <asp:Image class="wave" src="LoginPageComp/beigeWave.png" runat="server"/>  
        <div class="container">       
            <div class="img">            

        <asp:Image runat="server" src="LoginPageComp/eat-shop-logo.png"/>       

                                                                                                                                                                                                      
                </div>        
            <div class="login-content">            
                <form runat="server">                
                    <asp:Image runat="server" src="LoginPageComp/avatar.png"/>                
                    <h2 class="title">Welcome</h2>                   
                    <div class="input-div one">                      
                        <div class="i">                              
                            <i class="fas fa-user"></i>                      

                        </div>                      
                        <div class="div">                              
                            <h5>Username</h5>  
                            <asp:TextBox id="username" type="text" class="input" runat="server"></asp:TextBox>
                                                

                        </div>                   

                    </div>                   
                    <div class="input-div pass">                     
                        <div class="i">                            
                            <i class="fas fa-lock"></i>                     

                        </div>                   
                        <div class="div">                           
                            <h5>Password</h5>  
                            <asp:TextBox id="password" type="password" class="input" runat="server"></asp:TextBox>
                              
                        </div>
                          
                       
                    </div>                
                    <a href="RegisterPage.aspx">do you want to Register?</a>

                    <asp:Label ID="lblCredencialsError" class="errorMessage" text="incorrent Username or Password" runat="server"></asp:Label> 
                    <asp:Button ID="Button1" class="btn" runat="server" OnClick="Button1_Click" Text="Login" />                        

                                                                                                                                                                                                                                                            
                </form>        

            </div>    

        </div>    
        <script type="text/javascript" src="LoginPageComp/LoginPageScript.js"></script>
        <script src="https://kit.fontawesome.com/a81368914c.js"></script>  
    </body>

</html>