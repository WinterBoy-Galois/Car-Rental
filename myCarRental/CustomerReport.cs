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
    public partial class CustomerReport :MetroFramework.Forms.MetroForm
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void DashBoardLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManagement n = new CustomerManagement();
            n.ShowDialog();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
