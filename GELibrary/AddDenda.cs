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
    public partial class AddDenda : Form
    {
        public AddDenda()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 ID_Denda FROM Denda ORDER BY ID_Denda DESC";
            txtID.Text = autogenerateID("DN", query);
            txtID.Enabled = false;
            txtDeskripsi.Select();
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

        public void Clear()
        {
            txtID.Clear();
            txtDeskripsi.Clear();
            txtBiaya.Clear();
            txtDeskripsi.Select();

            string query = "SELECT TOP 1 ID_Denda FROM Denda ORDER BY ID_Denda DESC";
            txtID.Text = autogenerateID("DN", query);
            txtID.Enabled = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtBiaya.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show("Isi seluruh data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeskripsi.Select();
            }
            else
            {
                try
                {
                    string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    com.CommandText = "sp_InputDenda";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@ID_Denda", txtID.Text);
                    com.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                    com.Parameters.AddWithValue("@Biaya", txtBiaya.Text);


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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtBiaya_TextChanged(object sender, EventArgs e)
        {
            if (txtBiaya.Text == "")
            {
                return;
            }
            else
            {
                txtBiaya.Text = string.Format("{0:n0}", double.Parse(txtBiaya.Text));
                txtBiaya.SelectionStart = txtBiaya.Text.Length;
            }
        }


    }
    
    
}
