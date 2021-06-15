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
    public partial class EditPegawai : Form
    {

        public string jenisKelamin = "";
        MasterPegawai pegawai;

        public EditPegawai(MasterPegawai masterPegawai)
        {
            InitializeComponent();
            pegawai = masterPegawai;
        }

        //drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


    

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
                        if (txtNama.Text == "" || jenisKelamin == "" || txtUsername.Text == "" || txtPassword.Text == "" || cbJabatan.SelectedValue == "")
                        {
                            MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNama.Select();
                        }
                        else
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                            SqlConnection connection = new SqlConnection(connectionString);

                            SqlCommand update = new SqlCommand("sp_UpdatePegawai", connection);
                            update.CommandType = CommandType.StoredProcedure;

                            update.Parameters.AddWithValue("@ID", txtID.Text);
                            update.Parameters.AddWithValue("@Nama", txtNama.Text);
                            update.Parameters.AddWithValue("@jeniskelamin", jenisKelamin);
                            update.Parameters.AddWithValue("@Username", txtUsername.Text);
                            update.Parameters.AddWithValue("@Password", txtPassword.Text);
                            update.Parameters.AddWithValue("@ID_Jabatan", cbJabatan.SelectedValue);

                            try
                            {
                                connection.Open();
                                update.ExecuteNonQuery();
                                MessageBox.Show("Ubah Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                pegawai.loadData();

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
            txtNama.Clear();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            txtUsername.Clear();
            txtPassword.Clear();
            cbJabatan.SelectedIndex = -1;
        }

        private void EditPegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gELibraryDataSet1.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.gELibraryDataSet1.Jabatan);

        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked)
            {
                jenisKelamin = "Laki-Laki";
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked)
            {
                jenisKelamin = "Perempuan";
            }
        }
    }
}
