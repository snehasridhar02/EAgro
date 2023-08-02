using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using iTextSharp.text;
using System.Data;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace eagro
{
    public partial class invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label3.Text = Request.QueryString["orderid"];
            string orderid = Session["orderid"].ToString();
            Label3.Text = orderid;
            Label4.Text = Label3.Text;
            findorderdate(Label3.Text);
            findaddress(Label3.Text);
            showgrid(Label3.Text);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            exportpdf();
        }

        private void exportpdf()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=OrderInvoice.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Panel1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfdoc);
            PdfWriter.GetInstance(pdfdoc, Response.OutputStream);
            pdfdoc.Open();
            htmlparser.Parse(sr);
            pdfdoc.Close();
            Response.Write(pdfdoc);
            Response.End();
        }


        private void findorderdate(String orderid)
        {
            String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
            String myquery = "Select * from orderdetails where orderid='" + orderid + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label5.Text = ds.Tables[0].Rows[0]["dateoforder"].ToString();

            }
            con.Close();
        }
        private void findaddress(String orderid)
        {
            String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
            String myquery = "Select * from orderaddress where orderid='" + Label3.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label6.Text = ds.Tables[0].Rows[0]["address"].ToString();
            }
            con.Close();
        }
        private void showgrid(String orderid)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sno");
            dt.Columns.Add("id");
            dt.Columns.Add("pname");
            dt.Columns.Add("pprice");
            dt.Columns.Add("pquantity");
            dt.Columns.Add("totalprice");
            String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
            SqlConnection scon = new SqlConnection(mycon);
            String myquery = "Select * from orderdetails where orderid='" + Label3.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            int totalrows = ds.Tables[0].Rows.Count;
            int i = 0;
            int grandtotal = 0;
            while (i < totalrows)
            {
                dr = dt.NewRow();
                dr["sno"] = ds.Tables[0].Rows[i]["sno"].ToString(); 
                dr["id"] = ds.Tables[0].Rows[i]["id"].ToString();
                dr["pname"] = ds.Tables[0].Rows[i]["pname"].ToString();
                dr["pprice"] = ds.Tables[0].Rows[i]["pprice"].ToString();
                dr["pquantity"] = ds.Tables[0].Rows[i]["pquantity"].ToString();
                int price = Convert.ToInt16(ds.Tables[0].Rows[i]["pprice"].ToString());
                int quantity = Convert.ToInt16(ds.Tables[0].Rows[i]["pquantity"].ToString());
                int totalprice = price * quantity;
                dr["totalprice"] = totalprice;
                grandtotal = grandtotal + totalprice;
                dt.Rows.Add(dr);
                i = i + 1;

            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
            Label8.Text = grandtotal.ToString();


        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* verfies */
        }

       
    }
}
    
    

    

