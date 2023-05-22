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
    public partial class pengembalianUser : Form
    {
        public pengembalianUser()
        {
            InitializeComponent();
        }
        CLASSES.Pengembalian pengembalian = new CLASSES.Pengembalian();
        private void pengembalianUser_Load(object sender, EventArgs e)
        {
            gunaDataGridViewTblPengembalian.DataSource = pengembalian.pengembalianList();
        }
    }
}
