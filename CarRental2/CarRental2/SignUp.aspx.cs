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
    public partial class SignUp : System.Web.UI.Page
    {





        SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
        public void Bind_ddlCountry()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT COUNTRY_CODE,COUNTRY_NAME FROM COUNTRY", con);
            SqlDataReader dr = com.ExecuteReader();
            CountryList.DataSource = dr;
            CountryList.Items.Clear();
            CountryList.Items.Add("...Please select Country...");
            CountryList.DataTextField = "COUNTRY_NAME";
            CountryList.DataValueField = "COUNTRY_CODE";
            CountryList.DataBind();
            con.Close();



        }
        public void Bind_ddlCity()
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT CITY_CODE,CITY_NAME FROM CITY WHERE COUNTRY_CODE='" + CountryList.SelectedValue + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            CityList.DataSource = dr;
            CityList.Items.Clear();
            CityList.Items.Add("...Please Select City...");
            CityList.DataTextField = "CITY_NAME";
            CityList.DataValueField = "CITY_CODE";
            CityList.DataBind();
            con.Close();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label14.Visible = false;
            if (!IsPostBack)
            {
                Bind_ddlCountry();
                Bind_ddlCity();
            }

        }
        protected void PasswordValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value.Length >= 8 && args.Value.Length <= 20);
        }

        protected void CountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_ddlCity();
            if (CountryList.SelectedIndex==1)
            {
                Label13.Text = "+90";
            }
            if (CountryList.SelectedIndex == 0)
            {
                Label13.Text = "+1";
            }
            if (CountryList.SelectedIndex == 2)
            {
                Label13.Text = "+265";
            }
        }

        protected void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox3_CheckedChanged(EventArgs e)
        {

        }

        protected void Button1_Click(EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            localhost.WebService1 check = new localhost.WebService1();
         //   check.UsernameCheck(Emailtextbox.Text);
            if (check.UsernameCheck(Emailtextbox.Text))
            {
                Label14.Visible = true;
                
                Label14.Text = "email already taken";
            }




            else if (confirmtextbox.Checked)
            {
                SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
                con.Open();

                SqlCommand command = new SqlCommand("addcustomer", con);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter CUS_FNAME = new SqlParameter("@CUS_FNAME", SqlDbType.VarChar, 30);
                CUS_FNAME.Direction = ParameterDirection.Input;
                CUS_FNAME.Value = firstnameTextBox.Text;
                command.Parameters.Add(CUS_FNAME);

                SqlParameter CUS_LNAME = new SqlParameter("@CUS_LNAME", SqlDbType.VarChar, 30);
                CUS_LNAME.Direction = ParameterDirection.Input;
                CUS_LNAME.Value = lastnameTextbox.Text;
                command.Parameters.Add(CUS_LNAME);

                SqlParameter CUS_INITIAL = new SqlParameter("@CUS_INITIAL", SqlDbType.VarChar, 50);
                CUS_INITIAL.Direction = ParameterDirection.Input;
                CUS_INITIAL.Value = initialTextbox.Text;
                command.Parameters.Add(CUS_INITIAL);

                SqlParameter CUS_EMAIL = new SqlParameter("@CUS_EMAIL", SqlDbType.VarChar, 125);
                CUS_EMAIL.Direction = ParameterDirection.Input;
                CUS_EMAIL.Value = Emailtextbox.Text;
                command.Parameters.Add(CUS_EMAIL);

                SqlParameter CUS_CELL = new SqlParameter("@CUS_CELL", SqlDbType.VarChar, 20);
                CUS_CELL.Direction = ParameterDirection.Input;
                CUS_CELL.Value = Label13.Text + celltextbox.Text;
                command.Parameters.Add(CUS_CELL);

                SqlParameter CUS_ADDRESS = new SqlParameter("@CUS_ADDRESS", SqlDbType.VarChar, 255);
                CUS_ADDRESS.Direction = ParameterDirection.Input;
                CUS_ADDRESS.Value = addresstextbox.Text;
                command.Parameters.Add(CUS_ADDRESS);


                if (RadioButtonList2.SelectedValue=="Male")
                {
                    SqlParameter CUS_GENDER = new SqlParameter("@CUS_GENDER", SqlDbType.VarChar, 6);
                    CUS_GENDER.Direction = ParameterDirection.Input;
                    CUS_GENDER.Value = "Male";
                    command.Parameters.Add(CUS_GENDER);
                }
                else  
                {
                    SqlParameter CUS_GENDER = new SqlParameter("@CUS_GENDER", SqlDbType.VarChar, 6);
                    CUS_GENDER.Direction = ParameterDirection.Input;
                    CUS_GENDER.Value = "Female";
                    command.Parameters.Add(CUS_GENDER);
                }

                SqlParameter CUS_CITY = new SqlParameter("@CUS_CITY", SqlDbType.VarChar, 255);
                CUS_CITY.Direction = ParameterDirection.Input;
                CUS_CITY.Value = CityList.SelectedItem.Text;
                command.Parameters.Add(CUS_CITY);

                SqlParameter CUS_COUNTRY = new SqlParameter("@CUS_COUNTRY", SqlDbType.VarChar, 255);
                CUS_COUNTRY.Direction = ParameterDirection.Input;
                CUS_COUNTRY.Value = CountryList.SelectedItem.Text;
                command.Parameters.Add(CUS_COUNTRY);
                command.ExecuteNonQuery();

                SqlCommand com = new SqlCommand("addUsers", con);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter UserName = new SqlParameter("@UserName", SqlDbType.VarChar, 250);
                UserName.Direction = ParameterDirection.Input;
                UserName.Value = Emailtextbox.Text;
                com.Parameters.Add(UserName);

                SqlParameter UserType = new SqlParameter("@UserType", SqlDbType.Int);
                UserType.Direction = ParameterDirection.Input;
                UserType.Value = 1;
                com.Parameters.Add(UserType);



                SqlParameter Password = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                Password.Direction = ParameterDirection.Input;
                Password.Value = RetypePasswordTextbox.Text;
                com.Parameters.Add(Password);
                com.ExecuteNonQuery();






                con.Close();





                Response.Redirect("Account_Successfully_Created.aspx");

            }
        }

        protected void Emailtextbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}