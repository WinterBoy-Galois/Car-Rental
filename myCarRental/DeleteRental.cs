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
    public partial class DeleteRental : MetroFramework.Forms.MetroForm
    {
        public DeleteRental()
        {
            InitializeComponent();
        }

        private void rENTALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rENTALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

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

        private void DeleteRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.cARRENTALDataSet.RENTAL);

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental_Management_DashBoard l = new Rental_Management_DashBoard();
            l.ShowDialog();
        }

        private void rENTALDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Int32.Parse(rENTALDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if (id < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No rental selected to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete customer this rental"  + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand deletecus = new SqlCommand("DELETE FROM RENTAL WHERE RENTAL_ID =" + "'" + rENTALDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    deletecus.ExecuteNonQuery();
                    con.Close();
                    getRENTALDataSet();
                    MetroFramework.MetroMessageBox.Show(this, "Rental Deleted" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Rental not deleted " , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
