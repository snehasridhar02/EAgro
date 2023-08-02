using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace eagro
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        int ratings = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (str1.Checked == true)
            {
                ratings = ratings + 5;
            }
            else if (str2.Checked == true)
            {
                ratings = ratings + 4;
            }
            else if (str3.Checked == true)
            {
                ratings = ratings + 3;
            }
            else if (str4.Checked == true)
            {
                ratings = ratings + 2;
            }
            else if (str5.Checked == true)
            {
                ratings = ratings + 1;
            }
            Label1.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into ra1 rating('" + ratings + "','" + TextBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}