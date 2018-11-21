using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Notas1.Clases
{
    class Clases
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int credito { get; set; }
        public int habilitado { get; set; }
        public int Carrera_codigo { get; set; }
    }
}
