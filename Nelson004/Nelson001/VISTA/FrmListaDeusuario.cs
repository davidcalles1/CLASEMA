using Nelson001.DAO;
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
    public partial class FrmListaDeusuario : Form
    {
        public FrmListaDeusuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaDeusuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuario clsLista = new ClsListaUsuario();

            foreach (var iteracion in clsLista.user)
            {
                dataGridView1.Rows.Add(iteracion.ToString());
            }
        }
    }
}
