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
    public partial class Form4 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = new DataSet();
        OleDbDataReader dr = null;
        OleDbDataReader dr2 = null;
        DataSet filterset = new DataSet();
        int userlevel;
        int userlevelnr;
        int dgrowcounter = -1;
        string[] userdata;
        public Form4(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (userlevel < 7)
            {
                MessageBox.Show("Fehler: Kein Zugriff");
                this.Close();
            }
            cb_abteilung.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_userlevel.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                basis.SQLopen();
                dr = basis.AbteilungenAll();
                dr2 = basis.UserlevelAll();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cb_abteilung.Items.Add(dr.GetString(1));
                    }
                }
                while (dr2.Read())
                {
                    cb_userlevel.Items.Add(dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                }
                
                this.DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
        }
        public void DGRefresh()
        {
            dataGridView1.Enabled = false;
            ds.Clear();
            ds = basis.ShowDataMAadmin();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ShowDataMAadmin";
            dataGridView1.Enabled = true;
            dataGridView1.Columns["userlevel"].Visible = false;
            dataGridView1.Columns["abtnr"].Visible = false;
        }

        public void GetData()
        {
            if (dataGridView1.Enabled == true && dataGridView1.SelectedRows.Count > 0)
            {
                userlevelnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                int abtnr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                dr = basis.Userlevel(userlevelnr);
                dr.Read();
                if (dr.HasRows)
                {
                    cb_userlevel.SelectedItem = (dr.GetInt32(0).ToString() + ", " + dr.GetString(1));
                }

                dr2 = basis.Abteilungen(abtnr);
                dr2.Read();
                if (dr2.HasRows)
                {
                    tb_abt.Text = (dr2.GetInt32(0).ToString() + ", " + dr2.GetString(1));
                }


            }
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

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_userlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteduserlevel = cb_userlevel.Text.Split(',')[0].Trim();
            dataGridView1.SelectedRows[0].Cells[5].Value = Convert.ToInt32(selecteduserlevel);
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
                catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
                basis.SQLclose();

            }
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            this.DGRefresh();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                string meldung = basis.SaveDataDG("ShowDataMAadmin");
                MessageBox.Show(meldung);
                this.DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
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
                e.Row.Cells["Mnr"].Value = mnrneu;
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
            basis.SQLclose();
        }
    }
}
