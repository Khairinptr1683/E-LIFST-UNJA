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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        int[] idxDisplayBuku = new int[5];
        int htgBtnNext = 0;
        CLASSES.Books book = new CLASSES.Books();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelNumOfBooks.Text = book.booksList().Rows.Count.ToString();
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
            jdlBukuDashboard();
        }

        private void jdlBukuDashboard()
        {
            DataTable bookData = book.booksList();
            gunaLabelJdlBuku0.Text = bookData.Rows[idxDisplayBuku[0]][2].ToString();
            gunaLabelJdlBuku1.Text = bookData.Rows[idxDisplayBuku[1]][2].ToString();
            gunaLabelJdlBuku2.Text = bookData.Rows[idxDisplayBuku[2]][2].ToString();
            gunaLabelJdlBuku3.Text = bookData.Rows[idxDisplayBuku[3]][2].ToString();
            gunaLabelJdlBuku4.Text = bookData.Rows[idxDisplayBuku[4]][2].ToString();
        }

        private void gunaPictureBoxBtnNext_Click(object sender, EventArgs e)
        {
            htgBtnNext--;
            DataTable bookData = book.booksList();
            byte[] img;
            MemoryStream ms;
            int i = htgBtnNext - 5;
            int j = 0;
            if (i >= 0)
            {
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
            else
            {
                MessageBox.Show("Yaww Stap");
                htgBtnNext++;
            }

        }

        private void gunaPictureBoxPrev_Click(object sender, EventArgs e)
        {
            htgBtnNext++;
            DataTable bookData = book.booksList();
            byte[] img;
            MemoryStream ms;
            int j = 0;
            int i = htgBtnNext - 5;
            if (htgBtnNext <= book.booksList().Rows.Count)
            {
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
            else
            {
                MessageBox.Show("Yaww Stap");
                htgBtnNext--;
            }

        }

        private void panelBuku0_Click(object sender, EventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[0]);
            descBuku.Show();
        }

        private void panelBuku1_Click(object sender, EventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[1]);
            descBuku.Show();
        }

        private void panelBuku2_Click(object sender, EventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[2]);
            descBuku.Show();
        }

        private void panelBuku3_Click(object sender, EventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[3]);
            descBuku.Show();
        }

        private void panelBuku4_Click(object sender, EventArgs e)
        {
            DescBuku descBuku = new DescBuku(idxDisplayBuku[4]);
            descBuku.Show();
        }

        private void gunaShadowPanelDisplayBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabelJdlBuku4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabelJdlBuku3_Click(object sender, EventArgs e)
        {

        }

        private void panelBuku4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
