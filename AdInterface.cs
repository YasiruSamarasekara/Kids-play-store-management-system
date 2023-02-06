using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kids_play_store_management_syste_
{
    public partial class AdInterface : Form
    {
        public AdInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TechnicianBooking tc = new TechnicianBooking();
                tc.ShowDialog();
        }

        private void btncata_Click(object sender, EventArgs e)
        {
            Category CS = new Category();
            CS.ShowDialog();
        }

        private void btnpyment_Click(object sender, EventArgs e)
        {
            MonthlyBill mb = new MonthlyBill();
            mb.ShowDialog();
        }

        private void btnslehis_Click(object sender, EventArgs e)
        {
            SalesHistory sh = new SalesHistory();
            sh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails();
            ed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToySales ts = new ToySales();
            ts.ShowDialog();
        }
    }
}
