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
        CLASSES.Books book = new CLASSES.Books();

        private void tampilBuku(DataTable booksList)
        {
            ListViewItem[] items = new ListViewItem[booksList.Rows.Count];
            String[] titles = new String[booksList.Rows.Count];

            for (int i = 0; i < booksList.Rows.Count; i++)
            {
                byte[] img = (byte[])booksList.Rows[i][7];
                MemoryStream ms = new MemoryStream(img);

                // add image to the image list
                imageListBooksCovers.Images.Add(Image.FromStream(ms));

                // add title to titles array
                titles[i] = booksList.Rows[i][2].ToString();
            }

            listViewBooks.View = View.LargeIcon;
            imageListBooksCovers.ImageSize = new Size(150, 200);
            listViewBooks.LargeImageList = imageListBooksCovers;

            // loop to display the data in the listView
            for (int j = 0; j < imageListBooksCovers.Images.Count; j++)
            {
                listViewBooks.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j, SubItems = { j.ToString() } });

            }
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            tampilBukuAwal();

            DataTable booksList = book.booksList();
            tampilBuku(booksList);
        }

       

        private void gunaButtonSemuaBuku_Click(object sender, EventArgs e)
        {
            gunaShadowPanelSemuaBuku.Visible = true;
        }

        private void gunaShadowPanelSemuaBuku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            gunaShadowPanelSemuaBuku.Visible = false;
        }

        private void gunaButtonTeknologi_Click(object sender, EventArgs e)
        {
            gunaLabelJdlKategori.Text = "Teknologi";
            gunaLabelJdlKategori2.Text = "Teknologi";


        }

        private void listViewBooks_MouseClick(object sender, MouseEventArgs e)
        {
            String selected = listViewBooks.SelectedItems[0].SubItems[1].Text;

            DescBuku descBuku = new DescBuku(Convert.ToInt32(selected));
            descBuku.Show();
        }

        int[] idxDisplayBuku = new int[5];

        private void jdlBukuDashboard()
        {
            DataTable bookData = book.booksList();
            gunaLabelJdlBuku0.Text = bookData.Rows[idxDisplayBuku[0]][2].ToString();
            gunaLabelJdlBuku1.Text = bookData.Rows[idxDisplayBuku[1]][2].ToString();
            gunaLabelJdlBuku2.Text = bookData.Rows[idxDisplayBuku[2]][2].ToString();
            gunaLabelJdlBuku3.Text = bookData.Rows[idxDisplayBuku[3]][2].ToString();
            gunaLabelJdlBuku4.Text = bookData.Rows[idxDisplayBuku[4]][2].ToString();
        }

        private void tampilBukuAwal()
        {
            DataTable bookData = book.booksList();
            byte[] img;
            MemoryStream ms;
            int i = book.booksList().Rows.Count - 5;
            int j = 0;
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
            jdlBukuDashboard();

        }

        private void panelBuku4_MouseClick(object sender, MouseEventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[4]);
            descBuku.Show();
        }

        private void panelBuku3_MouseClick(object sender, MouseEventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[3]);
            descBuku.Show();
        }

        private void panelBuku2_MouseClick(object sender, MouseEventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[2]);
            descBuku.Show();
        }

        private void panelBuku1_MouseClick(object sender, MouseEventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[1]);
            descBuku.Show();
        }

        private void panelBuku0_MouseClick(object sender, MouseEventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[0]);
            descBuku.Show();
        }
    }
}
