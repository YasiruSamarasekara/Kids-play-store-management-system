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
    public partial class Review : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public Review()
        {
            InitializeComponent();
        }

        private void btncata_Click(object sender, EventArgs e)
        {
            Category cata = new Category();
            cata.Show();
            this.Hide();
        }

        private void btnreviewclear_Click(object sender, EventArgs e)
        {
            dgvaddkidsreview.Rows.Clear();
            dgvgetdatababy.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
        }

        private void btngetselect_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String review = "SELECT * FROM ToyDetails  WHERE ToyName= '" + cmbbabyreview.SelectedItem + "'";
                ldb = new OleDbCommand(review, db);
                OleDbDataReader reader = ldb.ExecuteReader();
                while (reader.Read())
                {
                    dgvgetdatababy.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString());
                }
                reader.Close();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            db.Open();
            String review = "SELECT * FROM ToyDetails  WHERE ToyName= '" + cmchildrengetdata.SelectedItem + "'";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btngetkiddetils_Click(object sender, EventArgs e)
        {
            try
            { 
            db.Open();
            String review = "SELECT * FROM ToyDetails  WHERE ToyName= '" + cmbgetkidsdata.SelectedItem + "'";
            ldb = new OleDbCommand(review, db);
            OleDbDataReader reader = ldb.ExecuteReader();
            while (reader.Read())
            {
                dgvaddkidsreview.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),reader[4].ToString());
            }
            reader.Close();
            db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            { 
            db.Open();
            String review = "SELECT * FROM ToyDetails  WHERE ToyName= '" + cmbhobyreview.SelectedItem + "'";
            ldb = new OleDbCommand(review, db);
            OleDbDataReader reader = ldb.ExecuteReader();
            while (reader.Read())
            {
                dataGridView3.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),reader[4].ToString());
            }
            reader.Close();
            db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
