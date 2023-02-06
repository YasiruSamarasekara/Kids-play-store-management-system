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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnadminprevious_Click(object sender, EventArgs e)
        {
            HomePage frm = new HomePage();
            frm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string name = "admin";
            string password = "1234";
            if (txtname.Text.Equals(name) && txtpass.Text.Equals(password))
            {
                AdInterface ad = new AdInterface();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("noela");
            }
        }
    }
}
