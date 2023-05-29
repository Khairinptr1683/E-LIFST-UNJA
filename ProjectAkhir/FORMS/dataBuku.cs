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
    public partial class dataBuku : Form
    {
        public dataBuku()
        {
            InitializeComponent();
        }
        CLASSES.Books books = new CLASSES.Books();
        int idBuku;
        private void dataBuku_Load(object sender, EventArgs e)
        {
            gunaDataGridViewtblDataBuku.DataSource = books.booksList();
            gunaDataGridViewtblDataBuku.RowTemplate.Height = 90;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridViewtblDataBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idBuku = Convert.ToInt32(gunaDataGridViewtblDataBuku.CurrentRow.Cells[0].Value);
            gunaTextBoxKodeBuku.Text = gunaDataGridViewtblDataBuku.CurrentRow.Cells[1].Value.ToString();
            gunaTextBoxJudulBuku.Text = gunaDataGridViewtblDataBuku.CurrentRow.Cells[2].Value.ToString();
            gunaTextBoxPenulis.Text = gunaDataGridViewtblDataBuku.CurrentRow.Cells[3].Value.ToString();
            gunaTextBoxTahunTerbit.Text = gunaDataGridViewtblDataBuku.CurrentRow.Cells[4].Value.ToString();
            gunaTextBoxKategori.Text = gunaDataGridViewtblDataBuku.CurrentRow.Cells[5].Value.ToString();
            textBoxDeskripsi.Text = gunaDataGridViewtblDataBuku.CurrentRow.Cells[6].Value.ToString();
            byte[] pic = (byte[])gunaDataGridViewtblDataBuku.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(pic);
            gunaPictureBoxCover.Image = Image.FromStream(ms);
        }



        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            string kode_buku = gunaTextBoxKodeBuku.Text;
            string judul_buku = gunaTextBoxJudulBuku.Text;
            string penulis = gunaTextBoxPenulis.Text;
            string tahun_terbit = gunaTextBoxTahunTerbit.Text;
            string kategori = gunaTextBoxKategori.Text;
            string deskripsi = textBoxDeskripsi.Text;

            MemoryStream ms = new MemoryStream();
            gunaPictureBoxCover.Image.Save(ms, gunaPictureBoxCover.Image.RawFormat);
            byte[] cover = ms.ToArray();

            if (books.editBook(idBuku, kode_buku, judul_buku, penulis, tahun_terbit, kategori, deskripsi, cover))
            {
                MessageBox.Show("Book Edited Succesfully", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gunaDataGridViewtblDataBuku.DataSource = books.booksList();
            }
        }

        private void gunaButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (books.removeBook(idBuku))
                {
                    MessageBox.Show("Book Deleted Succesfully", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gunaDataGridViewtblDataBuku.DataSource = books.booksList();
                }
                else
                {
                    MessageBox.Show("Book not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void gunaButtonAdd_Click(object sender, EventArgs e)
        {
            string kode_buku = gunaTextBoxKodeBuku.Text;
            string judul_buku = gunaTextBoxJudulBuku.Text;
            string penulis = gunaTextBoxPenulis.Text;
            string tahun_terbit = gunaTextBoxTahunTerbit.Text;
            string kategori = gunaTextBoxKategori.Text;
            string deskripsi = textBoxDeskripsi.Text;

            MemoryStream ms = new MemoryStream();
            gunaPictureBoxCover.Image.Save(ms, gunaPictureBoxCover.Image.RawFormat);
            byte[] cover = ms.ToArray();

            if (books.addBooks(kode_buku, judul_buku, penulis, tahun_terbit, kategori, deskripsi, cover))
            {
                MessageBox.Show("Buku Berhasil ditambahkan", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gunaDataGridViewtblDataBuku.DataSource = books.booksList();
            }
        }

        private void gunaButtonUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                gunaPictureBoxCover.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
