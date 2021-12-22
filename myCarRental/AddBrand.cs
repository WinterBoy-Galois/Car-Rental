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
    public partial class AddBrand : MetroFramework.Forms.MetroForm
    {
        public AddBrand()
        {
            InitializeComponent();
        }

        private void bRANDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bRANDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void AddBrand_Load(object sender, EventArgs e)
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

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            if(string.IsNullOrEmpty(brandid.Text)||string.IsNullOrEmpty(brandname.Text))
            {
                MetroFramework.MetroMessageBox.Show(this,"Cant add empty fields","message",MessageBoxButtons.OK);
                brandid.Focus();
                brandname.Focus();
                return;
            }


            try
            {
                

                    DialogResult DR = MetroFramework.MetroMessageBox.Show(this,"Are You Sure You want to add a new brand ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("sp_addBrand", con);
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter BRAND_ID = new SqlParameter("@BRAND_ID", SqlDbType.VarChar, 30);
                        BRAND_ID.Direction = ParameterDirection.Input;
                        BRAND_ID.Value = brandid.Text;
                        command.Parameters.Add(BRAND_ID);

                        SqlParameter BRAND_NAME = new SqlParameter("@BRAND_NAME", SqlDbType.VarChar, 30);
                        BRAND_NAME.Direction = ParameterDirection.Input;
                        BRAND_NAME.Value = brandname.Text;
                        command.Parameters.Add(BRAND_NAME);
                        command.ExecuteNonQuery();
                        con.Close();


                        MetroFramework.MetroMessageBox.Show(this,"Brand added succesfully","message",MessageBoxButtons.OK);
                        brandid.Clear();
                        brandname.Clear();
                        getBrandDataSet();    
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Brand Not added","Message",MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard cs = new Category_Management_Dashboard();
            cs.ShowDialog();
        }
    }
}
