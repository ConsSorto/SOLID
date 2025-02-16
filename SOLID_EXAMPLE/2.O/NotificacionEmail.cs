using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._2.O
{
    public class NotificacionEmail : Notificaciones, INotificaciones
    {
        public string Server { get; set; }
        public string Password { get; set; }
        public string Asunto { get; set; }

        void INotificaciones.Enviar(Estudiante estudiante, string Texto)
        {
            // codigo para enviar un correo
        }
    }
}
