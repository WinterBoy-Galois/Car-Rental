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
    public partial class UpdateBrand : MetroFramework.Forms.MetroForm
    {
        public UpdateBrand()
        {
            InitializeComponent();
        }

        private void bRANDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bRANDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void UpdateBrand_Load(object sender, EventArgs e)
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
        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard b = new Category_Management_Dashboard();
            b.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(brandid.Text)||string.IsNullOrEmpty(brandname.Text))
            {


                brandname.Focus();
                brandid.Focus();
                return;
            }




            try
            {
                    DialogResult DR = MetroFramework.MetroMessageBox.Show(this,"Are You Sure You want To Update Brand ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
                        con.Open();


                        SqlCommand command = new SqlCommand("sp_updatebrand", con);

                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.Add("@BRAND_ID", SqlDbType.VarChar, 30).Value = brandid.Text;

                        command.Parameters.Add("@BRAND_NAME", SqlDbType.VarChar, 30).Value = brandname.Text;
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Brand Updated");
                        brandid.Clear();

                        brandname.Clear();

                        getBrandDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Brand Not Updated");

                    }       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! : ", ex.Message);
            }

        }

        private void bRANDDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            brandid.Text = bRANDDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            brandname.Text = bRANDDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void brandname_Click(object sender, EventArgs e)
        {

        }
    }
}
