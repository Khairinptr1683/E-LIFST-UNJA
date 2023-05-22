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
    public partial class Buku : Form
    {
        public Buku()
        {
            InitializeComponent();
        }

        int[] idxDisplayBuku = new int[5];
        int htgBtnNext = 0;
        CLASSES.Books book = new CLASSES.Books();

        private void Buku_Load(object sender, EventArgs e)
        {
            DataTable bookData = book.booksList();
            byte[] img;
            MemoryStream ms;
            int i = book.booksList().Rows.Count - 5;
            int j = 0;
            htgBtnNext = book.booksList().Rows.Count;
            foreach (var control in gunaShadowPanelDisplayBook.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    idxDisplayBuku[j] = i;
                    Panel panel = (Panel)control;
                    img = (byte[])bookData.Rows[i][7];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                    i++;
                    j++;
                }

            }
            jdlBukuTampil();
        }

        private void jdlBukuTampil()
        {
            DataTable bookData = book.booksList();
            gunaLabelJdlBuku0.Text = bookData.Rows[idxDisplayBuku[0]][2].ToString();
            gunaLabelJdlBuku1.Text = bookData.Rows[idxDisplayBuku[1]][2].ToString();
            gunaLabelJdlBuku2.Text = bookData.Rows[idxDisplayBuku[2]][2].ToString();
            gunaLabelJdlBuku3.Text = bookData.Rows[idxDisplayBuku[3]][2].ToString();
            gunaLabelJdlBuku4.Text = bookData.Rows[idxDisplayBuku[4]][2].ToString();
        }
    }
}
