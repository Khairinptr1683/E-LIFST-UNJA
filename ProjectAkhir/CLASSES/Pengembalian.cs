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
            string query = "SELECT `id`, `username`, `kode_buku`, `tgl_pengembalian` FROM `peminjaman`";
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
    }
}
