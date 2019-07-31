using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public static class DocenteDatos
    {
        public static string DevuelveDocenteCedula(string cedula)
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Docente  FROM            Docente WHERE   Cedula like ('" + cedula + "%')";
        }
        public static string DevuelveDocente()
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Docente  FROM            Docente";
        }
        public static string Devuelvepresidenta()
        {
            return "SELECT  (apellido+' '+nombre) As Presidenta  FROM            dbo.Docente INNER JOIN  dbo.Cargo ON dbo.Docente.id_cargo = dbo.Cargo.id WHERE dbo.Cargo.nombre = 'Presidenta de Consejo Directivo'";
        }

        public static string DevuelveDocenteApellido(String apellido)
        {
            return "SELECT  cedula,(apellido+' '+nombre) As Docente  FROM            Docente WHERE Docente like ('" + apellido + "%')";
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

        public static string obtenerultimodoc()
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
    }
}
