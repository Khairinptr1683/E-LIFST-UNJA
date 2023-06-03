
namespace ProjectAkhir.FORMS
{
    partial class dataBuku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDataGridViewtblDataBuku = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaTextBoxKodeBuku = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBoxJudulBuku = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaTextBoxPenulis = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaTextBoxTahunTerbit = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaTextBoxKategori = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaButtonUploadCover = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonEdit = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonDelete = new Guna.UI.WinForms.GunaButton();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.gunaPictureBoxCover = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButtonAdd = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewtblDataBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(123)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(333, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATA BUKU PERPUSTAKAAN";
            // 
            // gunaDataGridViewtblDataBuku
            // 
            this.gunaDataGridViewtblDataBuku.AllowUserToAddRows = false;
            this.gunaDataGridViewtblDataBuku.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewtblDataBuku.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewtblDataBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewtblDataBuku.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewtblDataBuku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewtblDataBuku.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewtblDataBuku.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewtblDataBuku.ColumnHeadersHeight = 30;
            this.gunaDataGridViewtblDataBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gunaDataGridViewtblDataBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewtblDataBuku.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewtblDataBuku.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewtblDataBuku.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewtblDataBuku.Location = new System.Drawing.Point(12, 59);
            this.gunaDataGridViewtblDataBuku.Name = "gunaDataGridViewtblDataBuku";
            this.gunaDataGridViewtblDataBuku.ReadOnly = true;
            this.gunaDataGridViewtblDataBuku.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gunaDataGridViewtblDataBuku.RowHeadersVisible = false;
            this.gunaDataGridViewtblDataBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewtblDataBuku.Size = new System.Drawing.Size(1052, 299);
            this.gunaDataGridViewtblDataBuku.TabIndex = 3;
            this.gunaDataGridViewtblDataBuku.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewtblDataBuku.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewtblDataBuku.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewtblDataBuku.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.ReadOnly = true;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewtblDataBuku.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewtblDataBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridViewtblDataBuku_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 105.5838F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 26;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "kode_buku";
            this.Column2.FillWeight = 99.20232F;
            this.Column2.HeaderText = "Kode Buku";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "judul_buku";
            this.Column3.FillWeight = 99.20232F;
            this.Column3.HeaderText = "Judul Buku";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "penulis";
            this.Column4.FillWeight = 99.20232F;
            this.Column4.HeaderText = "Penulis";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tahun_terbit";
            this.Column5.FillWeight = 99.20232F;
            this.Column5.HeaderText = "Tahun Terbit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "kategori";
            this.Column6.FillWeight = 99.20232F;
            this.Column6.HeaderText = "Kategori";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "deskripsi";
            this.Column7.FillWeight = 99.20232F;
            this.Column7.HeaderText = "Deskripsi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cover";
            this.Column8.FillWeight = 99.20232F;
            this.Column8.HeaderText = "Cover";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kode Buku";
            // 
            // gunaTextBoxKodeBuku
            // 
            this.gunaTextBoxKodeBuku.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxKodeBuku.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxKodeBuku.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxKodeBuku.BorderSize = 1;
            this.gunaTextBoxKodeBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxKodeBuku.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxKodeBuku.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxKodeBuku.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxKodeBuku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxKodeBuku.Location = new System.Drawing.Point(25, 401);
            this.gunaTextBoxKodeBuku.Name = "gunaTextBoxKodeBuku";
            this.gunaTextBoxKodeBuku.PasswordChar = '\0';
            this.gunaTextBoxKodeBuku.Radius = 5;
            this.gunaTextBoxKodeBuku.SelectedText = "";
            this.gunaTextBoxKodeBuku.Size = new System.Drawing.Size(224, 31);
            this.gunaTextBoxKodeBuku.TabIndex = 6;
            // 
            // gunaTextBoxJudulBuku
            // 
            this.gunaTextBoxJudulBuku.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxJudulBuku.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxJudulBuku.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxJudulBuku.BorderSize = 1;
            this.gunaTextBoxJudulBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxJudulBuku.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxJudulBuku.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxJudulBuku.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxJudulBuku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxJudulBuku.Location = new System.Drawing.Point(25, 465);
            this.gunaTextBoxJudulBuku.Name = "gunaTextBoxJudulBuku";
            this.gunaTextBoxJudulBuku.PasswordChar = '\0';
            this.gunaTextBoxJudulBuku.Radius = 5;
            this.gunaTextBoxJudulBuku.SelectedText = "";
            this.gunaTextBoxJudulBuku.Size = new System.Drawing.Size(224, 31);
            this.gunaTextBoxJudulBuku.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Judul Buku";
            // 
            // gunaTextBoxPenulis
            // 
            this.gunaTextBoxPenulis.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxPenulis.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxPenulis.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxPenulis.BorderSize = 1;
            this.gunaTextBoxPenulis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxPenulis.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxPenulis.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxPenulis.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxPenulis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxPenulis.Location = new System.Drawing.Point(297, 401);
            this.gunaTextBoxPenulis.Name = "gunaTextBoxPenulis";
            this.gunaTextBoxPenulis.PasswordChar = '\0';
            this.gunaTextBoxPenulis.Radius = 5;
            this.gunaTextBoxPenulis.SelectedText = "";
            this.gunaTextBoxPenulis.Size = new System.Drawing.Size(224, 31);
            this.gunaTextBoxPenulis.TabIndex = 10;
            this.gunaTextBoxPenulis.TextChanged += new System.EventHandler(this.gunaTextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Penulis";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gunaTextBoxTahunTerbit
            // 
            this.gunaTextBoxTahunTerbit.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxTahunTerbit.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxTahunTerbit.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxTahunTerbit.BorderSize = 1;
            this.gunaTextBoxTahunTerbit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxTahunTerbit.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxTahunTerbit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxTahunTerbit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxTahunTerbit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxTahunTerbit.Location = new System.Drawing.Point(297, 465);
            this.gunaTextBoxTahunTerbit.Name = "gunaTextBoxTahunTerbit";
            this.gunaTextBoxTahunTerbit.PasswordChar = '\0';
            this.gunaTextBoxTahunTerbit.Radius = 5;
            this.gunaTextBoxTahunTerbit.SelectedText = "";
            this.gunaTextBoxTahunTerbit.Size = new System.Drawing.Size(224, 31);
            this.gunaTextBoxTahunTerbit.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tahun Terbit";
            // 
            // gunaTextBoxKategori
            // 
            this.gunaTextBoxKategori.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBoxKategori.BaseColor = System.Drawing.Color.White;
            this.gunaTextBoxKategori.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBoxKategori.BorderSize = 1;
            this.gunaTextBoxKategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxKategori.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBoxKategori.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBoxKategori.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBoxKategori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBoxKategori.Location = new System.Drawing.Point(549, 401);
            this.gunaTextBoxKategori.Name = "gunaTextBoxKategori";
            this.gunaTextBoxKategori.PasswordChar = '\0';
            this.gunaTextBoxKategori.Radius = 5;
            this.gunaTextBoxKategori.SelectedText = "";
            this.gunaTextBoxKategori.Size = new System.Drawing.Size(224, 31);
            this.gunaTextBoxKategori.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Deskripsi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(544, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cover";
            // 
            // gunaButtonUploadCover
            // 
            this.gunaButtonUploadCover.AnimationHoverSpeed = 0.07F;
            this.gunaButtonUploadCover.AnimationSpeed = 0.03F;
            this.gunaButtonUploadCover.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonUploadCover.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(123)))), ((int)(((byte)(177)))));
            this.gunaButtonUploadCover.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonUploadCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonUploadCover.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonUploadCover.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonUploadCover.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonUploadCover.ForeColor = System.Drawing.Color.White;
            this.gunaButtonUploadCover.Image = null;
            this.gunaButtonUploadCover.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonUploadCover.Location = new System.Drawing.Point(549, 656);
            this.gunaButtonUploadCover.Name = "gunaButtonUploadCover";
            this.gunaButtonUploadCover.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonUploadCover.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonUploadCover.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonUploadCover.OnHoverImage = null;
            this.gunaButtonUploadCover.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonUploadCover.Radius = 5;
            this.gunaButtonUploadCover.Size = new System.Drawing.Size(142, 33);
            this.gunaButtonUploadCover.TabIndex = 20;
            this.gunaButtonUploadCover.Text = "Upload Cover";
            this.gunaButtonUploadCover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonUploadCover.Click += new System.EventHandler(this.gunaButtonUploadCover_Click);
            // 
            // gunaButtonEdit
            // 
            this.gunaButtonEdit.AnimationHoverSpeed = 0.07F;
            this.gunaButtonEdit.AnimationSpeed = 0.03F;
            this.gunaButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(123)))), ((int)(((byte)(177)))));
            this.gunaButtonEdit.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonEdit.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonEdit.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonEdit.ForeColor = System.Drawing.Color.White;
            this.gunaButtonEdit.Image = null;
            this.gunaButtonEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonEdit.Location = new System.Drawing.Point(727, 523);
            this.gunaButtonEdit.Name = "gunaButtonEdit";
            this.gunaButtonEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonEdit.OnHoverImage = null;
            this.gunaButtonEdit.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.Radius = 5;
            this.gunaButtonEdit.Size = new System.Drawing.Size(106, 33);
            this.gunaButtonEdit.TabIndex = 21;
            this.gunaButtonEdit.Text = "Edit";
            this.gunaButtonEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonEdit.Click += new System.EventHandler(this.gunaButtonEdit_Click);
            // 
            // gunaButtonDelete
            // 
            this.gunaButtonDelete.AnimationHoverSpeed = 0.07F;
            this.gunaButtonDelete.AnimationSpeed = 0.03F;
            this.gunaButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.gunaButtonDelete.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonDelete.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonDelete.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonDelete.ForeColor = System.Drawing.Color.White;
            this.gunaButtonDelete.Image = null;
            this.gunaButtonDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonDelete.Location = new System.Drawing.Point(727, 562);
            this.gunaButtonDelete.Name = "gunaButtonDelete";
            this.gunaButtonDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonDelete.OnHoverImage = null;
            this.gunaButtonDelete.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonDelete.Radius = 5;
            this.gunaButtonDelete.Size = new System.Drawing.Size(106, 33);
            this.gunaButtonDelete.TabIndex = 22;
            this.gunaButtonDelete.Text = "Delete";
            this.gunaButtonDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonDelete.Click += new System.EventHandler(this.gunaButtonDelete_Click);
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeskripsi.Location = new System.Drawing.Point(25, 538);
            this.textBoxDeskripsi.Multiline = true;
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(496, 151);
            this.textBoxDeskripsi.TabIndex = 23;
            // 
            // gunaPictureBoxCover
            // 
            this.gunaPictureBoxCover.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBoxCover.BaseColor = System.Drawing.Color.Gray;
            this.gunaPictureBoxCover.Image = global::ProjectAkhir.Properties.Resources.uploadCover;
            this.gunaPictureBoxCover.Location = new System.Drawing.Point(549, 465);
            this.gunaPictureBoxCover.Name = "gunaPictureBoxCover";
            this.gunaPictureBoxCover.Radius = 8;
            this.gunaPictureBoxCover.Size = new System.Drawing.Size(142, 185);
            this.gunaPictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBoxCover.TabIndex = 17;
            this.gunaPictureBoxCover.TabStop = false;
            // 
            // gunaButtonAdd
            // 
            this.gunaButtonAdd.AnimationHoverSpeed = 0.07F;
            this.gunaButtonAdd.AnimationSpeed = 0.03F;
            this.gunaButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(127)))), ((int)(((byte)(32)))));
            this.gunaButtonAdd.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonAdd.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonAdd.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonAdd.ForeColor = System.Drawing.Color.White;
            this.gunaButtonAdd.Image = null;
            this.gunaButtonAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonAdd.Location = new System.Drawing.Point(727, 484);
            this.gunaButtonAdd.Name = "gunaButtonAdd";
            this.gunaButtonAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButtonAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonAdd.OnHoverImage = null;
            this.gunaButtonAdd.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonAdd.Radius = 5;
            this.gunaButtonAdd.Size = new System.Drawing.Size(106, 33);
            this.gunaButtonAdd.TabIndex = 24;
            this.gunaButtonAdd.Text = "Add";
            this.gunaButtonAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonAdd.Click += new System.EventHandler(this.gunaButtonAdd_Click);
            // 
            // dataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 701);
            this.Controls.Add(this.gunaButtonAdd);
            this.Controls.Add(this.textBoxDeskripsi);
            this.Controls.Add(this.gunaButtonDelete);
            this.Controls.Add(this.gunaButtonEdit);
            this.Controls.Add(this.gunaButtonUploadCover);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gunaPictureBoxCover);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gunaTextBoxKategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gunaTextBoxTahunTerbit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaTextBoxPenulis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaTextBoxJudulBuku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaTextBoxKodeBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaDataGridViewtblDataBuku);
            this.Controls.Add(this.label1);
            this.Name = "dataBuku";
            this.Text = "dataBuku";
            this.Load += new System.EventHandler(this.dataBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewtblDataBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewtblDataBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxKodeBuku;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxJudulBuku;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxPenulis;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxTahunTerbit;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBoxKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBoxCover;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton gunaButtonUploadCover;
        private Guna.UI.WinForms.GunaButton gunaButtonEdit;
        private Guna.UI.WinForms.GunaButton gunaButtonDelete;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private Guna.UI.WinForms.GunaButton gunaButtonAdd;
    }
}