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
        public int acceso(Login log)
        {
            int estado = 0;
            if (log.Usuario.Equals("nelson") && log.Password.Equals("1234"))
            {
                estado = 1;
            }
            return estado;
        }
    }
}
