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
    public partial class CustomerIndate : MetroFramework.Forms.MetroForm
    {
        public CustomerIndate()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagement b = new CustomerManagement();
            b.ShowDialog();
        }

        private void CustomerIndate_Load(object sender, EventArgs e)
        {

        }
    }
}
