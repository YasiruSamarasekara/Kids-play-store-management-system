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
    public partial class TechnicianBookin1 : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public TechnicianBookin1()
        {
            InitializeComponent();
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtechnician.SelectedIndex > -1)
                {
                    if (cmbtechnician.SelectedItem.ToString().Equals("Number One"))
                    {
                        db.Open();
                        String register = "INSERT INTO TechnicianBooking VALUES('" +this.dateTimePicker1.Text+"','"+ cmbtime.SelectedItem + "','" + cmbtechnician.SelectedItem + "','" + " " + "','" + " " + "','" + txttype.Text + "','" + txtCusname.Text + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Technician Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                        Repairdetails();
                        datagridRepairdetails();
                    }
                    else if (cmbtechnician.SelectedItem.ToString().Equals("Number Two"))
                    {
                        db.Open();
                        String register = "INSERT INTO TechnicianBooking VALUES('" + this.dateTimePicker1.Text + "','" + cmbtime.SelectedItem + "','" + " " + "','" + cmbtechnician.SelectedItem + "','" + " " + "','" + txttype.Text + "','" + txtCusname.Text + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Technician Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                        Repairdetails();
                        datagridRepairdetails();

                    }
                    else if (cmbtechnician.SelectedItem.ToString().Equals("Number Three"))
                    {
                        db.Open();
                        String register = "INSERT INTO TechnicianBooking VALUES('" + this.dateTimePicker1.Text + "','" + cmbtime.SelectedItem + "','" + " " + "','" + " " + "','" + cmbtechnician.SelectedItem + "','" + txttype.Text + "','" + txtCusname.Text + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Detils Added", "Technician Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                        Repairdetails();
                        datagridRepairdetails();
                    }
                }
                else
                {
                    
                    MessageBox.Show("Entter Technician Number");

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }finally
            {
                db.Close();
            }
            
        }
        private void Repairdetails()
        {
            db.Open();
            String register = "INSERT INTO TechnianRepairedDetails VALUES('" + this.dateTimePicker1.Text + "','" + cmbtechnician.SelectedItem + "','" + txttype.Text + "','" + txtCusname.Text +"','"+txtcharge.Text+"')";
            ldb = new OleDbCommand(register, db);
            ldb.ExecuteNonQuery();
            MessageBox.Show("Detils Added", "Toy Details Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.Close();
        }
        private void datagridRepairdetails()
        {
            db.Open();
            ldb = db.CreateCommand();
            ldb.CommandType = CommandType.Text;
            ldb.CommandText = "select * from TechnicianBooking";
            ldb.ExecuteNonQuery();
            DataTable dt = new DataTable();
            odb = new OleDbDataAdapter(ldb);
            odb.Fill(dt);
            dgvgooking.DataSource = dt;
            db.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                db.Open();
                ldb = db.CreateCommand();
                ldb.CommandType = CommandType.Text;
                ldb.CommandText = "delete from TechnicianBooking where CoustomerName='" + tztzcname.Text + "'";
                ldb.ExecuteReader();
                db.Close();
                MessageBox.Show("Record Deleted Successfully");
                datagridRepairdetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcharge.Clear();
            txtCusname.Clear();
            txttype.Clear();
            tztzcname.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             datagridRepairdetails();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            TechnicianBooking tc = new TechnicianBooking();
            tc.Show();
            this.Hide();
        }
    }
}
    
