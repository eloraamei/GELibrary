﻿namespace GELibrary
{
    partial class AddBuku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBuku));
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.txtPengarang = new GELibrary.CharTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPenerbit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTahunTerbit = new GELibrary.numericTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLokasi = new System.Windows.Forms.ComboBox();
            this.txtharga = new GELibrary.numericTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJumlah = new GELibrary.numericTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnTambah = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.gELibraryDataSet1 = new GELibrary.GELibraryDataSet1();
            this.kategoriBukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategori_BukuTableAdapter = new GELibrary.GELibraryDataSet1TableAdapters.Kategori_BukuTableAdapter();
            this.penerbitBukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penerbit_BukuTableAdapter = new GELibrary.GELibraryDataSet1TableAdapters.Penerbit_BukuTableAdapter();
            this.lokasiBukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokasi_BukuTableAdapter = new GELibrary.GELibraryDataSet1TableAdapters.Lokasi_BukuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gELibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penerbitBukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokasiBukuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 19;
            this.btnClose.Location = new System.Drawing.Point(711, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 19);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(295, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "        Tambah Buku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdd
            // 
            this.panelAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelAdd.Controls.Add(this.btnClose);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Location = new System.Drawing.Point(-1, -5);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(741, 79);
            this.panelAdd.TabIndex = 9;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdd_Paint);
            this.panelAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAdd_MouseDown);
            // 
            // txtPengarang
            // 
            this.txtPengarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPengarang.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPengarang.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPengarang.Location = new System.Drawing.Point(57, 294);
            this.txtPengarang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPengarang.Multiline = true;
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.Size = new System.Drawing.Size(280, 28);
            this.txtPengarang.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Judul Buku";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(57, 123);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(280, 26);
            this.txtID.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID Buku";
            // 
            // txtJudul
            // 
            this.txtJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtJudul.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudul.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtJudul.Location = new System.Drawing.Point(57, 180);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJudul.Multiline = true;
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(280, 26);
            this.txtJudul.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(53, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Kategori";
            // 
            // cbKategori
            // 
            this.cbKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbKategori.DataSource = this.kategoriBukuBindingSource;
            this.cbKategori.DisplayMember = "Nama";
            this.cbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKategori.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(57, 240);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(280, 21);
            this.cbKategori.TabIndex = 54;
            this.cbKategori.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(53, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pengarang";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(53, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Penerbit";
            // 
            // cbPenerbit
            // 
            this.cbPenerbit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPenerbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbPenerbit.DataSource = this.penerbitBukuBindingSource;
            this.cbPenerbit.DisplayMember = "Nama";
            this.cbPenerbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPenerbit.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbPenerbit.FormattingEnabled = true;
            this.cbPenerbit.Location = new System.Drawing.Point(57, 350);
            this.cbPenerbit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPenerbit.Name = "cbPenerbit";
            this.cbPenerbit.Size = new System.Drawing.Size(280, 21);
            this.cbPenerbit.TabIndex = 57;
            this.cbPenerbit.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(396, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tahun Terbit";
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtTahunTerbit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTahunTerbit.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTahunTerbit.Location = new System.Drawing.Point(399, 123);
            this.txtTahunTerbit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTahunTerbit.Multiline = true;
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(280, 26);
            this.txtTahunTerbit.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(396, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Lokasi Buku";
            // 
            // cbLokasi
            // 
            this.cbLokasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLokasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbLokasi.DataSource = this.lokasiBukuBindingSource;
            this.cbLokasi.DisplayMember = "Lokasi";
            this.cbLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLokasi.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbLokasi.FormattingEnabled = true;
            this.cbLokasi.Location = new System.Drawing.Point(399, 187);
            this.cbLokasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLokasi.Name = "cbLokasi";
            this.cbLokasi.Size = new System.Drawing.Size(280, 21);
            this.cbLokasi.TabIndex = 61;
            this.cbLokasi.ValueMember = "ID";
            // 
            // txtharga
            // 
            this.txtharga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtharga.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtharga.Location = new System.Drawing.Point(431, 240);
            this.txtharga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtharga.Multiline = true;
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(249, 26);
            this.txtharga.TabIndex = 64;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(396, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Harga Buku";
            // 
            // txtJumlah
            // 
            this.txtJumlah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtJumlah.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtJumlah.Location = new System.Drawing.Point(399, 296);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJumlah.Multiline = true;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(280, 28);
            this.txtJumlah.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(396, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Jumlah Buku";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 30;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(399, 413);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 22);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "  Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambah.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTambah.IconColor = System.Drawing.Color.White;
            this.btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTambah.IconSize = 30;
            this.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.Location = new System.Drawing.Point(266, 413);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(91, 22);
            this.btnTambah.TabIndex = 67;
            this.btnTambah.Text = " Tambah";
            this.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(397, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 18);
            this.label11.TabIndex = 92;
            this.label11.Text = "Rp.";
            // 
            // gELibraryDataSet1
            // 
            this.gELibraryDataSet1.DataSetName = "GELibraryDataSet1";
            this.gELibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriBukuBindingSource
            // 
            this.kategoriBukuBindingSource.DataMember = "Kategori_Buku";
            this.kategoriBukuBindingSource.DataSource = this.gELibraryDataSet1;
            // 
            // kategori_BukuTableAdapter
            // 
            this.kategori_BukuTableAdapter.ClearBeforeFill = true;
            // 
            // penerbitBukuBindingSource
            // 
            this.penerbitBukuBindingSource.DataMember = "Penerbit_Buku";
            this.penerbitBukuBindingSource.DataSource = this.gELibraryDataSet1;
            // 
            // penerbit_BukuTableAdapter
            // 
            this.penerbit_BukuTableAdapter.ClearBeforeFill = true;
            // 
            // lokasiBukuBindingSource
            // 
            this.lokasiBukuBindingSource.DataMember = "Lokasi_Buku";
            this.lokasiBukuBindingSource.DataSource = this.gELibraryDataSet1;
            // 
            // lokasi_BukuTableAdapter
            // 
            this.lokasi_BukuTableAdapter.ClearBeforeFill = true;
            // 
            // AddBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(739, 454);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbLokasi);
            this.Controls.Add(this.txtTahunTerbit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPenerbit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBuku";
            this.Load += new System.EventHandler(this.AddBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gELibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penerbitBukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokasiBukuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdd;
        private CharTextBox txtPengarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPenerbit;
        private System.Windows.Forms.Label label6;
        private numericTextbox txtTahunTerbit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLokasi;
        private numericTextbox txtharga;
        private System.Windows.Forms.Label label9;
        private numericTextbox txtJumlah;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnTambah;
        private System.Windows.Forms.Label label11;
        private GELibraryDataSet1 gELibraryDataSet1;
        private System.Windows.Forms.BindingSource kategoriBukuBindingSource;
        private GELibraryDataSet1TableAdapters.Kategori_BukuTableAdapter kategori_BukuTableAdapter;
        private System.Windows.Forms.BindingSource penerbitBukuBindingSource;
        private GELibraryDataSet1TableAdapters.Penerbit_BukuTableAdapter penerbit_BukuTableAdapter;
        private System.Windows.Forms.BindingSource lokasiBukuBindingSource;
        private GELibraryDataSet1TableAdapters.Lokasi_BukuTableAdapter lokasi_BukuTableAdapter;
    }
}