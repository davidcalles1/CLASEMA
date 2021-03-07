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
    }
    
}
