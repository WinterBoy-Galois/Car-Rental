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
    public partial class Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {





            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlCommand command;


            string email = Request.Cookies["UserEmail"].Value;
            command = new SqlCommand("SELECT UserType FROM Users WHERE UserName='" + email + "'", con);
            con.Open();
            SqlDataReader read = command.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string val = "1";

            while (read.Read())
            {
                val = read[0].ToString();

                if (val == "2")

                    Response.Redirect("Admin.aspx");
            }
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlCommand command;
            command = new SqlCommand("select * from VEHICLE WHERE REG_NUM NOT IN (SELECT REG_NUM FROM RENTAL WHERE '"+TextBox7.Text+"' >STARTDATE OR '"+ TextBox7.Text + "' <ENDDATE) INTERSECT SELECT * FROM VEHICLE WHERE MODEL_ID LIKE '%"+TextBox6.Text+"%' INTERSECT SELECT * FROM VEHICLE WHERE MODEL_ID IN (SELECT MODEL_ID FROM MODEL WHERE BRAND_ID LIKE '%"+TextBox5.Text+"%')", con);

            //   command.Parameters.AddWithValue("@date",TextBox7.Text);
          //  object[] arr4 = new object[123];
            Image[] images = new Image[120];
            Label[] labels = new Label[120];
            Panel[] panels = new Panel[120];

            panels[0] = Panel4;
            panels[1] = Panel5;
            panels[2] = Panel6;
            panels[3] = Panel7;
            panels[4] = Panel8;
            panels[5] = Panel9; panels[6] = Panel10;

            images[0] = Image1;
             labels[0] = Label1;
            images[1] = Image2;
               labels[1] = Label2;
            images[2] = Image3;
              labels[2] = Label3;
            images[3] = Image4;
               labels[3] = Label4;
            labels[4] = Label5;
            labels[5] = Label6;
            images[4] = Image5;
            images[5] = Image6;
            labels[6] = Label7;
            images[6]= Image7;
            labels[7] = Label8;
            images[7] = Image8; labels[8] = Label9;
            images[8] = Image9;

            for (int ai = 0; ai < 8; ai++)
            {
                images[ai].ImageUrl = "";
                labels[ai].Text = "";
                if (ai<7)
                {
                    panels[ai].Visible = false;
                }
            }

            con.Open();
            SqlDataReader read = command.ExecuteReader();
           int i = 0;
            int u = 0;
            while(read.Read())
            {
                images[u].ImageUrl = read[i+6].ToString();
               labels[u].Text = read[i+3].ToString()+"$ "+ read[i+4].ToString();
                panels[u].Visible = true;
                u++; 
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string email = Request.Cookies["UserEmail"].Value;
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            SqlCommand coma = new SqlCommand("SELECT REG_NUM FROM VEHICLE WHERE PICTURE='" + Image1.ImageUrl + "'", con);
            con.Open();

            SqlDataReader reade = coma.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string bara = "not";

            while (reade.Read())
            {
                bara = reade[0].ToString();
            }


            con.Close();







            SqlCommand com = new SqlCommand("SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL='"+email+"'" , con);
            con.Open();

            SqlDataReader read = com.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string kumbara="not";
             
            while (read.Read())
            {
                kumbara = read[0].ToString();
            }


            con.Close();

                con.Open();
                    SqlCommand command = new SqlCommand("sp_rentcar", con);
                    command.CommandType = CommandType.StoredProcedure;


                    SqlParameter STARTDATE = new SqlParameter("@STARTDATE", SqlDbType.Date);
                    STARTDATE.Direction = ParameterDirection.Input;
                    STARTDATE.Value = TextBox8.Text;
                    command.Parameters.Add(STARTDATE);

                    SqlParameter ENDDATE = new SqlParameter("@ENDDATE", SqlDbType.Date);
                    ENDDATE.Direction = ParameterDirection.Input;
                    ENDDATE.Value = TextBox9.Text;
                    command.Parameters.Add(ENDDATE);

                    SqlParameter CUS_ID = new SqlParameter("@CUS_ID", SqlDbType.Int);
                    CUS_ID.Direction = ParameterDirection.Input;
                    CUS_ID.Value = Convert.ToInt32(kumbara);
                    command.Parameters.Add(CUS_ID);

                    SqlParameter DROPOFFLOC_ID = new SqlParameter("@DROPOFFLOC_ID", SqlDbType.VarChar, 10);
                    DROPOFFLOC_ID.Direction = ParameterDirection.Input;
                    DROPOFFLOC_ID.Value = DropDownList2.Text;
                    command.Parameters.Add(DROPOFFLOC_ID);

                    SqlParameter PICUPLOC_ID = new SqlParameter("@PICUPLOC_ID", SqlDbType.VarChar, 10);
                    PICUPLOC_ID.Direction = ParameterDirection.Input;
                    PICUPLOC_ID.Value = DropDownList1.Text;
                    command.Parameters.Add(PICUPLOC_ID);

                    SqlParameter REG_NUM = new SqlParameter("@REG_NUM", SqlDbType.VarChar, 30);
                    REG_NUM.Direction = ParameterDirection.Input;
                    REG_NUM.Value = bara;
                    command.Parameters.Add(REG_NUM);

                    command.ExecuteNonQuery();
                    con.Close();


                        
                    }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label10.Visible = true;
            Label11.Visible = true;
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            TextBox8.Visible = true;
            TextBox9.Visible = true;
            Button2.Visible = true;
            Button21.Visible = true;
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            string email = Request.Cookies["UserEmail"].Value;

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

          



            SqlCommand coma = new SqlCommand("SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL='" + email + "'", con);
            con.Open();

            SqlDataReader read = coma.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string kumbara = "not";

            while (read.Read())
            {
                kumbara = read[0].ToString();
            }


            con.Close();


            SqlCommand com = new SqlCommand("INSERT INTO RESERVATION(PICKUPLOC_ID,DRPOFFLOC_ID,CUS_ID,PICKUPDATE,DROPOFFDATE) VALUES ('"+DropDownList1.Text+"','"+DropDownList2.Text+"','"+kumbara+"','" + TextBox8.Text + "','" + TextBox9.Text + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();





        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label12.Visible = true;
            Label13.Visible = true;
            DropDownList3.Visible = true;
            DropDownList4.Visible = true;
            TextBox10.Visible = true;
            TextBox11.Visible = true;
            Button23.Visible = true;
            Button24.Visible = true;
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            string email = Request.Cookies["UserEmail"].Value;

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");





            SqlCommand coma = new SqlCommand("SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL='" + email + "'", con);
            con.Open();

            SqlDataReader read = coma.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string kumbara = "not";

            while (read.Read())
            {
                kumbara = read[0].ToString();
            }


            con.Close();


            SqlCommand com = new SqlCommand("INSERT INTO RESERVATION(PICKUPLOC_ID,DRPOFFLOC_ID,CUS_ID,PICKUPDATE,DROPOFFDATE) VALUES ('" + DropDownList3.Text + "','" + DropDownList4.Text + "','" + kumbara + "','" + TextBox10.Text + "','" + TextBox11.Text + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();





        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label12.Visible = true;
            Label13.Visible = true;
            DropDownList3.Visible = true;
            DropDownList4.Visible = true;
            TextBox10.Visible = true;
            TextBox11.Visible = true;
            Button23.Visible = true;
            Button24.Visible = true;
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            string email = Request.Cookies["UserEmail"].Value;
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            SqlCommand coma = new SqlCommand("SELECT REG_NUM FROM VEHICLE WHERE PICTURE='" + Image2.ImageUrl + "'", con);
            con.Open();

            SqlDataReader reade = coma.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string bara = "not";

            while (reade.Read())
            {
                bara = reade[0].ToString();
            }


            con.Close();







            SqlCommand com = new SqlCommand("SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL='" + email + "'", con);
            con.Open();

            SqlDataReader read = com.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string kumbara = "not";

            while (read.Read())
            {
                kumbara = read[0].ToString();
            }


            con.Close();

            con.Open();
            SqlCommand command = new SqlCommand("sp_rentcar", con);
            command.CommandType = CommandType.StoredProcedure;


            SqlParameter STARTDATE = new SqlParameter("@STARTDATE", SqlDbType.Date);
            STARTDATE.Direction = ParameterDirection.Input;
            STARTDATE.Value = TextBox10.Text;
            command.Parameters.Add(STARTDATE);

            SqlParameter ENDDATE = new SqlParameter("@ENDDATE", SqlDbType.Date);
            ENDDATE.Direction = ParameterDirection.Input;
            ENDDATE.Value = TextBox11.Text;
            command.Parameters.Add(ENDDATE);

            SqlParameter CUS_ID = new SqlParameter("@CUS_ID", SqlDbType.Int);
            CUS_ID.Direction = ParameterDirection.Input;
            CUS_ID.Value = Convert.ToInt32(kumbara);
            command.Parameters.Add(CUS_ID);

            SqlParameter DROPOFFLOC_ID = new SqlParameter("@DROPOFFLOC_ID", SqlDbType.VarChar, 10);
            DROPOFFLOC_ID.Direction = ParameterDirection.Input;
            DROPOFFLOC_ID.Value = DropDownList4.Text;
            command.Parameters.Add(DROPOFFLOC_ID);

            SqlParameter PICUPLOC_ID = new SqlParameter("@PICUPLOC_ID", SqlDbType.VarChar, 10);
            PICUPLOC_ID.Direction = ParameterDirection.Input;
            PICUPLOC_ID.Value = DropDownList3.Text;
            command.Parameters.Add(PICUPLOC_ID);

            SqlParameter REG_NUM = new SqlParameter("@REG_NUM", SqlDbType.VarChar, 30);
            REG_NUM.Direction = ParameterDirection.Input;
            REG_NUM.Value = bara;
            command.Parameters.Add(REG_NUM);

            command.ExecuteNonQuery();
            con.Close();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label14.Visible = true;
            Label15.Visible = true;
            DropDownList5.Visible = true;
            DropDownList6.Visible = true;
            TextBox12.Visible = true;
            TextBox13.Visible = true;
            Button26.Visible = true;
            Button28.Visible = true;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label14.Visible = true;
            Label15.Visible = true;
            DropDownList5.Visible = true;
            DropDownList6.Visible = true;
            TextBox12.Visible = true;
            TextBox13.Visible = true;
            Button26.Visible = true;
            Button28.Visible = true;
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            string email = Request.Cookies["UserEmail"].Value;
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            SqlCommand coma = new SqlCommand("SELECT REG_NUM FROM VEHICLE WHERE PICTURE='" + Image3.ImageUrl + "'", con);
            con.Open();

            SqlDataReader reade = coma.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string bara = "not";

            while (reade.Read())
            {
                bara = reade[0].ToString();
            }


            con.Close();







            SqlCommand com = new SqlCommand("SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL='" + email + "'", con);
            con.Open();

            SqlDataReader read = com.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string kumbara = "not";

            while (read.Read())
            {
                kumbara = read[0].ToString();
            }


            con.Close();

            con.Open();
            SqlCommand command = new SqlCommand("sp_rentcar", con);
            command.CommandType = CommandType.StoredProcedure;


            SqlParameter STARTDATE = new SqlParameter("@STARTDATE", SqlDbType.Date);
            STARTDATE.Direction = ParameterDirection.Input;
            STARTDATE.Value = TextBox12.Text;
            command.Parameters.Add(STARTDATE);

            SqlParameter ENDDATE = new SqlParameter("@ENDDATE", SqlDbType.Date);
            ENDDATE.Direction = ParameterDirection.Input;
            ENDDATE.Value = TextBox13.Text;
            command.Parameters.Add(ENDDATE);

            SqlParameter CUS_ID = new SqlParameter("@CUS_ID", SqlDbType.Int);
            CUS_ID.Direction = ParameterDirection.Input;
            CUS_ID.Value = Convert.ToInt32(kumbara);
            command.Parameters.Add(CUS_ID);

            SqlParameter DROPOFFLOC_ID = new SqlParameter("@DROPOFFLOC_ID", SqlDbType.VarChar, 10);
            DROPOFFLOC_ID.Direction = ParameterDirection.Input;
            DROPOFFLOC_ID.Value = DropDownList6.Text;
            command.Parameters.Add(DROPOFFLOC_ID);

            SqlParameter PICUPLOC_ID = new SqlParameter("@PICUPLOC_ID", SqlDbType.VarChar, 10);
            PICUPLOC_ID.Direction = ParameterDirection.Input;
            PICUPLOC_ID.Value = DropDownList5.Text;
            command.Parameters.Add(PICUPLOC_ID);

            SqlParameter REG_NUM = new SqlParameter("@REG_NUM", SqlDbType.VarChar, 30);
            REG_NUM.Direction = ParameterDirection.Input;
            REG_NUM.Value = bara;
            command.Parameters.Add(REG_NUM);

            command.ExecuteNonQuery();
            con.Close();

        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            string email = Request.Cookies["UserEmail"].Value;

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");





            SqlCommand coma = new SqlCommand("SELECT CUS_ID FROM CUSTOMERS WHERE CUS_EMAIL='" + email + "'", con);
            con.Open();

            SqlDataReader read = coma.ExecuteReader();

            //       SqlDataReader read = command.ExecuteReader();
            string kumbara = "not";

            while (read.Read())
            {
                kumbara = read[0].ToString();
            }


            con.Close();


            SqlCommand com = new SqlCommand("INSERT INTO RESERVATION(PICKUPLOC_ID,DRPOFFLOC_ID,CUS_ID,PICKUPDATE,DROPOFFDATE) VALUES ('" + DropDownList5.Text + "','" + DropDownList6.Text + "','" + kumbara + "','" + TextBox12.Text + "','" + TextBox13.Text + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();





        }
    }
}