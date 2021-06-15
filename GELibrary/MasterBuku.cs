using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GELibrary
{
    public partial class MasterBuku : Form
    {
        private Form currentChildForm;

        public MasterBuku()
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
            OpenChildForm(new AddBuku());
        }
    }
}
