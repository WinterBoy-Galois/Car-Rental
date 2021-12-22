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
    public partial class DeleteBrand : MetroFramework.Forms.MetroForm
    {
        public DeleteBrand()
        {
            InitializeComponent();
        }

        private void bRANDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bRANDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void DeleteBrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.BRAND' table. You can move, or remove it, as needed.
            this.bRANDTableAdapter.Fill(this.cARRENTALDataSet.BRAND);

        }
        public void getBrandDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BRAND", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            bRANDDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void DeleteBrand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        private void bRANDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BRAND", con);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            bRANDDataGridView.DataSource = datatable;

            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("BRAND_NAME LIKE '%{0}%'", searchbybrand.Text);
            bRANDDataGridView.DataSource = DV;

        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard v = new Category_Management_Dashboard();
            v.ShowDialog();
        }

        private void bRANDDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are You Sure You want To Delete Brand ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand deletecus = new SqlCommand("DELETE FROM BRAND WHERE BRAND_ID =" + "'" + bRANDDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    deletecus.ExecuteNonQuery();
                    con.Close();
                    MetroFramework.MetroMessageBox.Show(this, "Brand Deleted", "message", MessageBoxButtons.OK);
                    getBrandDataSet();

                }

                else
                {
                    MessageBox.Show("Brand not deleted");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!!", ex.Message);
            }
        }
    }

 }
    

