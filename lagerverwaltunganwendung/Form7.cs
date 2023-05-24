using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lagerverwaltungbasis;
using System.Data.OleDb;

namespace lagerverwaltunganwendung
{
    public partial class Form7 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = new DataSet();
        OleDbDataReader dr = null;
        DataSet filterset = new DataSet();
        int userlevel;
        int dgrowcounter = -1;
        string[] userdata;
        public Form7(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (userlevel < 1)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }
            try
            {
                this.DGRefresh();

            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
        }

        public void DGRefresh()
        {
            dataGridView1.Enabled = false;
            ds.Clear();
            ds = basis.ShowDataLieferanten();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ShowDataLieferanten";
            dataGridView1.Enabled = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 30;
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                string meldung = basis.SaveDataDG("ShowDataLieferanten");
                MessageBox.Show(meldung);
                this.DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int selectedlnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string selectedlname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            DialogResult dialogResult = MessageBox.Show("Möchten Sie den Lieferanten (" + selectedlname + ") wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    basis.SQLopen();
                    string meldung = basis.DeleteLieferant(selectedlnr);
                    MessageBox.Show(meldung);
                    this.DGRefresh();
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Löschen abgebrochen");
            }
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            this.DGRefresh();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dgrowcounter++;
            try
            {
                basis.SQLopen();
                int rowsdb = basis.CountRowsLieferanten();
                int mnrneu = rowsdb + dgrowcounter;
                e.Row.Cells["Lnr"].Value = mnrneu;
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
        }
    
    }
}
