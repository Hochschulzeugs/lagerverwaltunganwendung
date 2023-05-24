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
    public partial class Form6 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = new DataSet();
        OleDbDataReader dr = null;
        DataSet filterset = new DataSet();
        int userlevel;
        int dgrowcounter = -1;
        string[] userdata;
        public Form6(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (userlevel < 1)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }
            cb_abt.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_filterabteilung.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                basis.SQLopen();
                dr = basis.AbteilungenAll();
                while (dr.Read())
                {
                    cb_abt.Items.Add(dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
                    cb_filterabteilung.Items.Add(dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
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
            ds = basis.ShowDataMA();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ShowDataMA";
            dataGridView1.Enabled = true;
            dataGridView1.Columns["abtnr"].Visible = false;
            tb_filteruser.Text = null;
            cb_filterabteilung.SelectedItem = null;
        }

        public void GetData()
        {
            if (dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0)
            {
                int abtnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                dr = basis.Abteilungen(abtnr);
                dr.Read();
                if (dr.HasRows)
                {
                    cb_abt.SelectedItem = (dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
                }
            }
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

        private void cb_abt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedabt = cb_abt.Text.Split(',')[0].Trim();
            dataGridView1.SelectedRows[0].Cells[4].Value = Convert.ToInt32(selectedabt);
            dataGridView1.Focus();
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

        private void b_save_Click(object sender, EventArgs e)
        {
            string meldung = null;
            try
            {
                if (dataGridView1.DataMember == "MAFilter")
                {
                    meldung = basis.SaveDataDG("MAFilter");
                }
                else if (dataGridView1.DataMember == "ShowDataMA")
                {
                    meldung = basis.SaveDataDG("ShowDataMA");
                }
                MessageBox.Show(meldung);
                this.DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            int selectedmnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string selectedmvname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            string selectedmnname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            DialogResult dialogResult = MessageBox.Show("Möchten Sie den Mitarbeiter (" + selectedmvname + " " + selectedmnname + ") wirklich löschen?", "Löschen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    basis.SQLopen();
                    string meldung = basis.DeleteMA(selectedmnr);
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

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            dgrowcounter++;
            e.Row.Cells["abtnr"].Value = "0";
            try
            {
                basis.SQLopen();
                int rowsdb = basis.CountRowsMitarbeiter();
                int mnrneu = rowsdb + dgrowcounter;
                e.Row.Cells["Nummer"].Value = mnrneu;
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
        }

        private void tb_filteruser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                dataGridView1.Enabled = false;
                string filtertext = tb_filteruser.Text;
                if (cb_filterabteilung.SelectedItem != null)
                {
                    string filterauswahl = cb_filterabteilung.SelectedItem.ToString();
                    string filterauswahl_id = filterauswahl.Split(',')[0].Trim();
                    ds = basis.MAFilter("abtnr", "Mnn", filterauswahl_id, filtertext);
                }
                else
                {
                    ds = basis.MAFilter("Mnn", "none", filtertext, "none");
                }
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "MAFilter";
                dataGridView1.Enabled = true;
                dataGridView1.Columns["abtnr"].Visible = false;
            }
            catch (Exception a) { MessageBox.Show("Fehler" + a); }
        }

        private void cb_filterabteilung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filterabteilung.SelectedItem != null)
            {
                try
                {
                    ds.Clear();
                    dataGridView1.Enabled = false;
                    string filtertext = tb_filteruser.Text;
                    if (tb_filteruser.Text != null)
                    {
                        string filterauswahl = cb_filterabteilung.SelectedItem.ToString();
                        string filterauswahl_id = filterauswahl.Split(',')[0].Trim();
                        ds = basis.MAFilter("abtnr", "Mnn", filterauswahl_id, filtertext);
                    }
                    else
                    {
                        string filterauswahl = cb_filterabteilung.SelectedItem.ToString();
                        string filterauswahl_id = filterauswahl.Split(',')[0].Trim();
                        ds = basis.MAFilter("abtnr", "none", filterauswahl_id, "none");
                    }
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "MAFilter";
                    dataGridView1.Enabled = true;
                    dataGridView1.Columns["abtnr"].Visible = false;
                }
                catch (Exception a) { MessageBox.Show("Fehler" + a); }
            }
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            this.DGRefresh();
        }
    }
}
