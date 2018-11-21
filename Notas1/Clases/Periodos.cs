using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Notas1.Clases
{
    class Periodos
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public int anio { get; set; }
        public int periodo { get; set; }
        public int habilitado { get; set; }
    }
}
