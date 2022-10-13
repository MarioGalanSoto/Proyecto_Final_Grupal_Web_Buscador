<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buscador_de_productos.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.Buscador_de_productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Buscador eat shop</title>
        <link rel="stylesheet" href="BuscadorStyleSheet.css"/>
        <link rel="icon" href="eat-shop-icon.png"/>
        <style type="text/css">
            .logDiv{
                 text-align:right;
            }

  

        </style>
    </head>

    <body>
            <form id="form1" runat="server">
                <div class="logDiv">
                     <asp:Button ID="LogOut" Text="LogOut" runat="server" Class="SearchButtons" BackColor="Red" ForeColor="White" OnClick="LogOut_Click"/>
                </div>

                <div id="all-container">

                    <div id="logoBuscador">

                        <asp:Image src="eat-shop-logo.png" ID='logoImage' alt="logo" runat="server" />

                        <br />
                        <br />
                        <br />
                        <br />

                        

                        <asp:TextBox ID="tbSearch1" class="tbSearch" placeholder="Type here to search a product" autocomplete="off" runat="server"></asp:TextBox>

                        

                        <asp:Button type="Image" ID="Button1" runat="server" Text="Search 🔍" OnClick="Button1_Click" class="SearchButtons"></asp:Button>

                    </div>
                </div>

                <br />

                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </ContentTemplate>


                </asp:UpdatePanel>

            </form>

    </body>
</html>
