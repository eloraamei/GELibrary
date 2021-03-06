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
    public partial class AddLokasi : Form
    {
        public AddLokasi()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 ID FROM Lokasi_Buku ORDER BY ID DESC";
            txtID.Text = autogenerateID("LB", query);
            txtID.Enabled = false;
            txtLokasi.Select();
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtLokasi.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLokasi.Select();
            }
            else
            {
                try
                {
                    string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    com.CommandText = "sp_InputLokasiBuku";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@ID", txtID.Text);
                    com.Parameters.AddWithValue("@Lokasi", txtLokasi.Text);


                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Input Data Berhasil");
                        MasterPenerbit masterPenerbit = new MasterPenerbit();
                        masterPenerbit.loadData();
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
            txtLokasi.Clear();

            string query = "SELECT TOP 1 ID FROM Lokasi_Buku ORDER BY ID DESC";
            txtID.Text = autogenerateID("LB", query);
            txtID.Enabled = false;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
