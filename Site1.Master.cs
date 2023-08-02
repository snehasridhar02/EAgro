using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eagro
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton7.Visible = false;
                    LinkButton3.Visible = false;
                    LinkButton4.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = true;
                    LinkButton5.Visible =false;
                    LinkButton6.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton13.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton15.Visible= false;
                    LinkButton16.Visible = false;
                    LinkButton17.Visible = false;
                    LinkButton18.Visible = false;
                }
                else if (Session["role"].Equals("farmer"))
                {
                    LinkButton9.Visible = false;
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton7.Visible = true;
                    LinkButton3.Visible = true;
                    LinkButton5.Visible = false;
                    LinkButton3.Text = "Hello " + Session["fullname"].ToString();

                    LinkButton11.Visible = true;
                    LinkButton12.Visible = false;
                    LinkButton8.Visible = true;
                    LinkButton4.Visible = true;
                    LinkButton6.Visible = false;
                    LinkButton10.Visible = true;
                    LinkButton13.Visible = false;
                    LinkButton14.Visible = false;
                    LinkButton15.Visible = false;
                    LinkButton16.Visible = true;
                    LinkButton17.Visible= false;
                    LinkButton18.Visible = true;
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton7.Visible = true;
                    LinkButton3.Visible = true;
                    LinkButton8.Visible = false;
                    LinkButton4.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton5.Visible = true;
                    LinkButton6.Visible = true;
                    LinkButton10.Visible = false;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = true;
                    LinkButton13.Visible = true;
                    LinkButton14.Visible = false;
                    LinkButton15.Visible = true;
                    LinkButton16.Visible = false;
                    LinkButton17.Visible = true;
                    LinkButton18.Visible = false;
                    LinkButton3.Text = "Hello Admin";

                   
                }
                else if (Session["role"].Equals("customer"))
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton7.Visible = true;
                    LinkButton3.Visible = true;
                    LinkButton8.Visible = false;
                    LinkButton4.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton5.Visible = false;
                    LinkButton6.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton11.Visible = false;
                    LinkButton12.Visible = false;
                    LinkButton13.Visible = false;
                    LinkButton14.Visible = true;
                    LinkButton15.Visible = false;
                    LinkButton16.Visible = false;
                    LinkButton17.Visible = false;
                    LinkButton18.Visible = false;
                    LinkButton3.Text = "Hello " + Session["fullname"].ToString();

                    
                }

            }
            catch (Exception ex)
            {

            }

        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["UserId"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";
            LinkButton1.Visible = true;
            LinkButton2.Visible = true;
            LinkButton7.Visible = false;
            LinkButton3.Visible = false;

            LinkButton9.Visible = true;
            LinkButton8.Visible = false;
            LinkButton4.Visible = false;
            LinkButton5.Visible = false;
            LinkButton6.Visible = false;
            LinkButton10.Visible = false;
            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            LinkButton13.Visible = false;
            LinkButton14.Visible = false;
            LinkButton15.Visible = false;
            LinkButton16.Visible = false;
            LinkButton17.Visible= false;
            LinkButton18.Visible = false;

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
    }
