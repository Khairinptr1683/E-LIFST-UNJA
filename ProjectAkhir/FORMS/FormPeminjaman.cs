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
    public partial class FormPeminjaman : Form
    {
        string kodeBuku;
        public FormPeminjaman(string kodeBuku)
        {
            InitializeComponent();
            this.kodeBuku = kodeBuku;
        }
        CLASSES.Peminjaman peminjaman = new CLASSES.Peminjaman();
        CLASSES.User user = new CLASSES.User(); 
        private void gunaButtonKirimFormulir_Click(object sender, EventArgs e)
        {
            string username = gunaTextBoxUsername.Text;
            string nim = gunaTextBoxNIM.Text;
            string email = gunaTextBoxEmail.Text;
            string kode_buku = gunaTextBoxKodeBuku.Text;
            DateTime tgl_peminjaman = dateTimePickerPeminjaman.Value;
            DateTime batasWkt = dateTimePickerPengembalian.Value;


            if(peminjaman.addPinjam(username, nim, email, kode_buku, tgl_peminjaman, batasWkt))
            {
                this.Close();
                notifPinjam notif = new notifPinjam();
                notif.Show();
            }
            else
            {
                MessageBox.Show("Peminjaman gagal");
            }

        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            dateTimePickerPengembalian.Value = DateTime.Now.AddDays(7);
            gunaTextBoxUsername.Text = user.userlogList().Rows[0][2].ToString();
            gunaTextBoxNIM.Text = user.userlogList().Rows[0][4].ToString();
            gunaTextBoxEmail.Text = user.userlogList().Rows[0][3].ToString();
            gunaTextBoxKodeBuku.Text = kodeBuku;

        }
    }
}
