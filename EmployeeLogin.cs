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
    public partial class EmployeeLogin : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration re = new Registration();
            re.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage frm = new HomePage();
            frm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            db.Open();
            String login = "SELECT * FROM StaffRegistration WHERE E_Name= '" + txtname.Text + "'and E_Password='" + cc.Text + "'";
            ldb = new OleDbCommand(login, db);
            OleDbDataReader dr = ldb.ExecuteReader();
            if (dr.Read() == true)
            {
                EmpInter em=new EmpInter();
                em.Show();
                db.Close();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid user name");
                txtname.Clear();
                cc.Clear();
                txtname.Focus();
                db.Close();
            }
        }

        private void chpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chpass.Checked)
            {
                cc.PasswordChar = '\0';
                
            }
            else
            {
                cc.PasswordChar = '*';
               
            }
        }
    }
}
