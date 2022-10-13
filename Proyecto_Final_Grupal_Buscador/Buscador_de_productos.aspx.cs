using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Grupal_Buscador
{
    public partial class Buscador_de_productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null) //if the session didn't start (login didn't happened)
            {
                Response.Redirect("LoginPage.aspx"); // go to login page
            }

        }
        protected void LogOut_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("LoginPage.aspx");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["busqueda"] = tbSearch1.Text;
            Response.Redirect("Resultados_Busqueda.aspx");
        }
    }
}