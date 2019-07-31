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
    public static class AsignaturasNegocio
    {
        public static DataSet DevolverAsignaturas(string carrera)
        {
            return CargarDatos.CargarListaDatos(AsignaturaDatos.DevuelveAsignaturaCarrera(carrera));
        }
        public static DataSet DevolverNivel(string asignatura)
        {
            return CargarDatos.CargarListaDatos(AsignaturaDatos.DevuelveNivelAsignatura(asignatura));
        }
        public static DataSet DevolverCarreraCedula(string cedula)
        {
            return CargarDatos.CargarListaDatos(AsignaturaDatos.obtenerCarreraEs(cedula));
        }
        public static DataSet DevolverCarrera()
        {
            return CargarDatos.CargarListaDatos(AsignaturaDatos.DevuelveaCarrera());
        }
        public static string DevolveCarreraEstudiante(string ced)
        {
            return AsignaturaDatos.obtenerCarreraEs(ced);
        }

    }
}
