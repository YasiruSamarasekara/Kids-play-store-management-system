using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Kids_play_store_management_syste_
{
    public partial class Registration : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public Registration()
        {
            InitializeComponent();
        }

        private void btncreatnewacount_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtname.Text.Length > 0)
                   {
                if (txtcpass.Text == txtpass.Text)
                {
                        db.Open();
                        String register = "INSERT INTO StaffRegistration VALUES('" + txtname.Text + "','" + txtpass.Text + "','" + txtnic.Text + "','" + txtadd.Text + "','" + txttp.Text + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else
                    {
                       
                      MessageBox.Show("Password does not match", "Registration not Success", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        db.Close();
                    }
                }
                else

                {
                    MessageBox.Show("Please Enter Valid Details", "Not Registerd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin el = new EmployeeLogin();
            el.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtadd.Clear();
            txtcpass.Clear();
            txtpass.Clear();
            txtnic.Clear();
            txttp.Clear();
        }

        private void hidepass(object sender, EventArgs e)
        {
            if (chpass.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtcpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtcpass.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
