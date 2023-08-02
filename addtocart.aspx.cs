using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace eagro
{
    public partial class addtocart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("sno");
                dt.Columns.Add("id");
                dt.Columns.Add("productname");
                dt.Columns.Add("pdesc");
                dt.Columns.Add("pprice");
                dt.Columns.Add("pquantity");
                dt.Columns.Add("image");
                dt.Columns.Add("totalprice");

                if (Request.QueryString["id"] != null)
                {
                    if (Session["buyitems"] == null)
                    {
                        dr = dt.NewRow();
                        String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
                        SqlConnection con = new SqlConnection(mycon);
                        String myquery = "select * from adminadd2 where id=" + Request.QueryString["id"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = con;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dr["sno"] = 1;
                        dr["id"] = ds.Tables[0].Rows[0]["id"].ToString();
                        dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        dr["pdesc"] = ds.Tables[0].Rows[0]["pdesc"].ToString();
                        dr["pprice"] = ds.Tables[0].Rows[0]["pprice"].ToString();
                        dr["pquantity"] = Request.QueryString["pquantity"];
                        dr["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                        int price = Convert.ToInt16(ds.Tables[0].Rows[0]["pprice"].ToString());
                        int quantity = Convert.ToInt16(Request.QueryString["pquantity"].ToString());
                        int totalprice = price * quantity;
                        dr["totalprice"] = totalprice;

                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[6].Text = "Total Amount";
                        GridView1.FooterRow.Cells[7].Text = grandtotal().ToString();
                        Response.Redirect("addtocart.aspx");
                    }
                    else
                    {
                        dt = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
                        SqlConnection con = new SqlConnection(mycon);
                        String myquery = "select * from adminadd2 where id=" + Request.QueryString["id"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = con;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dr["sno"] = sr+1;
                        dr["id"] = ds.Tables[0].Rows[0]["id"].ToString();
                        dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        dr["pdesc"] = ds.Tables[0].Rows[0]["pdesc"].ToString();
                        dr["pprice"] = ds.Tables[0].Rows[0]["pprice"].ToString();
                        dr["pquantity"] = Request.QueryString["pquantity"];
                        dr["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                        int price = Convert.ToInt16(ds.Tables[0].Rows[0]["pprice"].ToString());
                        int quantity = Convert.ToInt16(Request.QueryString["pquantity"].ToString());
                        int totalprice = price * quantity;
                        dr["totalprice"] = totalprice;

                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[6].Text = "Total Amount";
                        GridView1.FooterRow.Cells[7].Text = grandtotal().ToString();
                        Response.Redirect("addtocart.aspx");


                    }
                }
                else
                {
                    dt = (DataTable)Session["buyitems"];
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    if (GridView1.Rows.Count > 0)
                    {
                        GridView1.FooterRow.Cells[6].Text = "Total Amount";
                        GridView1.FooterRow.Cells[7].Text = grandtotal().ToString();
                    }
                }
                Label1.Text = GridView1.Rows.Count.ToString();

            }
        }
        public int grandtotal()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            int nrow = dt.Rows.Count;
            int i = 0;
            int gtotal = 0;
            while (i < nrow)
            {
                gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());
                i = i + 1;
            }
            return gtotal;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                int sr;
                int sr1;
                String qdata;
                String dtdata;
                sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
                TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
                qdata = cell.Text;
                dtdata = sr.ToString();
                sr1 = Convert.ToInt32(qdata);
                if (sr == sr1)
                {
                    dt.Rows[i].Delete();
                    dt.AcceptChanges();
                    break;
                }

            }
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                dt.Rows[i]["sno"] = i;
                dt.AcceptChanges();

            }
            Session["buyitems"] = dt;
            Response.Redirect("addtocart.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("editorder.aspx?sno=" + GridView1.SelectedRow.Cells[0].Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("fplaceorder.aspx");
        }
    }
    
}
   
