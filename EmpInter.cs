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
    public partial class EmpInter : Form
    {
        public EmpInter()
        {
            InitializeComponent();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            EmployeeLogin el = new EmployeeLogin();
            el.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TechnicianBooking tc = new TechnicianBooking();
            tc.ShowDialog();
        }

        private void btncata_Click(object sender, EventArgs e)
        {
            Category ct = new Category();
            ct.ShowDialog();
        }

        private void btnslehis_Click(object sender, EventArgs e)
        {
            SalesHistory sl = new SalesHistory();
            sl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToySales ts = new ToySales();
            ts.ShowDialog();
        }
    }
}
