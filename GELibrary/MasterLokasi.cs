﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GELibrary
{
    public partial class MasterLokasi : Form
    {
        private Form currentChildForm;
        string _id, _lokasi;

        public MasterLokasi()
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
            OpenChildForm(new AddLokasi());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection con = new SqlConnection(connectionString);
            string select = "SELECT * from Lokasi_Buku";
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection com = new SqlConnection(connectionString);
            SqlDataAdapter da;
            DataTable dt;
            com.Open();
            da = new SqlDataAdapter("SELECT * FROM Lokasi_Buku WHERE ID LIKE'" + this.txtCari.Text + "%'", com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            com.Close();
        }

        public static void hapus(string id)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand delete = new SqlCommand("sp_DeleteLokasiBuku", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("@ID", id);

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

        private void MasterLokasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Lokasi_Buku' table. You can move, or remove it, as needed.
            this.lokasi_BukuTableAdapter1.Fill(this.gELibraryDataSet1.Lokasi_Buku);
            // TODO: This line of code loads data into the 'gELibraryDataSet.Lokasi_Buku' table. You can move, or remove it, as needed.
            //this.lokasi_BukuTableAdapter.Fill(this.gELibraryDataSet.Lokasi_Buku);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[0, i].Value.ToString();
            _lokasi = dataGridView1[1, i].Value.ToString();
        }
   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                EditLokasi editLokasi = new EditLokasi(this);
                editLokasi.txtID.Enabled = false;
                editLokasi.txtID.Text = _id;
                editLokasi.txtLokasi.Text = _lokasi;

                editLokasi.Show();
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
    }
}
