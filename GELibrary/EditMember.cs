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
    public partial class EditMember : Form
    {
        public string jenisKelamin = "";
        MasterMember member;

        public EditMember(MasterMember masterMember)
        {
            InitializeComponent();
            member = masterMember;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin akan mengubah data?", "Validasi Edit", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    {
                        if (txtNama.Text == "" || jenisKelamin == "" || txtAlamat.Text == "" || txtTelp.Text == "" || cbStatus.SelectedValue == "")
                        {
                            MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNama.Select();
                        }
                        else
                        {
                            string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                            SqlConnection connection = new SqlConnection(connectionString);

                            SqlCommand update = new SqlCommand("sp_UpdateMember", connection);
                            update.CommandType = CommandType.StoredProcedure;

                            update.Parameters.AddWithValue("@ID", txtID.Text);
                            update.Parameters.AddWithValue("@Nama", txtNama.Text);
                            update.Parameters.AddWithValue("@JenisKelamin", jenisKelamin);
                            update.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                            update.Parameters.AddWithValue("@Telepon", txtTelp.Text);
                            update.Parameters.AddWithValue("@Status", cbStatus.SelectedValue);

                            try
                            {
                                connection.Open();
                                update.ExecuteNonQuery();
                                MessageBox.Show("Ubah Data Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                member.loadData();

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
            txtAlamat.Clear();
            txtTelp.Clear();
            cbStatus.SelectedIndex = -1;
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

        private void txtTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (txtTelp.Text.Length >= 13 && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
