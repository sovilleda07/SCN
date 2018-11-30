using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;


namespace Notas1.Clases
{
    class Registro
    {
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public int Alumnos_id { get; set; }
        public int Clases_codigo { get; set; }
        public int Periodos_codigo { get; set; }

    }
}
