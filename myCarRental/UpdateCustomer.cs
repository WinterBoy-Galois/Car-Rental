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
    public partial class UpdateCustomer : MetroFramework.Forms.MetroForm
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagement cs = new CustomerManagement();
            cs.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.cARRENTALDataSet.CUSTOMERS);

        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void Searchbyphone_TextChanged(object sender, EventArgs e)
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

        private void cUSTOMERSDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            male.Checked = false;
            female.Checked = false;


            cusid.Text= cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            firstname.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            lastname.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            initial.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[3].Value.ToString();

            email.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            phonenumber.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[5].Value.ToString();

            address.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            if (cUSTOMERSDataGridView.SelectedRows[0].Cells[7].Value.ToString() == "male")
            {
                male.Checked = true;
            }
            else if (cUSTOMERSDataGridView.SelectedRows[0].Cells[7].Value.ToString() == "female")
            {
                female.Checked = true;
            }
            city.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            country.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[9].Value.ToString();
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


        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(male.Text) || string.IsNullOrEmpty(female.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(phonenumber.Text) || string.IsNullOrEmpty(address.Text) || string.IsNullOrEmpty(city.Text) || string.IsNullOrEmpty(country.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill all customer details.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstname.Focus();
                lastname.Focus();
                phonenumber.Focus();
                address.Focus();
                country.Focus();
                city.Focus();
                male.Focus();
                female.Focus();
                email.Focus();
                cusid.Focus();
                return;
            }
            try
            {

                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save customer details.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
                        con.Open();          
                        SqlCommand command = new SqlCommand("sp_updateCustomer", con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@CUS_ID", SqlDbType.Int).Value =cusid.Text;
                        command.Parameters.Add("@CUS_FNAME", SqlDbType.VarChar, 30).Value = firstname.Text;
                        command.Parameters.Add("@CUS_LNAME", SqlDbType.VarChar, 30).Value = lastname.Text;
                        command.Parameters.Add("@CUS_INITIAL", SqlDbType.Char, 1).Value = initial.Text;
                        command.Parameters.Add("@CUS_EMAIL", SqlDbType.VarChar, 125).Value = email.Text;
                        command.Parameters.Add("@CUS_CELL", SqlDbType.VarChar, 11).Value = phonenumber.Text;
                        command.Parameters.Add("@CUS_ADDRESS", SqlDbType.VarChar, 255).Value = address.Text;
                        if(male.Checked)
                        command.Parameters.Add("@CUS_GENDER", SqlDbType.VarChar, 6).Value = "male";
                        else if(female.Checked)
                        command.Parameters.Add("@CUS_GENDER", SqlDbType.VarChar, 6).Value = "female";
                        command.Parameters.Add("@CUS_CITY", SqlDbType.VarChar, 255).Value = city.Text;
                        command.Parameters.Add("@CUS_COUNTRY", SqlDbType.VarChar, 255).Value = country.Text;
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Customer Information Updated");
                        cusid.Clear();
                        firstname.Clear();
                        lastname.Clear();
                        initial.Clear();
                        email.Clear();
                        phonenumber.Clear();
                        address.Clear();
                        male.Checked = false;
                        female.Checked = false;
                        city.Clear();
                        country.Clear();
                        getCustomerDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Customer Information Not Updated");

                    }
                
              }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! : ", ex.Message);
            }
        }

        private void cUSTOMERSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
