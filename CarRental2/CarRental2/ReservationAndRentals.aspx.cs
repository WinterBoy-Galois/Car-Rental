using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CarRental2
{
    public partial class ReservationAndRentals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlCommand command;
            SqlCommand com;


            string email = Request.Cookies["UserEmail"].Value;
            command = new SqlCommand("SELECT UserType FROM Users WHERE UserName='" + email + "'", con);
            con.Open();
            SqlDataReader read = command.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string val = "0";

            while (read.Read())
            {
                val = read[0].ToString();

                if (val == "2")

                    Response.Redirect("Admin.aspx");
                else if (val == "0")
                {
                    Response.Redirect("index.aspx");
                }

            }
            con.Close();


            com = new SqlCommand("SELECT * FROM RENTAL WHERE CUS_ID IN (SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL ='"+email+"')", con);
            con.Open();
            SqlDataReader rea = com.ExecuteReader();



            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RENTAL WHERE CUS_ID IN (SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL ='" + email + "')", con);
            //con.Open();
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //GridView1.DataSource = ds.Tables[0];
            //con.Close();









            Label1.Text = "Rentals</br> Rental id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pickup Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dropoff Date &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Customer Id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reg Num &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pickup Location&nbsp;&nbsp;&nbsp; DropOff Location</br>";
            int u = 0;
            while (rea.Read())
            {
                //    Label1.Text = rea[2].ToString();

                Label1.Text = Label1.Text + rea[0].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + rea[1].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " + rea[2].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + rea[3].ToString() + "  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + rea[4].ToString() + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + rea[5].ToString() + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + rea[6].ToString() + "</br>";
                //  u++;  

            }
            Label1.Text = Label1.Text.Replace("00:00:00", "");
            con.Close();



            com = new SqlCommand("SELECT * FROM RESERVATION WHERE CUS_ID IN (SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL ='" + email + "')", con);
            con.Open();
            SqlDataReader real = com.ExecuteReader();



            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RENTAL WHERE CUS_ID IN (SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL ='" + email + "')", con);
            //con.Open();
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //GridView1.DataSource = ds.Tables[0];
            //con.Close();









            Label3.Text = "Reservations</br> ResId &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pickup Location&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dropoff Location &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Customer Id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pick Up date &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Drop Off Date</br>";
          //  int u = 0;
            while (real.Read())
            {
                //    Label1.Text = rea[2].ToString();

                Label3.Text = Label3.Text + real[0].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + real[1].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " + real[2].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + real[3].ToString() + "  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + real[4].ToString() + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + real[5].ToString()  + "</br>";
                //  u++;  

            }
            Label3.Text = Label3.Text.Replace("00:00:00", "");
            con.Close();

















        }
    }
}