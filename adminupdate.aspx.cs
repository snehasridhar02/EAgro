using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eagro
{
    public partial class adminupdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label5") as Label;
            FileUpload fu = GridView1.Rows[e.RowIndex].FindControl("FileUpload1") as FileUpload;
            if (fu.HasFile)
            {

                
                TextBox email = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
                TextBox productname = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
                TextBox pdesc = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
                TextBox pprice = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
                TextBox pquantity = GridView1.Rows[e.RowIndex].FindControl("TextBox8") as TextBox;

                fu.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(fu.FileName));
                string image = Path.GetFileName(fu.FileName);


                String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update adminadd2 set email=@2,productname=@3,pdesc=@4,image=@5,pprice=@6,pquantity=@7 where id=@8", con);
                
                cmd.Parameters.AddWithValue("@2", email.Text);
                cmd.Parameters.AddWithValue("@3", productname.Text);
                cmd.Parameters.AddWithValue("@4", pdesc.Text);

                cmd.Parameters.AddWithValue("@5", image);
                cmd.Parameters.AddWithValue("@6", pprice.Text);
                cmd.Parameters.AddWithValue("@7", pquantity.Text);

                cmd.Parameters.AddWithValue("@8", id.Text);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Row updated successfully');</script>");
                GridView1.EditIndex = -1;
                SqlDataSource1.DataBind();
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Please select product image');</script>");

            }


        }
    }
}