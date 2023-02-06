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
    public partial class Toyprts : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public Toyprts()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0; int y = 0;
                if (rbtall.Checked == true)
                { 
                    if (int.TryParse(txtprice.Text, out x) && int.TryParse(txtquintity.Text, out y))
                    {
                        int price = x * y;
                        lablprice.Text = "Rs." + price.ToString();
                        db.Open();
                        String register = "INSERT INTO ToyPartDetails VALUES('"+this.dateTimePicker1.Text+"','" +rbtall.Text+"','"+ cmbprttype.SelectedItem + "','" + " " + "','" + " " + "','" + txtquintity.Text + "','" + "Rs." +price.ToString() + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Stoke Updated", "Update Success Fully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Enter Quintity and Price");
                    }
                }
                else if (rbtrc.Checked == true)
                {
                    if (int.TryParse(txtprice.Text, out x) && int.TryParse(txtquintity.Text, out y))
                    {
                        int price = x * y;
                        lablprice.Text = "Rs." + price.ToString();
                        db.Open();
                        String register = "INSERT INTO ToyPartDetails VALUES('" + this.dateTimePicker1.Text + "','" + rbtrc.Text + "','"+ " " + "','"+ cmbprttype.SelectedItem + "','"+ " " + "','" + txtquintity.Text + "','" + "Rs." + price.ToString() + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Stoke Updated", "Update Success Fully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Enter Quintity and Price");
                    }
                }
                else if (rbthobby.Checked == true)
                {
                    if (int.TryParse(txtprice.Text, out x) && int.TryParse(txtquintity.Text, out y))
                    {
                        int price = x * y;
                        lablprice.Text = "Rs." + price.ToString();
                        db.Open();
                        String register = "INSERT INTO ToyPartDetails VALUES('" + this.dateTimePicker1.Text + "','" + rbthobby.Text + "','"+" " + "','" + " " + "','"+cmbprttype.SelectedItem + "','" + txtquintity.Text + "','" + "Rs." + price.ToString() + "')";
                        ldb = new OleDbCommand(register, db);
                        ldb.ExecuteNonQuery();
                        MessageBox.Show("Stoke Updated", "Update Success Fully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.Close();
                    }
                    else
                    {
                        MessageBox.Show("Enter Quintity and Price");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }
        private void clickall(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbprttype.Items.Clear();
            cmbprttype.Items.Add("DC Moter");
            cmbprttype.Items.Add("4.5v Charger");
            cmbprttype.Items.Add("12v Battery");
            cmbprttype.Items.Add("MOC Gears");
            cmbprttype.Items.Add("3.7V Battery USB Charger ");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmbprttype.Items.Clear();
            cmbprttype.Items.Add("Metal Adjustable Shock Absorbers ");
            cmbprttype.Items.Add("Shock Mount for WPL C14 C24 MN D90 D91 D99S RC Car Modification Parts");
            cmbprttype.Items.Add("GEMFAN Apc Propeller knife horse Paddle 5-14 Inch Props For RC Airplane FPV Racing Drone");
            cmbprttype.Items.Add("Ewellsold F183 H8C 2.4G 4ch 6 Axis RC Quadcopter");
            cmbprttype.Items.Add("RC drone parts Main blades/propeller");
            cmbprttype.Items.Add("7.4V 5200mah 2S Lipo battery ");
            cmbprttype.Items.Add("Ewellsold F183 H8C 2.4G 4ch 6 Axis RC Quadcopter");
            cmbprttype.Items.Add("Wltoys 104001 Upgrade Parts Metal Servo 4WD Drive Off-Road RC Car");
            cmbprttype.Items.Add("RC Drone Arms Propellers");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cmbprttype.Items.Clear();
            cmbprttype.Items.Add("WLtoys 12428 parts Motor");
            cmbprttype.Items.Add("Shock Mount");
            cmbprttype.Items.Add("Metal Servo 4WD Drive Off-Road RC Car");
            cmbprttype.Items.Add("7.4V 5200mah 2S Lipo battery");
            cmbprttype.Items.Add("Drone Arms");
            cmbprttype.Items.Add(" 6 Axis RC Quadcopter");
            cmbprttype.Items.Add("Hobby drone parts Main blades/propeller");
            cmbprttype.Items.Add("knife horse Paddle 5-14 Inch Props For Hobby");
            cmbprttype.Items.Add("DC Steering Wheel for Sanwa Aluminum Alloy Factory Direct Sales Hobby RC");
            cmbprttype.Items.Add("RC Car Parts 1/8 8382-202T DHK Hobby ");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbcheck.SelectedIndex > -1)
            {
                if (cmbcheck.SelectedItem.ToString().Equals("ALL ACCESSORIES"))
                {
                    db.Open();
                    String review = "SELECT * FROM ToyPartDetails   WHERE ToyCategory= '" + cmbcheck.SelectedItem + "'";
                    ldb = new OleDbCommand(review, db);
                    OleDbDataReader reader = ldb.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvcheck.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[5].ToString());
                    }
                    reader.Close();
                    db.Close();
                }
                else if (cmbcheck.SelectedItem.ToString().Equals("RC TOYS"))
                {
                    db.Open();
                    String review = "SELECT * FROM ToyPartDetails   WHERE ToyCategory= '" + cmbcheck.SelectedItem + "'";
                    ldb = new OleDbCommand(review, db);
                    OleDbDataReader reader = ldb.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvcheck.Rows.Add(reader[1].ToString(), reader[3].ToString(), reader[5].ToString());
                    }
                    reader.Close();
                    db.Close();
                }
                else if (cmbcheck.SelectedItem.ToString().Equals("HOBBY TOYS"))
                {
                    db.Open();
                    String review = "SELECT * FROM ToyPartDetails   WHERE ToyCategory= '" + cmbcheck.SelectedItem + "'";
                    ldb = new OleDbCommand(review, db);
                    OleDbDataReader reader = ldb.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvcheck.Rows.Add(reader[1].ToString(), reader[4].ToString(), reader[5].ToString());
                    }
                    reader.Close();
                    db.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Toy Type");
            }
        }

        private void btnprivious_Click(object sender, EventArgs e)
        {
            TechnicianBooking tb = new TechnicianBooking();
            tb.Show();
            this.Hide();
        }
    }
}
