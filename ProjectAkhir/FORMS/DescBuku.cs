using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir.FORMS
{
    public partial class DescBuku : Form
    {
        int idxDisplayBuku;
        CLASSES.Books book = new CLASSES.Books();

        public DescBuku(int idxDisplayBuku)
        {
            InitializeComponent();
            this.idxDisplayBuku = idxDisplayBuku;
        }

        private void DescBuku_Load(object sender, EventArgs e)
        {
            DataTable bookData = book.booksList();
            byte[] img;
            MemoryStream ms;
            img = (byte[])bookData.Rows[idxDisplayBuku][7];
            ms = new MemoryStream(img);
            pictureBoxDescGbrBuku.Image = Image.FromStream(ms);

            gunaLabelKodeBuku.Text = bookData.Rows[idxDisplayBuku][1].ToString();
            gunaLabelJudul.Text = bookData.Rows[idxDisplayBuku][2].ToString();
            gunaLabelPenulis.Text = bookData.Rows[idxDisplayBuku][3].ToString();
            gunaLabelTahun.Text = bookData.Rows[idxDisplayBuku][4].ToString();
            gunaLabelKategori.Text = bookData.Rows[idxDisplayBuku][5].ToString();
            gunaLabelDeskripsi.Text = bookData.Rows[idxDisplayBuku][6].ToString();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            FormPeminjaman formPeminjaman = new FormPeminjaman(gunaLabelKodeBuku.Text);
            formPeminjaman.Show();
            this.Close();
        }
    }
}
