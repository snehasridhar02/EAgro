using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eagro
{
    public partial class addproduct : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (imageupload.HasFile)
                {
                    string filename = imageupload.PostedFile.FileName;
                    string filepath = "images/" + imageupload.FileName;
                    imageupload.PostedFile.SaveAs(Server.MapPath("~/images/") + filename);
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("Insert into product2 values('" + name.Text + "','" + TextBox1.Text + "','" + txtname.Text + "','" + txtdesc.Text + "','" + imageupload.FileName + "','" + txtprice.Text + "','" + txtquantity.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Product Supplied successfully');</script>");



                }

            }
            catch (Exception ex)

            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");


            }
        }
    }
}