using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAkhir.CLASSES
{
    class User
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public Boolean addUser(string namaLengkap, string username, string email, string nim, string password)
        {
            string query = "INSERT INTO `user`(`nama_lengkap`, `username`, `email`, `nim`, `password`) VALUES (@namaLengkap, @username, @email, @nim, @password)";
            MySqlParameter[] parameters = new MySqlParameter[5];
            parameters[0] = new MySqlParameter("@namaLengkap", MySqlDbType.VarChar);
            parameters[0].Value = namaLengkap;

            parameters[1] = new MySqlParameter("@username", MySqlDbType.VarChar);
            parameters[1].Value = username;

            parameters[2] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[2].Value = email;

            parameters[3] = new MySqlParameter("@nim", MySqlDbType.VarChar);
            parameters[3].Value = nim;

            parameters[4] = new MySqlParameter("@password", MySqlDbType.VarChar);
            parameters[4].Value = password;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable checkLogin(string name, string pwd)
        {
            string query = "SELECT * FROM user WHERE `username` = @name AND `password` = @pwd";
            MySqlParameter[] parameters = new MySqlParameter[2];

            parameters[0] = new MySqlParameter("@name", MySqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new MySqlParameter("@pwd", MySqlDbType.VarChar);
            parameters[1].Value = pwd;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }
    }
}
