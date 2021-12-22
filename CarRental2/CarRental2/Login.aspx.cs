using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;


namespace CarRental2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Label2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlCommand command;

            string email = UserEmail.Text;
            string password = TextBox2.Text;

            command = new SqlCommand("SELECT * FROM Users WHERE UserName='"+email+"' AND Password='"+password+"'", con);
            con.Open();
            SqlDataReader read = command.ExecuteReader();


            //while (read.Read())
            //{
            //    //Response.Cookies["UserEmail"].Value = email;
            //    //Response.Cookies["UserEmail"].Expires = DateTime.Now.AddDays(1);
            //    //FormsAuthentication.RedirectFromLoginPage(email, true);
            //}


            if (read.Read())
            {
                Response.Cookies["UserEmail"].Value = email;
                Response.Cookies["UserEmail"].Expires = DateTime.Now.AddDays(1);
                FormsAuthentication.RedirectFromLoginPage(email,true);
            }
            
            else
            {
                Label2.Visible = true;
                Label2.Text = "The information provided does not match our records. Please ensure that the information you have entered is correct and try again.";
            }
            con.Close();
        }
    }
}