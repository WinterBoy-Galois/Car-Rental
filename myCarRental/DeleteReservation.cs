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
    public partial class DeleteReservation : MetroFramework.Forms.MetroForm
    {
        public DeleteReservation()
        {
            InitializeComponent();
        }

        private void rESERVATIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rESERVATIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void DeleteReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.RESERVATION' table. You can move, or remove it, as needed.
            this.rESERVATIONTableAdapter.Fill(this.cARRENTALDataSet.RESERVATION);

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
        private void rESERVATIONDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Int32.Parse(rESERVATIONDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if (id < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No reservation selected to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this reservation" + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand deleteres = new SqlCommand("DELETE FROM RESERVATION WHERE RES_ID =" + "'" + rESERVATIONDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    deleteres.ExecuteNonQuery();
                    con.Close();
                    getreservationDataSet();
                    MetroFramework.MetroMessageBox.Show(this, "Reservation Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Reservation not deleted ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception )
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM RESERVATION", con);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            rESERVATIONDataGridView.DataSource = datatable;

            DataView DV = new DataView(datatable);
            try
            {
                DV.RowFilter = string.Format("RES_ID = {0}", int.Parse(metroTextBox1.Text));

                rESERVATIONDataGridView.DataSource = DV;
            }catch(Exception){ return; }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation_Management_Dashboard rs = new Reservation_Management_Dashboard();
            rs.ShowDialog();
        }
    }
}
