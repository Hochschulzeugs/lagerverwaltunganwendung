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
    public partial class Form10 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        OleDbDataReader dr = null;
        OleDbDataReader dr2 = null;
        OleDbDataReader dr3 = null;
        OleDbDataReader dr4 = null;
        DataSet filterset = new DataSet();
        int userlevel;
        string[] userdata;
        public Form10(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (userlevel < 1)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }
            try
            {
                this.DGRefresh();
                basis.SQLopen();
                dr = basis.GetSachbearbeiter();
                while (dr.Read())
                {
                    cb_sachbearbeiter.Items.Add(dr.GetInt32(0).ToString() + ", " + dr.GetString(1) + " " + dr.GetString(2));
                    cb_empf.Items.Add(dr.GetInt32(0).ToString() + ", " + dr.GetString(1) + " " + dr.GetString(2));
                }
                dr2 = basis.Artikelliste();
                while (dr2.Read())
                {
                    cb_new_artikel.Items.Add(dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                }
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            basis.SQLclose();
        }


        public void DGRefresh()
        {
            dataGridView1.Enabled = false;
            ds.Clear();
            ds = basis.ShowDataMatschein();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ShowDataMatschein";
            dataGridView1.Enabled = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 60;
            dataGridView1.Columns["sb"].Visible = false;
            dataGridView1.Columns["empf"].Visible = false;

        }

        public void DG2Refresh(string matschnr)
        {
            if (matschnr != null)
            {
                try
                {
                    dataGridView2.Enabled = false;
                    ds2.Clear();
                    ds2 = basis.ShowDataMatschArtikel(Convert.ToInt32(matschnr));
                    dataGridView2.DataSource = ds2;
                    dataGridView2.DataMember = "ShowDataMatschArtikel";
                    dataGridView2.Enabled = true;
                    DataGridViewColumn column2 = dataGridView2.Columns[0];
                    column2.Width = 60;
                    dataGridView2.Columns["einheitnr"].Visible = false;
                }
                catch (Exception a) { MessageBox.Show("Fehler: " + a); }
            }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string matschnr = null;
            if (dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                gb_mat_details.Visible = true;
                try
                {
                    matschnr = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                    this.DG2Refresh(matschnr);
                    basis.SQLopen();
                    dr = basis.GetSachbearbeiterFromId(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value));
                    dr.Read();
                    cb_sachbearbeiter.SelectedItem = (dr.GetInt32(0).ToString() + ", " + dr.GetString(1) + " " + dr.GetString(2));
                    cb_empf.SelectedItem = (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + ", " + dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    rtb_bem.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler:" + a); }
                basis.SQLclose();

            }
            else
            {
                gb_mat_details.Visible = false;
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            int anr;
            int matschnr;
            int anzahl = 0;
            if (dataGridView2.Enabled == true)
            {
                try
                {
                    matschnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                }
                catch (Exception a) { MessageBox.Show("Bitte zuerst einen Materialschein auswählen oder neu erstellen"); return; }
                try
                {
                    anr = Convert.ToInt32(cb_new_artikel.SelectedItem.ToString().Split(',')[0].Trim());
                }
                catch (Exception a) { MessageBox.Show("Bitte einen Artikel wählen"); return; }
                try
                {
                    anzahl = Convert.ToInt32(tb_new_anzahl.Text);
                }
                catch (Exception a) { MessageBox.Show("Bitte eine numerische Anzahl eingeben"); return; }

                try
                {
                    basis.SQLopen();
                    int countartikel = basis.CheckArtikelbestand(anr);
                    if (countartikel > anzahl)
                    { 
                    string meldung = basis.AddMatschArtikel(matschnr, anr, anzahl);
                    string meldung2 = basis.ChangeArtikelbestand(anr, -anzahl);
                    MessageBox.Show(meldung);
                    }
                    else
                    {
                        MessageBox.Show("Nicht genug Artikel auf Lager!");
                    }
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
                this.DG2Refresh(matschnr.ToString());
            }
        }

        private void b_delete_artikel_Click(object sender, EventArgs e)
        {
            int matschnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            int anr = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            int anzahl = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[2].Value);
            string Aname = Convert.ToString(dataGridView2.SelectedRows[0].Cells[1].Value);
            DialogResult dialogResult = MessageBox.Show("Möchten Sie den Artikel (" + Aname + ") wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    basis.SQLopen();
                    string meldung = basis.DeleteMatschArtikel(matschnr, anr);
                    string meldung2 = basis.ChangeArtikelbestand(anr, anzahl);
                    MessageBox.Show(meldung);
                    this.DG2Refresh(matschnr.ToString());
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Löschen abgebrochen");
            }
        }

        private void b_save_orderstatus_Click(object sender, EventArgs e)
        {
            int matschnr;
            int sb;
            int empf;
            string bem;
            try
            {
                matschnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                sb = Convert.ToInt32(cb_sachbearbeiter.SelectedItem.ToString().Split(',')[0].Trim());
                empf = Convert.ToInt32(cb_empf.SelectedItem.ToString().Split(',')[0].Trim());
                bem = rtb_bem.Text;
            }
            catch (Exception a) { MessageBox.Show("Bitte Materialschein, Sachbearbeiter und Empfänger auswählen"); return; }
            try
            {
                basis.SQLopen();
                string meldung = basis.SaveMatschein(matschnr, sb, empf, bem);
                MessageBox.Show(meldung);
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
            this.DGRefresh();
        }

        private void cb_new_artikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_new_artikel.SelectedItem != null)
            {
                try
                {
                    basis.SQLopen();
                    int matschnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    int anr = Convert.ToInt32(cb_new_artikel.SelectedItem.ToString().Split(',')[0].Trim());
                    int count = basis.CheckArtikelMatsch(anr, matschnr);
                    if (count < 1)
                    {
                        dr = basis.Artikeleinheitfromanr(anr);
                        dr.Read();
                        label_new_einheit.Text = dr.GetString(0);
                        tb_new_anzahl.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ausgewählter Artikel (" + cb_new_artikel.SelectedItem.ToString() + ") befindet sich schon auf dem Materialschein!");
                        cb_new_artikel.SelectedItem = null;
                    }
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
            }
        }

        private void b_add_order_Click(object sender, EventArgs e)
        {
            int matschnr = 0;
            int sb = Convert.ToInt32(userdata[3]);
            string dat = DateTime.Now.ToShortDateString();
            try
            {
                basis.SQLopen();
                dr = basis.GetCountMatschein();
                dr.Read();
                matschnr = dr.GetInt32(0);
                string meldung = basis.AddMatschein(matschnr, dat, sb);
                MessageBox.Show(meldung);
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            basis.SQLclose();
            this.DGRefresh();
        }
    }
}
