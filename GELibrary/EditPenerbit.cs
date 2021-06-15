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
    public partial class EditPenerbit : Form
    {
        MasterPenerbit Penerbit;

        public EditPenerbit(MasterPenerbit masterPenerbit)
        {
            InitializeComponent();
            Penerbit = masterPenerbit;
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
                        if (txtNama.Text == "")
                        {
                            MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNama.Select();
                        }
                        else
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                            SqlConnection connection = new SqlConnection(connectionString);

                            SqlCommand update = new SqlCommand("sp_UpdatePenerbitBuku", connection);
                            update.CommandType = CommandType.StoredProcedure;

                            update.Parameters.AddWithValue("ID", txtID.Text);
                            update.Parameters.AddWithValue("Nama", txtNama.Text);

                            try
                            {
                                connection.Open();
                                update.ExecuteNonQuery();
                                MessageBox.Show("Ubah Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Penerbit.loadData();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Unable to updated: " + ex.Message);
                            }
                        }
                    }break;
            }
        }

        public void Clear()
        {
            txtNama.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void EditPenerbit_Load(object sender, EventArgs e)
        {

        }
    }
}
