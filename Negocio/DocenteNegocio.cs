using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
   public static class DocenteNegocio
    {
        public static DataSet DevolverDocenteCedula(string id)
        {
            return CargarDatos.CargarListaDatos(DocenteDatos.DevuelveDocenteCedula(id));
        }
        public static DataSet DevolverDocente()
        {
            return CargarDatos.CargarListaDatos(DocenteDatos.DevuelveDocente());
        }
        public static DataSet DevolverListDocenteApellido(string apellido)
        {
            return CargarDatos.CargarListaDatos(DocenteDatos.DevuelveDocenteApellido(apellido));
        }

    }
}
