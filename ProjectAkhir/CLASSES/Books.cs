using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAkhir.CLASSES
{
    class Books
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        // function to return table of books
        public DataTable booksList()
        {
            string query = "SELECT * FROM books";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public DataTable booksListAll(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        public Boolean editBook(int id, string fname, string lname, string gender, string phone, string email, string desc, byte[] picture)
        {
            string query = "UPDATE `books` SET `kode_buku`=@fname,`judul_buku`=@lname,`penulis`=@gender,`tahun_terbit`=@phone,`kategori`=@email,`deskripsi`=@desc,`cover`=@picture WHERE id = @id";
            MySqlParameter[] parameters = new MySqlParameter[8];
            parameters[0] = new MySqlParameter("@fname", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@lname", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            parameters[2].Value = gender;

            parameters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            parameters[3].Value = phone;

            parameters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[4].Value = email;

            parameters[5] = new MySqlParameter("@desc", MySqlDbType.Text);
            parameters[5].Value = desc;

            parameters[6] = new MySqlParameter("@picture", MySqlDbType.Blob);
            parameters[6].Value = picture;

            parameters[7] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[7].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean removeBook(int id)
        {
            string query = "DELETE FROM books WHERE id = @id";
            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean addBooks(string fname, string lname, string gender, string phone, string email, string deskripsi, byte[] picture)
        {
            string query = "INSERT INTO `books`(`kode_buku`, `judul_buku`, `penulis`, `tahun_terbit`, `kategori`, `deskripsi`, `cover`) VALUES (@fname, @lname, @gender, @phone, @email, @deskripsi, @picture)";
            MySqlParameter[] parameters = new MySqlParameter[7];
            parameters[0] = new MySqlParameter("@fname", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@lname", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            parameters[2].Value = gender;

            parameters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            parameters[3].Value = phone;

            parameters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[4].Value = email;

            parameters[5] = new MySqlParameter("@deskripsi", MySqlDbType.VarChar);
            parameters[5].Value = deskripsi;

            parameters[6] = new MySqlParameter("@picture", MySqlDbType.Blob);
            parameters[6].Value = picture;

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
