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
    public partial class AddCategory : MetroFramework.Forms.MetroForm
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard v = new Category_Management_Dashboard();
            v.ShowDialog();
        }

        private void cATEGORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void AddCategory_Load(object sender, EventArgs e)
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
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                    DialogResult DR = MetroFramework.MetroMessageBox.Show(this,"Are You Sure You want to add a new category ? ", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("sp_addCategory", con);
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter CAT_ID = new SqlParameter("@CAT_ID", SqlDbType.VarChar, 20);
                        CAT_ID.Direction = ParameterDirection.Input;
                        CAT_ID.Value = categoryid.Text;
                        command.Parameters.Add(CAT_ID);

                        SqlParameter CAT_NAME = new SqlParameter("@CAT_NAME", SqlDbType.VarChar, 30);
                        CAT_NAME.Direction = ParameterDirection.Input;
                        CAT_NAME.Value = categoryname.Text;
                        command.Parameters.Add(CAT_NAME);

                        SqlParameter CATEGORY_DESCRIPTION = new SqlParameter("@CATEGORY_DESCRIPTION", SqlDbType.VarChar, 255);
                        CATEGORY_DESCRIPTION.Direction = ParameterDirection.Input;
                        CATEGORY_DESCRIPTION.Value = categorydescription.Text;
                        command.Parameters.Add(CATEGORY_DESCRIPTION);

                        command.ExecuteNonQuery();
                        con.Close();

                        MetroFramework.MetroMessageBox.Show(this,"Category added succesfully","message",MessageBoxButtons.OK);
                        getCategoryDataSet();
                    }
                
                else { MetroFramework.MetroMessageBox.Show(this,"Category not added"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
