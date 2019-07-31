using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public static class EstudianteDatos
    {
        public static string DevuelveEstudianteCedula(string cedula)
        {
            return @"SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE Cedula like ('" + cedula + "%')";
        }
        public static string DevuelveEstudianteCedulaSistemas(string cedula)
        {
            return @"SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE id_carrera = 1

 AND Cedula like ('" + cedula + "%')";
        }
        public static string DevuelveEstudianteCedulaElectronica(string cedula)
        {
            return @"SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE id_carrera = 3

 AND Cedula like ('" + cedula + "%')";
        }
        public static string DevuelveEstudianteCedulaIndustrial(string cedula)
        {
            return @"SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE id_carrera = 4

 AND Cedula like ('" + cedula + "%')";
        }

        public static string DevuelvePeriodoEstudiante(string cedula)
        {
            return @"SELECT        dbo.PeriodoAcademico.periodo
FROM            dbo.Estudiante INNER JOIN
                         dbo.Inscripcion ON dbo.Estudiante.id = dbo.Inscripcion.id_estudiante INNER JOIN
                         dbo.Matricula ON dbo.Inscripcion.id_matricula = dbo.Matricula.id INNER JOIN
                         dbo.PeriodoAcademico ON dbo.Matricula.id_periodo = dbo.PeriodoAcademico.id
WHERE dbo.Estudiante.cedula = '" + cedula + "'";
        }


        public static string DevuelveEstudiante()
        {
            return @"SELECT      dbo.Estudiante.cedula, ( dbo.Estudiante.nombre+' '+ dbo.Estudiante.apellido) AS Estudiante,   dbo.Carrera.nombre AS Carrera
FROM dbo.Estudiante INNER JOIN
                         dbo.Carrera ON dbo.Estudiante.id_carrera = dbo.Carrera.id";
        }
        public static string Devuelvepresidenta()
        {
            return "SELECT  (apellido+' '+nombre) As Presidenta  FROM            dbo.Docente INNER JOIN  dbo.Cargo ON dbo.Docente.id_cargo = dbo.Cargo.id WHERE dbo.Cargo.nombre = 'Presidenta de Consejo Directivo'";
        }

        public static string DevuelveEstudianteApellido(String apellido)
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE Estudiante like ('" + apellido + "%')";
        }
        public static string DevuelveEstudianteCarreraSistemas()
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE id_carrera =1";
        }
        public static string DevuelveEstudianteCarreraElectronica()
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE id_carrera =3";
        }
        public static string DevuelveEstudianteCarreraIndustrial()
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Estudiante  FROM            Estudiante WHERE id_carrera =4";
        }


        public static string obtenerFecha()
        {
            using (SqlConnection connection = new SqlConnection(Settings1.Default.cadena))
            {
                string val = "";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = (@"SELECT CONVERT(VARCHAR(100), GETDATE(), 103);");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0] != DBNull.Value)
                    {
                        val = dr[0].ToString();
                    }
                }
                connection.Close();
                return val;
            }
        }

        public static string obtenerultimodocAcademico()
        {
            using (SqlConnection connection = new SqlConnection(Settings1.Default.cadena))
            {
                string val = "";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = (@"SELECT id FROM DocAcademico WHERE id=(SELECT MAX(id) FROM DocAcademico)").ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0] != DBNull.Value)
                    {
                        val = dr[0].ToString();
                    }
                }
                connection.Close();
                return val;
            }
        }
        public static string obtenerultimodocTitulacion()
        {
            using (SqlConnection connection = new SqlConnection(Settings1.Default.cadena))
            {
                string val = "";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = (@"SELECT id FROM DocTitulacion WHERE id=(SELECT MAX(id) FROM DocTitulacion)").ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0] != DBNull.Value)
                    {
                        val = dr[0].ToString();
                    }
                }
                connection.Close();
                return val;
            }
        }
    }
}
