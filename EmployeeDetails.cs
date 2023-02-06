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
    public partial class EmployeeDetails : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "select * from StaffRegistration WHERE E_NIC='" + txtsearch.Text + "'";
                ldb.ExecuteNonQuery();
                DataTable dt = new DataTable();
                odb = new OleDbDataAdapter(ldb);
                odb.Fill(dt);
            dgvempdetails.DataSource = dt;
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "delete from StaffRegistration where E_NIC='" + txtsearch.Text + "'";
                ldb.ExecuteReader();
                db.Close();
                MessageBox.Show("Record Deleted Successfully");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagridviewcellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvempdetails.Rows[e.RowIndex];
            txtname.Text = row.Cells[0].Value.ToString();
            txtpass.Text = row.Cells[1].Value.ToString();
            txtcpass.Text= row.Cells[1].Value.ToString();
            txtnic.Text = row.Cells[2].Value.ToString();
            txttp.Text = row.Cells[4].Value.ToString();
            txtadd.Text = row.Cells[3].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "select * from StaffRegistration";
                ldb.ExecuteNonQuery();
                DataTable dt = new DataTable();
                odb = new OleDbDataAdapter(ldb);
                odb.Fill(dt);
                dgvempdetails.DataSource = dt;
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "update StaffRegistration set E_Name = '" + txtname.Text + "'where E_NIC='" + txtnic.Text+ "'";
                ldb.ExecuteNonQuery();
                db.Close();
                
                passwrd();
                nic();
                tp();
                address();
                MessageBox.Show("Record Updates sucessfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void passwrd()
        {
            try
            {
                if (txtpass.Text == txtcpass.Text)
                {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "update StaffRegistration set E_Password = '" + txtpass.Text + "'where E_NIC='" + txtnic.Text + "'";
                ldb.ExecuteNonQuery();
                db.Close();
            }
            else
                {
                    MessageBox.Show("Password Does Not match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }
        private void nic()
        {
            try
            {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "update StaffRegistration set E_NIC = '" + txtnic.Text + "'where E_Name = '" + txtname.Text + "'";
                ldb.ExecuteNonQuery();
                db.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }

        }
        private void tp()
        {
            try
            {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "update StaffRegistration set  TelephoneNumber= '" + txttp.Text + "'where E_NIC='" + txtnic.Text + "'";
                ldb.ExecuteNonQuery();
                db.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }
        private void address()
        {
            try
            {
                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "update StaffRegistration set Adreess = '" + txtadd.Text + "'where E_NIC='" + txtnic.Text + "'";
                ldb.ExecuteNonQuery();
                db.Close();

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
}

        private void chpass_CheckedChanged(object sender, EventArgs e)
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

        private void dgvempdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
