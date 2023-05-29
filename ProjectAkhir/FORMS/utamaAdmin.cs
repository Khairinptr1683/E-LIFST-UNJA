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
    public partial class utamaAdmin : Form
    {
        public utamaAdmin()
        {
            InitializeComponent();
        }

        private void utamaAdmin_Load(object sender, EventArgs e)
        {
            container(new dataBuku());
        }

        public void container(object _form)
        {
            if (gunaPanelContainer.Controls.Count > 0) gunaPanelContainer.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanelContainer.Controls.Add(fm);
            gunaPanelContainer.Tag = fm;
            fm.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            gunaButton1.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton2.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton5.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton3.BaseColor = Color.FromArgb(171, 212, 240);

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            container(new dataBuku());
            gunaButton1.BaseColor = Color.FromArgb(53, 92, 148);
            gunaButton2.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton5.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton3.BaseColor = Color.FromArgb(171, 212, 240);

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            container(new peminjamanAdmin());
            gunaButton1.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton2.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton5.BaseColor = Color.FromArgb(53, 92, 148);
            gunaButton3.BaseColor = Color.FromArgb(171, 212, 240);

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            container(new pengembalianAdmin());
            gunaButton1.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton2.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton3.BaseColor = Color.FromArgb(53, 92, 148);
            gunaButton5.BaseColor = Color.FromArgb(171, 212, 240);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            container(new Buku());
            gunaButton1.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton2.BaseColor = Color.FromArgb(53, 92, 148); 
            gunaButton3.BaseColor = Color.FromArgb(171, 212, 240);
            gunaButton5.BaseColor = Color.FromArgb(171, 212, 240);
        }
    }
}
