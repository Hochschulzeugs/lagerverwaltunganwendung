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
    public partial class Form9 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        OleDbDataReader dr = null;
        OleDbDataReader dr2 = null;
        int userlevel;
        string[] userdata;

        public Form9(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if (userlevel < 1)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }

            try
            {
                this.DGRefesh();
                this.DG3Refesh();
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
        }

        private void DGRefesh()
        {
            dg_lieferscheine.Enabled = false;
            ds.Clear();
            ds = basis.ShowDataLieferungen();
            dg_lieferscheine.DataSource = ds;
            dg_lieferscheine.DataMember = "ShowDataLieferungen";
            dg_lieferscheine.Enabled = true;
            DataGridViewColumn column = dg_lieferscheine.Columns[0];
            column.Width = 60;
            dg_lieferscheine.Columns["Lnr"].Visible = false;
            dg_lieferscheine.Columns["Bnr"].Visible = false;
            dg_lieferscheine.Columns["LSsb"].Visible = false;
            dg_lieferscheine.Columns["Lstatus"].Visible = false;
        }

        private void D2GRefesh(int lsnr)
        {
            dg_lsartikel.Enabled = false;
            ds2.Clear();
            ds2 = basis.ShowDataLieferscheinArtikel(lsnr);
            dg_lsartikel.DataSource = ds2;
            dg_lsartikel.DataMember = "ShowDataLieferscheinArtikel";
            dg_lsartikel.Enabled = true;
            DataGridViewColumn column2 = dg_lsartikel.Columns[0];
            column2.Width = 60;
        }

        private void DG3Refesh()
        {
            dg_bestellungen.Enabled = false;
            ds3.Clear();
            ds3 = basis.ShowDataBestellungenLS();
            dg_bestellungen.DataSource = ds3;
            dg_bestellungen.DataMember = "ShowDataBestellungenLS";
            dg_bestellungen.Enabled = true;
            DataGridViewColumn column3 = dg_bestellungen.Columns[0];
            column3.Width = 60;
            dg_bestellungen.Columns["Bsb"].Visible = false;
            dg_bestellungen.Columns["Lnr"].Visible = false;
            dg_bestellungen.Columns["statusnr"].Visible = false;
        }

        private void DG4Refesh(string bnr)
        {
            if (bnr != null)
            {
                try
                {
                    dg_checkartikel.Enabled = false;
                    ds4.Clear();
                    ds4 = basis.ShowDataBestellungenArtikelLS(Convert.ToInt32(bnr));
                    dg_checkartikel.DataSource = ds4;
                    dg_checkartikel.DataMember = "ShowDataBestellungenArtikelLS";
                    dg_checkartikel.Enabled = true;
                    DataGridViewColumn column4 = dg_checkartikel.Columns[0];
                    column4.Width = 60;
                    dg_checkartikel.Columns["einheitnr"].Visible = false;
                }
                catch (Exception a) { MessageBox.Show("Fehler: " + a); }
            }
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_lieferscheine_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_lieferscheine.Enabled == true && dg_lieferscheine.SelectedRows.Count > 0 && dg_lieferscheine.SelectedRows[0].Cells[0].Value != null)
            {
                gb_lsdetails.Visible = true;
                try
                {
                    int lsnr = Convert.ToInt32(dg_lieferscheine.SelectedRows[0].Cells[0].Value);
                    this.D2GRefesh(lsnr);
                }
                catch (Exception a) { MessageBox.Show("Fehler:" + a); }

            }
            else
            {
                gb_lsdetails.Visible = false;
            }
        }

        private void dg_bestellungen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string bnr = null;
            if (dg_bestellungen.Enabled == true && dg_bestellungen.SelectedRows.Count > 0 && dg_bestellungen.SelectedRows[0].Cells[0].Value != null)
            {
                bnr = Convert.ToString(dg_bestellungen.SelectedRows[0].Cells[0].Value);
                gb_checkartikel.Visible = true;
                try
                {
                    this.DG4Refesh(bnr);
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler:" + a); }

            }
            else
            {
                gb_checkartikel.Visible = false;
            }
        }

        private void b_edit_anzahl_Click(object sender, EventArgs e)
        {
            int anzahlold;
            string artikel;
            double preisold;
            double preisnew;
            int anzahl = 0;
            try
            {
                artikel = dg_checkartikel.SelectedRows[0].Cells[1].Value.ToString();
                anzahlold = Convert.ToInt32(dg_checkartikel.SelectedRows[0].Cells[2].Value);
                preisold = Convert.ToDouble(dg_checkartikel.SelectedRows[0].Cells[4].Value) / anzahlold;
                anzahl = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Bitte neue Menge für den Artikel '" + artikel + "' eingeben", "Menge", anzahlold.ToString(), -1, -1));
                preisnew = preisold * anzahl;
                dg_checkartikel.SelectedRows[0].Cells[2].Value = anzahl;
                dg_checkartikel.SelectedRows[0].Cells[4].Value = preisnew;

            }
            catch (Exception a) { MessageBox.Show("Bitte nur nummerische Werte eingeben!"); return; }
            MessageBox.Show("Menge für '" + artikel + "' wurde gändert auf " + anzahl.ToString() + ". Neuer Preis: " + preisnew.ToString());
        }

        private void dg_checkartikel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string anr = null;
            if (dg_checkartikel.Enabled == true && dg_checkartikel.SelectedRows.Count > 0 && dg_checkartikel.SelectedRows[0].Cells[0].Value != null)
            {
                anr = Convert.ToString(dg_checkartikel.SelectedRows[0].Cells[0].Value);
                b_edit_anzahl.Visible = true;
                b_delete_artikel.Visible = true;
            }
            else
            {
                b_edit_anzahl.Visible = false;
                b_delete_artikel.Visible = false;
            }
        }

        private void b_delete_artikel_Click(object sender, EventArgs e)
        {
            if (dg_checkartikel.Enabled == true && dg_checkartikel.SelectedRows.Count > 0 && dg_checkartikel.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {
                    int selectedIndex = dg_checkartikel.CurrentCell.RowIndex;
                    dg_checkartikel.Rows.RemoveAt(selectedIndex);
                }
                catch (Exception a) { MessageBox.Show("Fehler: " + a); }
            }
        }

        private void b_newls_Click(object sender, EventArgs e)
        {
            int bnr;
            int anr;
            int anzahl;
            int lsnr;
            int lnr;
            int sb;
            string bem = "";
            decimal preis;
            decimal versandkosten;
            string meldung = "nok";
            string meldung2 = "Fehler";
            string meldung3 = "Fehler";
            try
            {
                versandkosten = Convert.ToDecimal(tb_versandkosten.Text);
            }
            catch (Exception a) { MessageBox.Show("Bitte nur einen nummerischen Wert bei Versandkosten eingeben!"); return; }

            try
            {
                bnr = Convert.ToInt32(dg_bestellungen.SelectedRows[0].Cells[0].Value);
                lnr = Convert.ToInt32(dg_bestellungen.SelectedRows[0].Cells[4].Value);
                bem = rtb_bem.Text;
                sb = Convert.ToInt32(userdata[3]);
                basis.SQLopen();
                dr = basis.GetLieferant(lnr);
                dr.Read();
                lsnr = basis.AddLieferschein(bnr, lnr, bem, sb, 2, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetInt32(6), dr.GetInt32(7), dr.GetString(8), dr.GetString(9), versandkosten);

                foreach (DataGridViewRow row in dg_checkartikel.Rows)
                {
                    if (row.Cells["Nummer"].Value != null)
                    {
                        anr = Convert.ToInt32(row.Cells["Nummer"].Value);
                        anzahl = Convert.ToInt32(row.Cells["Menge"].Value);
                        preis = Convert.ToDecimal(row.Cells["Gesamtpreis"].Value);
                        meldung = basis.AddLieferscheinArtikel(lsnr, anr, anzahl, preis);
                        meldung3 = basis.ChangeArtikelbestand(anr, anzahl);
                    }
                }
                if (meldung == "ok" && meldung3 == "ok")
                {
                    meldung2 = basis.ChangeBestellungsStatus(bnr);
                }
                MessageBox.Show(meldung2);
            }
            catch (Exception a) { MessageBox.Show("Fehler: " + a.ToString()); }
            basis.SQLclose();
            gb_checkartikel.Visible = false;
            this.DGRefesh();
            this.DG3Refesh();

        }
    }
}
