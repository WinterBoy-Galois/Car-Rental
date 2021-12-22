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
    public partial class CustomerManagement : MetroFramework.Forms.MetroForm
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void DashBoardLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.ShowDialog ();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer nw = new NewCustomer();
            nw.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCustomer up = new UpdateCustomer();
            up.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCustomer dl = new DeleteCustomer();
            dl.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerReport v = new CustomerReport();
            v.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerIndate n = new CustomerIndate();
            n.ShowDialog();
        }
    }
}
