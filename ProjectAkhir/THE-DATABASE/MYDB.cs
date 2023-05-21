using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectAkhir.THE_DATABASE
{
    class MYDB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;database=pvisperpustakaan;uid=root;pwd=\"\"");

        //Open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //Close the Connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //Return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }

        //create a function to return a table of data
        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //create a function to set data and execute a query
        public int setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            openConnection();
            int commandState = command.ExecuteNonQuery();
            closeConnection();
            return commandState;
        }
    }
}
