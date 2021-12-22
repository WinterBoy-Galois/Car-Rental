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
    public partial class MakeReservation : MetroFramework.Forms.MetroForm
    {
        string id;
        string number;
        string name;
        string last;

        public MakeReservation(string customerid, string customerfirstname, string customerlastname, string customerphonenumber)
        {
            this.id = customerid;
            this.number = customerphonenumber;
            this.name = customerfirstname;
            this.last = customerlastname;

            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectReservationCustomer rs = new SelectReservationCustomer();
            rs.ShowDialog();
        }

        private void rESERVATIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESERVATIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.RESERVATION' table. You can move, or remove it, as needed.
            this.rESERVATIONTableAdapter.Fill(this.cARRENTALDataSet.RESERVATION);
            this.mycusid.Text = this.id;
            this.myfirstname.Text = this.name;
            this.mylastname.Text = this.last;
            this.myphonenumber.Text = this.number;

        }
        public void getreservationDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RESERVATION", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            rESERVATIONDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try

            {
                
                    DialogResult DR =MetroFramework.MetroMessageBox.Show(this,"Are You Sure You want to Make a Reservation with customer named "+"\n"+myfirstname.Text+" "+mylastname.Text, "Message",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {


                        con.Open();
                        SqlCommand command = new SqlCommand("sp_makereservation", con);
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter PICKUPLOC_ID = new SqlParameter("@PICKUPLOC_ID", SqlDbType.VarChar, 10);
                        PICKUPLOC_ID.Direction = ParameterDirection.Input;
                        PICKUPLOC_ID.Value = pickuplocation.SelectedItem;
                        command.Parameters.Add(PICKUPLOC_ID);

                        SqlParameter DRPOFFLOC_ID = new SqlParameter("@DRPOFFLOC_ID", SqlDbType.VarChar, 10);
                        DRPOFFLOC_ID.Direction = ParameterDirection.Input;
                        DRPOFFLOC_ID.Value = dropofflocation.SelectedItem;
                        command.Parameters.Add(DRPOFFLOC_ID);

                        SqlParameter CAT_ID = new SqlParameter("@CAT_ID", SqlDbType.VarChar, 20);
                        CAT_ID.Direction = ParameterDirection.Input;
                        CAT_ID.Value = vehiclecategory.SelectedItem;
                        command.Parameters.Add(CAT_ID);

                        SqlParameter CUS_ID = new SqlParameter("@CUS_ID", SqlDbType.Int);
                        CUS_ID.Direction = ParameterDirection.Input;
                        CUS_ID.Value =mycusid.Text;
                        command.Parameters.Add(CUS_ID);



                        SqlParameter @PICKUPDATE = new SqlParameter("@PICKUPDATE", SqlDbType.Date);
                        PICKUPDATE.Direction = ParameterDirection.Input;
                        PICKUPDATE.Value = startDate.Text;
                        command.Parameters.Add(PICKUPDATE);


                        SqlParameter @DROPOFFDATE = new SqlParameter("@DROPOFFDATE", SqlDbType.Date);
                        DROPOFFDATE.Direction = ParameterDirection.Input;
                        DROPOFFDATE.Value = endDate.Text;
                        command.Parameters.Add(@DROPOFFDATE);
                        command.ExecuteNonQuery();
                        con.Close();
                        MetroFramework.MetroMessageBox.Show(this,"Reservation completed successfully","Message",MessageBoxButtons.OK);
                        getreservationDataSet();
                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void vehiclecategory_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT CAT_ID FROM CATEGORY", con);
                SqlDataReader dr = command.ExecuteReader();
                vehiclecategory.Items.Clear();
                while (dr.Read())
                {
                    vehiclecategory.Items.Add(dr[0]);
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
    }
}
