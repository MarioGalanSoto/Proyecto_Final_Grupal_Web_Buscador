<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
       <link rel="stylesheet" type="text/css" href="LoginPageComp/LoginPageStyles.css"/>    
    <link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet"/>      
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="icon" href="eat-shop-icon.png" />
    <style type="text/css">
        .errorMessage{
            color:red;
            font-family: 'Poppins', sans-serif;
        }
        #ddSex{
            border:none;
            border-bottom:2px solid #d9d9d9;
            width:100%;
            height:100%;
        }
        html{
            zoom:90%;
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
                    <h2 class="title">Register Here</h2>    
                    
                    <div class="input-div one">                      
                        <div class="i">                              
                            <i class="fas fa-user"></i>                      
                        </div>                      
                        <div class="div">                              
                            <h5>Insert email</h5>  
                            <asp:TextBox id="email" type="text" class="input" runat="server"></asp:TextBox>                                            
                        </div>                   
                    </div>
                   
                    <div class="input-div one">                      
                        <div class="i">                              
                            <i class="fas fa-user"></i>                      
                        </div>                      
                        <div class="div">                              
                            <h5>Insert Username</h5>  
                            <asp:TextBox id="username" type="text" class="input" runat="server"></asp:TextBox>                                            
                        </div>                   
                    </div>
                    

                    <div class="input-div pass">                     
                        <div class="i">                            
                            <i class="fas fa-lock"></i>                     
                        </div>                   
                        <div class="div">                           
                            <h5>Insert Password</h5>  
                            <asp:TextBox id="password" type="password" class="input" runat="server"></asp:TextBox>   
                        </div>
                    </div>       
                    
                    <div class="input-div pass">                     
                        <div class="i">                            
                            <i class="fas fa-lock"></i>                    
                        </div>                   
                        <div class="div">                           
                            <h5>Confirm Password</h5>  
                            <asp:TextBox id="PasswordConfirm" type="password" class="input" runat="server"></asp:TextBox>                          
                        </div>
                    </div>

                    <div class="sex-div">                     
                        <div class="i">                            
                            <i class="fas fa-intersex">
                            <br />
                            <br />
                            </i>                    
                        </div>                   
                        <div class="">                           
                            <h5>Select your sex</h5>
                            <asp:DropDownList ID="ddSex" class="dd-list" runat="server" Width="145px">
                                <asp:ListItem Value="-"></asp:ListItem>
                                <asp:ListItem Value="M"></asp:ListItem>
                                <asp:ListItem Value="F"></asp:ListItem>
                            </asp:DropDownList>
                                                      
                            <br />
                            <br />
                                                      
                        </div>
                    </div>

                    
                    

                    <a href="LoginPage.aspx">do you alredy have and account?</a>

                    <asp:Label ID="lblCredencialsError" class="errorMessage" text="invalid or missing fields" runat="server"></asp:Label> 
                    <asp:Button ID="Button1" class="btn" runat="server" Text="Register" OnClick="Button1_Click" />                        

                                                                                                                                                                                                                                                            
                </form>        

            </div>    

        </div>    
        <script type="text/javascript" src="LoginPageComp/LoginPageScript.js"></script>
        <script src="https://kit.fontawesome.com/a81368914c.js"></script>
</body>
</html>
