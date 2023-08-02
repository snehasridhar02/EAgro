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
    public partial class customersignup : System.Web.UI.Page
    {
        int letter, digit, sp, space;
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string CustID = "CUST";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateAutoId();
            }
        }
        private void GenerateAutoId()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select Count(id)from Customer1", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            TextBox10.Text = CustID + i.ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["address"] = TextBox5.Text;
            Session["contact"] = TextBox3.Text;
            Session["email"] = TextBox4.Text;
            if (checkemail() == true)
            {
                email.Text = "This email id is already registered";
                email.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                string s = TextBox9.Text;
                char[] c = s.ToCharArray();
                int t = TextBox9.Text.Length;
                foreach (char x in c)
                {
                    char a = ' ';
                    int b = 0;
                    if ((x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z'))
                    {
                        letter = letter + 1;
                        a = x;
                    }
                    else if (x >= '0' && x <= '9')
                    {
                        digit = digit + 1;
                        b = x;
                    }
                    else if (x > 32 && x < 127 && x != a && x != b)
                    {
                        sp = sp + 1;

                    }
                    else if (x == ' ')
                    {

                        space = space + 1;
                    }
                }
                int p = TextBox9.Text.Length;
                if (p >= 8)
                {
                    if (letter >= 1 && digit >= 1 && sp >= 1 && space == 0)
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(strcon);
                            if (con.State == ConnectionState.Closed)
                            {
                                con.Open();
                            }
                            SqlCommand cmd = new SqlCommand("INSERT INTO Customer1(id,fullname,dob,contact,email,state,city,pincode,fulladdress,username,password,accountstatus)values(@id,@fullname,@dob,@contact,@email,@state,@city,@pincode,@fulladdress,@username,@password,@accountstatus)", con);
                            cmd.Parameters.AddWithValue("@id", TextBox10.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullname", TextBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", TextBox3.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                            cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                            cmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
                            cmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
                            cmd.Parameters.AddWithValue("@fulladdress", TextBox5.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", TextBox8.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());
                            cmd.Parameters.AddWithValue("@accountstatus", "pending");
                            cmd.ExecuteNonQuery();
                            con.Close();
                            GenerateAutoId();

                            Response.Write("<script>alert('SignUp Successful.Go to login to login');</script>");

                        }
                        catch

                        {

                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Password must contain 1 digit,1 letter ,1 special character')</script>");
                    }
                }
                else
                    Response.Write("<script>alert('Password must contain 8 characters');</script>");
            }
        }
        private Boolean checkemail()
        {
            Boolean emailavailable = false;
            String mycon = "Data Source=DESKTOP-1CNFFIH\\SQLEXPRESS;Initial Catalog=eagro;Integrated Security=True";
            string myquery = "Select *from customer1 where email='" + TextBox4.Text + " ' ";

            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd= new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand= cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0)
            {
                emailavailable = true;

            }
            con.Close();
            return emailavailable;



                 

        }
    }

   
    
}