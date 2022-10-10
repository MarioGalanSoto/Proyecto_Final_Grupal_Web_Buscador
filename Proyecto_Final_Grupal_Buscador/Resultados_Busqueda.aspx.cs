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

namespace Proyecto_Final_Grupal_Buscador
{
    public class CartRow
    {
        public string id;
        public string name;
        public string price;
        public string items;
    };
    
    public partial class Resultados_Busqueda : System.Web.UI.Page
    {
        ProductsTableAdapter adapter = new ProductsTableAdapter();

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

        }
        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();

        }

        public void Page_Load(object sender, EventArgs e)
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

            else {
                ProductsDataTable productos = adapter.GetData();
                GridView1.DataSourceID = "";
                GridView1.DataSource = productos;
                GridView1.DataBind();
                Session["busqueda"] = "";
            }

            /*Load cart*/
            DataTable cartData = new DataTable();
            cartData.Columns.Add("Product Name", typeof(string));
            cartData.Columns.Add("Unit Price", typeof(string));
            cartData.Columns.Add("Units in stock", typeof(string));
            Session["cartDetails"] = cartData;

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
                    //Response.Redirect("Resultados_Busqueda.aspx");
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
                    //Response.Redirect("Resultados_Busqueda.aspx");
                }
            }
            catch (Exception)
            {
                GridView2.ToolTip = "Select the item you want to delete";
                throw;
            }


            //cartTableTableAdapter cartAdapter = new cartTableTableAdapter();
            /*try
            {
                if (GridView2.SelectedRow.Cells[0].Text != null)
                {
                    cartAdapter.Delete(GridView2.SelectedRow.Cells[0].Text);
                    GridView2.DataBind();
                    //Response.Redirect("Resultados_Busqueda.aspx");
                }
            }
            catch (Exception)
            {
                GridView2.ToolTip = "Select the item you want to delete";
                throw;
            }*/




        }
    }
}
