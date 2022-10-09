<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buscador_de_productos.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.Buscador_de_productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Buscador eat shop</title>
        <link rel="stylesheet" href="BuscadorStyleSheet.css"/>
        <link rel="icon" href="eat-shop-logo.png"/>
        <style type="text/css">
  

            .auto-style1 {
                height: 46px;
                width: 5%;
            }
  

        </style>
    </head>

    <body>
            <form id="form1" runat="server">

                <div id="all-container">

                    <div id="logoBuscador">

                        <asp:Image src="eat-shop-icon.png" ID='logoImage' alt="logo" runat="server" />

                        <br />
                        <br />
                        <br />
                        <br />

                        <input type="text" id="search" placeholder="Type here to search a product" autocomplete="off"  />&nbsp;&nbsp;
                        <input ID="btnBuscar1" runat="server" Text="Buscar" type="Image" src="BuscadorLogo.png" OnClick="btnBuscar_Click" class="auto-style1"/>

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
