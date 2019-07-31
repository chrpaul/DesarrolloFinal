using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class EstudianteE
    {
        public EstudianteE()
        {

        }

        public int Id { get; set; }
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public string Carrera { get; set; }

    }
}

