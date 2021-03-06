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
    public partial class SelectReservationCustomer : MetroFramework.Forms.MetroForm
    {
        public SelectReservationCustomer()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation_Management_Dashboard rs = new Reservation_Management_Dashboard();
            rs.ShowDialog();
        }

        private void cUSTOMERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void SelectReservationCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.cARRENTALDataSet.CUSTOMERS);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CUSTOMERS", con);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            cUSTOMERSDataGridView.DataSource = datatable;

            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("CUS_CELL LIKE '%{0}%'",searchbyphone.Text);
            cUSTOMERSDataGridView.DataSource = DV;

        }

        private void searchbyphone_Click(object sender, EventArgs e)
        {

        }

        private void cUSTOMERSDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Int32.Parse(cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if (id < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No Customer selected to make reservation" + "\n" + "Make Sure You Have Selected A customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to make a reservation with customer named " + "\n" + cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString() + " " + cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {



                    string cusid = cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    String frstname = cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    String lstname = cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    String phonenumber = cUSTOMERSDataGridView.SelectedRows[0].Cells[5].Value.ToString();

                    MakeReservation n = new MakeReservation(cusid, frstname, lstname, phonenumber);



                    this.Hide();
                    n.ShowDialog();






                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Customer named " + cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString() + " " + cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "Reservation cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cUSTOMERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
