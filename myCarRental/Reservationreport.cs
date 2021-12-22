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
    public partial class Reservationreport : MetroFramework.Forms.MetroForm
    {
        public Reservationreport()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation_Management_Dashboard b = new Reservation_Management_Dashboard();
            b.ShowDialog();
        }
    }
}
