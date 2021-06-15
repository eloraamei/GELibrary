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
    public partial class EditJabatan : Form
    {
        MasterJabatan jabatan;

        public EditJabatan(MasterJabatan masterJabatan)
        {
            InitializeComponent();
            jabatan = masterJabatan;
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
                        if (txtPosisi.Text == "" || txtGaji.Text == "")
                        {
                            MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPosisi.Select();
                        }
                        else
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                            SqlConnection connection = new SqlConnection(connectionString);

                            SqlCommand update = new SqlCommand("sp_UpdateJabatan", connection);
                            update.CommandType = CommandType.StoredProcedure;

                            update.Parameters.AddWithValue("ID_Jabatan", txtID.Text);
                            update.Parameters.AddWithValue("Posisi", txtPosisi.Text);
                            update.Parameters.AddWithValue("Gaji", txtGaji.Text);

                            try
                            {
                                connection.Open();
                                update.ExecuteNonQuery();
                                MessageBox.Show("Ubah Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                jabatan.loadData();

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
            txtPosisi.Clear();
            txtGaji.Clear();
        }

        private void txtGaji_TextChanged(object sender, EventArgs e)
        {
            if (txtGaji.Text == "")
            {
                return;
            }
            else
            {
                txtGaji.Text = string.Format("{0:n0}", double.Parse(txtGaji.Text));
                txtGaji.SelectionStart = txtGaji.Text.Length;
            }
        }
    }
}
