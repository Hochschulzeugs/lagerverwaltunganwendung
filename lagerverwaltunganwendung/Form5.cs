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
    public partial class Form5 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = new DataSet();
        OleDbDataReader dr = null;
        OleDbDataReader dr2 = null;
        int aonr;
        int aenr;
        int userlevel;
        int dgrowcounter = -1;
        string[] userdata;
        public Form5(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (userlevel < 1)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }
            cb_einheitdg.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_lagerort.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_lagerortdg.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_lagerort.Items.Add("-");
            try
            {
                basis.SQLopen();
                dr = basis.ArtikeleinheitAll();
                dr2 = basis.ArtikelortAll();
                while (dr.Read())
                {
                    cb_einheitdg.Items.Add(dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
                }
                while (dr2.Read())
                {
                    cb_lagerortdg.Items.Add(dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                    cb_lagerort.Items.Add(dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                }

                this.DGRefresh();

            }
            catch (Exception a) { MessageBox.Show("Fehler" + a); }
            basis.SQLclose();

        }

        public void DGRefresh()
        {
            dataGridView1.Enabled = false;
            ds.Clear();
            ds = basis.ShowDataArtikel();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ShowDataArtikel";
            dataGridView1.Enabled = true;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 30;
            dataGridView1.Columns["Aeinheit"].Visible = false;
            dataGridView1.Columns["Alagerortnr"].Visible = false;
            tb_aname.Clear();
            cb_lagerort.SelectedItem = null;
        }


        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_filter_Click(object sender, EventArgs e)
        {
            if (gb_filter.Visible == false)
            {
                b_filter.Text = "Filter verbergen";
                gb_filter.Visible = true;
            }
            else
            {
                b_filter.Text = "Filter anzeigen";
                gb_filter.Visible = false;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Enabled == true)
            {
                try
                {
                    basis.SQLopen();
                    this.GetData();
                }
                catch (Exception a) { MessageBox.Show("Datenbankfehler:" + a); }
                basis.SQLclose();
            }
        }

        public void GetData()
        {
            if (dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0)
            {
                aenr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                aonr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
                dr2 = basis.Artikelort(aonr);
                dr2.Read();

                if (dr2.HasRows)
                {
                    cb_lagerortdg.SelectedItem = (dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                }
                dr = basis.Artikeleinheit(aenr);
                dr.Read();
                if (dr.HasRows)
                {
                    cb_einheitdg.SelectedItem = (dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
                }
            }
        }

        private void cb_lagerortdg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedaonr = cb_lagerortdg.Text.Split(',')[0].Trim();
            dataGridView1.SelectedRows[0].Cells[7].Value = Convert.ToInt32(selectedaonr);
            dataGridView1.Focus();

        }

        private void b_save_Click(object sender, EventArgs e)
        {
            string meldung = null;
            try
            {
                if (dataGridView1.DataMember == "ArtikelFilter")
                {
                    meldung = basis.SaveDataDG("ArtikelFilter");
                }
                else if (dataGridView1.DataMember == "ShowDataArtikel")
                {
                    meldung = basis.SaveDataDG("ShowDataArtikel");
                }
                MessageBox.Show(meldung);
                this.DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
        }

        private void cb_einheitdg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedeinheitnr = cb_einheitdg.Text.Split(',')[0].Trim();
            dataGridView1.SelectedRows[0].Cells[6].Value = Convert.ToInt32(selectedeinheitnr);
            dataGridView1.Focus();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int selectedanr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string selectedaname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            DialogResult dialogResult = MessageBox.Show("Möchten Sie den Artikel (" + selectedaname + ") wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    basis.SQLopen();
                    string meldung = basis.DeleteArtikel(selectedanr);
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

        private void tb_aname_TextChanged(object sender, EventArgs e)
        {
            if (tb_aname.Text != null)
            {


                try
                {
                    ds.Clear();
                    dataGridView1.Enabled = false;
                    string filtertext = tb_aname.Text;
                    if (cb_lagerort.SelectedItem != null)
                    {
                        string filterauswahl = cb_lagerort.SelectedItem.ToString();
                        string filterauswahl_id = filterauswahl.Split(',')[0].Trim();
                        ds = basis.ArtikelFilter("Alagerortnr", "Abez", filterauswahl_id, filtertext);
                    }
                    else
                    {
                        ds = basis.ArtikelFilter("Abez", "none", filtertext, "none");
                    }
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "ArtikelFilter";
                    dataGridView1.Enabled = true;
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 30;
                    dataGridView1.Columns["Aeinheit"].Visible = false;
                    dataGridView1.Columns["Alagerortnr"].Visible = false;
                }
                catch (Exception a) { MessageBox.Show("Fehler" + a); }
            }
        }

        private void cb_lagerort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cb_lagerort.SelectedItem.ToString();
            if (cb_lagerort.SelectedItem != null && selection != "-")
            {
                try
                {
                    ds.Clear();
                    dataGridView1.Enabled = false;
                    string filtertext = tb_aname.Text;
                    if (tb_aname.Text != null)
                    {
                        string filterauswahl = cb_lagerort.SelectedItem.ToString();
                        string filterauswahl_id = filterauswahl.Split(',')[0].Trim();
                        ds = basis.ArtikelFilter("Alagerortnr", "Abez", filterauswahl_id, filtertext);
                    }
                    else
                    {
                        string filterauswahl = cb_lagerort.SelectedItem.ToString();
                        string filterauswahl_id = filterauswahl.Split(',')[0].Trim();
                        ds = basis.ArtikelFilter("Alagerortnr", "none", filterauswahl_id, "none");
                    }
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "ArtikelFilter";
                    dataGridView1.Enabled = true;
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 30;
                    dataGridView1.Columns["Aeinheit"].Visible = false;
                    dataGridView1.Columns["Alagerortnr"].Visible = false;
                }
                catch (Exception a) { MessageBox.Show("Fehler" + a); }
            }
            else if (selection == "-")
            {
                string filtertext = tb_aname.Text;
                if (tb_aname.Text != null)
                {
                    ds.Clear();
                    dataGridView1.Enabled = false;
                    ds = basis.ArtikelFilter("Abez", "none", filtertext, "none");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "ArtikelFilter";
                    dataGridView1.Enabled = true;
                    DataGridViewColumn column = dataGridView1.Columns[0];
                    column.Width = 30;
                    dataGridView1.Columns["Aeinheit"].Visible = false;
                    dataGridView1.Columns["Alagerortnr"].Visible = false;
                }
            }


        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dgrowcounter++;
            try
            {
                basis.SQLopen();
                int rowsdb = basis.CountRowsArtikel();
                int mnrneu = rowsdb + dgrowcounter;
                e.Row.Cells["Anr"].Value = mnrneu;
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
        }
    }
}
