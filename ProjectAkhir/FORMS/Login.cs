using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir.FORMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataTable tableUser = new DataTable();
        CLASSES.User user = new CLASSES.User();
        CLASSES.infoLogin infologin = new CLASSES.infoLogin();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = gunaTextBoxUsername.Text;
                string pwd = gunaTextBoxPassword.Text;
                tableUser = user.checkLogin(name, pwd);
                
                if(tableUser.Rows.Count > 0)
                {
                    infologin.userInfo(1, tableUser.Rows[0][1].ToString(), tableUser.Rows[0][2].ToString(), tableUser.Rows[0][3].ToString(), tableUser.Rows[0][4].ToString(), tableUser.Rows[0][5].ToString());
                    this.Hide();
                    Utama utama = new Utama(tableUser);
                    utama.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Username atau Password salah " + ex);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daftar daftar = new Daftar();
            daftar.ShowDialog();
            this.Close();
        }
    }
}
