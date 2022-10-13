using Proyecto_Final_Grupal_Buscador.EatShopDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Grupal_Buscador
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCredencialsError.Visible = false;

            Session["User"] = null;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            UsersTblTableAdapter adapter = new UsersTblTableAdapter();

            int count = (int)adapter.LoginQ(username.Text.Trim(), password.Text.Trim());

            if (count == 1)
            {
                Session["User"] = username.Text.Trim();
                username.Text = "";
                password.Text = "";
                Response.Redirect("Buscador_de_productos.aspx");
            }
            else
            {

                /*                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El count de registro es: "+ count.ToString() + "!!')", true);*/
                username.Text = "";
                password.Text = "";
                lblCredencialsError.Visible = true;


            }


        }

    }
}