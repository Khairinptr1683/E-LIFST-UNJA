﻿using MySql.Data.MySqlClient;
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
    public partial class peminjamanAdmin : Form
    {
        public peminjamanAdmin()
        {
            InitializeComponent();
        }
        CLASSES.Peminjaman peminjaman = new CLASSES.Peminjaman();
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        private void peminjamanAdmin_Load(object sender, EventArgs e)
        {
            gunaDataGridViewTblPeminjaman.DataSource = peminjaman.peminjamanListAdmin();
            gunaDataGridViewTblPeminjaman.RowTemplate.Height = 30;
        }

        private void gunaDataGridViewTblPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridViewTblPeminjaman.Columns[e.ColumnIndex].Name == "aksi")
            {

                string query = "UPDATE `peminjaman` SET `status`=@sta WHERE id = @id";
                MySqlParameter[] parameters = new MySqlParameter[2];
                parameters[0] = new MySqlParameter("@sta", MySqlDbType.VarChar);
                parameters[0].Value = "Di Pinjam";

                parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[1].Value = gunaDataGridViewTblPeminjaman.CurrentRow.Cells[1].Value;

                db.setData(query, parameters);

                MessageBox.Show("Peminjaman di konfirmasi");
                gunaDataGridViewTblPeminjaman.DataSource = peminjaman.peminjamanListAdmin();
            }

        }
    }
}
