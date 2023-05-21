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
    }
}
