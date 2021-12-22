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
    public partial class VehicleReport : MetroFramework.Forms.MetroForm
    {
        public VehicleReport()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle_Management_Dashboard v = new Vehicle_Management_Dashboard();
            v.ShowDialog();
        }
    }
}
