using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class ModalidadDatos
    {
        public static string DevuelveModalidad()
        {
            return "SELECT  * from Modalidad ";
        }
        public static string DevuelvePeriodo()
        {
            return "SELECT  * from PeriodoAcademico ";
        }
        public static string DevuelveFacultad()
        {
            return "SELECT  * from Facultad ";
        }
    }
}
