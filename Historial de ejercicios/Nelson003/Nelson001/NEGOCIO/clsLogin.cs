using Nelson001.DAO;
using Nelson001.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelson001.NEGOCIO
{
    class clsLogin

    {
        ClsListaUsuario clsLista = new ClsListaUsuario();
        public int acceso(Login log)
        {
            //esto es un metodo de acceso 
            int estado = 0;
            for (int i=0; i<clsLista.user.Length; i++) {
            if (log.Usuario.Equals(clsLista.user[i]) && log.Password.Equals(clsLista.password[i]))
            {
                estado = 1;
            }
            }
            return estado;
        }
    }
}
