using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GELibrary
{
    public partial class EditBuku : Form
    {
        MasterBuku buku;

        public EditBuku(MasterBuku masterBuku)
        {
            InitializeComponent();
            buku = masterBuku;
        }

        //drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin akan mengubah data?", "Validasi Edit", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    {
                        if (txtJudul.Text == "" || cbKategori.SelectedValue == "" || txtPengarang.Text == "" || cbPenerbit.SelectedValue == "" ||
                            txtTahunTerbit.Text == "" || cbLokasi.SelectedValue == "" || txtharga.Text == "" || txtJumlah.Text == "")
                        {
                            MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtJudul.Select();
                        }
                        else
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                            SqlConnection connection = new SqlConnection(connectionString);

                            SqlCommand update = new SqlCommand("sp_UpdateBuku", connection);
                            update.CommandType = CommandType.StoredProcedure;

                            update.Parameters.AddWithValue("@ID_Buku", txtID.Text);
                            update.Parameters.AddWithValue("@Judul", txtJudul.Text);
                            update.Parameters.AddWithValue("@ID_Kategori", cbKategori.SelectedValue);
                            update.Parameters.AddWithValue("@Pengarang", txtPengarang.Text);
                            update.Parameters.AddWithValue("@ID_Penerbit", cbPenerbit.Text);
                            update.Parameters.AddWithValue("@TahunTerbit", txtTahunTerbit.Text);
                            update.Parameters.AddWithValue("@ID_Lokasi", cbLokasi.SelectedValue);
                            update.Parameters.AddWithValue("@Harga", txtharga.Text);
                            update.Parameters.AddWithValue("@Jumlah", txtJumlah.Text);

                            try
                            {
                                connection.Open();
                                update.ExecuteNonQuery();
                                MessageBox.Show("Ubah Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                buku.loadData();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unable to updated: " + ex.Message);
                            }
                        }
                    }
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtJudul.Clear();
            cbKategori.SelectedIndex = -1;
            txtPengarang.Clear();
            cbPenerbit.SelectedIndex = -1;
            txtTahunTerbit.Clear();
            cbLokasi.SelectedIndex = -1;
            txtharga.Clear();
            txtJumlah.Clear();
        }

        private void EditBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Lokasi_Buku' table. You can move, or remove it, as needed.
            this.lokasi_BukuTableAdapter.Fill(this.gELibraryDataSet1.Lokasi_Buku);
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Penerbit_Buku' table. You can move, or remove it, as needed.
            this.penerbit_BukuTableAdapter.Fill(this.gELibraryDataSet1.Penerbit_Buku);
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Kategori_Buku' table. You can move, or remove it, as needed.
            this.kategori_BukuTableAdapter.Fill(this.gELibraryDataSet1.Kategori_Buku);

        }
    }
}
