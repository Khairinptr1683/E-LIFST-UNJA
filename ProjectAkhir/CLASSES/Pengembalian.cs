using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAkhir.CLASSES
{
    class Pengembalian
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        public DataTable pengembalianList()
        {
            string query = "SELECT `id`, `username`, `kode_buku`, `tgl_peminjaman`, `tgl_pengembalian`, `batas_waktu`, `terlambat` FROM `peminjaman` WHERE `status` = 'Di Kembalikan' OR `status` = 'Di Pinjam'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public DataTable pengembalianListUser()
        {
            string queryCariUser = "SELECT `username` FROM `info_login`";
            DataTable tableUsr = new DataTable();
            tableUsr = db.getData(queryCariUser, null);

            string query = "SELECT `id`, `username`, `kode_buku`, `tgl_peminjaman`, `tgl_pengembalian`, `batas_waktu`, `terlambat` FROM `peminjaman` WHERE `status` = 'Di Kembalikan' AND `username` = @usrName";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@usrName", MySqlDbType.VarChar);
            parameters[0].Value = tableUsr.Rows[0][0].ToString();

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }
    }
}
