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
    public partial class peminjamanUser : Form
    {
        public peminjamanUser()
        {
            InitializeComponent();
        }
        CLASSES.Peminjaman peminjaman = new CLASSES.Peminjaman();
        private void peminjamanUser_Load(object sender, EventArgs e)
        {
            gunaDataGridViewTblPeminjaman.DataSource = peminjaman.peminjamanList();
        }
    }
}
