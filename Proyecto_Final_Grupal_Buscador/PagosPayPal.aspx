<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagosPayPal.aspx.cs" Inherits="Proyecto_Final_Grupal_Buscador.PagosPayPal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
<input type="hidden" name="cmd" value="_xclick">
<input type="hidden" name="business" value="ylendiazpolanco@gmail.com">
<input type="hidden" name="lc" value="US">
<input type="hidden" name="item_name" value="Chai">
<input type="hidden" name="amount" value="300.00">
<input type="hidden" name="currency_code" value="USD">
<input type="hidden" name="button_subtype" value="services">
<input type="hidden" name="no_note" value="0">
<input type="hidden" name="bn" value="PP-BuyNowBF:btn_buynowCC_LG.gif:NonHostedGuest">
<input type="image" src="https://www.paypalobjects.com/es_XC/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" alt="PayPal, la forma más segura y rápida de pagar en línea."><br />
        <br>
        <asp:Button ID="BtnPayPal" runat="server" OnClick="BtnPayPal_Click" style="height: 29px" Text="Procesar pago PayPal" />
&nbsp;<img alt="" border="0" src="https://www.paypalobjects.com/es_XC/i/scr/pixel.gif" width="1" height="1">
    </form>

        </div>
    </form>
</body>
</html>
