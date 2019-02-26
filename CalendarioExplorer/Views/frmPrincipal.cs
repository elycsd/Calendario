using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioExplorer.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmCalendario_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();
            OpenFrmCalendario();
                    }
        private void CloseForms()
        {
            foreach (Form mdiChild in MdiChildren)
            {
                mdiChild.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            OpenFrmCalendario();
        }
        private void OpenFrmCalendario()
        {
            frmCalendario newMDICalendario = new frmCalendario();
            newMDICalendario.MdiParent = this;
            newMDICalendario.WindowState = FormWindowState.Maximized;
            newMDICalendario.Show();
        }

        private void matrizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmMatrizes newMDIMatrizes = new frmMatrizes();
            newMDIMatrizes.MdiParent = this;
            newMDIMatrizes.WindowState = FormWindowState.Maximized;
            newMDIMatrizes.Show();
        }
    }
}
