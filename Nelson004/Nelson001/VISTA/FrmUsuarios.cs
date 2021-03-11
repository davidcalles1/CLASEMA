using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nelson001.MODEL;

namespace Nelson001.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            carga();
            Clear();
            

        }
        void Clear()
        {// para borrar los datos ingresados en las cajas de texto 
            txtid.Clear();
            txtNombre.Clear();
            // otra forma de hacer limpiesa de datos en las cajas de texto 
            txtApellido.Text = "";
            txtEdad.Clear();
            txtPass.Clear();
        }
        void carga()

        {
            using (programacionEntities db = new programacionEntities())
            {

                var Lista = db.UserList.ToList();
                foreach (var iteracion in Lista)
                {
                    dtgListaUsuarios.Rows.Add(iteracion.id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   try { 
            using (programacionEntities db = new programacionEntities())
            {
                UserList userList = new UserList();

                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.pass = txtPass.Text;
                db.UserList.Add(userList);
                db.SaveChanges();
                    MessageBox.Show("save");



            }
            } catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            carga();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int eliminar = Convert.ToInt32(txtid.Text);

                    UserList userList = db.UserList.Where(x => x.id == eliminar).Select(x => x).FirstOrDefault(); 
                    //userList = db.UserList.Find(eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();




                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            carga();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(txtid);
                    UserList userList = db.UserList.Where(x => x.id == update).Select(x => x).FirstOrDefault();

                    userList.NombreUsuario = txtNombre.Text;
                    userList.Apellido = txtEdad.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.pass = txtPass.Text;
                    db.SaveChanges();
                }
            } catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }
            carga();
            Clear();






        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();


            txtid.Text = id;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

    }
}
