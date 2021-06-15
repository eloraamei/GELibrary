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
    public partial class EditLokasi : Form
    {
        MasterLokasi Lokasi;
        public EditLokasi(MasterLokasi masterLokasi)
        {
            InitializeComponent();
            Lokasi = masterLokasi;
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


        private void EditLokasi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                        if (txtLokasi.Text == "")
                        {
                            MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtLokasi.Select();
                        }
                        else
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                            SqlConnection connection = new SqlConnection(connectionString);

                            SqlCommand update = new SqlCommand("sp_UpdateLokasiBuku", connection);
                            update.CommandType = CommandType.StoredProcedure;

                            update.Parameters.AddWithValue("ID", txtID.Text);
                            update.Parameters.AddWithValue("Lokasi", txtLokasi.Text);

                            try
                            {
                                connection.Open();
                                update.ExecuteNonQuery();
                                MessageBox.Show("Ubah Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Lokasi.loadData();

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
            txtLokasi.Clear();
        }
    }
}
