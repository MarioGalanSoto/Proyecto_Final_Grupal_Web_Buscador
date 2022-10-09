using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Grupal_Buscador
{
    public partial class Resultados_Busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["busqueda"].ToString() == "")) {
                tbSearch2.Text = Session["busqueda"].ToString();
            }
            


            /*Label1.Text = Session["value"].ToString();*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}