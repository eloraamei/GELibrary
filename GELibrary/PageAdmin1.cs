using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace GELibrary
{
    public partial class PageAdmin1 : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel leftBorderBtn2;
        private Panel leftBorderBtn3;
        private Form currentChildForm;

        public PageAdmin1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn2 = new Panel();
            leftBorderBtn3 = new Panel();

            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            leftBorderBtn2.Size = new Size(7, 60);
            panelPegawai.Controls.Add(leftBorderBtn2);

            leftBorderBtn3.Size = new Size(7, 60);
            panelBuku.Controls.Add(leftBorderBtn3);
            customizeDesign();


            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void customizeDesign()
        {
            panelPegawai.Visible = false;
            panelBuku.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPegawai.Visible == true)
                panelPegawai.Visible = false;
            if (panelBuku.Visible == true)
                panelBuku.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }



        //Structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
            public static Color color5 = Color.FromArgb(143, 227, 173);
            public static Color color6 = Color.FromArgb(221, 160, 221);
            public static Color color7 = Color.FromArgb(25, 176, 188);
            public static Color color8 = Color.FromArgb(253, 253, 150);
            public static Color color9 = Color.FromArgb(239, 51, 64);
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();


                //Icon current Child Form
                iconCurrentChildform.IconChar = currentBtn.IconChar;
                iconCurrentChildform.IconColor = color;

            }
        }

        private void ActivateButton2(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                //left border button
                leftBorderBtn2.BackColor = color;
                leftBorderBtn2.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn2.Visible = true;
                leftBorderBtn2.BringToFront();


                //Icon current Child Form
                iconCurrentChildform.IconChar = currentBtn.IconChar;
                iconCurrentChildform.IconColor = color;

            }
        }

        private void ActivateButton3(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                //left border button
                leftBorderBtn3.BackColor = color;
                leftBorderBtn3.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn3.Visible = true;
                leftBorderBtn3.BringToFront();


                //Icon current Child Form
                iconCurrentChildform.IconChar = currentBtn.IconChar;
                iconCurrentChildform.IconColor = color;

            }
        }
        private void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitleChildForm.Text = childform.Text;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
     
        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildform.IconChar = IconChar.Home;
            iconCurrentChildform.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
        }

        private void btnKelolaPegawai_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPegawai);
            ActivateButton(sender, RGBColor.color2);

        }

        private void btnKelolaBuku_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBuku);
            ActivateButton(sender, RGBColor.color4);

        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            ActivateButton2(sender, RGBColor.color5);
            OpenChildForm(new MasterPegawai());
        }

        private void btnJabatan_Click(object sender, EventArgs e)
        {
            ActivateButton2(sender, RGBColor.color6);
            OpenChildForm(new MasterJabatan());
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new MasterMember());
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            ActivateButton3(sender, RGBColor.color1);
            OpenChildForm(new MasterBuku());
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            ActivateButton3(sender, RGBColor.color2);
            OpenChildForm(new MasterKategori());
        }

        private void btnLokasi_Click(object sender, EventArgs e)
        {
            ActivateButton3(sender, RGBColor.color3);
            OpenChildForm(new MasterLokasi());
        }

        private void btnPenerbit_Click(object sender, EventArgs e)
        {
            ActivateButton3(sender, RGBColor.color6);
            OpenChildForm(new MasterPenerbit());
        }

        private void btnDenda_Click(object sender, EventArgs e)
        {
            ActivateButton3(sender, RGBColor.color7);
            OpenChildForm(new MasterDenda());
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void paneltitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e)
        {
            PageLogin pageLogin = new PageLogin();
            pageLogin.Show();
            this.Close();
        }
    }
}


