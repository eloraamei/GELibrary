using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace GELibrary
{
    public partial class AddBuku : Form
    {
        public AddBuku()
        {
            InitializeComponent();
            cbKategori.SelectedIndex = -1;
            cbPenerbit.SelectedIndex = -1;
            cbLokasi.SelectedIndex = -1;
            string query = "SELECT TOP 1 ID_Buku FROM Buku ORDER BY ID_Buku DESC";
            txtID.Text = autogenerateID("BK", query);
            txtID.Enabled = false;
        }

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public string autogenerateID(string firstText, string query)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(3, '0');
            return result;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtJudul.Text == "" || cbKategori.SelectedValue == "" || txtPengarang.Text == "" || cbPenerbit.SelectedValue == "" || 
                txtTahunTerbit.Text == "" || cbLokasi.SelectedValue == "" || txtharga.Text == "" || txtJumlah.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJudul.Select();
            }
            else
            {
                try
                {
                    string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    com.CommandText = "sp_InputBuku";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@ID_Buku", txtID.Text);
                    com.Parameters.AddWithValue("@Judul", txtJudul.Text);
                    com.Parameters.AddWithValue("@ID_Kategori", cbKategori.SelectedValue);
                    com.Parameters.AddWithValue("@Pengarang", txtPengarang.Text);
                    com.Parameters.AddWithValue("@ID_Penerbit", cbPenerbit.Text);
                    com.Parameters.AddWithValue("@TahunTerbit", txtTahunTerbit.Text);
                    com.Parameters.AddWithValue("@ID_Lokasi", cbLokasi.SelectedValue);
                    com.Parameters.AddWithValue("@Harga", txtharga.Text);
                    com.Parameters.AddWithValue("@Jumlah", txtJumlah.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Input Data Berhasil");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Input Data Gagal");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        public void Clear()
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

            string query = "SELECT TOP 1 ID_Buku FROM Buku ORDER BY ID_Buku DESC";
            txtID.Text = autogenerateID("BK", query);
            txtID.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            if (txtharga.Text == "")
            {
                return;
            }
            else
            {
                txtharga.Text = string.Format("{0:n0}", double.Parse(txtharga.Text));
                txtharga.SelectionStart = txtharga.Text.Length;
            }
        }

        private void AddBuku_Load(object sender, EventArgs e)
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
