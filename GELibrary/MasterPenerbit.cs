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
    public partial class MasterPenerbit : Form
    {
        private Form currentChildForm;
        string _id, _nama;

        public MasterPenerbit()
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
            OpenChildForm(new AddPenerbit());
        }

        private void MasterPenerbit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Penerbit_Buku' table. You can move, or remove it, as needed.
            this.penerbit_BukuTableAdapter1.Fill(this.gELibraryDataSet1.Penerbit_Buku);
            // TODO: This line of code loads data into the 'gELibraryDataSet.Penerbit_Buku' table. You can move, or remove it, as needed.
            //this.penerbit_BukuTableAdapter.Fill(this.gELibraryDataSet.Penerbit_Buku);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        
        public void loadData()
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection con = new SqlConnection(connectionString);
            string select = "SELECT * from Penerbit_Buku";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                EditPenerbit editPenerbit = new EditPenerbit(this);
                editPenerbit.txtID.Enabled = false;
                editPenerbit.txtID.Text = _id;
                editPenerbit.txtNama.Text = _nama;

                editPenerbit.Show();
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection com = new SqlConnection(connectionString);
            SqlDataAdapter da;
            DataTable dt;
            com.Open();
            da = new SqlDataAdapter("SELECT * FROM Penerbit_Buku WHERE Nama LIKE'" + this.txtCari.Text + "%'  OR ID LIKE'" + this.txtCari.Text + "%'", com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            com.Close();

        }

        public static void hapus(string id)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand delete = new SqlCommand("sp_DeletePenerbitBuku", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("@ID",id);

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[0, i].Value.ToString();
            _nama = dataGridView1[1, i].Value.ToString();
        }
    }
}
