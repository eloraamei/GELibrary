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
using System.Runtime.InteropServices;

namespace GELibrary
{
    public partial class PageLogin : Form
    {
        private Form currentChildForm;

        public PageLogin()
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

        //drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Silahkan Masukkan Username Anda!");
                txtUsername.Select();
            } else if (txtPassword.Text.Equals(""))
                {
                     MessageBox.Show("Silahkan Masukkan Password Anda!");
                     txtPassword.Select();
                }
            else
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = GELibrary";
                string query = "SELECT ID_Jabatan from Pegawai WHERE username = @username and password= @password";
                string returnValue = "";
                SqlConnection connection = new SqlConnection(connectionString);
                {
                    using (SqlCommand sqlcmd = new SqlCommand(query, connection))
                    {
                        sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text;
                        sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;
                        connection.Open();
                        returnValue = (string)sqlcmd.ExecuteScalar();
                    }
                }
                //EDIT to avoid NRE 
                if (String.IsNullOrEmpty(returnValue))
                {
                    MessageBox.Show("Username/Password Anda Salah!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Select();
                    return;
                }

                returnValue = returnValue.Trim();
                if (returnValue == "JB001")
                {
                    MessageBox.Show("Selamat datang, Admin!");
                    OpenChildForm(new PageAdmin1());
                }
                else if (returnValue == "JB002")
                {
                    MessageBox.Show("Selamat datang, Pegawai!");
                    OpenChildForm(new PagePegawai());
                }
                else if (returnValue == "JB003")
                {
                    MessageBox.Show("Selamat datang, Kepala Perpustakaan!");
                    OpenChildForm(new PagekepalaPerpus());
                }
            }
        }
     }
}
