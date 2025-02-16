using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._1.S
{
    public class Notificaciones
    {
        public string Fecha { get; set; }

        public string Server { get; set; }
        public string Sender { get; set; }
        public string Asunto { get; set; }
        public string CC { get; set; }

        public Notificaciones()
        {

        }

        public void Enviar(Estudiante estudiante, string Texto)
        {
            //codigo para enviar estudiante.email, texto 
        }
        
        
    }
}
