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
    public partial class Form3 : Form
    {
        Class1 basis = new Class1();
        DataSet ds = null;
        int userlevel;
        string[] userdata;
        public Form3(string[] userdata)
        {
            this.userdata = userdata;
            userlevel = Convert.ToInt32(userdata[4]);
            InitializeComponent();
        }

        public void DGRefresh()
        {
            dg_user.Enabled = false;
            ds = basis.ShowDataSettings(Convert.ToInt32(userdata[3]));
            dg_user.DataSource = ds;
            dg_user.DataMember = "ShowDataSettings";
            dg_user.Enabled = true;
            dg_user.Columns["Mnr"].Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_changepw_Click(object sender, EventArgs e)
        {
            string[] meldung;
            try
            {
                basis.SQLopen();
                meldung = basis.ChangePw(userdata[5], tb_newpw.Text, tb_newpw2.Text, tb_oldpw.Text);
                MessageBox.Show(meldung[0].ToString());
            }
            catch(Exception a) { MessageBox.Show("Datenbankfehler: " +a); }
            basis.SQLclose();

        }

        private void b_savedg_Click(object sender, EventArgs e)
        {
            try
            {
                string meldung = basis.SaveDataDG("ShowDataSettings");
                MessageBox.Show(meldung);
                ds.Clear();
                this.DGRefresh();
            }
            catch (Exception a) { MessageBox.Show("Datenbankfehler: " + a); }
        }
    }
}
