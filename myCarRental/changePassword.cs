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
    public partial class changePassword : MetroFramework.Forms.MetroForm
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(oldpassword.Text)||string.IsNullOrEmpty(newpassword.Text))
            {
                newpassword.Focus();
                oldpassword.Focus();
                return;
            }
            SqlConnection con = new SqlConnection("Server=BLESSINGS-PC\\SQLEXPRESS;Database=CARRENTAL;Integrated Security=true");
            try
            {
                DialogResult DR = MessageBox.Show("Are You Sure You want to change password ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DR == DialogResult.Yes)
                {
                    try
                    {
                        using (CARRENTALEntities3 db = new CARRENTALEntities3())
                        {
                            var query = from u in db.Users
                                        where u.UserName == "admin" && u.Password == oldpassword.Text
                                        select u;
                            if (query.SingleOrDefault() != null)
                            {
                                con.Open();
                                SqlCommand command = new SqlCommand("sp_changepassword", con);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("@UserName", SqlDbType.VarChar, 25).Value = "admin";
                                command.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = newpassword.Text;
                                command.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Password changed");
                                oldpassword.Clear();
                                newpassword.Clear();
                            }

                            else
                                MetroFramework.MetroMessageBox.Show(this, "Error Password not changed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }



            
            catch (Exception)
            {
                

                            MetroFramework.MetroMessageBox.Show(this, "Your user name or password is incorrrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePassword_Load(object sender, EventArgs e)
        {

        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard b = new Dashboard();
            b.ShowDialog();
        }
    }
}
