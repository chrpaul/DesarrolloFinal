using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public static class EstudianteNegocio
    {

        public static DataSet DevolverEstudiante()
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudiante());
        }
        public static DataSet DevolverPeriodo(string cedula )
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelvePeriodoEstudiante(cedula));
        }
        public static DataSet DevolverEstudianteCedula(string id)
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCedula(id));
        }
        public static DataSet DevolverEstudianteCedulaSistemas(string id)
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCedulaSistemas(id));
        }
        public static DataSet DevolverEstudianteCedulaElectronica(string id)
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCedulaElectronica(id));
        }
        public static DataSet DevolverEstudianteCedulaIndustrial(string id)
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCedulaIndustrial(id));

        }

        public static DataSet DevolverListEstudianteApellido(string apellido)
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteApellido(apellido));
        }
        public static DataSet DevolverListEstudianteCarreraSistemas()
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCarreraSistemas());
        }
        public static DataSet DevolverListEstudianteCarreraElectronica()
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCarreraElectronica());
        }
        public static DataSet DevolverListEstudianteCarreraIndustrial()
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.DevuelveEstudianteCarreraIndustrial());
        }

        public static string obtenerFecha()
        {
            return EstudianteDatos.obtenerFecha();
        }
       
        public static DataSet DevolverListPresidenta()
        {
            return CargarDatos.CargarListaDatos(EstudianteDatos.Devuelvepresidenta());
        }
        public static string obtenerultimodocAcademico()
        {
            return EstudianteDatos.obtenerultimodocAcademico();
        }
        public static string obtenerultimodocTitulacion()
        {
            return EstudianteDatos.obtenerultimodocTitulacion();
        }
    }
}
