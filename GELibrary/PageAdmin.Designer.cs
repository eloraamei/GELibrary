namespace GELibrary
{
    partial class PageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAdmin));
            this.paneltitleBar = new System.Windows.Forms.Panel();
            this.iconMin = new FontAwesome.Sharp.IconPictureBox();
            this.iconMax = new FontAwesome.Sharp.IconPictureBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildform = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDenda = new FontAwesome.Sharp.IconButton();
            this.btnPenerbit = new FontAwesome.Sharp.IconButton();
            this.btnLokasi = new FontAwesome.Sharp.IconButton();
            this.btnKategori = new FontAwesome.Sharp.IconButton();
            this.btnBuku = new FontAwesome.Sharp.IconButton();
            this.btnMember = new FontAwesome.Sharp.IconButton();
            this.btnJabatan = new FontAwesome.Sharp.IconButton();
            this.btnPegawai = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.paneltitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildform)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitleBar
            // 
            this.paneltitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.paneltitleBar.Controls.Add(this.iconMin);
            this.paneltitleBar.Controls.Add(this.iconMax);
            this.paneltitleBar.Controls.Add(this.iconClose);
            this.paneltitleBar.Controls.Add(this.iconButtonLogOut);
            this.paneltitleBar.Controls.Add(this.lblTitleChildForm);
            this.paneltitleBar.Controls.Add(this.iconCurrentChildform);
            this.paneltitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitleBar.Location = new System.Drawing.Point(220, 0);
            this.paneltitleBar.Name = "paneltitleBar";
            this.paneltitleBar.Size = new System.Drawing.Size(1010, 75);
            this.paneltitleBar.TabIndex = 1;
            this.paneltitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitleBar_Paint);
            this.paneltitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitleBar_MouseDown);
            // 
            // iconMin
            // 
            this.iconMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMin.BackColor = System.Drawing.Color.Transparent;
            this.iconMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconMin.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMin.Location = new System.Drawing.Point(919, 0);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(32, 32);
            this.iconMin.TabIndex = 5;
            this.iconMin.TabStop = false;
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // iconMax
            // 
            this.iconMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMax.BackColor = System.Drawing.Color.Transparent;
            this.iconMax.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMax.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMax.Location = new System.Drawing.Point(949, 0);
            this.iconMax.Name = "iconMax";
            this.iconMax.Size = new System.Drawing.Size(32, 32);
            this.iconMax.TabIndex = 4;
            this.iconMax.TabStop = false;
            this.iconMax.Click += new System.EventHandler(this.iconMax_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(978, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(32, 32);
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonLogOut.IconColor = System.Drawing.Color.HotPink;
            this.iconButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogOut.IconSize = 32;
            this.iconButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogOut.Location = new System.Drawing.Point(771, 0);
            this.iconButtonLogOut.Name = "iconButtonLogOut";
            this.iconButtonLogOut.Size = new System.Drawing.Size(142, 75);
            this.iconButtonLogOut.TabIndex = 2;
            this.iconButtonLogOut.Text = "Log Out";
            this.iconButtonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogOut.UseVisualStyleBackColor = true;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(56, 29);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(69, 23);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildform
            // 
            this.iconCurrentChildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildform.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildform.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildform.Location = new System.Drawing.Point(23, 26);
            this.iconCurrentChildform.Name = "iconCurrentChildform";
            this.iconCurrentChildform.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildform.TabIndex = 0;
            this.iconCurrentChildform.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1010, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnDenda);
            this.panelMenu.Controls.Add(this.btnPenerbit);
            this.panelMenu.Controls.Add(this.btnLokasi);
            this.panelMenu.Controls.Add(this.btnKategori);
            this.panelMenu.Controls.Add(this.btnBuku);
            this.panelMenu.Controls.Add(this.btnMember);
            this.panelMenu.Controls.Add(this.btnJabatan);
            this.panelMenu.Controls.Add(this.btnPegawai);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 717);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDenda
            // 
            this.btnDenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDenda.FlatAppearance.BorderSize = 0;
            this.btnDenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDenda.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnDenda.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDenda.IconSize = 30;
            this.btnDenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDenda.Location = new System.Drawing.Point(0, 620);
            this.btnDenda.Name = "btnDenda";
            this.btnDenda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDenda.Size = new System.Drawing.Size(220, 60);
            this.btnDenda.TabIndex = 9;
            this.btnDenda.Text = "Denda";
            this.btnDenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDenda.UseVisualStyleBackColor = true;
            this.btnDenda.Click += new System.EventHandler(this.btnDenda_Click);
            // 
            // btnPenerbit
            // 
            this.btnPenerbit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPenerbit.FlatAppearance.BorderSize = 0;
            this.btnPenerbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenerbit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenerbit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPenerbit.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.btnPenerbit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPenerbit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPenerbit.IconSize = 30;
            this.btnPenerbit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenerbit.Location = new System.Drawing.Point(0, 560);
            this.btnPenerbit.Name = "btnPenerbit";
            this.btnPenerbit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPenerbit.Size = new System.Drawing.Size(220, 60);
            this.btnPenerbit.TabIndex = 8;
            this.btnPenerbit.Text = "Penerbit";
            this.btnPenerbit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenerbit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPenerbit.UseVisualStyleBackColor = true;
            this.btnPenerbit.Click += new System.EventHandler(this.btnPenerbit_Click);
            // 
            // btnLokasi
            // 
            this.btnLokasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLokasi.FlatAppearance.BorderSize = 0;
            this.btnLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLokasi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLokasi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLokasi.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.btnLokasi.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLokasi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLokasi.IconSize = 30;
            this.btnLokasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLokasi.Location = new System.Drawing.Point(0, 500);
            this.btnLokasi.Name = "btnLokasi";
            this.btnLokasi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLokasi.Size = new System.Drawing.Size(220, 60);
            this.btnLokasi.TabIndex = 7;
            this.btnLokasi.Text = "Lokasi Buku";
            this.btnLokasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLokasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLokasi.UseVisualStyleBackColor = true;
            this.btnLokasi.Click += new System.EventHandler(this.btnLokasi_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKategori.FlatAppearance.BorderSize = 0;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKategori.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnKategori.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKategori.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKategori.IconSize = 30;
            this.btnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategori.Location = new System.Drawing.Point(0, 440);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKategori.Size = new System.Drawing.Size(220, 60);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori Buku";
            this.btnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuku.FlatAppearance.BorderSize = 0;
            this.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuku.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuku.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuku.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBuku.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBuku.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuku.IconSize = 30;
            this.btnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuku.Location = new System.Drawing.Point(0, 380);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuku.Size = new System.Drawing.Size(220, 60);
            this.btnBuku.TabIndex = 5;
            this.btnBuku.Text = "Buku";
            this.btnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuku.UseVisualStyleBackColor = true;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMember.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnMember.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMember.IconSize = 30;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 320);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMember.Size = new System.Drawing.Size(220, 60);
            this.btnMember.TabIndex = 4;
            this.btnMember.Text = "Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnJabatan
            // 
            this.btnJabatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJabatan.FlatAppearance.BorderSize = 0;
            this.btnJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJabatan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJabatan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJabatan.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnJabatan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnJabatan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJabatan.IconSize = 30;
            this.btnJabatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJabatan.Location = new System.Drawing.Point(0, 260);
            this.btnJabatan.Name = "btnJabatan";
            this.btnJabatan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnJabatan.Size = new System.Drawing.Size(220, 60);
            this.btnJabatan.TabIndex = 3;
            this.btnJabatan.Text = "Jabatan";
            this.btnJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJabatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJabatan.UseVisualStyleBackColor = true;
            this.btnJabatan.Click += new System.EventHandler(this.btnJabatan_Click);
            // 
            // btnPegawai
            // 
            this.btnPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPegawai.FlatAppearance.BorderSize = 0;
            this.btnPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPegawai.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegawai.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPegawai.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPegawai.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPegawai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPegawai.IconSize = 30;
            this.btnPegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPegawai.Location = new System.Drawing.Point(0, 200);
            this.btnPegawai.Name = "btnPegawai";
            this.btnPegawai.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPegawai.Size = new System.Drawing.Size(220, 60);
            this.btnPegawai.TabIndex = 2;
            this.btnPegawai.Text = "Pegawai";
            this.btnPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPegawai.UseVisualStyleBackColor = true;
            this.btnPegawai.Click += new System.EventHandler(this.btnPegawai_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 137);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1010, 633);
            this.panelDesktop.TabIndex = 3;
            // 
            // PageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 717);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.paneltitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "PageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halaman Admin";
            this.paneltitleBar.ResumeLayout(false);
            this.paneltitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildform)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneltitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildform;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private FontAwesome.Sharp.IconPictureBox iconMax;
        private FontAwesome.Sharp.IconPictureBox iconMin;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDenda;
        private FontAwesome.Sharp.IconButton btnPenerbit;
        private FontAwesome.Sharp.IconButton btnLokasi;
        private FontAwesome.Sharp.IconButton btnKategori;
        private FontAwesome.Sharp.IconButton btnBuku;
        private FontAwesome.Sharp.IconButton btnMember;
        private FontAwesome.Sharp.IconButton btnJabatan;
        private FontAwesome.Sharp.IconButton btnPegawai;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

