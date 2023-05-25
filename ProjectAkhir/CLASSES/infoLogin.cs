using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAkhir.CLASSES
{
    class infoLogin
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public Boolean userInfo(int id, string namaLengkap, string uName, string email, string nim, string pwd)
        {
            string query = "UPDATE `info_login` SET `nama_lengkap`=@namaLengkap,`username`=@uName,`email`=@email,`nim`=@nim,`password`=@pwd WHERE id = @id";
            MySqlParameter[] parameters = new MySqlParameter[6];
            parameters[0] = new MySqlParameter("@namaLengkap", MySqlDbType.VarChar);
            parameters[0].Value = namaLengkap;

            parameters[1] = new MySqlParameter("@uName", MySqlDbType.VarChar);
            parameters[1].Value = uName;

            parameters[2] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[2].Value = email;

            parameters[3] = new MySqlParameter("@nim", MySqlDbType.VarChar);
            parameters[3].Value = nim;

            parameters[4] = new MySqlParameter("@pwd", MySqlDbType.Text);
            parameters[4].Value = pwd;

            parameters[5] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[5].Value = id;

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
