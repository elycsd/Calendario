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
            frmCalendario newMDICalendario = new frmCalendario();
            newMDICalendario.MdiParent = this;
            newMDICalendario.WindowState = FormWindowState.Maximized;
            newMDICalendario.Show();
        }
        private void CloseForms()
        {
            foreach (Form mdiChild in MdiChildren)
            {
                mdiChild.Close();
            }
        }
    }
}
