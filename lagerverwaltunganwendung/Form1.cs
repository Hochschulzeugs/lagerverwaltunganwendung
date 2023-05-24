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
using lagerverwaltungbasis;

namespace lagerverwaltunganwendung
{
    public partial class Form1 : Form
    {
        Class1 basis = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_login_Click(object sender, EventArgs e)
        {
            string[] user;
            string passwd = tb_passwd.Text;
            user = new string[] { tb_mail.Text, tb_passwd.Text } ;
            try
            {
                basis.SQLopen();
                string[] userdata = basis.UserLogin(user);
                MessageBox.Show(userdata[0].ToString() + userdata[1].ToString());
                if (userdata[2] == "True")
                {
                    this.Hide();
                    Form2 mainmenu = new Form2(userdata);
                    mainmenu.ShowDialog();
                    this.Close();
                }

            }
            catch(Exception a) { MessageBox.Show(a.ToString()); }
            basis.SQLclose();

        }

        private void tb_passwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string[] user;
                string passwd = tb_passwd.Text;
                user = new string[] { tb_mail.Text, tb_passwd.Text };
                try
                {
                    basis.SQLopen();
                    string[] userdata = basis.UserLogin(user);
                    MessageBox.Show(userdata[0].ToString() + userdata[1].ToString());
                    if (userdata[2] == "True")
                    {
                        this.Hide();
                        Form2 mainmenu = new Form2(userdata);
                        mainmenu.ShowDialog();
                        this.Close();
                    }

                }
                catch (Exception a) { MessageBox.Show(a.ToString()); }
                basis.SQLclose();
            }
        }
    }
}
