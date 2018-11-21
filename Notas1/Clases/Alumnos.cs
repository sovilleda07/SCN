using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Notas1.Clases
{
    class Alumnos
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string observaciones { get; set; }
        public int habilitado { get; set; }
        public int carrera_codigo { get; set; }
    }
}
