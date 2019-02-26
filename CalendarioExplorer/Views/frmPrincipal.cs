using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CalendarioExplorer.Entities;

namespace CalendarioExplorer.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
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
            string chave, matrizes, materiais, caminhoPrincipal, caminhoOrigem;
            //Definindo os caminhos aserem utilizados:
            if (!File.Exists("D:/SERVER/unlockCalendar.yle"))
            {
                chave = "\\SERVER/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA/clEx/unlockCalendar.yle";
                matrizes = "\\SERVER/MATRIZES";
                materiais = "\\server/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA";
                caminhoPrincipal = "\\SERVER/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA/ORIGAMI COHAB/ANO ";
                caminhoOrigem = "\\SERVER/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA/ORIGAMI COHAB/ANO ";
            }
            else
            {
                chave = "D:/SERVER/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA/clEx/unlockCalendar.yle";
                matrizes = "D:/SERVER/MATRIZES";
                materiais = "D:/server/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA";
                caminhoPrincipal = "D:/SERVER/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA/ORIGAMI COHAB/ANO ";
                caminhoOrigem = "D:/SERVER/MATERIAIS A PRODUZIR_USO OBRIGATORIO DESTA PASTA/ORIGAMI COHAB/ANO ";
            }

            Caminhos caminhos = new Caminhos(chave, matrizes, materiais, caminhoPrincipal, caminhoOrigem);
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
