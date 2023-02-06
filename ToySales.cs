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
    public partial class ToySales : Form
    {
        OleDbConnection db = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = G:\\Sem 2 recodings & nots\\ICT Project\\Preoject\\Kids play store management syste,\\bin\\Debug\\KidsPlyStore.mdb");
        OleDbCommand ldb = new OleDbCommand();
        OleDbDataAdapter odb = new OleDbDataAdapter();

        public ToySales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                String register = "INSERT INTO ToySales VALUES('" + this.dateTimePicker1.Text + "','" + cmbtoytype.SelectedItem + "','" + txtdes.Text + "','" + txtcusname.Text + "','" + "Rs." + txtprice.Text + "')";
                ldb = new OleDbCommand(register, db);
                ldb.ExecuteNonQuery();
                MessageBox.Show("Detils Added", "Details Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Close();
                //MessageBox.Show("TOY LANKA" +
                //    "Date"+this.dateTimePicker1.Text+
                //    "Coustomer name"+ txtcusname.Text+
                //    "Toy Price"+ txtprice.Text+
                //    "WELLCOME AGAIN");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
