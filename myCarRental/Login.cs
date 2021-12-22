using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCarRental
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;

                
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            _instance = this;
            
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            try
            {
                using (CARRENTALEntities3 db = new CARRENTALEntities3()) 
                {
                    var query = from u in db.Users
                                where u.UserName == txtUsername.Text && u.Password == txtPassword.Text
                                select u;
                    if(query.SingleOrDefault()!=null)
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.ShowDialog();
                    }
                    else
                    
                        MetroFramework.MetroMessageBox.Show(this, "Your user name or password is incorrrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
