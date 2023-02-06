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
    public partial class ChartView : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();
        public ChartView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String login = "SELECT * FROM ToyDetails";
                odb = new OleDbDataAdapter(login, db);
                DataSet ds = new DataSet();
                odb.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                chart1.DataSource = dv;
                chart1.Series[0].XValueMember = "ToyCategory";
                chart1.Series[0].YValueMembers = "Quintity";
                chart1.DataBind();
                db.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String login = "SELECT * FROM TechnianRepairedDetails";
                odb = new OleDbDataAdapter(login, db);
                DataSet ds = new DataSet();
                odb.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                chart2.DataSource = dv;
                chart2.Series[0].XValueMember = "TechnianNumber";
                chart2.Series[0].YValueMembers = "ChargeForRepair";
                chart2.DataBind();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
