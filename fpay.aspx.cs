using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Net.NetworkInformation;


namespace eagro
{
    public partial class fpay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox5.Text = (string)Session["address"];

            TextBox7.Text = (string)Session["gtotal"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String txt = "Admin";
            bool connection = NetworkInterface.GetIsNetworkAvailable();
            if (connection == false)
            {
                Response.Write("<script>alert('No Connection');</script>");
            }
            else
            {
                string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into payment(firstname,lastname,cardno,expirydate,cvv,address,amount,email)Values(@firstname,@lastname,@cardno,@expirydate,@cvv,@address,@amount,@email)", con);

                cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", TextBox6.Text);
                cmd.Parameters.AddWithValue("@cardno", TextBox2.Text);
                cmd.Parameters.AddWithValue("@expirydate", TextBox3.Text);
                cmd.Parameters.AddWithValue("@cvv", TextBox4.Text);
                cmd.Parameters.AddWithValue("@address", TextBox5.Text);
                cmd.Parameters.AddWithValue("@amount", TextBox7.Text);
                cmd.Parameters.AddWithValue("@email", TextBox8.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                SqlConnection sqlconn = new SqlConnection(strcon);
                string sqlquery = "select amount from [dbo].[payment] where email='" + TextBox8.Text + "'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@email", TextBox8.Text);
                sqlconn.Open();
                SqlDataReader sdr = sqlcomm.ExecuteReader();
                if (sdr.Read())
                {

                    string amount = sdr["amount"].ToString();

                    MailMessage mm = new MailMessage("surakshithashetty18@gmail.com", TextBox8.Text);
                    mm.Subject = "Bank!";
                    mm.Body = string.Format("Hello!:'" + txt + "' <br/> Amount <h1>{0}</h1>is credited by '" + TextBox1.Text + "' to your account ", amount);
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential nc = new NetworkCredential();
                    nc.UserName = "surakshithashetty18@gmail.com";
                    nc.Password = "qngzqlmygbfmpisk";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    Response.Write("<script>alert('Payment Successfull');</script>");
                   
                        
                }

                TextBox6.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";

            }

        }
    }
}