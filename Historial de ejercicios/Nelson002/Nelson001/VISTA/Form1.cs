using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nelson001.DOMINIO;
using Nelson001.NEGOCIO;
using Nelson001.VISTA;

namespace Nelson001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            clsLogin clsl = new clsLogin();
            int variabledeevaluacion = clsl.acceso(log);

            if (variabledeevaluacion == 1)
            {

                MessageBox.Show("WELCOM");
                FormMenu frm = new FormMenu();
                frm.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("FALSE");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
