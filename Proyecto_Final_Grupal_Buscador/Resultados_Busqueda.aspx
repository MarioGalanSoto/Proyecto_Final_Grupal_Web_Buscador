<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultados_Busqueda.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.Resultados_Busqueda" EnableEventValidation ="false" %>

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

        .logDiv{
          text-align:right;
        }
      
          

        .logoSearchSection{
           /* align-items: center;*/
            text-align: center;
            background-color: beige;
            padding-bottom: 30px;
            /*justify-content: center;*/
        }

        #Button2 {
            background-color: limegreen;
            border: none;
            padding: 20px;

        }

        #Button3 {
            background-color: darkred;
            border: none;
            padding: 20px;
            color: white;
            

    

        }




        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logoSearchSection">
            <img alt="Eat-Shop-logo" class="auto-style1" src="eat-shop-logo.png" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbSearch2" CssClass="tbSearch" runat="server" OnTextChanged="tbSearch2_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" CssClass="SearchButtons" runat="server" OnClick="Button1_Click" Text="Search 🔍" />

            <div class="logDiv">
                <asp:Button ID="LogOut" CssClass="SearchButtons" Text="LogOut" runat="server" BackColor="Red" ForeColor="White" OnClick="LogOut_Click"/>
            </div>
        </div>
        <div class="pageContent">
        <br/><br/><asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="556px" Width="832px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                    <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock" />
                </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
            <br />
&nbsp;<br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="Button2" runat="server" Class="SearchButtons" OnClick="Button2_Click" Text="Add to cart  🛒" />
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <br />
                    <br />
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" Height="556px" HorizontalAlign="Center" OnRowDataBound="GridView2_RowDataBound" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="832px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                            <asp:BoundField DataField="UnitInStock" HeaderText="UnitInStock" SortExpression="UnitInStock" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                    
                    <br />
                    
                    <asp:Button ID="Button3" runat="server" Class="SearchButtons" OnClick="Button3_Click" Text="Delete ❌" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            
        <div>
            </div>
<input type="image" src="https://www.paypalobjects.com/es_XC/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" alt="PayPal, la forma más segura y rápida de pagar en línea." style="height: 73px; width: 260px"><br />
        <br>
        <asp:Button ID="BtnPayPal" runat="server" OnClick="BtnPayPal_Click" style="height: 29px" Text="Procesar pago PayPal" />
            <ContentTemplate><br />
                    <br />
                </ContentTemplate>
            
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [ProductName], [UnitPrice], [UnitInStock] FROM [cartTable]"></asp:SqlDataSource>
            <br />
        <br><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [ProductName], [UnitPrice], [UnitsInStock] FROM [Alphabetical list of products]"></asp:SqlDataSource>
            </div>
    </form>
</body>
</html>


