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
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox5.Text = (string)Session["address"];
            
            TextBox7.Text = (string)Session["gtotal"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into payment1(firstname,lastname,cardno,expirydate,cvv,address,amount)Values(@firstname,@lastname,@cardno,@expirydate,@cvv,@address,@amount)", con);

                cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", TextBox6.Text);
                cmd.Parameters.AddWithValue("@cardno", TextBox2.Text);
                cmd.Parameters.AddWithValue("@expirydate", TextBox3.Text);
                cmd.Parameters.AddWithValue("@cvv", TextBox4.Text);
                cmd.Parameters.AddWithValue("@address", TextBox5.Text);
                cmd.Parameters.AddWithValue("@amount", TextBox7.Text);


                cmd.ExecuteNonQuery();
                con.Close();


                Response.Write("<script>alert('Payment Successfull');</script>");
                
            }
            catch (Exception ex)
            {

                TextBox6.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox7.Text = "";

            }
            Server.Transfer("invoice.aspx");

        }
    }
}