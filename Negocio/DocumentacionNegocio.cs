using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public static  class DocumentacionNegocio
    {
        public static string GuardarDocAcademico(Documentacion doc)
        {
            string emp = DocumentacionDatos.GuardarDocuemntacionAcademico(doc);
            return emp;
        }
        public static string GuardarDocTitulacion(Documentacion doc)
        {
            string emp = DocumentacionDatos.GuardarDocuemntacionTitulacion(doc);
            return emp;
        }
    }
}
