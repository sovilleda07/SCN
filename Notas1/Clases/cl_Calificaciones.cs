using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Notas1.Clases
{
    class cl_Calificaciones
    {
        public int codigo { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double promedio { get; set; }

        public int Registro_codigo { get; set; }
        public DateTime Registro_fecha { get; set; }
        public int Registro_Alumno_id { get; set; }
        public int Registro_Clases_id { get; set; }
        public int Registro_Periodos_codigo { get; set; }


    }
}
