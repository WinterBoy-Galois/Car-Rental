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
    public partial class UpdateRental : MetroFramework.Forms.MetroForm
    {
        public UpdateRental()
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

        private void UpdateRental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.RENTAL' table. You can move, or remove it, as needed.
            this.rENTALTableAdapter.Fill(this.cARRENTALDataSet.RENTAL);

        }


        private void metroTile1_Click(object sender, EventArgs e)
        {


            try
            {

                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update rental with rent id"+" "+"\n"+rENTALDataGridView.SelectedRows[0].Cells[0].Value.ToString(), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
                    con.Open();
                    SqlCommand command = new SqlCommand("sp_updaterental", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@RENTAL_ID", SqlDbType.Int).Value = rENTALDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    command.Parameters.Add("@STARTDATE", SqlDbType.Date).Value = startDate.Text;
                    command.Parameters.Add("@ENDDATE", SqlDbType.Date).Value = endDate.Text;
                    command.Parameters.Add("@CUS_ID", SqlDbType.Int).Value = customerid.Text;
                    command.Parameters.Add("@PICUPLOC_ID", SqlDbType.VarChar, 10).Value = pickuplocation.Text;
                    command.Parameters.Add("@DROPOFFLOC_ID", SqlDbType.VarChar, 10).Value = dropofflocation.Text;
                    command.Parameters.Add("@REG_NUM", SqlDbType.VarChar, 30).Value = regnum.Text;
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Rental Information Updated");
                    
                    pickuplocation.Clear();
                    dropofflocation.Clear();
                    regnum.Clear();
                    customerid.Clear();
                    getRENTALDataSet();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Rental Information Not Updated","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! : ", ex.Message);
            }

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental_Management_DashBoard rt = new Rental_Management_DashBoard();
            rt.ShowDialog();
        }

        private void rENTALDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            startDate.Text = rENTALDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            endDate.Text = rENTALDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            customerid.Text = rENTALDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            regnum.Text=rENTALDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            pickuplocation.Text= rENTALDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            dropofflocation.Text= rENTALDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            
        }
    }
}
