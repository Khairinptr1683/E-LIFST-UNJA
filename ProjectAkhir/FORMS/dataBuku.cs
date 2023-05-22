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
    public partial class dataBuku : Form
    {
        public dataBuku()
        {
            InitializeComponent();
        }
        CLASSES.Books books = new CLASSES.Books();
        private void dataBuku_Load(object sender, EventArgs e)
        {
            gunaDataGridViewtblDataBuku.DataSource = books.booksList();
        }
    }
}
