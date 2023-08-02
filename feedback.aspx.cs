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
    public partial class feedback : System.Web.UI.Page
    {
        int ratings = 0;
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Label6.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into rating1(feedback,username,email) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();



        }
    }
    
}