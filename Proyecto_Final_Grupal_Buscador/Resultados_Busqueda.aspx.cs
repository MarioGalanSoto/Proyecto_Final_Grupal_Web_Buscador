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
            /*else if(Session["busqueda"].ToString() != tbSearch2.Text) {
                ProductsDataTable productos = adapter.GetDataByCriterio(tbSearch2.Text);
                GridView1.DataSourceID = "";
                GridView1.DataSource = productos;
                GridView1.DataBind();
            }*/
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



/*        protected void lnkBtnReadyToServeAdd_Click(object sender, EventArgs e)
        {
            DataTable dtCart = (DataTable)Session["sessiondtCart"];
            foreach (DataRow row in dtCart.Rows)
            {
                if (row["ProductName"] == Label1.Text) //check if already exists
                {
                    //now we know we need to increment the quantity, because it's already in the cart
                    int quantity = row["TotalPrice"] / int.Parse();
                    row["TotalPrice"] = quantity + int.Parse(txtQuantity.Text);
                }
                else
                {
                    //now we know the item wasn't in the cart, so we need to add it
                    dtCart.Rows.Add(lblProductName.Text, lblProductPrice.Text, txtQuantity.Text, imgk1.ImageUrl, int.Parse(lblProductPrice.Text) * int.Parse(txtQuantity.Text));
                }
            }

            Session["sessiondtCart"] = dtCart;
        }*/
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
            cartTableTableAdapter cartAdapter = new cartTableTableAdapter();

            if ((GridView1.SelectedRow.Cells[1].Text != null))
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


            /*else
            {
                //MessageBox.Show(Convert.ToString(GridView1.CurrentCell.Value));
                string a = GridView1.SelectedRow.Cells[1].Text;

                object[] values = new object[GridView1.Rows[0].Cells.Count];
                DataTable cartTable;

                for (int i = 0; i < GridView1.Rows[0].Cells.Count; i++)
                {
                    values[i] = GridView1.SelectedRow.Cells[i].Text;
                }

                cartTable = (DataTable)Session["cartDetails"];
                cartTable.Rows.Add(values);
                Session["cartDetails"] = cartTable;

                DataTable table =(DataTable)Session["cartDetails"];
                //Session["cartDetails"];
                GridView2.DataSource = cartTable.DefaultView;
            }*/

        }

        protected void tbSearch2_TextChanged(object sender, EventArgs e)
        {
            

        }

       

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

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

        protected void Button3_Click(object sender, EventArgs e)
        {
            cartTableTableAdapter cartAdapter = new cartTableTableAdapter();

            if (!(GridView2.SelectedRow.Cells[0].Text == null))
            {
                cartAdapter.DeleteQ(GridView2.SelectedRow.Cells[0].Text);
                GridView2.DataBind();
                Response.Redirect("Resultados_Busqueda.aspx");
            }
            else
            {

            }
            

        }
    }
}
