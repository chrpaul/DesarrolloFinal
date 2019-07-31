using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
   public static  class DocumentacionDatos
    {
        public static string GuardarDocuemntacionAcademico(Documentacion doc)
        {

            using (SqlConnection connection = new SqlConnection(Settings1.Default.cadena))
            {
                connection.Open();
                string queryString = "INSERT INTO [dbo].[DocAcademico]([cod_acuerdo],[fecha])" +
                                     "VALUES (@cod_acuerdo,@Fecha); SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@cod_acuerdo", doc.cod_acuerdo);
                cmd.Parameters.AddWithValue("@Fecha", doc.Fecha);
                var IdPersonaTest = cmd.ExecuteScalar();
                connection.Close();
                return IdPersonaTest.ToString();
            }

        }
        public static string GuardarDocuemntacionTitulacion(Documentacion doc)
        {

            using (SqlConnection connection = new SqlConnection(Settings1.Default.cadena))
            {
                connection.Open();
                string queryString = "INSERT INTO [dbo].[DocTitulacion]([cod_acuerdo],[fecha])" +
                                     "VALUES (@cod_acuerdo,@Fecha); SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                cmd.Parameters.AddWithValue("@cod_acuerdo", doc.cod_acuerdo);
                cmd.Parameters.AddWithValue("@Fecha", doc.Fecha);
                var IdPersonaTest = cmd.ExecuteScalar();
                connection.Close();
                return IdPersonaTest.ToString();
            }

        }
    }
}
