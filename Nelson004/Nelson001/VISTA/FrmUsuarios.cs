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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {
                
                UserList userList = db.UserList.Where(x => x.id == 6).Select(x => x).FirstOrDefault();

                userList.NombreUsuario = "Juan";
                db.SaveChanges();
            }




        }
    }
}
