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
    public partial class Category : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y;
                if (int.TryParse(txtprice.Text, out x) && int.TryParse(txtquintity.Text, out y))
                {
                    int t = x * y;
                    if (rbtbaby.Checked == true)
                    { 
                       db.Open();
                        String register = "INSERT INTO ToyDetails VALUES('" + this.dateTimePicker1.Text + "','" + rbtbaby.Text + "','" + cmbbaby.SelectedItem + "','" + txtquintity.Text + "','" + "Rs." + x.ToString()+ "','" + cmbreview.SelectedItem + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Details Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else if (rbtchildren.Checked == true)
                    {
                        db.Open();
                        String register = "INSERT INTO ToyDetails VALUES('" + this.dateTimePicker1.Text + "','" + rbtchildren.Text + "','" + cmbchilder.SelectedItem + "','" + txtquintity.Text + "','" + "Rs." + x.ToString() + "','" + cmbreview.SelectedItem + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Details Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else if (rbtkids.Checked == true)
                    {
                        db.Open();
                        String register = "INSERT INTO ToyDetails VALUES('" + this.dateTimePicker1.Text + "','" + rbtkids.Text + "','" + cmbkids.SelectedItem + "','" + txtquintity.Text + "','" + "Rs." + x.ToString() + "','" + cmbreview.SelectedItem + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Details Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else if (rbthoby.Checked == true)
                    {
                        db.Open();
                        String register = "INSERT INTO ToyDetails VALUES('" + this.dateTimePicker1.Text + "','" + rbthoby.Text + "','" + cmbhoby.SelectedItem + "','" + txtquintity.Text + "','" + "Rs." + x.ToString() + "','" + cmbreview.SelectedItem + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Details Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Select Category");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Quintity and price");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtbaby_CheckedChanged(object sender, EventArgs e)
        {
            cmbchilder.Enabled=false;
            cmbkids.Enabled=false;
            cmbhoby.Enabled=false;
            cmbbaby.Enabled=true;

        }

        private void rbtchildren_CheckedChanged(object sender, EventArgs e)
        {
            cmbbaby.Enabled=false;
            cmbkids.Enabled=false;
            cmbhoby.Enabled=false;
            cmbchilder.Enabled=true;
        }

        private void rbtkids_CheckedChanged(object sender, EventArgs e)
        {
            cmbbaby.Enabled=false;
            cmbchilder.Enabled=false;
            cmbhoby.Enabled=false;
            cmbkids.Enabled=true;
        }

        private void rbthoby_CheckedChanged(object sender, EventArgs e)
        {
            cmbbaby.Enabled=false;
            cmbchilder.Enabled=false;
            cmbkids.Enabled=false;
            cmbhoby.Enabled=true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbbaby.Text = "";
            cmbchilder.Text = "";
            cmbkids.Text = "";
            cmbhoby.Text = "";
            cmbreview.Text = "";
        }

        private void btnreview_Click(object sender, EventArgs e)
        {
            Review rv = new Review();
            rv.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
