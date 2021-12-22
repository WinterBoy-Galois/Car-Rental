using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myCarRental
{
    public partial class NewCustomer : MetroFramework.Forms.MetroForm
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.cARRENTALDataSet.CUSTOMERS);

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagement cs = new CustomerManagement();
            cs.ShowDialog();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text)|| string.IsNullOrEmpty(lastname.Text)|| string.IsNullOrEmpty(male.Text)|| string.IsNullOrEmpty(female.Text)|| string.IsNullOrEmpty(email.Text)|| string.IsNullOrEmpty(phonenumber.Text)|| string.IsNullOrEmpty(address.Text)|| string.IsNullOrEmpty(city.Text)||string.IsNullOrEmpty(country.Text))
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
                
                
                return;
            }

            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save customer details.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("addcustomer", con);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter CUS_FNAME = new SqlParameter("@CUS_FNAME", SqlDbType.VarChar, 30);
                    CUS_FNAME.Direction = ParameterDirection.Input;
                    CUS_FNAME.Value = firstname.Text;
                    command.Parameters.Add(CUS_FNAME);

                    SqlParameter CUS_LNAME = new SqlParameter("@CUS_LNAME", SqlDbType.VarChar, 30);
                    CUS_LNAME.Direction = ParameterDirection.Input;
                    CUS_LNAME.Value = lastname.Text;
                    command.Parameters.Add(CUS_LNAME);

                    SqlParameter CUS_INITIAL = new SqlParameter("@CUS_INITIAL", SqlDbType.Char, 1);
                    CUS_INITIAL.Direction = ParameterDirection.Input;
                    CUS_INITIAL.Value = initial.Text;
                    command.Parameters.Add(CUS_INITIAL);

                    SqlParameter CUS_EMAIL = new SqlParameter("@CUS_EMAIL", SqlDbType.VarChar, 125);
                    CUS_EMAIL.Direction = ParameterDirection.Input;
                    CUS_EMAIL.Value = email.Text;
                    command.Parameters.Add(CUS_EMAIL);

                    SqlParameter CUS_CELL = new SqlParameter("@CUS_CELL", SqlDbType.VarChar, 11);
                    CUS_CELL.Direction = ParameterDirection.Input;
                    CUS_CELL.Value = phonenumber.Text;
                    command.Parameters.Add(CUS_CELL);

                    SqlParameter CUS_ADDRESS = new SqlParameter("@CUS_ADDRESS", SqlDbType.VarChar, 255);
                    CUS_ADDRESS.Direction = ParameterDirection.Input;
                    CUS_ADDRESS.Value = address.Text;
                    command.Parameters.Add(CUS_ADDRESS);

                    
                    if (male.Checked)
                    {
                        SqlParameter CUS_GENDER = new SqlParameter("@CUS_GENDER", SqlDbType.VarChar, 6);
                     CUS_GENDER.Direction = ParameterDirection.Input;
                     CUS_GENDER.Value = "male";
                     command.Parameters.Add(CUS_GENDER);
                    }
                    else if(female.Checked)
                    {
                        SqlParameter CUS_GENDER = new SqlParameter("@CUS_GENDER", SqlDbType.VarChar, 6);
                        CUS_GENDER.Direction = ParameterDirection.Input;
                        CUS_GENDER.Value = "female";
                        command.Parameters.Add(CUS_GENDER);
                    }

                    SqlParameter CUS_CITY = new SqlParameter("@CUS_CITY", SqlDbType.VarChar, 255);
                    CUS_CITY.Direction = ParameterDirection.Input;
                    CUS_CITY.Value = city.Text;
                    command.Parameters.Add(CUS_CITY);

                    SqlParameter CUS_COUNTRY = new SqlParameter("@CUS_COUNTRY", SqlDbType.VarChar, 255);
                    CUS_COUNTRY.Direction = ParameterDirection.Input;
                    CUS_COUNTRY.Value = country.Text;
                    command.Parameters.Add(CUS_COUNTRY);

                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Customer added succesfully");

                    firstname.Clear();
                    lastname.Clear();
                    initial.Clear();
                    email.Clear();
                    phonenumber.Clear();
                    address.Clear();
                    city.Clear();
                    country.Clear();
                  
                    getCustomerDataSet();


                }







            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cUSTOMERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void cUSTOMERSDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firstname.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            lastname.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            initial.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[3].Value.ToString();

            email.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            phonenumber.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[5].Value.ToString();

            address.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[6].Value.ToString();

               

            city.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[8].Value.ToString();

            country.Text = cUSTOMERSDataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }
    }
}
