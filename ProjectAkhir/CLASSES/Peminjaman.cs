﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectAkhir.CLASSES
{
    class Peminjaman
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        public Boolean addPinjam(string username, string nim, string email, string kode_buku, DateTime tgl_peminjaman, DateTime tgl_pengembalian)
        {
            string query = "INSERT INTO `peminjaman`(`username`, `nim`, `email`, `kode_buku`, `tgl_peminjaman`, `tgl_pengembalian`) VALUES (@username, @nim, @email, @kode_buku, @tgl_peminjaman, @tgl_pengembalian)";
            MySqlParameter[] parameters = new MySqlParameter[6];
            
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

            parameters[5] = new MySqlParameter("@tgl_pengembalian", MySqlDbType.DateTime);
            parameters[5].Value = tgl_pengembalian;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}