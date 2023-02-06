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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbadmin.Checked == true)
            {
                AdminLogin al = new AdminLogin();
                al.Show();
                this.Hide();
            }
            else if (rdbemp.Checked == true)
            {
                EmployeeLogin el = new EmployeeLogin();
                el.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select Your Job Role");
            }
        }
    }
}
