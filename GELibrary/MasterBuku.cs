using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GELibrary
{
    public partial class MasterBuku : Form
    {
        private Form currentChildForm;
        string _id, _judul, _kategori, _pengarang, _penerbit, _tahunterbit, _lokasi, _harga, _jumlah;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[0, i].Value.ToString();
            _judul = dataGridView1[1, i].Value.ToString();
            _kategori = dataGridView1[2, i].Value.ToString();
            _pengarang = dataGridView1[3, i].Value.ToString();
            _penerbit = dataGridView1[4, i].Value.ToString();
            _tahunterbit = dataGridView1[5, i].Value.ToString();
            _lokasi = dataGridView1[6, i].Value.ToString();
            _harga = dataGridView1[7, i].Value.ToString();
            _jumlah = dataGridView1[8, i].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection com = new SqlConnection(connectionString);
            SqlDataAdapter da;
            DataTable dt;
            com.Open();
            da = new SqlDataAdapter("SELECT * FROM Buku WHERE ID_Buku LIKE'" + this.txtCari.Text + "%'  OR Judul LIKE'" + this.txtCari.Text + "%'", com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            com.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                EditBuku editBuku = new EditBuku(this);
                editBuku.txtID.Enabled = false;
                editBuku.txtID.Text = _id;
                editBuku.txtJudul.Text = _judul;
                editBuku.cbKategori.SelectedValue = _kategori;
                editBuku.txtPengarang.Text = _pengarang;
                editBuku.cbPenerbit.SelectedValue = _penerbit;
                editBuku.txtTahunTerbit.Text = _tahunterbit;
                editBuku.cbLokasi.SelectedValue = _lokasi;
                editBuku.txtharga.Text = _harga;
                editBuku.txtJumlah.Text = _jumlah;

                editBuku.Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                DialogResult dr = MessageBox.Show("Yakin akan menghapus data?", "Validasi Hapus", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        {
                            try
                            {
                                hapus(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                                loadData();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error : " + ex.Message);
                            }
                        }
                        break;
                }
            }
        }

        public MasterBuku()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddBuku());
        }

        private void MasterBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.gELibraryDataSet1.Buku);

        }

        public void loadData()
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection con = new SqlConnection(connectionString);
            string select = "SELECT * from Buku";
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void hapus(string id)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand delete = new SqlCommand("sp_DeleteBuku", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("@ID_Buku", id);

            connection.Open();
            int result = Convert.ToInt32(delete.ExecuteNonQuery());
            connection.Close();

            if (result != 0)
            {
                MessageBox.Show("Hapus Data Berhasil");

            }
            else
            {
                MessageBox.Show("Hapus Data Gagal");
            }
        }
    }
}
