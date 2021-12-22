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
    public partial class DeleteCustomer : MetroFramework.Forms.MetroForm
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagement cs = new CustomerManagement();
            cs.ShowDialog();
        }

        private void cUSTOMERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.cARRENTALDataSet.CUSTOMERS);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        public void getCustomerDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CUSTOMERS", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cUSTOMERSDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void cUSTOMERSDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int id = Int32.Parse(cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if (id<0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No Customer selected to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
 
            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete customer named "+cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString()+" "+ cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString()+"?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(DR==DialogResult.Yes)
                {
                    String frstname= cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    String lstname= cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    con.Open();
                    SqlCommand deletecus = new SqlCommand("DELETE FROM CUSTOMERS WHERE CUS_ID =" + "'" + cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    deletecus.ExecuteNonQuery();
                    con.Close();
                    getCustomerDataSet();
                    MetroFramework.MetroMessageBox.Show(this, "Customer named " +  frstname+ " " +lstname +" "+ "has been deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Customer named " + cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString() + " " + cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString() + "not deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Error","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CUSTOMERS", con);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            cUSTOMERSDataGridView.DataSource = datatable;

            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("CUS_CELL LIKE '%{0}%'", Searchbyphone.Text);
            cUSTOMERSDataGridView.DataSource = DV;

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cUSTOMERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
