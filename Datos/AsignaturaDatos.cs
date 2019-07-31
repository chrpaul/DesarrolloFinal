using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public static class AsignaturaDatos
    {
        public static string DevuelveAsignaturaCarrera(string carrera)
        {
            return " SELECT     asignatura FROM dbo.Asignaturas INNER JOIN dbo.Carrera ON dbo.Asignaturas.id_carrera = dbo.Carrera.id WHERE dbo.Carrera.nombre = '" + carrera + "'";
        }
        public static string DevuelveNivelAsignatura(string asignatura)
        {
            return @" SELECT        dbo.Nivel.nivel
FROM            dbo.Asignaturas INNER JOIN
                         dbo.Nivel ON dbo.Asignaturas.id_nivel = dbo.Nivel.id
WHERE        dbo.Asignaturas.asignatura = '" + asignatura + "'";
        }
        public static string DevuelveaCarrera()
        {
            return "SELECT id,  nombre from Carrera ";
        }
        public static string DevuelveaCarreraporEstudiante(string cedula)
        {
            return @"SELECT        dbo.Carrera.nombre
                        FROM dbo.Carrera INNER JOIN
                         dbo.Estudiante ON dbo.Carrera.id = dbo.Estudiante.id_carrera
                        WHERE(dbo.Estudiante.cedula =  ('" + cedula + "%'))";
        }
        public static string obtenerCarreraEs(string cedula)
        {
            
               return @"SELECT        dbo.Carrera.nombre
                        FROM dbo.Carrera INNER JOIN
                         dbo.Estudiante ON dbo.Carrera.id = dbo.Estudiante.id_carrera
                        WHERE dbo.Estudiante.cedula = '" + cedula + "'";


        }
    }
}
