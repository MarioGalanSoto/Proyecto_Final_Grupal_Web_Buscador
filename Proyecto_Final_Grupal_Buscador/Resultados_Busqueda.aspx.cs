using Proyecto_Final_Grupal_Buscador.EatShopDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Proyecto_Final_Grupal_Buscador.EatShopDS;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using System.Text;
using System.Xml.Linq;

namespace Proyecto_Final_Grupal_Buscador
{

    
    public partial class Resultados_Busqueda : System.Web.UI.Page
    {
        ProductsTableAdapter adapter = new ProductsTableAdapter();

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("LoginPage.aspx");
        }


        public void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null) //if the session didn't start (login didn't happened)
            {
                Response.Redirect("LoginPage.aspx"); // go to login page
            }
            if (!IsPostBack)
            {
                if (!(Session["busqueda"].ToString() == ""))
                {
                    tbSearch2.Text = Session["busqueda"].ToString();
                    ProductsDataTable productos = adapter.GetDataByCriterio(tbSearch2.Text);
                    GridView1.DataSourceID = "";
                    GridView1.DataSource = productos;
                    GridView1.DataBind();
                    Session["busqueda"] = "";



                }
                else
                {
                    ProductsDataTable productos = adapter.GetData();
                    GridView1.DataSourceID = "";
                    GridView1.DataSource = productos;
                    GridView1.DataBind();
                    Session["busqueda"] = "";
                }
            }
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (!(tbSearch2.Text == ""))
            {
                Session["busqueda"] = "";
                ProductsDataTable productos = adapter.GetDataByCriterio(tbSearch2.Text);
                GridView1.DataSourceID = "";
                GridView1.DataSource = productos;
                GridView1.DataBind();
                Session["busqueda"] = "";
            }
            else
            {
                Session["busqueda"] = "";
                ProductsDataTable productos = adapter.GetData();
                GridView1.DataSourceID = "";
                GridView1.DataSource = productos;
                GridView1.DataBind();
                Session["busqueda"] = "";
            }
        }

        //Selector handler of GridView 1
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
            foreach (GridViewRow row in GridView1.Rows)
            {
                
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;


                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                cartTableTableAdapter cartAdapter = new cartTableTableAdapter();

                if (GridView1.SelectedRow.Cells[0].Text != null)
                {
                    cartTableDataTable productos = cartAdapter.GetData();
                    GridView2.DataSourceID = "";
                    GridView2.DataSource = productos;
                    GridView2.DataBind();
                    string a = GridView1.SelectedRow.Cells[0].Text;
                    string b = GridView1.SelectedRow.Cells[1].Text;
                    string c = GridView1.SelectedRow.Cells[2].Text;
                    cartAdapter.Insert(a, b, c);
                    GridView2.DataBind();
                    Response.Redirect("Resultados_Busqueda.aspx");

                }

            }
            catch (Exception)
            {
                GridView1.ToolTip = "select the item you want to add to the cart";
                throw;
            }

            



        }

        protected void tbSearch2_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Selector handler of GridView 2
        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView2, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
            foreach (GridViewRow row in GridView2.Rows)
            {

                if (row.RowIndex == GridView2.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;
                    /*String pid;
                    pid = row.Cells[0].Text;
                    String pname;
                    pname = row.Cells[1].Text;
                    String price;
                    price = row.Cells[2].Text;*/
                    

                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
        }

        //button for deleting from cart
        protected void Button3_Click(object sender, EventArgs e)
        {
            cartTableTableAdapter cartAdapter = new cartTableTableAdapter();
            try
            {
                if (GridView2.SelectedRow.Cells[0].Text != null)
                {
                    cartAdapter.DeleteQ(GridView2.SelectedRow.Cells[0].Text);
                    GridView2.DataBind();
                }
            }
            catch (Exception)
            {
                GridView2.ToolTip = "Select the item you want to delete";
                throw;
            }


        }

        protected void BtnPayPal_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(


            "‹html>");
            sb.AppendLine("<body>");
            sb.AppendLine("<form name='frmsubmit' action='https://www.paypal.com/cgi-bin/webscr' method = 'post'>");
            sb.AppendLine(String.Format("<input type='hidden' name='cmd' value='{0}' />", "_xclick"));
            sb.AppendLine(String.Format("<input type='hidden' name='business' value='{0}' /> ", "ylendiazpolanco@gmail.com"));
            sb.AppendLine(String.Format("<input type='hidden' name='currency_code' value='{0}' />", "USD"));
            sb.AppendLine(String.Format("<input type='hidden' name='item name' value='{0}' />", "Orden en EatShop.com"));
            sb.AppendLine(String.Format("<input type='hidden' name='item number' value='{0}' /> ", ""));
            sb.AppendLine(String.Format("<input type='hidden' name='custom' value='{0}' />", ""));
            sb.AppendLine(String.Format("<input type='hidden' name='image_url' value=' {0}' />", "https://localhost:44352/Buscador_de_productos.aspx"));
            sb.AppendLine(String.Format("<input type='hidden' name='return' value='{0}' />", "https://localhost:44352/Resultados_Busqueda.aspx"));
            sb.AppendLine(String.Format("<input type='hidden' name='notify_url' value'{0}' />", "https://localhost:44352/Resultados_Busqueda.aspx"));
            sb.AppendLine(String.Format("<input type='hidden' name='no_note' value='{0}' />", "1"));
            sb.AppendLine(String.Format("<input type-'hidden' name='no_shipping' value=' {0}' />", "1"));
            sb.AppendLine(String.Format("<input type='hidden' name='rm' value = '{0}' />","5"));
            sb.AppendLine(String.Format("<input type='hidden' name='first_name' value='{0}' >", "Ylen")); 
            sb.AppendLine(String.Format("<input type='hidden' name='last_name' value='{0}' />", "Diaz")); 
            sb.AppendLine(String.Format("<input type='hidden' name='address1' value='{0}' />", "Arroyo Hondo")); 
            sb.AppendLine(String.Format("<input type='hidden' name='zip' value='{0}' />", "N/A")); 
            sb.AppendLine(String.Format("<input type='hidden' name='amount' value='{0:0.00}' />", "18.00")); // total
            
            sb.AppendLine("</form>");
            sb.AppendLine("<script language='javascript'>document.frmsubmit.submit();</script>");
            sb.AppendLine("<body>"); sb.AppendLine("</html>");
        }
    }
}
