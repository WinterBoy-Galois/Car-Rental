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
    public partial class Vehicle_Management_Dashboard : MetroFramework.Forms.MetroForm
    {
        public Vehicle_Management_Dashboard()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewVehicle nw = new NewVehicle();
            nw.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Vehicle w = new Update_Vehicle();
            w.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteVehicleDetails n = new DeleteVehicleDetails();
            n.ShowDialog();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleReport b = new VehicleReport();
            b.ShowDialog();
        }
    }
}
