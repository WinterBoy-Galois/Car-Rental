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
    public partial class NewVehicle : MetroFramework.Forms.MetroForm
    {
        public NewVehicle()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Management_Dashboard vh = new Vehicle_Management_Dashboard();
            vh.ShowDialog();
        }

        private void vEHICLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void NewVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.cARRENTALDataSet.VEHICLE);

        }
        public void getVehicleDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VEHICLE", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            vEHICLEDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if (string.IsNullOrEmpty(reg.Text) || string.IsNullOrEmpty(category.Text) || string.IsNullOrEmpty(brands.Text) || string.IsNullOrEmpty(model.Text) || string.IsNullOrEmpty(production.Text) || string.IsNullOrEmpty(mileage.Text) || string.IsNullOrEmpty(rentprice.Text) )
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill all Vehicle details.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reg.Focus();
                brands.Focus();
               category.Focus();
              model.Focus();
                rentprice.Focus();
                production.Focus();
                mileage.Focus();
                

                return;
            }

            try
            {
              



                
                    DialogResult DR = MessageBox.Show("Are You Sure You want to add a new Car? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (DR == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("sp_addvehicle", con);
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter REG_NUM = new SqlParameter("@REG_NUM", SqlDbType.VarChar, 30);
                        REG_NUM.Direction = ParameterDirection.Input;
                        REG_NUM.Value = reg.Text;
                        command.Parameters.Add(REG_NUM);

                        SqlParameter MODEL_ID = new SqlParameter("@MODEL_ID", SqlDbType.VarChar, 30);
                        MODEL_ID.Direction = ParameterDirection.Input;
                        MODEL_ID.Value = model.SelectedItem;
                        command.Parameters.Add(MODEL_ID);

                        SqlParameter CAT_ID = new SqlParameter("@CAT_ID", SqlDbType.VarChar, 20);
                        CAT_ID.Direction = ParameterDirection.Input;
                        CAT_ID.Value = category.SelectedItem;
                        command.Parameters.Add(CAT_ID);

                        SqlParameter MILEAGE = new SqlParameter("@MILEAGE", SqlDbType.Int, 125);
                        MILEAGE.Direction = ParameterDirection.Input;
                        MILEAGE.Value = mileage.Text;
                        command.Parameters.Add(MILEAGE);

                        SqlParameter PROD_YEAR = new SqlParameter("@PROD_YEAR", SqlDbType.Int);
                        PROD_YEAR.Direction = ParameterDirection.Input;
                        PROD_YEAR.Value = production.Text;
                        command.Parameters.Add(PROD_YEAR);

                        SqlParameter VEH_RENT_PICE = new SqlParameter("@VEH_RENT_PRICE", SqlDbType.Decimal);
                        VEH_RENT_PICE.Direction = ParameterDirection.Input;
                        VEH_RENT_PICE.Value = rentprice.Text;
                        command.Parameters.Add(VEH_RENT_PICE);


                        command.ExecuteNonQuery();
                        con.Close();
                        reg.Clear();
                        production.Clear();
                        mileage.Clear();
                        rentprice.Clear();

                         brands.ResetText() ;
                        category.ResetText();
                        model.ResetText();

                        getVehicleDataSet();
                        MessageBox.Show("Car added succesfully");

                  }
                else { MessageBox.Show("Vehicle not added"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void category_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT CAT_ID FROM CATEGORY", con);
                SqlDataReader dr = command.ExecuteReader();
                category.Items.Clear();
                while (dr.Read())
                {
                    category.Items.Add(dr[0]);
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

        private void brands_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT BRAND_ID FROM BRAND", con);
                SqlDataReader dr = command.ExecuteReader();
                brands.Items.Clear();
                while (dr.Read())
                {
                    brands.Items.Add(dr[0]);
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

        private void model_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("sp_modelbybrand", con);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter BRND_NAME = new SqlParameter("@BRND_NAME", SqlDbType.VarChar, 30);
                BRND_NAME.Direction = ParameterDirection.Input;
                BRND_NAME.Value = brands.SelectedItem;
                command.Parameters.Add(BRND_NAME);
                SqlDataReader reader = command.ExecuteReader();
                model.Items.Clear();
                while (reader.Read())
                {
                    model.Items.Add(reader[0]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Brand not found :", ex.Message);
            }
        }
    }
}
