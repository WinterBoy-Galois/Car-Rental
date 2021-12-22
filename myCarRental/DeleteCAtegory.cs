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
    public partial class DeleteCAtegory : MetroFramework.Forms.MetroForm
    {
        public DeleteCAtegory()
        {
            InitializeComponent();
        }

        private void cATEGORYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void DeleteCAtegory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.CATEGORY' table. You can move, or remove it, as needed.
            this.cATEGORYTableAdapter.Fill(this.cARRENTALDataSet.CATEGORY);

        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard c = new Category_Management_Dashboard();
            c.ShowDialog();
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

        private void cATEGORYDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(cATEGORYDataGridView.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select a row to delete.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }



            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete category named " +cATEGORYDataGridView.SelectedRows[0].Cells[1].Value.ToString() + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand deletecus = new SqlCommand("DELETE FROM CATEGORY WHERE CAT_ID =" + "'" + cATEGORYDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    deletecus.ExecuteNonQuery();
                    con.Close();
                    getCategoryDataSet();
                    MetroFramework.MetroMessageBox.Show(this, "Category  deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Category not deleted" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cATEGORYDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CATEGORY", con);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            cATEGORYDataGridView.DataSource = datatable;

            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("CAT_NAME LIKE '%{0}%'", metroTextBox1.Text);
            cATEGORYDataGridView.DataSource = DV;

        }
    }
}
