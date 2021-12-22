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
    public partial class rentalReport : MetroFramework.Forms.MetroForm
    {
        public rentalReport()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental_Management_DashBoard b = new Rental_Management_DashBoard();
            b.ShowDialog();
        }
    }
}
