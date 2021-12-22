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
    public partial class Reservation_Management_Dashboard : MetroFramework.Forms.MetroForm
    {
        public Reservation_Management_Dashboard()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteReservation dl = new DeleteReservation();
            dl.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectReservationCustomer nw = new SelectReservationCustomer();
            nw.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservationreport n = new Reservationreport();
            n.ShowDialog();
        }
    }
}
