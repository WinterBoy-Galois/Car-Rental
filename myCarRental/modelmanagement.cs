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
    public partial class modelmanagement : MetroFramework.Forms.MetroForm
    {
        public modelmanagement()
        {
            InitializeComponent();
        }

        private void mODELBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mODELBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cARRENTALDataSet);

        }

        private void AddModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cARRENTALDataSet.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.cARRENTALDataSet.MODEL);

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
        public void getModelDataSet()
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MODEL", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            mODELDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }



        private void metroTile1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                    DialogResult DR = MessageBox.Show("Are You Sure You want to add a new Model? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (DR == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("sp_addmodel", con);
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter MODEL_ID = new SqlParameter("@MODEL_ID", SqlDbType.VarChar, 30);
                        MODEL_ID.Direction = ParameterDirection.Input;
                        MODEL_ID.Value = modelid.Text;
                        command.Parameters.Add(MODEL_ID);

                        SqlParameter MODEL_NAME = new SqlParameter("@MODEL_NAME", SqlDbType.VarChar, 30);
                        MODEL_ID.Direction = ParameterDirection.Input;
                        MODEL_NAME.Value = modelname.Text;
                        command.Parameters.Add(MODEL_NAME);

                        SqlParameter BRANDID = new SqlParameter("@BRANDID", SqlDbType.VarChar, 30);
                        BRANDID.Direction = ParameterDirection.Input;
                        BRANDID.Value = brands.SelectedItem;
                        command.Parameters.Add(BRANDID);

                        command.ExecuteNonQuery();
                        con.Close();

                        modelid.Clear();
                        modelname.Clear();
                        brands.ResetText();
                        MessageBox.Show("Car added succesfully");
                        getModelDataSet();

                    }

                
                else { MessageBox.Show("Model not added"); }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mODELDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brands_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT BRAND_ID FROM BRAND", con);
                SqlDataReader dr = command.ExecuteReader();
                brands.Items.Clear();
                while (dr.Read())
                {
                    brands.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MODEL", con);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            mODELDataGridView.DataSource = datatable;

            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("MODEL_NAME LIKE '%{0}%'", modelnamesearch.Text);
            mODELDataGridView.DataSource = DV;

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                    DialogResult DR = MessageBox.Show("Are You Sure You want To Update Model ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
                        con.Open();


                        SqlCommand command = new SqlCommand("sp_updatemodel", con);

                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.Add("@MODEL_ID", SqlDbType.VarChar, 30).Value = modelid.Text;

                        command.Parameters.Add("@MODEL_NAME", SqlDbType.VarChar, 30).Value = modelname.Text;

                        command.Parameters.Add("@BRAND_ID", SqlDbType.VarChar, 30).Value = brands.Text;
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Model Updated");
                        modelid.Clear();

                        modelname.Clear();
                        brands.ResetText();
                        getModelDataSet();




                    }
                    else
                    {
                        MessageBox.Show("Model Not Updated");

                    }
                }
                

            
            catch (Exception ex)
            {
                MessageBox.Show("Error!!! : ", ex.Message);
            }
        }

        private void ChangePasswordTile_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                
                    DialogResult DR = MessageBox.Show("Are You Sure You want To Delete Model ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DR == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand deletecus = new SqlCommand("DELETE FROM MODEL WHERE MODEL_ID =" + "'" + modelid.Text + "'", con);
                        deletecus.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Model Deleted");
                        modelid.Clear();

                        modelname.Clear();
                        brands.ResetText();
                        getModelDataSet();

                    }

                
                else
                {
                    MessageBox.Show("Model not updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!!", ex.Message);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard b = new Category_Management_Dashboard();
            b.ShowDialog();
        }

        private void mODELDataGridView_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            modelid.Text = mODELDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            modelname.Text = mODELDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            brands.Text = mODELDataGridView.SelectedRows[0].Cells[2].Value.ToString();

        }
    }
}
