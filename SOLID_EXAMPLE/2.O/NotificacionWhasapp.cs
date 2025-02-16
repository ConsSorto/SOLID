using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_EXAMPLE._2.O
{
    public class NotificacionWhasapp : Notificaciones, INotificaciones
    {
        public string Token { get; set; }
        void INotificaciones.Enviar(Estudiante estudiante, string Texto)
        {
            //Enviar notificacion por la api de whatsapp
        }
    }
}
