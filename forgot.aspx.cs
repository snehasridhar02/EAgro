using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
namespace eagro
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(strcon);
            string sqlquery = "select email,password from [dbo].[farmer] where email=@email";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@email", email.Text);
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.Read())
            {
                string username = sdr["email"].ToString();
                string password = sdr["password"].ToString();

                MailMessage mm = new MailMessage("surakshithashetty18@gmail.com", email.Text);
                mm.Subject = "Your password!";
                mm.Body = string.Format("Hello:<h1>{0}</h1> is Your emailid <br/> Your password is <h1>{1}</h1>", username, password);
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
                Label1.Text = "Your password has been sent to " + email.Text;
                Label1.ForeColor = Color.Green;

            }
            else
            {
                Label1.Text = "Invalid EmailID!";
                Label1.ForeColor = Color.Red;
            }
        }
    }
}