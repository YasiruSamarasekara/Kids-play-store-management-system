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
    public partial class SalesHistory : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public SalesHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {try
            {
                db.Open();
                String review = "SELECT * FROM ToySales   WHERE Sale_Date= '" + this.datetimesalehis.Text + "'";
                ldb = new OleDbCommand(review, db);
                OleDbDataReader reader = ldb.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[3].ToString(), reader[4].ToString());
                }
                reader.Close();
                db.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.Close();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String review = "SELECT * FROM TechnianRepairedDetails   WHERE RepairedDate= '" + this.datetimetechbooking.Text + "'";
                ldb = new OleDbCommand(review, db);
                OleDbDataReader reader = ldb.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView2.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString());
                }
                reader.Close();
                db.Close();
            }
            catch (Exception ex)
            {
                db.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
