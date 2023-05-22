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
        public FormPeminjaman()
        {
            InitializeComponent();
        }
        CLASSES.Peminjaman peminjaman = new CLASSES.Peminjaman();
        private void gunaButtonKirimFormulir_Click(object sender, EventArgs e)
        {
            string username = gunaTextBoxUsername.Text;
            string nim = gunaTextBoxNIM.Text;
            string email = gunaTextBoxEmail.Text;
            string kode_buku = gunaTextBoxKodeBuku.Text;
            DateTime tgl_peminjaman = dateTimePickerPeminjaman.Value;
            DateTime tgl_pengembalian = dateTimePickerPengembalian.Value;


            if(peminjaman.addPinjam(username, nim, email, kode_buku, tgl_peminjaman, tgl_pengembalian))
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
    }
}
