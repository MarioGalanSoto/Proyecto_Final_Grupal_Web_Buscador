<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultados_Busqueda.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.Resultados_Busqueda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscador eat shop</title>

        <link rel="stylesheet" href="BuscadorStyleSheet.css"/>
        <link rel="icon" href="eat-shop-icon.png"/>
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 100px;
        }

        .logoSearchSection{
            display: flex;
            align-items: center;
            padding-left :50px;
            
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logoSearchSection">
            <img alt="Eat-Shop-logo" class="auto-style1" src="eat-shop-logo.png" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbSearch2" CssClass="tbSearch" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" CssClass="SearchButtons" runat="server" OnClick="Button1_Click" Text="Search 🔍" />
        </div>
    </form>
</body>
</html>
