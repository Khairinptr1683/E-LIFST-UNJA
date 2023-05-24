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
    public partial class Daftar : Form
    {
        public Daftar()
        {
            InitializeComponent();
        }
        CLASSES.User user = new CLASSES.User();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(gunaTextBoxUsername.Text != "" && gunaTextBoxNamaLengkap.Text != "" && gunaTextBoxEmail.Text != "" && gunaTextBoxNim.Text != "" && gunaTextBoxPwd.Text != "" && gunaTextBoxConfPwd.Text != "")
            {
                if (gunaTextBoxPwd.Text == gunaTextBoxConfPwd.Text)
                {
                    string namaLengkap = gunaTextBoxNamaLengkap.Text;
                    string username = gunaTextBoxUsername.Text;
                    string email = gunaTextBoxEmail.Text;
                    string nim = gunaTextBoxNim.Text;
                    string password = gunaTextBoxPwd.Text;

                    user.addUser(namaLengkap, username, email, nim, password);
                    MessageBox.Show("Daftar Akun Berhasil");
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Konfirmasi Password Tidak sesuai");
                }
            }
            else
            {
                MessageBox.Show("Pastikan semua data tidak kosong");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
