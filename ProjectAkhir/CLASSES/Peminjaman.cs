using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectAkhir.CLASSES
{
    class Peminjaman
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        public Boolean addPinjam(string username, string nim, string email, string kode_buku, DateTime tgl_peminjaman, DateTime batasWkt)
        {
            string query = "INSERT INTO `peminjaman`(`username`, `nim`, `email`, `kode_buku`, `tgl_peminjaman`, `batas_waktu`, `status`) VALUES (@username, @nim, @email, @kode_buku, @tgl_peminjaman, @batasWkt, @sta)";
            MySqlParameter[] parameters = new MySqlParameter[7];
            
            parameters[0] = new MySqlParameter("@username", MySqlDbType.VarChar);
            parameters[0].Value = username;

            parameters[1] = new MySqlParameter("@nim", MySqlDbType.VarChar);
            parameters[1].Value = nim;

            parameters[2] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[2].Value = email;

            parameters[3] = new MySqlParameter("@kode_buku", MySqlDbType.VarChar);
            parameters[3].Value = kode_buku;

            parameters[4] = new MySqlParameter("@tgl_peminjaman", MySqlDbType.DateTime);
            parameters[4].Value = tgl_peminjaman;

            parameters[5] = new MySqlParameter("@batasWkt", MySqlDbType.DateTime);
            parameters[5].Value = batasWkt;

            parameters[6] = new MySqlParameter("@sta", MySqlDbType.VarChar);
            parameters[6].Value = "Di Proses";

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable peminjamanList()
        {
            string query = "SELECT `id`, `username`, `kode_buku`, `tgl_peminjaman`, `status`, `batas_waktu` FROM `peminjaman`";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public DataTable peminjamanListAdmin()
        {
            string query = "SELECT `id`, `username`, `kode_buku`, `tgl_peminjaman`, `status` FROM `peminjaman` WHERE `status` = 'Di Proses' OR `status` = 'Di Pinjam'";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

    }
}
