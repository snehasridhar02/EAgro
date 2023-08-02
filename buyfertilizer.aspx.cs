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
    public partial class buyfertilizer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GVbind();
        }
        protected void GVbind()
        {
            string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from adminadd", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();


                }

                con.Close();


            }

        }
    }
}