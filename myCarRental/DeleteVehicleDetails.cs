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
    public partial class DeleteVehicleDetails : MetroFramework.Forms.MetroForm
    {
        public DeleteVehicleDetails()
        {
            InitializeComponent();
        }

        private void vEHICLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

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

        private void DeleteVehicleDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.cARRENTALDataSet.VEHICLE);

        }

        private void vEHICLEDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if(String.IsNullOrEmpty(vEHICLEDataGridView.SelectedRows[0].Cells[0].Value.ToString()))
            {

                MetroFramework.MetroMessageBox.Show(this, "Cant Delete Empty row", "message", MessageBoxButtons.OK);
                return;

            }
            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete vehicle registration number"+" " + vEHICLEDataGridView.SelectedRows[0].Cells[0].Value.ToString()+"?" , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    String regnum= vEHICLEDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    con.Open();
                    SqlCommand deletecus = new SqlCommand("DELETE FROM VEHICLE WHERE REG_NUM = "+"'"+regnum+"'", con);
                    deletecus.ExecuteNonQuery();
                    con.Close();
                    getVehicleDataSet();
                    MetroFramework.MetroMessageBox.Show(this, "Vehicle Deleted " , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Vehicle Reg_Num " + vEHICLEDataGridView.SelectedRows[0].Cells[0].Value.ToString() + " "  + "not deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception )
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void vEHICLEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Management_Dashboard dsh = new Vehicle_Management_Dashboard();
            dsh.ShowDialog();
        }
    }
}
