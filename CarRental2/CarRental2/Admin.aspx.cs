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
    public partial class Admin : System.Web.UI.Page
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
            string val = "2";

            while (read.Read())
            {
                val = read[0].ToString();

                if (val == "1")

                    Response.Redirect("Customers.aspx");
            }
            con.Close();



            com = new SqlCommand("SELECT * FROM RENTAL", con);
            con.Open();
            SqlDataReader rea = com.ExecuteReader();



            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RENTAL WHERE CUS_ID IN (SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL ='" + email + "')", con);
            //con.Open();
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //GridView1.DataSource = ds.Tables[0];
            //con.Close();









            Label1.Text = "Rentals</br> Rental id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pickup Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dropoff Date &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Customer Id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Reg Num &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pickup Location&nbsp;&nbsp;&nbsp; DropOff Location</br>";
            //int u = 0
            //Label1.Text = "rental id</br>";
            //Label2.Text = "Start date</br>";
            //Label3.Text = "end date</br>";
            //Label4.Text = "Customer id</br>";
            //Label5.Text = "Registiration number</br>";
            //Label6.Text = "Pickup location</br>";
            //Label7.Text = "Drop off location</br>";
            while (rea.Read())
            {

                //Label1.Text =Label1.Text+"</br>"  + rea[0].ToString();
                //Label2.Text = Label2.Text + "</br>" + rea[1].ToString();
                //Label3.Text =  Label3.Text + "</br>" + rea[2].ToString();
                //Label4.Text =  Label4.Text + "</br>" + rea[3].ToString();
                //Label5.Text =  Label5.Text + "</br>" + rea[4].ToString();
                //Label6.Text =  Label6.Text + "</br>" + rea[5].ToString();
                //Label7.Text =  Label7.Text + "</br>" + rea[6].ToString();
                ////    Label1.Text = rea[2].ToString();

                Label1.Text = Label1.Text + rea[0].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + rea[1].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " + rea[2].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + rea[3].ToString() + "  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + rea[4].ToString() + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + rea[5].ToString() + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + rea[6].ToString() + "</br>";
                //  u++;  

            }
            Label1.Text = Label1.Text.Replace("00:00:00", "");
            con.Close();



            com = new SqlCommand("SELECT * FROM RESERVATION ", con);
            con.Open();
            SqlDataReader real = com.ExecuteReader();



            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RENTAL WHERE CUS_ID IN (SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL ='" + email + "')", con);
            //con.Open();
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //GridView1.DataSource = ds.Tables[0];
            //con.Close();









            Label2.Text = "Reservations</br> ResId &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pickup Location&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dropoff Location &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Customer Id &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Pick Up date &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Drop Off Date</br>";
            //  int u = 0;
            while (real.Read())
            {
                //    Label1.Text = rea[2].ToString();

                Label2.Text = Label2.Text + real[0].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + real[1].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   " + real[2].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + real[3].ToString() + "  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + real[4].ToString() + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  " + real[5].ToString() + "</br>";
                //  u++;  

            }
            Label2.Text = Label2.Text.Replace("00:00:00", "");
            con.Close();







        }

        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            con.Open();
            SqlCommand deletecus = new SqlCommand("DELETE FROM RENTAL WHERE RENTAL_ID =" + "'" +TextBox1.Text + "'", con);
            deletecus.ExecuteNonQuery();
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            con.Open();
            SqlCommand deletecus = new SqlCommand("DELETE FROM RESERVATION WHERE RES_ID =" + "'" + TextBox2.Text + "'", con);
            deletecus.ExecuteNonQuery();
            con.Close();

        }
    }
}