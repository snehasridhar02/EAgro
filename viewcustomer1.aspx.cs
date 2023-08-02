using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eagro
{
    public partial class viewcustomer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            if (dt != null)
            {
                Label8.Text = dt.Rows.Count.ToString();
            }
            else
            {
                Label8.Text = "0";
            }

        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DropDownList dlist = (DropDownList)(e.Item.FindControl("DropDownList1"));
            Response.Redirect("addcart.aspx?id=" + e.CommandArgument.ToString() + "&pquantity=" + dlist.SelectedItem.ToString());
        }





        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter("Select * from product2 where(productname like '%" + TextBox1.Text + "%') or (id like '%" + TextBox1.Text + "%')", mycon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataList1.DataSourceID = null;
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        
    }
}