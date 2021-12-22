using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCarRental
{
    public partial class Rental : MetroFramework.Forms.MetroForm
    {

        string id;
        string number;
        string name;
        string last;



        public Rental(string customerid,string customerfirstname,string customerlastname,string customerphonenumber)
        {
            this.id = customerid;
            this.number = customerphonenumber;
            this.name = customerfirstname;
            this.last = customerlastname;

            InitializeComponent();
            

        }
        
        


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void rENTALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rENTALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void Rental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.cARRENTALDataSet.RENTAL);
            this.mycusid.Text = this.id;
            this.myfirstname.Text = this.name;
            this.mylastname.Text = this.last;
            this.myphonenumber.Text = this.number;
           
           

        }

        private void Rental_Shown(object sender, EventArgs e)
        {

        }

        private void Rental_Activated(object sender, EventArgs e)
        {

        }

        private void rENTALDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectRentalCustomer sc = new SelectRentalCustomer();
            sc.ShowDialog();

        }
        public void getRENTALDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RENTAL", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rENTALDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                DialogResult DR = MessageBox.Show("Are You Sure You want to rent a car ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("sp_rentcar", con);
                    command.CommandType = CommandType.StoredProcedure;


                    SqlParameter STARTDATE = new SqlParameter("@STARTDATE", SqlDbType.Date);
                    STARTDATE.Direction = ParameterDirection.Input;
                    STARTDATE.Value = startDate.Text;
                    command.Parameters.Add(STARTDATE);

                    SqlParameter ENDDATE = new SqlParameter("@ENDDATE", SqlDbType.Date);
                    ENDDATE.Direction = ParameterDirection.Input;
                    ENDDATE.Value = endDate.Text;
                    command.Parameters.Add(ENDDATE);

                    SqlParameter CUS_ID = new SqlParameter("@CUS_ID", SqlDbType.Int);
                    CUS_ID.Direction = ParameterDirection.Input;
                    CUS_ID.Value = mycusid.Text;
                    command.Parameters.Add(CUS_ID);

                    SqlParameter DROPOFFLOC_ID = new SqlParameter("@DROPOFFLOC_ID", SqlDbType.VarChar, 10);
                    DROPOFFLOC_ID.Direction = ParameterDirection.Input;
                    DROPOFFLOC_ID.Value = dropofflocation.SelectedItem;
                    command.Parameters.Add(DROPOFFLOC_ID);

                    SqlParameter PICUPLOC_ID = new SqlParameter("@PICUPLOC_ID", SqlDbType.VarChar, 10);
                    PICUPLOC_ID.Direction = ParameterDirection.Input;
                    PICUPLOC_ID.Value = pickuplocation.SelectedItem;
                    command.Parameters.Add(PICUPLOC_ID);

                    SqlParameter REG_NUM = new SqlParameter("@REG_NUM", SqlDbType.VarChar, 30);
                    REG_NUM.Direction = ParameterDirection.Input;
                    REG_NUM.Value = regnum.SelectedItem;
                    command.Parameters.Add(REG_NUM);

                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("CAR HAS BEEN RENTED");
                    getRENTALDataSet();









                }



            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT MODEL_ID FROM VEHICLE", con);
                SqlDataReader dr = command.ExecuteReader();
                model.Items.Clear();
                while (dr.Read())
                {
                    model.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!!!:", ex.Message);
            }

        }

        private void regnum_MouseClick(object sender, MouseEventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT REG_NUM FROM VEHICLE WHERE MODEL_ID = " + "'" + model.SelectedItem + "'", con);
                SqlDataReader dr = command.ExecuteReader();
                regnum.Items.Clear();
                while (dr.Read())
                {
                    regnum.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!!!!:", ex.Message);
            }
        }

        private void pickupcity_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT CITY_NAME FROM CITY", con);
                SqlDataReader dr = command.ExecuteReader();
                pickupcity.Items.Clear();
                while (dr.Read())
                {
                    pickupcity.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void pickuplocation_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_locationbycity", con);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter CITYNAME = new SqlParameter("@CITYNAME", SqlDbType.VarChar, 30);
                CITYNAME.Direction = ParameterDirection.Input;
                CITYNAME.Value = pickupcity.SelectedItem;
                command.Parameters.Add(CITYNAME);
                SqlDataReader reader = command.ExecuteReader();
                pickuplocation.Items.Clear();
                while (reader.Read())
                {
                   pickuplocation.Items.Add(reader[0]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LOCATION not found :", ex.Message);
            }
        }

        private void dropoffcity_MouseClick(object sender, MouseEventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT CITY_NAME FROM CITY", con);
                SqlDataReader dr = command.ExecuteReader();
                dropoffcity.Items.Clear();
                while (dr.Read())
                {
                    dropoffcity.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :", ex.Message);
            }
            finally
            {
                con.Close();
            }



        }

        private void dropofflocation_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_locationbycity", con);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter CITYNAME = new SqlParameter("@CITYNAME", SqlDbType.VarChar, 30);
                CITYNAME.Direction = ParameterDirection.Input;
                CITYNAME.Value = dropoffcity.SelectedItem;
                command.Parameters.Add(CITYNAME);
                SqlDataReader reader = command.ExecuteReader();
                dropofflocation.Items.Clear();
                while (reader.Read())
                {
                   dropofflocation.Items.Add(reader[0]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error LOCATION not found :", ex.Message);
            }
        }

        private void metroComboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT VEH_RENT_PRICE FROM VEHICLE WHERE REG_NUM =" + "'" + regnum.SelectedItem + "'", con);
                SqlDataReader dr = command.ExecuteReader();
                carprice.Items.Clear();
                while (dr.Read())
                {
                    carprice.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Vehicle not selected!!!!!:", ex.Message);
            }
        }
    }
}
