using Proyecto_Final_Grupal_Buscador.EatShopDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final_Grupal_Buscador
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCredencialsError.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ddSex.Text != "-" || username.Text != "" || password.Text != "" || PasswordConfirm.Text != "" || email.Text != "")
            {
                if (PasswordConfirm.Text == password.Text)
                {
                    UsersTblTableAdapter adapter = new UsersTblTableAdapter();
                    adapter.Insert(username.Text.Trim(), password.Text.Trim(), email.Text.Trim(), ddSex.Text);
                    ddSex.Text = username.Text = password.Text = PasswordConfirm.Text = email.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Te has registrado Correctamente!!')", true);
                    Response.Redirect("LoginPage.aspx");

                }
                else
                {
                    lblCredencialsError.Text = "Password and confirm password must be equal";
                    lblCredencialsError.Visible = true;

                    ddSex.Text = username.Text = password.Text = PasswordConfirm.Text = email.Text = "";
                }

            }
            else
            {
                ddSex.Text = username.Text = password.Text = PasswordConfirm.Text = email.Text = "";
                lblCredencialsError.Text = "invalid or missing fields";
                lblCredencialsError.Visible = true;
            }

        }
    }
}