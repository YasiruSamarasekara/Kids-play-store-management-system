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
    public partial class MonthlyBill : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public MonthlyBill()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String review = "SELECT * FROM ToyDetails  WHERE TOY_Get_Date= '" + this.datetimetoystoke.Text + "'";
                ldb = new OleDbCommand(review, db);
                OleDbDataReader reader = ldb.ExecuteReader();
                if (reader.Read() == true)
                {
                    while (reader.Read())
                    {
                        dgvtoystoke.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    }
                    reader.Close();
                    db.Close();
                }
                else
                {
                    MessageBox.Show("This day has not Cost");
                    db.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //meka hdanna
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String review = "SELECT * FROM TechnianRepairedDetails   WHERE RepairedDate= '" + this.datetimetechnician.Text + "'";
                ldb = new OleDbCommand(review, db);
                OleDbDataReader reader = ldb.ExecuteReader();
                if (reader.Read() == true)
                {
                    while (reader.Read())
                    {
                        dataGridView3.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString());
                    }
                    reader.Close();
                    db.Close();
                }else
                {
                    MessageBox.Show("This day has not Cost");
                    db.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String review = "SELECT * FROM ToySales WHERE Sale_Date= '" + this.dtetimesales.Text + "'";
                ldb = new OleDbCommand(review, db);
                OleDbDataReader reader = ldb.ExecuteReader();
                if (reader.Read() == true)
                {
                   
                        dgvtoysale.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    
                    reader.Close();
                    db.Close();
                }
                else
                {
                    MessageBox.Show("This day has not Cost");
                    db.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvprtstoke.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgvtoystoke.Rows.Clear();
            lbltsum.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvtoysale.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
