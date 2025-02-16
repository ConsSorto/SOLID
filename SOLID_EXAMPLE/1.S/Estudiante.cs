using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._1.S
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public string Identidad { get; set; }

        public Estudiante()
        {

        }
    }
}
