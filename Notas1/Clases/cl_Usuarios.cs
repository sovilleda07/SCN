using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Notas1.Clases
{
    class cl_Usuarios
    {
        // CREACIÓN DE PROPIEDADES PARA LA CLASE
        public string usuario { get; set; }
        public string clave { get; set; }
        public int habilitado { get; set; }

        //CONSTRUCTOR
        //Verificar si necesita más constructores
        public cl_Usuarios() { }

        public cl_Usuarios(string usuario, string clave) { }

        public void ObtenerUsuario(string usuarioLogin, string clave)
        {

        }


    }
}
