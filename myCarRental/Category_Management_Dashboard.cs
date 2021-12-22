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
    public partial class Category_Management_Dashboard : MetroFramework.Forms.MetroForm
    {
        public Category_Management_Dashboard()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.ShowDialog();
        }

        private void CustomerTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategory add = new AddCategory();
            add.ShowDialog();
        }

        private void ReservationTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCAtegory dl = new DeleteCAtegory();
            dl.ShowDialog();
        }

        private void RentalTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCategory c = new UpdateCategory();
            c.ShowDialog();
        }

        private void CategoryTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBrand add = new AddBrand();
            add.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBrand v = new DeleteBrand();
            v.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateBrand p = new UpdateBrand();
            p.ShowDialog();
        }

        private void VehicleTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            modelmanagement n = new modelmanagement();
            n.ShowDialog();
        }
    }
}
