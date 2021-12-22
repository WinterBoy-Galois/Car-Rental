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
    public partial class Update_Vehicle : MetroFramework.Forms.MetroForm
    {
        public Update_Vehicle()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Management_Dashboard w = new Vehicle_Management_Dashboard();
            w.ShowDialog();
        }

        private void vEHICLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void Update_Vehicle_Load(object sender, EventArgs e)
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if (string.IsNullOrEmpty(reg.Text) || string.IsNullOrEmpty(category.Text)|| string.IsNullOrEmpty(model.Text) || string.IsNullOrEmpty(production.Text) || string.IsNullOrEmpty(mileage.Text) || string.IsNullOrEmpty(rentprice.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill all Vehicle details.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reg.Focus();
                category.Focus();
                model.Focus();
                rentprice.Focus();
                production.Focus();
                mileage.Focus();
                return;
            }
         try
            {
                    DialogResult DR = MetroFramework.MetroMessageBox.Show(this,"Are You Sure You want To Update Car ?",  "Message",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("sp_updatevehicle", con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@REG_NUM", SqlDbType.VarChar, 30).Value = reg.Text;
                        command.Parameters.Add("@MILEAGE", SqlDbType.Int).Value = mileage.Text;
                        command.Parameters.Add("@PROD_YEAR", SqlDbType.Int).Value = production.Text;
                        command.Parameters.Add("@VEH_RENT_PRICE", SqlDbType.Int).Value = rentprice.Text;
                        command.Parameters.Add("@MODEL_ID", SqlDbType.VarChar, 30).Value = model.Text;
                        command.Parameters.Add("@CAT_ID", SqlDbType.VarChar, 20).Value = category.Text;
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Car Information Updated");
                        reg.Clear();
                        rentprice.Clear();
                        category.Clear();                       
                        model.Clear();
                        production.Clear();
                        mileage.Clear();
                        getVehicleDataSet();
                }
                else {
                    MessageBox.Show("Vehicle details not updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! : ", ex.Message);
            }
        }

        private void vEHICLEDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            reg.Text= vEHICLEDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            mileage.Text= vEHICLEDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            production.Text= vEHICLEDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            rentprice.Text= vEHICLEDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            model.Text= vEHICLEDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            category.Text= vEHICLEDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
