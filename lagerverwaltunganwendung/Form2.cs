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
    public partial class Form2 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = null;
        OleDbDataReader dr = null;
        string[] userdata;
        int userlevel;
        public Form2(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_welcome.Text = ("Willkommen " + userdata[1]);
            if (userlevel >6)
            {
                b_admin.Visible = true;
            }

            this.DGRefresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 usersettings = new Form3(userdata);
            usersettings.ShowDialog();
            ds.Clear();
            this.DGRefresh();
        }

        public void DGRefresh()
        {
            try
            {
                ds = basis.LimitArtikel();
                dg_artikel_low.DataSource = ds;
                dg_artikel_low.DataMember = "LimitArtikel";
                dg_artikel_low.Columns["Nummer"].Visible = false;
                basis.SQLopen();
                foreach (DataGridViewRow row in dg_artikel_low.Rows)
                {
                    if (row.Cells["Nummer"].Value != null)
                    {
                        dr = basis.LimitArtikelCheckOrder(Convert.ToInt32(row.Cells["Nummer"].Value));
                        dr.Read();
                        if (dr.GetInt32(0) > 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.SelectionBackColor = Color.Green;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.SelectionBackColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            basis.SQLclose();

        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_admin_Click(object sender, EventArgs e)
        {
            if (userlevel > 6)
            {
                Form4 administration = new Form4(userdata);
                administration.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }

        private void b_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.ShowDialog();
            this.Close();
        }

        private void b_artikel_Click(object sender, EventArgs e)
        {
            if (userlevel > 1)
            {
                Form5 artikel = new Form5(userdata);
                artikel.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            ds.Clear();
            this.DGRefresh();
        }

        private void b_mitarbeiter_Click(object sender, EventArgs e)
        {
            if (userlevel > 1)
            {
                Form6 mitarbeiter = new Form6(userdata);
                mitarbeiter.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }

        private void b_lieferanten_Click(object sender, EventArgs e)
        {
            if (userlevel > 1)
            {
                Form7 lieferanten = new Form7(userdata);
                lieferanten.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }

        private void b_bestellungen_Click(object sender, EventArgs e)
        {
            if (userlevel > 1)
            {
                Form8 bestellungen = new Form8(userdata);
                bestellungen.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }

        private void b_lieferungen_Click(object sender, EventArgs e)
        {
            if (userlevel > 1)
            {
                Form9 lieferungen = new Form9(userdata);
                lieferungen.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }

        private void b_matentnahme_Click(object sender, EventArgs e)
        {
            if (userlevel > 1)
            {
                Form10 matschein = new Form10(userdata);
                matschein.ShowDialog();
                ds.Clear();
                this.DGRefresh();
            }
            else
            {
                MessageBox.Show("Kein Zugriff!");
            }
        }
    }
}
