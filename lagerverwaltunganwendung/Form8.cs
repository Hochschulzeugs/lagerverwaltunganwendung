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
    public partial class Form8 : Form
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
        public Form8(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cb_new_artikel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cb_new_artikel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_new_artikel.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (userlevel < 1)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }
            try
            {
                this.DGRefresh();
                basis.SQLopen();
                dr = basis.Artikelliste();
                while (dr.Read())
                {
                    cb_new_artikel.Items.Add(dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
                }
                dr2 = basis.GetStatus();
                while (dr2.Read())
                {
                    cb_status.Items.Add(dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                }
                cb_status.Items.Remove(2 + ", " + "geliefert");
                dr3 = basis.GetLieferanten();
                while (dr3.Read())
                {
                    cb_lieferant.Items.Add(dr3.GetInt32(0).ToString() + ", " + dr3.GetString(1));
                }
                dr4 = basis.GetSachbearbeiter();
                while (dr4.Read())
                {
                    cb_sachbearbeiter.Items.Add(dr4.GetInt32(0).ToString() + ", " + dr4.GetString(1) + " " + dr4.GetString(2));
                }

            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
        }

        public void DGRefresh()
        {
            dataGridView1.Enabled = false;
            ds.Clear();
            ds = basis.ShowDataBestellungen();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ShowDataBestellungen";
            dataGridView1.Enabled = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 60;
            dataGridView1.Columns["Bsb"].Visible = false;
            dataGridView1.Columns["Lnr"].Visible = false;
            dataGridView1.Columns["statusnr"].Visible = false;

        }

        public void DG2Refresh(string bnr)
        {
            if (bnr != null)
            {
                try
                {
                    dataGridView2.Enabled = false;
                    ds2.Clear();
                    ds2 = basis.ShowDataBestellungenArtikel(Convert.ToInt32(bnr));
                    dataGridView2.DataSource = ds2;
                    dataGridView2.DataMember = "ShowDataBestellungenArtikel";
                    dataGridView2.Enabled = true;
                    DataGridViewColumn column2 = dataGridView2.Columns[0];
                    column2.Width = 60;
                    dataGridView2.Columns["einheitnr"].Visible = false;
                }
                catch (Exception a) { MessageBox.Show("Fehler: " + a); }
            }

        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            this.DGRefresh();
        }


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                gb_bestell_details.Visible = true;
                try
                {
                    basis.SQLopen();
                    this.GetDataBest();
                    basis.SQLclose();
                    cb_status.SelectedItem = (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() + ", " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    cb_lieferant.SelectedItem = (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + ", " + dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                    cb_sachbearbeiter.SelectedItem = (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + ", " + dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                    rtb_bem.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler:" + a); }

            }
            else
            {
                gb_bestell_details.Visible = false;
            }
        }

        public void GetDataBest()
        {
            string bnr = null;
            if (dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                bnr = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                this.DG2Refresh(bnr);

            }
        }

        private void b_delete_order_Click(object sender, EventArgs e)
        {
            int bnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string Bname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            DialogResult dialogResult = MessageBox.Show("Möchten Sie die Bestellung (" + Bname + ") wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    basis.SQLopen();
                    string meldung = basis.DeleteBestellung(bnr);
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

        private void b_delete_artikel_Click(object sender, EventArgs e)
        {
            int bnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            int anr = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            string Aname = Convert.ToString(dataGridView2.SelectedRows[0].Cells[1].Value);
            DialogResult dialogResult = MessageBox.Show("Möchten Sie den Artikel (" + Aname + ") wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    basis.SQLopen();
                    string meldung = basis.DeleteBestellungArtikel(bnr, anr);
                    MessageBox.Show(meldung);
                    this.DG2Refresh(bnr.ToString());
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Löschen abgebrochen");
            }
        }

        private void b_new_add_Click(object sender, EventArgs e)
        {
            int anr;
            int bnr;
            int anzahl;
            double preis = 0;
            if (dataGridView2.Enabled == true)
            {
                try
                {
                    bnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                }
                catch (Exception a) { MessageBox.Show("Bitte zuerst eine Bestellung auswählen oder neu erstellen"); return; }
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
                    dr = basis.GetPrice(anr);
                    dr.Read();
                    preis = anzahl * Convert.ToDouble(dr.GetDecimal(0));
                    string meldung = basis.AddBestellungArtikel(bnr, anr, anzahl, Convert.ToDecimal(preis));
                    MessageBox.Show(meldung);
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
                this.DG2Refresh(bnr.ToString());
            }
        }

        private void tb_new_anzahl_TextChanged(object sender, EventArgs e)
        {
            if (tb_new_anzahl.Text != null && tb_new_anzahl.Text != "")
            {
                int anr;
                try
                {
                    string selectedartikel = cb_new_artikel.SelectedItem.ToString();
                    anr = Convert.ToInt32(selectedartikel.Split(',')[0].Trim());
                }
                catch (Exception a)
                {
                    MessageBox.Show("Bitte einen Artikel wählen");
                    return;
                }

                int anzahl = 0;
                double preis = 0;
                try
                {
                    anzahl = Convert.ToInt32(tb_new_anzahl.Text);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Bitte eine numerische Anzahl eingeben");
                    tb_new_kosten.Text = "0";
                    return;
                }
                try
                {
                    basis.SQLopen();
                    dr = basis.GetPrice(anr);
                    dr.Read();
                    preis = anzahl * Convert.ToDouble(dr.GetDecimal(0));
                    tb_new_kosten.Text = Convert.ToString(preis);

                }
                catch (Exception a)
                {
                    MessageBox.Show("Datenbankfehler: " + a);
                }
                basis.SQLclose();
            }
            else
            {
                tb_new_kosten.Text = "0";
            }

        }

        private void cb_new_artikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_new_artikel.SelectedItem != null)
            {
                try
                {
                    basis.SQLopen();
                    int bnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    int anr = Convert.ToInt32(cb_new_artikel.SelectedItem.ToString().Split(',')[0].Trim());
                    int count = basis.CheckArtikel(anr, bnr);
                    if (count < 1)
                    {
                        dr = basis.Artikeleinheitfromanr(anr);
                        dr.Read();
                        label_new_einheit.Text = dr.GetString(0);
                        tb_new_anzahl.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ausgewählter Artikel (" + cb_new_artikel.SelectedItem.ToString() + ") befindet sich schon in der Bestellung!");
                        cb_new_artikel.SelectedItem = null;
                    }
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
            }
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Enabled == true && dataGridView2.Enabled == true && dataGridView2.SelectedRows.Count > 0 && dataGridView2.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {
                    gb_edit_artikel.Visible = true;
                    label_edit_einheit.Text = Convert.ToString(dataGridView2.SelectedRows[0].Cells[3].Value);
                    tb_edit_anzahl.Text = Convert.ToString(dataGridView2.SelectedRows[0].Cells[2].Value);
                    tb_edit_kosten.Text = Convert.ToString(dataGridView2.SelectedRows[0].Cells[4].Value);
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler:" + a); }
            }
            else
            {
                gb_edit_artikel.Visible = false;
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            int anr;
            int bnr;
            int anzahl;
            double preis = 0;
            if (dataGridView2.Enabled == true)
            {
                try
                {
                    bnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                }
                catch (Exception a) { MessageBox.Show("Bitte zuerst eine Bestellung auswählen oder neu erstellen"); return; }
                try
                {
                    anr = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                }
                catch (Exception a) { MessageBox.Show("Bitte einen Artikel wählen"); return; }
                try
                {
                    anzahl = Convert.ToInt32(tb_edit_anzahl.Text);
                }
                catch (Exception a) { MessageBox.Show("Bitte eine numerische Anzahl eingeben"); return; }

                try
                {
                    basis.SQLopen();
                    dr = basis.GetPrice(anr);
                    dr.Read();
                    preis = anzahl * Convert.ToDouble(dr.GetDecimal(0));
                    string meldung = basis.SaveBestellungArtikel(bnr, anr, anzahl, Convert.ToDecimal(preis));
                    MessageBox.Show(meldung);
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();
                this.DG2Refresh(bnr.ToString());
            }
        }

        private void tb_edit_anzahl_TextChanged(object sender, EventArgs e)
        {
            if (tb_edit_anzahl.Text != null && tb_edit_anzahl.Text != "" && dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0)
            {
                int anr;
                try
                {
                    anr = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Bitte einen Artikel wählen");
                    return;
                }

                int anzahl = 0;
                double preis = 0;
                try
                {
                    anzahl = Convert.ToInt32(tb_edit_anzahl.Text);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Bitte eine numerische Anzahl eingeben");
                    tb_edit_kosten.Text = "0";
                    return;
                }
                try
                {
                    basis.SQLopen();
                    dr = basis.GetPrice(anr);
                    dr.Read();
                    preis = anzahl * Convert.ToDouble(dr.GetDecimal(0));
                    tb_edit_kosten.Text = Convert.ToString(preis);

                }
                catch (Exception a)
                {
                    MessageBox.Show("Datenbankfehler: " + a);
                }
                basis.SQLclose();
            }
            else
            {
                tb_edit_kosten.Text = "0";
            }
        }


        private void b_save_orderstatus_Click(object sender, EventArgs e)
        {
            int bnr;
            int sb;
            int status;
            int lnr;
            string bbem;
            try
            {
                bnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                sb = Convert.ToInt32(cb_sachbearbeiter.SelectedItem.ToString().Split(',')[0].Trim());
                status = Convert.ToInt32(cb_status.SelectedItem.ToString().Split(',')[0].Trim());
                lnr = Convert.ToInt32(cb_lieferant.SelectedItem.ToString().Split(',')[0].Trim());
                bbem = rtb_bem.Text;
            }
            catch (Exception a) { MessageBox.Show("Bitte Bestellung, Sachbearbeiter, Lieferant und Status auswählen"); return; }
            try
            {
                basis.SQLopen();
                string meldung = basis.SaveBestellung(bnr, sb, status, lnr, bbem);
                MessageBox.Show(meldung);
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
            this.DGRefresh();
        }

        private void b_add_order_Click(object sender, EventArgs e)
        {
            int bnr = 0;
            int sb = Convert.ToInt32(userdata[3]);
            string bdat = DateTime.Now.ToShortDateString();
            try
            {
                basis.SQLopen();
                dr = basis.GetCountBestellungen();
                dr.Read();
                bnr = dr.GetInt32(0);
                string meldung = basis.AddBestellung(bnr, bdat, sb);
                MessageBox.Show(meldung);
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            basis.SQLclose();
            this.DGRefresh();
        }
    }
}