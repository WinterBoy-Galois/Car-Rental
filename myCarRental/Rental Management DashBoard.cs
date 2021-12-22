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
    public partial class Rental_Management_DashBoard : MetroFramework.Forms.MetroForm
    {
        public Rental_Management_DashBoard()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectRentalCustomer sl = new SelectRentalCustomer();
            sl.ShowDialog();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRental dl = new DeleteRental();
            dl.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateRental up = new UpdateRental();
            up.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentalReport d = new rentalReport();
            d.ShowDialog();
        }
    }
}
