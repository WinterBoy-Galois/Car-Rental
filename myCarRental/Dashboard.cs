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
    public partial class Dashboard : MetroFramework.Forms.MetroForm

    {
        bool _logOut;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            _logOut = true;
            this.Close();
            Login.Instance.Show(); 
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_logOut)
                Application.Exit();
        }

        private void CustomerTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagement cs = new CustomerManagement();
            cs.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void RentalTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental_Management_DashBoard rt = new Rental_Management_DashBoard();
            rt.ShowDialog();
        }

        private void ReservationTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation_Management_Dashboard rs = new Reservation_Management_Dashboard();
            rs.ShowDialog();
        }

        private void VehicleTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Management_Dashboard vh = new Vehicle_Management_Dashboard();
            vh.ShowDialog();
        }

        private void CategoryTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category_Management_Dashboard c = new Category_Management_Dashboard();
            c.ShowDialog();
        }

        private void ChangePasswordTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword n = new changePassword();
            n.ShowDialog();
        }
    }
}
