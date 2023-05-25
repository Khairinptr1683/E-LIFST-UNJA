using MySql.Data.MySqlClient;
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
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        private void peminjamanUser_Load(object sender, EventArgs e)
        {
            string queryCariUser = "SELECT `username` FROM `info_login`";
            DataTable tableUsr = new DataTable();
            tableUsr = db.getData(queryCariUser, null);

            string query = "SELECT `id`, `kode_buku`, `username`, `tgl_peminjaman`, `batas_waktu`, `status` FROM `peminjaman` WHERE `username` = @usrName AND `status` <> 'Di Kembalikan'";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@usrName", MySqlDbType.VarChar);
            parameters[0].Value = tableUsr.Rows[0][0].ToString();

            DataTable table = new DataTable();
            table = db.getData(query, parameters);


            gunaDataGridViewTblPeminjaman.DataSource = table;
        }
    }
}
