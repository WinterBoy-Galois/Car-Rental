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
    public partial class UpdateCategory : MetroFramework.Forms.MetroForm
    {
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard d = new Category_Management_Dashboard();
            d.ShowDialog();
        }

        private void cATEGORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.cARRENTALDataSet.CATEGORY);

        }
        public void getCategoryDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CATEGORY", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cATEGORYDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }


        private void save_Click(object sender, EventArgs e)
        {



            try
            {
                    DialogResult DR = MetroFramework.MetroMessageBox.Show(this,"Are You Sure You want To Update Category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
                        con.Open();
                        SqlCommand command = new SqlCommand("sp_updatecategory", con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@CAT_ID", SqlDbType.VarChar, 20).Value = categoryid.Text;
                        command.Parameters.Add("@CAT_NAME", SqlDbType.VarChar, 30).Value = categoryname.Text;
                        command.Parameters.Add("@CATEGORY_DESCRIPTION", SqlDbType.VarChar, 255).Value = categorydescription.Text;
                        command.ExecuteNonQuery();
                        con.Close();
                        MetroFramework.MetroMessageBox.Show(this,"Category Information Updated","message",MessageBoxButtons.OK);
                        categoryid.Clear();
                        categoryname.Clear();
                        categorydescription.Clear();
                        getCategoryDataSet();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Car Information Not Updated","message",MessageBoxButtons.OK);

                    }
                }
                            
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! : ", ex.Message);
            }

        }

        private void cATEGORYDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            categoryid.Text = cATEGORYDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            categoryname.Text = cATEGORYDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            categorydescription.Text = cATEGORYDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
