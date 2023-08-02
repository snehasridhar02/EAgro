using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace eagro
{
    public partial class fplaceorder : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["id"].ToString() == "" || Session["id"] == null)
                {
                    Response.Write("<script>alert('Session expired');</script>");
                    Response.Redirect("farmerlogin.aspx");
                }
                else
                {
                    if (!Page.IsPostBack)
                    {
                        getUserPersonalDetails();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Session expired');</script>");
                Response.Redirect("farmerlogin.aspx");
            }
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
                string orderdate = DateTime.Now.ToShortDateString();
                Session["orderdate"] = orderdate;
                Label3.Text = DateTime.Now.ToShortDateString();
                orderid();
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
            Session["gtotal"]=gtotal.ToString();
            return gtotal;
        }
        public void orderid()
        {
            String pass = "abcdefghijklmnopqrstuvwxyz123456789";
            Random r = new Random();
            char[] mypass = new char[5];
            for (int i = 0; i < 5; i++)
            {
                mypass[i] = pass[(int)(35 * r.NextDouble())];

            }
            String orderid;
            orderid = "orderid:" + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(mypass) + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            Session["orderid"] = orderid;
            Label2.Text = orderid;

        }
        public void saveaddress()
        {


            String mycon1 = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
            SqlConnection s = new SqlConnection(mycon1);
            s.Open();
            SqlCommand cmd1 = new SqlCommand("insert into placeorder(orderid,name,address,mobilenumber)values('" + Label2.Text + "','" + TextBox3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "')", s);
            //  cmd1.CommandText = updatepass;
            cmd1.Connection = s;
            cmd1.ExecuteNonQuery();
            s.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = (DataTable)Session["buyitems"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                String updatepass = "insert into orderdetails(orderid,custname,sno,id,pname,pprice,pquantity,dateoforder)values('" + Label2.Text + "','" + TextBox3.Text + "','" + dt.Rows[i]["sno"] + "','" + dt.Rows[i]["id"] + "','" + dt.Rows[i]["productname"] + "','" + dt.Rows[i]["pprice"] + "','" + dt.Rows[i]["pquantity"] + "','" + Label3.Text + "')";

                String mycon1 = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
                SqlConnection s = new SqlConnection(mycon1);
                s.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = updatepass;
                cmd1.Connection = s;
                cmd1.ExecuteNonQuery();
                s.Close();
            }
            saveaddress();

            Response.Redirect("fpay.aspx");
        }
        void getUserPersonalDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                }
                SqlCommand cmd = new SqlCommand("select * from farmer where id='" + Session["id"].ToString() + " ';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                TextBox3.Text = (string)Session["fullname"];
                TextBox1.Text = (string)Session["fulladdress"];
                TextBox2.Text = (string)Session["contact"];
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(' " + ex.Message + " ');</script>");
            }
        }
    }
    
}