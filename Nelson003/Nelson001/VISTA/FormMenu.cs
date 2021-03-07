using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelson001.VISTA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void clikcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcerca = new FrmAcercaDe();
            frmAcerca.MdiParent = this;
            frmAcerca.Show();
        }

        private void cLICKPARAACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDeusuario frmLista = new FrmListaDeusuario();
            frmLista.MdiParent = this;
            frmLista.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public string usuarioEstado;
        private void FormMenu_Load(object sender, EventArgs e)
        {
            label1.Text = usuarioEstado;
        }

        private void sumasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmO = new FrmOperaciones();
            frmO.MdiParent = this;
            frmO.btnRestaa.Enabled = false;

            frmO.Show();

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmO = new FrmOperaciones();
            frmO.MdiParent = this;
            frmO.btnSuma.Enabled = false;

            frmO.Show();
        }
    }
    
}
