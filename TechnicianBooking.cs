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
    public partial class TechnicianBooking : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
     
        public TechnicianBooking()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {

            db.Open();
            ldb = db.CreateCommand();
            ldb.CommandType = CommandType.Text;
            ldb.CommandText = "select * from TechnicianBooking WHERE RepairDate= '" + this.dateTimePicker1.Text + "'";
            ldb.ExecuteNonQuery();
            DataTable dt = new DataTable();
            odb = new OleDbDataAdapter(ldb);
            odb.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TechnicianBookin1 tc =new TechnicianBookin1();
            tc.ShowDialog();
            this.Hide();
        }

        private void btntoyprts_Click(object sender, EventArgs e)
        {
            Toyprts tp = new Toyprts();
            tp.ShowDialog();
            this.Hide();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
