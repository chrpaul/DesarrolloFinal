using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public static class ModalidadNegocio
    {
        public static DataSet DevolverMOdalidad()
        {
            return CargarDatos.CargarListaDatos(ModalidadDatos.DevuelveModalidad());
        }
        public static DataSet DevolverPeriodo()
        {
            return CargarDatos.CargarListaDatos(ModalidadDatos.DevuelvePeriodo());
        }
        public static DataSet DevolverFacultad()
        {
            return CargarDatos.CargarListaDatos(ModalidadDatos.DevuelveFacultad());
        }
    }
}
